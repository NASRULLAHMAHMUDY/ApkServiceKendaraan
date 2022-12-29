<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHistoriService
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CmbNomor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DGVJasa = New System.Windows.Forms.DataGridView()
        Me.TKeluhan = New System.Windows.Forms.TextBox()
        Me.TNopol = New System.Windows.Forms.TextBox()
        Me.TTotalharga = New System.Windows.Forms.Label()
        Me.TBiayaBarang = New System.Windows.Forms.Label()
        Me.TTanggal = New System.Windows.Forms.Label()
        Me.TBiayaService = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TDibayar = New System.Windows.Forms.TextBox()
        Me.TKembali = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnCetak = New System.Windows.Forms.Button()
        Me.DGVBarang = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DGVJasa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbNomor
        '
        Me.CmbNomor.FormattingEnabled = True
        Me.CmbNomor.Location = New System.Drawing.Point(171, 11)
        Me.CmbNomor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmbNomor.Name = "CmbNomor"
        Me.CmbNomor.Size = New System.Drawing.Size(148, 28)
        Me.CmbNomor.TabIndex = 133
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 31)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Nomor"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(498, 627)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(160, 31)
        Me.Label10.TabIndex = 131
        Me.Label10.Text = "Dibayar"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DGVJasa
        '
        Me.DGVJasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVJasa.Location = New System.Drawing.Point(12, 101)
        Me.DGVJasa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGVJasa.Name = "DGVJasa"
        Me.DGVJasa.RowHeadersWidth = 62
        Me.DGVJasa.Size = New System.Drawing.Size(820, 180)
        Me.DGVJasa.TabIndex = 124
        '
        'TKeluhan
        '
        Me.TKeluhan.Enabled = False
        Me.TKeluhan.Location = New System.Drawing.Point(489, 44)
        Me.TKeluhan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TKeluhan.Name = "TKeluhan"
        Me.TKeluhan.Size = New System.Drawing.Size(343, 26)
        Me.TKeluhan.TabIndex = 123
        '
        'TNopol
        '
        Me.TNopol.Enabled = False
        Me.TNopol.Location = New System.Drawing.Point(489, 13)
        Me.TNopol.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TNopol.Name = "TNopol"
        Me.TNopol.Size = New System.Drawing.Size(148, 26)
        Me.TNopol.TabIndex = 122
        '
        'TTotalharga
        '
        Me.TTotalharga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TTotalharga.Location = New System.Drawing.Point(668, 596)
        Me.TTotalharga.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TTotalharga.Name = "TTotalharga"
        Me.TTotalharga.Size = New System.Drawing.Size(150, 31)
        Me.TTotalharga.TabIndex = 121
        Me.TTotalharga.Text = "Total Harga"
        Me.TTotalharga.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TBiayaBarang
        '
        Me.TBiayaBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TBiayaBarang.Location = New System.Drawing.Point(668, 565)
        Me.TBiayaBarang.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TBiayaBarang.Name = "TBiayaBarang"
        Me.TBiayaBarang.Size = New System.Drawing.Size(150, 31)
        Me.TBiayaBarang.TabIndex = 120
        Me.TBiayaBarang.Text = "Biaya Barang"
        Me.TBiayaBarang.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TTanggal
        '
        Me.TTanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TTanggal.Location = New System.Drawing.Point(171, 47)
        Me.TTanggal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TTanggal.Name = "TTanggal"
        Me.TTanggal.Size = New System.Drawing.Size(150, 31)
        Me.TTanggal.TabIndex = 118
        Me.TTanggal.Text = "Tanggal"
        '
        'TBiayaService
        '
        Me.TBiayaService.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TBiayaService.Location = New System.Drawing.Point(669, 285)
        Me.TBiayaService.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TBiayaService.Name = "TBiayaService"
        Me.TBiayaService.Size = New System.Drawing.Size(150, 31)
        Me.TBiayaService.TabIndex = 119
        Me.TBiayaService.Text = "Biaya Service"
        Me.TBiayaService.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(498, 596)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 31)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "Total Harga"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(498, 565)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 31)
        Me.Label6.TabIndex = 116
        Me.Label6.Text = "Biaya Barang"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(510, 285)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 31)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "Biaya Service"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(330, 44)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 31)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "Keluhan"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(330, 13)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 31)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "Nomor Polisi"
        '
        'TDibayar
        '
        Me.TDibayar.Enabled = False
        Me.TDibayar.Location = New System.Drawing.Point(668, 627)
        Me.TDibayar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TDibayar.Name = "TDibayar"
        Me.TDibayar.Size = New System.Drawing.Size(148, 26)
        Me.TDibayar.TabIndex = 132
        Me.TDibayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TKembali
        '
        Me.TKembali.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TKembali.Location = New System.Drawing.Point(668, 657)
        Me.TKembali.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TKembali.Name = "TKembali"
        Me.TKembali.Size = New System.Drawing.Size(150, 31)
        Me.TKembali.TabIndex = 130
        Me.TKembali.Text = "Kembali"
        Me.TKembali.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(498, 657)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 31)
        Me.Label9.TabIndex = 129
        Me.Label9.Text = "Kembali"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(255, 561)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 62)
        Me.Button3.TabIndex = 128
        Me.Button3.Text = "Tutup"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(134, 561)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 62)
        Me.Button2.TabIndex = 127
        Me.Button2.Text = "Batal"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnCetak
        '
        Me.BtnCetak.Location = New System.Drawing.Point(12, 561)
        Me.BtnCetak.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCetak.Name = "BtnCetak"
        Me.BtnCetak.Size = New System.Drawing.Size(112, 62)
        Me.BtnCetak.TabIndex = 126
        Me.BtnCetak.Text = "Cetak"
        Me.BtnCetak.UseVisualStyleBackColor = True
        '
        'DGVBarang
        '
        Me.DGVBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBarang.Location = New System.Drawing.Point(12, 321)
        Me.DGVBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGVBarang.Name = "DGVBarang"
        Me.DGVBarang.RowHeadersWidth = 62
        Me.DGVBarang.Size = New System.Drawing.Size(820, 231)
        Me.DGVBarang.TabIndex = 125
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 31)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Tanggal"
        '
        'FormHistoriService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 699)
        Me.Controls.Add(Me.CmbNomor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DGVJasa)
        Me.Controls.Add(Me.TKeluhan)
        Me.Controls.Add(Me.TNopol)
        Me.Controls.Add(Me.TTotalharga)
        Me.Controls.Add(Me.TBiayaBarang)
        Me.Controls.Add(Me.TTanggal)
        Me.Controls.Add(Me.TBiayaService)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TDibayar)
        Me.Controls.Add(Me.TKembali)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnCetak)
        Me.Controls.Add(Me.DGVBarang)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FormHistoriService"
        Me.Text = "FormHistoriService"
        CType(Me.DGVJasa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbNomor As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DGVJasa As DataGridView
    Friend WithEvents TKeluhan As TextBox
    Friend WithEvents TNopol As TextBox
    Friend WithEvents TTotalharga As Label
    Friend WithEvents TBiayaBarang As Label
    Friend WithEvents TTanggal As Label
    Friend WithEvents TBiayaService As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TDibayar As TextBox
    Friend WithEvents TKembali As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnCetak As Button
    Friend WithEvents DGVBarang As DataGridView
    Friend WithEvents Label2 As Label
End Class
