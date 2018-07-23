Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        txtSum.Text = Jiaquan(txtApplePrice.Text, txtAppleSales.Text, txtBananaPrice.Text,
txtBananaSales.Text, txtOrangePrice.Text, txtOrangeSales.Text)
    End Sub

    Private Function Jiaquan(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer,
                             ByVal d As Integer, ByVal e As Integer, ByVal f As Integer)
        Dim sum = (a * b + c * d + e * f) / (b + d + f)
        sum = Math.Round(sum, 2)
        Return sum
    End Function

End Class
