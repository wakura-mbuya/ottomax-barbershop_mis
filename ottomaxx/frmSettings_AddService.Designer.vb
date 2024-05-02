<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings_AddService
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
        txtPrice = New TextBox()
        Label5 = New Label()
        txtDescription = New TextBox()
        Label4 = New Label()
        btnExit = New Button()
        btnSave = New Button()
        txtServiceName = New TextBox()
        Label3 = New Label()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtPrice)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txtDescription)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(btnExit)
        GroupBox1.Controls.Add(btnSave)
        GroupBox1.Controls.Add(txtServiceName)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(12, 38)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(490, 292)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Enter shop details"
        ' 
        ' txtPrice
        ' 
        txtPrice.Font = New Font("Verdana", 11.25F)
        txtPrice.Location = New Point(152, 90)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(307, 26)
        txtPrice.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(42, 100)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 16)
        Label5.TabIndex = 2
        Label5.Text = "Price:"
        ' 
        ' txtDescription
        ' 
        txtDescription.Font = New Font("Verdana", 11.25F)
        txtDescription.Location = New Point(152, 133)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(307, 82)
        txtDescription.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(42, 143)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 16)
        Label4.TabIndex = 4
        Label4.Text = "Description:"
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnExit.FlatAppearance.BorderColor = Color.Gray
        btnExit.FlatAppearance.BorderSize = 3
        btnExit.FlatAppearance.MouseOverBackColor = Color.Red
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Location = New Point(367, 238)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(92, 34)
        btnExit.TabIndex = 7
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnSave.FlatAppearance.BorderColor = Color.Gray
        btnSave.FlatAppearance.BorderSize = 3
        btnSave.FlatAppearance.MouseOverBackColor = Color.Lime
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Location = New Point(246, 238)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(92, 34)
        btnSave.TabIndex = 6
        btnSave.Text = "&Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtServiceName
        ' 
        txtServiceName.Font = New Font("Verdana", 11.25F)
        txtServiceName.Location = New Point(152, 43)
        txtServiceName.Name = "txtServiceName"
        txtServiceName.Size = New Size(307, 26)
        txtServiceName.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(37, 53)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 16)
        Label3.TabIndex = 0
        Label3.Text = "Service Name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 12F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(227, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 18)
        Label1.TabIndex = 10
        Label1.Text = "Add Service"
        ' 
        ' frmSettings_AddService
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(530, 355)
        ControlBox = False
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "frmSettings_AddService"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Service"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtServiceName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
