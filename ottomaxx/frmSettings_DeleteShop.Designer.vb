<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings_DeleteShop
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
        btnExit = New Button()
        btnDelete = New Button()
        txtShopName = New TextBox()
        txtShopID = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnSearch)
        GroupBox1.Controls.Add(btnExit)
        GroupBox1.Controls.Add(btnDelete)
        GroupBox1.Controls.Add(txtShopName)
        GroupBox1.Controls.Add(txtShopID)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(13, 93)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(506, 178)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Enter shop details"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackgroundImage = My.Resources.Resources.Search
        btnSearch.BackgroundImageLayout = ImageLayout.Stretch
        btnSearch.FlatAppearance.BorderColor = Color.Silver
        btnSearch.FlatAppearance.BorderSize = 3
        btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Location = New Point(429, 27)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(42, 38)
        btnSearch.TabIndex = 2
        btnSearch.UseVisualStyleBackColor = True
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
        btnExit.TabIndex = 6
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnDelete.FlatAppearance.BorderColor = Color.Gray
        btnDelete.FlatAppearance.BorderSize = 3
        btnDelete.FlatAppearance.MouseOverBackColor = Color.Lime
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Location = New Point(246, 117)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(92, 34)
        btnDelete.TabIndex = 5
        btnDelete.Text = "&Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' txtShopName
        ' 
        txtShopName.Font = New Font("Verdana", 11.25F)
        txtShopName.Location = New Point(152, 73)
        txtShopName.Name = "txtShopName"
        txtShopName.Size = New Size(319, 26)
        txtShopName.TabIndex = 4
        ' 
        ' txtShopID
        ' 
        txtShopID.Font = New Font("Verdana", 11.25F)
        txtShopID.Location = New Point(152, 33)
        txtShopID.Name = "txtShopID"
        txtShopID.Size = New Size(271, 26)
        txtShopID.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(37, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 17)
        Label3.TabIndex = 3
        Label3.Text = "Shop Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(59, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 17)
        Label2.TabIndex = 0
        Label2.Text = "Shop ID:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._1_transparent
        PictureBox1.Location = New Point(350, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(117, 108)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' frmSettings_DeleteShop
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(529, 287)
        ControlBox = False
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "frmSettings_DeleteShop"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Delete Shop"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtShopName As TextBox
    Friend WithEvents txtShopID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSearch As Button
End Class
