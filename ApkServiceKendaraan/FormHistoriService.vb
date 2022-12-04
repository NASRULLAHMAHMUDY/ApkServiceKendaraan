Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormHistoriService

    Sub Kosongkan()
        ComboBox1.Text = ""
        TTanggal.Text = ""
        TNopol.Text = ""
        TKeluhan.Text = ""
        TBiayaService.Text = ""
        TBiayaBarang.Text = ""
        TTotalharga.Text = ""
        TDibayar.Text = ""
        TKembali.Text = ""
    End Sub

    Sub TampilData()
        TTanggal.Text = rd.Item("Tanggal")
        TNopol.Text = rd.Item("Nomor_Polisi")
        TKeluhan.Text = rd.Item("Keluhan")
        TBiayaService.Text = rd.Item("Biaya_Jasa")
        TBiayaBarang.Text = rd.Item("Biaya_Barang")
        TTotalharga.Text = rd.Item("Total_Harga")
        TDibayar.Text = rd.Item("Dibayar")
        TKembali.Text = rd.Item("Kembali")
    End Sub
    Sub detailJasa()
        da = New OdbcDataAdapter("select Nama_Jasa,Harga_Jasa from jasa,detail where jasa.Kode_Jasa=detail.Kode_Jasa and Nomor='" & ComboBox1.Text & "'", conn)
        ds = New DataSet
        da.Fill(ds)
        DGVJasa.DataSource = ds.Tables(0)
        DGVJasa.ReadOnly = True
        DGVJasa.Columns(0).HeaderText = "Nama Jasa"
        DGVJasa.Columns(1).HeaderText = "Harga"
        DGVJasa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Sub detailBarang()
        da = New OdbcDataAdapter("select barang.Nama_Barang,Harga_Barang,detail.Jumlah,Total from barang,detail where barang.Kode_Barang=detail.Kode_Barang and Nomor='" & ComboBox1.Text & "'", conn)
        ds = New DataSet
        da.Fill(ds)
        DGVBarang.DataSource = ds.Tables(0)
        DGVBarang.ReadOnly = True

        DGVBarang.Columns(0).HeaderText = "Nama Barang"
        DGVBarang.Columns(1).HeaderText = "Harga Barang"
        DGVBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    Sub BersihkanDuaGrid()
        DGVJasa.Columns.Clear()
        DGVBarang.Columns.Clear()
    End Sub



    Private Sub HistoriService_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        cmd = New OdbcCommand("select Nomor from service", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            ComboBox1.Items.Add(rd.Item(0))
        Loop
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call Kosongkan()
        Call BersihkanDuaGrid()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        cmd = New OdbcCommand("select * from service where nomor='" & ComboBox1.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Call TampilData()
            Call detailJasa()
            Call detailBarang()
        Else
            Call Kosongkan()
            Call BersihkanDuaGrid()
            MsgBox("Data tidak ditemukan")
        End If
    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Cetak.Show()
    '    Cetak.CRV.SelectionFormula = "{service.NOMOR} = '" & ComboBox1.Text & "'"
    '    laporan.Load("faktur ok.rpt")
    '    Call SetingLaporan()
    '    Cetak.CRV.ReportSource = laporan
    '    Cetak.CRV.RefreshReport()
    'End Sub
End Class