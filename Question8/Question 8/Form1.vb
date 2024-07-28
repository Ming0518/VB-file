Public Class Form1
    Const WholesalerPrice1To50 As Decimal = 15D
    Const WholesalerPrice51To150 As Decimal = 13D
    Const WholesalerPriceOver150 As Decimal = 10D

    ' Constants for retailer prices
    Const RetailerPrice1To25 As Decimal = 22D
    Const RetailerPriceOver25 As Decimal = 18D
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim unitsOrdered As Integer
        Dim customerStatus As String
        Dim totalCost As Decimal = 0D

        ' Get the number of units ordered from the TextBox
        unitsOrdered = CInt(txtUnitsOrdered.Text)

        ' Determine the customer status based on the selected radio button
        If rbtnWholesaler.Checked Then
            customerStatus = "Wholesaler"
        ElseIf rbtnRetailer.Checked Then
            customerStatus = "Retailer"
        Else
            MessageBox.Show("Please select the customer status.")
            Exit Sub
        End If

        ' Calculate the total cost based on customer status and units ordered
        If customerStatus = "Wholesaler" Then
            If unitsOrdered >= 1 AndAlso unitsOrdered <= 50 Then
                totalCost = unitsOrdered * WholesalerPrice1To50
            ElseIf unitsOrdered >= 51 AndAlso unitsOrdered <= 150 Then
                totalCost = unitsOrdered * WholesalerPrice51To150
            Else
                totalCost = unitsOrdered * WholesalerPriceOver150
            End If
        ElseIf customerStatus = "Retailer" Then
            If unitsOrdered >= 1 AndAlso unitsOrdered <= 25 Then
                totalCost = unitsOrdered * RetailerPrice1To25
            Else
                totalCost = unitsOrdered * RetailerPriceOver25
            End If
        End If

        ' Display the result
        txtResult.Text = "Customer Status: " & customerStatus & Environment.NewLine &
                         "Units Ordered: " & unitsOrdered & Environment.NewLine &
                         "Total Cost: $" & totalCost.ToString("F2")
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtResult_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub txtUnitsOrdered_TextChanged(sender As Object, e As EventArgs) Handles txtUnitsOrdered.TextChanged
    End Sub
End Class
