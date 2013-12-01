<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Load
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
        Me.cmdDownload = New System.Windows.Forms.Button()
        Me.cmdOpen = New System.Windows.Forms.Button()
        Me.cmdCreateNew = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdDownload
        '
        Me.cmdDownload.BackColor = System.Drawing.Color.Transparent
        Me.cmdDownload.BackgroundImage = Global.Word_Processor.My.Resources.Resources.downloadFile
        Me.cmdDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdDownload.Location = New System.Drawing.Point(216, 181)
        Me.cmdDownload.Name = "cmdDownload"
        Me.cmdDownload.Size = New System.Drawing.Size(56, 54)
        Me.cmdDownload.TabIndex = 2
        Me.cmdDownload.UseVisualStyleBackColor = False
        '
        'cmdOpen
        '
        Me.cmdOpen.BackColor = System.Drawing.Color.Transparent
        Me.cmdOpen.BackgroundImage = Global.Word_Processor.My.Resources.Resources.fileOpen
        Me.cmdOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdOpen.Location = New System.Drawing.Point(278, 181)
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(56, 54)
        Me.cmdOpen.TabIndex = 1
        Me.cmdOpen.UseVisualStyleBackColor = False
        '
        'cmdCreateNew
        '
        Me.cmdCreateNew.BackColor = System.Drawing.Color.Transparent
        Me.cmdCreateNew.BackgroundImage = Global.Word_Processor.My.Resources.Resources.createNew
        Me.cmdCreateNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdCreateNew.Location = New System.Drawing.Point(12, 181)
        Me.cmdCreateNew.Name = "cmdCreateNew"
        Me.cmdCreateNew.Size = New System.Drawing.Size(56, 54)
        Me.cmdCreateNew.TabIndex = 0
        Me.cmdCreateNew.UseVisualStyleBackColor = False
        '
        'Main_Load
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 247)
        Me.Controls.Add(Me.cmdDownload)
        Me.Controls.Add(Me.cmdOpen)
        Me.Controls.Add(Me.cmdCreateNew)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main_Load"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Word Processor | Welcome"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdCreateNew As System.Windows.Forms.Button
    Friend WithEvents cmdOpen As System.Windows.Forms.Button
    Friend WithEvents cmdDownload As System.Windows.Forms.Button
End Class
