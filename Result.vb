Imports System.Data
Imports System.Data.SqlClient
Public Class Result
    Private Sub Result_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim eng, nep, sci, mat, soc, com As Single
        Dim total As Single
        eng = Val(txtEnglish.Text)
        nep = Val(txtNepali.Text)
        sci = Val(txtScience.Text)
        mat = Val(txtMaths.Text)
        soc = Val(txtSocial.Text)
        com = Val(txtComputer.Text)
        total = eng + nep + sci + mat + soc + com
        Dim Average As Double
        Average = total / 5
        ListView1.Items.Add(New ListViewItem({txtname.Text, txtrollno.Text, txtclass.Text, txtaddress.Text, eng, nep, sci, mat, soc, com, total, Average}))
        txtname.Clear()
        txtrollno.Clear()
        txtclass.Clear()
        txtaddress.Clear()
        txtEnglish.Clear()
        txtNepali.Clear()
        txtScience.Clear()
        txtMaths.Clear()
        txtSocial.Clear()
        txtComputer.Clear()
    End Sub

    ' Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    '     Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-7400\SQLEXPRESS;Initial Catalog=vb login form.dbo;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
    '     Dim cmd As SqlCommand = New SqlCommand(" DELETE From [dbo].[Result]
    '   Where [Name]='" + txtname.Text + "'", con)
    '     con.Open()
    '     cmd.ExecuteNonQuery()
    '     MessageBox.Show("data deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '     con.Close()
    ' End Sub

    ' Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    '     Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-7400\SQLEXPRESS;Initial Catalog=vb login form.dbo;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
    '     Dim cmd As SqlCommand = New SqlCommand("UPDATE [dbo].[Result]
    'SET [Name] = '" + txtname.Text + "',[Roll NO] = '" + txtrollno.Text + "',[Class] = '" + txtclass.Text + "',[Address] = '" + txtaddress.Text + "'WHERE [Name]='" + txtname.Text + "'", con)
    '     con.Open()
    '     cmd.ExecuteNonQuery()
    '     MessageBox.Show("data updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '     con.Close()
    ' End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        ListView1.Columns.Add("Name", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Roll No", 50, HorizontalAlignment.Left)
        ListView1.Columns.Add("Class", 50, HorizontalAlignment.Left)
        ListView1.Columns.Add("Address", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("English", 50, HorizontalAlignment.Center)
        ListView1.Columns.Add("Nepali", 50, HorizontalAlignment.Center)
        ListView1.Columns.Add("Science", 50, HorizontalAlignment.Center)
        ListView1.Columns.Add("Maths", 50, HorizontalAlignment.Center)
        ListView1.Columns.Add("Social", 50, HorizontalAlignment.Center)
        ListView1.Columns.Add("Computer", 50, HorizontalAlignment.Center)
        'ListView1.Columns.Add("Full Mark", 100, HorizontalAlignment.Center)
        ' ListView1.Columns.Add("Obtained Mark", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Total", 50, HorizontalAlignment.Center)
        ListView1.Columns.Add("Average", 50, HorizontalAlignment.Center)


    End Sub
End Class