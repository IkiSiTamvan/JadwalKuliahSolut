<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mapel
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
        Me.cmbKeahlian = New System.Windows.Forms.ComboBox()
        Me.cmbKelas = New System.Windows.Forms.ComboBox()
        Me.cmbSemester = New System.Windows.Forms.ComboBox()
        Me.lvMapel = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtNamaMapel = New System.Windows.Forms.TextBox()
        Me.cbButuhLab = New System.Windows.Forms.CheckBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.numTimeUnit = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotalTU = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.numTimeUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbTahunAjar
        '
        Me.cmbTahunAjar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTahunAjar.FormattingEnabled = True
        Me.cmbTahunAjar.Location = New System.Drawing.Point(12, 72)
        Me.cmbTahunAjar.Name = "cmbTahunAjar"
        Me.cmbTahunAjar.Size = New System.Drawing.Size(121, 21)
        Me.cmbTahunAjar.TabIndex = 0
        '
        'cmbKeahlian
        '
        Me.cmbKeahlian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKeahlian.FormattingEnabled = True
        Me.cmbKeahlian.Location = New System.Drawing.Point(139, 72)
        Me.cmbKeahlian.Name = "cmbKeahlian"
        Me.cmbKeahlian.Size = New System.Drawing.Size(396, 21)
        Me.cmbKeahlian.TabIndex = 1
        '
        'cmbKelas
        '
        Me.cmbKelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKelas.Items.AddRange(New Object() {"X", "XI", "XII"})
        Me.cmbKelas.Location = New System.Drawing.Point(541, 72)
        Me.cmbKelas.Name = "cmbKelas"
        Me.cmbKelas.Size = New System.Drawing.Size(55, 21)
        Me.cmbKelas.TabIndex = 2
        '
        'cmbSemester
        '
        Me.cmbSemester.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSemester.Items.AddRange(New Object() {"1", "2"})
        Me.cmbSemester.Location = New System.Drawing.Point(602, 72)
        Me.cmbSemester.Name = "cmbSemester"
        Me.cmbSemester.Size = New System.Drawing.Size(55, 21)
        Me.cmbSemester.TabIndex = 3
        '
        'lvMapel
        '
        Me.lvMapel.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lvMapel.FullRowSelect = True
        Me.lvMapel.GridLines = True
        Me.lvMapel.HideSelection = False
        Me.lvMapel.Location = New System.Drawing.Point(12, 99)
        Me.lvMapel.Name = "lvMapel"
        Me.lvMapel.Size = New System.Drawing.Size(645, 248)
        Me.lvMapel.TabIndex = 4
        Me.lvMapel.UseCompatibleStateImageBehavior = False
        Me.lvMapel.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Id"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Id Keahlian"
        Me.ColumnHeader3.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Keahlian"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Tahun Ajar"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Kelas"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Semester"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Time Unit"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Butuh Lab"
        '
        'txtNamaMapel
        '
        Me.txtNamaMapel.Location = New System.Drawing.Point(10, 42)
        Me.txtNamaMapel.Name = "txtNamaMapel"
        Me.txtNamaMapel.Size = New System.Drawing.Size(341, 20)
        Me.txtNamaMapel.TabIndex = 5
        '
        'cbButuhLab
        '
        Me.cbButuhLab.AutoSize = True
        Me.cbButuhLab.Location = New System.Drawing.Point(458, 44)
        Me.cbButuhLab.Name = "cbButuhLab"
        Me.cbButuhLab.Size = New System.Drawing.Size(75, 17)
        Me.cbButuhLab.TabIndex = 7
        Me.cbButuhLab.Text = "Butuh Lab"
        Me.cbButuhLab.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(556, 40)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 8
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(556, 11)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 9
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Tahun Ajar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Keahlian"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(538, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Kelas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(599, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Semester"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Nama Mata Pelajaran"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(353, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Time Unit"
        '
        'numTimeUnit
        '
        Me.numTimeUnit.Location = New System.Drawing.Point(356, 41)
        Me.numTimeUnit.Name = "numTimeUnit"
        Me.numTimeUnit.Size = New System.Drawing.Size(96, 20)
        Me.numTimeUnit.TabIndex = 6
        Me.numTimeUnit.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(472, 355)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Total Time Unit"
        '
        'txtTotalTU
        '
        Me.txtTotalTU.Enabled = False
        Me.txtTotalTU.Location = New System.Drawing.Point(557, 352)
        Me.txtTotalTU.Name = "txtTotalTU"
        Me.txtTotalTU.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalTU.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalTU.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNamaMapel)
        Me.GroupBox1.Controls.Add(Me.cbButuhLab)
        Me.GroupBox1.Controls.Add(Me.btnSimpan)
        Me.GroupBox1.Controls.Add(Me.numTimeUnit)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 373)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(645, 73)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'Mapel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 455)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtTotalTU)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvMapel)
        Me.Controls.Add(Me.cmbSemester)
        Me.Controls.Add(Me.cmbKelas)
        Me.Controls.Add(Me.cmbKeahlian)
        Me.Controls.Add(Me.cmbTahunAjar)
        Me.Name = "Mapel"
        Me.Text = "FormMapel"
        CType(Me.numTimeUnit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbTahunAjar As ComboBox
    Friend WithEvents cmbKeahlian As ComboBox
    Friend WithEvents cmbKelas As ComboBox
    Friend WithEvents cmbSemester As ComboBox
    Friend WithEvents lvMapel As ListView
    Friend WithEvents txtNamaMapel As TextBox
    Friend WithEvents cbButuhLab As CheckBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents numTimeUnit As NumericUpDown
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTotalTU As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
