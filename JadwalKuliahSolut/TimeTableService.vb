Imports System.Data.OleDb

Public Class TimeTableService
    Public koneksi As New ClassKoneksi

    Public catatan As String
    Public perintah As OleDb.OleDbCommand
    Public reader As OleDb.OleDbDataReader

    Function getTtable(ByVal sqlString As String) As List(Of TimeTableModel)
        bukaKoneksi()
        Dim listData As New List(Of TimeTableModel)
        Try
            perintah = New OleDb.OleDbCommand(sqlString, koneksi.koneksi)
            reader = perintah.ExecuteReader()
            While reader.Read
                Dim tTableResult As New TimeTableModel
                tTableResult.id = reader("id")
                tTableResult.hari = reader("hari")
                tTableResult.nama = reader("nama")
                tTableResult.index = reader("index_hari")
                tTableResult.mulai = reader("mulai")
                tTableResult.menit = reader("menit")
                tTableResult.akhir = reader("akhir")
                tTableResult.tampil = reader("tampil")
                tTableResult.pelajaran = reader("pelajaran")
                tTableResult.tahunAjar = reader("tahun_ajar")
                listData.Add(tTableResult)
            End While

        Catch ex As Exception
            catatan = "Error : " + ex.ToString
            MsgBox("Data Gagal dicari " & catatan, MsgBoxStyle.Critical, "Find")
        End Try
        tutupKoneksi()
        reader.Close()
        Return listData
    End Function

    Function getTtableForm(tTable As TimeTableModel) As List(Of TimeTableModel)
        Return getTtable("
        select * from time_table 
        where tahun_ajar = '" & tTable.tahunAjar & "'  
        and hari like '" & tTable.hari & "'
        order by hari, index_hari asc;")
    End Function
    Function getTtableByTA(ByVal ta As String)
        Return getTtable("select * from time_table 
        where tahun_ajar = '" & ta & "' 
        order by index_hari asc;")
    End Function


    Sub insertData(tTable As TimeTableModel)
        bukaKoneksi()
        If tTable.pelajaran = True Then
            tTable.nama = "-"
        End If
        Try
            Using perintah As New OleDbCommand(
                "insert into time_table (hari, nama, index_hari, mulai, menit, akhir, tampil, pelajaran, tahun_ajar ) 
                values ('" & tTable.hari & "', '" & tTable.nama & "', '" & tTable.index & "', '" & tTable.mulai & "', '" & tTable.menit & "', '" & tTable.akhir & "', '" & tTable.tampil & "',  " & tTable.pelajaran & ", '" & tTable.tahunAjar & "' )", koneksi.koneksi)
                perintah.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            catatan = "Error : " + ex.ToString
            MsgBox("Data Gagal disimpan " & catatan, MsgBoxStyle.Critical, "Insert")
        End Try
        tutupKoneksi()
    End Sub


    Sub deleteData(idTtable As Integer)
        bukaKoneksi()
        Try
            Using perintah As New OleDbCommand(
                "delete from time_table where id = " & idTtable, koneksi.koneksi)
                perintah.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            catatan = "Error : " + ex.ToString
            MsgBox("Data Gagal dihapus " & catatan, MsgBoxStyle.Critical, "Delete")
        End Try
        tutupKoneksi()
    End Sub

    Sub deleteDataHari(tTable As TimeTableModel)
        bukaKoneksi()
        Try
            Using perintah As New OleDbCommand(
                "delete from time_table where hari = '" & tTable.hari & "' and tahun_ajar = '" & tTable.tahunAjar & "'", koneksi.koneksi)
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
