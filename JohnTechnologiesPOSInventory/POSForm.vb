Imports MySql.Data.MySqlClient

Public Class POSForm
    Private cart As New List(Of CartItem)

    Private Sub POSForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
        UpdateCartGrid()
        lblTotal.Text = "Total: 0.00"
        lblChange.Text = "Change: 0.00"
    End Sub

    Private Sub LoadProducts()
        cmbProduct.Items.Clear()
        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()
                Dim query As String = "SELECT ProductID, ProductName, Price, Quantity FROM Products WHERE Quantity > 0"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim prodId As Integer = Convert.ToInt32(reader("ProductID"))
                            Dim prodName As String = reader("ProductName").ToString()
                            Dim prodPrice As Decimal = Convert.ToDecimal(reader("Price"))
                            Dim prodQty As Integer = Convert.ToInt32(reader("Quantity"))
                            cmbProduct.Items.Add(New ComboBoxItem(prodName, prodId, prodPrice, prodQty))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        If cmbProduct.SelectedIndex = -1 Or txtQuantity.Text = "" Then
            MessageBox.Show("Please select a product and enter quantity.")
            Return
        End If
        Dim selectedProduct As ComboBoxItem = CType(cmbProduct.SelectedItem, ComboBoxItem)
        Dim quantity As Integer
        If Not Integer.TryParse(txtQuantity.Text, quantity) Or quantity <= 0 Then
            MessageBox.Show("Please enter a valid positive quantity.")
            Return
        End If
        If quantity > selectedProduct.AvailableQty Then
            MessageBox.Show("Not enough stock available.")
            Return
        End If
        ' Add to cart
        Dim existing = cart.FirstOrDefault(Function(x) x.ProductID = selectedProduct.Value)
        If existing IsNot Nothing Then
            If existing.Quantity + quantity > selectedProduct.AvailableQty Then
                MessageBox.Show("Not enough stock available for this product.")
                Return
            End If
            existing.Quantity += quantity
        Else
            cart.Add(New CartItem(selectedProduct.Value, selectedProduct.Text, selectedProduct.Price, quantity))
        End If
        UpdateCartGrid()
        UpdateTotal()
        txtQuantity.Text = ""
        cmbProduct.SelectedIndex = -1
    End Sub

    Private Sub UpdateCartGrid()
        dgvCart.Rows.Clear()
        For Each item In cart
            dgvCart.Rows.Add(item.ProductID, item.ProductName, item.Price, item.Quantity, item.Price * item.Quantity)
        Next
    End Sub

    Private Sub UpdateTotal()
        Dim total As Decimal = cart.Sum(Function(x) x.Price * x.Quantity)
        lblTotal.Text = "Total: " & total.ToString("F2")
    End Sub

    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        Dim total As Decimal = cart.Sum(Function(x) x.Price * x.Quantity)
        Dim cash As Decimal
        If Decimal.TryParse(txtCash.Text, cash) Then
            Dim change = cash - total
            lblChange.Text = "Change: " & change.ToString("F2")
        Else
            lblChange.Text = "Change: 0.00"
        End If
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Dim total As Decimal = cart.Sum(Function(x) x.Price * x.Quantity)
        Dim cash As Decimal
        Dim salesId As Integer ' Declare salesId here so it's accessible after Try block
        If cart.Count = 0 Then
            MessageBox.Show("Cart is empty.")
            Return
        End If
        If Not Decimal.TryParse(txtCash.Text, cash) Or cash < total Then
            MessageBox.Show("Insufficient cash.")
            Return
        End If
        Dim userId As Integer = GetCurrentUserId()
        If userId = 0 Then
            MessageBox.Show("Error: The current user does not exist in the Users table.")
            Return
        End If
        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()
                ' Insert into Sales
                Dim salesQuery As String = "INSERT INTO Sales (UserID, Date, TotalAmount) VALUES (@uid, @date, @total)"
                Using salesCmd As New MySqlCommand(salesQuery, conn)
                    salesCmd.Parameters.AddWithValue("@uid", userId)
                    salesCmd.Parameters.AddWithValue("@date", DateTime.Now) ' Save full date and time
                    salesCmd.Parameters.AddWithValue("@total", total)
                    salesCmd.ExecuteNonQuery()
                End Using
                ' Get last inserted SalesID
                Using idCmd As New MySqlCommand("SELECT LAST_INSERT_ID()", conn)
                    salesId = Convert.ToInt32(idCmd.ExecuteScalar())
                End Using
                ' Insert SalesDetails and update product quantity
                For Each item In cart
                    Dim detailQuery As String = "INSERT INTO SalesDetails (SalesID, ProductID, Quantity, Subtotal) VALUES (@sid, @pid, @qty, @sub)"
                    Using detailCmd As New MySqlCommand(detailQuery, conn)
                        detailCmd.Parameters.AddWithValue("@sid", salesId)
                        detailCmd.Parameters.AddWithValue("@pid", item.ProductID)
                        detailCmd.Parameters.AddWithValue("@qty", item.Quantity)
                        detailCmd.Parameters.AddWithValue("@sub", item.Price * item.Quantity)
                        detailCmd.ExecuteNonQuery()
                    End Using
                    ' Update product quantity
                    Dim updateQuery As String = "UPDATE Products SET Quantity = Quantity - @qty WHERE ProductID = @pid"
                    Using updateCmd As New MySqlCommand(updateQuery, conn)
                        updateCmd.Parameters.AddWithValue("@qty", item.Quantity)
                        updateCmd.Parameters.AddWithValue("@pid", item.ProductID)
                        updateCmd.ExecuteNonQuery()
                    End Using
                Next
                ' Insert Payment Received record
                Dim paymentQuery As String = "INSERT INTO Payments (Date, Amount, Type, Sender, Receiver) VALUES (@date, @amount, @type, @sender, @receiver)"
                Using paymentCmd As New MySqlCommand(paymentQuery, conn)
                    paymentCmd.Parameters.AddWithValue("@date", DateTime.Now)
                    paymentCmd.Parameters.AddWithValue("@amount", total)
                    paymentCmd.Parameters.AddWithValue("@type", "Received")
                    paymentCmd.Parameters.AddWithValue("@sender", "Customer")
                    paymentCmd.Parameters.AddWithValue("@receiver", MainDashboard.CurrentUsername)
                    paymentCmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Sale completed! Receipt generated.")
            GenerateReceipt(salesId, total, cash)
            cart.Clear()
            UpdateCartGrid()
            UpdateTotal()
            txtCash.Text = ""
        Catch ex As Exception
            MessageBox.Show("Error processing sale: " & ex.Message)
        End Try
    End Sub

    Private Sub ShowReceiptForm(salesId As Integer, total As Decimal, cash As Decimal)
        ' Prepare product list for receipt
        Dim productList As New List(Of ReceiptForm.ProductItem)
        For Each item In cart
            productList.Add(New ReceiptForm.ProductItem(item.ProductName, item.Price, item.Quantity, item.Price * item.Quantity))
        Next
        ' Prepare other details
        Dim saleDate As DateTime = DateTime.Now.Date
        Dim saleTime As String = DateTime.Now.ToString("HH:mm:ss")
        Dim assistedBy As String = MainDashboard.CurrentUsername
        Dim paymentMethod As String = "Cash" ' You can change this if you support other methods
        Dim paymentAmount As Decimal = cash
        Dim changeAmount As Decimal = cash - total
        ' Show ReceiptForm
        Dim receiptForm As New ReceiptForm(salesId, saleDate, saleTime, assistedBy, paymentMethod, productList, total, paymentAmount, changeAmount)
        receiptForm.ShowDialog()
    End Sub

    ' Update GenerateReceipt to call ShowReceiptForm
    Private Sub GenerateReceipt(salesId As Integer, total As Decimal, cash As Decimal)
        ShowReceiptForm(salesId, total, cash)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnClearSelected_Click(sender As Object, e As EventArgs) Handles btnClearSelected.Click
        If dgvCart.SelectedRows.Count > 0 Then
            Dim productId As Integer = Convert.ToInt32(dgvCart.SelectedRows(0).Cells(0).Value)
            Dim itemToRemove = cart.FirstOrDefault(Function(x) x.ProductID = productId)
            If itemToRemove IsNot Nothing Then
                cart.Remove(itemToRemove)
                UpdateCartGrid()
                UpdateTotal()
                txtCash_TextChanged(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        cart.Clear()
        UpdateCartGrid()
        UpdateTotal()
        txtCash_TextChanged(Nothing, Nothing)
    End Sub

    ' Helper classes
    Private Class ComboBoxItem
        Public Property Text As String
        Public Property Value As Integer
        Public Property Price As Decimal
        Public Property AvailableQty As Integer
        Public Sub New(text As String, value As Integer, price As Decimal, qty As Integer)
            Me.Text = text
            Me.Value = value
            Me.Price = price
            Me.AvailableQty = qty
        End Sub
        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class

    Private Class CartItem
        Public Property ProductID As Integer
        Public Property ProductName As String
        Public Property Price As Decimal
        Public Property Quantity As Integer
        Public Sub New(pid As Integer, pname As String, price As Decimal, qty As Integer)
            ProductID = pid
            ProductName = pname
            Me.Price = price
            Quantity = qty
        End Sub
    End Class

    Private Function GetCurrentUserId() As Integer
        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()
                Dim query As String = "SELECT UserID FROM Users WHERE Username=@username"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", MainDashboard.CurrentUsername)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        Return Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error getting user ID: " & ex.Message)
        End Try
        Return 0
    End Function
End Class