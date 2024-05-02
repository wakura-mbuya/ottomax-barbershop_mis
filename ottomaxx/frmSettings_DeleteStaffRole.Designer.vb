<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings_DeleteStaffRole
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
        btnSearch = New Button()
        btnDelete = New Button()
        btnExit = New Button()
        txtRole = New TextBox()
        txtID = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnSearch
        ' 
        btnSearch.BackgroundImage = My.Resources.Resources.Search
        btnSearch.BackgroundImageLayout = ImageLayout.Stretch
        btnSearch.FlatAppearance.BorderColor = Color.Silver
        btnSearch.FlatAppearance.BorderSize = 3
        btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Location = New Point(353, 45)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(38, 35)
        btnSearch.TabIndex = 2
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnDelete.FlatAppearance.BorderSize = 3
        btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Location = New Point(200, 132)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(84, 27)
        btnDelete.TabIndex = 5
        btnDelete.Text = "&Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnExit.FlatAppearance.BorderSize = 3
        btnExit.FlatAppearance.MouseOverBackColor = Color.Red
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Location = New Point(307, 132)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(84, 27)
        btnExit.TabIndex = 6
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' txtRole
        ' 
        txtRole.Location = New Point(96, 91)
        txtRole.Name = "txtRole"
        txtRole.Size = New Size(295, 23)
        txtRole.TabIndex = 4
        ' 
        ' txtID
        ' 
        txtID.Enabled = False
        txtID.Location = New Point(96, 51)
        txtID.Name = "txtID"
        txtID.Size = New Size(251, 23)
        txtID.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(28, 94)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 16)
        Label3.TabIndex = 3
        Label3.Text = "Role:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(28, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 16)
        Label2.TabIndex = 0
        Label2.Text = "Role ID:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(185, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 16)
        Label1.TabIndex = 7
        Label1.Text = "Delete Role"
        ' 
        ' frmSettings_DeleteStaffRole
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(439, 173)
        ControlBox = False
        Controls.Add(btnSearch)
        Controls.Add(btnDelete)
        Controls.Add(btnExit)
        Controls.Add(txtRole)
        Controls.Add(txtID)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "frmSettings_DeleteStaffRole"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Delete Role"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtRole As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
