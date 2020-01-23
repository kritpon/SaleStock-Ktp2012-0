Imports System.Data.SqlClient

Module stkTools
    
    Sub openDB()
        strConn = strConn
        With Conn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = strConn
            .Open()
        End With

    End Sub


    Sub closeDB()
        Conn.Close()
    End Sub


    Sub updateStock(ByVal CusID As String, ByVal whCode As String, ByVal StkCode As String, ByVal OrderQ1 As Double, ByVal RcvQ1 As Double, ByVal IssQ1 As Double, ByVal PenDingUpdate As Boolean)


        Dim subDA3 As New SqlClient.SqlDataAdapter
        Dim subDS3 As New DataSet

        Dim wStk As Double = DBtools.getStkWight(StkCode)

        Dim Dtl_Bal_q2 As Double = 0
        Dim Dtl_Bal_q1 As Double = 0
        Dim Dtl_LS_Q1 As Double = 0
        Dim Dtl_LS_Q2 As Double = 0



        txtSQL = "Select * From StkDetl "
        txtSQL = txtSQL & "Where Dtl_Code='" & StkCode & "' "
        txtSQL = txtSQL & "And  Dtl_Store='" & CusID & "' "
        txtSQL = txtSQL & "And Dtl_Wh='" & whCode & "'"

        subDA3 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA3.Fill(subDS3, "chkStk")


        If subDS3.Tables("chkStk").Rows.Count > 0 Then
            With subDS3.Tables("chkStk").Rows(0)

                If IsDBNull(.Item("Dtl_Bal_q1")) Then
                    Dtl_Bal_q1 = 0
                Else
                    Dtl_Bal_q1 = .Item("Dtl_Bal_q1")
                End If
                If IsDBNull(.Item("Dtl_Bal_q2")) Then
                    Dtl_Bal_q2 = 0
                Else
                    Dtl_Bal_q2 = .Item("Dtl_Bal_q2")
                End If

                If IsDBNull(.Item("Dtl_LS_Q1")) Then
                    Dtl_LS_Q1 = 0
                Else
                    Dtl_LS_Q1 = .Item("Dtl_LS_Q1")
                End If
                If IsDBNull(.Item("Dtl_LS_Q2")) Then
                    Dtl_LS_Q2 = 0
                Else
                    Dtl_LS_Q2 = .Item("Dtl_LS_Q2")
                End If

                txtSQL = "Update StkDetl Set "
                If IsDBNull(.Item("Dtl_Or_Q1")) Then
                    txtSQL = txtSQL & "Dtl_Or_Q1=" & ((0 + OrderQ1)) & ","
                Else
                    txtSQL = txtSQL & "Dtl_Or_Q1=" & ((.Item("Dtl_Or_Q1") + OrderQ1)) & ","
                End If

                If IsDBNull(.Item("Dtl_Or_Q2")) Then
                    txtSQL = txtSQL & "Dtl_Or_Q2=" & ((0 + (OrderQ1 * wStk))) & ","
                Else
                    txtSQL = txtSQL & "Dtl_Or_Q2=" & ((.Item("Dtl_Or_Q2") + (OrderQ1 * wStk))) & ","
                End If

                If IsDBNull(.Item("Dtl_Rcv_Q2")) Then
                    txtSQL = txtSQL & "Dtl_Rcv_Q1=" & ((0 + RcvQ1)) & ","
                Else
                    txtSQL = txtSQL & "Dtl_Rcv_Q1=" & ((.Item("Dtl_Rcv_Q2") + RcvQ1)) & ","
                End If

                If IsDBNull(.Item("Dtl_Rcv_Q2")) Then
                    txtSQL = txtSQL & "Dtl_Rcv_Q2=" & ((0 + (RcvQ1 * wStk))) & ","
                Else
                    txtSQL = txtSQL & "Dtl_Rcv_Q2=" & ((.Item("Dtl_Rcv_Q2") + (RcvQ1 * wStk))) & ","
                End If

                If IsDBNull(.Item("Dtl_iss_Q1")) Then
                    txtSQL = txtSQL & "Dtl_iSS_Q1=" & ((0 + IssQ1)) & ","
                Else
                    txtSQL = txtSQL & "Dtl_iSS_Q1=" & ((.Item("Dtl_iss_Q1") + IssQ1)) & ","
                End If

                If IsDBNull(.Item("Dtl_iss_Q2")) Then
                    txtSQL = txtSQL & "Dtl_iSS_Q2=" & ((0 + (IssQ1 * wStk))) & ","
                Else
                    txtSQL = txtSQL & "Dtl_iSS_Q2=" & ((.Item("Dtl_iss_Q2") + (IssQ1 * wStk))) & ","
                End If

                If ((Dtl_LS_Q1 + Dtl_Bal_q1 + RcvQ1) - IssQ1) > 0 Then
                    txtSQL = txtSQL & "Dtl_LS_Q1=0" & ","
                    txtSQL = txtSQL & "Dtl_LS_Q2=0" & ","
                    txtSQL = txtSQL & "Dtl_Bal_Q1=" & (Dtl_LS_Q1 + Dtl_Bal_q1 + RcvQ1) - IssQ1 & ","
                    txtSQL = txtSQL & "Dtl_Bal_Q2=" & (((Dtl_LS_Q2 + Dtl_Bal_q2 + RcvQ1) - IssQ1) * wStk) & " "
                Else
                    txtSQL = txtSQL & "Dtl_LS_Q1=" & (((.Item("Dtl_LS_Q1") + .Item("Dtl_Bal_q1") + RcvQ1) - IssQ1) * -1) & ","
                    txtSQL = txtSQL & "Dtl_LS_Q2=0" & (((.Item("Dtl_LS_Q1") + .Item("Dtl_Bal_q1") + RcvQ1) - IssQ1) * -1) * wStk & ","
                    txtSQL = txtSQL & "Dtl_Bal_Q1=" & ((.Item("Dtl_LS_Q1") + .Item("Dtl_Bal_q1") + RcvQ1) - IssQ1) * -1 & ","
                    txtSQL = txtSQL & "Dtl_Bal_Q2=" & ((((.Item("Dtl_LS_Q2") + .Item("Dtl_Bal_q2") + RcvQ1) - IssQ1)) * wStk) * -1 & " "
                End If

                If PenDingUpdate = True Then
                    txtSQL = txtSQL & ",Dtl_Pen_Q1=" & ((getPending(CusID, StkCode) + OrderQ1) - IssQ1) & ","
                    txtSQL = txtSQL & "Dtl_Pen_Q2=" & (((getPending(CusID, StkCode) + OrderQ1) - IssQ1) * wStk) & " "
                End If
                txtSQL = txtSQL & "Where Dtl_Store='" & CusID & "' "
                txtSQL = txtSQL & "And Dtl_Code='" & StkCode & "' "
                txtSQL = txtSQL & "And Dtl_Wh='" & whCode & "' "

            End With

        Else
            txtSQL = "Insert Into StkDetl "
            txtSQL = txtSQL & "("
            txtSQL = txtSQL & "Dtl_Wh,Dtl_Store,Dtl_Code,"

            txtSQL = txtSQL & "Dtl_Or_Q1,Dtl_Or_Q2,"    ' จอง
            txtSQL = txtSQL & "Dtl_Rcv_Q1,Dtl_Rcv_Q2,"  ' ผลิต
            txtSQL = txtSQL & "Dtl_ISS_Q1,Dtl_ISS_Q2,"  ' ขาย

            txtSQL = txtSQL & "Dtl_LS_Q1,Dtl_LS_Q2, "   ' ยกมา
            txtSQL = txtSQL & "Dtl_Bal_Q1,Dtl_Bal_Q2,"

            txtSQL = txtSQL & "Dtl_Pen_Q1,Dtl_Pen_Q2 "
            txtSQL = txtSQL & ")"
            txtSQL = txtSQL & " Values"
            txtSQL = txtSQL & "('" & whCode & "',"
            txtSQL = txtSQL & "'" & CusID & "','" & StkCode & "',"

            txtSQL = txtSQL & (OrderQ1) & "," & (((OrderQ1 * wStk))) & ","   '  จอง
            txtSQL = txtSQL & (RcvQ1) & "," & (RcvQ1 * wStk) & ","   '  ผลิต
            txtSQL = txtSQL & (IssQ1) & "," & (IssQ1 * wStk) & ","   '  ขาย

            If (RcvQ1 - IssQ1) < 0 Then
                txtSQL = txtSQL & (RcvQ1 - IssQ1) * -1 & "," & ((RcvQ1 - IssQ1) * -1) * wStk & ","  '  ยกมา
                txtSQL = txtSQL & 0 & "," & 0 & ","     '  Stock
            Else
                txtSQL = txtSQL & 0 & "," & 0 & ","  '  ยกมา
                txtSQL = txtSQL & (RcvQ1 - IssQ1) & "," & ((RcvQ1 - IssQ1) * wStk) & ","     '  Stock
            End If
            txtSQL = txtSQL & ((getPending(CusID, StkCode) + OrderQ1) - IssQ1) & "," 'pen_q1
            txtSQL = txtSQL & (((getPending(CusID, StkCode) + OrderQ1) - IssQ1) * wStk) & " "  '  pen

            txtSQL = txtSQL & ")"

        End If
        Call DBtools.dbSaveDATA(txtSQL, StkCode)
        subDS3 = Nothing
        subDA3 = Nothing

    End Sub

    Sub updateStkdetl(ByVal dtlType As String, ByVal dtlStr As String, ByVal dtlWH As String, ByVal dtlCode As String, ByVal dtlQty As Integer)

        Dim f As String = ""
        'Dim stkCode As String = "010103001230184000001011"
        Dim subDaZ As SqlClient.SqlDataAdapter
        Dim subDsZ As DataSet = New DataSet
        Dim iLoop As Integer = 0
        'Dim strcode As String = "110098"
        'f = dbTools.chkDtlFlag(stkcode, strcode)
        DBtools.openDB()
        txtSQL = "Select * from StkDetl "
        txtSQL = txtSQL & "where Dtl_Code='" & dtlCode & "' "
        txtSQL = txtSQL & "And Dtl_Store='" & dtlStr & "' "
        txtSQL = txtSQL & "And Dtl_Wh='" & dtlWH & "' "

        subDaZ = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDaZ.Fill(subDsZ, "DtlSet")

        Dim issQ1 As Integer = subDsZ.Tables("DtlSet").Rows(iLoop).Item("Dtl_iSS_Q1")
        Dim rcvQ1 As Integer = subDsZ.Tables("DtlSet").Rows(iLoop).Item("Dtl_RCV_Q1")
        Dim lsQ1 As Integer = subDsZ.Tables("DtlSet").Rows(iLoop).Item("Dtl_LS_Q1")
        Dim orQ1 As Integer = subDsZ.Tables("DtlSet").Rows(iLoop).Item("Dtl_Or_Q1")
        Dim balQ1 As Integer = subDsZ.Tables("DtlSet").Rows(iLoop).Item("Dtl_Bal_Q1")
        Dim penQ1 As Integer = subDsZ.Tables("DtlSet").Rows(iLoop).Item("Dtl_Pen_Q1")


        If subDsZ.Tables("DtlSet").Rows.Count > 0 Then

            txtSQL = "Update StkDetl Set "
            Select Case dtlType
                Case "S"
                    txtSQL = txtSQL & "Dtl_iss_Q1=" & issQ1 + dtlQty & " "
                    txtSQL = txtSQL & "Dtl_Pen_Q1=" & orQ1 + dtlQty - issQ1 & " "
                    txtSQL = txtSQL & "Dtl_Bal_Q1=" & lsQ1 + rcvQ1 - issQ1 - dtlQty & " "
                Case "D"
                    txtSQL = txtSQL & "Dtl_RCV_Q1=" & rcvQ1 + dtlQty & " "
                    txtSQL = txtSQL & "Dtl_Bal_Q1=" & lsQ1 + rcvQ1 - issQ1 + dtlQty & " "
                Case "G"
                    txtSQL = txtSQL & "Dtl_RCV_Q1=" & rcvQ1 + dtlQty & " "
                    txtSQL = txtSQL & "Dtl_Bal_Q1=" & lsQ1 + rcvQ1 - issQ1 + dtlQty & " "
                Case "B"
                    txtSQL = txtSQL & "Dtl_Or_Q1=" & orQ1 + dtlQty & " "
                    txtSQL = txtSQL & "Dtl_Pen_Q1=" & orQ1 + dtlQty - issQ1 & " "
                Case "F"
                    txtSQL = txtSQL & "Dtl_RCV_Q1=" & rcvQ1 + dtlQty & " "
                    txtSQL = txtSQL & "Dtl_Bal_Q1=" & lsQ1 + rcvQ1 - issQ1 + dtlQty & " "
                Case "Z"
                    txtSQL = txtSQL & "Dtl_iss_Q1=" & issQ1 + dtlQty & " "
                    txtSQL = txtSQL & "Dtl_Bal_Q1=" & lsQ1 + rcvQ1 - issQ1 - dtlQty & " "

            End Select

            txtSQL = txtSQL & "Where Dtl_Store='" & dtlStr & "' "
            txtSQL = txtSQL & "And Dtl_Code='" & dtlCode & "' "
            txtSQL = txtSQL & "And Dtl_Wh='" & dtlWH & "' "

            DBtools.dbSaveDATA(txtSQL, dtlCode)
        End If


    End Sub
    Function getPending(ByVal cusCode As String, ByVal stkCode As String) As Double

        Dim ans As Double

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet

        If Trim(stkCode) = "" Or Trim(cusCode) = "" Then
            subDS = Nothing
            subDA = Nothing
            Return False
        Else
            txtSQL = "Select Dtl_idCus,Dtl_idTrade,sum(Dtl_Num-Dtl_Num_2)as penDing "
            txtSQL = txtSQL & "From TranDataD "

            txtSQL = txtSQL & "Where Dtl_idCus='" & cusCode & "'"
            txtSQL = txtSQL & "And Dtl_idTrade='" & stkCode & "'"
            txtSQL = txtSQL & "And Dtl_Type='B' "
            txtSQL = txtSQL & "Group by Dtl_idCus,Dtl_idTrade "

            subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA.Fill(subDS, "PendingTB")
            If subDS.Tables("PendingTB").Rows.Count > 0 Then
                ans = subDS.Tables("PendingTB").Rows(0).Item("penDing")
                Return ans
            Else
                subDS = Nothing
                subDA = Nothing
                Return 0
            End If

        End If
    End Function

End Module
