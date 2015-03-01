<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fchitiethoadon
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
        Me.txt = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtgia = New System.Windows.Forms.TextBox()
        Me.txtmasanpham = New System.Windows.Forms.TextBox()
        Me.txtmahoadon = New System.Windows.Forms.TextBox()
        Me.txtmachitiethoadon = New System.Windows.Forms.TextBox()
        Me.txtsoluong = New System.Windows.Forms.TextBox()
        Me.lstsanpham = New System.Windows.Forms.ListView()
        Me.clmachitiethoadon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmahoadon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmasanpham = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clsoluong = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clgia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bntdong = New System.Windows.Forms.Button()
        Me.bntxoa = New System.Windows.Forms.Button()
        Me.bntsua = New System.Windows.Forms.Button()
        Me.bntthem = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt
        '
        Me.txt.AutoSize = True
        Me.txt.Location = New System.Drawing.Point(35, 42)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(99, 13)
        Me.txt.TabIndex = 0
        Me.txt.Text = "Mã chi tiết hóa đơn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã hóa đơn"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mã sản phẩm"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Số lượng"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Giá"
        '
        'txtgia
        '
        Me.txtgia.Location = New System.Drawing.Point(167, 159)
        Me.txtgia.Name = "txtgia"
        Me.txtgia.Size = New System.Drawing.Size(346, 20)
        Me.txtgia.TabIndex = 1
        '
        'txtmasanpham
        '
        Me.txtmasanpham.Location = New System.Drawing.Point(167, 95)
        Me.txtmasanpham.Name = "txtmasanpham"
        Me.txtmasanpham.Size = New System.Drawing.Size(346, 20)
        Me.txtmasanpham.TabIndex = 1
        '
        'txtmahoadon
        '
        Me.txtmahoadon.Location = New System.Drawing.Point(167, 67)
        Me.txtmahoadon.Name = "txtmahoadon"
        Me.txtmahoadon.Size = New System.Drawing.Size(346, 20)
        Me.txtmahoadon.TabIndex = 1
        '
        'txtmachitiethoadon
        '
        Me.txtmachitiethoadon.Location = New System.Drawing.Point(167, 35)
        Me.txtmachitiethoadon.Name = "txtmachitiethoadon"
        Me.txtmachitiethoadon.Size = New System.Drawing.Size(346, 20)
        Me.txtmachitiethoadon.TabIndex = 1
        '
        'txtsoluong
        '
        Me.txtsoluong.Location = New System.Drawing.Point(167, 127)
        Me.txtsoluong.Name = "txtsoluong"
        Me.txtsoluong.Size = New System.Drawing.Size(346, 20)
        Me.txtsoluong.TabIndex = 1
        '
        'lstsanpham
        '
        Me.lstsanpham.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmachitiethoadon, Me.clmahoadon, Me.clmasanpham, Me.clsoluong, Me.clgia})
        Me.lstsanpham.FullRowSelect = True
        Me.lstsanpham.GridLines = True
        Me.lstsanpham.Location = New System.Drawing.Point(29, 252)
        Me.lstsanpham.Name = "lstsanpham"
        Me.lstsanpham.Size = New System.Drawing.Size(541, 214)
        Me.lstsanpham.TabIndex = 7
        Me.lstsanpham.UseCompatibleStateImageBehavior = False
        Me.lstsanpham.View = System.Windows.Forms.View.Details
        '
        'clmachitiethoadon
        '
        Me.clmachitiethoadon.Text = "Mã chi tiết hóa đơn"
        Me.clmachitiethoadon.Width = 112
        '
        'clmahoadon
        '
        Me.clmahoadon.Text = "Mã hóa đơn"
        Me.clmahoadon.Width = 111
        '
        'clmasanpham
        '
        Me.clmasanpham.Text = "Mã sản phẩm"
        Me.clmasanpham.Width = 107
        '
        'clsoluong
        '
        Me.clsoluong.Text = "Số lượng"
        Me.clsoluong.Width = 91
        '
        'clgia
        '
        Me.clgia.Text = "Giá"
        Me.clgia.Width = 73
        '
        'bntdong
        '
        Me.bntdong.Location = New System.Drawing.Point(458, 198)
        Me.bntdong.Name = "bntdong"
        Me.bntdong.Size = New System.Drawing.Size(46, 23)
        Me.bntdong.TabIndex = 8
        Me.bntdong.Text = "Đóng"
        Me.bntdong.UseVisualStyleBackColor = True
        '
        'bntxoa
        '
        Me.bntxoa.Location = New System.Drawing.Point(348, 198)
        Me.bntxoa.Name = "bntxoa"
        Me.bntxoa.Size = New System.Drawing.Size(46, 23)
        Me.bntxoa.TabIndex = 9
        Me.bntxoa.Text = "Xóa"
        Me.bntxoa.UseVisualStyleBackColor = True
        '
        'bntsua
        '
        Me.bntsua.Location = New System.Drawing.Point(251, 198)
        Me.bntsua.Name = "bntsua"
        Me.bntsua.Size = New System.Drawing.Size(46, 23)
        Me.bntsua.TabIndex = 10
        Me.bntsua.Text = "Sửa"
        Me.bntsua.UseVisualStyleBackColor = True
        '
        'bntthem
        '
        Me.bntthem.Location = New System.Drawing.Point(168, 198)
        Me.bntthem.Name = "bntthem"
        Me.bntthem.Size = New System.Drawing.Size(46, 23)
        Me.bntthem.TabIndex = 11
        Me.bntthem.Text = "Thêm"
        Me.bntthem.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtmachitiethoadon)
        Me.GroupBox1.Controls.Add(Me.bntdong)
        Me.GroupBox1.Controls.Add(Me.txt)
        Me.GroupBox1.Controls.Add(Me.bntxoa)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.bntsua)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.bntthem)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtgia)
        Me.GroupBox1.Controls.Add(Me.txtmasanpham)
        Me.GroupBox1.Controls.Add(Me.txtsoluong)
        Me.GroupBox1.Controls.Add(Me.txtmahoadon)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(541, 234)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chi tiết hóa đơn"
        '
        'Fchitiethoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 492)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstsanpham)
        Me.Name = "Fchitiethoadon"
        Me.Text = "Chi tiết hóa đơn"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtgia As System.Windows.Forms.TextBox
    Friend WithEvents txtmasanpham As System.Windows.Forms.TextBox
    Friend WithEvents txtmahoadon As System.Windows.Forms.TextBox
    Friend WithEvents txtmachitiethoadon As System.Windows.Forms.TextBox
    Friend WithEvents txtsoluong As System.Windows.Forms.TextBox
    Friend WithEvents lstsanpham As System.Windows.Forms.ListView
    Friend WithEvents bntdong As System.Windows.Forms.Button
    Friend WithEvents bntxoa As System.Windows.Forms.Button
    Friend WithEvents bntsua As System.Windows.Forms.Button
    Friend WithEvents bntthem As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents clmachitiethoadon As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmahoadon As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmasanpham As System.Windows.Forms.ColumnHeader
    Friend WithEvents clsoluong As System.Windows.Forms.ColumnHeader
    Friend WithEvents clgia As System.Windows.Forms.ColumnHeader
End Class
