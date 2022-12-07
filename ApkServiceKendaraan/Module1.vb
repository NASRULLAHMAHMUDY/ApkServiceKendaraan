Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Module Module1

    Public CONN As OdbcConnection
    Public DA As OdbcDataAdapter
    Public DS As DataSet
    Public CMD As OdbcCommand
    Public DR As OdbcDataReader


    Public laporan As New ReportDocument
    Public TabelLogon As CrystalDecisions.Shared.TableLogOnInfo

    Public Sub SetingLaporan()
        Dim BacaTabel As CrystalDecisions.CrystalReports.Engine.Table
        For Each BacaTabel In laporan.Database.Tables
            TabelLogon = BacaTabel.LogOnInfo
            With TabelLogon.ConnectionInfo
                .ServerName = "service mysql" 'Application.StartupPath & "\database.mdb"
                .UserID = "root"
                .Password = ""
                .DatabaseName = "dbservice"
            End With
            BacaTabel.ApplyLogOnInfo(TabelLogon)
        Next BacaTabel
    End Sub

    Public Sub Koneksi()
        CONN = New OdbcConnection("dsn=service mysql")
        CONN.Open()

        'For Each frm As Form In My.Application.OpenForms
        '    If frm.Name = "MenuUtama" Then
        '        'frm.Text = ""
        '        frm.Text = "Aplikasi Service Kendaraan - Uus Rusmawan"
        '    Else
        '        frm.Text = frm.Text + " - Uus Rusmawan"
        '    End If
        'Next
    End Sub
End Module

