Imports System.Data.OleDb

Public Class ClassKoneksi
    Public koneksi As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\JadwalKuliah.mdb")

    Public Sub setKoneksi(ByVal konekString As String)
        koneksi = New OleDb.OleDbConnection(konekString)
        Exit Sub
    End Sub
End Class
