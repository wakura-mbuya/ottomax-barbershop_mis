<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSavings_ViewSavingWithdrawals
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
        dgvWithdrawals = New DataGridView()
        GroupBox2 = New GroupBox()
        btnSearch = New Button()
        txtRole = New TextBox()
        txtName = New TextBox()
        txtID = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnExit = New Button()
        btnLoad = New Button()
        GroupBox1.SuspendLayout()
        CType(dgvWithdrawals, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dgvWithdrawals)
        GroupBox1.Location = New Point(9, 172)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(589, 368)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Savings Withdrawals"
        ' 
        ' dgvWithdrawals
        ' 
        dgvWithdrawals.AllowUserToAddRows = False
        dgvWithdrawals.AllowUserToDeleteRows = False
        dgvWithdrawals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvWithdrawals.Dock = DockStyle.Fill
        dgvWithdrawals.Location = New Point(3, 17)
        dgvWithdrawals.Name = "dgvWithdrawals"
        dgvWithdrawals.ReadOnly = True
        dgvWithdrawals.Size = New Size(583, 348)
        dgvWithdrawals.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnSearch)
        GroupBox2.Controls.Add(txtRole)
        GroupBox2.Controls.Add(txtName)
        GroupBox2.Controls.Add(txtID)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Font = New Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(9, 29)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(589, 95)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Staff Details"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackgroundImage = My.Resources.Resources.Search
        btnSearch.BackgroundImageLayout = ImageLayout.Stretch
        btnSearch.FlatAppearance.BorderColor = Color.Silver
        btnSearch.FlatAppearance.BorderSize = 3
        btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Location = New Point(539, 9)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(32, 27)
        btnSearch.TabIndex = 2
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtRole
        ' 
        txtRole.Enabled = False
        txtRole.Location = New Point(179, 65)
        txtRole.Name = "txtRole"
        txtRole.Size = New Size(392, 21)
        txtRole.TabIndex = 6
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(179, 39)
        txtName.Name = "txtName"
        txtName.Size = New Size(392, 21)
        txtName.TabIndex = 4
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(179, 13)
        txtID.Name = "txtID"
        txtID.Size = New Size(354, 21)
        txtID.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(99, 73)
        Label4.Name = "Label4"
        Label4.Size = New Size(37, 13)
        Label4.TabIndex = 5
        Label4.Text = "Role:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(99, 47)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 13)
        Label3.TabIndex = 3
        Label3.Text = "Staff Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(99, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 13)
        Label2.TabIndex = 0
        Label2.Text = "Staff ID:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(235, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(184, 14)
        Label1.TabIndex = 0
        Label1.Text = "View Savings Withdrawals"
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnExit.FlatAppearance.BorderSize = 3
        btnExit.FlatAppearance.MouseOverBackColor = Color.Red
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Location = New Point(523, 130)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 32)
        btnExit.TabIndex = 4
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnLoad
        ' 
        btnLoad.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnLoad.FlatAppearance.BorderSize = 3
        btnLoad.FlatAppearance.MouseOverBackColor = Color.Lime
        btnLoad.FlatStyle = FlatStyle.Flat
        btnLoad.Location = New Point(430, 130)
        btnLoad.Name = "btnLoad"
        btnLoad.Size = New Size(75, 32)
        btnLoad.TabIndex = 2
        btnLoad.Text = "&Load"
        btnLoad.UseVisualStyleBackColor = False
        ' 
        ' frmSavings_ViewSavingWithdrawals
        ' 
        AutoScaleDimensions = New SizeF(7F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(622, 547)
        ControlBox = False
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Controls.Add(Label1)
        Controls.Add(btnExit)
        Controls.Add(btnLoad)
        Font = New Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "frmSavings_ViewSavingWithdrawals"
        StartPosition = FormStartPosition.CenterScreen
        Text = "View Savings Withdrawals"
        GroupBox1.ResumeLayout(False)
        CType(dgvWithdrawals, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvWithdrawals As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtRole As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLoad As Button
End Class
