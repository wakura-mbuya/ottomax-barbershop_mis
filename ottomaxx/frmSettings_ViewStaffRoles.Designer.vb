<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings_ViewStaffRoles
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
        dgvRoles = New DataGridView()
        btnLoad = New Button()
        btnExit = New Button()
        GroupBox1.SuspendLayout()
        CType(dgvRoles, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dgvRoles)
        GroupBox1.Location = New Point(27, 17)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(463, 442)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "All Staff Roles"
        ' 
        ' dgvRoles
        ' 
        dgvRoles.AllowUserToAddRows = False
        dgvRoles.AllowUserToDeleteRows = False
        dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRoles.Dock = DockStyle.Fill
        dgvRoles.Location = New Point(3, 19)
        dgvRoles.Name = "dgvRoles"
        dgvRoles.ReadOnly = True
        dgvRoles.Size = New Size(457, 420)
        dgvRoles.TabIndex = 0
        ' 
        ' btnLoad
        ' 
        btnLoad.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnLoad.FlatAppearance.BorderSize = 3
        btnLoad.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnLoad.FlatStyle = FlatStyle.Flat
        btnLoad.Location = New Point(292, 477)
        btnLoad.Name = "btnLoad"
        btnLoad.Size = New Size(84, 27)
        btnLoad.TabIndex = 7
        btnLoad.Text = "&Load"
        btnLoad.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnExit.FlatAppearance.BorderSize = 3
        btnExit.FlatAppearance.MouseOverBackColor = Color.Red
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Location = New Point(406, 477)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(84, 27)
        btnExit.TabIndex = 8
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' frmSettings_ViewStaffRoles
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(509, 516)
        ControlBox = False
        Controls.Add(btnLoad)
        Controls.Add(btnExit)
        Controls.Add(GroupBox1)
        Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "frmSettings_ViewStaffRoles"
        StartPosition = FormStartPosition.CenterScreen
        Text = "View Staff Roles"
        GroupBox1.ResumeLayout(False)
        CType(dgvRoles, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvRoles As DataGridView
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnExit As Button
End Class
