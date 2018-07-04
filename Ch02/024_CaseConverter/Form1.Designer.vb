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
        Me.LblToUpper = New System.Windows.Forms.Label()
        Me.TxtToUpper = New System.Windows.Forms.TextBox()
        Me.LblTolower = New System.Windows.Forms.Label()
        Me.TxtToLower = New System.Windows.Forms.TextBox()
        Me.BtnToUpper = New System.Windows.Forms.Button()
        Me.BtnToLower = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblToUpper
        '
        Me.LblToUpper.AutoSize = True
        Me.LblToUpper.Location = New System.Drawing.Point(13, 73)
        Me.LblToUpper.Name = "LblToUpper"
        Me.LblToUpper.Size = New System.Drawing.Size(0, 12)
        Me.LblToUpper.TabIndex = 0
        '
        'TxtToUpper
        '
        Me.TxtToUpper.Location = New System.Drawing.Point(15, 35)
        Me.TxtToUpper.Name = "TxtToUpper"
        Me.TxtToUpper.Size = New System.Drawing.Size(307, 21)
        Me.TxtToUpper.TabIndex = 1
        '
        'LblTolower
        '
        Me.LblTolower.AutoSize = True
        Me.LblTolower.Location = New System.Drawing.Point(13, 153)
        Me.LblTolower.Name = "LblTolower"
        Me.LblTolower.Size = New System.Drawing.Size(0, 12)
        Me.LblTolower.TabIndex = 0
        '
        'TxtToLower
        '
        Me.TxtToLower.Location = New System.Drawing.Point(15, 115)
        Me.TxtToLower.Name = "TxtToLower"
        Me.TxtToLower.Size = New System.Drawing.Size(307, 21)
        Me.TxtToLower.TabIndex = 1
        '
        'BtnToUpper
        '
        Me.BtnToUpper.Location = New System.Drawing.Point(339, 33)
        Me.BtnToUpper.Name = "BtnToUpper"
        Me.BtnToUpper.Size = New System.Drawing.Size(75, 23)
        Me.BtnToUpper.TabIndex = 2
        Me.BtnToUpper.Text = "转换大写"
        Me.BtnToUpper.UseVisualStyleBackColor = True
        '
        'BtnToLower
        '
        Me.BtnToLower.Location = New System.Drawing.Point(339, 115)
        Me.BtnToLower.Name = "BtnToLower"
        Me.BtnToLower.Size = New System.Drawing.Size(75, 23)
        Me.BtnToLower.TabIndex = 2
        Me.BtnToLower.Text = "转换小写"
        Me.BtnToLower.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 198)
        Me.Controls.Add(Me.BtnToLower)
        Me.Controls.Add(Me.BtnToUpper)
        Me.Controls.Add(Me.TxtToLower)
        Me.Controls.Add(Me.LblTolower)
        Me.Controls.Add(Me.TxtToUpper)
        Me.Controls.Add(Me.LblToUpper)
        Me.Name = "Form1"
        Me.Text = "字母大小写转换"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblToUpper As Label
    Friend WithEvents TxtToUpper As TextBox
    Friend WithEvents LblTolower As Label
    Friend WithEvents TxtToLower As TextBox
    Friend WithEvents BtnToUpper As Button
    Friend WithEvents BtnToLower As Button
End Class
