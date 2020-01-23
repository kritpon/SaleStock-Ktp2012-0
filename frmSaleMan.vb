Public Class frmSaleMan
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grdSaleMan As System.Windows.Forms.DataGrid
    Friend WithEvents txtSaleID As System.Windows.Forms.TextBox
    Friend WithEvents txtSaleName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbExit As System.Windows.Forms.Button
    Friend WithEvents cmbDel As System.Windows.Forms.Button
    Friend WithEvents cmbSave As System.Windows.Forms.Button
    Friend WithEvents cmbSelect As System.Windows.Forms.Button
    Friend WithEvents cmbgrp As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbSelect = New System.Windows.Forms.Button
        Me.txtSaleID = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSaleName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbgrp = New System.Windows.Forms.ComboBox
        Me.grdSaleMan = New System.Windows.Forms.DataGrid
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbExit = New System.Windows.Forms.Button
        Me.cmbDel = New System.Windows.Forms.Button
        Me.cmbSave = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdSaleMan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbSelect)
        Me.GroupBox1.Controls.Add(Me.txtSaleID)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtSaleName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbgrp)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 48)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'cmbSelect
        '
        Me.cmbSelect.BackColor = System.Drawing.Color.LightSkyBlue
        Me.cmbSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbSelect.ForeColor = System.Drawing.Color.Navy
        Me.cmbSelect.Location = New System.Drawing.Point(432, 16)
        Me.cmbSelect.Name = "cmbSelect"
        Me.cmbSelect.Size = New System.Drawing.Size(48, 24)
        Me.cmbSelect.TabIndex = 25
        Me.cmbSelect.Text = "Select"
        Me.cmbSelect.UseVisualStyleBackColor = False
        '
        'txtSaleID
        '
        Me.txtSaleID.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txtSaleID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaleID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSaleID.ForeColor = System.Drawing.Color.Navy
        Me.txtSaleID.Location = New System.Drawing.Point(144, 16)
        Me.txtSaleID.MaxLength = 4
        Me.txtSaleID.Name = "txtSaleID"
        Me.txtSaleID.Size = New System.Drawing.Size(40, 21)
        Me.txtSaleID.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(112, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "รหัส"
        '
        'txtSaleName
        '
        Me.txtSaleName.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txtSaleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSaleName.ForeColor = System.Drawing.Color.Navy
        Me.txtSaleName.Location = New System.Drawing.Point(256, 16)
        Me.txtSaleName.MaxLength = 60
        Me.txtSaleName.Name = "txtSaleName"
        Me.txtSaleName.Size = New System.Drawing.Size(168, 21)
        Me.txtSaleName.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(-76, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "รหัส Group"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ชื่อพนักงานขาย"
        '
        'cmbgrp
        '
        Me.cmbgrp.BackColor = System.Drawing.Color.LightSkyBlue
        Me.cmbgrp.Location = New System.Drawing.Point(8, 16)
        Me.cmbgrp.Name = "cmbgrp"
        Me.cmbgrp.Size = New System.Drawing.Size(96, 21)
        Me.cmbgrp.TabIndex = 20
        '
        'grdSaleMan
        '
        Me.grdSaleMan.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.grdSaleMan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.grdSaleMan.CaptionBackColor = System.Drawing.Color.LightSkyBlue
        Me.grdSaleMan.CaptionForeColor = System.Drawing.Color.Navy
        Me.grdSaleMan.CaptionText = "รายละเอียด"
        Me.grdSaleMan.DataMember = ""
        Me.grdSaleMan.ForeColor = System.Drawing.Color.Navy
        Me.grdSaleMan.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdSaleMan.Location = New System.Drawing.Point(16, 2)
        Me.grdSaleMan.Name = "grdSaleMan"
        Me.grdSaleMan.ReadOnly = True
        Me.grdSaleMan.Size = New System.Drawing.Size(488, 174)
        Me.grdSaleMan.TabIndex = 17
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbExit)
        Me.GroupBox2.Controls.Add(Me.cmbDel)
        Me.GroupBox2.Controls.Add(Me.cmbSave)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 224)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(488, 59)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'cmbExit
        '
        Me.cmbExit.BackColor = System.Drawing.Color.LightSkyBlue
        Me.cmbExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbExit.ForeColor = System.Drawing.Color.Navy
        Me.cmbExit.Location = New System.Drawing.Point(400, 16)
        Me.cmbExit.Name = "cmbExit"
        Me.cmbExit.Size = New System.Drawing.Size(80, 24)
        Me.cmbExit.TabIndex = 22
        Me.cmbExit.Text = "Exit"
        Me.cmbExit.UseVisualStyleBackColor = False
        '
        'cmbDel
        '
        Me.cmbDel.BackColor = System.Drawing.Color.LightSkyBlue
        Me.cmbDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbDel.ForeColor = System.Drawing.Color.Navy
        Me.cmbDel.Location = New System.Drawing.Point(104, 16)
        Me.cmbDel.Name = "cmbDel"
        Me.cmbDel.Size = New System.Drawing.Size(80, 24)
        Me.cmbDel.TabIndex = 25
        Me.cmbDel.Text = "Delete"
        Me.cmbDel.UseVisualStyleBackColor = False
        '
        'cmbSave
        '
        Me.cmbSave.BackColor = System.Drawing.Color.LightSkyBlue
        Me.cmbSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbSave.ForeColor = System.Drawing.Color.Navy
        Me.cmbSave.Location = New System.Drawing.Point(10, 16)
        Me.cmbSave.Name = "cmbSave"
        Me.cmbSave.Size = New System.Drawing.Size(80, 24)
        Me.cmbSave.TabIndex = 23
        Me.cmbSave.Text = "Save"
        Me.cmbSave.UseVisualStyleBackColor = False
        '
        'frmSaleMan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(512, 295)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grdSaleMan)
        Me.Name = "frmSaleMan"
        Me.Text = "frmSaleMan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdSaleMan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim subDS As New DataSet()
    Dim subDA As SqlClient.SqlDataAdapter
    Dim chkSaleMan As Boolean

    Private Sub frmSaleMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtSQL = "Select * "
        txtSQL = txtSQL & "From SalesMan "
        txtSQL = txtSQL & "order by sl_id"

       
        Call ShowData()
        Call addgroupsale()

    End Sub

    Sub ShowData()

        '  txtSQL = "Select *  "
        ' txtSQL = txtSQL & "From SalesMan "
        'txtSQL = txtSQL & "Order by Sl_ID "

        txtSQL = " SELECT salesman.SL_ID, salesman.SL_NAME,salesman.SL_Acct, "
        txtSQL = txtSQL & " GrpSales.Grps_Name, GrpSales.Grps_target"
        txtSQL = txtSQL & " FROM GrpSales INNER JOIN SalesMan "        
        txtSQL = txtSQL & " ON GrpSales.Grps_id = salesman.SL_GRP"
        'txtSQL = txtSQL & " Where SL_ID = 'SL03' "
        'txtSQL = txtSQL & " Or sl_id='SL14'"
        txtSQL = txtSQL & " Order by SL_ID "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        'chkSaleMan = False
        'subDA.SelectCommand.CommandText = txtSQL

        If chkSaleMan = True Then
            subDS.Tables("SaleMan").Clear()
            chkSaleMan = False
        End If
        subDA.SelectCommand.CommandText = (txtSQL)
        subDA.Fill(subDS, "SaleMan")
        chkSaleMan = True
        With grdSaleMan
            .DataSource = subDS.Tables("SaleMan")

        End With
        Call frmSticGrd()

    End Sub

    Sub frmSticGrd()

        Dim grdTS As DataGridTableStyle = New DataGridTableStyle
        Dim csCode01 As New DataGridTextBoxColumn
        Dim csName01 As New DataGridTextBoxColumn
        'Dim csDate01 As New DataGridTextBoxColumn()
        Dim csAcct01 As New DataGridTextBoxColumn
        Dim csGrpname As New DataGridTextBoxColumn
        Dim csGrptarget As New DataGridTextBoxColumn

        With grdTS
            .AlternatingBackColor = Color.LightSkyBlue
            .BackColor = Color.AliceBlue
            .MappingName = "SaleMan"  'กำหนดให้ DatagridTalbleStyle ใช้กับ Table ใด

        End With

        With csCode01
            .HeaderText = "รหัสพนักงานขาย"
            .MappingName = "SL_ID"
            .ReadOnly = True
            .Width = 70
        End With

        With csName01
            .HeaderText = "ชื่อพนักงานขาย"
            .MappingName = "SL_Name"
            .ReadOnly = True
            .Width = 100
        End With

        With csGrpname
            .HeaderText = "ชื่อกลุ่มพนักงานขาย"
            .MappingName = "Grps_Name"
            .ReadOnly = True
            .Width = 100
        End With

        With csGrptarget
            .HeaderText = "Targetกลุ่มพนักงาขาย"
            .MappingName = "Grps_target"
            .ReadOnly = True
            .Width = 70
        End With


        With csAcct01
            .HeaderText = "รหัสบัญชีค่างวด"
            .MappingName = "SL_Acct"
            .ReadOnly = True
            .Width = 100
        End With

        grdTS.GridColumnStyles.Add(csCode01)
        grdTS.GridColumnStyles.Add(csName01)
        grdTS.GridColumnStyles.Add(csGrpname)
        grdTS.GridColumnStyles.Add(csGrptarget)
        grdTS.GridColumnStyles.Add(csAcct01)


        With grdSaleMan
            .TableStyles.Clear()
            .CaptionText = "ข้อมูลพนักงานขาย"
            .FlatMode = True
            .TableStyles.Add(grdTS)
        End With

    End Sub


    'Private Sub cmbExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'SLid = "Test"
    '    Me.Close()

    'End Sub

    Private Sub grdSaleMan_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdSaleMan.MouseMove
        Dim UserSelRow As Integer = 0
        UserSelRow = grdSaleMan.CurrentRowIndex

        If UserSelRow >= 0 Then
            txtSaleID.Text = CStr(grdSaleMan.Item(UserSelRow, 0))
            txtSaleName.Text = CStr(grdSaleMan.Item(UserSelRow, 1))
        End If

    End Sub

    'Private Sub cmbSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'SLid = txtSaleID.Text
    '    selSale = txtSaleID.Text
    '    selSaleName = txtSaleName.Text
    '    Me.Close()
    'End Sub

    Private Sub cmbSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbExit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExit.Click
        Me.Close()
    End Sub

    Private Sub cmbSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSave.Click
        Dim DS As DataSet = New DataSet
        Dim DA As SqlClient.SqlDataAdapter
        Dim SCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand
        If txtSaleID.Text = "" Then
            MessageBox.Show("กรุณากรอกรหัส", "แจ้งให้ทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtSaleID.Focus()
            Exit Sub
        End If
        If txtSaleName.Text = "" Then
            MessageBox.Show("กรุณากรอกชื่อพนักงานขาย", "แจ้งให้ทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtSaleName.Focus()
            Exit Sub
        End If
        DS.Clear()
        txtSQL = " select * from salesman where SL_ID='" & txtSaleID.Text & "'"
        DA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        DA.Fill(DS, "SaleID")
        If DS.Tables("SaleID").Rows.Count > 0 Then
            MessageBox.Show("รหัสนี้ถูกใช้แล้ว", "แจ้งเตือน", MessageBoxButtons.OK)
            Exit Sub
        Else
            txtSQL = " insert into salesman (SL_ID,SL_NAME,SL_GRP)"
            txtSQL = txtSQL & "Values('" & txtSaleID.Text & "','" & txtSaleName.Text & "','" & cmbgrp.SelectedValue & "' ) "
        End If
        Try
            With SCommand
                .CommandType = CommandType.Text
                .CommandText = txtSQL
                .Connection = Conn
                .ExecuteNonQuery()
            End With
        Catch errprocess As Exception
            MessageBox.Show("ไม่สามารถเพิ่มข้อมูลได้เนื่องจาก " & errprocess.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        Call ShowData()
        txtSaleID.Text = ""
        txtSaleName.Text = ""

    End Sub

    Private Sub cmbDel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDel.Click
        Dim subCom As SqlClient.SqlCommand = New SqlClient.SqlCommand

        If txtSaleID.Text = "" Then
            MessageBox.Show("กรุณาตรวจสอบข้อมูลอีกครั้ง !!!", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf txtSaleName.Text = "" Then
            MessageBox.Show("กรุณาตรวจสอบข้อมูลอีกครั้ง !!!", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        txtSQL = "Delete   From salesman "
        txtSQL = txtSQL & " Where sl_id='" & txtSaleID.Text & "' "

        Try
            If MessageBox.Show("ต้องการลบข้อมลูที่ระบุหรือไม่", "คำยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                With subCom
                    .CommandType = CommandType.Text
                    .CommandText = txtSQL
                    .Connection = Conn
                    .ExecuteNonQuery()
                End With

            Else
                Exit Sub
            End If
        Catch errprocess As Exception
            MessageBox.Show("ไม่สามารถเพิ่มข้อมูลได้เนื่องจาก " & errprocess.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        MessageBox.Show("การลบข้อมูลเรียบร้อยแล้ว ", "ข้อความแจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Call clsText()
        Call ShowData()
        txtSaleID.Text = ""
        txtSaleName.Text = ""

    End Sub

    Private Sub cmbSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSelect.Click
        selSale = txtSaleID.Text
        selSaleName = txtSaleName.Text
        Me.Close()
    End Sub

    Sub showgrpsale()
        'txtSQL = "Select *  "
        'txtSQL = txtSQL & "From SalesMan "
        'txtSQL = txtSQL & "Order by Sl_ID "

        txtSQL = " SELECT salesman.SL_ID, salesman.SL_NAME,salesman.SL_Acct, GrpSales.Grps_Name, GrpSales.Grps_target"
        txtSQL = txtSQL & " FROM GrpSales INNER JOIN"
        txtSQL = txtSQL & " salesman ON GrpSales.Grps_id = salesman.SL_GRP"
        'txtSQL = txtSQL & " Where SL_ID = 'SL03' or sl_id='SL14'"
        txtSQL = txtSQL & " order by SL_ID "

        subDA.SelectCommand.CommandText = txtSQL

        If chkSaleMan = True Then
            subDS.Tables("SaleMan").Clear()
            chkSaleMan = False
        End If
        subDA.SelectCommand.CommandText = (txtSQL)
        subDA.Fill(subDS, "SaleMan")
        chkSaleMan = True
        With grdSaleMan
            .DataSource = subDS.Tables("SaleMan")

        End With
        Call frmSticGrd()
    End Sub

    Sub addgroupsale()

        txtSQL = "Select  Grps_id,Grps_name "
        txtSQL = txtSQL & "From Grpsales "
        txtSQL = txtSQL & "Order by Grps_id DESC "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "GrpSales")

        With cmbgrp
            .DataSource = subDS.Tables("GrpSales")
            .DisplayMember = "Grps_name"
            .ValueMember = "Grps_id"
            '.Text = ""
        End With
    End Sub

    Private Sub cmbgrp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbgrp.SelectedIndexChanged
        Call showgrpsale()
    End Sub
End Class
