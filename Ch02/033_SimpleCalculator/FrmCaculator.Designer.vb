<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCaculator
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PnlShow = New System.Windows.Forms.Panel()
        Me.LblEx = New System.Windows.Forms.Label()
        Me.LblResult = New System.Windows.Forms.Label()
        Me.BtnEqual = New System.Windows.Forms.Button()
        Me.Btn0 = New System.Windows.Forms.Button()
        Me.BtnDot = New System.Windows.Forms.Button()
        Me.BtnPN = New System.Windows.Forms.Button()
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PnlShow.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlShow
        '
        Me.PnlShow.Controls.Add(Me.LblEx)
        Me.PnlShow.Controls.Add(Me.LblResult)
        Me.PnlShow.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlShow.Location = New System.Drawing.Point(0, 0)
        Me.PnlShow.Name = "PnlShow"
        Me.PnlShow.Size = New System.Drawing.Size(224, 100)
        Me.PnlShow.TabIndex = 25
        '
        'LblEx
        '
        Me.LblEx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblEx.Font = New System.Drawing.Font("Agency FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEx.ForeColor = System.Drawing.Color.Gray
        Me.LblEx.Location = New System.Drawing.Point(0, 0)
        Me.LblEx.Name = "LblEx"
        Me.LblEx.Size = New System.Drawing.Size(224, 41)
        Me.LblEx.TabIndex = 26
        Me.LblEx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblResult
        '
        Me.LblResult.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LblResult.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResult.ForeColor = System.Drawing.Color.Black
        Me.LblResult.Location = New System.Drawing.Point(0, 41)
        Me.LblResult.Name = "LblResult"
        Me.LblResult.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblResult.Size = New System.Drawing.Size(224, 59)
        Me.LblResult.TabIndex = 27
        Me.LblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnEqual
        '
        Me.BtnEqual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnEqual.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnEqual.Location = New System.Drawing.Point(171, 283)
        Me.BtnEqual.Name = "BtnEqual"
        Me.BtnEqual.Size = New System.Drawing.Size(50, 55)
        Me.BtnEqual.TabIndex = 12
        Me.BtnEqual.Text = "="
        Me.BtnEqual.UseVisualStyleBackColor = True
        '
        'Btn0
        '
        Me.Btn0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn0.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn0.Location = New System.Drawing.Point(59, 283)
        Me.Btn0.Name = "Btn0"
        Me.Btn0.Size = New System.Drawing.Size(50, 55)
        Me.Btn0.TabIndex = 0
        Me.Btn0.Text = "0"
        Me.Btn0.UseVisualStyleBackColor = True
        '
        'BtnDot
        '
        Me.BtnDot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnDot.Font = New System.Drawing.Font("宋体", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnDot.Location = New System.Drawing.Point(115, 283)
        Me.BtnDot.Name = "BtnDot"
        Me.BtnDot.Size = New System.Drawing.Size(50, 55)
        Me.BtnDot.TabIndex = 11
        Me.BtnDot.Text = "."
        Me.BtnDot.UseVisualStyleBackColor = True
        '
        'BtnPN
        '
        Me.BtnPN.AccessibleDescription = "Positive And Negative"
        Me.BtnPN.AccessibleName = "正负符号"
        Me.BtnPN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnPN.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnPN.Location = New System.Drawing.Point(3, 283)
        Me.BtnPN.Name = "BtnPN"
        Me.BtnPN.Size = New System.Drawing.Size(50, 55)
        Me.BtnPN.TabIndex = 10
        Me.BtnPN.Text = "±"
        Me.BtnPN.UseVisualStyleBackColor = True
        '
        'BtnPlus
        '
        Me.BtnPlus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnPlus.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnPlus.Location = New System.Drawing.Point(171, 227)
        Me.BtnPlus.Name = "BtnPlus"
        Me.BtnPlus.Size = New System.Drawing.Size(50, 50)
        Me.BtnPlus.TabIndex = 13
        Me.BtnPlus.Text = "+"
        Me.BtnPlus.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn2.Location = New System.Drawing.Point(59, 227)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(50, 50)
        Me.Btn2.TabIndex = 2
        Me.Btn2.Text = "2"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Btn3
        '
        Me.Btn3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn3.Location = New System.Drawing.Point(115, 227)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(50, 50)
        Me.Btn3.TabIndex = 3
        Me.Btn3.Text = "3"
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'Btn1
        '
        Me.Btn1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn1.Location = New System.Drawing.Point(3, 227)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(50, 50)
        Me.Btn1.TabIndex = 1
        Me.Btn1.Text = "1"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'BtnMinus
        '
        Me.BtnMinus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnMinus.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnMinus.Location = New System.Drawing.Point(171, 171)
        Me.BtnMinus.Name = "BtnMinus"
        Me.BtnMinus.Size = New System.Drawing.Size(50, 50)
        Me.BtnMinus.TabIndex = 14
        Me.BtnMinus.Text = "-"
        Me.BtnMinus.UseVisualStyleBackColor = True
        '
        'Btn5
        '
        Me.Btn5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn5.Location = New System.Drawing.Point(59, 171)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(50, 50)
        Me.Btn5.TabIndex = 5
        Me.Btn5.Text = "5"
        Me.Btn5.UseVisualStyleBackColor = True
        '
        'Btn6
        '
        Me.Btn6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn6.Location = New System.Drawing.Point(115, 171)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(50, 50)
        Me.Btn6.TabIndex = 6
        Me.Btn6.Text = "6"
        Me.Btn6.UseVisualStyleBackColor = True
        '
        'Btn4
        '
        Me.Btn4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn4.Location = New System.Drawing.Point(3, 171)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(50, 50)
        Me.Btn4.TabIndex = 4
        Me.Btn4.Text = "4"
        Me.Btn4.UseVisualStyleBackColor = True
        '
        'BtnReciprocal
        '
        Me.BtnReciprocal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnReciprocal.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnReciprocal.Location = New System.Drawing.Point(171, 3)
        Me.BtnReciprocal.Name = "BtnReciprocal"
        Me.BtnReciprocal.Size = New System.Drawing.Size(50, 50)
        Me.BtnReciprocal.TabIndex = 23
        Me.BtnReciprocal.Text = "1/x"
        Me.BtnReciprocal.UseVisualStyleBackColor = True
        '
        'BtnDivision
        '
        Me.BtnDivision.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnDivision.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnDivision.Location = New System.Drawing.Point(171, 59)
        Me.BtnDivision.Name = "BtnDivision"
        Me.BtnDivision.Size = New System.Drawing.Size(50, 50)
        Me.BtnDivision.TabIndex = 19
        Me.BtnDivision.Text = "÷"
        Me.BtnDivision.UseVisualStyleBackColor = True
        '
        'BtnAsterisk
        '
        Me.BtnAsterisk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnAsterisk.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnAsterisk.Location = New System.Drawing.Point(171, 115)
        Me.BtnAsterisk.Name = "BtnAsterisk"
        Me.BtnAsterisk.Size = New System.Drawing.Size(50, 50)
        Me.BtnAsterisk.TabIndex = 15
        Me.BtnAsterisk.Text = "*"
        Me.BtnAsterisk.UseVisualStyleBackColor = True
        '
        'BtnSqrt
        '
        Me.BtnSqrt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnSqrt.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnSqrt.Location = New System.Drawing.Point(59, 3)
        Me.BtnSqrt.Name = "BtnSqrt"
        Me.BtnSqrt.Size = New System.Drawing.Size(50, 50)
        Me.BtnSqrt.TabIndex = 21
        Me.BtnSqrt.Text = "√"
        Me.BtnSqrt.UseVisualStyleBackColor = True
        '
        'BtnC
        '
        Me.BtnC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnC.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnC.Location = New System.Drawing.Point(59, 59)
        Me.BtnC.Name = "BtnC"
        Me.BtnC.Size = New System.Drawing.Size(50, 50)
        Me.BtnC.TabIndex = 17
        Me.BtnC.Text = "C"
        Me.BtnC.UseVisualStyleBackColor = True
        '
        'Btn8
        '
        Me.Btn8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn8.Location = New System.Drawing.Point(59, 115)
        Me.Btn8.Name = "Btn8"
        Me.Btn8.Size = New System.Drawing.Size(50, 50)
        Me.Btn8.TabIndex = 8
        Me.Btn8.Text = "8"
        Me.Btn8.UseVisualStyleBackColor = True
        '
        'BtnSqr
        '
        Me.BtnSqr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnSqr.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnSqr.Location = New System.Drawing.Point(115, 3)
        Me.BtnSqr.Name = "BtnSqr"
        Me.BtnSqr.Size = New System.Drawing.Size(50, 50)
        Me.BtnSqr.TabIndex = 22
        Me.BtnSqr.Text = "x²"
        Me.BtnSqr.UseVisualStyleBackColor = True
        '
        'BtnBackspace
        '
        Me.BtnBackspace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnBackspace.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnBackspace.Location = New System.Drawing.Point(115, 59)
        Me.BtnBackspace.Name = "BtnBackspace"
        Me.BtnBackspace.Size = New System.Drawing.Size(50, 50)
        Me.BtnBackspace.TabIndex = 18
        Me.BtnBackspace.Text = "←"
        Me.BtnBackspace.UseVisualStyleBackColor = True
        '
        'Btn9
        '
        Me.Btn9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn9.Location = New System.Drawing.Point(115, 115)
        Me.Btn9.Name = "Btn9"
        Me.Btn9.Size = New System.Drawing.Size(50, 50)
        Me.Btn9.TabIndex = 9
        Me.Btn9.Text = "9"
        Me.Btn9.UseVisualStyleBackColor = True
        '
        'BtnPct
        '
        Me.BtnPct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnPct.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnPct.Location = New System.Drawing.Point(3, 3)
        Me.BtnPct.Name = "BtnPct"
        Me.BtnPct.Size = New System.Drawing.Size(50, 50)
        Me.BtnPct.TabIndex = 20
        Me.BtnPct.Text = "％"
        Me.BtnPct.UseVisualStyleBackColor = True
        '
        'BtnCe
        '
        Me.BtnCe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnCe.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnCe.Location = New System.Drawing.Point(3, 59)
        Me.BtnCe.Name = "BtnCe"
        Me.BtnCe.Size = New System.Drawing.Size(50, 50)
        Me.BtnCe.TabIndex = 16
        Me.BtnCe.Text = "CE"
        Me.BtnCe.UseVisualStyleBackColor = True
        '
        'Btn7
        '
        Me.Btn7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn7.Location = New System.Drawing.Point(3, 115)
        Me.Btn7.Name = "Btn7"
        Me.Btn7.Size = New System.Drawing.Size(50, 50)
        Me.Btn7.TabIndex = 7
        Me.Btn7.Text = "7"
        Me.Btn7.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnEqual, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnPct, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnSqrt, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnSqr, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnPN, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnReciprocal, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnPlus, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnCe, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnC, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnBackspace, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn1, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnDivision, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnMinus, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn7, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn8, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn9, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnAsterisk, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn3, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn2, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn6, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn5, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnDot, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn0, 1, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 100)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.65499!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.65499!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67167!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67167!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67167!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.675!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(224, 341)
        Me.TableLayoutPanel1.TabIndex = 26
        '
        'FrmCaculator
        '
        Me.AcceptButton = Me.BtnEqual
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 441)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PnlShow)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(360, 480)
        Me.MinimumSize = New System.Drawing.Size(240, 480)
        Me.Name = "FrmCaculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator V1.0"
        Me.PnlShow.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnEqual As Button
    Friend WithEvents Btn0 As Button
    Friend WithEvents BtnDot As Button
    Friend WithEvents BtnPN As Button
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
    Friend WithEvents LblResult As Label
    Friend WithEvents PnlShow As Panel
    Friend WithEvents LblEx As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
