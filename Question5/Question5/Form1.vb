Public Class Form1
    Const ChildTicket As Decimal = 8D
    Const AdultTicket As Decimal = 12D
    Const SeniorTicketDiscount As Decimal = 0.5D
    Const InternationalMovieExtra As Decimal = 0.2D
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBook.Click

        Dim intnumCustomers As Integer
        Dim isInternationalMovie As Boolean
        Dim totalPayment As Decimal = 0D

        intnumCustomers = CInt(txtNumCustomers.Text)

        isInternationalMovie = rbtnInternational.Checked

        For i As Integer = 1 To intnumCustomers

            Dim age As Integer = CInt(InputBox("Enter the age of customer " & i & ":"))


            Dim ticketPrice As Decimal
            If age < 4 Then
                ticketPrice = 0D
            ElseIf age >= 4 AndAlso age <= 12 Then
                ticketPrice = ChildTicket
            ElseIf age >= 13 AndAlso age < 60 Then
                ticketPrice = AdultTicket
            Else
                ticketPrice = AdultTicket * SeniorTicketDiscount
            End If

            If isInternationalMovie Then
                ticketPrice += ticketPrice * InternationalMovieExtra
            End If
            totalPayment += ticketPrice
        Next

        txtTotalPayment.Text = "RM" & totalPayment.ToString("F2")


    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
