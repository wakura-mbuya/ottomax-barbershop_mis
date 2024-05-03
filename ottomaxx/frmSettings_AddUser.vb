Public Class frmSettings_AddUser
    Private Sub frmSettings_AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSave.Enabled = False
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        If (Not String.IsNullOrEmpty(txtPassword.Text AndAlso Not String.IsNullOrEmpty(txtUsername.Text))) Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If (Not String.IsNullOrEmpty(txtPassword.Text AndAlso Not String.IsNullOrEmpty(txtUsername.Text))) Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class