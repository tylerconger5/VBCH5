Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

    End Sub

    Private Sub btnNumbers_Click(sender As Object, e As EventArgs) Handles btnNumbers.Click
        Dim strUserInput
        Dim IntUserInput As Integer
        Dim i As Integer
        strUserInput = InputBox("Enter a positive integer value", "Input Needed", 10)
        If strUserInput <> String.Empty Then
            Try
                intUserInput = CInt(strUserInput)
                If IntUserInput < 0 Then
                    MessageBox.Show("negative numbers are not accepted.")

                End If
            Catch ex As Exception
                MessageBox.Show("Quantity amount must be numeric.")

            End Try
            'Show messagebox,
        Else
            'intUserInput = (IntUserPut + i)
            InputBox(MessageBox.Show("sum of Numbers", "The sum of numbers" & (i + IntUserInput), MessageBoxButtons.OK))

        End If

    End Sub
End Class
