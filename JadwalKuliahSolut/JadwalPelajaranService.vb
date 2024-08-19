Imports System.Data.OleDb

Public Class JadwalPelajaranService
    Public koneksi As New ClassKoneksi

    Public catatan As String
    Public perintah As OleDb.OleDbCommand
    Public reader As OleDb.OleDbDataReader

    Function getJadwalByHariTA(ByVal ta As String, ByVal hari As String, ByVal namaKelas As String, ByVal semester As String)
        Return getJadwalPelajaran("
        SELECT t.tampil,t.nama as nama_kegiatan, t.pelajaran, t.hari, t.id AS tt_id, j.id, j.id_guru, j.nama_guru, t.tahun_ajar AS t_tahun_ajar, j.nama_kelas, j.id_mapel, j.nama_mapel, j.semester
        FROM time_table AS t
        LEFT JOIN (
            SELECT * FROM jadwal_pelajaran where nama_kelas = '" & namaKelas & "' and semester = '" & semester & "' 
        ) AS j ON t.id = j.tt_id  
        WHERE t.tahun_ajar = '" & ta & "' 
        AND t.hari like '" & hari & "'
        ORDER BY t.hari, t.index_hari;")
    End Function

    Function getJadwalPelajaran(ByVal sqlString As String) As List(Of JadwalPelajaranModel)
        bukaKoneksi()
        Dim listData As New List(Of JadwalPelajaranModel)
        Try
            perintah = New OleDb.OleDbCommand(sqlString, koneksi.koneksi)
            reader = perintah.ExecuteReader()
            While reader.Read
                Dim jadwalPelajaran As New JadwalPelajaranModel
                jadwalPelajaran.idTimeTable = reader("tt_id")
                jadwalPelajaran.tahunAjar = reader("t_tahun_ajar")
                jadwalPelajaran.tampil = reader("tampil")
                jadwalPelajaran.namaKegiatan = reader("nama_kegiatan")
                jadwalPelajaran.pelajaran = reader("pelajaran")
                jadwalPelajaran.hari = reader("hari")
                If Not IsDBNull(reader("id_guru")) Then
                    jadwalPelajaran.idGuru = reader("id_guru")
                End If
                If Not IsDBNull(reader("nama_guru")) Then
                    jadwalPelajaran.namaGuru = reader("nama_guru")
                End If
                If Not IsDBNull(reader("nama_kelas")) Then
                    jadwalPelajaran.namaKelas = reader("nama_kelas")
                End If
                If Not IsDBNull(reader("id_mapel")) Then
                    jadwalPelajaran.idMapel = reader("id_mapel")
                End If
                If Not IsDBNull(reader("nama_mapel")) Then
                    jadwalPelajaran.namaMapel = reader("nama_mapel")
                End If
                If Not IsDBNull(reader("id")) Then
                    jadwalPelajaran.id = reader("id")
                End If
                If Not IsDBNull(reader("semester")) Then
                    jadwalPelajaran.id = reader("semester")
                End If
                listData.Add(jadwalPelajaran)
            End While

        Catch ex As Exception
            catatan = "Error : " + ex.ToString
            MsgBox("Data Gagal dicari " & catatan, MsgBoxStyle.Critical, "Find")
        End Try
        tutupKoneksi()
        reader.Close()
        Return listData
    End Function

    Function getJadwalPelajaranForm(tTable As JadwalPelajaranModel) As List(Of JadwalPelajaranModel)
        Return getJadwalPelajaran("
        select * from time_table 
        where tahun_ajar = '" & tTable.tahunAjar & "'  
        order by hari, index_hari asc;")
    End Function
    Function getTtableByTA(ByVal ta As String) As List(Of JadwalPelajaranModel)
        Return getJadwalPelajaran("select * from time_table 
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

    Private Function MapelFull(connection As OleDbConnection, objJadwalPelajaran As JadwalPelajaranModel) As Boolean

        Dim countJadwal As New Integer
        Using command As New OleDbCommand("SELECT COUNT(*) FROM jadwal_pelajaran WHERE id_mapel = @MapelId 
                                            AND nama_kelas = @Kelas AND tahun_ajar = @TA AND semester = @Semester ", connection)
            command.Parameters.AddWithValue("@MapelId", objJadwalPelajaran.idMapel)
            command.Parameters.AddWithValue("@Kelas", objJadwalPelajaran.namaKelas)
            command.Parameters.AddWithValue("@TA", objJadwalPelajaran.tahunAjar)
            command.Parameters.AddWithValue("@Semester", objJadwalPelajaran.semester)
            countJadwal = Convert.ToInt32(command.ExecuteScalar())

            If countJadwal = 0 Then
                Return False
            End If
        End Using

        Using command2 As New OleDbCommand("SELECT time_unit FROM mapel WHERE id = @MapelId", connection)
            command2.Parameters.AddWithValue("@MapelId", objJadwalPelajaran.idMapel)
            Dim countTU As New Integer
            countTU = Convert.ToInt32(command2.ExecuteScalar())

            If countJadwal < countTU Then
                Return False
            End If
        End Using

        Return True
    End Function

    Sub insertData(objJadwalPelajaran As JadwalPelajaranModel)
        bukaKoneksi()
        Try
            If Not MapelFull(koneksi.koneksi, objJadwalPelajaran) Then
                Using command As New OleDbCommand("
                            INSERT INTO jadwal_pelajaran (tahun_ajar, semester, id_guru, nama_guru, nama_kelas, id_mapel, nama_mapel, tt_id, tampil) 
                                              VALUES (@tahun_ajar, @semester, @id_guru, @nama_guru, @nama_kelas, @id_mapel, @nama_mapel, @tt_id, @tampil)", koneksi.koneksi)
                    command.Parameters.AddWithValue("@tahun_ajar", objJadwalPelajaran.tahunAjar)
                    command.Parameters.AddWithValue("@semester", objJadwalPelajaran.semester)
                    command.Parameters.AddWithValue("@id_guru", objJadwalPelajaran.idGuru)
                    command.Parameters.AddWithValue("@nama_guru", objJadwalPelajaran.namaGuru)
                    command.Parameters.AddWithValue("@nama_kelas", objJadwalPelajaran.namaKelas)
                    command.Parameters.AddWithValue("@id_mapel", objJadwalPelajaran.idMapel)
                    command.Parameters.AddWithValue("@nama_mapel", objJadwalPelajaran.namaMapel)
                    command.Parameters.AddWithValue("@tt_id", objJadwalPelajaran.idTimeTable)
                    command.Parameters.AddWithValue("@tampil", objJadwalPelajaran.tampil)

                    command.ExecuteNonQuery()
                End Using
            Else
                MsgBox("Data Gagal disimpan " & vbCrLf & "Mapel sudah memenuhi time unit", MsgBoxStyle.Critical, "Insert")
            End If
        Catch ex As Exception
            catatan = "Error : " + ex.ToString
            If ex.ToString.Contains("duplicate") Then
                MsgBox("Data Gagal disimpan " & vbCrLf & "pada semester ini, Guru sudah mengajar pada jam ini", MsgBoxStyle.Critical, "Insert")
            Else
                MsgBox("Data Gagal disimpan " & catatan, MsgBoxStyle.Critical, "Insert")
            End If

        Finally
            tutupKoneksi()
        End Try

    End Sub

    Sub tutupKoneksi()
        koneksi.koneksi.Close()
    End Sub
    Sub bukaKoneksi()
        koneksi.koneksi.Open()
    End Sub
End Class
