Imports DAL
Public Class ThamSoDAL
    Public Shared Function SelectThamSoAll() As DataTable
        Dim sql As String = "select * from THAMSO"
        Return DataProvider.ExcuteQuery(sql)
    End Function

    Public Shared Function SelectSoLuongTon(masach As Integer) As DataTable
        Dim sql As String = "select * from SACH where MaSach=" + masach + ""
        Return DataProvider.ExcuteQuery(sql)
    End Function


End Class
