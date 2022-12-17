<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksi
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
        Me.tbarisbarang = New System.Windows.Forms.Label()
        Me.tbarisjasa = New System.Windows.Forms.Label()
        Me.txtMontir = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TKeluhan = New System.Windows.Forms.TextBox()
        Me.TNopol = New System.Windows.Forms.TextBox()
        Me.TTotalharga = New System.Windows.Forms.Label()
        Me.TTLBiayaBarang = New System.Windows.Forms.Label()
        Me.TTanggal = New System.Windows.Forms.Label()
        Me.TTLBiayaService = New System.Windows.Forms.Label()
        Me.TNomor = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jasa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV2 = New System.Windows.Forms.DataGridView()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.TDibayar = New System.Windows.Forms.TextBox()
        Me.TKembali = New System.Windows.Forms.Label()
        Me.TCariBarang = New System.Windows.Forms.TextBox()
        Me.TCariJasa = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DGVBarang = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVJasa = New System.Windows.Forms.DataGridView()
        Me.Harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TNamaAdmin = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVJasa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbarisbarang
        '
        Me.tbarisbarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbarisbarang.Location = New System.Drawing.Point(7, 711)
        Me.tbarisbarang.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tbarisbarang.Name = "tbarisbarang"
        Me.tbarisbarang.Size = New System.Drawing.Size(150, 31)
        Me.tbarisbarang.TabIndex = 119
        '
        'tbarisjasa
        '
        Me.tbarisjasa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbarisjasa.Location = New System.Drawing.Point(5, 344)
        Me.tbarisjasa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tbarisjasa.Name = "tbarisjasa"
        Me.tbarisjasa.Size = New System.Drawing.Size(150, 31)
        Me.tbarisjasa.TabIndex = 118
        '
        'txtMontir
        '
        Me.txtMontir.Location = New System.Drawing.Point(323, 681)
        Me.txtMontir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMontir.Name = "txtMontir"
        Me.txtMontir.Size = New System.Drawing.Size(158, 26)
        Me.txtMontir.TabIndex = 117
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(323, 645)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(160, 31)
        Me.Label8.TabIndex = 116
        Me.Label8.Text = "Montir"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(5, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 31)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Nomor"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(493, 707)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(160, 31)
        Me.Label10.TabIndex = 112
        Me.Label10.Text = "Dibayar"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TKeluhan
        '
        Me.TKeluhan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TKeluhan.Location = New System.Drawing.Point(482, 38)
        Me.TKeluhan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TKeluhan.Name = "TKeluhan"
        Me.TKeluhan.Size = New System.Drawing.Size(576, 26)
        Me.TKeluhan.TabIndex = 102
        '
        'TNopol
        '
        Me.TNopol.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TNopol.Location = New System.Drawing.Point(482, 7)
        Me.TNopol.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TNopol.Name = "TNopol"
        Me.TNopol.Size = New System.Drawing.Size(148, 26)
        Me.TNopol.TabIndex = 101
        '
        'TTotalharga
        '
        Me.TTotalharga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TTotalharga.Location = New System.Drawing.Point(662, 676)
        Me.TTotalharga.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TTotalharga.Name = "TTotalharga"
        Me.TTotalharga.Size = New System.Drawing.Size(150, 31)
        Me.TTotalharga.TabIndex = 100
        Me.TTotalharga.Text = "Total Harga"
        Me.TTotalharga.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TTLBiayaBarang
        '
        Me.TTLBiayaBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TTLBiayaBarang.Location = New System.Drawing.Point(662, 645)
        Me.TTLBiayaBarang.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TTLBiayaBarang.Name = "TTLBiayaBarang"
        Me.TTLBiayaBarang.Size = New System.Drawing.Size(150, 31)
        Me.TTLBiayaBarang.TabIndex = 99
        Me.TTLBiayaBarang.Text = "Biaya Barang"
        Me.TTLBiayaBarang.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TTanggal
        '
        Me.TTanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TTanggal.Location = New System.Drawing.Point(164, 41)
        Me.TTanggal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TTanggal.Name = "TTanggal"
        Me.TTanggal.Size = New System.Drawing.Size(150, 31)
        Me.TTanggal.TabIndex = 97
        Me.TTanggal.Text = "Tanggal"
        '
        'TTLBiayaService
        '
        Me.TTLBiayaService.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TTLBiayaService.Location = New System.Drawing.Point(662, 344)
        Me.TTLBiayaService.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TTLBiayaService.Name = "TTLBiayaService"
        Me.TTLBiayaService.Size = New System.Drawing.Size(150, 31)
        Me.TTLBiayaService.TabIndex = 98
        Me.TTLBiayaService.Text = "Biaya Service"
        Me.TTLBiayaService.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TNomor
        '
        Me.TNomor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TNomor.Location = New System.Drawing.Point(164, 7)
        Me.TNomor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TNomor.Name = "TNomor"
        Me.TNomor.Size = New System.Drawing.Size(150, 31)
        Me.TNomor.TabIndex = 96
        Me.TNomor.Text = "Nomor"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(493, 676)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 31)
        Me.Label7.TabIndex = 95
        Me.Label7.Text = "Total Harga"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(493, 645)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 31)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "Biaya Barang"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(503, 344)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 31)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Biaya Service"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(323, 38)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 31)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Keluhan"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(323, 7)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 31)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Nomor Polisi"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(5, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 31)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Tanggal"
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 8
        Me.Total.Name = "Total"
        Me.Total.Width = 150
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(493, 738)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 31)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "Kembali"
        '
        'Kode
        '
        Me.Kode.HeaderText = "Kode"
        Me.Kode.MinimumWidth = 8
        Me.Kode.Name = "Kode"
        Me.Kode.Width = 150
        '
        'Jasa
        '
        Me.Jasa.HeaderText = "Jasa"
        Me.Jasa.MinimumWidth = 8
        Me.Jasa.Name = "Jasa"
        Me.Jasa.Width = 300
        '
        'DGV2
        '
        Me.DGV2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2.Location = New System.Drawing.Point(845, 401)
        Me.DGV2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGV2.Name = "DGV2"
        Me.DGV2.RowHeadersWidth = 62
        Me.DGV2.Size = New System.Drawing.Size(706, 229)
        Me.DGV2.TabIndex = 115
        '
        'DGV1
        '
        Me.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(843, 95)
        Me.DGV1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.RowHeadersWidth = 62
        Me.DGV1.Size = New System.Drawing.Size(706, 229)
        Me.DGV1.TabIndex = 114
        '
        'TDibayar
        '
        Me.TDibayar.Location = New System.Drawing.Point(662, 707)
        Me.TDibayar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TDibayar.Name = "TDibayar"
        Me.TDibayar.Size = New System.Drawing.Size(148, 26)
        Me.TDibayar.TabIndex = 113
        Me.TDibayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TKembali
        '
        Me.TKembali.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TKembali.Location = New System.Drawing.Point(662, 738)
        Me.TKembali.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TKembali.Name = "TKembali"
        Me.TKembali.Size = New System.Drawing.Size(150, 31)
        Me.TKembali.TabIndex = 111
        Me.TKembali.Text = "Kembali"
        Me.TKembali.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TCariBarang
        '
        Me.TCariBarang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TCariBarang.Location = New System.Drawing.Point(835, 642)
        Me.TCariBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TCariBarang.Name = "TCariBarang"
        Me.TCariBarang.Size = New System.Drawing.Size(222, 26)
        Me.TCariBarang.TabIndex = 109
        '
        'TCariJasa
        '
        Me.TCariJasa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TCariJasa.Location = New System.Drawing.Point(835, 344)
        Me.TCariJasa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TCariJasa.Name = "TCariJasa"
        Me.TCariJasa.Size = New System.Drawing.Size(222, 26)
        Me.TCariJasa.TabIndex = 108
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(193, 645)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 62)
        Me.Button3.TabIndex = 107
        Me.Button3.Text = "Tutup"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(99, 645)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 62)
        Me.Button2.TabIndex = 106
        Me.Button2.Text = "Batal"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 645)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 62)
        Me.Button1.TabIndex = 105
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DGVBarang
        '
        Me.DGVBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Nama, Me.DataGridViewTextBoxColumn2, Me.Jumlah, Me.Total})
        Me.DGVBarang.Location = New System.Drawing.Point(7, 401)
        Me.DGVBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGVBarang.Name = "DGVBarang"
        Me.DGVBarang.RowHeadersWidth = 62
        Me.DGVBarang.Size = New System.Drawing.Size(820, 231)
        Me.DGVBarang.TabIndex = 104
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Kode"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 75
        '
        'Nama
        '
        Me.Nama.HeaderText = "Nama Barang"
        Me.Nama.MinimumWidth = 8
        Me.Nama.Name = "Nama"
        Me.Nama.Width = 175
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Harga"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'Jumlah
        '
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.MinimumWidth = 8
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.Width = 50
        '
        'DGVJasa
        '
        Me.DGVJasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVJasa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Kode, Me.Jasa, Me.Harga})
        Me.DGVJasa.Location = New System.Drawing.Point(5, 95)
        Me.DGVJasa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGVJasa.Name = "DGVJasa"
        Me.DGVJasa.RowHeadersWidth = 62
        Me.DGVJasa.Size = New System.Drawing.Size(820, 231)
        Me.DGVJasa.TabIndex = 103
        '
        'Harga
        '
        Me.Harga.HeaderText = "Harga"
        Me.Harga.MinimumWidth = 8
        Me.Harga.Name = "Harga"
        Me.Harga.Width = 150
        '
        'TNamaAdmin
        '
        Me.TNamaAdmin.Location = New System.Drawing.Point(772, 5)
        Me.TNamaAdmin.Name = "TNamaAdmin"
        Me.TNamaAdmin.Size = New System.Drawing.Size(149, 26)
        Me.TNamaAdmin.TabIndex = 120
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(909, 736)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(149, 26)
        Me.TextBox2.TabIndex = 121
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1289, 792)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TNamaAdmin)
        Me.Controls.Add(Me.tbarisbarang)
        Me.Controls.Add(Me.tbarisjasa)
        Me.Controls.Add(Me.txtMontir)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TKeluhan)
        Me.Controls.Add(Me.TNopol)
        Me.Controls.Add(Me.TTotalharga)
        Me.Controls.Add(Me.TTLBiayaBarang)
        Me.Controls.Add(Me.TTanggal)
        Me.Controls.Add(Me.TTLBiayaService)
        Me.Controls.Add(Me.TNomor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DGV2)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.TDibayar)
        Me.Controls.Add(Me.TKembali)
        Me.Controls.Add(Me.TCariBarang)
        Me.Controls.Add(Me.TCariJasa)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DGVBarang)
        Me.Controls.Add(Me.DGVJasa)
        Me.Name = "FormTransaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormTransaksi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVJasa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbarisbarang As Label
    Friend WithEvents tbarisjasa As Label
    Friend WithEvents txtMontir As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TKeluhan As TextBox
    Friend WithEvents TNopol As TextBox
    Friend WithEvents TTotalharga As Label
    Friend WithEvents TTLBiayaBarang As Label
    Friend WithEvents TTanggal As Label
    Friend WithEvents TTLBiayaService As Label
    Friend WithEvents TNomor As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Label9 As Label
    Friend WithEvents Kode As DataGridViewTextBoxColumn
    Friend WithEvents Jasa As DataGridViewTextBoxColumn
    Friend WithEvents DGV2 As DataGridView
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents TDibayar As TextBox
    Friend WithEvents TKembali As Label
    Friend WithEvents TCariBarang As TextBox
    Friend WithEvents TCariJasa As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DGVBarang As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As DataGridViewTextBoxColumn
    Friend WithEvents DGVJasa As DataGridView
    Friend WithEvents Harga As DataGridViewTextBoxColumn
    Friend WithEvents TNamaAdmin As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
