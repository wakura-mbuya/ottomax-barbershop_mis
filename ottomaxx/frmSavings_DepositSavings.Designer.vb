<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSavings_DepositSavings
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
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtID = New TextBox()
        txtName = New TextBox()
        txtRole = New TextBox()
        txtAmount = New TextBox()
        dtpDate = New DateTimePicker()
        btnExit = New Button()
        btnSave = New Button()
        GroupBox1 = New GroupBox()
        btnSearch = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(201, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 16)
        Label1.TabIndex = 0
        Label1.Text = "Deposit Savings"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 16)
        Label2.TabIndex = 0
        Label2.Text = "Staff ID:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 65)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 16)
        Label3.TabIndex = 3
        Label3.Text = "Staff Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(24, 105)
        Label4.Name = "Label4"
        Label4.Size = New Size(40, 16)
        Label4.TabIndex = 5
        Label4.Text = "Role:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(24, 145)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 16)
        Label5.TabIndex = 7
        Label5.Text = "Amount:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(24, 185)
        Label6.Name = "Label6"
        Label6.Size = New Size(44, 16)
        Label6.TabIndex = 9
        Label6.Text = "Date:"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(124, 25)
        txtID.Name = "txtID"
        txtID.Size = New Size(267, 23)
        txtID.TabIndex = 1
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(124, 65)
        txtName.Name = "txtName"
        txtName.Size = New Size(311, 23)
        txtName.TabIndex = 4
        ' 
        ' txtRole
        ' 
        txtRole.Enabled = False
        txtRole.Location = New Point(124, 105)
        txtRole.Name = "txtRole"
        txtRole.Size = New Size(311, 23)
        txtRole.TabIndex = 6
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(124, 145)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(311, 23)
        txtAmount.TabIndex = 8
        ' 
        ' dtpDate
        ' 
        dtpDate.Location = New Point(124, 185)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(311, 23)
        dtpDate.TabIndex = 10
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnExit.FlatAppearance.BorderSize = 3
        btnExit.FlatAppearance.MouseOverBackColor = Color.Red
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Location = New Point(360, 227)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 32)
        btnExit.TabIndex = 12
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnSave.FlatAppearance.BorderSize = 3
        btnSave.FlatAppearance.MouseOverBackColor = Color.Lime
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Location = New Point(269, 227)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 32)
        btnSave.TabIndex = 11
        btnSave.Text = "&Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnSearch)
        GroupBox1.Controls.Add(btnExit)
        GroupBox1.Controls.Add(btnSave)
        GroupBox1.Controls.Add(dtpDate)
        GroupBox1.Controls.Add(txtAmount)
        GroupBox1.Controls.Add(txtRole)
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(txtID)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(12, 35)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(463, 279)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Savings Details"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackgroundImage = My.Resources.Resources.Search
        btnSearch.BackgroundImageLayout = ImageLayout.Stretch
        btnSearch.FlatAppearance.BorderColor = Color.Silver
        btnSearch.FlatAppearance.BorderSize = 3
        btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Location = New Point(397, 22)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(38, 29)
        btnSearch.TabIndex = 2
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' frmSavings_DepositSavings
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(497, 326)
        ControlBox = False
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "frmSavings_DepositSavings"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Deposit Savings"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtRole As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSearch As Button
End Class
