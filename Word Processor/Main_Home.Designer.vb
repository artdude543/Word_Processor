<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Home))
        Me.menuHome = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimesNewRomanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoldToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnderlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItalicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusHome = New System.Windows.Forms.StatusStrip()
        Me.statsWordCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtField = New System.Windows.Forms.RichTextBox()
        Me.toolStripHome = New System.Windows.Forms.ToolStrip()
        Me.cmdBold = New System.Windows.Forms.ToolStripButton()
        Me.cmdUnderline = New System.Windows.Forms.ToolStripButton()
        Me.cmdItalic = New System.Windows.Forms.ToolStripButton()
        Me.lblFontSize = New System.Windows.Forms.ToolStripLabel()
        Me.cmbFontSize = New System.Windows.Forms.ToolStripComboBox()
        Me.CalibriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHome.SuspendLayout()
        Me.statusHome.SuspendLayout()
        Me.toolStripHome.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuHome
        '
        Me.menuHome.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.FontToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menuHome.Location = New System.Drawing.Point(0, 0)
        Me.menuHome.Name = "menuHome"
        Me.menuHome.Size = New System.Drawing.Size(742, 24)
        Me.menuHome.TabIndex = 0
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem1, Me.StyleToolStripMenuItem})
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'FontToolStripMenuItem1
        '
        Me.FontToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TimesNewRomanToolStripMenuItem, Me.ArialToolStripMenuItem, Me.CalibriToolStripMenuItem})
        Me.FontToolStripMenuItem1.Name = "FontToolStripMenuItem1"
        Me.FontToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.FontToolStripMenuItem1.Text = "Font"
        '
        'TimesNewRomanToolStripMenuItem
        '
        Me.TimesNewRomanToolStripMenuItem.Name = "TimesNewRomanToolStripMenuItem"
        Me.TimesNewRomanToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.TimesNewRomanToolStripMenuItem.Text = "Times New Roman"
        '
        'ArialToolStripMenuItem
        '
        Me.ArialToolStripMenuItem.Name = "ArialToolStripMenuItem"
        Me.ArialToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ArialToolStripMenuItem.Text = "Arial"
        '
        'StyleToolStripMenuItem
        '
        Me.StyleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BoldToolStripMenuItem, Me.UnderlineToolStripMenuItem, Me.ItalicToolStripMenuItem})
        Me.StyleToolStripMenuItem.Name = "StyleToolStripMenuItem"
        Me.StyleToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StyleToolStripMenuItem.Text = "Style"
        '
        'BoldToolStripMenuItem
        '
        Me.BoldToolStripMenuItem.Name = "BoldToolStripMenuItem"
        Me.BoldToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.BoldToolStripMenuItem.Text = "Bold"
        '
        'UnderlineToolStripMenuItem
        '
        Me.UnderlineToolStripMenuItem.Name = "UnderlineToolStripMenuItem"
        Me.UnderlineToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.UnderlineToolStripMenuItem.Text = "Underline"
        '
        'ItalicToolStripMenuItem
        '
        Me.ItalicToolStripMenuItem.Name = "ItalicToolStripMenuItem"
        Me.ItalicToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ItalicToolStripMenuItem.Text = "Italic"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'statusHome
        '
        Me.statusHome.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statsWordCount})
        Me.statusHome.Location = New System.Drawing.Point(0, 459)
        Me.statusHome.Name = "statusHome"
        Me.statusHome.Size = New System.Drawing.Size(742, 22)
        Me.statusHome.TabIndex = 1
        Me.statusHome.Text = "StatusStrip1"
        '
        'statsWordCount
        '
        Me.statsWordCount.Name = "statsWordCount"
        Me.statsWordCount.Size = New System.Drawing.Size(84, 17)
        Me.statsWordCount.Text = "Word Count: 0"
        '
        'txtField
        '
        Me.txtField.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtField.Location = New System.Drawing.Point(12, 58)
        Me.txtField.Name = "txtField"
        Me.txtField.Size = New System.Drawing.Size(718, 398)
        Me.txtField.TabIndex = 2
        Me.txtField.Text = ""
        '
        'toolStripHome
        '
        Me.toolStripHome.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdBold, Me.cmdUnderline, Me.cmdItalic, Me.lblFontSize, Me.cmbFontSize})
        Me.toolStripHome.Location = New System.Drawing.Point(0, 24)
        Me.toolStripHome.Name = "toolStripHome"
        Me.toolStripHome.Size = New System.Drawing.Size(742, 25)
        Me.toolStripHome.TabIndex = 3
        Me.toolStripHome.Text = "ToolStrip1"
        '
        'cmdBold
        '
        Me.cmdBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdBold.Image = CType(resources.GetObject("cmdBold.Image"), System.Drawing.Image)
        Me.cmdBold.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBold.Name = "cmdBold"
        Me.cmdBold.Size = New System.Drawing.Size(23, 22)
        Me.cmdBold.Text = "Bold"
        '
        'cmdUnderline
        '
        Me.cmdUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdUnderline.Image = CType(resources.GetObject("cmdUnderline.Image"), System.Drawing.Image)
        Me.cmdUnderline.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdUnderline.Name = "cmdUnderline"
        Me.cmdUnderline.Size = New System.Drawing.Size(23, 22)
        Me.cmdUnderline.Text = "Underline"
        '
        'cmdItalic
        '
        Me.cmdItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdItalic.Image = CType(resources.GetObject("cmdItalic.Image"), System.Drawing.Image)
        Me.cmdItalic.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdItalic.Name = "cmdItalic"
        Me.cmdItalic.Size = New System.Drawing.Size(23, 22)
        Me.cmdItalic.Text = "Italic"
        '
        'lblFontSize
        '
        Me.lblFontSize.Name = "lblFontSize"
        Me.lblFontSize.Size = New System.Drawing.Size(57, 22)
        Me.lblFontSize.Text = "Font Size:"
        '
        'cmbFontSize
        '
        Me.cmbFontSize.Items.AddRange(New Object() {"8", "9", "10", "11", "12", "13", "14", "15"})
        Me.cmbFontSize.Name = "cmbFontSize"
        Me.cmbFontSize.Size = New System.Drawing.Size(121, 25)
        '
        'CalibriToolStripMenuItem
        '
        Me.CalibriToolStripMenuItem.Name = "CalibriToolStripMenuItem"
        Me.CalibriToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.CalibriToolStripMenuItem.Text = "Calibri"
        '
        'Main_Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 481)
        Me.Controls.Add(Me.toolStripHome)
        Me.Controls.Add(Me.txtField)
        Me.Controls.Add(Me.statusHome)
        Me.Controls.Add(Me.menuHome)
        Me.MainMenuStrip = Me.menuHome
        Me.Name = "Main_Home"
        Me.Text = "Word Processor | Home"
        Me.menuHome.ResumeLayout(False)
        Me.menuHome.PerformLayout()
        Me.statusHome.ResumeLayout(False)
        Me.statusHome.PerformLayout()
        Me.toolStripHome.ResumeLayout(False)
        Me.toolStripHome.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuHome As System.Windows.Forms.MenuStrip
    Friend WithEvents statusHome As System.Windows.Forms.StatusStrip
    Friend WithEvents statsWordCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtField As System.Windows.Forms.RichTextBox
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripHome As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdBold As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdUnderline As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdItalic As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StyleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BoldToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnderlineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItalicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimesNewRomanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblFontSize As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbFontSize As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ArialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalibriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
