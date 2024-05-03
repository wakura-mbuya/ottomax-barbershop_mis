Public Class frmNav_MainDashboard
    Private Sub AddShopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddShopToolStripMenuItem.Click
        frmSettings_AddShop.ShowDialog()
    End Sub

    Private Sub DeleteShopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteShopToolStripMenuItem.Click
        frmSettings_DeleteShop.ShowDialog()
    End Sub

    Private Sub EditShopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditShopToolStripMenuItem.Click
        frmSettings_EditShop.ShowDialog()
    End Sub

    Private Sub ViewAllShopsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAllShopsToolStripMenuItem.Click
        frmSettings_ViewShops.ShowDialog()
    End Sub

    Private Sub AddServiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddServiceToolStripMenuItem.Click
        frmSettings_AddService.ShowDialog()
    End Sub

    Private Sub DeleteServiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteServiceToolStripMenuItem.Click
        frmSettings_DeleteService.ShowDialog()
    End Sub

    Private Sub ViewAllServicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAllServicesToolStripMenuItem.Click
        frmSettings_ViewServices.ShowDialog()
    End Sub

    Private Sub EditServiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditServiceToolStripMenuItem.Click
        frmSettings_EditService.ShowDialog()
    End Sub

    Private Sub AddRoleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddRoleToolStripMenuItem.Click
        frmSettings_AddStaffRole.ShowDialog()
    End Sub

    Private Sub EditRoleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditRoleToolStripMenuItem.Click
        frmSettings_EditStaffRole.ShowDialog()
    End Sub

    Private Sub DeleteRoleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteRoleToolStripMenuItem.Click
        frmSettings_DeleteStaffRole.ShowDialog()
    End Sub

    Private Sub ViewAllRolesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAllRolesToolStripMenuItem.Click
        frmSettings_ViewStaffRoles.ShowDialog()
    End Sub
End Class
