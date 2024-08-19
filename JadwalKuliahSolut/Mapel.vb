Public Class Mapel
    Dim keahlianService As New KeahlianService
    Dim configService As New ConfigService
    Dim mapelService As New MapelService
    Dim objMapel As New MapelModel
    Dim formReady As New Boolean

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNamaMapel.Text = "" Then
            txtNamaMapel.Focus()
            MsgBox("Nama Mata Pelajaran Harus Diisi," & vbCrLf & "silahkan lengkapi data", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Submit")
        Else
            Call setDataMapel()
            If objMapel.id = 0 Then
                mapelService.insertData(objMapel)
            Else
                mapelService.updateData(objMapel)
            End If
            tampilListview()
        End If
    End Sub

    Private Sub tampilListview()
        setDataMapel()
        Dim mapels As List(Of MapelModel)
        Dim totalTimeUnit As Integer = 0
        mapels = mapelService.getFormData(objMapel)

        lvMapel.Items.Clear()
        Dim lvItem As ListViewItem
        For Each mapel As MapelModel In mapels
            lvItem = lvMapel.Items.Add(mapel.id)
            lvItem.SubItems.Add(mapel.nama)
            lvItem.SubItems.Add(mapel.idKeahlian)
            lvItem.SubItems.Add(mapel.Keahlian)
            lvItem.SubItems.Add(mapel.tahunAjar)
            lvItem.SubItems.Add(mapel.kelas)
            lvItem.SubItems.Add(mapel.semester)
            lvItem.SubItems.Add(mapel.timeUnit)
            lvItem.SubItems.Add(mapel.butuhLab)
            totalTimeUnit = totalTimeUnit + mapel.timeUnit
        Next

        formClear()
        txtTotalTU.Text = totalTimeUnit
        lvMapel.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
    Private Sub setDataMapel()
        objMapel.kelas = cmbKelas.Text
        objMapel.semester = cmbSemester.Text
        objMapel.idKeahlian = getFromBracket(cmbKeahlian.Text)
        objMapel.nama = txtNamaMapel.Text
        objMapel.tahunAjar = cmbTahunAjar.Text
        objMapel.timeUnit = numTimeUnit.Value
        objMapel.butuhLab = cbButuhLab.Checked
    End Sub

    Private Sub formClear()
        txtNamaMapel.Text = ""
        numTimeUnit.Value = 2
        cbButuhLab.Checked = False
        txtTotalTU.Text = ""

        objMapel.kelas = ""
        objMapel.semester = ""
        objMapel.idKeahlian = ""
        objMapel.nama = ""
        objMapel.tahunAjar = ""
        objMapel.timeUnit = 0
        objMapel.butuhLab = False
        objMapel.id = 0
    End Sub

    Function getFromBracket(ByVal someString As String) As String
        Dim startIndex As Integer = someString.IndexOf("[")
        Dim endIndex As Integer = someString.IndexOf("]")
        Dim result As String = ""
        ' Check if both opening and closing brackets are found
        If startIndex <> -1 AndAlso endIndex <> -1 AndAlso endIndex > startIndex Then
            ' Get the substring inside the square brackets
            result = someString.Substring(startIndex + 1, endIndex - startIndex - 1)
        End If
        Return result
    End Function

    Private Sub FormMapel_Load(sender As Object, e As EventArgs) Handles Me.Load
        populateData()
        formReady = True
        Me.MdiParent = MDIParent1
    End Sub

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
            cmbKeahlian.Items.Add(keahlian.nama & " [" & keahlian.id & "]")
        Next
        cmbKeahlian.Text = cmbKeahlian.Items(0)
        cmbKelas.Text = cmbKelas.Items(0)
        cmbSemester.Text = cmbSemester.Items(0)

        objMapel.id = 0
    End Sub

    Private Sub cmbTahunAjar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTahunAjar.SelectedIndexChanged
        cmbchange()
    End Sub

    Private Sub cmbKeahlian_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKeahlian.SelectedIndexChanged
        cmbchange()
    End Sub

    Private Sub cmbKelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKelas.SelectedIndexChanged
        cmbchange()
    End Sub

    Private Sub cmbSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSemester.SelectedIndexChanged
        cmbchange()
    End Sub

    Private Sub cmbchange()
        txtNamaMapel.Focus()
        If formReady Then
            tampilListview()
        End If
    End Sub

    Private Sub lvMapel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvMapel.SelectedIndexChanged
        objMapel.id = lvMapel.FocusedItem.Text
        txtNamaMapel.Text = lvMapel.FocusedItem.SubItems(1).Text
        cmbKeahlian.Text = lvMapel.FocusedItem.SubItems(3).Text & " [" & lvMapel.FocusedItem.SubItems(2).Text & "]"
        cmbTahunAjar.Text = lvMapel.FocusedItem.SubItems(4).Text
        cmbKelas.Text = lvMapel.FocusedItem.SubItems(5).Text
        cmbSemester.Text = lvMapel.FocusedItem.SubItems(6).Text
        numTimeUnit.Value = lvMapel.FocusedItem.SubItems(7).Text
        cbButuhLab.Checked = lvMapel.FocusedItem.SubItems(8).Text
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If objMapel.id = 0 Then
            MsgBox("tidak ada mapel yang dipilih" & vbCrLf & "silahkan pilih mapel yang akan dihapus", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Submit")
        Else
            mapelService.deleteData(objMapel)
            Call tampilListview()
        End If
    End Sub
End Class