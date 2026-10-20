Imports MySql.Data.MySqlClient

Public Class ProductForm
    Private Sub ProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MainDashboard.CurrentRole <> "Administrator" AndAlso MainDashboard.CurrentRole <> "Owner" Then
            btnAdd.Visible = False
            btnEdit.Visible = False
            btnDelete.Visible = False
            btnClear.Visible = False
            txtProductName.ReadOnly = True
            txtCategory.ReadOnly = True
            txtPrice.ReadOnly = True
            txtQuantity.ReadOnly = True
            ' Check for low stock and show notification if needed
            Dim hasLowStock As Boolean = False
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM Products WHERE Quantity <= 10"
                Using cmd As New MySqlCommand(query, conn)
                    Dim count = Convert.ToInt32(cmd.ExecuteScalar())
                    hasLowStock = (count > 0)
                End Using
            End Using
            lblLowStockAlert.Visible = hasLowStock
        Else
            lblLowStockAlert.Visible = False
        End If
        LoadProducts()
    End Sub

    Private Sub LoadProducts()
        dgvProducts.Rows.Clear()
        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()
                Dim query As String = "SELECT * FROM Products"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            dgvProducts.Rows.Add(reader("ProductID"), reader("ProductName"), reader("Category"), reader("Price"), reader("Quantity"))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        End Try
    End Sub

    Private Function IsNumbersOnly(input As String) As Boolean
        Return input.All(Function(c) Char.IsDigit(c))
    End Function

    Private Function IsValidName(input As String) As Boolean
        Return Not IsNumbersOnly(input) AndAlso input.Length > 0
    End Function

    Private Function IsValidPrice(priceText As String) As Boolean
        Dim price As Decimal
        If Decimal.TryParse(priceText, price) Then
            Return price >= 0.01 AndAlso price <= 1000000
        End If
        Return False
    End Function

    Private Function IsValidCategory(input As String) As Boolean
        Return Not IsNumbersOnly(input) AndAlso input.Length > 0
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtProductName.Text = "" Or txtCategory.Text = "" Or txtPrice.Text = "" Or txtQuantity.Text = "" Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If
        ' Check for duplicate product name
        Dim exists As Boolean = False
        Using conn As MySqlConnection = DBConnection.GetConnection()
            conn.Open()
            Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM Products WHERE LOWER(ProductName) = LOWER(@name)", conn)
            checkCmd.Parameters.AddWithValue("@name", txtProductName.Text)
            Dim count = Convert.ToInt32(checkCmd.ExecuteScalar())
            If count > 0 Then
                exists = True
            End If
        End Using
        If exists Then
            MessageBox.Show("A product with this name already exists.")
            Return
        End If
        Dim price As Decimal
        Dim quantity As Integer
        If Not Decimal.TryParse(txtPrice.Text, price) Or price <= 0 Then
            MessageBox.Show("Please enter a valid positive price.")
            Return
        End If
        If Not Integer.TryParse(txtQuantity.Text, quantity) Or quantity < 0 Then
            MessageBox.Show("Please enter a valid non-negative quantity.")
            Return
        End If
        If Not IsValidName(txtProductName.Text) Then
            MessageBox.Show("Product name cannot be numbers only and cannot be empty.")
            Return
        End If
        If Not IsValidCategory(txtCategory.Text) Then
            MessageBox.Show("Product category cannot be numbers only and cannot be empty.")
            Return
        End If
        If Not IsValidPrice(txtPrice.Text) Then
            MessageBox.Show("Price must be between 0.01 and 1,000,000.")
            Return
        End If
        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()
                Dim query As String = "INSERT INTO Products (ProductName, Category, Price, Quantity) VALUES (@name, @cat, @price, @qty)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", txtProductName.Text)
                    cmd.Parameters.AddWithValue("@cat", txtCategory.Text)
                    cmd.Parameters.AddWithValue("@price", price)
                    cmd.Parameters.AddWithValue("@qty", quantity)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Product added successfully.")
            ClearFields()
            LoadProducts()
        Catch ex As Exception
            MessageBox.Show("Error adding product: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvProducts.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a product to edit.")
            Return
        End If
        Dim price As Decimal
        Dim quantity As Integer
        If Not Decimal.TryParse(txtPrice.Text, price) Or price <= 0 Then
            MessageBox.Show("Please enter a valid positive price.")
            Return
        End If
        If Not Integer.TryParse(txtQuantity.Text, quantity) Or quantity < 0 Then
            MessageBox.Show("Please enter a valid non-negative quantity.")
            Return
        End If
        Dim productId As Integer = dgvProducts.SelectedRows(0).Cells(0).Value
        If Not IsValidName(txtProductName.Text) Then
            MessageBox.Show("Product name cannot be numbers only and cannot be empty.")
            Return
        End If
        If Not IsValidCategory(txtCategory.Text) Then
            MessageBox.Show("Product category cannot be numbers only and cannot be empty.")
            Return
        End If
        If Not IsValidPrice(txtPrice.Text) Then
            MessageBox.Show("Price must be between 0.01 and 1,000,000.")
            Return
        End If
        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()
                Dim query As String = "UPDATE Products SET ProductName=@name, Category=@cat, Price=@price, Quantity=@qty WHERE ProductID=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", txtProductName.Text)
                    cmd.Parameters.AddWithValue("@cat", txtCategory.Text)
                    cmd.Parameters.AddWithValue("@price", price)
                    cmd.Parameters.AddWithValue("@qty", quantity)
                    cmd.Parameters.AddWithValue("@id", productId)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Product updated successfully.")
            ClearFields()
            LoadProducts()
        Catch ex As Exception
            MessageBox.Show("Error updating product: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvProducts.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a product to delete.")
            Return
        End If
        Dim productId As Integer = dgvProducts.SelectedRows(0).Cells(0).Value
        If MessageBox.Show("Are you sure you want to delete this product?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                Using conn As MySqlConnection = DBConnection.GetConnection()
                    conn.Open()
                    Dim query As String = "DELETE FROM Products WHERE ProductID=@id"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@id", productId)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Product deleted successfully.")
                ClearFields()
                LoadProducts()
            Catch ex As Exception
                MessageBox.Show("Error deleting product: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub dgvProducts_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProducts.SelectionChanged
        If dgvProducts.SelectedRows.Count > 0 Then
            Dim row = dgvProducts.SelectedRows(0)
            ' Prevent error when selecting the new row (asterisk row)
            If Not row.IsNewRow AndAlso row.Cells(0).Value IsNot Nothing Then
                txtProductName.Text = row.Cells(1).Value.ToString()
                txtCategory.Text = row.Cells(2).Value.ToString()
                txtPrice.Text = row.Cells(3).Value.ToString()
                txtQuantity.Text = row.Cells(4).Value.ToString()
                txtQuantity.ReadOnly = True ' Make quantity read-only for existing products
            Else
                ClearFields()
            End If
        End If
    End Sub

    Private Sub ClearFields()
        txtProductName.Text = ""
        txtCategory.Text = ""
        txtPrice.Text = ""
        txtQuantity.Text = ""
        txtQuantity.ReadOnly = False ' Allow editing quantity when adding new product
        dgvProducts.ClearSelection()
    End Sub

    ' Add Back button handler
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnProductSearch_Click(sender As Object, e As EventArgs) Handles btnProductSearch.Click
        Dim searchText As String = txtSearchProduct.Text.Trim().ToLower()
        dgvProducts.Rows.Clear()
        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()
                Dim query As String = "SELECT * FROM Products WHERE " &
                    "LOWER(ProductName) LIKE @search OR " &
                    "LOWER(Category) LIKE @search OR " &
                    "CAST(Price AS CHAR) LIKE @search OR " &
                    "CAST(Quantity AS CHAR) LIKE @search"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@search", "%" & searchText & "%")
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            dgvProducts.Rows.Add(reader("ProductID"), reader("ProductName"), reader("Category"), reader("Price"), reader("Quantity"))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching products: " & ex.Message)
        End Try
    End Sub

    Private Sub txtSearchProduct_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProduct.TextChanged
        If txtSearchProduct.Text.Trim() = "" Then
            LoadProducts()
        End If
    End Sub

    Private Sub lblLowStockAlert_Click(sender As Object, e As EventArgs) Handles lblLowStockAlert.Click
        Using lowStockForm As New LowStockForm()
            lowStockForm.ShowDialog()
        End Using
        ProductForm_Load(Nothing, Nothing)
    End Sub
End Class