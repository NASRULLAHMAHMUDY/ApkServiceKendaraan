Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports CrystalDecisions.CrystalReports.Engine

Public Class FormHistoriService

    Sub Kosongkan()
        CmbNomor.Text = ""
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
        TTanggal.Text = DR.Item("tanggal")
        TNopol.Text = DR.Item("nomor_polisi")
        TKeluhan.Text = DR.Item("keluhan")
        TBiayaService.Text = DR.Item("biaya_jasa")
        TBiayaBarang.Text = DR.Item("biaya_barang")
        TTotalharga.Text = DR.Item("total_harga")
        TDibayar.Text = DR.Item("dibayar")
        TKembali.Text = DR.Item("kembali")
    End Sub
    Sub detailJasa()
        DA = New OdbcDataAdapter("select Nama_jasa,harga_jasa from jasa,detail where jasa.kode_jasa=detail.kode_jasa and nomor='" & CmbNomor.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DGVJasa.DataSource = DS.Tables(0)
        DGVJasa.ReadOnly = True
        DGVJasa.Columns(0).HeaderText = "Nama Jasa"
        DGVJasa.Columns(1).HeaderText = "Harga"
        DGVJasa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Sub detailBarang()
        DA = New OdbcDataAdapter("select barang.nama_barang,harga_barang,detail.Jumlah,Total from barang,detail where barang.kode_barang=detail.kode_barang and nomor='" & CmbNomor.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DGVBarang.DataSource = DS.Tables(0)
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
        Call Koneksi()
        CMD = New OdbcCommand("select nomor from service", CONN)
        DR = CMD.ExecuteReader
        Do While DR.Read
            CmbNomor.Items.Add(DR.Item(0))
        Loop
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call Kosongkan()
        Call BersihkanDuaGrid()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbNomor.SelectedIndexChanged
        CMD = New OdbcCommand("select * from service where nomor='" & CmbNomor.Text & "'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Call TampilData()
            Call detailJasa()
            Call detailBarang()
        Else
            Call Kosongkan()
            Call BersihkanDuaGrid()
            MsgBox("Data tidak ditemukan")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCetak.Click
        Dim Lap As New ReportDocument
        Lap.Load("..\..\CVR4.rpt")
        FormLapHistori.CrystalReportViewer1.SelectionFormula = "Totext({detail1.Nomor})='" & CmbNomor.Text & "'"
        FormLapHistori.CrystalReportViewer1.ReportSource = Lap
        FormLapHistori.Show()
    End Sub

    Private Sub FormHistoriService_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush(Me.ClientRectangle, Color.Blue, Color.Gray, Drawing2D.LinearGradientMode.Horizontal)
        e.Graphics.FillRectangle(i, Me.ClientRectangle)
    End Sub
End Class