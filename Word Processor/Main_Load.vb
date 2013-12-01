Imports System.Net

Public Class Main_Load

    Private Sub cmdCreateNew_Click(sender As Object, e As EventArgs) Handles cmdCreateNew.Click

        Main_Processor.Show()
        Me.Hide()

    End Sub

    Private Sub cmdOpen_Click(sender As Object, e As EventArgs) Handles cmdOpen.Click

        My.Settings.Open_Enable = True

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

            My.Settings.Open_FileName = openFileDialog.FileName

            Main_Processor.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub cmdDownload_Click(sender As Object, e As EventArgs) Handles cmdDownload.Click

        Dim downloadURL As String
        Dim tempSave = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\temp.rtf"

        My.Settings.Download_Enable = True

        downloadURL = InputBox("Please Enter The URL For A Text File (.rtf)")

        Dim webClient As New WebClient

        webClient.DownloadFile(downloadURL, tempSave)

        If (System.IO.File.Exists(tempSave)) Then

            My.Settings.Download_Temp = tempSave

            Main_Processor.Show()
            Me.Hide()

        Else



        End If

    End Sub

    Private Sub Main_Load_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Application.Exit()

    End Sub

End Class