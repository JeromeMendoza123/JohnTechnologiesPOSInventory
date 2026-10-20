<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductForm
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
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.lblProductSearch = New System.Windows.Forms.Label()
        Me.txtSearchProduct = New System.Windows.Forms.TextBox()
        Me.btnProductSearch = New System.Windows.Forms.Button()
        Me.lblLowStockAlert = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvProducts
        '
        Me.dgvProducts.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvProducts.Location = New System.Drawing.Point(95, 260)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.RowHeadersWidth = 51
        Me.dgvProducts.RowTemplate.Height = 24
        Me.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProducts.Size = New System.Drawing.Size(1718, 523)
        Me.dgvProducts.TabIndex = 0
        '
        'txtProductName
        '
        Me.txtProductName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtProductName.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.Location = New System.Drawing.Point(340, 825)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(585, 47)
        Me.txtProductName.TabIndex = 1
        '
        'txtCategory
        '
        Me.txtCategory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCategory.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(1228, 828)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(585, 47)
        Me.txtCategory.TabIndex = 2
        '
        'txtPrice
        '
        Me.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(340, 927)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(585, 47)
        Me.txtPrice.TabIndex = 3
        '
        'txtQuantity
        '
        Me.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(1228, 930)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(585, 47)
        Me.txtQuantity.TabIndex = 4
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(40, 22)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(244, 93)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(780, 22)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(244, 93)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(414, 22)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(244, 93)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(1147, 22)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(244, 93)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.IndianRed
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBack.Location = New System.Drawing.Point(17, 13)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(158, 72)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(88, 828)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 41)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Product Name:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(88, 930)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 41)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Price:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(1039, 828)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 41)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Category:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(1039, 930)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 41)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Quantity:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Location = New System.Drawing.Point(238, 97)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1424, 137)
        Me.Panel1.TabIndex = 14
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Transparent
        Me.Panel11.Location = New System.Drawing.Point(8, 10)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(175, 78)
        Me.Panel11.TabIndex = 18
        '
        'lblProductSearch
        '
        Me.lblProductSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblProductSearch.AutoSize = True
        Me.lblProductSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductSearch.Location = New System.Drawing.Point(957, 30)
        Me.lblProductSearch.Name = "lblProductSearch"
        Me.lblProductSearch.Size = New System.Drawing.Size(221, 36)
        Me.lblProductSearch.TabIndex = 19
        Me.lblProductSearch.Text = "Search Product"
        '
        'txtSearchProduct
        '
        Me.txtSearchProduct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSearchProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchProduct.Location = New System.Drawing.Point(1197, 27)
        Me.txtSearchProduct.Name = "txtSearchProduct"
        Me.txtSearchProduct.Size = New System.Drawing.Size(459, 41)
        Me.txtSearchProduct.TabIndex = 20
        '
        'btnProductSearch
        '
        Me.btnProductSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnProductSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductSearch.Location = New System.Drawing.Point(1678, 25)
        Me.btnProductSearch.Name = "btnProductSearch"
        Me.btnProductSearch.Size = New System.Drawing.Size(135, 46)
        Me.btnProductSearch.TabIndex = 21
        Me.btnProductSearch.Text = "Search"
        Me.btnProductSearch.UseVisualStyleBackColor = True
        '
        'lblLowStockAlert
        '
        Me.lblLowStockAlert.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLowStockAlert.AutoSize = True
        Me.lblLowStockAlert.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLowStockAlert.ForeColor = System.Drawing.Color.Red
        Me.lblLowStockAlert.Location = New System.Drawing.Point(232, 30)
        Me.lblLowStockAlert.Name = "lblLowStockAlert"
        Me.lblLowStockAlert.Size = New System.Drawing.Size(667, 36)
        Me.lblLowStockAlert.TabIndex = 22
        Me.lblLowStockAlert.Text = "⚠ Low Stock Alert! Click to view low stock items."
        Me.lblLowStockAlert.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "ProductID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        Me.Column1.Width = 200
        '
        'Column2
        '
        Me.Column2.HeaderText = "ProductName"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 370
        '
        'Column3
        '
        Me.Column3.HeaderText = "Category"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 380
        '
        'Column4
        '
        Me.Column4.HeaderText = "Price"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 320
        '
        'Column5
        '
        Me.Column5.HeaderText = "Quantity"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 320
        '
        'ProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.lblLowStockAlert)
        Me.Controls.Add(Me.btnProductSearch)
        Me.Controls.Add(Me.txtSearchProduct)
        Me.Controls.Add(Me.lblProductSearch)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.dgvProducts)
        Me.Controls.Add(Me.Panel11)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProductForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Products"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents lblProductSearch As Label
    Friend WithEvents txtSearchProduct As TextBox
    Friend WithEvents btnProductSearch As Button
    Friend WithEvents lblLowStockAlert As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
