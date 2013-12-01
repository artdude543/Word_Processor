Imports System.Net

Public Class Word_Loading

    Private Sub cmdCreateNew_Click(sender As Object, e As EventArgs) Handles cmdCreateNew.Click

        ' Creates a new document.
        Word_Main.Show()
        Me.Hide()

    End Sub

    Private Sub cmdOpen_Click(sender As Object, e As EventArgs) Handles cmdOpen.Click

        ' This opens up a new document and uses the "OpenFileDialog" to select the file and set global settings so that the main
        ' form has access to the settings to open the file.
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

            Word_Main.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub cmdDownload_Click(sender As Object, e As EventArgs) Handles cmdDownload.Click

        ' This adds the ability to download ".rtf" files (May be changing) the user inputs a URL and then the function downloads
        ' the file and is stored in the users "temp" folder, once downloaded the sets the settings so that the next form has
        ' knowledge that this file is here to be opened.
        Dim downloadURL As String
        Dim tempSave = My.Computer.FileSystem.SpecialDirectories.Temp & "\temp.rtf"


        My.Settings.Download_Enable = True

        downloadURL = InputBox("Please Enter The URL For A Text File (.rtf)")

        Dim webClient As New WebClient
        webClient.DownloadFile(downloadURL, tempSave)

        If (System.IO.File.Exists(tempSave)) Then

            My.Settings.Download_Temp = tempSave

            Word_Main.Show()
            Me.Hide()

        Else



        End If

    End Sub

    Private Sub Main_Load_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        ' Closes the application.
        Application.Exit()

    End Sub

End Class