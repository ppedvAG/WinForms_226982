Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Runtime.InteropServices

Public Class CustomerManagement

    Dim conString = "Server=(localdb)\mssqllocaldb;Database=Northwnd;Trusted_Connection=true"
    Private Sub loadButton_Click(sender As Object, e As EventArgs) Handles loadButton.Click

        Try

            Using con = New SqlConnection(conString)

                con.Open()

                Using cmd = New SqlCommand("SELECT * FROM Customers")

                    cmd.Connection = con

                    Using reader = cmd.ExecuteReader()

                        Dim customers As New List(Of Customer)

                        While reader.Read()

                            Dim newCust = New Customer()
                            newCust.Id = reader.GetString(reader.GetOrdinal("CustomerID"))
                            If Not reader.IsDBNull(reader.GetOrdinal("CompanyName")) Then
                                newCust.CompanyName = reader.GetString(reader.GetOrdinal("CompanyName"))
                            End If
                            If Not reader.IsDBNull(reader.GetOrdinal("ContactName")) Then
                                newCust.ContactName = reader.GetString(reader.GetOrdinal("ContactName"))
                            End If

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

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click

        Dim selectedCustomer = CType(DataGridView1?.CurrentRow?.DataBoundItem, Customer)
        If selectedCustomer Is Nothing Then
            MessageBox.Show("Es ist kein Customer ausgewählt")
            Return
        End If

        Dim msgText = $"Soll der Customer {selectedCustomer.CompanyName} wirklich gelöscht werden?"
        Dim dlgRes = MessageBox.Show(msgText, "Löschen?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dlgRes = DialogResult.Yes Then
            Try
                Using con = New SqlConnection(conString)
                    con.Open()
                    Using cmd = con.CreateCommand()
                        cmd.CommandText = "DELETE FROM Customers WHERE CustomerId = @custId"
                        cmd.Parameters.AddWithValue("@custId", selectedCustomer.Id)
                        Dim rows = cmd.ExecuteNonQuery()
                        MessageBox.Show($"{rows} Zeile wurden gelöscht")
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}", ":-(", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


End Class

Public Class Customer
    Property Id As String
    Property CompanyName As String
    Property ContactName As String
End Class
