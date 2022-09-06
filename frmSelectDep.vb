Public Class frmSelectDep
    Dim chkTB As Boolean
    Dim chkBill As Boolean = False
    Dim chkRow As Boolean
    Dim searchDS As DataSet = New DataSet
    Dim searchDA As SqlClient.SqlDataAdapter
    Dim QDAte As Date
    Dim QNo As String


    Dim QStatus As String
    Dim QSum As Double
    Dim QDep As Double
    Dim AnyData() As String
    Dim lvi As ListViewItem
    Dim DepCusID As String
    Private Sub frmSelectDep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Headlist()

        DepCusID = DBtools.DepCus
        Call SearchDep(DepCusID)
    End Sub
    Sub Headlist()
        If chkTB = True Then

            lsvDepCus.Columns.Clear()
            lsvDepCus.Items.Clear()
            chkTB = False

        End If
        lsvDepCus.Columns.Add("วันที่เอกสาร", 120, HorizontalAlignment.Center) '0
        lsvDepCus.Columns.Add("เลขที่เอกสาร", 160, HorizontalAlignment.Center) '1
        lsvDepCus.Columns.Add("ยอดเงินมัดจำ", 130, HorizontalAlignment.Right) '6
        lsvDepCus.Columns.Add("ยอดเงินมัดจำคงเหลือ", 160, HorizontalAlignment.Right) '7
        lsvDepCus.View = View.Details
        lsvDepCus.GridLines = True


        chkTB = True
    End Sub
    Sub SearchDep(ByVal CusID As String)
        If chkBill = True Then

            searchDS.Tables("BillData").Clear()
            chkBill = False
        End If

        txtSQL = getSQLbyDep(CusID)
        searchDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        searchDA.Fill(searchDS, "BillData")

        chkBill = True

        If txtSQL = "" Then
            MsgBox("กรุณาเลือกหัวข้อที่ต้องการค้นหา", vbOKOnly, "แจ้งเตือน")
            Exit Sub
        Else
            If searchDS.Tables("BillData").Rows.Count > 0 Then
                Dim maxI As Integer
                Dim i As Integer
                Dim rowI As Integer = 0

                maxI = searchDS.Tables("BillData").Rows.Count

                For i = 0 To searchDS.Tables("BillData").Rows.Count - 1
                    QDAte = Format(searchDS.Tables("BillData").Rows(i).Item("trh_Date"), "dd/MM/yy")
                    QNo = searchDS.Tables("BillData").Rows(i).Item("Trh_no")



                    QSum = searchDS.Tables("BillData").Rows(i).Item("trh_amt")
                    If IsDBNull(searchDS.Tables("BillData").Rows(i).Item("trh_d_amt")) Then
                        QDep = searchDS.Tables("BillData").Rows(i).Item("trh_amt")
                    Else
                        QDep = searchDS.Tables("BillData").Rows(i).Item("trh_d_amt")
                    End If
                    If IsDBNull(searchDS.Tables("BillData").Rows(i).Item("trh_tran")) Then
                        QStatus = ""
                    Else
                        QStatus = searchDS.Tables("BillData").Rows(i).Item("trh_tran")
                        If QStatus = True Then
                            QStatus = "ใช้งานได้"
                        Else
                            QStatus = "ปิด"
                        End If
                    End If
                    AnyData = New String() {QDAte, QNo, QSum.ToString("#,##0.00"), QDep.ToString("#,##0.00"), QStatus}
                    lvi = New ListViewItem(AnyData)
                    lsvDepCus.Items.Add(lvi)
                    lvi.BackColor = System.Drawing.Color.DarkSeaGreen
                    lvi.ForeColor = System.Drawing.Color.Black
                    lvi.UseItemStyleForSubItems = True
                    chkRow = True
                Next

            Else
                MsgBox("ไม่พบข้อมูล", vbOKOnly, "แจ้งเตือน")
                Exit Sub
            End If


        End If

    End Sub
    Function getSQLbyDep(ByVal Depcusid As String) As String
        txtSQL1 = "Select  TranDataH.Trh_Type, TranDataH.Trh_NoType, "
        txtSQL1 = txtSQL1 & " TranDataH.Trh_No, TranDataH.Trh_Cus, "
        txtSQL1 = txtSQL1 & " TranDataH.Trh_Date, TranDataH.Trh_Amt,"
        txtSQL1 = txtSQL1 & " TranDataH.Trh_D_Amt, TranDataH.Trh_V_Amt,"
        txtSQL1 = txtSQL1 & " TranDataH.Trh_Full_Amt, TranDataH.Trh_Detail,"
        txtSQL1 = txtSQL1 & " TranDataH.Trh_Sale, TranDataH.Trh_Deposit, "
        txtSQL1 = txtSQL1 & " TranDataH.Trh_Tran, TranDataH.Trh_User, "
        txtSQL1 = txtSQL1 & " TranDataH.Trh_RunID, TranDataH.Trh_CS, "
        txtSQL1 = txtSQL1 & " TranDataH.Trh_Cus_Name, ArFile.Ar_Name "
        txtSQL1 = txtSQL1 & " From ArFile RIGHT OUTER Join "
        txtSQL1 = txtSQL1 & " TranDataH On ArFile.AR_CUS_ID = TranDataH.Trh_Cus "
        txtSQL1 = txtSQL1 & " Where (TranDataH.Trh_Type = '8') and TranDataH.Trh_Cus ='" & Depcusid & "'and TranDataH.Trh_d_amt>0 "
        If txtDepSearch.Text <> "" Then
            txtSQL1 = txtSQL1 & " and  trh_no='" & txtDepSearch.Text & "'"
        End If
        Return txtSQL1
    End Function

    Private Sub lsvDepCus_DoubleClick(sender As Object, e As EventArgs) Handles lsvDepCus.DoubleClick
        Dim i As Integer
        Dim frm1 As New frmSale

        For i = 0 To lsvDepCus.SelectedItems.Count - 1

            lvi = lsvDepCus.SelectedItems(i)

            EditDocNo = lsvDepCus.SelectedItems(i).SubItems.Item(1).Text()

        Next
        Me.Hide()



    End Sub

    Private Sub btnDepSearch_Click(sender As Object, e As EventArgs) Handles btnDepSearch.Click

    End Sub
End Class