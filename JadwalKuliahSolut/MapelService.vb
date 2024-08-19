Imports System.Data.OleDb

Public Class MapelService
    Public koneksi As New ClassKoneksi

    Public catatan As String
    Public perintah As OleDb.OleDbCommand
    Public reader As OleDb.OleDbDataReader
    Function getFormData(ByVal mapel As MapelModel) As List(Of MapelModel)
        Return getData("SELECT m.id, m.nama, m.id_keahlian,  a.nama as keahlian, m.tahun_ajar, m.kelas, m.semester, m.time_unit, m.butuh_lab, a.singkatan
        FROM mapel AS m
        INNER JOIN keahlian AS a ON m.id_keahlian = a.id
        WHERE m.tahun_ajar = '" & mapel.tahunAjar & "' 
        and a.id = " & mapel.idKeahlian & " 
        and m.kelas = '" & mapel.kelas & "' 
        and m.semester = '" & mapel.semester & "'  
        and m.dihapus = false ")
    End Function
    Function getDistinctMapel(ByVal tahunAjar As String, ByVal idKeahlian As Integer) As List(Of MapelModel)
        Return getData("
        SELECT m.id, m.nama, m.id_keahlian, a.nama AS keahlian, m.tahun_ajar, m.kelas, m.semester, m.time_unit, m.butuh_lab, a.singkatan
        FROM mapel AS m
        INNER JOIN keahlian AS a ON m.id_keahlian = a.id
        WHERE m.id IN (
            SELECT MIN(sub_m.id)
            FROM mapel AS sub_m
            WHERE sub_m.tahun_ajar = '" & tahunAjar & "'
            AND sub_m.dihapus = false
            AND sub_m.id_keahlian = " & idKeahlian & "
            GROUP BY sub_m.nama
        )
        ORDER BY m.nama;")
    End Function

    Function getData(ByVal sqlstring As String) As List(Of MapelModel)
        bukaKoneksi()
        perintah = New OleDb.OleDbCommand(sqlstring, koneksi.koneksi)
        reader = perintah.ExecuteReader()
        Dim mapels As New List(Of MapelModel)
        While reader.Read
            Dim mapel As New MapelModel
            mapel.id = reader("id")
            mapel.nama = reader("nama")
            mapel.idKeahlian = reader("id_keahlian")
            mapel.Keahlian = reader("keahlian")
            mapel.tahunAjar = reader("tahun_ajar")
            mapel.kelas = reader("kelas")
            mapel.semester = reader("semester")
            mapel.timeUnit = reader("time_unit")
            mapel.butuhLab = reader("butuh_lab")
            mapel.singkatan = reader("singkatan")
            mapels.Add(mapel)
        End While
        tutupKoneksi()
        reader.Close()
        Return mapels
    End Function

    Sub insertData(mapel As MapelModel)
        bukaKoneksi()
        Try
            Using perintah As New OleDbCommand(
                "insert into mapel (nama, id_keahlian, tahun_ajar, kelas, semester, time_unit, butuh_lab ) 
                values ('" & mapel.nama & "', " & mapel.idKeahlian & ", '" & mapel.tahunAjar & "', '" & mapel.kelas &
                "', '" & mapel.semester & "', " & mapel.timeUnit & ", " & mapel.butuhLab & ")", koneksi.koneksi)
                perintah.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Data Gagal disimpan", MsgBoxStyle.Critical, "Insert")
            catatan = "Error : " + ex.ToString
        End Try
        tutupKoneksi()
    End Sub

    Sub updateData(mapel As MapelModel)
        bukaKoneksi()
        Try
            Using perintah As New OleDbCommand(
                "update mapel set nama = '" & mapel.nama & "', id_keahlian = " & mapel.idKeahlian &
                ", tahun_ajar = '" & mapel.tahunAjar & "', kelas = '" & mapel.kelas &
                "', semester =  '" & mapel.semester & "', time_unit = " & mapel.timeUnit &
                ", butuh_lab = " & mapel.butuhLab & " where id = " & mapel.id & ";
                ", koneksi.koneksi)
                perintah.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Data Gagal disimpan", MsgBoxStyle.Critical, "Insert")
            catatan = "Error : " + ex.ToString
        End Try
        tutupKoneksi()
    End Sub

    Sub deleteData(mapel As MapelModel)
        bukaKoneksi()
        Try
            Using perintah As New OleDbCommand(
                "update mapel set dihapus = true where id = " & mapel.id, koneksi.koneksi)
                perintah.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Data Gagal disimpan", MsgBoxStyle.Critical, "Insert")
            catatan = "Error : " + ex.ToString
        End Try
        tutupKoneksi()
    End Sub
    Sub tutupKoneksi()
        koneksi.koneksi.Close()
        perintah.Dispose()
    End Sub
    Sub bukaKoneksi()
        koneksi.koneksi.Open()
    End Sub
End Class
