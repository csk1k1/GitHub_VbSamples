Imports System.Drawing
Imports System.Drawing.Graphics
Imports System.Drawing.Text
Public Class Form1
    Private t As Boolean()
    Private len As Integer
    Private p As Integer
    Private Sub Pic0_MouseMove(sender As Object, e As MouseEventArgs) Handles Pic0.MouseMove
        p = MousePosition.Y
    End Sub

    Private Function Trigger(ByVal n As Integer) As Boolean()
        If n > 0 Then
            ReDim t(n)
            For i As Integer = 0 To n - 1
                t(i) = False
            Next
        End If
        Return t
    End Function

    Private Sub Pic0_Paint(sender As Object, e As PaintEventArgs) Handles Pic0.Paint

        Dim g As Graphics = e.Graphics
        Dim f As New Font("华文行楷", 12)
        Dim b As Brush = Brushes.Black
        Dim x, y As Single
        Dim letter As String() = {"一封家书", "亲爱的爸爸妈妈：", "你们好吗", "现在工作很忙吧！", "身体还好么？", "我现在广州挺好的", "爸爸妈妈不要太牵挂", "虽然我很少写信", "其实我很想家", "WXD"}
        Len = letter.Length
        Dim t = Trigger(len)
        Dim w = Pic0.Width
        Dim h = Pic0.Height / (letter.Length + 1)
        For i As Integer = 0 To letter.Length - 1
            x = CSng(w - g.MeasureString(letter(i), f).Width) / 2
            y = CSng(h * i + h)
            If x = p Then
                t(i) = True
            End If

            If t(i) = True Then
                If i <> letter.Length - 1 Then
                    g.DrawString(letter(i), f, b, x, y)
                Else
                    g.DrawString(letter(i), f, b, 1.5 * x, y)
                End If
            End If

        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Dim ifc As New InstalledFontCollection
        'Dim fonts As FontFamily() = ifc.Families

        'Dim x As Single = 0.0F
        'Dim y As Single = 0.0F
        'For i As Integer = 0 To ifc.Families.Length - 1
        '    If ifc.Families(i).IsStyleAvailable(FontStyle.Regular) Then
        '        Console.WriteLine(ifc.Families(i).Name)
        '        y += 20
        '        If y Mod 700 = 0 Then
        '            x += 140
        '            y = 0
        '        End If
        '    End If
        'Next

    End Sub

    Private Sub Pic0_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Pic0.MouseDoubleClick
        Application.Exit()
    End Sub
End Class
