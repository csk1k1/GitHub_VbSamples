Public Class Form1

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
        Application.Exit()
        Application.ExitThread()
    End Sub

    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
        TxtUpper.Text = RMBChinese(TxtLower.Text)
    End Sub

    Private Sub TxtLower_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtLower.KeyPress
        '绑定回车事件
        If e.KeyChar = ChrW(13) Then
            Call BtnConvert_Click(sender, e)
        End If
    End Sub
End Class
