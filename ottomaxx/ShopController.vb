Public Class ShopController
    Dim DBAccess As New DBControl

    Private Function StringEmpty(str As String) As Boolean
        Return String.IsNullOrEmpty(str)
    End Function

    Public Function CreateShop(shopName As String, ByRef errString As String) As Boolean
        ' Creates a new shop record in the table tblShop in the database
        ' @shopName: Name of the shop
        ' @errString: Stores the exception message if an error occurs
        ' @Return: True if the record is added successfuly into the database, 
        '           Returns false if an error occurs

        DBAccess.addParameters("@shopName", shopName)
        DBAccess.executeQuery("INSERT INTO tblShops(shopName) VALUES(@shopName);")

        If Not StringEmpty(DBAccess.exception) Then
            errString = DBAccess.exception
            Return False

        Else
            errString = String.Empty
            Return True
        End If
    End Function

    Public Function ReadShopID(shopName As String, ByRef errString As String) As Integer
        ' Returns the shop ID of a given shop from the database
        ' @shopName: the name of the shop
        ' @errString: for recording error messages
        ' @Returns: On success, Returns the shop ID if the shop is found otherwise it returns 0 if the shop is not found
        '           On error, it returns -1

        DBAccess.addParameters("@shopName", shopName)
        DBAccess.executeQuery("SELECT shopID FROM tblShops WHERE shopName = @shopName;")

        If Not StringEmpty(DBAccess.exception) Then
            errString = DBAccess.exception
            Return -1
        Else
            errString = String.Empty
            If DBAccess.recordCount > 0 Then
                Return DBAccess.dbTbl.Rows(0)("shopID")
            Else
                errString = String.Empty
                Return (0)
            End If
        End If
    End Function

    Public Function ReadShopName(shopID As Integer, ByRef errString As String) As String
        ' Returns the shop Name of a given shop from the database
        ' @shopID: the ID of the shop
        ' @errString: for recording error messages
        ' @Returns: On success, Returns the shop name if the shop is found otherwise it returns "Not Found" if the shop is not found
        '           On error, it returns "Error"

        DBAccess.addParameters("@shopID", shopID)
        DBAccess.executeQuery("SELECT shopName FROM tblShops WHERE shopID = @shopID;")

        If Not StringEmpty(DBAccess.exception) Then
            errString = DBAccess.exception
            Return "Error"
        Else
            errString = String.Empty
            If DBAccess.recordCount > 0 Then
                Return DBAccess.dbTbl.Rows(0)("shopName")
            Else
                errString = String.Empty
                Return "Not found"
            End If
        End If
    End Function

    Public Function DeleteShop(shopID As Integer, ByRef errString As String) As Boolean
        DBAccess.addParameters("@shopID", shopID)
        DBAccess.executeQuery("DELETE FROM tblShops WHERE shopID = @shopID")

        If Not StringEmpty(DBAccess.exception) Then
            errString = DBAccess.exception
            Return False

        Else
            errString = String.Empty
            Return True
        End If
    End Function

    Public Sub EditShop(shopID As Integer, shopName As String, ByRef errString As String)
        DBAccess.addParameters("@shopName", shopName)
        DBAccess.addParameters("@shopID", shopID)
        DBAccess.executeQuery("UPDATE tblShops SET tblShops.shopName = @shopName
WHERE (((tblShops.shopID)=@shopID));")
        MsgBox(DBAccess.exception)
        If Not StringEmpty(DBAccess.exception) Then
            errString = DBAccess.exception
        Else
            errString = String.Empty
        End If
    End Sub
End Class
