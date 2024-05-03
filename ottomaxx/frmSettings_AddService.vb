Public Class frmSettings_AddService
    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        If (Not String.IsNullOrEmpty(txtDescription.Text) AndAlso Not String.IsNullOrEmpty(txtServiceName.Text) AndAlso Not String.IsNullOrEmpty(txtPrice.Text)) Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        ' allow only nums, . and backspace
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmSettings_AddService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSave.Enabled = False
    End Sub

    Private Sub txtServiceName_TextChanged(sender As Object, e As EventArgs) Handles txtServiceName.TextChanged
        If (Not String.IsNullOrEmpty(txtPrice.Text) AndAlso Not String.IsNullOrEmpty(txtDescription.Text) AndAlso Not String.IsNullOrEmpty(txtServiceName.Text)) Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtDescription_TextChanged(sender As Object, e As EventArgs) Handles txtDescription.TextChanged
        If (Not String.IsNullOrEmpty(txtServiceName.Text) AndAlso Not String.IsNullOrEmpty(txtPrice.Text) AndAlso Not String.IsNullOrEmpty(txtDescription.Text)) Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim serviceCtrl As New Service
        Dim price As Double
        Dim serviceName As String
        Dim description As String
        Dim errString As String = ""


        ' Get the data from the form controls
        price = Double.Parse(txtPrice.Text)
        serviceName = txtServiceName.Text
        description = txtDescription.Text

        ' Check if the service is already added
        Dim serviceID As Integer = serviceCtrl.GetServiceID(serviceName, errString)
        If serviceID > 0 Then
            MsgBox(serviceName + " already added to the database", MsgBoxStyle.Exclamation, "Ottomaxx") : Exit Sub
        End If

        If serviceCtrl.AddService(serviceName, price, description, errString) Then
            MsgBox("Added the service successfully", MsgBoxStyle.Information, "Ottomaxx")
        Else
            MsgBox(errString, MsgBoxStyle.Critical, "Ottomaxx")
        End If
    End Sub
End Class