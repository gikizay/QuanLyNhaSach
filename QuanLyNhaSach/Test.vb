Imports DTO
Imports DAL
Imports Bus
Public Class Test

    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Date.Now()
        hien()
    End Sub
    Private Sub hien()
        DataGridView1.DataSource = PhieuNhapDAL.SelectPhieuNhapAll()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim p As New PhieuNhapDTO()

        p.NgayNhap = DateTimePicker1.Value
        p.MaPhieuNhap = TextBox2.Text
        If PhieuNhapBUS.ThemPhieuNhap(p) Then
            MessageBox.Show("ok")
        End If
        hien()



    End Sub
End Class