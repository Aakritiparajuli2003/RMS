

Imports System.Data.SqlClient

Public Class Create_Account1
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim qs = "Data Source=LAPTOP-7400\SQLEXPRESS;Initial Catalog=vb login form.dbo;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"
        Dim query = String.Empty
        query &= "insert into [dbo].[create account]([name] ,[last name] ,[email] ,[password], "
        query &= "                               [address] ,[date of birth] ,[phone] ,[gender])  "
        query &= "values (@name, @last name, @email, @passwd, @address, @dob, @phone, @gender)"
        Using conn As New SqlConnection(qs)
            Using comm As New SqlCommand
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@name", txtname.Text)
                    .Parameters.AddWithValue("@last name", txtlastName.Text)
                    .Parameters.AddWithValue("@email", txtemail.Text)
                    .Parameters.AddWithValue("@passwd", txtpassword.Text)
                    .Parameters.AddWithValue("@address", txtAddr.Text)
                    .Parameters.AddWithValue("@dob", dtDOB.Value)
                    .Parameters.AddWithValue("@phone", txtphone.Text)
                    .Parameters.AddWithValue("@gender", cbmGender.SelectedItem.ToString())
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    MessageBox.Show("you account is created successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As SqlException
                    MessageBox.Show(ex.Message.ToString, "error message")
                End Try
            End Using
        End Using
    End Sub
End Class
