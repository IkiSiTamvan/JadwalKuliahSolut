<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmkeahlian
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
        Me.LabelNama = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.LabelProgram = New System.Windows.Forms.Label()
        Me.TxtProgram = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBidang = New System.Windows.Forms.TextBox()
        Me.txtSingkatan = New System.Windows.Forms.TextBox()
        Me.LabelSingkatan = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.lvKeahlian = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelNama
        '
        Me.LabelNama.AutoSize = True
        Me.LabelNama.Location = New System.Drawing.Point(9, 78)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(35, 13)
        Me.LabelNama.TabIndex = 0
        Me.LabelNama.Text = "Nama"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(131, 75)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(199, 20)
        Me.txtNama.TabIndex = 1
        '
        'LabelProgram
        '
        Me.LabelProgram.AutoSize = True
        Me.LabelProgram.Location = New System.Drawing.Point(9, 104)
        Me.LabelProgram.Name = "LabelProgram"
        Me.LabelProgram.Size = New System.Drawing.Size(90, 13)
        Me.LabelProgram.TabIndex = 2
        Me.LabelProgram.Text = "Program Keahlian"
        '
        'TxtProgram
        '
        Me.TxtProgram.Location = New System.Drawing.Point(131, 101)
        Me.TxtProgram.Name = "TxtProgram"
        Me.TxtProgram.Size = New System.Drawing.Size(199, 20)
        Me.TxtProgram.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Bidang Keahlian"
        '
        'txtBidang
        '
        Me.txtBidang.Location = New System.Drawing.Point(131, 127)
        Me.txtBidang.Name = "txtBidang"
        Me.txtBidang.Size = New System.Drawing.Size(199, 20)
        Me.txtBidang.TabIndex = 5
        '
        'txtSingkatan
        '
        Me.txtSingkatan.Location = New System.Drawing.Point(131, 153)
        Me.txtSingkatan.Name = "txtSingkatan"
        Me.txtSingkatan.Size = New System.Drawing.Size(199, 20)
        Me.txtSingkatan.TabIndex = 6
        '
        'LabelSingkatan
        '
        Me.LabelSingkatan.AutoSize = True
        Me.LabelSingkatan.Location = New System.Drawing.Point(9, 156)
        Me.LabelSingkatan.Name = "LabelSingkatan"
        Me.LabelSingkatan.Size = New System.Drawing.Size(55, 13)
        Me.LabelSingkatan.TabIndex = 7
        Me.LabelSingkatan.Text = "Singkatan"
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(352, 151)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 8
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'lvKeahlian
        '
        Me.lvKeahlian.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvKeahlian.FullRowSelect = True
        Me.lvKeahlian.GridLines = True
        Me.lvKeahlian.HideSelection = False
        Me.lvKeahlian.Location = New System.Drawing.Point(12, 179)
        Me.lvKeahlian.Name = "lvKeahlian"
        Me.lvKeahlian.Size = New System.Drawing.Size(792, 153)
        Me.lvKeahlian.TabIndex = 9
        Me.lvKeahlian.UseCompatibleStateImageBehavior = False
        Me.lvKeahlian.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Id"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nama Keahlian"
        Me.ColumnHeader1.Width = 153
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Program Keahlian"
        Me.ColumnHeader2.Width = 224
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Bidang Keahlian"
        Me.ColumnHeader3.Width = 291
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "singkatan"
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(433, 151)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 10
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'frmkeahlian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 344)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.lvKeahlian)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.LabelSingkatan)
        Me.Controls.Add(Me.txtSingkatan)
        Me.Controls.Add(Me.txtBidang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtProgram)
        Me.Controls.Add(Me.LabelProgram)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.LabelNama)
        Me.Name = "frmkeahlian"
        Me.Text = "Form Keahlian"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents LabelProgram As Label
    Friend WithEvents TxtProgram As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBidang As TextBox
    Friend WithEvents txtSingkatan As TextBox
    Friend WithEvents LabelSingkatan As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents btnHapus As Button
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents lvKeahlian As ListView
End Class
