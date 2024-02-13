<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        CheckBox1 = New CheckBox()
        Button3 = New Button()
        Label2 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        txtPass = New TextBox()
        txtUser = New TextBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightCyan
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(txtPass)
        Panel1.Controls.Add(txtUser)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.ForeColor = Color.Black
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(461, 615)
        Panel1.TabIndex = 0
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Checked = True
        CheckBox1.CheckState = CheckState.Checked
        CheckBox1.Location = New Point(144, 422)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(162, 29)
        CheckBox1.TabIndex = 8
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Azure
        Button3.Location = New Point(151, 557)
        Button3.Name = "Button3"
        Button3.Size = New Size(155, 46)
        Button3.TabIndex = 7
        Button3.Text = "create account"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(210, 529)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 25)
        Label2.TabIndex = 6
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.GradientActiveCaption
        Button2.Location = New Point(285, 477)
        Button2.Name = "Button2"
        Button2.Size = New Size(133, 49)
        Button2.TabIndex = 5
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.GradientActiveCaption
        Button1.Location = New Point(60, 479)
        Button1.Name = "Button1"
        Button1.Size = New Size(135, 47)
        Button1.TabIndex = 4
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txtPass
        ' 
        txtPass.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtPass.Location = New Point(60, 354)
        txtPass.Multiline = True
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "*"c
        txtPass.PlaceholderText = "Password"
        txtPass.Size = New Size(315, 49)
        txtPass.TabIndex = 3
        txtPass.TextAlign = HorizontalAlignment.Center
        txtPass.UseSystemPasswordChar = True
        ' 
        ' txtUser
        ' 
        txtUser.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtUser.Location = New Point(60, 272)
        txtUser.Multiline = True
        txtUser.Name = "txtUser"
        txtUser.PlaceholderText = "User Name"
        txtUser.Size = New Size(315, 49)
        txtUser.TabIndex = 2
        txtUser.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(180, 211)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 30)
        Label1.TabIndex = 1
        Label1.Text = "Sign in"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(151, 35)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(156, 146)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(247))
        ClientSize = New Size(485, 639)
        Controls.Add(Panel1)
        ForeColor = Color.Black
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login Form"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox

End Class
