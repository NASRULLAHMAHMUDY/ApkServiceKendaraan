Imports System.Data.Odbc
Public Class Barang
    Public Kode_Barang As String
    Public Nama_Barang As String
    Public Harga_Barang As String
    Public Stok As String

    Sub simpan()
        Call Koneksi()
        Dim Simpan As String = "insert into barang values('" & Kode_Barang & "','" & Nama_Barang & "','" & Harga_Barang & "','" & Stok & "')"
    End Sub

    Sub Hapus()
        Call Koneksi()
        Dim Hapus As String = "delete from barang where Kode_Barang = '" & Kode_Barang & "')"
        CMD = New OdbcCommand(Hapus, CONN)
        CMD.ExecuteNonQuery()
    End Sub
End Class
