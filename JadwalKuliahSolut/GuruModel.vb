Public Class GuruModel
    Public id As Integer
    Public nama As String
    Public email As String
    Public noTelpon As String
    Public internal As Boolean
    Public aktif As Boolean

    Public Overrides Function ToString() As String
        Return $"{nama}"
    End Function
End Class
