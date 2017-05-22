Imports DTO
Imports DAL
Imports Bus
Public Class Form_LapPhieuNhapSach
    Dim F_Bosungchitiet As New Form_BoSungChiTietPhieuNhap()
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Application.Exit()
    End Sub

    Private Sub Form_LapPhieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Date.Now()
        HienThiPieuNhap()
    End Sub

    Private Sub HienThiPieuNhap()
        dataPhieuNhap.DataSource = PhieuNhapDAL.SelectPhieuNhapAll()

    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim dem As Integer = 0
        Dim p As New PhieuNhapDTO()
        p.NgayNhap = DateTimePicker1.Value
        p.MaPhieuNhap = txbMaPhieuNhap.Text
        If PhieuNhapBUS.ThemPhieuNhap(p) Then
            MessageBox.Show("Bạn Đã Nhập Thành Công!")
        End If
        HienThiPieuNhap()
        F_Bosungchitiet.txbMaPhieuNhap.Text = dataPhieuNhap.Rows(dem).Cells(0).Value.ToString()

    End Sub



    Private Sub btnBoSung_Click(sender As Object, e As EventArgs) Handles btnBoSung.Click
        Me.Enabled = False
        F_Bosungchitiet.Show()

    End Sub

    Private Sub dataPhieuNhap_SelectionChanged(sender As Object, e As EventArgs) Handles dataPhieuNhap.SelectionChanged
        If dataPhieuNhap.SelectedRows.Count > 0 Then
            F_Bosungchitiet.txbMaPhieuNhap.Text = dataPhieuNhap.SelectedRows(0).Cells(0).Value.ToString()
            F_Bosungchitiet.txbMaSach.Text = dataPhieuNhap.SelectedRows(0).Cells(0).Value.ToString()
        End If
    End Sub
End Class