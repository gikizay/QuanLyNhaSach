<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_BoSungChiTietPhieuNhap
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txbChiTietPhieuNhap = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txbSoLuong = New System.Windows.Forms.TextBox()
        Me.txbMaSach = New System.Windows.Forms.TextBox()
        Me.txbMaPhieuNhap = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnXoaTrang = New System.Windows.Forms.Button()
        Me.btnBoSung = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dataChiTietPhieuNhap = New System.Windows.Forms.DataGridView()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.colMaPhieuNhapCT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMaSachCT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTacGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSoLuong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dataChiTietPhieuNhap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(95, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bổ Sung Chi Tiết"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txbChiTietPhieuNhap)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txbSoLuong)
        Me.GroupBox1.Controls.Add(Me.txbMaSach)
        Me.GroupBox1.Controls.Add(Me.txbMaPhieuNhap)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 148)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin bổ sung"
        '
        'txbChiTietPhieuNhap
        '
        Me.txbChiTietPhieuNhap.Location = New System.Drawing.Point(146, 34)
        Me.txbChiTietPhieuNhap.Name = "txbChiTietPhieuNhap"
        Me.txbChiTietPhieuNhap.Size = New System.Drawing.Size(135, 20)
        Me.txbChiTietPhieuNhap.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Mã Chi Tiết Phiếu Nhập:"
        '
        'txbSoLuong
        '
        Me.txbSoLuong.Location = New System.Drawing.Point(146, 112)
        Me.txbSoLuong.Name = "txbSoLuong"
        Me.txbSoLuong.Size = New System.Drawing.Size(135, 20)
        Me.txbSoLuong.TabIndex = 5
        '
        'txbMaSach
        '
        Me.txbMaSach.Location = New System.Drawing.Point(146, 86)
        Me.txbMaSach.Name = "txbMaSach"
        Me.txbMaSach.Size = New System.Drawing.Size(135, 20)
        Me.txbMaSach.TabIndex = 4
        '
        'txbMaPhieuNhap
        '
        Me.txbMaPhieuNhap.Location = New System.Drawing.Point(146, 60)
        Me.txbMaPhieuNhap.Name = "txbMaPhieuNhap"
        Me.txbMaPhieuNhap.Size = New System.Drawing.Size(135, 20)
        Me.txbMaPhieuNhap.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Sớ Lượng:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Mã Sách:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã Phiếu Nhập:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnXoaTrang)
        Me.GroupBox2.Controls.Add(Me.btnBoSung)
        Me.GroupBox2.Location = New System.Drawing.Point(35, 239)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(304, 61)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chức Năng"
        '
        'btnXoaTrang
        '
        Me.btnXoaTrang.Location = New System.Drawing.Point(189, 25)
        Me.btnXoaTrang.Name = "btnXoaTrang"
        Me.btnXoaTrang.Size = New System.Drawing.Size(75, 23)
        Me.btnXoaTrang.TabIndex = 1
        Me.btnXoaTrang.Text = "Xóa Hết"
        Me.btnXoaTrang.UseVisualStyleBackColor = True
        '
        'btnBoSung
        '
        Me.btnBoSung.Location = New System.Drawing.Point(59, 25)
        Me.btnBoSung.Name = "btnBoSung"
        Me.btnBoSung.Size = New System.Drawing.Size(75, 23)
        Me.btnBoSung.TabIndex = 0
        Me.btnBoSung.Text = "Bổ Sung"
        Me.btnBoSung.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dataChiTietPhieuNhap)
        Me.GroupBox3.Location = New System.Drawing.Point(35, 306)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(587, 180)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Chi tiết phiếu nhập"
        '
        'dataChiTietPhieuNhap
        '
        Me.dataChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataChiTietPhieuNhap.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMaPhieuNhapCT, Me.colMaSachCT, Me.colTacGia, Me.colSoLuong})
        Me.dataChiTietPhieuNhap.Location = New System.Drawing.Point(6, 19)
        Me.dataChiTietPhieuNhap.Name = "dataChiTietPhieuNhap"
        Me.dataChiTietPhieuNhap.Size = New System.Drawing.Size(423, 150)
        Me.dataChiTietPhieuNhap.TabIndex = 0
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(263, 492)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 23)
        Me.btnThoat.TabIndex = 4
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'colMaPhieuNhapCT
        '
        Me.colMaPhieuNhapCT.DataPropertyName = "MaPhieuNhap"
        Me.colMaPhieuNhapCT.HeaderText = "Mã Phiếu Nhập"
        Me.colMaPhieuNhapCT.Name = "colMaPhieuNhapCT"
        '
        'colMaSachCT
        '
        Me.colMaSachCT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colMaSachCT.DataPropertyName = "MaSach"
        Me.colMaSachCT.HeaderText = "Mã Sách"
        Me.colMaSachCT.Name = "colMaSachCT"
        Me.colMaSachCT.Width = 69
        '
        'colTacGia
        '
        Me.colTacGia.DataPropertyName = "TacGia"
        Me.colTacGia.HeaderText = "Tác Giả"
        Me.colTacGia.Name = "colTacGia"
        '
        'colSoLuong
        '
        Me.colSoLuong.DataPropertyName = "SoLuongNhap"
        Me.colSoLuong.HeaderText = "Số Lượng Nhập"
        Me.colSoLuong.Name = "colSoLuong"
        Me.colSoLuong.Width = 50
        '
        'Form_BoSungChiTietPhieuNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 527)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_BoSungChiTietPhieuNhap"
        Me.Text = "Form_BoSungChiTiet"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dataChiTietPhieuNhap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txbSoLuong As TextBox
    Friend WithEvents txbMaSach As TextBox
    Friend WithEvents txbMaPhieuNhap As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnXoaTrang As Button
    Friend WithEvents btnBoSung As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dataChiTietPhieuNhap As DataGridView
    Friend WithEvents btnThoat As Button
    Friend WithEvents txbChiTietPhieuNhap As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents colMaPhieuNhapCT As DataGridViewTextBoxColumn
    Friend WithEvents colMaSachCT As DataGridViewTextBoxColumn
    Friend WithEvents colTacGia As DataGridViewTextBoxColumn
    Friend WithEvents colSoLuong As DataGridViewTextBoxColumn
End Class
