Imports System.Globalization
Imports System.Numerics
'Imports System.Globalization.NumberFormatInfo

Imports Microsoft.VisualBasic.CallType
Imports System.Text.RegularExpressions
Imports System.Math
Imports Microsoft.VisualBasic.VBMath

Public Class FrmCaculator

    Private snd As Object
    Private evt As EventArgs
    Private strPrev As String = String.Empty
    Private strCurrent As String = "0"
    Private prevValue As Decimal
    Private currentValue As Decimal = Decimal.Zero
    Private strOp As String = String.Empty
    Private inputs() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "+", "-", "*", "/", "^"}
    ' Get decimal separator.
    Private decimalSeparator As String = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator
    Private pattern As String
    Dim intToFormat As Long
    Dim bigintToFormat As BigInteger = BigInteger.Zero
    Dim floatToFormat As Double

    Private Property Current() As Decimal
        Get
            Return currentValue
        End Get
        Set(value As Decimal)
            currentValue = value
        End Set
    End Property

    Private Property Prev() As Decimal
        Get
            Return prevValue
        End Get
        Set(value As Decimal)
            prevValue = value
        End Set
    End Property

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True '确定窗体上控件的按键事件向窗体注册，这步一定要有的
        LblCurrent.Text = "0"
        LblPrev.Text = ""
    End Sub


    'Protected Overrides Sub OnSizeChanged(e As EventArgs)
    'End Sub
    'Protected Sub OnSizing(e As EventArgs)
    'End Sub

    '判断当前算式是否为非0, 如果非0返回TRUE,如果为0返回FALSE
    Private Function started() As Boolean
        If Equals(strCurrent, "0") Then
            Return False
        Else
            Return True
        End If
        'Debug.Print(Equals(strCurrent, 0))
    End Function

    Private Sub Entry(n As String)
        If Not strCurrent.Length < 12 Then
            Exit Sub
        End If

        '如果初值已经变为非零数，则新数字加在strCurrent最后；如果初值还是零则用新值赋值给strCurrent
        If started() OrElse Equals(n, decimalSeparator) OrElse n = decimalSeparator Then
            'strCurrent = strCurrent + n
            strCurrent += n
        Else
            strCurrent = n
        End If

        LblCurrent.Text = strCurrent
        If strCurrent.Last <> decimalSeparator Then
            'If Strings.Right(strCurrent, 1) <> decimalSeparator Then
            'End If
            Current = CDec(strCurrent)            'Current = Decimal.Parse(strCurrent)
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
        strCurrent = Current.ToString  '不要用CStr(),转化的正数字符串带有前导空格
        LblCurrent.Text = strCurrent
    End Sub

    Private Sub BtnPoint_Click(sender As Object, e As EventArgs) Handles BtnPoint.Click
        If InStr(strCurrent, decimalSeparator) = 0 Then
            Entry(decimalSeparator)
        End If
    End Sub

    Private Sub BtnPlus_Click(sender As Object, e As EventArgs) Handles BtnPlus.Click

    End Sub

    Private Sub BtnMinus_Click(sender As Object, e As EventArgs) Handles BtnMinus.Click

    End Sub

    Private Sub BtnAsterisk_Click(sender As Object, e As EventArgs) Handles BtnAsterisk.Click

    End Sub

    Private Sub BtnDivision_Click(sender As Object, e As EventArgs) Handles BtnDivision.Click

    End Sub

    Private Sub BtnBackspace_Click(sender As Object, e As EventArgs) Handles BtnBackspace.Click
        strCurrent.Remove(strCurrent.Length - 1)
    End Sub

    Private Sub BtnC_Click(sender As Object, e As EventArgs) Handles BtnC.Click
        strPrev = Nothing
        Prev = Nothing
        LblPrev.Text = strPrev
        strCurrent = "0"
        Current = Decimal.Zero
        LblCurrent.Text = strCurrent
    End Sub

    Private Sub BtnCe_Click(sender As Object, e As EventArgs) Handles BtnCe.Click
        strCurrent = "0"
        Current = Decimal.Zero
        LblCurrent.Text = strCurrent
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


    Protected Overrides Sub WndProc(ByRef m As Message)

        Select Case m.Msg
            Case &H24 'WM_GETMINMAXINFO = &H24

            Case &HF 'WM_PAINT 要求一个窗口重绘自己 

            Case &H214 'WM_SIZING 

        End Select

        MyBase.WndProc(m)
    End Sub


End Class
