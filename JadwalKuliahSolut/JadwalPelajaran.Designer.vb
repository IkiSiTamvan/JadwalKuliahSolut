<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JadwalPelajaran
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbHari = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbSemester = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbNamaKelas = New System.Windows.Forms.ComboBox()
        Me.cmbKelas = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbKeahlian = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbTahunAjar = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbGuru = New System.Windows.Forms.ListBox()
        Me.lbMapel = New System.Windows.Forms.ListBox()
        Me.lbWaktu = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbClear = New System.Windows.Forms.Button()
        Me.lvJadwalPelajaran = New System.Windows.Forms.ListView()
        Me.tampilJ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.namaGuruJ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.namaMapelJ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kelasJ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hariJ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pelajaranj = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmbSimpan = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lvMapel = New System.Windows.Forms.ListView()
        Me.nama = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kelas = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.semester = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.timeUnit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lvGM = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mapel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvGK = New System.Windows.Forms.ListView()
        Me.keahlian = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rbsemuaGuru = New System.Windows.Forms.RadioButton()
        Me.rbSesuaikanMapel = New System.Windows.Forms.RadioButton()
        Me.rbSesuaikanKeahlian = New System.Windows.Forms.RadioButton()
        Me.rbSesuaikanJadwal = New System.Windows.Forms.RadioButton()
        Me.lvGuru = New System.Windows.Forms.ListView()
        Me.namaGuru = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tampil = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.internal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idGuru = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hari = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFindGuru = New System.Windows.Forms.TextBox()
        Me.cmbFindByGuru = New System.Windows.Forms.ComboBox()
        Me.btnSaveExcel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbHari)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbSemester)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbNamaKelas)
        Me.GroupBox1.Controls.Add(Me.cmbKelas)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbKeahlian)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbTahunAjar)
        Me.GroupBox1.Location = New System.Drawing.Point(615, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(558, 81)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(489, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Hari"
        '
        'cmbHari
        '
        Me.cmbHari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHari.FormattingEnabled = True
        Me.cmbHari.Items.AddRange(New Object() {"Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu", "%"})
        Me.cmbHari.Location = New System.Drawing.Point(492, 46)
        Me.cmbHari.Name = "cmbHari"
        Me.cmbHari.Size = New System.Drawing.Size(54, 21)
        Me.cmbHari.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(428, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Semester"
        '
        'cmbSemester
        '
        Me.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSemester.FormattingEnabled = True
        Me.cmbSemester.Items.AddRange(New Object() {"1", "2"})
        Me.cmbSemester.Location = New System.Drawing.Point(431, 46)
        Me.cmbSemester.Name = "cmbSemester"
        Me.cmbSemester.Size = New System.Drawing.Size(55, 21)
        Me.cmbSemester.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(331, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nama Kelas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(288, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Kelas"
        '
        'cmbNamaKelas
        '
        Me.cmbNamaKelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNamaKelas.FormattingEnabled = True
        Me.cmbNamaKelas.Location = New System.Drawing.Point(334, 46)
        Me.cmbNamaKelas.Name = "cmbNamaKelas"
        Me.cmbNamaKelas.Size = New System.Drawing.Size(91, 21)
        Me.cmbNamaKelas.TabIndex = 5
        '
        'cmbKelas
        '
        Me.cmbKelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKelas.FormattingEnabled = True
        Me.cmbKelas.Items.AddRange(New Object() {"X", "XI", "XII"})
        Me.cmbKelas.Location = New System.Drawing.Point(291, 46)
        Me.cmbKelas.Name = "cmbKelas"
        Me.cmbKelas.Size = New System.Drawing.Size(37, 21)
        Me.cmbKelas.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Keahlian"
        '
        'cmbKeahlian
        '
        Me.cmbKeahlian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKeahlian.FormattingEnabled = True
        Me.cmbKeahlian.Location = New System.Drawing.Point(118, 46)
        Me.cmbKeahlian.Name = "cmbKeahlian"
        Me.cmbKeahlian.Size = New System.Drawing.Size(167, 21)
        Me.cmbKeahlian.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tahun Ajar"
        '
        'cmbTahunAjar
        '
        Me.cmbTahunAjar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTahunAjar.FormattingEnabled = True
        Me.cmbTahunAjar.Location = New System.Drawing.Point(6, 46)
        Me.cmbTahunAjar.Name = "cmbTahunAjar"
        Me.cmbTahunAjar.Size = New System.Drawing.Size(106, 21)
        Me.cmbTahunAjar.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSaveExcel)
        Me.GroupBox2.Controls.Add(Me.lbGuru)
        Me.GroupBox2.Controls.Add(Me.lbMapel)
        Me.GroupBox2.Controls.Add(Me.lbWaktu)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cmbClear)
        Me.GroupBox2.Controls.Add(Me.lvJadwalPelajaran)
        Me.GroupBox2.Controls.Add(Me.cmbSimpan)
        Me.GroupBox2.Location = New System.Drawing.Point(615, 100)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(558, 436)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Jadwal Pelajaran"
        '
        'lbGuru
        '
        Me.lbGuru.Enabled = False
        Me.lbGuru.FormattingEnabled = True
        Me.lbGuru.Location = New System.Drawing.Point(357, 45)
        Me.lbGuru.Name = "lbGuru"
        Me.lbGuru.Size = New System.Drawing.Size(103, 17)
        Me.lbGuru.TabIndex = 11
        '
        'lbMapel
        '
        Me.lbMapel.Enabled = False
        Me.lbMapel.FormattingEnabled = True
        Me.lbMapel.Location = New System.Drawing.Point(136, 45)
        Me.lbMapel.Name = "lbMapel"
        Me.lbMapel.Size = New System.Drawing.Size(215, 17)
        Me.lbMapel.TabIndex = 10
        '
        'lbWaktu
        '
        Me.lbWaktu.Enabled = False
        Me.lbWaktu.FormattingEnabled = True
        Me.lbWaktu.Location = New System.Drawing.Point(9, 45)
        Me.lbWaktu.Name = "lbWaktu"
        Me.lbWaktu.Size = New System.Drawing.Size(121, 17)
        Me.lbWaktu.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(354, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Guru"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(133, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Mata Pelajaran"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Waktu"
        '
        'cmbClear
        '
        Me.cmbClear.Location = New System.Drawing.Point(471, 403)
        Me.cmbClear.Name = "cmbClear"
        Me.cmbClear.Size = New System.Drawing.Size(71, 23)
        Me.cmbClear.TabIndex = 5
        Me.cmbClear.Text = "Clear "
        Me.cmbClear.UseVisualStyleBackColor = True
        '
        'lvJadwalPelajaran
        '
        Me.lvJadwalPelajaran.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.tampilJ, Me.namaGuruJ, Me.namaMapelJ, Me.kelasJ, Me.hariJ, Me.pelajaranj})
        Me.lvJadwalPelajaran.FullRowSelect = True
        Me.lvJadwalPelajaran.GridLines = True
        Me.lvJadwalPelajaran.HideSelection = False
        Me.lvJadwalPelajaran.Location = New System.Drawing.Point(9, 71)
        Me.lvJadwalPelajaran.Name = "lvJadwalPelajaran"
        Me.lvJadwalPelajaran.Size = New System.Drawing.Size(537, 326)
        Me.lvJadwalPelajaran.TabIndex = 4
        Me.lvJadwalPelajaran.UseCompatibleStateImageBehavior = False
        Me.lvJadwalPelajaran.View = System.Windows.Forms.View.Details
        '
        'tampilJ
        '
        Me.tampilJ.Text = "Tampil"
        '
        'namaGuruJ
        '
        Me.namaGuruJ.Text = "Guru"
        '
        'namaMapelJ
        '
        Me.namaMapelJ.Text = "Mapel"
        '
        'kelasJ
        '
        Me.kelasJ.Text = "Kelas"
        '
        'hariJ
        '
        Me.hariJ.Text = "Hari"
        '
        'pelajaranj
        '
        Me.pelajaranj.Text = "Pelajaran"
        '
        'cmbSimpan
        '
        Me.cmbSimpan.Location = New System.Drawing.Point(466, 42)
        Me.cmbSimpan.Name = "cmbSimpan"
        Me.cmbSimpan.Size = New System.Drawing.Size(75, 23)
        Me.cmbSimpan.TabIndex = 3
        Me.cmbSimpan.Text = "Simpan"
        Me.cmbSimpan.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lvMapel)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(597, 202)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mata Pelajaran"
        '
        'lvMapel
        '
        Me.lvMapel.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.nama, Me.kelas, Me.semester, Me.timeUnit, Me.id})
        Me.lvMapel.FullRowSelect = True
        Me.lvMapel.GridLines = True
        Me.lvMapel.HideSelection = False
        Me.lvMapel.Location = New System.Drawing.Point(6, 19)
        Me.lvMapel.Name = "lvMapel"
        Me.lvMapel.Size = New System.Drawing.Size(585, 177)
        Me.lvMapel.TabIndex = 0
        Me.lvMapel.UseCompatibleStateImageBehavior = False
        Me.lvMapel.View = System.Windows.Forms.View.Details
        '
        'nama
        '
        Me.nama.Text = "Nama"
        '
        'kelas
        '
        Me.kelas.Text = "Kelas"
        '
        'semester
        '
        Me.semester.Text = "Semester"
        '
        'timeUnit
        '
        Me.timeUnit.Text = "Time Unit"
        '
        'id
        '
        Me.id.Text = "id"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lvGM)
        Me.GroupBox4.Controls.Add(Me.lvGK)
        Me.GroupBox4.Controls.Add(Me.rbsemuaGuru)
        Me.GroupBox4.Controls.Add(Me.rbSesuaikanMapel)
        Me.GroupBox4.Controls.Add(Me.rbSesuaikanKeahlian)
        Me.GroupBox4.Controls.Add(Me.rbSesuaikanJadwal)
        Me.GroupBox4.Controls.Add(Me.lvGuru)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtFindGuru)
        Me.GroupBox4.Controls.Add(Me.cmbFindByGuru)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 220)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(597, 316)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Guru"
        '
        'lvGM
        '
        Me.lvGM.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.mapel})
        Me.lvGM.FullRowSelect = True
        Me.lvGM.GridLines = True
        Me.lvGM.HideSelection = False
        Me.lvGM.Location = New System.Drawing.Point(278, 164)
        Me.lvGM.Name = "lvGM"
        Me.lvGM.Size = New System.Drawing.Size(313, 139)
        Me.lvGM.TabIndex = 9
        Me.lvGM.UseCompatibleStateImageBehavior = False
        Me.lvGM.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Keahlian"
        '
        'mapel
        '
        Me.mapel.Text = "Mapel"
        '
        'lvGK
        '
        Me.lvGK.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.keahlian})
        Me.lvGK.FullRowSelect = True
        Me.lvGK.GridLines = True
        Me.lvGK.HideSelection = False
        Me.lvGK.Location = New System.Drawing.Point(278, 58)
        Me.lvGK.Name = "lvGK"
        Me.lvGK.Size = New System.Drawing.Size(313, 100)
        Me.lvGK.TabIndex = 8
        Me.lvGK.UseCompatibleStateImageBehavior = False
        Me.lvGK.View = System.Windows.Forms.View.Details
        '
        'keahlian
        '
        Me.keahlian.Text = "Keahlian"
        '
        'rbsemuaGuru
        '
        Me.rbsemuaGuru.AutoSize = True
        Me.rbsemuaGuru.Checked = True
        Me.rbsemuaGuru.Location = New System.Drawing.Point(343, 35)
        Me.rbsemuaGuru.Name = "rbsemuaGuru"
        Me.rbsemuaGuru.Size = New System.Drawing.Size(84, 17)
        Me.rbsemuaGuru.TabIndex = 7
        Me.rbsemuaGuru.TabStop = True
        Me.rbsemuaGuru.Text = "Semua Guru"
        Me.rbsemuaGuru.UseVisualStyleBackColor = True
        '
        'rbSesuaikanMapel
        '
        Me.rbSesuaikanMapel.AutoSize = True
        Me.rbSesuaikanMapel.Location = New System.Drawing.Point(343, 19)
        Me.rbSesuaikanMapel.Name = "rbSesuaikanMapel"
        Me.rbSesuaikanMapel.Size = New System.Drawing.Size(107, 17)
        Me.rbSesuaikanMapel.TabIndex = 6
        Me.rbSesuaikanMapel.TabStop = True
        Me.rbSesuaikanMapel.Text = "Sesuaikan Mapel"
        Me.rbSesuaikanMapel.UseVisualStyleBackColor = True
        '
        'rbSesuaikanKeahlian
        '
        Me.rbSesuaikanKeahlian.AutoSize = True
        Me.rbSesuaikanKeahlian.Location = New System.Drawing.Point(214, 35)
        Me.rbSesuaikanKeahlian.Name = "rbSesuaikanKeahlian"
        Me.rbSesuaikanKeahlian.Size = New System.Drawing.Size(119, 17)
        Me.rbSesuaikanKeahlian.TabIndex = 6
        Me.rbSesuaikanKeahlian.TabStop = True
        Me.rbSesuaikanKeahlian.Text = "Sesuaikan Keahlian"
        Me.rbSesuaikanKeahlian.UseVisualStyleBackColor = True
        '
        'rbSesuaikanJadwal
        '
        Me.rbSesuaikanJadwal.AutoSize = True
        Me.rbSesuaikanJadwal.Location = New System.Drawing.Point(214, 19)
        Me.rbSesuaikanJadwal.Name = "rbSesuaikanJadwal"
        Me.rbSesuaikanJadwal.Size = New System.Drawing.Size(111, 17)
        Me.rbSesuaikanJadwal.TabIndex = 5
        Me.rbSesuaikanJadwal.TabStop = True
        Me.rbSesuaikanJadwal.Text = "Sesuaikan Jadwal"
        Me.rbSesuaikanJadwal.UseVisualStyleBackColor = True
        '
        'lvGuru
        '
        Me.lvGuru.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.namaGuru, Me.tampil, Me.internal, Me.idGuru, Me.hari})
        Me.lvGuru.FullRowSelect = True
        Me.lvGuru.GridLines = True
        Me.lvGuru.HideSelection = False
        Me.lvGuru.Location = New System.Drawing.Point(6, 58)
        Me.lvGuru.Name = "lvGuru"
        Me.lvGuru.Size = New System.Drawing.Size(266, 245)
        Me.lvGuru.TabIndex = 4
        Me.lvGuru.UseCompatibleStateImageBehavior = False
        Me.lvGuru.View = System.Windows.Forms.View.Details
        '
        'namaGuru
        '
        Me.namaGuru.Text = "Nama"
        '
        'tampil
        '
        Me.tampil.Text = "Time"
        '
        'internal
        '
        Me.internal.Text = "Internal"
        '
        'idGuru
        '
        Me.idGuru.Text = "Id"
        '
        'hari
        '
        Me.hari.Text = "Hari"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(107, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Cari"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Cari dengan"
        '
        'txtFindGuru
        '
        Me.txtFindGuru.Location = New System.Drawing.Point(107, 32)
        Me.txtFindGuru.Name = "txtFindGuru"
        Me.txtFindGuru.Size = New System.Drawing.Size(100, 20)
        Me.txtFindGuru.TabIndex = 1
        '
        'cmbFindByGuru
        '
        Me.cmbFindByGuru.FormattingEnabled = True
        Me.cmbFindByGuru.Location = New System.Drawing.Point(6, 31)
        Me.cmbFindByGuru.Name = "cmbFindByGuru"
        Me.cmbFindByGuru.Size = New System.Drawing.Size(95, 21)
        Me.cmbFindByGuru.TabIndex = 0
        '
        'btnSaveExcel
        '
        Me.btnSaveExcel.Location = New System.Drawing.Point(373, 403)
        Me.btnSaveExcel.Name = "btnSaveExcel"
        Me.btnSaveExcel.Size = New System.Drawing.Size(87, 23)
        Me.btnSaveExcel.TabIndex = 12
        Me.btnSaveExcel.Text = "Save To Excel"
        Me.btnSaveExcel.UseVisualStyleBackColor = True
        '
        'JadwalPelajaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 545)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "JadwalPelajaran"
        Me.Text = "JadwalPelajaran"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbTahunAjar As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbSemester As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbNamaKelas As ComboBox
    Friend WithEvents cmbKelas As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbKeahlian As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbHari As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbSimpan As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbClear As Button
    Friend WithEvents lvJadwalPelajaran As ListView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lvMapel As ListView
    Friend WithEvents lvGuru As ListView
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtFindGuru As TextBox
    Friend WithEvents cmbFindByGuru As ComboBox
    Friend WithEvents rbsemuaGuru As RadioButton
    Friend WithEvents rbSesuaikanMapel As RadioButton
    Friend WithEvents rbSesuaikanKeahlian As RadioButton
    Friend WithEvents rbSesuaikanJadwal As RadioButton
    Friend WithEvents id As ColumnHeader
    Friend WithEvents nama As ColumnHeader
    Friend WithEvents kelas As ColumnHeader
    Friend WithEvents semester As ColumnHeader
    Friend WithEvents timeUnit As ColumnHeader
    Friend WithEvents namaGuru As ColumnHeader
    Friend WithEvents tampil As ColumnHeader
    Friend WithEvents internal As ColumnHeader
    Friend WithEvents idGuru As ColumnHeader
    Friend WithEvents hari As ColumnHeader
    Friend WithEvents lvGM As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents lvGK As ListView
    Friend WithEvents keahlian As ColumnHeader
    Friend WithEvents mapel As ColumnHeader
    Friend WithEvents tampilJ As ColumnHeader
    Friend WithEvents namaGuruJ As ColumnHeader
    Friend WithEvents namaMapelJ As ColumnHeader
    Friend WithEvents kelasJ As ColumnHeader
    Friend WithEvents hariJ As ColumnHeader
    Friend WithEvents lbGuru As ListBox
    Friend WithEvents lbMapel As ListBox
    Friend WithEvents lbWaktu As ListBox
    Friend WithEvents pelajaranj As ColumnHeader
    Friend WithEvents btnSaveExcel As Button
End Class
