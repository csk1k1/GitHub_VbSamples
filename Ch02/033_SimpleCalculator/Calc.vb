Imports System.Globalization.NumberFormatInfo

Friend Module Calc

    'Private preVal As Decimal
    'Private currentVal As Decimal
    'Public result As Decimal

    Property Current As Decimal = 0
    Property Prev As Decimal = 0
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
#Region "Code: Arithmetic method"
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
#End Region
#Region "Code Recycle"
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

#End Region
    Sub SimpleCalc(ByVal strO As String)
        'If Not Array.IndexOf(oprts, strO) >= 0 Then Exit Function
        Select Case strO
            Case "+"
                Try
                    Prev = Decimal.Add(Prev, Current)
                Catch ex As Exception
                    StrCurrent = "溢出"
                    Reset()
                End Try
            Case "-"
                Try
                    Prev = Decimal.Subtract(Prev, Current)
                Catch ex As Exception
                    StrCurrent = "溢出"
                    Reset()
                End Try
            Case "*"
                Try
                    Prev = Decimal.Multiply(Prev, Current)
                Catch ex As Exception
                    StrCurrent = "溢出"
                    Reset()
                End Try
            Case "/"
                Try
                    Prev = Decimal.Divide(Prev, Current)
                Catch ex As Exception
                    StrCurrent = IIf(Current = 0, "除数不能为零", "溢出")
                    Reset()
                End Try
'以工资为例：          如果我们的工资大于800开始扣税， 那么应该怎么算呢？

'第一步：            我们用3225-800 = 2425

'第二步：2425-485（税钱）=1940

'第三步：1940+800=2740（税后）
            Case "%"
                Try
                    Current = Decimal.Divide(Current, 100)
                    StrExpCur = IIf(StrExpCur = "", "1 /(" & Current.ToString & ")", "1 /(" & StrExpCur & ")")  '表达式显示方式
                Catch ex As Exception
                    StrCurrent = "溢出"
                    Reset()
                End Try
            Case "sqrt"
                Try
                    Current = Decimal.Parse(Math.Sqrt(Current))
                    StrExpCur = IIf(StrExpCur = "", "sqrt(" & Current.ToString & ")", "sqrt(" & StrExpCur & ")")  '表达式显示方式
                Catch ex As Exception
                    StrCurrent = IIf(Current < 0, "亲,别用负数求平方根好吗", "溢出")
                    Reset()
                End Try
            Case "sqr"
                Try
                    Current = Decimal.Parse(Math.Pow(Current, 2))
                    StrExpCur = IIf(StrExpCur = "", "sqr(" & Current.ToString & ")", "sqr(" & StrExpCur & ")")  '表达式显示方式
                Catch ex As Exception
                    StrCurrent = "溢出"
                    Reset()
                End Try
            Case "reciprocal"
                Try
                    Current = Decimal.Divide(1, Current)
                    StrExpCur = IIf(StrExpCur = "", "1 /(" & Current.ToString & ")", "1 /(" & StrExpCur & ")")  '表达式显示方式
                Catch ex As Exception
                    StrCurrent = IIf(Current = 0, "除数不能为零", "溢出")
                    Reset()
                End Try
        End Select
    End Sub

    Sub Reset()
        Current = 0
        Prev = 0
        StrExp = ""
        StrExpPrev = ""
        StrExpCur = ""
        Oprt = ""
    End Sub
End Module
