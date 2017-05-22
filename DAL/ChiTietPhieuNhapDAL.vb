Imports DTO

Public Class ChiTietPhieuNhapDAL

    Public Shared Function SelectChiTietPhieuNhapAll() As DataTable
        Dim sql As String = "SELECT * FROM CHITIETPHIEUNHAP"
        Dim dt As DataTable = DataProvider.ExcuteQuery(sql)
        Return dt
    End Function
    Public Shared Sub InsertChiTietPhieuNhap(p As ChiTietPhieuNhapDTO)
        Dim sql As String = "insert into CHITIETPHIEUNHAP(MAPHIEUNHAP,MaSach,SoluongNhap) values('" + p.MaPhieuNhap + "','" + p.MaSach + "'," + p.SoLuongNhap + ")"""
        DataProvider.ExcuteNonQuery(sql)
    End Sub
    Public Shared Function SelectPhieuNhapByName(maphieunhap As String, masach As String) As ChiTietPhieuNhapDTO
        Dim sql As String = "select*from CHITIETPHIEUNHAP where((MaPhieuNhap=" + maphieunhap + ")AND(Masach=" + masach + "))"
        Dim dt As DataTable = DataProvider.ExcuteQuery(sql)
        If (dt.Rows.Count = 0) Then
            Return Nothing


        Else
            Dim pn As New ChiTietPhieuNhapDTO()
            pn.MaPhieuNhap = dt.Rows(0).ItemArray(0).ToString()
            Return pn
        End If

    End Function
End Class
