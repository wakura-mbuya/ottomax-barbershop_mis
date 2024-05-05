Public Class frmLoans_ApplyLoan
    Private Sub frmLoans_ApplyLoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnApply.Enabled = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged,
            txtName.TextChanged, txtPosition.TextChanged, txtPrincipal.TextChanged, dtpAppDate.ValueChanged
        btnApply.Enabled = (Not String.IsNullOrEmpty(txtID.Text) AndAlso Not String.IsNullOrEmpty(txtName.Text) _
            AndAlso Not String.IsNullOrEmpty(txtPosition.Text) AndAlso Not String.IsNullOrEmpty(txtPrincipal.Text))
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress,
            txtInstallment.KeyPress, txtPrincipal.KeyPress
        If ((e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back)) Then
            e.Handled = True
        End If
    End Sub
End Class