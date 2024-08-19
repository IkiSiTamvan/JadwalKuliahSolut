Imports System.Runtime.CompilerServices

Public Class JadwalGuru
    Dim configService As New ConfigService
    Dim guruService As New GuruService
    Dim timeTableService As New TimeTableService
    Dim jadwalGuruService As New JadwalGuruService
    Dim key As String = "%"
    Private Sub JadwalGuru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateData()
        tampilListViewGuru()
        Me.MdiParent = MDIParent1
    End Sub

    Private Sub populateData()
        Dim configs As List(Of ConfigModel)
        configs = configService.getAllData
        For Each config As ConfigModel In configs
            cmbTahunAjar.Items.Add(config.tahunAjar)
        Next
        cmbTahunAjar.Text = cmbTahunAjar.Items(0)

        cmbFind.SelectedIndex = 0
    End Sub

    Private Sub tampilListViewGuru()
        Dim gurus As List(Of GuruModel)
        gurus = guruService.searchGuru(cmbFind.Text, key)

        LvGuru.Items.Clear()
        Dim lvitem As ListViewItem
        For Each guru As GuruModel In gurus
            lvitem = LvGuru.Items.Add(guru.id)
            lvitem.SubItems.Add(guru.nama)
            lvitem.SubItems.Add(guru.email)
            lvitem.SubItems.Add(guru.noTelpon)
            lvitem.SubItems.Add(guru.internal)
            lvitem.SubItems.Add(guru.aktif)
        Next
        txtIdGuru.Text = ""
        txtNama.Text = ""
        LvGuru.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub LvGuru_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvGuru.SelectedIndexChanged
        txtIdGuru.Text = LvGuru.FocusedItem.Text
        txtNama.Text = LvGuru.FocusedItem.SubItems(1).Text
        tampilCheckedListbox()
    End Sub

    Private Sub txtFind_TextChanged(sender As Object, e As EventArgs) Handles txtFind.TextChanged
        key = txtFind.Text
    End Sub

    Private Sub txtFind_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFind.KeyUp
        If e.KeyCode = Keys.Enter Then
            tampilListViewGuru()
        End If
    End Sub

    Private Sub tampilCheckedListbox()
        Dim jadwalGurus As List(Of JadwalGuruModel)
        If txtIdGuru.Text = "" Then
            jadwalGurus = jadwalGuruService.getJGuruByTA(cmbTahunAjar.Text)
        Else
            jadwalGurus = jadwalGuruService.getJGuruByIdGuru_TA(cmbTahunAjar.Text, txtIdGuru.Text)
        End If

        clearCheckedListBox()

        For Each ttable As JadwalGuruModel In jadwalGurus
            If ttable.pelajaran Then
                If ttable.hari = "Senin" Then
                    clbSenin.Items.Add(ttable)
                    If Not ttable.idGuru = Nothing Then
                        clbSenin.SetItemChecked(clbSenin.Items.Count - 1, True)
                    End If
                ElseIf ttable.hari = "Selasa" Then
                    clbSelasa.Items.Add(ttable)
                    If Not ttable.idGuru = Nothing Then
                        clbSelasa.SetItemChecked(clbSelasa.Items.Count - 1, True)
                    End If
                ElseIf ttable.hari = "Rabu" Then
                    clbRabu.Items.Add(ttable)
                    If Not ttable.idGuru = Nothing Then
                        clbRabu.SetItemChecked(clbRabu.Items.Count - 1, True)
                    End If
                ElseIf ttable.hari = "Kamis" Then
                    clbKamis.Items.Add(ttable)
                    If Not ttable.idGuru = Nothing Then
                        clbKamis.SetItemChecked(clbKamis.Items.Count - 1, True)
                    End If
                ElseIf ttable.hari = "Jumat" Then
                    clbJumat.Items.Add(ttable)
                    If Not ttable.idGuru = Nothing Then
                        clbJumat.SetItemChecked(clbJumat.Items.Count - 1, True)
                    End If
                ElseIf ttable.hari = "Sabtu" Then
                    clbSabtu.Items.Add(ttable)
                    If Not ttable.idGuru = Nothing Then
                        clbSabtu.SetItemChecked(clbSabtu.Items.Count - 1, True)
                    End If
                ElseIf ttable.hari = "Minggu" Then
                    clbMinggu.Items.Add(ttable)
                    If Not ttable.idGuru = Nothing Then
                        clbMinggu.SetItemChecked(clbMinggu.Items.Count - 1, True)
                    End If
                End If
            End If
        Next

    End Sub
    Private Sub clearCheckedListBox()
        clbSenin.Items.Clear()
        clbSelasa.Items.Clear()
        clbRabu.Items.Clear()
        clbKamis.Items.Clear()
        clbJumat.Items.Clear()
        clbSabtu.Items.Clear()
        clbMinggu.Items.Clear()
    End Sub

    Private Sub cmbTahunAjar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTahunAjar.SelectedIndexChanged
        txtIdGuru.Text = ""
        txtNama.Text = ""
        tampilCheckedListbox()
    End Sub

    Private Sub cbSenin_CheckedChanged(sender As Object, e As EventArgs) Handles cbSenin.CheckedChanged
        Dim checked As Boolean = cbSenin.Checked
        For i As Integer = 0 To clbSenin.Items.Count - 1
            clbSenin.SetItemChecked(i, checked)
        Next
    End Sub

    Private Sub cbSelasa_CheckedChanged(sender As Object, e As EventArgs) Handles cbSelasa.CheckedChanged
        Dim checked As Boolean = cbSelasa.Checked
        For i As Integer = 0 To clbSelasa.Items.Count - 1
            clbSelasa.SetItemChecked(i, checked)
        Next
    End Sub

    Private Sub cbRabu_CheckedChanged(sender As Object, e As EventArgs) Handles cbRabu.CheckedChanged
        Dim checked As Boolean = cbRabu.Checked
        For i As Integer = 0 To clbRabu.Items.Count - 1
            clbRabu.SetItemChecked(i, checked)
        Next
    End Sub

    Private Sub cbKamis_CheckedChanged(sender As Object, e As EventArgs) Handles cbKamis.CheckedChanged
        Dim checked As Boolean = cbKamis.Checked
        For i As Integer = 0 To clbKamis.Items.Count - 1
            clbKamis.SetItemChecked(i, checked)
        Next
    End Sub

    Private Sub cbJumat_CheckedChanged(sender As Object, e As EventArgs) Handles cbJumat.CheckedChanged
        Dim checked As Boolean = cbJumat.Checked
        For i As Integer = 0 To clbJumat.Items.Count - 1
            clbJumat.SetItemChecked(i, checked)
        Next
    End Sub

    Private Sub cbSabtu_CheckedChanged(sender As Object, e As EventArgs) Handles cbSabtu.CheckedChanged
        Dim checked As Boolean = cbSabtu.Checked
        For i As Integer = 0 To clbSabtu.Items.Count - 1
            clbSabtu.SetItemChecked(i, checked)
        Next
    End Sub

    Private Sub cbMinggu_CheckedChanged(sender As Object, e As EventArgs) Handles cbMinggu.CheckedChanged
        Dim checked As Boolean = cbMinggu.Checked
        For i As Integer = 0 To clbMinggu.Items.Count - 1
            clbMinggu.SetItemChecked(i, checked)
        Next
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtIdGuru.Text = "" Then
            MsgBox("Guru belum dipilih," & vbCrLf & "silahkan pilih guru", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Submit")
        Else
            jadwalGuruService.insertData(clbSenin, txtIdGuru.Text, txtNama.Text, cmbTahunAjar.Text)
            jadwalGuruService.insertData(clbSelasa, txtIdGuru.Text, txtNama.Text, cmbTahunAjar.Text)
            jadwalGuruService.insertData(clbRabu, txtIdGuru.Text, txtNama.Text, cmbTahunAjar.Text)
            jadwalGuruService.insertData(clbKamis, txtIdGuru.Text, txtNama.Text, cmbTahunAjar.Text)
            jadwalGuruService.insertData(clbJumat, txtIdGuru.Text, txtNama.Text, cmbTahunAjar.Text)
            jadwalGuruService.insertData(clbSabtu, txtIdGuru.Text, txtNama.Text, cmbTahunAjar.Text)
            jadwalGuruService.insertData(clbMinggu, txtIdGuru.Text, txtNama.Text, cmbTahunAjar.Text)

            tampilCheckedListbox()
        End If
    End Sub
End Class