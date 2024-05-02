Public Class frmSettings_ViewShops
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim shopCtrl As New ShopController
        Dim shopDtbl As New DataTable
        Dim errString As String = ""

        shopDtbl = shopCtrl.ViewShops(errString)
        If Not String.IsNullOrEmpty(errString) Then
            MsgBox(errString, MsgBoxStyle.Critical, "Ottomaxx")
        Else
            dgvShops.DataSource = shopDtbl
        End If
    End Sub
End Class