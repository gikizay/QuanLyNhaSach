Imports DTO
Public Class PhieuNhapDAL
    Public Shared Function SelectPhieuNhapAll() As DataTable
        Dim sql As String = "SELECT * FROM PHIEUNHAP"
        Dim dt As DataTable = DataProvider.ExcuteQuery(sql)
        Return dt
    End Function



    Public Shared Sub InsertPHIEUNHAP(p As PhieuNhapDTO)
        Dim sql As String = "insert into PHIEUNHAP(MAPHIEUNHAP,NGAYNHAP) values('" + p.MaPhieuNhap + "','" + p.NgayNhap + "')"
        DataProvider.ExcuteNonQuery(sql)
    End Sub


End Class
