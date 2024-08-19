Public Class FormMasterDosen
    Dim pesan As String

    Dim objDosen As New ClassDosen
    Dim reader As OleDb.OleDbDataReader
    Dim find As String = ""

    Sub tampilListView()
        objDosen.bukaKoneksi()
        objDosen.getDataDosen(Trim(cmbTemukan.Text), find)
        reader = objDosen.DosenReader

        ListView1.Items.Clear()

        If reader.HasRows Then
            Dim lvBarang As ListViewItem
            While reader.Read
                lvBarang = ListView1.Items.Add(reader("IdDosen"))
                lvBarang.SubItems.Add(reader("namaDosen"))
                lvBarang.SubItems.Add(reader("kompetensi"))
                lvBarang.SubItems.Add(reader("noTelepon"))
                lvBarang.SubItems.Add(reader("alamatE_Mail"))
            End While
        End If
        reader.Close()
        objDosen.tutupKoneksi()
        Catatan.Text = "Terdapat " & ListView1.Items.Count & " record"

    End Sub

    Sub setDataDosen()

        objDosen.setIdDosen(txtIdDosen.Text)
        objDosen.setNamaDosen(txtNamaDosen.Text)
        objDosen.setKompetensi(cmbKompetensi.Text)
        objDosen.setAlamatEMail(txtAlamatEMail.Text)
        objDosen.setNoTelepon(txtNoTelepon.Text)

    End Sub

    Private Sub cmdSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubmit.Click
        If txtIdDosen.Text = "" Or txtNamaDosen.Text = "" Or cmbKompetensi.Text = "" Or txtNoTelepon.Text = "" Or txtAlamatEMail.Text = "" Then
            MsgBox("Data dosen belum terisi dengan sempurna," & vbCrLf & "silahkan lengkapi data", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Submit")
        Else
            objDosen.bukaKoneksi()
            Call setDataDosen()
            objDosen.getDataDosen("IdDosen", txtIdDosen.Text)
            reader = objDosen.DosenReader

            If reader.HasRows Then
                pesan = MsgBox("Submit dapat menyebabkan perubahan data," & vbCrLf & "Simpan perubahan?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Submit")
                If pesan = vbOK Then
                    objDosen.updateDosen()

                    objDosen.tutupKoneksi()
                    reader.Close()
                    Catatan.Text = objDosen.catatan

                    setDataDosen()
                    Call tampilListView()
                End If
            Else
                pesan = MsgBox("Submit akan menyimpan data baru," & vbCrLf & "Simpan perubahan?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Submit")
                If pesan = vbOK Then
                    objDosen.insertDosen()

                    objDosen.tutupKoneksi()
                    reader.Close()
                    Catatan.Text = objDosen.catatan

                    setDataDosen()
                    Call tampilListView()
                End If
            End If
        End If

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        txtIdDosen.Enabled = False
        txtIdDosen.Text = ListView1.FocusedItem.Text
        txtNamaDosen.Text = ListView1.FocusedItem.SubItems(1).Text
        cmbKompetensi.Text = ListView1.FocusedItem.SubItems(2).Text
        txtNoTelepon.Text = ListView1.FocusedItem.SubItems(3).Text
        txtAlamatEMail.Text = ListView1.FocusedItem.SubItems(4).Text
    End Sub

    Private Sub txtNoTelepon_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoTelepon.KeyPress
        If e.KeyChar <> Chr(13) And IsNumeric(e.KeyChar) = False And e.KeyChar <> vbBack Then
            e.KeyChar = Chr(0)
        End If
    End Sub

    Private Sub cmdDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDefault.Click
        txtIdDosen.Text = ""
        txtIdDosen.Enabled = True
        txtAlamatEMail.Text = ""
        txtNoTelepon.Text = ""
        txtNamaDosen.Text = ""
        cmbKompetensi.SelectedIndex = -1
        Catatan.Text = "Catatan"
    End Sub

    Private Sub cmdTemukan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTemukan.Click
        find = InputBox("Masukan " & cmbTemukan.Text & " yang ingin anda cari.", "Find")
        setDataDosen()
        tampilListView()
        Catatan.Text = "Ditemukan " & ListView1.Items.Count & " record yang sesuai"
    End Sub

    Private Sub cmdAmbil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAmbil.Click
        If txtIdDosen.Text = "" Or txtNamaDosen.Text = "" Or cmbKompetensi.Text = "" Or txtNoTelepon.Text = "" Or txtAlamatEMail.Text = "" Then
            MsgBox("Pilih data diri dosen pada list untuk mengambil data.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Submit")
        Else
            FormJadwalSP.txtKodeDosen.Text = txtIdDosen.Text
            FormJadwalSP.txtNamaDosen.Text = txtNamaDosen.Text
            FormJadwalSP.txtNoTeleponD.Text = txtNoTelepon.Text
            FormJadwalSP.txtKompetensiDosen.Text = cmbKompetensi.Text
            FormJadwalSP.txtAlamatEmail.Text = txtAlamatEMail.Text
            cmdAmbil.Visible = False
            Me.Close()
        End If

    End Sub

    Private Sub FormMasterDosen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampilListView()
        Me.MdiParent = MDIParent1
    End Sub

    
End Class