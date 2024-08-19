
Public Class KeahlianModel
    Public id As String
    Public nama As String
    Public bidang As String
    Public program As String
    Public singkatan As String


    Sub setNama(ByVal Nama_ As String)
        nama = Nama_
    End Sub

    Sub setId(ByVal Id_ As String)
        id = Id_
    End Sub

    Sub setBidang(ByVal Bidang_ As String)
        bidang = Bidang_
    End Sub

    Sub setProgram(ByVal Program_ As String)
        program = Program_
    End Sub

    Sub setSingkatan(ByVal Singkatan_ As String)
        singkatan = Singkatan_
    End Sub

    Public Overrides Function ToString() As String
        Return $"{nama}"
    End Function
End Class
