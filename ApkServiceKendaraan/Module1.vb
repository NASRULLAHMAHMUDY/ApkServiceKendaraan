Imports System.Data.Odbc

Module Module1

    Public CONN As OdbcConnection
    Public DA As OdbcDataAdapter
    Public DS As DataSet
    Public CMD As OdbcCommand
    Public DR As OdbcDataReader
    Public MyDB As String



    Public Sub Koneksi()
        MyDB = "Driver={Mysql ODBC 3.51 Driver};Database=dbservice;server=localhost;uid=root"
        CONN = New OdbcConnection(MyDB)
        If CONN.State = ConnectionState.Closed Then CONN.Open()

    End Sub
End Module

