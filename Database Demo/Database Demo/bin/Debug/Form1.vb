Public Class frmProfile
    Private Sub ProfileBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProfileBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProfileBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDataSet)
    End Sub

    Private Sub frmProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDataSet.Profile' table. You can move, or remove it, as needed.
        Me.ProfileTableAdapter.Fill(Me.StudentDataSet.Profile)
    End Sub

    Private Sub btnMoveFirst_Click(sender As Object, e As EventArgs) Handles btnMoveFirst.Click
        Me.ProfileBindingSource.MoveFirst()

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Me.ProfileBindingSource.MovePrevious()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.ProfileBindingSource.MoveNext()
    End Sub

    Private Sub btnMoveLast_Click(sender As Object, e As EventArgs) Handles btnMoveLast.Click
        Me.ProfileBindingSource.MoveLast()
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Me.ProfileBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Me.ProfileBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(StudentDataSet)
            MessageBox.Show("Data have been recorded")
        Catch ex As Exception
            MessageBox.Show("An error occured! Please try again.")
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.ProfileBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'optional
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Me.ProfileBindingSource.Filter = "MatricNo = '" & txtSearch.Text & "'"
        ProfileBindingSource.DataSource = "SELECT * FROM Profile WHERE " & "MatricNo = '" & txtSearch.Text & "'"
    End Sub
End Class
