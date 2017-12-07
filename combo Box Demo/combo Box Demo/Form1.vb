Public Class Form1

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        txtCountry.Text = cboCountries.Text
        txtPlau.Text = cboPlays.Text
        txtArtist.Text = cboArtisits.Text
    End Sub
End Class
