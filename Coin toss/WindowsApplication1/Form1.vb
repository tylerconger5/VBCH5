Public Class Form1

    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        Dim intShoot As Integer
        Dim rand As New Random

        intShoot = rand.Next(3)

        If intShoot = 0 Then
            lblResult.Text = "Rock Tie"
        ElseIf intShoot = 1 Then
            lblResult.Text = "Paper You Win"
        ElseIf intShoot = 2 Then
            lblResult.Text = "Scissors You Lose"
        End If

    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        Dim intShoot As Integer
        Dim rand As New Random

        intShoot = rand.Next(3)

        If intShoot = 0 Then
            lblResult.Text = "Rock You Lose"
        ElseIf intShoot = 1 Then
            lblResult.Text = "Paper You Win"
        ElseIf intShoot = 2 Then
            lblResult.Text = "Scissors Tie"
        End If
    End Sub

    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        Dim intShoot As Integer
        Dim rand As New Random

        intShoot = rand.Next(3)

        If intShoot = 0 Then
            lblResult.Text = "Rock You Win"
        ElseIf intShoot = 1 Then
            lblResult.Text = "Paper Tie"
        ElseIf intShoot = 2 Then
            lblResult.Text = "Scissors You Lose"
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
