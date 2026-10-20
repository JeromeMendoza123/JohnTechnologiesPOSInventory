<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReceiptForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblAssistedBy = New System.Windows.Forms.Label()
        Me.lblPaymentMethod = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.btnDownloadPDF = New System.Windows.Forms.Button()
        Me.lvProducts = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblPaymentAmount = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(158, 38)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(393, 28)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "John Technologies and Construction Inc."
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(191, 148)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(79, 20)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date Here"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(191, 191)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(79, 20)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "Time here"
        '
        'lblAssistedBy
        '
        Me.lblAssistedBy.AutoSize = True
        Me.lblAssistedBy.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssistedBy.Location = New System.Drawing.Point(191, 241)
        Me.lblAssistedBy.Name = "lblAssistedBy"
        Me.lblAssistedBy.Size = New System.Drawing.Size(125, 20)
        Me.lblAssistedBy.TabIndex = 3
        Me.lblAssistedBy.Text = "Assisted By here"
        '
        'lblPaymentMethod
        '
        Me.lblPaymentMethod.AutoSize = True
        Me.lblPaymentMethod.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentMethod.Location = New System.Drawing.Point(191, 287)
        Me.lblPaymentMethod.Name = "lblPaymentMethod"
        Me.lblPaymentMethod.Size = New System.Drawing.Size(128, 20)
        Me.lblPaymentMethod.TabIndex = 4
        Me.lblPaymentMethod.Text = "Pay method here"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(94, 543)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(77, 20)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "Total here"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(547, 541)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(96, 20)
        Me.lblChange.TabIndex = 7
        Me.lblChange.Text = "Change here"
        '
        'btnDownloadPDF
        '
        Me.btnDownloadPDF.Location = New System.Drawing.Point(503, 737)
        Me.btnDownloadPDF.Name = "btnDownloadPDF"
        Me.btnDownloadPDF.Size = New System.Drawing.Size(173, 38)
        Me.btnDownloadPDF.TabIndex = 8
        Me.btnDownloadPDF.Text = "Download PDF"
        Me.btnDownloadPDF.UseVisualStyleBackColor = True
        '
        'lvProducts
        '
        Me.lvProducts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvProducts.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvProducts.HideSelection = False
        Me.lvProducts.Location = New System.Drawing.Point(47, 340)
        Me.lvProducts.Name = "lvProducts"
        Me.lvProducts.Size = New System.Drawing.Size(578, 166)
        Me.lvProducts.TabIndex = 9
        Me.lvProducts.UseCompatibleStateImageBehavior = False
        Me.lvProducts.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Product Name"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Price"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Quantity"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Subtotal"
        Me.ColumnHeader4.Width = 150
        '
        'lblPaymentAmount
        '
        Me.lblPaymentAmount.AutoSize = True
        Me.lblPaymentAmount.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentAmount.Location = New System.Drawing.Point(344, 541)
        Me.lblPaymentAmount.Name = "lblPaymentAmount"
        Me.lblPaymentAmount.Size = New System.Drawing.Size(104, 20)
        Me.lblPaymentAmount.TabIndex = 10
        Me.lblPaymentAmount.Text = "Payment here"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(76, 28)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Time:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Assisted By:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Payment Method:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 543)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Total:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(205, 541)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Payment Amount"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(486, 541)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 20)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Change:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(47, 593)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(607, 10)
        Me.Panel1.TabIndex = 19
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(35, 85)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(619, 10)
        Me.Panel2.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(33, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(301, 20)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Address: Buendia Tunsan Muntinlupa City"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(85, 623)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(523, 23)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Thank you for choosing John Technologies and Construction Inc."
        '
        'ReceiptForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 787)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblPaymentAmount)
        Me.Controls.Add(Me.lvProducts)
        Me.Controls.Add(Me.btnDownloadPDF)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblPaymentMethod)
        Me.Controls.Add(Me.lblAssistedBy)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "ReceiptForm"
        Me.Text = "ReceiptForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblAssistedBy As Label
    Friend WithEvents lblPaymentMethod As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents btnDownloadPDF As Button
    Friend WithEvents lvProducts As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents lblPaymentAmount As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
