<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterDosen
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmdTemukan = New System.Windows.Forms.Button
        Me.cmdDefault = New System.Windows.Forms.Button
        Me.cmbTemukan = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdAmbil = New System.Windows.Forms.Button
        Me.cmdSubmit = New System.Windows.Forms.Button
        Me.txtNamaDosen = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbKompetensi = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtIdDosen = New System.Windows.Forms.TextBox
        Me.txtNoTelepon = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtAlamatEMail = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Catatan = New System.Windows.Forms.Label
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(809, 49)
        Me.GroupBox4.TabIndex = 32
        Me.GroupBox4.TabStop = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(798, 26)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Form Master Dosen"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.cmdTemukan)
        Me.GroupBox3.Controls.Add(Me.cmdDefault)
        Me.GroupBox3.Controls.Add(Me.cmbTemukan)
        Me.GroupBox3.Location = New System.Drawing.Point(385, 434)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(432, 50)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(87, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Temukan Dengan :"
        '
        'cmdTemukan
        '
        Me.cmdTemukan.Location = New System.Drawing.Point(349, 12)
        Me.cmdTemukan.Name = "cmdTemukan"
        Me.cmdTemukan.Size = New System.Drawing.Size(80, 30)
        Me.cmdTemukan.TabIndex = 8
        Me.cmdTemukan.Text = "Temukan"
        Me.cmdTemukan.UseVisualStyleBackColor = True
        '
        'cmdDefault
        '
        Me.cmdDefault.Location = New System.Drawing.Point(6, 12)
        Me.cmdDefault.Name = "cmdDefault"
        Me.cmdDefault.Size = New System.Drawing.Size(75, 30)
        Me.cmdDefault.TabIndex = 6
        Me.cmdDefault.Text = "Default"
        Me.cmdDefault.UseVisualStyleBackColor = True
        '
        'cmbTemukan
        '
        Me.cmbTemukan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTemukan.FormattingEnabled = True
        Me.cmbTemukan.Items.AddRange(New Object() {"IdDosen", "NamaDosen", "Kompetensi", "NoTelepon", "AlamatE_Mail"})
        Me.cmbTemukan.Location = New System.Drawing.Point(208, 12)
        Me.cmbTemukan.Name = "cmbTemukan"
        Me.cmbTemukan.Size = New System.Drawing.Size(134, 24)
        Me.cmbTemukan.TabIndex = 7
        Me.cmbTemukan.Text = "IdDosen"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdAmbil)
        Me.GroupBox2.Controls.Add(Me.cmdSubmit)
        Me.GroupBox2.Controls.Add(Me.txtNamaDosen)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cmbKompetensi)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtIdDosen)
        Me.GroupBox2.Controls.Add(Me.txtNoTelepon)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtAlamatEMail)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 353)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(808, 140)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        '
        'cmdAmbil
        '
        Me.cmdAmbil.Location = New System.Drawing.Point(714, 49)
        Me.cmdAmbil.Name = "cmdAmbil"
        Me.cmdAmbil.Size = New System.Drawing.Size(88, 30)
        Me.cmdAmbil.TabIndex = 21
        Me.cmdAmbil.Text = "Ambil Data"
        Me.cmdAmbil.UseVisualStyleBackColor = True
        Me.cmdAmbil.Visible = False
        '
        'cmdSubmit
        '
        Me.cmdSubmit.Location = New System.Drawing.Point(564, 48)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(75, 30)
        Me.cmdSubmit.TabIndex = 5
        Me.cmdSubmit.Text = "Submit"
        Me.cmdSubmit.UseVisualStyleBackColor = True
        '
        'txtNamaDosen
        '
        Me.txtNamaDosen.Location = New System.Drawing.Point(107, 23)
        Me.txtNamaDosen.Name = "txtNamaDosen"
        Me.txtNamaDosen.Size = New System.Drawing.Size(233, 20)
        Me.txtNamaDosen.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nama Dosen"
        '
        'cmbKompetensi
        '
        Me.cmbKompetensi.FormattingEnabled = True
        Me.cmbKompetensi.Items.AddRange(New Object() {"Akuntansi", "Manajemen", "Komputer", "Desktop Programming", "Web Programming", "Bahasa"})
        Me.cmbKompetensi.Location = New System.Drawing.Point(107, 49)
        Me.cmbKompetensi.Name = "cmbKompetensi"
        Me.cmbKompetensi.Size = New System.Drawing.Size(136, 21)
        Me.cmbKompetensi.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No Telepon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kompetensi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat E-mail"
        '
        'txtIdDosen
        '
        Me.txtIdDosen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdDosen.Location = New System.Drawing.Point(415, 49)
        Me.txtIdDosen.Name = "txtIdDosen"
        Me.txtIdDosen.Size = New System.Drawing.Size(143, 26)
        Me.txtIdDosen.TabIndex = 0
        '
        'txtNoTelepon
        '
        Me.txtNoTelepon.Location = New System.Drawing.Point(107, 77)
        Me.txtNoTelepon.Name = "txtNoTelepon"
        Me.txtNoTelepon.Size = New System.Drawing.Size(136, 20)
        Me.txtNoTelepon.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(370, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Id Dosen"
        '
        'txtAlamatEMail
        '
        Me.txtAlamatEMail.Location = New System.Drawing.Point(107, 103)
        Me.txtAlamatEMail.Name = "txtAlamatEMail"
        Me.txtAlamatEMail.Size = New System.Drawing.Size(173, 20)
        Me.txtAlamatEMail.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Catatan)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 505)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(808, 83)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        '
        'Catatan
        '
        Me.Catatan.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Catatan.ForeColor = System.Drawing.Color.Red
        Me.Catatan.Location = New System.Drawing.Point(6, 13)
        Me.Catatan.Name = "Catatan"
        Me.Catatan.Size = New System.Drawing.Size(793, 64)
        Me.Catatan.TabIndex = 0
        Me.Catatan.Text = "Catatan"
        Me.Catatan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(11, 79)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(809, 268)
        Me.ListView1.TabIndex = 28
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Id Dosen"
        Me.ColumnHeader1.Width = 110
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama Dosen"
        Me.ColumnHeader2.Width = 240
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Kompetensi"
        Me.ColumnHeader3.Width = 115
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "No Telepon"
        Me.ColumnHeader4.Width = 130
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Alamat E-mail"
        Me.ColumnHeader5.Width = 210
        '
        'FormMasterDosen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 600)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "FormMasterDosen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormMasterDosen"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdTemukan As System.Windows.Forms.Button
    Friend WithEvents cmdDefault As System.Windows.Forms.Button
    Friend WithEvents cmbTemukan As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSubmit As System.Windows.Forms.Button
    Friend WithEvents txtNamaDosen As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbKompetensi As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtIdDosen As System.Windows.Forms.TextBox
    Friend WithEvents txtNoTelepon As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAlamatEMail As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Catatan As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdAmbil As System.Windows.Forms.Button
End Class
