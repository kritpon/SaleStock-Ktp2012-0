Public Class frmReport2
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
    Friend WithEvents lbStkName As System.Windows.Forms.Label
    Friend WithEvents lbStkCode As System.Windows.Forms.Label
    Friend WithEvents lbFindStk As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbRun As System.Windows.Forms.Button
    Friend WithEvents cmbExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboDType As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optDoc As System.Windows.Forms.RadioButton
    Friend WithEvents optStk As System.Windows.Forms.RadioButton
    Friend WithEvents lbDate01 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbDate02 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dataShow As System.Windows.Forms.DataGrid
    Friend WithEvents chkDocNo As System.Windows.Forms.CheckBox
    Friend WithEvents txtSelectNo As System.Windows.Forms.TextBox
    Friend WithEvents lsvShow As System.Windows.Forms.ListView
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lbCusName As System.Windows.Forms.Label
    Friend WithEvents lbCusID As System.Windows.Forms.Label
    Friend WithEvents lbFindCus As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lbTranQty As System.Windows.Forms.Label
    Friend WithEvents lbQty1 As System.Windows.Forms.Label
    Friend WithEvents lbQty2 As System.Windows.Forms.Label
    Friend WithEvents lbAmt As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkOnDetail As System.Windows.Forms.CheckBox
    Friend WithEvents cmbPrint As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cboDType = New System.Windows.Forms.ComboBox
        Me.lbDate01 = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbStkName = New System.Windows.Forms.Label
        Me.lbStkCode = New System.Windows.Forms.Label
        Me.lbFindStk = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbRun = New System.Windows.Forms.Button
        Me.cmbExit = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbDate02 = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtSelectNo = New System.Windows.Forms.TextBox
        Me.chkDocNo = New System.Windows.Forms.CheckBox
        Me.optStk = New System.Windows.Forms.RadioButton
        Me.optDoc = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmbPrint = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.chkOnDetail = New System.Windows.Forms.CheckBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.lbCusName = New System.Windows.Forms.Label
        Me.lbCusID = New System.Windows.Forms.Label
        Me.lbFindCus = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.dataShow = New System.Windows.Forms.DataGrid
        Me.lsvShow = New System.Windows.Forms.ListView
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lbTranQty = New System.Windows.Forms.Label
        Me.lbQty1 = New System.Windows.Forms.Label
        Me.lbQty2 = New System.Windows.Forms.Label
        Me.lbAmt = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dataShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboDType
        '
        Me.cboDType.Location = New System.Drawing.Point(56, 16)
        Me.cboDType.Name = "cboDType"
        Me.cboDType.Size = New System.Drawing.Size(160, 24)
        Me.cboDType.TabIndex = 1
        Me.cboDType.Text = "ComboBox1"
        '
        'lbDate01
        '
        Me.lbDate01.CalendarFont = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDate01.Location = New System.Drawing.Point(248, 16)
        Me.lbDate01.Name = "lbDate01"
        Me.lbDate01.Size = New System.Drawing.Size(144, 23)
        Me.lbDate01.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbStkName)
        Me.GroupBox1.Controls.Add(Me.lbStkCode)
        Me.GroupBox1.Controls.Add(Me.lbFindStk)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(400, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 80)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'lbStkName
        '
        Me.lbStkName.BackColor = System.Drawing.Color.PowderBlue
        Me.lbStkName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbStkName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStkName.Location = New System.Drawing.Point(72, 48)
        Me.lbStkName.Name = "lbStkName"
        Me.lbStkName.Size = New System.Drawing.Size(376, 24)
        Me.lbStkName.TabIndex = 9
        '
        'lbStkCode
        '
        Me.lbStkCode.BackColor = System.Drawing.Color.Yellow
        Me.lbStkCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbStkCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStkCode.Location = New System.Drawing.Point(72, 16)
        Me.lbStkCode.Name = "lbStkCode"
        Me.lbStkCode.Size = New System.Drawing.Size(192, 24)
        Me.lbStkCode.TabIndex = 5
        '
        'lbFindStk
        '
        Me.lbFindStk.BackColor = System.Drawing.Color.DarkCyan
        Me.lbFindStk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbFindStk.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbFindStk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbFindStk.Location = New System.Drawing.Point(264, 16)
        Me.lbFindStk.Name = "lbFindStk"
        Me.lbFindStk.Size = New System.Drawing.Size(24, 24)
        Me.lbFindStk.TabIndex = 6
        Me.lbFindStk.Text = "..."
        Me.lbFindStk.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "รหัสสินค้า"
        '
        'cmbRun
        '
        Me.cmbRun.Location = New System.Drawing.Point(864, 56)
        Me.cmbRun.Name = "cmbRun"
        Me.cmbRun.Size = New System.Drawing.Size(104, 32)
        Me.cmbRun.TabIndex = 12
        Me.cmbRun.Text = "Run"
        '
        'cmbExit
        '
        Me.cmbExit.Location = New System.Drawing.Point(864, 136)
        Me.cmbExit.Name = "cmbExit"
        Me.cmbExit.Size = New System.Drawing.Size(104, 32)
        Me.cmbExit.TabIndex = 13
        Me.cmbExit.Text = "Exit"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "รายงาน"
        '
        'lbDate02
        '
        Me.lbDate02.CalendarFont = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDate02.Location = New System.Drawing.Point(416, 16)
        Me.lbDate02.Name = "lbDate02"
        Me.lbDate02.Size = New System.Drawing.Size(144, 23)
        Me.lbDate02.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(392, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "ถึง"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(216, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "วันที่"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSelectNo)
        Me.GroupBox2.Controls.Add(Me.chkDocNo)
        Me.GroupBox2.Controls.Add(Me.optStk)
        Me.GroupBox2.Controls.Add(Me.optDoc)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(384, 72)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "รายงาน"
        '
        'txtSelectNo
        '
        Me.txtSelectNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSelectNo.Location = New System.Drawing.Point(184, 16)
        Me.txtSelectNo.MaxLength = 20
        Me.txtSelectNo.Name = "txtSelectNo"
        Me.txtSelectNo.Size = New System.Drawing.Size(152, 22)
        Me.txtSelectNo.TabIndex = 3
        Me.txtSelectNo.Text = ""
        '
        'chkDocNo
        '
        Me.chkDocNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkDocNo.Location = New System.Drawing.Point(112, 24)
        Me.chkDocNo.Name = "chkDocNo"
        Me.chkDocNo.Size = New System.Drawing.Size(72, 16)
        Me.chkDocNo.TabIndex = 2
        Me.chkDocNo.Text = "ระบุเลขที่"
        '
        'optStk
        '
        Me.optStk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optStk.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.optStk.Location = New System.Drawing.Point(16, 48)
        Me.optStk.Name = "optStk"
        Me.optStk.Size = New System.Drawing.Size(104, 16)
        Me.optStk.TabIndex = 1
        Me.optStk.Text = "ตามสินค้า"
        '
        'optDoc
        '
        Me.optDoc.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optDoc.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.optDoc.Location = New System.Drawing.Point(16, 24)
        Me.optDoc.Name = "optDoc"
        Me.optDoc.Size = New System.Drawing.Size(128, 16)
        Me.optDoc.TabIndex = 0
        Me.optDoc.Text = "ตามเอกสาร"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbPrint)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.lbDate02)
        Me.GroupBox3.Controls.Add(Me.cmbRun)
        Me.GroupBox3.Controls.Add(Me.cmbExit)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.lbDate01)
        Me.GroupBox3.Controls.Add(Me.cboDType)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 488)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(976, 208)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        '
        'cmbPrint
        '
        Me.cmbPrint.Location = New System.Drawing.Point(864, 96)
        Me.cmbPrint.Name = "cmbPrint"
        Me.cmbPrint.Size = New System.Drawing.Size(104, 32)
        Me.cmbPrint.TabIndex = 22
        Me.cmbPrint.Text = "Print"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkOnDetail)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 120)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(384, 80)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "รายละเอียด"
        '
        'chkOnDetail
        '
        Me.chkOnDetail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkOnDetail.Location = New System.Drawing.Point(8, 24)
        Me.chkOnDetail.Name = "chkOnDetail"
        Me.chkOnDetail.Size = New System.Drawing.Size(152, 24)
        Me.chkOnDetail.TabIndex = 4
        Me.chkOnDetail.Text = "ต้องการดูรายละเอียด"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lbCusName)
        Me.GroupBox5.Controls.Add(Me.lbCusID)
        Me.GroupBox5.Controls.Add(Me.lbFindCus)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(400, 48)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(456, 72)
        Me.GroupBox5.TabIndex = 20
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "เลือกลูกค้า"
        '
        'lbCusName
        '
        Me.lbCusName.BackColor = System.Drawing.Color.PowderBlue
        Me.lbCusName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCusName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusName.Location = New System.Drawing.Point(144, 16)
        Me.lbCusName.Name = "lbCusName"
        Me.lbCusName.Size = New System.Drawing.Size(216, 24)
        Me.lbCusName.TabIndex = 14
        '
        'lbCusID
        '
        Me.lbCusID.BackColor = System.Drawing.Color.Yellow
        Me.lbCusID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCusID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusID.Location = New System.Drawing.Point(16, 16)
        Me.lbCusID.Name = "lbCusID"
        Me.lbCusID.Size = New System.Drawing.Size(64, 24)
        Me.lbCusID.TabIndex = 13
        '
        'lbFindCus
        '
        Me.lbFindCus.BackColor = System.Drawing.Color.DarkCyan
        Me.lbFindCus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbFindCus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbFindCus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbFindCus.Location = New System.Drawing.Point(80, 16)
        Me.lbFindCus.Name = "lbFindCus"
        Me.lbFindCus.Size = New System.Drawing.Size(24, 24)
        Me.lbFindCus.TabIndex = 15
        Me.lbFindCus.Text = "..."
        Me.lbFindCus.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(112, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 24)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "ลูกค้า"
        '
        'dataShow
        '
        Me.dataShow.DataMember = ""
        Me.dataShow.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dataShow.Location = New System.Drawing.Point(8, 0)
        Me.dataShow.Name = "dataShow"
        Me.dataShow.ReadOnly = True
        Me.dataShow.Size = New System.Drawing.Size(976, 24)
        Me.dataShow.TabIndex = 20
        '
        'lsvShow
        '
        Me.lsvShow.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvShow.Location = New System.Drawing.Point(8, 24)
        Me.lsvShow.Name = "lsvShow"
        Me.lsvShow.Size = New System.Drawing.Size(976, 432)
        Me.lsvShow.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(112, 472)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 24)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "จำนวนรายการ"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(368, 472)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 24)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "จำนวน"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(560, 472)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 24)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "น้ำหนัก"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(784, 472)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 24)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "มูลค่า"
        '
        'lbTranQty
        '
        Me.lbTranQty.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbTranQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbTranQty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTranQty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbTranQty.Location = New System.Drawing.Point(200, 464)
        Me.lbTranQty.Name = "lbTranQty"
        Me.lbTranQty.Size = New System.Drawing.Size(96, 24)
        Me.lbTranQty.TabIndex = 26
        Me.lbTranQty.Text = "0"
        Me.lbTranQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbQty1
        '
        Me.lbQty1.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbQty1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbQty1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbQty1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbQty1.Location = New System.Drawing.Point(416, 464)
        Me.lbQty1.Name = "lbQty1"
        Me.lbQty1.Size = New System.Drawing.Size(104, 24)
        Me.lbQty1.TabIndex = 27
        Me.lbQty1.Text = "0"
        Me.lbQty1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbQty2
        '
        Me.lbQty2.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbQty2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbQty2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbQty2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbQty2.Location = New System.Drawing.Point(608, 464)
        Me.lbQty2.Name = "lbQty2"
        Me.lbQty2.Size = New System.Drawing.Size(128, 24)
        Me.lbQty2.TabIndex = 28
        Me.lbQty2.Text = "0"
        Me.lbQty2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbAmt
        '
        Me.lbAmt.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbAmt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbAmt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbAmt.Location = New System.Drawing.Point(816, 464)
        Me.lbAmt.Name = "lbAmt"
        Me.lbAmt.Size = New System.Drawing.Size(120, 24)
        Me.lbAmt.TabIndex = 29
        Me.lbAmt.Text = "0"
        Me.lbAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(944, 472)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 24)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "บาท"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(744, 472)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 24)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Kg."
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(520, 472)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 24)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "แผ่น"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(296, 472)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 24)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "รายการ"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(536, 712)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(160, 32)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Label10"
        '
        'frmReport2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(1128, 773)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lbAmt)
        Me.Controls.Add(Me.lbQty2)
        Me.Controls.Add(Me.lbQty1)
        Me.Controls.Add(Me.lbTranQty)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lsvShow)
        Me.Controls.Add(Me.dataShow)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.KeyPreview = True
        Me.Name = "frmReport2"
        Me.Text = "frmReport2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dataShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim subDA As Data.SqlClient.SqlDataAdapter
    Dim subDS As New Data.DataSet
    Dim chkData As Boolean

    Dim lvi As ListViewItem
    Dim lviGrp As ListViewItem

    Dim chkRow As Boolean = False
    Dim chkcol As Boolean = True


    'Dim rpt1 As testReport3 = New testReport3

    Private Sub cmbExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExit.Click
        Me.Close()
    End Sub

    Sub getColListView()

        'If chkFullOpt.Checked = True Then
        '    lsvShow.Columns.Add("จอง", 90, HorizontalAlignment.Right)
        '    lsvShow.Columns.Add("ค้างส่ง", 90, HorizontalAlignment.Right)
        'Else

        'End If
        If optDoc.Checked = True Then
            lsvShow.Columns.Add("Type", 5, HorizontalAlignment.Center)
            lsvShow.Columns.Add("ลำดับ", 50, HorizontalAlignment.Center)
            lsvShow.Columns.Add("วันที่ ", 80, HorizontalAlignment.Center)
            lsvShow.Columns.Add("เลขที่", 90, HorizontalAlignment.Left)
            lsvShow.Columns.Add("ลูกค้า", 300, HorizontalAlignment.Left)
            lsvShow.Columns.Add("เก็บ", 90, HorizontalAlignment.Center)
            lsvShow.Columns.Add("รายการ", 300, HorizontalAlignment.Left)

            lsvShow.Columns.Add("จำนวน(แผ่น)", 90, HorizontalAlignment.Right)
            lsvShow.Columns.Add("จำนวน(Kg.)", 90, HorizontalAlignment.Right)
            lsvShow.Columns.Add("ราคา/แผ่น", 90, HorizontalAlignment.Right)
            lsvShow.Columns.Add("มูลค่า", 90, HorizontalAlignment.Right)

        ElseIf optStk.Checked = True Then

            lsvShow.Columns.Add("Type", 5, HorizontalAlignment.Center)
            lsvShow.Columns.Add("ลำดับ", 50, HorizontalAlignment.Center)

            If chkOnDetail.Checked = True Then
                lsvShow.Columns.Add("วันที่ ", 80, HorizontalAlignment.Center)
                lsvShow.Columns.Add("เลขที่", 90, HorizontalAlignment.Left)
                lsvShow.Columns.Add("ลูกค้า", 300, HorizontalAlignment.Left)
            End If

            lsvShow.Columns.Add("รายการ", 300, HorizontalAlignment.Left)

            lsvShow.Columns.Add("จำนวน(แผ่น)", 90, HorizontalAlignment.Right)
            lsvShow.Columns.Add("จำนวน(Kg.)", 90, HorizontalAlignment.Right)
            If chkOnDetail.Checked = True Then
                lsvShow.Columns.Add("ราคา/แผ่น", 90, HorizontalAlignment.Right)
                lsvShow.Columns.Add("มูลค่า", 90, HorizontalAlignment.Right)
            End If


        End If

        'lsvShow.Columns.Add("รับ", 90, HorizontalAlignment.Right)
        'lsvShow.Columns.Add("จ่าย", 100, HorizontalAlignment.Right)
        'lsvShow.Columns.Add("คงเหลือ", 100, HorizontalAlignment.Right)
        'lsvShow.Columns.Add("xxx", 100, HorizontalAlignment.Right)
        'lsvShow.Columns.Add("con_id", 80, HorizontalAlignment.Center)

        lsvShow.View = View.Details
        lsvShow.GridLines = True
        'chkCol = True

    End Sub

    Sub getItemDetail()
        Dim iRow As Integer = 0


        Dim anyData() As String

        '   ตัวแปร ที่ใช้ในการคำนวน รายละเอียด

        Dim rowNo As Integer = 0
        Dim date01 As Date
        Dim strDocNo As String
        Dim dtlItem As String
        Dim dtlStkName As String
        Dim dtlType As String
        Dim dtlConiD As String

        Dim Q_Iss As Double = 0
        Dim Q_Rcv As Double = 0
        Dim Q_Pen As Double = 0
        Dim Q_Order As Double = 0
        Dim Q_Bal As Double = 0

        Dim Dtl_Detail As String = ""
        Dim Q_Qty2 As Double = 0

        Dim Dtl_Price As Double = 0
        Dim Dtl_Amt As Double = 0

        lbTranQty.Text = Format(0, "#,##0.00")
        lbQty1.Text = Format(0, "#,##0.00")
        lbQty2.Text = Format(0, "#,##0.00")
        lbAmt.Text = Format(0, "#,##0.00")

        With subDS.Tables("Command")

            If (subDS.Tables("Command").Rows.Count >= 1) Then

                For iRow = 0 To .Rows.Count - 1
                    rowNo = iRow + 1

                    If IsDBNull(.Rows(iRow).Item("Stk_Name_1")) Then

                    Else
                        dtlType = (.Rows(iRow).Item("Trh_Type"))


                        date01 = (.Rows(iRow).Item("Trh_Date"))
                        strDocNo = (.Rows(iRow).Item("Trh_No"))

                        'If IsDBNull(.Rows(iRow).Item("Dtl_Con_ID")) Then
                        '    dtlConiD = ""
                        'Else
                        '    dtlConiD = (.Rows(iRow).Item("Dtl_Con_ID"))
                        'End If

                        If dtlType = "S" Then
                            'dtlItem = "ขายสินค้าให้กับ " & dbTools.findCusName(.Rows(iRow).Item("Trh_Cus"))
                            dtlItem = .Rows(iRow).Item("Ar_Name")
                        ElseIf dtlType = "B" Then
                            'dtlItem = "Order สินค้าของ " & dbTools.findCusName(.Rows(iRow).Item("Trh_Cus")) '& (subDS.Tables("rptByItem").Rows(iRow).Item("Dtl_idTrade"))
                            dtlItem = .Rows(iRow).Item("Ar_Name")
                        ElseIf dtlType = "D" Then
                            dtlItem = "รับสินค้าจากการผลิต" '& (subDS.Tables("rptByItem").Rows(iRow).Item("Dtl_idTrade"))
                        ElseIf dtlType = "P" Then
                            dtlItem = "เบิกสินค้าเพื่อขาย " '& (subDS.Tables("rptByItem").Rows(iRow).Item("Dtl_idTrade"))
                        End If

                        Dtl_Detail = .Rows(iRow).Item("Dtl_Detail")
                    If IsDBNull(.Rows(iRow).Item("Stk_Name_1")) Then
                        dtlStkName = ""
                    Else
                        dtlStkName = .Rows(iRow).Item("Stk_Name_1")
                    End If


                    Q_Iss = 0
                    Q_Rcv = 0
                    Q_Order = 0
                    Q_Pen = 0
                    Q_Qty2 = 0
                    Dtl_Price = 0
                    Dtl_Amt = 0

                    'Q_Bal = 0
                    If dtlType = "S" Then
                        Q_Rcv = (.Rows(iRow).Item("Dtl_num"))
                    ElseIf dtlType = "B" Then
                        Q_Rcv = (.Rows(iRow).Item("Dtl_num"))
                        Q_Pen = (.Rows(iRow).Item("Dtl_num") - .Rows(iRow).Item("Dtl_num_2"))
                    ElseIf dtlType = "D" Then
                        If IsDBNull(.Rows(iRow).Item("Dtl_Num")) Then
                            Q_Rcv = 0
                        Else
                            Q_Rcv = (.Rows(iRow).Item("Dtl_num"))
                            Q_Bal = (Q_Bal + Q_Rcv)
                        End If

                    End If
                    If IsDBNull(.Rows(iRow).Item("Stk_Factor")) Then
                        Q_Qty2 = Q_Rcv
                    Else
                        Q_Qty2 = (Q_Rcv * .Rows(iRow).Item("Stk_Factor"))
                    End If


                    Dtl_Price = .Rows(iRow).Item("Dtl_Price")
                    Dtl_Amt = (Q_Rcv * Dtl_Price)

                    '=======================   control  Total label  

                    lbTranQty.Text = Format(Int(iRow + 1), "#,##0")
                    lbQty1.Text = Format(Q_Rcv + Int(lbQty1.Text), "#,##0.00")
                    lbQty2.Text = Format(Q_Qty2 + CDbl(lbQty2.Text), "#,##0.00")
                    lbAmt.Text = Format(Dtl_Amt + CDbl(lbAmt.Text), "#,##0.00")

                        anyData = New String() _
                                {dtlType, rowNo, date01, strDocNo, dtlItem, Dtl_Detail, dtlStkName, _
                                Q_Rcv.ToString("#,##0"), Q_Qty2.ToString("#,##0.00"), _
                                Dtl_Price.ToString("#,##0.00"), Dtl_Amt.ToString("#,##0.00")}

                    'If optDoc.Checked = True Then

                    '    anyData = New String() _
                    '            {dtlType, date01, strDocNo, dtlItem, _
                    '            Q_Order.ToString("#,##0.00"), Q_Pen.ToString("#,##0"), Q_Rcv.ToString("#,##0.00"), _
                    '            Q_Iss.ToString("#,##0.00"), Q_Bal.ToString("#,##0.00"), dtlConiD}

                    'ElseIf optStk.Checked = True Then

                    '    anyData = New String() _
                    '            {dtlType, date01, strDocNo, dtlItem, _
                    '            Q_Rcv.ToString("#,##0.00"), _
                    '            Q_Iss.ToString("#,##0.00"), Q_Bal.ToString("#,##0.00"), dtlConiD}
                    'End If

                    lvi = New ListViewItem(anyData)
                    lsvShow.Items.Add(lvi)
                    If chkRow = False Then
                        chkRow = True
                    Else
                        chkRow = False
                    End If

                    Call colorList(dtlType)
                        End If

                Next

            End If
        End With


    End Sub

    Sub getItemDetailByStk()
        Dim iRow As Integer = 0


        Dim anyData() As String

        '   ตัวแปร ที่ใช้ในการคำนวน รายละเอียด

        Dim rowNo As Integer = 0
        Dim date01 As Date
        Dim strDocNo As String
        Dim dtlItem As String
        Dim dtlStkName As String
        Dim dtlType As String
        Dim dtlConiD As String

        Dim Q_Iss As Double = 0
        Dim Q_Rcv As Double = 0
        Dim Q_Pen As Double = 0
        Dim Q_Order As Double = 0
        Dim Q_Bal As Double = 0

        Dim Q_Detail As String = ""

        Dim Q_Qty2 As Double = 0

        Dim Dtl_Price As Double = 0
        Dim Dtl_Amt As Double = 0

        lbTranQty.Text = Format(0, "#,##0.00")
        lbQty1.Text = Format(0, "#,##0.00")
        lbQty2.Text = Format(0, "#,##0.00")
        lbAmt.Text = Format(0, "#,##0.00")

        With subDS.Tables("Command")

            If (subDS.Tables("Command").Rows.Count >= 1) Then

                For iRow = 0 To .Rows.Count - 1
                    rowNo = iRow + 1

                    If IsDBNull(.Rows(iRow).Item("Stk_Name_1")) Then

                    Else
                        dtlType = (.Rows(iRow).Item("Trh_Type"))
                        If chkOnDetail.Checked = True Then

                            date01 = (.Rows(iRow).Item("Trh_Date"))
                            strDocNo = (.Rows(iRow).Item("Trh_No"))

                            'If IsDBNull(.Rows(iRow).Item("Dtl_Con_ID")) Then
                            '    dtlConiD = ""
                            'Else
                            '    dtlConiD = (.Rows(iRow).Item("Dtl_Con_ID"))
                            'End If

                            If dtlType = "S" Then
                                'dtlItem = "ขายสินค้าให้กับ " & dbTools.findCusName(.Rows(iRow).Item("Trh_Cus"))
                                dtlItem = .Rows(iRow).Item("Ar_Name")
                            ElseIf dtlType = "B" Then
                                'dtlItem = "Order สินค้าของ " & dbTools.findCusName(.Rows(iRow).Item("Trh_Cus")) '& (subDS.Tables("rptByItem").Rows(iRow).Item("Dtl_idTrade"))
                                dtlItem = .Rows(iRow).Item("Ar_Name")
                            ElseIf dtlType = "D" Then
                                dtlItem = "รับสินค้าจากการผลิต" '& (subDS.Tables("rptByItem").Rows(iRow).Item("Dtl_idTrade"))
                            ElseIf dtlType = "P" Then
                                dtlItem = "เบิกสินค้าเพื่อขาย " '& (subDS.Tables("rptByItem").Rows(iRow).Item("Dtl_idTrade"))
                            End If

                        End If
                        If IsDBNull(.Rows(iRow).Item("Stk_Name_1")) Then
                            dtlStkName = ""
                        Else
                            dtlStkName = .Rows(iRow).Item("Stk_Name_1")
                        End If


                        Q_Iss = 0
                        Q_Rcv = 0
                        Q_Order = 0
                        Q_Pen = 0
                        Q_Qty2 = 0
                        Dtl_Price = 0
                        Dtl_Amt = 0

                        'Q_Bal = 0
                        If dtlType = "S" Then
                            Q_Rcv = (.Rows(iRow).Item("Dtl_num"))
                        ElseIf dtlType = "B" Then
                            Q_Rcv = (.Rows(iRow).Item("Dtl_num"))
                            Q_Pen = (.Rows(iRow).Item("Dtl_num") - .Rows(iRow).Item("Dtl_num_2"))
                        ElseIf dtlType = "D" Then
                            If IsDBNull(.Rows(iRow).Item("Dtl_Num")) Then
                                Q_Rcv = 0
                            Else
                                Q_Rcv = (.Rows(iRow).Item("Dtl_num"))
                                Q_Bal = (Q_Bal + Q_Rcv)
                            End If

                        End If
                        If IsDBNull(.Rows(iRow).Item("Stk_Factor")) Then
                            Q_Qty2 = Q_Rcv
                        Else
                            Q_Qty2 = (Q_Rcv * .Rows(iRow).Item("Stk_Factor"))
                        End If


                        Dtl_Price = 0 ' .Rows(iRow).Item("Dtl_Price")
                        Dtl_Amt = 0 '(Q_Rcv * Dtl_Price)

                        '=======================   control  Total label  

                        lbTranQty.Text = Format(Int(iRow + 1), "#,##0")
                        lbQty1.Text = Format(Q_Rcv + Int(lbQty1.Text), "#,##0.00")
                        lbQty2.Text = Format(Q_Qty2 + CDbl(lbQty2.Text), "#,##0.00")
                        lbAmt.Text = Format(Dtl_Amt + CDbl(lbAmt.Text), "#,##0.00")
                        If chkOnDetail.Checked = True Then
                            anyData = New String() _
                                    {dtlType, rowNo, date01, strDocNo, dtlItem, dtlStkName, _
                                    Q_Rcv.ToString("#,##0"), Q_Qty2.ToString("#,##0.00"), _
                                    Dtl_Price.ToString("#,##0.00"), Dtl_Amt.ToString("#,##0.00")}
                        ElseIf chkOnDetail.Checked = False Then
                            anyData = New String() _
                                    {dtlType, rowNo, dtlStkName, _
                                    Q_Rcv.ToString("#,##0"), Q_Qty2.ToString("#,##0.00")}

                        End If


                        'If optDoc.Checked = True Then

                        '    anyData = New String() _
                        '            {dtlType, date01, strDocNo, dtlItem, _
                        '            Q_Order.ToString("#,##0.00"), Q_Pen.ToString("#,##0"), Q_Rcv.ToString("#,##0.00"), _
                        '            Q_Iss.ToString("#,##0.00"), Q_Bal.ToString("#,##0.00"), dtlConiD}

                        'ElseIf optStk.Checked = True Then

                        '    anyData = New String() _
                        '            {dtlType, date01, strDocNo, dtlItem, _
                        '            Q_Rcv.ToString("#,##0.00"), _
                        '            Q_Iss.ToString("#,##0.00"), Q_Bal.ToString("#,##0.00"), dtlConiD}
                        'End If

                        lvi = New ListViewItem(anyData)
                        lsvShow.Items.Add(lvi)
                        If chkRow = False Then
                            chkRow = True
                        Else
                            chkRow = False
                        End If

                        Call colorList(dtlType)
                    End If

                Next

            End If
        End With


    End Sub

    Sub colorList(ByVal iType As String)

        'If (listType = "QZ") Or (listType = "QC") Then
        If chkRow = True Then
            If (iType = "S") Then
                lvi.BackColor = System.Drawing.Color.GreenYellow
                lvi.ForeColor = System.Drawing.Color.Black
                lvi.UseItemStyleForSubItems = True
            ElseIf (iType = "B") Then
                lvi.BackColor = System.Drawing.Color.Yellow
                lvi.ForeColor = System.Drawing.Color.Black
                lvi.UseItemStyleForSubItems = True
            ElseIf (iType = "D") Then

                lvi.BackColor = System.Drawing.Color.Blue
                lvi.ForeColor = System.Drawing.Color.White
                lvi.UseItemStyleForSubItems = True
                'ElseIf (dayDif <= -91) Then

                '    lvi.BackColor = System.Drawing.Color.Tomato
                '    lvi.UseItemStyleForSubItems = True
            End If
        Else
            lvi.BackColor = System.Drawing.Color.White
            lvi.ForeColor = System.Drawing.Color.Black
            lvi.UseItemStyleForSubItems = True

        End If

        'End If
    End Sub

    Private Sub frmReport2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbDate01.Value = Now
        lbDate02.Value = Now
        Call addItemCBO()
        'Call FormatGrd()
        optDoc.Checked = True
        Call getColListView()
        cmbRun.Focus()
    End Sub

    Sub FormatGrd()

        Dim grdTS As DataGridTableStyle = New DataGridTableStyle

        Dim colType As New DataGridTextBoxColumn
        Dim colDate As New DataGridTextBoxColumn
        Dim colNo As New DataGridTextBoxColumn
        Dim colStkName As New DataGridTextBoxColumn
        Dim colDetl As New DataGridTextBoxColumn
        Dim colQty1 As New DataGridTextBoxColumn
        Dim colQty2 As New DataGridTextBoxColumn
        'dim col


        With grdTS
            .AlternatingBackColor = Color.LemonChiffon
            .BackColor = Color.White
            .MappingName = "Command"  'กำหนดให้ DatagridTalbleStyle ใช้กับ Table ใด

        End With

        With colType
            .HeaderText = "ประเภท"
            .MappingName = "Trh_Type"
            .Alignment = HorizontalAlignment.Center
            '.ReadOnly = True
            .Width = 50
        End With
        With colNo
            .HeaderText = "เลขที่"
            .MappingName = "Trh_No"
            ' .ReadOnly = True
            .Width = 100
        End With
        With colDate
            .HeaderText = "วันที่"
            .MappingName = "Trh_Date"
            ' .ReadOnly = True
            .Width = 100
        End With

        With colStkName
            .HeaderText = "รายการ"
            .MappingName = "Stk_Name_1"
            ' .ReadOnly = True
            .Width = 250
        End With


        With colQty1
            .HeaderText = "จำนวนแผ่น"
            .MappingName = "Dtl_Num"
            .Alignment = HorizontalAlignment.Right

            ' .ReadOnly = True
            .Width = 100
        End With


        With colQty2
            .HeaderText = "น้ำหนัก"
            .MappingName = "Dtl_Num_2"
            .Alignment = HorizontalAlignment.Center
            '.ReadOnly = True
            .Width = 100
        End With


        grdTS.GridColumnStyles.Add(colType)
        grdTS.GridColumnStyles.Add(colDate)
        grdTS.GridColumnStyles.Add(colNo)
        grdTS.GridColumnStyles.Add(colStkName)
        grdTS.GridColumnStyles.Add(colQty1)
        grdTS.GridColumnStyles.Add(colQty2)


        With dataShow
            .TableStyles.Clear()
            .CaptionText = "รายงานการเคลื่อนไหวสินค้า"
            .FlatMode = True
            .TableStyles.Add(grdTS)
            '.Controls.Clear()
        End With

    End Sub

    Sub genSQLdetailByDoc()

        txtSQL = "SELECT  "
        txtSQL = txtSQL & "TranDataH.Trh_Type,TranDataH.Trh_NoType,"
        txtSQL = txtSQL & "TranDatah.Trh_Date, TranDataH.Trh_No,"
        txtSQL = txtSQL & "TranDataH.Trh_Cus,Ar_Name,Dtl_Detail,GrpSales.Grps_id,Grps_Name,"
        txtSQL = txtSQL & "TranDataH.Trh_Sale,Sl_Name,"
        txtSQL = txtSQL & "TranDataD.Dtl_idTrade,Basemast.Stk_Name_1,BaseMast.Stk_Factor,"
        txtSQL = txtSQL & "TranDataD.Dtl_Num,TranDataD.Dtl_Num_2,"
        txtSQL = txtSQL & "TranDataD.Dtl_Price,TranDataD.Dtl_Con_id,Dtl_Same_Code "

        txtSQL = txtSQL & "FROM TranDataH LEFT OUTER JOIN TranDataD "
        txtSQL = txtSQL & "ON TranDataH.Trh_Type = TranDataD.Dtl_type "
        txtSQL = txtSQL & "AND TranDataH.Trh_No = TranDataD.Dtl_no "
        txtSQL = txtSQL & "left outer join Basemast "
        txtSQL = txtSQL & "on TranDataD.Dtl_idTrade=Basemast.Stk_Code "
        txtSQL = txtSQL & "left join Arfile "
        txtSQL = txtSQL & "on TranDataH.Trh_Cus=ArFile.Ar_Cus_id "
        txtSQL = txtSQL & "left join SalesMan "
        txtSQL = txtSQL & "On TranDatah.Trh_Sale=Salesman.Sl_Id "
        txtSQL = txtSQL & "left join GrpSales  "
        txtSQL = txtSQL & "on SalesMan.Sl_Grp=GrpSales.Grps_ID "

        txtSQL = txtSQL & "where Trh_Type='" & cboDType.SelectedValue & "' "
        txtSQL = txtSQL & "And Trh_Date >= '" & Format(DateAdd(DateInterval.Year, -543, lbDate01.Value), "yyyy/MM/dd") & "' "
        txtSQL = txtSQL & "And Trh_Date <= '" & Format(DateAdd(DateInterval.Year, -543, lbDate02.Value), "yyyy/MM/dd") & "' "

        If chkDocNo.Checked = True Then
            txtSQL = txtSQL & "And Trh_No like '%" & Trim(txtSelectNo.Text) & "%' "
        Else

        End If


        txtSQL = txtSQL & "Order by TranDataH.Trh_Date,TranDataH.Trh_No,TranDataD.Dtl_idTrade "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        If chkData = True Then
            subDS.Tables("Command").Clear()
            chkData = False
        End If

        subDA.Fill(subDS, "Command")
        chkData = True


        'rpt1.Database.Tables("Command").SetDataSource(subDS.Tables("Command"))
        'rpt1.Refresh()

        dataShow.DataSource = subDS.Tables("Command")
        dataShow.Refresh()

    End Sub

    Sub genSQLdetailByStk()


        txtSQL = "SELECT  "
        txtSQL = txtSQL & "TranDataH.Trh_Type,"

        If chkOnDetail.Checked = True Then
            txtSQL = txtSQL & "TranDatah.Trh_Date,"
            txtSQL = txtSQL & "TranDataH.Trh_No,"
            txtSQL = txtSQL & "TranDataH.Trh_Cus,Ar_Name,GrpSales.Grps_id,Grps_Name,"
            txtSQL = txtSQL & "TranDataH.Trh_Sale,Sl_Name,"
        End If

        txtSQL = txtSQL & "TranDataD.Dtl_idTrade,Basemast.Stk_Name_1,BaseMast.Stk_Factor,"

        txtSQL = txtSQL & "sum(TranDataD.Dtl_Num)as Dtl_Num,sum(TranDataD.Dtl_Num_2)as Dtl_Num_2 "

        'txtSQL = txtSQL & "TranDataD.Dtl_Price,"
        'txtSQL = txtSQL & "TranDataD.Dtl_Con_id,Dtl_Same_Code "

        txtSQL = txtSQL & "FROM TranDataH LEFT OUTER JOIN TranDataD "
        txtSQL = txtSQL & "ON TranDataH.Trh_Type = TranDataD.Dtl_type "
        txtSQL = txtSQL & "AND TranDataH.Trh_No = TranDataD.Dtl_no "
        txtSQL = txtSQL & "left outer join Basemast "
        txtSQL = txtSQL & "on TranDataD.Dtl_idTrade=Basemast.Stk_Code "
        txtSQL = txtSQL & "left join Arfile "
        txtSQL = txtSQL & "on TranDataH.Trh_Cus=ArFile.Ar_Cus_id "
        txtSQL = txtSQL & "left join SalesMan "
        txtSQL = txtSQL & "On TranDatah.Trh_Sale=Salesman.Sl_Id "
        txtSQL = txtSQL & "left join GrpSales  "
        txtSQL = txtSQL & "on SalesMan.Sl_Grp=GrpSales.Grps_ID "

        txtSQL = txtSQL & "where Trh_Type='" & cboDType.SelectedValue & "' "
        txtSQL = txtSQL & "And Trh_Date >= '" & Format(DateAdd(DateInterval.Year, -543, lbDate01.Value), "yyyy/MM/dd") & "' "
        txtSQL = txtSQL & "And Trh_Date <= '" & Format(DateAdd(DateInterval.Year, -543, lbDate02.Value), "yyyy/MM/dd") & "' "

        '===============  Group by  ======================================

        txtSQL = txtSQL & "Group By "
        txtSQL = txtSQL & "TranDataH.Trh_Type,"

        If chkOnDetail.Checked = True Then
            txtSQL = txtSQL & "TranDatah.Trh_Date,"
            txtSQL = txtSQL & "TranDataH.Trh_No,"
            txtSQL = txtSQL & "TranDataH.Trh_Cus,Ar_Name,GrpSales.Grps_id,Grps_Name,"
            txtSQL = txtSQL & "TranDataH.Trh_Sale,Sl_Name,"
        End If
        txtSQL = txtSQL & "TranDataD.Dtl_idTrade,Basemast.Stk_Name_1,BaseMast.Stk_Factor "

        '===============  Group by  ======================================

        txtSQL = txtSQL & "Order by TranDataD.Dtl_idTrade "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        If chkData = True Then
            subDS.Tables("Command").Clear()
            chkData = False
        End If

        subDA.Fill(subDS, "Command")
        chkData = True

        dataShow.DataSource = subDS.Tables("Command")
        dataShow.Refresh()

    End Sub

    Sub addItemCBO()

        Dim da As SqlClient.SqlDataAdapter
        Dim ds As DataSet = New DataSet
        Dim iRow As Integer = 0

        'cboType.SelectedItem = Nothing
        'cboGrp.SelectedItem = Nothing
        'cboSize.SelectedItem = Nothing
        'cboThick.SelectedItem = Nothing
        'cboPaper.SelectedItem = Nothing
        'cboColor.SelectedItem = Nothing
        cboDType.SelectedItem = Nothing

        txtSQL = "Select * From  TypeDocMast "
        txtSQL = txtSQL & "Order by Type_ID "

        da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        da.Fill(ds, "DTypeMast")

        If ds.Tables("DTypeMast").Rows.Count > 0 Then
            With cboDType
                .DataSource = ds.Tables("DTypeMast")
                .DisplayMember = "Type_Name"
                .ValueMember = "Type_ID"
                .Text = ""
            End With
        End If
        cboDType.SelectedItem = Nothing
    End Sub

    Private Sub cmbRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRun.Click
        lsvShow.Items.Clear()
        chkcol = False
        If chkcol = False Then
            lsvShow.Columns.Clear()
            Call getColListView()
            chkcol = True

        End If
        If optDoc.Checked = True Then

            Call genSQLdetailByDoc()
            Call getItemDetail()

        ElseIf optStk.Checked = True Then

            Call genSQLdetailByStk()
            Call getItemDetailByStk()

        End If

    End Sub

    Private Sub lbFindStk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbFindStk.Click
        Dim frmFindStk As frmFindStk = New frmFindStk
        selStkID = ""
        frmFindStk.ShowDialog()
        lbStkCode.Text = selStkID
        lbStkName.Text = dbTools.getStkName(selStkID)
    End Sub

    Private Sub lbDate01_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbDate01.ValueChanged
        lbDate02.Value = lbDate01.Value
    End Sub

    Sub prnReport()

        Dim myExcel As Microsoft.Office.Interop.Excel.Application
        'Dim subDA2 As New SqlClient.SqlDataAdapter
        'Dim subDS2 As New DataSet


        Dim rw As Integer
        Dim countRow As Integer
        Dim countRow2 As Integer
        Dim rowExcel As Integer = 9 '  เริ่ม รายการบรรทัดที่ 9
        Dim bufferExcel As Integer = 0 ' ใช้ในกรณีขึ้น sheet ใหม่ และ ให้ buffer ค่าต่อจาก sheet เดิม เพื่อนับต่อ
        Dim sheetCount As Integer = 1
        Dim stkName2 As String



        fileName = CurDir() & "\report\rptStk02.xls"
        myExcel = New Microsoft.Office.Interop.Excel.Application
        myExcel = CreateObject("Excel.Application")
        myExcel.Visible = True
        myExcel.DisplayAlerts = False
        'myExcel.ActiveWorkbook.AutoUpdateSaveChanges = False
        myExcel.AskToUpdateLinks = False
        myExcel.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlNormal

        myExcel.Workbooks.Open(fileName, 0, 1)

        With myExcel

            'rw = .ActiveCell.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell).Row
            rw = subDS.Tables("Command").Rows.Count - 1

            .ActiveWindow.FreezePanes = False
            .Range("E2").Select()
            .ActiveCell.Value = dbTools.getDocType(cboDType.SelectedValue)

            For countRow = 0 To rw

                .Range("B" & rowExcel).Select()
                .ActiveCell.Value = countRow + 1

                .Range("C" & rowExcel).Select()
                .ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_Date")

                .Range("D" & rowExcel).Select()
                .ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_No")

                If IsDBNull(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Ar_Name")) Then

                    .Range("E" & rowExcel).Select()
                    .ActiveCell.Value = "ไม่พบข้อมูล"

                Else
                    .Range("E" & rowExcel).Select()
                    .ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Ar_Name")

                End If

                .Range("F" & rowExcel).Select()
                .ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Detail")

                .Range("G" & rowExcel).Select()
                .ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Stk_Name_1")

                .Range("J" & rowExcel).Select()
                .ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Num")

                .Range("K" & rowExcel).Select()
                If IsDBNull(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Stk_Factor")) Or IsDBNull(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Num")) Then
                    .ActiveCell.Value = 0
                Else
                    .ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Num") * subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Stk_Factor")
                End If

                '  ============  เพิ่มบรรทัด
                .Range("B" & (rowExcel + 1) & ":" & "K" & (rowExcel + 1)).Select() '  เลือกบรรทัดเพื่อแทรก
                .Selection.copy()
                .Range("B" & (rowExcel + 2) & ":" & "K" & (rowExcel + 2)).Select()
                .Selection.Insert(Shift:=2)    '     เพิ่ม( Insert ) บรรทัด 
                '  ============  เพิ่มบรรทัด

                rowExcel = rowExcel + 1
                'If rowExcel = 900 Then
                '    'bufferExcel = 500
                '    rowExcel = 9
                '    'myExcel.Workbooks.Open(fileName, 0, 1)
                '    sheetCount = sheetCount + 1
                '    .Sheets(sheetCount).select()
                'End If

            Next



            'myExcel.Quit()
            myExcel = Nothing
        End With
    End Sub

    Private Sub cmbPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPrint.Click
        Call prnReport()
    End Sub

    Private Sub frmReport2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.F3 Then

            Dim frmFindStk As frmFindStk = New frmFindStk
            selStkID = ""
            frmFindStk.ShowDialog()
            lbStkCode.Text = selStkID
            If lbStkCode.Text = "" Then
            Else
                lbStkName.Text = dbTools.getStkName(selStkID)
            End If


        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
