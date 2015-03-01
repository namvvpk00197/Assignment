Imports System.Data
Imports System.Data.SqlClient
Public Class Fhoadon
    Dim ketnoidulieu As New SqlConnection("Data Source=PCNAMVUONG;Initial Catalog=Namvvpk00197_asm_1;Integrated Security=True")
    Private Sub Loaddulieu()
        ketnoidulieu.Open()
        Dim truyvan As New SqlCommand("select * from HOADON", ketnoidulieu)
        Dim ad As New SqlDataAdapter(truyvan)
        Dim table As New DataTable
        ad.Fill(table)
        ketnoidulieu.Close()
        lstSanpham.Items.Clear()
        Dim i As Integer
        For Each hang As DataRow In table.Rows
            lstsanpham.Items.Add(hang("MaHoaDon").ToString())
            lstsanpham.Items(i).SubItems.Add(hang("MaKhachHang").ToString())
            lstsanpham.Items(i).SubItems.Add(hang("NgayLamHoaDon").ToString())
            lstsanpham.Items(i).SubItems.Add(hang("ThanhTien").ToString())
            i += 1
        Next
    End Sub
    Private Sub Fhoadon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loaddulieu()
    End Sub
    Private Sub lstsanpham_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstsanpham.SelectedIndexChanged
        For Each List As ListViewItem In lstsanpham.SelectedItems
            txtmahoadon.Text = List.SubItems(0).Text
            txtmakhachhang.Text = List.SubItems(1).Text
            txtngaylamhoadon.Text = List.SubItems(2).Text
            txtthanhtien.Text = List.SubItems(3).Text
        Next
    End Sub

    Private Sub bntthem_Click(sender As Object, e As EventArgs) Handles bntthem.Click
        Try
            ketnoidulieu.Open()
            Dim Makhachhang As String = txtmakhachhang.Text
            Dim Ngaylamhoadon As String = txtngaylamhoadon.Text
            Dim Thanhtien As String = txtthanhtien.Text
            Dim truyvan1 As New SqlCommand("insert into HOADON values (N'" + Makhachhang + "',N'" + Ngaylamhoadon + "', N'" + Thanhtien + "')", ketnoidulieu)
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
            Dim Mahoadon As String = txtmahoadon.Text
            Dim Makhachhang As String = txtmakhachhang.Text
            Dim Ngaylamhoadon As String = txtngaylamhoadon.Text
            Dim Thanhtien As String = txtthanhtien.Text
            Dim truyvan2 As New SqlCommand("Update HOADON set Makhachhang='" + Makhachhang + "',Ngaylamhoadon='" + Ngaylamhoadon + "',Thanhtien='" + Thanhtien + "' where MaHoaDon='" + Mahoadon + "'", ketnoidulieu)
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
            Dim ID As String = txtmahoadon.Text
            Dim truyvan1 As New SqlCommand("delete from HOADON where MaHoaDon = '" + ID + "'", ketnoidulieu)
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
