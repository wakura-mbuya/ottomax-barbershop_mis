Public Class frmSettings_ViewServices
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim serviceCtrl As New Service
        Dim errString As String = ""
        Dim serviceDtbl As DataTable

        serviceDtbl = serviceCtrl.GetServices(errString)
        If String.IsNullOrEmpty(errString) Then
            dgvServices.DataSource = serviceDtbl
        Else
            MsgBox(errString, MsgBoxStyle.Exclamation, "Ottomaxx")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class