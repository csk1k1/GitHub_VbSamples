Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Application.Exit()
        Application.ExitThread()
    End Sub

    Private Sub txtLower_TextChanged(sender As Object, e As EventArgs) Handles txtLower.TextChanged
        txtUpper.Text = RMBChinese(txtLower.Text)
    End Sub
End Class
