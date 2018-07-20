Imports System.Globalization
Imports System.Numerics
Imports System.Text.RegularExpressions
Imports System.Math
Imports Microsoft.VisualBasic.VBMath

Public Class FrmCaculator


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

        LblCurrent.Text = dCurrent
        LblPrev.Text = dPrev
    End Sub

    '声明 
    'Protected Overrides Sub OnSizeChanged(e As EventArgs)

    'End Sub
    'Protected Sub OnSizing(e As EventArgs)

    'End Sub


    '判断当前算式是否为非0, 如果非0返回TRUE,如果为0返回FALSE
    Private Function started() As Boolean
        If Equals(dCurrent, "0") Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub EntryNum(n As Int32)
        If Not dCurrent.ToString.Length < 12 Then
            Exit Sub
        End If

        '如果初值已经变为非零数，则新数字加在strCurrent最后；如果初值还是零则用新值赋值给strCurrent
        If started() Then
            dCurrent = Decimal.Parse(dCurrent.ToString + n.ToString)
            dCurrent = CDec(dCurrent.ToString + n.ToString)
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

    Protected Overrides Sub WndProc(ByRef m As Message)

        Select Case m.Msg
            Case &H24 'WM_GETMINMAXINFO = &H24

            Case &HF 'WM_PAINT 要求一个窗口重绘自己 

            Case &H214 'WM_SIZING 

        End Select

        MyBase.WndProc(m)
    End Sub
End Class
