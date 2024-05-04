<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccounts_ViewPayments
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
        dtpStart = New DateTimePicker()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        dgvPayments = New DataGridView()
        btnExit = New Button()
        btnGenerate = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dgvPayments, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        GroupBox1.Controls.Add(dtpStart)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.Location = New Point(46, 19)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(496, 72)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' dtpStart
        ' 
        dtpStart.Location = New Point(131, 27)
        dtpStart.Name = "dtpStart"
        dtpStart.Size = New Size(247, 22)
        dtpStart.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(7, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 14)
        Label2.TabIndex = 0
        Label2.Text = "Transaction Date:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(403, 4)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 16)
        Label1.TabIndex = 0
        Label1.Text = "Payments History"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        GroupBox2.Controls.Add(dgvPayments)
        GroupBox2.FlatStyle = FlatStyle.Flat
        GroupBox2.Location = New Point(46, 111)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(822, 411)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Payments history"
        ' 
        ' dgvPayments
        ' 
        dgvPayments.AllowUserToAddRows = False
        dgvPayments.AllowUserToDeleteRows = False
        dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Blue
        DataGridViewCellStyle1.Font = New Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvPayments.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPayments.Dock = DockStyle.Fill
        dgvPayments.Location = New Point(3, 18)
        dgvPayments.Name = "dgvPayments"
        dgvPayments.ReadOnly = True
        dgvPayments.Size = New Size(816, 390)
        dgvPayments.TabIndex = 0
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnExit.FlatAppearance.BorderSize = 2
        btnExit.FlatAppearance.MouseOverBackColor = Color.Red
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Location = New Point(697, 76)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(168, 29)
        btnExit.TabIndex = 4
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnGenerate
        ' 
        btnGenerate.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnGenerate.FlatAppearance.BorderSize = 2
        btnGenerate.FlatAppearance.MouseOverBackColor = Color.Lime
        btnGenerate.FlatStyle = FlatStyle.Flat
        btnGenerate.Location = New Point(697, 39)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(168, 29)
        btnGenerate.TabIndex = 2
        btnGenerate.Text = "&Generate Payments"
        btnGenerate.UseVisualStyleBackColor = False
        ' 
        ' frmAccounts_ViewPayments
        ' 
        AutoScaleDimensions = New SizeF(8F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(903, 565)
        ControlBox = False
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(GroupBox2)
        Controls.Add(btnExit)
        Controls.Add(btnGenerate)
        Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "frmAccounts_ViewPayments"
        StartPosition = FormStartPosition.CenterScreen
        Text = "View Payments"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(dgvPayments, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvPayments As DataGridView
    Friend WithEvents btnExit As Button
    Friend WithEvents btnGenerate As Button
End Class
