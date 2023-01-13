Imports System.Data.Odbc
Public Class FormLogin
    Sub Bersih()
        TxtNama.Text = "Username"
        TxtPassword.Text = ""
    End Sub
    Sub Buka()
        FormMenuUtama.Button1.Enabled = True
        FormMenuUtama.Btn_User.Enabled = True
        FormMenuUtama.Btn_Barang.Enabled = True
        FormMenuUtama.Btn_Jasa.Enabled = True
        FormMenuUtama.Btn_Service.Enabled = True
        FormMenuUtama.BtnHistoriService.Enabled = True
        FormMenuUtama.Btn_LapBarang.Enabled = True
        FormMenuUtama.Btn_LapJasa.Enabled = True
        FormMenuUtama.btnDataMaster.Enabled = True
        FormMenuUtama.btnTransaksi.Enabled = True
        FormMenuUtama.btnLaporan.Enabled = True
        FormMenuUtama.Btn_LogOff.Enabled = True
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        TxtNama.Focus()
        'TxtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TxtPassword.UseSystemPasswordChar = False
        Else
            TxtPassword.UseSystemPasswordChar = True
        End If
        TxtPassword.Focus()
    End Sub

    Private Sub TxtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            btnMasuk.Focus()
        End If
        If TxtPassword.Text = "Password" Then
            TxtPassword.ForeColor = Color.Silver

        Else
            TxtPassword.UseSystemPasswordChar = True
            TxtPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNama.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtPassword.Focus()
        End If
        If TxtNama.Text = "Username" Then
            TxtNama.ForeColor = Color.Silver
        Else
            TxtNama.ForeColor = Color.Black
        End If
    End Sub

    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        'Username(Kode_User) dan password (Pwd_user)tidak boleh kosong
        If TxtNama.Text = "" Or TxtPassword.Text = "" Then
            MsgBox("Kode admin dan password tidak boleh kosong!", MsgBoxStyle.Exclamation, "Isi Username dan Password")
        Else
            'Menggambill data user dari database
            Call Koneksi()
            CMD = New OdbcCommand("select * from admin where Kode_Admin='" & TxtNama.Text & "' and Pwd_Admin='" & TxtPassword.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                Me.Close()
                Call Buka()
                FormMenuUtama.Show()
                FormMenuUtama.Slabel2.Text = DR!Kode_Admin
                FormMenuUtama.Slabel4.Text = DR!Nama_Admin
                FormMenuUtama.Slabel6.Text = DR!Status_Admin
            Else
                MsgBox("Kode Admin dan Password salah!", MsgBoxStyle.Critical, "Cek Username dan Password")
                Call Bersih()
                TxtNama.Focus()
            End If
        End If
    End Sub

    Private Sub TxtNama_MouseClick(sender As Object, e As MouseEventArgs) Handles TxtNama.MouseClick
        If TxtNama.Text = "Username" Then
            TxtNama.Clear()
            TxtNama.ForeColor = Color.Black
        End If
    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click

    End Sub
End Class