﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FormMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TahunAngkatanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeahlianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MataPelajaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KelasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JadwalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JadwalGuruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintPreviewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.JadwalPelajaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormMasterToolStripMenuItem, Me.JadwalToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FormMasterToolStripMenuItem
        '
        Me.FormMasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TahunAngkatanToolStripMenuItem, Me.KeahlianToolStripMenuItem, Me.MataPelajaranToolStripMenuItem, Me.GuruToolStripMenuItem, Me.KelasToolStripMenuItem})
        Me.FormMasterToolStripMenuItem.Name = "FormMasterToolStripMenuItem"
        Me.FormMasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.FormMasterToolStripMenuItem.Text = "Master"
        '
        'TahunAngkatanToolStripMenuItem
        '
        Me.TahunAngkatanToolStripMenuItem.Name = "TahunAngkatanToolStripMenuItem"
        Me.TahunAngkatanToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TahunAngkatanToolStripMenuItem.Text = "Config"
        '
        'KeahlianToolStripMenuItem
        '
        Me.KeahlianToolStripMenuItem.Name = "KeahlianToolStripMenuItem"
        Me.KeahlianToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.KeahlianToolStripMenuItem.Text = "Keahlian"
        '
        'MataPelajaranToolStripMenuItem
        '
        Me.MataPelajaranToolStripMenuItem.Name = "MataPelajaranToolStripMenuItem"
        Me.MataPelajaranToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MataPelajaranToolStripMenuItem.Text = "Mata Pelajaran"
        '
        'GuruToolStripMenuItem
        '
        Me.GuruToolStripMenuItem.Name = "GuruToolStripMenuItem"
        Me.GuruToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GuruToolStripMenuItem.Text = "Guru"
        '
        'KelasToolStripMenuItem
        '
        Me.KelasToolStripMenuItem.Name = "KelasToolStripMenuItem"
        Me.KelasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.KelasToolStripMenuItem.Text = "Kelas"
        '
        'JadwalToolStripMenuItem
        '
        Me.JadwalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TimeTableToolStripMenuItem, Me.JadwalGuruToolStripMenuItem, Me.JadwalPelajaranToolStripMenuItem})
        Me.JadwalToolStripMenuItem.Name = "JadwalToolStripMenuItem"
        Me.JadwalToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.JadwalToolStripMenuItem.Text = "Jadwal"
        '
        'TimeTableToolStripMenuItem
        '
        Me.TimeTableToolStripMenuItem.Name = "TimeTableToolStripMenuItem"
        Me.TimeTableToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TimeTableToolStripMenuItem.Text = "Rangka Jadwal"
        '
        'JadwalGuruToolStripMenuItem
        '
        Me.JadwalGuruToolStripMenuItem.Name = "JadwalGuruToolStripMenuItem"
        Me.JadwalGuruToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.JadwalGuruToolStripMenuItem.Text = "Jadwal Guru"
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.ToolStripSeparator1, Me.PrintToolStripButton, Me.PrintPreviewToolStripButton, Me.ToolStripSeparator2, Me.HelpToolStripButton})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(632, 25)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "New"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton.Text = "Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "Save"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintToolStripButton.Text = "Print"
        '
        'PrintPreviewToolStripButton
        '
        Me.PrintPreviewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintPreviewToolStripButton.Image = CType(resources.GetObject("PrintPreviewToolStripButton.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.PrintPreviewToolStripButton.Name = "PrintPreviewToolStripButton"
        Me.PrintPreviewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintPreviewToolStripButton.Text = "Print Preview"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HelpToolStripButton.Text = "Help"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'JadwalPelajaranToolStripMenuItem
        '
        Me.JadwalPelajaranToolStripMenuItem.Name = "JadwalPelajaranToolStripMenuItem"
        Me.JadwalPelajaranToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.JadwalPelajaranToolStripMenuItem.Text = "Jadwal Pelajaran"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIParent1"
        Me.Text = "MDIParent1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintPreviewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FormMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KelasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JadwalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TahunAngkatanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JadwalGuruToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeahlianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MataPelajaranToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuruToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimeTableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JadwalPelajaranToolStripMenuItem As ToolStripMenuItem
End Class
