Public Class frmSettings_EditService
    Dim serviceID As Integer
    Dim errString As String
    Dim serviceName As String
    Dim serviceCtrl As New ServiceController

    Private Sub txtServiceName_TextChanged(sender As Object, e As EventArgs) Handles txtServiceName.TextChanged
        If Not String.IsNullOrEmpty(txtServiceName.Text) Then
            If Not String.IsNullOrEmpty(txtPrice.Text) Then
                If Not String.IsNullOrEmpty(txtDescription.Text) Then
                    btnSave.Enabled = True : Exit Sub
                End If
            End If
        End If
        btnSave.Enabled = False
    End Sub

    Private Sub frmSettings_EditService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSave.Enabled = False
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        If Not String.IsNullOrEmpty(txtServiceName.Text) Then
            If Not String.IsNullOrEmpty(txtPrice.Text) Then
                If Not String.IsNullOrEmpty(txtDescription.Text) Then
                    btnSave.Enabled = True : Exit Sub
                End If
            End If
        End If
        btnSave.Enabled = False
    End Sub

    Private Sub txtDescription_TextChanged(sender As Object, e As EventArgs) Handles txtDescription.TextChanged
        If Not String.IsNullOrEmpty(txtServiceName.Text) Then
            If Not String.IsNullOrEmpty(txtPrice.Text) Then
                If Not String.IsNullOrEmpty(txtDescription.Text) Then
                    btnSave.Enabled = True : Exit Sub
                End If
            End If
        End If
        btnSave.Enabled = False
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

            serviceID = serviceDtbl.Rows(0)("Service ID")
            txtPrice.Text = serviceDtbl.Rows(0)("Price")
            txtDescription.Text = serviceDtbl.Rows(0)("Description")
            btnSave.Enabled = True : Exit Sub
        End If

        MsgBox("Enter the Service Name and try again", MsgBoxStyle.Exclamation, "Ottomaxx")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim serviceCtrl As New ServiceController

        If serviceID < 1 Then
            MsgBox(errString, MsgBoxStyle.Exclamation, "Ottomaxx")

        Else
            If serviceCtrl.EditService(serviceID, txtServiceName.Text, Double.Parse(txtPrice.Text), txtDescription.Text, errString) Then
                MsgBox("Updated the record successfully", MsgBoxStyle.Information, "Ottomaxx")
                txtDescription.Text = String.Empty
            Else
                MsgBox(errString, MsgBoxStyle.Exclamation, "Ottomaxx")
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class