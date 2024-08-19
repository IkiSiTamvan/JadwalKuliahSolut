Public Class Config
    Dim configService As New ConfigService
    Dim objConfig As New ConfigModel
    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click
        If txtTahunAjar.Text = "" Or lstTahunAngkatan.Items.Count = 0 Then
            MsgBox("Tahun Ajar dan Tahun Angkatan Harus Diisi," & vbCrLf & "silahkan lengkapi data", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Submit")
        Else
            Dim result As DialogResult =
                MessageBox.Show("Data ini akan sulit dirubah jika Jadwal Pelajaran sudah dibuat" &
                                vbCrLf & "simpan data dengan time unit saat ini?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Call setDataConfig()
                If (objConfig.id = "") Then
                    configService.insertData(objConfig)
                Else
                    configService.updateData(objConfig)
                End If
            End If
        End If
        tampilListView()
    End Sub

    Private Sub tampilListView()
        Dim configs As List(Of ConfigModel)
        configs = configService.getAllData()

        lvConfig.Items.Clear()
        Dim lvBarang As ListViewItem
        For Each config As ConfigModel In configs
            lvBarang = lvConfig.Items.Add(config.id)
            lvBarang.SubItems.Add(config.tahunAjar)
            lvBarang.SubItems.Add(config.tahunAngkatan)
            lvBarang.SubItems.Add(config.timeUnitValue)
        Next
        formClear()
        lvConfig.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
    Private Sub formClear()
        txtTahunAjar.Text = ""
        numTimeUnit.Value = 25
        If lstTahunAngkatan.DataSource Is Nothing Then
            lstTahunAngkatan.Items.Clear()
        Else
            lstTahunAngkatan.DataSource = Nothing
            lstTahunAngkatan.Items.Clear()
        End If

        objConfig.tahunAjar = ""
        objConfig.tahunAngkatan = ""
        objConfig.timeUnitValue = 0
        objConfig.id = ""

    End Sub
    Private Sub setDataConfig()
        objConfig.tahunAjar = txtTahunAjar.Text
        objConfig.tahunAngkatan = configService.setListAngkatan(lstTahunAngkatan.Items.Cast(Of String)().ToList())
        objConfig.timeUnitValue = numTimeUnit.Value
    End Sub

    Private Sub Config_Load(sender As Object, e As EventArgs) Handles Me.Load
        tampilListView()
        Me.MdiParent = MDIParent1
    End Sub

    Private Sub lvConfig_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvConfig.SelectedIndexChanged
        objConfig.id = lvConfig.FocusedItem.Text
        txtTahunAjar.Text = lvConfig.FocusedItem.SubItems(1).Text
        lstTahunAngkatan.DataSource = configService.getListAngkatan(lvConfig.FocusedItem.SubItems(2).Text)
        lstTahunAngkatan.SelectedIndex = -1
        numTimeUnit.Value = lvConfig.FocusedItem.SubItems(3).Text
    End Sub

    Private Sub cmdTambahAngkatan_Click(sender As Object, e As EventArgs) Handles cmdTambahAngkatan.Click
        Dim configs As List(Of ConfigModel)
        configs = configService.getAllData()

        If IsNothing(configs) Then
            Dim currentYear As String = DateTime.Now.Year.ToString
            Dim numYear As Integer = Integer.Parse(currentYear)
            setTA(numYear)
        Else
            Dim tahunAjar As String = configs(0).tahunAjar
            Dim tahun As Integer = tahunAjar.Split("-"c)(1)
            setTA(tahun)
        End If
    End Sub

    Private Sub setTA(ByVal year As Integer)
        txtTahunAjar.Text = year & "-" & year + 1
        lstTahunAngkatan.DataSource = Nothing
        lstTahunAngkatan.Items.Clear()
        lstTahunAngkatan.Items.Add(year.ToString)
        lstTahunAngkatan.Items.Add((year - 1).ToString)
        lstTahunAngkatan.Items.Add((year - 2).ToString)
    End Sub
End Class