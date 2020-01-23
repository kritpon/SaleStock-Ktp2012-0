Public Class frmEditNo
   

    Dim DS As DataSet = New DataSet
    Dim DA As SqlClient.SqlDataAdapter
    Dim chkID As Boolean = False

    Dim strDocNO As String = ""
    Dim F_Date As Date

    Dim chkClick0 As Boolean

    Function AutoGenerateID(ByVal V_Type As String, Fdate As Date) As String


        Dim oldmonth As Integer 'String = ""
        Dim newmonth As Integer 'String = ""

        Dim runId As String = ""
        Dim showMonth As String = ""
        Dim idmonth As String = ""

        Dim Years0 As Integer
        Dim Month0 As Integer

        Dim strYear As String = ""
        Dim strMonth As String = ""

        Dim docNo As String = ""

        'Dim idcon As String
        'Dim test As String
        'Dim ID As String

        'years = Microsoft.VisualBasic.Right(CStr(Year(F_Date)), 2)
        Years0 = Year(Fdate) - 543
        Month0 = Month(Fdate)



        '**********************************************ของใหม่บิลเลขที่เกิน1000**********************************************
        'Try
        If CStr(V_Type) = "V" Or CStr(V_Type) = "P" Or CStr(V_Type) = "B" Or CStr(V_Type) = "Y" Then

            V_Type = "V"

            'txtSQL = "SELECT  top 1  Max(Trh_RunID) AS maxno, Trh_No "
            'txtSQL = txtSQL & "FROM  TranDataH "

            'txtSQL = txtSQL & "WHERE (Trh_Type='S') "
            'txtSQL = txtSQL & "And left(trh_no,3)='V" & years & "' "
            ''  ตัดเดือน และ เอาเข้า SQL เลือกออกมา
            'txtSQL = txtSQL & "AND RIGHT(LEFT(Trh_No, 5), 2) = '" & Format(Month(F_Date), "0#") & "' "

            'txtSQL = txtSQL & "GROUP BY Trh_No "
            'txtSQL = txtSQL & "ORDER BY Max(Trh_runid) DESC "
            'txtSQL = txtSQL & " "

            txtSQL = "Select top 1 Max(Trh_RunID) as maxNo ,Trh_No,Trh_Date "
            txtSQL = txtSQL & "From TranDatah "

            txtSQL = txtSQL & "Where Trh_Type='S' "
            txtSQL = txtSQL & "And left(Trh_No,1)='V' "
            txtSQL = txtSQL & "And year(Trh_Date)=" & Years0 & " "
            txtSQL = txtSQL & "And month(Trh_Date)=" & Month0 & ""

            txtSQL = txtSQL & "Group by Trh_No ,Trh_Date "
            txtSQL = txtSQL & "ORDER BY Max(Trh_runid) DESC "


        ElseIf CStr(V_Type) = "N" Or CStr(V_Type) = "M" Or CStr(V_Type) = "X" Or CStr(V_Type) = "Z" Then

            V_Type = "N"

            'txtSQL = "SELECT   top 1 Max(Trh_RunID) AS maxno, Trh_No "
            'txtSQL = txtSQL & "FROM   TranDataH "
            'txtSQL = txtSQL & "WHERE     (Trh_Type = 'S') and left(trh_no,3)='N" & years & "' "
            'txtSQL = txtSQL & "AND RIGHT(LEFT(Trh_No, 5), 2) =  '" & Format(Month(F_Date), "0#") & "' "

            'txtSQL = txtSQL & "GROUP BY Trh_No "
            'txtSQL = txtSQL & "ORDER BY Max(Trh_runid) DESC "
            'txtSQL = txtSQL & " "


            txtSQL = "Select top 1 Max(Trh_RunID) as maxNo ,Trh_No ,Trh_Date "
            txtSQL = txtSQL & "From TranDatah "

            txtSQL = txtSQL & "Where Trh_Type='S' "
            txtSQL = txtSQL & "And left(Trh_No,1)='N' "
            txtSQL = txtSQL & "And year(Trh_Date)=" & Years0 & " "
            txtSQL = txtSQL & "And month(Trh_Date)=" & Month0 & " "

            txtSQL = txtSQL & "Group by Trh_No ,Trh_Date "
            txtSQL = txtSQL & "ORDER BY Max(Trh_runid) DESC "
            txtSQL = txtSQL & " "

        End If

        If chkID = True Then
            chkID = False
            DS.Tables("ID").Clear()
        End If

        DA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        DA.Fill(DS, "ID")
        chkID = True

        If DS.Tables("ID").Rows.Count > 0 Then
            'จะได้เดือนของเอกสารใบสุดท้าย
            'oldmonth = CStr(Val(Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(CStr(DS.Tables("ID").Rows(0).Item("trh_no")), 5), 2)))
            oldmonth = CStr(Month(DS.Tables("ID").Rows(0).Item("trh_Date")))
            ' เดือนปัจจุบัน
            newmonth = CStr(Month(Fdate))

            If oldmonth = newmonth Then

                If IsDBNull(DS.Tables("ID").Rows(0).Item("maxNo")) Then
                    'test = DS.Tables("ID").Rows(0).Item("trh_no")
                    Num = 0
                Else
                    Num = DS.Tables("ID").Rows(0).Item("maxNo")
                End If

                Num = Num + 1

                trh_RunID = Num

                'If Len(CStr(Num)) = 1 Then
                '    runId = "0000" & CStr(Num)
                'ElseIf Len(CStr(Num)) = 2 Then
                '    runId = "000" & CStr(Num)
                'ElseIf Len(CStr(Num)) = 3 Then
                '    runId = "00" & CStr(Num)
                '    'runId = CStr(Num)
                'ElseIf Len(CStr(Num)) = 4 Then
                '    runId = "0" & CStr(Num)
                '    'runId = CStr(Num)
                'ElseIf Len(CStr(Num)) = 5 Then
                '    runId = CStr(Num)
                'Else
                '    runId = ""
                'End If

                If Len(CStr(Num)) = 1 Then
                    runId = "000" & CStr(Num)
                ElseIf Len(CStr(Num)) = 2 Then
                    runId = "00" & CStr(Num)
                ElseIf Len(CStr(Num)) = 3 Then
                    runId = "0" & CStr(Num)
                    'runId = CStr(Num)

                ElseIf Len(CStr(Num)) = 4 Then
                    runId = CStr(Num)
                Else
                    runId = ""
                End If

            Else
                runId = "0001"
            End If

            showMonth = CStr(Month(Fdate))

            If CDbl(showMonth) < 10 Then
                idmonth = "0" & showMonth
            Else
                idmonth = showMonth
            End If

            strYear = Microsoft.VisualBasic.Right(Format(Fdate, "dd/MM/yyyy"), 2)

            If CStr(V_Type) = "V" Or CStr(V_Type) = "P" Or CStr(V_Type) = "B" Then
                'docNo = "V" & years & idmonth & "/" & runId
                docNo = "V" & strYear & idmonth & runId    '  แบบไม่มี "/"
            Else
                'docNo = "N" & years & idmonth & "/" & runId
                docNo = "N" & strYear & idmonth & runId    '  แบบไม่มี "/"

            End If
        Else 'เดือนใหม่

            showMonth = CStr(Month(Fdate))

            Num = 1
            If CDbl(showMonth) < 10 Then
                idmonth = "0" & showMonth
            Else
                idmonth = showMonth
            End If

            'Years0 = Microsoft.VisualBasic.Right(Format(Fdate, "dd/MM/yyyy"), 2)
            'docNo = CStr(V_Type) & years & "/" & idmonth & "00001"   '   แบบมี  "/"
            'docNo = CStr(V_Type) & strYear & idmonth & "0001"   '   แบบไม่มี  "/"

            '========================================
            strYear = Microsoft.VisualBasic.Right(Format(Fdate, "dd/MM/yyyy"), 2)

            If CStr(V_Type) = "V" Or CStr(V_Type) = "P" Or CStr(V_Type) = "B" Then
                'docNo = "V" & years & idmonth & "/" & runId
                docNo = "V" & strYear & idmonth & "0001"     '  แบบไม่มี "/"
            Else
                'docNo = "N" & years & idmonth & "/" & runId
                docNo = "N" & strYear & idmonth & "0001"    '  แบบไม่มี "/"

            End If

        End If

        Return docNo

        'If CStr(V_Type) = "P" Then
        '    dtp01.Enabled = True
        'Else
        '    dtp01.Enabled = False
        'End If

        'Catch errprocess As Exception
        '    MessageBox.Show("กรุณาเลือกประเภทเอกสาร" & errprocess.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return ""
        '    Exit Function
        'End Try

    End Function


    Private Sub frmEditNo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbTimer1.Text = 0

        F_Date = SelectDate
        EditNo = (AutoGenerateID(Dvat, Format(F_Date, "dd/MM/yyyy")))
        txtDocID.Text = (EditNo)
        Timer1.Enabled = True

    End Sub

   
    'Private Sub cmbKO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKO.Click

    '    chkClick0 = True
    '    Call chkClick()


    'End Sub

    Sub chkClick()

        If chkClick0 = True Then

            Call selectOK()
            Me.Close()

        ElseIf chkClick0 = False Then

            Me.Close()

        End If

    End Sub

    Function selectOK() As String

        EditNo = txtDocID.Text
        Return EditNo

    End Function

  
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        lbTimer1.Text = lbTimer1.Text + 1
        If lbTimer1.Text = 1 Then
            Call selectOK()
            Me.Hide()
        End If

    End Sub

  
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub cmbKO_Click(sender As Object, e As EventArgs) Handles cmbKO.Click

    End Sub
End Class