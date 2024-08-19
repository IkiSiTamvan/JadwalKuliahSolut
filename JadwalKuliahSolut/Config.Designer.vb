<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Config
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
        Me.txtTahunAjar = New System.Windows.Forms.TextBox()
        Me.lstTahunAngkatan = New System.Windows.Forms.ListBox()
        Me.numTimeUnit = New System.Windows.Forms.NumericUpDown()
        Me.lvConfig = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdSimpan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdTambahAngkatan = New System.Windows.Forms.Button()
        CType(Me.numTimeUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTahunAjar
        '
        Me.txtTahunAjar.Enabled = False
        Me.txtTahunAjar.Location = New System.Drawing.Point(113, 35)
        Me.txtTahunAjar.Name = "txtTahunAjar"
        Me.txtTahunAjar.Size = New System.Drawing.Size(120, 20)
        Me.txtTahunAjar.TabIndex = 0
        '
        'lstTahunAngkatan
        '
        Me.lstTahunAngkatan.AccessibleName = ""
        Me.lstTahunAngkatan.Enabled = False
        Me.lstTahunAngkatan.FormattingEnabled = True
        Me.lstTahunAngkatan.Location = New System.Drawing.Point(113, 61)
        Me.lstTahunAngkatan.Name = "lstTahunAngkatan"
        Me.lstTahunAngkatan.Size = New System.Drawing.Size(120, 69)
        Me.lstTahunAngkatan.TabIndex = 1
        '
        'numTimeUnit
        '
        Me.numTimeUnit.Location = New System.Drawing.Point(113, 136)
        Me.numTimeUnit.Name = "numTimeUnit"
        Me.numTimeUnit.Size = New System.Drawing.Size(120, 20)
        Me.numTimeUnit.TabIndex = 2
        Me.numTimeUnit.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'lvConfig
        '
        Me.lvConfig.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvConfig.FullRowSelect = True
        Me.lvConfig.HideSelection = False
        Me.lvConfig.Location = New System.Drawing.Point(12, 171)
        Me.lvConfig.Name = "lvConfig"
        Me.lvConfig.Size = New System.Drawing.Size(422, 157)
        Me.lvConfig.TabIndex = 3
        Me.lvConfig.UseCompatibleStateImageBehavior = False
        Me.lvConfig.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Id"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "TahunAjar"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tahun Angkatan"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Time Unit"
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(239, 136)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(75, 23)
        Me.cmdSimpan.TabIndex = 4
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tahun Ajar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Tahun Angkatan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Time Unit"
        '
        'cmdTambahAngkatan
        '
        Me.cmdTambahAngkatan.Location = New System.Drawing.Point(239, 33)
        Me.cmdTambahAngkatan.Name = "cmdTambahAngkatan"
        Me.cmdTambahAngkatan.Size = New System.Drawing.Size(75, 23)
        Me.cmdTambahAngkatan.TabIndex = 8
        Me.cmdTambahAngkatan.Text = "TA Baru"
        Me.cmdTambahAngkatan.UseVisualStyleBackColor = True
        '
        'Config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 340)
        Me.Controls.Add(Me.cmdTambahAngkatan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.lvConfig)
        Me.Controls.Add(Me.numTimeUnit)
        Me.Controls.Add(Me.lstTahunAngkatan)
        Me.Controls.Add(Me.txtTahunAjar)
        Me.Name = "Config"
        Me.Text = "Config"
        CType(Me.numTimeUnit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTahunAjar As TextBox
    Friend WithEvents lstTahunAngkatan As ListBox
    Friend WithEvents numTimeUnit As NumericUpDown
    Friend WithEvents lvConfig As ListView
    Friend WithEvents cmdSimpan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents cmdTambahAngkatan As Button
End Class
