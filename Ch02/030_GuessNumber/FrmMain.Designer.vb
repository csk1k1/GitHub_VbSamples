<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.Lbl0 = New System.Windows.Forms.Label()
        Me.TxtNum = New System.Windows.Forms.TextBox()
        Me.LblCap = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LblCount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbl0
        '
        Me.Lbl0.AutoSize = True
        Me.Lbl0.Location = New System.Drawing.Point(20, 21)
        Me.Lbl0.Name = "Lbl0"
        Me.Lbl0.Size = New System.Drawing.Size(173, 12)
        Me.Lbl0.TabIndex = 0
        Me.Lbl0.Text = "请输入你猜测的数字(0-1000): "
        '
        'TxtNum
        '
        Me.TxtNum.Location = New System.Drawing.Point(199, 18)
        Me.TxtNum.Name = "TxtNum"
        Me.TxtNum.Size = New System.Drawing.Size(100, 21)
        Me.TxtNum.TabIndex = 1
        '
        'LblCap
        '
        Me.LblCap.AutoSize = True
        Me.LblCap.Location = New System.Drawing.Point(141, 56)
        Me.LblCap.Name = "LblCap"
        Me.LblCap.Size = New System.Drawing.Size(0, 12)
        Me.LblCap.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(305, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Try"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LblCount
        '
        Me.LblCount.AutoSize = True
        Me.LblCount.Location = New System.Drawing.Point(210, 3)
        Me.LblCount.Name = "LblCount"
        Me.LblCount.Size = New System.Drawing.Size(89, 12)
        Me.LblCount.TabIndex = 4
        Me.LblCount.Text = "GuessCounter: "
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 73)
        Me.Controls.Add(Me.LblCount)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblCap)
        Me.Controls.Add(Me.TxtNum)
        Me.Controls.Add(Me.Lbl0)
        Me.Name = "FrmMain"
        Me.Text = "GuessNumber v1.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl0 As Label
    Friend WithEvents TxtNum As TextBox
    Friend WithEvents LblCap As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LblCount As Label
End Class
