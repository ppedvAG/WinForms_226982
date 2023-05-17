Public Class Form1

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Text = My.Resources.Titel

        'Text = My.Settings.Text
        BackColor = My.Settings.MeinFarbe

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Label1.Text = TextBox1.Text

        Me.BackColor = Color.Yellow

    End Sub

    Private Sub showSplittPanel2Button_Click(sender As Object, e As EventArgs) Handles showSplittPanel2Button.Click

        SplitContainer1.Panel2Collapsed = Not SplitContainer1.Panel2Collapsed

    End Sub



    Private Sub ÖffneBüchersucheToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÖffneBüchersucheToolStripMenuItem.Click

        Dim frm = New Form()
        frm.Text = "Die beste Büchersuche der Welt"
        frm.Width = 800
        frm.Height = 600
        frm.StartPosition = FormStartPosition.CenterParent

        Dim gbs = New GoogleBooksAPISuche()
        gbs.Dock = DockStyle.Fill
        frm.Controls.Add(gbs)

        frm.Show(Me)

    End Sub
End Class
