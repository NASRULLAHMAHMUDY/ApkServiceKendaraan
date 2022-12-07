Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormLogin
    Sub Bersih()
        txtNama.Text = ""
        TxtPassword.Text = ""
    End Sub
    Private Sub txtnama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNama.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtPassword.Focus()
        End If
    End Sub

    Private Sub txtpassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            OK.Focus()
        End If
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'Username(Kode_User) dan password (Pwd_user)tidak boleh kosong
        If txtNama.Text = "" Or TxtPassword.Text = "" Then
            MsgBox("Kode admin dan password tidak boleh kosong!", MsgBoxStyle.Exclamation, "Isi Username dan Password")
        Else
            'Menggambill data user dari database
            Call koneksi()
            cmd = New OdbcCommand("select * from users where Kode_User='" & txtNama.Text & "' and Pwd_User='" & TxtPassword.Text & "'", conn)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                Me.Hide()
                FormMenuUtama.ShowDialog()
                Me.Close()
            Else
                MsgBox("Kode Admin dan Password salah!", MsgBoxStyle.Critical, "Cek Username dan Password")
                Call Bersih()
                txtNama.Focus()
            End If

        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        txtNama.Focus()
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
End Class