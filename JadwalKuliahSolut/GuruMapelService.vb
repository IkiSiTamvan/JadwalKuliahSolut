Imports System.Data.OleDb

Public Class GuruMapelService
    Public koneksi As New ClassKoneksi

    Public catatan As String
    Public perintah As OleDb.OleDbCommand
    Public reader As OleDb.OleDbDataReader

    Function getMapelGuru(ByVal guruId As Integer) As List(Of GuruMapelModel)
        bukaKoneksi()
        perintah = New OleDb.OleDbCommand("
        SELECT 
            gm.id_guru, 
            g.nama AS [nama_guru], 
            gm.id_mapel, 
            a.singkatan,
            m.nama as [mapel]
        FROM 
            ((guru_mapel AS gm
            INNER JOIN guru AS g ON gm.id_guru = g.id)
            INNER JOIN mapel AS m ON gm.id_mapel = m.id)
            INNER JOIN keahlian as a on m.id_keahlian = a.id 
        where gm.id_guru = " & guruId & ";", koneksi.koneksi)
        reader = perintah.ExecuteReader()
        Dim listData As New List(Of GuruMapelModel)
        While reader.Read
            Dim gupel As New GuruMapelModel
            gupel.idGuru = reader("id_guru")
            gupel.idMapel = reader("id_mapel")
            gupel.namaGuru = reader("nama_guru")
            gupel.namaMapel = reader("mapel")
            gupel.singkatan = reader("singkatan")
            listData.Add(gupel)
        End While
        tutupKoneksi()
        reader.Close()
        Return listData
    End Function

    Sub insertData(idGuru As Integer, idKeahlian As String)
        insertData(idGuru, Integer.Parse(idKeahlian))
    End Sub

    Sub insertData(idGuru As Integer, idMapel As Integer)
        bukaKoneksi()
        Try
            Using perintah As New OleDbCommand(
                "insert into guru_mapel (id_guru, id_mapel ) 
                values (" & idGuru & ", " & idMapel & " )", koneksi.koneksi)
                perintah.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            catatan = "Error : " + ex.ToString
            If catatan.Contains("duplicate values") Then
                catatan = "Error : keahlian ini sudah disimpan"
            End If
            MsgBox("Data Gagal disimpan " & catatan, MsgBoxStyle.Critical, "Insert")
        End Try
        tutupKoneksi()
    End Sub

    Sub deleteData(idGuru As Integer, idmapel As Integer)
        bukaKoneksi()
        Try
            Using perintah As New OleDbCommand(
                "delete from guru_mapel where id_guru = " & idGuru & " and id_mapel = " & idmapel & "", koneksi.koneksi)
                perintah.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            catatan = "Error : " + ex.ToString
            MsgBox("Data Gagal dihapus " & catatan, MsgBoxStyle.Critical, "Delete")
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
