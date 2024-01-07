Imports System.Data.SqlClient

Public Class CreateUserF

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblPassword.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblPhone.Click

    End Sub

    Private Sub txtGender_Click(sender As Object, e As EventArgs) Handles lblDBO.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lblGender.Click

    End Sub

    Private Sub lblAddress_Click(sender As Object, e As EventArgs) Handles lblAddress.Click

    End Sub
    Private Sub insert_botton_click(sender As Object, e As EventArgs) Handles btnCreate.Click
        '  Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-7400\SQLEXPRESS;Initial Catalog=createuservb;Integrated Security=True;TrustServerCertificate=true")
        Dim qs As String = "Data Source=LAPTOP-7400\SQLEXPRESS;Initial Catalog=createuservb;Integrated Security=True;TrustServerCertificate=true"

        Dim query As String = String.Empty
        query &= "INSERT INTO [dbo].[createuser]([first name] ,[last name] ,[email] ,[password], "
        query &= "                               [address] ,[date of birth] ,[phone] ,[gender])  "
        query &= "VALUES (@fname, @lname, @email, @passwd, @addr, @dob, @phone, @gender)"

        Using conn As New SqlConnection(qs)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@fname", txtUsername.Text)
                    .Parameters.AddWithValue("@lname", txtLastname.Text)
                    .Parameters.AddWithValue("@email", txtEmail.Text)
                    .Parameters.AddWithValue("@passwd", txtPassword.Text)
                    .Parameters.AddWithValue("@addr", txtAddr.Text)
                    .Parameters.AddWithValue("@dob", dtDOB.ToString())
                    .Parameters.AddWithValue("@phone", txtPhone.Text)
                    .Parameters.AddWithValue("@gender", cbmGender.SelectedItem.ToString())
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    MessageBox.Show("You Account is Created successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As SqlException
                    MessageBox.Show(ex.Message.ToString(), "Error Message")
                End Try
            End Using
        End Using
    End Sub


End Class

