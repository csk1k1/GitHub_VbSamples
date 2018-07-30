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

#Region "DeclareRecycle"
    'Private preVal As Decimal
    'Private currentVal As Decimal
    'Public result As Decimal
    'Property PrevCurrent As Decimal = String.Empty
    'Property StrResult As String = String.Empty
    'Property StrExp As String = String.Empty
    'Property StrPrevExp As String = String.Empty
    'Property StrCurrExp As String = String.Empty
    Property Nums As New Stack(Of Decimal)
    Property Ops As New Stack(Of String)
    Property Current As Decimal = Zero
    Property Prev As Decimal = Zero
    Property Oprt As String = String.Empty
    Public op1 As String() = {"+", "-"}
    Public op2 As String() = {"*", "/"}
#End Region
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
    Function OpValue(ByVal op As String) As Integer
        If Array.IndexOf(op1, op) >= 0 Then
            Return 1
        Else
            Return 2
        End If
    End Function
    Sub TryPushOp(ByVal op As String)
        If Ops.Count = 0 AndAlso Nums.Count = 0 Then
            Ops.Push(op)
            Nums.Push(Current)
            op = String.Empty
            Exit Sub
        End If

        If OpValue(Ops.Peek) < OpValue(op) Then
            Ops.Push(op)
            Nums.Push(Current)
            op = String.Empty
        End If
    End Sub
    Sub Equal()
        If Ops.Count = 0 Then Exit Sub
        For i = 1 To Ops.Count
            Current = Result(Ops.Pop, Nums.Pop, Current)
        Next
    End Sub

    Function Result(ByVal op As String, ByVal p As Decimal, ByVal c As Decimal) As Decimal
        Select Case op
            Case "+"
                Result = Add(p, c)
            Case "-"
                Result = Subtract(p, c)
            Case "*"
                Result = Multiply(p, c)
            Case "/"
                Result = Divide(p, c)
            Case "%"
                Result = Multiply(p, c / 100)
            Case "sqrt"
                Result = Parse(Math.Sqrt(c))
            Case "sqr"
                Result = Parse(Math.Pow(c, 2))
            Case "reciprocal"
                Result = Divide(1, c)
            Case Else
                Exit Select
        End Select
        Return Result
    End Function
End Module
