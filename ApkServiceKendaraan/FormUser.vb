Imports System.Data.Odbc

Public Class FormUser
    'untuk mematikan Textbox,combobox,button kecuali button simpan. dan pada saat button simpan di klik maka toolbox yang mati akan hidup.'
    Sub Kosongkan()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Sub DataBaru()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox1.Text = ""
        TextBox2.Focus()
    End Sub

    Sub TampilStatus()
        cmd = New OdbcCommand("select Status_User from Users", conn)
        rd = cmd.ExecuteReader
        ComboBox1.Items.Clear()
        Do While rd.Read
            ComboBox1.Items.Add(rd.Item("Status_User"))
        Loop
    End Sub

    Sub TampilGrid()
        da = New OdbcDataAdapter("select * from users", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
    End Sub

    Sub Ketemu()
        On Error Resume Next
        TextBox2.Text = rd.Item("Nama_User")
        TextBox3.Text = rd.Item("Pwd_User")
        ComboBox1.Text = rd.Item("Status_User")
        TextBox2.Focus()
    End Sub

    Sub CariData()
        cmd = New OdbcCommand("select * from users where Kode_User='" & TextBox1.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
    End Sub

    Private Sub User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call Kosongkan()
        Call TampilGrid()
        Call TampilStatus()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Call CariData()
            If rd.HasRows Then
                Call Ketemu()
            Else
                Call DataBaru()
            End If
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Call CariData()
            If Not rd.HasRows Then
                Dim simpan As String = "insert into users values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & UCase(ComboBox1.Text) & "')"
                cmd = New OdbcCommand(simpan, conn)
                cmd.ExecuteNonQuery()
            Else
                Dim edit As String = "update users set Nama_User='" & TextBox2.Text & "',Pwd_User='" & TextBox3.Text & "',Status_User='" & UCase(ComboBox1.Text) & "' where Kode_User='" & TextBox1.Text & "'"
                cmd = New OdbcCommand(edit, conn)
                cmd.ExecuteNonQuery()
            End If
            Call Kosongkan()
            Call TampilStatus()
            Call TampilGrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TextBox1.Text = "" Then
            MsgBox("kode harus diisi")
            TextBox1.Focus()
            Exit Sub
        End If

        Call CariData()
        If Not rd.HasRows Then
            MsgBox("kode tidak terdaftar")
            TextBox1.Clear()
            TextBox1.Focus()
            Exit Sub
        End If

        If MessageBox.Show("yakin akan dihapus...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim hapus As String = "delete  from users where Kode_User='" & TextBox1.Text & "'"
            cmd = New OdbcCommand(hapus, conn)
            cmd.ExecuteNonQuery()
            Call Kosongkan()
            Call TampilGrid()
            Call TampilStatus()
        Else
            Call Kosongkan()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Kosongkan()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        da = New OdbcDataAdapter("select * from users where nama_user like '%" & TextBox4.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
    End Sub

    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        On Error Resume Next
        TextBox1.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        TextBox3.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        ComboBox1.Text = DGV.Rows(e.RowIndex).Cells(3).Value
    End Sub
End Class