<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeTable
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
        Me.cmbHari = New System.Windows.Forms.ComboBox()
        Me.txtNamaKegiatan = New System.Windows.Forms.TextBox()
        Me.cbPelajaran = New System.Windows.Forms.CheckBox()
        Me.dtpMulai = New System.Windows.Forms.DateTimePicker()
        Me.numMenit = New System.Windows.Forms.NumericUpDown()
        Me.dtpBerakhir = New System.Windows.Forms.DateTimePicker()
        Me.cmbTahunAjar = New System.Windows.Forms.ComboBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.lvTimeTable = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnHapusTerakhir = New System.Windows.Forms.Button()
        Me.btnHapusHari = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.numMenit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbHari
        '
        Me.cmbHari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHari.FormattingEnabled = True
        Me.cmbHari.Items.AddRange(New Object() {"Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu", "%"})
        Me.cmbHari.Location = New System.Drawing.Point(147, 99)
        Me.cmbHari.Name = "cmbHari"
        Me.cmbHari.Size = New System.Drawing.Size(79, 21)
        Me.cmbHari.TabIndex = 1
        '
        'txtNamaKegiatan
        '
        Me.txtNamaKegiatan.Location = New System.Drawing.Point(314, 99)
        Me.txtNamaKegiatan.Name = "txtNamaKegiatan"
        Me.txtNamaKegiatan.Size = New System.Drawing.Size(170, 20)
        Me.txtNamaKegiatan.TabIndex = 3
        '
        'cbPelajaran
        '
        Me.cbPelajaran.AutoSize = True
        Me.cbPelajaran.Location = New System.Drawing.Point(232, 102)
        Me.cbPelajaran.Name = "cbPelajaran"
        Me.cbPelajaran.Size = New System.Drawing.Size(70, 17)
        Me.cbPelajaran.TabIndex = 2
        Me.cbPelajaran.Text = "Pelajaran"
        Me.cbPelajaran.UseVisualStyleBackColor = True
        '
        'dtpMulai
        '
        Me.dtpMulai.Enabled = False
        Me.dtpMulai.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpMulai.Location = New System.Drawing.Point(490, 99)
        Me.dtpMulai.Name = "dtpMulai"
        Me.dtpMulai.ShowUpDown = True
        Me.dtpMulai.Size = New System.Drawing.Size(68, 20)
        Me.dtpMulai.TabIndex = 4
        Me.dtpMulai.Value = New Date(2024, 5, 26, 7, 0, 0, 0)
        '
        'numMenit
        '
        Me.numMenit.Location = New System.Drawing.Point(565, 99)
        Me.numMenit.Name = "numMenit"
        Me.numMenit.Size = New System.Drawing.Size(55, 20)
        Me.numMenit.TabIndex = 5
        '
        'dtpBerakhir
        '
        Me.dtpBerakhir.Enabled = False
        Me.dtpBerakhir.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpBerakhir.Location = New System.Drawing.Point(626, 99)
        Me.dtpBerakhir.Name = "dtpBerakhir"
        Me.dtpBerakhir.ShowUpDown = True
        Me.dtpBerakhir.Size = New System.Drawing.Size(70, 20)
        Me.dtpBerakhir.TabIndex = 6
        Me.dtpBerakhir.Value = New Date(2024, 5, 26, 0, 0, 0, 0)
        '
        'cmbTahunAjar
        '
        Me.cmbTahunAjar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTahunAjar.FormattingEnabled = True
        Me.cmbTahunAjar.Location = New System.Drawing.Point(20, 99)
        Me.cmbTahunAjar.Name = "cmbTahunAjar"
        Me.cmbTahunAjar.Size = New System.Drawing.Size(121, 21)
        Me.cmbTahunAjar.TabIndex = 0
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(702, 98)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 7
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'lvTimeTable
        '
        Me.lvTimeTable.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lvTimeTable.FullRowSelect = True
        Me.lvTimeTable.HideSelection = False
        Me.lvTimeTable.Location = New System.Drawing.Point(20, 126)
        Me.lvTimeTable.Name = "lvTimeTable"
        Me.lvTimeTable.Size = New System.Drawing.Size(757, 289)
        Me.lvTimeTable.TabIndex = 8
        Me.lvTimeTable.UseCompatibleStateImageBehavior = False
        Me.lvTimeTable.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Hari"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nama"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Urutan"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Mulai"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Menit"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Akhir"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Tampilan"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Pelajaran"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Tahun Ajar"
        '
        'btnHapusTerakhir
        '
        Me.btnHapusTerakhir.Location = New System.Drawing.Point(551, 421)
        Me.btnHapusTerakhir.Name = "btnHapusTerakhir"
        Me.btnHapusTerakhir.Size = New System.Drawing.Size(132, 23)
        Me.btnHapusTerakhir.TabIndex = 9
        Me.btnHapusTerakhir.Text = "Hapus Jadwal Terakhir"
        Me.btnHapusTerakhir.UseVisualStyleBackColor = True
        '
        'btnHapusHari
        '
        Me.btnHapusHari.Location = New System.Drawing.Point(688, 421)
        Me.btnHapusHari.Name = "btnHapusHari"
        Me.btnHapusHari.Size = New System.Drawing.Size(88, 23)
        Me.btnHapusHari.TabIndex = 10
        Me.btnHapusHari.Text = "Hapus Hari Ini"
        Me.btnHapusHari.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Tahun Ajaran"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(144, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Hari"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(311, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Nama Kegiatan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(487, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Mulai"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(562, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Menit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(623, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Berakhir"
        '
        'TimeTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 459)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnHapusHari)
        Me.Controls.Add(Me.btnHapusTerakhir)
        Me.Controls.Add(Me.lvTimeTable)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.cmbTahunAjar)
        Me.Controls.Add(Me.dtpBerakhir)
        Me.Controls.Add(Me.numMenit)
        Me.Controls.Add(Me.dtpMulai)
        Me.Controls.Add(Me.cbPelajaran)
        Me.Controls.Add(Me.txtNamaKegiatan)
        Me.Controls.Add(Me.cmbHari)
        Me.Name = "TimeTable"
        Me.Text = "Rangka Jadwal"
        CType(Me.numMenit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbHari As ComboBox
    Friend WithEvents txtNamaKegiatan As TextBox
    Friend WithEvents cbPelajaran As CheckBox
    Friend WithEvents dtpMulai As DateTimePicker
    Friend WithEvents numMenit As NumericUpDown
    Friend WithEvents dtpBerakhir As DateTimePicker
    Friend WithEvents cmbTahunAjar As ComboBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents lvTimeTable As ListView
    Friend WithEvents btnHapusTerakhir As Button
    Friend WithEvents btnHapusHari As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
End Class
