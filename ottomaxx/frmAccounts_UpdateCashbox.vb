Public Class frmAccounts_UpdateCashbox
    Private Sub frmAccounts_UpdateCashbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSave.Enabled = False
    End Sub

    Private Sub txtOpenBal_TextChanged(sender As Object, e As EventArgs) Handles txtOpenBal.TextChanged,
            txtBank.TextChanged, txtCloseBal.TextChanged
        btnSave.Enabled = (Not String.IsNullOrEmpty(txtOpenBal.Text) AndAlso
            Not String.IsNullOrEmpty(txtBank.Text) AndAlso Not String.IsNullOrEmpty(txtCloseBal.Text))
    End Sub

    Private Sub txtOpenBal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles _
        txtOpenBal.KeyPress,
        txtBank.KeyPress,
        txtCloseBal.KeyPress
        ' only allow numbers and backspace characters
        If ((e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class