<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create_Account1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        btnCreate = New Button()
        dtDOB = New DateTimePicker()
        cbmGender = New ComboBox()
        txtAddr = New TextBox()
        txtphone = New TextBox()
        txtpassword = New TextBox()
        txtemail = New TextBox()
        lblAddress = New Label()
        lblGender = New Label()
        lblPhone = New Label()
        lblDBO = New Label()
        lblPassword = New Label()
        lblEmail = New Label()
        txtlastName = New TextBox()
        txtname = New TextBox()
        lblLastname = New Label()
        lblName = New Label()
        Panel1 = New Panel()
        TextBox1 = New TextBox()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.LightCyan
        GroupBox1.Controls.Add(btnCreate)
        GroupBox1.Controls.Add(dtDOB)
        GroupBox1.Controls.Add(cbmGender)
        GroupBox1.Controls.Add(txtAddr)
        GroupBox1.Controls.Add(txtphone)
        GroupBox1.Controls.Add(txtpassword)
        GroupBox1.Controls.Add(txtemail)
        GroupBox1.Controls.Add(lblAddress)
        GroupBox1.Controls.Add(lblGender)
        GroupBox1.Controls.Add(lblPhone)
        GroupBox1.Controls.Add(lblDBO)
        GroupBox1.Controls.Add(lblPassword)
        GroupBox1.Controls.Add(lblEmail)
        GroupBox1.Controls.Add(txtlastName)
        GroupBox1.Controls.Add(txtname)
        GroupBox1.Controls.Add(lblLastname)
        GroupBox1.Controls.Add(lblName)
        GroupBox1.Controls.Add(Panel1)
        GroupBox1.Location = New Point(-2, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(823, 513)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' btnCreate
        ' 
        btnCreate.Location = New Point(358, 460)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(112, 37)
        btnCreate.TabIndex = 17
        btnCreate.Text = "Create"
        btnCreate.UseVisualStyleBackColor = True
        ' 
        ' dtDOB
        ' 
        dtDOB.Location = New Point(39, 320)
        dtDOB.Name = "dtDOB"
        dtDOB.Size = New Size(300, 31)
        dtDOB.TabIndex = 16
        ' 
        ' cbmGender
        ' 
        cbmGender.FormattingEnabled = True
        cbmGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        cbmGender.Location = New Point(39, 408)
        cbmGender.Name = "cbmGender"
        cbmGender.Size = New Size(300, 33)
        cbmGender.TabIndex = 15
        ' 
        ' txtAddr
        ' 
        txtAddr.Location = New Point(487, 408)
        txtAddr.Name = "txtAddr"
        txtAddr.Size = New Size(300, 31)
        txtAddr.TabIndex = 14
        ' 
        ' txtphone
        ' 
        txtphone.Location = New Point(487, 320)
        txtphone.Name = "txtphone"
        txtphone.Size = New Size(300, 31)
        txtphone.TabIndex = 13
        ' 
        ' txtpassword
        ' 
        txtpassword.Location = New Point(487, 217)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(300, 31)
        txtpassword.TabIndex = 12
        ' 
        ' txtemail
        ' 
        txtemail.Location = New Point(38, 217)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(301, 31)
        txtemail.TabIndex = 11
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Location = New Point(603, 372)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(85, 25)
        lblAddress.TabIndex = 10
        lblAddress.Text = "*Address"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(130, 372)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(77, 25)
        lblGender.TabIndex = 9
        lblGender.Text = "*Gender"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(589, 273)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(70, 25)
        lblPhone.TabIndex = 8
        lblPhone.Text = "*Phone"
        ' 
        ' lblDBO
        ' 
        lblDBO.AutoSize = True
        lblDBO.Location = New Point(126, 273)
        lblDBO.Name = "lblDBO"
        lblDBO.Size = New Size(123, 25)
        lblDBO.TabIndex = 7
        lblDBO.Text = "*Date Of Birth"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(589, 168)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(95, 25)
        lblPassword.TabIndex = 6
        lblPassword.Text = "*Password"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(126, 168)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(62, 25)
        lblEmail.TabIndex = 5
        lblEmail.Text = "*Email"
        ' 
        ' txtlastName
        ' 
        txtlastName.Location = New Point(487, 118)
        txtlastName.Name = "txtlastName"
        txtlastName.Size = New Size(300, 31)
        txtlastName.TabIndex = 4
        ' 
        ' txtname
        ' 
        txtname.Location = New Point(38, 118)
        txtname.Name = "txtname"
        txtname.Size = New Size(301, 31)
        txtname.TabIndex = 3
        ' 
        ' lblLastname
        ' 
        lblLastname.AutoSize = True
        lblLastname.Location = New Point(589, 80)
        lblLastname.Name = "lblLastname"
        lblLastname.Size = New Size(103, 25)
        lblLastname.TabIndex = 2
        lblLastname.Text = "*Last Name"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(126, 80)
        lblName.Name = "lblName"
        lblName.Size = New Size(67, 25)
        lblName.TabIndex = 1
        lblName.Text = "*Name"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.PowderBlue
        Panel1.Controls.Add(TextBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(817, 63)
        Panel1.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.PowderBlue
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.ForeColor = SystemColors.MenuHighlight
        TextBox1.Location = New Point(250, 1)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(320, 59)
        TextBox1.TabIndex = 0
        TextBox1.Text = "Create Account"
        ' 
        ' Create_Account1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(817, 509)
        Controls.Add(GroupBox1)
        Name = "Create_Account1"
        Text = "Create_Account1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbmGender As ComboBox
    Friend WithEvents txtAddr As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblDBO As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtlastName As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents lblLastname As Label
    Friend WithEvents lblName As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents dtDOB As DateTimePicker
    Friend WithEvents btnCreate As Button
End Class
