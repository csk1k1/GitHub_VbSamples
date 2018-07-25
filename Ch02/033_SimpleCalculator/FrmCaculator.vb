

#Region "Imports_Recycle"
'Imports System.Numerics
'Imports Microsoft.VisualBasic.CallType
'Imports System.Text.RegularExpressions
'Imports System.Math
'Imports Microsoft.VisualBasic.VBMath
#End Region
Imports System.Globalization.NumberFormatInfo
Public Class FrmCaculator
#Region "Declare_Recycle"
    'Private snd As Object
    'Private evt As EventArgs
    'Private strPrev As String = String.Empty
    'Private prevValue As Decimal
    'Private currentValue As Decimal = Decimal.Zero
    'Private strOp As String = String.Empty
    'Private inputs() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "+", "-", "*", "/", "^"}
    ' Get decimal separator.
    'Private pattern As String
    'Dim intToFormat As Long
    'Dim bigintToFormat As BigInteger = BigInteger.Zero
    'Dim floatToFormat As Double
#End Region
#Region "Code"
    'Private Property Current() As Decimal
    '    Get
    '        Return currentValue
    '    End Get
    '    Set(value As Decimal)
    '        currentValue = value
    '    End Set
    'End Property

    'Private Property Prev() As Decimal
    '    Get
    '        Return prevValue
    '    End Get
    '    Set(value As Decimal)
    '        prevValue = value
    '    End Set
    'End Property
#End Region
#Region "Module Calc"
    Property Current As Decimal
    Property Prev As Decimal
    Private _oprt As String = String.Empty
    Public oprts As String() = {"+", "-", "*", "/", "%", "sqrt", "sqr", "reciprocal"}
    Property Op As String
        Get
            Return _oprt
        End Get
        Set(oprt As String)
            If Array.IndexOf(oprts, oprt) >= 0 Then
                _oprt = oprt
            End If
        End Set
    End Property

    Sub OprtGo(ByVal oprt As String)
        Try
            Select Case oprt
                Case "%", "sqrt", "sqr", "reciprocal"
                    Op = oprt
                    TxtExpression = "(" + Current.ToString + ")" + "%"
                    Current = SimpleCalc()
                    Prev += Current
                    TxtCurrent = Current.ToString
                Case "+", "-", "*", "/"
                    If Op.Length > 0 Then
                        Current = SimpleCalc()
                        Prev = Current
                        Current = 0
                        Op = oprt
                    Else
                        Prev = Current
                        Current = 0
                        Op = oprt
                    End If
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Function SimpleCalc() As Decimal
        Select Case Op
            Case "+"
                SimpleCalc = Decimal.Add(Prev, Current)
            Case "-"
                SimpleCalc = Decimal.Subtract(Prev, Current)
            Case "*"
                SimpleCalc = Decimal.Multiply(Prev, Current)
            Case "/"
                SimpleCalc = Decimal.Divide(Prev, Current)
            Case "%"
                SimpleCalc = Decimal.Divide(Current, 100)
            Case "sqrt"
                SimpleCalc = Decimal.Parse(Math.Sqrt(Current))
            Case "sqr"
                SimpleCalc = Decimal.Parse(Math.Pow(Current, 2))
            Case "reciprocal"
                SimpleCalc = Decimal.Divide(1, Current)
        End Select
    End Function
