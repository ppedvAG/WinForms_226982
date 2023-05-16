Imports System.Text

Public Class ControlsByCode

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim btn As New Button()
        btn.Text = $"Klick mich! {FlowLayoutPanel2.Controls.Count}"
        btn.AutoSize = True
        btn.Tag = GenerateLargeString()
        AddHandler btn.Click, AddressOf ButtonWasClicked

        FlowLayoutPanel2.Controls.Add(btn)

    End Sub

    Private Sub ButtonWasClicked(sender As Object, e As EventArgs)

        Dim btn = TryCast(sender, Button)
        If btn IsNot Nothing Then

            btn.BackColor = Color.RosyBrown
            MessageBox.Show($"Hallo ich bin '{btn.Text}'")
            AddHandler FlowLayoutPanel2.DoubleClick, AddressOf ResetButtonsColor

        End If

    End Sub

    Private Sub ResetButtonsColor(sender As Object, e As EventArgs)
        For Each con As Control In FlowLayoutPanel2.Controls
            con.BackColor = SystemColors.Control
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FlowLayoutPanel2.Controls.Clear()

    End Sub

    Public Function GenerateLargeString() As String
        Dim sb As New StringBuilder()
        Dim dataSize As Integer = 10 * 1024 * 1024 ' 10 MB

        ' Füge den Buffer zum StringBuilder hinzu, bis die gewünschte Größe erreicht ist
        While sb.Length < dataSize
            sb.Append("B")
        End While

        Return sb.ToString()
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GC.Collect()
    End Sub
End Class
