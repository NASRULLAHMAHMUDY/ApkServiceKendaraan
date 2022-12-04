Imports System.Data.Odbc
Public Class FormLogin

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
        Call koneksi()
        cmd = New OdbcCommand("select * from users where Nama_User='" & txtNama.Text & "' and Pwd_User='" & TxtPassword.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            MsgBox("login gagal")
            txtNama.Clear()
            TxtPassword.Clear()
            txtNama.Focus()
            Exit Sub
        Else
            Me.Visible = False
            FormMenuUtama.Show()
            FormMenuUtama.Panel1.Text = rd.Item("Kode_User")
            FormMenuUtama.Panel2.Text = rd.Item("Nama_User")
            FormMenuUtama.Panel3.Text = UCase(rd.Item("Status_User"))

            If FormMenuUtama.Panel3.Text <> "ADMIN" Then
                FormMenuUtama.Button1.Visible = False
            End If

        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
    End Sub
End Class
