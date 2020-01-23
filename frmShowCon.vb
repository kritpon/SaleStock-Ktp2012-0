Public Class frmShowCon
    Dim chkData As Boolean = False

    Sub showDATA()
        Dim subDa As SqlClient.SqlDataAdapter
        Dim subDs As New DataSet

        Dim strID As String
        Dim strName As String

        Dim anydata() As String
        Dim lvi As ListViewItem
        Dim i As Integer

        txtSQL = "Select * "
        txtSQL = txtSQL & "From ArConDetl "
        txtSQL = txtSQL & "Left Join ArCondition "
        txtSQL = txtSQL & "on ArCondetl.Ar_Con_id=ArCondition.Ar_Con_ID  "

        txtSQL = txtSQL & "Where ArCondetl.Ar_Con_CusID='" & selCusiD & "' "
        txtSQL = txtSQL & "Order by ArCondetl.Ar_Con_ID "

        If chkData = True Then
            subDs.Tables("Detail").Clear()
            chkData = False
            End If

        subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa.Fill(subDs, "Detail")
        chkData = True
        lsvCond.Items.Clear()
        If subDs.Tables("Detail").Rows.Count > 0 Then



            For i = 0 To subDs.Tables("Detail").Rows.Count - 1
                With subDs.Tables("Detail").Rows(i)

                    strID = .Item("Ar_Con_ID")
                    strName = .Item("Ar_con_Name")

                    anydata = New String() {strID, strName}
                    lvi = New ListViewItem(anydata)
                    lsvCond.Items.Add(lvi)

                End With

            Next
        Else
            Me.Close()
        End If

    End Sub
    Sub fmtListView()

        lsvCond.Columns.Add("ID.", 80, HorizontalAlignment.Center) '0
        lsvCond.Columns.Add("รายการ", 300, HorizontalAlignment.Left) '1
        'lsvMap.Columns.Add("Order No.", 480, HorizontalAlignment.Left) '2
        lsvCond.View = View.Details
        lsvCond.GridLines = True

    End Sub

    Private Sub frmShowCon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DBtools.openDB()

        Call fmtListView()
        Call showDATA()

    End Sub

    Private Sub cmbExit_Click(sender As Object, e As EventArgs) Handles cmbExit.Click
        Me.Close()

    End Sub
End Class