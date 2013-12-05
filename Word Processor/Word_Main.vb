Imports System.Drawing.Printing
Imports ExtendedRichTextBox.RichTextBoxPrintCtrl

Public Class Word_Main

#Region "Declarations"

    Dim clickBold As Integer = 0
    Dim clickUnderline As Integer = 0
    Dim clickItalic As Integer = 0

    Dim fontGlobalFont As String
    Dim fontGlobalSize As Integer = 9
    Dim fontGlobalStyle As FontStyle

    Dim fileGlobalName As String
    Dim fileCheckPrint As Integer

#End Region

#Region "Form Events"

    Private Sub Main_Processor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set Application Title
        Me.Text = "ThermoCraft Word - New Document"

        ' Set default font.
        fontGlobalFont = "Times New Roman"
        Dim fontDefault As New Font("Times New Roman", fontGlobalSize, fontGlobalStyle)
        txtField.SelectionFont = fontDefault

    End Sub

    Private Sub Main_Processor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Dim tempFile As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\temp.rtf"

        ' Checks to see if a tempoary file has been downloaded and if so delelte it from the directory.
        If (My.Computer.FileSystem.FileExists(tempFile)) Then

            ' Deletes the file and then closes the application.
            My.Computer.FileSystem.DeleteFile(tempFile)
            Call applicationClose()

        Else

            ' Closes the application.
            Call applicationClose()

        End If

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click

        ' Closes the application.
        Call applicationClose()

    End Sub

    Private Sub applicationClose()

        If txtField.Modified Then

            Dim userPrompt As Integer
            userPrompt = MessageBox.Show("The current document has not been saved, would you like to continue without saving?", "Unsaved Document", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If userPrompt = Windows.Forms.DialogResult.No Then

                Exit Sub

            Else

                Application.Exit()

            End If

        Else

            Application.Exit()

        End If

    End Sub

    Private Sub cmdAbout_Click(sender As Object, e As EventArgs) Handles cmdAbout.Click

        ' Shows the "About" form as a dialog box.
        Word_About.ShowDialog()

    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click

        ' Help

    End Sub

    Private Sub txtField_KeyDown(sender As Object, e As KeyEventArgs) Handles txtField.KeyDown

        ' If the application detects "CTRL + B" being pressed it performs a virtual click to load the function.
        If (e.KeyCode = Keys.B AndAlso e.Modifiers = Keys.Control) Then

            cmdBold.PerformClick()

            ' If the application detects "CTRL + U" being pressed it performs a virtual click to load the function.
        ElseIf (e.KeyCode = Keys.U AndAlso e.Modifiers = Keys.Control) Then


            cmdUnderline.PerformClick()

            ' If the application detects "CTRL + I" being pressed it performs a virtual click to load the function.
        ElseIf (e.KeyCode = Keys.I AndAlso e.Modifiers = Keys.Control) Then

            cmdItalic.PerformClick()

        End If

    End Sub

#End Region

#Region "Document Events"

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click

        If txtField.Modified Then

            Dim userPrompt As Integer
            userPrompt = MessageBox.Show("The Current Docuement Has Not Been Saved, Do You Wish To Contiune Without Saving?", "Unsaved Document!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If userPrompt = Windows.Forms.DialogResult.Yes Then

                txtField.Clear()

            Else

                Exit Sub

            End If

        Else

            txtField.Clear()

        End If

        fileGlobalName = ""
        Me.Text = "ThermoCraft Word - New Document"

    End Sub

    Private Sub cmbFontSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFontSize.SelectedIndexChanged

        ' This updates the font size, based on the selected index then it updates all the global variables based on this.
        fontGlobalSize = cmbFontSize.Text

        Dim txtFontSize As New Font(fontGlobalFont, fontGlobalSize, fontGlobalStyle)
        txtField.SelectionFont = txtFontSize

    End Sub

    Private Sub txtField_TextChanged(sender As Object, e As EventArgs) Handles txtField.TextChanged

        ' Updates the word count based on the lenght of text in the "txtField" RichTextBox.
        statsWordCount.Text = "Word Count: " & txtField.Text.Length

    End Sub

#End Region

#Region "Font Events"

    Private Sub cmdBold_Click(sender As Object, e As EventArgs) Handles cmdBold.Click

        ' This is based on the clicking system (May be changed) but once a click has been done the script runs to chanhe the "Style" of
        ' the font and once this has to been changed an applied it then updates the globalStyle to allow other scripts to be updated.
        If clickBold = 1 Then

            fontGlobalStyle = FontStyle.Regular
            Dim fontNormal As New Font(fontGlobalFont, fontGlobalSize, fontGlobalStyle)
            txtField.SelectionFont = fontNormal
            clickBold = 0

            cmdBold.BackgroundImage = My.Resources.fontBold

        Else

            Dim fontBold As New Font(fontGlobalFont, fontGlobalSize, FontStyle.Bold)
            txtField.SelectionFont = fontBold
            clickBold = 1
            fontGlobalStyle = FontStyle.Bold

            cmdBold.BackgroundImage = My.Resources.fontBoldClicked

        End If

    End Sub

    Private Sub cmdUnderline_Click(sender As Object, e As EventArgs) Handles cmdUnderline.Click

        ' This is based on the clicking system (May be changed) but once a click has been done the script runs to chanhe the "Style" of
        ' the font and once this has to been changed an applied it then updates the globalStyle to allow other scripts to be updated.
        If clickUnderline = 1 Then

            fontGlobalStyle = FontStyle.Regular
            Dim fontNormal As New Font(fontGlobalFont, fontGlobalSize, fontGlobalStyle)
            txtField.SelectionFont = fontNormal
            clickUnderline = 0

            cmdUnderline.BackgroundImage = My.Resources.fontUnderline

        Else

            Dim fontUnderline As New Font(fontGlobalFont, fontGlobalSize, FontStyle.Underline)
            txtField.SelectionFont = fontUnderline
            clickUnderline = 1
            fontGlobalStyle = FontStyle.Underline

            cmdUnderline.BackgroundImage = My.Resources.fontUnderlineClicked

        End If

    End Sub

    Private Sub cmdItalic_Click(sender As Object, e As EventArgs) Handles cmdItalic.Click

        ' This is based on the clicking system (May be changed) but once a click has been done the script runs to chanhe the "Style" of
        ' the font and once this has to been changed an applied it then updates the globalStyle to allow other scripts to be updated.
        If clickItalic = 1 Then

            fontGlobalStyle = FontStyle.Regular
            Dim fontNormal As New Font(fontGlobalFont, fontGlobalSize, fontGlobalStyle)
            txtField.SelectionFont = fontNormal
            clickItalic = 0

            cmdItalic.BackgroundImage = My.Resources.fontItalic

        Else

            Dim fontItalic As New Font(fontGlobalFont, fontGlobalSize, FontStyle.Italic)
            txtField.SelectionFont = fontItalic
            clickItalic = 1
            fontGlobalStyle = FontStyle.Italic

            cmdItalic.BackgroundImage = My.Resources.fontItalicClicked

        End If

    End Sub

    Private Sub cmdStyleBold_Click(sender As Object, e As EventArgs) Handles cmdStyleBold.Click

        ' Performs a virtual click.
        cmdBold.PerformClick()

    End Sub

    Private Sub cmdStyleUnderline_Click(sender As Object, e As EventArgs) Handles cmdStyleUnderline.Click

        ' Performs a virtual click.
        cmdUnderline.PerformClick()

    End Sub

    Private Sub cmdStyleItalic_Click(sender As Object, e As EventArgs) Handles cmdStyleItalic.Click

        ' Performs a virtual click.
        cmdItalic.PerformClick()

    End Sub

    Private Sub cmbFontSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFontSelection.SelectedIndexChanged

        ' This function changes the font based on the user input and what has been inputed. Once the font has been selected, 
        ' the script changes the font then updates the globalfont to allow other scripts to be updated on the current font.
        If cmbFontSelection.SelectedItem = "Times New Roman" Then

            fontGlobalFont = "Times New Roman"
            Dim fontNTR As New Font("Times New Roman", fontGlobalSize, fontGlobalStyle)
            txtField.SelectionFont = fontNTR

        ElseIf cmbFontSelection.SelectedItem = "Arial" Then

            fontGlobalFont = "Arial"
            Dim fontArial As New Font("Arial", fontGlobalSize, fontGlobalStyle)
            txtField.SelectionFont = fontArial

        ElseIf cmbFontSelection.SelectedItem = "Calibri" Then

            fontGlobalFont = "Calibri"
            Dim fontCalibri As New Font("Calibri", fontGlobalSize, fontGlobalStyle)
            txtField.SelectionFont = fontCalibri

        End If

    End Sub

#End Region

#Region "Alignments/Formats"

    Private Sub cmdLeft_Click(sender As Object, e As EventArgs) Handles cmdLeft.Click

        txtField.SelectionAlignment = HorizontalAlignment.Left

    End Sub

    Private Sub cmdMiddle_Click(sender As Object, e As EventArgs) Handles cmdMiddle.Click

        txtField.SelectionAlignment = HorizontalAlignment.Center

    End Sub

    Private Sub cmdRight_Click(sender As Object, e As EventArgs) Handles cmdRight.Click

        txtField.SelectionAlignment = HorizontalAlignment.Right

    End Sub

    Private Sub cmdBulletAdd_Click(sender As Object, e As EventArgs) Handles cmdBulletAdd.Click

        txtField.BulletIndent = 10
        txtField.SelectionBullet = True

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        txtField.SelectionBullet = False

    End Sub

#End Region

#Region "Save/Open Events"

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        If fileGlobalName = "" Then

            cmdSaveAs_Click(Me, e)
            Exit Sub

        End If

        Dim strExt As String
        strExt = System.IO.Path.GetExtension(fileGlobalName)
        strExt = strExt.ToUpper()

        Select Case strExt

            Case ".RTF"

                txtField.SaveFile(fileGlobalName)

            Case Else

                Dim txtWriter As System.IO.StreamWriter
                txtWriter = New System.IO.StreamWriter(fileGlobalName)
                txtWriter.Write(txtField.Text)
                txtWriter.Close()
                txtWriter = Nothing
                txtField.SelectionStart = 0
                txtField.SelectionLength = 0
                txtField.Modified = False

        End Select

    End Sub

    Private Sub cmdSaveAs_Click(sender As Object, e As EventArgs) Handles cmdSaveAs.Click

        Dim saveFileDialog As SaveFileDialog = New System.Windows.Forms.SaveFileDialog

        saveFileDialog.Title = "ThermoCraft Word - Save File"
        saveFileDialog.DefaultExt = "rtf"
        saveFileDialog.Filter = "Rich Text Files|*.rtf|Text Files|*.txt|HTML Files|*.htm|All Files|*.*"
        saveFileDialog.FilterIndex = 1
        saveFileDialog.ShowDialog()

        If saveFileDialog.FileName = "" Then Exit Sub

        Dim strExt As String
        strExt = System.IO.Path.GetExtension(saveFileDialog.FileName)
        strExt = strExt.ToUpper()

        Select Case strExt

            Case ".RTF"

                txtField.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText)

            Case Else

                Dim txtWriter As System.IO.StreamWriter
                txtWriter = New System.IO.StreamWriter(saveFileDialog.FileName)
                txtWriter.Write(txtField.Text)
                txtWriter.Close()
                txtWriter = Nothing
                txtField.SelectionStart = 0
                txtField.SelectionLength = 0

        End Select

        fileGlobalName = saveFileDialog.FileName
        txtField.Modified = False
        Me.Text = "ThermoCraft Word - " & fileGlobalName.ToString()

    End Sub

    Private Sub cmdSaveTS_Click(sender As Object, e As EventArgs) Handles cmdSaveTS.Click

        cmdSave.PerformClick()

    End Sub

    Private Sub cmdOpen_Click(sender As Object, e As EventArgs) Handles cmdOpen.Click

        Dim openFileDialog As OpenFileDialog = New System.Windows.Forms.OpenFileDialog

        openFileDialog.Title = "ThermoCraft Word - Open File"
        openFileDialog.DefaultExt = "rtf"
        openFileDialog.Filter = "Rich Text Files|*.rtf|Text Files|*.txt|HTML Files|*.htm|All Files|*.*"
        openFileDialog.FilterIndex = 1
        openFileDialog.ShowDialog()

        If openFileDialog.FileName = "" Then Exit Sub

        Dim strExt As String
        strExt = System.IO.Path.GetExtension(openFileDialog.FileName)
        strExt = strExt.ToUpper()

        Select Case strExt
            Case ".RTF"

                txtField.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText)

            Case Else

                Dim txtReader As System.IO.StreamReader
                txtReader = New System.IO.StreamReader(openFileDialog.FileName)
                txtField.Text = txtReader.ReadToEnd
                txtReader.Close()
                txtReader = Nothing
                txtField.SelectionStart = 0
                txtField.SelectionLength = 0

        End Select

        fileGlobalName = openFileDialog.FileName
        txtField.Modified = False
        Me.Text = "ThermoCraft Word - " & fileGlobalName.ToString()

    End Sub

