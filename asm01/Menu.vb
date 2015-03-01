Public Class Menu

    Private Sub txthoadons_Click(sender As Object, e As EventArgs) Handles txthoadons.Click
        Dim f As New Fhoadon()
        f.Show()
    End Sub

    Private Sub txtchitiethoadons_Click(sender As Object, e As EventArgs) Handles txtchitiethoadons.Click
        Dim f As New Fchitiethoadon()
        f.Show()
    End Sub

    Private Sub txtsanphams_Click(sender As Object, e As EventArgs) Handles txtsanphams.Click
        Dim f As New FSanPham()
        f.Show()
    End Sub
End Class