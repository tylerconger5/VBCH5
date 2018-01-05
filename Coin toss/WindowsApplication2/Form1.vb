Public Class Form1

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        ' Dim result As Double
        If radioC.Checked = True Then
            CalcSideC(CDbl(txtA.text), CDbl(txtB.Text))
        End If
    End Sub

