Public Class Form1
    Dim packageCharge,
        totalAdditionalCharge,
        totalCharge As Double

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbCMC.CheckedChanged

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        totalAdditionalCharge = 0
        totalCharge = 0

        If rbBasic.Checked Then
            packageCharge = 24.99
        ElseIf rbSilver.Checked Then
            packageCharge = 42.99
        ElseIf rbGold.Checked Then
            packageCharge = 84.99
        ElseIf rbDiamond.Checked Then
            packageCharge = 99.99
        End If

        If cbCMC.Checked Then
            totalAdditionalCharge += 9.5
        End If
        If cbHMC.Checked Then
            totalAdditionalCharge += 9.5
        End If
        If cbSMC.Checked Then
            totalAdditionalCharge += 10.5
        End If
        If cbLS.Checked Then
            totalAdditionalCharge += 6.0
        End If

        totalCharge = packageCharge + totalAdditionalCharge

        txtPackageCharge.Text = "$" + packageCharge.ToString("F2")
        txtAdditionalCharges.Text = "$" + totalAdditionalCharge.ToString("F2")
        txtTotalCharge.Text = "$" + totalCharge.ToString("F2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtPackageCharge_TextChanged(sender As Object, e As EventArgs) Handles txtPackageCharge.TextChanged

    End Sub
End Class
