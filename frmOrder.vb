Public Class frmOrder
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lsvShow As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lsvShow = New System.Windows.Forms.ListView()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lsvShow)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 328)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lsvShow
        '
        Me.lsvShow.BackColor = System.Drawing.Color.FloralWhite
        Me.lsvShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lsvShow.ForeColor = System.Drawing.Color.Blue
        Me.lsvShow.FullRowSelect = True
        Me.lsvShow.GridLines = True
        Me.lsvShow.HideSelection = False
        Me.lsvShow.Location = New System.Drawing.Point(8, 8)
        Me.lsvShow.Name = "lsvShow"
        Me.lsvShow.Size = New System.Drawing.Size(664, 312)
        Me.lsvShow.TabIndex = 1
        Me.lsvShow.UseCompatibleStateImageBehavior = False
        '
        'frmOrder
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(712, 373)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "frmOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายการจากใบเบิก"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim OrderNo As String
    Dim PNo As String
    Dim IDTrade As String
    Dim ODate As String
    Dim NamePro As String
    Dim NumPay As Integer
    Dim PricePro As Double
    Dim prDisc As String
    Dim WeightPro As Double
    Dim AnyData() As String
    Dim tmpNum As Boolean 'ใช้ของ Stock
    Dim tmpPayNum As Boolean 'ใช้ของPaynum
    Dim PayNum As Integer
    Dim OrderNum As Integer
    Dim i As Integer = 0
    Dim lvi As ListViewItem
    Dim chkTB As Boolean
    Dim PayOut As Integer
    Dim IDCus As String


    Private Sub frmOrder_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()

        End If
    End Sub

    Private Sub frmOrder_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

    End Sub


    Private Sub frmOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call HeadDataGrid1()
        'Call HeadDataGrid2()
        Call HeadList()
        'Call Table()
        Call Table2()

    End Sub

    Sub Table()
        Dim ODS As DataSet = New DataSet()
        Dim ODA As SqlClient.SqlDataAdapter
        ODS.Clear()
        txtSQL1 = " SELECT  TranDataD.Dtl_type, TranDataD.Dtl_date, TranDataD.Dtl_con_id, TranDataD.Dtl_idcus,"
        txtSQL1 = txtSQL1 & "BaseMast.Stk_Code, BaseMast.Stk_Name_1, BaseMast.Stk_Factor,"
        txtSQL1 = txtSQL1 & "TranDataD.Dtl_idtrade, TranDataD.Dtl_num,TranDataD.Dtl_price,  "
        txtSQL1 = txtSQL1 & " ARFILE.AR_TYPE AS Expr1, ARFILE.AR_NAME "

        txtSQL1 = txtSQL1 & "FROM    TranDataD LEFT OUTER JOIN  BaseMast "
        txtSQL1 = txtSQL1 & "ON TranDataD.Dtl_idtrade = BaseMast.Stk_Code LEFT OUTER JOIN "
        txtSQL1 = txtSQL1 & "ARFILE ON TranDataD.Dtl_idcus = ARFILE.AR_CUS_ID "
        txtSQL1 = txtSQL1 & "Left Join wareHouse "
        txtSQL1 = txtSQL1 & "ON trandatad.Dtl_Wh=wareHouse.WH_ID "

        txtSQL1 = txtSQL1 & "WHERE (TranDataD.Dtl_type = 'P') "
        txtSQL1 = txtSQL1 & "AND (ARFILE.AR_TYPE ='AR') "
        txtSQL1 = txtSQL1 & "and trandatad.dtl_idcus='" & PId & "' "
        'txtSQL1 = txtSQL1 & "And TranDataD.dtl_Wh='" & selWH & "' "

        'txtSql1 = txtSql1 & " and trandatad.dtl_num-trandatad.dtl_num_2>0 and (TranDataD.Dtl_date = CONVERT(DATETIME, '" & Pdate & "', 102))"
        txtSql1 = txtSql1 & " order by trandatad.dtl_date"
        ODA = New SqlClient.SqlDataAdapter(txtSql1, Conn)
        ODA.Fill(ODS, "OrderData")
        If ODS.Tables("OrderData").Rows.Count > 0 Then
            'DataGrid1.DataSource = ODS.Tables("OrderData")
        End If
    End Sub

    Sub TableNew()  ' kritpon  แก้ไขให้แสดง Order 

        Dim DS As DataSet = New DataSet()
        'Dim DA As SqlClient.SqlDataAdapter

        Dim DS2 As DataSet = New DataSet()
        Dim DS3 As DataSet = New DataSet()
        Dim DS4 As DataSet = New DataSet()
        Dim DS5 As DataSet = New DataSet()
        ' Dim DA2 As SqlClient.SqlDataAdapter
        Dim strArCode As String = ""
        Dim strArName As String = ""
        'Dim i2, i3 As Date
        Dim strDateS As String = ""
        Dim strDateE As String = ""
        Dim strStkName As String = ""
        Dim strStkBalQ1n As String = ""
        Dim strStkPenQ1n As String = ""
        Dim strStkPenQ2w As String = ""
        Dim strSalesName As String = ""
        'Dim strCondition As String = ""

        Dim dblPrByKg As Double = 0
        Dim dblPrCost As Double = 0
        Dim dblRev As Double = 0

        Dim strDocPO As String = ""
        Dim strDocNo As String = ""
        Dim strStkCode As String = ""

        'Dim dblDif As Double
        Dim strDetail As String = ""
        Dim strCondition As String = ""
        Dim dblPrice As Double = 0
        Dim dblProFit As Double = 0
        'Dim date01 As Date

        'Dim i1, i17 As String

        Dim dblPrAVG As Double = 0
        'Dim strOrderQty1 As String = ""
        'Dim dblOrderQty2 As Double = 0

        'Dim anydata() As String
        'Dim lvi As ListViewItem
        Dim i As Integer = 0
        'Dim pro_stock As String
        'Dim pro_id As String
        'Dim whCode As String
        Dim vsStock As Double = 0
        'Dim numplan As Integer
        'Dim numpost As Integer
        'Dim numrev As Integer

        'date01 = CDate(Format(txtDate01.Value, "yyyy/MM/dd"))

        'If chkSales.Checked = True Then

        '    If lbSalesID.Text = "" Then
        '        MsgBox("ยังไม่ได้เลือกข้อมูล Sales ที่ถูกต้อง ตรวจสอบอีกครั้ง ! ", MsgBoxStyle.Critical)
        '        Exit Sub
        '    End If

        'End If

        'pro_stock = txtStkName.Text
        'pro_id = product_id


        'If wh01.Checked = True Then
        '    rbchk = "01"
        'End If


        'If wh01.Checked = True Then
        '    whCode = "01"
        'Else
        '    whCode = "12"
        'End If

        'ListEdit.Items.Clear()

        'txtsum.Text = CDbl(txtstock1.Text) - numpost
        'lbRev.Text = 0
        'If txtsum.Text < 0 Then

        '    If MsgBox("จำนวนค้างจองอยู่ " & numpost & " ต้องการให้เบิกส่งได้หรือไม่", MsgBoxStyle.YesNo, "แจ้งเตือน") = MsgBoxResult.Yes Then

        '    End If

        '    txtsum.Text = "0"

        'End If

        'DS.Clear()


        ''ปรับใช้งาน 31-03-58
        'txtSQL1 = "Select BaseMast.Stk_Code,BaseMast.Stk_Name_1,"
        'txtSQL1 = txtSQL1 & "TB_TypeB.Dtl_Date,TB_TypeB.Dtl_no,"
        'txtSQL1 = txtSQL1 & "TB_TypeB.Dtl_dateS, TB_TypeB.Dtl_dateF,"
        'txtSQL1 = txtSQL1 & "(TB_TypeB.Dtl_po + ' ' + TB_TypeB.Dtl_Condition) Dtl_po,TB_TypeB.Dtl_Condition, "
        ''txtSQL1 = txtSQL1 & "( TB_TypeB.Dtl_po ) Dtl_po, "
        'txtSQL1 = txtSQL1 & "TB_TypeB.Dtl_idcus,ArFile.AR_NAME,salesman.SL_NAME,TB_TypeB.Dtl_Detail,TB_TypeB.Dtl_Condition,"

        'txtSQL1 = txtSQL1 & "(Stkdetl.DTL_BAL_Q1) AS Dtl_bal_q1_n,"
        ''txtSQL1 = txtSQL1 & "(Stkdetl.DTL_BAL_Q1 * BaseMast.Stk_Factor2)AS Dtl_Bal_Q2_w,"

        'txtSQL1 = txtSQL1 & "(TB_TypeB.Dtl_num - TB_TypeB.Dtl_num_2) AS sumQty1, "
        'txtSQL1 = txtSQL1 & "((TB_TypeB.Dtl_num - TB_TypeB.Dtl_num_2)* TB_TypeB.Dtl_price) AS AmtOrder, "
        'txtSQL1 = txtSQL1 & "(TB_TypeB.Dtl_num - TB_TypeB.Dtl_num_2)* BaseMast.Stk_Factor2 AS sumQty2,"
        ''TB_TypeB.Dtl_price()
        'txtSQL1 = txtSQL1 & "((TB_TypeT.Dtl_num_3)) AS rev ,"
        'txtSQL1 = txtSQL1 & "((TB_TypeT.Dtl_num_3) * TB_TypeB.Dtl_price) AS AmtRev ,"
        'txtSQL1 = txtSQL1 & "((TB_TypeT.Dtl_Num_3-TB_TypeT.Dtl_num_4))as dif ,  "
        'txtSQL1 = txtSQL1 & "((TB_TypeT.Dtl_Num_3-TB_TypeT.Dtl_num_4) *  TB_TypeB.Dtl_price)as AmtDif ,  "


        'txtSQL1 = txtSQL1 & "TB_TypeB.dtl_Num,TB_TypeB.Dtl_Num_2,"
        'txtSQL1 = txtSQL1 & "TB_TypeT.dtl_Num_3,TB_TypeT.Dtl_Num_4,"
        'txtSQL1 = txtSQL1 & "(TB_TypeB.Dtl_price / BaseMast.Stk_Factor2) AS prAVG,"
        'txtSQL1 = txtSQL1 & "TB_TypeB.Dtl_price  "

        'txtSQL1 = txtSQL1 & "From "
        'txtSQL1 = txtSQL1 & "( "
        ''txtSQL1 = txtSQL1 & "Select (dtl_PO + dtl_condition)as dtl_po ,* "
        'txtSQL1 = txtSQL1 & "Select * "
        'txtSQL1 = txtSQL1 & "From TranDataD "

        'txtSQL1 = txtSQL1 & "Where dtl_type='B' "
        'If chkArSel.Checked = True Then
        '    If txtCusID.Text = "" Then
        '        'txtSQL1 = txtSQL1 & "And    dtl_idcus='" & txtCusID.Text & "' "
        '    Else
        '        txtSQL1 = txtSQL1 & "And    dtl_idcus='" & txtCusID.Text & "' "
        '    End If
        'End If


        'txtSQL1 = txtSQL1 & ") TB_TypeB "
        'txtSQL1 = txtSQL1 & " Left Join "
        'txtSQL1 = txtSQL1 & "( "
        'txtSQL1 = txtSQL1 & "Select dtl_idCus,Dtl_Con_id,Dtl_idTrade,"
        'txtSQL1 = txtSQL1 & "Sum(Dtl_Num_3)Dtl_Num_3,Sum(Dtl_Num_4)dtl_Num_4 "
        'txtSQL1 = txtSQL1 & "From TranDataD "

        'txtSQL1 = txtSQL1 & "Where dtl_type='T' "
        'If chkArSel.Checked = True Then
        '    If txtCusID.Text = "" Then
        '        'txtSQL1 = txtSQL1 & "And    dtl_idcus='" & txtCusID.Text & "' "
        '    Else
        '        txtSQL1 = txtSQL1 & "And    dtl_idcus='" & txtCusID.Text & "' "
        '    End If
        'End If

        'If txtDate01.Checked = True Then

        '    txtSQL1 = txtSQL1 & "And Dtl_DueDate='" & Format(DateAdd(DateInterval.Year, -543, txtDate01.Value), "MM/dd/yyyy") & "' "

        'Else


        'End If

        'txtSQL1 = txtSQL1 & "Group by  dtl_idCus,dtl_con_id,Dtl_idTrade  "
        'txtSQL1 = txtSQL1 & ") TB_TypeT "
        'txtSQL1 = txtSQL1 & "On (TB_TypeB.Dtl_Con_ID=TB_TypeT.Dtl_Con_ID "
        'txtSQL1 = txtSQL1 & "And TB_TypeB.Dtl_idTrade=TB_TypeT.Dtl_idTrade "
        'txtSQL1 = txtSQL1 & ") "

        'txtSQL1 = txtSQL1 & "left join BaseMast "
        'txtSQL1 = txtSQL1 & "On TB_TypeB.dtl_idTrade=BaseMast.Stk_Code "

        'txtSQL1 = txtSQL1 & "left Join StkDetl "
        'txtSQL1 = txtSQL1 & "On BaseMast.Stk_Code=StkDetl.Dtl_Code "

        'txtSQL1 = txtSQL1 & "left Join ArFile 	 "
        'txtSQL1 = txtSQL1 & "ON ArFile.AR_CUS_ID = TB_TypeB.Dtl_idcus "

        'txtSQL1 = txtSQL1 & "LEFT JOIN SalesMan "
        'txtSQL1 = txtSQL1 & "ON ArFile.AR_SALES = SalesMan.SL_ID "

        'txtSQL1 = txtSQL1 & ""
        ''txtSQL = txtSQL & "Order by dtl_type "

        ''txtSQL1 = "  SELECT  BaseMast.Stk_Code, BaseMast.Stk_Name_1,"
        ''txtSQL1 = txtSQL1 & "SUM(Stkdetl.DTL_BAL_Q1) AS Dtl_bal_q1_n,"
        ''txtSQL1 = txtSQL1 & "SUM(Stkdetl.DTL_VS_Q1) AS Dtl_VS_Q1,"
        ''txtSQL1 = txtSQL1 & "SUM(Stkdetl.DTL_BAL_Q1 * BaseMast.Stk_Factor2)AS Dtl_Bal_Q2_w,"

        ''txtSQL1 = txtSQL1 & "TranDataD.Dtl_Date,TranDataD.Dtl_no,"
        ''txtSQL1 = txtSQL1 & "TranDataD.Dtl_dateS, TranDataD.Dtl_dateF,TranDataD.Dtl_po, "
        ''txtSQL1 = txtSQL1 & "TranDataD.Dtl_idcus,ArFile.AR_NAME,salesman.SL_NAME,TranDataD.Dtl_Detail,"

        ''txtSQL1 = txtSQL1 & "(TranDataD.Dtl_num - TranDataD.Dtl_num_2) AS sumQty1, "
        ''txtSQL1 = txtSQL1 & "(TranDataD.Dtl_num - TranDataD.Dtl_num_2)* BaseMast.Stk_Factor2 AS sumQty2,"

        ''txtSQL1 = txtSQL1 & "SUM(TranDataD.Dtl_price / BaseMast.Stk_Factor2) AS prAVG,"
        ''txtSQL1 = txtSQL1 & "TranDataD.Dtl_price,"
        ''===   24-03-58  kritpon
        ''txtSQL1 = txtSQL1 & "sum((TranDataD.Dtl_num_3-TranDataD.Dtl_num_4)) AS rev ,"

        ''txtSQL1 = txtSQL1 & "sum((TRanDataD.Dtl_Num_3-TranDataD.Dtl_num_4))as dif   "


        '' txtSQL1 = txtSQL1 & " TranDataD.Dtl_po, SUM(TranDataD.Dtl_price / BaseMast.Stk_Factor2) AS price, salesman.SL_NAME,TranDataD.Dtl_price , TranDataD.Dtl_num_3, TranDataD.Dtl_dateS  " 'แก้ไข 19022556

        ''txtSQL1 = txtSQL1 & "FROM TranDataD "
        ''txtSQL1 = txtSQL1 & "left OUTER JOIN BaseMast "
        ''txtSQL1 = txtSQL1 & "ON BaseMast.Stk_Code = TranDataD.Dtl_idtrade "

        ''txtSQL1 = txtSQL1 & "left Join ArFile 	 "
        ''txtSQL1 = txtSQL1 & "ON ArFile.AR_CUS_ID = TranDataD.Dtl_idcus "

        ''txtSQL1 = txtSQL1 & "LEFT OUTER JOIN SalesMan "
        ''txtSQL1 = txtSQL1 & "ON ArFile.AR_SALES = SalesMan.SL_ID "

        ''txtSQL1 = txtSQL1 & "RIGHT OUTER JOIN  Stkdetl "
        ''txtSQL1 = txtSQL1 & "ON BaseMast.Stk_Code = Stkdetl.DTL_CODE  "

        ''============================== where  ========================================

        ''txtSQL1 = txtSQL1 & "WHERE (NOT (Stkdetl.DTL_BAL_Q1 IS NULL)) "
        'txtSQL1 = txtSQL1 & "Where "
        ''txtSQL1 = txtSQL1 & "And (TranDataD.Dtl_type = 'B') "
        'txtSQL1 = txtSQL1 & "(NOT (Stkdetl.DTL_STORE = '110603')) "
        'txtSQL1 = txtSQL1 & "AND (NOT (Stkdetl.DTL_STORE = '112054')) "

        'txtSQL1 = txtSQL1 & "AND (NOT (BaseMast.Type_Code = '04')) " ' แก้ไข 19022556
        'txtSQL1 = txtSQL1 & "AND (NOT (BaseMast.Type_Code = '11')) "
        'txtSQL1 = txtSQL1 & "AND (NOT (BaseMast.Type_Code = '13')) "

        ''txtSQL1 = txtSQL1 & "AND (TranDataD.Dtl_price <> 0) "
        'txtSQL1 = txtSQL1 & "AND (TB_TypeB.Dtl_num - TB_TypeB.Dtl_num_2 > 0) "   ' เช็คว่ามี Order ค้างหรือไม่ ถ้าเป็น 0 ไม่แสดง
        ''txtSQL1 = txtSQL1 & "AND (TranDataD.Dtl_idcus LIKE '%') "

        'txtSQL1 = txtSQL1 & "AND (ArFile.AR_TYPE = 'AR') "
        'If chkZone.Checked = True Then
        '    txtSQL1 = txtSQL1 & "And Ar_Map_Code='" & cboGZone.SelectedValue & "' "
        'End If

        'txtSQL1 = txtSQL1 & "And Stkdetl.Dtl_Wh='" & whCode & "' "

        'If chkStkMast.Checked = False Then

        'Else

        '    If txtStkCode.Text = "" Then
        '    Else
        '        txtSQL1 = txtSQL1 & "AND (BaseMast.Stk_Code = '" & pro_id & "' )   "
        '    End If
        '    'MsgBox(getStkName(pro_id))
        'End If

        'If chkArSel.Checked = True Then
        '    If Trim(txtCusName.Text) = "" Then

        '        'txtSQL1 = txtSQL1 & "And Dtl_idCus like ''  "
        '    Else

        '        txtSQL1 = txtSQL1 & "And TB_TypeB.Dtl_idCus='" & txtCusID.Text & "'  "
        '    End If


        'End If

        'If chkSales.Checked = True Then

        '    'If cboSales.SelectedValue = "SL90" Then
        '    If cboSales.Text = "*" Then
        '        'txtSQL1 = txtSQL1 & "And (ArFile.Ar_Sales='" & cboSales.SelectedValue & "') "
        '    Else

        '        txtSQL1 = txtSQL1 & "And (ArFile.Ar_Sales='" & cboSales.SelectedValue & "') "
        '    End If

        'End If
        'If optShowAll.Checked = True Then
        '    txtSQL1 = txtSQL1 & "  "
        'ElseIf optShowPenRev.Checked = True Then
        '    txtSQL1 = txtSQL1 & "And (TB_TypeT.Dtl_Num_3-TB_TypeT.Dtl_num_4) > 0 "
        'ElseIf optShowREV.Checked = True Then
        '    txtSQL1 = txtSQL1 & "And (Tb_TypeT.Dtl_Num_3 > 0 ) "
        'End If




        ''txtSQL1 = txtSQL1 & "Group By BaseMast.Stk_Name_1, BaseMast.Stk_Code, TranDataD.Dtl_num,"
        ''txtSQL1 = txtSQL1 & "TranDataD.Dtl_num_2, BaseMast.Stk_Factor2, TranDataD.Dtl_no,"
        ''txtSQL1 = txtSQL1 & "TranDataD.Dtl_idcus,TranDataD.Dtl_Detail, ArFile.AR_NAME,"
        ''txtSQL1 = txtSQL1 & " TranDataD.Dtl_date, TranDataD.Dtl_dateS,TranDataD.Dtl_dateF, TranDataD.Dtl_po,"
        ''txtSQL1 = txtSQL1 & "salesman.SL_NAME, TranDataD.Dtl_price,"
        ''txtSQL1 = txtSQL1 & "TranDataD.Dtl_num_3,TranDataD.Dtl_num_4,TranDataD.Dtl_dateS   "

        ''===============  จัดเรียงข้อมูล  =======================================
        ''.Items.Add("ตาม-วันที่ส่งเสร็จ")
        ''.Items.Add("ตาม-เลขที่ Order")
        ''.Items.Add("ตาม-ชื่อลูกค้า")
        ''.Items.Add("ตาม-จำนวนสต๊อกคงเหลือ")

        'If cboOrderBy.Text = "ตาม-วันที่ส่งเสร็จ" Then

        '    txtSQL1 = txtSQL1 & " ORDER BY Dtl_dateF DESC,Ar_Name "

        'ElseIf cboOrderBy.Text = "ตาม-วันที่เริ่มส่ง" Then

        '    txtSQL1 = txtSQL1 & " ORDER BY Dtl_dateS DESC,Ar_Name "

        'ElseIf cboOrderBy.Text = "ตาม-ชื่อลูกค้า" Then

        '    txtSQL1 = txtSQL1 & " ORDER BY Ar_Name ASC "

        'ElseIf cboOrderBy.Text = "ตาม-เลขที่ Order" Then

        '    txtSQL1 = txtSQL1 & " ORDER BY tb_TypeB.Dtl_NO DESC,Ar_Name "

        'ElseIf cboOrderBy.Text = "ตาม-จำนวนสต๊อกคงเหลือ" Then

        '    txtSQL1 = txtSQL1 & " ORDER BY Dtl_bal_q1_n DESC "

        'ElseIf cboOrderBy.Text = "ตาม-วันที่รับ Order" Then

        '    txtSQL1 = txtSQL1 & " ORDER BY tb_TypeB.Dtl_Date ASC,Ar_Name "

        'Else
        '    txtSQL1 = txtSQL1 & " ORDER BY tb_TypeB.Dtl_dateS DESC,Ar_Name "
        'End If




        ''===============  จัดเรียงข้อมูล  =======================================

        'DA = New SqlClient.SqlDataAdapter(txtSQL1, Conn)
        'lbSumOrder.Text = 0
        'lbTotalWeight.Text = 0
        'lbSumAmt.Text = 0
        'lbPrKg.Text = 0

        'DA.Fill(DS, "PayDetail")
        'lbPenRev.Text = 0
        'lbRev.Text = 0
        'lbSumOrder.Text = 0
        'lbSumAmt.Text = 0
        'lbTotalWeight.Text = 0
        'lbPrKg.Text = 0



        'If DS.Tables("PayDetail").Rows.Count > 0 Then

        '    For i = 0 To DS.Tables("PayDetail").Rows.Count - 1
        '        With DS.Tables("PayDetail").Rows(i)
        '            i1 = i + 1

        '            'i2 = .Item("dtl_dateS")
        '            'strDateS = .Item("dtl_dateS")

        '            If IsDate(.Item("dtl_dateS")) Then
        '                strDateS = Format(DateAdd(DateInterval.Year, 543, CDate(.Item("dtl_dateS"))), "dd/MM/yy")

        '            Else
        '                If IsDBNull(.Item("dtl_dateS")) Then
        '                    strDateS = ""
        '                Else
        '                    strDateS = .Item("dtl_dateS")
        '                End If

        '            End If

        '            If IsDate(.Item("dtl_dateF")) Then
        '                strDateE = Format(DateAdd(DateInterval.Year, 543, CDate(.Item("dtl_dateF"))), "dd/MM/yy")
        '            Else

        '                If IsDBNull(.Item("dtl_dateF")) Then
        '                    strDateS = ""
        '                Else
        '                    strDateE = .Item("dtl_dateF")
        '                End If


        '            End If

        '            If IsDBNull(.Item("dtl_po")) Then
        '                strDocPO = ""
        '            Else
        '                strDocPO = .Item("dtl_po")
        '            End If

        '            strDocNo = .Item("dtl_no")

        '            'i5 = .Item("dtl_no")
        '            strArCode = .Item("Dtl_idcus")

        '            strArName = .Item("AR_NAME")
        '            strStkPenQ1n = .Item("sumqty1")

        '            lbSumOrder.Text = Format(CDbl(lbSumOrder.Text) + CDbl(strStkPenQ1n), "###,###.##")
        '            'i8 = .Item("sumqty1")
        '            lbTotalWeight.Text = Format(CDbl(lbTotalWeight.Text) + .Item("sumQty2"), "###,###.##")
        '            'i9 = Format(.Item("sumqty2"), "###,###.##")
        '            strStkName = .Item("stk_name_1")
        '            'i10 = .Item("stk_name_1")
        '            strStkBalQ1n = .Item("dtl_Bal_Q1_n")
        '            txtStkName.Text = strStkName

        '            'If IsDBNull(.Item("Dtl_VS_Q1")) Then
        '            '    vsStock = 0
        '            'Else
        '            '    vsStock = .Item("Dtl_VS_Q1")
        '            '    End If


        '            strSalesName = .Item("SL_NAME")
        '            strStkCode = .Item("Stk_Code")

        '            dblPrice = Format(.Item("Dtl_price"), "#,##0.00")


        '            'i14 = .Item("Dtl_price")

        '            If IsDBNull(.Item("sumqty1")) = True Then

        '                ' lbSumAmt.Text += Format((.Item("Dtl_price") * CDbl(strStkPenQ1n)), "#,###.00")
        '            Else

        '                lbSumAmt.Text = Format(lbSumAmt.Text + ((CDbl(.Item("Dtl_price")) * CDbl(strStkPenQ1n))), "#,###.00")

        '            End If



        '            If IsDBNull(.Item("rev")) Then
        '                dblRev = 0

        '            Else
        '                dblRev = .Item("rev")
        '            End If

        '            'i15 = CDbl(i8) - CDbl(i16)
        '            If IsDBNull(.Item("dif")) Then
        '                dblDif = 0
        '            Else
        '                dblDif = .Item("dif")
        '            End If

        '            If chkProFit.Checked = True Then

        '                If optShowAll.Checked = True Then

        '                    dblPrCost = DBtools.getCostByStk(strStkCode, date01, 0) * CDbl(strStkPenQ1n)

        '                ElseIf optShowPenRev.Checked = True Then
        '                    dblPrCost = DBtools.getCostByStk(strStkCode, date01, 0) * dblDif

        '                ElseIf optShowREV.Checked = True Then

        '                    dblPrCost = DBtools.getCostByStk(strStkCode, date01, 0) * dblRev
        '                End If

        '            Else


        '                If optShowAll.Checked = True Then

        '                    dblPrCost = CDbl(.Item("AmtOrder"))

        '                ElseIf optShowPenRev.Checked = True Then
        '                    dblPrCost = CDbl(.Item("AmtDif"))

        '                ElseIf optShowREV.Checked = True Then

        '                    dblPrCost = CDbl(.Item("AmtRev"))
        '                End If

        '                'dblPrCost = Format((CDbl(.Item("Dtl_price")) * CDbl(strStkPenQ1n)) / CDbl(strStkPenQ1n), "#,###.00")
        '                'dblPrByKg = dbTools.getCostByStk(strStkCode, date01, 0) ' .Item("prAVG")

        '            End If




        '            'lbPrKg.Text = Format(CDbl(lbSumAmt.Text) / CDbl(lbTotalWeight.Text), "#,###.00")
        '            'If dbTools.getCostType(strStkCode) = 0 Then
        '            'dblPrByKg = dbTools.getCostByStk(strStkCode, date01, 0) ' .Item("prAVG")
        '            '    'Dtl_Cost_PR = CDbl(.Rows(iRow).Item("CS_Cost"))
        '            '    dblProFit = dblPrice - dbTools.getCostByStk(strStkCode, date01, 0) 'CDbl(.Rows(iRow).Item("CS_Cost"))
        '            '    dblprofic = dblPrice *
        '            '    Dtl_Cost_Amt = Dtl_Cost_PR * Q_Qty2
        '            '    Dtl_ProFit = CStr(Format(Dtl_Amt - Dtl_Cost_Amt, "#,##00.00"))
        '            '    Dtl_Pr_Div_Q2 = CDbl(Dtl_Amt / Q_Qty2)

        '            'ElseIf dbTools.getCostType(strStkCode) = 1 Then
        '            'dblPrByKg = dbTools.getCostByStk(strStkCode, date01, 0) '.Item("prAVG")

        '            '    Dtl_Cost_PR = dbTools.getCostByStk(stkCode, date01, 0) 'CDbl(.Rows(iRow).Item("CS_Cost"))
        '            '    Dtl_Cost_Amt = Dtl_Cost_PR * num
        '            '    Dtl_ProFit = CStr(Format(Dtl_Amt - Dtl_Cost_Amt, "#,##00.00"))
        '            '    Dtl_Pr_Div_Q2 = CDbl(Dtl_Amt / num)
        '            'Else
        '            '.Item("prAVG")
        '            'End If


        '            'i16 = .Item("dif")
        '            i17 = .Item("Dtl_date")

        '            If IsDBNull(.Item("Dtl_Detail")) Then
        '                'i18 = ""
        '                strDetail = ""
        '            Else
        '                'i18 = .Item("Dtl_Detail")
        '                strDetail = .Item("Dtl_Detail")

        '            End If
        '            If IsDBNull(.Item("Dtl_Condition")) Then
        '                'i18 = ""
        '                strCondition = ""
        '            Else
        '                'i18 = .Item("Dtl_Detail")
        '                strCondition = .Item("Dtl_Condition")

        '            End If


        '            ' If CDbl(i15) > 0 Then


        '            anydata = New String() {i1, CStr(strDateS), CStr(strDateE), strDocPO, strDocNo, strArCode, strArName, strStkName, strStkBalQ1n, strStkPenQ1n, dblRev, dblDif, Format(dblPrCost, "#,##0.00"), strSalesName, strStkCode, dblPrice.ToString("#,##0.00"), i17, strDetail, strCondition}
        '            'anydata = New String() {i1, CStr(strDateS), CStr(strDateE), i4, i5, i6, strStkName, strArName, strStkBalQ1n, vsStock, strStkPenQ1n, i15, i16, i11, i12, i13, i14, i17, i18}
        '            'anydata = New String() {i1, CStr(strDateS), CStr(strDateE), i4, i5, i6, strStkName, strArName, strStkBalQ1n, vsStock, strStkPenQ1n, i15, i16, i11, i12, i13, i14, i17, i18}
        '            'anydata = New String() {i1, CStr(strDateS), CStr(strDateE), i4, i5, i6, strStkName, strArName, strStkBalQ1n, vsStock, strStkPenQ1n, i15, i16, i11, i12, i13, i14, i17, i18}
        '            lvi = New ListViewItem(anydata)

        '            If optShowREV.Checked = True And dblRev > 0 Then

        '                addItem2List(lvi, dblRev, dblDif)


        '            ElseIf optShowPenRev.Checked = True And dblDif > 0 Then

        '                addItem2List(lvi, dblRev, dblDif)

        '            ElseIf optShowAll.Checked = True Then

        '                addItem2List(lvi, dblRev, dblDif)
        '                'Else

        '                'addItem2List(lvi, dblRev, dblDif)

        '            End If




        '            'lvi.BackColor = System.Drawing.Color.LightSteelBlue
        '            'lvi.ForeColor = System.Drawing.Color.Black
        '            'lvi.UseItemStyleForSubItems = True

        '            'ListEdit.Items.Add(lvi)
        '            'lbRev.Text = Format(CDbl(lbRev.Text) + dblRev, "#,##0")
        '            'lbPenRev.Text = Format(CDbl(lbPenRev.Text) + dblDif, "#,##0")



        '        End With

        '    Next

        '    lbPrKg.Text = Format(CDbl(lbSumAmt.Text) / CDbl(lbTotalWeight.Text), "#,###.00")
        '    '  รวมยอด
        '    'Call GrandTotal()

        'End If

        'Dno = ""
    End Sub

    Sub Table2()
        
        Dim ODS As DataSet = New DataSet
        Dim ODA As SqlClient.SqlDataAdapter


        ODS.Clear()
        txtSQL1 = " SELECT  TranDataD.Dtl_type, TranDataD.Dtl_date, TranDataD.Dtl_con_id,TranDataD.Dtl_no,"
        txtSQL1 = txtSQL1 & "TranDataD.Dtl_idcus,"
        txtSQL1 = txtSQL1 & " TranDataD.Dtl_idtrade, TranDataD.Dtl_num, "
        txtSQL1 = txtSQL1 & "TranDataD.Dtl_price,TranDataD.Dtl_T_Disc, TranDataD.Dtl_same_code, ARFILE.AR_TYPE AS Expr1,"
        txtSQL1 = txtSQL1 & "ARFILE.AR_NAME, BaseMast.Stk_Code, BaseMast.Stk_Name_1, BaseMast.Stk_Factor "

        txtSQL1 = txtSQL1 & "FROM  TranDataD "
        txtSQL1 = txtSQL1 & "LEFT OUTER JOIN  BaseMast "
        txtSQL1 = txtSQL1 & "ON TranDataD.Dtl_idtrade = BaseMast.Stk_Code "
        txtSQL1 = txtSQL1 & "LEFT OUTER JOIN ARFILE "
        txtSQL1 = txtSQL1 & "ON TranDataD.Dtl_idcus = ARFILE.AR_CUS_ID "
        txtSQL1 = txtSQL1 & "Left Join wareHouse "
        txtSQL1 = txtSQL1 & "ON trandatad.Dtl_Wh=wareHouse.WH_ID "

        txtSQL1 = txtSQL1 & "WHERE (TranDataD.Dtl_type = 'P') "
        txtSQL1 = txtSQL1 & "AND (ARFILE.AR_TYPE ='AR' and trandatad.dtl_idcus='" & PId & "') "

        '(((Month(  Now) & "/" & DateAndTime.Day( Now) & "/" & Year( Now) - 543)))
        txtSQL1 = txtSQL1 & "And trandatad.dtl_date= '" & (((Month(Now) & "/" & DateAndTime.Day(Now) & "/" & Year(Now) - 543))) & "' "
        txtSQL1 = txtSQL1 & "And TranDataD.dtl_Wh='" & selWH & "' "

        'txtSql1 = txtSql1 & " and trandatad.dtl_num-trandatad.dtl_num_2>0 "
        txtSql1 = txtSql1 & " order by trandatad.dtl_date"


        ODA = New SqlClient.SqlDataAdapter(txtSql1, Conn)
        ODA.Fill(ODS, "OrderData")
        Dim maxI As Integer
        Dim i As Integer


        maxI = ODS.Tables("OrderData").Rows.Count

        For i = 0 To maxI - 1 'วนลูปตามเลขที่order

            OrderNo = ODS.Tables("OrderData").Rows(i).Item("Dtl_con_id")
            PNo = ODS.Tables("OrderData").Rows(i).Item("Dtl_no")
            IDTrade = ODS.Tables("OrderData").Rows(i).Item("Dtl_idtrade")
            NamePro = ODS.Tables("OrderData").Rows(i).Item("Stk_Name_1")
            PricePro = ODS.Tables("OrderData").Rows(i).Item("Dtl_price")
            prDisc = ODS.Tables("OrderData").Rows(i).Item("Dtl_T_Disc")
            WeightPro = ODS.Tables("OrderData").Rows(i).Item("Stk_Factor")
            ODate = ODS.Tables("OrderData").Rows(i).Item("Dtl_Date")
            OrderNum = ODS.Tables("OrderData").Rows(i).Item("dtl_num")
            IDCus = ODS.Tables("OrderData").Rows(i).Item("dtl_idcus")

            If tmpNum = True Then
                ODS.Tables("OrderData").Clear()
                tmpNum = False
            End If

            Stock = DBtools.getStock(IDTrade, IDCus, selWH)
            tmpNum = True

            'txtSQL = genSQL2(IDTrade)
            'ODA.SelectCommand.CommandText = txtSQL
            'ODA.Fill(ODS, "DataStock")
            'If ODS.Tables("DataStock").Rows.Count > 0 Then
            'ODS.Tables("DataStock").Rows(0).Item("dtl_bal_q1")
            'Else
            'Stock = 0
            'End If

            If tmpNum = True Then
                ODS.Tables("DataStock").Clear()
                tmpNum = False
            End If

            txtSQL = genSQL3(PNo, IDTrade, IDCus)
            ODA.SelectCommand.CommandText = txtSQL
            ODA.Fill(ODS, "tmpData01")
            tmpNum = True

            If ODS.Tables("tmpData01").Rows.Count > 0 Then
                PayOut = ODS.Tables("tmpData01").Rows(0).Item("Pay")
            Else
                PayOut = 0
            End If
            PayNum = OrderNum - PayOut 'จำนวนที่เบิกได้
            'PayNum = OrderNum - PayOut 'จำนวนที่เบิกได้

            If tmpNum = True Then
                ODS.Tables("tmpData01").Clear()
                tmpNum = False
            End If

            If PayNum > 0 Then
                AnyData = New String() {ODate, OrderNo, PNo, IDTrade, NamePro, PayNum, Stock, PricePro.ToString("#,##0.00"), prDisc, WeightPro.ToString("#,##0.00")}
                lvi = New ListViewItem(AnyData)
                lsvShow.Items.Add(lvi)
                If i <> 0 Then
                    If ((i / 2) - (i \ 2)) = 0 Then

                        lvi.BackColor = System.Drawing.Color.Khaki
                        lvi.UseItemStyleForSubItems = True
                    Else

                        lvi.BackColor = System.Drawing.Color.Gold
                        lvi.UseItemStyleForSubItems = True
                    End If
                End If
            Else

            End If
            'PayNum = 0
            'OrderNum = 0
            'PayOut = 0

        Next



    End Sub

    Sub HeadList()

        If chkTB = True Then

            lsvShow.Columns.Clear()
            lsvShow.Items.Clear()
            chkTB = False

        End If

        lsvShow.Columns.Add("วันที่", 60, HorizontalAlignment.Right) '0
        lsvShow.Columns.Add("เลขที่Order ", 80, HorizontalAlignment.Center) '1
        lsvShow.Columns.Add("เลขที่ใบเบิก ", 80, HorizontalAlignment.Center) '2
        lsvShow.Columns.Add("รหัสสินค้า", 1, HorizontalAlignment.Left) '3
        lsvShow.Columns.Add("ชื่อสินค้า", 250, HorizontalAlignment.Left) '4
        lsvShow.Columns.Add("จำนวนที่เบิก", 70, HorizontalAlignment.Right) '5 
        lsvShow.Columns.Add("Stock", 70, HorizontalAlignment.Right) '6
        lsvShow.Columns.Add("ราคา", 70, HorizontalAlignment.Right) '7
        lsvShow.Columns.Add("ส่วนลด", 70, HorizontalAlignment.Right) '7
        lsvShow.Columns.Add("น้ำหนัก/แผ่น", 80, HorizontalAlignment.Right) '8



        lsvShow.View = View.Details
        lsvShow.GridLines = True


        chkTB = True

    End Sub

    Function genSQL3(ByVal PNo As String, ByVal IDTrade As String, ByVal IDcus As String) As String
        Dim txtSQLs As String
        txtSQLs = "select  Dtl_con_id, Dtl_same_code,dtl_idcus, SUM(Dtl_num) AS Pay   "
        txtSQLs = txtSQLs & " from trandatad  "
        txtSQLs = txtSQLs & " where dtl_type='s' and dtl_po=  '" & PNo & "' and dtl_same_code='" & IDTrade & "' and dtl_idcus='" & IDcus & "'"
        txtSQLs = txtSQLs & " GROUP BY Dtl_con_id, Dtl_same_code, Dtl_idcus"



        Return txtSQLs
    End Function

    Function genSQL2(ByVal IDTrade As String) As String
        Dim txtSQLs As String

        txtSQLs = "select  Dtl_bal_q1, Dtl_code  "
        txtSQLs = txtSQLs & " from stkdetl  "
        txtSQLs = txtSQLs & " where  dtl_code='" & IDTrade & "' and dtl_store='" & IDCus & "' "
        txtSQLs = txtSQLs & "And dtl_wh='" & selWH & "'"




        Return txtSQLs
    End Function
    'Private Sub HeadDataGrid1()
    '    Dim DGrid As DataGridTableStyle = New DataGridTableStyle
    '    Dim G1 As New DataGridTextBoxColumn
    '    Dim G2 As New DataGridTextBoxColumn
    '    Dim G3 As New DataGridTextBoxColumn
    '    Dim G4 As New DataGridTextBoxColumn
    '    Dim G5 As New DataGridTextBoxColumn
    '    Dim G6 As New DataGridTextBoxColumn
    '    Dim G7 As New DataGridTextBoxColumn

    '    With DGrid
    '        .AlternatingBackColor = Color.AliceBlue
    '        .BackColor = Color.AliceBlue
    '        .ForeColor = Color.SteelBlue
    '        .MappingName = "OrderData"
    '    End With
    '    With G1
    '        .HeaderText = "วันที่"
    '        .MappingName = "dtl_date"
    '        .Width = 60
    '        .ReadOnly = True
    '    End With
    '    With G2
    '        .HeaderText = "Order No."
    '        .MappingName = "dtl_con_id"
    '        .Width = 60
    '        .ReadOnly = True
    '    End With
    '    With G3
    '        .HeaderText = "รหัสสินค้า"
    '        .MappingName = "dtl_idtrade"
    '        .Width = 100
    '        .ReadOnly = True
    '    End With
    '    With G4
    '        .HeaderText = "ชื่อสินค้า"
    '        .MappingName = "stk_name_1"
    '        .Width = 210
    '        .ReadOnly = True
    '    End With
    '    With G5
    '        .HeaderText = "จำนวนจอง"
    '        .MappingName = "Remain"
    '        .Width = 50
    '        .ReadOnly = True
    '    End With
    '    With G6
    '        .HeaderText = "ราคา"
    '        .MappingName = "dtl_price"
    '        .Width = 60
    '        .ReadOnly = True
    '    End With
    '    With G7
    '        .HeaderText = "น้ำหนัก"
    '        .MappingName = "stk_factor"
    '        .Width = 60
    '    End With
    '    DGrid.GridColumnStyles.Add(G1)
    '    DGrid.GridColumnStyles.Add(G2)
    '    DGrid.GridColumnStyles.Add(G3)
    '    DGrid.GridColumnStyles.Add(G4)
    '    DGrid.GridColumnStyles.Add(G5)
    '    DGrid.GridColumnStyles.Add(G6)
    '    DGrid.GridColumnStyles.Add(G7)
    '    With DataGrid1
    '        .TableStyles.Clear()
    '        .CaptionText = "รายละเอียด ORDER CONFIRM"
    '        .TableStyles.Add(DGrid)
    '        .FlatMode = True
    '    End With
    'End Sub


    'Private Sub HeadDataGrid2()
    '    Dim DGrid As DataGridTableStyle = New DataGridTableStyle
    '    Dim G1 As New DataGridTextBoxColumn
    '    Dim G2 As New DataGridTextBoxColumn
    '    Dim G3 As New DataGridTextBoxColumn
    '    Dim G4 As New DataGridTextBoxColumn
    '    Dim G5 As New DataGridTextBoxColumn
    '    Dim G6 As New DataGridTextBoxColumn
    '    Dim G7 As New DataGridTextBoxColumn

    '    With DGrid
    '        .AlternatingBackColor = Color.AliceBlue
    '        .BackColor = Color.AliceBlue
    '        .ForeColor = Color.SteelBlue
    '        .MappingName = "OrderData"
    '    End With
    '    With G1
    '        .HeaderText = "วันที่"
    '        .MappingName = "dtl_date"
    '        .Width = 60
    '        .ReadOnly = True
    '    End With
    '    With G2
    '        .HeaderText = "Order No."
    '        .MappingName = "dtl_con_id"
    '        .Width = 60
    '        .ReadOnly = True
    '    End With
    '    With G3
    '        .HeaderText = "รหัสสินค้า"
    '        .MappingName = "dtl_idtrade"
    '        .Width = 100
    '        .ReadOnly = True
    '    End With
    '    With G4
    '        .HeaderText = "ชื่อสินค้า"
    '        .MappingName = "stk_name_1"
    '        .Width = 210
    '        .ReadOnly = True
    '    End With
    '    With G5
    '        .HeaderText = "จำนวนจอง"
    '        .MappingName = "Remain"
    '        .Width = 50
    '        .ReadOnly = True
    '    End With
    '    With G6
    '        .HeaderText = "ราคา"
    '        .MappingName = "dtl_price"
    '        .Width = 60
    '        .ReadOnly = True
    '    End With
    '    With G7
    '        .HeaderText = "น้ำหนัก"
    '        .MappingName = "stk_factor"
    '        .Width = 60
    '    End With
    '    DGrid.GridColumnStyles.Add(G1)
    '    DGrid.GridColumnStyles.Add(G2)
    '    DGrid.GridColumnStyles.Add(G3)
    '    DGrid.GridColumnStyles.Add(G4)
    '    DGrid.GridColumnStyles.Add(G5)
    '    DGrid.GridColumnStyles.Add(G6)
    '    DGrid.GridColumnStyles.Add(G7)
    '    With DataGrid2
    '        .TableStyles.Clear()
    '        .CaptionText = "รายละเอียดในแผน ORDER"
    '        .TableStyles.Add(DGrid)
    '        .FlatMode = True
    '    End With
    'End Sub
    'Private Sub DataGrid1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    Dim UserClick As Integer = 0

    '    UserClick = DataGrid1.CurrentRowIndex
    '    If UserClick >= 0 Then
    '        SelectNo = DataGrid1.Item(UserClick, 1)
    '        SelectCode = DataGrid1.Item(UserClick, 2)
    '        SelectName = DataGrid1.Item(UserClick, 3)
    '        SelectNum = DataGrid1.Item(UserClick, 4)
    '        SelectPrice = DataGrid1.Item(UserClick, 5)
    '        SelectWeight = DataGrid1.Item(UserClick, 6)
    '    End If
    '    Me.Close()
    'End Sub



    'Private Sub DataGrid2_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    Dim UserClick As Integer = 0

    '    UserClick = DataGrid2.CurrentRowIndex
    '    If UserClick >= 0 Then
    '        SelectNo = DataGrid2.Item(UserClick, 1)
    '        SelectCode = DataGrid2.Item(UserClick, 2)
    '        SelectName = DataGrid2.Item(UserClick, 3)
    '        SelectNum = DataGrid2.Item(UserClick, 4)
    '        SelectPrice = DataGrid2.Item(UserClick, 5)
    '        SelectWeight = DataGrid2.Item(UserClick, 6)
    '    End If
    '    Me.Close()
    'End Sub

    Private Sub lsvShow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsvShow.Click
        Dim i As Integer = 0
        Dim lvi As ListViewItem
        Try
            For i = 0 To lsvShow.SelectedItems.Count - 1
                lvi = lsvShow.SelectedItems(i)
                '  เลือก  Order ที่จะนำไปทำบิลขาย

                SelectNo = lsvShow.SelectedItems(i).SubItems.Item(1).Text()
                SelectPNo = lsvShow.SelectedItems(i).SubItems.Item(2).Text()
                SelectCode = lsvShow.SelectedItems(i).SubItems.Item(3).Text()
                SelectName = lsvShow.SelectedItems(i).SubItems.Item(4).Text()
                SelectNum = lsvShow.SelectedItems(i).SubItems.Item(5).Text()
                SelectPrice = lsvShow.SelectedItems(i).SubItems.Item(7).Text()
                SelectWeight = lsvShow.SelectedItems(i).SubItems.Item(8).Text()
                SelectStock = lsvShow.SelectedItems(i).SubItems.Item(6).Text()


                subDs.Clear()

                txtSQL = "SELECT BaseMast.Stk_Code, BaseMast.Type_Code, TypeMast.Type_Name, "
                txtSQL = txtSQL & "BaseMast.Grp_Code, GrpMast.Grp_Name, BaseMast.Th_Code, ThMast.Th_Name, "
                txtSQL = txtSQL & "BaseMast.Size_Code, SizeMast.Size_Name, BaseMast.Paper_Code, "
                txtSQL = txtSQL & "PaperMast.Paper_Name, BaseMast.G_Code, gMast.G_Name,colormast.color_code,colormast.color_name"

                txtSQL = txtSQL & "     FROM         BaseMast LEFT OUTER JOIN"
                txtSQL = txtSQL & "     GrpMast ON BaseMast.Grp_Code = GrpMast.Grp_Code LEFT OUTER JOIN"
                txtSQL = txtSQL & "     TypeMast ON BaseMast.Type_Code = TypeMast.Type_Code LEFT OUTER JOIN"
                txtSQL = txtSQL & "     gMast ON BaseMast.G_Code = gMast.G_Code LEFT OUTER JOIN"
                txtSQL = txtSQL & "     PaperMast ON BaseMast.Paper_Code = PaperMast.Paper_Code LEFT OUTER JOIN"
                txtSQL = txtSQL & "     ThMast ON BaseMast.Th_Code = ThMast.Th_Code LEFT OUTER JOIN"
                txtSQL = txtSQL & "     ColorMast ON BaseMast.Color_Code = ColorMast.Color_Code LEFT OUTER JOIN"
                txtSQL = txtSQL & "     SizeMast ON BaseMast.Size_Code = SizeMast.Size_Code"
                txtSQL = txtSQL & ""

                txtSQL = txtSQL & "   where basemast.stk_code='" & SelectCode & "'"

                subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
                subDa.Fill(subDs, "Detail")

                CodeT = subDs.Tables("Detail").Rows(0).Item("Type_code")
                CodeG = subDs.Tables("Detail").Rows(0).Item("Grp_code")
                CodeColor = subDs.Tables("Detail").Rows(0).Item("color_code")
                CodeTh = subDs.Tables("Detail").Rows(0).Item("Th_code")
                CodeSize = subDs.Tables("Detail").Rows(0).Item("Size_code")
                CodePaper = subDs.Tables("Detail").Rows(0).Item("Paper_code")
                CodeGrade = subDs.Tables("Detail").Rows(0).Item("G_code")

            Next

            'If MsgBox("คุณต้องการแก้ไขข้อมูลนี้หรือไม่?", MsgBoxStyle.YesNo, "ยืนยัน") = MsgBoxResult.Yes Then
            '    chkUp = True
            'Else
            '    chkUp = False

            'End If
            Me.Close()
        Catch
            Exit Sub
        End Try
    End Sub

    Private Sub lsvShow_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvShow.SelectedIndexChanged

    End Sub
End Class
