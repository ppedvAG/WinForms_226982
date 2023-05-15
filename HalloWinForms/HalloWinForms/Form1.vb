Public Class Form1

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Label1.Text = TextBox1.Text

        Me.BackColor = Color.Yellow

    End Sub

    Private Sub showSplittPanel2Button_Click(sender As Object, e As EventArgs) Handles showSplittPanel2Button.Click

        SplitContainer1.Panel2Collapsed = Not SplitContainer1.Panel2Collapsed

    End Sub
End Class
