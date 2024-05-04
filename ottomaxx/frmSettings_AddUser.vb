Imports System.Net.Mime.MediaTypeNames

Public Class frmSettings_AddUser
    Private Sub frmSettings_AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSave.Enabled = False
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        If (Not String.IsNullOrEmpty(txtPassword.Text) AndAlso Not String.IsNullOrEmpty(txtUsername.Text)) Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If (Not String.IsNullOrEmpty(txtPassword.Text) AndAlso Not String.IsNullOrEmpty(txtUsername.Text)) Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim password, username As String
        Dim errString As String = ""
        Dim userCtrl As New User
        Dim user As New DataTable

        username = txtUsername.Text
        password = txtPassword.Text

        ' check if the user already exists
        errString = ""
        user = userCtrl.GetUser(username, errString)
        If IsNothing(user) Then
            If Not errString.Equals("Not Found") Then
                MsgBox(errString, MsgBoxStyle.Critical, "Ottomaxx") : Exit Sub 'error occurred
            End If
        Else
            MsgBox("User already in the database", MsgBoxStyle.Exclamation, "Ottomax") : Exit Sub
        End If

        ' Add user to the database
        errString = ""
        If userCtrl.AddUser(username, password, errString) Then
            MsgBox("User added to the system successfully", MsgBoxStyle.Information, "Ottomaxx")
        Else
            MsgBox(errString, MsgBoxStyle.Exclamation, "Ottomaxx")
        End If
    End Sub
End Class