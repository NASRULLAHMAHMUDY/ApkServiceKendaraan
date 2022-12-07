Imports System.Data.Odbc
Imports Microsoft.VisualBasic.ApplicationServices

Public Class FormMenuUtama

    Private Sub MenuUtama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(27) Then
            If MessageBox.Show("Tutup aplikasi...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                End
            End If
        End If
    End Sub

    Private Sub MenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        Call Koneksi()
        PictureBox1.Load("wall2.jpg")
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FormUser.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FormBarang.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        FormJasa.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        FormTransaksi.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        FormLaporanMaster.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        FormLaporanService.Show()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        FormHistoriService.Show()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Me.Close()
        FormLogin.Show()
        FormLogin.txtNama.Clear()
        FormLogin.TxtPassword.Clear()
        FormLogin.txtNama.Focus()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If MessageBox.Show("Tutup aplikasi...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Call Koneksi()
        CMD = New OdbcCommand("delete  from service", CONN)
        CMD.ExecuteNonQuery()

        CMD = New OdbcCommand("delete  from DETAIL", CONN)
        CMD.ExecuteNonQuery()

        MsgBox("data transaksi berhasil dihapus")

    End Sub
End Class