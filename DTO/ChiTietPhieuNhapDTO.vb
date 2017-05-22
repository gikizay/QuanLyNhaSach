
Public Class ChiTietPhieuNhapDTO

    Private _MaChiTietPhieuNhap As String
    Public Property MaChiTietPhieuNhap As String
        Get
            Return _MaChiTietPhieuNhap
        End Get
        Set(value As String)
            _MaChiTietPhieuNhap = value
        End Set
    End Property

    Private _MaPhieuNhap As String
    Public Property MaPhieuNhap As String
        Get
            Return _MaPhieuNhap
        End Get
        Set(value As String)
            _MaPhieuNhap = value
        End Set
    End Property

    Private _MaSach As String
    Public Property MaSach As String
        Get
            Return _MaSach
        End Get
        Set(value As String)
            _MaSach = value
        End Set
    End Property

    Private _SoLuongNhap As Integer
    Public Property SoLuongNhap As Integer
        Get
            Return _SoLuongNhap
        End Get
        Set(value As Integer)
            _SoLuongNhap = value
        End Set
    End Property
End Class
