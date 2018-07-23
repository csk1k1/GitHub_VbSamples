Imports System.Globalization.NumberFormatInfo

Friend Module Calc

    'Private preVal As Decimal
    'Private currentVal As Decimal
    'Public result As Decimal

    Property Current As Decimal
    Property Prev As Decimal
    Private _oprt As String = String.Empty

    'Property Current As Decimal
    '    Get
    '        Return currentVal
    '    End Get
    '    Set(value As Decimal)
    '        currentVal = value
    '    End Set
    'End Property

    'Property Prev As Decimal
    '    Get
    '        Return preVal
    '    End Get
    '    Set(value As Decimal)
    '        preVal = value
    '    End Set
    'End Property

    Property Op As String
        Get
            Return _oprt
        End Get
        Set(value As String)
            If Not Len(_oprt) > 0 Then
                _oprt = value
            End If
        End Set
    End Property

    Sub SetExpression()

    Sub SimpleCalc(ByVal oprt As String)
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
                Current = Decimal.Parse(Math.Sqrt(Current))
            Case "sqr"
                Current = Decimal.Parse(Math.Pow(Current, 2))
            Case "reciprocal"
                Current = Decimal.Divide(1, Current)
        End Select
    End Sub
End Module
