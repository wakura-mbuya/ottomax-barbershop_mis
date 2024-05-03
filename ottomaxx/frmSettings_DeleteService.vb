Public Class frmSettings_DeleteService
    Dim serviceID As Integer
    Dim serviceName, description, errString As String
    Dim serviceCtrl As New Service
    Private Sub frmSettings_DeleteService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDelete.Enabled = False
    End Sub

    Private Sub txtServiceName_TextChanged(sender As Object, e As EventArgs) Handles txtServiceName.TextChanged

    End Sub

    Private Sub txtServiceName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtServiceName.KeyPress

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim serviceDtbl As New DataTable
        serviceName = txtServiceName.Text
        If Not String.IsNullOrEmpty(serviceName) Then
            ' use service name to search for the service details
            errString = ""
            serviceDtbl = serviceCtrl.GetService(serviceName, errString)
            If IsNothing(serviceDtbl) Then
                MsgBox(errString, MsgBoxStyle.Exclamation, "Ottomaxx") : Exit Sub
            End If

            txtPrice.Text = serviceDtbl.Rows(0)("Price")
            txtDescription.Text = serviceDtbl.Rows(0)("Description")
            btnDelete.Enabled = True : Exit Sub
        End If

        MsgBox("Enter the Service Name and try again", MsgBoxStyle.Exclamation, "Ottomaxx")
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        ' allow only nums, . and backspace
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (String.IsNullOrEmpty(txtServiceName.Text) OrElse String.IsNullOrEmpty(txtPrice.Text) OrElse String.IsNullOrEmpty(txtDescription.Text)) Then
            MsgBox("Enter the Service Name and try again", MsgBoxStyle.Exclamation, "Ottomaxx") : Exit Sub
        End If

        errString = ""
        serviceID = serviceCtrl.GetServiceID(txtServiceName.Text, errString)
        If serviceCtrl.DeleteService(serviceID, errString) Then
            MsgBox("Successfully delete the service", MsgBoxStyle.Information, "Ottomaxx")
            txtServiceName.Text = String.Empty
            txtPrice.Text = String.Empty
            txtDescription.Text = String.Empty
        Else
            MsgBox(errString, MsgBoxStyle.Exclamation, "Ottomaxx")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class