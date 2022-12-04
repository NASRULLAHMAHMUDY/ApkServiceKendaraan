Imports System.Data.Odbc
Module Module1
    Public conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public rd As OdbcDataReader
    Public cmd As OdbcCommand
    Public Sub koneksi()
        Try
            conn = New OdbcConnection("Dsn=konek_dbservice")
            If conn.State = ConnectionState.Closed Then
                conn.Open()

            End If
        Catch ex As Exception

        End Try
    End Sub
End Module
