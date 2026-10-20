<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportsForm
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
        Me.TabSalesReport = New System.Windows.Forms.TabControl()
        Me.tabReports = New System.Windows.Forms.TabPage()
        Me.btnSalesSearch = New System.Windows.Forms.Button()
        Me.txtSalesSearch = New System.Windows.Forms.TextBox()
        Me.lblSalesSearch = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.btnFilterSales = New System.Windows.Forms.Button()
        Me.btnExportSalesExcel = New System.Windows.Forms.Button()
        Me.btnExportSalesPDF = New System.Windows.Forms.Button()
        Me.dgvSalesReport = New System.Windows.Forms.DataGridView()
        Me.tabInventoryReport = New System.Windows.Forms.TabPage()
        Me.btnExportInventoryExcel = New System.Windows.Forms.Button()
        Me.btnExportInventoryPDF = New System.Windows.Forms.Button()
        Me.dgvInventoryReport = New System.Windows.Forms.DataGridView()
        Me.tabStockTransactionsReport = New System.Windows.Forms.TabPage()
        Me.lblStockSearch = New System.Windows.Forms.Label()
        Me.btnStockSearch = New System.Windows.Forms.Button()
        Me.btnExportStockExcel = New System.Windows.Forms.Button()
        Me.btnExportStockPDF = New System.Windows.Forms.Button()
        Me.btnFilterStockTransactions = New System.Windows.Forms.Button()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.dgvStockTransactionsReport = New System.Windows.Forms.DataGridView()
        Me.txtStockSearch = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabSalesReport.SuspendLayout()
        Me.tabReports.SuspendLayout()
        CType(Me.dgvSalesReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabInventoryReport.SuspendLayout()
        CType(Me.dgvInventoryReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabStockTransactionsReport.SuspendLayout()
        CType(Me.dgvStockTransactionsReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabSalesReport
        '
        Me.TabSalesReport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TabSalesReport.Controls.Add(Me.tabReports)
        Me.TabSalesReport.Controls.Add(Me.tabInventoryReport)
        Me.TabSalesReport.Controls.Add(Me.tabStockTransactionsReport)
        Me.TabSalesReport.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabSalesReport.Location = New System.Drawing.Point(44, 82)
        Me.TabSalesReport.Name = "TabSalesReport"
        Me.TabSalesReport.SelectedIndex = 0
        Me.TabSalesReport.Size = New System.Drawing.Size(1818, 911)
        Me.TabSalesReport.TabIndex = 0
        '
        'tabReports
        '
        Me.tabReports.Controls.Add(Me.btnSalesSearch)
        Me.tabReports.Controls.Add(Me.txtSalesSearch)
        Me.tabReports.Controls.Add(Me.lblSalesSearch)
        Me.tabReports.Controls.Add(Me.DateTimePicker1)
        Me.tabReports.Controls.Add(Me.DateTimePicker2)
        Me.tabReports.Controls.Add(Me.btnFilterSales)
        Me.tabReports.Controls.Add(Me.btnExportSalesExcel)
        Me.tabReports.Controls.Add(Me.btnExportSalesPDF)
        Me.tabReports.Controls.Add(Me.dgvSalesReport)
        Me.tabReports.Location = New System.Drawing.Point(4, 26)
        Me.tabReports.Name = "tabReports"
        Me.tabReports.Padding = New System.Windows.Forms.Padding(3)
        Me.tabReports.Size = New System.Drawing.Size(1810, 881)
        Me.tabReports.TabIndex = 0
        Me.tabReports.Text = "Sales Report"
        Me.tabReports.UseVisualStyleBackColor = True
        '
        'btnSalesSearch
        '
        Me.btnSalesSearch.Location = New System.Drawing.Point(1065, 5)
        Me.btnSalesSearch.Name = "btnSalesSearch"
        Me.btnSalesSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSalesSearch.TabIndex = 19
        Me.btnSalesSearch.Text = "Search"
        Me.btnSalesSearch.UseVisualStyleBackColor = True
        '
        'txtSalesSearch
        '
        Me.txtSalesSearch.Location = New System.Drawing.Point(857, 3)
        Me.txtSalesSearch.Name = "txtSalesSearch"
        Me.txtSalesSearch.Size = New System.Drawing.Size(171, 25)
        Me.txtSalesSearch.TabIndex = 18
        '
        'lblSalesSearch
        '
        Me.lblSalesSearch.AutoSize = True
        Me.lblSalesSearch.Location = New System.Drawing.Point(767, 7)
        Me.lblSalesSearch.Name = "lblSalesSearch"
        Me.lblSalesSearch.Size = New System.Drawing.Size(83, 17)
        Me.lblSalesSearch.TabIndex = 17
        Me.lblSalesSearch.Text = "Search Sales"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(301, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(308, 25)
        Me.DateTimePicker1.TabIndex = 16
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(6, 2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(289, 25)
        Me.DateTimePicker2.TabIndex = 15
        '
        'btnFilterSales
        '
        Me.btnFilterSales.Location = New System.Drawing.Point(628, 3)
        Me.btnFilterSales.Name = "btnFilterSales"
        Me.btnFilterSales.Size = New System.Drawing.Size(132, 23)
        Me.btnFilterSales.TabIndex = 14
        Me.btnFilterSales.Text = "Filter"
        Me.btnFilterSales.UseVisualStyleBackColor = True
        '
        'btnExportSalesExcel
        '
        Me.btnExportSalesExcel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExportSalesExcel.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportSalesExcel.ForeColor = System.Drawing.Color.Violet
        Me.btnExportSalesExcel.Location = New System.Drawing.Point(1472, 777)
        Me.btnExportSalesExcel.Name = "btnExportSalesExcel"
        Me.btnExportSalesExcel.Size = New System.Drawing.Size(283, 75)
        Me.btnExportSalesExcel.TabIndex = 13
        Me.btnExportSalesExcel.Text = "Export Excel"
        Me.btnExportSalesExcel.UseVisualStyleBackColor = False
        '
        'btnExportSalesPDF
        '
        Me.btnExportSalesPDF.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExportSalesPDF.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportSalesPDF.ForeColor = System.Drawing.Color.Gold
        Me.btnExportSalesPDF.Location = New System.Drawing.Point(1129, 777)
        Me.btnExportSalesPDF.Name = "btnExportSalesPDF"
        Me.btnExportSalesPDF.Size = New System.Drawing.Size(252, 75)
        Me.btnExportSalesPDF.TabIndex = 12
        Me.btnExportSalesPDF.Text = "Export PDF"
        Me.btnExportSalesPDF.UseVisualStyleBackColor = False
        '
        'dgvSalesReport
        '
        Me.dgvSalesReport.AllowUserToAddRows = False
        Me.dgvSalesReport.AllowUserToDeleteRows = False
        Me.dgvSalesReport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvSalesReport.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalesReport.Location = New System.Drawing.Point(6, 33)
        Me.dgvSalesReport.Name = "dgvSalesReport"
        Me.dgvSalesReport.ReadOnly = True
        Me.dgvSalesReport.RowHeadersWidth = 51
        Me.dgvSalesReport.RowTemplate.Height = 24
        Me.dgvSalesReport.Size = New System.Drawing.Size(1774, 720)
        Me.dgvSalesReport.TabIndex = 10
        '
        'tabInventoryReport
        '
        Me.tabInventoryReport.Controls.Add(Me.btnExportInventoryExcel)
        Me.tabInventoryReport.Controls.Add(Me.btnExportInventoryPDF)
        Me.tabInventoryReport.Controls.Add(Me.dgvInventoryReport)
        Me.tabInventoryReport.Location = New System.Drawing.Point(4, 26)
        Me.tabInventoryReport.Name = "tabInventoryReport"
        Me.tabInventoryReport.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInventoryReport.Size = New System.Drawing.Size(1810, 881)
        Me.tabInventoryReport.TabIndex = 1
        Me.tabInventoryReport.Text = "Inventory Report"
        Me.tabInventoryReport.UseVisualStyleBackColor = True
        '
        'btnExportInventoryExcel
        '
        Me.btnExportInventoryExcel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExportInventoryExcel.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportInventoryExcel.ForeColor = System.Drawing.Color.Violet
        Me.btnExportInventoryExcel.Location = New System.Drawing.Point(1472, 777)
        Me.btnExportInventoryExcel.Name = "btnExportInventoryExcel"
        Me.btnExportInventoryExcel.Size = New System.Drawing.Size(283, 75)
        Me.btnExportInventoryExcel.TabIndex = 11
        Me.btnExportInventoryExcel.Text = "Export Excel"
        Me.btnExportInventoryExcel.UseVisualStyleBackColor = False
        '
        'btnExportInventoryPDF
        '
        Me.btnExportInventoryPDF.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExportInventoryPDF.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportInventoryPDF.ForeColor = System.Drawing.Color.Gold
        Me.btnExportInventoryPDF.Location = New System.Drawing.Point(1129, 777)
        Me.btnExportInventoryPDF.Name = "btnExportInventoryPDF"
        Me.btnExportInventoryPDF.Size = New System.Drawing.Size(252, 75)
        Me.btnExportInventoryPDF.TabIndex = 10
        Me.btnExportInventoryPDF.Text = "Export PDF"
        Me.btnExportInventoryPDF.UseVisualStyleBackColor = False
        '
        'dgvInventoryReport
        '
        Me.dgvInventoryReport.AllowUserToAddRows = False
        Me.dgvInventoryReport.AllowUserToDeleteRows = False
        Me.dgvInventoryReport.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvInventoryReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventoryReport.Location = New System.Drawing.Point(19, 18)
        Me.dgvInventoryReport.Name = "dgvInventoryReport"
        Me.dgvInventoryReport.ReadOnly = True
        Me.dgvInventoryReport.RowHeadersWidth = 51
        Me.dgvInventoryReport.RowTemplate.Height = 24
        Me.dgvInventoryReport.Size = New System.Drawing.Size(1771, 732)
        Me.dgvInventoryReport.TabIndex = 9
        '
        'tabStockTransactionsReport
        '
        Me.tabStockTransactionsReport.Controls.Add(Me.lblStockSearch)
        Me.tabStockTransactionsReport.Controls.Add(Me.btnStockSearch)
        Me.tabStockTransactionsReport.Controls.Add(Me.btnExportStockExcel)
        Me.tabStockTransactionsReport.Controls.Add(Me.btnExportStockPDF)
        Me.tabStockTransactionsReport.Controls.Add(Me.btnFilterStockTransactions)
        Me.tabStockTransactionsReport.Controls.Add(Me.dtpEndDate)
        Me.tabStockTransactionsReport.Controls.Add(Me.dtpStartDate)
        Me.tabStockTransactionsReport.Controls.Add(Me.dgvStockTransactionsReport)
        Me.tabStockTransactionsReport.Controls.Add(Me.txtStockSearch)
        Me.tabStockTransactionsReport.Location = New System.Drawing.Point(4, 26)
        Me.tabStockTransactionsReport.Name = "tabStockTransactionsReport"
        Me.tabStockTransactionsReport.Padding = New System.Windows.Forms.Padding(3)
        Me.tabStockTransactionsReport.Size = New System.Drawing.Size(1810, 881)
        Me.tabStockTransactionsReport.TabIndex = 2
        Me.tabStockTransactionsReport.Text = "Stock-In & Stock-Out Report"
        Me.tabStockTransactionsReport.UseVisualStyleBackColor = True
        '
        'lblStockSearch
        '
        Me.lblStockSearch.AutoSize = True
        Me.lblStockSearch.Location = New System.Drawing.Point(778, 9)
        Me.lblStockSearch.Name = "lblStockSearch"
        Me.lblStockSearch.Size = New System.Drawing.Size(134, 17)
        Me.lblStockSearch.TabIndex = 21
        Me.lblStockSearch.Text = "Search Stock In/Out:"
        '
        'btnStockSearch
        '
        Me.btnStockSearch.Location = New System.Drawing.Point(1151, 6)
        Me.btnStockSearch.Name = "btnStockSearch"
        Me.btnStockSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnStockSearch.TabIndex = 20
        Me.btnStockSearch.Text = "Search"
        Me.btnStockSearch.UseVisualStyleBackColor = True
        '
        'btnExportStockExcel
        '
        Me.btnExportStockExcel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExportStockExcel.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportStockExcel.ForeColor = System.Drawing.Color.Violet
        Me.btnExportStockExcel.Location = New System.Drawing.Point(1472, 777)
        Me.btnExportStockExcel.Name = "btnExportStockExcel"
        Me.btnExportStockExcel.Size = New System.Drawing.Size(283, 75)
        Me.btnExportStockExcel.TabIndex = 6
        Me.btnExportStockExcel.Text = "Export Excel"
        Me.btnExportStockExcel.UseVisualStyleBackColor = False
        '
        'btnExportStockPDF
        '
        Me.btnExportStockPDF.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExportStockPDF.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportStockPDF.ForeColor = System.Drawing.Color.Gold
        Me.btnExportStockPDF.Location = New System.Drawing.Point(1129, 777)
        Me.btnExportStockPDF.Name = "btnExportStockPDF"
        Me.btnExportStockPDF.Size = New System.Drawing.Size(252, 75)
        Me.btnExportStockPDF.TabIndex = 1
        Me.btnExportStockPDF.Text = "Export PDF"
        Me.btnExportStockPDF.UseVisualStyleBackColor = False
        '
        'btnFilterStockTransactions
        '
        Me.btnFilterStockTransactions.Location = New System.Drawing.Point(626, 3)
        Me.btnFilterStockTransactions.Name = "btnFilterStockTransactions"
        Me.btnFilterStockTransactions.Size = New System.Drawing.Size(142, 23)
        Me.btnFilterStockTransactions.TabIndex = 5
        Me.btnFilterStockTransactions.Text = "Filter"
        Me.btnFilterStockTransactions.UseVisualStyleBackColor = True
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(299, 3)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(319, 25)
        Me.dtpEndDate.TabIndex = 3
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Location = New System.Drawing.Point(3, 3)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(287, 25)
        Me.dtpStartDate.TabIndex = 2
        '
        'dgvStockTransactionsReport
        '
        Me.dgvStockTransactionsReport.AllowUserToAddRows = False
        Me.dgvStockTransactionsReport.AllowUserToDeleteRows = False
        Me.dgvStockTransactionsReport.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvStockTransactionsReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStockTransactionsReport.Location = New System.Drawing.Point(6, 34)
        Me.dgvStockTransactionsReport.Name = "dgvStockTransactionsReport"
        Me.dgvStockTransactionsReport.ReadOnly = True
        Me.dgvStockTransactionsReport.RowHeadersWidth = 51
        Me.dgvStockTransactionsReport.RowTemplate.Height = 24
        Me.dgvStockTransactionsReport.Size = New System.Drawing.Size(1781, 713)
        Me.dgvStockTransactionsReport.TabIndex = 0
        '
        'txtStockSearch
        '
        Me.txtStockSearch.Location = New System.Drawing.Point(940, 6)
        Me.txtStockSearch.Name = "txtStockSearch"
        Me.txtStockSearch.Size = New System.Drawing.Size(194, 25)
        Me.txtStockSearch.TabIndex = 7
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBack.BackColor = System.Drawing.Color.IndianRed
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(10, 7)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(107, 67)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(136, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 62)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "REPORTS"
        '
        'ReportsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.TabSalesReport)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReportsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReportsForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabSalesReport.ResumeLayout(False)
        Me.tabReports.ResumeLayout(False)
        Me.tabReports.PerformLayout()
        CType(Me.dgvSalesReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabInventoryReport.ResumeLayout(False)
        CType(Me.dgvInventoryReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabStockTransactionsReport.ResumeLayout(False)
        Me.tabStockTransactionsReport.PerformLayout()
        CType(Me.dgvStockTransactionsReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabSalesReport As TabControl
    Friend WithEvents tabReports As TabPage
    Friend WithEvents tabInventoryReport As TabPage
    Friend WithEvents tabStockTransactionsReport As TabPage
    Friend WithEvents dgvStockTransactionsReport As DataGridView
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents btnFilterStockTransactions As Button
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents btnExportStockExcel As Button
    Friend WithEvents btnExportStockPDF As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnExportSalesExcel As Button
    Friend WithEvents btnExportSalesPDF As Button
    Friend WithEvents dgvSalesReport As DataGridView
    Friend WithEvents btnExportInventoryExcel As Button
    Friend WithEvents btnExportInventoryPDF As Button
    Friend WithEvents dgvInventoryReport As DataGridView
    Friend WithEvents btnFilterSales As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents btnStockSearch As Button
    Friend WithEvents txtStockSearch As TextBox
    Friend WithEvents lblSalesSearch As Label
    Friend WithEvents txtSalesSearch As TextBox
    Friend WithEvents btnSalesSearch As Button
    Friend WithEvents lblStockSearch As Label
End Class
