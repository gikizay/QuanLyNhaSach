Imports DTO
Imports Bus
Imports DAL

Public Class Form_BoSungChiTietPhieuNhap
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txbSoLuong.TextChanged

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Form_LapPhieuNhapSach.Show()
        Form_LapPhieuNhapSach.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub Form_BoSungChiTietPhieuNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HienThiChiTietPhieuNhap()
    End Sub

    Private Sub HienThiChiTietPhieuNhap()
        dataChiTietPhieuNhap.DataSource = ChiTietPhieuNhapDAL.SelectChiTietPhieuNhapAll()
    End Sub

    Private Sub dataChiTietPhieuNhap_SelectionChanged(sender As Object, e As EventArgs) Handles dataChiTietPhieuNhap.SelectionChanged
        If dataChiTietPhieuNhap.SelectedRows.Count > 0 Then
            txbMaPhieuNhap.Text = dataChiTietPhieuNhap.SelectedRows(0).Cells(0).Value.ToString()
            txbMaSach.Text = dataChiTietPhieuNhap.SelectedRows(0).Cells(1).Value.ToString()
            txbSoLuong.Text = dataChiTietPhieuNhap.SelectedRows(0).Cells(2).Value.ToString()
        End If
    End Sub

    'Private Sub btnBoSung_Click(sender As Object, e As EventArgs) Handles btnBoSung.Click
    '    Dim dt As DataTable = ThamSoDAL.SelectThamSoAll()
    '    Dim nhapmin As Integer = Integer.Parse(dt.Rows(0).ItemArray(1).ToString())
    '    Dim luongtonmin As Integer = Integer.Parse(dt.Rows(0).ItemArray(2).ToString())

    '    Dim p As New PhieuNhapDTO()
    '    Try

    '        If txtmaphieunhap.Text <> "" Then

    '            p.MaPhieuNhap = Integer.Parse(txtmaphieunhap.Text)
    '        Else
    '            MessageBox.Show("Mã phiếu nhập không được để trống")
    '            Return
    '        End If
    '        If txtmasach.Text <> "" Then



    '            p.MaSach = Integer.Parse(txtmasach.Text)
    '        Else
    '            MessageBox.Show("Mã sách không được để trống")
    '            Return
    '        End If
    '    Catch
    '        MessageBox.Show("Mã là số nguyên")
    '        Return
    '    End Try
    '    Try
    '        If Integer.Parse(txtsoluong.Text) < nhapmin Then
    '            MessageBox.Show("Số lượng phải lớn hơn số lượng quy định")
    '            Return
    '        Else

    '            p.SoLuong = Integer.Parse(txtsoluong.Text)
    '        End If
    '    Catch generatedExceptionName As FormatException
    '        MessageBox.Show("Số lượng phải là kiểu số")
    '        Return
    '    End Try
    '    Dim dt2 As DataTable = ThamSoDAL.SlectSoLuongTon(p.MaSach)
    '    Dim luongton As Integer = Integer.Parse(dt2.Rows(0).ItemArray(3).ToString())
    '    Dim soluongtonnew As Integer = luongton + Integer.Parse(txtsoluong.Text)
    '    If luongton < luongtonmin Then
    '        If PhieuNhapBUS.themchitietphieunhap(p) = False Then
    '            MessageBox.Show("Sách này đã có trong phiếu!")
    '        Else

    '            Dim s As New SachDTO()
    '            s.MaSach = Integer.Parse(txtmasach.Text)
    '            s.SoLuongTon = soluongtonnew
    '            SachDAO.UpdateSoLuongTon(s)
    '            HienThiDanhSach()
    '            Dim bc As New BaoCaoTonDTO()
    '            bc.MaSach = s.MaSach
    '            bc.NgayPhatSinh = dtpick.Value
    '            bc.PhatSinh = "Phiếu nhập sách"
    '            bc.TonDau = luongton
    '            bc.TonCuoi = soluongtonnew
    '            BaoCaoTonDAO.Insert(bc)
    '            MessageBox.Show("Thành công")
    '        End If
    '    Else

    '        MessageBox.Show("Chỉ nhập các đầu sách có lượng tồn ít hơn theo quy định")
    '    End If
    'End Sub
End Class