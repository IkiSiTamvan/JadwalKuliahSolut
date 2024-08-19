Public Class TimeTable


    Dim configService As New ConfigService
    Dim listConfig As New List(Of ConfigModel)
    Dim currentConfig As New ConfigModel
    Dim objTtable As New TimeTableModel
    Dim tTableService As New TimeTableService
    Private indexHari As Integer = 0
    Private lastId As Integer = 0
    Dim formReady As Boolean
    Private Sub TimeTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbHari.SelectedIndex = 0
        populateData()
        tampilListViewTtable()
        Me.MdiParent = MDIParent1
        formReady = True
    End Sub
    Private Sub populateData()
        Dim configs As List(Of ConfigModel)
        configs = ConfigService.getAllData
        For Each config As ConfigModel In configs
            cmbTahunAjar.Items.Add(config.tahunAjar)
        Next
        cmbTahunAjar.Text = cmbTahunAjar.Items(0)
        listConfig = configs
    End Sub
    Private Sub tampilListViewTtable()
        Dim ttables As List(Of TimeTableModel)
        Call setDataTtable()
        ttables = tTableService.getTtableForm(objTtable)
        Dim lastAkhir As String = "07:00:00"

        If ttables.Count = 0 Then
            indexHari = 0
        End If
        lvTimeTable.Items.Clear()
        Dim lvItem As ListViewItem
        For Each ttable As TimeTableModel In ttables
            lvItem = lvTimeTable.Items.Add(ttable.id)
            lvItem.SubItems.Add(ttable.hari)
            lvItem.SubItems.Add(ttable.nama)
            lvItem.SubItems.Add(ttable.index)
            lvItem.SubItems.Add(ttable.mulai)
            lvItem.SubItems.Add(ttable.menit)
            lvItem.SubItems.Add(ttable.akhir)
            lvItem.SubItems.Add(ttable.tampil)
            lvItem.SubItems.Add(ttable.pelajaran)
            lvItem.SubItems.Add(ttable.tahunAjar)
            indexHari = ttable.index
            lastAkhir = ttable.akhir
            lastId = ttable.id
        Next

        indexHari = indexHari + 1
        setDtpMulaiValue(lastAkhir)
        formClear()
        lvTimeTable.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub cbPelajaran_CheckedChanged(sender As Object, e As EventArgs) Handles cbPelajaran.CheckedChanged
        If cbPelajaran.Checked = True Then
            If dtpMulai.Text = "07:00:00" Then
                dtpMulai.Enabled = True
            End If
            getCurrentConfig()
            numMenit.Enabled = False
            txtNamaKegiatan.Enabled = False
        Else
            dtpMulai.Enabled = False
            numMenit.Enabled = True
            txtNamaKegiatan.Enabled = True
        End If
    End Sub

    Private Sub setDtpMulaiValue(timeString As String)
        Dim time As DateTime

        ' Parse the time string into a DateTime object
        If DateTime.TryParse(timeString, time) Then
            ' Set the Value property of the DateTimePicker to the parsed DateTime
            dtpMulai.Value = time
        Else
            ' Handle the error if the string cannot be parsed
            MessageBox.Show("Invalid time format")
        End If
    End Sub

    Private Sub calculateTime()
        ' Get the value from the first DateTimePicker
        Dim firstDate As DateTime = dtpMulai.Value

        ' Get the numeric value from the NumericUpDown
        Dim numericValue As Integer = Convert.ToInt32(numMenit.Value)

        ' Add the numeric value to the date (assuming the numeric value represents days)
        Dim updatedDate As DateTime = firstDate.AddMinutes(numericValue)

        ' Set the value of the second DateTimePicker
        dtpBerakhir.Value = updatedDate
    End Sub

    Private Sub cmbTahunAjar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTahunAjar.SelectedIndexChanged
        getCurrentConfig()
        If formReady Then
            tampilListViewTtable()
        End If
    End Sub
    Private Sub getCurrentConfig()
        For Each config As ConfigModel In listConfig
            If config.tahunAjar = cmbTahunAjar.Text Then
                currentConfig = config
                Exit For
            End If
        Next
        numMenit.Value = currentConfig.timeUnitValue
    End Sub

    Private Sub numMenit_ValueChanged(sender As Object, e As EventArgs) Handles numMenit.ValueChanged
        calculateTime()
    End Sub

    Private Sub numMenit_KeyUp(sender As Object, e As KeyEventArgs) Handles numMenit.KeyUp
        calculateTime()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call setDataTtable()
        If objTtable.id = 0 Then
            tTableService.insertData(objTtable)
        Else

        End If
        tampilListViewTtable()
    End Sub

    Private Sub setDataTtable()
        objTtable.hari = cmbHari.Text
        objTtable.tahunAjar = cmbTahunAjar.Text
        objTtable.nama = txtNamaKegiatan.Text
        objTtable.mulai = dtpMulai.Text
        objTtable.menit = numMenit.Value
        objTtable.akhir = dtpBerakhir.Text
        objTtable.tampil = dtpMulai.Text & "-" & dtpBerakhir.Text
        objTtable.pelajaran = cbPelajaran.Checked
        objTtable.index = indexHari
    End Sub

    Private Sub formClear()
        cbPelajaran.Checked = True
        txtNamaKegiatan.Text = ""

        objTtable.id = 0
    End Sub

    Private Sub cmbHari_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHari.SelectedIndexChanged
        If formReady Then
            tampilListViewTtable()
        End If
    End Sub

    Private Sub dtpMulai_ValueChanged(sender As Object, e As EventArgs) Handles dtpMulai.ValueChanged
        calculateTime()
    End Sub

    Private Sub btnHapusTerakhir_Click(sender As Object, e As EventArgs) Handles btnHapusTerakhir.Click
        If lvTimeTable.Items.Count = 0 Then
            MessageBox.Show("No Data")
        Else
            tTableService.deleteData(lastId)
            tampilListViewTtable()
        End If
    End Sub

    Private Sub btnHapusHari_Click(sender As Object, e As EventArgs) Handles btnHapusHari.Click
        If lvTimeTable.Items.Count = 0 Then
            MessageBox.Show("No Data")
        Else
            Dim result As DialogResult =
                MessageBox.Show("Ini akan menghapus semua jadwal hari ini" &
                                vbCrLf & "hapus jadwal hari ini?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Call setDataTtable()
                tTableService.deleteDataHari(objTtable)
                tampilListViewTtable()
            End If

        End If
    End Sub
End Class