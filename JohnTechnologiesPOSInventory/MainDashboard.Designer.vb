<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainDashboard
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
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.btnManageProducts = New System.Windows.Forms.Button()
        Me.btnStockTransactions = New System.Windows.Forms.Button()
        Me.btnPOS = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnUserManagement = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAnalytics = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(2, 3)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(443, 54)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = """Name Appears Here"""
        '
        'lblRole
        '
        Me.lblRole.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRole.AutoSize = True
        Me.lblRole.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.Location = New System.Drawing.Point(1477, 3)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(412, 54)
        Me.lblRole.TabIndex = 1
        Me.lblRole.Text = """Role Appears Here"""
        Me.lblRole.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnManageProducts
        '
        Me.btnManageProducts.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.btnManageProducts.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageProducts.Location = New System.Drawing.Point(690, 220)
        Me.btnManageProducts.Name = "btnManageProducts"
        Me.btnManageProducts.Size = New System.Drawing.Size(486, 147)
        Me.btnManageProducts.TabIndex = 2
        Me.btnManageProducts.Text = "📥Manage Products"
        Me.btnManageProducts.UseVisualStyleBackColor = False
        '
        'btnStockTransactions
        '
        Me.btnStockTransactions.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.btnStockTransactions.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockTransactions.Location = New System.Drawing.Point(403, 413)
        Me.btnStockTransactions.Name = "btnStockTransactions"
        Me.btnStockTransactions.Size = New System.Drawing.Size(489, 147)
        Me.btnStockTransactions.TabIndex = 3
        Me.btnStockTransactions.Text = "📤Stock Transactions"
        Me.btnStockTransactions.UseVisualStyleBackColor = False
        '
        'btnPOS
        '
        Me.btnPOS.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.btnPOS.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPOS.Location = New System.Drawing.Point(64, 220)
        Me.btnPOS.Name = "btnPOS"
        Me.btnPOS.Size = New System.Drawing.Size(486, 147)
        Me.btnPOS.TabIndex = 4
        Me.btnPOS.Text = "Payment"
        Me.btnPOS.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.btnReports.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.Location = New System.Drawing.Point(690, 222)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(486, 145)
        Me.btnReports.TabIndex = 5
        Me.btnReports.Text = "📃Reports"
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'btnUserManagement
        '
        Me.btnUserManagement.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.btnUserManagement.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserManagement.Location = New System.Drawing.Point(64, 222)
        Me.btnUserManagement.Name = "btnUserManagement"
        Me.btnUserManagement.Size = New System.Drawing.Size(486, 145)
        Me.btnUserManagement.TabIndex = 6
        Me.btnUserManagement.Text = "👤User Management"
        Me.btnUserManagement.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.IndianRed
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(406, 652)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(486, 141)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnAnalytics)
        Me.Panel1.Controls.Add(Me.btnManageProducts)
        Me.Panel1.Controls.Add(Me.btnReports)
        Me.Panel1.Controls.Add(Me.btnUserManagement)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnStockTransactions)
        Me.Panel1.Controls.Add(Me.btnPOS)
        Me.Panel1.Location = New System.Drawing.Point(354, 181)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1218, 817)
        Me.Panel1.TabIndex = 9
        '
        'btnAnalytics
        '
        Me.btnAnalytics.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.btnAnalytics.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnalytics.Location = New System.Drawing.Point(406, 415)
        Me.btnAnalytics.Name = "btnAnalytics"
        Me.btnAnalytics.Size = New System.Drawing.Size(486, 145)
        Me.btnAnalytics.TabIndex = 8
        Me.btnAnalytics.Text = "📊 Analytics "
        Me.btnAnalytics.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Location = New System.Drawing.Point(4, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1913, 83)
        Me.Panel7.TabIndex = 12
        '
        'Panel8
        '
        Me.Panel8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel8.Controls.Add(Me.lblWelcome)
        Me.Panel8.Controls.Add(Me.lblRole)
        Me.Panel8.Location = New System.Drawing.Point(11, 9)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1893, 62)
        Me.Panel8.TabIndex = 14
        '
        'MainDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents btnManageProducts As Button
    Friend WithEvents btnStockTransactions As Button
    Friend WithEvents btnPOS As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnUserManagement As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnAnalytics As Button
End Class
