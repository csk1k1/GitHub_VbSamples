Imports System.Drawing
Imports System.Drawing.Graphics
Imports System.Drawing.Text
Imports System.Runtime.InteropServices

Public Class Form1

    Private len As Integer
    Private x, y As Single
    'Private t() As Boolean
    'Private p As Integer
    'Private i As Integer
    Dim offSetX, offSetY As Integer

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Location = New Point(Cursor.Position.X - offSetX, Cursor.Position.Y - offSetY)
    End Sub

    Private Sub Pic0_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Pic0.MouseDown
        offSetX = PointToClient(Cursor.Position).X
        offSetY = PointToClient(Cursor.Position).Y
        Timer1.Enabled = True
    End Sub

    Private Sub Pic0_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Pic0.MouseUp
        Timer1.Enabled = False
    End Sub
    Private Sub Pic0_MouseMove(sender As Object, e As MouseEventArgs) Handles Pic0.MouseMove
        'p = MousePosition.Y

        'Pic0.Refresh()
        'Me.Invalidate()
    End Sub

    'Private Function Trigger(ByVal n As Integer) As Boolean()

    '    ReDim t(n)
    '    For j As Integer = 0 To n
    '        t(j) = False
    '    Next
    '    Return t
    'End Function

    Private Sub Pic0_Paint(sender As Object, e As PaintEventArgs) Handles Pic0.Paint

        Dim g As Graphics = e.Graphics
        Dim f As New Font("华文行楷", 12)
        Dim b As Brush = Brushes.Black
        Dim letter As String() = {"一封家书", "亲爱的爸爸妈妈：", "你们好吗", "现在工作很忙吧！", "身体还好么？", "我现在广州挺好的", "爸爸妈妈不要太牵挂", "虽然我很少写信", "其实我很想家", "WXD"}
        Len = letter.Length
        Dim w = Pic0.Width
        Dim h = Pic0.Height / (letter.Length + 1)
        For i = 0 To letter.Length - 1
            x = CSng(w - g.MeasureString(letter(i), f).Width) / 2
            y = CSng(h * i + h)

            If i <> len - 1 Then
                g.DrawString(letter(i), f, b, x, y)
            Else
                g.DrawString(letter(i), f, b, 1.5 * x, y)
            End If
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Pic0.Cursor = New Cursor("C:\Users\WXD\source\repos\VBSamples\Ch01\028_一封家书\Source\Cur\Text_Hnd.cur")

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
