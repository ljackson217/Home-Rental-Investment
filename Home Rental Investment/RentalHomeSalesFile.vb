' Lindsay Allen (Jackson)
' 05/19/21
' Rental Home Investment

' RentalHomeSalesFile Class - StreamWriter

Public Class RentalHomeSalesFile

    ' Class variables
    Private name As String
    Private numRentalYears As String
    Private homePrice As String
    Private rentalCity As String
    Private returnAmount As Decimal

    ' Constructor
    Sub New(ByVal name As String, ByVal years As String, ByVal price As String, ByVal city As String, ByVal amount As Decimal)

        ' Assigns arguments to class variables
        Me.name = name
        numRentalYears = years
        homePrice = price
        rentalCity = city
        returnAmount = amount

    End Sub


    ' Procedure opens the rentalRecords.txt file and records rental home data
    Sub WriteToRecordFile()

        Dim fileLocation As String = "rentalRecords.txt"

        Try
            Dim objWriter As IO.StreamWriter = IO.File.AppendText(fileLocation)

            objWriter.Write(Me.name & ", ")
            objWriter.Write(numRentalYears & ", ")
            objWriter.Write(homePrice & ", ")
            objWriter.Write(rentalCity & ", ")
            objWriter.WriteLine(returnAmount)
            objWriter.Close()

        Catch ex As Exception
            MessageBox.Show("File cannot be found")
            Application.Exit()

        End Try

    End Sub

End Class
