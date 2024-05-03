Public Class Service
    Dim DBAccess As New DBControl

    Public Function StringEmpty(strError As String) As Boolean
        ' Checks if a string str is null or empty
        ' @str: the string to be checked
        ' @Return: True if the string is null or empty
        '               Otherwise it returns false
        Return String.IsNullOrEmpty(strError)
    End Function

    Public Function AddService(serviceName As String, price As Double, description As String, ByRef errString As String) As Boolean
        ' Adds a new record into the tblServices
        ' @serviceName: The name of the new service
        ' @price: the price of the new item
        ' @description: The detailed description of what the function does.
        ' 
        '@Return: True if the record is added successfully to the database
        '              Otherwise it Returns false

        With DBAccess
            .addParameters("@serviceName", serviceName)
            .addParameters("@price", price)
            .addParameters("@description", description)

            .executeQuery("INSERT INTO tblServices(serviceName, price, description) VALUES(@serviceName, @price, @description);")
        End With

        errString = DBAccess.exception
        If StringEmpty(DBAccess.exception) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function GetServiceID(serviceName As String, ByRef errString As String) As Integer
        ' Checks for the Service ID of a given service in the tblServices
        ' @serviceName: the name of the service
        ' @errString: for tracking exception messages
        '
        ' Return:   the service ID on success
        '               0 if the service is not found
        '               -1 if an error occurs

        With DBAccess
            .addParameters("@serviceName", serviceName)
            .executeQuery("SELECT serviceID FROM tblServices WHERE serviceName=@serviceName;")
        End With

        errString = DBAccess.exception
        If StringEmpty(errString) Then
            If DBAccess.recordCount > 0 Then
                Return DBAccess.dbTbl.Rows(0)("serviceID")
            Else
                errString = "Not Found"
                Return 0
            End If
        Else
            Return -1
        End If
    End Function

    Public Function GetServiceName(serviceID As Integer, ByRef errString As String) As String
        ' Checks for the Service Name of a given service in the tblServices
        ' @serviceID: the unique ID of the service
        ' @errString: for tracking exception messages
        '
        ' Return:   the service Name on success
        '               Nothing if an error occurs

        With DBAccess
            .addParameters("@serviceID", serviceID)
            .executeQuery("SELECT serviceName FROM tblServices WHERE serviceID=@serviceID;")
        End With

        errString = DBAccess.exception
        If StringEmpty(errString) Then
            If DBAccess.recordCount > 0 Then
                Return DBAccess.dbTbl.Rows(0)("serviceName")
            Else
                errString = "Not Found"
                Return Nothing
            End If
        Else
            Return Nothing
        End If
    End Function

    Public Function DeleteService(serviceID As Integer, ByRef errString As String) As Boolean
        ' Deletes a record from tblServices
        ' @serviceID: Unique ID of the service to be deleted
        ' @errString: for storing exception messages
        '
        ' Return: True on succee
        '             False on failure

        With DBAccess
            .addParameters("@serviceID", serviceID)
            .executeQuery("DELETE FROM tblServices WHERE serviceID=@serviceID")
        End With

        errString = DBAccess.exception
        If StringEmpty(errString) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function EditService(serviceID As Integer, serviceName As String, price As Double, description As String, ByRef errString As String) As Boolean
        ' Updates the details of a record in tblServices
        ' @serviceID: unique ID of the record to be updated
        ' @serviceName: updated service name
        ' @price: Updated price of the service
        ' @description: updated description of the service
        ' @errString: for tracking error messages
        '
        '  Return:  True on success
        '               False on failure

        With DBAccess
            .addParameters("@serviceName", serviceName)
            .addParameters("@price", price)
            .addParameters("@description", description)
            .addParameters("@serviceID", serviceID)

            .executeQuery("UPDATE tblServices SET serviceName=@serviceName, price=@price, description=@description WHERE serviceID=@serviceID")
        End With

        errString = DBAccess.exception
        Return StringEmpty(errString)
    End Function

    Public Function GetService(serviceName As String, ByRef errString As String) As DataTable
        ' Gets the Service Details from the database
        ' @serviceName: the name of the service
        '
        ' Return:   Details of the service as a datatable on success
        '               Nothing on error

        With DBAccess
            .addParameters("@serviceName", serviceName)
            .executeQuery("SELECT serviceID As [Service ID], serviceName As [Service Name], price As Price, description As Description FROM tblServices WHERE serviceName=@serviceName;")
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

    Public Function GetServices(ByRef errString As String) As DataTable
        ' Gets all Services from the database
        ' 
        ' Return:   Details of the all services as a datatable on success
        '               Nothing on error

        With DBAccess
            .executeQuery("SELECT serviceID As [Service ID], serviceName As [Service Name], price As Price, description As Description FROM tblServices;")
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
