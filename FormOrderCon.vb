Public Class FormOrderCon
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
    Friend WithEvents lsvShow As System.Windows.Forms.ListView
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents cboSize As System.Windows.Forms.ComboBox
    Friend WithEvents cboTh As System.Windows.Forms.ComboBox
    Friend WithEvents cboColor As System.Windows.Forms.ComboBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbEnd As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lsvShow = New System.Windows.Forms.ListView()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.cboTh = New System.Windows.Forms.ComboBox()
        Me.cboColor = New System.Windows.Forms.ComboBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lsvShow
        '
        Me.lsvShow.BackColor = System.Drawing.Color.FloralWhite
        Me.lsvShow.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lsvShow.ForeColor = System.Drawing.Color.Blue
        Me.lsvShow.FullRowSelect = True
        Me.lsvShow.GridLines = True
        Me.lsvShow.HideSelection = False
        Me.lsvShow.Location = New System.Drawing.Point(16, 8)
        Me.lsvShow.Name = "lsvShow"
        Me.lsvShow.Size = New System.Drawing.Size(672, 312)
        Me.lsvShow.TabIndex = 2
        Me.lsvShow.UseCompatibleStateImageBehavior = False
        '
        'cboType
        '
        Me.cboType.BackColor = System.Drawing.Color.DodgerBlue
        Me.cboType.ForeColor = System.Drawing.Color.Yellow
        Me.cboType.Location = New System.Drawing.Point(16, 336)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(160, 21)
        Me.cboType.TabIndex = 66
        '
        'cboSize
        '
        Me.cboSize.BackColor = System.Drawing.Color.Yellow
        Me.cboSize.ForeColor = System.Drawing.Color.RoyalBlue
        Me.cboSize.Location = New System.Drawing.Point(432, 336)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(152, 21)
        Me.cboSize.TabIndex = 65
        '
        'cboTh
        '
        Me.cboTh.BackColor = System.Drawing.Color.Yellow
        Me.cboTh.ForeColor = System.Drawing.Color.RoyalBlue
        Me.cboTh.Location = New System.Drawing.Point(344, 336)
        Me.cboTh.Name = "cboTh"
        Me.cboTh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboTh.Size = New System.Drawing.Size(88, 21)
        Me.cboTh.TabIndex = 64
        '
        'cboColor
        '
        Me.cboColor.BackColor = System.Drawing.Color.Yellow
        Me.cboColor.ForeColor = System.Drawing.Color.RoyalBlue
        Me.cboColor.Location = New System.Drawing.Point(176, 336)
        Me.cboColor.Name = "cboColor"
        Me.cboColor.Size = New System.Drawing.Size(168, 21)
        Me.cboColor.TabIndex = 63
        '
        'Label50
        '
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.Blue
        Me.Label50.Location = New System.Drawing.Point(120, 360)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(48, 16)
        Me.Label50.TabIndex = 67
        Me.Label50.Text = "ประเภท"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(296, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "สี"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(384, 360)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "ความหนา"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(536, 360)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "ขนาด"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbEnd
        '
        Me.cmbEnd.BackColor = System.Drawing.Color.DimGray
        Me.cmbEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbEnd.ForeColor = System.Drawing.Color.Yellow
        Me.cmbEnd.Location = New System.Drawing.Point(600, 336)
        Me.cmbEnd.Name = "cmbEnd"
        Me.cmbEnd.Size = New System.Drawing.Size(75, 23)
        Me.cmbEnd.TabIndex = 71
        Me.cmbEnd.Text = "ออก"
        Me.cmbEnd.UseVisualStyleBackColor = False
        '
        'FormOrderCon
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(712, 391)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbEnd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.cboSize)
        Me.Controls.Add(Me.cboTh)
        Me.Controls.Add(Me.cboColor)
        Me.Controls.Add(Me.lsvShow)
        Me.KeyPreview = True
        Me.Name = "FormOrderCon"
        Me.Text = "รายกา Order  [Update 23-09-57]"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim OrderNo As String
    Dim OrderPO As String
    Dim OrderWh As String
    Dim IDTrade As String
    Dim orderDtl As String = ""
    Dim ODate As String
    Dim CusOrder As String
    Dim NamePro As String
    Dim NumPay As Integer
    Dim PricePro As Double
    Dim prDisc As String
    Dim WeightPro As Double
    Dim AnyData() As String
    Dim tmpNum As Boolean
    Dim PayNum As Integer
    Dim OrderNum As Integer
    Dim i As Integer = 0
    Dim lvi As ListViewItem
    Dim chkTB As Boolean = False

    Private Sub FormOrderCon_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    
    'Dim chkODS As Boolean = False
    'Dim chkODS2 As Boolean = False


    Private Sub frmOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Call HeadList()
        'Call Table2()
        'Call comboFactor()
        'จำเป้นต้องเรียงลำดับตามนี้ เพราะว่าจะไม่แสดงข้อมูลOrder



        cboType.Focus()    ' ใช้เคลียร์หรือไม่เคลียร์สำหรับทำให้เป็นสีที่สินค้าที่เลือกแล้ว
        If chkItem = False Then
            Call comboFactor()
            Call HeadList()
            Call Table2()
            chkItem = True
        Else
            Call comboFactor()
            Call HeadList()
            Call Table2()

        End If

        cboType.SelectedItem = Nothing
        cboType.SelectedItem = Nothing
        cboColor.SelectedItem = Nothing
        cboTh.SelectedItem = Nothing
        cboSize.SelectedItem = Nothing



        'cboType.SelectedText = ""
        'cboColor.SelectedText = ""
        'cboTh.SelectedText = ""
        'cboSize.SelectedText = ""
    End Sub
    'Sub Table()
    '    Dim ODS As DataSet = New DataSet
    '    Dim ODA As SqlClient.SqlDataAdapter
    '    ODS.Clear()
    '    txtSql1 = " SELECT  TranDataD.Dtl_type, TranDataD.Dtl_date, TranDataD.Dtl_con_id, TranDataD.Dtl_idcus, TranDataD.Dtl_idtrade, TranDataD.Dtl_num, "
    '    txtSql1 = txtSql1 & " TranDataD.Dtl_price, ARFILE.AR_TYPE AS Expr1, ARFILE.AR_NAME, BaseMast.Stk_Code, BaseMast.Stk_Name_1, BaseMast.Stk_Factor"
    '    txtSql1 = txtSql1 & " FROM    TranDataD LEFT OUTER JOIN  BaseMast ON TranDataD.Dtl_idtrade = BaseMast.Stk_Code LEFT OUTER JOIN"
    '    txtSql1 = txtSql1 & " ARFILE ON TranDataD.Dtl_idcus = ARFILE.AR_CUS_ID"
    '    txtSql1 = txtSql1 & " WHERE     (TranDataD.Dtl_type = 'B') AND (ARFILE.AR_TYPE = N'AR') and trandatad.dtl_idcus='" & PId & "'"
    '    txtSql1 = txtSql1 & " and trandatad.dtl_num-trandatad.dtl_num_2>0 and (TranDataD.Dtl_date = CONVERT(DATETIME, '" & Pdate & "', 102))"
    '    txtSql1 = txtSql1 & " order by trandatad.dtl_date"
    '    ODA = New SqlClient.SqlDataAdapter(txtSql1, Conn)
    '    ODA.Fill(ODS, "OrderData")
    '    If ODS.Tables("OrderData").Rows.Count > 0 Then
    '        'DataGrid1.DataSource = ODS.Tables("OrderData")
    '    End If
    'End Sub

    Sub Table2()
       

        Dim ODS As DataSet = New DataSet
        Dim ODA As SqlClient.SqlDataAdapter
        Dim ODS2 As DataSet = New DataSet
        Dim ODA2 As SqlClient.SqlDataAdapter
        Dim ODS3 As DataSet = New DataSet
        Dim ODA3 As SqlClient.SqlDataAdapter

        'Dim PayOut As Integer
        'Dim test As String
        'If chkODS = True Then
        '    ODS.Tables("OrderData").Clear()
        '    chkODS = False
        'End If
        'test = cboColor.SelectedValue
        ODS.Clear()
        txtSQL1 = " SELECT  TranDataD.Dtl_type, TranDataD.Dtl_date, TranDataD.Dtl_con_id, TranDataD.Dtl_po,"
        txtSQL1 = txtSQL1 & "TranDataD.Dtl_idcus, "
        txtSQL1 = txtSQL1 & "TranDataD.Dtl_idtrade, (TranDataD.Dtl_num-TranDataD.Dtl_num_2) as Remain, "
        txtSQL1 = txtSQL1 & " TranDataD.Dtl_price,TranDataD.Dtl_T_Disc, ARFILE.AR_TYPE AS Expr1, ARFILE.AR_NAME,"
        txtSQL1 = txtSQL1 & " BaseMast.Stk_Code, BaseMast.Stk_Name_1, BaseMast.Stk_Factor,Wh_Id,Wh_Name,TranDataD.Dtl_detail "

        txtSQL1 = txtSQL1 & "FROM  TranDataD LEFT OUTER JOIN  BaseMast "
        txtSQL1 = txtSQL1 & "ON TranDataD.Dtl_idtrade = BaseMast.Stk_Code "
        'txtSQL1 = txtSQL1 & "Left Join StkDetl "
        'txtSQL1 = txtSQL1 & "On (TranDataD.Dtl_idTrade=StkDetl.Dtl_Code and TranDataD.Dtl_Wh=StkDetl.Dtl_Wh )"
        txtSQL1 = txtSQL1 & "LEFT OUTER JOIN ARFILE "
        txtSQL1 = txtSQL1 & "ON TranDataD.Dtl_idcus = ARFILE.AR_CUS_ID "
        txtSQL1 = txtSQL1 & "Left Join WareHouse "
        txtSQL1 = txtSQL1 & "On TrandataD.Dtl_Wh=WareHouse.WH_id "

        txtSQL1 = txtSQL1 & "WHERE (TranDataD.Dtl_type = 'B') "
        txtSQL1 = txtSQL1 & "AND (ARFILE.AR_TYPE ='AR') "
        txtSQL1 = txtSQL1 & "and trandatad.dtl_idcus='" & PId & "'"
        txtSQL1 = txtSQL1 & "and (trandatad.dtl_num-trandatad.dtl_num_2)>0 "

        txtSQL1 = txtSQL1 & "order by trandatad.dtl_con_id"

        'If Trim(cboType.SelectedValue) = "" Then

        'Else
        '    If Len(txtSQL1) > 0 Then
        '        txtSQL1 = txtSQL1 & " And "
        '    End If
        '    txtSQL1 = txtSQL1 & " Type_Code like'%" & cboType.SelectedValue & "%' "

        'End If


        'If Trim(cboSize.SelectedValue) = "" Then
        'Else
        '    If Len(txtSQL1) > 0 Then
        '        txtSQL1 = txtSQL1 & " And "
        '    End If
        '    txtSQL1 = txtSQL1 & " Size_Code like'%" & cboSize.SelectedValue & "%' "
        'End If



        'If Trim(cboTh.SelectedValue) = "" Then
        'Else
        '    If Len(txtSQL1) > 0 Then
        '        txtSQL1 = txtSQL1 & " And "
        '    End If
        '    txtSQL1 = txtSQL1 & " Th_Code like'%" & cboTh.SelectedValue & "%' "
        'End If

        'If Trim(cboColor.SelectedValue) = "" Then
        'Else
        '    If Len(txtSQL1) > 0 Then
        '        txtSQL1 = txtSQL1 & " And "
        '    End If
        '    txtSQL1 = txtSQL1 & " BaseMast.color_Code like'%" & cboColor.SelectedValue & "%' "
        'End If

        'txtSQL1 = txtSQL1 & " order by trandatad.dtl_con_id,dtl_idtrade,remain"

        ODA = New SqlClient.SqlDataAdapter(txtSQL1, Conn)
        ODA.Fill(ODS, "OrderData")
        'chkODS = True

        Dim maxI As Integer
        Dim i As Integer


        maxI = ODS.Tables("OrderData").Rows.Count

        For i = 0 To maxI - 1 'วนลูปตามเลขที่order

            OrderNo = ODS.Tables("OrderData").Rows(i).Item("Dtl_con_id")
            IDTrade = ODS.Tables("OrderData").Rows(i).Item("Dtl_idtrade")
            NamePro = ODS.Tables("OrderData").Rows(i).Item("Stk_Name_1")
            PricePro = ODS.Tables("OrderData").Rows(i).Item("Dtl_price")
            If IsDBNull(ODS.Tables("OrderData").Rows(i).Item("Dtl_T_Disc")) Then
                prDisc = 0 'ODS.Tables("OrderData").Rows(i).Item("Dtl_T_Disc")
            Else
                prDisc = ODS.Tables("OrderData").Rows(i).Item("Dtl_T_Disc")
            End If

            WeightPro = ODS.Tables("OrderData").Rows(i).Item("Stk_Factor")
            ODate = ODS.Tables("OrderData").Rows(i).Item("Dtl_Date")
            OrderNum = ODS.Tables("OrderData").Rows(i).Item("Remain")
            CusOrder = ODS.Tables("OrderData").Rows(i).Item("dtl_idcus")
            OrderPO = ODS.Tables("OrderData").Rows(i).Item("dtl_po")
            orderDtl = ODS.Tables("OrderData").Rows(i).Item("dtl_detail")
            If IsDBNull(ODS.Tables("OrderData").Rows(i).Item("Wh_ID")) Then
                OrderWh = selWH
            Else

                OrderWh = ODS.Tables("OrderData").Rows(i).Item("Wh_ID")
            End If


            'If chkODS2 = True Then
            '    ODS2.Tables("DataStock").Clear()
            '    chkODS2 = False
            'End If
            ODS2.Clear()
            txtSQL = genSQL3(IDTrade)
            ODA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            ODA2.Fill(ODS2, "DataStock")
            'chkODS2 = True

            If ODS2.Tables("DataStock").Rows.Count > 0 Then
                If Not IsDBNull(ODS2.Tables("DataStock").Rows(0).Item("dtl_bal_q1")) Then
                    Stock = ODS2.Tables("DataStock").Rows(0).Item("dtl_bal_q1")
                Else
                    Stock = 0
                End If
            End If

            'If tmpNum = True Then
            '    ODS3.Tables("tmpData01").Clear()
            '    tmpNum = False
            'End If

            ODS3.Clear()
            txtSQL = genSQL2(OrderNo, IDTrade)
            ODA3 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            ODA3.Fill(ODS3, "tmpData01")
            tmpNum = True

            'If ODS3.Tables("tmpData01").Rows.Count > 0 Then
            '    PayOut = ODS3.Tables("tmpData01").Rows(0).Item("Pay")
            'Else
            '    PayOut = 0
            'End If
            'PayNum = OrderNum - PayOut 'จำนวนที่เบิกได้

            If OrderNum > 0 Then
                AnyData = New String() {ODate, OrderNo, OrderPO, IDTrade, NamePro, OrderNum, Stock, PricePro.ToString("#,##0.00"), WeightPro.ToString("#,##0.00"), prDisc, OrderWh, orderDtl}
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

        Next
      


    End Sub

    Function genSQL3(ByVal IDTrade As String) As String

        Dim txtSQLs As String
        '  ตรวจสอบสต๊อก
        txtSQLs = "select  Dtl_code, sum(Dtl_bal_q1)as Dtl_Bal_Q1  "
        txtSQLs = txtSQLs & " from stkdetl  "
        txtSQLs = txtSQLs & "Where  dtl_code='" & IDTrade & "' "
        txtSQLs = txtSQLs & "And (Dtl_Store='110098' ) "
        txtSQLs = txtSQLs & "And Dtl_Wh='" & selWH & "'"
        txtSQLs = txtSQLs & "Group by Dtl_Code "

        Return txtSQLs
    End Function
    Sub HeadList()

        If chkTB = True Then 'เอาไว้เคลียร์ List view แม้งั้นข้อมุลจะเบิ้ล

            lsvShow.Columns.Clear()
            lsvShow.Items.Clear()
            chkTB = False

        End If

        lsvShow.Columns.Add("วันที่", 80, HorizontalAlignment.Right)
        lsvShow.Columns.Add("เลขที่Order ", 80, HorizontalAlignment.Center)
        lsvShow.Columns.Add("เลขที่PO", 95, HorizontalAlignment.Center)
        lsvShow.Columns.Add("รหัสสินค้า", 1, HorizontalAlignment.Left)
        lsvShow.Columns.Add("ชื่อสินค้า", 250, HorizontalAlignment.Left)
        lsvShow.Columns.Add("จำนวน", 70, HorizontalAlignment.Right)
        lsvShow.Columns.Add("Stock", 70, HorizontalAlignment.Right)
        lsvShow.Columns.Add("ราคา", 70, HorizontalAlignment.Right)
        lsvShow.Columns.Add("ส่วนลด", 70, HorizontalAlignment.Right) '========  9
        lsvShow.Columns.Add("น้ำหนัก/แผ่น", 80, HorizontalAlignment.Right)
        lsvShow.Columns.Add("-", 80, HorizontalAlignment.Right)
        lsvShow.Columns.Add("หมายเหตุ", 400, HorizontalAlignment.Left)


        lsvShow.View = View.Details
        lsvShow.GridLines = True


        chkTB = True

    End Sub

    Function genSQL2(ByVal OrderNo As String, ByVal IDTrade As String) As String
        Dim txtSQLs As String
        txtSQLs = "select  Dtl_con_id, Dtl_idtrade, SUM(Dtl_num) AS Pay   "
        txtSQLs = txtSQLs & " from trandatad  "
        txtSQLs = txtSQLs & " Where dtl_type='P' "
        txtSQLs = txtSQLs & "And dtl_con_id=  '" & OrderNo & "' "
        txtSQLs = txtSQLs & "And dtl_idtrade='" & IDTrade & "'"
        txtSQLs = txtSQLs & "And Dtl_Wh='" & selWH & "'"

        txtSQLs = txtSQLs & " GROUP BY Dtl_con_id, Dtl_idtrade"




        Return txtSQLs
    End Function

    Private Sub lsvShow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsvShow.Click
        Dim i As Integer = 0
        Dim lvi As ListViewItem
        Try
            For i = 0 To lsvShow.SelectedItems.Count - 1
                lvi = lsvShow.SelectedItems(i)

                SelectNo2 = lsvShow.SelectedItems(i).SubItems.Item(1).Text()
                SelectPNo2 = lsvShow.SelectedItems(i).SubItems.Item(2).Text()
                SelectCode2 = lsvShow.SelectedItems(i).SubItems.Item(3).Text()
                SelectName2 = lsvShow.SelectedItems(i).SubItems.Item(4).Text()
                SelectNum2 = lsvShow.SelectedItems(i).SubItems.Item(5).Text()
                SelectStock2 = lsvShow.SelectedItems(i).SubItems.Item(6).Text()
                SelectPrice2 = lsvShow.SelectedItems(i).SubItems.Item(7).Text()
                SelectDisc = lsvShow.SelectedItems(i).SubItems.Item(9).Text()
                SelectWeight2 = lsvShow.SelectedItems(i).SubItems.Item(10).Text()
                selectDetail = lsvShow.SelectedItems(i).SubItems.Item(11).Text()

                subDs.Clear()
                'txtSQL = "   SELECT BaseMast.Stk_Code, BaseMast.Type_Code, TypeMast.Type_Name, "
                'txtSQL = txtSQL & "BaseMast.Grp_Code, GrpMast.Grp_Name, BaseMast.Th_Code, ThMast.Th_Name, "
                'txtSQL = txtSQL & "BaseMast.Size_Code, SizeMast.Size_Name, BaseMast.Paper_Code, "
                'txtSQL = txtSQL & "PaperMast.Paper_Name, BaseMast.G_Code, gMast.G_Name,colormast.color_code,"
                'txtSQL = txtSQL & "colormast.color_name "

                'txtSQL = txtSQL & "FROM BaseMast LEFT OUTER JOIN GrpMast "
                'txtSQL = txtSQL & "ON BaseMast.Grp_Code = GrpMast.Grp_Code "
                'txtSQL = txtSQL & "LEFT OUTER JOIN TypeMast "
                'txtSQL = txtSQL & "ON BaseMast.Type_Code = TypeMast.Type_Code "


                'txtSQL = txtSQL & "LEFT OUTER JOIN gMast ON BaseMast.G_Code = gMast.G_Code "
                'txtSQL = txtSQL & "LEFT OUTER JOIN PaperMast "
                'txtSQL = txtSQL & "ON BaseMast.Paper_Code = PaperMast.Paper_Code"
                'txtSQL = txtSQL & " LEFT OUTER JOIN ThMast ON BaseMast.Th_Code = ThMast.Th_Code "
                'txtSQL = txtSQL & "LEFT OUTER JOIN ColorMast "
                'txtSQL = txtSQL & "ON BaseMast.Color_Code = ColorMast.Color_Code "
                'txtSQL = txtSQL & "LEFT OUTER JOIN SizeMast "
                'txtSQL = txtSQL & "ON BaseMast.Size_Code = SizeMast.Size_Code "

                'txtSQL = txtSQL & "where basemast.stk_code='" & SelectCode2 & "'"

                'subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
                'subDa.Fill(subDs, "Detail")

                'CodeT = subDs.Tables("Detail").Rows(0).Item("Type_code")
                'CodeG = subDs.Tables("Detail").Rows(0).Item("Grp_code")
                'CodeColor = subDs.Tables("Detail").Rows(0).Item("color_code")
                'CodeTh = subDs.Tables("Detail").Rows(0).Item("Th_code")
                'CodeSize = subDs.Tables("Detail").Rows(0).Item("Size_code")
                'CodePaper = subDs.Tables("Detail").Rows(0).Item("Paper_code")
                'CodeGrade = subDs.Tables("Detail").Rows(0).Item("G_code")


                lvi.BackColor = System.Drawing.Color.DarkGoldenrod
                lvi.UseItemStyleForSubItems = True
            Next

            'If MsgBox("คุณต้องการแก้ไขข้อมูลนี้หรือไม่?", MsgBoxStyle.YesNo, "ยืนยัน") = MsgBoxResult.Yes Then
            '    chkUp = True

            'Else
            '    chkUp = False

            'End If
            Me.Close()
            'Me.Hide()
        Catch
            Exit Sub
        End Try
    End Sub

    Private Sub cboType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboType.SelectedIndexChanged
        Dim subDs As DataSet = New DataSet
        Dim subDa1 As SqlClient.SqlDataAdapter
        Try
            txtSQL = "Select  Color_Code,(color_code1 + '  '+ Color_StkName) as Color_StkName  From ColorMast "
            'txtSQL = "Select  Color_Code,Color_StkName  From ColorMast "
            txtSQL = txtSQL & "Where Color_Type = '" & cboType.SelectedValue & "' "
            txtSQL = txtSQL & "Order by Color_Code "

            subDa1 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDa1.Fill(subDs, "ColorMast")

            If subDs.Tables("ColorMast").Rows.Count > 0 Then
                With cboColor
                    .DataSource = subDs.Tables("ColorMast")
                    .DisplayMember = "Color_StkName"
                    .ValueMember = "Color_Code"
                    .Text = ""
                End With

            End If
            'cboColor.SelectedItem = Nothing
        Catch ex As Exception

        End Try
      
    End Sub
    Sub comboFactor()
        Dim da As SqlClient.SqlDataAdapter
        Dim ds As DataSet = New DataSet

        txtSQL = "Select  Type_Code,Type_Name,Type_Stk_Name  From TypeMast "
        txtSQL = txtSQL & "Order by Type_Code "

        da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        da.Fill(ds, "TypeMast")

        If ds.Tables("TypeMast").Rows.Count > 0 Then
            With cboType
                .DataSource = ds.Tables("TypeMast")
                .DisplayMember = "Type_Name"
                .ValueMember = "Type_Code"
                '.Text = ""
                .SelectedIndex = Nothing
            End With
        End If
        'scboType.SelectedItem = Nothing



        txtSQL = "Select  Color_Code,(color_code1 + '-'+ Color_StkName) as Color_StkName  From ColorMast "
        'txtSQL = "Select  Color_Code,Color_StkName  From ColorMast "
        'txtSQL = txtSQL & " where color_type = '" & cboType.SelectedValue & "'"
        txtSQL = txtSQL & "Order by Color_Code "
        da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        da.Fill(ds, "ColorMast")

        If ds.Tables("ColorMast").Rows.Count > 0 Then
            With cboColor
                .DataSource = ds.Tables("ColorMast")
                .DisplayMember = "Color_StkName"
                .ValueMember = "Color_Code"
                .Text = ""
            End With
        End If
        cboColor.SelectedItem = Nothing


        txtSQL = "Select  Th_Name,Th_Code,Th_Th  From ThMast "
        txtSQL = txtSQL & "Order by Th_Name "

        da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        da.Fill(ds, "ThMast")

        If ds.Tables("ThMast").Rows.Count > 0 Then
            With cboTh
                .DataSource = ds.Tables("ThMast")
                .DisplayMember = "Th_Th"
                .ValueMember = "Th_Code"
                .Text = ""
            End With
        End If
        cboTh.SelectedItem = Nothing


        txtSQL = "Select  Size_Name_2,Size_Code  From SizeMast "
        txtSQL = txtSQL & "Order by Size_Name_2  "

        da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        da.Fill(ds, "SizeMast")

        If ds.Tables("SizeMast").Rows.Count > 0 Then
            With cboSize
                .DataSource = ds.Tables("SizeMast")
                .DisplayMember = "Size_Name_2"
                .ValueMember = "Size_Code"
                .Text = ""
            End With
        End If
        cboSize.SelectedItem = Nothing


    End Sub

    Private Sub cboColor_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboColor.SelectionChangeCommitted
        Call HeadList()
        Call Table2()
    End Sub

    Private Sub cboSize_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSize.SelectionChangeCommitted
        Call HeadList()
        Call Table2()
    End Sub

    Private Sub cboType_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboType.SelectionChangeCommitted
        Call HeadList()
        Call Table2()
    End Sub

    Private Sub cboTh_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTh.SelectionChangeCommitted
        Call HeadList()
        Call Table2()
    End Sub

    Private Sub cboType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboType.KeyDown
        If e.KeyCode = 13 Then
            Call HeadList()
            Call Table2()
            cboColor.Focus()
        End If
    End Sub

    Private Sub cboColor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboColor.KeyDown
        If e.KeyCode = 13 Then
            Call HeadList()
            Call Table2()
            cboTh.Focus()
        End If
    End Sub

    Private Sub cboTh_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboTh.KeyDown
        If e.KeyCode = 13 Then
            Call HeadList()
            Call Table2()
            cboSize.Focus()
        End If
    End Sub

    Private Sub cboSize_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSize.KeyDown
        If e.KeyCode = 13 Then
            Call HeadList()
            Call Table2()
            cboType.Focus()
        End If
    End Sub

    Private Sub cmbEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEnd.Click
        'cboColor.Items.Clear()
        'cboTh.Refresh()
        'cboSize.Refresh()
        Me.Close()
    End Sub

   
    Private Sub lsvShow_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvShow.SelectedIndexChanged

    End Sub
End Class
