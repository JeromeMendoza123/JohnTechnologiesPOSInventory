Imports MySql.Data.MySqlClient

Public Class StockTransactions
    Private Sub StockTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
        cmbType.Items.Clear()
        cmbType.Items.Add("IN")
        cmbType.Items.Add("OUT")
        lblPurchaseAmount.Visible = False
        txtPurchaseAmount.Visible = False
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        If cmbType.SelectedItem IsNot Nothing AndAlso cmbType.SelectedItem.ToString() = "IN" Then
            lblPurchaseAmount.Visible = True
            txtPurchaseAmount.Visible = True
        Else
            lblPurchaseAmount.Visible = False
            txtPurchaseAmount.Visible = False
        End If
    End Sub

    Private Sub LoadProducts()
        cmbProduct.Items.Clear()
        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()
                Dim query As String = "SELECT ProductID, ProductName FROM Products"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            cmbProduct.Items.Add(New ComboBoxItem(reader("ProductName").ToString(), reader("ProductID")))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbProduct.SelectedIndex = -1 Or txtQuantity.Text = "" Or cmbType.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If
        Dim quantity As Integer
        If Not Integer.TryParse(txtQuantity.Text, quantity) Or quantity <= 0 Then
            MessageBox.Show("Please enter a valid positive quantity.")
            Return
        End If
        Dim selectedProduct As ComboBoxItem = CType(cmbProduct.SelectedItem, ComboBoxItem)
        Dim productId As Integer = selectedProduct.Value
        Dim type As String = cmbType.SelectedItem.ToString()
        Dim userId As Integer = GetCurrentUserId()
        If userId = 0 Then
            MessageBox.Show("Error: The current user does not exist in the Users table. Please check your login and user setup.")
            Return
        End If
        ' Prevent stock-out if quantity is insufficient
        If type = "OUT" Then
            Dim currentQty As Integer = 0
            Try
                Using conn As MySqlConnection = DBConnection.GetConnection()
                    conn.Open()
                    Dim checkQuery As String = "SELECT Quantity FROM Products WHERE ProductID = @pid"
                    Using checkCmd As New MySqlCommand(checkQuery, conn)
                        checkCmd.Parameters.AddWithValue("@pid", productId)
                        Dim result = checkCmd.ExecuteScalar()
                        If result IsNot Nothing Then
                            currentQty = Convert.ToInt32(result)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error checking product quantity: " & ex.Message)
                Return
            End Try
            If quantity > currentQty Then
                MessageBox.Show($"Cannot stock out more than available quantity. Current stock: {currentQty}")
                Return
            End If
        End If
        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()
                Dim query As String = "INSERT INTO StockTransactions (ProductID, UserID, Type, Quantity, Date) VALUES (@pid, @uid, @type, @qty, @date)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@pid", productId)
                    cmd.Parameters.AddWithValue("@uid", userId)
                    cmd.Parameters.AddWithValue("@type", type)
                    cmd.Parameters.AddWithValue("@qty", quantity)
                    cmd.Parameters.AddWithValue("@date", DateTime.Now) ' Save full date and time
                    cmd.ExecuteNonQuery()
                End Using
                ' Update product quantity
                Dim updateQuery As String
                If type = "IN" Then
                    updateQuery = "UPDATE Products SET Quantity = Quantity + @qty WHERE ProductID = @pid"
                Else
                    updateQuery = "UPDATE Products SET Quantity = Quantity - @qty WHERE ProductID = @pid"
                End If
                Using updateCmd As New MySqlCommand(updateQuery, conn)
                    updateCmd.Parameters.AddWithValue("@qty", quantity)
                    updateCmd.Parameters.AddWithValue("@pid", productId)
                    updateCmd.ExecuteNonQuery()
                End Using
                ' Insert expense record for Stock-In
                If type = "IN" Then
                    If txtPurchaseAmount.Text = "" OrElse Not IsNumeric(txtPurchaseAmount.Text) OrElse Convert.ToDecimal(txtPurchaseAmount.Text) <= 0 Then
                        MessageBox.Show("Please enter a valid purchase amount for Stock-In.")
                        Return
                    End If
                    Dim purchaseAmount As Decimal = Convert.ToDecimal(txtPurchaseAmount.Text)
                    Dim expenseQuery As String = "INSERT INTO Expenses (Date, Amount, Description, Category) VALUES (@date, @amount, @desc, @cat)"
                    Using expenseCmd As New MySqlCommand(expenseQuery, conn)
                        expenseCmd.Parameters.AddWithValue("@date", DateTime.Now)
                        expenseCmd.Parameters.AddWithValue("@amount", purchaseAmount)
                        expenseCmd.Parameters.AddWithValue("@desc", $"Stock-In purchase for {selectedProduct.Text}")
                        expenseCmd.Parameters.AddWithValue("@cat", "Inventory")
                        expenseCmd.ExecuteNonQuery()
                    End Using
                End If
            End Using
            MessageBox.Show("Stock transaction recorded successfully.")
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error recording transaction: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub ClearFields()
        cmbProduct.SelectedIndex = -1
        txtQuantity.Text = ""
        cmbType.SelectedIndex = -1
        txtPurchaseAmount.Text = ""
        lblPurchaseAmount.Visible = False
        txtPurchaseAmount.Visible = False
    End Sub

    ' Helper class for ComboBox items
    Private Class ComboBoxItem
        Public Property Text As String
        Public Property Value As Integer
        Public Sub New(text As String, value As Integer)
            Me.Text = text
            Me.Value = value
        End Sub
        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class

    ' Replace this with your actual logic to get the current user's UserID
    Private Function GetCurrentUserId() As Integer
        ' Example: Query the Users table using MainDashboard.CurrentUsername
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
        Return 0 ' Default/fallback
    End Function
End Class
