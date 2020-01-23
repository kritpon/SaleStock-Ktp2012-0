
Public Class frmSearchAmphoe

    Dim subDS As New DataSet
    Dim subDA As SqlClient.SqlDataAdapter
    Dim chkAmphur As Boolean = False


    Sub ShowData()
        txtSQL = " SELECT * "
        txtSQL = txtSQL & " FROM AmphoeMast "
        If txtFindStr.Text = "" Then
        Else
            txtSQL = txtSQL & "Where Amphoe_Name like '%" & txtFindStr.Text & "%' "
        End If
        txtSQL = txtSQL & " order by Amphoe_Code "

        If chkAmphur = True Then
            subDS.Tables("Amphoe").Clear()
            chkAmphur = False
        End If

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "Amphoe")

        chkAmphur = True

        With dbGrid
            .DataSource = subDS.Tables("Amphoe")

        End With

        Call frmSticGrd()

        If subDS.Tables("Amphoe").Rows.Count = 1 Then

            lbCode.Text = subDS.Tables("Amphoe").Rows(0).Item("Amphoe_Code")
            lbName.Text = subDS.Tables("Amphoe").Rows(0).Item("Amphoe_Name")
            lbCountryCode.Text = subDS.Tables("Amphoe").Rows(0).Item("Country_Code")
            lbCountryName.Text = subDS.Tables("Amphoe").Rows(0).Item("Country_Name")
        End If
        Call showAddr()
    End Sub

    Sub frmSticGrd()

        Dim grdTS As DataGridTableStyle = New DataGridTableStyle
        Dim Country01 As New DataGridTextBoxColumn
        Dim Country02 As New DataGridTextBoxColumn
        Dim Country03 As New DataGridTextBoxColumn
        Dim Country04 As New DataGridTextBoxColumn

        With grdTS

            '.AlternatingBackColor = Color.LightSkyBlue
            '.BackColor = Color.AliceBlue
            .MappingName = "Amphoe"  'กำหนดให้ DatagridTalbleStyle ใช้กับ Table ใด

        End With

        With Country01

            .HeaderText = "อำเภอ"
            .MappingName = "Amphoe_Name"
            .Width = 200
            .ReadOnly = True

        End With
        With Country02

            .HeaderText = "Code"
            .MappingName = "Amphoe_Code"
            .Width = 5
            .ReadOnly = True

        End With
        With Country03

            .HeaderText = "จังหวัด"
            .MappingName = "Country_Name"
            .Width = 200
            .ReadOnly = True

        End With
        With Country04

            .HeaderText = "CountryCode"
            .MappingName = "Country_Code"
            .Width = 5
            .ReadOnly = True

        End With
        grdTS.GridColumnStyles.Add(Country01)
        grdTS.GridColumnStyles.Add(Country02)

        grdTS.GridColumnStyles.Add(Country03)
        grdTS.GridColumnStyles.Add(Country04)

        With dbGrid
            If chkAmphur = True Then
                .TableStyles.Clear()
            End If

            .CaptionText = "รายละเอียดอำเภอ "
            .FlatMode = True
            .TableStyles.Add(grdTS)
            .Refresh()
        End With

    End Sub

    Private Sub cmbExit_Click(sender As Object, e As EventArgs) Handles cmbExit.Click
        Me.Close()

    End Sub
    Sub updateAmphoe(ArCode As String, ArAmphoe As String, ArCountry As String)

        txtSQL = "Update Arfile "
        txtSQL = txtSQL & "Set Ar_Amphoe_Code='" & ArAmphoe & "',"
        txtSQL = txtSQL & "Ar_Country_Code='" & ArCountry & "' "

        txtSQL = txtSQL & "Where Ar_Cus_ID='" & ArCode & "' "

        DBtools.dbSaveDATA(txtSQL, "")


    End Sub
    Private Sub cmbSelect_Click(sender As Object, e As EventArgs) Handles cmbSelect.Click
        If lbCode.Text = "" Then
            MsgBox("เขตการยังไม่ได้ถูกเลือก")
        End If
        selAmphoe = lbCode.Text
        selCountry = lbCountryCode.Text
        If selAmphoe = "" Then
        Else
            Call updateAmphoe(selCusiD, selAmphoe, selCountry)
        End If

        'selZip=
        Me.Close()
    End Sub

    Sub fmtListView()

        lsvAddrCus.Columns.Add("รายการ", 400, HorizontalAlignment.Left) '0
        'lsvAddrCus.Columns.Add("รายการ", 300, HorizontalAlignment.Left) '1
        'lsvMap.Columns.Add("Order No.", 480, HorizontalAlignment.Left) '2
        lsvAddrCus.View = View.Details
        lsvAddrCus.GridLines = True

    End Sub
    Sub showAddr()

        Dim chkData As Boolean = False
        Dim subDS As New DataSet
        Dim subDA As New SqlClient.SqlDataAdapter

        Dim anydata() As String
        Dim lvi As ListViewItem
        Dim i As Integer
        Dim strData As String = ""

        'Dim strArCusName As String = ""
        'Dim strArAddr As String = ""
        'Dim strArAddr1 As String = ""
        'Dim strArAddr2 As String = ""

        txtSQL = "Select Ar_Name,Ar_Addr,Ar_Addr_1,Ar_Addr_2 "
        txtSQL = txtSQL & "From ArFile "
        txtSQL = txtSQL & "Where Ar_Cus_id='" & selCusiD & "' "
        If chkData = True Then
            subDS.Tables("Detail").Clear()
            chkData = False
        End If

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "Detail")
        chkData = True
        lsvAddrCus.Items.Clear()


        For i = 0 To subDS.Tables("Detail").Columns.Count - 1
            With subDS.Tables("Detail").Rows(0)

                strData = .Item(i)               
                anydata = New String() {strData}
                lvi = New ListViewItem(anydata)
                lsvAddrCus.Items.Add(lvi)

            End With

        Next

    End Sub

    Private Sub frmSearchAmphoe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call fmtListView()
        DBtools.openDB()
        Call ShowData()
        txtFindStr.Focus()

    End Sub

    Private Sub dbGrid_Click(sender As Object, e As EventArgs) Handles dbGrid.Click
        Dim UserSelRow As Integer = 0
        UserSelRow = dbGrid.CurrentRowIndex

        If UserSelRow >= 0 Then
            lbCode.Text = CStr(dbGrid.Item(UserSelRow, 1))
            lbName.Text = CStr(dbGrid.Item(UserSelRow, 0))

            lbCountryCode.Text = CStr(dbGrid.Item(UserSelRow, 3))
            lbCountryName.Text = CStr(dbGrid.Item(UserSelRow, 2))

        End If
    End Sub

    Private Sub dbGrid_CurrentCellChanged(sender As Object, e As EventArgs) Handles dbGrid.CurrentCellChanged
        Dim UserSelRow As Integer = 0
        UserSelRow = dbGrid.CurrentRowIndex

        If UserSelRow >= 0 Then
            lbCode.Text = CStr(dbGrid.Item(UserSelRow, 1))
            lbName.Text = CStr(dbGrid.Item(UserSelRow, 0))

            lbCountryCode.Text = CStr(dbGrid.Item(UserSelRow, 3))
            lbCountryName.Text = CStr(dbGrid.Item(UserSelRow, 2))

        End If
    End Sub

    Private Sub dbGrid_Navigate(sender As Object, ne As NavigateEventArgs) Handles dbGrid.Navigate

    End Sub

    Private Sub cmdFind_Click(sender As Object, e As EventArgs) Handles cmdFind.Click

        ShowData()

    End Sub

    Private Sub txtFindStr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFindStr.KeyDown
        If e.KeyCode = Keys.Enter Then
            ShowData()
        End If
    End Sub

   
End Class