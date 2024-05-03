Public Class frmSettings_DeleteStaffRole
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmSettings_DeleteStaffRole_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDelete.Enabled = False
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        If (Not String.IsNullOrEmpty(txtID.Text) AndAlso Not String.IsNullOrEmpty(txtRole.Text)) Then
            btnDelete.Enabled = True
        Else
            btnDelete.Enabled = False
        End If
    End Sub

    Private Sub txtRole_TextChanged(sender As Object, e As EventArgs) Handles txtRole.TextChanged
        If (Not String.IsNullOrEmpty(txtID.Text) AndAlso Not String.IsNullOrEmpty(txtRole.Text)) Then
            btnDelete.Enabled = True
        Else
            btnDelete.Enabled = False
        End If
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        ' allow only nums and backspace
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim roleCtrl As New Role
        Dim errString As String = ""
        Dim roleID As Integer
        Dim role As String

        ' if txtID filled, search by Role ID
        If Not String.IsNullOrEmpty(txtID.Text) Then
            roleID = Integer.Parse(txtID.Text)
            role = roleCtrl.GetRoleName(roleID, errString)
            If IsNothing(role) Then
                MsgBox(errString, MsgBoxStyle.Exclamation, "Ottomaxx")
                btnDelete.Enabled = False : Exit Sub
            Else
                txtRole.Text = role
                btnDelete.Enabled = True : Exit Sub
            End If
        End If

        ' Check if txtRole is filled
        If Not String.IsNullOrEmpty(txtRole.Text) Then
            role = txtRole.Text
            roleID = roleCtrl.GetRoleID(role, errString)
            If roleID > 0 Then
                ' role found
                txtID.Text = roleID.ToString : Exit Sub
            Else
                MsgBox(errString, MsgBoxStyle.Exclamation, "Ottomaxx") : Exit Sub
            End If
        End If

        ' both ID and role not filled
        MsgBox("Enter either role ID or role name and try again", MsgBoxStyle.Exclamation, "Ottomaxx")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim roleCtrl As New Role
        Dim errString As String = ""
        Dim role As String
        Dim roleID As Integer

        role = txtRole.Text
        roleID = txtID.Text

        If roleCtrl.DeleteRole(roleID, errString) Then
            MsgBox("Successfully deleted the role details", MsgBoxStyle.Information, "Ottomaxx")
            txtID.Text = String.Empty
            txtRole.Text = String.Empty
        Else
            MsgBox(errString, MsgBoxStyle.Exclamation, "Ottomaxx")
        End If
    End Sub
End Class