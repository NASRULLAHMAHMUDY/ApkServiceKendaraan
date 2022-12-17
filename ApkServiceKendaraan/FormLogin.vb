Imports System.Data.Odbc
Public Class FormLogin
    Sub Bersih()
        TxtNama.Text = ""
        TxtPassword.Text = ""
    End Sub

    Sub Buka()
        FormMenuUtama.Btn_User.Enabled = True
        FormMenuUtama.Btn_Barang.Enabled = True
        FormMenuUtama.Btn_Jasa.Enabled = True
        FormMenuUtama.Btn_service.Enabled = True
        FormMenuUtama.Btn_Master.Enabled = True
        FormMenuUtama.Btn_Service_Lp.Enabled = True
        FormMenuUtama.Btn_Histori.Enabled = True
        FormMenuUtama.Btn_LogOff.Enabled = True
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
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

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        TxtNama.Focus()
        TxtPassword.UseSystemPasswordChar = True
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
            OK.Focus()
        End If
    End Sub

    Private Sub TxtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNama.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtPassword.Focus()
        End If
    End Sub


End Class