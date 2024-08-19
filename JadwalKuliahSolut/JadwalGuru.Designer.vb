<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JadwalGuru
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
        Me.cmbTahunAjar = New System.Windows.Forms.ComboBox()
        Me.cmbFind = New System.Windows.Forms.ComboBox()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.LvGuru = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtIdGuru = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.clbSenin = New System.Windows.Forms.CheckedListBox()
        Me.clbSelasa = New System.Windows.Forms.CheckedListBox()
        Me.clbRabu = New System.Windows.Forms.CheckedListBox()
        Me.clbKamis = New System.Windows.Forms.CheckedListBox()
        Me.clbJumat = New System.Windows.Forms.CheckedListBox()
        Me.clbSabtu = New System.Windows.Forms.CheckedListBox()
        Me.clbMinggu = New System.Windows.Forms.CheckedListBox()
        Me.cbSenin = New System.Windows.Forms.CheckBox()
        Me.cbSelasa = New System.Windows.Forms.CheckBox()
        Me.cbRabu = New System.Windows.Forms.CheckBox()
        Me.cbKamis = New System.Windows.Forms.CheckBox()
        Me.cbJumat = New System.Windows.Forms.CheckBox()
        Me.cbSabtu = New System.Windows.Forms.CheckBox()
        Me.cbMinggu = New System.Windows.Forms.CheckBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.cbAlways = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'cmbTahunAjar
        '
        Me.cmbTahunAjar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTahunAjar.FormattingEnabled = True
        Me.cmbTahunAjar.Location = New System.Drawing.Point(109, 11)
        Me.cmbTahunAjar.Name = "cmbTahunAjar"
        Me.cmbTahunAjar.Size = New System.Drawing.Size(121, 21)
        Me.cmbTahunAjar.TabIndex = 0
        '
        'cmbFind
        '
        Me.cmbFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFind.FormattingEnabled = True
        Me.cmbFind.Items.AddRange(New Object() {"Nama", "Email", "Aktif", "Internal"})
        Me.cmbFind.Location = New System.Drawing.Point(109, 38)
        Me.cmbFind.Name = "cmbFind"
        Me.cmbFind.Size = New System.Drawing.Size(121, 21)
        Me.cmbFind.TabIndex = 1
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(109, 65)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(121, 20)
        Me.txtFind.TabIndex = 2
        '
        'LvGuru
        '
        Me.LvGuru.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.LvGuru.FullRowSelect = True
        Me.LvGuru.HideSelection = False
        Me.LvGuru.Location = New System.Drawing.Point(250, 11)
        Me.LvGuru.Name = "LvGuru"
        Me.LvGuru.Size = New System.Drawing.Size(538, 165)
        Me.LvGuru.TabIndex = 3
        Me.LvGuru.UseCompatibleStateImageBehavior = False
        Me.LvGuru.View = System.Windows.Forms.View.Details
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
        'txtIdGuru
        '
        Me.txtIdGuru.Enabled = False
        Me.txtIdGuru.Location = New System.Drawing.Point(109, 130)
        Me.txtIdGuru.Name = "txtIdGuru"
        Me.txtIdGuru.Size = New System.Drawing.Size(121, 20)
        Me.txtIdGuru.TabIndex = 4
        '
        'txtNama
        '
        Me.txtNama.Enabled = False
        Me.txtNama.Location = New System.Drawing.Point(109, 156)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(121, 20)
        Me.txtNama.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Tahun Ajar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cari Berdasarkan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cari"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Id Guru"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Nama"
        '
        'clbSenin
        '
        Me.clbSenin.CheckOnClick = True
        Me.clbSenin.FormattingEnabled = True
        Me.clbSenin.Location = New System.Drawing.Point(12, 218)
        Me.clbSenin.Name = "clbSenin"
        Me.clbSenin.Size = New System.Drawing.Size(115, 169)
        Me.clbSenin.TabIndex = 11
        '
        'clbSelasa
        '
        Me.clbSelasa.CheckOnClick = True
        Me.clbSelasa.FormattingEnabled = True
        Me.clbSelasa.Location = New System.Drawing.Point(133, 218)
        Me.clbSelasa.Name = "clbSelasa"
        Me.clbSelasa.Size = New System.Drawing.Size(115, 169)
        Me.clbSelasa.TabIndex = 12
        '
        'clbRabu
        '
        Me.clbRabu.CheckOnClick = True
        Me.clbRabu.FormattingEnabled = True
        Me.clbRabu.Location = New System.Drawing.Point(254, 218)
        Me.clbRabu.Name = "clbRabu"
        Me.clbRabu.Size = New System.Drawing.Size(115, 169)
        Me.clbRabu.TabIndex = 13
        '
        'clbKamis
        '
        Me.clbKamis.CheckOnClick = True
        Me.clbKamis.FormattingEnabled = True
        Me.clbKamis.Location = New System.Drawing.Point(375, 218)
        Me.clbKamis.Name = "clbKamis"
        Me.clbKamis.Size = New System.Drawing.Size(115, 169)
        Me.clbKamis.TabIndex = 14
        '
        'clbJumat
        '
        Me.clbJumat.CheckOnClick = True
        Me.clbJumat.FormattingEnabled = True
        Me.clbJumat.Location = New System.Drawing.Point(496, 218)
        Me.clbJumat.Name = "clbJumat"
        Me.clbJumat.Size = New System.Drawing.Size(115, 169)
        Me.clbJumat.TabIndex = 15
        '
        'clbSabtu
        '
        Me.clbSabtu.CheckOnClick = True
        Me.clbSabtu.FormattingEnabled = True
        Me.clbSabtu.Location = New System.Drawing.Point(617, 218)
        Me.clbSabtu.Name = "clbSabtu"
        Me.clbSabtu.Size = New System.Drawing.Size(115, 169)
        Me.clbSabtu.TabIndex = 16
        '
        'clbMinggu
        '
        Me.clbMinggu.CheckOnClick = True
        Me.clbMinggu.FormattingEnabled = True
        Me.clbMinggu.Location = New System.Drawing.Point(738, 218)
        Me.clbMinggu.Name = "clbMinggu"
        Me.clbMinggu.Size = New System.Drawing.Size(115, 169)
        Me.clbMinggu.TabIndex = 17
        '
        'cbSenin
        '
        Me.cbSenin.AutoSize = True
        Me.cbSenin.Location = New System.Drawing.Point(12, 195)
        Me.cbSenin.Name = "cbSenin"
        Me.cbSenin.Size = New System.Drawing.Size(77, 17)
        Me.cbSenin.TabIndex = 18
        Me.cbSenin.Text = "Senin Siap"
        Me.cbSenin.UseVisualStyleBackColor = True
        '
        'cbSelasa
        '
        Me.cbSelasa.AutoSize = True
        Me.cbSelasa.Location = New System.Drawing.Point(133, 195)
        Me.cbSelasa.Name = "cbSelasa"
        Me.cbSelasa.Size = New System.Drawing.Size(82, 17)
        Me.cbSelasa.TabIndex = 19
        Me.cbSelasa.Text = "Selasa Siap"
        Me.cbSelasa.UseVisualStyleBackColor = True
        '
        'cbRabu
        '
        Me.cbRabu.AutoSize = True
        Me.cbRabu.Location = New System.Drawing.Point(254, 195)
        Me.cbRabu.Name = "cbRabu"
        Me.cbRabu.Size = New System.Drawing.Size(76, 17)
        Me.cbRabu.TabIndex = 20
        Me.cbRabu.Text = "Rabu Siap"
        Me.cbRabu.UseVisualStyleBackColor = True
        '
        'cbKamis
        '
        Me.cbKamis.AutoSize = True
        Me.cbKamis.Location = New System.Drawing.Point(375, 195)
        Me.cbKamis.Name = "cbKamis"
        Me.cbKamis.Size = New System.Drawing.Size(78, 17)
        Me.cbKamis.TabIndex = 21
        Me.cbKamis.Text = "Kamis Siap"
        Me.cbKamis.UseVisualStyleBackColor = True
        '
        'cbJumat
        '
        Me.cbJumat.AutoSize = True
        Me.cbJumat.Location = New System.Drawing.Point(496, 195)
        Me.cbJumat.Name = "cbJumat"
        Me.cbJumat.Size = New System.Drawing.Size(78, 17)
        Me.cbJumat.TabIndex = 22
        Me.cbJumat.Text = "Jumat Siap"
        Me.cbJumat.UseVisualStyleBackColor = True
        '
        'cbSabtu
        '
        Me.cbSabtu.AutoSize = True
        Me.cbSabtu.Location = New System.Drawing.Point(617, 195)
        Me.cbSabtu.Name = "cbSabtu"
        Me.cbSabtu.Size = New System.Drawing.Size(78, 17)
        Me.cbSabtu.TabIndex = 23
        Me.cbSabtu.Text = "Sabtu Siap"
        Me.cbSabtu.UseVisualStyleBackColor = True
        '
        'cbMinggu
        '
        Me.cbMinggu.AutoSize = True
        Me.cbMinggu.Location = New System.Drawing.Point(738, 195)
        Me.cbMinggu.Name = "cbMinggu"
        Me.cbMinggu.Size = New System.Drawing.Size(85, 17)
        Me.cbMinggu.TabIndex = 24
        Me.cbMinggu.Text = "Minggu Siap"
        Me.cbMinggu.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(859, 365)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(69, 23)
        Me.btnSimpan.TabIndex = 26
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'cbAlways
        '
        Me.cbAlways.AutoSize = True
        Me.cbAlways.Location = New System.Drawing.Point(859, 342)
        Me.cbAlways.Name = "cbAlways"
        Me.cbAlways.Size = New System.Drawing.Size(79, 17)
        Me.cbAlways.TabIndex = 27
        Me.cbAlways.Text = "Selalu Siap"
        Me.cbAlways.UseVisualStyleBackColor = True
        '
        'JadwalGuru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 395)
        Me.Controls.Add(Me.cbAlways)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.cbMinggu)
        Me.Controls.Add(Me.cbSabtu)
        Me.Controls.Add(Me.cbJumat)
        Me.Controls.Add(Me.cbKamis)
        Me.Controls.Add(Me.cbRabu)
        Me.Controls.Add(Me.cbSelasa)
        Me.Controls.Add(Me.cbSenin)
        Me.Controls.Add(Me.clbMinggu)
        Me.Controls.Add(Me.clbSabtu)
        Me.Controls.Add(Me.clbJumat)
        Me.Controls.Add(Me.clbKamis)
        Me.Controls.Add(Me.clbRabu)
        Me.Controls.Add(Me.clbSelasa)
        Me.Controls.Add(Me.clbSenin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtIdGuru)
        Me.Controls.Add(Me.LvGuru)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.cmbFind)
        Me.Controls.Add(Me.cmbTahunAjar)
        Me.Name = "JadwalGuru"
        Me.Text = "JadwalGuru"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbTahunAjar As ComboBox
    Friend WithEvents cmbFind As ComboBox
    Friend WithEvents txtFind As TextBox
    Friend WithEvents LvGuru As ListView
    Friend WithEvents txtIdGuru As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents clbSenin As CheckedListBox
    Friend WithEvents clbSelasa As CheckedListBox
    Friend WithEvents clbRabu As CheckedListBox
    Friend WithEvents clbKamis As CheckedListBox
    Friend WithEvents clbJumat As CheckedListBox
    Friend WithEvents clbSabtu As CheckedListBox
    Friend WithEvents clbMinggu As CheckedListBox
    Friend WithEvents cbSenin As CheckBox
    Friend WithEvents cbSelasa As CheckBox
    Friend WithEvents cbRabu As CheckBox
    Friend WithEvents cbKamis As CheckBox
    Friend WithEvents cbJumat As CheckBox
    Friend WithEvents cbSabtu As CheckBox
    Friend WithEvents cbMinggu As CheckBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents cbAlways As CheckBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
End Class
