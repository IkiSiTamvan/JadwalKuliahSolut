<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guru
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
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtNoTelpon = New System.Windows.Forms.TextBox()
        Me.cmbKeahlian = New System.Windows.Forms.ComboBox()
        Me.btnTambahKeahlian = New System.Windows.Forms.Button()
        Me.cmbMapel = New System.Windows.Forms.ComboBox()
        Me.btnTambahMapel = New System.Windows.Forms.Button()
        Me.lvGuru = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cbGuruInternal = New System.Windows.Forms.CheckBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnHapusKeahlian = New System.Windows.Forms.Button()
        Me.lvKeahlian = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbTahunAjar = New System.Windows.Forms.ComboBox()
        Me.lvMapel = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnHapusMapel = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbAktif = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(7, 40)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(200, 20)
        Me.txtNama.TabIndex = 0
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(213, 40)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 20)
        Me.txtEmail.TabIndex = 1
        '
        'txtNoTelpon
        '
        Me.txtNoTelpon.Location = New System.Drawing.Point(419, 40)
        Me.txtNoTelpon.Name = "txtNoTelpon"
        Me.txtNoTelpon.Size = New System.Drawing.Size(200, 20)
        Me.txtNoTelpon.TabIndex = 2
        '
        'cmbKeahlian
        '
        Me.cmbKeahlian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKeahlian.FormattingEnabled = True
        Me.cmbKeahlian.Location = New System.Drawing.Point(6, 19)
        Me.cmbKeahlian.Name = "cmbKeahlian"
        Me.cmbKeahlian.Size = New System.Drawing.Size(159, 21)
        Me.cmbKeahlian.TabIndex = 3
        '
        'btnTambahKeahlian
        '
        Me.btnTambahKeahlian.Location = New System.Drawing.Point(174, 19)
        Me.btnTambahKeahlian.Name = "btnTambahKeahlian"
        Me.btnTambahKeahlian.Size = New System.Drawing.Size(75, 23)
        Me.btnTambahKeahlian.TabIndex = 5
        Me.btnTambahKeahlian.Text = "Tambah"
        Me.btnTambahKeahlian.UseVisualStyleBackColor = True
        '
        'cmbMapel
        '
        Me.cmbMapel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMapel.FormattingEnabled = True
        Me.cmbMapel.Location = New System.Drawing.Point(87, 19)
        Me.cmbMapel.Name = "cmbMapel"
        Me.cmbMapel.Size = New System.Drawing.Size(211, 21)
        Me.cmbMapel.TabIndex = 6
        '
        'btnTambahMapel
        '
        Me.btnTambahMapel.Location = New System.Drawing.Point(304, 17)
        Me.btnTambahMapel.Name = "btnTambahMapel"
        Me.btnTambahMapel.Size = New System.Drawing.Size(54, 23)
        Me.btnTambahMapel.TabIndex = 8
        Me.btnTambahMapel.Text = "Tambah"
        Me.btnTambahMapel.UseVisualStyleBackColor = True
        '
        'lvGuru
        '
        Me.lvGuru.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvGuru.FullRowSelect = True
        Me.lvGuru.HideSelection = False
        Me.lvGuru.Location = New System.Drawing.Point(6, 95)
        Me.lvGuru.Name = "lvGuru"
        Me.lvGuru.Size = New System.Drawing.Size(613, 161)
        Me.lvGuru.TabIndex = 9
        Me.lvGuru.UseCompatibleStateImageBehavior = False
        Me.lvGuru.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Email"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "No Telpon"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Internal"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Aktif"
        '
        'cbGuruInternal
        '
        Me.cbGuruInternal.AutoSize = True
        Me.cbGuruInternal.Location = New System.Drawing.Point(398, 70)
        Me.cbGuruInternal.Name = "cbGuruInternal"
        Me.cbGuruInternal.Size = New System.Drawing.Size(87, 17)
        Me.cbGuruInternal.TabIndex = 10
        Me.cbGuruInternal.Text = "Guru Internal"
        Me.cbGuruInternal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(544, 66)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 3
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(210, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(416, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "No Telpon"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnHapusKeahlian)
        Me.GroupBox1.Controls.Add(Me.lvKeahlian)
        Me.GroupBox1.Controls.Add(Me.btnTambahKeahlian)
        Me.GroupBox1.Controls.Add(Me.cmbKeahlian)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 302)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(255, 177)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Keahlian Guru"
        '
        'btnHapusKeahlian
        '
        Me.btnHapusKeahlian.Location = New System.Drawing.Point(6, 148)
        Me.btnHapusKeahlian.Name = "btnHapusKeahlian"
        Me.btnHapusKeahlian.Size = New System.Drawing.Size(75, 23)
        Me.btnHapusKeahlian.TabIndex = 7
        Me.btnHapusKeahlian.Text = "Hapus"
        Me.btnHapusKeahlian.UseVisualStyleBackColor = True
        '
        'lvKeahlian
        '
        Me.lvKeahlian.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lvKeahlian.FullRowSelect = True
        Me.lvKeahlian.HideSelection = False
        Me.lvKeahlian.Location = New System.Drawing.Point(6, 48)
        Me.lvKeahlian.Name = "lvKeahlian"
        Me.lvKeahlian.Size = New System.Drawing.Size(243, 97)
        Me.lvKeahlian.TabIndex = 6
        Me.lvKeahlian.UseCompatibleStateImageBehavior = False
        Me.lvKeahlian.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "id"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Keahlian"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbTahunAjar)
        Me.GroupBox2.Controls.Add(Me.lvMapel)
        Me.GroupBox2.Controls.Add(Me.btnHapusMapel)
        Me.GroupBox2.Controls.Add(Me.btnTambahMapel)
        Me.GroupBox2.Controls.Add(Me.cmbMapel)
        Me.GroupBox2.Location = New System.Drawing.Point(274, 302)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(368, 177)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mata Pelajaran Guru"
        '
        'cmbTahunAjar
        '
        Me.cmbTahunAjar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTahunAjar.FormattingEnabled = True
        Me.cmbTahunAjar.Location = New System.Drawing.Point(8, 19)
        Me.cmbTahunAjar.Name = "cmbTahunAjar"
        Me.cmbTahunAjar.Size = New System.Drawing.Size(73, 21)
        Me.cmbTahunAjar.TabIndex = 21
        '
        'lvMapel
        '
        Me.lvMapel.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.lvMapel.FullRowSelect = True
        Me.lvMapel.HideSelection = False
        Me.lvMapel.Location = New System.Drawing.Point(8, 48)
        Me.lvMapel.Name = "lvMapel"
        Me.lvMapel.Size = New System.Drawing.Size(350, 97)
        Me.lvMapel.TabIndex = 20
        Me.lvMapel.UseCompatibleStateImageBehavior = False
        Me.lvMapel.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "id"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Mapel"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Keahlian"
        '
        'btnHapusMapel
        '
        Me.btnHapusMapel.Location = New System.Drawing.Point(6, 148)
        Me.btnHapusMapel.Name = "btnHapusMapel"
        Me.btnHapusMapel.Size = New System.Drawing.Size(75, 23)
        Me.btnHapusMapel.TabIndex = 19
        Me.btnHapusMapel.Text = "Hapus"
        Me.btnHapusMapel.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbAktif)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.btnSimpan)
        Me.GroupBox3.Controls.Add(Me.cbGuruInternal)
        Me.GroupBox3.Controls.Add(Me.lvGuru)
        Me.GroupBox3.Controls.Add(Me.txtNoTelpon)
        Me.GroupBox3.Controls.Add(Me.txtEmail)
        Me.GroupBox3.Controls.Add(Me.txtNama)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 34)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(629, 262)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Guru"
        '
        'cbAktif
        '
        Me.cbAktif.AutoSize = True
        Me.cbAktif.Location = New System.Drawing.Point(491, 70)
        Me.cbAktif.Name = "cbAktif"
        Me.cbAktif.Size = New System.Drawing.Size(47, 17)
        Me.cbAktif.TabIndex = 15
        Me.cbAktif.Text = "Aktif"
        Me.cbAktif.UseVisualStyleBackColor = True
        '
        'Guru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 491)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Guru"
        Me.Text = "Guru"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtNoTelpon As TextBox
    Friend WithEvents cmbKeahlian As ComboBox
    Friend WithEvents btnTambahKeahlian As Button
    Friend WithEvents cmbMapel As ComboBox
    Friend WithEvents btnTambahMapel As Button
    Friend WithEvents lvGuru As ListView
    Friend WithEvents cbGuruInternal As CheckBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbAktif As CheckBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents lvKeahlian As ListView
    Friend WithEvents btnHapusKeahlian As Button
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents btnHapusMapel As Button
    Friend WithEvents lvMapel As ListView
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents cmbTahunAjar As ComboBox
End Class
