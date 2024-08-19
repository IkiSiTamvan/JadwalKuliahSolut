Public Class TimeTableModel
    Public id As Integer
    Public hari As String
    Public nama As String
    Public index As Integer
    Public mulai As String
    Public menit As Integer
    Public akhir As String
    Public tampil As String
    Public pelajaran As Boolean
    Public tahunAjar As String

    Public Overrides Function ToString() As String
        Return $"{tampil}"
    End Function
End Class
