<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtNumToStr = New System.Windows.Forms.TextBox()
        Me.LblNumToStr = New System.Windows.Forms.Label()
        Me.TxtStrToNum = New System.Windows.Forms.TextBox()
        Me.LblStrToNum = New System.Windows.Forms.Label()
        Me.BtnNumToStr = New System.Windows.Forms.Button()
        Me.BtnStrToNum = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtNumToStr
        '
        Me.TxtNumToStr.Location = New System.Drawing.Point(13, 13)
        Me.TxtNumToStr.Name = "TxtNumToStr"
        Me.TxtNumToStr.Size = New System.Drawing.Size(190, 21)
        Me.TxtNumToStr.TabIndex = 0
        '
        'LblNumToStr
        '
        Me.LblNumToStr.AutoSize = True
        Me.LblNumToStr.Location = New System.Drawing.Point(13, 41)
        Me.LblNumToStr.Name = "LblNumToStr"
        Me.LblNumToStr.Size = New System.Drawing.Size(0, 12)
        Me.LblNumToStr.TabIndex = 1
        '
        'TxtStrToNum
        '
        Me.TxtStrToNum.Location = New System.Drawing.Point(12, 56)
        Me.TxtStrToNum.Name = "TxtStrToNum"
        Me.TxtStrToNum.Size = New System.Drawing.Size(190, 21)
        Me.TxtStrToNum.TabIndex = 0
        '
        'LblStrToNum
        '
        Me.LblStrToNum.AutoSize = True
        Me.LblStrToNum.Location = New System.Drawing.Point(12, 84)
        Me.LblStrToNum.Name = "LblStrToNum"
        Me.LblStrToNum.Size = New System.Drawing.Size(0, 12)
        Me.LblStrToNum.TabIndex = 1
        '
        'BtnNumToStr
        '
        Me.BtnNumToStr.Location = New System.Drawing.Point(209, 11)
        Me.BtnNumToStr.Name = "BtnNumToStr"
        Me.BtnNumToStr.Size = New System.Drawing.Size(75, 23)
        Me.BtnNumToStr.TabIndex = 2
        Me.BtnNumToStr.Text = "NumToStr"
        Me.BtnNumToStr.UseVisualStyleBackColor = True
        '
        'BtnStrToNum
        '
        Me.BtnStrToNum.Location = New System.Drawing.Point(208, 54)
        Me.BtnStrToNum.Name = "BtnStrToNum"
        Me.BtnStrToNum.Size = New System.Drawing.Size(75, 23)
        Me.BtnStrToNum.TabIndex = 2
        Me.BtnStrToNum.Text = "StrToNum"
        Me.BtnStrToNum.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 112)
        Me.Controls.Add(Me.BtnStrToNum)
        Me.Controls.Add(Me.BtnNumToStr)
        Me.Controls.Add(Me.LblStrToNum)
        Me.Controls.Add(Me.LblNumToStr)
        Me.Controls.Add(Me.TxtStrToNum)
        Me.Controls.Add(Me.TxtNumToStr)
        Me.Name = "Form1"
        Me.Text = "Number&String Convert"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNumToStr As TextBox
    Friend WithEvents LblNumToStr As Label
    Friend WithEvents TxtStrToNum As TextBox
    Friend WithEvents LblStrToNum As Label
    Friend WithEvents BtnNumToStr As Button
    Friend WithEvents BtnStrToNum As Button
End Class
