Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dbSales As Double
        Dim dbCommission As Double
        Dim dbAdditional As Double
        Dim dbTotal As Double

        If String.IsNullOrEmpty(txtSales.Text) OrElse Not Double.TryParse(txtSales.Text, dbSales) Then
            MessageBox.Show("Please input your sales", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        dbSales = Val(txtSales.Text)

        Select Case dbSales
            Case < 6000
                dbCommission = 0.1 * dbSales
            Case 6000 To 29999.99
                dbCommission = 600 + (0.13 * (dbSales - 6000))
            Case Else
                dbCommission = 3720 + (0.14 * (dbSales - 30000))
        End Select


        If rbOver.Checked Then
            If dbSales >= 10000 Then
                dbAdditional = 500
            End If
        End If

        If rbTrue.Checked Then
            dbAdditional = dbAdditional + 700
        End If

        If dbSales <> 0 Then
            dbTotal = dbCommission + dbAdditional
            txtAdditional.Text = dbAdditional
            txtCommission.Text = dbCommission
            txtTotal.Text = dbTotal
        Else
            txtAdditional.Text = 0
            txtCommission.Text = 0
            txtTotal.Text = 0
        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear text boxes
        txtSales.Clear()
        txtAdditional.Clear()
        txtCommission.Clear()
        txtTotal.Clear()

        ' Uncheck radio buttons
        rbOver.Checked = False
        rbTrue.Checked = False
    End Sub
End Class
