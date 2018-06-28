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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtUpper = New System.Windows.Forms.TextBox()
        Me.TxtLower = New System.Windows.Forms.TextBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnConvert = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("华文行楷", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.IndianRed
        Me.Label1.Location = New System.Drawing.Point(52, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(468, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "人民币大小写转换器  v1.0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 12)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "输入小写金额:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 12)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "自动大写金额: "
        '
        'TxtUpper
        '
        Me.TxtUpper.Location = New System.Drawing.Point(130, 114)
        Me.TxtUpper.Name = "TxtUpper"
        Me.TxtUpper.Size = New System.Drawing.Size(361, 21)
        Me.TxtUpper.TabIndex = 1
        '
        'TxtLower
        '
        Me.TxtLower.Location = New System.Drawing.Point(130, 81)
        Me.TxtLower.Name = "TxtLower"
        Me.TxtLower.Size = New System.Drawing.Size(361, 21)
        Me.TxtLower.TabIndex = 1
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(497, 112)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 2
        Me.BtnExit.Text = " 退出"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnConvert
        '
        Me.BtnConvert.Location = New System.Drawing.Point(497, 79)
        Me.BtnConvert.Name = "BtnConvert"
        Me.BtnConvert.Size = New System.Drawing.Size(75, 23)
        Me.BtnConvert.TabIndex = 3
        Me.BtnConvert.Text = "转换"
        Me.BtnConvert.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 12)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tips：数字金额最多支持千亿级别"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(330, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 12)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Author:王旭栋 QQ:260726000"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 221)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnConvert)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.TxtLower)
        Me.Controls.Add(Me.TxtUpper)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "RMB Converter V1.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtUpper As TextBox
    Friend WithEvents TxtLower As TextBox
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnConvert As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
