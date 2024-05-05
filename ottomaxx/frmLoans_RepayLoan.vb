Public Class frmLoans_RepayLoan
    Private Sub frmLoans_RepayLoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSave.Enabled = False
    End Sub

    Private Sub txtStaffID_TextChanged(sender As Object, e As EventArgs) Handles txtStaffID.TextChanged, txtRepayAmount.TextChanged, txtStaffName.TextChanged
        btnSave.Enabled = (Not String.IsNullOrEmpty(txtStaffID.Text) AndAlso Not String.IsNullOrEmpty(txtStaffRole.Text) AndAlso Not String.IsNullOrEmpty(txtStaffName.Text) AndAlso Not String.IsNullOrEmpty(txtRepayAmount.Text))

    End Sub

    Private Sub txtStaffID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStaffID.KeyPress, txtRepayAmount.KeyPress
        If ((e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class