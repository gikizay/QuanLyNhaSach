Imports DAL
Imports DTO

Public Class BaoCaoCongNoBUS
    Public Function LayDanhSach() As List(Of BaoCaoCongNoDTO)
        Dim BCCN As New BaoCaoCongNoDAL()
        Return BCCN.LayDanhSach()
    End Function


End Class
