Public Class FormLaporanMaster

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        laporan.Load("barang.rpt")
        Call SetingLaporan()
        CRV.ReportSource = laporan
        CRV.RefreshReport()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        laporan.Load("jasa.rpt")
        Call SetingLaporan()
        CRV.ReportSource = laporan
        CRV.RefreshReport()
    End Sub

End Class