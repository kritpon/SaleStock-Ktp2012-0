Module prTools

    Function chkPriceDiff(ByVal PrType As String, ByVal CusCode As String, ByVal stkCode As String, ByVal Pr_Q1 As Double) As Boolean

        Dim ans As Boolean = True
        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        Dim Pr_Q2 As Double = 0

        'DBtools.openDB()

        txtSQL = "Select * "
        txtSQL = txtSQL & "From ApPrice "
        txtSQL = txtSQL & "Where P_Type='" & PrType & "' "
        txtSQL = txtSQL & "And P_Cus_ID='" & CusCode & "' "
        txtSQL = txtSQL & "And P_Stk_CD='" & stkCode & "' "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "APchk")

        Pr_Q2 = subDS.Tables("APchk").Rows(0).Item("P_Pr_Q1_1")


        If Pr_Q1 = Pr_Q2 Then
            ans = False
        Else
            ans = True
        End If

        subDS = Nothing
        subDA = Nothing

        Return ans


    End Function

    Sub setPrice(ByVal Pr_Type As String, ByVal Cus_id As String, ByVal stkCode As String, ByVal p_pr_q1 As Double)
        'DBtools.openDB()

        If ChkPrice(Pr_Type, Cus_id, stkCode) = True Then

            If chkPriceDiff(Pr_Type, Cus_id, stkCode, p_pr_q1) = True Then  '  ถ้าราคา "ต่าง" ถึงจะ ทำ
                editPrice(Pr_Type, Cus_id, stkCode, p_pr_q1)
            End If

        Else
            addPrice(Pr_Type, Cus_id, stkCode, p_pr_q1)
        End If

        'DBtools.closeDB()
    End Sub

    Function ChkPrice(ByVal Pr_Type As String, ByVal Cus_id As String, ByVal stkCode As String) As Boolean

        Dim ans As Boolean = True
        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet

        'DBtools.openDB()

        txtSQL = "Select * "
        txtSQL = txtSQL & "From ApPrice "
        txtSQL = txtSQL & "Where P_Type='" & Pr_Type & "' "
        txtSQL = txtSQL & "And P_Cus_ID='" & Cus_id & "' "
        txtSQL = txtSQL & "And P_Stk_CD='" & stkCode & "' "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "APchk")

        If (subDS.Tables("APchk").Rows.Count > 0) Then
            ans = True
        Else
            ans = False

        End If

        subDS = Nothing
        subDA = Nothing

        ' DBtools.closeDB()

        Return ans

    End Function

    Sub editPrice(ByVal Pr_Type As String, ByVal Cus_id As String, ByVal stkCode As String, ByVal Pr_Q1 As Double)

        txtSQL = "Update ApPrice "
        txtSQL = txtSQL & "Set "
        '(((Month(  Now) & "/" & DateAndTime.Day( Now) & "/" & Year( Now) - 543)))
        txtSQL = txtSQL & "P_DD_Q1_1='" & (((Month(Now) & "/" & DateAndTime.Day(Now) & "/" & Year(Now) - 543))) & "', "
        txtSQL = txtSQL & "P_Pr_Q1_1=" & Pr_Q1 & " "

        txtSQL = txtSQL & "Where P_Type='" & Pr_Type & "' "
        txtSQL = txtSQL & "And  P_Cus_ID='" & Cus_id & "' "
        txtSQL = txtSQL & "And P_Stk_CD='" & stkCode & "' "

        DBtools.dbSaveDATA(txtSQL, "")


    End Sub

    Sub addPrice(ByVal Pr_Type As String, ByVal Cus_id As String, ByVal stkCode As String, ByVal Pr_Q1 As Double)

        txtSQL = "Insert Into ApPrice(P_Type,P_Cus_ID,P_Stk_CD,P_DD_Q1_1,P_Pr_Q1_1) "
        txtSQL = txtSQL & "Values('" & Pr_Type & "','" & Cus_id & "','" & stkCode & "','"
        '((Month( Now) & "-" & DateAndTime.Day( Now) & "-" & Year( Now) - 543))
        txtSQL = txtSQL & ((Month(Now) & "-" & DateAndTime.Day(Now) & "-" & Year(Now) - 543))
        txtSQL = txtSQL & "'," & Pr_Q1 & ") "

        DBtools.dbSaveDATA(txtSQL, "")


    End Sub

    Sub delPrice(ByVal Pr_Type As String, ByVal Cus_id As String, ByVal stkCode As String, ByVal Pr_Q1 As Double)

    End Sub

    Function getPrice(ByVal Pr_Type As String, ByVal Cus_id As String, ByVal stkCode As String) As Double
        Dim ans As Double = 0
        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet

        txtSQL = "Select * "
        txtSQL = txtSQL & "From ApPrice "
        txtSQL = txtSQL & "Where P_Type='" & Pr_Type & "' "
        txtSQL = txtSQL & "And P_Cus_ID='" & Cus_id & "' "
        txtSQL = txtSQL & "And P_Stk_CD='" & stkCode & "' "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "APchk")

        If ChkPrice(Pr_Type, Cus_id, stkCode) = True Then

            ans = subDS.Tables("APchk").Rows(0).Item("P_Pr_Q1_1")

        Else
            ans = 0

        End If

        subDS = Nothing
        subDA = Nothing
        Return ans

    End Function

End Module
