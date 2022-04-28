Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lv.Columns.Add("Mã thuốc", 60, HorizontalAlignment.Center)
        lv.Columns.Add("Loại thuốc", 130, HorizontalAlignment.Center)
        lv.Columns.Add("Tên thuốc", 130, HorizontalAlignment.Center)
        lv.Columns.Add("Hạn sử dụng", 130, HorizontalAlignment.Center)
        lv.Columns.Add("Nhà cung cấp", 130, HorizontalAlignment.Center)
        lv.Columns.Add("Số lượng", 130, HorizontalAlignment.Center)
    End Sub

    Private Sub lv_Click(sender As Object, e As EventArgs) Handles lv.Click
        If lv.SelectedItems.Count > 0 Then
            tb1.Text = lv.SelectedItems(0).SubItems(0).Text
            tb2.Text = lv.SelectedItems(0).SubItems(1).Text
            tb3.Text = lv.SelectedItems(0).SubItems(2).Text
            tb4.Text = lv.SelectedItems(0).SubItems(3).Text
            tb5.Text = lv.SelectedItems(0).SubItems(4).Text
            tb6.Text = lv.SelectedItems(0).SubItems(5).Text
        End If
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim ptu As New ListViewItem(tb1.Text)
        ptu.SubItems.Add(tb2.Text)
        ptu.SubItems.Add(tb3.Text)
        ptu.SubItems.Add(tb4.Text)
        ptu.SubItems.Add(tb5.Text)
        ptu.SubItems.Add(tb6.Text)

        lv.Items.Add(ptu)

        tb1.Text = ""
        tb2.Text = ""
        tb3.Text = ""
        tb4.Text = ""
        tb5.Text = ""
        tb6.Text = ""
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If lv.SelectedItems.Count > 0 Then
            lv.SelectedItems(0).SubItems(0).Text = tb1.Text
            lv.SelectedItems(0).SubItems(1).Text = tb2.Text
            lv.SelectedItems(0).SubItems(2).Text = tb3.Text
            lv.SelectedItems(0).SubItems(3).Text = tb4.Text
            lv.SelectedItems(0).SubItems(4).Text = tb5.Text
            lv.SelectedItems(0).SubItems(5).Text = tb6.Text

            tb1.Text = ""
            tb2.Text = ""
            tb3.Text = ""
            tb4.Text = ""
            tb5.Text = ""
            tb6.Text = ""
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If lv.SelectedItems.Count > 0 Then
            lv.Items.Remove(lv.SelectedItems(0))
            tb1.Text = ""
            tb2.Text = ""
            tb3.Text = ""
            tb4.Text = ""
            tb5.Text = ""
            tb6.Text = ""
        End If
    End Sub
End Class
