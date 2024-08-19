Imports System.Data.OleDb

Public Class ConfigService
    Public koneksi As New ClassKoneksi

    Public catatan As String
    Public perintah As OleDb.OleDbCommand
    Public reader As OleDb.OleDbDataReader

    Sub insertData(config As ConfigModel)
        bukaKoneksi()
        Try
            Using perintah As New OleDbCommand("insert into config (tahun_angkatan, tahun_ajar, time_unit_value) values('" & config.tahunAngkatan & "', '" & config.tahunAjar & "', " & config.timeUnitValue & ")", koneksi.koneksi)
                perintah.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Data Gagal disimpan", MsgBoxStyle.Critical, "Insert")
            catatan = "Error : " + ex.ToString
        End Try
        tutupKoneksi()
    End Sub

    Sub updateData(config As ConfigModel)
        bukaKoneksi()
        Try
            Using perintah As New OleDbCommand("update config set tahun_angkatan ='" & config.tahunAngkatan & "' , tahun_ajar = '" & config.tahunAjar & "', time_unit_value = " & config.timeUnitValue & " where id = " & config.id & "", koneksi.koneksi)
                perintah.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            catatan = "Error : " + ex.ToString
            MsgBox("Data Gagal disimpan, " & catatan, MsgBoxStyle.Critical, "Insert")

        End Try
        tutupKoneksi()
    End Sub
    Function getAllData() As List(Of ConfigModel)
        Return getData("select * from config order by tahun_ajar desc")
    End Function

    Function getData(ByVal sqlstring As String) As List(Of ConfigModel)
        bukaKoneksi()
        perintah = New OleDb.OleDbCommand(sqlstring, koneksi.koneksi)
        reader = perintah.ExecuteReader()
        Dim configs As New List(Of ConfigModel)
        While reader.Read
            Dim config As New ConfigModel
            config.id = reader("id")
            config.tahunAjar = reader("tahun_ajar")
            config.tahunAngkatan = reader("tahun_angkatan")
            config.timeUnitValue = reader("time_unit_value")
            configs.Add(config)
        End While
        tutupKoneksi()
        reader.Close()
        Return configs
    End Function

    Sub tutupKoneksi()
        koneksi.koneksi.Close()
        perintah.Dispose()
    End Sub
    Sub bukaKoneksi()
        koneksi.koneksi.Open()
    End Sub

    Function getListAngkatan(ByVal stringAngkatan As String)
        Dim listAngkatan As String() = stringAngkatan.Split(","c)
        Dim angkatanList As List(Of String) = listAngkatan.ToList
        Return angkatanList
    End Function

    Function setListAngkatan(ByVal listAngkatan As List(Of String))
        Return String.Join(",", listAngkatan)
    End Function

    Function setListAngkatan(ByVal listAngkatan As List(Of Integer))
        Return String.Join(",", listAngkatan)
    End Function


End Class
