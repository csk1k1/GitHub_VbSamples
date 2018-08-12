

Imports System.Decimal
Imports System.Globalization.NumberFormatInfo
Public Class FrmCaculator
    Private InputSwitchOpen As Boolean = True
    Private ErrFlag As Boolean = False
    Private hasExt As Boolean = False
    Private arrSubExp As New ArrayList
    Private decimalSeparator As String = CurrentInfo.NumberDecimalSeparator
    Public Property TxtResult As String
        Get
            Return LblResult.Text
        End Get
        Set(value As String)
            LblResult.Text = value
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
        TxtResult = "0"
        TxtExpression = ""
    End Sub

    Private Sub EntryNum(n As String)
        If Not TxtResult.Length < 12 Then
            Exit Sub
        End If
        '如果初值已经变为非零数，则新数字加在strCurrent最后；如果初值还是零则用新值赋值给strCurrent
        If TxtResult <> "0" OrElse n = decimalSeparator Then
            'strCurrent = strCurrent + n
            TxtResult += n
        ElseIf TxtResult = "0" Then
            TxtResult = n
        End If

        If TxtResult.Last <> decimalSeparator Then          'Strings.Right(strCurrent, 1) <> decimalSeparator 
            Current = CDec(TxtResult)            'Current = Decimal.Parse(strCurrent)
        End If
    End Sub

    Private Sub BtnPlusMinus_Click(sender As Object, e As EventArgs) Handles BtnPN.Click
        TxtExpression += "Negate(" + Current.ToString + ")"
        Current = Decimal.Negate(Current)
        TxtResult = Current.ToString
    End Sub

    Private Sub BtnDot_Click(sender As Object, e As EventArgs) Handles BtnDot.Click
        If InStr(TxtResult, decimalSeparator) < 0 Then
            EntryNum(decimalSeparator)
        End If
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        EntryNum("0")
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        EntryNum("1")
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        EntryNum("2")
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        EntryNum("3")
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        EntryNum("4")
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        EntryNum("5")
    End Sub
    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        EntryNum("6")
    End Sub
    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        EntryNum("7")
    End Sub
    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        EntryNum("8")
    End Sub
    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        EntryNum("9")
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
        If TxtResult.Length = 1 And Current = Zero Then
            Exit Sub
        End If
        If InputSwitchOpen Then
            If TxtResult.Length > 1 Then
                TxtResult = TxtResult.Remove(TxtResult.Length - 1)
                Current = CDec(TxtResult)
            Else
                TxtResult = "0"
                Current = Zero
            End If
        End If
    End Sub

    Private Sub BtnC_Click(sender As Object, e As EventArgs) Handles BtnC.Click
        If ErrFlag = True Then
            ErrOff()
        End If
        Clear()
    End Sub

    Private Sub BtnCe_Click(sender As Object, e As EventArgs) Handles BtnCe.Click
        TxtResult = "0"
        Current = Decimal.Zero
    End Sub

    Private Sub BtnReciprocal_Click(sender As Object, e As EventArgs) Handles BtnReciprocal.Click
        If Current = Zero Then
            TxtResult = Calc.ErrText("rec")
            ErrOn()
        Else
            Current = Calc.Calc("rec", Current)
            TxtResult = Current.ToString
        End If
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

    Private Sub Clear()
        Prev = Decimal.Zero
        Oprt = String.Empty
        TxtExpression = String.Empty
        TxtResult = "0"
        Current = Decimal.Zero
    End Sub

    Private Sub BtnEqual_Click(sender As Object, e As EventArgs) Handles BtnEqual.Click
        Equal()
        Clear()
    End Sub

    Private Sub ErrOn()
        ErrFlag = True
        For Each cmd As Control In TableLayoutPanel1.Controls
            If TypeOf cmd Is Button And cmd.Name <> NameOf(BtnC) Then
                cmd.Enabled = False
            End If
        Next
    End Sub

    Private Sub ErrOff()
        ErrFlag = False
        For Each cmd As Control In TableLayoutPanel1.Controls
            If TypeOf cmd Is Button And cmd.Name <> NameOf(BtnC) Then
                cmd.Enabled = True
            End If
        Next
    End Sub
End Class
