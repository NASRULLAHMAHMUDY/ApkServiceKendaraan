Imports System.Data.Odbc

Public Class FormLaporanService

    Private Sub LaporanService_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        CMD = New OdbcCommand("select nomor from service", CONN)
        DR = CMD.ExecuteReader
        Do While DR.Read
            ListBox1.Items.Add(DR.Item(0))
        Loop

        CMD = New OdbcCommand("select distinct nomor_polisi from service", CONN)
        DR = CMD.ExecuteReader
        Do While DR.Read
            ListBox2.Items.Add(DR.Item(0))
        Loop
        DTP1.Format = DateTimePickerFormat.Short
        DTP2.Format = DateTimePickerFormat.Short
        DTP3.Format = DateTimePickerFormat.Short
        DTP4.Format = DateTimePickerFormat.Short
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CRV.SelectionFormula = "Totext({service.tanggal}) = '" & DTP1.Text & "'"
        laporan.Load("MASTER SERVICE.rpt")
        Call SetingLaporan()
        CRV.ReportSource = laporan
        CRV.RefreshReport()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CRV.SelectionFormula = "{service.tanggal} in date ('" & DTP2.Text & "') to date ('" & DTP3.Text & "')"
        laporan.Load("MASTER SERVICE.rpt")
        Call SetingLaporan()
        CRV.ReportSource = laporan
        CRV.RefreshReport()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CRV.SelectionFormula = "month({service.tanggal}) = (" & Month(DTP4.Text) & ") and year({service.tanggal}) = (" & Year(DTP4.Text) & ")"
        laporan.Load("MASTER SERVICE.rpt")
        Call SetingLaporan()
        CRV.ReportSource = laporan
        CRV.RefreshReport()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        CRV.SelectionFormula = "{service.NOMOR} = '" & ListBox1.Text & "'"
        laporan.Load("per nomor service.rpt")
        Call SetingLaporan()
        CRV.ReportSource = laporan
        CRV.RefreshReport()
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        CRV.SelectionFormula = "{service.NOMOR_polisi} = '" & ListBox2.Text & "'"
        laporan.Load("per nomor polisi.rpt")
        Call SetingLaporan()
        CRV.ReportSource = laporan
        CRV.RefreshReport()
    End Sub
End Class