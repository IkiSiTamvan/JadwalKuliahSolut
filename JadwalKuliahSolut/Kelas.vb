Public Class Kelas
    Dim keahlianService As New KeahlianService
    Dim configService As New ConfigService
    Dim kelasService As New KelasService
    Dim objKelas As New KelasModel
    Dim listKelas As New List(Of KelasModel)
    Dim listKeahlian As New List(Of KeahlianModel)
    Dim listConfig As New List(Of ConfigModel)
    Dim formReady As New Boolean

    Private Sub populateData()
        Dim keahlians As List(Of KeahlianModel)
        keahlians = keahlianService.getAllData
        For Each keahlian As KeahlianModel In keahlians
            cmbKeahlian.Items.Add(keahlian.nama & " [" & keahlian.id & "]")
        Next
        listKeahlian = keahlians
        cmbKeahlian.Text = cmbKeahlian.Items(0)

        Dim configs As List(Of ConfigModel)
        configs = configService.getAllData
        For Each config As ConfigModel In configs
            cmbTahunAjar.Items.Add(config.tahunAjar)
        Next
        cmbTahunAjar.Text = cmbTahunAjar.Items(0)
        listConfig = configs
        populateAngkatan()
    End Sub

    Private Sub populateAngkatan()
        For Each config As ConfigModel In listConfig
            If config.tahunAjar = cmbTahunAjar.Text Then
                cmbTahunAngkatan.DataSource = configService.getListAngkatan(config.tahunAngkatan)
            End If
        Next
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Kelas_Load(sender As Object, e As EventArgs) Handles Me.Load
        populateData()
        formReady = True
        Me.MdiParent = MDIParent1
    End Sub
    Private Sub setDataKelas()
        objKelas.nama = txtNama.Text
        objKelas.idKeahlian = getFromBracket(cmbKeahlian.Text)
        objKelas.tahunAngkatan = cmbTahunAngkatan.Text
    End Sub

    Private Sub tampilListView()
        setDataKelas()
        Dim kelass As List(Of KelasModel)
        kelass = kelasService.getAllData(objKelas)

        lvKelas.Items.Clear()
        Dim lvItem As ListViewItem
        For Each kelas As KelasModel In kelass
            lvItem = lvKelas.Items.Add(kelas.id)
            lvItem.SubItems.Add(kelas.nama)
            lvItem.SubItems.Add(kelas.idKeahlian)
            lvItem.SubItems.Add(kelas.Keahlian)
            lvItem.SubItems.Add(kelas.tahunAngkatan)
        Next
        listKelas = kelass
        formClear()
        lvKelas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
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
        Return Integer.Parse(result)
    End Function
    Private Sub formClear()
        txtNama.Text = ""

        objKelas.id = 0
        objKelas.keahlian = ""
        objKelas.idKeahlian = 0
        objKelas.nama = ""
        objKelas.tahunAngkatan = ""
    End Sub

    Private Sub cmbTahunAjar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTahunAjar.SelectedIndexChanged
        populateAngkatan()
    End Sub

    Private Sub btnTambahKelas_Click(sender As Object, e As EventArgs) Handles btnTambahKelas.Click
        Dim result As DialogResult =
                MessageBox.Show("Data ini akan sulit dihapus jika Jadwal Pelajaran sudah dibuat" &
                                vbCrLf & "simpan data kelas baru?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            If listKelas.Count = 0 Then
                generateNewKelasName(False)
            Else
                generateNewKelasName(True)
            End If
            Call setDataKelas()
            kelasService.insertData(objKelas)
            tampilListView()
        End If
    End Sub
    Private Sub generateNewKelasName(ByVal classIncrease As Boolean)
        If classIncrease = False Then
            Dim namaKelas As String = getSingkatan(getFromBracket(cmbKeahlian.Text))
            namaKelas = namaKelas & cmbTahunAngkatan.Text
            txtNama.Text = namaKelas & "-1"
        Else
            Dim namaKelas As String = lvKelas.Items(0).SubItems(1).Text
            ' Extract the last character as a string
            Dim lastCharString As String = namaKelas.Substring(namaKelas.Length - 1)

            ' Convert the last character to an integer and increment it
            Dim lastNumber As Integer = Integer.Parse(lastCharString) + 1

            ' Remove the last character from the original string and append the incremented number
            Dim newString As String = namaKelas.Substring(0, namaKelas.Length - 1) & lastNumber.ToString()

            txtNama.Text = newString
        End If
    End Sub
    Function getSingkatan(ByVal idKeahlian As Integer)
        For Each keahlian As KeahlianModel In listKeahlian
            If idKeahlian = keahlian.id Then
                Return keahlian.singkatan
            End If
        Next
    End Function
    Private Sub cmbKeahlian_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKeahlian.SelectedIndexChanged
        cmbchange()
    End Sub

    Private Sub cmbchange()
        If formReady Then
            tampilListView()
        End If
    End Sub

    Private Sub cmbTahunAngkatan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTahunAngkatan.SelectedIndexChanged
        cmbchange()
    End Sub

    Private Sub lvKelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvKelas.SelectedIndexChanged
        objKelas.id = lvKelas.FocusedItem.Text
        txtNama.Text = lvKelas.FocusedItem.SubItems(1).Text
    End Sub
End Class