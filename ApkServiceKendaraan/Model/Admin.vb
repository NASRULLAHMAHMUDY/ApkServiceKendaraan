Imports System.Data.Odbc
Public Class Admin
    Public Kode_Admin As String
    Public Nama_Admin As String
    Public Pwd_Admin As String
    Public Status_Admin As String

    Sub simpan()
        Call Koneksi()
        Dim Simpan As String = "insert into admin values('" & Kode_Admin & "','" & Nama_Admin & "','" & Pwd_Admin & "','" & Status_Admin & "')"
    End Sub

    Sub Hapus()
        Call Koneksi()
        Dim Hapus As String = "delete from admin where Kode_Admin = '" & Kode_Admin & "')"
        CMD = New OdbcCommand(Hapus, CONN)
        CMD.ExecuteNonQuery()
    End Sub
End Class
