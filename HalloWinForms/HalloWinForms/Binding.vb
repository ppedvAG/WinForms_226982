
Public Class Binding

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        TextBox2.DataBindings.Add("Text", TextBox1, "Text", True, DataSourceUpdateMode.OnPropertyChanged)
        TextBox2.DataBindings.Add("BackColor", TextBox1, "Text", True, DataSourceUpdateMode.OnPropertyChanged)

        PictureBox1.DataBindings.Add(NameOf(PictureBox1.Visible), CheckBox1, NameOf(CheckBox1.Checked))

        Dim persons = New List(Of Person)()
        Dim p1 = New Person With {
            .Id = 1,
            .Name = "Fred",
            .BDate = DateTime.Now.AddDays(-50000)
        }
        Dim p2 = New Person With {
            .Id = 2,
            .Name = "Wilma",
            .BDate = DateTime.Now.AddDays(-30000)
        }
        persons.Add(p1)
        persons.Add(p2)

        BindingSource1.DataSource = persons

        nameTextBox.DataBindings.Add("Text", BindingSource1, "Name", True, DataSourceUpdateMode.OnPropertyChanged)
        idLabel.DataBindings.Add("Text", BindingSource1, "Id", True)
        gebDateTimePicker.DataBindings.Add(NameOf(DateTimePicker.Value), BindingSource1, NameOf(Person.BDate), True, DataSourceUpdateMode.OnPropertyChanged)

        'ListBox1.DisplayMember = "Name" 'nur 1 Property

    End Sub

    Private Sub ListBox1_Format(sender As Object, e As ListControlConvertEventArgs) Handles ListBox1.Format

        Dim person = CType(e.Value, Person)
        If person IsNot Nothing Then
            e.Value = $"{person.Id} {person.Name} {person.BDate:d}"
        End If

    End Sub

    Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
        e.Graphics.FillEllipse(Brushes.Orange, e.CellBounds)

    End Sub
End Class

Class Person
    Property Id As Integer
    Property Name As String
    Property BDate As DateTime

    'Schlechte IDEE!
    'Public Overrides Function ToString() As String
    '    Return $"{Id} {Name} {BDate:d}"
    'End Function
End Class
