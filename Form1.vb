
Imports System.Data
Imports System.Data.SqlClient
Imports System.Xml
Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-7400\SQLEXPRESS;Initial Catalog=vbloginform;Integrated Security=True;TrustServerCertificate=true")
        Dim cmd As SqlCommand = New SqlCommand("select *from login where username='" + txtUser.Text + "'and password='" + txtPass.Text + "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then

            Dim user As String = dt.Rows(0).Item("username").ToString()
            MessageBox.Show("login success" + user, "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If
        Dim username As String
        Dim password As String
        username = txtUser.Text
        password = txtPass.Text
        If (username.Equals("admin") And password.Equals("admin")) Then
            MessageBox.Show("login success", "information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            Dim fdash As New Dashboard()



            Result.Show()
            Me.Hide()




        Else
            MessageBox.Show("Error", "information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Create_Account1.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPass.UseSystemPasswordChar = True
        Else
            txtPass.UseSystemPasswordChar = False
        End If
    End Sub
End Class

