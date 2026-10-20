Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private loginAttempts As Integer = 0
    Private Const MaxAttempts As Integer = 3

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        lblError.Text = "" ' Clear previous error
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text

        If username = "" Or password = "" Then
            lblError.Text = "Please enter both username and password."
            Return
        End If

        Try
            Using conn As MySqlConnection = DBConnection.GetConnection()
                conn.Open()
                Dim query As String = "SELECT UserID, Username, Role FROM Users WHERE Username = @username AND Password = @password"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            loginAttempts = 0
                            Me.Hide()
                            MainDashboard.CurrentUsername = reader("Username").ToString()
                            MainDashboard.CurrentRole = reader("Role").ToString()
                            MainDashboard.CurrentUserID = Convert.ToInt32(reader("UserID"))
                            MainDashboard.Show()
                        Else
                            loginAttempts += 1
                            If loginAttempts >= MaxAttempts Then
                                MessageBox.Show("Login failed 3 times. Application will now exit.", "Login Locked", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Application.Exit()
                            Else
                                lblError.Text = $"Invalid username or password. Attempt {loginAttempts} of {MaxAttempts}."
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            lblError.Text = "Database error: " & ex.Message
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub
End Class