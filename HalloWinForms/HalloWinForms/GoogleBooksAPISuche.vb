Imports System.Net.Http
Imports Newtonsoft.Json

Public Class GoogleBooksAPISuche

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        booksDataGridView.AutoGenerateColumns = False

    End Sub

    Private Sub suchButton_Click(sender As Object, e As EventArgs) Handles suchButton.Click
        LoadBooks(suchTextBox.Text)
    End Sub

    Private Sub LoadBooks(suchText As String, Optional startIndex As Integer = 0)

        If (String.IsNullOrWhiteSpace(suchText)) Then
            MessageBox.Show("Bitte eine Suchtext eingeben")
            Return
        End If

        Dim url = $"https://www.googleapis.com/books/v1/volumes?q={suchText}&maxResults={maxRows}&startIndex={startIndex}"

        If nurDECheckBox.Checked Then
            url += "&langRestrict=de"
        End If

        Dim http = New HttpClient()
        Dim json = http.GetStringAsync(url).Result

        Dim result = JsonConvert.DeserializeObject(Of GoogleBooksResult)(json)

        CreatePageLinks(result)

        booksDataGridView.DataSource = result.items.Select(Function(x) x.volumeInfo).ToList()
    End Sub

    Dim maxRows As Integer = 40

    Private Sub CreatePageLinks(result As GoogleBooksResult)

        pagesFlowLayoutPanel.Controls.Clear()

        If (result.totalItems > maxRows) Then
            Dim pageCoung = maxRows / result.totalItems

            For index = 1 To 10
                Dim linkLbl = New LinkLabel()
                linkLbl.Text = $"{index}"
                linkLbl.AutoSize = True
                linkLbl.Tag = index
                AddHandler linkLbl.Click, Function(s, e)
                                              LoadBooks(suchTextBox.Text, ((CType(CType(s, Control).Tag, Integer) - 1) * maxRows))
                                          End Function
                pagesFlowLayoutPanel.Controls.Add(linkLbl)
            Next

        End If

    End Sub

    Private Sub booksDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles booksDataGridView.CellFormatting
        If e.ColumnIndex = authorsColumn.Index Then
            Dim authorenList = TryCast(e.Value, List(Of String))

            If authorenList IsNot Nothing Then
                e.Value = String.Join(", ", authorenList)
            End If
        End If
    End Sub
End Class
