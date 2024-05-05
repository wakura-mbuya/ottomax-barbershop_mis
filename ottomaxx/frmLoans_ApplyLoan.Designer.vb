<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoans_ApplyLoan
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
        GroupBox1 = New GroupBox()
        btnSearch = New Button()
        txtPrincipal = New TextBox()
        Label7 = New Label()
        btnExit = New Button()
        btnApply = New Button()
        dtpAppDate = New DateTimePicker()
        txtInstallment = New TextBox()
        txtPosition = New TextBox()
        txtName = New TextBox()
        txtID = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(249, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 16)
        Label1.TabIndex = 1
        Label1.Text = "Apply Loan"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnSearch)
        GroupBox1.Controls.Add(txtPrincipal)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(btnExit)
        GroupBox1.Controls.Add(btnApply)
        GroupBox1.Controls.Add(dtpAppDate)
        GroupBox1.Controls.Add(txtInstallment)
        GroupBox1.Controls.Add(txtPosition)
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(txtID)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(32, 32)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(524, 338)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Loan details"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackgroundImage = My.Resources.Resources.Search
        btnSearch.BackgroundImageLayout = ImageLayout.Stretch
        btnSearch.FlatAppearance.BorderColor = Color.Silver
        btnSearch.FlatAppearance.BorderSize = 3
        btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Location = New Point(453, 32)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(38, 35)
        btnSearch.TabIndex = 2
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtPrincipal
        ' 
        txtPrincipal.Location = New Point(231, 158)
        txtPrincipal.Name = "txtPrincipal"
        txtPrincipal.Size = New Size(260, 23)
        txtPrincipal.TabIndex = 8
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(40, 158)
        Label7.Name = "Label7"
        Label7.Size = New Size(122, 16)
        Label7.TabIndex = 7
        Label7.Text = "Principal Amount:"
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnExit.FlatAppearance.BorderSize = 3
        btnExit.FlatAppearance.MouseOverBackColor = Color.Red
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Location = New Point(416, 283)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 31)
        btnExit.TabIndex = 14
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnApply
        ' 
        btnApply.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnApply.FlatAppearance.BorderSize = 3
        btnApply.FlatAppearance.MouseOverBackColor = Color.Lime
        btnApply.FlatStyle = FlatStyle.Flat
        btnApply.Location = New Point(309, 283)
        btnApply.Name = "btnApply"
        btnApply.Size = New Size(75, 31)
        btnApply.TabIndex = 13
        btnApply.Text = "&Apply"
        btnApply.UseVisualStyleBackColor = False
        ' 
        ' dtpAppDate
        ' 
        dtpAppDate.Location = New Point(231, 238)
        dtpAppDate.Name = "dtpAppDate"
        dtpAppDate.Size = New Size(260, 23)
        dtpAppDate.TabIndex = 12
        ' 
        ' txtInstallment
        ' 
        txtInstallment.Location = New Point(231, 198)
        txtInstallment.Name = "txtInstallment"
        txtInstallment.Size = New Size(260, 23)
        txtInstallment.TabIndex = 10
        ' 
        ' txtPosition
        ' 
        txtPosition.Location = New Point(231, 118)
        txtPosition.Name = "txtPosition"
        txtPosition.ReadOnly = True
        txtPosition.Size = New Size(260, 23)
        txtPosition.TabIndex = 6
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(231, 78)
        txtName.Name = "txtName"
        txtName.Size = New Size(260, 23)
        txtName.TabIndex = 4
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(231, 38)
        txtID.Name = "txtID"
        txtID.Size = New Size(216, 23)
        txtID.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(40, 238)
        Label6.Name = "Label6"
        Label6.Size = New Size(157, 16)
        Label6.TabIndex = 11
        Label6.Text = "Loan Application Date:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(40, 198)
        Label5.Name = "Label5"
        Label5.Size = New Size(150, 16)
        Label5.TabIndex = 9
        Label5.Text = "Monthly Installments:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(40, 118)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 16)
        Label4.TabIndex = 5
        Label4.Text = "Position:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(40, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 16)
        Label3.TabIndex = 3
        Label3.Text = "Staff Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(40, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 16)
        Label2.TabIndex = 0
        Label2.Text = "Staff ID:"
        ' 
        ' frmLoans_ApplyLoan
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(586, 397)
        ControlBox = False
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "frmLoans_ApplyLoan"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Request Loan"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPrincipal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnApply As Button
    Friend WithEvents dtpAppDate As DateTimePicker
    Friend WithEvents txtInstallment As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents btnSearch As Button
End Class
