Public Class frmSettings_AddShop

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtShopName.Text) Then
            MsgBox("Enter the name of the shop and try again", MsgBoxStyle.Exclamation, "Ottomaxx") : Exit Sub
        End If

        Dim shopCtrl As New ShopController
        Dim errStr As String = ""
        Dim shopID As Integer = shopCtrl.ReadShopID(txtShopName.Text, errStr)
        If (shopID = -1) Then
            MsgBox(errStr, MsgBoxStyle.Critical, "Ottomaxx") : Exit Sub
        ElseIf (shopID > 0) Then
            MsgBox("Shop already added in the system. Try another name", MsgBoxStyle.Exclamation, "Ottomaxx")
            Exit Sub
        Else
            If (shopCtrl.CreateShop(txtShopName.Text, errStr)) Then
                MsgBox("Shop details added to the database successfuly", MsgBoxStyle.Information, "Ottomaxx")
            Else
                MsgBox(errStr, MsgBoxStyle.Critical, "Ottomaxx")
            End If
        End If
    End Sub

    Private Sub frmSettings_AddShop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSave.Enabled = False
    End Sub

    Private Sub txtShopName_TextChanged(sender As Object, e As EventArgs) Handles txtShopName.TextChanged
        If Not String.IsNullOrEmpty(txtShopName.Text) Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If
    End Sub
End Class