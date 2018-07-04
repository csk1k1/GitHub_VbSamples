Public Class Form1
    Private Sub BtnToUpper_Click(sender As Object, e As EventArgs) Handles BtnToUpper.Click
        LblToUpper.Text = UCase(TxtToUpper.Text)
    End Sub

    Private Sub BtnToLower_Click(sender As Object, e As EventArgs) Handles BtnToLower.Click
        LblTolower.Text = LCase(TxtToLower.Text)
    End Sub
End Class
