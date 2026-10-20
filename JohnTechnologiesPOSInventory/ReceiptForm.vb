Imports PdfSharp.Pdf
Imports PdfSharp.Drawing
Imports System.Windows.Forms

Public Class ReceiptForm
    ' Properties to hold receipt data
    Public Property SaleID As Integer
    Public Property SaleDate As DateTime
    Public Property SaleTime As String
    Public Property AssistedBy As String
    Public Property PaymentMethod As String
    Public Property ProductList As List(Of ProductItem)
    Public Property TotalAmount As Decimal
    Public Property PaymentAmount As Decimal
    Public Property ChangeAmount As Decimal

    ' Constructor to receive all data
    Public Sub New(saleID As Integer, saleDate As DateTime, saleTime As String, assistedBy As String, paymentMethod As String, productList As List(Of ProductItem), totalAmount As Decimal, paymentAmount As Decimal, changeAmount As Decimal)
        InitializeComponent()
        Me.SaleID = saleID
        Me.SaleDate = saleDate
        Me.SaleTime = saleTime
        Me.AssistedBy = assistedBy
        Me.PaymentMethod = paymentMethod
        Me.ProductList = productList
        Me.TotalAmount = totalAmount
        Me.PaymentAmount = paymentAmount
        Me.ChangeAmount = changeAmount
    End Sub

    ' Helper class for product items
    Public Class ProductItem
        Public Property ProductName As String
        Public Property Price As Decimal
        Public Property Quantity As Integer
        Public Property Subtotal As Decimal
        Public Sub New(name As String, price As Decimal, qty As Integer, subtotal As Decimal)
            ProductName = name
            Me.Price = price
            Quantity = qty
            Me.Subtotal = subtotal
        End Sub
    End Class

    Private Sub ReceiptForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display static info
        lblDate.Text = SaleDate.ToString("yyyy-MM-dd")
        lblTime.Text = SaleTime
        lblAssistedBy.Text = AssistedBy
        lblPaymentMethod.Text = PaymentMethod
        lblTotal.Text = TotalAmount.ToString("F2")
        lblPaymentAmount.Text = PaymentAmount.ToString("F2")
        lblChange.Text = ChangeAmount.ToString("F2")
        ' Display product list in ListView
        lvProducts.Items.Clear()
        For Each prod In ProductList
            Dim item As New ListViewItem(prod.ProductName)
            item.SubItems.Add(prod.Price.ToString("F2"))
            item.SubItems.Add(prod.Quantity.ToString())
            item.SubItems.Add(prod.Subtotal.ToString("F2"))
            lvProducts.Items.Add(item)
        Next
    End Sub

    Private Sub btnDownloadPDF_Click(sender As Object, e As EventArgs) Handles btnDownloadPDF.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "PDF Files|*.pdf"
        sfd.Title = "Save Receipt as PDF"
        sfd.FileName = $"Receipt_{SaleID}_{SaleDate:yyyyMMdd}.pdf"
        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Dim doc As New PdfDocument()
                doc.Info.Title = "Sales Receipt"
                Dim page As PdfPage = doc.AddPage()
                Dim gfx As XGraphics = XGraphics.FromPdfPage(page)
                Dim fontTitle As New XFont("Arial", 16, System.Drawing.FontStyle.Bold)
                Dim fontLabel As New XFont("Arial", 10, System.Drawing.FontStyle.Bold)
                Dim fontValue As New XFont("Arial", 10, System.Drawing.FontStyle.Regular)
                Dim fontAddress As New XFont("Arial", 10, System.Drawing.FontStyle.Regular)
                Dim fontThankYou As New XFont("Arial", 12, System.Drawing.FontStyle.Bold)
                Dim y As Double = 40
                ' Title
                gfx.DrawString("John Technologies and Construction Inc.", fontTitle, XBrushes.Black, New XRect(0, y, page.Width, 20), XStringFormats.TopCenter)
                y += 25
                ' Line under title
                gfx.DrawLine(XPens.Black, 40, y, page.Width - 40, y)
                y += 10
                ' Address (left-aligned)
                gfx.DrawString("Address: Buendia Tunasan Muntinlupa City", fontAddress, XBrushes.Black, 40, y)
                y += 20
                ' Date, Time (AM/PM), Assisted By
                Dim timeStr As String = DateTime.Parse(SaleTime).ToString("hh:mm:ss tt")
                gfx.DrawString($"Date: {SaleDate:yyyy-MM-dd}", fontLabel, XBrushes.Black, 40, y)
                gfx.DrawString($"Time: {timeStr}", fontLabel, XBrushes.Black, 200, y)
                gfx.DrawString($"Assisted By: {AssistedBy}", fontLabel, XBrushes.Black, 350, y)
                y += 20
                ' Payment Method
                gfx.DrawString($"Payment Method: {PaymentMethod}", fontLabel, XBrushes.Black, 40, y)
                y += 30
                ' Product Table Header
                gfx.DrawString("Product Name", fontLabel, XBrushes.Black, 40, y)
                gfx.DrawString("Price", fontLabel, XBrushes.Black, 200, y)
                gfx.DrawString("Quantity", fontLabel, XBrushes.Black, 300, y)
                gfx.DrawString("Subtotal", fontLabel, XBrushes.Black, 400, y)
                y += 20
                gfx.DrawLine(XPens.Black, 40, y, page.Width - 40, y)
                y += 10
                ' Product Table Rows
                For Each prod In ProductList
                    gfx.DrawString(prod.ProductName, fontValue, XBrushes.Black, 40, y)
                    gfx.DrawString(prod.Price.ToString("F2"), fontValue, XBrushes.Black, 200, y)
                    gfx.DrawString(prod.Quantity.ToString(), fontValue, XBrushes.Black, 300, y)
                    gfx.DrawString(prod.Subtotal.ToString("F2"), fontValue, XBrushes.Black, 400, y)
                    y += 18
                Next
                y += 10
                gfx.DrawLine(XPens.Black, 40, y, page.Width - 40, y)
                y += 20
                ' Payment Info
                gfx.DrawString($"Total: {TotalAmount:F2}", fontLabel, XBrushes.Black, 40, y)
                gfx.DrawString($"Payment Amount: {PaymentAmount:F2}", fontLabel, XBrushes.Black, 200, y)
                gfx.DrawString($"Change: {ChangeAmount:F2}", fontLabel, XBrushes.Black, 400, y)
                y += 20
                ' Line under totals
                gfx.DrawLine(XPens.Black, 40, y, page.Width - 40, y)
                y += 30
                ' Thank you message
                gfx.DrawString("Thank you for choosing John Technologies and Construction Inc.", fontThankYou, XBrushes.Black, New XRect(0, y, page.Width, 20), XStringFormats.TopCenter)
                ' Save PDF
                doc.Save(sfd.FileName)
                MessageBox.Show("Receipt saved as PDF!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error saving PDF: " & ex.Message)
            End Try
        End If
    End Sub

    ' Back button logic
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class