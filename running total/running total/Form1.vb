Public Class Form1

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        Const intNUM_DAYS As Integer = 5        ' The number of days
        Dim intCount As Integer = 1          ' Loop counter 
        Dim decSales As Decimal = 0         ' To hold daily sales 
        Dim decTotal As Decimal = 0         ' to hold total sales 
        Dim strInput As String                  ' To hold string input 

        Do While intCount <= intNUM_DAYS
            strInput = InputBox("Enter the sales for day ") & intCount.ToString()
            If Decimal.TryParse(strInput, decSales) Then
                'decTotal =+ decSales
                decTotal += decSales
                'intCount += 1 shortcut version
                intCount += 1
            Else
                MessageBox.Show("Enter a numeric value")
            End If
        Loop
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
