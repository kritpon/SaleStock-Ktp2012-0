Public Class frmConnectDB

    Dim fileName As String

    Private Sub frmConnectDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSetting() 'ของพี่กวางที่เรียก config.ini

        lbDBconnect.Text = strConn
        'lbFileName.Text = _Directory
        lbTimer1.Text = 0
        Timer1.Enabled = True

    End Sub

    Private Sub cboDBlist_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try
            '  strConn = cboDBlist.SelectedValue ' DBConnString.strConn2
            lbDBconnect.Text = strConn
        Catch ex As Exception

        End Try

    End Sub
    Sub RunDB()
        Dim frmBegin As New frmBegin

        DBtools.openDB()
        With Conn
            If .State = ConnectionState.Open Then
                Me.Hide()
                frmBegin.Show()

                'Else
                '    MsgBox("ไม่สามารถติดต่อฐานข้อมูลได้")
            End If

        End With

    End Sub
    Private Sub cmdConnect_Click(sender As Object, e As EventArgs) Handles cmdConnect.Click

        Call RunDB()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lbTimer1.Text = lbTimer1.Text + 1
        If lbTimer1.Text = 1 Then
            'Call selectOK()
            If Conn.State = ConnectionState.Closed Then
                Call RunDB()
            End If
            If Conn.State = ConnectionState.Open Then
                Me.Hide()
            Else
                MsgBox("ไม่สามารถติดต่อ Server ได้")
            End If

        End If

    End Sub
    Sub getFileName()

        'monthSel = Format(Month(Now), "00")
        'yearSel = Year(Now) - 543
        'ExcelName = "แผนผลิต" & monthSel & "-" & yearSel & ".xlsm"
        'ExcelName2 = "แผนผลิตเล็ก" & monthSel & "-" & yearSel & ".xlsm"
        'ExcelName3 = "รายงานติดกระดาษ(" & monthSel & "-" & Mid((yearSel + 543), 3, 2) & ").xlsm"
        'DBtools.DBConnection()
        'MsgBox(ExcelName)
        'lbDataBase.Text = strConn
        'Format(Month(Now), "00")

        fileName = "\\192.168.1.5\Config\config.ini"
        lbFileName.Text = fileName


    End Sub
    Private Sub cmbOpenFile_Click(sender As Object, e As EventArgs) Handles cmbOpenFile.Click
        'CurDir() & 
        openFile01.FileName = fileName
        openFile01.InitialDirectory = fileName
        openFile01.ShowDialog()

        lbFileName.Text = openFile01.FileName
        '_Directory = lbFileName.Text
        '_ini = New Setting.IniFile(lbFileName.Text)
        'strConn = _ini.ReadValue("SetSystem", "svParthDataSource")

        lbDBconnect.Text = strConn

        RunDB()

    End Sub


End Class