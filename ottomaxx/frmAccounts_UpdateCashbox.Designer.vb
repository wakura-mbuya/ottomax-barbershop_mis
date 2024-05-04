<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccounts_UpdateCashbox
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
        btnExit = New Button()
        btnSave = New Button()
        GroupBox1 = New GroupBox()
        Label5 = New Label()
        Label4 = New Label()
        txtCloseBal = New TextBox()
        txtBank = New TextBox()
        txtOpenBal = New TextBox()
        Label3 = New Label()
        dtpStart = New DateTimePicker()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnExit.FlatAppearance.BorderSize = 2
        btnExit.FlatAppearance.MouseOverBackColor = Color.Red
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Location = New Point(325, 185)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(78, 29)
        btnExit.TabIndex = 9
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnSave.FlatAppearance.BorderSize = 2
        btnSave.FlatAppearance.MouseOverBackColor = Color.Lime
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Location = New Point(238, 185)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(78, 29)
        btnSave.TabIndex = 8
        btnSave.Text = "&Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        GroupBox1.Controls.Add(btnExit)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(btnSave)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txtCloseBal)
        GroupBox1.Controls.Add(txtBank)
        GroupBox1.Controls.Add(txtOpenBal)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(dtpStart)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.Location = New Point(39, 28)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(424, 239)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Cashbox details"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(29, 116)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 16)
        Label5.TabIndex = 4
        Label5.Text = "Cash to Bank:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(29, 156)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 16)
        Label4.TabIndex = 6
        Label4.Text = "Closing Balance:"
        ' 
        ' txtCloseBal
        ' 
        txtCloseBal.Location = New Point(156, 156)
        txtCloseBal.Name = "txtCloseBal"
        txtCloseBal.Size = New Size(247, 23)
        txtCloseBal.TabIndex = 7
        ' 
        ' txtBank
        ' 
        txtBank.Location = New Point(156, 116)
        txtBank.Name = "txtBank"
        txtBank.Size = New Size(247, 23)
        txtBank.TabIndex = 5
        ' 
        ' txtOpenBal
        ' 
        txtOpenBal.Location = New Point(156, 76)
        txtOpenBal.Name = "txtOpenBal"
        txtOpenBal.Size = New Size(247, 23)
        txtOpenBal.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(29, 76)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 16)
        Label3.TabIndex = 2
        Label3.Text = "Opening Balance:"
        ' 
        ' dtpStart
        ' 
        dtpStart.Location = New Point(156, 36)
        dtpStart.Name = "dtpStart"
        dtpStart.Size = New Size(247, 23)
        dtpStart.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(29, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 16)
        Label2.TabIndex = 0
        Label2.Text = "Date:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(195, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 16)
        Label1.TabIndex = 0
        Label1.Text = "Update Cashbox"
        ' 
        ' frmAccounts_UpdateCashbox
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(496, 279)
        ControlBox = False
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "frmAccounts_UpdateCashbox"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Update Cashbox"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCloseBal As TextBox
    Friend WithEvents txtBank As TextBox
    Friend WithEvents txtOpenBal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
