Public Class Main_Processor

    Dim clickBold As Integer = 0
    Dim clickUnderline As Integer = 0
    Dim clickItalic As Integer = 0
    Dim clickFontTimesNewRoman As Integer = 0
    Dim clickFontArial As Integer = 0
    Dim clickFontCalibri As Integer = 0

    Dim fontGlobalFont As String
    Dim fontGlobalSize As Integer = 9
    Dim fontGlobalStyle As FontStyle

    Dim fileGlobalName As String

    Private Sub Main_Processor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (My.Settings.Open_Enable = True) Then

            txtField.LoadFile(My.Settings.Open_FileName)

            fileGlobalName = My.Settings.Open_FileName
            Me.Text = "Word Processor | " & fileGlobalName

            My.Settings.Open_Enable = False
            My.Settings.Open_FileName = ""

        ElseIf (My.Settings.Download_Enable = True) Then

            txtField.LoadFile(My.Settings.Download_Temp)

            fileGlobalName = My.Settings.Download_Temp
            Me.Text = "Word Processor | " & fileGlobalName

            My.Settings.Download_Enable = False

        End If

    End Sub

    Private Sub Main_Processor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Application.Exit()

    End Sub

    Private Sub txtField_KeyDown(sender As Object, e As KeyEventArgs) Handles txtField.KeyDown

        If (e.KeyCode = Keys.B AndAlso e.Modifiers = Keys.Control) Then

            cmdBold.PerformClick()

        ElseIf (e.KeyCode = Keys.U AndAlso e.Modifiers = Keys.Control) Then


            cmdUnderline.PerformClick()

        ElseIf (e.KeyCode = Keys.I AndAlso e.Modifiers = Keys.Control) Then

            cmdUnderline.PerformClick()

        End If

    End Sub

    Private Sub cmdBold_Click(sender As Object, e As EventArgs) Handles cmdBold.Click

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
    Private Sub TimesNewRomanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimesNewRomanToolStripMenuItem.Click

        If clickFontTimesNewRoman = 1 Then

            fontGlobalFont = "Microsoft Sans Serif"
            Dim fontNormal As New Font(fontGlobalFont, fontGlobalSize, fontGlobalStyle)
            txtField.SelectionFont = fontNormal
            clickFontTimesNewRoman = 0

        Else

            Dim fontNTR As New Font("Times New Roman", fontGlobalSize, fontGlobalStyle)
            txtField.SelectionFont = fontNTR
            clickFontTimesNewRoman = 1
            fontGlobalFont = "Times New Roman"

        End If

    End Sub

    Private Sub ArialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArialToolStripMenuItem.Click

        If clickFontArial = 1 Then

            fontGlobalFont = "Microsoft Sans Serif"
            Dim fontNormal As New Font(fontGlobalFont, fontGlobalSize, fontGlobalStyle)
            txtField.SelectionFont = fontNormal
            clickFontTimesNewRoman = 0

        Else

            Dim fontArial As New Font("Arial", fontGlobalSize, fontGlobalStyle)
            txtField.SelectionFont = fontArial
            clickFontArial = 1
            fontGlobalFont = "Arial"

        End If


    End Sub

    Private Sub CalibriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalibriToolStripMenuItem.Click

        If clickFontCalibri = 1 Then

            fontGlobalFont = "Microsoft Sans Serif"
            Dim fontNormal As New Font(fontGlobalFont, fontGlobalSize, fontGlobalStyle)
            txtField.SelectionFont = fontNormal
            clickFontTimesNewRoman = 0

        Else

            Dim fontArial As New Font("Calibri", fontGlobalSize, fontGlobalStyle)
            txtField.SelectionFont = fontArial
            clickFontArial = 1
            fontGlobalFont = "Calibri"

        End If

    End Sub

    Private Sub cmbFontSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFontSize.SelectedIndexChanged

        fontGlobalSize = cmbFontSize.Text

        Dim txtFontSize As New Font(fontGlobalFont, fontGlobalSize, fontGlobalStyle)
        txtField.SelectionFont = txtFontSize

    End Sub

    Private Sub BoldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoldToolStripMenuItem.Click

        cmdBold.PerformClick()

    End Sub

    Private Sub UnderlineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnderlineToolStripMenuItem.Click

        cmdUnderline.PerformClick()

    End Sub

    Private Sub ItalicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItalicToolStripMenuItem.Click

        cmdItalic.PerformClick()

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click

        Application.Exit()

    End Sub

    Private Sub txtField_TextChanged(sender As Object, e As EventArgs) Handles txtField.TextChanged

        statsWordCount.Text = "Word Count: " & txtField.Text.Length

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

        Dim saveFileDialog As SaveFileDialog = New System.Windows.Forms.SaveFileDialog
        Dim saveFileName As String = ""

        With saveFileDialog
            .AddExtension = True
            .CheckPathExists = True
            .DefaultExt = ".rtf"
            .Filter = "Rich Text Format|*.rtf"
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        End With

        If saveFileName = "" Then

            If saveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then

                saveFileName = saveFileDialog.FileName
                txtField.SaveFile(saveFileName, RichTextBoxStreamType.RichText)
            End If

        Else

            txtField.SaveFile(saveFileName, RichTextBoxStreamType.RichText)

        End If

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

        Dim openFileDialog As OpenFileDialog = New System.Windows.Forms.OpenFileDialog

        With openFileDialog
            .AddExtension = True
            .CheckPathExists = True
            .DefaultExt = ".rtf"
            .Filter = "Rich Text Format|*.rtf"
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        End With

        If (openFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK) _
            And (openFileDialog.FileName.Length > 0) Then

            txtField.LoadFile(openFileDialog.FileName)

            fileGlobalName = openFileDialog.FileName
            Me.Text = "Word Processor | " & fileGlobalName

        End If

    End Sub

End Class
