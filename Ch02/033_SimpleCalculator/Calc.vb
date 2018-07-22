Imports System.Globalization.NumberFormatInfo

Friend Module Calc

    Private prevValue As Decimal
    Private currentValue As Decimal
    'Public result As Decimal
    Public oprt As String
    Property Current As Decimal
        Get
            Return currentValue
        End Get
        Set(value As Decimal)
            currentValue = value
        End Set
    End Property

    Private Property Prev As Decimal
        Get
            Return prevValue
        End Get
        Set(value As Decimal)
            prevValue = value
        End Set
    End Property

    Sub Calc()
        Select Case oprt
            Case "+"
                Current = Decimal.Add(Prev, Current)
            Case "-"
                Current = Decimal.Subtract(Prev, Current)
            Case "*"
                Current = Decimal.Multiply(Prev, Current)
            Case "/"
                Current = Decimal.Divide(Prev, Current)
            Case "%"
                Current = Decimal.Divide(Current, 100)
            Case "sqrt"
                Current = Math.Sqrt(Current)
            Case "sqr"
                Current = Math.Pow(Current, 2)
            Case "/"
                Current = Decimal.Divide(1, Current)
        End Select
    End Sub

End Module
