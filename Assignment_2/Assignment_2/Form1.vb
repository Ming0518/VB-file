Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs)
        If rbMember.Checked Then
            txtTotal.Text = 100
        End If

        If rbNonMember.Checked Then
            If rbMonThur.Checked Then
                txtTotal.Text = 150

            ElseIf rbFriSun.Checked Then
                txtTotal.Text = 200
            End If
        End If

    End Sub

End Class
