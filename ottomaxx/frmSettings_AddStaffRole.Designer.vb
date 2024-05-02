<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings_AddStaffRole
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtID = New TextBox()
        txtRole = New TextBox()
        btnSave = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(155, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 16)
        Label1.TabIndex = 6
        Label1.Text = "Add Staff Role"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(34, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 16)
        Label2.TabIndex = 0
        Label2.Text = "Role ID:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(34, 122)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 16)
        Label3.TabIndex = 2
        Label3.Text = "Role:"
        ' 
        ' txtID
        ' 
        txtID.Enabled = False
        txtID.Location = New Point(102, 79)
        txtID.Name = "txtID"
        txtID.Size = New Size(289, 23)
        txtID.TabIndex = 1
        ' 
        ' txtRole
        ' 
        txtRole.Location = New Point(102, 119)
        txtRole.Name = "txtRole"
        txtRole.Size = New Size(289, 23)
        txtRole.TabIndex = 3
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnSave.FlatAppearance.BorderSize = 3
        btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Location = New Point(200, 159)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(84, 27)
        btnSave.TabIndex = 4
        btnSave.Text = "&Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnExit.FlatAppearance.BorderSize = 3
        btnExit.FlatAppearance.MouseOverBackColor = Color.Red
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Location = New Point(307, 159)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(84, 27)
        btnExit.TabIndex = 5
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' frmSettings_AddStaffRole
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(428, 202)
        ControlBox = False
        Controls.Add(btnSave)
        Controls.Add(btnExit)
        Controls.Add(txtRole)
        Controls.Add(txtID)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "frmSettings_AddStaffRole"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Staff Role"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtRole As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExit As Button
End Class
