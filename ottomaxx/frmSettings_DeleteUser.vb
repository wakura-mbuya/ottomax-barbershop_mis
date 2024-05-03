Public Class frmSettings_DeleteUser
    Private Sub frmSettings_DeleteUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDelete.Enabled = False
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        If Not String.IsNullOrEmpty(txtUsername.Text) Then
            btnDelete.Enabled = True
        Else
            btnDelete.Enabled = False
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class