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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSum = New System.Windows.Forms.TextBox()
        Me.txtApplePrice = New System.Windows.Forms.TextBox()
        Me.txtBananaPrice = New System.Windows.Forms.TextBox()
        Me.txtOrangePrice = New System.Windows.Forms.TextBox()
        Me.txtAppleSales = New System.Windows.Forms.TextBox()
        Me.txtBananaSales = New System.Windows.Forms.TextBox()
        Me.txtOrangeSales = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "苹果"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "香蕉"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "橘子"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(70, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "单价："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(70, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "单价："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(70, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "单价："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(208, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 12)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "销量："
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(208, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 12)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "销量："
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(208, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 12)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "销量："
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(30, 127)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 12)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "加权平均值为： "
        '
        'txtSum
        '
        Me.txtSum.Location = New System.Drawing.Point(144, 123)
        Me.txtSum.Name = "txtSum"
        Me.txtSum.Size = New System.Drawing.Size(75, 21)
        Me.txtSum.TabIndex = 1
        '
        'txtApplePrice
        '
        Me.txtApplePrice.Location = New System.Drawing.Point(122, 27)
        Me.txtApplePrice.Name = "txtApplePrice"
        Me.txtApplePrice.Size = New System.Drawing.Size(75, 21)
        Me.txtApplePrice.TabIndex = 1
        '
        'txtBananaPrice
        '
        Me.txtBananaPrice.Location = New System.Drawing.Point(122, 54)
        Me.txtBananaPrice.Name = "txtBananaPrice"
        Me.txtBananaPrice.Size = New System.Drawing.Size(75, 21)
        Me.txtBananaPrice.TabIndex = 1
        '
        'txtOrangePrice
        '
        Me.txtOrangePrice.Location = New System.Drawing.Point(122, 81)
        Me.txtOrangePrice.Name = "txtOrangePrice"
        Me.txtOrangePrice.Size = New System.Drawing.Size(75, 21)
        Me.txtOrangePrice.TabIndex = 1
        '
        'txtAppleSales
        '
        Me.txtAppleSales.Location = New System.Drawing.Point(260, 27)
        Me.txtAppleSales.Name = "txtAppleSales"
        Me.txtAppleSales.Size = New System.Drawing.Size(75, 21)
        Me.txtAppleSales.TabIndex = 1
        '
        'txtBananaSales
        '
        Me.txtBananaSales.Location = New System.Drawing.Point(260, 54)
        Me.txtBananaSales.Name = "txtBananaSales"
        Me.txtBananaSales.Size = New System.Drawing.Size(75, 21)
        Me.txtBananaSales.TabIndex = 1
        '
        'txtOrangeSales
        '
        Me.txtOrangeSales.Location = New System.Drawing.Point(260, 81)
        Me.txtOrangeSales.Name = "txtOrangeSales"
        Me.txtOrangeSales.Size = New System.Drawing.Size(75, 21)
        Me.txtOrangeSales.TabIndex = 1
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(256, 122)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "Caculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtOrangeSales)
        Me.Controls.Add(Me.txtOrangePrice)
        Me.Controls.Add(Me.txtBananaSales)
        Me.Controls.Add(Me.txtBananaPrice)
        Me.Controls.Add(Me.txtAppleSales)
        Me.Controls.Add(Me.txtApplePrice)
        Me.Controls.Add(Me.txtSum)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSum As TextBox
    Friend WithEvents txtApplePrice As TextBox
    Friend WithEvents txtBananaPrice As TextBox
    Friend WithEvents txtOrangePrice As TextBox
    Friend WithEvents txtAppleSales As TextBox
    Friend WithEvents txtBananaSales As TextBox
    Friend WithEvents txtOrangeSales As TextBox
    Friend WithEvents btnCalc As Button
End Class
