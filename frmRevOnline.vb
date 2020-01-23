Public Class frmRevOnline
    Dim subDA As New SqlClient.SqlDataAdapter
    Dim subDS As New DataSet

    'Dim subDA As New SqlClient.SqlDataAdapter
    'Dim subDS As New DataSet

    Dim chkMaster As Boolean = False
    Dim chkArFile As Boolean = False


    Dim AnyData() As String
    Dim Lvi As ListViewItem
    Dim strT_Type As String = ""
    Dim strP_Type As String = ""
    Dim strB_Type As String = ""
    Dim strPOdoc As String = ""
    Dim strStkCode As String = ""
    Dim strStkName As String = ""
    Dim stkQty As Double = 0
    Dim stkQty2 As Double = 0
    Dim stkPrice As Double = 0
    Dim stkDisc As String = ""
    Dim stkAmt As Double = 0
    Dim strDetl As String = ""
    Dim strCusCode As String = ""
    Dim strCusName As String = ""

    Dim chkAdd As Boolean = False
    Dim chkData As Boolean = False

    Dim i As Integer = 0

    Sub getCols()
       
        lsvRev.Clear()
        lsvRev.Columns.Add("เลขที่ PO", 100, HorizontalAlignment.Center)        '==0
        lsvRev.Columns.Add("TypeV", 30, HorizontalAlignment.Center)        '==0
        lsvRev.Columns.Add("ใบจอง", 0, HorizontalAlignment.Center)        '==1
        lsvRev.Columns.Add("ใบเบิก", 80, HorizontalAlignment.Center)        '==2

        lsvRev.Columns.Add("รหัสลูกค้า", 0, HorizontalAlignment.Left)      '==3
        lsvRev.Columns.Add("ชื่อลูกค้า", 200, HorizontalAlignment.Left)      '==4
        lsvRev.Columns.Add("Order", 80, HorizontalAlignment.Left)      '==5
        lsvRev.Columns.Add("รหัสสินค้า", 0, HorizontalAlignment.Center)     '==6
        lsvRev.Columns.Add("รายการ", 300, HorizontalAlignment.Left)      '==7
        lsvRev.Columns.Add("จำนวนเบิก", 80, HorizontalAlignment.Right)      '==8
        lsvRev.Columns.Add("จำนวนจัด", 80, HorizontalAlignment.Right)      '==8

        lsvRev.Columns.Add("ราคา/หน่วย", 100, HorizontalAlignment.Right)     '==9
        'lsvRev.Columns.Add("%ลด", 100, HorizontalAlignment.Left)          '==10        
        lsvRev.Columns.Add("มูลค่า", 100, HorizontalAlignment.Right)         '==11

        lsvRev.Columns.Add("หมายเหตุ", 100, HorizontalAlignment.Left)      '==12
        lsvRev.Columns.Add("condition", 100, HorizontalAlignment.Left)      '==12

        lsvRev.View = View.Details
        lsvRev.GridLines = True



    End Sub

    Private Sub frmRevOnline_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If chkLoad = False Then

            'If selCusiD = "" Then
            'Call getCols()
            'Call getDataShow()
            'Else
            txtDate01.Text = Now
            Call getCols()
            Call getDataShow()
            chkLoad = True
            ' MsgBox("True")
            '        Else
        End If


        ' End If


    End Sub

    Sub getDataShow()

        Dim strVATtype As String = ""
        Dim dtlChk As Boolean = False
        Dim chkColor As Boolean = False
        Dim dtlCondition As String = ""


        txtSQL1 = " SELECt TrhType.Trh_NoType TypeVAT ,TranDataH.Trh_Transport,CarMast.Car_Contact_Name,"
        txtSQL1 = txtSQL1 & "CarMast.Car_Name, TranDataD.Dtl_type, TranDataD.Dtl_date,"
        txtSQL1 = txtSQL1 & "TranDataD.Dtl_no,TranDataD.Dtl_Order,TranDataD.Dtl_Type_T, TranDataD.Dtl_con_id,Dtl_Chk, "
        txtSQL1 = txtSQL1 & "ArFile.Ar_Cus_id,ArFile.AR_NAME,"
        txtSQL1 = txtSQL1 & "(ArFile.Ar_Addr + ' ' + ArFile.Ar_Addr_1+ ' ' + ArFile.Ar_Addr_2)as Ar_Addr,"

        txtSQL1 = txtSQL1 & "TranDataD.Dtl_detail,TranDataD.Dtl_Condition,SalesMan.SL_Name, "
        txtSQL1 = txtSQL1 & "(Ar_Map_Code + '-' + Map_S_Line_name)as Zone,"
        txtSQL1 = txtSQL1 & "left(Ar_Map_Code,1)as Map_Grp,"
        txtSQL1 = txtSQL1 & "TranDataD.Dtl_idtrade,BaseMast.Stk_Name_1,BaseMast.Stk_Factor,"
        txtSQL1 = txtSQL1 & "TranDataD.Dtl_price, TranDataD.Dtl_num,TranDataD.Dtl_num_2,  TranDataD.Dtl_sum,  "
        txtSQL1 = txtSQL1 & "(BaseMast.Stk_Factor * TranDataD.Dtl_num) AS FacSum, "
        txtSQL1 = txtSQL1 & "(TranDataD.Dtl_price / BaseMast.Stk_Factor ) AS PrPerKg,  "
        txtSQL1 = txtSQL1 & "(TranDataD.Dtl_price * TranDataD.Dtl_Num ) AS PrPerB "

        txtSQL1 = txtSQL1 & "FROM  TranDataD "
        txtSQL1 = txtSQL1 & "RIGHT JOIN TranDataH  "
        txtSQL1 = txtSQL1 & "ON (TranDataD.Dtl_no = TranDataH.Trh_No "
        txtSQL1 = txtSQL1 & "AND TranDataD.Dtl_type = TranDataH.Trh_Type) "

        '=================================================================
        '  ทำเพื่อแสดงประเภทของ VAT ให้เลือกได้ 
        txtSQL1 = txtSQL1 & "left Join "
        txtSQL1 = txtSQL1 & "(Select * "
        txtSQL1 = txtSQL1 & "From TranDataH "

        txtSQL1 = txtSQL1 & "Where TranDataH.Trh_Type='T' "
        'txtSQL1 = txtSQL1 & "and TranDataH.Trh_Date='201'"
        txtSQL1 = txtSQL1 & ")TrhType "
        txtSQL1 = txtSQL1 & "On TranDataD.Dtl_Order=TrhType.Trh_No "

        '=================================================================

        txtSQL1 = txtSQL1 & "LEFT JOIN ArFile "
        txtSQL1 = txtSQL1 & "ON TranDataD.Dtl_idcus = ArFile.AR_CUS_ID  "

        txtSQL1 = txtSQL1 & " Left Join MapSLineMast "
        txtSQL1 = txtSQL1 & " On Ar_Map_Code=Map_S_Line_Code "

        txtSQL1 = txtSQL1 & "LEFT JOIN BaseMast "
        txtSQL1 = txtSQL1 & "ON TranDataD.Dtl_idtrade = BaseMast.Stk_Code "

        txtSQL1 = txtSQL1 & "Left Join CarMast "
        txtSQL1 = txtSQL1 & "On TranDataH.Trh_Cus=CarMast.Car_No "

        txtSQL1 = txtSQL1 & "Left Join SalesMAN "
        txtSQL1 = txtSQL1 & "On Arfile.Ar_Sales=SalesMan.SL_ID "
       

        txtSQL1 = txtSQL1 & "WHERE (TranDataD.Dtl_type = 'P') "

        txtSQL1 = txtSQL1 & "And TranDataD.Dtl_state=0 "
        If chkRev.Checked = True Then
            txtSQL1 = txtSQL1 & "And TranDataD.Dtl_Chk<>'0' "
        Else
            'txtSQL1 = txtSQL1 & "And TranDataD.Dtl_Chk='0' "
        End If

        'txtSQL1 = txtSQL1 & "And (TranDataH.trh_date>= '" & ((Month(txtDate01.Value) & "-" & DateAndTime.Day(txtDate01.Value) & "-" & Year(txtDate01.Value) - 543)) & "') "

        txtSQL1 = txtSQL1 & "And (TranDataD.Dtl_Duedate= '" & ((Month(txtDate01.Value) & "-" & DateAndTime.Day(txtDate01.Value) & "-" & Year(txtDate01.Value) - 543)) & "')  "

        If SelectTypeP_No2 = "" Then
        Else
            txtSQL1 = txtSQL1 & "And (TranDataD.Dtl_no='" & SelectTypeP_No2 & "') "
        End If

        If selCusiD = "" Or chkCus.Checked = False Then

        Else
            txtSQL1 = txtSQL1 & "And (TranDataD.Dtl_idCus='" & selCusiD & "') "
        End If


        'If chkDate.Checked = True Then
        '    txtSQL1 = txtSQL1 & "And (TranDataD.Dtl_date>= '" & (Format(DateAdd(DateInterval.Year, -543, Date01.Value), "MM/dd/yyyy")) & "')  "
        '    txtSQL1 = txtSQL1 & "And (TranDataD.Dtl_date<= '" & (Format(DateAdd(DateInterval.Year, -543, Date02.Value), "MM/dd/yyyy")) & "') "
        'End If

        'If chkTransport.Checked = True Then
        '    txtSQL1 = txtSQL1 & " and TranDatah.trh_transport= '" & cboTransport.SelectedValue & "'"
        'End If

        txtSQL1 = txtSQL1 & " Order by dtl_no desc,AR_Cus_ID,TranDataH.Trh_Transport,dtl_idcus,TrhType.Trh_NoType  "

        subDA = New SqlClient.SqlDataAdapter(txtSQL1, Conn)
        If chkData = True Then

            subDS.Tables("Master").Clear()
            chkData = False

        End If

        subDA.Fill(subDS, "Master")
        chkData = True
        Dim rw As Integer = 0

        For rw = 0 To subDS.Tables("Master").Rows.Count - 1

            With subDS.Tables("Master")
                dtlChk = .Rows(rw).Item("Dtl_Chk")

                If IsDBNull(.Rows(rw).Item("TypeVAT")) Then
                    strVATtype = ""
                Else
                    strVATtype = .Rows(rw).Item("TypeVAT")  ' ประเภทVAT
                End If

                strT_Type = .Rows(rw).Item("Dtl_Order")  ' ใบจอง
                strP_Type = .Rows(rw).Item("Dtl_No")  ' ใบเบิก
                strB_Type = .Rows(rw).Item("Dtl_con_id")  ' Order
                strPOdoc = getDocPO(strB_Type)
                strStkCode = .Rows(rw).Item("Dtl_idTrade")
                strStkName = .Rows(rw).Item("Stk_Name_1")
                '========================  Type P  Dtl_Num_2  คือ จัดของได้
                If IsDBNull(.Rows(rw).Item("Dtl_Num_2")) Then
                    stkQty2 = 0 ' .Rows(rw).Item("Dtl_Num")

                Else
                    If (.Rows(rw).Item("Dtl_Num_2") = 0) Then
                        stkQty2 = 0 '.Rows(rw).Item("Dtl_Num")
                    Else
                        stkQty2 = .Rows(rw).Item("Dtl_Num_2")
                    End If
                End If
                '========================  Type P  Dtl_Num  คือ จำนวนเบิก

                If IsDBNull(.Rows(rw).Item("Dtl_Num")) Then
                    stkQty = 0 '.Rows(rw).Item("Dtl_Num")

                Else
                    If (.Rows(rw).Item("Dtl_Num") = 0) Then
                        stkQty = 0 '.Rows(rw).Item("Dtl_Num")
                    Else
                        stkQty = .Rows(rw).Item("Dtl_Num")
                    End If
                End If

                'stkQty = .Rows(rw).Item("Dtl_Num")

                stkPrice = .Rows(rw).Item("Dtl_Price")
                stkAmt = .Rows(rw).Item("Dtl_Sum")
                strDetl = .Rows(rw).Item("Dtl_detail")
                dtlCondition = .Rows(rw).Item("Dtl_Condition")

                strCusCode = .Rows(rw).Item("Ar_Cus_iD")
                strCusName = .Rows(rw).Item("Ar_Name")

            End With

            AnyData = New String() {strPOdoc, strVATtype, strT_Type, strP_Type, strCusCode, strCusName, strB_Type, strStkCode,
                                    strStkName, stkQty.ToString("#,##0.00"), stkQty2.ToString("#,##0.00"), stkPrice.ToString("#,##0.00"),
                                     stkAmt, strDetl, dtlCondition}

            Lvi = New ListViewItem(AnyData)
            lsvRev.Items.Add(Lvi)
            If dtlChk = False Then
                Lvi.BackColor = System.Drawing.Color.Orange
                Lvi.ForeColor = System.Drawing.Color.Black
                Lvi.UseItemStyleForSubItems = True

                'If chkColor = True Then
                '    Lvi.BackColor = System.Drawing.Color.White
                '    Lvi.ForeColor = System.Drawing.Color.Black
                '    Lvi.UseItemStyleForSubItems = True
                '    chkColor = False
                'Else

                '    Lvi.BackColor = System.Drawing.Color.WhiteSmoke
                '    Lvi.ForeColor = System.Drawing.Color.Black
                '    Lvi.UseItemStyleForSubItems = True
                '    chkColor = True

                'End If

            ElseIf dtlChk = True Then
                Lvi.BackColor = System.Drawing.Color.DarkGreen
                Lvi.ForeColor = System.Drawing.Color.WhiteSmoke
                Lvi.UseItemStyleForSubItems = True

                'If chkColor = True Then
                '    Lvi.BackColor = System.Drawing.Color.White
                '    Lvi.ForeColor = System.Drawing.Color.Black
                '    Lvi.UseItemStyleForSubItems = True
                '    chkColor = False
                'Else

                '    Lvi.BackColor = System.Drawing.Color.WhiteSmoke
                '    Lvi.ForeColor = System.Drawing.Color.Black
                '    Lvi.UseItemStyleForSubItems = True
                '    chkColor = True

                'End If
            End If
            dtlChk = False
        Next

        If (selCusiD = "") Then
        Else
            lbCusName.Text = strCusName
            lbStkName.Text = strStkName
            lbDocTypeP.Text = strP_Type
        End If

    End Sub

    Private Sub lsvRev_Click(sender As Object, e As EventArgs) Handles lsvRev.Click

        'If Not (selCusiD = "") Then
        'Else

        'End If

        For i = 0 To lsvRev.SelectedItems.Count - 1

            Lvi = lsvRev.SelectedItems(i)

            selCusiD = lsvRev.SelectedItems(i).SubItems.Item(4).Text()   ' รหัสลูกค้า
            selCusName = lsvRev.SelectedItems(i).SubItems.Item(5).Text() ' ชื่อลูกค้า

            'Lvi = lsvRev.SelectedItems(i)

            SelectNo2 = lsvRev.SelectedItems(i).SubItems.Item(6).Text()  'เลขที่ Order  
            'selCusiD = lsvRev.SelectedItems(i).SubItems.Item(2).Text()   ' รหัสลูกค้า
            'selCusName = lsvRev.SelectedItems(i).SubItems.Item(3).Text() ' ชื่อลูกค้า
            SelectCode2 = lsvRev.SelectedItems(i).SubItems.Item(7).Text() ' ชื่อสินค้า

            If lsvRev.SelectedItems(i).SubItems.Item(10).Text() = 0 Then ' จำนวนจัด
                SelectNum2 = lsvRev.SelectedItems(i).SubItems.Item(9).Text() ' จำนวนเบิก
            Else
                SelectNum2 = lsvRev.SelectedItems(i).SubItems.Item(10).Text() ' จำนวน

            End If

            SelectRevNo2 = lsvRev.SelectedItems(i).SubItems.Item(2).Text() ' ใบจอง
            SelectTypeP_No2 = lsvRev.SelectedItems(i).SubItems.Item(3).Text() ' ใบเบิก
            selectDetail = lsvRev.SelectedItems(i).SubItems.Item(13).Text()
            selectCondition = lsvRev.SelectedItems(i).SubItems.Item(14).Text()
            SelectPrice2 = lsvRev.SelectedItems(i).SubItems.Item(11).Text()
            selTypeVAT = lsvRev.SelectedItems(i).SubItems.Item(1).Text()
            'If chkAdd = False Then

            'Else
            lsvRev.SelectedItems(i).SubItems.Clear()
            'End If

        Next
        ' If chkAdd = False Then

        'Call getCols()
        'Call getDataShow()

        'Else
        chkLoad = True
        Me.Hide()


    End Sub


    'Private Sub lsvRev_DoubleClick(sender As Object, e As EventArgs) Handles lsvRev.DoubleClick

    '    'Dim i As Integer = 0

    '    'SelectNo2 =  'เลขที่ Order  lsvShow.SelectedItems(i).SubItems.Item(1).Text()
    '    'SelectPNo2 = lsvShow.SelectedItems(i).SubItems.Item(2).Text()
    '    'SelectCode2 = '  รหัสสินค้า  lsvShow.SelectedItems(i).SubItems.Item(3).Text()
    '    'SelectName2 = '  ชื่อสินค้า  lsvShow.SelectedItems(i).SubItems.Item(4).Text()
    '    'SelectNum2 =  '  จำนวน  lsvShow.SelectedItems(i).SubItems.Item(5).Text()
    '    'SelectStock2 = ' จำนวน สต๊อก  lsvShow.SelectedItems(i).SubItems.Item(6).Text()
    '    'SelectPrice2 = lsvShow.SelectedItems(i).SubItems.Item(7).Text()
    '    'SelectDisc = lsvShow.SelectedItems(i).SubItems.Item(9).Text()
    '    'SelectWeight2 = lsvShow.SelectedItems(i).SubItems.Item(10).Text()
    '    'selectDetail = lsvShow.SelectedItems(i).SubItems.Item(11).Text()
    '    'MsgBox(lsvRev.SelectedItems.Count)

    '    For i = 0 To lsvRev.SelectedItems.Count - 1

    '        Lvi = lsvRev.SelectedItems(i)

    '        SelectNo2 = lsvRev.SelectedItems(i).SubItems.Item(4).Text()  'เลขที่ Order  
    '        selCusiD = lsvRev.SelectedItems(i).SubItems.Item(2).Text()   ' รหัสลูกค้า
    '        selCusName = lsvRev.SelectedItems(i).SubItems.Item(3).Text() ' ชื่อลูกค้า
    '        SelectCode2 = lsvRev.SelectedItems(i).SubItems.Item(5).Text() ' ชื่อสินค้า
    '        SelectNum2 = lsvRev.SelectedItems(i).SubItems.Item(7).Text() ' จำนวน
    '        SelectRevNo2 = lsvRev.SelectedItems(i).SubItems.Item(0).Text() ' ใบจอง
    '        SelectTypeP_No2 = lsvRev.SelectedItems(i).SubItems.Item(1).Text() ' ใบเบิก
    '        selectDetail = lsvRev.SelectedItems(i).SubItems.Item(10).Text()


    '        'txtSQL = "Select * "
    '        'txtSQL = txtSQL & "From ArFile "
    '        'txtSQL = txtSQL & "Where Ar_Cus_ID='" & selCusiD & "'"

    '        'subDA = New SqlClient.SqlDataAdapter(txtSQL1, Conn)
    '        'If chkArFile = True Then

    '        '    subDS.Tables("ArFile1").Clear()
    '        '    chkArFile = False

    '        'End If
    '        'subDA.Fill(subDS, "ArFile1")
    '        'chkArFile = True

    '        'With subDS.Tables("ArFile1").Rows(0)

    '        '    CusSaleID = .Item("Ar_Sales")
    '        '    CusSaleName = DBtools.getSaleName(CusSaleID)
    '        '    CusDiscount = .Item("Ar_Discnt")
    '        '    CusLimit = .Item("Ar_CRE_Lim")
    '        '    CusCreTerm = .Item("Ar_Term")

    '        'End With



    '    Next


    'End Sub

   
    Private Sub cmbCancel_Click(sender As Object, e As EventArgs) Handles cmbCancel.Click
        selCusiD = ""  ' รหัสลูกค้า
        selCusName = "" ' ชื่อลูกค้า

        'Lvi = lsvRev.SelectedItems(i)

        SelectNo2 = ""  'เลขที่ Order  
        'selCusiD = lsvRev.SelectedItems(i).SubItems.Item(2).Text()   ' รหัสลูกค้า
        'selCusName = lsvRev.SelectedItems(i).SubItems.Item(3).Text() ' ชื่อลูกค้า
        SelectCode2 = "" ' ชื่อสินค้า
        SelectNum2 = 0 ' จำนวน
        SelectRevNo2 = "" ' ใบจอง
        SelectTypeP_No2 = "" ' ใบเบิก
        selectDetail = ""
        SelectPrice2 = 0
        Me.Hide()

    End Sub

    Private Sub cmbRun_Click(sender As Object, e As EventArgs) Handles cmbRun.Click
        Call getCols()
        Call getDataShow()
    End Sub

    'Private Sub txtDate01_ValueChanged(sender As Object, e As EventArgs) Handles txtDate01.ValueChanged
    '    Call getCols()
    '    Call getDataShow()
    'End Sub

    Private Sub chkCus_CheckedChanged(sender As Object, e As EventArgs) Handles chkCus.CheckedChanged

        If chkCus.Checked = True Then
            selCusiD = ""
        Else
            selCusiD = ""
        End If


    End Sub

    Private Sub lsvRev_DoubleClick(sender As Object, e As EventArgs) Handles lsvRev.DoubleClick

    End Sub

    Private Sub lsvRev_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvRev.SelectedIndexChanged

    End Sub

    Private Sub cmbSelect_Click(sender As Object, e As EventArgs) Handles cmbSelect.Click

    End Sub

    Private Sub chkRev_CheckedChanged(sender As Object, e As EventArgs) Handles chkRev.CheckedChanged
        Call getCols()
        Call getDataShow()
    End Sub

    Private Sub txtDate01_ValueChanged(sender As Object, e As EventArgs) Handles txtDate01.ValueChanged
        Call getCols()
        Call getDataShow()
    End Sub
End Class