<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings_EditStaffRole
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
        btnSave = New Button()
        btnExit = New Button()
        txtRole = New TextBox()
        txtID = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnSearch = New Button()
        SuspendLayout()
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnSave.FlatAppearance.BorderSize = 3
        btnSave.FlatAppearance.MouseOverBackColor = Color.Lime
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Location = New Point(205, 144)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(84, 27)
        btnSave.TabIndex = 5
        btnSave.Text = "&Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnExit.FlatAppearance.BorderSize = 3
        btnExit.FlatAppearance.MouseOverBackColor = Color.Red
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Location = New Point(312, 144)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(84, 27)
        btnExit.TabIndex = 6
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' txtRole
        ' 
        txtRole.Location = New Point(101, 103)
        txtRole.Name = "txtRole"
        txtRole.Size = New Size(295, 23)
        txtRole.TabIndex = 4
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(101, 63)
        txtID.Name = "txtID"
        txtID.Size = New Size(251, 23)
        txtID.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(33, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 16)
        Label3.TabIndex = 3
        Label3.Text = "Role:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(33, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 16)
        Label2.TabIndex = 0
        Label2.Text = "Role ID:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(205, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 16)
        Label1.TabIndex = 7
        Label1.Text = "Edit Role"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackgroundImage = My.Resources.Resources.Search
        btnSearch.BackgroundImageLayout = ImageLayout.Stretch
        btnSearch.FlatAppearance.BorderColor = Color.Silver
        btnSearch.FlatAppearance.BorderSize = 3
        btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Location = New Point(358, 57)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(38, 35)
        btnSearch.TabIndex = 2
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' frmSettings_EditStaffRole
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(438, 192)
        ControlBox = False
        Controls.Add(btnSearch)
        Controls.Add(btnSave)
        Controls.Add(btnExit)
        Controls.Add(txtRole)
        Controls.Add(txtID)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "frmSettings_EditStaffRole"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Edit Staff Role"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtRole As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Button
End Class
