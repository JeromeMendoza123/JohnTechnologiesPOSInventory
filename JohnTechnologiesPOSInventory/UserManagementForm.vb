Imports MySql.Data.MySqlClient

Public Class UserManagementForm
    Dim selectedUserId As Integer = -1

    Private Sub UserManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
        cmbRole.Items.Clear()
        If MainDashboard.CurrentRole = "Owner" Then
            cmbRole.Items.AddRange(New String() {"Administrator", "Staff"})
        ElseIf MainDashboard.CurrentRole = "Administrator" Then
            cmbRole.Items.Add("Staff")
        End If
        If cmbRole.Items.Count > 0 Then cmbRole.SelectedIndex = 0
        ClearInputs()
        ' Only Owner and Admin can manage users
        Dim canManageUsers As Boolean = (MainDashboard.CurrentRole = "Owner" Or MainDashboard.CurrentRole = "Administrator")
        btnAdd.Enabled = canManageUsers
        btnEdit.Enabled = canManageUsers
        btnDelete.Enabled = canManageUsers
    End Sub

    Private Sub LoadUsers()
        dgvUsers.Rows.Clear()
        Using conn As MySqlConnection = DBConnection.GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT UserID, Username, Role FROM Users", conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                dgvUsers.Rows.Add(reader("UserID"), reader("Username"), reader("Role"))
            End While
        End Using
        dgvUsers.ClearSelection()
        ClearInputs()
    End Sub

    Private Sub ClearInputs()
        txtUsername.Text = ""
        txtPassword.Text = ""
        If cmbRole.Items.Count > 0 Then cmbRole.SelectedIndex = 0
        selectedUserId = -1
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadUsers()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Or cmbRole.SelectedIndex = -1 Then
            MessageBox.Show("Please enter username, password, and select a role.")
            Return
        End If
        ' Prevent duplicate username
        Dim exists As Boolean = False
        Using conn As MySqlConnection = DBConnection.GetConnection()
            conn.Open()
            Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @username", conn)
            checkCmd.Parameters.AddWithValue("@username", txtUsername.Text)
            Dim count = Convert.ToInt32(checkCmd.ExecuteScalar())
            If count > 0 Then
                exists = True
            End If
        End Using
        If exists Then
            MessageBox.Show("A user with this username already exists.")
            Return
        End If
        ' Role logic: Owner can add Admin/Staff, Admin can add Staff only
        Dim selectedRole As String = cmbRole.SelectedItem.ToString()
        If MainDashboard.CurrentRole = "Administrator" AndAlso selectedRole <> "Staff" Then
            MessageBox.Show("Administrators can only add Staff accounts.")
            Return
        End If
        ' Validate username and password
        If Not IsValidUsername(txtUsername.Text) Then
            MessageBox.Show("Username cannot be numbers only and cannot be empty.")
            Return
        End If
        If Not IsValidPassword(txtPassword.Text) Then
            MessageBox.Show("Password must be 6-8 characters and cannot be numbers only.")
            Return
        End If
        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand("INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)", conn)
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                cmd.Parameters.AddWithValue("@Role", selectedRole)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("User added successfully.")
            LoadUsers()
        Catch ex As Exception
            MessageBox.Show("Error adding user: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvUsers_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUsers.SelectionChanged
        If dgvUsers.SelectedRows.Count > 0 Then
            Dim row = dgvUsers.SelectedRows(0)
            selectedUserId = Convert.ToInt32(row.Cells(0).Value)
            txtUsername.Text = row.Cells(1).Value.ToString()
            cmbRole.SelectedItem = row.Cells(2).Value.ToString()
            txtPassword.Text = ""
            btnSave.Enabled = False
            btnCancel.Enabled = True
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If selectedUserId = -1 Then
            MessageBox.Show("Please select a user to edit.")
            Return
        End If
        ' Get the original role from the selected row
        Dim originalRole As String = ""
        If dgvUsers.SelectedRows.Count > 0 Then
            originalRole = dgvUsers.SelectedRows(0).Cells(2).Value.ToString()
        End If
        ' Prevent Admin from editing any Administrator account
        If MainDashboard.CurrentRole = "Administrator" AndAlso originalRole = "Administrator" Then
            MessageBox.Show("Administrators cannot edit Administrator accounts.")
            Return
        End If
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If selectedUserId = -1 Then
            MessageBox.Show("No user selected.")
            Return
        End If
        If txtUsername.Text = "" Then
            MessageBox.Show("Username cannot be empty.")
            Return
        End If
        ' Validate username and password
        If Not IsValidUsername(txtUsername.Text) Then
            MessageBox.Show("Username cannot be numbers only and cannot be empty.")
            Return
        End If
        If Not IsValidPassword(txtPassword.Text) Then
            MessageBox.Show("Password must be 6-8 characters and cannot be numbers only.")
            Return
        End If
        ' Get the original role from the selected row
        Dim originalRole As String = ""
        If dgvUsers.SelectedRows.Count > 0 Then
            originalRole = dgvUsers.SelectedRows(0).Cells(2).Value.ToString()
        End If
        ' Prevent Admin from saving changes to any Administrator account
        If MainDashboard.CurrentRole = "Administrator" AndAlso originalRole = "Administrator" Then
            MessageBox.Show("Administrators cannot save changes to Administrator accounts.")
            Return
        End If
        Using conn As MySqlConnection = DBConnection.GetConnection()
            conn.Open()
            Dim sql As String = "UPDATE Users SET Username=@Username, Role=@Role" & If(txtPassword.Text <> "", ", Password=@Password", "") & " WHERE UserID=@UserID"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@Role", cmbRole.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@UserID", selectedUserId)
            If txtPassword.Text <> "" Then
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
            End If
            cmd.ExecuteNonQuery()
        End Using
        MessageBox.Show("User updated successfully.")
        LoadUsers()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedUserId = -1 Then
            MessageBox.Show("Please select a user to delete.")
            Return
        End If
        ' Prevent Admin from deleting Admins
        Dim selectedRole As String = ""
        If dgvUsers.SelectedRows.Count > 0 Then
            selectedRole = dgvUsers.SelectedRows(0).Cells(2).Value.ToString()
        End If
        If MainDashboard.CurrentRole = "Administrator" AndAlso selectedRole = "Administrator" Then
            MessageBox.Show("Administrators cannot delete other Administrators.")
            Return
        End If
        If MessageBox.Show("Are you sure you want to delete this user?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM Users WHERE UserID=@UserID", conn)
                cmd.Parameters.AddWithValue("@UserID", selectedUserId)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("User deleted successfully.")
            LoadUsers()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearInputs()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close() ' Just close the form, do not show MainDashboard again
    End Sub

    Private Function IsNumbersOnly(input As String) As Boolean
        Return input.All(Function(c) Char.IsDigit(c))
    End Function

    Private Function IsValidUsername(input As String) As Boolean
        Return Not IsNumbersOnly(input) AndAlso input.Length > 0
    End Function

    Private Function IsValidPassword(input As String) As Boolean
        Return Not IsNumbersOnly(input) AndAlso input.Length >= 6 AndAlso input.Length <= 8
    End Function
End Class