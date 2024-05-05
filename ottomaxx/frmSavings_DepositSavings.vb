Public Class frmSavings_DepositSavings
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmSavings_DepositSavings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSave.Enabled = False
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged, txtName.TextChanged,
            txtRole.TextChanged, txtAmount.TextChanged, dtpDate.ValueChanged
        btnSave.Enabled = (Not String.IsNullOrEmpty(txtID.Text) AndAlso Not String.IsNullOrEmpty(txtName.Text) _
            AndAlso Not String.IsNullOrEmpty(txtRole.Text) AndAlso Not String.IsNullOrEmpty(txtAmount.Text))
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub
End Class