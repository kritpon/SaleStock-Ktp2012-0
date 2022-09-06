Public Class frmAnswers
    Private Sub cmbCancel_Click(sender As Object, e As EventArgs) Handles cmbCancel.Click

        chkUserUpdate = False

        Me.Close()
    End Sub

    Private Sub frmAnswers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkUserUpdate = True

        lbUser.Text = GetUserName()
        lbComName.Text = GetComputerName()
        lbUserID.Text = getUserID(lbComName.Text)
    End Sub

    Private Sub cmbSave_Click(sender As Object, e As EventArgs) Handles cmbSave.Click
        If txtDetail.Text = "" Then
            MsgBox("ข้อมูลไม่ถูกต้อง ระบุสาเหตุอีกครั้ง ", MsgBoxStyle.Critical, "แจ้งเตือน")
            Exit Sub

        End If
        '(((DateAndTime.Day(Now) & Month(Now) & Year(Now) - 543))).ToString 
        txtSQL = "Insert Into userHistoryUpdate "
        txtSQL = txtSQL & "Values('" & Format(DateAdd(DateInterval.Year, -543, Now), "MM/dd/yyyy HH:mm:ss") & "','S','" & EditNo & "','" & lbUser.Text & "','" & txtDetail.Text & "')"
        DBtools.dbSaveDATA(txtSQL, "")
        chkUserUpdate = True
        Me.Close()

    End Sub
End Class