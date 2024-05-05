<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSavings_WithdrawSavings
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
        btnExit = New Button()
        btnWithdraw = New Button()
        dtpDate = New DateTimePicker()
        txtWithdrawAmount = New TextBox()
        txtRole = New TextBox()
        txtName = New TextBox()
        txtID = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        txtSavings = New TextBox()
        Label7 = New Label()
        btnSearch = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(215, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 16)
        Label1.TabIndex = 0
        Label1.Text = "Withdraw Savings"
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnExit.FlatAppearance.BorderSize = 3
        btnExit.FlatAppearance.MouseOverBackColor = Color.Red
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Location = New Point(400, 270)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 32)
        btnExit.TabIndex = 14
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnWithdraw
        ' 
        btnWithdraw.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnWithdraw.FlatAppearance.BorderSize = 3
        btnWithdraw.FlatAppearance.MouseOverBackColor = Color.Lime
        btnWithdraw.FlatStyle = FlatStyle.Flat
        btnWithdraw.Location = New Point(299, 270)
        btnWithdraw.Name = "btnWithdraw"
        btnWithdraw.Size = New Size(85, 32)
        btnWithdraw.TabIndex = 13
        btnWithdraw.Text = "&Withdraw"
        btnWithdraw.UseVisualStyleBackColor = False
        ' 
        ' dtpDate
        ' 
        dtpDate.Location = New Point(164, 235)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(311, 23)
        dtpDate.TabIndex = 12
        ' 
        ' txtWithdrawAmount
        ' 
        txtWithdrawAmount.Location = New Point(164, 193)
        txtWithdrawAmount.Name = "txtWithdrawAmount"
        txtWithdrawAmount.Size = New Size(311, 23)
        txtWithdrawAmount.TabIndex = 10
        ' 
        ' txtRole
        ' 
        txtRole.Enabled = False
        txtRole.Location = New Point(164, 109)
        txtRole.Name = "txtRole"
        txtRole.Size = New Size(311, 23)
        txtRole.TabIndex = 6
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(164, 67)
        txtName.Name = "txtName"
        txtName.Size = New Size(311, 23)
        txtName.TabIndex = 4
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(164, 25)
        txtID.Name = "txtID"
        txtID.Size = New Size(267, 23)
        txtID.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(24, 235)
        Label6.Name = "Label6"
        Label6.Size = New Size(44, 16)
        Label6.TabIndex = 11
        Label6.Text = "Date:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(24, 193)
        Label5.Name = "Label5"
        Label5.Size = New Size(130, 16)
        Label5.TabIndex = 9
        Label5.Text = "Withdraw Amount:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(24, 109)
        Label4.Name = "Label4"
        Label4.Size = New Size(40, 16)
        Label4.TabIndex = 5
        Label4.Text = "Role:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 67)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 16)
        Label3.TabIndex = 3
        Label3.Text = "Staff Name:"
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
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtSavings)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(btnSearch)
        GroupBox1.Controls.Add(btnExit)
        GroupBox1.Controls.Add(btnWithdraw)
        GroupBox1.Controls.Add(dtpDate)
        GroupBox1.Controls.Add(txtWithdrawAmount)
        GroupBox1.Controls.Add(txtRole)
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(txtID)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(15, 28)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(505, 316)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Savings Withdrawal Details"
        ' 
        ' txtSavings
        ' 
        txtSavings.Enabled = False
        txtSavings.Location = New Point(164, 151)
        txtSavings.Name = "txtSavings"
        txtSavings.Size = New Size(311, 23)
        txtSavings.TabIndex = 8
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(24, 151)
        Label7.Name = "Label7"
        Label7.Size = New Size(127, 16)
        Label7.TabIndex = 7
        Label7.Text = "Available Savings:"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackgroundImage = My.Resources.Resources.Search
        btnSearch.BackgroundImageLayout = ImageLayout.Stretch
        btnSearch.FlatAppearance.BorderColor = Color.Silver
        btnSearch.FlatAppearance.BorderSize = 3
        btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Location = New Point(437, 22)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(38, 29)
        btnSearch.TabIndex = 2
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' frmSavings_WithdrawSavings
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(542, 359)
        ControlBox = False
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "frmSavings_WithdrawSavings"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Withdraw Savings"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnWithdraw As Button
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents txtWithdrawAmount As TextBox
    Friend WithEvents txtRole As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSavings As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSearch As Button
End Class
