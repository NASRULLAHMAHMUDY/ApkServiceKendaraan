Imports System.Data.Odbc
Imports Microsoft.VisualBasic.ApplicationServices

Public Class FormMenuUtama
    Sub Kunci()
        Btn_User.Enabled = False
        Btn_Barang.Enabled = False
        Btn_Jasa.Enabled = False
        Btn_Service.Enabled = False
        Btn_LapBarang.Enabled = False
        Btn_LapJasa.Enabled = False
        Btn_LapJasa.Enabled = False
        Btn_Histori.Enabled = False
        btnDataMaster.Enabled = False
        btnTransaksi.Enabled = False
        btnLaporan.Enabled = False
        Btn_LogOff.Enabled = True
    End Sub

    Private Sub MenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Slabel8.Text = Today
        Call Kunci()

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        FormLogin.Show()
        FormLogin.TxtNama.Clear()
        FormLogin.TxtPassword.Clear()
        FormLogin.TxtNama.Focus()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MessageBox.Show("Tutup aplikasi...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub
    Private Sub Btn_User_Click(sender As Object, e As EventArgs) Handles Btn_User.Click
        FormAdmin.ShowDialog()
    End Sub

    Private Sub Btn_Barang_Click(sender As Object, e As EventArgs) Handles Btn_Barang.Click
        FormBarang.ShowDialog()
    End Sub

    Private Sub Btn_Jasa_Click(sender As Object, e As EventArgs) Handles Btn_Jasa.Click
        FormJasa.ShowDialog()
    End Sub

    Private Sub Btn_Service_Click(sender As Object, e As EventArgs) Handles Btn_Service.Click
        FormTransaksi.ShowDialog()
    End Sub

    Private Sub Btn_LapBarang_Click(sender As Object, e As EventArgs) Handles Btn_LapBarang.Click
        FormLaporanBarang.ShowDialog()
    End Sub

    Private Sub Btn_LapJasa_Click(sender As Object, e As EventArgs) Handles Btn_LapJasa.Click
        FormLaporanJasa.ShowDialog()
    End Sub

    Private Sub Btn_Histori_Click(sender As Object, e As EventArgs) Handles Btn_Histori.Click
        FormLapHistori.ShowDialog()
    End Sub

    Private Sub btnDataMaster_Click(sender As Object, e As EventArgs) Handles btnDataMaster.Click
        'Button Dipilih
        lblSelected1.Visible = True
        lblSelected2.Visible = False
        lblSelected3.Visible = False
        lblSelected4.Visible = False
        lblSelected5.Visible = False
        'Tampilkan panel konten
        pnlDataMaster.Visible = True
        pnlTransaksi.Visible = False
        pnlLaporan.Visible = False
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = True
        lblSelected3.Visible = False
        lblSelected4.Visible = False
        lblSelected5.Visible = False
        'Tampilkan panel konten
        pnlDataMaster.Visible = False
        pnlTransaksi.Visible = True
        pnlLaporan.Visible = False
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = False
        lblSelected3.Visible = True
        lblSelected4.Visible = False
        lblSelected5.Visible = False
        'Tampilkan panel konten
        pnlDataMaster.Visible = False
        pnlTransaksi.Visible = False
        pnlLaporan.Visible = True
    End Sub

    Private Sub btnTentang_Click(sender As Object, e As EventArgs) Handles Btn_LogOff.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = False
        lblSelected3.Visible = False
        lblSelected4.Visible = True
        lblSelected5.Visible = False
        Me.Close()
        FormLogin.Show()
        FormLogin.TxtNama.Clear()
        FormLogin.TxtPassword.Clear()
        FormLogin.TxtNama.Focus()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = False
        lblSelected3.Visible = False
        lblSelected4.Visible = False
        lblSelected5.Visible = True
        End
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        FormLogin.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Slabel10.Text = TimeOfDay
    End Sub


End Class