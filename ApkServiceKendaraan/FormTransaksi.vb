Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class FormTransaksi

    Dim jumlahbarisjasa As Integer
    Dim jumlahbarisbarang As Integer

    Sub Bersihkan()
        TNopol.Clear()
        TKeluhan.Text = "-"
        TTLBiayaBarang.Text = 0
        TTLBiayaService.Text = 0
        TTotalharga.Text = 0
        TDibayar.Text = 0
        TKembali.Text = 0
        tbarisbarang.Text = 0
        tbarisjasa.Text = 0
        TCariBarang.Clear()
        TCariJasa.Clear()
        DGVJasa.Rows.Clear()
        DGVBarang.Rows.Clear()
    End Sub

    Sub Otomatis()
        cmd = New OdbcCommand("select nomor from service order by nomor desc", conn)
        DR = cmd.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            TNomor.Text = "00001"
        Else
            TNomor.Text = Format(Microsoft.VisualBasic.Right(DR.Item("nomor"), 5) + 1, "00000")
        End If
    End Sub

    Sub tampilJasa()
        da = New OdbcDataAdapter("select * from jasa", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV1.DataSource = ds.Tables(0)
        DGV1.ReadOnly = True
    End Sub

    Sub tampilBarang()
        da = New OdbcDataAdapter("select * from barang where stok>0", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV2.DataSource = ds.Tables(0)
        DGV2.ReadOnly = True
    End Sub

    Private Sub Transaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call Otomatis()
        TTanggal.Text = Today
        Call tampilBarang()
        Call tampilJasa()
        Call Bersihkan()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call Bersihkan()
    End Sub

    Sub TotalBiayaJasa()
        Dim hitung As Integer = 0
        For baris As Integer = 0 To DGVJasa.RowCount - 1
            hitung = hitung + DGVJasa.Rows(baris).Cells(2).Value
            TTLBiayaService.Text = FormatNumber(hitung, 0)
        Next
        tbarisjasa.Text = DGVJasa.RowCount - 1
    End Sub

    Sub TotalBiayaBarang()
        Dim hitung As Integer = 0
        For baris As Integer = 0 To DGVBarang.RowCount - 1
            hitung = hitung + DGVBarang.Rows(baris).Cells(4).Value
            TTLBiayaBarang.Text = FormatNumber(hitung, 0)
        Next
        tbarisbarang.Text = DGVBarang.RowCount - 1
    End Sub

    Sub HitungTotal()
        TTotalharga.Text = Val(Microsoft.VisualBasic.Str(TTLBiayaService.Text)) + Val(Microsoft.VisualBasic.Str(TTLBiayaBarang.Text))
        TTotalharga.Text = FormatNumber(TTotalharga.Text, 0)
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub TCariJasa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TCariJasa.TextChanged
        da = New OdbcDataAdapter("select * from jasa where nama_jasa like '%" & TCariJasa.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV1.DataSource = ds.Tables(0)
        DGV1.ReadOnly = True
    End Sub

    Private Sub TCariBarang_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TCariBarang.TextChanged
        da = New OdbcDataAdapter("select * from barang where nama_barang like '%" & TCariBarang.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV2.DataSource = ds.Tables(0)
        DGV2.ReadOnly = True

    End Sub

    Private Sub TDibayar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TDibayar.KeyPress
        If e.KeyChar = Chr(13) Then
            TDibayar.Text = FormatNumber(TDibayar.Text, 0)
            If Val(Microsoft.VisualBasic.Str(TDibayar.Text)) < Val(Microsoft.VisualBasic.Str(TTotalharga.Text)) Then
                MsgBox("Pembayaran kurang")
                Exit Sub
            ElseIf Val(Microsoft.VisualBasic.Str(TDibayar.Text)) >= Val(Microsoft.VisualBasic.Str(TTotalharga.Text)) Then
                TKembali.Text = Val(Microsoft.VisualBasic.Str(TDibayar.Text)) - Val(Microsoft.VisualBasic.Str(TTotalharga.Text))
                TKembali.Text = FormatNumber(TKembali.Text, 0)
                'Button1.Enabled = True
            End If
            Button1.Focus()
        End If

        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TNopol.Text = "" Or TKeluhan.Text = "" Or TDibayar.Text = "" Or TDibayar.Text = 0 Or txtMontir.Text = "" Then
            MsgBox("data belum lengkap")
            Exit Sub
        End If

        CMD = New OdbcCommand("insert into service values ('" & TNomor.Text & "','" & Format(DateValue(TTanggal.Text), "yyyy-MM-dd") & "','" & TNopol.Text & "','" & TKeluhan.Text & "','" & TTLBiayaService.Text & "','" & TTLBiayaBarang.Text & "','" & TTotalharga.Text & "','" & TDibayar.Text & "','" & TKembali.Text & "','" & FormMenuUtama.Panel1.Text & "','" & txtMontir.Text & "')", CONN)
        CMD.ExecuteNonQuery()

        'jika baris jasa lebih banyak
        If Val(tbarisjasa.Text) > Val(tbarisbarang.Text) Then
            For baris As Integer = 0 To DGVJasa.RowCount - 2
                cmd = New OdbcCommand("insert into detail values('" & TNomor.Text & "','-',0,0,0,'" & DGVJasa.Rows(baris).Cells(0).Value & "','" & DGVJasa.Rows(baris).Cells(2).Value & "')", conn)
                cmd.ExecuteNonQuery()
            Next

            For baris As Integer = 0 To DGVBarang.RowCount - 2
                cmd = New OdbcCommand("update detail set kode_barang='" & DGVBarang.Rows(baris).Cells(0).Value & "',Harga='" & DGVBarang.Rows(baris).Cells(2).Value & "',Jumlah='" & DGVBarang.Rows(baris).Cells(3).Value & "',Total='" & DGVBarang.Rows(baris).Cells(4).Value & "' where nomor='" & TNomor.Text & "' and kode_jasa='" & DGVJasa.Rows(baris).Cells(0).Value & "'", conn)
                cmd.ExecuteNonQuery()

                cmd = New OdbcCommand("select stok from barang where kode_barang='" & DGVBarang.Rows(baris).Cells(0).Value & "'", conn)
                DR = cmd.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    cmd = New OdbcCommand("update barang set stok='" & DR.Item("stok") - DGVBarang.Rows(baris).Cells(3).Value & "' where kode_barang='" & DGVBarang.Rows(baris).Cells(0).Value & "'", conn)
                    cmd.ExecuteNonQuery()
                End If
            Next
        End If

        'jika baris barang lebih banyak
        If Val(tbarisbarang.Text) >= Val(tbarisjasa.Text) Then
            For baris As Integer = 0 To DGVBarang.RowCount - 2
                cmd = New OdbcCommand("insert into detail values('" & TNomor.Text & "','" & DGVBarang.Rows(baris).Cells(0).Value & "','" & DGVBarang.Rows(baris).Cells(2).Value & "','" & DGVBarang.Rows(baris).Cells(3).Value & "','" & DGVBarang.Rows(baris).Cells(4).Value & "','-',0)", conn)
                cmd.ExecuteNonQuery()

                cmd = New OdbcCommand("select stok from barang where kode_barang='" & DGVBarang.Rows(baris).Cells(0).Value & "'", conn)
                DR = cmd.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    cmd = New OdbcCommand("update barang set stok='" & DR.Item("stok") - DGVBarang.Rows(baris).Cells(3).Value & "' where kode_barang='" & DGVBarang.Rows(baris).Cells(0).Value & "'", conn)
                    cmd.ExecuteNonQuery()
                End If
            Next

            For baris As Integer = 0 To DGVJasa.RowCount - 2
                cmd = New OdbcCommand("update detail set kode_jasa='" & DGVJasa.Rows(baris).Cells(0).Value & "',tarif='" & DGVJasa.Rows(baris).Cells(2).Value & "' where nomor='" & TNomor.Text & "' and kode_barang='" & DGVBarang.Rows(baris).Cells(0).Value & "'", conn)
                cmd.ExecuteNonQuery()
            Next
        End If

        'jika baris jasa dan barang sama


        If MessageBox.Show("cetak faktur...", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            FormCetak.Show()
            'laporan.Load("pembayaran.rpt")
            laporan.Load("faktur ok.rpt")
            Call SetingLaporan()
            FormCetak.CRV.ReportSource = laporan
            FormCetak.CRV.RefreshReport()
        End If
        Call Otomatis()
        Call Bersihkan()
        Call tampilBarang()

    End Sub

    Private Sub TNopol_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TNopol.KeyPress
        If e.KeyChar = Chr(13) Then
            TNopol.Text = UCase(TNopol.Text)
            TKeluhan.Focus()
        End If
    End Sub

    Private Sub DGVJasa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DGVJasa.KeyPress
        On Error Resume Next
        If e.KeyChar = Chr(27) Then
            DGVJasa.Rows.RemoveAt(DGVJasa.CurrentCell.RowIndex)
            Call TotalBiayaJasa()
            Call HitungTotal()
        End If
    End Sub

    Private Sub DGVBarang_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVBarang.CellEndEdit
        If e.ColumnIndex = 3 Then
            Try
                DGVBarang.Rows(e.RowIndex).Cells(4).Value = DGVBarang.Rows(e.RowIndex).Cells(3).Value * DGVBarang.Rows(e.RowIndex).Cells(2).Value
            Catch ex As Exception
                MsgBox("harus angka")
                SendKeys.Send("{UP}")
                DGVBarang.Rows(e.RowIndex).Cells(3).Value = 1
                DGVBarang.Rows(e.RowIndex).Cells(4).Value = DGVBarang.Rows(e.RowIndex).Cells(3).Value * DGVBarang.Rows(e.RowIndex).Cells(2).Value
            End Try
        End If
        Call TotalBiayaBarang()
        Call HitungTotal()
    End Sub


    Private Sub DGVBarang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DGVBarang.KeyPress
        On Error Resume Next
        If e.KeyChar = Chr(27) Then
            DGVBarang.Rows.RemoveAt(DGVBarang.CurrentCell.RowIndex)
            Call TotalBiayaBarang()
            Call HitungTotal()
        End If
    End Sub

    Private Sub DGV1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV1.CellMouseClick
        On Error Resume Next
        Dim baris As Integer = DGVJasa.RowCount - 1
        DGVJasa.Rows.Add(DGV1.Rows(e.RowIndex).Cells(0).Value)

        For i As Integer = 0 To DGVJasa.RowCount - 1
            For j As Integer = i + 1 To DGVJasa.RowCount - 1
                If DGVJasa.Rows(j).Cells(0).Value = DGVJasa.Rows(i).Cells(0).Value Then
                    MsgBox("data sudah dientri")
                    DGVJasa.Rows.RemoveAt(j)
                    Exit Sub
                End If
            Next
        Next

        cmd = New OdbcCommand("select * from jasa where kode_jasa='" & DGVJasa.Rows(baris).Cells(0).Value & "'", conn)
        DR = cmd.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            DGVJasa.Rows(baris).Cells(1).Value = DR.Item("nama_jasa")
            DGVJasa.Rows(baris).Cells(2).Value = DR.Item("harga_jasa")
            DGVJasa.Columns(2).DefaultCellStyle.Format = "###,###,###"
            DGVJasa.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
        Call TotalBiayaJasa()
        Call HitungTotal()
        TCariJasa.Clear()

    End Sub

    Private Sub DGV2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV2.CellMouseClick
        Dim baris As Integer = DGVBarang.RowCount - 1
        DGVBarang.Rows.Add(DGV2.Rows(e.RowIndex).Cells(0).Value)

        For i As Integer = 0 To DGVBarang.RowCount - 1
            For j As Integer = i + 1 To DGVBarang.RowCount - 1
                If DGVBarang.Rows(j).Cells(0).Value = DGVBarang.Rows(i).Cells(0).Value Then
                    MsgBox("data sudah dientri")
                    DGVBarang.Rows.RemoveAt(j)
                    Exit Sub
                End If
            Next
        Next

        cmd = New OdbcCommand("select * from Barang where kode_Barang='" & DGVBarang.Rows(baris).Cells(0).Value & "'", conn)
        DR = cmd.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            DGVBarang.Rows(baris).Cells(1).Value = DR.Item("nama_Barang")
            DGVBarang.Rows(baris).Cells(2).Value = DR.Item("harga_Barang")
            DGVBarang.Columns(2).DefaultCellStyle.Format = "###,###,###"
            DGVBarang.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGVBarang.Rows(baris).Cells(3).Value = 1
            DGVBarang.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGVBarang.Rows(baris).Cells(4).Value = DGVBarang.Rows(baris).Cells(2).Value * DGVBarang.Rows(baris).Cells(3).Value
            DGVBarang.Columns(4).DefaultCellStyle.Format = "###,###,###"
            DGVBarang.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
        Call TotalBiayaBarang()
        Call HitungTotal()
        TCariBarang.Clear()
    End Sub


End Class


