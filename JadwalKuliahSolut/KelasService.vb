Imports System.Data.OleDb

Public Class KelasService
    Public koneksi As New ClassKoneksi

    Public catatan As String
    Public perintah As OleDb.OleDbCommand
    Public reader As OleDb.OleDbDataReader
    Function getAllData(ByVal kelas As KelasModel) As List(Of KelasModel)
        Return getData("select k.id, k.nama, k.id_keahlian, a.nama as keahlian, k.tahun_angkatan
        from kelas2 as k 
        inner join keahlian as a on k.id_keahlian = a.id
        where k.tahun_angkatan = '" & kelas.tahunAngkatan & "' 
        and k.id_keahlian = " & kelas.idKeahlian & " 
        order by k.nama desc")
    End Function

    Function getDataByTA_KelasKeahlian(ByVal TA As String, ByVal kelas As String, ByVal idKeahlian As Integer) As List(Of KelasModel)
        Dim splitYears() As String
        splitYears = TA.Split("-"c)
        TA = splitYears(0)
        Dim yearReducer As New Integer
        Select Case kelas
            Case "X"
                yearReducer = 0
            Case "XI"
                yearReducer = 1
            Case "XII"
                yearReducer = 2
            Case Else
                MsgBox("kelas tidak valid " & catatan, MsgBoxStyle.Critical, "Get Data")
        End Select

        Dim yearAsInteger As Integer = Convert.ToInt32(TA) - yearReducer
        TA = yearAsInteger.ToString

        Return getData("select *, '' as keahlian from kelas2 where tahun_angkatan = '" & TA & "' and id_keahlian = " & idKeahlian & "")
    End Function

    Function getData(ByVal sqlstring As String) As List(Of KelasModel)
        bukaKoneksi()
        perintah = New OleDb.OleDbCommand(sqlstring, koneksi.koneksi)
        reader = perintah.ExecuteReader()
        Dim kelass As New List(Of KelasModel)
        While reader.Read
            Dim kelas As New KelasModel
            kelas.id = reader("id")
            kelas.nama = reader("nama")
            kelas.tahunAngkatan = reader("tahun_angkatan")
            kelas.idKeahlian = reader("id_keahlian")
            kelas.keahlian = reader("keahlian")
            kelass.Add(kelas)
        End While
        tutupKoneksi()
        reader.Close()
        Return kelass
    End Function
    Sub insertData(kelas As KelasModel)
        bukaKoneksi()
        Try
            Using perintah As New OleDbCommand(
                "insert into kelas2 (nama, id_keahlian, tahun_angkatan ) 
                values ('" & kelas.nama & "', " & kelas.idKeahlian & ", '" & kelas.tahunAngkatan & "' )", koneksi.koneksi)
                perintah.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            catatan = "Error : " + ex.ToString
            MsgBox("Data Gagal disimpan " & catatan, MsgBoxStyle.Critical, "Insert")
        End Try
        tutupKoneksi()
    End Sub
    Sub tutupKoneksi()
        koneksi.koneksi.Close()
    End Sub
    Sub bukaKoneksi()
        koneksi.koneksi.Open()
    End Sub
End Class
