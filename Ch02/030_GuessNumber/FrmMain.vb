Public Class FrmMain
    Private intTarget, icnt As Integer
    Private gameOver As Boolean = False

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewGame()
    End Sub

    Private Sub NewGame()
        gameOver = False
        icnt = 0
        VBMath.Randomize(Rnd() * 888)
        intTarget = CInt(Int(1000 * Rnd()))
        LblCap.Text = ""
        LblCount.Text = ""
    End Sub

    Private Sub Guess(ByVal n As Integer)
        icnt += 1
        LblCount.Text = "猜数次数: " & icnt
        If n < intTarget Then
            LblCap.Text = "Wrong! Please try a bigger one!"
        ElseIf n > intTarget Then
            LblCap.Text = "Wrong! Please try a smaller one!"
        ElseIf n = intTarget Then
            LblCap.Text = "Excellent! You got the number!"
            gameOver = True
        End If
    End Sub

    Private Sub ShowDlg()
        Dim r = MessageBox.Show("Well done! Do you want play again?", "Info", MessageBoxButtons.RetryCancel)
        If r = DialogResult.Cancel Then
            Application.Exit()
        ElseIf r = DialogResult.Retry Then
            NewGame()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNumeric(TxtNum.Text) = True And CStr(Int(TxtNum.Text)) = TxtNum.Text Then
            guess(CInt(TxtNum.Text))
        End If
        If gameOver Then
            ShowDlg()
        End If
    End Sub
End Class
