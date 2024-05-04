Public Class frmSettings_DeleteItem
    Private Sub txtItemID_TextChanged(sender As Object, e As EventArgs) Handles txtItemID.TextChanged,
            txtItemName.TextChanged
        btnDelete.Enabled = (Not String.IsNullOrEmpty(txtItemID.Text) AndAlso Not String.IsNullOrEmpty(txtItemName.Text))
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub txtItemID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItemID.KeyPress
        If ((e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmSettings_DeleteItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDelete.Enabled = False
    End Sub
End Class