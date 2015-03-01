<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fhoadon
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtmahoadon = New System.Windows.Forms.TextBox()
        Me.txtmakhachhang = New System.Windows.Forms.TextBox()
        Me.txtngaylamhoadon = New System.Windows.Forms.TextBox()
        Me.txtthanhtien = New System.Windows.Forms.TextBox()
        Me.bntdong = New System.Windows.Forms.Button()
        Me.bntxoa = New System.Windows.Forms.Button()
        Me.bntsua = New System.Windows.Forms.Button()
        Me.bntthem = New System.Windows.Forms.Button()
        Me.lstsanpham = New System.Windows.Forms.ListView()
        Me.clmahoadong = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmakhachhang = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clngaylamhoadon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clthanhtien = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã hóa đơn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã khách hàng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Ngày làm hóa đơn"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Thành tiền"
        '
        'txtmahoadon
        '
        Me.txtmahoadon.Location = New System.Drawing.Point(165, 31)
        Me.txtmahoadon.Name = "txtmahoadon"
        Me.txtmahoadon.Size = New System.Drawing.Size(364, 20)
        Me.txtmahoadon.TabIndex = 1
        '
        'txtmakhachhang
        '
        Me.txtmakhachhang.Location = New System.Drawing.Point(165, 57)
        Me.txtmakhachhang.Name = "txtmakhachhang"
        Me.txtmakhachhang.Size = New System.Drawing.Size(364, 20)
        Me.txtmakhachhang.TabIndex = 1
        '
        'txtngaylamhoadon
        '
        Me.txtngaylamhoadon.Location = New System.Drawing.Point(165, 83)
        Me.txtngaylamhoadon.Name = "txtngaylamhoadon"
        Me.txtngaylamhoadon.Size = New System.Drawing.Size(364, 20)
        Me.txtngaylamhoadon.TabIndex = 1
        '
        'txtthanhtien
        '
        Me.txtthanhtien.Location = New System.Drawing.Point(165, 109)
        Me.txtthanhtien.Name = "txtthanhtien"
        Me.txtthanhtien.Size = New System.Drawing.Size(364, 20)
        Me.txtthanhtien.TabIndex = 1
        '
        'bntdong
        '
        Me.bntdong.Location = New System.Drawing.Point(321, 135)
        Me.bntdong.Name = "bntdong"
        Me.bntdong.Size = New System.Drawing.Size(46, 30)
        Me.bntdong.TabIndex = 3
        Me.bntdong.Text = "Đóng"
        Me.bntdong.UseVisualStyleBackColor = True
        '
        'bntxoa
        '
        Me.bntxoa.Location = New System.Drawing.Point(269, 135)
        Me.bntxoa.Name = "bntxoa"
        Me.bntxoa.Size = New System.Drawing.Size(46, 30)
        Me.bntxoa.TabIndex = 4
        Me.bntxoa.Text = "Xóa"
        Me.bntxoa.UseVisualStyleBackColor = True
        '
        'bntsua
        '
        Me.bntsua.Location = New System.Drawing.Point(217, 135)
        Me.bntsua.Name = "bntsua"
        Me.bntsua.Size = New System.Drawing.Size(46, 30)
        Me.bntsua.TabIndex = 5
        Me.bntsua.Text = "Sửa"
        Me.bntsua.UseVisualStyleBackColor = True
        '
        'bntthem
        '
        Me.bntthem.Location = New System.Drawing.Point(165, 135)
        Me.bntthem.Name = "bntthem"
        Me.bntthem.Size = New System.Drawing.Size(46, 30)
        Me.bntthem.TabIndex = 6
        Me.bntthem.Text = "Thêm"
        Me.bntthem.UseVisualStyleBackColor = True
        '
        'lstsanpham
        '
        Me.lstsanpham.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmahoadong, Me.clmakhachhang, Me.clngaylamhoadon, Me.clthanhtien})
        Me.lstsanpham.FullRowSelect = True
        Me.lstsanpham.GridLines = True
        Me.lstsanpham.Location = New System.Drawing.Point(30, 218)
        Me.lstsanpham.Name = "lstsanpham"
        Me.lstsanpham.Size = New System.Drawing.Size(556, 177)
        Me.lstsanpham.TabIndex = 7
        Me.lstsanpham.UseCompatibleStateImageBehavior = False
        Me.lstsanpham.View = System.Windows.Forms.View.Details
        '
        'clmahoadong
        '
        Me.clmahoadong.Text = "Mã hóa đơn"
        Me.clmahoadong.Width = 82
        '
        'clmakhachhang
        '
        Me.clmakhachhang.DisplayIndex = 1
        Me.clmakhachhang.Text = "Mã khách hàng"
        Me.clmakhachhang.Width = 96
        '
        'clngaylamhoadon
        '
        Me.clngaylamhoadon.Text = "Ngày làm hóa đơn"
        Me.clngaylamhoadon.Width = 104
        '
        'clthanhtien
        '
        Me.clthanhtien.Text = "Thành tiền"
        Me.clthanhtien.Width = 96
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtmahoadon)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.bntdong)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.bntxoa)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.bntsua)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.bntthem)
        Me.GroupBox1.Controls.Add(Me.txtmakhachhang)
        Me.GroupBox1.Controls.Add(Me.txtthanhtien)
        Me.GroupBox1.Controls.Add(Me.txtngaylamhoadon)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(556, 188)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hóa đơn"
        '
        'Fhoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 448)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstsanpham)
        Me.Name = "Fhoadon"
        Me.Text = "Hóa Đơn"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtmahoadon As System.Windows.Forms.TextBox
    Friend WithEvents txtmakhachhang As System.Windows.Forms.TextBox
    Friend WithEvents txtngaylamhoadon As System.Windows.Forms.TextBox
    Friend WithEvents txtthanhtien As System.Windows.Forms.TextBox
    Friend WithEvents bntdong As System.Windows.Forms.Button
    Friend WithEvents bntxoa As System.Windows.Forms.Button
    Friend WithEvents bntsua As System.Windows.Forms.Button
    Friend WithEvents bntthem As System.Windows.Forms.Button
    Friend WithEvents lstsanpham As System.Windows.Forms.ListView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents clmahoadong As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmakhachhang As System.Windows.Forms.ColumnHeader
    Friend WithEvents clngaylamhoadon As System.Windows.Forms.ColumnHeader
    Friend WithEvents clthanhtien As System.Windows.Forms.ColumnHeader

End Class
