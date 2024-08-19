Imports System.Data.OleDb
Imports System.Data.SqlTypes

Public Class GuruKeahlianService
    Public koneksi As New ClassKoneksi

    Public catatan As String
    Public perintah As OleDb.OleDbCommand
    Public reader As OleDb.OleDbDataReader

    Function getKeahlianGuru(ByVal guruId As Integer) As List(Of GuruKeahlianModel)
        bukaKoneksi()
        perintah = New OleDb.OleDbCommand("
        SELECT 
            gk.id_guru, 
            g.nama AS [nama_guru], 
            gk.id_keahlian, 
            a.nama AS [nama_keahlian]
        FROM 
            (guru_keahlian AS gk
            INNER JOIN guru AS g ON gk.id_guru = g.id)
            INNER JOIN keahlian AS a ON gk.id_keahlian = a.id
        where gk.id_guru = " & guruId & ";", koneksi.koneksi)
        reader = perintah.ExecuteReader()
        Dim listData As New List(Of GuruKeahlianModel)
        While reader.Read
            Dim gurah As New GuruKeahlianModel
            gurah.id_Guru = reader("id_guru")
            gurah.id_keahlian = reader("id_keahlian")
            gurah.nama_guru = reader("nama_guru")
            gurah.nama_keahlian = reader("nama_keahlian")
            listData.Add(gurah)
        End While
        tutupKoneksi()
        reader.Close()
        Return listData
    End Function

    Sub insertData(idGuru As Integer, idKeahlian As String)
        insertData(idGuru, Integer.Parse(idKeahlian))
    End Sub

    Sub insertData(idGuru As Integer, idKeahlian As Integer)
        bukaKoneksi()
        Try
            Using perintah As New OleDbCommand(
                "insert into guru_keahlian (id_guru, id_keahlian ) 
                values (" & idGuru & ", " & idKeahlian & " )", koneksi.koneksi)
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

    Sub deleteData(idGuru As Integer, idKeahlian As Integer)
        bukaKoneksi()
        Try
            Using perintah As New OleDbCommand(
                "delete from guru_keahlian where id_guru = " & idGuru & " and id_keahlian = " & idKeahlian & "", koneksi.koneksi)
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
