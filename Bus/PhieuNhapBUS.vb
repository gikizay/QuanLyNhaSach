Imports DAL
Imports DTO
Public Class PhieuNhapBUS

    Public Shared Function ThemPhieuNhap(p As PhieuNhapDTO) As Boolean
        PhieuNhapDAL.InsertPHIEUNHAP(p)
        Return True

    End Function


End Class
