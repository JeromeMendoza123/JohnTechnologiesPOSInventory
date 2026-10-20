<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AnalyticsForm
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.lblTotalExpense = New System.Windows.Forms.Label()
        Me.lblPaymentSent = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotalSalesValue = New System.Windows.Forms.Label()
        Me.lblTotalExpenseValue = New System.Windows.Forms.Label()
        Me.lblPaymentSentValue = New System.Windows.Forms.Label()
        Me.lblPaymentReceivedValue = New System.Windows.Forms.Label()
        Me.chartSales = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chartCategories = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblTotalSalesPercent = New System.Windows.Forms.Label()
        Me.lblTotalExpensePercent = New System.Windows.Forms.Label()
        Me.lblPaymentSentPercent = New System.Windows.Forms.Label()
        Me.lblPaymentReceivedPercent = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        CType(Me.chartSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTotalSales
        '
        Me.lblTotalSales.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotalSales.AutoSize = True
        Me.lblTotalSales.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalSales.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSales.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotalSales.Location = New System.Drawing.Point(101, 39)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(184, 45)
        Me.lblTotalSales.TabIndex = 0
        Me.lblTotalSales.Text = "Total Sales"
        '
        'lblTotalExpense
        '
        Me.lblTotalExpense.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotalExpense.AutoSize = True
        Me.lblTotalExpense.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalExpense.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalExpense.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotalExpense.Location = New System.Drawing.Point(77, 39)
        Me.lblTotalExpense.Name = "lblTotalExpense"
        Me.lblTotalExpense.Size = New System.Drawing.Size(232, 45)
        Me.lblTotalExpense.TabIndex = 1
        Me.lblTotalExpense.Text = "Total Expense"
        '
        'lblPaymentSent
        '
        Me.lblPaymentSent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPaymentSent.AutoSize = True
        Me.lblPaymentSent.BackColor = System.Drawing.Color.Transparent
        Me.lblPaymentSent.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentSent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPaymentSent.Location = New System.Drawing.Point(94, 39)
        Me.lblPaymentSent.Name = "lblPaymentSent"
        Me.lblPaymentSent.Size = New System.Drawing.Size(195, 45)
        Me.lblPaymentSent.TabIndex = 2
        Me.lblPaymentSent.Text = "Investment"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(139, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 45)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Profit"
        '
        'lblTotalSalesValue
        '
        Me.lblTotalSalesValue.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotalSalesValue.AutoSize = True
        Me.lblTotalSalesValue.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalSalesValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotalSalesValue.Location = New System.Drawing.Point(166, 123)
        Me.lblTotalSalesValue.Name = "lblTotalSalesValue"
        Me.lblTotalSalesValue.Size = New System.Drawing.Size(48, 16)
        Me.lblTotalSalesValue.TabIndex = 4
        Me.lblTotalSalesValue.Text = "Label5"
        '
        'lblTotalExpenseValue
        '
        Me.lblTotalExpenseValue.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotalExpenseValue.AutoSize = True
        Me.lblTotalExpenseValue.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalExpenseValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotalExpenseValue.Location = New System.Drawing.Point(166, 123)
        Me.lblTotalExpenseValue.Name = "lblTotalExpenseValue"
        Me.lblTotalExpenseValue.Size = New System.Drawing.Size(48, 16)
        Me.lblTotalExpenseValue.TabIndex = 5
        Me.lblTotalExpenseValue.Text = "Label6"
        '
        'lblPaymentSentValue
        '
        Me.lblPaymentSentValue.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPaymentSentValue.AutoSize = True
        Me.lblPaymentSentValue.BackColor = System.Drawing.Color.Transparent
        Me.lblPaymentSentValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPaymentSentValue.Location = New System.Drawing.Point(166, 123)
        Me.lblPaymentSentValue.Name = "lblPaymentSentValue"
        Me.lblPaymentSentValue.Size = New System.Drawing.Size(48, 16)
        Me.lblPaymentSentValue.TabIndex = 6
        Me.lblPaymentSentValue.Text = "Label7"
        '
        'lblPaymentReceivedValue
        '
        Me.lblPaymentReceivedValue.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPaymentReceivedValue.AutoSize = True
        Me.lblPaymentReceivedValue.BackColor = System.Drawing.Color.Transparent
        Me.lblPaymentReceivedValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPaymentReceivedValue.Location = New System.Drawing.Point(170, 123)
        Me.lblPaymentReceivedValue.Name = "lblPaymentReceivedValue"
        Me.lblPaymentReceivedValue.Size = New System.Drawing.Size(48, 16)
        Me.lblPaymentReceivedValue.TabIndex = 7
        Me.lblPaymentReceivedValue.Text = "Label8"
        '
        'chartSales
        '
        Me.chartSales.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chartSales.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.chartSales.BorderlineColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.chartSales.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.chartSales.BorderlineWidth = 5
        ChartArea1.Name = "ChartArea1"
        Me.chartSales.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartSales.Legends.Add(Legend1)
        Me.chartSales.Location = New System.Drawing.Point(46, 379)
        Me.chartSales.Name = "chartSales"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartSales.Series.Add(Series1)
        Me.chartSales.Size = New System.Drawing.Size(887, 600)
        Me.chartSales.TabIndex = 8
        Me.chartSales.Text = "Chart1"
        '
        'chartCategories
        '
        Me.chartCategories.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chartCategories.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.chartCategories.BorderlineColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.chartCategories.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.chartCategories.BorderlineWidth = 5
        ChartArea2.Name = "ChartArea1"
        Me.chartCategories.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chartCategories.Legends.Add(Legend2)
        Me.chartCategories.Location = New System.Drawing.Point(1023, 379)
        Me.chartCategories.Name = "chartCategories"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chartCategories.Series.Add(Series2)
        Me.chartCategories.Size = New System.Drawing.Size(838, 600)
        Me.chartCategories.TabIndex = 9
        Me.chartCategories.Text = "Chart2"
        '
        'lblTotalSalesPercent
        '
        Me.lblTotalSalesPercent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotalSalesPercent.AutoSize = True
        Me.lblTotalSalesPercent.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalSalesPercent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotalSalesPercent.Location = New System.Drawing.Point(166, 183)
        Me.lblTotalSalesPercent.Name = "lblTotalSalesPercent"
        Me.lblTotalSalesPercent.Size = New System.Drawing.Size(48, 16)
        Me.lblTotalSalesPercent.TabIndex = 10
        Me.lblTotalSalesPercent.Text = "Label5"
        Me.lblTotalSalesPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalExpensePercent
        '
        Me.lblTotalExpensePercent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotalExpensePercent.AutoSize = True
        Me.lblTotalExpensePercent.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalExpensePercent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotalExpensePercent.Location = New System.Drawing.Point(166, 183)
        Me.lblTotalExpensePercent.Name = "lblTotalExpensePercent"
        Me.lblTotalExpensePercent.Size = New System.Drawing.Size(48, 16)
        Me.lblTotalExpensePercent.TabIndex = 11
        Me.lblTotalExpensePercent.Text = "Label5"
        Me.lblTotalExpensePercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPaymentSentPercent
        '
        Me.lblPaymentSentPercent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPaymentSentPercent.AutoSize = True
        Me.lblPaymentSentPercent.BackColor = System.Drawing.Color.Transparent
        Me.lblPaymentSentPercent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPaymentSentPercent.Location = New System.Drawing.Point(166, 183)
        Me.lblPaymentSentPercent.Name = "lblPaymentSentPercent"
        Me.lblPaymentSentPercent.Size = New System.Drawing.Size(48, 16)
        Me.lblPaymentSentPercent.TabIndex = 12
        Me.lblPaymentSentPercent.Text = "Label5"
        Me.lblPaymentSentPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPaymentReceivedPercent
        '
        Me.lblPaymentReceivedPercent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPaymentReceivedPercent.AutoSize = True
        Me.lblPaymentReceivedPercent.BackColor = System.Drawing.Color.Transparent
        Me.lblPaymentReceivedPercent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPaymentReceivedPercent.Location = New System.Drawing.Point(170, 183)
        Me.lblPaymentReceivedPercent.Name = "lblPaymentReceivedPercent"
        Me.lblPaymentReceivedPercent.Size = New System.Drawing.Size(48, 16)
        Me.lblPaymentReceivedPercent.TabIndex = 13
        Me.lblPaymentReceivedPercent.Text = "Label5"
        Me.lblPaymentReceivedPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.IndianRed
        Me.btnBack.Location = New System.Drawing.Point(13, 13)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(118, 62)
        Me.btnBack.TabIndex = 14
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTotalSalesPercent)
        Me.Panel1.Controls.Add(Me.lblTotalSalesValue)
        Me.Panel1.Controls.Add(Me.lblTotalSales)
        Me.Panel1.Location = New System.Drawing.Point(55, 105)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(385, 242)
        Me.Panel1.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel2.Location = New System.Drawing.Point(46, 97)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(405, 260)
        Me.Panel2.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblTotalExpensePercent)
        Me.Panel3.Controls.Add(Me.lblTotalExpense)
        Me.Panel3.Controls.Add(Me.lblTotalExpenseValue)
        Me.Panel3.Location = New System.Drawing.Point(537, 105)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(385, 242)
        Me.Panel3.TabIndex = 17
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(528, 97)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(405, 260)
        Me.Panel4.TabIndex = 18
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lblPaymentSent)
        Me.Panel5.Controls.Add(Me.lblPaymentSentValue)
        Me.Panel5.Controls.Add(Me.lblPaymentSentPercent)
        Me.Panel5.Location = New System.Drawing.Point(10, 8)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(385, 242)
        Me.Panel5.TabIndex = 19
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.lblPaymentReceivedValue)
        Me.Panel6.Controls.Add(Me.lblPaymentReceivedPercent)
        Me.Panel6.Location = New System.Drawing.Point(10, 8)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(385, 242)
        Me.Panel6.TabIndex = 20
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Panel5)
        Me.Panel7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel7.Location = New System.Drawing.Point(1023, 97)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(405, 260)
        Me.Panel7.TabIndex = 17
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Panel6)
        Me.Panel8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel8.Location = New System.Drawing.Point(1456, 97)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(405, 260)
        Me.Panel8.TabIndex = 21
        '
        'AnalyticsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.chartCategories)
        Me.Controls.Add(Me.chartSales)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AnalyticsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AnalyticsForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.chartSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartCategories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTotalSales As Label
    Friend WithEvents lblTotalExpense As Label
    Friend WithEvents lblPaymentSent As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotalSalesValue As Label
    Friend WithEvents lblTotalExpenseValue As Label
    Friend WithEvents lblPaymentSentValue As Label
    Friend WithEvents lblPaymentReceivedValue As Label
    Friend WithEvents chartSales As DataVisualization.Charting.Chart
    Friend WithEvents chartCategories As DataVisualization.Charting.Chart
    Friend WithEvents lblTotalSalesPercent As Label
    Friend WithEvents lblTotalExpensePercent As Label
    Friend WithEvents lblPaymentSentPercent As Label
    Friend WithEvents lblPaymentReceivedPercent As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
End Class
