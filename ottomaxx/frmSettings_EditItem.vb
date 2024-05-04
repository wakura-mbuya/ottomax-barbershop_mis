Public Class frmSettings_EditItem
    Private Sub frmSettings_EditItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSave.Enabled = False
    End Sub

    Private Sub NumTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItemID.KeyPress, txtQuantity.KeyPress
        ' allow only nums and backspace
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtItemName_TextChanged(sender As Object, e As EventArgs) Handles txtItemName.TextChanged _
        , txtItemID.TextChanged, txtQuantity.TextChanged, cmbxShops.SelectedIndexChanged
        btnSave.Enabled = (Not String.IsNullOrEmpty(txtItemName.Text) AndAlso Not String.IsNullOrEmpty(txtQuantity.Text) _
            AndAlso cmbxShops.SelectedIndex >= 0 AndAlso Not String.IsNullOrEmpty(txtItemID.Text))
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class