' Lindsay Allen (Jackson)
' 05/18/21
' Home Rental Investment

' Presentation Tier

Public Class homeRentalInvestmentForm
    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click

        Dim rentalHome As New RentalHome(nameTextbox.Text, rentalYearsTextbox.Text, homePriceTextbox.Text, rentalCityCombobox.Text)

        rentalHome.RecordValues()
        rentalHome.DisplayReturnValue()


    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click

        Close()

    End Sub
End Class
