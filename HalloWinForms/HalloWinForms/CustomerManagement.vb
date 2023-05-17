Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing

Public Class CustomerManagement
    Private Sub loadButton_Click(sender As Object, e As EventArgs) Handles loadButton.Click

        Try
            Dim conString = "Server=(localdb)\mssqllocaldb;Database=Northwnd;Trusted_Connection=true"

            Using con = New SqlConnection(conString)

                con.Open()

                Using cmd = New SqlCommand("SELECT * FROM Customers")

                    cmd.Connection = con

                    Using reader = cmd.ExecuteReader()

                        Dim customers As New List(Of Customer)

                        While reader.Read()

                            Dim newCust = New Customer()
                            newCust.Id = reader.GetString(reader.GetOrdinal("CustomerID"))
                            newCust.CompanyName = reader.GetString(reader.GetOrdinal("CompanyName"))
                            newCust.ContactName = reader.GetString(reader.GetOrdinal("ContactName"))
                            customers.Add(newCust)

                        End While
                        DataGridView1.DataSource = customers

                    End Using 'reader.Dispose()
                End Using 'cmd.Dispose()  
            End Using 'con.Dispose() -> con.Close()

        Catch ex As SqlException
            MessageBox.Show($"SQL ERORR: {ex.Message}", ":-(", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", ":-(", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class

Public Class Customer
    Property Id As String
    Property CompanyName As String
    Property ContactName As String
End Class
