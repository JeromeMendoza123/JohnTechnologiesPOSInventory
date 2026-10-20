<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POSForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvCart = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbProduct = New System.Windows.Forms.ComboBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        Me.btnClearSelected = New System.Windows.Forms.Button()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCart
        '
        Me.dgvCart.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvCart.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvCart.Location = New System.Drawing.Point(331, 90)
        Me.dgvCart.Name = "dgvCart"
        Me.dgvCart.RowHeadersWidth = 51
        Me.dgvCart.RowTemplate.Height = 24
        Me.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCart.Size = New System.Drawing.Size(1534, 610)
        Me.dgvCart.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "ProductID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "ProductName"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Price"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Quantity"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'cmbProduct
        '
        Me.cmbProduct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbProduct.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProduct.FormattingEnabled = True
        Me.cmbProduct.Location = New System.Drawing.Point(616, 768)
        Me.cmbProduct.Name = "cmbProduct"
        Me.cmbProduct.Size = New System.Drawing.Size(581, 49)
        Me.cmbProduct.TabIndex = 1
        '
        'txtQuantity
        '
        Me.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(616, 938)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(581, 47)
        Me.txtQuantity.TabIndex = 2
        '
        'txtCash
        '
        Me.txtCash.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCash.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.Location = New System.Drawing.Point(616, 851)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(581, 47)
        Me.txtCash.TabIndex = 3
        '
        'lblChange
        '
        Me.lblChange.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblChange.AutoSize = True
        Me.lblChange.BackColor = System.Drawing.Color.Transparent
        Me.lblChange.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(1480, 771)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(184, 41)
        Me.lblChange.TabIndex = 4
        Me.lblChange.Text = "The Change"
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(1480, 851)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(270, 41)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "The Total Amount"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1329, 771)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 41)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Change:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1329, 851)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 41)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Total:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(323, 771)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 41)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Select Product:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(324, 941)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 41)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Quantity:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(324, 851)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 41)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Cash:"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.IndianRed
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBack.Location = New System.Drawing.Point(3, 7)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(93, 41)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnCheckout
        '
        Me.btnCheckout.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCheckout.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.btnCheckout.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.Location = New System.Drawing.Point(15, 187)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(253, 134)
        Me.btnCheckout.TabIndex = 12
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'btnAddToCart
        '
        Me.btnAddToCart.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.btnAddToCart.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddToCart.Location = New System.Drawing.Point(15, 11)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(253, 120)
        Me.btnAddToCart.TabIndex = 13
        Me.btnAddToCart.Text = "Add to Cart"
        Me.btnAddToCart.UseVisualStyleBackColor = False
        '
        'btnClearSelected
        '
        Me.btnClearSelected.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClearSelected.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.btnClearSelected.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearSelected.Location = New System.Drawing.Point(15, 385)
        Me.btnClearSelected.Name = "btnClearSelected"
        Me.btnClearSelected.Size = New System.Drawing.Size(253, 137)
        Me.btnClearSelected.TabIndex = 14
        Me.btnClearSelected.Text = "Clear Selected"
        Me.btnClearSelected.UseVisualStyleBackColor = False
        '
        'btnClearAll
        '
        Me.btnClearAll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClearAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.btnClearAll.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAll.Location = New System.Drawing.Point(15, 593)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(253, 121)
        Me.btnClearAll.TabIndex = 15
        Me.btnClearAll.Text = "Clear All"
        Me.btnClearAll.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(117, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(216, 45)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Point of Sale"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCheckout)
        Me.Panel1.Controls.Add(Me.btnAddToCart)
        Me.Panel1.Controls.Add(Me.btnClearAll)
        Me.Panel1.Controls.Add(Me.btnClearSelected)
        Me.Panel1.Location = New System.Drawing.Point(12, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(288, 740)
        Me.Panel1.TabIndex = 17
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.Controls.Add(Me.btnBack)
        Me.Panel8.Location = New System.Drawing.Point(12, 12)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(99, 54)
        Me.Panel8.TabIndex = 18
        '
        'Panel7
        '
        Me.Panel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(317, 72)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1560, 650)
        Me.Panel7.TabIndex = 23
        '
        'POSForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.cmbProduct)
        Me.Controls.Add(Me.dgvCart)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "POSForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POSForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCart As DataGridView
    Friend WithEvents cmbProduct As ComboBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtCash As TextBox
    Friend WithEvents lblChange As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnCheckout As Button
    Friend WithEvents btnAddToCart As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents btnClearSelected As Button
    Friend WithEvents btnClearAll As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
End Class
