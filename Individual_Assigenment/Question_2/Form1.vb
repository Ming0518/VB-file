Public Class Form1
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        Dim description As String = txtDescription.Text
        Dim yearOfPurchase As Integer = Integer.Parse(txtYear.Text)
        Dim cost As Decimal = Decimal.Parse(txtCosts.Text)
        Dim estimatedLife As Integer = Integer.Parse(txtLife.Text)
        Dim depreciationMethod As String

        If rbStaright.Checked Then
            depreciationMethod = "Straight-Line"
        ElseIf rbDouble.Checked Then
            depreciationMethod = "Double-Declining"
        Else
            MessageBox.Show("Please select a depreciation method.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        GenerateDepreciationSchedule(description, yearOfPurchase, cost, estimatedLife, depreciationMethod)
    End Sub

    Private Sub GenerateDepreciationSchedule(description As String, yearOfPurchase As Integer, cost As Decimal, estimatedLife As Integer, method As String)
        ' Clear previous data
        dgvData.Rows.Clear()
        dgvData.Columns.Clear()

        ' Set up DataGridView columns
        dgvData.Columns.Add("Year", "Year")
        dgvData.Columns.Add("ValueAtBeginning", "Value at the Beginning of Year")
        dgvData.Columns.Add("AmountDepreciation", "Amount Depreciation During Year")
        dgvData.Columns.Add("TotalDepreciation", "Total Depreciation to End of Year")

        Dim year As Integer = yearOfPurchase
        Dim valueAtBeginning As Decimal = cost
        Dim totalDepreciation As Decimal = 0

        For i As Integer = 1 To estimatedLife
            Dim amountDepreciation As Decimal

            If method = "Straight-Line" Then
                amountDepreciation = cost / estimatedLife
            ElseIf method = "Double-Declining" Then
                amountDepreciation = (2 / estimatedLife) * valueAtBeginning
                If i = estimatedLife Then
                    amountDepreciation = valueAtBeginning ' Depreciate remaining value in the last year
                End If
            End If

            totalDepreciation += amountDepreciation

            ' Add row to DataGridView
            dgvData.Rows.Add(year, valueAtBeginning.ToString("F2"), amountDepreciation.ToString("F2"), totalDepreciation.ToString("F2"))

            ' Update for next iteration
            valueAtBeginning -= amountDepreciation
            year += 1
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDescription.Clear()
        txtYear.Clear()
        txtCosts.Clear()
        txtLife.Clear()

        ' Clear radio buttons
        rbStaright.Checked = False
        rbDouble.Checked = False

        ' Clear the DataGridView
        dgvData.Rows.Clear()
        dgvData.Columns.Clear()
    End Sub
End Class
