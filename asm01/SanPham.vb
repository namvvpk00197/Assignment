Imports System.Data
Imports System.Data.SqlClient
Public Class FSanPham
    Dim ketnoidulieu As New SqlConnection("Data Source=PCNAMVUONG;Initial Catalog=Namvvpk00197_asm_1;Integrated Security=True")
    Private Sub Loaddulieu()
        ketnoidulieu.Open()
        Dim truyvan As New SqlCommand("select * from SANPHAM", ketnoidulieu)
        Dim ad As New SqlDataAdapter(truyvan)
        Dim table As New DataTable
        ad.Fill(table)
        ketnoidulieu.Close()
        lstsanpham.Items.Clear()
        Dim i As Integer
        For Each hang As DataRow In table.Rows
            lstsanpham.Items.Add(hang("MaSanPham").ToString())
            lstsanpham.Items(i).SubItems.Add(hang("TenSanPham").ToString())
            lstsanpham.Items(i).SubItems.Add(hang("MaLoaiSanPham").ToString())
            lstsanpham.Items(i).SubItems.Add(hang("Gia").ToString())
            i += 1
        Next
    End Sub

    Private Sub FSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loaddulieu()
    End Sub
    Private Sub lstsanpham_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstsanpham.SelectedIndexChanged
        For Each List As ListViewItem In lstsanpham.SelectedItems
            txtmasanpham.Text = List.SubItems(0).Text
            Txttensanpham.Text = List.SubItems(1).Text
            txtloaisanpham.Text = List.SubItems(2).Text
            txtgia.Text = List.SubItems(3).Text
        Next
    End Sub

    Private Sub bntthem_Click(sender As Object, e As EventArgs) Handles bntthem.Click
        Try
            ketnoidulieu.Open()
            Dim Tensanpham As String = txttensanpham.Text
            Dim Loaisanpham As String = txtloaisanpham.Text
            Dim Gia As String = txtgia.Text
            Dim truyvan1 As New SqlCommand("insert into SANPHAM values (N'" + Tensanpham + "',N'" + Loaisanpham + "','" + Gia + "')", ketnoidulieu)
            truyvan1.ExecuteNonQuery()
            ketnoidulieu.Close()
            MessageBox.Show("Thêm dữ liệu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Loaddulieu()
        Catch ex As Exception
            MessageBox.Show("Thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bntsua_Click(sender As Object, e As EventArgs) Handles bntsua.Click
        Try
            ketnoidulieu.Open()
            Dim ID As String = txtmasanpham.Text
            Dim Tensanpham As String = txttensanpham.Text
            Dim Loaisanpham As String = txtloaisanpham.Text
            Dim Gia As String = txtgia.Text
            Dim truyvan2 As New SqlCommand("Update sanpham set Tensanpham='" + Tensanpham + "',MaLoaisanpham='" + Loaisanpham + "',Gia='" + Gia + "' where Masanpham='" + ID + "'", ketnoidulieu)
            truyvan2.ExecuteNonQuery()
            ketnoidulieu.Close()
            MessageBox.Show("Đã sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Loaddulieu()
        Catch ex As Exception
            MessageBox.Show("Không thể sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bntxoa_Click(sender As Object, e As EventArgs) Handles bntxoa.Click
        Try
            ketnoidulieu.Open()
            Dim ID As String = txtmasanpham.Text
            Dim truyvan1 As New SqlCommand("delete from SANPHAM where Masanpham = '" + ID + "'", ketnoidulieu)
            truyvan1.ExecuteNonQuery()
            ketnoidulieu.Close()
            MessageBox.Show("Đã xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Loaddulieu()
        Catch ex As Exception
            MessageBox.Show("Không thể xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bntdong_Click(sender As Object, e As EventArgs) Handles bntdong.Click
        Me.Close()
    End Sub
End Class