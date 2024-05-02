<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings_ViewServices
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox1 = New GroupBox()
        dgvServices = New DataGridView()
        Button2 = New Button()
        btnLoad = New Button()
        GroupBox1.SuspendLayout()
        CType(dgvServices, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dgvServices)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(663, 486)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "All Services"
        ' 
        ' dgvServices
        ' 
        dgvServices.AllowUserToAddRows = False
        dgvServices.AllowUserToDeleteRows = False
        dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Blue
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvServices.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvServices.Dock = DockStyle.Fill
        dgvServices.Location = New Point(3, 21)
        dgvServices.Name = "dgvServices"
        dgvServices.ReadOnly = True
        dgvServices.Size = New Size(657, 462)
        dgvServices.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        Button2.FlatAppearance.BorderSize = 3
        Button2.FlatAppearance.MouseOverBackColor = Color.Red
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(698, 240)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 30)
        Button2.TabIndex = 5
        Button2.Text = "E&xit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' btnLoad
        ' 
        btnLoad.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnLoad.FlatAppearance.BorderSize = 3
        btnLoad.FlatAppearance.MouseOverBackColor = Color.Lime
        btnLoad.FlatStyle = FlatStyle.Flat
        btnLoad.Location = New Point(699, 190)
        btnLoad.Name = "btnLoad"
        btnLoad.Size = New Size(75, 30)
        btnLoad.TabIndex = 4
        btnLoad.Text = "&Load"
        btnLoad.UseVisualStyleBackColor = False
        ' 
        ' frmSettings_ViewServices
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(800, 510)
        ControlBox = False
        Controls.Add(Button2)
        Controls.Add(btnLoad)
        Controls.Add(GroupBox1)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "frmSettings_ViewServices"
        StartPosition = FormStartPosition.CenterScreen
        Text = "View all services"
        GroupBox1.ResumeLayout(False)
        CType(dgvServices, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvServices As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents btnLoad As Button
End Class
