Public Class Form1
    Dim order,
        shippingFee,
        orderAmount As Double

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtOrder.TextChanged
        If Double.TryParse(txtOrder.Text, order) And order >= 100 Then
            lblFSCode.Visible = True
            txtSFC.Visible = True
        Else
            lblFSCode.Visible = False
            txtSFC.Visible = False
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim orderText As String = txtOrder.Text

        If orderText = "" Then
            lblWarning.Text = "Please input order!"
            Return
        ElseIf Not IsNumeric(orderText) Then
            lblWarning.Text = "Please input proper order!"
            Return
        End If
        lblWarning.Text = ""


        If Not Double.TryParse(orderText, order) Then
            lblWarning.Text = "Something went wrong here"
        End If

        If order > 100 And txtSFC.Text = "SELFIEYA" Then
            shippingFee = 0.0
        Else
            shippingFee = 5.0
        End If

        txtSF.Text = shippingFee
        txtOA.Text = order + shippingFee
    End Sub

    Private Sub lblFSCode_Click(sender As Object, e As EventArgs)

    End Sub
End Class
