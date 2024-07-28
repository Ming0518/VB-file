Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dbNumber As Double
        Dim dbTotal As Double

        If String.IsNullOrEmpty(txtInput.Text) OrElse Not Double.TryParse(txtInput.Text, dbNumber) Then
            MessageBox.Show("Please input a valid number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        dbTotal = 1
        dbNumber = Val(txtInput.Text)

        Do While dbNumber > 0
            dbTotal = dbNumber * dbTotal
            dbNumber = dbNumber - 1
        Loop

        txtFactor.Text = dbTotal
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInput.Text = ""
        txtFactor.Text = ""
    End Sub
End Class
