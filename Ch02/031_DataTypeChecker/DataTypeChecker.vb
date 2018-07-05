
Public Class DataTypeChecker
    Private data As String
    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles BtnCheck.Click
        data = TxtData.Text
        If IsNothing(data) Then
            MessageBox.Show("There is Nothing in the TextBox!")
        ElseIf System.Text.RegularExpressions.Regex.IsMatch(data, "[\u0100-\uffff]") Then
            MsgBox("有中文字符")
        ElseIf IsNumeric(data) Then
            MessageBox.Show("The Data is Numeric")
        ElseIf IsDate(data) Then
            MessageBox.Show("The Data is a Date")
        ElseIf data Like "[a-z]" Then
            MessageBox.Show("你输入了一个小写字母")
        End If
    End Sub
End Class
