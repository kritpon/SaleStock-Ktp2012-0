Public Class frmTypeP_Post
    Dim lsvItem As New ListViewItem

    Private Sub frmTypeP_Post_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        lsvItem.SubItems.Add("VB.net 2015")
        lsvItem.SubItems.Add("VB.net 2015")
        lsvItem = ListView1.Items.Add("P001")


        lsvItem.SubItems.Add("VB.net 2015")
        lsvItem.SubItems.Add("VB.net 2015")
        lsvItem = ListView1.Items.Add("P001")

        lsvItem.SubItems.Add(TextBox1.Text).BackColor = Color.Yellow
        ListView1.Items.Insert(1, "rwer")


    End Sub
End Class