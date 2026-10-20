Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class AnalyticsForm
    Private Sub AnalyticsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSummaryCards()
        LoadSalesChart()
        LoadCategoryPieChart()
    End Sub

    Private Sub LoadSummaryCards()
        ' Get current and last month values for each metric
        Dim currentMonth As Integer = DateTime.Now.Month
        Dim lastMonth As Integer = If(currentMonth = 1, 12, currentMonth - 1)
        Dim currentYear As Integer = DateTime.Now.Year
        Dim lastMonthYear As Integer = If(currentMonth = 1, currentYear - 1, currentYear)

        Using conn As MySqlConnection = DBConnection.GetConnection()
            conn.Open()
            ' Total Sales
            Dim querySalesCurrent As String = "SELECT IFNULL(SUM(TotalAmount),0) FROM Sales WHERE MONTH(Date) = @month AND YEAR(Date) = @year"
            Dim querySalesLast As String = "SELECT IFNULL(SUM(TotalAmount),0) FROM Sales WHERE MONTH(Date) = @month AND YEAR(Date) = @year"
            Dim totalSales, lastMonthSales As Decimal
            Using cmd As New MySqlCommand(querySalesCurrent, conn)
                cmd.Parameters.AddWithValue("@month", currentMonth)
                cmd.Parameters.AddWithValue("@year", currentYear)
                totalSales = Convert.ToDecimal(cmd.ExecuteScalar())
            End Using
            Using cmd As New MySqlCommand(querySalesLast, conn)
                cmd.Parameters.AddWithValue("@month", lastMonth)
                cmd.Parameters.AddWithValue("@year", lastMonthYear)
                lastMonthSales = Convert.ToDecimal(cmd.ExecuteScalar())
            End Using
            lblTotalSalesValue.Text = "₱" & totalSales.ToString("N2")
            lblTotalSalesPercent.Text = GetPercentChangeText(totalSales, lastMonthSales)

            ' Total Expense
            Dim queryExpenseCurrent As String = "SELECT IFNULL(SUM(Amount),0) FROM Expenses WHERE MONTH(Date) = @month AND YEAR(Date) = @year"
            Dim queryExpenseLast As String = "SELECT IFNULL(SUM(Amount),0) FROM Expenses WHERE MONTH(Date) = @month AND YEAR(Date) = @year"
            Dim totalExpense, lastMonthExpense As Decimal
            Using cmd As New MySqlCommand(queryExpenseCurrent, conn)
                cmd.Parameters.AddWithValue("@month", currentMonth)
                cmd.Parameters.AddWithValue("@year", currentYear)
                totalExpense = Convert.ToDecimal(cmd.ExecuteScalar())
            End Using
            Using cmd As New MySqlCommand(queryExpenseLast, conn)
                cmd.Parameters.AddWithValue("@month", lastMonth)
                cmd.Parameters.AddWithValue("@year", lastMonthYear)
                lastMonthExpense = Convert.ToDecimal(cmd.ExecuteScalar())
            End Using
            lblTotalExpenseValue.Text = "₱" & totalExpense.ToString("N2")
            lblTotalExpensePercent.Text = GetPercentChangeText(totalExpense, lastMonthExpense)

            ' Payment Sent
            Dim querySentCurrent As String = "SELECT IFNULL(SUM(Amount),0) FROM Payments WHERE Type='Sent' AND MONTH(Date) = @month AND YEAR(Date) = @year"
            Dim querySentLast As String = "SELECT IFNULL(SUM(Amount),0) FROM Payments WHERE Type='Sent' AND MONTH(Date) = @month AND YEAR(Date) = @year"
            Dim paymentSent, lastMonthSent As Decimal
            Using cmd As New MySqlCommand(querySentCurrent, conn)
                cmd.Parameters.AddWithValue("@month", currentMonth)
                cmd.Parameters.AddWithValue("@year", currentYear)
                paymentSent = Convert.ToDecimal(cmd.ExecuteScalar())
            End Using
            Using cmd As New MySqlCommand(querySentLast, conn)
                cmd.Parameters.AddWithValue("@month", lastMonth)
                cmd.Parameters.AddWithValue("@year", lastMonthYear)
                lastMonthSent = Convert.ToDecimal(cmd.ExecuteScalar())
            End Using
            lblPaymentSentValue.Text = "₱" & paymentSent.ToString("N2")
            lblPaymentSentPercent.Text = GetPercentChangeText(paymentSent, lastMonthSent)

            ' Payment Received
            Dim queryReceivedCurrent As String = "SELECT IFNULL(SUM(Amount),0) FROM Payments WHERE Type='Received' AND MONTH(Date) = @month AND YEAR(Date) = @year"
            Dim queryReceivedLast As String = "SELECT IFNULL(SUM(Amount),0) FROM Payments WHERE Type='Received' AND MONTH(Date) = @month AND YEAR(Date) = @year"
            Dim paymentReceived, lastMonthReceived As Decimal
            Using cmd As New MySqlCommand(queryReceivedCurrent, conn)
                cmd.Parameters.AddWithValue("@month", currentMonth)
                cmd.Parameters.AddWithValue("@year", currentYear)
                paymentReceived = Convert.ToDecimal(cmd.ExecuteScalar())
            End Using
            Using cmd As New MySqlCommand(queryReceivedLast, conn)
                cmd.Parameters.AddWithValue("@month", lastMonth)
                cmd.Parameters.AddWithValue("@year", lastMonthYear)
                lastMonthReceived = Convert.ToDecimal(cmd.ExecuteScalar())
            End Using
            lblPaymentReceivedValue.Text = "₱" & paymentReceived.ToString("N2")
            lblPaymentReceivedPercent.Text = GetPercentChangeText(paymentReceived, lastMonthReceived)
        End Using
    End Sub

    Private Function GetPercentChangeText(currentValue As Decimal, lastValue As Decimal) As String
        If lastValue = 0 Then
            If currentValue = 0 Then
                Return "0% Than Last Month"
            Else
                Return "+100% Than Last Month"
            End If
        End If
        Dim percentChange As Decimal = ((currentValue - lastValue) / lastValue) * 100
        Dim sign As String = If(percentChange >= 0, "+", "-")
        Return sign & Math.Abs(percentChange).ToString("N0") & "% Than Last Month"
    End Function

    Private Sub LoadSalesChart()
        chartSales.Series.Clear()
        Dim salesSeries As New Series("Sales")
        salesSeries.ChartType = SeriesChartType.Column
        Using conn As MySqlConnection = DBConnection.GetConnection()
            conn.Open()
            Dim query As String = "SELECT DATE_FORMAT(Date, '%b') AS Month, SUM(TotalAmount) AS Total FROM Sales GROUP BY Month ORDER BY MIN(Date)"
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        salesSeries.Points.AddXY(reader("Month").ToString(), Convert.ToDecimal(reader("Total")))
                    End While
                End Using
            End Using
        End Using
        chartSales.Series.Add(salesSeries)
        chartSales.ChartAreas(0).AxisX.Title = "Month"
        chartSales.ChartAreas(0).AxisY.Title = "Sales Amount"
    End Sub

    Private Sub LoadCategoryPieChart()
        chartCategories.Series.Clear()
        Dim categorySeries As New Series("Categories")
        categorySeries.ChartType = SeriesChartType.Pie
        Using conn As MySqlConnection = DBConnection.GetConnection()
            conn.Open()
            Dim query As String = "SELECT Category, COUNT(*) AS Count FROM Products GROUP BY Category"
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        categorySeries.Points.AddXY(reader("Category").ToString(), Convert.ToInt32(reader("Count")))
                    End While
                End Using
            End Using
        End Using
        chartCategories.Series.Add(categorySeries)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        MainDashboard.Show()
    End Sub
End Class