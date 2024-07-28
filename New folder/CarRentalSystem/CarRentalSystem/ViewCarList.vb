Public Class ViewCarList
    Private Sub btnAddRental_Click(sender As Object, e As EventArgs) Handles btnAddCar.Click
        AddCar.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub

    Private Sub btnAddRental_Click_1(sender As Object, e As EventArgs) Handles btnAddRental.Click
        AddRental.Show()
    End Sub

    Private Sub btnViewRental_Click(sender As Object, e As EventArgs) Handles btnViewRental.Click
        ViewRental.Show()
    End Sub

    Private Sub btnViewCar_Click(sender As Object, e As EventArgs) Handles btnViewCar.Click
        ViewCar.Show()
    End Sub
End Class