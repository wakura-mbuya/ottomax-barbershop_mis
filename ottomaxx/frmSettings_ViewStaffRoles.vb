Public Class frmSettings_ViewStaffRoles
    Private Sub frmSettings_ViewStaffRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        ' load roles and display them on the datagrid view
        Dim roleCtrl As New Role
        Dim errString As String = ""
        Dim rolesDtbl As New DataTable

        rolesDtbl = roleCtrl.GetRoles(errString)
        If IsNothing(rolesDtbl) Then
            MsgBox(errString, MsgBoxStyle.Exclamation, "Ottomaxx")
            dgvRoles.DataSource = Nothing
        Else
            dgvRoles.DataSource = rolesDtbl
        End If
    End Sub
End Class