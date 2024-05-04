Public Class frmSettings_AddItem
    Private Sub frmSettings_AddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSave.Enabled = False
    End Sub

    Private Sub txtItemName_TextChanged(sender As Object, e As EventArgs) Handles txtItemName.TextChanged
        btnSave.Enabled = (Not String.IsNullOrEmpty(txtItemName.Text) AndAlso Not String.IsNullOrEmpty(txtQuantity.Text) AndAlso cmbxShops.SelectedIndex >= 0)
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        btnSave.Enabled = (Not String.IsNullOrEmpty(txtItemName.Text) AndAlso Not String.IsNullOrEmpty(txtQuantity.Text) AndAlso cmbxShops.SelectedIndex >= 0)
    End Sub

    Private Sub cmbxShops_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxShops.SelectedIndexChanged
        btnSave.Enabled = (Not String.IsNullOrEmpty(txtItemName.Text) AndAlso Not String.IsNullOrEmpty(txtQuantity.Text) AndAlso cmbxShops.SelectedIndex >= 0)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        ' allow only nums and backspace
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub
End Class