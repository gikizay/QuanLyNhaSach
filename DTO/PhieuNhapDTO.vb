Public Class PhieuNhapDTO
    Private _MaPhieuNhap As String
    Public Property MaPhieuNhap As String
        Get
            Return _MaPhieuNhap
        End Get
        Set(value As String)
            _MaPhieuNhap = value
        End Set
    End Property

    Private _NgayNhap As DateTime
    Public Property NgayNhap As DateTime
        Get
            Return _NgayNhap
        End Get
        Set(value As DateTime)
            _NgayNhap = value
        End Set
    End Property


End Class
