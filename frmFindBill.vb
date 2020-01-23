Public Class frmFindBill
    Inherits System.Windows.Forms.Form

    Dim searchDS As DataSet = New DataSet
    Dim searchDA As SqlClient.SqlDataAdapter
    Dim chkBill As Boolean = False

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
    Friend WithEvents lsvShowBill As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lsvShowBill = New System.Windows.Forms.ListView
        Me.SuspendLayout()
        '
        'lsvShowBill
        '
        Me.lsvShowBill.BackColor = System.Drawing.Color.BurlyWood
        Me.lsvShowBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lsvShowBill.ForeColor = System.Drawing.Color.Blue
        Me.lsvShowBill.FullRowSelect = True
        Me.lsvShowBill.GridLines = True
        Me.lsvShowBill.Location = New System.Drawing.Point(8, 8)
        Me.lsvShowBill.Name = "lsvShowBill"
        Me.lsvShowBill.Size = New System.Drawing.Size(696, 368)
        Me.lsvShowBill.TabIndex = 3
        '
        'frmFindBill
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(720, 390)
        Me.Controls.Add(Me.lsvShowBill)
        Me.Name = "frmFindBill"
        Me.Text = "ค้นหาบิล"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Sub HeadList()

        lsvShowBill.Columns.Add("วันทีฺ่", 80, HorizontalAlignment.Right) '1
        lsvShowBill.Columns.Add("เลขที่Bill", 80, HorizontalAlignment.Center) '2
        lsvShowBill.Columns.Add("เลขที่Order", 95, HorizontalAlignment.Center) '3
        lsvShowBill.Columns.Add("ชื่อลูกค้า", 1, HorizontalAlignment.Left) '3
        lsvShowBill.Columns.Add("ชื่อสินค้า", 250, HorizontalAlignment.Left) '4
        lsvShowBill.Columns.Add("จำนวน", 70, HorizontalAlignment.Right) '5
        lsvShowBill.Columns.Add("ราคา/แผ่น", 70, HorizontalAlignment.Right) '6
        lsvShowBill.Columns.Add("ราคารวม", 70, HorizontalAlignment.Right) '7
        lsvShowBill.View = View.Details
        lsvShowBill.GridLines = True

    End Sub

    Private Sub frmFindBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call HeadList()

    End Sub
    Sub Search()
        If chkBill = True Then
            searchDS.Tables("BillData").Clear()
        End If
        txtSQL1 = " SELECT     TranDataD.Dtl_type, TranDataD.Dtl_date, TranDataD.Dtl_no, TranDataD.Dtl_con_id, ArFile.AR_NAME, BaseMast.Stk_Name_1, TranDataD.Dtl_num, "
        txtSQL1 = txtSQL1 & " TranDataD.Dtl_price(, TranDataD.Dtl_sum)"
        txtSQL1 = txtSQL1 & " FROM         TranDataD LEFT OUTER JOIN"
        txtSQL1 = txtSQL1 & " ArFile ON TranDataD.Dtl_idcus = ArFile.AR_CUS_ID LEFT OUTER JOIN"
        txtSQL1 = txtSQL1 & " BaseMast ON TranDataD.Dtl_idtrade = BaseMast.Stk_Code"
        txtSQL1 = txtSQL1 & " WHERE     (TranDataD.Dtl_type = 'S') "


        searchDA = New SqlClient.SqlDataAdapter(txtSQL1, Conn)
        searchDA.Fill(searchDS, "BillData")
        Dim maxI As Integer
        Dim i As Integer


        maxI = searchDS.Tables("BillData").Rows.Count

        For i = 0 To maxI - 1 'วนลูปตามเลขที่order
            OrderNo = searchDS.Tables("BillData").Rows(i).Item("Dtl_con_id")
            IDTrade = searchDS.Tables("BillData").Rows(i).Item("Dtl_idtrade")
            NamePro = searchDS.Tables("BillData").Rows(i).Item("Stk_Name_1")
            PricePro = searchDS.Tables("BillData").Rows(i).Item("Dtl_price")
            WeightPro = searchDS.Tables("BillData").Rows(i).Item("Stk_Factor")
            ODate = searchDS.Tables("BillData").Rows(i).Item("Dtl_Date")
            OrderNum = searchDS.Tables("BillData").Rows(i).Item("Remain")
            CusOrder = ODS.Tables("BillData").Rows(i).Item("dtl_idcus")
            OrderPO = ODS.Tables("BillData").Rows(i).Item("dtl_po")

            ODS2.Clear()
            txtSQL = genSQL3(IDTrade)
            ODA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            ODA2.Fill(ODS2, "DataStock")


            If ODS2.Tables("DataStock").Rows.Count > 0 Then
                If Not IsDBNull(ODS2.Tables("DataStock").Rows(0).Item("dtl_bal_q1")) Then
                    Stock = ODS2.Tables("DataStock").Rows(0).Item("dtl_bal_q1")
                Else
                    Stock = 0
                End If
            End If

            If tmpNum = True Then
                ODS3.Tables("tmpData01").Clear()
                tmpNum = False
            End If

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
                AnyData = New String() {ODate, OrderNo, OrderPO, IDTrade, NamePro, OrderNum, Stock, PricePro.ToString("#,##0.00"), WeightPro.ToString("#,##0.00")}
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
End Class
