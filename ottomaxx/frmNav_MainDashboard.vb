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

    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click
        frmSettings_AddUser.ShowDialog()
    End Sub

    Private Sub EditUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditUserToolStripMenuItem.Click
        frmSettings_EditUser.ShowDialog()
    End Sub

    Private Sub DeleteUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteUserToolStripMenuItem.Click
        frmSettings_DeleteUser.ShowDialog()
    End Sub

    Private Sub ViewAllUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAllUsersToolStripMenuItem.Click
        frmSettings_ViewUsers.ShowDialog()
    End Sub

    Private Sub AddItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddItemToolStripMenuItem.Click
        frmSettings_AddItem.ShowDialog()
    End Sub

    Private Sub EditItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditItemToolStripMenuItem.Click
        frmSettings_EditItem.ShowDialog()
    End Sub

    Private Sub DeleteItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteItemToolStripMenuItem.Click
        frmSettings_DeleteItem.ShowDialog()
    End Sub

    Private Sub ViewAllItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAllItemsToolStripMenuItem.Click
        frmSettings_ViewItems.ShowDialog()
    End Sub

    Private Sub ViewCashboxHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCashboxHistoryToolStripMenuItem.Click
        frmAccounts_CashboxHistory.ShowDialog()
    End Sub

    Private Sub UpdateCashboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateCashboxToolStripMenuItem.Click
        frmAccounts_UpdateCashbox.ShowDialog()
    End Sub

    Private Sub ViewPaymentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPaymentsToolStripMenuItem.Click
        frmAccounts_ViewPayments.ShowDialog()
    End Sub
End Class
