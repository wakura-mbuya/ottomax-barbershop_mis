<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings_ViewShops
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgvShops = New DataGridView()
        GroupBox1 = New GroupBox()
        btnLoad = New Button()
        Button2 = New Button()
        PictureBox1 = New PictureBox()
        CType(dgvShops, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvShops
        ' 
        dgvShops.AllowUserToAddRows = False
        dgvShops.AllowUserToDeleteRows = False
        dgvShops.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvShops.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvShops.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvShops.Dock = DockStyle.Fill
        dgvShops.Location = New Point(3, 19)
        dgvShops.Name = "dgvShops"
        dgvShops.ReadOnly = True
        dgvShops.Size = New Size(533, 389)
        dgvShops.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dgvShops)
        GroupBox1.Location = New Point(14, 19)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(539, 411)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "All Shops"
        ' 
        ' btnLoad
        ' 
        btnLoad.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnLoad.FlatAppearance.BorderSize = 3
        btnLoad.FlatAppearance.MouseOverBackColor = Color.Lime
        btnLoad.FlatStyle = FlatStyle.Flat
        btnLoad.Location = New Point(587, 221)
        btnLoad.Name = "btnLoad"
        btnLoad.Size = New Size(75, 30)
        btnLoad.TabIndex = 2
        btnLoad.Text = "&Load"
        btnLoad.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        Button2.FlatAppearance.BorderSize = 3
        Button2.FlatAppearance.MouseOverBackColor = Color.Red
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(586, 271)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 30)
        Button2.TabIndex = 3
        Button2.Text = "E&xit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._1_transparent
        PictureBox1.Location = New Point(573, 47)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(115, 120)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' frmSettings_ViewShops
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(700, 445)
        ControlBox = False
        Controls.Add(PictureBox1)
        Controls.Add(Button2)
        Controls.Add(btnLoad)
        Controls.Add(GroupBox1)
        Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "frmSettings_ViewShops"
        StartPosition = FormStartPosition.CenterScreen
        Text = "View Shops"
        CType(dgvShops, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvShops As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
