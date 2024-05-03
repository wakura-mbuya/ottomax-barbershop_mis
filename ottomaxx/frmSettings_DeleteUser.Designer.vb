<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings_DeleteUser
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
        btnExit = New Button()
        btnDelete = New Button()
        txtUsername = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnExit)
        GroupBox1.Controls.Add(btnDelete)
        GroupBox1.Controls.Add(txtUsername)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(24, 33)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(536, 122)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Enter username"
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnExit.FlatAppearance.BorderSize = 3
        btnExit.FlatAppearance.MouseOverBackColor = Color.Red
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Location = New Point(434, 72)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(86, 34)
        btnExit.TabIndex = 3
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnDelete.FlatAppearance.BorderSize = 3
        btnDelete.FlatAppearance.MouseOverBackColor = Color.Lime
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Location = New Point(325, 72)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(86, 34)
        btnDelete.TabIndex = 2
        btnDelete.Text = "&Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(131, 30)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(389, 23)
        txtUsername.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(46, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 16)
        Label2.TabIndex = 0
        Label2.Text = "Username:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(257, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 16)
        Label1.TabIndex = 1
        Label1.Text = "Delete User"
        ' 
        ' frmSettings_DeleteUser
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(568, 169)
        ControlBox = False
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "frmSettings_DeleteUser"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Delete User"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
