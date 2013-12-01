Public Class Word_Main

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

        Dim tempFile As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\temp.rtf"

        If (My.Computer.FileSystem.FileExists(tempFile)) Then

            My.Computer.FileSystem.DeleteFile(tempFile)
            Application.Exit()

        Else

            Application.Exit()

        End If

    End Sub

    Private Sub txtField_KeyDown(sender As Object, e As KeyEventArgs) Handles txtField.KeyDown

        If (e.KeyCode = Keys.B AndAlso e.Modifiers = Keys.Control) Then

            cmdBold.PerformClick()

        ElseIf (e.KeyCode = Keys.U AndAlso e.Modifiers = Keys.Control) Then


            cmdUnderline.PerformClick()

        ElseIf (e.KeyCode = Keys.I AndAlso e.Modifiers = Keys.Control) Then

            cmdItalic.PerformClick()

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

    Private Sub cmbFontSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFontSelection.SelectedIndexChanged

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

    Private Sub cmbFontSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFontSize.SelectedIndexChanged

        fontGlobalSize = cmbFontSize.Text

        Dim txtFontSize As New Font(fontGlobalFont, fontGlobalSize, fontGlobalStyle)
        txtField.SelectionFont = txtFontSize

    End Sub

    Private Sub cmdStyleBold_Click(sender As Object, e As EventArgs) Handles cmdStyleBold.Click

        cmdBold.PerformClick()

    End Sub

    Private Sub cmdStyleUnderline_Click(sender As Object, e As EventArgs) Handles cmdStyleUnderline.Click

        cmdUnderline.PerformClick()

    End Sub

    Private Sub cmdStyleItalic_Click(sender As Object, e As EventArgs) Handles cmdStyleItalic.Click

        cmdItalic.PerformClick()

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click

        Application.Exit()

    End Sub

    Private Sub cmdAbout_Click(sender As Object, e As EventArgs) Handles cmdAbout.Click

        Word_About.ShowDialog()

    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click

        MsgBox("Coming Soon!")

    End Sub

    Private Sub txtField_TextChanged(sender As Object, e As EventArgs) Handles txtField.TextChanged

        statsWordCount.Text = "Word Count: " & txtField.Text.Length

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

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

    Private Sub cmdOpen_Click(sender As Object, e As EventArgs) Handles cmdOpen.Click

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

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click



    End Sub

End Class
