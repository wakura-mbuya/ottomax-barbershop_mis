<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoans_RepayLoan
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
        txtStaffRole = New TextBox()
        txtStaffName = New TextBox()
        txtStaffID = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        dtpAppDate = New DateTimePicker()
        txtInstallments = New TextBox()
        txtPrincipal = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        txtLoanID = New TextBox()
        Label4 = New Label()
        GroupBox3 = New GroupBox()
        dtpRepayDate = New DateTimePicker()
        txtRepayAmount = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        btnSave = New Button()
        btnExit = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnSearch)
        GroupBox1.Controls.Add(txtStaffRole)
        GroupBox1.Controls.Add(txtStaffName)
        GroupBox1.Controls.Add(txtStaffID)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(14, 33)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(570, 152)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Staff Details"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackgroundImage = My.Resources.Resources.Search
        btnSearch.BackgroundImageLayout = ImageLayout.Stretch
        btnSearch.FlatAppearance.BorderColor = Color.Silver
        btnSearch.FlatAppearance.BorderSize = 3
        btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Location = New Point(504, 18)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(36, 32)
        btnSearch.TabIndex = 7
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtStaffRole
        ' 
        txtStaffRole.Enabled = False
        txtStaffRole.Location = New Point(119, 109)
        txtStaffRole.Name = "txtStaffRole"
        txtStaffRole.Size = New Size(421, 23)
        txtStaffRole.TabIndex = 6
        ' 
        ' txtStaffName
        ' 
        txtStaffName.Location = New Point(119, 66)
        txtStaffName.Name = "txtStaffName"
        txtStaffName.Size = New Size(421, 23)
        txtStaffName.TabIndex = 5
        ' 
        ' txtStaffID
        ' 
        txtStaffID.Location = New Point(119, 23)
        txtStaffID.Name = "txtStaffID"
        txtStaffID.Size = New Size(379, 23)
        txtStaffID.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(26, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 16)
        Label3.TabIndex = 2
        Label3.Text = "Role:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 16)
        Label2.TabIndex = 1
        Label2.Text = "Staff Name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(26, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 16)
        Label1.TabIndex = 0
        Label1.Text = "Staff ID:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(dtpAppDate)
        GroupBox2.Controls.Add(txtInstallments)
        GroupBox2.Controls.Add(txtPrincipal)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(txtLoanID)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Enabled = False
        GroupBox2.Location = New Point(14, 191)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(570, 228)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Loan Details"
        ' 
        ' dtpAppDate
        ' 
        dtpAppDate.Location = New Point(188, 124)
        dtpAppDate.Name = "dtpAppDate"
        dtpAppDate.Size = New Size(352, 23)
        dtpAppDate.TabIndex = 13
        ' 
        ' txtInstallments
        ' 
        txtInstallments.Location = New Point(188, 163)
        txtInstallments.Name = "txtInstallments"
        txtInstallments.Size = New Size(352, 23)
        txtInstallments.TabIndex = 12
        ' 
        ' txtPrincipal
        ' 
        txtPrincipal.Location = New Point(188, 85)
        txtPrincipal.Name = "txtPrincipal"
        txtPrincipal.Size = New Size(352, 23)
        txtPrincipal.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(26, 163)
        Label7.Name = "Label7"
        Label7.Size = New Size(150, 16)
        Label7.TabIndex = 10
        Label7.Text = "Monthly Installments:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(26, 124)
        Label6.Name = "Label6"
        Label6.Size = New Size(157, 16)
        Label6.TabIndex = 9
        Label6.Text = "Loan Application Date:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(26, 85)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 16)
        Label5.TabIndex = 8
        Label5.Text = "Principal Amount:"
        ' 
        ' txtLoanID
        ' 
        txtLoanID.Location = New Point(188, 46)
        txtLoanID.Name = "txtLoanID"
        txtLoanID.Size = New Size(352, 23)
        txtLoanID.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(26, 46)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 16)
        Label4.TabIndex = 3
        Label4.Text = "Loan ID:"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(dtpRepayDate)
        GroupBox3.Controls.Add(txtRepayAmount)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Location = New Point(14, 425)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(570, 101)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "Repayment Details"
        ' 
        ' dtpRepayDate
        ' 
        dtpRepayDate.Location = New Point(188, 61)
        dtpRepayDate.Name = "dtpRepayDate"
        dtpRepayDate.Size = New Size(352, 23)
        dtpRepayDate.TabIndex = 17
        ' 
        ' txtRepayAmount
        ' 
        txtRepayAmount.Location = New Point(188, 22)
        txtRepayAmount.Name = "txtRepayAmount"
        txtRepayAmount.Size = New Size(352, 23)
        txtRepayAmount.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(26, 61)
        Label8.Name = "Label8"
        Label8.Size = New Size(122, 16)
        Label8.TabIndex = 15
        Label8.Text = "Repayment Date:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(26, 22)
        Label9.Name = "Label9"
        Label9.Size = New Size(63, 16)
        Label9.TabIndex = 14
        Label9.Text = "Amount:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Verdana", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(324, 14)
        Label10.Name = "Label10"
        Label10.Size = New Size(91, 16)
        Label10.TabIndex = 7
        Label10.Text = "Repay Loan"
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnSave.FlatAppearance.BorderSize = 3
        btnSave.FlatAppearance.MouseOverBackColor = Color.Lime
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Location = New Point(607, 262)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 32)
        btnSave.TabIndex = 8
        btnSave.Text = "&Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnExit.FlatAppearance.BorderSize = 3
        btnExit.FlatAppearance.MouseOverBackColor = Color.Red
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Location = New Point(607, 315)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 32)
        btnExit.TabIndex = 9
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' frmLoans_RepayLoan
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(704, 547)
        ControlBox = False
        Controls.Add(btnExit)
        Controls.Add(btnSave)
        Controls.Add(Label10)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "frmLoans_RepayLoan"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Loan repayment"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtStaffRole As TextBox
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents txtStaffID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLoanID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpAppDate As DateTimePicker
    Friend WithEvents txtInstallments As TextBox
    Friend WithEvents txtPrincipal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpRepayDate As DateTimePicker
    Friend WithEvents txtRepayAmount As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSearch As Button
End Class
