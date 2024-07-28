Public Class AddCar
    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub UPGrant_Click(sender As Object, e As EventArgs) Handles UPGrant.Click
        Dim openFileDialog As New OpenFileDialog()

        ' Set filter options and filter index
        openFileDialog.Filter = "All Files (*.*)|*.*|Text Files (*.txt)|*.txt"
        openFileDialog.FilterIndex = 1
        openFileDialog.Multiselect = False

        ' Call the ShowDialog method to show the dialog box
        Dim result As DialogResult = openFileDialog.ShowDialog()

        ' Process input if the user clicked OK
        If result = DialogResult.OK Then
            ' Get the selected file name and display in a TextBox
            Dim filePath As String = openFileDialog.FileName
            MessageBox.Show("Selected file: " & filePath)

            ' Logic for uploading the file can be added here
        End If
    End Sub

    Private Sub UPCar_Click(sender As Object, e As EventArgs) Handles UPCar.Click
        Dim openFileDialog As New OpenFileDialog()

        ' Set filter options and filter index
        openFileDialog.Filter = "All Files (*.*)|*.*|Text Files (*.txt)|*.txt"
        openFileDialog.FilterIndex = 1
        openFileDialog.Multiselect = False

        ' Call the ShowDialog method to show the dialog box
        Dim result As DialogResult = openFileDialog.ShowDialog()

        ' Process input if the user clicked OK
        If result = DialogResult.OK Then
            ' Get the selected file name and display in a TextBox
            Dim filePath As String = openFileDialog.FileName
            MessageBox.Show("Selected file: " & filePath)

            ' Logic for uploading the file can be added here
        End If
    End Sub

    Private Sub UPInsurance_Click(sender As Object, e As EventArgs) Handles UPInsurance.Click
        Dim openFileDialog As New OpenFileDialog()

        ' Set filter options and filter index
        openFileDialog.Filter = "All Files (*.*)|*.*|Text Files (*.txt)|*.txt"
        openFileDialog.FilterIndex = 1
        openFileDialog.Multiselect = False

        ' Call the ShowDialog method to show the dialog box
        Dim result As DialogResult = openFileDialog.ShowDialog()

        ' Process input if the user clicked OK
        If result = DialogResult.OK Then
            ' Get the selected file name and display in a TextBox
            Dim filePath As String = openFileDialog.FileName
            MessageBox.Show("Selected file: " & filePath)

            ' Logic for uploading the file can be added here
        End If
    End Sub
End Class