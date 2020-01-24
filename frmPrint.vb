Imports System.IO
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Text

Public Class frmPrint

    Dim UseFont As New Font("Cordia UPC", 19, FontStyle.Bold)
    Dim UseFont1 As New Font("MS Sans Serif", 9)
    Dim UseFont2 As New Font("MS Sans Serif", 10)


    Dim pagenumber As Integer = 1

    'Public Property PaperSize As PaperSize
    'Dim UseFont As New Font("Cordia UPC", 14, FontStyle.Bold)

    Dim prDoc As PrintDocument = New PrintDocument
    Dim prDlg As PrintDialog = New PrintDialog

    Dim DA01 As OleDb.OleDbDataAdapter
    Dim DS01 As New DataSet

    Dim chkMaster As Boolean = False

    Dim chkPrnPO As Boolean = False
    Dim chkPrint As Boolean = False
    Dim strTime As String = getTimeSer().ToString

    Private Function IsInstallPrinter() As Boolean
        IsInstallPrinter = False
        If prDoc.PrinterSettings.PrinterName = "<no default printer>" Then
            IsInstallPrinter = False
        Else
            prDoc.PrinterSettings.PrinterName = cmbDrvPrint.Text  '  เลือกเครื่องพิมพ์  Prin
            IsInstallPrinter = True
        End If
    End Function
    Private Sub StringToPrint_Print(ByVal sender As Object, ByVal e As PrintPageEventArgs)


        If MsgBox("ต้องการแสดง PO หรือไม่", MsgBoxStyle.YesNo, "สอบถาม") = MsgBoxResult.Yes Then
            chkPrnPO = True
            'printHpo(sender, e)  '  ยังไม่เสร้จ ปิดไว้ก่อน 
            printNpo(sender, e)

        Else 'ของmsgbox
            chkPrnPO = False
            printNpo(sender, e)


        End If ' ของmsgbox



        Dno = ""


    End Sub
    Sub Print()
        AddHandler prDoc.PrintPage, New PrintPageEventHandler(AddressOf Me.StringToPrint_Print)
        prDoc.DocumentName = "Bill"
        'prDoc.DefaultPageSettings.Landscape = True
        prDlg.Document = prDoc
        'prDlg.Document.PrinterSettings.PaperSizes=*************************************
        Cursor.Current = Cursors.Default
    End Sub

    Sub Setting_Print() 'ของเก่าก่อนเปลี่ยนให้พิมพ์ต่อเนื่อง ปัจจุบันใช้อันนี้เพราะว่า Printแล้วไม่เลื่อน

        If IsInstallPrinter() = True Then

            'If prDlg.ShowDialog = DialogResult.OK Then

            '    prDoc.Print()

            'End If
            prDoc.Print()
        Else
            MessageBox.Show("กรุณาติดตั้งเครื่อง Printer ก่อนสั่งพิมพ์เอกสาร", "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
    Sub runGetUserPrint()

        DBtools.dbSaveUser(SqlGetUserPrint(EditNo), EditNo)

    End Sub

    Function SqlGetUserPrint(editNo As String) As String

        txtSQL = "Insert into userhistory("
        txtSQL = txtSQL & "history_user,history_Status,history_date,history_time,History_head"
        txtSQL = txtSQL & ")"
        txtSQL = txtSQL & "Values("
        txtSQL = txtSQL & "'" & GetUserName & "','พิมพ์เอกสารเลขที่" & editNo & "   ','"
        '(((Month( Now) & "/" & DateAndTime.Day(Now) & "/" & Year(Now) - 543)))
        txtSQL = txtSQL & (((Month(Now) & "/" & DateAndTime.Day(Now) & "/" & Year(Now) - 543))) & "','"
        txtSQL = txtSQL & (Format((Now), "HH:mm:ss")) & "','"
        txtSQL = txtSQL & editNo & "'"
        txtSQL = txtSQL & ")"
        Return txtSQL
    End Function

    Sub runPrint()

        'If MsgBox("ต้องการพิมพ์เอกสารหรือไม่ ", MsgBoxStyle.YesNo, "แจ้งเตือน") = MsgBoxResult.Yes Then

        Call Print()
        Call Setting_Print()
        Call runGetUserPrint()

        chkNew = False
        chkEditDoc = False
        'EditNo = ""

        'End If

        Me.Close()


    End Sub

    Private Sub frmPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pkInstalledPrinters As String

        Dim pkCustomSize1 As New PaperSize("Custom Paper Size", 550, 850)
        lbDocNo.Text = EditNo
        'cboPageSize.Items.Add(pkCustomSize1)
        'cboPageSize.SelectedIndex = 0

        For Each pkInstalledPrinters In _
       PrinterSettings.InstalledPrinters
            cmbDrvPrint.Items.Add(pkInstalledPrinters)
        Next pkInstalledPrinters
        'cmbDrvPrint.SelectedIndex = 0  ' code เดิม

        Dim oPS As New System.Drawing.Printing.PrinterSettings
        Try
            ' ใช้ Default Printer เป็นลำดับที่ 1
            cmbDrvPrint.SelectedItem = oPS.PrinterName
        Catch ex As Exception

        End Try

        'For i = 0 To prDoc.PrinterSettings.PaperSizes.Count - 1
        '    pkSize = prDoc.PrinterSettings.PaperSizes.Item(i)
        '    cboPageSize.Items.Add(pkSize)
        'Next

        'เลือกเครื่องพิมพ์
        'prDoc.PrinterSettings.PrinterName = cmbPrint.Text
    End Sub


    Function SQLprtTrhNo_PO(ByVal txtNo As String) As String  'ไม่มีPO

        txtSQL = "Select  "
        txtSQL = txtSQL & "TranDataH.Trh_Type, TranDataH.Trh_Date,DATEADD(d, TranDataH.Trh_Term, TranDataH.Trh_date) AS dday,"
        txtSQL = txtSQL & "TranDataH.Trh_Disc, TranDataH.Trh_V_Amt,  TranDataH.Trh_Amt, TranDataH.Trh_D_Amt,"
        txtSQL = txtSQL & "TranDataH.Trh_Detail,TranDataH.Trh_D_Amt + TranDataH.Trh_V_Amt AS Total,TranDataH.Trh_No, "
        txtSQL = txtSQL & "TranDataH.Trh_Cus, TranDataH.Trh_Detail,TranDataH.Trh_Term,Trh_Deposit,Trh_Depo_Ref,Trh_Bill,"
        txtSQL = txtSQL & "ArFile.Ar_Type, ARFILE.AR_CUS_ID,ArFile.Ar_Tax_Code,ARFILE.AR_NAME,ArFile.Ar_update,"
        txtSQL = txtSQL & "Arfile.AR_CUS_ID AS Cus_Code,Ar_Acct, "
        txtSQL = txtSQL & "Arfile.ar_shp_va,Arfile.ar_shp_va1,Arfile.ar_shp_va2, Arfile.AR_NAME, "
        txtSQL = txtSQL & "Arfile.ar_addr, Arfile.ar_addr_1, Arfile.ar_addr_2, Arfile.ar_sales,SalesMan.SL_Name, Arfile.ar_term "

        txtSQL = txtSQL & "From TranDataH left Join Arfile "
        txtSQL = txtSQL & "On TranDataH.Trh_Cus=ArFile.Ar_Cus_ID "
        txtSQL = txtSQL & "Left Join SalesMan "
        txtSQL = txtSQL & "ON TranDataH.Trh_Sale=SalesMan.SL_ID "

        txtSQL = txtSQL & "Where TranDataH.Trh_Type='S' "
        txtSQL = txtSQL & "And TranDataH.Trh_No='" & txtNo & "' "

        Return txtSQL

    End Function
    Function SQLprtDtlNo_PO(ByVal txtNo As String) As String  'ไม่มีPO

        txtSQL = "Select "
        txtSQL = txtSQL & "TranDataD.Dtl_type,TranDataD.Dtl_date, TranDataD.Dtl_need, TranDataD.Dtl_no,TranDataD.Dtl_PO,  "
        txtSQL = txtSQL & "TranDataD.Dtl_idtrade, TranDataD.Dtl_num, TranDataD.Dtl_price,TranDataD.Dtl_t_disc,"
        txtSQL = txtSQL & "TranDataD.Dtl_sum, TranDataD.Dtl_con_id, "
        txtSQL = txtSQL & "TranDataD.Dtl_cutA_code, TranDataD.Dtl_runnum, TranDataD.Dtl_detail,"
        txtSQL = txtSQL & "BaseMast.Stk_Name_1, BaseMast.Stk_Name_2, BaseMast.Stk_Unit_1, TranDataD.Dtl_con_id "

        txtSQL = txtSQL & "From TranDataD "
        txtSQL = txtSQL & "Left Join BaseMast "
        txtSQL = txtSQL & "On TranDataD.Dtl_idTrade=BaseMast.Stk_Code "

        txtSQL = txtSQL & "Where Dtl_Type='S' "
        txtSQL = txtSQL & "And TranDataD.Dtl_No='" & txtNo & "' "
        txtSQL = txtSQL & ""


        Return txtSQL

    End Function


    Sub printNpo(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim ds As New DataSet
        Dim da As New SqlClient.SqlDataAdapter

        Dim NoSel1 As String

        Dim c As Integer = 0
        'Dim k As Integer = 0
        '=================================================================
        '    หัวบิล    
        Dim strTrhNo As String = ""
        Dim strTrhDate As String = ""
        Dim strTrhCus As String = ""    'เก็บรหัสลูกค้าปิ่นเกล้า
        Dim strArName As String = ""
        Dim strArTaxID As String = ""
        Dim strArAcct As String = ""
        Dim strTrhDepoRef As String = ""

        Dim strArAddr As String = ""
        Dim strArAddr1 As String = ""
        Dim strArAddr2 As String = ""

        Dim strArShpVa As String = ""
        Dim strArShpVa1 As String = ""
        Dim strArShpVa2 As String = ""

        Dim strDDay As String = ""
        Dim strSLname As String = ""
        Dim strArTerm As String = ""

        Dim dblTrhAmt As Double = 0.0
        Dim StrTrhAmt As String = ""

        Dim dblTrhD_Amt As Double = 0.0
        Dim StrTrhD_Amt As String = ""

        Dim dblTrhDePoSit As Double = 0
        Dim strTrhDeposit As String = ""

        Dim dblTrhDisc As Double = 0
        Dim strTrhDisc As String = ""
        Dim strTrhDiscPrn As String = ""  ' ใช้ในการพิมพ์ % ส่วนลด บริเวณท้ายบิล

        Dim StrTrhVat As String = ""
        Dim dblTrhVat As Double = 0.0

        Dim dblTrhTotal1 As Double = 0
        Dim strTrhTotal1 As String = ""
        'Dim dblTrhTotal2 As Double = 0

        Dim StrTrhFullAmt As String = ""
        Dim dblTrhFullAmt As Double = 0.0
        Dim stringTotal As String = ""

        Dim strTrhDetail As String = ""
        '   ท้ายบิล

        '=================================================================
        '   รายการสินค้า

        Dim FMsetDigiCal As String = "#,##0.00"
        Dim setDigiCal As Integer = 0
        Dim FMsetDigiCal2 As String = ""
        Dim strItem As String = ""
        Dim strItemCount As Integer = 0 ' นับจำนวน item สินค้าแล้วนำเอาไปปิดท้ายบิล
        Dim strStkName As String = ""
        Dim strDtlDetail As String = ""

        Dim strQty As String = ""
        Dim strPrice As String = ""
        Dim strSum As String = ""
        Dim strPriceDisc As String = ""

        Dim str16 As String = ""


        Dim str21 As String = ""

        Dim strDtlPO As String = ""
        Dim str24 As String = ""


        Dim yy As Integer = 0

        Dim totalYY As Integer = 0  '  จัดตำแหน่ง ตัวเลขก่อนลด และ หักมัดจำ

        Dim calVAT As Double = 0
        Dim chkVAT As String = ""
        Dim tempDisc As Double = 0
        Dim strDisc As String = ""

        'Dim StrAmt As String = ""

        Dim DiscBath As Double = 0.0 'เก็บค่าส่วนลดเป็นบาทที่ตัดbทิ้ง


        Dim x As Integer = 520
        Dim y As Integer = 900
        'Dim width As Integer = 225
        Dim width As Integer = 60
        Dim height As Integer = 60
        Dim newImage As Image = Image.FromFile(CurDir() & "\Report\QRcodePanStar.jpg")

        NoSel1 = EditNo

        If chkPrint = True Then
            ds.Tables("Print").Clear()
            chkPrint = False
        End If
        '              เริ่มชุดคำสั่ง พิมพ์ งานที่ ไม่มี PO 
        '======================================================================================================
        'txtSQL = SQLPrint2() 'ไม่มีPO (vat)

        txtSQL = SQLprtTrhNo_PO(NoSel1)
        ds = New DataSet
        da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        da.Fill(ds, "prnTrh")

        txtSQL = SQLprtDtlNo_PO(NoSel1)
        'DS = New DataSet
        da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        da.Fill(ds, "prnDtl")
        chkPrint = True

        strTrhNo = CStr(ds.Tables("prnTrh").Rows(c).Item("trh_no")) 'เลขที่บิล

        If Dvat = "N" Or Dvat = "n" Or Dvat = "M" Or Dvat = "X" Or Dvat = "Z" Then
            chkVAT = "N"
        Else
            chkVAT = "V"
            'chkVAT = Microsoft.VisualBasic.Left(strTrhNo, 1)
        End If
        calVAT = ds.Tables("prnTrh").Rows(c).Item("trh_bill")
        'strTrhDate = CStr(Format((DateInterval.Year, -543, ds.Tables("prnTrh").Rows(c).Item("trh_date")), "dd/MM/yyyy")) 'วันที่บิล
        strTrhDate = CStr(Format(((DateAndTime.Day(ds.Tables("prnTrh").Rows(c).Item("trh_date")) & "/" & Month(ds.Tables("prnTrh").Rows(c).Item("trh_date")) & "/" & Year(ds.Tables("prnTrh").Rows(c).Item("trh_date")) - 543)))) 'วันที่บิล
        strTrhCus = CStr(ds.Tables("prnTrh").Rows(c).Item("trh_cus")) 'รหัสลูกค้า
        strArName = CStr(ds.Tables("prnTrh").Rows(c).Item("Ar_Name")) 'ชื่อร้าน
        strArAddr = CStr(ds.Tables("prnTrh").Rows(c).Item("ar_addr")) 'ที่อยู่
        strArAddr1 = CStr(ds.Tables("prnTrh").Rows(c).Item("ar_addr_1")) 'ที่อยู่
        strArAddr2 = CStr(ds.Tables("prnTrh").Rows(c).Item("ar_addr_2")) 'ที่อยู่
        strArTerm = CStr(ds.Tables("prnTrh").Rows(c).Item("trh_term")) 'เครดิตเทอม
        strArAcct = CStr(ds.Tables("prnTrh").Rows(c).Item("Ar_Acct")) 'เครดิตเทอม

        If strArAcct = "112010" Then
            setDigiCal = 2
            FMsetDigiCal = "#,##0.00"
        Else
            setDigiCal = 3 '  3-08-60  แก้ไข จาก 4  เป็น 3  
            FMsetDigiCal2 = "#,##0.0000"
            FMsetDigiCal = "#,##0.0000"
        End If

        If Dvat = "N" Or Dvat = "n" Or Dvat = "M" Or Dvat = "X" Or Dvat = "Z" Then
            strArTaxID = ""
        Else
            If IsDBNull(ds.Tables("prnTrh").Rows(c).Item("Ar_Tax_Code")) Then
                strArTaxID = ""
            ElseIf Trim(ds.Tables("prnTrh").Rows(c).Item("Ar_Tax_Code")) = "" Then
                strArTaxID = ""
            Else
                strArTaxID = "Tax ID:= " & CStr(ds.Tables("prnTrh").Rows(c).Item("Ar_Tax_Code"))
            End If

        End If

        If IsDBNull(ds.Tables("prnTrh").Rows(c).Item("Trh_Depo_Ref")) Then
            strTrhDepoRef = ""
        ElseIf Trim(ds.Tables("prnTrh").Rows(c).Item("Trh_Depo_Ref")) = "" Then
            strTrhDepoRef = ""
        Else
            strTrhDepoRef = CStr(ds.Tables("prnTrh").Rows(c).Item("Trh_Depo_Ref"))
        End If

        If IsDBNull(ds.Tables("prnTrh").Rows(c).Item("dday")) Then
            strDDay = ""
        Else
            strDDay = CStr(ds.Tables("prnTrh").Rows(c).Item("dday")) 'วันที่ครบกำหนดชำระ
        End If

        strSLname = CStr(ds.Tables("prnTrh").Rows(c).Item("sl_name")) 'ชื่อsale


        If IsDBNull(ds.Tables("prnTrh").Rows(c).Item("ar_shp_va")) Then
            strArShpVa = ""
        Else
            strArShpVa = CStr(ds.Tables("prnTrh").Rows(c).Item("ar_shp_va")) 'ที่ส่งของ

        End If
        'ElseIf DS.Tables("prnTrh").Rows(c).Item("ar_shp_va1") = "" Then
        '    strArShpVa1 = ""

        If IsDBNull(ds.Tables("prnTrh").Rows(c).Item("ar_shp_va1")) Then
            strArShpVa1 = ""

        Else
            strArShpVa1 = CStr(ds.Tables("prnTrh").Rows(c).Item("ar_shp_va1")) 'ชื่อsale
        End If

        If IsDBNull(ds.Tables("prnTrh").Rows(c).Item("ar_shp_va2")) Then
            strArShpVa2 = ""
        Else
            strArShpVa2 = CStr(ds.Tables("prnTrh").Rows(c).Item("ar_shp_va2")) 'ชื่อsale
        End If

        '=================================   ส่วนของเงินท้ายบิล    ====================================================

        'dblTrhAmt = dblTrhAmt - dblTrhDisc - dblTrhDePoSit
        'StrTrhAmt = Format(dblTrhAmt, "#,##0.00#")

        dblTrhAmt = ds.Tables("prnTrh").Rows(c).Item("trh_amt")   '  ยอดเงิน  ก่อนลดส่วนลด 
        StrTrhAmt = Format(dblTrhAmt, FMsetDigiCal)

        dblTrhD_Amt = ds.Tables("prnTrh").Rows(c).Item("trh_D_amt")
        StrTrhD_Amt = Format(Math.Round(dblTrhD_Amt, 3), FMsetDigiCal)

        'ยอดเงิน หลังลดส่วนลด 
        If IsDBNull(ds.Tables("prnTrh").Rows(c).Item("trh_disc")) Then
            dblTrhDisc = 0
        ElseIf Microsoft.VisualBasic.Right(ds.Tables("prnTrh").Rows(c).Item("trh_disc"), 1) = "B" Then

            'dblTrhDisc = CDbl(Microsoft.VisualBasic.Left(DS.Tables("prnTrh").Rows(c).Item("trh_disc"), (Len(DS.Tables("prnTrh").Rows(c).Item("trh_disc")) - 1)))

            dblTrhDisc = CDbl(Microsoft.VisualBasic.Left(ds.Tables("prnTrh").Rows(c).Item("trh_disc"), (Len(ds.Tables("prnTrh").Rows(c).Item("trh_disc")) - 1)))
            strTrhDisc = Format(Math.Round(dblTrhDisc, 2), "#,##0.00")
            strTrhDiscPrn = ""
        ElseIf Microsoft.VisualBasic.Right(ds.Tables("prnTrh").Rows(c).Item("trh_disc"), 1) = "b" Then

            ' dblTrhDisc = CDbl(Microsoft.VisualBasic.Left(DS.Tables("prnTrh").Rows(c).Item("trh_disc"), (Len(DS.Tables("prnTrh").Rows(c).Item("trh_disc")) - 1)))
            dblTrhDisc = CDbl(Microsoft.VisualBasic.Left(ds.Tables("prnTrh").Rows(c).Item("trh_disc"), (Len(ds.Tables("prnTrh").Rows(c).Item("trh_disc")) - 1)))
            strTrhDisc = Format(Math.Round(dblTrhDisc, 2), "#,##0.00")
            strTrhDiscPrn = ""
        ElseIf Microsoft.VisualBasic.Right(ds.Tables("prnTrh").Rows(c).Item("trh_disc"), 1) = "%" Then

            dblTrhDisc = CDbl(Microsoft.VisualBasic.Left(ds.Tables("prnTrh").Rows(c).Item("trh_disc"), (Len(ds.Tables("prnTrh").Rows(c).Item("trh_disc")) - 1)))
            dblTrhDisc = Math.Round((dblTrhDisc * ds.Tables("prnTrh").Rows(c).Item("trh_amt")) / 100, 2)
            strTrhDisc = Format(Math.Round(dblTrhDisc, 2), "#,##0.00")
            strTrhDiscPrn = ds.Tables("prnTrh").Rows(c).Item("trh_disc")


        ElseIf IsNumeric(Microsoft.VisualBasic.Right(ds.Tables("prnTrh").Rows(c).Item("trh_disc"), 1)) Then

            strTrhDisc = Format(Math.Round(CDbl(ds.Tables("prnTrh").Rows(c).Item("trh_disc"))), "#,##0.00")
            dblTrhDisc = CDbl(strTrhDisc)
            strTrhDiscPrn = ""
        End If

        '   เงินมัดจำ
        If IsDBNull(ds.Tables("prnTrh").Rows(c).Item("trh_Deposit")) Then

            dblTrhDePoSit = 0
            strTrhDeposit = "0.00"

        ElseIf Microsoft.VisualBasic.Right(ds.Tables("prnTrh").Rows(c).Item("trh_Deposit"), 1) = "%" Then
            dblTrhDePoSit = CDbl(Microsoft.VisualBasic.Left(ds.Tables("prnTrh").Rows(c).Item("trh_Deposit"), (Len(ds.Tables("prnTrh").Rows(c).Item("trh_Deposit")) - 1)))
            dblTrhDePoSit = (dblTrhAmt * dblTrhDePoSit) / 100
            strTrhDeposit = Format(dblTrhDePoSit, "#,##0.00")

        ElseIf Microsoft.VisualBasic.Right(ds.Tables("prnTrh").Rows(c).Item("trh_Deposit"), 1) = "b" Then

            dblTrhDePoSit = CDbl(Microsoft.VisualBasic.Left(ds.Tables("prnTrh").Rows(c).Item("trh_Deposit"), (Len(ds.Tables("prnTrh").Rows(c).Item("trh_Deposit")) - 1)))
            strTrhDeposit = Format(dblTrhDePoSit, "#,##0.00")

        ElseIf Microsoft.VisualBasic.Right(ds.Tables("prnTrh").Rows(c).Item("trh_Deposit"), 1) = "B" Then

            dblTrhDePoSit = CDbl(Microsoft.VisualBasic.Left(ds.Tables("prnTrh").Rows(c).Item("trh_Deposit"), (Len(ds.Tables("prnTrh").Rows(c).Item("trh_Deposit")) - 1)))
            strTrhDeposit = Format(dblTrhDePoSit, "#,##0.00")

        ElseIf IsNumeric(Microsoft.VisualBasic.Right(ds.Tables("prnTrh").Rows(c).Item("trh_Deposit"), 1)) Then

            dblTrhDePoSit = CDbl(ds.Tables("prnTrh").Rows(c).Item("trh_DePosit"))
            strTrhDeposit = Format(dblTrhDePoSit, "#,##0.00")

        End If

        dblTrhTotal1 = (dblTrhAmt - dblTrhDisc) - dblTrhDePoSit
        strTrhTotal1 = Format((dblTrhAmt - dblTrhDisc) - dblTrhDePoSit, FMsetDigiCal)

        '=======  VAT
        If chkVAT = "V" Or chkVAT = "v" Then
            dblTrhVat = (dblTrhTotal1 * calVAT) / 100
        Else
            dblTrhVat = 0
        End If

        StrTrhVat = Format(dblTrhVat, "#,##0.00") 'ภาษี

        If dblTrhVat <> 0 Then
            StrTrhFullAmt = Format((dblTrhTotal1 + dblTrhVat), FMsetDigiCal)
        Else
            StrTrhFullAmt = Format(dblTrhTotal1, FMsetDigiCal)
        End If

        ThaiBaht01 = StrTrhFullAmt  'ยอดเงินรวม
        stringTotal = DBtools.NumberToThaiWord(ThaiBaht01)
        strTrhDetail = CStr(ds.Tables("prnTrh").Rows(c).Item("trh_detail"))   'หมายเหตุหลัก  ส่วนท้ายบิล

        '=========เริ่มส่วนของการ Print   รายละเอียดสินค้า  =================================================================
        Dim offSetY As Integer = 0
        Dim offSetX As Integer = 0

        If Dvat = "N" Or Dvat = "n" Or Dvat = "M" Or Dvat = "X" Or Dvat = "Z" Then
            offSetY = -65
            offSetX = -70
        Else
            offSetY = 3
            'offSetX = -70
        End If

        If ds.Tables("prnDtl").Rows.Count > 0 Then

            '===== เริ่ม บันทัดรายการสินค้า  =======================================================================
            For c = 0 To ds.Tables("prnDtl").Rows.Count - 1

                If chkVAT = "N" Then
                    '==========    พิมพ์  ฟอร์ม N-VAT  ===============
                    strItem = c + 1  '   ลำดับ หน้ารายการ

                    If IsDBNull(ds.Tables("prnDtl").Rows(c).Item("stk_name_1")) Then
                        If IsDBNull(ds.Tables("prnDtl").Rows(c).Item("stk_name_2")) Then
                            strStkName = ""
                        Else
                            strStkName = CStr((ds.Tables("prnDtl").Rows(c).Item("stk_name_2"))) 'ชื่อสินค้า PC
                        End If
                    Else
                        strStkName = CStr((ds.Tables("prnDtl").Rows(c).Item("stk_name_1"))) 'ชื่อสินค้า Sale
                    End If

                    strQty = CSng(Format(ds.Tables("prnDtl").Rows(c).Item("dtl_num"), "#,##0.00")) 'จำนวน
                    strPrice = Format(CDbl(ds.Tables("prnDtl").Rows(c).Item("Dtl_price")), FMsetDigiCal) 'ราคา/แผ่น
                    strDisc = 0
                    strPriceDisc = ""
                    If (ds.Tables("prnDtl").Rows(c).Item("Dtl_t_disc")) = "0" Then

                        'str13 = Format(CDbl(DS.Tables("Print").Rows(c).Item("Dtl_sum")), "#,##0.00") 'ราคารวม
                        strSum = Format(Math.Round(ds.Tables("prnDtl").Rows(c).Item("Dtl_sum"), 4), "#,##0.00")
                        strStkName = CStr(ds.Tables("prnDtl").Rows(c).Item("stk_name_1")) 'ชื่อสินค้า

                    Else

                        If IsDBNull(ds.Tables("prnDtl").Rows(c).Item("Dtl_t_disc")) Then
                            strDisc = 0
                        Else
                            strDisc = ds.Tables("prnDtl").Rows(c).Item("Dtl_t_disc")
                        End If

                        'If Microsoft.VisualBasic.Right(strDisc, 1) <> "b" Then
                        '    '  ลดราคาเป็น บาท  "b"  
                        '    tempDisc = CDbl(Microsoft.VisualBasic.Left(strDisc, Len(strDisc) - 1))
                        '    strPriceDisc = Format(Math.Round(strPrice - tempDisc, 4), "#,##0.00")
                        '    strSum = Format(Math.Round(DS.Tables("prnDtl").Rows(c).Item("Dtl_sum"), 4), "#,##0.00")

                        'ElseIf Microsoft.VisualBasic.Right(strDisc, 1) <> "%" Then

                        '    tempDisc = (CDbl(DS.Tables("prnDtl").Rows(c).Item("Dtl_sum")) * CDbl(tempDisc)) / 100
                        '    strSum = Format(Math.Round(DS.Tables("prnDtl").Rows(c).Item("Dtl_sum"), 4), "#,##0.00")

                        'Else
                        '    strSum = Format(Math.Round(DS.Tables("prnDtl").Rows(c).Item("Dtl_sum"), 4), "#,##0.00")
                        'End If

                        If Microsoft.VisualBasic.Right(strDisc, 1) = "b" Or Microsoft.VisualBasic.Right(strDisc, 1) = "B" Then
                            '  ลดราคาเป็น บาท  "b"  
                            tempDisc = CDbl(Microsoft.VisualBasic.Left(strDisc, Len(strDisc) - 1))
                            strPriceDisc = Format(Math.Round(strPrice - tempDisc, 4), "#,##0.00")

                            strSum = Format(Math.Round(ds.Tables("prnDtl").Rows(c).Item("Dtl_sum"), 3), "#,##0.00")

                        ElseIf Microsoft.VisualBasic.Right(strDisc, 1) = "%" Then

                            tempDisc = CDbl(Microsoft.VisualBasic.Left(strDisc, Len(strDisc) - 1))
                            tempDisc = (CDbl(ds.Tables("prnDtl").Rows(c).Item("Dtl_price")) * CDbl(tempDisc)) / 100

                            strPriceDisc = Format(Math.Round(strPrice - tempDisc, 4), "#,##0.00")
                            strSum = Format(Math.Round(ds.Tables("prnDtl").Rows(c).Item("Dtl_sum"), 3), "#,##0.00")

                        ElseIf IsNumeric(strDisc) Then

                            tempDisc = CDbl(strDisc)
                            strPriceDisc = Format(Math.Round(strPrice - tempDisc, 4), "#,##0.00")
                            strSum = Format(Math.Round(ds.Tables("prnDtl").Rows(c).Item("Dtl_sum"), 3), "#,##0.00")

                        End If

                    End If

                    If IsDBNull(ds.Tables("prnDtl").Rows(c).Item("dtl_detail")) Or Trim(ds.Tables("prnDtl").Rows(c).Item("dtl_detail")) = "" Then
                        strDtlDetail = ""
                    Else
                        strDtlDetail = "( " & CStr(ds.Tables("prnDtl").Rows(c).Item("dtl_detail")) & " )" 'หมายเหตุย่อย
                    End If
                    If chkPrnPO = True Then
                        If IsDBNull(ds.Tables("prnDtl").Rows(c).Item("Dtl_PO")) Or ds.Tables("prnDtl").Rows(c).Item("Dtl_PO") = "ไม่มีใบเบิก" Then
                            strDtlPO = ""
                        Else
                            strDtlPO = CStr(ds.Tables("prnDtl").Rows(c).Item("Dtl_PO"))
                        End If
                    End If
                    strDtlDetail = strDtlPO & "  " & strDtlDetail  ' รวม PO กับ หมายเหตุ

                    AnyString1(e.Graphics, strItem, (85 + 10 - 10), 440 + 30 + yy + offSetY, True) 'ลำดับ
                    AnyString1(e.Graphics, strStkName, (130 - 10), 440 + 30 + yy + offSetY, False) 'ชื่อสินค้า
                    'แก้ไข  04-01-59  เปลี่ยนฟอร์มใหม่  N-VAT
                    AnyString1(e.Graphics, strQty, (500 + 78 + offSetX), 440 + 30 + yy + offSetY, True) 'จำนวน
                    AnyString1(e.Graphics, strPrice, (590 + 55 + offSetX), 440 + 30 + yy + offSetY, True) 'ราคา
                    'AnyString1(e.Graphics, strPrice, 620, 440 + yy) 'ราคา  ปรับตำแหน่ง จาก 620 เป็น 590 
                    AnyString1(e.Graphics, (strPriceDisc), 590 + 120, 440 + 30 + yy + offSetY, True) 'ราคาหลังลด

                    If strDisc = "0" Or strDisc = "" Then
                        'strDisc = ""
                    Else
                        AnyString1(e.Graphics, "-" & strDisc, (640 + 40) + offSetX, 440 + 30 + yy + offSetY, True) 'ส่วนลด
                    End If

                    AnyString1(e.Graphics, strSum, (730 + 65), 440 + 30 + yy + offSetY, True) 'ราคารวม
                    '   พิมพ์ เลขที่ PO ในรายการสินค้า 

                    'If chkPrnPO = True Then
                    '    If strDtlPO = "" Then
                    '        AnyString1(e.Graphics, strDtlPO, 135, 460 + 30 + yy + offSetY, False) 'po
                    '    Else
                    '        AnyString1(e.Graphics, strDtlPO, 135, 460 + 30 + yy + offSetY, False) 'po
                    '    End If
                    'Else
                    '    'AnyString1(e.Graphics, "", 135, 460 + yy) 'po
                    'End If

                    '   พิมพ์ หมายเหตุ ในรายการสินค้า 
                    If strDtlDetail = "" Then
                        AnyString1(e.Graphics, strDtlDetail, 135, 460 + 30 + yy + offSetY, False) 'po
                    Else
                        AnyString1(e.Graphics, strDtlDetail, 135, 460 + 30 + yy + offSetY, False) 'po
                    End If

                    'If strDtlDetail = "" Then

                    'Else
                    '    If chkPrnPO = True And (Len(strDtlPO) > 0) Then
                    '        AnyString1(e.Graphics, strDtlDetail, (136 + (Len(strDtlPO) * 50) + 5), 460 + 30 + yy + offSetY, False) 'หมายเหตุย่อยต่อท้ายPO
                    '        'yy = yy + offSetY 
                    '        yy = yy + offSetY

                    '    Else
                    '        AnyString1(e.Graphics, strDtlDetail, (136 + 5), 460 + 30 + yy + offSetY, False) 'หมายเหตุย่อยต่อท้ายPO
                    '        yy = yy + offSetY
                    '        'AnyString1(e.Graphics, yy, (136 + (Len(strDtlPO) * 50) + 5), 460 + 30 + yy + offSetY, False) 'หมายเหตุย่อยต่อท้ายPO
                    '    End If

                    'End If

                    If chkPrnPO = True Then
                        yy = yy + 40
                    Else
                        If Trim(strDtlDetail) = "" Then
                            yy = yy + 20
                        Else
                            yy = yy + 40
                        End If

                    End If

                Else
                    '==================    พิมพ์ฟอร์ม VAT  =================

                    strItem = c + 1  '   ลำดับ หน้ารายการ

                    If IsDBNull(ds.Tables("prnDtl").Rows(c).Item("stk_name_1")) Then
                        If IsDBNull(ds.Tables("prnDtl").Rows(c).Item("stk_name_2")) Then
                            strStkName = ""
                        Else
                            strStkName = CStr((ds.Tables("prnDtl").Rows(c).Item("stk_name_2"))) 'ชื่อสินค้า PC
                        End If
                    Else
                        strStkName = CStr((ds.Tables("prnDtl").Rows(c).Item("stk_name_1"))) 'ชื่อสินค้า Sale
                    End If

                    strQty = CSng(Format(ds.Tables("prnDtl").Rows(c).Item("dtl_num"), "#,##0.00")) 'จำนวน
                    strPrice = Format(CDbl(ds.Tables("prnDtl").Rows(c).Item("Dtl_price")), FMsetDigiCal) 'ราคา/แผ่น
                    strDisc = ""
                    tempDisc = 0
                    strPriceDisc = ""


                    If (ds.Tables("prnDtl").Rows(c).Item("Dtl_t_disc")) = "0" Then
                        'str13 = Format(CDbl(DS.Tables("Print").Rows(c).Item("Dtl_sum")), "#,##0.00") 'ราคารวม
                        strSum = Format(Math.Round(ds.Tables("prnDtl").Rows(c).Item("Dtl_sum"), 3), FMsetDigiCal)
                        strStkName = CStr(ds.Tables("prnDtl").Rows(c).Item("stk_name_1")) 'ชื่อสินค้า

                    Else

                        If IsDBNull(ds.Tables("prnDtl").Rows(c).Item("Dtl_t_disc")) Then
                            strDisc = 0
                        Else
                            strDisc = ds.Tables("prnDtl").Rows(c).Item("Dtl_t_disc")
                        End If

                        If Microsoft.VisualBasic.Right(strDisc, 1) = "b" Or Microsoft.VisualBasic.Right(strDisc, 1) = "B" Then
                            '  ลดราคาเป็น บาท  "b"  
                            tempDisc = CDbl(Microsoft.VisualBasic.Left(strDisc, Len(strDisc) - 1))
                            strPriceDisc = Format(Math.Round(strPrice - tempDisc, 4), "#,##0.00")

                            strSum = Format(Math.Round(ds.Tables("prnDtl").Rows(c).Item("Dtl_sum"), 3), FMsetDigiCal)

                        ElseIf Microsoft.VisualBasic.Right(strDisc, 1) = "%" Then

                            tempDisc = CDbl(Microsoft.VisualBasic.Left(strDisc, Len(strDisc) - 1))
                            tempDisc = (CDbl(ds.Tables("prnDtl").Rows(c).Item("Dtl_price")) * CDbl(tempDisc)) / 100

                            strPriceDisc = Format(Math.Round(strPrice - tempDisc, 4), "#,##0.00")
                            strSum = Format(Math.Round(ds.Tables("prnDtl").Rows(c).Item("Dtl_sum"), 3), FMsetDigiCal)

                        ElseIf IsNumeric(strDisc) Then

                            tempDisc = CDbl(strDisc)
                            strPriceDisc = Format(Math.Round(strPrice - tempDisc, 4), "#,##0.00")
                            strSum = Format(Math.Round(ds.Tables("prnDtl").Rows(c).Item("Dtl_sum"), 3), FMsetDigiCal)

                        End If

                    End If

                    If IsDBNull(ds.Tables("prnDtl").Rows(c).Item("dtl_detail")) Or Trim(ds.Tables("prnDtl").Rows(c).Item("dtl_detail")) = "" Then
                        strDtlDetail = ""
                    Else
                        strDtlDetail = "( " & CStr(ds.Tables("prnDtl").Rows(c).Item("dtl_detail")) & " )" 'หมายเหตุย่อย
                    End If

                    If IsDBNull(ds.Tables("prnDtl").Rows(c).Item("Dtl_PO")) Or ds.Tables("prnDtl").Rows(c).Item("Dtl_PO") = "ไม่มีใบเบิก" Then
                        strDtlPO = ""
                    Else
                        strDtlPO = CStr(ds.Tables("prnDtl").Rows(c).Item("Dtl_PO"))
                    End If
                    'tempDisc


                    AnyString1(e.Graphics, strItem, 85, 440 + yy + offSetY, True) 'ลำดับ
                    AnyString1(e.Graphics, strStkName, 110, 440 + yy + offSetY, False) 'ชื่อสินค้า
                    AnyString1(e.Graphics, strQty, 500, 440 + yy + offSetY, True) 'จำนวน
                    AnyString1(e.Graphics, strPrice, 590, 440 + yy + offSetY, True) 'ราคา/หน่วย
                    AnyString1(e.Graphics, (strPriceDisc), 590 + 120, 440 + yy + offSetY, True) 'ราคาหลังลด

                    ' แบบเดิม
                    'AnyString1(e.Graphics, strItem, (85 + 10), 440 + yy, True) 'ลำดับ
                    'AnyString1(e.Graphics, strStkName, (135), 440 + yy, False) 'ชื่อสินค้า
                    'AnyString1(e.Graphics, strQty, (500 + 40), 440 + yy, True) 'จำนวน
                    'AnyString1(e.Graphics, strPrice, (590 + 55), 440 + yy, True) 'ราคา/หน่วย

                    If strDisc = "0" Or strDisc = "" Then
                        'strDisc = ""
                    Else
                        AnyString1(e.Graphics, "-" & strDisc, (625), 440 + yy + offSetY, True) 'ส่วนลด
                        'AnyString1(e.Graphics, "-" & strDisc, (640 + 40), 440 + yy, True) 'ส่วนลด
                    End If

                    AnyString1(e.Graphics, strSum, (730 + 65), 440 + yy + offSetY, True) 'ราคารวม
                    '   พิมพ์ เลขที่ PO ในรายการสินค้า 

                    If chkPrnPO = True Then
                        If strDtlPO = "" Then
                            AnyString1(e.Graphics, strDtlPO, 135, 460 + yy + offSetY, False) 'po
                        Else

                            AnyString1(e.Graphics, strDtlPO, 135, 460 + yy + offSetY, False) 'po
                        End If
                    Else
                        'AnyString1(e.Graphics, "", 135, 460 + yy) 'po
                    End If

                    '   พิมพ์ หมายเหตุ ในรายการสินค้า 
                    If strDtlDetail = "" Then


                    Else
                        If chkPrnPO = True And (Len(strDtlPO) > 0) Then
                            AnyString1(e.Graphics, strDtlDetail, (136 + (Len(strDtlPO) * 10) + 5), 460 + yy + offSetY, False) 'หมายเหตุย่อยต่อท้ายPO
                            yy = yy + 20
                        Else
                            AnyString1(e.Graphics, strDtlDetail, (136 + 5), 460 + yy + offSetY, False) 'หมายเหตุย่อยต่อท้ายPO
                            yy = yy + 20
                        End If

                    End If

                    If chkPrnPO = True Then
                        yy = yy + 40
                    Else
                        yy = yy + 20
                    End If
                End If
                strItemCount = strItemCount + 1
                '===========================================================================================
            Next

        End If
        If ds.Tables("prnDtl").Rows.Count <> strItemCount Then

            MsgBox("จำนวนรายการสินค้าอาจผิดพลาด ตรวจสอบอีกครั้ง !", MsgBoxStyle.Critical, "แจ้งเตือน")

        End If

        If chkVATtype(strTrhCus) = 0 Then
            AnyString1(e.Graphics, "======== จำนวนรายการสินค้าทั้งหมด " & ds.Tables("prnDtl").Rows.Count & " รายการ ========", (136 + 5), 450 + yy, False)

        Else
            'AnyString1(e.Graphics, "========  ========", (136 + 5), 450 + yy, False)

            AnyString1(e.Graphics, "========  จำนวนรายการสินค้าทั้งหมด " & ds.Tables("prnDtl").Rows.Count & " รายการ ========", (136 + 5), 450 + yy, False)

        End If

        If chkVAT = "N" Then
            ' MsgBox("Dvat=" & Dvat)
            AnyString1(e.Graphics, Dvat & "-ตัดสต๊อกคลังสินค้า " & " (" & "01" & ") ", 630, 920, False)  '  ปรับจาก 950 เดิมขึ้นอีก 30
            e.Graphics.DrawImage(newImage, 760, 60, width, height)
            AnyString1(e.Graphics, "PR" & strTime & "[" & GetUserName & "]", 630, 935, False)  '  ปรับจาก 950 เดิมขึ้นอีก 30

        Else
            'MsgBox("Dvat=" & Dvat)

            AnyString1(e.Graphics, Dvat & "-FM-FA-01 Rev.00 11/06/04  " & " (" & "01" & ") ", 600, 930 + offSetY, False)
            e.Graphics.DrawImage(newImage, 620, 20 + offSetY, width, height)
            AnyString1(e.Graphics, "PR" & strTime & "[" & GetUserName() & "]", 600, 945 + offSetY, False)  '  ปรับจาก 950 เดิมขึ้นอีก 30

        End If

        AnyString1(e.Graphics, strTrhNo, 680, 130 + offSetY, False) 'เลขที่บิล
        AnyString1(e.Graphics, strTrhDate, 680, 170 + offSetY, False) 'วันที่บิล
        AnyString1(e.Graphics, strArName, 130, 240 + offSetY, False) 'ชื่อร้าน
        AnyString1(e.Graphics, strArAddr, 130, 260 + offSetY, False) 'ที่อยู่
        AnyString1(e.Graphics, strArAddr1, 130, 280 + offSetY, False) 'ที่อยู่
        AnyString1(e.Graphics, strArAddr2, 130, 300 + offSetY, False) 'ที่อยู่
        AnyString1(e.Graphics, strArTaxID, 130, 320 + offSetY, False) 'ที่อยู่

        If strArShpVa = "" And strArShpVa1 = "" And strArShpVa2 = "" Then
            AnyString1(e.Graphics, strArAddr, 525, 260 + offSetY, False) 'ที่อยู่ส่งของ
            AnyString1(e.Graphics, strArAddr1, 525, 280 + offSetY, False) 'ที่อยู่
            AnyString1(e.Graphics, strArAddr2, 525, 300 + offSetY, False) 'ที่อยู่

        Else
            AnyString1(e.Graphics, strArShpVa, 525, 260 + offSetY, False) 'ขนส่ง
            AnyString1(e.Graphics, strArShpVa1, 525, 280 + offSetY, False) 'ที่อยู่
            AnyString1(e.Graphics, strArShpVa2, 525, 300 + offSetY, False) 'ที่อยู่
        End If

        AnyString1(e.Graphics, strArTerm, 150, 370 + offSetY, False) 'เครดิต
        AnyString1(e.Graphics, strDDay, 360, 370 + offSetY, False) 'due
        AnyString1(e.Graphics, strSLname, 680, 370 + offSetY, False) 'sale

        'If Microsoft.VisualBasic.Left(txtNo.Text, 1) = "V" Then 'แบบมีVat

        '  =====  เริ่มส่วนของ  ท้ายบิล   ที่เป็นยอดเงิน  
        If Len(strTrhDetail) > 0 Then
            AnyString1(e.Graphics, "หมายเหตุ :" & strTrhDetail, 135, 810, False)  '  ปรับจาก  840 -->  810
        End If
        If chkVATtype(strTrhCus) = 0 Then
            AnyString2(e.Graphics, stringTotal, 135, 860 + 20, False) 'thaibaht  ตัวอักษรจำนวน ภาษาไทย  ปรับขึ้นอีก  30 จาก  880 เป็น   850

        Else
            AnyString2(e.Graphics, "หมายเหตุ : คิดภาษีแบบรวมใน ", 135, 860, False)
            AnyString2(e.Graphics, stringTotal, 135, 860 + 20, False) 'thaibaht  ตัวอักษรจำนวน ภาษาไทย  ปรับขึ้นอีก  30 จาก  880 เป็น   850

        End If

        If chkVAT = "V" Or chkVAT = "v" Then
            If strArAcct = "112010" Then
                AnyString2(e.Graphics, strTrhTotal1, (730 + 65), 860, True)   ' ยอดเงินหลังหลักส่วนลด และ หักมัดจำ
                AnyString2(e.Graphics, StrTrhVat, (730 + 65), 880, True)     'ภาษี
                AnyString2(e.Graphics, StrTrhFullAmt, (730 + 65), 905, True) 'ยอดเงินรวม

                '=================================================================
            Else

                'ทศนิยม 4 ตำแหน่ง
                AnyString2(e.Graphics, strTrhTotal1, (730 + 65), 860, True)   ' ยอดเงินหลังหลักส่วนลด และ หักมัดจำ
                'AnyString2(e.Graphics, "0", (730 + 65), 880, True)     'ภาษี
                AnyString2(e.Graphics, strTrhTotal1, (730 + 65), 905, True)   'ยอดเงินรวม
                '=================================================================
                'AnyString2(e.Graphics, StrTrhAmt, (730 + 65), 860, True)   ' ยอดเงินหลังหลักส่วนลด และ หักมัดจำ
                'AnyString2(e.Graphics, "0", (730 + 65), 880, True)     'ภาษี
                'AnyString2(e.Graphics, StrTrhAmt, (730 + 65), 905, True)   'ยอดเงินรวม
                '=================================================================
            End If

            totalYY = 830
        Else
            'AnyString1(e.Graphics, strTrhTotal1, (730 + 65), 885, True) 'ยอดเงินรวม ปรับจาก 915 เป็น 885  
            AnyString2(e.Graphics, strTrhTotal1, (730 + 65), 890, True) 'ยอดเงินรวม ปรับจาก 915 เป็น 885  
            totalYY = 830
        End If

        If dblTrhDePoSit > 0 Then
            AnyString1(e.Graphics, "หักเงินมัดจำ " & strTrhDepoRef & ": ", 550, totalYY, False)
            'AnyString1(e.Graphics, str17, 135, 860) ' หมายเหตุที่ใสเลขที่มัดจำ
            AnyString2(e.Graphics, strTrhDeposit, (730 + 65), totalYY, True)
            totalYY = totalYY - 20

        End If

        If dblTrhDisc > 0 Then
            AnyString1(e.Graphics, "หักเงินส่วนลด" & " " & strTrhDiscPrn, 550, totalYY, False)
            AnyString2(e.Graphics, strTrhDisc, (730 + 65), totalYY, True)
            totalYY = totalYY - 20

        End If

        If dblTrhDisc > 0 Or dblTrhDePoSit > 0 Then

            AnyString1(e.Graphics, "ยอดรวม", 550, totalYY, False)  '815 
            AnyString2(e.Graphics, StrTrhAmt, (730 + 65), totalYY, True)  '815 
            totalYY = totalYY - 20

        End If

    


    End Sub

    Private Sub AnyString1(ByVal g As Graphics, ByVal printString As String, ByVal xPos As Integer, ByVal yPos As Integer, backToFont As Boolean)

        Dim anyPoint As New PointF(xPos, yPos)
        Dim lenString As Integer

        Dim point_X As Integer = xPos    '   ขยับตำแหน่ง X พิมพ์จาก หลังมาหน้า
        Dim point_y As Integer = yPos    '   ไม่ต้องยุ่ง  ใช้ตามเดิม  
        Dim strPrint As String

        Dim i As Integer = 0


        If backToFont = True Then
            lenString = Len(printString)     '   หาจำนวนตัวอักษร



            For i = 0 To lenString - 1

                point_X = xPos - (6 * (1 + i))
                anyPoint = New PointF(point_X, point_y)
                strPrint = Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Right(printString, i + 1), 1)

                g.DrawString(strPrint, UseFont1, Brushes.Black, anyPoint)

            Next
        Else

            g.DrawString(printString, UseFont1, Brushes.Black, anyPoint)
        End If

    End Sub
    Private Sub AnyString2(ByVal g As Graphics, ByVal printString As String, ByVal xPos As Integer, ByVal yPos As Integer, backToFont As Boolean)

        Dim anyPoint As New PointF(xPos, yPos)
        Dim lenString As Integer

        Dim point_X As Integer = xPos    '   ขยับตำแหน่ง X พิมพ์จาก หลังมาหน้า
        Dim point_y As Integer = yPos    '   ไม่ต้องยุ่ง  ใช้ตามเดิม  
        Dim strPrint As String

        Dim i As Integer = 0


        If backToFont = True Then
            lenString = Len(printString)     '   หาจำนวนตัวอักษร



            For i = 0 To lenString - 1

                point_X = xPos - (7.5 * (1 + i))
                anyPoint = New PointF(point_X, point_y)
                strPrint = Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Right(printString, i + 1), 1)

                g.DrawString(strPrint, UseFont2, Brushes.Black, anyPoint)

            Next
        Else

            g.DrawString(printString, UseFont2, Brushes.Black, anyPoint)
        End If

    End Sub

    Private Sub cmbPrint_Click(sender As Object, e As EventArgs) Handles cmbPrint.Click

        Call runPrint()
        Call DBtools.updatePrint(EditNo)
        'Me.Close()

    End Sub
End Class