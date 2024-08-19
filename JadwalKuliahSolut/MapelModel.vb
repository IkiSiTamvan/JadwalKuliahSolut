Public Class MapelModel
    Public id As Integer
    Public nama As String
    Public idKeahlian As String
    Public Keahlian As String
    Public tahunAjar As String
    Public kelas As String
    Public semester As String
    Public timeUnit As Integer
    Public butuhLab As Boolean
    Public singkatan As String

    Public Overrides Function ToString() As String
        Return $"{nama}"
    End Function
End Class
