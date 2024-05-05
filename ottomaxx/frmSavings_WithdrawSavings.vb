Public Class frmSavings_WithdrawSavings
    Private Sub frmSavings_WithdrawSavings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnWithdraw.Enabled = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged, txtName.TextChanged,
            txtRole.TextChanged, txtSavings.TextChanged, txtWithdrawAmount.TextChanged, dtpDate.ValueChanged
        btnWithdraw.Enabled = (Not String.IsNullOrEmpty(txtID.Text) AndAlso Not String.IsNullOrEmpty(txtName.Text) _
            AndAlso Not String.IsNullOrEmpty(txtRole.Text) AndAlso Not String.IsNullOrEmpty(txtSavings.Text) _
            AndAlso Not String.IsNullOrEmpty(txtWithdrawAmount.Text))
    End Sub

    Private Sub txtWithdrawAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWithdrawAmount.KeyPress,
            txtID.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub
End Class