Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        If rbMember.Checked Then
            txtTotal.Text = 100
        End If

        If rbNonMember.Checked Then
            If rbMonThur.Checked Then
                txtTotal.Text = 150
            ElseIf rbFriSun.Checked Then
                txtTotal.Text = 200
            Else
                MessageBox.Show("Please Choose The Day", "Day Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub rbNonMember_CheckedChanged(sender As Object, e As EventArgs) Handles rbNonMember.CheckedChanged
        If rbNonMember.Checked Then
            groupBoxDays.Visible = True
            txtTotal.Clear()
        End If
    End Sub

    Private Sub rbMember_CheckedChanged(sender As Object, e As EventArgs) Handles rbMember.CheckedChanged
        If rbMember.Checked Then
            groupBoxDays.Visible = False
            rbMonThur.Checked = False
            rbFriSun.Checked = False
            txtTotal.Clear()
        End If
    End Sub
End Class
