<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FSanPham
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
        Me.txtmasanpham = New System.Windows.Forms.TextBox()
        Me.txttensanpham = New System.Windows.Forms.TextBox()
        Me.txtloaisanpham = New System.Windows.Forms.TextBox()
        Me.txtgia = New System.Windows.Forms.TextBox()
        Me.bntthem = New System.Windows.Forms.Button()
        Me.bntsua = New System.Windows.Forms.Button()
        Me.bntxoa = New System.Windows.Forms.Button()
        Me.bntdong = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstsanpham = New System.Windows.Forms.ListView()
        Me.clmasanpham = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cltensanpham = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clloaisanpham = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clgia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã sản phẩm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên sản phẩm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Loản sản phẩm"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Giá"
        '
        'txtmasanpham
        '
        Me.txtmasanpham.Location = New System.Drawing.Point(159, 28)
        Me.txtmasanpham.Name = "txtmasanpham"
        Me.txtmasanpham.Size = New System.Drawing.Size(356, 20)
        Me.txtmasanpham.TabIndex = 1
        '
        'txttensanpham
        '
        Me.txttensanpham.Location = New System.Drawing.Point(159, 54)
        Me.txttensanpham.Name = "txttensanpham"
        Me.txttensanpham.Size = New System.Drawing.Size(356, 20)
        Me.txttensanpham.TabIndex = 1
        '
        'txtloaisanpham
        '
        Me.txtloaisanpham.Location = New System.Drawing.Point(159, 80)
        Me.txtloaisanpham.Name = "txtloaisanpham"
        Me.txtloaisanpham.Size = New System.Drawing.Size(356, 20)
        Me.txtloaisanpham.TabIndex = 1
        '
        'txtgia
        '
        Me.txtgia.Location = New System.Drawing.Point(159, 106)
        Me.txtgia.Name = "txtgia"
        Me.txtgia.Size = New System.Drawing.Size(356, 20)
        Me.txtgia.TabIndex = 1
        '
        'bntthem
        '
        Me.bntthem.Location = New System.Drawing.Point(159, 132)
        Me.bntthem.Name = "bntthem"
        Me.bntthem.Size = New System.Drawing.Size(46, 23)
        Me.bntthem.TabIndex = 2
        Me.bntthem.Text = "Thêm"
        Me.bntthem.UseVisualStyleBackColor = True
        '
        'bntsua
        '
        Me.bntsua.Location = New System.Drawing.Point(242, 132)
        Me.bntsua.Name = "bntsua"
        Me.bntsua.Size = New System.Drawing.Size(46, 23)
        Me.bntsua.TabIndex = 2
        Me.bntsua.Text = "Sửa"
        Me.bntsua.UseVisualStyleBackColor = True
        '
        'bntxoa
        '
        Me.bntxoa.Location = New System.Drawing.Point(339, 132)
        Me.bntxoa.Name = "bntxoa"
        Me.bntxoa.Size = New System.Drawing.Size(46, 23)
        Me.bntxoa.TabIndex = 2
        Me.bntxoa.Text = "Xóa"
        Me.bntxoa.UseVisualStyleBackColor = True
        '
        'bntdong
        '
        Me.bntdong.Location = New System.Drawing.Point(449, 132)
        Me.bntdong.Name = "bntdong"
        Me.bntdong.Size = New System.Drawing.Size(46, 23)
        Me.bntdong.TabIndex = 2
        Me.bntdong.Text = "Đóng"
        Me.bntdong.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.bntdong)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.bntxoa)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.bntsua)
        Me.GroupBox1.Controls.Add(Me.txtmasanpham)
        Me.GroupBox1.Controls.Add(Me.bntthem)
        Me.GroupBox1.Controls.Add(Me.txttensanpham)
        Me.GroupBox1.Controls.Add(Me.txtgia)
        Me.GroupBox1.Controls.Add(Me.txtloaisanpham)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 205)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sản Phẩm"
        '
        'lstsanpham
        '
        Me.lstsanpham.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmasanpham, Me.cltensanpham, Me.clloaisanpham, Me.clgia})
        Me.lstsanpham.FullRowSelect = True
        Me.lstsanpham.GridLines = True
        Me.lstsanpham.Location = New System.Drawing.Point(26, 252)
        Me.lstsanpham.Name = "lstsanpham"
        Me.lstsanpham.Size = New System.Drawing.Size(528, 227)
        Me.lstsanpham.TabIndex = 5
        Me.lstsanpham.UseCompatibleStateImageBehavior = False
        Me.lstsanpham.View = System.Windows.Forms.View.Details
        '
        'clmasanpham
        '
        Me.clmasanpham.Text = "Mã sản phẩm"
        Me.clmasanpham.Width = 114
        '
        'cltensanpham
        '
        Me.cltensanpham.Text = "Tên sản phẩm"
        Me.cltensanpham.Width = 129
        '
        'clloaisanpham
        '
        Me.clloaisanpham.Text = "Loại sản phẩm"
        Me.clloaisanpham.Width = 104
        '
        'clgia
        '
        Me.clgia.Text = "Giá"
        Me.clgia.Width = 89
        '
        'FSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 491)
        Me.Controls.Add(Me.lstsanpham)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FSanPham"
        Me.Text = "Sản Phẩm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtmasanpham As System.Windows.Forms.TextBox
    Friend WithEvents txttensanpham As System.Windows.Forms.TextBox
    Friend WithEvents txtloaisanpham As System.Windows.Forms.TextBox
    Friend WithEvents txtgia As System.Windows.Forms.TextBox
    Friend WithEvents bntthem As System.Windows.Forms.Button
    Friend WithEvents bntsua As System.Windows.Forms.Button
    Friend WithEvents bntxoa As System.Windows.Forms.Button
    Friend WithEvents bntdong As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstsanpham As System.Windows.Forms.ListView
    Friend WithEvents clmasanpham As System.Windows.Forms.ColumnHeader
    Friend WithEvents cltensanpham As System.Windows.Forms.ColumnHeader
    Friend WithEvents clloaisanpham As System.Windows.Forms.ColumnHeader
    Friend WithEvents clgia As System.Windows.Forms.ColumnHeader
End Class
