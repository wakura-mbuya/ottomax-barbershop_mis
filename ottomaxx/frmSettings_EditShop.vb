﻿Public Class frmSettings_EditShop
    Dim shopCtrl As New Shop
    Dim errString As String = ""
    Dim shopID As Integer
    Dim shopName As String

    Private Sub frmSettings_EditShop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSave.Enabled = False
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' check if shop ID is entered
        If (Not String.IsNullOrEmpty(txtShopID.Text)) Then
            ' Search for shop using its ID
            shopID = Integer.Parse(txtShopID.Text) ' I am assuming this won't fail because I only allow numbers to be typed in this textbox
            shopName = shopCtrl.ReadShopName(shopID, errString)

            If String.Equals(shopName, "Not found") Then
                MsgBox(shopName, MsgBoxStyle.Exclamation, "Ottomaxx")
                btnSave.Enabled = False : Exit Sub
            ElseIf String.Equals(shopName, "Error") Then
                MsgBox(errString, MsgBoxStyle.Critical, "Ottomaxx")
                btnSave.Enabled = False : Exit Sub
            Else
                txtShopName.Text = shopName
                btnSave.Enabled = True : Exit Sub
            End If
        End If

        ' if Shop Name is entered
        If (Not String.IsNullOrEmpty(txtShopName.Text)) Then
            ' Search for the shop using the name
            shopName = txtShopName.Text
            shopID = shopCtrl.ReadShopID(shopName, errString)

            If shopID = -1 Then
                MsgBox(errString, MsgBoxStyle.Critical, "Ottomaxx")
                btnSave.Enabled = False : Exit Sub

            ElseIf shopID = 0 Then
                MsgBox("Not found", MsgBoxStyle.Exclamation, "Ottomaxx")
                btnSave.Enabled = False : Exit Sub
            Else
                txtShopID.Text = shopID.ToString()
                btnSave.Enabled = True : Exit Sub
            End If
        End If

        ' Both name and ID not entered
        MsgBox("Enter Either Shop ID or Shop Name and try again", MsgBoxStyle.Exclamation, "Ottomaxx")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        MsgBox(shopID.ToString)
        shopCtrl.EditShop(shopID, shopName, errString)
        If String.IsNullOrEmpty(errString) Then
            MsgBox("Shop details updated succefully", MsgBoxStyle.Information, "Ottomaxx")
        Else
            MsgBox(errString, MsgBoxStyle.Critical, "Ottomaxx")
        End If
    End Sub

    Private Sub txtShopID_TextChanged(sender As Object, e As EventArgs) Handles txtShopID.TextChanged

    End Sub

    Private Sub txtShopID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtShopID.KeyPress
        ' allow only nums and backspace
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub
End Class