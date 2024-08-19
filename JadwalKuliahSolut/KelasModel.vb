Public Class KelasModel
    Public id As String
    Public nama As String
    Public idKeahlian As String
    Public keahlian As String
    Public tahunAngkatan As String

    Public Overrides Function ToString() As String
        Return $"{nama}"
    End Function
End Class
