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
    Property TxtStack As New Stack(Of String)
    Property NumStack As New Stack(Of Decimal)
    Property OpStack As New Stack(Of String)
    Property Current As Decimal = Zero
    Property Prev As Decimal = Zero
    Property Oprt As String = String.Empty
    Public op1 As String() = {"+", "-"}
    Public op2 As String() = {"*", "/"}
    Public op3 As String() = {"sqr", "sqrt", "rec"}
    Public op4 As String() = {"%"}
#Region "DeclareRecycle"
    'Private preVal As Decimal
    'Private currentVal As Decimal
    'Public result As Decimal
    'Property PrevCurrent As Decimal = String.Empty
    'Property StrResult As String = String.Empty
    'Property StrExp As String = String.Empty
    'Property StrPrevExp As String = String.Empty
    'Property StrCurrExp As String = String.Empty
#End Region
#Region "Code: Arithmetic method"

    'Function Sqrt(ByVal d As Decimal) As Decimal
    '    Try
    '        Sqrt = Parse(Math.Sqrt(d))
    '    Catch ex As Exception
    '        StrResult = IIf(d < 0, "Invalid Data", "溢出")
    '        Return Nothing
    '    End Try
    'End Function

    'Function Sqr(ByVal d As Decimal) As Decimal
    '    Try
    '        Sqr = Parse(Math.Pow(d, 2))
    '    Catch ex As Exception
    '        StrResult = "溢出"
    '        Return Nothing
    '    End Try
    'End Function


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

    '                Case "rec"
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
    'Op:运算符     PRI:优先级Priority
    Function OpPRI(ByVal op As String) As Integer
        If Array.IndexOf(op1, op) >= 0 Then
            Return 1
        ElseIf Array.IndexOf(op2, op) >= 0 Then
            Return 2
        ElseIf Array.IndexOf(op3, op) >= 0 Then
            Return 3
        Else
            Return 4
        End If
    End Function
    Sub CallCalc(Oprt)

        If OpPRI(Oprt) = 4 Then
            If OpStack.Count > 0 AndAlso NumStack.Count > 0 Then
                Current = Calc(Oprt, NumStack.Peek, Current)
                Oprt = String.Empty
                Exit Sub
            End If
        ElseIf OpPRI(Oprt) = 3 Then
            'Try
            '    Current = Result(op, Current)
            '    Exit Sub
            'Catch ex As Exception
            '    ErrText(op)
            'End Try
            Current = Calc(Oprt, Current)
            Exit Sub
        End If

        If (OpStack.Count = 0 AndAlso NumStack.Count = 0) Then      '数字和符号栈都为空
            OpStack.Push(Oprt)
            NumStack.Push(Current)
            Oprt = String.Empty
            Exit Sub
        ElseIf OpPRI(OpStack.Peek) < OpPRI(Oprt) Then     '栈顶的运算符优先级低于准备入栈的op,不计算直接入栈
            OpStack.Push(Oprt)
            NumStack.Push(Current)
            Oprt = String.Empty
            Exit Sub
        ElseIf OpPRI(OpStack.Peek) >= OpPRI(Oprt) Then    '栈顶的运算符优先级高于准备入栈的op,先弹出栈顶的数字和运算符与current进行算术运算,并将结果赋值给Current和当前op作为参数继续调用入栈过程PushOp()
            Current = Calc(OpStack.Pop, NumStack.Pop, Current)
            CallCalc(Oprt)
        End If
    End Sub
    Sub Equal()
        If OpStack.Count = 0 Then Exit Sub
        For i = OpStack.Count To 1 Step -1
            Current = Calc(OpStack.Pop, NumStack.Pop, Current)
        Next
        Reboot()
    End Sub

    Function Calc(ByVal op As String, ByVal p As Decimal, ByVal c As Decimal) As Decimal
        Select Case op
            Case "+"
                Calc = Add(p, c)
            Case "-"
                Calc = Subtract(p, c)
            Case "*"
                Calc = Multiply(p, c)
            Case "/"
                Calc = Divide(p, c)
            Case "%"
                Calc = Multiply(p, c / 100)
            Case Else
                Return Nothing
        End Select
    End Function
    Function Calc(ByVal op As String, ByVal c As Decimal) As Decimal
        Select Case op
            Case "sqrt"
                Calc = Parse(Math.Sqrt(c))
            Case "sqr"
                Calc = Parse(Math.Pow(c, 2))
            Case "rec"
                Calc = Divide(1, c)
            Case Else
                Return Nothing
        End Select
    End Function

    Public Function ErrText(ByVal op As String) As String
        Select Case op
            Case "/"
                ErrText = "亲,除数不能为零哦"
            Case "%"
                ErrText = "%用法示例: a<?op1>b%: 使用%方法为 输入数字a 加 (+-*/)任一 再加数字b 最后输入%"
            Case "sqrt"
                ErrText = "负数没有平方根(虚数人家不懂的啦)"
            Case "rec"
                ErrText = "亲,人家不会对零求倒数啊"
            Case Else
                ErrText = "臣妾做不到啊~"
        End Select
        Reboot()
    End Function

    Public Sub Reboot()
        Current = Decimal.Zero
        Prev = Decimal.Zero
        Oprt = String.Empty
        OpStack.Clear()
        NumStack.Clear()
        TxtStack.Clear()
    End Sub
End Module
