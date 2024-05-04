Public Class Role
    Dim DBAccess As New DBControl

    Public Function StringEmpty(strError As String) As Boolean
        ' Checks if a string str is null or empty
        ' @str: the string to be checked
        ' @Return: True if the string is null or empty
        '               Otherwise it returns false
        Return String.IsNullOrEmpty(strError)
    End Function

    Public Function AddRole(role As String, ByRef errString As String) As Boolean
        ' Adds a new record into the tblRoles
        ' @role: The name of the new service
        ' @errString: for storing exception messages.
        ' 
        '@Return: True if the record is added successfully to the database
        '              Otherwise it Returns false

        With DBAccess
            .addParameters("@role", role)
            .executeQuery("INSERT INTO tblRoles (role) VALUES(@role);")
        End With

        errString = DBAccess.exception
        If StringEmpty(DBAccess.exception) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function GetRoleID(role As String, ByRef errString As String) As Integer
        ' Checks for the Role ID of a given role in the tblServices
        ' @role: the name of the role
        ' @errString: for tracking exception messages
        '
        ' Return:   the Role ID on success
        '               0 if the role is not found
        '               -1 if an error occurs

        With DBAccess
            .addParameters("@role", role)
            .executeQuery("SELECT roleID FROM tblRoles WHERE role=@role;")
        End With

        errString = DBAccess.exception
        If StringEmpty(errString) Then
            If DBAccess.recordCount > 0 Then
                Return DBAccess.dbTbl.Rows(0)("roleID")
            Else
                errString = "Not Found"
                Return 0
            End If
        Else
            Return -1
        End If
    End Function

    Public Function GetRoleName(roleID As Integer, ByRef errString As String) As String
        ' Checks for the Role Name of a given service in the tblRoles
        ' @roleID: the unique ID of the role
        ' @errString: for tracking exception messages
        '
        ' Return:   the Role Name on success
        '               Nothing if an error occurs

        With DBAccess
            .addParameters("@roleID", roleID)
            .executeQuery("SELECT role FROM tblRoles WHERE roleID=@roleID;")
        End With

        errString = DBAccess.exception
        If StringEmpty(errString) Then
            If DBAccess.recordCount > 0 Then
                Return DBAccess.dbTbl.Rows(0)("role")
            Else
                errString = "Not Found"
                Return Nothing
            End If
        Else
            Return Nothing
        End If
    End Function

    Public Function DeleteRole(roleID As Integer, ByRef errString As String) As Boolean
        ' Deletes a record from the tblRoles
        ' @roleID:  Unique ID for the role to be deleted
        ' @errString:   For tracking exception messages
        '
        'Return: True on success
        '           False on failure

        With DBAccess
            .addParameters("@roleID", roleID)
            .executeQuery("DELETE FROM tblRoles WHERE roleID=@roleID")
        End With

        errString = DBAccess.exception
        If StringEmpty(errString) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function EditRole(roleID As Integer, role As String, ByRef errString As String) As Boolean
        ' Updates a record in tblRoles
        ' @roleID: Unique ID for the record to be updated
        ' @role: the updated name of the role
        '
        ' Return:   True on sucess
        '               False on fail
        With DBAccess
            .addParameters("@role", role)
            .addParameters("@roleID", roleID)

            .executeQuery("UPDATE tblRoles SET role=@role WHERE roleID=@roleID")
        End With

        errString = DBAccess.exception
        Return StringEmpty(errString)
    End Function

    Public Function GetRole(role As String, ByRef errString As String) As DataTable
        ' Gets the Role Details from the database
        ' @role: the name of the role
        '
        ' Return:   Details of the role as a datatable on success
        '               Nothing on error

        With DBAccess
            .addParameters("@role", role)
            .executeQuery("SELECT roleID As [Role ID], role As [Role] FROM tblRoles WHERE role=@role;")
        End With

        errString = DBAccess.exception
        If StringEmpty(errString) Then
            If DBAccess.recordCount > 0 Then
                Return DBAccess.dbTbl
            Else
                errString = "Not Found"
                Return Nothing
            End If
        Else
            Return Nothing
        End If
    End Function

    Public Function GetRoles(ByRef errString As String) As DataTable
        ' Gets all roles from the database
        ' 
        ' Return:   Details of the all services as a datatable on success
        '               Nothing on error

        With DBAccess
            .executeQuery("SELECT roleID As [Role ID], role As [Role] FROM tblRoles;")
        End With

        errString = DBAccess.exception
        If StringEmpty(errString) Then
            If DBAccess.recordCount > 0 Then
                Return DBAccess.dbTbl
            Else
                errString = "Not Found"
                Return Nothing
            End If
        Else
            Return Nothing
        End If
    End Function
End Class