Public Class Form1
    Private Sub BtnNumToStr_Click(sender As Object, e As EventArgs) Handles BtnNumToStr.Click
        LblNumToStr.Text = CStr(CDbl(TxtNumToStr.Text))
    End Sub

    Private Sub BtnStrToNum_Click(sender As Object, e As EventArgs) Handles BtnStrToNum.Click
        LblStrToNum.Text = CDbl(TxtStrToNum.Text)
    End Sub
End Class
