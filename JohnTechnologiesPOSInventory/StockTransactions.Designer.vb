<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StockTransactions
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
        Me.cmbProduct = New System.Windows.Forms.ComboBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPurchaseAmount = New System.Windows.Forms.Label()
        Me.txtPurchaseAmount = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbProduct
        '
        Me.cmbProduct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbProduct.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold)
        Me.cmbProduct.FormattingEnabled = True
        Me.cmbProduct.Location = New System.Drawing.Point(350, 127)
        Me.cmbProduct.Name = "cmbProduct"
        Me.cmbProduct.Size = New System.Drawing.Size(499, 53)
        Me.cmbProduct.TabIndex = 0
        '
        'cmbType
        '
        Me.cmbType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbType.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold)
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"IN", "OUT"})
        Me.cmbType.Location = New System.Drawing.Point(1310, 140)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(525, 53)
        Me.cmbType.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Transaction Type"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 45)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Product"
        '
        'txtQuantity
        '
        Me.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold)
        Me.txtQuantity.Location = New System.Drawing.Point(350, 331)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(225, 52)
        Me.txtQuantity.TabIndex = 4
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(810, 772)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(298, 115)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.IndianRed
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(18, 16)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(196, 100)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 45)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Quantity:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(209, 109)
        Me.Panel1.TabIndex = 8
        '
        'lblPurchaseAmount
        '
        Me.lblPurchaseAmount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPurchaseAmount.AutoSize = True
        Me.lblPurchaseAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblPurchaseAmount.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurchaseAmount.Location = New System.Drawing.Point(6, 16)
        Me.lblPurchaseAmount.Name = "lblPurchaseAmount"
        Me.lblPurchaseAmount.Size = New System.Drawing.Size(304, 45)
        Me.lblPurchaseAmount.TabIndex = 9
        Me.lblPurchaseAmount.Text = "Purchase Amount:"
        '
        'txtPurchaseAmount
        '
        Me.txtPurchaseAmount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPurchaseAmount.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold)
        Me.txtPurchaseAmount.Location = New System.Drawing.Point(502, 543)
        Me.txtPurchaseAmount.Name = "txtPurchaseAmount"
        Me.txtPurchaseAmount.Size = New System.Drawing.Size(347, 52)
        Me.txtPurchaseAmount.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(146, 202)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(187, 65)
        Me.Panel2.TabIndex = 11
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(146, 401)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(187, 75)
        Me.Panel3.TabIndex = 12
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel4.Controls.Add(Me.lblPurchaseAmount)
        Me.Panel4.Location = New System.Drawing.Point(146, 618)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(321, 80)
        Me.Panel4.TabIndex = 13
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Location = New System.Drawing.Point(967, 205)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(313, 65)
        Me.Panel5.TabIndex = 14
        '
        'StockTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtPurchaseAmount)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.cmbProduct)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StockTransactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StockTransactions"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbProduct As ComboBox
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblPurchaseAmount As Label
    Friend WithEvents txtPurchaseAmount As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
End Class
