Public Class FrmLogin
    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        Me.Close()
        FrmMain.Show()
    End Sub
End Class