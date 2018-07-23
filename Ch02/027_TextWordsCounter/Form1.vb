Imports System.IO
Imports System.Text
Imports Microsoft.Office.Interop.Word
Public Class Form1

    Private strFileName As String = ""
    Private myStream As Stream
    Private builder As StringBuilder
    Private result As Char()
    Private strInitialPath As String = "C:\Users\Administrator\Desktop"
    Private strFilter As String = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
    Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles BtnShow.Click
        Dim wordApp As New Application
        Dim myDoc As New Document
        Dim wordDlg As Dialog
        Try
            myDoc.Range.Text = TxtBox.Text
            wordDlg = myDoc.Application.Dialogs(WdWordDialog.wdDialogDocumentStatistics)
            LblWordNum.Text = "Num of Words: " & CStr(wordDlg.Words)
            LblCharNum.Text = "Num of Chars: " & CStr(wordDlg.Characters)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            myDoc.Close(SaveChanges:=False)
            'myDoc.Application.Quit(SaveChanges:=False)
        End Try
    End Sub

    Private Async Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles BtnOpen.Click
        Dim openDlg = New OpenFileDialog With {
            .InitialDirectory = strInitialPath,
            .Filter = strFilter,
            .FilterIndex = 2,
            .RestoreDirectory = True
        }

        'Dim builder As StringBuilder = New StringBuilder()

        If openDlg.ShowDialog() = DialogResult.OK Then
            Try
                myStream = openDlg.OpenFile()
                strFileName = openDlg.FileName
                TxtPath.Text = strFileName
                If (myStream IsNot Nothing) Then
                    'VERSION3: streamReader.ReadToEndAsync | using filename
                    Using sr As StreamReader = New StreamReader(strFileName, Encoding.Default)
                        TxtBox.Text = Await sr.ReadToEndAsync
                    End Using

                    ''VERSION2: StreamReader.ReadLineAsync
                    'Using sr As StreamReader = New StreamReader(myStream, Encoding.Default)
                    '    Dim eCode = sr.CurrentEncoding.ToString + vbCrLf
                    '    Do While sr.Peek > -1
                    '        'result += Await sr.ReadLineAsync()
                    '        builder.AppendLine(Await sr.ReadLineAsync())
                    '    Loop
                    'End Using
                    'builder.Insert(0, eCode)
                    'TxtBox.Text = builder.ToString

                    'VERSION 1: StreamReader.ReadAsync
                    'Using reader = New StreamReader(myStream, Encoding.Default)
                    '    ReDim result(reader.BaseStream.Length)
                    '    Await reader.ReadAsync(result, 0, reader.BaseStream.Length)
                    '    Dim eCode = reader.CurrentEncoding.ToString() + "\r"
                    'End Using

                    'For Each c As Char In result
                    '    builder.Append(c)
                    'Next
                    'TxtBox.Text = "Encoding: " + eCode + builder.ToString()
                End If
            Catch Ex As FileNotFoundException
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If




    End Sub

    Private Sub BtnSave_ClickAsync(sender As Object, e As EventArgs) Handles BtnSave.Click
        ' Code to write the stream goes here.

        'Version2:
        If strFileName <> "" Then
            File.WriteAllText(strFileName, TxtBox.Text, Encoding.Default)
        Else
            Call BtnSaveAs_Click(sender, e)
        End If

        'Version1: use StreamWriter
        'If strFileName <> "" Then

        '    Using sw As New StreamWriter(strFileName, False, Encoding.Default)
        '        Await sw.WriteAsync(TxtBox.Text)
        '    End Using

        'End If

    End Sub

    Private Sub BtnSaveAs_Click(sender As Object, e As EventArgs) Handles BtnSaveAs.Click
        Dim saveDlg As SaveFileDialog = New SaveFileDialog With {
            .InitialDirectory = strInitialPath,
            .Filter = strFilter,
            .FilterIndex = 1,
            .DefaultExt = "txt",
            .AddExtension = True,
            .RestoreDirectory = True,
            .OverwritePrompt = True
        }

        If saveDlg.ShowDialog() = DialogResult.OK Then
            Try
                strFileName = saveDlg.FileName
                TxtPath.Text = strFileName
                File.WriteAllText(strFileName, TxtBox.Text, Encoding.Default)
                'My.Computer.FileSystem.WriteAllText(strFileName, TxtBox.Text, False, Encoding.Default)
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                saveDlg.Dispose()
            End Try

            'Try
            '    myStream = saveDlg.OpenFile()

            '    If (myStream IsNot Nothing) Then
            '        ' Code to write the stream goes here.
            '        'myStream.Close()
            '        Using sw As New StreamWriter(myStream, Encoding.Default)
            '            Await sw.WriteAsync(TxtBox.Text)
            '        End Using
            '    End If
            'Catch Ex As Exception
            '    MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            'Finally
            '    If (myStream IsNot Nothing) Then
            '        myStream.Close()
            '    End If
            '    saveDlg.Dispose()
            'End Try
        End If

    End Sub

    Private Sub TxtBox_TextChanged(sender As Object, e As EventArgs) Handles TxtBox.TextChanged
    End Sub
End Class
