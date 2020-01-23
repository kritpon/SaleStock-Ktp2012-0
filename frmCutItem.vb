Public Class frmCutItem
    Inherits System.Windows.Forms.Form
    Dim OD As Date
    Dim OrNo As String
    Dim PO As String
    Dim ID As String
    Dim IDName As String
    Dim ORnum As Double
    Dim ORPrice As Double
    Dim ORFac As Double
    Dim Orcus As String
    Dim lvi As ListViewItem
    Dim AnyData() As String
    Dim i As Integer
    Dim chkTB As Boolean
    Dim CutOrNo As String
    Dim CutOrCus As String
    Dim CutID As String
    Dim CutOrNum As Double

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
    Friend WithEvents cmbCut As System.Windows.Forms.Button
    Friend WithEvents exitFrm As System.Windows.Forms.Button
    Friend WithEvents ListOrder As System.Windows.Forms.ListView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents cboSize As System.Windows.Forms.ComboBox
    Friend WithEvents cboTh As System.Windows.Forms.ComboBox
    Friend WithEvents cboColor As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListOrder = New System.Windows.Forms.ListView()
        Me.cmbCut = New System.Windows.Forms.Button()
        Me.exitFrm = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.cboTh = New System.Windows.Forms.ComboBox()
        Me.cboColor = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListOrder)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1312, 591)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ListOrder
        '
        Me.ListOrder.FullRowSelect = True
        Me.ListOrder.GridLines = True
        Me.ListOrder.Location = New System.Drawing.Point(16, 30)
        Me.ListOrder.Name = "ListOrder"
        Me.ListOrder.Size = New System.Drawing.Size(1280, 546)
        Me.ListOrder.TabIndex = 0
        Me.ListOrder.UseCompatibleStateImageBehavior = False
        '
        'cmbCut
        '
        Me.cmbCut.BackColor = System.Drawing.Color.SlateGray
        Me.cmbCut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbCut.ForeColor = System.Drawing.Color.Yellow
        Me.cmbCut.Location = New System.Drawing.Point(832, 30)
        Me.cmbCut.Name = "cmbCut"
        Me.cmbCut.Size = New System.Drawing.Size(176, 73)
        Me.cmbCut.TabIndex = 10
        Me.cmbCut.Text = "ตัดItemในOrder"
        Me.cmbCut.UseVisualStyleBackColor = False
        '
        'exitFrm
        '
        Me.exitFrm.BackColor = System.Drawing.Color.SlateGray
        Me.exitFrm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exitFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitFrm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.exitFrm.ForeColor = System.Drawing.Color.Yellow
        Me.exitFrm.Location = New System.Drawing.Point(1088, 30)
        Me.exitFrm.Name = "exitFrm"
        Me.exitFrm.Size = New System.Drawing.Size(176, 73)
        Me.exitFrm.TabIndex = 11
        Me.exitFrm.Text = "จบการทำงาน"
        Me.exitFrm.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.Controls.Add(Me.cmbCut)
        Me.GroupBox2.Controls.Add(Me.exitFrm)
        Me.GroupBox2.Location = New System.Drawing.Point(32, 679)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1296, 119)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'cboType
        '
        Me.cboType.BackColor = System.Drawing.Color.DodgerBlue
        Me.cboType.ForeColor = System.Drawing.Color.Yellow
        Me.cboType.Location = New System.Drawing.Point(32, 635)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(320, 33)
        Me.cboType.TabIndex = 70
        '
        'cboSize
        '
        Me.cboSize.BackColor = System.Drawing.Color.Yellow
        Me.cboSize.ForeColor = System.Drawing.Color.RoyalBlue
        Me.cboSize.Location = New System.Drawing.Point(1008, 635)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(304, 33)
        Me.cboSize.TabIndex = 69
        '
        'cboTh
        '
        Me.cboTh.BackColor = System.Drawing.Color.Yellow
        Me.cboTh.ForeColor = System.Drawing.Color.RoyalBlue
        Me.cboTh.Location = New System.Drawing.Point(784, 635)
        Me.cboTh.Name = "cboTh"
        Me.cboTh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboTh.Size = New System.Drawing.Size(176, 33)
        Me.cboTh.TabIndex = 68
        '
        'cboColor
        '
        Me.cboColor.BackColor = System.Drawing.Color.Yellow
        Me.cboColor.ForeColor = System.Drawing.Color.RoyalBlue
        Me.cboColor.Location = New System.Drawing.Point(384, 635)
        Me.cboColor.Name = "cboColor"
        Me.cboColor.Size = New System.Drawing.Size(336, 33)
        Me.cboColor.TabIndex = 67
        '
        'frmCutItem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(10, 24)
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1354, 826)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.cboSize)
        Me.Controls.Add(Me.cboTh)
        Me.Controls.Add(Me.cboColor)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCutItem"
        Me.Text = "เลือกItem ที่ต้องการตัด"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub exitFrm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitFrm.Click
        Me.Close()
    End Sub

    Private Sub frmCutItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call comboFactor()
        Call HeadList()
        Call searchOrder()
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
                .Text = ""
            End With
        End If
        cboType.SelectedItem = Nothing



        txtSQL = "Select  Color_Code,(color_code1 + '  '+ Color_StkName) as Color_StkName  From ColorMast "
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
    Private Sub cboType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboType.SelectedIndexChanged
        Dim subDs As DataSet = New DataSet
        Dim subDa1 As SqlClient.SqlDataAdapter
        Try
            txtSQL = "Select  Color_Code,(color_code1 + '  '+ Color_StkName) as Color_StkName  From ColorMast "
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
            cboColor.SelectedItem = Nothing
        Catch ex As Exception

        End Try
    End Sub
    Sub HeadList()
        If chkTB = True Then

            ListOrder.Columns.Clear()
            ListOrder.Items.Clear()
            chkTB = False

        End If

        ListOrder.Columns.Add("วันที่", 80, HorizontalAlignment.Right)
        ListOrder.Columns.Add("เลขที่Order ", 80, HorizontalAlignment.Center) '1
        ListOrder.Columns.Add("เลขที่PO", 95, HorizontalAlignment.Center) '2
        ListOrder.Columns.Add("รหัสสินค้า", 1, HorizontalAlignment.Left) '3
        ListOrder.Columns.Add("ชื่อสินค้า", 250, HorizontalAlignment.Left) '4
        ListOrder.Columns.Add("จำนวน", 70, HorizontalAlignment.Right) '5
        'ListOrder.Columns.Add("Stock", 70, HorizontalAlignment.Right)
        ListOrder.Columns.Add("ราคา", 70, HorizontalAlignment.Right)
        ListOrder.Columns.Add("น้ำหนัก/แผ่น", 80, HorizontalAlignment.Right)



        ListOrder.View = View.Details
        ListOrder.GridLines = True

        chkTB = True


    End Sub
    Sub searchOrder()


        Dim ODS As DataSet = New DataSet
        Dim ODA As SqlClient.SqlDataAdapter
        Dim ODS2 As DataSet = New DataSet
        'Dim ODA2 As SqlClient.SqlDataAdapter
        Dim ODS3 As DataSet = New DataSet
        'Dim ODA3 As SqlClient.SqlDataAdapter
        'Dim PayOut As Integer

        ODS.Clear()
        txtSQL1 = " SELECT  TranDataD.Dtl_type, TranDataD.Dtl_date, TranDataD.Dtl_con_id, TranDataD.Dtl_po,TranDataD.Dtl_idcus, TranDataD.Dtl_idtrade, (TranDataD.Dtl_num-TranDataD.Dtl_num_2) as Remain, "
        txtSQL1 = txtSQL1 & " TranDataD.Dtl_price, ARFILE.AR_TYPE AS Expr1, ARFILE.AR_NAME, BaseMast.Stk_Code, BaseMast.Stk_Name_1, BaseMast.Stk_Factor"
        txtSQL1 = txtSQL1 & " FROM    TranDataD LEFT OUTER JOIN  BaseMast ON TranDataD.Dtl_idtrade = BaseMast.Stk_Code LEFT OUTER JOIN"
        txtSQL1 = txtSQL1 & " ARFILE ON TranDataD.Dtl_idcus = ARFILE.AR_CUS_ID"
        txtSQL1 = txtSQL1 & " WHERE     (TranDataD.Dtl_type = 'B') "
        txtSQL1 = txtSQL1 & "AND (ARFILE.AR_TYPE = N'AR') "
        txtSQL1 = txtSQL1 & "and trandatad.dtl_idcus='" & PId & "'"
        txtSQL1 = txtSQL1 & " and trandatad.dtl_num-trandatad.dtl_num_2>0 "

        If Trim(cboType.SelectedValue) = "" Then

        Else
            If Len(txtSQL1) > 0 Then
                txtSQL1 = txtSQL1 & " And "
            End If
            txtSQL1 = txtSQL1 & " Type_Code like'%" & cboType.SelectedValue & "%' "

        End If


        If Trim(cboSize.SelectedValue) = "" Then
        Else
            If Len(txtSQL1) > 0 Then
                txtSQL1 = txtSQL1 & " And "
            End If
            txtSQL1 = txtSQL1 & " Size_Code like'%" & cboSize.SelectedValue & "%' "
        End If



        If Trim(cboTh.SelectedValue) = "" Then
        Else
            If Len(txtSQL1) > 0 Then
                txtSQL1 = txtSQL1 & " And "
            End If
            txtSQL1 = txtSQL1 & " Th_Code like'%" & cboTh.SelectedValue & "%' "
        End If

        If Trim(cboColor.SelectedValue) = "" Then
        Else
            If Len(txtSQL1) > 0 Then
                txtSQL1 = txtSQL1 & " And "
            End If
            txtSQL1 = txtSQL1 & " BaseMast.color_Code like'%" & cboColor.SelectedValue & "%' "
        End If

        txtSQL1 = txtSQL1 & " order by trandatad.dtl_con_id,dtl_idtrade,remain"

        ODA = New SqlClient.SqlDataAdapter(txtSQL1, Conn)
        ODA.Fill(ODS, "OrderData")


        Dim maxI As Integer
        'Dim i As Integer


        maxI = ODS.Tables("OrderData").Rows.Count

        For i = 0 To maxI - 1 'วนลูปตามเลขที่order
            OrNo = ODS.Tables("OrderData").Rows(i).Item("Dtl_con_id")
            ID = ODS.Tables("OrderData").Rows(i).Item("Dtl_idtrade")
            IDName = ODS.Tables("OrderData").Rows(i).Item("Stk_Name_1")
            ORPrice = ODS.Tables("OrderData").Rows(i).Item("Dtl_price")
            ORFac = ODS.Tables("OrderData").Rows(i).Item("Stk_Factor")
            OD = ODS.Tables("OrderData").Rows(i).Item("Dtl_Date")
            ORnum = ODS.Tables("OrderData").Rows(i).Item("Remain")
            Orcus = ODS.Tables("OrderData").Rows(i).Item("dtl_idcus")
            PO = ODS.Tables("OrderData").Rows(i).Item("dtl_po")


            If ORnum > 0 Then

                AnyData = New String() {OD, OrNo, PO, ID, IDName, ORnum, ORPrice.ToString("#,##0.00"), ORFac.ToString("#,##0.00")}
                lvi = New ListViewItem(AnyData)
                ListOrder.Items.Add(lvi)

                lvi.BackColor = System.Drawing.Color.Khaki
                lvi.ForeColor = System.Drawing.Color.Black
                lvi.UseItemStyleForSubItems = True

            Else

            End If

        Next



    End Sub


    Private Sub cboType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboType.KeyDown
        If e.KeyCode = 13 Then
            Call HeadList()
            Call searchOrder()
            cboColor.Focus()
        End If
    End Sub

    Private Sub cboColor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboColor.KeyDown
        If e.KeyCode = 13 Then
            Call HeadList()
            Call searchOrder()
            cboTh.Focus()
        End If
    End Sub

    Private Sub cboTh_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboTh.KeyDown
        If e.KeyCode = 13 Then
            Call HeadList()
            Call searchOrder()
            cboSize.Focus()
        End If
    End Sub

    Private Sub cboSize_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSize.KeyDown
        If e.KeyCode = 13 Then
            Call HeadList()
            Call searchOrder()
            'cboColor.Focus()
        End If
    End Sub

    Private Sub cboType_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboType.SelectionChangeCommitted
        Call HeadList()
        Call searchOrder()
    End Sub

    Private Sub cboColor_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboColor.SelectionChangeCommitted
        Call HeadList()
        Call searchOrder()
    End Sub

    Private Sub cboTh_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTh.SelectionChangeCommitted
        Call HeadList()
        Call searchOrder()
    End Sub

    Private Sub cboSize_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSize.SelectionChangeCommitted
        Call HeadList()
        Call searchOrder()
    End Sub

    Private Sub ListOrder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListOrder.Click
        Dim i As Integer = 0
        Dim lvi As ListViewItem
        Try
            For i = 0 To ListOrder.SelectedItems.Count - 1
                lvi = ListOrder.SelectedItems(i)
                CutOrNo = ListOrder.SelectedItems(i).SubItems.Item(1).Text()
                CutID = ListOrder.SelectedItems(i).SubItems.Item(3).Text()
                CutOrNum = ListOrder.SelectedItems(i).SubItems.Item(5).Text()
               
            Next
        Catch
            Exit Sub
        End Try
    End Sub

    Private Sub cmbCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCut.Click
        Dim da As SqlClient.SqlDataAdapter
        Dim ds As DataSet = New DataSet
        Dim CutNum As Double

        ds.Clear()
        txtSQL = "   SELECT     * "
        txtSQL = txtSQL & " from trandatad "
        txtSQL = txtSQL & " where dtl_con_id='" & CutOrNo & "' "
        txtSQL = txtSQL & " and dtl_idtrade='" & CutID & "'"
        txtSQL = txtSQL & " and dtl_idcus='" & PId & "'"
        txtSQL = txtSQL & " and dtl_type='B'"

        da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        da.Fill(ds, "CutDetail")

        If ds.Tables("CutDetail").Rows.Count > 0 Then
            CutNum = CutOrNum + ds.Tables("CutDetail").Rows(0).Item("dtl_num_2")

            txtSQL = "Update trandatad "
            txtSQL = txtSQL & "Set "
            txtSQL = txtSQL & "dtl_num_2='" & CutNum & "'"
            txtSQL = txtSQL & " where dtl_idtrade='" & CutID & "' and dtl_con_id='" & CutOrNo & "' and dtl_type='b'"


            Try
                With subCom
                    .CommandType = CommandType.Text
                    .CommandText = txtSQL
                    .Connection = Conn
                    .ExecuteNonQuery()
                End With
            Catch errprocess As Exception
                MessageBox.Show("ไม่สามารถเพิ่มข้อมูลได้เนื่องจาก " & errprocess.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

        End If 'ของ Trandatad
        CutNum = 0
        txtSQL = "   SELECT     * "
        txtSQL = txtSQL & " from stkdetl "
        txtSQL = txtSQL & " where dtl_code='" & CutID & "'"
        txtSQL = txtSQL & " and dtl_store='" & PId & "'"


        da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        da.Fill(ds, "CutStkDetl")

        If ds.Tables("CutStkDetl").Rows.Count > 0 Then
            CutNum = ds.Tables("CutStkDetl").Rows(0).Item("dtl_or_q1") - CutOrNum

            txtSQL = "Update stkdetl "
            txtSQL = txtSQL & "Set "
            txtSQL = txtSQL & "dtl_or_q1='" & CutNum & "'"
            txtSQL = txtSQL & " where dtl_code='" & CutID & "' and dtl_store='" & PId & "' "

            Try
                With subCom
                    .CommandType = CommandType.Text
                    .CommandText = txtSQL
                    .Connection = Conn
                    .ExecuteNonQuery()
                End With
            Catch errprocess As Exception
                MessageBox.Show("ไม่สามารถเพิ่มข้อมูลได้เนื่องจาก " & errprocess.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        Call runGetUserDel()
        Call HeadList()
        Call searchOrder()

        CutNum = 0
        CutOrNo = ""
        CutID = ""
       
    End Sub

    Sub runGetUserDel()
        DBtools.dbSaveUser(SqlGetUserDel, CutID)
    End Sub
    Function SqlGetUserDel() As String
        txtSQL = "Insert into userhistory("
        txtSQL = txtSQL & "history_user,history_Status,history_date,history_time,History_head"
        txtSQL = txtSQL & ")"
        txtSQL = txtSQL & "Values("
        txtSQL = txtSQL & "'" & GetUserName & "','ตัดitemสินค้า " & CutID & " ในOrderเลขที่ " & CutOrNo & " จำนวน " & CutOrNum & "  ','"
        '(((Month(  Now) & "/" & DateAndTime.Day( Now) & "/" & Year( Now) - 543)))
        txtSQL = txtSQL & (((Month(Now) & "/" & DateAndTime.Day(Now) & "/" & Year(Now) - 543))) & "','"
        txtSQL = txtSQL & (Format((Now), "HH:mm:ss")) & "','"

        txtSQL = txtSQL & CutOrNo & "'"
        txtSQL = txtSQL & ")"
        Return txtSQL
    End Function

   
End Class
