<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(104, 49)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(75, 23)
        Me.BtnStart.TabIndex = 0
        Me.BtnStart.Text = "GAME START"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 112)
        Me.Controls.Add(Me.BtnStart)
        Me.Name = "FrmLogin"
        Me.Text = "Guess Number V1.0"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnStart As Button
End Class
