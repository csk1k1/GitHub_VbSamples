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
        Me.TxtBox = New System.Windows.Forms.TextBox()
        Me.GbxDetail = New System.Windows.Forms.GroupBox()
        Me.BtnShow = New System.Windows.Forms.Button()
        Me.LblCharNum = New System.Windows.Forms.Label()
        Me.LblWordNum = New System.Windows.Forms.Label()
        Me.BtnOpen = New System.Windows.Forms.Button()
        Me.TxtPath = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnSaveAs = New System.Windows.Forms.Button()
        Me.Menu0 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbxDetail.SuspendLayout()
        Me.Menu0.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtBox
        '
        Me.TxtBox.Location = New System.Drawing.Point(12, 53)
        Me.TxtBox.Multiline = True
        Me.TxtBox.Name = "TxtBox"
        Me.TxtBox.Size = New System.Drawing.Size(390, 425)
        Me.TxtBox.TabIndex = 0
        '
        'GbxDetail
        '
        Me.GbxDetail.Controls.Add(Me.BtnShow)
        Me.GbxDetail.Controls.Add(Me.LblCharNum)
        Me.GbxDetail.Controls.Add(Me.LblWordNum)
        Me.GbxDetail.Location = New System.Drawing.Point(408, 53)
        Me.GbxDetail.Name = "GbxDetail"
        Me.GbxDetail.Size = New System.Drawing.Size(138, 425)
        Me.GbxDetail.TabIndex = 2
        Me.GbxDetail.TabStop = False
        Me.GbxDetail.Text = "    字数统计信息"
        '
        'BtnShow
        '
        Me.BtnShow.Location = New System.Drawing.Point(24, 396)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.Size = New System.Drawing.Size(90, 23)
        Me.BtnShow.TabIndex = 1
        Me.BtnShow.Text = "字数统计"
        Me.BtnShow.UseVisualStyleBackColor = True
        '
        'LblCharNum
        '
        Me.LblCharNum.AutoSize = True
        Me.LblCharNum.Location = New System.Drawing.Point(22, 213)
        Me.LblCharNum.Name = "LblCharNum"
        Me.LblCharNum.Size = New System.Drawing.Size(0, 12)
        Me.LblCharNum.TabIndex = 0
        '
        'LblWordNum
        '
        Me.LblWordNum.AutoSize = True
        Me.LblWordNum.Location = New System.Drawing.Point(22, 65)
        Me.LblWordNum.Name = "LblWordNum"
        Me.LblWordNum.Size = New System.Drawing.Size(0, 12)
        Me.LblWordNum.TabIndex = 0
        '
        'BtnOpen
        '
        Me.BtnOpen.Location = New System.Drawing.Point(369, 498)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(61, 23)
        Me.BtnOpen.TabIndex = 3
        Me.BtnOpen.Text = "Open"
        Me.BtnOpen.UseVisualStyleBackColor = True
        '
        'TxtPath
        '
        Me.TxtPath.Location = New System.Drawing.Point(12, 498)
        Me.TxtPath.Name = "TxtPath"
        Me.TxtPath.Size = New System.Drawing.Size(351, 21)
        Me.TxtPath.TabIndex = 4
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(436, 498)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(55, 23)
        Me.BtnSave.TabIndex = 3
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnSaveAs
        '
        Me.BtnSaveAs.Location = New System.Drawing.Point(497, 498)
        Me.BtnSaveAs.Name = "BtnSaveAs"
        Me.BtnSaveAs.Size = New System.Drawing.Size(55, 23)
        Me.BtnSaveAs.TabIndex = 3
        Me.BtnSaveAs.Text = "Save As"
        Me.BtnSaveAs.UseVisualStyleBackColor = True
        '
        'Menu0
        '
        Me.Menu0.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.Menu0.Location = New System.Drawing.Point(0, 0)
        Me.Menu0.Name = "Menu0"
        Me.Menu0.Size = New System.Drawing.Size(565, 25)
        Me.Menu0.TabIndex = 5
        Me.Menu0.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveASToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(39, 21)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveASToolStripMenuItem
        '
        Me.SaveASToolStripMenuItem.Name = "SaveASToolStripMenuItem"
        Me.SaveASToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.SaveASToolStripMenuItem.Text = "Save AS"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 557)
        Me.Controls.Add(Me.TxtPath)
        Me.Controls.Add(Me.BtnSaveAs)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnOpen)
        Me.Controls.Add(Me.GbxDetail)
        Me.Controls.Add(Me.TxtBox)
        Me.Controls.Add(Me.Menu0)
        Me.MainMenuStrip = Me.Menu0
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text Editor"
        Me.GbxDetail.ResumeLayout(False)
        Me.GbxDetail.PerformLayout()
        Me.Menu0.ResumeLayout(False)
        Me.Menu0.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtBox As TextBox
    Friend WithEvents GbxDetail As GroupBox
    Friend WithEvents LblCharNum As Label
    Friend WithEvents LblWordNum As Label
    Friend WithEvents BtnShow As Button
    Friend WithEvents BtnOpen As Button
    Friend WithEvents TxtPath As TextBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnSaveAs As Button
    Friend WithEvents Menu0 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
