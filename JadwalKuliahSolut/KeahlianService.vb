Imports System.Data.OleDb

Public Class KeahlianService
    Public koneksiKeahlian As New ClassKoneksi

    Public catatan As String
    Public perintah As OleDb.OleDbCommand
    Public reader As OleDb.OleDbDataReader


    Function getData(ByVal sqlstring As String) As List(Of KeahlianModel)
        bukaKoneksi()
        perintah = New OleDb.OleDbCommand(sqlstring, koneksiKeahlian.koneksi)
        reader = perintah.ExecuteReader()
        Dim keahlians As New List(Of KeahlianModel)
        While reader.Read
            Dim keahlian As New KeahlianModel
            keahlian.setId(reader("id"))
            keahlian.setProgram(reader("program"))
            keahlian.setBidang(reader("bidang"))
            keahlian.setNama(reader("nama"))
            keahlian.setSingkatan(reader("singkatan"))
            keahlians.Add(keahlian)
        End While
        tutupKoneksi()
        reader.Close()
        Return keahlians
    End Function

    Function getAllData() As List(Of KeahlianModel)
        Return getData("SELECT * FROM keahlian where dihapus = false ORDER by nama asc ")
    End Function
    Sub insertData(keahlian As KeahlianModel)
        bukaKoneksi()

        Try
            Using perintah As New OleDbCommand("insert into keahlian (nama, program, bidang, singkatan) values('" & keahlian.nama & "', '" & keahlian.program & "', '" & keahlian.bidang & "', '" & keahlian.singkatan & "')", koneksiKeahlian.koneksi)
                'perintah = New OleDb.OleDbCommand("insert into keahlian (nama, program, bidang, singkatan) values('" & nama & "', '" & program & "', '" & bidang & "', '" & singkatan & "')", koneksiKeahlian.koneksi)
                perintah.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Data Gagal disimpan", MsgBoxStyle.Critical, "Insert")
            catatan = "Error : " + ex.ToString
        End Try
        tutupKoneksi()
    End Sub

    Sub updateData(keahlian As KeahlianModel)
        bukaKoneksi()
        Console.WriteLine(koneksiKeahlian.koneksi.ConnectionString)
        Try
            perintah = New OleDb.OleDbCommand("update keahlian set nama = '" & keahlian.nama & "', program = '" & keahlian.program & "', bidang ='" & keahlian.bidang & "', singkatan ='" & keahlian.singkatan & "' where id = " & keahlian.id & "", koneksiKeahlian.koneksi)
            perintah.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Data Gagal diupdate", MsgBoxStyle.Critical, "Update")
            catatan = "Error : " + ex.ToString
        End Try
        tutupKoneksi()

    End Sub

    Sub deleteData(keahlian As KeahlianModel)
        bukaKoneksi()
        Try
            perintah = New OleDb.OleDbCommand("update keahlian set dihapus = true where id = " & keahlian.id, koneksiKeahlian.koneksi)
            perintah.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Data Gagal dihapus", MsgBoxStyle.Critical, "Delete")
            catatan = "Error : " + ex.ToString
        End Try
        tutupKoneksi()
    End Sub

    Sub tutupKoneksi()
        koneksiKeahlian.koneksi.Close()
        perintah.Dispose()
    End Sub
    Sub bukaKoneksi()
        koneksiKeahlian.koneksi.Open()
    End Sub
End Class
