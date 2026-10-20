<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LowStockForm
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
        Me.dgvLowStock = New System.Windows.Forms.DataGridView()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        CType(Me.dgvLowStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLowStock
        '
        Me.dgvLowStock.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvLowStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLowStock.Location = New System.Drawing.Point(125, 81)
        Me.dgvLowStock.Name = "dgvLowStock"
        Me.dgvLowStock.RowHeadersWidth = 51
        Me.dgvLowStock.RowTemplate.Height = 24
        Me.dgvLowStock.Size = New System.Drawing.Size(1638, 830)
        Me.dgvLowStock.TabIndex = 0
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.ButtonRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRefresh.Location = New System.Drawing.Point(1602, 13)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(161, 52)
        Me.ButtonRefresh.TabIndex = 1
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = False
        '
        'LowStockForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.dgvLowStock)
        Me.Name = "LowStockForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LowStockForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvLowStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvLowStock As DataGridView
    Friend WithEvents ButtonRefresh As Button
End Class
