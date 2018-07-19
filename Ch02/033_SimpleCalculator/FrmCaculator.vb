Imports System.Math
Imports Microsoft.VisualBasic.VBMath

Public Class FrmCaculator


    Private strPrev As String
    Private strCurrent As String = Str(0)


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load

        LblCurrent.Text = strCurrent
        LblPrev.Text = strPrev
    End Sub

    '声明 
    'Protected Overrides Sub OnSizeChanged(e As EventArgs)

    'End Sub
    'Protected Sub OnSizing(e As EventArgs)

    'End Sub


    '判断当前算式是否为非0, 如果非0返回TRUE,如果为0返回FALSE
    Private Function Valid() As Boolean
        If Equals(strCurrent, Str(0)) Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Entry(n As Integer)
        If Valid() Then
            strCurrent = strCurrent + Str(n)
        Else
            strCurrent = Str(n)
        End If
        LblCurrent.Text = strCurrent
    End Sub



    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        Entry(0)
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Entry(1)
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Entry(2)
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        Entry(3)
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        Entry(4)
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        Entry(5)
    End Sub
    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        Entry(6)
    End Sub
    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        Entry(7)
    End Sub
    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        Entry(8)
    End Sub
    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        Entry(9)
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
