Public Class MyButton
    Inherits Button

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)

        pevent.Graphics.FillRectangle(New SolidBrush(Parent.BackColor), Me.ClientRectangle)
        pevent.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        If Me.ClientRectangle.Contains(Me.PointToClient(MousePosition)) Then
            If MouseButtons.HasFlag(MouseButtons.Left) Then
                pevent.Graphics.FillEllipse(Brushes.YellowGreen, Me.ClientRectangle)
            Else
                pevent.Graphics.FillEllipse(Brushes.OrangeRed, Me.ClientRectangle)
            End If
        Else
            pevent.Graphics.FillEllipse(Brushes.CornflowerBlue, Me.ClientRectangle)
        End If

        Dim border = Me.ClientRectangle
        border.Inflate(-3, -3)
        pevent.Graphics.DrawEllipse(New Pen(Color.DarkRed, 3), border)

        Dim sf = New StringFormat()
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        pevent.Graphics.DrawString(Text, SystemFonts.DefaultFont, New SolidBrush(ForeColor), ClientRectangle, sf)

    End Sub

End Class
