Imports DTO
Imports DAL
Public Class ChiTietPhieuNhapBUS
    Public Shared Function ThemChiTietPhieuNhap(p As ChiTietPhieuNhapDTO) As Boolean
        If (ChiTietPhieuNhapDAL.SelectPhieuNhapByName(p.MaPhieuNhap, p.MaSach) Is Nothing) Then
            ChiTietPhieuNhapDAL.InsertChiTietPhieuNhap(p)
            Return True
        Else
            Return False
        End If

    End Function
End Class
