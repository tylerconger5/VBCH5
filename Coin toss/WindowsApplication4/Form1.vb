Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim rand As New Random
        Dim intCount As Integer
        Const intMAX_SUBSCRIPT = 0
        Dim intNumbers(intMAX_SUBSCRIPT) As Integer
        For intCount = 0 To intMAX_SUBSCRIPT
            intNumbers.text(intCount) = rand.Next(100)

        Next

    End Sub
End Class