#End Region

#Region "Undo/Redo Events"

    Private Sub cmdUndo_Click(sender As Object, e As EventArgs) Handles cmdUndo.Click

        If txtField.CanUndo Then txtField.Undo()

    End Sub

    Private Sub cmdRedo_Click(sender As Object, e As EventArgs) Handles cmdRedo.Click

        If txtField.CanRedo Then txtField.Redo()

    End Sub

#End Region

#Region "Input Events"

    Private Sub cmdInsertImage_Click(sender As Object, e As EventArgs) Handles cmdInsertImage.Click

        Dim openFileDialog As OpenFileDialog = New System.Windows.Forms.OpenFileDialog

        openFileDialog.Title = "ThermoCraft Word - Insert Image"
        openFileDialog.DefaultExt = "rtf"
        openFileDialog.Filter = "Bitmap Files|*.bmp|JPEG Files|*.jpg|GIF Files|*.gif|PNG Files|*.png"
        openFileDialog.FilterIndex = 1
        openFileDialog.ShowDialog()

        If openFileDialog.FileName = "" Then Exit Sub

        Try

            Dim imagePath As String = openFileDialog.FileName
            Dim img As Image
            img = Image.FromFile(imagePath)
            Clipboard.SetDataObject(img)

            Dim dataFormat As DataFormats.Format
            dataFormat = DataFormats.GetFormat(DataFormats.Bitmap)

            If Me.txtField.CanPaste(dataFormat) Then

                Me.txtField.Paste(dataFormat)

            End If

        Catch ex As Exception

            MessageBox.Show("Unable To Insert Image Format Selected.", "ThermoCraft Word - Paste", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

#End Region

#Region "Printing"

    Private Sub cmdPageSetup_Click(sender As Object, e As EventArgs) Handles cmdPageSetup.Click

        Dim pageSetup As PageSetupDialog = New System.Windows.Forms.PageSetupDialog

        pageSetup.Document = filePrintDocument
        pageSetup.ShowDialog()

    End Sub

    Private Sub cmdPrintPreview_Click(sender As Object, e As EventArgs)

        Dim printPreviewDialog As PrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog

        printPreviewDialog.Document = filePrintDocument
        printPreviewDialog.ShowDialog()

    End Sub

    Private Sub filePrintDocument_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles filePrintDocument.BeginPrint

        ' Adapted from Microsoft's example for extended richtextbox control
        '
        fileCheckPrint = 0

    End Sub


    Private Sub filePrintDocument_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles filePrintDocument.PrintPage

        ' Adapted from Microsoft's example for extended richtextbox control
        '
        ' Print the content of the RichTextBox. Store the last character printed.
        fileCheckPrint = txtField.Print(fileCheckPrint, txtField.TextLength, e)

        ' Look for more pages
        If fileCheckPrint < txtField.TextLength Then

            e.HasMorePages = True

        Else

            e.HasMorePages = False

        End If

    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click

        Dim printFileDialog As PrintDialog = New System.Windows.Forms.PrintDialog

        printFileDialog.Document = filePrintDocument

        If printFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then

            filePrintDocument.Print()

        End If

    End Sub

#End Region

End Class