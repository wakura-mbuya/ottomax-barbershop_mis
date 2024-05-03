Public Class User
    Dim DBAccess As New DBControl

    Public Function StringEmpty(strError As String) As Boolean
        ' Checks if a string str is null or empty
        ' @str: the string to be checked
        ' @Return: True if the string is null or empty
        '               Otherwise it returns false
        Return String.IsNullOrEmpty(strError)
    End Function

    Public Function AddUser(username As String, password As String, ByRef errString As String) As Boolean
        ' Adds a new record into the tblSystemUsers
        ' @username: The name of the new user
        ' @password:    The password of the user
        ' @errString: for storing exception messages.
        ' 
        '@Return: True if the record is added successfully to the database
        '              Otherwise it Returns false

        With DBAccess
            .addParameters("@username", username)
            .addParameters("@password", password)
            .executeQuery("INSERT INTO tblSystemUsers(username, password) VALUES(@username, @password);")
        End With

        errString = DBAccess.exception
        If StringEmpty(DBAccess.exception) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function GetUserID(username As String, ByRef errString As String) As Integer
        ' Checks for the user ID of a given user in the tblServices
        ' @username: the name of the username
        ' @errString: for tracking exception messages
        '
        ' Return:   the user ID on success
        '               0 if the user is not found
        '               -1 if an error occurs

        With DBAccess
            .addParameters("@username", username)
            .executeQuery("SELECT userID FROM tblSystemUsers WHERE username=@username;")
        End With

        errString = DBAccess.exception
        If StringEmpty(errString) Then
            If DBAccess.recordCount > 0 Then
                Return DBAccess.dbTbl.Rows(0)("userID")
            Else
                errString = "Not Found"
                Return 0
            End If
        Else
            Return -1
        End If
    End Function

    Public Function GetUsername(userID As Integer, ByRef errString As String) As String
        ' Checks for the username of a given user in the database
        ' @userID: the unique ID of the user
        ' @errString: for tracking exception messages
        '
        ' Return:   the username on success
        '               Nothing if an error occurs

        With DBAccess
            .addParameters("@userID", userID)
            .executeQuery("SELECT username FROM tblSystemUsers WHERE userID=@userID;")
        End With

        errString = DBAccess.exception
        If StringEmpty(errString) Then
            If DBAccess.recordCount > 0 Then
                Return DBAccess.dbTbl.Rows(0)("username")
            Else
                errString = "Not Found"
                Return Nothing
            End If
        Else
            Return Nothing
        End If
    End Function

    Public Function DeleteUser(userID As Integer, ByRef errString As String) As Boolean
        ' Deletes a record from the tblSystemUsers
        ' @userID:  Unique ID for the user to be deleted
        ' @errString:   For tracking exception messages
        '
        'Return: True on success
        '           False on failure

        With DBAccess
            .addParameters("@userID", userID)
            .executeQuery("DELETE FROM tblSystemUsers WHERE userID=@userID")
        End With

        errString = DBAccess.exception
        If StringEmpty(errString) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function EditUser(userID As Integer, username As String, password As String, ByRef errString As String) As Boolean
        ' Updates a record in tblSystemUsers
        ' @userID: Unique ID for the record to be updated
        ' @username: the updated username
        ' @password: the updated user password
        ' @errString: for tracking exception messages
        '
        ' Return:   True on sucess
        '               False on fail

        With DBAccess
            .addParameters("@username", username)
            .addParameters("@password", password)
            .addParameters("@userID", userID)

            .executeQuery("UPDATE tblSystemUsers SET username=@username, password=@password WHERE userID=@userID")
        End With

        errString = DBAccess.exception
        Return StringEmpty(errString)
    End Function

    Public Function GetUser(username As String, ByRef errString As String) As DataTable
        ' Gets the User Details from the database
        ' @role: the name of the role
        '
        ' Return:   Details of the user as a datatable on success
        '               Nothing on error

        With DBAccess
            .addParameters("@username", username)
            .executeQuery("SELECT userID As [User ID], username As Username, password As [Password] FROM tblSystemUsers WHERE username=@username;")
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

    Public Function Users(ByRef errString As String) As DataTable
        ' Gets all users from the database
        ' 
        ' Return:   Details of the all users as a datatable on success
        '               Nothing on error

        With DBAccess
            .executeQuery("SELECT username As [Username], password As [Password] FROM tblSystemUsers;")
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
