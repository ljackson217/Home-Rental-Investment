' Lindsay Allen (Jackson)
' 05/18/21
' Home Rental Investment

' RentalHome Class - Base class

Public Class RentalHome

    ' Class variables
    Protected name As String
    Protected numRentalYears As Integer
    Protected homePrice As Decimal
    Protected rentalCity As String


    ' Constructor
    Sub New(ByVal name As String, ByVal numRentalYears As String, ByVal homePrice As String, ByVal rentalCity As String)

        Try

            ' Verifies that no textfields are left blank
            If (name IsNot "") Then
                Me.name = name
            Else
                MessageBox.Show("Please enter a valid name.")
            End If


            If (numRentalYears IsNot "") Then
                Me.numRentalYears = Convert.ToInt16(numRentalYears)
            Else
                MessageBox.Show("Please enter a valid number of rental years.")
            End If


            If (rentalCity IsNot "") Then
                Me.rentalCity = rentalCity
            Else
                MessageBox.Show("Please select a rental city.")
            End If


            ' Requires homePrice to be at least 10,000
            If (homePrice >= 10000 And homePrice IsNot "") Then
                Me.homePrice = Convert.ToDecimal(homePrice)
            Else
                MessageBox.Show("Home price must be at least $10,000")
            End If


        Catch ex As Exception

        End Try

    End Sub

    ' Function calculates the return on investment based on the city selected
    Function CalculateReturnValue() As Decimal

        Select Case rentalCity

            Case "Memphis"
                Return Me.numRentalYears * Me.homePrice * 0.1238

            Case "Ocala"
                Return Me.numRentalYears * Me.homePrice * 0.1023

            Case "Atlanta"
                Return Me.numRentalYears * Me.homePrice * 0.097

            Case "Phoenix"
                Return Me.numRentalYears * Me.homePrice * 0.0877

            Case "Ogden"
                Return Me.numRentalYears * Me.homePrice * 0.0844

        End Select


    End Function

    ' Writes information to file
    Sub RecordValues()

        Dim SalesFile = New RentalHomeSalesFile(Me.name, Me.numRentalYears, Me.homePrice, Me.rentalCity, CalculateReturnValue())
        SalesFile.WriteToRecordFile()

    End Sub

    ' Displays the formatted calculation of CalculateReturnValue function as the text field for returnOutputLabel
    Sub DisplayReturnValue()

        homeRentalInvestmentForm.returnOutputLabel.Text = CalculateReturnValue().ToString("C")

    End Sub

End Class
