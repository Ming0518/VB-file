Public Class Form1
    Dim blackNum,
        navyNum,
        redNum,
        totalNum As Integer
    Dim discount,
        oriAmount,
        totalPrice As Double
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        discount = 0
        oriAmount = 0
        totalPrice = 0

        If (txtBlackNum.Text = "") Then
            txtBlackNum.Text = "0"
        End If
        If (txtNavyNum.Text = "") Then
            txtNavyNum.Text = "0"
        End If
        If (txtRedNum.Text = "") Then
            txtRedNum.Text = "0"
        End If

        If Not (Integer.TryParse(txtBlackNum.Text, blackNum) And Integer.TryParse(txtNavyNum.Text, navyNum) And Integer.TryParse(txtRedNum.Text, redNum)) Then
            lblWarning.Text = "Something went wrong here!"
            Return
        End If

        totalNum = blackNum + navyNum + redNum
        oriAmount = blackNum * 45.99 + (navyNum + redNum) * 39.99

        If rbCC.Checked Then
            discount = oriAmount * 0.1
        ElseIf totalNum >= 2 Then
            discount = oriAmount * 0.05
        Else
            discount = 0
        End If
        totalPrice = oriAmount - discount

        txtTotalJacket.Text = totalNum.ToString
        txtOriAmount.Text = oriAmount.ToString("F2")
        txtDiscount.Text = discount.ToString("F2")
        txtTotalAmount.Text = totalPrice.ToString("F2")
    End Sub

    Private Sub txtBlackNum_TextChanged(sender As Object, e As EventArgs) Handles txtBlackNum.TextChanged
        If txtBlackNum.Text <> "" And Not IsNumeric(txtBlackNum.Text) Then
            lblWarning.Text = "Please input numeric value to black jacket number!"
            Return
        Else
            lblWarning.Text = ""
            Return
        End If
        If Integer.TryParse(txtBlackNum.Text, blackNum) And (blackNum < 0) Then
            lblWarning.Text = "Please input proper number of black jacket"
            Return
        Else
            lblWarning.Text = ""
            Return
        End If
    End Sub

    Private Sub txtNavyNum_TextChanged(sender As Object, e As EventArgs) Handles txtNavyNum.TextChanged
        If txtNavyNum.Text <> "" And Not IsNumeric(txtNavyNum.Text) Then
            lblWarning.Text = "Please input numeric value to navy jacket number!"
            Return
        Else
            lblWarning.Text = ""
            Return
        End If
        If Integer.TryParse(txtNavyNum.Text, navyNum) And (navyNum < 0) Then
            lblWarning.Text = "Please input proper number of navy jacket"
            Return
        Else
            lblWarning.Text = ""
            Return
        End If
    End Sub

    Private Sub txtRedNum_TextChanged(sender As Object, e As EventArgs) Handles txtRedNum.TextChanged
        If txtRedNum.Text <> "" And Not IsNumeric(txtRedNum.Text) Then
            lblWarning.Text = "Please input numeric value to red jacket number!"
            Return
        Else
            lblWarning.Text = ""
            Return
        End If
        If Integer.TryParse(txtRedNum.Text, redNum) And (redNum < 0) Then
            lblWarning.Text = "Please input proper number of red jacket"
            Return
        Else
            lblWarning.Text = ""
            Return
        End If
    End Sub

    Private Sub lblTotalAmount_Click(sender As Object, e As EventArgs) Handles lblTotalAmount.Click
    End Sub
End Class
