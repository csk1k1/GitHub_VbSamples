Imports System.Math
Imports Microsoft.VisualBasic.VBMath

Public Class FrmCaculator


    Private strPrev As String
    Private strCurrent As String


    Private Sub Initial()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        strPrev = ""
        strCurrent = "0"
        LblCurrent.Text = strCurrent
        LblPrev.Text = strPrev
    End Sub
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initial()
    End Sub

    '判断当前算式是否为非0, 如果非0返回TRUE,如果为0返回FALSE
    Private Function Valid() As Boolean
        If strCurrent = "0" Then
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
End Class
