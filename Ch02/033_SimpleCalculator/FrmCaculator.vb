Imports System.Globalization
Imports System.Numerics
Imports Microsoft.VisualBasic.CallType

Imports System.Text.RegularExpressions
Imports System.Math
Imports Microsoft.VisualBasic.VBMath

Public Class FrmCaculator

    Private snd As Object
    Private evt As EventArgs
    Private dPrev As Decimal
    Private dCurrent As Decimal = 0
    Private strOp As String = String.Empty
    Private inputs() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "+", "-", "*", "/", "^"}
    ' Get decimal separator.
    Private decimalSeparator As String = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator
    Private pattern As String
    Dim intToFormat As Long
    Dim bigintToFormat As BigInteger = BigInteger.Zero
    Dim floatToFormat As Double

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
        LblCurrent.Text = dCurrent
        'LblPrev.Text = dPrev
    End Sub

    '声明 
    'Protected Overrides Sub OnSizeChanged(e As EventArgs)

    'End Sub
    'Protected Sub OnSizing(e As EventArgs)

    'End Sub


    '判断当前算式是否为非0, 如果非0返回TRUE,如果为0返回FALSE
    Private Function started() As Boolean
        If Equals(dCurrent, 0) Then
            Return False
        Else
            Return True
        End If
        Debug.Print(Equals(dCurrent, 0))
    End Function

    Private Sub EntryNum(n As Int32)
        If Not dCurrent.ToString.Length < 12 Then
            Exit Sub
        End If

        '如果初值已经变为非零数，则新数字加在strCurrent最后；如果初值还是零则用新值赋值给strCurrent
        If started() Then
            dCurrent = Decimal.Parse(dCurrent.ToString + n.ToString)
            'dCurrent = CDec(dCurrent.ToString + n.ToString)
        Else
            dCurrent = n
        End If
        LblCurrent.Text = dCurrent
    End Sub



    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        EntryNum(0)
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        EntryNum(1)
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        EntryNum(2)
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        EntryNum(3)
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        EntryNum(4)
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        EntryNum(5)
    End Sub
    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        EntryNum(6)
    End Sub
    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        EntryNum(7)
    End Sub
    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        EntryNum(8)
    End Sub
    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        EntryNum(9)
    End Sub



    Private Sub BtnPlusMinus_Click(sender As Object, e As EventArgs) Handles BtnPlusMinus.Click

    End Sub

    Private Sub BtnPoint_Click(sender As Object, e As EventArgs) Handles BtnPoint.Click

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

    End Sub

    Private Sub BtnC_Click(sender As Object, e As EventArgs) Handles BtnC.Click

    End Sub

    Private Sub BtnCe_Click(sender As Object, e As EventArgs) Handles BtnCe.Click

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
