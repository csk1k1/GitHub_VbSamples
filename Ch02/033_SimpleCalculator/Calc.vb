Imports System.Globalization.NumberFormatInfo

Friend Module Calc

    'Private preVal As Decimal
    'Private currentVal As Decimal
    'Public result As Decimal

    Property Current As Decimal
    Property Prev As Decimal
    Property StrCurrent As String = ""
    Property StrExp As String = ""
    Property StrExpPrev As String = ""
    Property StrExpCur As String = ""

    Private _oprt As String = String.Empty
    Public oprts As String() = {"+", "-", "*", "/", "%", "sqrt", "sqr", "reciprocal"}
    Property Oprt As String
        Get
            Return _oprt
        End Get
        Set(value As String)
            If Not Len(_oprt) > 0 Then
                _oprt = value
            End If
        End Set
    End Property

    Function Divide100(ByVal d As Decimal) As Decimal
        Try
            Divide100 = Decimal.Divide(d, 100)
        Catch ex As Exception
            StrCurrent = "溢出"
            Return Nothing
        End Try
    End Function

    Function Sqrt(ByVal d As Decimal) As Decimal
        Try
            Sqrt = Decimal.Parse(Math.Sqrt(d))
        Catch ex As Exception
            StrCurrent = IIf(d < 0, "Invalid Data", "溢出")
            Return Nothing
        End Try
    End Function

    Function Sqr(ByVal d As Decimal) As Decimal
        Try
            Sqr = Decimal.Parse(Math.Pow(d, 2))
        Catch ex As Exception
            StrCurrent = "溢出"
            Return Nothing
        End Try
    End Function

    Function Reciprocal(ByVal d As Decimal) As Decimal
        Try
            Reciprocal = Decimal.Divide(1, d)
        Catch ex As Exception
            StrCurrent = IIf(d = 0, "除数不能为零", "溢出")
            Return Nothing
        End Try
    End Function

    Function Add(ByVal a As Decimal, ByVal b As Decimal) As Decimal
        Try
            Add = Decimal.Add(a, b)
        Catch ex As Exception
            StrCurrent = "溢出"
            Return Nothing
        End Try
    End Function

    Function Subtract(ByVal a As Decimal, ByVal b As Decimal) As Decimal
        Try
            Return Decimal.Subtract(a, b)
        Catch ex As Exception
            StrCurrent = "溢出"
            Return Nothing
        End Try
    End Function

    Function Multiply(ByVal a As Decimal, ByVal b As Decimal) As Decimal
        Try
            Return Decimal.Multiply(a, b)
        Catch ex As Exception
            StrCurrent = "溢出"
            Return Nothing
        End Try
    End Function

    Function Divide(ByVal a As Decimal, ByVal b As Decimal) As Decimal
        Try
            Return Decimal.Divide(a, b)
        Catch ex As Exception
            StrCurrent = IIf(b = 0, "除数不能为零", "溢出")
            Return Nothing
        End Try
    End Function

    'Sub OprtHandler(ByVal strO As String)
    '    Try
    '        If Array.IndexOf(oprts, strO) >= 0 Then
    '            Select Case strO
    '                Case "%"
    '                    StrExpCur = "(" + Current.ToString + ")/100"
    '                    StrExp = StrExpPrev + StrExpCur
    '                    Current = SimpleCalc("%")

    '                Case "sqrt"

    '                Case "sqr"

    '                Case "reciprocal"
    '                    Oprt = String.Empty
    '                    Prev = Decimal.Zero
    '                    SimpleCalc(strO)
    '                Case "+"

    '                Case "-"

    '                Case "*"

    '                Case "/"
    '                    If Oprt.Length > 0 Then
    '                        SimpleCalc(Oprt)
    '                        Prev = Current
    '                        Current = 0
    '                        Oprt = strO
    '                    Else
    '                        Prev = Current
    '                        Current = 0
    '                        Oprt = strO
    '                    End If
    '            End Select
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Function SimpleCalc(ByVal strO As String)
    '    Select Case strO
    '        Case "+"
    '            SimpleCalc = Decimal.Add(Prev, Current)
    '        Case "-"
    '            SimpleCalc = Decimal.Subtract(Prev, Current)
    '        Case "*"
    '            SimpleCalc = Decimal.Multiply(Prev, Current)
    '        Case "/"
    '            SimpleCalc = Decimal.Divide(Prev, Current)
    '        Case "%"
    '            SimpleCalc = Decimal.Divide(Current, 100)
    '        Case "sqrt"
    '            SimpleCalc = Decimal.Parse(Math.Sqrt(Current))
    '        Case "sqr"
    '            SimpleCalc = Decimal.Parse(Math.Pow(Current, 2))
    '        Case "reciprocal"
    '            SimpleCalc = Decimal.Divide(1, Current)
    '    End Select
    'End Function
End Module
