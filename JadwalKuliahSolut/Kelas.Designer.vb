<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kelas
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
        Me.cmbKeahlian = New System.Windows.Forms.ComboBox()
        Me.cmbTahunAngkatan = New System.Windows.Forms.ComboBox()
        Me.lvKelas = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbTahunAjar = New System.Windows.Forms.ComboBox()
        Me.btnTambahKelas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNama
        '
        Me.txtNama.Enabled = False
        Me.txtNama.Location = New System.Drawing.Point(113, 51)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(138, 20)
        Me.txtNama.TabIndex = 0
        '
        'cmbKeahlian
        '
        Me.cmbKeahlian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKeahlian.FormattingEnabled = True
        Me.cmbKeahlian.Location = New System.Drawing.Point(113, 77)
        Me.cmbKeahlian.Name = "cmbKeahlian"
        Me.cmbKeahlian.Size = New System.Drawing.Size(247, 21)
        Me.cmbKeahlian.TabIndex = 1
        '
        'cmbTahunAngkatan
        '
        Me.cmbTahunAngkatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTahunAngkatan.FormattingEnabled = True
        Me.cmbTahunAngkatan.Location = New System.Drawing.Point(113, 131)
        Me.cmbTahunAngkatan.Name = "cmbTahunAngkatan"
        Me.cmbTahunAngkatan.Size = New System.Drawing.Size(138, 21)
        Me.cmbTahunAngkatan.TabIndex = 3
        '
        'lvKelas
        '
        Me.lvKelas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvKelas.FullRowSelect = True
        Me.lvKelas.HideSelection = False
        Me.lvKelas.Location = New System.Drawing.Point(15, 158)
        Me.lvKelas.Name = "lvKelas"
        Me.lvKelas.Size = New System.Drawing.Size(452, 183)
        Me.lvKelas.TabIndex = 4
        Me.lvKelas.UseCompatibleStateImageBehavior = False
        Me.lvKelas.View = System.Windows.Forms.View.Details
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
        Me.ColumnHeader3.Text = "Id Keahlian"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Keahlian"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Tahun Angkatan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Keahlian"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tahun Angkatan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tahun Ajar"
        '
        'cmbTahunAjar
        '
        Me.cmbTahunAjar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTahunAjar.FormattingEnabled = True
        Me.cmbTahunAjar.Location = New System.Drawing.Point(113, 104)
        Me.cmbTahunAjar.Name = "cmbTahunAjar"
        Me.cmbTahunAjar.Size = New System.Drawing.Size(138, 21)
        Me.cmbTahunAjar.TabIndex = 2
        '
        'btnTambahKelas
        '
        Me.btnTambahKelas.Location = New System.Drawing.Point(257, 48)
        Me.btnTambahKelas.Name = "btnTambahKelas"
        Me.btnTambahKelas.Size = New System.Drawing.Size(103, 23)
        Me.btnTambahKelas.TabIndex = 9
        Me.btnTambahKelas.Text = "Tambah Kelas"
        Me.btnTambahKelas.UseVisualStyleBackColor = True
        '
        'Kelas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 353)
        Me.Controls.Add(Me.btnTambahKelas)
        Me.Controls.Add(Me.cmbTahunAjar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvKelas)
        Me.Controls.Add(Me.cmbTahunAngkatan)
        Me.Controls.Add(Me.cmbKeahlian)
        Me.Controls.Add(Me.txtNama)
        Me.Name = "Kelas"
        Me.Text = "Kelas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNama As TextBox
    Friend WithEvents cmbKeahlian As ComboBox
    Friend WithEvents cmbTahunAngkatan As ComboBox
    Friend WithEvents lvKelas As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbTahunAjar As ComboBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents btnTambahKelas As Button
End Class
