Public Class Form2

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim intCount As Integer
        Dim intCount1 As Integer
        Dim rand As New Random
        For intCount = 16 To 360
            picCar1.Left = intCount
        Next
        For intCount = 16 To rand.Next(270) + 500
            picCar2.Left = intCount 1 
        Next
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click

    End Sub

    Private Sub picCar1_Click(sender As Object, e As EventArgs) Handles picCar1.Click

    End Sub
End Class