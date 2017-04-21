Imports FastColoredTextBoxNS

Public Class Form1
    Dim ara As New FastColoredTextBoxNS.FastColoredTextBox
    Dim open As New OpenFileDialog
    Dim save As New SaveFileDialog


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        WebBrowser1.ScriptErrorsSuppressed = True
        ara.Text = My.Resources.html
        ara.Dock = DockStyle.Fill : ara.Language = FastColoredTextBoxNS.Language.HTML
        RichTextBox1.Controls.Add(ara)
        SyntaxRTB1.Text = My.Resources.vbscript
    End Sub

    Private Sub LOADToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOADToolStripMenuItem.Click
        open.DefaultExt = "*.html"
        open.Filter = "html files|*.html"
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            ara.Text = open.FileName
        End If
    End Sub

    Private Sub SAVEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAVEToolStripMenuItem.Click
        save.DefaultExt = "*.html"
        save.Filter = "html FILES|*.html"
        save.CreatePrompt = True
        If save.ShowDialog = Windows.Forms.DialogResult.OK Then
            'RichTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.RichText)
            My.Computer.FileSystem.WriteAllText(save.FileName, WebBrowser1.DocumentText, True)
        End If
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub RUNCODEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RUNCODEToolStripMenuItem.Click
        WebBrowser1.DocumentText = ara.Text
    End Sub
End Class
