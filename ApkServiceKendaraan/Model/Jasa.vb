Imports System.Data.Odbc
Public Class Jasa
    Public Kode_Jasa As String
    Public Nama_Jasa As String
    Public Harga_Jasa As String

    Sub simpan()
        Call Koneksi()
        Dim Simpan As String = "insert into jasa values('" & Kode_Jasa & "','" & Nama_Jasa & "','" & Harga_Jasa & "')"
    End Sub

    Sub Hapus()
        Call Koneksi()
        Dim Hapus As String = "delete from jasa where Kode_Jasa = '" & Kode_Jasa & "')"
        CMD = New OdbcCommand(Hapus, CONN)
        CMD.ExecuteNonQuery()
    End Sub
End Class
