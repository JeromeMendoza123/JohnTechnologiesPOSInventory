Imports MySql.Data.MySqlClient
Imports OfficeOpenXml
Imports System.IO
Imports PdfSharp.Pdf
Imports PdfSharp.Drawing

Public Class ReportsForm
    Private Sub ReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSalesReport()
        LoadInventoryReport()
        LoadStockTransactionsReport()
    End Sub

    Private Sub LoadSalesReport(Optional startDate As DateTime? = Nothing, Optional endDate As DateTime? = Nothing)
        dgvSalesReport.Rows.Clear()
        dgvSalesReport.Columns.Clear()
        dgvSalesReport.Columns.Add("SalesID", "Sales ID")
        dgvSalesReport.Columns.Add("Date", "Date")
        dgvSalesReport.Columns.Add("Cashier", "Cashier")
        dgvSalesReport.Columns.Add("ProductName", "Product Name")
        dgvSalesReport.Columns.Add("TotalAmount", "Total Amount")
        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()
                Dim query As String = "SELECT s.SalesID, s.Date, u.Username AS Cashier, p.ProductName, s.TotalAmount " &
                    "FROM Sales s " &
                    "JOIN Users u ON s.UserID = u.UserID " &
                    "JOIN SalesDetails sd ON s.SalesID = sd.SalesID " &
                    "JOIN Products p ON sd.ProductID = p.ProductID "
                If startDate.HasValue AndAlso endDate.HasValue Then
                    query &= " WHERE s.Date BETWEEN @start AND @end"
                End If
                query &= " ORDER BY s.Date DESC, s.SalesID DESC"
                Using cmd As New MySqlCommand(query, conn)
                    If startDate.HasValue AndAlso endDate.HasValue Then
                        cmd.Parameters.AddWithValue("@start", startDate.Value)
                        cmd.Parameters.AddWithValue("@end", endDate.Value)
                    End If
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            dgvSalesReport.Rows.Add(reader("SalesID"), reader("Date"), reader("Cashier"), reader("ProductName"), reader("TotalAmount"))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading sales report: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadInventoryReport()
        dgvInventoryReport.Rows.Clear()
        dgvInventoryReport.Columns.Clear()
        dgvInventoryReport.Columns.Add("ProductID", "Product ID")
        dgvInventoryReport.Columns.Add("ProductName", "Product Name")
        dgvInventoryReport.Columns.Add("Category", "Category")
        dgvInventoryReport.Columns.Add("Price", "Price")
        dgvInventoryReport.Columns.Add("Quantity", "Quantity")
        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()
                Dim query As String = "SELECT ProductID, ProductName, Category, Price, Quantity FROM Products ORDER BY ProductName"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            dgvInventoryReport.Rows.Add(reader("ProductID"), reader("ProductName"), reader("Category"), reader("Price"), reader("Quantity"))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading inventory report: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadStockTransactionsReport(Optional startDate As DateTime? = Nothing, Optional endDate As DateTime? = Nothing)
        dgvStockTransactionsReport.Rows.Clear()
        dgvStockTransactionsReport.Columns.Clear()
        dgvStockTransactionsReport.Columns.Add("TransactionID", "Transaction ID")
        dgvStockTransactionsReport.Columns.Add("Date", "Date")
        dgvStockTransactionsReport.Columns.Add("ProductName", "Product Name")
        dgvStockTransactionsReport.Columns.Add("Type", "Type")
        dgvStockTransactionsReport.Columns.Add("Quantity", "Quantity")
        dgvStockTransactionsReport.Columns.Add("User", "User")
        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()
                Dim query As String = "SELECT t.TransactionID, t.Date, p.ProductName, t.Type, t.Quantity, u.Username AS User FROM StockTransactions t JOIN Products p ON t.ProductID = p.ProductID JOIN Users u ON t.UserID = u.UserID"
                If startDate.HasValue AndAlso endDate.HasValue Then
                    query &= " WHERE t.Date BETWEEN @start AND @end"
                End If
                query &= " ORDER BY t.Date DESC"
                Using cmd As New MySqlCommand(query, conn)
                    If startDate.HasValue AndAlso endDate.HasValue Then
                        cmd.Parameters.AddWithValue("@start", startDate.Value)
                        cmd.Parameters.AddWithValue("@end", endDate.Value)
                    End If
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            dgvStockTransactionsReport.Rows.Add(reader("TransactionID"), reader("Date"), reader("ProductName"), reader("Type"), reader("Quantity"), reader("User"))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading stock transactions report: " & ex.Message)
        End Try
    End Sub

    Private Sub btnExportSalesExcel_Click(sender As Object, e As EventArgs) Handles btnExportSalesExcel.Click
        OfficeOpenXml.ExcelPackage.License.SetNonCommercialPersonal("Your Name")
        ExportDataGridViewToExcel(dgvSalesReport, "SalesReport.xlsx", "Sales Report")
    End Sub

    Private Sub btnExportInventoryExcel_Click(sender As Object, e As EventArgs) Handles btnExportInventoryExcel.Click
        OfficeOpenXml.ExcelPackage.License.SetNonCommercialPersonal("Your Name")
        ExportDataGridViewToExcel(dgvInventoryReport, "InventoryReport.xlsx", "Inventory Report")
    End Sub

    Private Sub btnExportStockExcel_Click(sender As Object, e As EventArgs) Handles btnExportStockExcel.Click
        OfficeOpenXml.ExcelPackage.License.SetNonCommercialPersonal("Your Name")
        ExportDataGridViewToExcel(dgvStockTransactionsReport, "StockTransactionsReport.xlsx", "Stock-In/Stock-Out Report")
    End Sub

    Private Sub ExportDataGridViewToExcel(dgv As DataGridView, defaultFileName As String, sheetName As String)
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "Excel Files|*.xlsx"
        sfd.Title = $"Export {sheetName} to Excel"
        sfd.FileName = defaultFileName
        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Using package As New ExcelPackage()
                    Dim ws = package.Workbook.Worksheets.Add(sheetName)
                    ' Add headers
                    For col = 0 To dgv.Columns.Count - 1
                        ws.Cells(1, col + 1).Value = dgv.Columns(col).HeaderText
                    Next
                    ' Add rows
                    For row = 0 To dgv.Rows.Count - 1
                        For col = 0 To dgv.Columns.Count - 1
                            Dim cellValue = dgv.Rows(row).Cells(col).Value
                            If dgv.Columns(col).HeaderText.ToLower().Contains("date") AndAlso cellValue IsNot Nothing Then
                                Dim dt As DateTime
                                If DateTime.TryParse(cellValue.ToString(), dt) Then
                                    ws.Cells(row + 2, col + 1).Value = dt.ToString("yyyy-MM-dd HH:mm:ss")
                                    ws.Cells(row + 2, col + 1).Style.Numberformat.Format = "yyyy-mm-dd hh:mm:ss"
                                Else
                                    ws.Cells(row + 2, col + 1).Value = cellValue.ToString()
                                End If
                            Else
                                ws.Cells(row + 2, col + 1).Value = cellValue
                            End If
                        Next
                    Next
                    package.SaveAs(New FileInfo(sfd.FileName))
                End Using
                MessageBox.Show($"{sheetName} exported to Excel successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Error exporting to Excel: {ex.Message}")
            End Try
        End If
    End Sub

    Private Sub btnExportSalesPDF_Click(sender As Object, e As EventArgs) Handles btnExportSalesPDF.Click
        ExportDataGridViewToPDF(dgvSalesReport, "SalesReport.pdf", "Sales Report")
    End Sub

    Private Sub btnExportInventoryPDF_Click(sender As Object, e As EventArgs) Handles btnExportInventoryPDF.Click
        ExportDataGridViewToPDF(dgvInventoryReport, "InventoryReport.pdf", "Inventory Report")
    End Sub

    Private Sub btnExportStockPDF_Click(sender As Object, e As EventArgs) Handles btnExportStockPDF.Click
        ExportDataGridViewToPDF(dgvStockTransactionsReport, "StockTransactionsReport.pdf", "Stock-In/Stock-Out Report")
    End Sub

    Private Sub ExportDataGridViewToPDF(dgv As DataGridView, defaultFileName As String, reportTitle As String)
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "PDF Files|*.pdf"
        sfd.Title = $"Export {reportTitle} to PDF"
        sfd.FileName = defaultFileName
        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Dim doc As New PdfDocument()
                Dim page As PdfPage = doc.AddPage()
                Dim gfx As XGraphics = XGraphics.FromPdfPage(page)
                Dim fontTitle As New XFont("Arial", 14, System.Drawing.FontStyle.Bold)
                Dim fontHeader As New XFont("Arial", 10, System.Drawing.FontStyle.Bold)
                Dim fontCell As New XFont("Arial", 10, System.Drawing.FontStyle.Regular)
                Dim y As Double = 40
                gfx.DrawString(reportTitle, fontTitle, XBrushes.Black, New XRect(0, y, page.Width, 20), XStringFormats.TopCenter)
                y += 30
                ' Custom column widths for each report type
                Dim colWidths As Double()
                Select Case reportTitle
                    Case "Sales Report"
                        colWidths = New Double() {60, 120, 80, 140, 80} ' SalesID, Date, Cashier, ProductName, TotalAmount
                    Case "Inventory Report"
                        colWidths = New Double() {60, 140, 140, 80, 80} ' ProductID, ProductName, Category, Price, Quantity
                    Case "Stock-In/Stock-Out Report"
                        colWidths = New Double() {80, 120, 140, 80, 60, 80} ' TransactionID, Date, ProductName, Type, Quantity, User
                    Case Else
                        colWidths = Enumerable.Repeat(100.0, dgv.Columns.Count).ToArray()
                End Select
                Dim x As Double = 40
                ' Draw headers
                For col = 0 To dgv.Columns.Count - 1
                    gfx.DrawString(dgv.Columns(col).HeaderText, fontHeader, XBrushes.Black, x, y)
                    x += If(col < colWidths.Length, colWidths(col), 100)
                Next
                y += 20
                ' Draw rows
                For row = 0 To dgv.Rows.Count - 1
                    x = 40
                    For col = 0 To dgv.Columns.Count - 1
                        Dim cellValue = dgv.Rows(row).Cells(col).Value
                        If dgv.Columns(col).HeaderText.ToLower().Contains("date") AndAlso cellValue IsNot Nothing Then
                            Dim dt As DateTime
                            If DateTime.TryParse(cellValue.ToString(), dt) Then
                                cellValue = dt.ToString("dd/MM/yyyy hh:mm:ss tt")
                            End If
                        End If
                        gfx.DrawString(cellValue?.ToString(), fontCell, XBrushes.Black, x, y)
                        x += If(col < colWidths.Length, colWidths(col), 100)
                    Next
                    y += 18
                Next
                doc.Save(sfd.FileName)
                MessageBox.Show($"{reportTitle} exported to PDF successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Error exporting to PDF: {ex.Message}")
            End Try
        End If
    End Sub

    Private Sub btnFilterSales_Click(sender As Object, e As EventArgs) Handles btnFilterSales.Click
        ' Use the correct date pickers for Sales Report tab
        Dim startDate = DateTimePicker2.Value.Date
        Dim endDate = DateTimePicker1.Value.Date.AddDays(1).AddSeconds(-1)
        LoadSalesReport(startDate, endDate)
    End Sub

    Private Sub btnFilterStockTransactions_Click(sender As Object, e As EventArgs) Handles btnFilterStockTransactions.Click
        Dim startDate = dtpStartDate.Value.Date
        Dim endDate = dtpEndDate.Value.Date.AddDays(1).AddSeconds(-1)
        LoadStockTransactionsReport(startDate, endDate)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnSalesSearch_Click(sender As Object, e As EventArgs) Handles btnSalesSearch.Click
        Dim searchText As String = txtSalesSearch.Text.Trim()
        dgvSalesReport.Rows.Clear()
        dgvSalesReport.Columns.Clear()
        dgvSalesReport.Columns.Add("SalesID", "Sales ID")
        dgvSalesReport.Columns.Add("Date", "Date")
        dgvSalesReport.Columns.Add("Cashier", "Cashier")
        dgvSalesReport.Columns.Add("ProductName", "Product Name")
        dgvSalesReport.Columns.Add("TotalAmount", "Total Amount")
        Using conn As MySqlConnection = DBConnection.GetConnection()
            conn.Open()
            Dim query As String = "SELECT s.SalesID, s.Date, u.Username AS Cashier, p.ProductName, s.TotalAmount " & _
                "FROM Sales s " & _
                "JOIN Users u ON s.UserID = u.UserID " & _
                "JOIN SalesDetails sd ON s.SalesID = sd.SalesID " & _
                "JOIN Products p ON sd.ProductID = p.ProductID " & _
                "WHERE p.ProductName LIKE @search OR u.Username LIKE @search OR s.Date LIKE @search " & _
                "ORDER BY s.Date DESC, s.SalesID DESC"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@search", "%" & searchText & "%")
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        dgvSalesReport.Rows.Add(reader("SalesID"), reader("Date"), reader("Cashier"), reader("ProductName"), reader("TotalAmount"))
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub txtSalesSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSalesSearch.TextChanged
        If txtSalesSearch.Text.Trim() = "" Then
            btnSalesSearch.PerformClick()
        End If
    End Sub

    Private Sub btnStockSearch_Click(sender As Object, e As EventArgs) Handles btnStockSearch.Click
        Dim searchText As String = txtStockSearch.Text.Trim()
        dgvStockTransactionsReport.Rows.Clear()
        dgvStockTransactionsReport.Columns.Clear()
        dgvStockTransactionsReport.Columns.Add("TransactionID", "Transaction ID")
        dgvStockTransactionsReport.Columns.Add("Date", "Date")
        dgvStockTransactionsReport.Columns.Add("ProductName", "Product Name")
        dgvStockTransactionsReport.Columns.Add("Type", "Type")
        dgvStockTransactionsReport.Columns.Add("Quantity", "Quantity")
        dgvStockTransactionsReport.Columns.Add("User", "User")
        Using conn As MySqlConnection = DBConnection.GetConnection()
            conn.Open()
            Dim query As String = "SELECT t.TransactionID, t.Date, p.ProductName, t.Type, t.Quantity, u.Username AS User " & _
                "FROM StockTransactions t " & _
                "JOIN Products p ON t.ProductID = p.ProductID " & _
                "JOIN Users u ON t.UserID = u.UserID " & _
                "WHERE p.ProductName LIKE @search OR u.Username LIKE @search OR t.Type LIKE @search OR t.Date LIKE @search " & _
                "ORDER BY t.Date DESC"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@search", "%" & searchText & "%")
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        dgvStockTransactionsReport.Rows.Add(reader("TransactionID"), reader("Date"), reader("ProductName"), reader("Type"), reader("Quantity"), reader("User"))
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub txtStockSearch_TextChanged(sender As Object, e As EventArgs) Handles txtStockSearch.TextChanged
        If txtStockSearch.Text.Trim() = "" Then
            btnStockSearch.PerformClick()
        End If
    End Sub
End Class