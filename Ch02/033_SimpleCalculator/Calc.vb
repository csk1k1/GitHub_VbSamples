Imports System.Globalization.NumberFormatInfo
Imports System.Decimal

'''////////////////////////////////////////////////////////////////////////////////////////////////////
''' <summary>   A calculate. </summary>
'''
''' <remarks>   WXD, 2018/7/26 星期四. </remarks>
'''
''' <example>   . </example>
'''
''' <inheritdoc/>
'''////////////////////////////////////////////////////////////////////////////////////////////////////

Friend Module Calc

    'Private preVal As Decimal
    'Private currentVal As Decimal
    'Public result As Decimal

    Property Current As Decimal = 0
    Property Prev As Decimal = 0
    Property PrevCurrent As Decimal
    Property StrResult As String = ""
    Property StrExp As String = ""
    Property StrPrevExp As String = ""
    Property StrCurrExp As String = ""
    Property Oprt As String = ""
    Public oprts As String() = {"+", "-", "*", "/"}

#Region "Code: Arithmetic method"

    Function Sqrt(ByVal d As Decimal) As Decimal
        Try
            Sqrt = Parse(Math.Sqrt(d))
        Catch ex As Exception
            StrResult = IIf(d < 0, "Invalid Data", "溢出")
            Return Nothing
        End Try
    End Function

    Function Sqr(ByVal d As Decimal) As Decimal
        Try
            Sqr = Parse(Math.Pow(d, 2))
        Catch ex As Exception
            StrResult = "溢出"
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

    ''' <summary>
    ''' 计算过程
    ''' </summary>
    ''' <param name="strO">算术运算符</param>
    Sub SimpleCalc(ByVal strO As String)
        'If Not Array.IndexOf(oprts, strO) >= 0 Then Exit Function
        Select Case strO
            Case "+"
                Try
                    Prev = Decimal.Add(Prev, Current)
                Catch ex As Exception
                    StrResult = "溢出"
                    Reset()
                End Try
            Case "-"
                Try
                    Prev = Decimal.Subtract(Prev, Current)
                Catch ex As Exception
                    StrResult = "溢出"
                    Reset()
                End Try
            Case "*"
                Try
                    Prev = Multiply(Prev, Current)
                Catch ex As Exception
                    StrResult = "溢出"
                    Reset()
                End Try
            Case "/"
                Try
                    Prev = Decimal.Divide(Prev, Current)
                Catch ex As Exception
                    StrResult = IIf(Current = 0, "除数不能为零", "溢出")
                    Reset()
                End Try

            '---------------------  % 的用法说明  -------------------------------------/
            '%需要配合+-*/使用：输入a + b%，等于表达式a+a*b%                           '
            '以工资为例：          如果我们的工资大于800开始扣税， 那么应该怎么算呢？  '
            '第一步：            我们用3225-800 = 2425                                 '
            '第二步：2425-485（税钱）=1940                                             '
            '第三步：1940+800=2740（税后）                                             '
            '--------------------------------------------------------------------------*/
            Case "%"
                If Array.IndexOf({"+", "-", "*", "/"}, Oprt) < 0 Then
                    StrResult = "%需要配合+-*/使用：输入a + b%，等于表达式a+a*b%"
                    Exit Sub
                End If
                Try
                    Current = Prev * Current / 100
                    StrCurrExp = IIf(StrCurrExp = "", "1 /(" & Current.ToString & ")", "1 /(" & StrCurrExp & ")")  '表达式显示方式
                Catch ex As Exception
                    StrResult = "溢出"
                    Reset()
                End Try
            Case "sqrt"
                Try
                    Current = Parse(Math.Sqrt(Current))
                    StrCurrExp = IIf(StrCurrExp = "", "sqrt(" & Current.ToString & ")", "sqrt(" & StrCurrExp & ")")  '表达式显示方式
                Catch ex As Exception
                    StrResult = IIf(Current < 0, "亲,别用负数求平方根好吗", "溢出")
                    Reset()
                End Try
            Case "sqr"
                Try
                    Current = Parse(Math.Pow(Current, 2))
                    StrCurrExp = IIf(StrCurrExp = "", "sqr(" & Current.ToString & ")", "sqr(" & StrCurrExp & ")")  '表达式显示方式
                Catch ex As Exception
                    StrResult = "溢出"
                    Reset()
                End Try
            Case "reciprocal"
                Try
                    Current = Decimal.Divide(1, Current)
                    StrCurrExp = IIf(StrCurrExp = "", "1 /(" & Current.ToString & ")", "1 /(" & StrCurrExp & ")")  '表达式显示方式
                Catch ex As Exception
                    StrResult = IIf(Current = 0, "除数不能为零", "溢出")
                    Reset()
                End Try
        End Select
    End Sub

    Sub Reset()
        Current = 0
        Prev = 0
        StrExp = ""
        Oprt = ""
    End Sub

    Function Result(ByVal op As String) As Decimal
        Select Case op
            Case "+"
                Result = Decimal.Add(Prev, Current)
            Case "-"
                Result = Decimal.Subtract(Prev, Current)
            Case "*"
                Result = Multiply(PrevCurrent, Current)
            Case "/"
                Result = Divide(PrevCurrent, Current)
            Case "%"
                Result = Multiply(Prev, Current / 100)
            Case "sqrt"
                Result = Parse(Math.Sqrt(Current))
            Case "sqr"
                Result = Parse(Math.Pow(Current, 2))
            Case "reciprocal"
                Result = Decimal.Divide(1, Current)
            Case Else
                Exit Select
        End Select
        Return Result
    End Function
End Module
