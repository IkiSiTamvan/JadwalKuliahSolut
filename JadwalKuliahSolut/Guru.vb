Public Class Guru
    Dim objGuru As New GuruModel
    Dim guruService As New GuruService
    Dim keahlianService As New KeahlianService
    Dim guruKeahlianService As New GuruKeahlianService
    Dim configService As New ConfigService
    Dim mapelService As New MapelService
    Dim guruMapelService As New GuruMapelService
    Dim formready As New Boolean

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNama.Text = "" Or txtEmail.Text = "" Or txtNoTelpon.Text = "" Then
            MsgBox("Nama, Email, dan No Telpon Harus Diisi," & vbCrLf & "silahkan lengkapi data", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Submit")
        Else
            Call setDataGuru()
            If objGuru.id = 0 Then
                guruService.insertData(objGuru)
            Else
                guruService.updateData(objGuru)
            End If
        End If
        tampilListViewGuru()
        txtNama.Focus()
    End Sub
    Private Sub tampilListViewGuru()
        Dim gurus As List(Of GuruModel)
        gurus = guruService.getAllData()

        lvGuru.Items.Clear()
        Dim lvitem As ListViewItem
        For Each guru As GuruModel In gurus
            lvitem = lvGuru.Items.Add(guru.id)
            lvitem.SubItems.Add(guru.nama)
            lvitem.SubItems.Add(guru.email)
            lvitem.SubItems.Add(guru.noTelpon)
            lvitem.SubItems.Add(guru.internal)
            lvitem.SubItems.Add(guru.aktif)
        Next
        guruSectClear()
        keahlianSectClear()
        lvGuru.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
    Private Sub tampilListviewGK()
        Dim gkList As List(Of GuruKeahlianModel)
        gkList = guruKeahlianService.getKeahlianGuru(objGuru.id)

        lvKeahlian.Items.Clear()
        Dim lvItem As ListViewItem
        For Each gk As GuruKeahlianModel In gkList
            lvItem = lvKeahlian.Items.Add(gk.id_keahlian)
            lvItem.SubItems.Add(gk.nama_keahlian)
        Next
        lvKeahlian.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
    Private Sub tampilListviewGM()
        Dim gmList As List(Of GuruMapelModel)
        gmList = guruMapelService.getMapelGuru(objGuru.id)

        lvMapel.Items.Clear()
        Dim lvItem As ListViewItem
        For Each gm As GuruMapelModel In gmList
            lvItem = lvMapel.Items.Add(gm.idMapel)
            lvItem.SubItems.Add(gm.namaMapel)
            lvItem.SubItems.Add(gm.singkatan)
        Next
        lvMapel.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
    Private Sub setDataGuru()
        objGuru.nama = txtNama.Text
        objGuru.email = txtEmail.Text
        objGuru.noTelpon = txtNoTelpon.Text
        objGuru.aktif = cbAktif.Checked
        objGuru.internal = cbGuruInternal.Checked
    End Sub

    Private Sub keahlianSectClear()
        cmbKeahlian.SelectedIndex = -1
        lvKeahlian.Items.Clear()
    End Sub
    Private Sub guruSectClear()
        txtEmail.Text = ""
        txtNama.Text = ""
        txtNoTelpon.Text = ""
        cbAktif.Checked = True
        cbGuruInternal.Checked = False

        objGuru.id = 0
        objGuru.nama = ""
        objGuru.noTelpon = ""
        objGuru.email = ""
        objGuru.aktif = True
        objGuru.internal = False

    End Sub

    Private Sub Guru_Load(sender As Object, e As EventArgs) Handles Me.Load
        tampilListViewGuru()
        populateData()
        Me.MdiParent = MDIParent1
        formready = True
    End Sub

    Private Sub lvGuru_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvGuru.SelectedIndexChanged
        objGuru.id = lvGuru.FocusedItem.Text
        txtNama.Text = lvGuru.FocusedItem.SubItems(1).Text
        txtEmail.Text = lvGuru.FocusedItem.SubItems(2).Text
        txtNoTelpon.Text = lvGuru.FocusedItem.SubItems(3).Text
        cbGuruInternal.Checked = lvGuru.FocusedItem.SubItems(4).Text
        cbAktif.Checked = lvGuru.FocusedItem.SubItems(5).Text
        tampilListviewGK()
        tampilListviewGM()
        cmbKeahlian.Text = ""
        cmbMapel.Text = ""
    End Sub

    Private Sub populateData()
        Dim keahlians As List(Of KeahlianModel)
        keahlians = keahlianService.getAllData
        For Each keahlian As KeahlianModel In keahlians
            cmbKeahlian.Items.Add(keahlian.nama & " [" & keahlian.id & "]")
        Next

        Dim configs As List(Of ConfigModel)
        configs = configService.getAllData
        For Each config As ConfigModel In configs
            cmbTahunAjar.Items.Add(config.tahunAjar)
        Next
        cmbTahunAjar.SelectedIndex = 0
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

    Private Sub btnTambahKeahlian_Click(sender As Object, e As EventArgs) Handles btnTambahKeahlian.Click
        If objGuru.id = 0 Or cmbKeahlian.Text = "" Then
            MsgBox("Guru atau keahlian belum terpilih," & vbCrLf & "silahkan pilih guru dan keahlian", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Submit")
        Else
            guruKeahlianService.insertData(objGuru.id, getFromBracket(cmbKeahlian.Text))
            tampilListviewGK()
        End If
    End Sub

    Private Sub btnHapusKeahlian_Click(sender As Object, e As EventArgs) Handles btnHapusKeahlian.Click
        If objGuru.id = 0 Or cmbKeahlian.Text = "" Then
            MsgBox("Guru atau keahlian belum terpilih," & vbCrLf & "silahkan pilih guru dan keahlian", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Delete")
        Else
            guruKeahlianService.deleteData(objGuru.id, getFromBracket(cmbKeahlian.Text))
            tampilListviewGK()
            cmbKeahlian.SelectedIndex = -1
        End If
    End Sub

    Private Sub lvKeahlian_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvKeahlian.SelectedIndexChanged
        cmbKeahlian.Text = lvKeahlian.FocusedItem.SubItems(1).Text & " [" & lvKeahlian.FocusedItem.Text & "]"
    End Sub

    Private Sub cmbTahunAjar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTahunAjar.SelectedIndexChanged
        If formready Then
            populateMapel()
        End If
    End Sub

    Private Sub populateMapel()
        If cmbTahunAjar.Text = "" Or cmbKeahlian.Text = "" Then
            MsgBox("Mengumpulkan data Mapel, namun tahun ajar atau keahlian belum terpilih," & vbCrLf & "silahkan pilih tahun ajar dan keahlian", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Submit")
        Else
            cmbMapel.Items.Clear()
            Dim mapelList As New List(Of MapelModel)
            mapelList = mapelService.getDistinctMapel(cmbTahunAjar.Text, getFromBracket(cmbKeahlian.Text))
            For Each mapel As MapelModel In mapelList
                cmbMapel.Items.Add(mapel.nama & "-" & mapel.singkatan & "[" & mapel.id & "]")
            Next
        End If

    End Sub

    Private Sub btnTambahMapel_Click(sender As Object, e As EventArgs) Handles btnTambahMapel.Click
        If objGuru.id = 0 Or cmbMapel.Text = "" Then
            MsgBox("Guru atau mapel belum terpilih," & vbCrLf & "silahkan pilih guru dan mapel", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Submit")
        Else
            guruMapelService.insertData(objGuru.id, getFromBracket(cmbMapel.Text))
            tampilListviewGM()
        End If
    End Sub

    Private Sub lvMapel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvMapel.SelectedIndexChanged
        cmbMapel.Text = lvMapel.FocusedItem.SubItems(1).Text & "-" & lvMapel.FocusedItem.SubItems(2).Text & "[" & lvMapel.FocusedItem.Text & "]"
    End Sub

    Private Sub btnHapusMapel_Click(sender As Object, e As EventArgs) Handles btnHapusMapel.Click
        If objGuru.id = 0 Or cmbMapel.Text = "" Then
            MsgBox("Guru atau mapel belum terpilih," & vbCrLf & "silahkan pilih guru dan mapel", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Delete")
        Else
            guruMapelService.deleteData(objGuru.id, getFromBracket(cmbMapel.Text))
            tampilListviewGM()
            cmbMapel.SelectedIndex = -1
        End If
    End Sub

    Private Sub cmbKeahlian_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKeahlian.SelectedIndexChanged
        If formready Then
            populateMapel()
        End If
    End Sub


End Class