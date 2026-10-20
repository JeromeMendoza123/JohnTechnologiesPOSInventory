Imports MySql.Data.MySqlClient

Public Class LowStockForm
    Private Sub LowStockForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLowStockProducts()
    End Sub

    Private Sub LoadLowStockProducts()
        dgvLowStock.Rows.Clear()
        dgvLowStock.Columns.Clear()
        dgvLowStock.Columns.Add("ProductID", "Product ID")
        dgvLowStock.Columns.Add("ProductName", "Product Name")
        dgvLowStock.Columns.Add("Category", "Category")
        dgvLowStock.Columns.Add("Price", "Price")
        dgvLowStock.Columns.Add("Quantity", "Quantity")
        ' Add Stock In button column
        Dim btnCol As New DataGridViewButtonColumn()
        btnCol.Name = "StockIn"
        btnCol.HeaderText = "Stock In"
        btnCol.Text = "Stock In"
        btnCol.UseColumnTextForButtonValue = True
        dgvLowStock.Columns.Add(btnCol)
        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()
                Dim query As String = "SELECT * FROM Products WHERE Quantity <= 10 ORDER BY Quantity ASC"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            dgvLowStock.Rows.Add(reader("ProductID"), reader("ProductName"), reader("Category"), reader("Price"), reader("Quantity"))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading low stock products: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvLowStock_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLowStock.CellContentClick
        If e.ColumnIndex = dgvLowStock.Columns("StockIn").Index AndAlso e.RowIndex >= 0 Then
            Dim productId = dgvLowStock.Rows(e.RowIndex).Cells("ProductID").Value
            Dim productName = dgvLowStock.Rows(e.RowIndex).Cells("ProductName").Value.ToString()
            Dim promptQty = $"Enter quantity to stock in for {productName}:"
            Dim inputQty = InputBox(promptQty, "Stock In", "")
            Dim qtyToAdd As Integer
            If Integer.TryParse(inputQty, qtyToAdd) AndAlso qtyToAdd > 0 Then
                Dim promptAmt = $"Enter investment amount for {qtyToAdd} units of {productName}:"
                Dim inputAmt = InputBox(promptAmt, "Investment Amount", "")
                Dim investmentAmount As Decimal
                If Decimal.TryParse(inputAmt, investmentAmount) AndAlso investmentAmount > 0 Then
                    Dim investorPrompt = "Enter investor name (leave blank for 'Investor'):"
                    Dim investorName = InputBox(investorPrompt, "Investor Name", "Investor")
                    If String.IsNullOrWhiteSpace(investorName) Then investorName = "Investor"
                    Try
                        Using conn As MySqlConnection = DBConnection.GetConnection()
                            conn.Open()
                            ' Update product quantity
                            Dim updateQuery As String = "UPDATE Products SET Quantity = Quantity + @qty WHERE ProductID = @id"
                            Using updateCmd As New MySqlCommand(updateQuery, conn)
                                updateCmd.Parameters.AddWithValue("@qty", qtyToAdd)
                                updateCmd.Parameters.AddWithValue("@id", productId)
                                updateCmd.ExecuteNonQuery()
                            End Using
                            ' Log stock in transaction
                            Dim logQuery As String = "INSERT INTO StockTransactions (ProductID, UserID, Type, Quantity, Date) VALUES (@pid, @uid, 'IN', @qty, @date)"
                            Using logCmd As New MySqlCommand(logQuery, conn)
                                logCmd.Parameters.AddWithValue("@pid", productId)
                                logCmd.Parameters.AddWithValue("@uid", MainDashboard.CurrentUserID)
                                logCmd.Parameters.AddWithValue("@qty", qtyToAdd)
                                logCmd.Parameters.AddWithValue("@date", DateTime.Now)
                                logCmd.ExecuteNonQuery()
                            End Using
                            ' Log expense for stock-in
                            Dim expenseQuery As String = "INSERT INTO Expenses (Date, Amount, Description, Category) VALUES (@date, @amount, @desc, @cat)"
                            Using expenseCmd As New MySqlCommand(expenseQuery, conn)
                                expenseCmd.Parameters.AddWithValue("@date", DateTime.Now)
                                expenseCmd.Parameters.AddWithValue("@amount", investmentAmount)
                                expenseCmd.Parameters.AddWithValue("@desc", $"Stock-In investment for {productName}")
                                expenseCmd.Parameters.AddWithValue("@cat", "Inventory")
                                expenseCmd.ExecuteNonQuery()
                            End Using
                            ' Log payment sent for stock-in
                            Dim paymentQuery As String = "INSERT INTO Payments (Date, Amount, Type, Sender, Receiver) VALUES (@date, @amount, @type, @sender, @receiver)"
                            Using paymentCmd As New MySqlCommand(paymentQuery, conn)
                                paymentCmd.Parameters.AddWithValue("@date", DateTime.Now)
                                paymentCmd.Parameters.AddWithValue("@amount", investmentAmount)
                                paymentCmd.Parameters.AddWithValue("@type", "Sent")
                                paymentCmd.Parameters.AddWithValue("@sender", MainDashboard.CurrentUsername)
                                paymentCmd.Parameters.AddWithValue("@receiver", investorName)
                                paymentCmd.ExecuteNonQuery()
                            End Using
                        End Using
                        MessageBox.Show($"Stock in successful for {productName}.")
                        LoadLowStockProducts()
                        If dgvLowStock.Rows.Count = 0 Then
                            MessageBox.Show("No more low stock items.")
                            Me.Close()
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error stocking in: " & ex.Message)
                    End Try
                Else
                    MessageBox.Show("Please enter a valid positive investment amount.")
                End If
            Else
                MessageBox.Show("Please enter a valid positive quantity.")
            End If
        End If
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        LoadLowStockProducts()
    End Sub
End Class