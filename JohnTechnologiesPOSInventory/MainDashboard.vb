Public Class MainDashboard
    Public Shared Property CurrentUsername As String = ""
    Public Shared Property CurrentRole As String = ""
    Public Shared CurrentUserID As Integer

    Private Sub MainDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = $"Welcome, {CurrentUsername}!"
        lblRole.Text = $"Role: {CurrentRole}"
        ' User Management: Owner and Admin only
        btnUserManagement.Visible = (CurrentRole = "Administrator" Or CurrentRole = "Owner")
        ' Reports: Owner only
        btnReports.Visible = (CurrentRole = "Owner")
        ' Manage Products: Admin and Staff
        btnManageProducts.Visible = (CurrentRole = "Administrator" Or CurrentRole = "Staff")
        ' Stock Transactions: Admin only
        btnStockTransactions.Visible = (CurrentRole = "Administrator")
        ' POS: Staff only
        btnPOS.Visible = (CurrentRole = "Staff")
        ' Analytics: Owner only
        btnAnalytics.Visible = (CurrentRole = "Owner")
    End Sub

    Private Sub btnManageProducts_Click(sender As Object, e As EventArgs) Handles btnManageProducts.Click
        Dim productForm As New ProductForm()
        productForm.ShowDialog()
        productForm.Dispose()
    End Sub

    Private Sub btnStockTransactions_Click(sender As Object, e As EventArgs) Handles btnStockTransactions.Click
        Dim stockTransactionsForm As New StockTransactions()
        stockTransactionsForm.ShowDialog()
        stockTransactionsForm.Dispose()
    End Sub

    Private Sub btnPOS_Click(sender As Object, e As EventArgs) Handles btnPOS.Click
        Dim posForm As New POSForm()
        posForm.ShowDialog()
        posForm.Dispose()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        If CurrentRole <> "Owner" Then
            MessageBox.Show("Access denied. Only owners can view reports.")
            Return
        End If
        Dim reportsForm As New ReportsForm()
        reportsForm.ShowDialog()
        reportsForm.Dispose()
    End Sub

    Private Sub btnUserManagement_Click(sender As Object, e As EventArgs) Handles btnUserManagement.Click
        Dim userForm As New UserManagementForm()
        userForm.ShowDialog()
        userForm.Dispose()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub btnAnalytics_Click(sender As Object, e As EventArgs) Handles btnAnalytics.Click
        If CurrentRole <> "Owner" Then
            MessageBox.Show("Access denied. Only owners can view analytics.")
            Return
        End If
        Dim analyticsForm As New AnalyticsForm()
        analyticsForm.ShowDialog()
        analyticsForm.Dispose()
    End Sub

    Private Sub Panel11_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
