Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim client As New ServiceReference1.TestServiceClient()

        Label1.Text = client.Sum(NumericUpDown1.Value, NumericUpDown2.Value)

    End Sub
End Class
