Public Class searchCusNotLock
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbExit As System.Windows.Forms.Button
    Friend WithEvents cmbSearch As System.Windows.Forms.Button
    Friend WithEvents cmbOK As System.Windows.Forms.Button
    Friend WithEvents dbCusGrid As System.Windows.Forms.DataGrid
    Friend WithEvents lbCusName As System.Windows.Forms.TextBox
    Friend WithEvents txtCusName As System.Windows.Forms.TextBox
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents lbCusID As System.Windows.Forms.Label
    Friend WithEvents chkCusType As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dbCusGrid = New System.Windows.Forms.DataGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbCusID = New System.Windows.Forms.Label()
        Me.lbCusName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbOK = New System.Windows.Forms.Button()
        Me.cmbSearch = New System.Windows.Forms.Button()
        Me.txtCusName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbExit = New System.Windows.Forms.Button()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.chkCusType = New System.Windows.Forms.CheckBox()
        CType(Me.dbCusGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dbCusGrid
        '
        Me.dbCusGrid.CaptionBackColor = System.Drawing.Color.SlateGray
        Me.dbCusGrid.DataMember = ""
        Me.dbCusGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbCusGrid.Location = New System.Drawing.Point(16, 0)
        Me.dbCusGrid.Name = "dbCusGrid"
        Me.dbCusGrid.Size = New System.Drawing.Size(1184, 458)
        Me.dbCusGrid.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbCusID)
        Me.GroupBox1.Controls.Add(Me.lbCusName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbOK)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 517)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1184, 89)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'lbCusID
        '
        Me.lbCusID.BackColor = System.Drawing.Color.Turquoise
        Me.lbCusID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCusID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusID.Location = New System.Drawing.Point(192, 30)
        Me.lbCusID.Name = "lbCusID"
        Me.lbCusID.Size = New System.Drawing.Size(130, 38)
        Me.lbCusID.TabIndex = 10
        '
        'lbCusName
        '
        Me.lbCusName.BackColor = System.Drawing.Color.PowderBlue
        Me.lbCusName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbCusName.Location = New System.Drawing.Point(320, 30)
        Me.lbCusName.MaxLength = 60
        Me.lbCusName.Name = "lbCusName"
        Me.lbCusName.Size = New System.Drawing.Size(688, 35)
        Me.lbCusName.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label2.Location = New System.Drawing.Point(32, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 29)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "�����١��ҷ�����͡"
        '
        'cmbOK
        '
        Me.cmbOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbOK.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.cmbOK.Location = New System.Drawing.Point(1024, 30)
        Me.cmbOK.Name = "cmbOK"
        Me.cmbOK.Size = New System.Drawing.Size(144, 38)
        Me.cmbOK.TabIndex = 2
        Me.cmbOK.Text = "���͡"
        '
        'cmbSearch
        '
        Me.cmbSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbSearch.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.cmbSearch.Location = New System.Drawing.Point(848, 473)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(144, 38)
        Me.cmbSearch.TabIndex = 9
        Me.cmbSearch.Text = "����"
        '
        'txtCusName
        '
        Me.txtCusName.BackColor = System.Drawing.Color.PowderBlue
        Me.txtCusName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCusName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCusName.Location = New System.Drawing.Point(176, 473)
        Me.txtCusName.MaxLength = 60
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(656, 35)
        Me.txtCusName.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Location = New System.Drawing.Point(32, 473)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "���ͷ���ͧ���"
        '
        'cmbExit
        '
        Me.cmbExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbExit.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.cmbExit.Location = New System.Drawing.Point(1040, 620)
        Me.cmbExit.Name = "cmbExit"
        Me.cmbExit.Size = New System.Drawing.Size(144, 45)
        Me.cmbExit.TabIndex = 4
        Me.cmbExit.Text = "Exit"
        '
        'cboType
        '
        Me.cboType.Location = New System.Drawing.Point(1024, 473)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(176, 33)
        Me.cboType.TabIndex = 5
        Me.cboType.Text = "ComboBox1"
        '
        'chkCusType
        '
        Me.chkCusType.Enabled = False
        Me.chkCusType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkCusType.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.chkCusType.Location = New System.Drawing.Point(16, 620)
        Me.chkCusType.Name = "chkCusType"
        Me.chkCusType.Size = New System.Drawing.Size(112, 45)
        Me.chkCusType.TabIndex = 6
        Me.chkCusType.Text = "����к�"
        '
        'searchCusNotLock
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(10, 24)
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1245, 698)
        Me.Controls.Add(Me.chkCusType)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.cmbExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dbCusGrid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCusName)
        Me.Controls.Add(Me.cmbSearch)
        Me.Name = "searchCusNotLock"
        Me.Text = "���Ң��������˹��"
        CType(Me.dbCusGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim chkData As Boolean = False
    Dim subDA As SqlClient.SqlDataAdapter
    Dim subDS As DataSet = New DataSet

    Private Sub cmbExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExit.Click
        'dbTools.closeDB()
        Me.Close()
    End Sub

    Private Sub searchCus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dTB As New DataTable
        Dim dRow As DataRow
        'Dim i As Integer

        'dbTools.openDB()

        dTB.Columns.Add(New DataColumn("T_Type", GetType(String)))
        dTB.Columns.Add(New DataColumn("T_Name", GetType(String)))

        dRow = dTB.NewRow
        dRow(0) = "AP"
        dRow(1) = "���˹��"
        dTB.Rows.Add(dRow)

        dRow = dTB.NewRow
        dRow(0) = "AR"
        dRow(1) = "�١˹��"
        dTB.Rows.Add(dRow)


        With cboType
            .DataSource = dTB
            .DisplayMember = "T_Name"
            .ValueMember = "T_Type"
        End With
        cboType.SelectedIndex = 1
        Call showData("")


    End Sub

    Sub showData(ByVal cusName As String)
        'dbTools.openDB()
        If chkData = True Then
            subDS.Tables("ARdata").Clear()
            chkData = False
        End If

        txtSQL = "Select Ar_Cus_ID,Ar_Name,Ar_ConTact "
        txtSQL = txtSQL & "From Arfile "
        txtSQL = txtSQL & "Where Ar_Type='" & Convert.ToString(cboType.SelectedValue) & "' "
        txtSQL = txtSQL & "And  (Ar_Name Like '%" & cusName & "%') "
        txtSQL = txtSQL & "Order by Ar_Cus_ID,Ar_Name "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "ARdata")
        chkData = True
        dbCusGrid.DataSource = subDS.Tables("ARdata")
        Call frmSticGrd()
        'subDA = Nothing
        'subDS = Nothing
        'dbTools.closeDB()


    End Sub

    Sub frmSticGrd()

        Dim grdTS As DataGridTableStyle = New DataGridTableStyle
        Dim cusID As New DataGridTextBoxColumn
        Dim cusName As New DataGridTextBoxColumn
        Dim cusContact As New DataGridTextBoxColumn
        'Dim csSale As New DataGridTextBoxColumn()

        With grdTS
            .AlternatingBackColor = Color.LemonChiffon
            .BackColor = Color.White
            .MappingName = "ARdata"  '��˹���� DatagridTalbleStyle ��Ѻ Table �

        End With

        With cusID
            .HeaderText = "���� ���˹��/�١˹��"
            .MappingName = "Ar_Cus_ID"
            .NullText = "������к����"
            .ReadOnly = True
            .Width = 100
            .Alignment = HorizontalAlignment.Center
        End With

        With cusName
            .HeaderText = "�������˹��/�١˹��"
            .MappingName = "Ar_Name"
            .NullText = "������к����"
            .ReadOnly = True
            .Width = 220
            .Alignment = HorizontalAlignment.Left
        End With

        With cusContact
            .HeaderText = "���ͼ��Դ���"
            .MappingName = "Ar_Contact"
            .NullText = "������к����"
            .ReadOnly = True
            .Width = 220
            .Alignment = HorizontalAlignment.Left
        End With



        grdTS.GridColumnStyles.Add(cusID)
        grdTS.GridColumnStyles.Add(cusName)
        grdTS.GridColumnStyles.Add(cusContact)

        With dbCusGrid
            .TableStyles.Clear()
            .CaptionText = "���� �١˹��-���˹�� "
            .FlatMode = True
            .TableStyles.Add(grdTS)
        End With

    End Sub

    Private Sub cmbSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSearch.Click
        Call showData(txtCusName.Text)
    End Sub

    Private Sub cmbOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOK.Click
        selCusiD = lbCusID.Text
        selCusName = lbCusName.Text
        Me.Close()
    End Sub

    Private Sub txtCusName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCusName.KeyDown
        If e.KeyCode = 13 Then
            Call showData(txtCusName.Text)
        End If
    End Sub

    Private Sub cboType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboType.SelectedValueChanged
        If cboType.Text = "" Then Exit Sub
        Call showData("")
    End Sub

    Private Sub dbCusGrid_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dbCusGrid.CurrentCellChanged
        Dim rowSel As Integer

        rowSel = dbCusGrid.CurrentRowIndex
        If rowSel < 0 Then Exit Sub
        lbCusID.Text = Convert.ToString(dbCusGrid.Item(rowSel, 0))
        lbCusName.Text = Convert.ToString(dbCusGrid.Item(rowSel, 1))
    End Sub

End Class
