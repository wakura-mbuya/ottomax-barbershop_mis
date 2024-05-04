<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings_AddItem
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
        btnExit = New Button()
        btnSave = New Button()
        cmbxShops = New ComboBox()
        txtQuantity = New TextBox()
        txtItemName = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnExit)
        GroupBox1.Controls.Add(btnSave)
        GroupBox1.Controls.Add(cmbxShops)
        GroupBox1.Controls.Add(txtQuantity)
        GroupBox1.Controls.Add(txtItemName)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(12, 45)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(451, 201)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Enter item details"
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnExit.FlatAppearance.BorderSize = 3
        btnExit.FlatAppearance.MouseOverBackColor = Color.Red
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Location = New Point(348, 158)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 28)
        btnExit.TabIndex = 7
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnSave.FlatAppearance.BorderSize = 3
        btnSave.FlatAppearance.MouseOverBackColor = Color.Lime
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Location = New Point(240, 158)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 28)
        btnSave.TabIndex = 6
        btnSave.Text = "&Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' cmbxShops
        ' 
        cmbxShops.DropDownStyle = ComboBoxStyle.DropDownList
        cmbxShops.FlatStyle = FlatStyle.Popup
        cmbxShops.FormattingEnabled = True
        cmbxShops.Items.AddRange(New Object() {"Shop A", "Shop B"})
        cmbxShops.Location = New Point(142, 112)
        cmbxShops.Name = "cmbxShops"
        cmbxShops.Size = New Size(281, 24)
        cmbxShops.TabIndex = 5
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(142, 75)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(281, 23)
        txtQuantity.TabIndex = 3
        ' 
        ' txtItemName
        ' 
        txtItemName.Location = New Point(142, 38)
        txtItemName.Name = "txtItemName"
        txtItemName.Size = New Size(281, 23)
        txtItemName.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(45, 112)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 16)
        Label4.TabIndex = 4
        Label4.Text = "Shop:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(45, 75)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 16)
        Label3.TabIndex = 2
        Label3.Text = "Quantity:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(45, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 16)
        Label2.TabIndex = 0
        Label2.Text = "Item name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(133, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(224, 16)
        Label1.TabIndex = 1
        Label1.Text = "Add shop item and equipment"
        ' 
        ' frmSettings_AddItem
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(475, 256)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "frmSettings_AddItem"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Shop Item"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents cmbxShops As ComboBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
