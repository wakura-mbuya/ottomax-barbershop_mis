<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccounts_CashboxHistory
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
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        dtpEnd = New DateTimePicker()
        Label3 = New Label()
        dtpStart = New DateTimePicker()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        dgvCashbox = New DataGridView()
        btnExit = New Button()
        btnGenerate = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dgvCashbox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(369, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 16)
        Label1.TabIndex = 2
        Label1.Text = "Cashbox History"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        GroupBox1.Controls.Add(dtpEnd)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(dtpStart)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.Location = New Point(12, 24)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(402, 97)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' dtpEnd
        ' 
        dtpEnd.Location = New Point(98, 58)
        dtpEnd.Name = "dtpEnd"
        dtpEnd.Size = New Size(247, 22)
        dtpEnd.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 58)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 14)
        Label3.TabIndex = 2
        Label3.Text = "End Date:"
        ' 
        ' dtpStart
        ' 
        dtpStart.Location = New Point(98, 27)
        dtpStart.Name = "dtpStart"
        dtpStart.Size = New Size(247, 22)
        dtpStart.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 14)
        Label2.TabIndex = 0
        Label2.Text = "Start Date:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        GroupBox2.Controls.Add(dgvCashbox)
        GroupBox2.FlatStyle = FlatStyle.Flat
        GroupBox2.Location = New Point(12, 127)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(822, 400)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Cashbox history"
        ' 
        ' dgvCashbox
        ' 
        dgvCashbox.AllowUserToAddRows = False
        dgvCashbox.AllowUserToDeleteRows = False
        dgvCashbox.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Blue
        DataGridViewCellStyle1.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvCashbox.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvCashbox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCashbox.Dock = DockStyle.Fill
        dgvCashbox.Location = New Point(3, 18)
        dgvCashbox.Name = "dgvCashbox"
        dgvCashbox.ReadOnly = True
        dgvCashbox.Size = New Size(816, 379)
        dgvCashbox.TabIndex = 0
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnExit.FlatAppearance.BorderSize = 2
        btnExit.FlatAppearance.MouseOverBackColor = Color.Red
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Location = New Point(689, 81)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(142, 29)
        btnExit.TabIndex = 7
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnGenerate
        ' 
        btnGenerate.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnGenerate.FlatAppearance.BorderSize = 2
        btnGenerate.FlatAppearance.MouseOverBackColor = Color.Lime
        btnGenerate.FlatStyle = FlatStyle.Flat
        btnGenerate.Location = New Point(689, 44)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(142, 29)
        btnGenerate.TabIndex = 6
        btnGenerate.Text = "&Generate History"
        btnGenerate.UseVisualStyleBackColor = False
        ' 
        ' frmAccounts_CashboxHistory
        ' 
        AutoScaleDimensions = New SizeF(8F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(846, 539)
        ControlBox = False
        Controls.Add(btnExit)
        Controls.Add(btnGenerate)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "frmAccounts_CashboxHistory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "View Cashbox History"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(dgvCashbox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvCashbox As DataGridView
    Friend WithEvents btnExit As Button
    Friend WithEvents btnGenerate As Button
End Class
