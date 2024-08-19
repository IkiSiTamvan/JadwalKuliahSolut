Imports System.Data.OleDb

Public Class JadwalGuruService
    Public koneksi As New ClassKoneksi

    Public catatan As String
    Public perintah As OleDb.OleDbCommand
    Public reader As OleDb.OleDbDataReader

    Function getJadwalGuru(ByVal sqlString As String) As List(Of JadwalGuruModel)
        bukaKoneksi()
        Dim listData As New List(Of JadwalGuruModel)
        Try
            perintah = New OleDb.OleDbCommand(sqlString, koneksi.koneksi)
            reader = perintah.ExecuteReader()
            While reader.Read
                Dim jGuruResult As New JadwalGuruModel
                If Not IsDBNull(reader("j_id")) Then
                    jGuruResult.id = reader("j_id")
                End If
                If Not IsDBNull(reader("id_guru")) Then
                    jGuruResult.idGuru = reader("id_guru")
                End If
                If Not IsDBNull(reader("nama")) Then
                    jGuruResult.nama = reader("nama")
                End If
                If Not IsDBNull(reader("j_tahun_ajar")) Then
                    jGuruResult.tahunAjar = reader("j_tahun_ajar")
                End If
                If Not IsDBNull(reader("is_scheduled")) Then
                    jGuruResult.isScheduled = reader("is_scheduled")
                End If
                If Not IsDBNull(reader("internal")) Then
                    jGuruResult.internal = reader("internal")
                End If

                jGuruResult.idTimeTable = reader("tt_id")
                jGuruResult.tampil = reader("tampil")
                jGuruResult.pelajaran = reader("pelajaran")
                jGuruResult.hari = reader("hari")
                listData.Add(jGuruResult)
            End While

        Catch ex As Exception
            catatan = "Error : " + ex.ToString
            MsgBox("Data Gagal dicari " & catatan, MsgBoxStyle.Critical, "Find")
        End Try
        tutupKoneksi()
        reader.Close()
        Return listData
    End Function

    Function getJGuruByTA(ByVal ta As String)
        Return getJadwalGuru("
        SELECT t.tampil, t.pelajaran, t.hari, t.id AS tt_id, 
        NULL AS j_id, NULL AS id_guru, NULL AS nama, NULL as internal,
        NULL AS j_tahun_ajar, NULL AS is_scheduled
        FROM time_table AS t
        WHERE t.tahun_ajar = '" & ta & "'
        ORDER BY t.hari, t.index_hari;")
    End Function
    Function getJGuruByHari_TA(ByVal ta As String, ByVal hari As String)
        Return getJadwalGuru("
        SELECT t.tampil, t.pelajaran, t.hari, t.id AS tt_id, j.id AS j_id, j.id_guru, j.nama, j.tahun_ajar AS j_tahun_ajar, j.is_scheduled, g.internal as internal
        FROM (( time_table AS t INNER JOIN  jadwal_guru AS j ON t.id = j.tt_id) INNER JOIN guru AS g ON j.id_guru = g.id)
        WHERE t.tahun_ajar = '" & ta & "' 
        AND t.hari = '" & hari & "'
        ORDER BY j.id_guru, t.index_hari;")
    End Function
    Function getJGuruByHari_TA_Waktu(ByVal ta As String, ByVal hari As String, ByVal ttId As Integer)
        Return getJadwalGuru("
        SELECT t.tampil, t.pelajaran, t.hari, t.id AS tt_id, j.id AS j_id, j.id_guru, j.nama, j.tahun_ajar AS j_tahun_ajar, j.is_scheduled, g.internal as internal
        FROM (( time_table AS t INNER JOIN  jadwal_guru AS j ON t.id = j.tt_id) INNER JOIN guru AS g ON j.id_guru = g.id)
        WHERE t.tahun_ajar = '" & ta & "' 
        AND t.hari = '" & hari & "'
        AND t.id = " & ttId & "
        ORDER BY j.id_guru, t.index_hari;")
    End Function

    Function getJGuruByIdGuru_TA(ByVal ta As String, ByVal idGuru As Integer)
        Return getJadwalGuru("
        SELECT t.tampil, t.pelajaran, t.hari, t.id AS tt_id, j.id AS j_id, j.id_guru, j.nama, j.tahun_ajar AS j_tahun_ajar, j.is_scheduled,NULL as internal
        FROM time_table AS t
        LEFT JOIN (
            SELECT * FROM jadwal_guru WHERE id_guru = " & idGuru & "
        ) AS j ON t.id = j.tt_id 
        WHERE t.tahun_ajar = '" & ta & "' 
        ORDER BY t.hari, t.index_hari;")
    End Function

    Private Function ScheduleExists(connection As OleDbConnection, transaction As OleDbTransaction, idGuru As Integer, timetableId As Integer) As Boolean
        Dim command As New OleDbCommand("SELECT COUNT(*) FROM jadwal_guru WHERE id_guru = @TeacherId AND tt_id = @TimetableId", connection, transaction)
        command.Parameters.AddWithValue("@TeacherId", idGuru)
        command.Parameters.AddWithValue("@TimetableId", timetableId)

        Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
        Return count > 0
    End Function

    Sub insertData(clb As CheckedListBox, ByVal idGuru As Integer, ByVal nama As String, ByVal ta As String)

        bukaKoneksi()
            Dim transaction As OleDbTransaction = koneksi.koneksi.BeginTransaction()
            Dim command As OleDbCommand = koneksi.koneksi.CreateCommand()
            command.Transaction = transaction
        Try
            For Each checkedItem As JadwalGuruModel In clb.CheckedItems

                If Not ScheduleExists(koneksi.koneksi, transaction, idGuru, checkedItem.idTimeTable) Then
                    ' Prepare the SQL INSERT statement
                    command.CommandText = "INSERT INTO jadwal_Guru (id_guru, tt_id, nama, tahun_ajar, is_scheduled) 
                    VALUES (@TeacherId, @TimetableId, @Name, @TA, @IsScheduled)"
                    command.Parameters.Clear()
                    command.Parameters.AddWithValue("@TeacherId", idGuru) ' Assuming TeacherId is 1 for this example
                    command.Parameters.AddWithValue("@TimetableId", checkedItem.idTimeTable)
                    command.Parameters.AddWithValue("@Name", nama)
                    command.Parameters.AddWithValue("@TA", ta)
                    command.Parameters.AddWithValue("@IsScheduled", False)

                    ' Execute the command
                    command.ExecuteNonQuery()
                End If
            Next

            For i As Integer = 0 To clb.Items.Count - 1
                If clb.GetItemCheckState(i) = CheckState.Unchecked Then
                    Dim item As JadwalGuruModel = clb.Items(i)
                    If ScheduleExists(koneksi.koneksi, transaction, idGuru, item.idTimeTable) Then
                        command.CommandText = "DELETE FROM jadwal_guru where id_guru = @TeacherId and tt_id = @TimetableId"
                        command.Parameters.Clear()
                        command.Parameters.AddWithValue("@TeacherId", idGuru) ' Assuming TeacherId is 1 for this example
                        command.Parameters.AddWithValue("@TimetableId", item.idTimeTable)

                        command.ExecuteNonQuery()
                    End If
                End If
            Next

            ' Commit the transaction
            transaction.Commit()
        Catch ex As Exception
            transaction.Rollback()
            catatan = "Error : " + ex.ToString
            MsgBox("Data Gagal disimpan " & catatan, MsgBoxStyle.Critical, "Insert")
        Finally
            ' Dispose of the command
            If command IsNot Nothing Then
                command.Dispose()
            End If

            ' Dispose of the transaction
            If transaction IsNot Nothing Then
                transaction.Dispose()
            End If
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
