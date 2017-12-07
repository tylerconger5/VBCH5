Public Class btnToss
    Dim intSideUp As Integer 'To indicate which side is up
    Dim rand As New Random   ' Random number generator 

    Private Sub btnT_Click(sender As Object, e As EventArgs) Handles btnT.Click
        ' Get a random number in the range of 0 through 1. 
        ' 0 means tails up, and 1 means heads up.
        intSideUp = rand.Next(2)

        ' Display the side that is up.
        If intSideUp = 0 Then
            ' 0 means tails is up, so display the tails 
            ' image and hide the heads image.
            picTails.Visible = True
            picHeads.Visible = False
            tailTotal = 1 + headsTotal
        Else
            ' 1 means heads is up, so dispaly the heads
            'image and hide the tails image 
            picHeads.Visible = True
            picTails.Visible = False
            HeadsTotal = 1 + headsTotal

        End If

        lblHead.Text = HeadsTotal.ToString
        lblTails.Text = tailTotal.ToString

    End Sub

    Private Sub btnToss_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
