Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1
    Dim inttotalCharge As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RBNormalCar.CheckedChanged
        If RBNormalCar.Checked Then
            gbCoupon.Visible = False

        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RBYes.CheckedChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles gbCoupon.Enter

    End Sub

    Private Sub RBLuxuryCar_CheckedChanged(sender As Object, e As EventArgs) Handles RBLuxuryCar.CheckedChanged
        If RBLuxuryCar.Checked Then
            gbCoupon.Visible = True

        End If
    End Sub

    Private Sub txtFee_TextChanged(sender As Object, e As EventArgs) Handles txtFee.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click



        If RBLuxuryCar.Checked = True Then
            If RBYes.Checked Then
                inttotalCharge = 55 + 10
            Else
                inttotalCharge = 55 + 30

            End If
        Else
            inttotalCharge = 55

        End If

        txtFee.Text = inttotalCharge


    End Sub
End Class
