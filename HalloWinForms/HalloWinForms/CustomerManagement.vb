Imports System.Data.SqlClient

Public Class CustomerManagement
    Private Sub loadButton_Click(sender As Object, e As EventArgs) Handles loadButton.Click

        'TODO rrror handling
        'Todo Dispose

        Dim conString = "Server=(localdb)\mssqllocaldb;Database=Northwnd;Trusted_Connection=true"

        Dim con = New SqlConnection(conString)
        con.Open()

        Dim cmd = New SqlCommand("SELECT * FROM Customers")
        cmd.Connection = con

        Dim reader = cmd.ExecuteReader()

        Dim customers As New List(Of Customer)

        While reader.Read()

            Dim newCust = New Customer()
            newCust.Id = reader.GetString(reader.GetOrdinal("CustomerID"))
            newCust.CompanyName = reader.GetString(reader.GetOrdinal("CompanyName"))
            newCust.ContactName = reader.GetString(reader.GetOrdinal("ContactName"))
            customers.Add(newCust)

        End While

        DataGridView1.DataSource = customers

    End Sub
End Class

Public Class Customer
    Property Id As String
    Property CompanyName As String
    Property ContactName As String
End Class
