Imports System.Data.OleDb

Public Class GuruService
    Public koneksi As New ClassKoneksi

    Public catatan As String
    Public perintah As OleDb.OleDbCommand
    Public reader As OleDb.OleDbDataReader
    Function searchGuru(ByVal findby As String, ByVal key As String) As List(Of GuruModel)
        If findby.Equals("Aktif") Or findby.Equals("Internal") Then
            Return getData("select * from guru where " & findby & " = " & key)
        Else
            Return getData("select * from guru where " & findby & " like '%" & key & "%'")
        End If
    End Function
    Function getAllData() As List(Of GuruModel)
        Return getData("select * from guru")
    End Function

    Function getData(ByVal sqlstring As String) As List(Of GuruModel)
        bukaKoneksi()
        Dim gurus As New List(Of GuruModel)
        Try
            perintah = New OleDb.OleDbCommand(sqlstring, koneksi.koneksi)
            reader = perintah.ExecuteReader()
            While reader.Read
                Dim guru As New GuruModel
                guru.id = reader("id")
                guru.nama = reader("nama")
                guru.email = reader("email")
                guru.noTelpon = reader("no_telpon")
                guru.aktif = reader("aktif")
                guru.internal = reader("internal")
                gurus.Add(guru)
            End While
        Catch ex As Exception
            catatan = "Error : " + ex.ToString
            MsgBox("Data Gagal dicari " & catatan, MsgBoxStyle.Critical, "Find")
        End Try

        tutupKoneksi()
        reader.Close()
        Return gurus
    End Function
    Sub insertData(guru As GuruModel)
        bukaKoneksi()
        Try
            Using perintah As New OleDbCommand(
                "insert into guru (nama, email, no_telpon, aktif, internal ) 
                values ('" & guru.nama & "', '" & guru.email & "', '" & guru.noTelpon & "', " & guru.aktif & ", " & guru.internal & " )", koneksi.koneksi)
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

    Friend Sub updateData(objGuru As GuruModel)
        bukaKoneksi()
        Try
            Using perintah As New OleDbCommand(
                "update guru set nama = '" & objGuru.nama & "', email = '" & objGuru.email & "',
                no_telpon = '" & objGuru.noTelpon & "', internal = " & objGuru.internal & ", 
                aktif = " & objGuru.aktif & " 
                where id = " & objGuru.id & " ", koneksi.koneksi)
                perintah.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            catatan = "Error : " + ex.ToString
            MsgBox("Data Gagal diubah " & catatan, MsgBoxStyle.Critical, "Update")
        End Try
        tutupKoneksi()
    End Sub
End Class
