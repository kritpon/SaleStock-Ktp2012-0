Public Class frmBegin
    Inherits System.Windows.Forms.Form

    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboDClist As System.Windows.Forms.ComboBox
    Friend WithEvents cmbExit As System.Windows.Forms.Button
  
    Friend WithEvents lbAns As System.Windows.Forms.Label
    Friend WithEvents cmbTest As System.Windows.Forms.Button
   

    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents TreeView2 As System.Windows.Forms.TreeView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents optDocN As System.Windows.Forms.RadioButton
    Friend WithEvents optDocV As System.Windows.Forms.RadioButton
    Friend WithEvents optX As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents checkPrint As CheckBox
    Friend WithEvents lbDBName As System.Windows.Forms.ToolStripStatusLabel


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
    Friend WithEvents cmbNew As System.Windows.Forms.Button
    Friend WithEvents cmbEditDoc As System.Windows.Forms.Button
    Friend WithEvents txtEditNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbCusName As System.Windows.Forms.Label
    Friend WithEvents lbCusID As System.Windows.Forms.Label
    Friend WithEvents cmbSearchCus As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents optOK As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkDate As System.Windows.Forms.CheckBox
    Friend WithEvents chkCus As System.Windows.Forms.CheckBox
    Friend WithEvents Date02 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Date01 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lsvShowBill As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmbNew = New System.Windows.Forms.Button()
        Me.cmbEditDoc = New System.Windows.Forms.Button()
        Me.txtEditNo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.checkPrint = New System.Windows.Forms.CheckBox()
        Me.optDocN = New System.Windows.Forms.RadioButton()
        Me.optX = New System.Windows.Forms.RadioButton()
        Me.optDocV = New System.Windows.Forms.RadioButton()
        Me.lbAns = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lsvShowBill = New System.Windows.Forms.ListView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TreeView2 = New System.Windows.Forms.TreeView()
        Me.cmbTest = New System.Windows.Forms.Button()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbExit = New System.Windows.Forms.Button()
        Me.chkCus = New System.Windows.Forms.CheckBox()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Date02 = New System.Windows.Forms.DateTimePicker()
        Me.Date01 = New System.Windows.Forms.DateTimePicker()
        Me.lbCusName = New System.Windows.Forms.Label()
        Me.cmbSearchCus = New System.Windows.Forms.Button()
        Me.optOK = New System.Windows.Forms.Button()
        Me.lbCusID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboDClist = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbDBName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbNew
        '
        Me.cmbNew.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmbNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmbNew.ForeColor = System.Drawing.Color.White
        Me.cmbNew.Location = New System.Drawing.Point(225, 10)
        Me.cmbNew.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbNew.Name = "cmbNew"
        Me.cmbNew.Size = New System.Drawing.Size(272, 33)
        Me.cmbNew.TabIndex = 2
        Me.cmbNew.Text = "เอกสารใหม่"
        Me.cmbNew.UseVisualStyleBackColor = False
        '
        'cmbEditDoc
        '
        Me.cmbEditDoc.BackColor = System.Drawing.Color.Black
        Me.cmbEditDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbEditDoc.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbEditDoc.ForeColor = System.Drawing.Color.Yellow
        Me.cmbEditDoc.Location = New System.Drawing.Point(1206, 10)
        Me.cmbEditDoc.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbEditDoc.Name = "cmbEditDoc"
        Me.cmbEditDoc.Size = New System.Drawing.Size(98, 28)
        Me.cmbEditDoc.TabIndex = 1
        Me.cmbEditDoc.Text = "ค้นหา"
        Me.cmbEditDoc.UseVisualStyleBackColor = False
        '
        'txtEditNo
        '
        Me.txtEditNo.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtEditNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEditNo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtEditNo.ForeColor = System.Drawing.SystemColors.Info
        Me.txtEditNo.Location = New System.Drawing.Point(1026, 10)
        Me.txtEditNo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEditNo.Name = "txtEditNo"
        Me.txtEditNo.Size = New System.Drawing.Size(173, 27)
        Me.txtEditNo.TabIndex = 0
        Me.txtEditNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.lbAns)
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.cmbTest)
        Me.GroupBox1.Controls.Add(Me.TreeView1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.lbCusID)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(6, 41)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(1306, 564)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เลือกเอกสาร"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.checkPrint)
        Me.GroupBox3.Controls.Add(Me.optDocN)
        Me.GroupBox3.Controls.Add(Me.optX)
        Me.GroupBox3.Controls.Add(Me.optDocV)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 463)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(310, 88)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ประเภทเอกสาร"
        '
        'checkPrint
        '
        Me.checkPrint.AutoSize = True
        Me.checkPrint.Checked = True
        Me.checkPrint.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkPrint.Location = New System.Drawing.Point(6, 57)
        Me.checkPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.checkPrint.Name = "checkPrint"
        Me.checkPrint.Size = New System.Drawing.Size(105, 18)
        Me.checkPrint.TabIndex = 17
        Me.checkPrint.Text = "แสดงการพิมพ์"
        Me.checkPrint.UseVisualStyleBackColor = True
        '
        'optDocN
        '
        Me.optDocN.AutoSize = True
        Me.optDocN.BackColor = System.Drawing.Color.Red
        Me.optDocN.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optDocN.ForeColor = System.Drawing.Color.Red
        Me.optDocN.Location = New System.Drawing.Point(207, 22)
        Me.optDocN.Margin = New System.Windows.Forms.Padding(2)
        Me.optDocN.Name = "optDocN"
        Me.optDocN.Size = New System.Drawing.Size(100, 23)
        Me.optDocN.TabIndex = 15
        Me.optDocN.Text = "àÍ¡ÊÒÃ N"
        Me.optDocN.UseVisualStyleBackColor = False
        '
        'optX
        '
        Me.optX.AutoSize = True
        Me.optX.BackColor = System.Drawing.Color.Yellow
        Me.optX.Checked = True
        Me.optX.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optX.ForeColor = System.Drawing.Color.Yellow
        Me.optX.Location = New System.Drawing.Point(100, 22)
        Me.optX.Margin = New System.Windows.Forms.Padding(2)
        Me.optX.Name = "optX"
        Me.optX.Size = New System.Drawing.Size(100, 23)
        Me.optX.TabIndex = 16
        Me.optX.TabStop = True
        Me.optX.Text = "àÍ¡ÊÒÃ N"
        Me.optX.UseVisualStyleBackColor = False
        '
        'optDocV
        '
        Me.optDocV.AutoSize = True
        Me.optDocV.BackColor = System.Drawing.Color.Green
        Me.optDocV.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optDocV.ForeColor = System.Drawing.Color.Green
        Me.optDocV.Location = New System.Drawing.Point(6, 22)
        Me.optDocV.Margin = New System.Windows.Forms.Padding(2)
        Me.optDocV.Name = "optDocV"
        Me.optDocV.Size = New System.Drawing.Size(99, 23)
        Me.optDocV.TabIndex = 14
        Me.optDocV.Text = "àÍ¡ÊÒÃ V"
        Me.optDocV.UseVisualStyleBackColor = False
        '
        'lbAns
        '
        Me.lbAns.AutoSize = True
        Me.lbAns.Location = New System.Drawing.Point(150, 438)
        Me.lbAns.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbAns.Name = "lbAns"
        Me.lbAns.Size = New System.Drawing.Size(47, 14)
        Me.lbAns.TabIndex = 8
        Me.lbAns.Text = "Label4"
        Me.lbAns.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 22)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1292, 410)
        Me.TabControl1.TabIndex = 13
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lsvShowBill)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(1284, 383)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lsvShowBill
        '
        Me.lsvShowBill.BackColor = System.Drawing.Color.DimGray
        Me.lsvShowBill.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lsvShowBill.ForeColor = System.Drawing.Color.Snow
        Me.lsvShowBill.FullRowSelect = True
        Me.lsvShowBill.GridLines = True
        Me.lsvShowBill.HideSelection = False
        Me.lsvShowBill.Location = New System.Drawing.Point(6, 6)
        Me.lsvShowBill.Margin = New System.Windows.Forms.Padding(2)
        Me.lsvShowBill.Name = "lsvShowBill"
        Me.lsvShowBill.Size = New System.Drawing.Size(1264, 352)
        Me.lsvShowBill.TabIndex = 11
        Me.lsvShowBill.UseCompatibleStateImageBehavior = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TreeView2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(1284, 383)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TreeView2
        '
        Me.TreeView2.Location = New System.Drawing.Point(6, 16)
        Me.TreeView2.Margin = New System.Windows.Forms.Padding(2)
        Me.TreeView2.Name = "TreeView2"
        Me.TreeView2.Size = New System.Drawing.Size(1254, 360)
        Me.TreeView2.TabIndex = 0
        '
        'cmbTest
        '
        Me.cmbTest.Location = New System.Drawing.Point(88, 436)
        Me.cmbTest.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbTest.Name = "cmbTest"
        Me.cmbTest.Size = New System.Drawing.Size(60, 22)
        Me.cmbTest.TabIndex = 9
        Me.cmbTest.Text = "Button1"
        Me.cmbTest.UseVisualStyleBackColor = True
        Me.cmbTest.Visible = False
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(628, 296)
        Me.TreeView1.Margin = New System.Windows.Forms.Padding(2)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(11, 8)
        Me.TreeView1.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmbExit)
        Me.GroupBox2.Controls.Add(Me.chkCus)
        Me.GroupBox2.Controls.Add(Me.chkDate)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Date02)
        Me.GroupBox2.Controls.Add(Me.Date01)
        Me.GroupBox2.Controls.Add(Me.lbCusName)
        Me.GroupBox2.Controls.Add(Me.cmbSearchCus)
        Me.GroupBox2.Controls.Add(Me.optOK)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(378, 438)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(905, 112)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ค้นหาข้อมูล"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 30)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "เลือกวันที่"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 76)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "เลือกลูกค้า"
        '
        'cmbExit
        '
        Me.cmbExit.BackColor = System.Drawing.Color.Maroon
        Me.cmbExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbExit.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.cmbExit.ForeColor = System.Drawing.Color.White
        Me.cmbExit.Location = New System.Drawing.Point(740, 52)
        Me.cmbExit.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbExit.Name = "cmbExit"
        Me.cmbExit.Size = New System.Drawing.Size(153, 48)
        Me.cmbExit.TabIndex = 12
        Me.cmbExit.Text = "ออก"
        Me.cmbExit.UseVisualStyleBackColor = False
        '
        'chkCus
        '
        Me.chkCus.Location = New System.Drawing.Point(14, 73)
        Me.chkCus.Margin = New System.Windows.Forms.Padding(2)
        Me.chkCus.Name = "chkCus"
        Me.chkCus.Size = New System.Drawing.Size(16, 24)
        Me.chkCus.TabIndex = 11
        '
        'chkDate
        '
        Me.chkDate.BackColor = System.Drawing.SystemColors.Control
        Me.chkDate.Checked = True
        Me.chkDate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDate.Location = New System.Drawing.Point(14, 25)
        Me.chkDate.Margin = New System.Windows.Forms.Padding(2)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(16, 24)
        Me.chkDate.TabIndex = 10
        Me.chkDate.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(300, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ถึง"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Date02
        '
        Me.Date02.CalendarForeColor = System.Drawing.Color.Red
        Me.Date02.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Date02.Location = New System.Drawing.Point(328, 25)
        Me.Date02.Margin = New System.Windows.Forms.Padding(2)
        Me.Date02.Name = "Date02"
        Me.Date02.Size = New System.Drawing.Size(164, 24)
        Me.Date02.TabIndex = 8
        '
        'Date01
        '
        Me.Date01.CalendarForeColor = System.Drawing.Color.Red
        Me.Date01.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Date01.Location = New System.Drawing.Point(138, 25)
        Me.Date01.Margin = New System.Windows.Forms.Padding(2)
        Me.Date01.Name = "Date01"
        Me.Date01.Size = New System.Drawing.Size(164, 24)
        Me.Date01.TabIndex = 7
        '
        'lbCusName
        '
        Me.lbCusName.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbCusName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCusName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusName.ForeColor = System.Drawing.Color.White
        Me.lbCusName.Location = New System.Drawing.Point(138, 68)
        Me.lbCusName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCusName.Name = "lbCusName"
        Me.lbCusName.Size = New System.Drawing.Size(390, 30)
        Me.lbCusName.TabIndex = 4
        Me.lbCusName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbSearchCus
        '
        Me.cmbSearchCus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbSearchCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSearchCus.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.cmbSearchCus.ForeColor = System.Drawing.Color.White
        Me.cmbSearchCus.Location = New System.Drawing.Point(528, 67)
        Me.cmbSearchCus.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbSearchCus.Name = "cmbSearchCus"
        Me.cmbSearchCus.Size = New System.Drawing.Size(45, 32)
        Me.cmbSearchCus.TabIndex = 3
        Me.cmbSearchCus.Text = "..."
        Me.cmbSearchCus.UseVisualStyleBackColor = False
        '
        'optOK
        '
        Me.optOK.BackColor = System.Drawing.SystemColors.HotTrack
        Me.optOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optOK.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.optOK.ForeColor = System.Drawing.Color.Yellow
        Me.optOK.Location = New System.Drawing.Point(580, 52)
        Me.optOK.Margin = New System.Windows.Forms.Padding(2)
        Me.optOK.Name = "optOK"
        Me.optOK.Size = New System.Drawing.Size(152, 48)
        Me.optOK.TabIndex = 5
        Me.optOK.Text = "ตกลง"
        Me.optOK.UseVisualStyleBackColor = False
        '
        'lbCusID
        '
        Me.lbCusID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCusID.Location = New System.Drawing.Point(16, 438)
        Me.lbCusID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCusID.Name = "lbCusID"
        Me.lbCusID.Size = New System.Drawing.Size(63, 16)
        Me.lbCusID.TabIndex = 5
        Me.lbCusID.Text = "ÃËÑÊÅÙ¡¤éÒ"
        Me.lbCusID.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(980, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "เลขที่"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "คลังสินค้า"
        '
        'cboDClist
        '
        Me.cboDClist.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboDClist.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboDClist.ForeColor = System.Drawing.Color.White
        Me.cboDClist.FormattingEnabled = True
        Me.cboDClist.Location = New System.Drawing.Point(88, 10)
        Me.cboDClist.Margin = New System.Windows.Forms.Padding(2)
        Me.cboDClist.Name = "cboDClist"
        Me.cboDClist.Size = New System.Drawing.Size(123, 27)
        Me.cboDClist.TabIndex = 7
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbDBName})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 641)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 8, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1283, 24)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbDBName
        '
        Me.lbDBName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDBName.ForeColor = System.Drawing.Color.Red
        Me.lbDBName.Name = "lbDBName"
        Me.lbDBName.Size = New System.Drawing.Size(163, 19)
        Me.lbDBName.Text = "ToolStripStatusLabel1"
        '
        'frmBegin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1283, 665)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.cboDClist)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbNew)
        Me.Controls.Add(Me.txtEditNo)
        Me.Controls.Add(Me.cmbEditDoc)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmBegin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "โปรแกรมเปิดบิลขาย :  24-05-65"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim searchDS As DataSet = New DataSet
    Dim searchDA As SqlClient.SqlDataAdapter
    Dim chkBill As Boolean = False
    Dim ONo As String
    Dim BNo As String
    Dim StkID As String
    Dim StkName As String
    Dim StkPrice As Double
    Dim BillDate As Date
    Dim RunID As String = ""
    Dim CusName As String
    Dim BNum As Double
    Dim BPrice As Double
    Dim BBill As Double
    Dim BSum As Double

    Dim AnyData() As String

    Dim lvi As ListViewItem

    Dim LOrder As New ListViewItem

    Dim subDA As SqlClient.SqlDataAdapter

    Dim dTB As New DataTable   '  ãÊ¢éÍÁÙÅÅ§ã¹  cboVAT
    Dim Drow As DataRow

    Dim chkRow As Boolean

    Dim chkTB As Boolean

    Dim subDS As New DataSet

    Sub colorList(ByVal chkCost As Integer, ChkPrint As Integer, chkPrtDisp As Boolean)
        'Dim LOrder As ListViewItem
        'If chkEditDoc = True Then



        If chkCost = 0 Then
            If chkRow = False Then
                'If ChkPrint = 1 And chkPrtDisp = 1 Then
                '    lvi.BackColor = System.Drawing.Color.Orange
                'Else
                lvi.BackColor = System.Drawing.Color.DarkRed
                'End If
                lvi.ForeColor = System.Drawing.Color.White
                lvi.UseItemStyleForSubItems = True
                chkRow = True

            Else

                If ChkPrint = 1 And chkPrtDisp = True Then
                    'lvi.BackColor = System.Drawing.Color.DodgerBlue
                    'lvi.BackColor = System.Drawing.Color.DarkOliveGreen
                    lvi.BackColor = System.Drawing.Color.DarkSeaGreen
                Else
                    lvi.BackColor = System.Drawing.Color.Honeydew
                End If


                lvi.ForeColor = System.Drawing.Color.Black
                lvi.UseItemStyleForSubItems = True
                chkRow = True

            End If
        ElseIf chkCost = 1 Then

            If chkRow = False Then

                'If ChkPrint = 1 And chkPrtDisp = 1 Then
                '    lvi.BackColor = System.Drawing.Color.Orange
                'Else
                lvi.BackColor = System.Drawing.Color.Red
                'End If

                lvi.ForeColor = System.Drawing.Color.White
                lvi.UseItemStyleForSubItems = True
                chkRow = True


            Else
                If ChkPrint = 1 And chkPrtDisp = True Then
                    'lvi.BackColor = System.Drawing.Color.CadetBlue
                    lvi.BackColor = System.Drawing.Color.MediumSeaGreen
                Else
                    lvi.BackColor = System.Drawing.Color.White
                End If

                lvi.ForeColor = System.Drawing.Color.Black
                lvi.UseItemStyleForSubItems = True
                chkRow = True


            End If
        Else

            If ChkPrint = 1 And chkPrtDisp = True Then
                'lvi.BackColor = System.Drawing.Color.CadetBlue
                lvi.BackColor = System.Drawing.Color.OrangeRed
            Else
                lvi.BackColor = System.Drawing.Color.Yellow
            End If
            lvi.ForeColor = System.Drawing.Color.Black
            lvi.UseItemStyleForSubItems = True
            chkRow = True

        End If

    End Sub

    Sub addListDC()

        txtSQL = "Select * "
        txtSQL = txtSQL & "From wareHouse "
        txtSQL = txtSQL & "where Wh_Type='DC' "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "listData")

        If subDS.Tables("listData").Rows.Count > 0 Then

            cboDClist.DataSource = subDS.Tables("listData")
            cboDClist.ValueMember = "Wh_id"
            cboDClist.DisplayMember = "Wh_Name"
            'cboDClist.Text = ""

        End If

    End Sub

    Private Sub cmbNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNew.Click

        Dim frm1 As frmSale
        frm1 = New frmSale
        EditStatus = False 'ไม่ได้เป็นการแก้ไขเอกสาร แต่เป็นการสร้างเอกสารใหม่
        selCusiD = ""  ' ÃËÑÊÅÙ¡¤éÒ
        selCusName = "" ' ª×èÍÅÙ¡¤éÒ
        chkLoad = False
        'Lvi = lsvRev.SelectedItems(i)

        SelectNo2 = ""  'àÅ¢·Õè Order  
        'selCusiD = lsvRev.SelectedItems(i).SubItems.Item(2).Text()   ' ÃËÑÊÅÙ¡¤éÒ
        'selCusName = lsvRev.SelectedItems(i).SubItems.Item(3).Text() ' ª×èÍÅÙ¡¤éÒ
        SelectCode2 = "" ' ª×èÍÊÔ¹¤éÒ
        SelectNum2 = 0 ' ¨Ó¹Ç¹
        SelectRevNo2 = "" ' ãº¨Í§
        SelectTypeP_No2 = "" ' ãºàºÔ¡
        selectDetail = ""
        SelectPrice2 = 0

        EditNo = ""
        chkNew = True
        'chkEditDoc = False
        selWH = cboDClist.SelectedValue

        Me.Hide()
        frm1.ShowDialog(Me)


        Me.Show()
        Call reLoad()
        'Call HeadList()
        'Call Search2()

    End Sub

    Private Sub cmbEditDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEditDoc.Click

        Dim frm1 As frmSale
        frm1 = New frmSale
        If txtEditNo.Text <> "" Then
            chkEditDoc = True
            chkNew = False
            EditNo = txtEditNo.Text

            Me.Hide()
            frm1.ShowDialog(Me)
            Me.Show()
            chkNew = False
            chkEditDoc = False
            EditNo = ""
            txtEditNo.Text = ""
            lsvShowBill.Clear()
            chkDate.Checked = True
        Else
            MsgBox("ไม่พบเลขที่เอกสาร", MsgBoxStyle.OkOnly, "แจ้งเตือน")
            txtEditNo.Focus()
            Exit Sub
        End If

    End Sub

    Private Sub frmBegin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call setYear()

        'DBtools.openDB()
        lbDBName.Text = DBtools.strConn
        'MsgBox("time=" & getTimeSer())
        'Call addDataVAT()
        Call addListDC()
        chkItem = False
        chkDate.Checked = True
        Call reLoad()

    End Sub



    Private Sub txtEditNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEditNo.KeyDown
        Dim frm1 As frmSale
        If e.KeyCode = 13 Then
            If txtEditNo.Text <> "" Then
                chkEditDoc = True
                chkNew = False
                EditNo = txtEditNo.Text
                frm1 = New frmSale
                Me.Hide()
                frm1.ShowDialog(Me)
                Me.Show()
                chkNew = False
                chkEditDoc = False
                EditNo = ""
                txtEditNo.Text = ""
                lsvShowBill.Items.Clear()
                chkDate.Checked = True

                Call reLoad()
            Else
                MsgBox("ไม่พบเลขที่เอกสาร", MsgBoxStyle.OkOnly, "แจ้งเตือน")
                txtEditNo.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub frmBegin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            End
        End If

    End Sub


    Private Sub cmbSearchCus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSearchCus.Click
        Dim frmCustomer As searchCus = New searchCus
        'Dim frmCustomer As searchCus = New searchCus
        frmCustomer.ShowDialog()

        lbCusID.Text = selCusiD
        lbCusName.Text = selCusName

        selCusiD = ""
        selCusName = ""

    End Sub
    Sub reLoad()
        Call HeadList()
        Call Search2()
    End Sub

    Private Sub cmbOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optOK.Click
        Call reLoad()
        'Call HeadList()
        'Call Search2()
    End Sub

    Sub HeadList()

        If chkTB = True Then

            lsvShowBill.Columns.Clear()
            lsvShowBill.Items.Clear()
            chkTB = False

        End If

        lsvShowBill.Columns.Add("วันที่", 80, HorizontalAlignment.Right) '1
        lsvShowBill.Columns.Add("Type", 40, HorizontalAlignment.Center) '2
        lsvShowBill.Columns.Add("เลขที่", 110, HorizontalAlignment.Center) '3
        lsvShowBill.Columns.Add("Order", 100, HorizontalAlignment.Center) '4
        lsvShowBill.Columns.Add("ชื่อลูกค้า", 220, HorizontalAlignment.Left) '5
        lsvShowBill.Columns.Add("Vatลูกค้า", 1, HorizontalAlignment.Right) '6
        lsvShowBill.Columns.Add("ชื่อสินค้า", 250, HorizontalAlignment.Left) '7
        lsvShowBill.Columns.Add("จำนวน", 80, HorizontalAlignment.Right) '8
        lsvShowBill.Columns.Add("ราคาต่อหน่วย", 100, HorizontalAlignment.Right) '9
        lsvShowBill.Columns.Add("ราคารวม", 100, HorizontalAlignment.Right) '10
        lsvShowBill.Columns.Add("runID", 1, HorizontalAlignment.Right) '11
        lsvShowBill.Columns.Add("¼Ùéà»Ô´ºÔÅ", 1, HorizontalAlignment.Right) '12
        lsvShowBill.Columns.Add("ãº¨Í§", 100, HorizontalAlignment.Center) '13
        lsvShowBill.Columns.Add("ใบเบิก", 100, HorizontalAlignment.Center) '14
        lsvShowBill.Columns.Add("PO", 250, HorizontalAlignment.Left) '15
        lsvShowBill.Columns.Add("Print", 60, HorizontalAlignment.Center) '16

        lsvShowBill.View = View.Details
        lsvShowBill.GridLines = True


        chkTB = True

    End Sub

    Sub Search()
        'Dim CusName2 As String
        'Dim CusName3 As String

        If chkBill = True Then
            searchDS.Tables("BillData").Clear()
            chkBill = False
        End If
        txtSQL1 = " SELECT    TranDataD.Dtl_type, TranDataD.Dtl_date, "
        txtSQL1 = txtSQL1 & "TranDataD.Dtl_no,TranDataD.Dtl_con_id,TranDataD.Dtl_Type_T,Dtl_Type_P,"
        txtSQL1 = txtSQL1 & " ArFile.AR_NAME,"
        txtSQL1 = txtSQL1 & " BaseMast.Stk_Name_1, TranDataD.Dtl_num, "
        txtSQL1 = txtSQL1 & " TranDataD.Dtl_price, TranDataD.Dtl_idtrade, TranDataD.Dtl_sum, TranDataH.Trh_Bill "

        txtSQL1 = txtSQL1 & " FROM TranDataD "
        txtSQL1 = txtSQL1 & " RIGHT OUTER JOIN TranDataH ON TranDataD.Dtl_no = TranDataH.Trh_No "
        txtSQL1 = txtSQL1 & " AND TranDataD.Dtl_type = TranDataH.Trh_Type "
        txtSQL1 = txtSQL1 & " LEFT OUTER JOIN ArFile "
        txtSQL1 = txtSQL1 & " ON TranDataD.Dtl_idcus = ArFile.AR_CUS_ID "
        txtSQL1 = txtSQL1 & " LEFT OUTER JOIN BaseMast "
        txtSQL1 = txtSQL1 & " ON TranDataD.Dtl_idtrade = BaseMast.Stk_Code"

        'txtSQL1 = " SELECT     TranDataD.Dtl_type, TranDataD.Dtl_date, TranDataD.Dtl_no, TranDataD.Dtl_con_id, ArFile.AR_NAME, BaseMast.Stk_Name_1, TranDataD.Dtl_num, "
        'txtSQL1 = txtSQL1 & " TranDataD.Dtl_price,TranDataD.Dtl_idtrade, TranDataD.Dtl_sum"
        'txtSQL1 = txtSQL1 & " FROM         TranDataD LEFT OUTER JOIN"
        'txtSQL1 = txtSQL1 & " ArFile ON TranDataD.Dtl_idcus = ArFile.AR_CUS_ID LEFT OUTER JOIN"
        'txtSQL1 = txtSQL1 & " BaseMast ON TranDataD.Dtl_idtrade = BaseMast.Stk_Code"
        txtSQL1 = txtSQL1 & " WHERE     (TranDataD.Dtl_type = 'S') "
        If chkCus.Checked = True And chkDate.Checked = False Then
            txtSQL1 = txtSQL1 & " and     (TranDataD.Dtl_idcus = '" & lbCusID.Text & "') "
        ElseIf chkCus.Checked = False And chkDate.Checked = True Then
            'txtSQL1 = txtSQL1 & " and     (TranDataD.Dtl_date>= '" & (Format(DateAdd(DateInterval.Year, -543, Date01.Value), "dd/MM/yyyy")) & "')  and (TranDataD.Dtl_date<= '" & (Format(DateAdd(DateInterval.Year, -543, Date02.Value), "dd/MM/yyyy")) & "')"

            '(((Month( Date01.Value) & "/" & DateAndTime.Day(Date01.Value) & "/" & Year(Date01.Value) - 543)))
            '(((Month( Date01.Value) & "/" & DateAndTime.Day(Date01.Value) & "/" & Year(Date01.Value) - 543)))
            txtSQL1 = txtSQL1 & " and     (TranDataD.Dtl_date>= '" & (((Month(Date01.Value) & "/" & DateAndTime.Day(Date01.Value) & "/" & Year(Date01.Value) - 543))) & "')  "
            txtSQL1 = txtSQL1 & "and (TranDataD.Dtl_date<= '" & (((Month(Date02.Value) & "/" & DateAndTime.Day(Date02.Value) & "/" & Year(Date02.Value) - 543))) & "')"
        ElseIf chkCus.Checked = True And chkDate.Checked = True Then
            txtSQL1 = txtSQL1 & " and (TranDataD.Dtl_idcus = '" & lbCusID.Text & "') "
            txtSQL1 = txtSQL1 & "and (TranDataD.Dtl_date>= '" & (((Month(Date01.Value) & "/" & DateAndTime.Day(Date01.Value) & "/" & Year(Date01.Value) - 543))) & "')  "
            txtSQL1 = txtSQL1 & "and (TranDataD.Dtl_date<= '" & (((Month(Date02.Value) & "/" & DateAndTime.Day(Date02.Value) & "/" & Year(Date02.Value) - 543))) & "')"
        End If
        txtSQL1 = txtSQL1 & " Order by     dtl_no"

        searchDA = New SqlClient.SqlDataAdapter(txtSQL1, Conn)
        searchDA.Fill(searchDS, "BillData")
        chkBill = True

        Dim maxI As Integer
        Dim i As Integer
        Dim docTypeT As String = ""
        Dim docTypeP As String = ""

        maxI = searchDS.Tables("BillData").Rows.Count

        For i = 0 To maxI - 1 'Ç¹ÅÙ»µÒÁàÅ¢·Õèorder
            BillDate = searchDS.Tables("BillData").Rows(i).Item("Dtl_Date")
            BNo = searchDS.Tables("BillData").Rows(i).Item("Dtl_no")
            ONo = searchDS.Tables("BillData").Rows(i).Item("Dtl_con_id")
            docTypeP = searchDS.Tables("BillData").Rows(i).Item("Dtl_Type_P")
            docTypeT = searchDS.Tables("BillData").Rows(i).Item("Dtl_Type_T")
            StkID = searchDS.Tables("BillData").Rows(i).Item("Dtl_idtrade")
            If IsDBNull(searchDS.Tables("BillData").Rows(i).Item("Stk_Name_1")) Then
                StkName = ""
            Else
                StkName = searchDS.Tables("BillData").Rows(i).Item("Stk_Name_1")
            End If

            StkPrice = searchDS.Tables("BillData").Rows(i).Item("Dtl_price")
            CusName = searchDS.Tables("BillData").Rows(i).Item("ar_name")
            BNum = searchDS.Tables("BillData").Rows(i).Item("dtl_num")
            BPrice = searchDS.Tables("BillData").Rows(i).Item("dtl_price")
            BSum = searchDS.Tables("BillData").Rows(i).Item("dtl_sum")
            BBill = searchDS.Tables("BillData").Rows(i).Item("trh_bill")


            AnyData = New String() {BillDate, BBill, BNo, ONo, CusName, BBill, StkName, BNum, StkPrice.ToString("#,##0.00"), BSum.ToString("#,##0.00"), "", docTypeT, docTypeP}
            lvi = New ListViewItem(AnyData)
            lsvShowBill.Items.Add(lvi)


            'If i <> 0 Then
            '    If ((i / 2) - (i \ 2)) = 0 Then

            '        lvi.BackColor = System.Drawing.Color.DimGray
            '        lvi.ForeColor = System.Drawing.Color.White
            '        lvi.UseItemStyleForSubItems = True
            '    Else

            '        lvi.BackColor = System.Drawing.Color.Pink
            '        lvi.ForeColor = System.Drawing.Color.Black
            '        lvi.UseItemStyleForSubItems = True
            '    End If
            'End If


        Next
    End Sub

    Sub Search2()

        'Dim CusName2 As String
        'Dim CusName3 As String
        Dim beforID As Integer = 0
        Dim afterID As Integer = 0
        chkRow = True
        Dim chkNo1 As String = ""
        Dim chkNo2 As String = ""
        Dim TrhNoType As String
        Dim docTypeT As String = ""
        Dim docTypeP As String = ""

        If chkBill = True Then
            searchDS.Tables("BillData").Clear()
            chkBill = False
        End If
        '  Trh_Bill  =  VAT

        txtSQL1 = " SELECT TranDataH.Trh_runID,TranDataH.Trh_Type,TranDataH.Trh_NoType,"
        txtSQL1 = txtSQL1 & "TranDataH.Trh_Date,TranDataH.Trh_no,TranDataH.Trh_Bill, "
        txtSQL1 = txtSQL1 & "ArFile.AR_NAME,"
        txtSQL1 = txtSQL1 & "TranDataD.Dtl_no,TranDataD.Dtl_con_id,TranDataD.Dtl_Type_T,Dtl_Type_P,"
        txtSQL1 = txtSQL1 & "TranDataD.Dtl_idtrade, BaseMast.Stk_Name_1, TranDataD.Dtl_num, "
        txtSQL1 = txtSQL1 & "TranDataD.Dtl_price, TranDataD.Dtl_sum,Trh_Print,Trh_Chk_Print,TranDataD.Dtl_Po "

        txtSQL1 = txtSQL1 & "FROM TranDataH Left JOIN TranDataD "
        txtSQL1 = txtSQL1 & "ON (TranDataH.Trh_type = TranDataD.Dtl_Type "
        txtSQL1 = txtSQL1 & "AND TranDataH.Trh_no = TranDataD.Dtl_No) "
        txtSQL1 = txtSQL1 & "LEFT JOIN ArFile "
        txtSQL1 = txtSQL1 & "ON TranDataH.Trh_Cus = ArFile.AR_CUS_ID "
        txtSQL1 = txtSQL1 & "LEFT OUTER JOIN BaseMast "
        txtSQL1 = txtSQL1 & "ON TranDataD.Dtl_idtrade = BaseMast.Stk_Code "
        txtSQL1 = txtSQL1 & "WHERE     (TranDataH.Trh_type = 'S') "

        If optX.Checked = True Then
            'txtSQL1=txtSQL1 & "And (TranDataH.Trh_NType='' ) "
        ElseIf optDocN.Checked = True Then
            txtSQL1 = txtSQL1 & "And (TranDataH.Trh_NoType='N' ) "
        Else
            txtSQL1 = txtSQL1 & "And not(TranDataH.Trh_NoType='N' ) "
        End If

        If chkCus.Checked = True And chkDate.Checked = False Then
            txtSQL1 = txtSQL1 & "And (TranDataH.trh_cus = '" & lbCusID.Text & "') "
            'txtSQL1 = txtSQL1 & "And (TranDataH.trh_date>= '2014/01/01') "
            'txtSQL1 = txtSQL1 & "And (TranDataH.Trh_date<= '" & (Format(DateAdd(DateInterval.Year, -543, Now), "MM/dd/yyyy")) & "') "
        ElseIf chkCus.Checked = False And chkDate.Checked = True Then
            'txtSQL1 = txtSQL1 & " and     (TranDataH.Trh_date>= '" & (Format(DateAdd(DateInterval.Year, -543, Date01.Value), "dd/MM/yyyy")) & "')  and (TranDataD.Dtl_date<= '" & (Format(DateAdd(DateInterval.Year, -543, Date02.Value), "dd/MM/yyyy")) & "')"
            'txtSQL1 = txtSQL1 & "And (TranDataH.trh_date>= '" & Format((Date01.Value), "MM/dd/yyyy") & "') "
            'txtSQL1 = txtSQL1 & "And (TranDataH.Trh_date<= '" & Format((Date02.Value), "MM/dd/yyyy") & "') "

            'If Month(Date01.Value) = 2 And DateAndTime.Day(Date01.Value) = 29 Then


            'Else
            '    txtSQL1 = txtSQL1 & "And (TranDataH.trh_date>= '" & (Format(DateAdd(DateInterval.Year, -543, Date01.Value), "MM/dd/yyyy")) & "') "

            'End If

            txtSQL1 = txtSQL1 & "And (TranDataH.trh_date>= '" & ((Month(Date01.Value) & "-" & DateAndTime.Day(Date01.Value) & "-" & Year(Date01.Value) - 543)) & "') "
            txtSQL1 = txtSQL1 & "And (TranDataH.trh_date<= '" & ((Month(Date02.Value) & "-" & DateAndTime.Day(Date02.Value) & "-" & Year(Date02.Value) - 543)) & "') "

            'txtSQL1 = txtSQL1 & "And (TranDataH.Trh_date<= '" & (Format(DateAdd(DateInterval.Year, -543, Date02.Value), "MM/dd/yyyy")) & "') "
        ElseIf chkCus.Checked = True And chkDate.Checked = True Then
            txtSQL1 = txtSQL1 & "And (TranDataH.trh_cus = '" & lbCusID.Text & "') "
            'txtSQL1 = txtSQL1 & "And (TranDataH.Trh_date>= '" & Format((Date01.Value), "MM/dd/yyyy") & "') "
            'txtSQL1 = txtSQL1 & "And (TranDataH.Trh_date<= '" &  Format(( Date02.Value), "MM/dd/yyyy") & "') "

            txtSQL1 = txtSQL1 & "And (TranDataH.trh_date>= '" & ((Month(Date01.Value) & "-" & DateAndTime.Day(Date01.Value) & "-" & Year(Date01.Value) - 543)) & "') "
            txtSQL1 = txtSQL1 & "And (TranDataH.trh_date<= '" & ((Month(Date02.Value) & "-" & DateAndTime.Day(Date02.Value) & "-" & Year(Date02.Value) - 543)) & "') "

            'txtSQL1 = txtSQL1 & "And (TranDataH.Trh_date>= '" & (Format(DateAdd(DateInterval.Year, -543, Date01.Value), "MM/dd/yyyy")) & "') "
            'txtSQL1 = txtSQL1 & "And (TranDataH.Trh_date<= '" & (Format(DateAdd(DateInterval.Year, -543, Date02.Value), "MM/dd/yyyy")) & "') "
        Else
            txtSQL1 = txtSQL1 & "And (TranDataH.trh_date>= '2014/01/01') "
            txtSQL1 = txtSQL1 & "And (TranDataH.trh_date<= '" & ((Month(Now) & "-" & DateAndTime.Day(Now) & "-" & Year(Now) - 543)) & "') "
            'txtSQL1 = txtSQL1 & "And (TranDataH.Trh_date<= '" & (Format(DateAdd(DateInterval.Year, -543, Now), "MM/dd/yyyy")) & "') "

            'txtSQL1 = txtSQL1 & "And (TranDataH.trh_date>= '2557/01/01') "
            'txtSQL1 = txtSQL1 & "And (TranDataH.Trh_date<= '" & Format((Now), "MM/dd/yyyy") & "') "
        End If
        txtSQL1 = txtSQL1 & "Order by     Trh_no desc  "

        searchDA = New SqlClient.SqlDataAdapter(txtSQL1, Conn)
        searchDA.Fill(searchDS, "BillData")
        chkBill = True

        Dim maxI As Integer
        Dim i As Integer
        Dim rowI As Integer = 0

        maxI = searchDS.Tables("BillData").Rows.Count
        'For i = 0 To maxI - 1 'Ç¹ÅÙ»µÒÁàÅ¢·Õè àÍ¡ÊÒÃ

        For i = 0 To searchDS.Tables("BillData").Rows.Count - 1

            BillDate = searchDS.Tables("BillData").Rows(i).Item("Trh_Date")
            BNo = searchDS.Tables("BillData").Rows(i).Item("Trh_no")
            If IsDBNull(searchDS.Tables("BillData").Rows(i).Item("Dtl_Type_P")) Then
                docTypeP = "ไม่พบข้อมูล"
            Else
                docTypeP = searchDS.Tables("BillData").Rows(i).Item("Dtl_Type_P")

            End If

            If IsDBNull(searchDS.Tables("BillData").Rows(i).Item("Dtl_Type_T")) Then
                docTypeT = "ไม่พบข้อมูล"
            Else
                docTypeT = searchDS.Tables("BillData").Rows(i).Item("Dtl_Type_T")
            End If



            CusName = searchDS.Tables("BillData").Rows(i).Item("ar_name")
            BBill = searchDS.Tables("BillData").Rows(i).Item("trh_Bill")

            If IsDBNull(searchDS.Tables("BillData").Rows(i).Item("Dtl_con_id")) Then
                ONo = "ไม่พบข้อมูล"
                chkRow = False
            Else
                ONo = searchDS.Tables("BillData").Rows(i).Item("Dtl_con_id")
            End If
            If IsDBNull(searchDS.Tables("BillData").Rows(i).Item("Dtl_idtrade")) Then
                StkID = "ไม่พบข้อมูล"
                StkName = "ไม่พบข้อมูลสินค้า "
                chkRow = False
            Else
                StkID = searchDS.Tables("BillData").Rows(i).Item("Dtl_idtrade")
                If IsDBNull(searchDS.Tables("BillData").Rows(i).Item("Stk_Name_1")) Then
                    StkName = "ติดต่อ ICT ICT "
                    chkRow = False
                Else
                    StkName = searchDS.Tables("BillData").Rows(i).Item("Stk_Name_1")
                End If
                StkPrice = searchDS.Tables("BillData").Rows(i).Item("Dtl_price")
                BNum = searchDS.Tables("BillData").Rows(i).Item("dtl_num")
                BPrice = searchDS.Tables("BillData").Rows(i).Item("dtl_price")
                BSum = searchDS.Tables("BillData").Rows(i).Item("dtl_sum")
            End If

            TrhNoType = searchDS.Tables("BillData").Rows(i).Item("Trh_noType")
            'If IsDBNull(searchDS.Tables("BillData").Rows(i).Item("Trh_runID")) Then
            '    RunID = 0
            'Else
            'If IsDBNull(searchDS.Tables("BillData").Rows(i).Item("Trh_runID")) Then
            '    RunID = "ÁÕ Error"
            'Else
            RunID = searchDS.Tables("BillData").Rows(i).Item("Trh_runID")
            'End If

            'End If

            'If beforID = 0 Then

            '    beforID = RunID

            'ElseIf RunID = beforID Then

            '    beforID = RunID + 1
            'Else

            'End If
            Dim DtlPO As String = ""
            If IsDBNull(searchDS.Tables("BillData").Rows(i).Item("Dtl_po")) Then
                DtlPO = ""
            Else
                DtlPO = searchDS.Tables("BillData").Rows(i).Item("Dtl_Po")

            End If
            Dim checkPr As Integer
            If IsDBNull(searchDS.Tables("BillData").Rows(i).Item("Trh_Chk_Print")) Then
                checkPr = 0
            Else
                checkPr = searchDS.Tables("BillData").Rows(i).Item("Trh_Chk_Print")
            End If

            AnyData = New String() {BillDate, TrhNoType, BNo, ONo, CusName, BBill, StkName, BNum,
                StkPrice.ToString("#,##0.00"), BSum.ToString("#,##0.00"),
                RunID, "", docTypeT, docTypeP, DtlPO, checkPr}

            lvi = New ListViewItem(AnyData)
            lsvShowBill.Items.Add(lvi)




            If checkPrint.Checked = False Then

                colorList(rowI, checkPr, False)

            ElseIf checkPrint.Checked = True Then

                colorList(rowI, checkPr, True)

            End If

            If rowI = 0 Then
                rowI = 1
            Else
                rowI = 0
            End If




            'If i <> 0 Then
            '    If ((i / 2) - (i \ 2)) = 0 Then

            '        lvi.BackColor = System.Drawing.Color.DimGray
            '        lvi.ForeColor = System.Drawing.Color.White
            '        lvi.UseItemStyleForSubItems = True
            '    Else

            '        lvi.BackColor = System.Drawing.Color.Pink
            '        lvi.ForeColor = System.Drawing.Color.Black
            '        lvi.UseItemStyleForSubItems = True
            '    End If
            'End If


        Next
    End Sub


    Private Sub cmbExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExit.Click
        End

    End Sub

    Private Sub cboDClist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDClist.SelectedIndexChanged



    End Sub

    Private Sub cboDClist_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDClist.SelectedValueChanged


    End Sub

    Private Sub cmbTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTest.Click

        If cboDClist.Text = "" Then

            MsgBox("äÁè¾º¢éÍÁÙÅ ¡ÒÃàÅ×Í¡¤ÅÑ§ÊÔ¹¤éÒ")

        Else

            strFactor = cboDClist.SelectedValue
            lbAns.Text = strFactor

        End If



    End Sub

    Private Sub txtEditNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEditNo.TextChanged

    End Sub

    Private Sub lsvShowBill_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsvShowBill.DoubleClick
        Dim i As Integer
        Dim frm1 As frmSale
        Dim chkPrint As Boolean = 0
        EditStatus = True 'เป็นการเข้ามาดูเอกสารเก่าหรือแก้ไขเอกสาร

        'Try

        For i = 0 To lsvShowBill.SelectedItems.Count - 1
            lvi = lsvShowBill.SelectedItems(i)
            chkEditDoc = True
            chkNew = False
            EditNo = lsvShowBill.SelectedItems(i).SubItems.Item(2).Text()
            ' chkPrint = lsvShowBill.SelectedItems(i).SubItems.Item(15).Text()
            txtEditNo.Text = EditNo
        Next

        frm1 = New frmSale

        Me.Hide()
        frm1.ShowDialog(Me)

        Me.Show()
        'Call HeadList()
        'Call Search2()
        'cmbNew.Enabled = False


        chkNew = False
        chkEditDoc = False
        EditNo = ""
        txtEditNo.Text = ""
        'lsvShowBill.Clear()
        'chkDate.Checked = False
        'Date01.Value = Now
        'Date02.Value = Now

        'Catch
        '    MsgBox("¾º¤ÇÒÁ¼Ô´¾ÅÒ´ ã¹ÃÐººá¨é§ ICT ãËéµÃÇ¨ÊÍº¡ÒÃ·Ó§Ò¹ ")
        '    Me.Show()
        '    'Call HeadList()
        '    'Call Search2()
        'End Try
    End Sub

    Private Sub optDocN_CheckedChanged(sender As Object, e As EventArgs) Handles optDocN.CheckedChanged
        Call HeadList()
        Call Search2()
    End Sub

    Private Sub optDocV_CheckedChanged(sender As Object, e As EventArgs) Handles optDocV.CheckedChanged
        Call HeadList()
        Call Search2()
    End Sub






    Private Sub frmBegin_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Call reLoad()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Date01_ValueChanged(sender As Object, e As EventArgs) Handles Date01.ValueChanged
        Date02.Value = Date01.Value
        Call reLoad()
    End Sub
End Class
