<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_LapPhieuNhapSach
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
        Me.txbMaPhieuNhap = New System.Windows.Forms.TextBox()
        Me.lbNgayNhap = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lbMaPhieuNhap = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBoSung = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dataPhieuNhap = New System.Windows.Forms.DataGridView()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.colmaphieunhap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNgayNhap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dataPhieuNhap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lập Phiếu Nhập Sách"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txbMaPhieuNhap)
        Me.GroupBox1.Controls.Add(Me.lbNgayNhap)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.lbMaPhieuNhap)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 83)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lập Phiếu Nhập"
        '
        'txbMaPhieuNhap
        '
        Me.txbMaPhieuNhap.Location = New System.Drawing.Point(116, 17)
        Me.txbMaPhieuNhap.Name = "txbMaPhieuNhap"
        Me.txbMaPhieuNhap.Size = New System.Drawing.Size(146, 20)
        Me.txbMaPhieuNhap.TabIndex = 3
        '
        'lbNgayNhap
        '
        Me.lbNgayNhap.AutoSize = True
        Me.lbNgayNhap.Location = New System.Drawing.Point(26, 48)
        Me.lbNgayNhap.Name = "lbNgayNhap"
        Me.lbNgayNhap.Size = New System.Drawing.Size(64, 13)
        Me.lbNgayNhap.TabIndex = 2
        Me.lbNgayNhap.Text = "Ngày Nhập:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(116, 45)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(146, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'lbMaPhieuNhap
        '
        Me.lbMaPhieuNhap.AutoSize = True
        Me.lbMaPhieuNhap.Location = New System.Drawing.Point(26, 20)
        Me.lbMaPhieuNhap.Name = "lbMaPhieuNhap"
        Me.lbMaPhieuNhap.Size = New System.Drawing.Size(84, 13)
        Me.lbMaPhieuNhap.TabIndex = 0
        Me.lbMaPhieuNhap.Text = "Mã Phiếu Nhập:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBoSung)
        Me.GroupBox2.Controls.Add(Me.btnThem)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 174)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(318, 64)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chức Năng"
        '
        'btnBoSung
        '
        Me.btnBoSung.Location = New System.Drawing.Point(157, 24)
        Me.btnBoSung.Name = "btnBoSung"
        Me.btnBoSung.Size = New System.Drawing.Size(105, 23)
        Me.btnBoSung.TabIndex = 1
        Me.btnBoSung.Text = "Bổ Sung Chi Tiết"
        Me.btnBoSung.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(44, 24)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 0
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dataPhieuNhap)
        Me.GroupBox3.Location = New System.Drawing.Point(25, 279)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(318, 174)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Danh Sách Phiếu Nhập"
        '
        'dataPhieuNhap
        '
        Me.dataPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataPhieuNhap.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colmaphieunhap, Me.colNgayNhap})
        Me.dataPhieuNhap.Location = New System.Drawing.Point(7, 20)
        Me.dataPhieuNhap.Name = "dataPhieuNhap"
        Me.dataPhieuNhap.Size = New System.Drawing.Size(305, 148)
        Me.dataPhieuNhap.TabIndex = 0
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(259, 460)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 23)
        Me.btnThoat.TabIndex = 4
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'colmaphieunhap
        '
        Me.colmaphieunhap.DataPropertyName = "MaPhieuNhap"
        Me.colmaphieunhap.HeaderText = "Mã Phiếu Nhập"
        Me.colmaphieunhap.Name = "colmaphieunhap"
        '
        'colNgayNhap
        '
        Me.colNgayNhap.DataPropertyName = "NgayNhap"
        Me.colNgayNhap.HeaderText = "Ngày Nhập"
        Me.colNgayNhap.Name = "colNgayNhap"
        Me.colNgayNhap.Width = 165
        '
        'Form_LapPhieuNhapSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 495)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_LapPhieuNhapSach"
        Me.Text = "Form_LapPhieu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dataPhieuNhap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txbMaPhieuNhap As TextBox
    Friend WithEvents lbNgayNhap As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lbMaPhieuNhap As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnBoSung As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dataPhieuNhap As DataGridView
    Friend WithEvents btnThoat As Button
    Friend WithEvents colmaphieunhap As DataGridViewTextBoxColumn
    Friend WithEvents colNgayNhap As DataGridViewTextBoxColumn
End Class
