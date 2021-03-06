﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Word_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Word_Main))
        Me.menuHome = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdPageSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdPrintPreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdStyleBold = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdStyleUnderline = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdStyleItalic = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusHome = New System.Windows.Forms.StatusStrip()
        Me.statsWordCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtField = New ExtendedRichTextBox.RichTextBoxPrintCtrl()
        Me.toolStripHome = New System.Windows.Forms.ToolStrip()
        Me.cmdNewTS = New System.Windows.Forms.ToolStripButton()
        Me.cmdSaveTS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdBold = New System.Windows.Forms.ToolStripButton()
        Me.cmdUnderline = New System.Windows.Forms.ToolStripButton()
        Me.cmdItalic = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLeft = New System.Windows.Forms.ToolStripButton()
        Me.cmdMiddle = New System.Windows.Forms.ToolStripButton()
        Me.cmdRight = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdBulletAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblFontSize = New System.Windows.Forms.ToolStripLabel()
        Me.cmbFontSize = New System.Windows.Forms.ToolStripComboBox()
        Me.lblFont = New System.Windows.Forms.ToolStripLabel()
        Me.cmbFontSelection = New System.Windows.Forms.ToolStripComboBox()
        Me.filePrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.InsertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdInsertImage = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHome.SuspendLayout()
        Me.statusHome.SuspendLayout()
        Me.toolStripHome.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuHome
        '
        Me.menuHome.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.InsertToolStripMenuItem, Me.FontToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menuHome.Location = New System.Drawing.Point(0, 0)
        Me.menuHome.Name = "menuHome"
        Me.menuHome.Size = New System.Drawing.Size(742, 24)
        Me.menuHome.TabIndex = 0
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdNew, Me.cmdOpen, Me.cmdPrint, Me.cmdPageSetup, Me.cmdPrintPreview, Me.cmdSave, Me.cmdSaveAs, Me.cmdClose})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'cmdNew
        '
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(152, 22)
        Me.cmdNew.Text = "New"
        '
        'cmdOpen
        '
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(152, 22)
        Me.cmdOpen.Text = "Open"
        '
        'cmdPrint
        '
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(152, 22)
        Me.cmdPrint.Text = "Print"
        '
        'cmdPageSetup
        '
        Me.cmdPageSetup.Name = "cmdPageSetup"
        Me.cmdPageSetup.Size = New System.Drawing.Size(152, 22)
        Me.cmdPageSetup.Text = "Page Setup"
        '
        'cmdPrintPreview
        '
        Me.cmdPrintPreview.Name = "cmdPrintPreview"
        Me.cmdPrintPreview.Size = New System.Drawing.Size(152, 22)
        Me.cmdPrintPreview.Text = "Print Preview"
        '
        'cmdSave
        '
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(152, 22)
        Me.cmdSave.Text = "Save"
        '
        'cmdSaveAs
        '
        Me.cmdSaveAs.Name = "cmdSaveAs"
        Me.cmdSaveAs.Size = New System.Drawing.Size(152, 22)
        Me.cmdSaveAs.Text = "Save As"
        '
        'cmdClose
        '
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(152, 22)
        Me.cmdClose.Text = "Close"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdUndo, Me.cmdRedo})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'cmdUndo
        '
        Me.cmdUndo.Name = "cmdUndo"
        Me.cmdUndo.Size = New System.Drawing.Size(103, 22)
        Me.cmdUndo.Text = "Undo"
        '
        'cmdRedo
        '
        Me.cmdRedo.Name = "cmdRedo"
        Me.cmdRedo.Size = New System.Drawing.Size(103, 22)
        Me.cmdRedo.Text = "Redo"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StyleToolStripMenuItem})
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'StyleToolStripMenuItem
        '
        Me.StyleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdStyleBold, Me.cmdStyleUnderline, Me.cmdStyleItalic})
        Me.StyleToolStripMenuItem.Name = "StyleToolStripMenuItem"
        Me.StyleToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.StyleToolStripMenuItem.Text = "Style"
        '
        'cmdStyleBold
        '
        Me.cmdStyleBold.Name = "cmdStyleBold"
        Me.cmdStyleBold.Size = New System.Drawing.Size(125, 22)
        Me.cmdStyleBold.Text = "Bold"
        '
        'cmdStyleUnderline
        '
        Me.cmdStyleUnderline.Name = "cmdStyleUnderline"
        Me.cmdStyleUnderline.Size = New System.Drawing.Size(125, 22)
        Me.cmdStyleUnderline.Text = "Underline"
        '
        'cmdStyleItalic
        '
        Me.cmdStyleItalic.Name = "cmdStyleItalic"
        Me.cmdStyleItalic.Size = New System.Drawing.Size(125, 22)
        Me.cmdStyleItalic.Text = "Italic"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdHelp, Me.cmdAbout})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'cmdHelp
        '
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(107, 22)
        Me.cmdHelp.Text = "Help"
        '
        'cmdAbout
        '
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Size = New System.Drawing.Size(107, 22)
        Me.cmdAbout.Text = "About"
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
        Me.txtField.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtField.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtField.Location = New System.Drawing.Point(12, 58)
        Me.txtField.Name = "txtField"
        Me.txtField.Size = New System.Drawing.Size(718, 398)
        Me.txtField.TabIndex = 2
        Me.txtField.Text = ""
        '
        'toolStripHome
        '
        Me.toolStripHome.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdNewTS, Me.cmdSaveTS, Me.ToolStripSeparator1, Me.cmdBold, Me.cmdUnderline, Me.cmdItalic, Me.ToolStripSeparator2, Me.cmdLeft, Me.cmdMiddle, Me.cmdRight, Me.ToolStripSeparator3, Me.cmdBulletAdd, Me.ToolStripButton1, Me.ToolStripSeparator4, Me.lblFontSize, Me.cmbFontSize, Me.lblFont, Me.cmbFontSelection})
        Me.toolStripHome.Location = New System.Drawing.Point(0, 24)
        Me.toolStripHome.Name = "toolStripHome"
        Me.toolStripHome.Size = New System.Drawing.Size(742, 25)
        Me.toolStripHome.TabIndex = 3
        Me.toolStripHome.Text = "ToolStrip1"
        '
        'cmdNewTS
        '
        Me.cmdNewTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdNewTS.Image = Global.Word_Processor.My.Resources.Resources.createNew
        Me.cmdNewTS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNewTS.Name = "cmdNewTS"
        Me.cmdNewTS.Size = New System.Drawing.Size(23, 22)
        Me.cmdNewTS.Text = "ToolStripButton2"
        '
        'cmdSaveTS
        '
        Me.cmdSaveTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSaveTS.Image = Global.Word_Processor.My.Resources.Resources.save
        Me.cmdSaveTS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSaveTS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSaveTS.Name = "cmdSaveTS"
        Me.cmdSaveTS.Size = New System.Drawing.Size(23, 22)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'cmdBold
        '
        Me.cmdBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdBold.Image = Global.Word_Processor.My.Resources.Resources.fontBold
        Me.cmdBold.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBold.Name = "cmdBold"
        Me.cmdBold.Size = New System.Drawing.Size(23, 22)
        Me.cmdBold.Text = "Bold"
        '
        'cmdUnderline
        '
        Me.cmdUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdUnderline.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdUnderline.Image = CType(resources.GetObject("cmdUnderline.Image"), System.Drawing.Image)
        Me.cmdUnderline.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdUnderline.Name = "cmdUnderline"
        Me.cmdUnderline.Size = New System.Drawing.Size(23, 22)
        Me.cmdUnderline.Text = "Underline"
        '
        'cmdItalic
        '
        Me.cmdItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdItalic.Image = Global.Word_Processor.My.Resources.Resources.fontItalic
        Me.cmdItalic.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdItalic.Name = "cmdItalic"
        Me.cmdItalic.Size = New System.Drawing.Size(23, 22)
        Me.cmdItalic.Text = "Italic"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'cmdLeft
        '
        Me.cmdLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdLeft.Image = CType(resources.GetObject("cmdLeft.Image"), System.Drawing.Image)
        Me.cmdLeft.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdLeft.Name = "cmdLeft"
        Me.cmdLeft.Size = New System.Drawing.Size(23, 22)
        Me.cmdLeft.Text = "ToolStripButton1"
        '
        'cmdMiddle
        '
        Me.cmdMiddle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdMiddle.Image = CType(resources.GetObject("cmdMiddle.Image"), System.Drawing.Image)
        Me.cmdMiddle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdMiddle.Name = "cmdMiddle"
        Me.cmdMiddle.Size = New System.Drawing.Size(23, 22)
        Me.cmdMiddle.Text = "ToolStripButton1"
        '
        'cmdRight
        '
        Me.cmdRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdRight.Image = CType(resources.GetObject("cmdRight.Image"), System.Drawing.Image)
        Me.cmdRight.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRight.Name = "cmdRight"
        Me.cmdRight.Size = New System.Drawing.Size(23, 22)
        Me.cmdRight.Text = "ToolStripButton1"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'cmdBulletAdd
        '
        Me.cmdBulletAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdBulletAdd.Image = CType(resources.GetObject("cmdBulletAdd.Image"), System.Drawing.Image)
        Me.cmdBulletAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBulletAdd.Name = "cmdBulletAdd"
        Me.cmdBulletAdd.Size = New System.Drawing.Size(23, 22)
        Me.cmdBulletAdd.Text = "ToolStripButton1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "cmdBulletRemove"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
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
        'lblFont
        '
        Me.lblFont.Name = "lblFont"
        Me.lblFont.Size = New System.Drawing.Size(34, 22)
        Me.lblFont.Text = "Font:"
        '
        'cmbFontSelection
        '
        Me.cmbFontSelection.Items.AddRange(New Object() {"Times New Roman", "Arial", "Calibri"})
        Me.cmbFontSelection.Name = "cmbFontSelection"
        Me.cmbFontSelection.Size = New System.Drawing.Size(121, 25)
        '
        'filePrintDocument
        '
        '
        'InsertToolStripMenuItem
        '
        Me.InsertToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImageToolStripMenuItem})
        Me.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem"
        Me.InsertToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InsertToolStripMenuItem.Text = "Insert"
        '
        'ImageToolStripMenuItem
        '
        Me.ImageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdInsertImage})
        Me.ImageToolStripMenuItem.Name = "ImageToolStripMenuItem"
        Me.ImageToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ImageToolStripMenuItem.Text = "Media"
        '
        'cmdInsertImage
        '
        Me.cmdInsertImage.Name = "cmdInsertImage"
        Me.cmdInsertImage.Size = New System.Drawing.Size(152, 22)
        Me.cmdInsertImage.Text = "Image"
        '
        'Word_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 481)
        Me.Controls.Add(Me.toolStripHome)
        Me.Controls.Add(Me.txtField)
        Me.Controls.Add(Me.statusHome)
        Me.Controls.Add(Me.menuHome)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuHome
        Me.Name = "Word_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripHome As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdBold As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdUnderline As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdItalic As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StyleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdStyleBold As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdStyleUnderline As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdStyleItalic As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblFontSize As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbFontSize As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents cmdOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblFont As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbFontSelection As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents cmdHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdNewTS As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSaveTS As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdSaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents filePrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents txtField As ExtendedRichTextBox.RichTextBoxPrintCtrl
    Friend WithEvents cmdPrintPreview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdUndo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRedo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdLeft As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdMiddle As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRight As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdBulletAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPageSetup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdInsertImage As System.Windows.Forms.ToolStripMenuItem

End Class