#End Region
    Private decimalSeparator As String = CurrentInfo.NumberDecimalSeparator
    Public Property TxtCurrent As String
        Get
            Return LblCurrent.Text
        End Get
        Set(value As String)
            LblCurrent.Text = value
        End Set
    End Property

    Public Property TxtExpression As String
        Get
            Return LblEx.Text
        End Get
        Set(ByVal exp As String)
            LblEx.Text = exp
            Prev += Current
        End Set
    End Property

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True '确定窗体上控件的按键事件向窗体注册，这步一定要有的
        TxtCurrent = "0"
        TxtExpression = ""
    End Sub


    'Protected Overrides Sub OnSizeChanged(e As EventArgs)
    'End Sub
    'Protected Sub OnSizing(e As EventArgs)
    'End Sub

    '判断当前算式是否为非0, 如果非0返回TRUE,如果为0返回FALSE
    Private Function started() As Boolean
        If Equals(TxtCurrent, "0") Then
            Return False
        Else
            Return True
        End If
        'Debug.Print(Equals(strCurrent, 0))
    End Function

    Private Sub Entry(n As String)
        If Not TxtCurrent.Length < 12 Then
            Exit Sub
        End If

        '如果初值已经变为非零数，则新数字加在strCurrent最后；如果初值还是零则用新值赋值给strCurrent
        If started() OrElse n = decimalSeparator OrElse Equals(n, decimalSeparator) Then
            'strCurrent = strCurrent + n
            TxtCurrent += n
        Else
            TxtCurrent = n
        End If

        LblCurrent.Text = TxtCurrent

        If TxtCurrent.Last <> decimalSeparator Then
            'If Strings.Right(strCurrent, 1) <> decimalSeparator Then
            'End If
            Current = CDec(TxtCurrent)            'Current = Decimal.Parse(strCurrent)
        End If
    End Sub


    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        Entry("0")
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Entry("1")
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Entry("2")
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        Entry("3")
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        Entry("4")
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        Entry("5")
    End Sub
    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        Entry("6")
    End Sub
    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        Entry("7")
    End Sub
    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        Entry("8")
    End Sub
    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        Entry("9")
    End Sub

    Private Sub BtnPlusMinus_Click(sender As Object, e As EventArgs) Handles BtnPN.Click
        'NumberFormatInfo.PositiveSign:     "+"
        'Dim signP = NumberFormatInfo.CurrentInfo.PositiveSign
        'NumberFormatInfo.NegativeSign:     "-"
        'Dim signN = NumberFormatInfo.CurrentInfo.NegativeSign
        '乘-1: uses the Negate method to change the sign of several Decimal values.
        Current = Decimal.Negate(Current)
        TxtCurrent = Current.ToString  '不要用CStr(),转化的正数字符串带有前导空格
    End Sub

    Private Sub BtnPoint_Click(sender As Object, e As EventArgs) Handles BtnPoint.Click
        If InStr(TxtCurrent, decimalSeparator) = 0 Then
            Entry(decimalSeparator)
        End If
    End Sub

    Private Sub BtnPlus_Click(sender As Object, e As EventArgs) Handles BtnPlus.Click
        OprtGo("+")
    End Sub

    Private Sub BtnMinus_Click(sender As Object, e As EventArgs) Handles BtnMinus.Click
        OprtGo("-")
    End Sub

    Private Sub BtnAsterisk_Click(sender As Object, e As EventArgs) Handles BtnAsterisk.Click
        OprtGo("*")
    End Sub

    Private Sub BtnDivision_Click(sender As Object, e As EventArgs) Handles BtnDivision.Click
        OprtGo("/")
    End Sub

    Private Sub BtnBackspace_Click(sender As Object, e As EventArgs) Handles BtnBackspace.Click
        If TxtCurrent.Length > 1 Then
            TxtCurrent.Remove(TxtCurrent.Length - 1)
            Current = CDec(TxtCurrent)
        ElseIf TxtCurrent.Length = 1 Then
            TxtCurrent = "0"
            Current = 0
        End If
    End Sub

    Private Sub BtnC_Click(sender As Object, e As EventArgs) Handles BtnC.Click
        TxtExpression = ""
        TxtCurrent = "0"
        Prev = Decimal.Zero
        'Current = Decimal.Zero
    End Sub

    Private Sub BtnCe_Click(sender As Object, e As EventArgs) Handles BtnCe.Click
        TxtCurrent = "0"
        'Current = Decimal.Zero
    End Sub

    Private Sub BtnReciprocal_Click(sender As Object, e As EventArgs) Handles BtnReciprocal.Click

    End Sub

    Private Sub BtnSqr_Click(sender As Object, e As EventArgs) Handles BtnSqr.Click

    End Sub

    Private Sub BtnPct_Click(sender As Object, e As EventArgs) Handles BtnPct.Click

    End Sub

    Private Sub BtnSqrt_Click(sender As Object, e As EventArgs) Handles BtnSqrt.Click

    End Sub

    Private Sub FrmCaculator_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case Keys.D0, Keys.NumPad0
                Btn0_Click(sender, e)
            Case Keys.D1, Keys.NumPad1
                Btn1_Click(sender, e)
            Case Keys.D2, Keys.NumPad2
                Btn2_Click(sender, e)
            Case Keys.D3, Keys.NumPad3
                Btn3_Click(sender, e)
            Case Keys.D4, Keys.NumPad4
                Btn4_Click(sender, e)
            Case Keys.D5, Keys.NumPad5
                Btn5_Click(sender, e)
            Case Keys.D6, Keys.NumPad6
                Btn6_Click(sender, e)
            Case Keys.D7, Keys.NumPad7
                Btn7_Click(sender, e)
            Case Keys.D8, Keys.NumPad8
                Btn8_Click(sender, e)
            Case Keys.D9, Keys.NumPad9
                Btn9_Click(sender, e)
            Case Keys.Add
                BtnPlus_Click(sender, e)
            Case Keys.Subtract
                BtnMinus_Click(sender, e)
            Case Keys.Multiply
                BtnAsterisk_Click(sender, e)
            Case Keys.Divide
                BtnDivision_Click(sender, e)
            Case Keys.Back
                BtnBackspace_Click(sender, e)
        End Select
    End Sub


    'Protected Overrides Sub WndProc(ByRef m As Message)

    '    Select Case m.Msg
    '        Case &H24 'WM_GETMINMAXINFO = &H24

    '        Case &HF 'WM_PAINT 要求一个窗口重绘自己 

    '        Case &H214 'WM_SIZING 

    '    End Select

    '    MyBase.WndProc(m)
    'End Sub


End Class
