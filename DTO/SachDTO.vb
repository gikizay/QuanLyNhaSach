Public Class SachDTO

    Private _Masach As String
    Private _TenSach As String
    Private _TheLoai As String
    Private _Tacgia As String
    Private _DonGia As String
    Private _SoLuongTon As String

    Public Property Masach As String
        Get
            Return _Masach
        End Get
        Set(value As String)
            _Masach = value
        End Set
    End Property

    Public Property TenSach As String
        Get
            Return _TenSach
        End Get
        Set(value As String)
            _TenSach = value
        End Set
    End Property

    Public Property TheLoai As String
        Get
            Return _TheLoai
        End Get
        Set(value As String)
            _TheLoai = value
        End Set
    End Property

    Public Property Tacgia As String
        Get
            Return _Tacgia
        End Get
        Set(value As String)
            _Tacgia = value
        End Set
    End Property

    Public Property DonGia As String
        Get
            Return _DonGia
        End Get
        Set(value As String)
            _DonGia = value
        End Set
    End Property

    Public Property SoLuongTon As String
        Get
            Return _SoLuongTon
        End Get
        Set(value As String)
            _SoLuongTon = value
        End Set
    End Property
End Class
