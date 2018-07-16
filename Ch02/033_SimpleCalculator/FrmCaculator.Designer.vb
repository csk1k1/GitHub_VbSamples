<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCaculator
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnEqual = New System.Windows.Forms.Button()
        Me.Btn0 = New System.Windows.Forms.Button()
        Me.BtnPoint = New System.Windows.Forms.Button()
        Me.BtnPlusMinus = New System.Windows.Forms.Button()
        Me.BtnPlus = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.BtnMinus = New System.Windows.Forms.Button()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.Btn6 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.BtnReciprocal = New System.Windows.Forms.Button()
        Me.BtnDivision = New System.Windows.Forms.Button()
        Me.BtnAsterisk = New System.Windows.Forms.Button()
        Me.BtnSqrt = New System.Windows.Forms.Button()
        Me.BtnC = New System.Windows.Forms.Button()
        Me.Btn8 = New System.Windows.Forms.Button()
        Me.BtnSqr = New System.Windows.Forms.Button()
        Me.BtnBackspace = New System.Windows.Forms.Button()
        Me.Btn9 = New System.Windows.Forms.Button()
        Me.BtnPct = New System.Windows.Forms.Button()
        Me.BtnCe = New System.Windows.Forms.Button()
        Me.Btn7 = New System.Windows.Forms.Button()
        Me.LblPrev = New System.Windows.Forms.Label()
        Me.LblCurrent = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.BtnEqual)
        Me.Panel1.Controls.Add(Me.Btn0)
        Me.Panel1.Controls.Add(Me.BtnPoint)
        Me.Panel1.Controls.Add(Me.BtnPlusMinus)
        Me.Panel1.Controls.Add(Me.BtnPlus)
        Me.Panel1.Controls.Add(Me.Btn2)
        Me.Panel1.Controls.Add(Me.Btn3)
        Me.Panel1.Controls.Add(Me.Btn1)
        Me.Panel1.Controls.Add(Me.BtnMinus)
        Me.Panel1.Controls.Add(Me.Btn5)
        Me.Panel1.Controls.Add(Me.Btn6)
        Me.Panel1.Controls.Add(Me.Btn4)
        Me.Panel1.Controls.Add(Me.BtnReciprocal)
        Me.Panel1.Controls.Add(Me.BtnDivision)
        Me.Panel1.Controls.Add(Me.BtnAsterisk)
        Me.Panel1.Controls.Add(Me.BtnSqrt)
        Me.Panel1.Controls.Add(Me.BtnC)
        Me.Panel1.Controls.Add(Me.Btn8)
        Me.Panel1.Controls.Add(Me.BtnSqr)
        Me.Panel1.Controls.Add(Me.BtnBackspace)
        Me.Panel1.Controls.Add(Me.Btn9)
        Me.Panel1.Controls.Add(Me.BtnPct)
        Me.Panel1.Controls.Add(Me.BtnCe)
        Me.Panel1.Controls.Add(Me.Btn7)
        Me.Panel1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Panel1.Location = New System.Drawing.Point(13, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(194, 277)
        Me.Panel1.TabIndex = 1
        '
        'BtnEqual
        '
        Me.BtnEqual.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnEqual.Location = New System.Drawing.Point(141, 234)
        Me.BtnEqual.Name = "BtnEqual"
        Me.BtnEqual.Size = New System.Drawing.Size(50, 40)
        Me.BtnEqual.TabIndex = 0
        Me.BtnEqual.Text = "="
        Me.BtnEqual.UseVisualStyleBackColor = True
        '
        'Btn0
        '
        Me.Btn0.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn0.Location = New System.Drawing.Point(49, 234)
        Me.Btn0.Name = "Btn0"
        Me.Btn0.Size = New System.Drawing.Size(50, 40)
        Me.Btn0.TabIndex = 0
        Me.Btn0.Text = "0"
        Me.Btn0.UseVisualStyleBackColor = True
        '
        'BtnPoint
        '
        Me.BtnPoint.Font = New System.Drawing.Font("宋体", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnPoint.Location = New System.Drawing.Point(95, 234)
        Me.BtnPoint.Name = "BtnPoint"
        Me.BtnPoint.Size = New System.Drawing.Size(50, 40)
        Me.BtnPoint.TabIndex = 0
        Me.BtnPoint.Text = "."
        Me.BtnPoint.UseVisualStyleBackColor = True
        '
        'BtnPlusMinus
        '
        Me.BtnPlusMinus.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnPlusMinus.Location = New System.Drawing.Point(3, 234)
        Me.BtnPlusMinus.Name = "BtnPlusMinus"
        Me.BtnPlusMinus.Size = New System.Drawing.Size(50, 40)
        Me.BtnPlusMinus.TabIndex = 0
        Me.BtnPlusMinus.Text = "±"
        Me.BtnPlusMinus.UseVisualStyleBackColor = True
        '
        'BtnPlus
        '
        Me.BtnPlus.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnPlus.Location = New System.Drawing.Point(141, 188)
        Me.BtnPlus.Name = "BtnPlus"
        Me.BtnPlus.Size = New System.Drawing.Size(50, 40)
        Me.BtnPlus.TabIndex = 0
        Me.BtnPlus.Text = "+"
        Me.BtnPlus.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn2.Location = New System.Drawing.Point(49, 188)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(50, 40)
        Me.Btn2.TabIndex = 0
        Me.Btn2.Text = "2"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Btn3
        '
        Me.Btn3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn3.Location = New System.Drawing.Point(95, 188)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(50, 40)
        Me.Btn3.TabIndex = 0
        Me.Btn3.Text = "3"
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'Btn1
        '
        Me.Btn1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn1.Location = New System.Drawing.Point(3, 188)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(50, 40)
        Me.Btn1.TabIndex = 0
        Me.Btn1.Text = "1"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'BtnMinus
        '
        Me.BtnMinus.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnMinus.Location = New System.Drawing.Point(141, 142)
        Me.BtnMinus.Name = "BtnMinus"
        Me.BtnMinus.Size = New System.Drawing.Size(50, 40)
        Me.BtnMinus.TabIndex = 0
        Me.BtnMinus.Text = "-"
        Me.BtnMinus.UseVisualStyleBackColor = True
        '
        'Btn5
        '
        Me.Btn5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn5.Location = New System.Drawing.Point(49, 142)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(50, 40)
        Me.Btn5.TabIndex = 0
        Me.Btn5.Text = "5"
        Me.Btn5.UseVisualStyleBackColor = True
        '
        'Btn6
        '
        Me.Btn6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn6.Location = New System.Drawing.Point(95, 142)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(50, 40)
        Me.Btn6.TabIndex = 0
        Me.Btn6.Text = "6"
        Me.Btn6.UseVisualStyleBackColor = True
        '
        'Btn4
        '
        Me.Btn4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn4.Location = New System.Drawing.Point(3, 142)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(50, 40)
        Me.Btn4.TabIndex = 0
        Me.Btn4.Text = "4"
        Me.Btn4.UseVisualStyleBackColor = True
        '
        'BtnReciprocal
        '
        Me.BtnReciprocal.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnReciprocal.Location = New System.Drawing.Point(141, 4)
        Me.BtnReciprocal.Name = "BtnReciprocal"
        Me.BtnReciprocal.Size = New System.Drawing.Size(50, 40)
        Me.BtnReciprocal.TabIndex = 0
        Me.BtnReciprocal.Text = "1/x"
        Me.BtnReciprocal.UseVisualStyleBackColor = True
        '
        'BtnDivision
        '
        Me.BtnDivision.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnDivision.Location = New System.Drawing.Point(141, 50)
        Me.BtnDivision.Name = "BtnDivision"
        Me.BtnDivision.Size = New System.Drawing.Size(50, 40)
        Me.BtnDivision.TabIndex = 0
        Me.BtnDivision.Text = "÷"
        Me.BtnDivision.UseVisualStyleBackColor = True
        '
        'BtnAsterisk
        '
        Me.BtnAsterisk.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnAsterisk.Location = New System.Drawing.Point(141, 96)
        Me.BtnAsterisk.Name = "BtnAsterisk"
        Me.BtnAsterisk.Size = New System.Drawing.Size(50, 40)
        Me.BtnAsterisk.TabIndex = 0
        Me.BtnAsterisk.Text = "*"
        Me.BtnAsterisk.UseVisualStyleBackColor = True
        '
        'BtnSqrt
        '
        Me.BtnSqrt.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnSqrt.Location = New System.Drawing.Point(49, 4)
        Me.BtnSqrt.Name = "BtnSqrt"
        Me.BtnSqrt.Size = New System.Drawing.Size(50, 40)
        Me.BtnSqrt.TabIndex = 0
        Me.BtnSqrt.Text = "√"
        Me.BtnSqrt.UseVisualStyleBackColor = True
        '
        'BtnC
        '
        Me.BtnC.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnC.Location = New System.Drawing.Point(49, 50)
        Me.BtnC.Name = "BtnC"
        Me.BtnC.Size = New System.Drawing.Size(50, 40)
        Me.BtnC.TabIndex = 0
        Me.BtnC.Text = "C"
        Me.BtnC.UseVisualStyleBackColor = True
        '
        'Btn8
        '
        Me.Btn8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn8.Location = New System.Drawing.Point(49, 96)
        Me.Btn8.Name = "Btn8"
        Me.Btn8.Size = New System.Drawing.Size(50, 40)
        Me.Btn8.TabIndex = 0
        Me.Btn8.Text = "8"
        Me.Btn8.UseVisualStyleBackColor = True
        '
        'BtnSqr
        '
        Me.BtnSqr.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnSqr.Location = New System.Drawing.Point(95, 4)
        Me.BtnSqr.Name = "BtnSqr"
        Me.BtnSqr.Size = New System.Drawing.Size(50, 40)
        Me.BtnSqr.TabIndex = 0
        Me.BtnSqr.Text = "x²"
        Me.BtnSqr.UseVisualStyleBackColor = True
        '
        'BtnBackspace
        '
        Me.BtnBackspace.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnBackspace.Location = New System.Drawing.Point(95, 50)
        Me.BtnBackspace.Name = "BtnBackspace"
        Me.BtnBackspace.Size = New System.Drawing.Size(50, 40)
        Me.BtnBackspace.TabIndex = 0
        Me.BtnBackspace.Text = "退格"
        Me.BtnBackspace.UseVisualStyleBackColor = True
        '
        'Btn9
        '
        Me.Btn9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn9.Location = New System.Drawing.Point(95, 96)
        Me.Btn9.Name = "Btn9"
        Me.Btn9.Size = New System.Drawing.Size(50, 40)
        Me.Btn9.TabIndex = 0
        Me.Btn9.Text = "9"
        Me.Btn9.UseVisualStyleBackColor = True
        '
        'BtnPct
        '
        Me.BtnPct.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnPct.Location = New System.Drawing.Point(3, 4)
        Me.BtnPct.Name = "BtnPct"
        Me.BtnPct.Size = New System.Drawing.Size(50, 40)
        Me.BtnPct.TabIndex = 0
        Me.BtnPct.Text = "％"
        Me.BtnPct.UseVisualStyleBackColor = True
        '
        'BtnCe
        '
        Me.BtnCe.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnCe.Location = New System.Drawing.Point(3, 50)
        Me.BtnCe.Name = "BtnCe"
        Me.BtnCe.Size = New System.Drawing.Size(50, 40)
        Me.BtnCe.TabIndex = 0
        Me.BtnCe.Text = "CE"
        Me.BtnCe.UseVisualStyleBackColor = True
        '
        'Btn7
        '
        Me.Btn7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn7.Location = New System.Drawing.Point(3, 96)
        Me.Btn7.Name = "Btn7"
        Me.Btn7.Size = New System.Drawing.Size(50, 40)
        Me.Btn7.TabIndex = 0
        Me.Btn7.Text = "7"
        Me.Btn7.UseVisualStyleBackColor = True
        '
        'LblPrev
        '
        Me.LblPrev.Location = New System.Drawing.Point(13, 4)
        Me.LblPrev.Name = "LblPrev"
        Me.LblPrev.Size = New System.Drawing.Size(194, 26)
        Me.LblPrev.TabIndex = 2
        Me.LblPrev.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblCurrent
        '
        Me.LblCurrent.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblCurrent.Location = New System.Drawing.Point(11, 30)
        Me.LblCurrent.Name = "LblCurrent"
        Me.LblCurrent.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblCurrent.Size = New System.Drawing.Size(195, 47)
        Me.LblCurrent.TabIndex = 2
        Me.LblCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCaculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(211, 360)
        Me.Controls.Add(Me.LblCurrent)
        Me.Controls.Add(Me.LblPrev)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmCaculator"
        Me.Text = "Calculator V1.0"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnEqual As Button
    Friend WithEvents Btn0 As Button
    Friend WithEvents BtnPoint As Button
    Friend WithEvents BtnPlusMinus As Button
    Friend WithEvents BtnPlus As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents Btn1 As Button
    Friend WithEvents BtnMinus As Button
    Friend WithEvents Btn5 As Button
    Friend WithEvents Btn6 As Button
    Friend WithEvents Btn4 As Button
    Friend WithEvents BtnReciprocal As Button
    Friend WithEvents BtnDivision As Button
    Friend WithEvents BtnAsterisk As Button
    Friend WithEvents BtnSqrt As Button
    Friend WithEvents BtnC As Button
    Friend WithEvents Btn8 As Button
    Friend WithEvents BtnSqr As Button
    Friend WithEvents BtnBackspace As Button
    Friend WithEvents Btn9 As Button
    Friend WithEvents BtnPct As Button
    Friend WithEvents BtnCe As Button
    Friend WithEvents Btn7 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblPrev As Label
    Friend WithEvents LblCurrent As Label
End Class
