Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class JadwalGuruModel
    Public id As Integer
    Public idGuru As Integer
    Public internal As Boolean
    Public idTimeTable As Integer
    Public nama As String
    Public tahunAjar As String
    Public isScheduled As Boolean
    Public tampil As String
    Public pelajaran As Boolean
    Public hari As String
    Public Overrides Function ToString() As String
        Return $"{tampil}"
    End Function
End Class
