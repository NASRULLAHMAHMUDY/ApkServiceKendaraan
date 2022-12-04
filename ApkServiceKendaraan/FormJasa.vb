Imports System.Data.Odbc

Public Class FormJasa

    Sub Kosongkan()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox1.Focus()
    End Sub

    Sub DataBaru()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox2.Focus()
    End Sub

    Sub TampilGrid()
        da = New OdbcDataAdapter("select * from jasa where Kode_Jasa<>'-'", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
    End Sub
    Sub Ketemu()
        On Error Resume Next
        TextBox2.Text = rd.Item("Nama_Jasa")
        TextBox3.Text = rd.Item("Harga_Jasa")
        TextBox2.Focus()
    End Sub
    Sub CariData()
        cmd = New OdbcCommand("select * from jasa where Kode_Jasa='" & TextBox1.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
    End Sub

    Private Sub jasa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call Kosongkan()
        Call TampilGrid()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call CariData()
            If rd.HasRows Then
                Call Ketemu()
            Else
                Call DataBaru()
            End If
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Call CariData()
            If Not rd.HasRows Then
                Dim simpan As String = "insert into jasa values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"
                cmd = New OdbcCommand(simpan, conn)
                cmd.ExecuteNonQuery()
            Else
                Dim edit As String = "update jasa set Nama_Jasa='" & TextBox2.Text & "',Harga_Jasa='" & TextBox3.Text & "' where Kode_Jasa='" & TextBox1.Text & "'"
                cmd = New OdbcCommand(edit, conn)
                cmd.ExecuteNonQuery()
            End If
            Call Kosongkan()
            Call TampilGrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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
            Dim hapus As String = "delete  from jasa where Kode_Jasa='" & TextBox1.Text & "'"
            cmd = New OdbcCommand(hapus, conn)
            cmd.ExecuteNonQuery()
            Call Kosongkan()
            Call TampilGrid()
        Else
            Call Kosongkan()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call Kosongkan()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        da = New OdbcDataAdapter("select * from jasa where Nama_Jasa like '%" & TextBox4.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
    End Sub

    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        TextBox1.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        TextBox3.Text = DGV.Rows(e.RowIndex).Cells(2).Value
    End Sub


    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub
End Class