Public Class frmSettings_AddStaffRole
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmSettings_AddStaffRole_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSave.Enabled = False
    End Sub

    Private Sub txtRole_TextChanged(sender As Object, e As EventArgs) Handles txtRole.TextChanged
        If String.IsNullOrEmpty(txtRole.Text) Then
            btnSave.Enabled = False
        Else
            btnSave.Enabled = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' check if the role is already added in the database
        Dim roleCtrl As New Role
        Dim role As String
        Dim roleID As Integer
        Dim errString As String = ""

        role = txtRole.Text
        roleID = roleCtrl.GetRoleID(role, errString)
        If roleID = -1 Then
            MsgBox(errString, MsgBoxStyle.Critical, "Ottomaxx") : Exit Sub
        ElseIf roleID > 0 Then
            MsgBox(role + " already added to the system", MsgBoxStyle.Exclamation, "Ottomaxx") : Exit Sub
        End If

        ' Add the role to the database since it does not exist in the database
        If roleCtrl.AddRole(role, errString) Then
            MsgBox(role + " role added to the database successsfully", MsgBoxStyle.Information, "Ottomaxx")
        Else
            MsgBox(errString, MsgBoxStyle.Exclamation, "Ottomaxx")
        End If
    End Sub
End Class