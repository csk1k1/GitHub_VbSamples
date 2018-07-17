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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PnlShow = New System.Windows.Forms.Panel()
        Me.LblPrev = New System.Windows.Forms.Label()
        Me.LblCurrent = New System.Windows.Forms.Label()
        Me.PnlBtns = New System.Windows.Forms.Panel()
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
        Me.PnlShow.SuspendLayout()
        Me.PnlBtns.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlShow
        '
        Me.PnlShow.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlShow.Controls.Add(Me.LblPrev)
        Me.PnlShow.Controls.Add(Me.LblCurrent)
        Me.PnlShow.Location = New System.Drawing.Point(15, 11)
        Me.PnlShow.Name = "PnlShow"
        Me.PnlShow.Size = New System.Drawing.Size(187, 100)
        Me.PnlShow.TabIndex = 25
        '
        'LblPrev
        '
        Me.LblPrev.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblPrev.ForeColor = System.Drawing.Color.Gray
        Me.LblPrev.Location = New System.Drawing.Point(0, 0)
        Me.LblPrev.Name = "LblPrev"
        Me.LblPrev.Size = New System.Drawing.Size(187, 41)
        Me.LblPrev.TabIndex = 26
        Me.LblPrev.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblCurrent
        '
        Me.LblCurrent.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LblCurrent.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblCurrent.ForeColor = System.Drawing.Color.Black
        Me.LblCurrent.Location = New System.Drawing.Point(0, 41)
        Me.LblCurrent.Name = "LblCurrent"
        Me.LblCurrent.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblCurrent.Size = New System.Drawing.Size(187, 59)
        Me.LblCurrent.TabIndex = 27
        Me.LblCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PnlBtns
        '
        Me.PnlBtns.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlBtns.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PnlBtns.BackColor = System.Drawing.Color.Transparent
        Me.PnlBtns.Controls.Add(Me.BtnEqual)
        Me.PnlBtns.Controls.Add(Me.Btn0)
        Me.PnlBtns.Controls.Add(Me.BtnPoint)
        Me.PnlBtns.Controls.Add(Me.BtnPlusMinus)
        Me.PnlBtns.Controls.Add(Me.BtnPlus)
        Me.PnlBtns.Controls.Add(Me.Btn2)
        Me.PnlBtns.Controls.Add(Me.Btn3)
        Me.PnlBtns.Controls.Add(Me.Btn1)
        Me.PnlBtns.Controls.Add(Me.BtnMinus)
        Me.PnlBtns.Controls.Add(Me.Btn5)
        Me.PnlBtns.Controls.Add(Me.Btn6)
        Me.PnlBtns.Controls.Add(Me.Btn4)
        Me.PnlBtns.Controls.Add(Me.BtnReciprocal)
        Me.PnlBtns.Controls.Add(Me.BtnDivision)
        Me.PnlBtns.Controls.Add(Me.BtnAsterisk)
        Me.PnlBtns.Controls.Add(Me.BtnSqrt)
        Me.PnlBtns.Controls.Add(Me.BtnC)
        Me.PnlBtns.Controls.Add(Me.Btn8)
        Me.PnlBtns.Controls.Add(Me.BtnSqr)
        Me.PnlBtns.Controls.Add(Me.BtnBackspace)
        Me.PnlBtns.Controls.Add(Me.Btn9)
        Me.PnlBtns.Controls.Add(Me.BtnPct)
        Me.PnlBtns.Controls.Add(Me.BtnCe)
        Me.PnlBtns.Controls.Add(Me.Btn7)
        Me.PnlBtns.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.PnlBtns.Location = New System.Drawing.Point(12, 117)
        Me.PnlBtns.Name = "PnlBtns"
        Me.PnlBtns.Size = New System.Drawing.Size(190, 282)
        Me.PnlBtns.TabIndex = 0
        '
        'BtnEqual
        '
        Me.BtnEqual.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEqual.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnEqual.Location = New System.Drawing.Point(141, 234)
        Me.BtnEqual.Name = "BtnEqual"
        Me.BtnEqual.Size = New System.Drawing.Size(45, 44)
        Me.BtnEqual.TabIndex = 12
        Me.BtnEqual.Text = "="
        Me.BtnEqual.UseVisualStyleBackColor = True
        '
        'Btn0
        '
        Me.Btn0.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn0.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn0.Location = New System.Drawing.Point(49, 234)
        Me.Btn0.Name = "Btn0"
        Me.Btn0.Size = New System.Drawing.Size(45, 44)
        Me.Btn0.TabIndex = 0
        Me.Btn0.Text = "0"
        Me.Btn0.UseVisualStyleBackColor = True
        '
        'BtnPoint
        '
        Me.BtnPoint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPoint.Font = New System.Drawing.Font("宋体", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnPoint.Location = New System.Drawing.Point(95, 234)
        Me.BtnPoint.Name = "BtnPoint"
        Me.BtnPoint.Size = New System.Drawing.Size(45, 44)
        Me.BtnPoint.TabIndex = 11
        Me.BtnPoint.Text = "."
        Me.BtnPoint.UseVisualStyleBackColor = True
        '
        'BtnPlusMinus
        '
        Me.BtnPlusMinus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnPlusMinus.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnPlusMinus.Location = New System.Drawing.Point(3, 234)
        Me.BtnPlusMinus.Name = "BtnPlusMinus"
        Me.BtnPlusMinus.Size = New System.Drawing.Size(45, 44)
        Me.BtnPlusMinus.TabIndex = 10
        Me.BtnPlusMinus.Text = "±"
        Me.BtnPlusMinus.UseVisualStyleBackColor = True
        '
        'BtnPlus
        '
        Me.BtnPlus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPlus.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnPlus.Location = New System.Drawing.Point(141, 188)
        Me.BtnPlus.Name = "BtnPlus"
        Me.BtnPlus.Size = New System.Drawing.Size(45, 44)
        Me.BtnPlus.TabIndex = 13
        Me.BtnPlus.Text = "+"
        Me.BtnPlus.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn2.Location = New System.Drawing.Point(49, 188)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(45, 44)
        Me.Btn2.TabIndex = 2
        Me.Btn2.Text = "2"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Btn3
        '
        Me.Btn3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn3.Location = New System.Drawing.Point(95, 188)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(45, 44)
        Me.Btn3.TabIndex = 3
        Me.Btn3.Text = "3"
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'Btn1
        '
        Me.Btn1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn1.Location = New System.Drawing.Point(3, 188)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(45, 44)
        Me.Btn1.TabIndex = 1
        Me.Btn1.Text = "1"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'BtnMinus
        '
        Me.BtnMinus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinus.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnMinus.Location = New System.Drawing.Point(141, 142)
        Me.BtnMinus.Name = "BtnMinus"
        Me.BtnMinus.Size = New System.Drawing.Size(45, 44)
        Me.BtnMinus.TabIndex = 14
        Me.BtnMinus.Text = "-"
        Me.BtnMinus.UseVisualStyleBackColor = True
        '
        'Btn5
        '
        Me.Btn5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn5.Location = New System.Drawing.Point(49, 142)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(45, 44)
        Me.Btn5.TabIndex = 5
        Me.Btn5.Text = "5"
        Me.Btn5.UseVisualStyleBackColor = True
        '
        'Btn6
        '
        Me.Btn6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn6.Location = New System.Drawing.Point(95, 142)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(45, 44)
        Me.Btn6.TabIndex = 6
        Me.Btn6.Text = "6"
        Me.Btn6.UseVisualStyleBackColor = True
        '
        'Btn4
        '
        Me.Btn4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn4.Location = New System.Drawing.Point(3, 142)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(45, 44)
        Me.Btn4.TabIndex = 4
        Me.Btn4.Text = "4"
        Me.Btn4.UseVisualStyleBackColor = True
        '
        'BtnReciprocal
        '
        Me.BtnReciprocal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnReciprocal.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnReciprocal.Location = New System.Drawing.Point(141, 4)
        Me.BtnReciprocal.Name = "BtnReciprocal"
        Me.BtnReciprocal.Size = New System.Drawing.Size(45, 44)
        Me.BtnReciprocal.TabIndex = 23
        Me.BtnReciprocal.Text = "1/x"
        Me.BtnReciprocal.UseVisualStyleBackColor = True
        '
        'BtnDivision
        '
        Me.BtnDivision.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDivision.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnDivision.Location = New System.Drawing.Point(141, 50)
        Me.BtnDivision.Name = "BtnDivision"
        Me.BtnDivision.Size = New System.Drawing.Size(45, 44)
        Me.BtnDivision.TabIndex = 19
        Me.BtnDivision.Text = "÷"
        Me.BtnDivision.UseVisualStyleBackColor = True
        '
        'BtnAsterisk
        '
        Me.BtnAsterisk.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAsterisk.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnAsterisk.Location = New System.Drawing.Point(141, 96)
        Me.BtnAsterisk.Name = "BtnAsterisk"
        Me.BtnAsterisk.Size = New System.Drawing.Size(45, 44)
        Me.BtnAsterisk.TabIndex = 15
        Me.BtnAsterisk.Text = "*"
        Me.BtnAsterisk.UseVisualStyleBackColor = True
        '
        'BtnSqrt
        '
        Me.BtnSqrt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSqrt.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnSqrt.Location = New System.Drawing.Point(49, 4)
        Me.BtnSqrt.Name = "BtnSqrt"
        Me.BtnSqrt.Size = New System.Drawing.Size(45, 44)
        Me.BtnSqrt.TabIndex = 21
        Me.BtnSqrt.Text = "√"
        Me.BtnSqrt.UseVisualStyleBackColor = True
        '
        'BtnC
        '
        Me.BtnC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnC.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnC.Location = New System.Drawing.Point(49, 50)
        Me.BtnC.Name = "BtnC"
        Me.BtnC.Size = New System.Drawing.Size(45, 44)
        Me.BtnC.TabIndex = 17
        Me.BtnC.Text = "C"
        Me.BtnC.UseVisualStyleBackColor = True
        '
        'Btn8
        '
        Me.Btn8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn8.Location = New System.Drawing.Point(49, 96)
        Me.Btn8.Name = "Btn8"
        Me.Btn8.Size = New System.Drawing.Size(45, 44)
        Me.Btn8.TabIndex = 8
        Me.Btn8.Text = "8"
        Me.Btn8.UseVisualStyleBackColor = True
        '
        'BtnSqr
        '
        Me.BtnSqr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSqr.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnSqr.Location = New System.Drawing.Point(95, 4)
        Me.BtnSqr.Name = "BtnSqr"
        Me.BtnSqr.Size = New System.Drawing.Size(45, 44)
        Me.BtnSqr.TabIndex = 22
        Me.BtnSqr.Text = "x²"
        Me.BtnSqr.UseVisualStyleBackColor = True
        '
        'BtnBackspace
        '
        Me.BtnBackspace.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBackspace.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnBackspace.Location = New System.Drawing.Point(95, 50)
        Me.BtnBackspace.Name = "BtnBackspace"
        Me.BtnBackspace.Size = New System.Drawing.Size(45, 44)
        Me.BtnBackspace.TabIndex = 18
        Me.BtnBackspace.Text = "退格"
        Me.BtnBackspace.UseVisualStyleBackColor = True
        '
        'Btn9
        '
        Me.Btn9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn9.Location = New System.Drawing.Point(95, 96)
        Me.Btn9.Name = "Btn9"
        Me.Btn9.Size = New System.Drawing.Size(45, 44)
        Me.Btn9.TabIndex = 9
        Me.Btn9.Text = "9"
        Me.Btn9.UseVisualStyleBackColor = True
        '
        'BtnPct
        '
        Me.BtnPct.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnPct.Location = New System.Drawing.Point(3, 4)
        Me.BtnPct.Name = "BtnPct"
        Me.BtnPct.Size = New System.Drawing.Size(45, 44)
        Me.BtnPct.TabIndex = 20
        Me.BtnPct.Text = "％"
        Me.BtnPct.UseVisualStyleBackColor = True
        '
        'BtnCe
        '
        Me.BtnCe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCe.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnCe.Location = New System.Drawing.Point(3, 50)
        Me.BtnCe.Name = "BtnCe"
        Me.BtnCe.Size = New System.Drawing.Size(45, 44)
        Me.BtnCe.TabIndex = 16
        Me.BtnCe.Text = "CE"
        Me.BtnCe.UseVisualStyleBackColor = True
        '
        'Btn7
        '
        Me.Btn7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn7.Location = New System.Drawing.Point(3, 96)
        Me.Btn7.Name = "Btn7"
        Me.Btn7.Size = New System.Drawing.Size(45, 44)
        Me.Btn7.TabIndex = 7
        Me.Btn7.Text = "7"
        Me.Btn7.UseVisualStyleBackColor = True
        '
        'FrmCaculator
        '
        Me.AcceptButton = Me.BtnEqual
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 411)
        Me.Controls.Add(Me.PnlBtns)
        Me.Controls.Add(Me.PnlShow)
        Me.Name = "FrmCaculator"
        Me.Text = "Calculator V1.0"
        Me.PnlShow.ResumeLayout(False)
        Me.PnlBtns.ResumeLayout(False)
        Me.ResumeLayout(False)

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
    Friend WithEvents PnlBtns As Panel
    Friend WithEvents LblCurrent As Label
    Friend WithEvents PnlShow As Panel
    Friend WithEvents LblPrev As Label
End Class
