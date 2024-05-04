<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings_EditUser
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
        btnSearch = New Button()
        btnExit = New Button()
        btnSave = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnSearch)
        GroupBox1.Controls.Add(btnExit)
        GroupBox1.Controls.Add(btnSave)
        GroupBox1.Controls.Add(txtPassword)
        GroupBox1.Controls.Add(txtUsername)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(19, 43)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(500, 163)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Enter user details"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackgroundImage = My.Resources.Resources.Search
        btnSearch.BackgroundImageLayout = ImageLayout.Stretch
        btnSearch.FlatAppearance.BorderColor = Color.Silver
        btnSearch.FlatAppearance.BorderSize = 3
        btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Location = New Point(450, 35)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(36, 31)
        btnSearch.TabIndex = 2
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnExit.FlatAppearance.BorderSize = 3
        btnExit.FlatAppearance.MouseOverBackColor = Color.Red
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Location = New Point(410, 113)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 32)
        btnExit.TabIndex = 6
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnSave.FlatAppearance.BorderSize = 3
        btnSave.FlatAppearance.MouseOverBackColor = Color.Lime
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Location = New Point(315, 113)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 32)
        btnSave.TabIndex = 5
        btnSave.Text = "&Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(106, 75)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(379, 23)
        txtPassword.TabIndex = 4
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(106, 39)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(341, 23)
        txtUsername.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(25, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 16)
        Label3.TabIndex = 3
        Label3.Text = "Password:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(23, 42)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 16)
        Label2.TabIndex = 0
        Label2.Text = "Username:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(250, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 16)
        Label1.TabIndex = 0
        Label1.Text = "Edit User"
        ' 
        ' frmSettings_EditUser
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(541, 220)
        ControlBox = False
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "frmSettings_EditUser"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Edit user details"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Button
End Class
