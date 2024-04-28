Public Class Form1
    Private DBAccess As New DBControl

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        DBAccess.executeQuery("SELECT * FROM tblStaff")
        If Not String.IsNullOrEmpty(DBAccess.exception) Then MsgBox(DBAccess.exception) : Exit Sub

        dgvStaff.DataSource = DBAccess.dbTbl
    End Sub

End Class
