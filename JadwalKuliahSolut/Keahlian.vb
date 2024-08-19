Public Class frmkeahlian
    Dim objKeahlian As New KeahlianModel
    Dim keahlianService As New KeahlianService
    Dim reader As OleDb.OleDbDataReader
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtBidang.Text = "" Or txtNama.Text = "" Or txtSingkatan.Text = "" Or TxtProgram.Text = "" Then
            MsgBox("Nama, Program, Bidang, dan Singkatan Harus Diisi," & vbCrLf & "silahkan lengkapi data", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Submit")
        Else
            Call setDataKeahlian()
            If objKeahlian.id = "" Then
                keahlianService.insertData(objKeahlian)
            Else
                keahlianService.updateData(objKeahlian)
            End If
        End If
        tampilListview()
    End Sub
    Private Sub setDataKeahlian()
        objKeahlian.setBidang(txtBidang.Text)
        objKeahlian.setNama(txtNama.Text)
        objKeahlian.setProgram(TxtProgram.Text)
        objKeahlian.setSingkatan(txtSingkatan.Text)
    End Sub

    Private Sub formClear()
        txtBidang.Text = ""
        txtNama.Text = ""
        txtSingkatan.Text = ""
        TxtProgram.Text = ""

        objKeahlian.setBidang("")
        objKeahlian.setNama("")
        objKeahlian.setProgram("")
        objKeahlian.setSingkatan("")
        objKeahlian.setId("")
    End Sub

    Private Sub tampilListview()
        Dim keahlians As List(Of KeahlianModel)
        keahlians = keahlianService.getAllData

        lvKeahlian.Items.Clear()
        Dim lvbarang As ListViewItem
        For Each keahlian As KeahlianModel In keahlians
            lvbarang = lvKeahlian.Items.Add(keahlian.id)
            lvbarang.SubItems.Add(keahlian.nama)
            lvbarang.SubItems.Add(keahlian.program)
            lvbarang.SubItems.Add(keahlian.bidang)
            lvbarang.SubItems.Add(keahlian.singkatan)
        Next
        formClear()
        lvKeahlian.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub frmkeahlian_Load(sender As Object, e As EventArgs) Handles Me.Load
        tampilListview()
        Me.MdiParent = MDIParent1
    End Sub

    Private Sub lvKeahlian_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvKeahlian.SelectedIndexChanged
        objKeahlian.setId(lvKeahlian.FocusedItem.Text)
        txtNama.Text = lvKeahlian.FocusedItem.SubItems(1).Text
        TxtProgram.Text = lvKeahlian.FocusedItem.SubItems(2).Text
        txtBidang.Text = lvKeahlian.FocusedItem.SubItems(3).Text
        txtSingkatan.Text = lvKeahlian.FocusedItem.SubItems(4).Text
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If objKeahlian.id = "" Then
            MsgBox("tidak ada keahlian yang dipilih" & vbCrLf & "silahkan pilih keahlian yang akan dihapus", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Submit")
        Else
            keahlianService.deleteData(objKeahlian)
            Call tampilListview()
        End If
    End Sub
End Class