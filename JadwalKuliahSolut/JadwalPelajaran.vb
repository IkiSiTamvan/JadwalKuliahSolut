Imports OfficeOpenXml
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class JadwalPelajaran
    Dim configService As New ConfigService
    Dim keahlianService As New KeahlianService
    Dim mapelService As New MapelService
    Dim kelasService As New KelasService
    Dim selectedKeahlian As New KeahlianModel
    Dim jadwalGuruService As New JadwalGuruService
    Dim jadwalPelajaranService As New JadwalPelajaranService
    Dim guruKeahlianService As New GuruKeahlianService
    Dim guruMapelService As New GuruMapelService
    Dim formReady As New Boolean

    Private Sub populateData()
        Dim configs As List(Of ConfigModel)
        configs = configService.getAllData
        For Each config As ConfigModel In configs
            cmbTahunAjar.Items.Add(config.tahunAjar)
        Next
        cmbTahunAjar.Text = cmbTahunAjar.Items(0)

        Dim keahlians As List(Of KeahlianModel)
        keahlians = keahlianService.getAllData
        For Each keahlian As KeahlianModel In keahlians
            cmbKeahlian.Items.Add(keahlian)
        Next
        cmbKeahlian.SelectedIndex = 0

        cmbKelas.SelectedIndex = 0
        cmbSemester.SelectedIndex = 0
        cmbHari.SelectedIndex = 0

        populateCmbNamaKelas()


    End Sub

    Private Sub populateCmbNamaKelas()
        If formReady Then
            Dim kelass As List(Of KelasModel)
            kelass = kelasService.getDataByTA_KelasKeahlian(cmbTahunAjar.Text, cmbKelas.Text, selectedKeahlian.id)
            cmbNamaKelas.Items.Clear()
            For Each kelas As KelasModel In kelass
                cmbNamaKelas.Items.Add(kelas)
            Next
            If kelass.Count > 0 Then
                cmbNamaKelas.SelectedIndex = 0
            End If
        End If

    End Sub
    Private Sub JadwalPelajaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateData()
        formReady = True
        Me.MdiParent = MDIParent1
    End Sub

    Private Sub tampilMapelListview()
        Dim objMapel As New MapelModel
        objMapel.tahunAjar = cmbTahunAjar.Text
        selectedKeahlian = CType(cmbKeahlian.SelectedItem, KeahlianModel)
        objMapel.idKeahlian = selectedKeahlian.id
        objMapel.kelas = cmbKelas.Text
        objMapel.semester = cmbSemester.Text

        Dim mapels As List(Of MapelModel)
        mapels = mapelService.getFormData(objMapel)

        lvMapel.Items.Clear()
        Dim lvItem As ListViewItem
        For Each mapel As MapelModel In mapels
            lvItem = lvMapel.Items.Add(mapel.nama)
            lvItem.SubItems.Add(mapel.kelas)
            lvItem.SubItems.Add(mapel.semester)
            lvItem.SubItems.Add(mapel.timeUnit)
            lvItem.SubItems.Add(mapel.id)
        Next
        lvMapel.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
    Private Sub lvMapel_DoubleClick(sender As Object, e As EventArgs) Handles lvMapel.DoubleClick
        If lbWaktu.Items.Count < 1 Then
            MsgBox("Waktu belum terpilih, silahkan pilih waktu terlebih dahulu ", MsgBoxStyle.Exclamation, "Data")
            Exit Sub
        End If

        Dim mapel As New MapelModel
        mapel.id = lvMapel.FocusedItem.SubItems(4).Text
        mapel.nama = lvMapel.FocusedItem.SubItems(0).Text
        lbMapel.Items.Clear()
        lbMapel.Items.Add(mapel)
    End Sub
    Private Sub cmbSimpan_Click(sender As Object, e As EventArgs) Handles cmbSimpan.Click
        If lbGuru.Items.Count < 1 Or lbMapel.Items.Count < 1 Or lbWaktu.Items.Count < 1 Then
            MsgBox("Data Jadwal Pelajaran Belum Lengkap" & vbCrLf & "silahkan lengkapi jadwal", MsgBoxStyle.Exclamation, "Insert")
        Else
            Dim ttModel As TimeTableModel = lbWaktu.Items(0)
            Dim guru As GuruModel = lbGuru.Items(0)
            Dim mapel As MapelModel = lbMapel.Items(0)

            Dim objJadwalPelajaran As New JadwalPelajaranModel
            objJadwalPelajaran.tahunAjar = cmbTahunAjar.Text
            objJadwalPelajaran.semester = cmbSemester.Text
            objJadwalPelajaran.idGuru = guru.id
            objJadwalPelajaran.namaGuru = guru.nama
            objJadwalPelajaran.namaKelas = cmbNamaKelas.Text
            objJadwalPelajaran.idMapel = mapel.id
            objJadwalPelajaran.namaMapel = mapel.nama
            objJadwalPelajaran.idTimeTable = ttModel.id
            objJadwalPelajaran.tampil = ttModel.tampil

            jadwalPelajaranService.insertData(objJadwalPelajaran)
            tampilJadwalPelajaranListView()
        End If

    End Sub

    Private Sub tampilGuruListView()
        If formReady Then
            Dim jadwalGurus As List(Of JadwalGuruModel)
            If rbSesuaikanJadwal.Checked Then
                If lbWaktu.Items.Count < 1 Then
                    MsgBox("Waktu belum terpilih, silahkan pilih waktu terlebih dahulu ", MsgBoxStyle.Exclamation, "Data")
                    rbsemuaGuru.Checked = True
                    jadwalGurus = jadwalGuruService.getJGuruByHari_TA(cmbTahunAjar.Text, cmbHari.Text)
                Else
                    Dim ttModel As TimeTableModel = lbWaktu.Items(0)
                    jadwalGurus = jadwalGuruService.getJGuruByHari_TA_Waktu(cmbTahunAjar.Text, cmbHari.Text, ttModel.id)
                End If

            ElseIf rbsemuaGuru.Checked Then
                jadwalGurus = jadwalGuruService.getJGuruByHari_TA(cmbTahunAjar.Text, cmbHari.Text)
            End If

            lvGuru.Items.Clear()
            Dim lvItem As ListViewItem
            For Each jadwalGuru As JadwalGuruModel In jadwalGurus
                lvItem = lvGuru.Items.Add(jadwalGuru.nama)
                lvItem.SubItems.Add(jadwalGuru.tampil)
                lvItem.SubItems.Add(jadwalGuru.internal)
                lvItem.SubItems.Add(jadwalGuru.idGuru)
                lvItem.SubItems.Add(jadwalGuru.hari)
                lvItem.SubItems.Add(jadwalGuru.idTimeTable)
            Next
            lvGuru.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        End If

    End Sub

    Private Sub lvGuru_DoubleClick(sender As Object, e As EventArgs) Handles lvGuru.DoubleClick
        If lbWaktu.Items.Count < 1 Then
            MsgBox("Waktu belum terpilih, silahkan pilih waktu terlebih dahulu ", MsgBoxStyle.Exclamation, "Data")
            Exit Sub
        End If

        Dim ttModel As New TimeTableModel
        ttModel = lbWaktu.Items(0)
        If ttModel.id <> lvGuru.FocusedItem.SubItems(5).Text Then
            MsgBox("Waktu tidak sesuai, silahkan pilih waktu yang sesuai ", MsgBoxStyle.Exclamation, "Data")
            Exit Sub
        Else
            Dim guru As New GuruModel
            guru.id = lvGuru.FocusedItem.SubItems(3).Text
            guru.nama = lvGuru.FocusedItem.SubItems(0).Text
            lbGuru.Items.Clear()
            lbGuru.Items.Add(guru)
        End If
    End Sub
    Private Sub clearJadwalPelajaranSementara()
        lbWaktu.Items.Clear()
        lbMapel.Items.Clear()
        lbGuru.Items.Clear()
    End Sub
    Private Sub tampilJadwalPelajaranListView()

        If formReady Then
            If cmbNamaKelas.Text = "" Then
                MsgBox("Gagal memuat data jadwal pelajaran, pilih nama kelas terlebih dahulu", MsgBoxStyle.Exclamation, "Data")
                Exit Sub
            End If
            Dim jadwalPelajarans As List(Of JadwalPelajaranModel)
            jadwalPelajarans = jadwalPelajaranService.getJadwalByHariTA(cmbTahunAjar.Text, cmbHari.Text, cmbNamaKelas.Text, cmbSemester.Text)

            lvJadwalPelajaran.Items.Clear()
            Dim lvItem As ListViewItem
            For Each jadwalPelajaran As JadwalPelajaranModel In jadwalPelajarans
                lvItem = lvJadwalPelajaran.Items.Add(jadwalPelajaran.tampil)
                lvItem.SubItems.Add(jadwalPelajaran.namaGuru)
                If jadwalPelajaran.pelajaran Then
                    lvItem.SubItems.Add(jadwalPelajaran.namaMapel)
                Else
                    lvItem.SubItems.Add(jadwalPelajaran.namaKegiatan)
                End If
                lvItem.SubItems.Add(jadwalPelajaran.namaKelas)
                lvItem.SubItems.Add(jadwalPelajaran.hari)
                lvItem.SubItems.Add(jadwalPelajaran.pelajaran)
                lvItem.SubItems.Add(jadwalPelajaran.idTimeTable)
            Next
            lvJadwalPelajaran.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        End If
        clearJadwalPelajaranSementara()
    End Sub
    Private Sub lvJadwalPelajaran_DoubleClick(sender As Object, e As EventArgs) Handles lvJadwalPelajaran.DoubleClick
        If lvJadwalPelajaran.FocusedItem.SubItems(5).Text = "False" Then
            MsgBox("Bukan jam belajar, silahkan pilih jam belajar ", MsgBoxStyle.Exclamation, "Data")
        Else
            Dim ttModel As New TimeTableModel
            ttModel.id = lvJadwalPelajaran.FocusedItem.SubItems(6).Text
            ttModel.tampil = lvJadwalPelajaran.FocusedItem.SubItems(0).Text
            lbWaktu.Items.Clear()
            lbWaktu.Items.Add(ttModel)
            tampilGuruListView()
        End If
    End Sub

    Private Sub tampilListviewGK()
        Dim gkList As List(Of GuruKeahlianModel)
        gkList = guruKeahlianService.getKeahlianGuru(lvGuru.FocusedItem.SubItems(3).Text)

        lvGK.Items.Clear()
        Dim lvItem As ListViewItem
        For Each gk As GuruKeahlianModel In gkList
            lvItem = lvGK.Items.Add(gk.nama_keahlian)
        Next
        lvGK.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
    Private Sub tampilListviewGM()
        Dim gmList As List(Of GuruMapelModel)
        gmList = guruMapelService.getMapelGuru(lvGuru.FocusedItem.SubItems(3).Text)

        lvGM.Items.Clear()
        Dim lvItem As ListViewItem
        For Each gm As GuruMapelModel In gmList
            lvItem = lvGM.Items.Add(gm.singkatan)
            lvItem.SubItems.Add(gm.namaMapel)
        Next
        lvGM.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub cmbSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSemester.SelectedIndexChanged
        cmbchange()
        clearJadwalPelajaranSementara()
        tampilJadwalPelajaranListView()
    End Sub
    Private Sub cmbchange()

        If formReady Then
            tampilMapelListview()
        End If
    End Sub

    Private Sub cmbKelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKelas.SelectedIndexChanged
        cmbchange()
        populateCmbNamaKelas()
        clearJadwalPelajaranSementara()
    End Sub

    Private Sub cmbKeahlian_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKeahlian.SelectedIndexChanged
        selectedKeahlian = CType(cmbKeahlian.SelectedItem, KeahlianModel)
        cmbchange()
        populateCmbNamaKelas()
        tampilJadwalPelajaranListView()
        clearJadwalPelajaranSementara()
    End Sub

    Private Sub cmbTahunAjar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTahunAjar.SelectedIndexChanged
        cmbchange()
        populateCmbNamaKelas()
        tampilGuruListView()
        tampilJadwalPelajaranListView()
        clearJadwalPelajaranSementara()
    End Sub

    Private Sub cmbHari_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHari.SelectedIndexChanged
        tampilGuruListView()
        tampilJadwalPelajaranListView()
        clearJadwalPelajaranSementara()
    End Sub

    Private Sub lvGuru_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvGuru.SelectedIndexChanged
        tampilListviewGK()
        tampilListviewGM()
    End Sub

    Private Sub cmbClear_Click(sender As Object, e As EventArgs) Handles cmbClear.Click
        clearJadwalPelajaranSementara()
    End Sub

    Private Sub cmbNamaKelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNamaKelas.SelectedIndexChanged
        clearJadwalPelajaranSementara()
        tampilJadwalPelajaranListView()

    End Sub

    Private Sub rbSesuaikanJadwal_CheckedChanged(sender As Object, e As EventArgs) Handles rbSesuaikanJadwal.CheckedChanged
        tampilGuruListView()
    End Sub

    Private Sub btnSaveExcel_Click(sender As Object, e As EventArgs) Handles btnSaveExcel.Click

        Using saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Excel Files|*.xlsx"
            saveFileDialog.Title = "Save an Excel File"
            saveFileDialog.FileName = "Schedule.xlsx"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                SaveListViewToExcel(saveFileDialog.FileName)
            End If
        End Using
    End Sub

    Private Sub SaveListViewToExcel(filePath As String)

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial
        ' Create a new Excel package
        Using package As New ExcelPackage()
            ' Add a new worksheet to the Excel workbook
            Dim worksheet As ExcelWorksheet = package.Workbook.Worksheets.Add("Schedule")

            ' Add column headers
            For col As Integer = 0 To lvJadwalPelajaran.Columns.Count - 1
                worksheet.Cells(1, col + 1).Value = lvJadwalPelajaran.Columns(col).Text
            Next

            ' Add rows
            For row As Integer = 0 To lvJadwalPelajaran.Items.Count - 1
                For col As Integer = 0 To lvJadwalPelajaran.Columns.Count - 1
                    worksheet.Cells(row + 2, col + 1).Value = lvJadwalPelajaran.Items(row).SubItems(col).Text
                Next
            Next

            ' Adjust column widths
            worksheet.Cells.AutoFitColumns()

            ' Save the Excel package to a file
            Dim fileInfo As New FileInfo(filePath)
            package.SaveAs(fileInfo)

            MessageBox.Show("Excel file created successfully at " & filePath)
        End Using
    End Sub
End Class