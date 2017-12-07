Public Class Form1

    Private Sub btndone_Click(sender As Object, e As EventArgs) Handles btndone.Click
        Dim dbldistanceTraveled As Double, dblx As Double

        dblx = CDbl(0.0)
        Do While dblx < txtHours.Text
            dblx = dblx 1 
            dbldistanceTraveled = (txtSpeed.Text) * dblx
            listResult.Items.Add(dblx.ToString + "hours mean they traveled " + dblDistanceTraveled.ToString)


        Loop
    End Sub
End Class
