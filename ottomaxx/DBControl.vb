Imports Microsoft.VisualBasic
Imports System.Data.OleDb

Public Class DBControl
    'create database connection
    Private conn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; " &
                                          "Data Source=ottomaxx_db.accdb")

    'Prepare DB command
    Private DBcmd As OleDbCommand

    'DB Data, executes our commands and storage of the data
    Public dbAdapter As OleDbDataAdapter            'for execution of commands
    Public dbTbl As DataTable                       'for storage

    'Query parameters
    Public params As New List(Of OleDbParameter)

    'storage of query statistics
    Public recordCount As Integer
    Public exception As String

    Public Sub executeQuery(qryString)
        'executes the queries we pass on the database


        'reset query stats
        recordCount = 0
        exception = ""

        Try
            'open connection
            conn.Open()

            'create the db command
            DBcmd = New OleDbCommand(qryString, conn)

            'load parameters into db command(using for...each loop and lambda expressions)
            params.ForEach(Sub(p) DBcmd.Parameters.Add(p))


            'For p As OleDbParameter in params
            'DBcmd.Parameters.Add(p)
            'Next

            'clear parameter list
            params.Clear()

            'execute command and fill the dataset/datatable
            dbTbl = New DataTable
            dbAdapter = New OleDbDataAdapter(DBcmd)
            recordCount = dbAdapter.Fill(dbTbl)
        Catch ex As Exception
            exception = ex.Message
        End Try

        'close the database connection
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Public Sub addParameters(name As String, value As Object)
        'add parameters to the list

        Dim newParam As New OleDbParameter(name, value)
        params.Add(newParam)
    End Sub
End Class
