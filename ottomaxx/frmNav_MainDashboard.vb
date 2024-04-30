Public Class frmNav_MainDashboard
    Private Sub AddShopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddShopToolStripMenuItem.Click
        frmSettings_AddShop.ShowDialog()
    End Sub

    Private Sub DeleteShopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteShopToolStripMenuItem.Click
        frmSettings_DeleteShop.ShowDialog()
    End Sub
End Class
