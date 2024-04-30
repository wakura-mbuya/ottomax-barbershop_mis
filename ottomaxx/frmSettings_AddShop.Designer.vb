<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings_AddShop
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
        Label2 = New Label()
        Label3 = New Label()
        txtShopID = New TextBox()
        txtShopName = New TextBox()
        btnSave = New Button()
        btnExit = New Button()
        GroupBox1 = New GroupBox()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(59, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 16)
        Label2.TabIndex = 4
        Label2.Text = "Shop ID:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(37, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 16)
        Label3.TabIndex = 0
        Label3.Text = "Shop Name:"
        ' 
        ' txtShopID
        ' 
        txtShopID.Font = New Font("Verdana", 11.25F)
        txtShopID.Location = New Point(152, 33)
        txtShopID.Name = "txtShopID"
        txtShopID.ReadOnly = True
        txtShopID.Size = New Size(307, 26)
        txtShopID.TabIndex = 5
        ' 
        ' txtShopName
        ' 
        txtShopName.Font = New Font("Verdana", 11.25F)
        txtShopName.Location = New Point(152, 73)
        txtShopName.Name = "txtShopName"
        txtShopName.Size = New Size(307, 26)
        txtShopName.TabIndex = 1
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnSave.FlatAppearance.BorderColor = Color.Gray
        btnSave.FlatAppearance.BorderSize = 3
        btnSave.FlatAppearance.MouseOverBackColor = Color.Lime
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Location = New Point(246, 117)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(92, 34)
        btnSave.TabIndex = 2
        btnSave.Text = "&Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnExit.FlatAppearance.BorderColor = Color.Gray
        btnExit.FlatAppearance.BorderSize = 3
        btnExit.FlatAppearance.MouseOverBackColor = Color.Red
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Location = New Point(367, 117)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(92, 34)
        btnExit.TabIndex = 3
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnExit)
        GroupBox1.Controls.Add(btnSave)
        GroupBox1.Controls.Add(txtShopName)
        GroupBox1.Controls.Add(txtShopID)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(39, 89)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(506, 178)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Enter shop details"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._1_transparent
        PictureBox1.Location = New Point(387, 8)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(117, 108)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' frmSettings_AddShop
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(583, 306)
        ControlBox = False
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.Fixed3D
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmSettings_AddShop"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Shop"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtShopID As TextBox
    Friend WithEvents txtShopName As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
