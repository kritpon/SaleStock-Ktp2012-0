Public Class frmPriceList
    Dim DS As DataSet = New DataSet
    Dim DA As SqlClient.SqlDataAdapter
    Dim chkLoad As Boolean = False

    Dim stkCode As String = ""

    Dim AnyData() As String
    Dim lvi As ListViewItem

    Dim prPrice As Double = 0
    Dim PrDate As Date
    Dim docNo As String
    Dim docOrder As String
    Dim prDic As String
    Dim iMax As Integer = 0

    Sub HeadList()

        'If chkTB = True Then

        '    lsvShowBill.Columns.Clear()
        '    lsvShowBill.Items.Clear()
        '    chkTB = False

        'End If
        With listPrice.Columns

            .Add("วันที่ขาย", 110, HorizontalAlignment.Left) '0
            .Add("เอกสาร Order", 110, HorizontalAlignment.Center) '1
            .Add("เอกสาร", 110, HorizontalAlignment.Right) '2
            .Add("ราคา", 120, HorizontalAlignment.Right) '\3
            .Add("% สวนลด", 110, HorizontalAlignment.Right) '4

            '.Add("เลขที่Order", 100, HorizontalAlignment.Center) '3
            '.Add("ชื่อลูกค้า", 220, HorizontalAlignment.Left) '4
            '.Add("Vatลูกค้า", 40, HorizontalAlignment.Right) '9
            '.Add("ชื่อสินค้า", 250, HorizontalAlignment.Left) '5
            '.Add("จำนวน", 80, HorizontalAlignment.Right) '6
            '.Add("ราคา/แผ่น", 100, HorizontalAlignment.Right) '7
            '.Add("ราคารวม", 100, HorizontalAlignment.Right) '8
            '.Add("runID", 100, HorizontalAlignment.Right) '8

        End With
      
        listPrice.View = View.Details
        listPrice.GridLines = True


        'chkTB = True

    End Sub

    Function genSQLPrice() As String

        txtSQL = "Select top 100 * "
        txtSQL = txtSQL & "From TrandataD  "
        If optSales.Checked = True Then
            txtSQL = txtSQL & "Where Dtl_type ='S' "
        ElseIf optOrder.Checked = True Then

            txtSQL = txtSQL & "Where Dtl_type ='B' "
        ElseIf optCost.Checked = True Then
            txtSQL = txtSQL & "Where Dtl_type ='C' "

        End If

        txtSQL = txtSQL & "And Dtl_idTrade ='" & SelectCode & "' "
        txtSQL = txtSQL & "And Dtl_idCus='" & CusId & "' "
        txtSQL = txtSQL & "Order by dtl_date desc "


        Return txtSQL
    End Function
    Sub loadPrice()

       
        Call HeadList()

        Dim rowSel As Boolean = False

        txtSQL = genSQLPrice()
        If chkLoad = True Then
            DS.Tables("prList").Clear()
            chkLoad = False
            listPrice.Clear()
            HeadList()
        End If
        DA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        DA.Fill(DS, "prList")
        chkLoad = True
        lbStkName.Text = DBtools.getStkName(SelectCode)
        For iMax = 0 To DS.Tables("prList").Rows.Count - 1

            'AnyData = New String() {PrDate, stkPrice.ToString("#,##0.00"), BSum.ToString("#,##0.00")}
            With DS.Tables("prList")
                PrDate = .Rows(iMax).Item("Dtl_Date")
                docNo = .Rows(iMax).Item("Dtl_NO")
                docOrder = .Rows(iMax).Item("Dtl_Con_id")
                prPrice = .Rows(iMax).Item("Dtl_Price")
                If IsDBNull(.Rows(iMax).Item("dtl_t_disc")) Then
                    prDic = "" '.Rows(iMax).Item("dtl_t_disc")
                Else
                    prDic = .Rows(iMax).Item("dtl_t_disc")
                End If


            End With

            AnyData = New String() {PrDate, docOrder, docNo, prPrice.ToString("#,##0.00"), prDic}
            lvi = New ListViewItem(AnyData)

            If rowSel = False Then
                'lvi.BackColor = System.Drawing.Color.Khaki
                'lvi.ForeColor = System.Drawing.Color.Black
                'lvi.UseItemStyleForSubItems = True
                lvi.BackColor = System.Drawing.Color.White
                lvi.ForeColor = System.Drawing.Color.Black
                lvi.UseItemStyleForSubItems = True
                rowSel = True
            Else
                lvi.BackColor = System.Drawing.Color.WhiteSmoke
                lvi.ForeColor = System.Drawing.Color.Black
                lvi.UseItemStyleForSubItems = True
                rowSel = False
            End If


            listPrice.Items.Add(lvi)

        Next iMax
    End Sub

    Private Sub frmPriceList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call loadPrice()
    End Sub

     
    Private Sub cmbSelect_Click(sender As Object, e As EventArgs) Handles cmbSelect.Click
        SelectPrice = CDbl(lbPrice.Text)
        SelectDisc = Trim(lbDisc.Text)
        Me.Close()

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub optOrder_CheckedChanged(sender As Object, e As EventArgs) Handles optOrder.CheckedChanged
        Call loadPrice()
    End Sub

    Private Sub optSales_CheckedChanged(sender As Object, e As EventArgs) Handles optSales.CheckedChanged
        Call loadPrice()
    End Sub

    Private Sub listPrice_Click(sender As Object, e As EventArgs) Handles listPrice.Click
        Dim editChk As Boolean = False
        Dim i As Integer = 0
        'Dim LEdit As Integer
        For i = 0 To listPrice.SelectedItems.Count - 1
            editChk = True

            LEdit = listPrice.SelectedItems(i)
            'Ditem = listPrice.Items(LEdit.Index).SubItems(0).Text 'ลำดับ
            prPrice = listPrice.Items(LEdit.Index).SubItems(3).Text 'เลขที่Pickking
            PrDate = listPrice.Items(LEdit.Index).SubItems(0).Text 'เลขที่Order
            prDic = listPrice.Items(LEdit.Index).SubItems(4).Text 'เลขที่Order

        Next

        lbPrice.Text = prPrice
        lbDate.Text = PrDate
        lbDisc.Text = prDic


    End Sub

    Private Sub listPrice_DoubleClick(sender As Object, e As EventArgs) Handles listPrice.DoubleClick

        Dim editChk As Boolean = False
        Dim i As Integer = 0
        'Dim LEdit As Integer
        For i = 0 To listPrice.SelectedItems.Count - 1
            editChk = True

            LEdit = listPrice.SelectedItems(i)
            'Ditem = listPrice.Items(LEdit.Index).SubItems(0).Text 'ลำดับ
            prPrice = listPrice.Items(LEdit.Index).SubItems(3).Text 'เลขที่Pickking
            PrDate = listPrice.Items(LEdit.Index).SubItems(0).Text 'เลขที่Order
            prDic = listPrice.Items(LEdit.Index).SubItems(4).Text 'เลขที่Order

        Next

        lbPrice.Text = prPrice
        lbDate.Text = PrDate
        lbDisc.Text = prDic

        SelectPrice = CDbl(lbPrice.Text)
        SelectDisc = Trim(lbDisc.Text)
        Me.Close()

    End Sub

   
    Private Sub listPrice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listPrice.SelectedIndexChanged

    End Sub
End Class