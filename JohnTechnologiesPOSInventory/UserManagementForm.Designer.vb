<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManagementForm
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
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvUsers
        '
        Me.dgvUsers.AllowUserToAddRows = False
        Me.dgvUsers.AllowUserToDeleteRows = False
        Me.dgvUsers.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvUsers.Location = New System.Drawing.Point(336, 111)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.ReadOnly = True
        Me.dgvUsers.RowHeadersWidth = 51
        Me.dgvUsers.RowTemplate.Height = 24
        Me.dgvUsers.Size = New System.Drawing.Size(1535, 648)
        Me.dgvUsers.TabIndex = 0
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(377, 815)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(185, 45)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username:"
        '
        'lblPassword
        '
        Me.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(377, 925)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(175, 45)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password:"
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(581, 817)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(552, 45)
        Me.txtUsername.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(581, 927)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(552, 45)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblRole
        '
        Me.lblRole.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRole.AutoSize = True
        Me.lblRole.BackColor = System.Drawing.Color.Transparent
        Me.lblRole.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.Location = New System.Drawing.Point(1247, 815)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(97, 45)
        Me.lblRole.TabIndex = 5
        Me.lblRole.Text = "Role:"
        '
        'cmbRole
        '
        Me.cmbRole.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Items.AddRange(New Object() {"Administrator", "Cashier"})
        Me.cmbRole.Location = New System.Drawing.Point(1381, 815)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(490, 46)
        Me.cmbRole.TabIndex = 6
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(14, 19)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(261, 129)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(14, 174)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(261, 129)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(14, 326)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(261, 129)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(14, 474)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(261, 129)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(14, 621)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(261, 129)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(14, 768)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(261, 129)
        Me.btnRefresh.TabIndex = 12
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLogout.BackColor = System.Drawing.Color.IndianRed
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(12, 12)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(170, 82)
        Me.btnLogout.TabIndex = 13
        Me.btnLogout.Text = "Back"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Location = New System.Drawing.Point(12, 111)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(292, 910)
        Me.Panel1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 25.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(204, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(455, 59)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "USER MANAGEMENT"
        '
        'Column1
        '
        Me.Column1.HeaderText = "UserID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 300
        '
        'Column2
        '
        Me.Column2.HeaderText = "Username"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 470
        '
        'Column3
        '
        Me.Column3.HeaderText = "Role"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 420
        '
        'UserManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.cmbRole)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.dgvUsers)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserManagementForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserManagementForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblRole As Label
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
