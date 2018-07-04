Public Class Form1

    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles Btn.Click
        For i As Integer = 0 To 9
            SetResult(i)
        Next
    End Sub

    Private Function GetScore(ByVal i As Integer) As Integer
        Dim score As Integer
        Try
            score = GpbScore.Controls.Item("TxtScore" & i).Text
        Catch ex As ArgumentException
            MessageBox.Show("The number i of txtScore(i) is invalid!")
        End Try
        Return score
    End Function

    Private Sub SetResult(ByVal i As Integer)
        Try
            GpbScore.Controls.Item("LblResult" & i).Text = Grade(GetScore(i))
        Catch ex As ArgumentException
            MessageBox.Show("The number i of LblResult(i) is invalid!")
        End Try
    End Sub

    Private Function Grade(ByVal n As Integer) As String
        Dim g As String = ""
        If 0 <= n <= 100 Then
            Select Case n
                Case 0 To 59
                    g = "C-"
                Case 60 To 64
                    g = "C"
                Case 65 To 69
                    g = "C+"
                Case 70 To 74
                    g = "B-"
                Case 75 To 79
                    g = "B"
                Case 80 To 84
                    g = "B+"
                Case 85 To 89
                    g = "A-"
                Case 90 To 94
                    g = "A"
                Case 95 To 99
                    g = "A+"
                Case 100
                    g = "Excellent!"
            End Select
        Else
            g = "Invalid Score"
            MessageBox.Show("Invalid Score,please input numbers between 0 and 100!")
        End If
        Return g
    End Function
End Class
