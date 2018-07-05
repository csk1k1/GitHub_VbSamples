<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataTypeChecker
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
        Me.BtnCheck = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtData = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnCheck
        '
        Me.BtnCheck.Location = New System.Drawing.Point(145, 37)
        Me.BtnCheck.Name = "BtnCheck"
        Me.BtnCheck.Size = New System.Drawing.Size(75, 23)
        Me.BtnCheck.TabIndex = 0
        Me.BtnCheck.Text = "Check"
        Me.BtnCheck.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Input the data: "
        '
        'TxtData
        '
        Me.TxtData.Location = New System.Drawing.Point(120, 10)
        Me.TxtData.Name = "TxtData"
        Me.TxtData.Size = New System.Drawing.Size(100, 21)
        Me.TxtData.TabIndex = 2
        '
        'DataTypeChecker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtData)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCheck)
        Me.Name = "DataTypeChecker"
        Me.Text = "DataTypeChecker V1.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCheck As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtData As TextBox
End Class
