Imports System.IO


Public Class Form1
    Private selectedRowIndex As Integer = -1

    Private Sub btnWriteToFile_Click(sender As Object, e As EventArgs) Handles btnWriteToFile.Click
        Dim filePath As String = "C:\Users\user\Desktop\Project\test.txt"

        If File.Exists(filePath) Then
            ' Read all lines into a list
            Dim lines As List(Of String) = File.ReadAllLines(filePath).ToList()

            ' Modify the list (e.g., append new text)
            lines.Add("This is an additional line.")

            ' Write the updated content back to the file
            Using writer As New StreamWriter(filePath, False)
                For Each line As String In lines
                    writer.WriteLine(line)
                Next
            End Using
        Else
            Console.WriteLine("File does not exist.")
        End If
    End Sub

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

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim newRecord = txtTest.Text.Trim

        ' Check if the text box is not empty
        If newRecord <> "" Then
            ' Add the new record to the DataGridView
            dgvRecord.Rows.Add(newRecord)
            txtTest.Clear()
        Else
            MessageBox.Show("Please enter a record before adding.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dgvRecord.SelectedRows.Count > 0 Then
            ' Remove the selected row
            dgvRecord.Rows.RemoveAt(dgvRecord.SelectedRows(0).Index)
        Else
            MessageBox.Show("Please select a record to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button2_Click()
        If selectedRowIndex <> -1 Then
            Dim editedRecord As String = txtRes.Text.Trim()

            ' Check if the text box is not empty
            If editedRecord <> "" Then
                ' Update the selected row
                dgvRecord.Rows(selectedRowIndex).Cells(0).Value = editedRecord
                txtRes.Clear()
                selectedRowIndex = -1
            Else
                MessageBox.Show("Please enter a record before editing.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Please select a record to edit.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub dgvRecords_SelectionChanged(sender As Object, e As EventArgs) Handles dgvRecord.SelectionChanged
        ' Check if a row is selected
        If dgvRecord.SelectedRows.Count > 0 Then
            selectedRowIndex = dgvRecord.SelectedRows(0).Index
        End If
    End Sub
End Class
