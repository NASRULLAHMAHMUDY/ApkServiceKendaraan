Imports System.Data.Odbc
Imports Microsoft.VisualBasic.ApplicationServices

Public Class FormMenuUtama

    Sub Kunci()
        Btn_User.Enabled = False
        Btn_Barang.Enabled = False
        Btn_Jasa.Enabled = False
        Btn_service.Enabled = False
        Btn_Master.Enabled = False
        Btn_Service_Lp.Enabled = False
        Btn_Histori.Enabled = False
        Btn_LogOff.Enabled = False
    End Sub

    Private Sub MenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Slabel8.Text = Today
        Call Kunci()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_User.Click
        FormAdmin.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Barang.Click
        FormBarang.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Jasa.Click
        FormJasa.ShowDialog()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_service.Click
        FormTransaksi.ShowDialog()


    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Histori.Click
        FormHistoriService.ShowDialog()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_LogOff.Click
        Me.Close()
        FormLogin.Show()
        FormLogin.TxtNama.Clear()
        FormLogin.TxtPassword.Clear()
        FormLogin.TxtNama.Focus()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Exit.Click
        If MessageBox.Show("Tutup aplikasi...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Call Koneksi()
        'CMD = New OdbcCommand("delete  from service", CONN)
        'CMD.ExecuteNonQuery()

        'CMD = New OdbcCommand("delete  from DETAIL", CONN)
        'CMD.ExecuteNonQuery()

        'MsgBox("data transaksi berhasil dihapus")

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Slabel10.Text = TimeOfDay
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        FormLogin.ShowDialog()
    End Sub

    Private Sub Btn_Master_Click(sender As Object, e As EventArgs) Handles Btn_Master.Click
        FormLaporanMaster.Show()

    End Sub

    Private Sub Btn_Service_Lp_Click(sender As Object, e As EventArgs) Handles Btn_Service_Lp.Click

    End Sub
End Class