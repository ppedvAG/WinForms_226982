Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing

Public Class CustomerManagement
    Private Sub loadButton_Click(sender As Object, e As EventArgs) Handles loadButton.Click

        'TODO rrror handling
        'Todo Dispose
        Dim con As SqlConnection
        Try
            Dim conString = "Server=(localdb)\mssqllocaldb;Database=Northwnd;Trusted_Connection=true"

            con = New SqlConnection(conString)
            con.Open()

            Dim cmd = New SqlCommand("SELECT * FROM Customerserölkmfgrlökmlerkmglkerm")
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

        Catch ex As SqlException
            MessageBox.Show($"SQL ERORR: {ex.Message}", ":-(", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", ":-(", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con Is Not Nothing Then
                con.Close()
            End If

        End Try

    End Sub
End Class

Public Class Customer
    Property Id As String
    Property CompanyName As String
    Property ContactName As String
End Class
