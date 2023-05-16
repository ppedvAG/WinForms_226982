Public Class MyDateRangeControl

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DateTimePicker1.Value = New DateTime(2023, 5, 15)
        DateTimePicker2.Value = New DateTime(2023, 5, 19)
    End Sub

    Public Property Start As DateTime
        Get
            Return DateTimePicker1.Value
        End Get
        Set(value As DateTime)
            DateTimePicker1.Value = value
        End Set
    End Property

    Public Property Ende As DateTime
        Get
            Return DateTimePicker2.Value
        End Get
        Set(value As DateTime)
            DateTimePicker2.Value = value
        End Set
    End Property

    Sub ShowDays()
        Dim daySpan As TimeSpan = (DateTimePicker2.Value - DateTimePicker1.Value)

        Label2.Text = $"{daySpan.TotalDays} Tage = {daySpan.TotalHours} Stunden = {daySpan.TotalMinutes} Minuten"
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        ShowDays()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        ShowDays()
    End Sub
End Class
