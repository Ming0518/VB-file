Public Class Dashboard
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnViewCarList_Click(sender As Object, e As EventArgs) Handles btnViewCarList.Click
        ViewCarList.Show
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        History.Show()

    End Sub
End Class