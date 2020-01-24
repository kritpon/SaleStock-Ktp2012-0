Imports System.Drawing.Printing
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
'Imports System.IO

'  08-01-57  á¡éä¢ ¢éÍ¼Ô´¾ÅÒ´ ¡ÒÃµÑ´ Order ·ÕèÁÕ¡ÒÃ¢ÒÂÊÔ¹¤éÒÍ×è¹á·¹ ÊÔ¹¤éÒ·ÕèÁÕ¡ÒÃ Order ÁÒ
Public Class frmSale
    Inherits System.Windows.Forms.Form

    Friend WithEvents cmbPrint2 As System.Windows.Forms.Button
    Friend WithEvents cmbFindStk As System.Windows.Forms.Button
    Friend WithEvents lbWhName As System.Windows.Forms.Label
    Friend WithEvents lbWHcode As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbAddr1 As System.Windows.Forms.Label
    Friend WithEvents lbAddr4 As System.Windows.Forms.Label
    Friend WithEvents txtShAddr4 As System.Windows.Forms.TextBox
    Friend WithEvents txtShAddr3 As System.Windows.Forms.TextBox
    Friend WithEvents txtShAddr2 As System.Windows.Forms.TextBox
    Friend WithEvents txtShAddr1 As System.Windows.Forms.TextBox
    Friend WithEvents lbContact As System.Windows.Forms.Label
    Friend WithEvents txtDepoSit As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents txtRefNo As System.Windows.Forms.TextBox
    Friend WithEvents lbAddr3 As System.Windows.Forms.Label
    Friend WithEvents lbAddr2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lbDisc As System.Windows.Forms.Label
    Friend WithEvents lbDicPage1 As System.Windows.Forms.Label
    Friend WithEvents lbDeposit As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lbTotalProfit As System.Windows.Forms.Label
    Friend WithEvents lbNProfit As System.Windows.Forms.Label
    Friend WithEvents lbTotalCost As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents lbTaxID As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cmbRecal As System.Windows.Forms.Button
    Friend WithEvents lbArAcct As System.Windows.Forms.Label
    Friend WithEvents txtTermDtl As System.Windows.Forms.TextBox
    Friend WithEvents lbCreLimit As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbTotal2 As System.Windows.Forms.TextBox
    Friend WithEvents lbVat As System.Windows.Forms.TextBox
    Friend WithEvents lbSumary As System.Windows.Forms.TextBox
    Friend WithEvents cmbPrList As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbSelRev As System.Windows.Forms.Button
    Friend WithEvents lbRevDocNo As System.Windows.Forms.Label
    Friend WithEvents lbTypeP As System.Windows.Forms.Label
    Friend WithEvents lbPONo As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtCondition As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtTypeP As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.Label
    Friend WithEvents chkLockTypeP As System.Windows.Forms.CheckBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents lbOldCode As System.Windows.Forms.Label
    Friend WithEvents cmbPrint1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbTotaliTemDisc As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbTotaliTemAmt As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lbTotalHDisc As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents lbProFitretio As Label
    Friend WithEvents lbAvgPrice As Label
    Friend WithEvents lbAvgCost As Label
    Friend WithEvents opt4D As RadioButton
    Friend WithEvents opt2D As RadioButton
    Friend WithEvents lbMapCode As Label
    Friend WithEvents lbMapName As Label
    Friend WithEvents cmbDel As System.Windows.Forms.Button





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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cmbExit As System.Windows.Forms.Button
    Friend WithEvents lbOrder As System.Windows.Forms.Label
    Friend WithEvents cmbSearch As System.Windows.Forms.Button
    Friend WithEvents lbCusName As System.Windows.Forms.Label
    Friend WithEvents lbCusID As System.Windows.Forms.Label
    Friend WithEvents txtSaleQty As System.Windows.Forms.TextBox
    Friend WithEvents txtDisc As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtDetail2 As System.Windows.Forms.TextBox
    Friend WithEvents cmbSave As System.Windows.Forms.Button
    Friend WithEvents dtp01 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ListEdit As System.Windows.Forms.ListView
    Friend WithEvents txtCusVat As System.Windows.Forms.TextBox
    Friend WithEvents txtCredit As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents txtCusDisc As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents llbAdd As System.Windows.Forms.LinkLabel
    Friend WithEvents lbStkCode As System.Windows.Forms.Label
    Friend WithEvents lbProductName As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents lbTotalWeight As System.Windows.Forms.Label
    Friend WithEvents lbCount As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbStock As System.Windows.Forms.Label
    Friend WithEvents cmbCancel As System.Windows.Forms.Button
    Friend WithEvents cmbOrder As System.Windows.Forms.Button
    Friend WithEvents lbStatus As System.Windows.Forms.Label
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    Friend WithEvents cboTypeDoc As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCutItem As System.Windows.Forms.Button
    Friend WithEvents txtSaleMan As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbSelSale As System.Windows.Forms.Label
    Friend WithEvents lbSaleName As System.Windows.Forms.Label
    Friend WithEvents txtDetail As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lbWHcode = New System.Windows.Forms.Label()
        Me.lbWhName = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtUserName = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.dtp01 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSaleMan = New System.Windows.Forms.TextBox()
        Me.cboTypeDoc = New System.Windows.Forms.ComboBox()
        Me.lbOrder = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtRefNo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.txtDepoSit = New System.Windows.Forms.TextBox()
        Me.txtCusDisc = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.txtDetail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbSelSale = New System.Windows.Forms.Label()
        Me.lbSaleName = New System.Windows.Forms.Label()
        Me.txtCusVat = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.ListEdit = New System.Windows.Forms.ListView()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.opt4D = New System.Windows.Forms.RadioButton()
        Me.opt2D = New System.Windows.Forms.RadioButton()
        Me.lbAvgCost = New System.Windows.Forms.Label()
        Me.lbAvgPrice = New System.Windows.Forms.Label()
        Me.lbProFitretio = New System.Windows.Forms.Label()
        Me.lbTotalWeight = New System.Windows.Forms.Label()
        Me.lbTotaliTemAmt = New System.Windows.Forms.Label()
        Me.lbTotalHDisc = New System.Windows.Forms.Label()
        Me.lbNProfit = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.lbTotalProfit = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lbTotalCost = New System.Windows.Forms.Label()
        Me.lbTotaliTemDisc = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lbSumary = New System.Windows.Forms.TextBox()
        Me.lbTotal2 = New System.Windows.Forms.TextBox()
        Me.lbVat = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbDeposit = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbDisc = New System.Windows.Forms.Label()
        Me.lbDicPage1 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbOldCode = New System.Windows.Forms.Label()
        Me.lbStkCode = New System.Windows.Forms.Label()
        Me.cmbDel = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtTypeP = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtCondition = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lbPONo = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbProductName = New System.Windows.Forms.Label()
        Me.cmbPrList = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbFindStk = New System.Windows.Forms.Button()
        Me.lbStock = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtDisc = New System.Windows.Forms.TextBox()
        Me.txtSaleQty = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtDetail2 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.llbAdd = New System.Windows.Forms.LinkLabel()
        Me.cmbOrder = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbCount = New System.Windows.Forms.Label()
        Me.cmbSave = New System.Windows.Forms.Button()
        Me.cmbCancel = New System.Windows.Forms.Button()
        Me.cmbCutItem = New System.Windows.Forms.Button()
        Me.cmbExit = New System.Windows.Forms.Button()
        Me.cmbPrint2 = New System.Windows.Forms.Button()
        Me.lbCusID = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cmbSearch = New System.Windows.Forms.Button()
        Me.lbCusName = New System.Windows.Forms.Label()
        Me.lbCreLimit = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTermDtl = New System.Windows.Forms.TextBox()
        Me.lbTaxID = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtCredit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lbMapName = New System.Windows.Forms.Label()
        Me.lbMapCode = New System.Windows.Forms.Label()
        Me.lbAddr3 = New System.Windows.Forms.Label()
        Me.lbAddr2 = New System.Windows.Forms.Label()
        Me.lbContact = New System.Windows.Forms.Label()
        Me.lbAddr4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbAddr1 = New System.Windows.Forms.Label()
        Me.txtShAddr4 = New System.Windows.Forms.TextBox()
        Me.txtShAddr3 = New System.Windows.Forms.TextBox()
        Me.txtShAddr2 = New System.Windows.Forms.TextBox()
        Me.txtShAddr1 = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.cmbPrint1 = New System.Windows.Forms.Button()
        Me.cmbRecal = New System.Windows.Forms.Button()
        Me.chkLockTypeP = New System.Windows.Forms.CheckBox()
        Me.cmbSelRev = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.lbRevDocNo = New System.Windows.Forms.Label()
        Me.lbTypeP = New System.Windows.Forms.Label()
        Me.lbArAcct = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbWHcode
        '
        Me.lbWHcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbWHcode.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbWHcode.ForeColor = System.Drawing.Color.White
        Me.lbWHcode.Location = New System.Drawing.Point(130, 19)
        Me.lbWHcode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbWHcode.Name = "lbWHcode"
        Me.lbWHcode.Size = New System.Drawing.Size(106, 46)
        Me.lbWHcode.TabIndex = 1
        Me.lbWHcode.Text = "Label9"
        Me.lbWHcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbWHcode.Visible = False
        '
        'lbWhName
        '
        Me.lbWhName.BackColor = System.Drawing.Color.Yellow
        Me.lbWhName.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbWhName.ForeColor = System.Drawing.Color.Black
        Me.lbWhName.Location = New System.Drawing.Point(248, 19)
        Me.lbWhName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbWhName.Name = "lbWhName"
        Me.lbWhName.Size = New System.Drawing.Size(274, 46)
        Me.lbWhName.TabIndex = 0
        Me.lbWhName.Text = "Label7"
        Me.lbWhName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbWhName.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.dtp01)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbWHcode)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lbWhName)
        Me.GroupBox1.Location = New System.Drawing.Point(2110, 146)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(476, 160)
        Me.GroupBox1.TabIndex = 78
        Me.GroupBox1.TabStop = False
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.Color.Black
        Me.txtUserName.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUserName.ForeColor = System.Drawing.Color.Yellow
        Me.txtUserName.Location = New System.Drawing.Point(96, 94)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(370, 50)
        Me.txtUserName.TabIndex = 98
        Me.txtUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Blue
        Me.Label32.Location = New System.Drawing.Point(16, 110)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(102, 29)
        Me.Label32.TabIndex = 97
        Me.Label32.Text = "User :"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtp01
        '
        Me.dtp01.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtp01.Location = New System.Drawing.Point(78, 21)
        Me.dtp01.Margin = New System.Windows.Forms.Padding(4)
        Me.dtp01.Name = "dtp01"
        Me.dtp01.Size = New System.Drawing.Size(390, 46)
        Me.dtp01.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(14, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "วันที่"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(8, 31)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(144, 40)
        Me.Label12.TabIndex = 83
        Me.Label12.Text = "¤ÅÑ§ÊÔ¹¤éÒ"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSaleMan
        '
        Me.txtSaleMan.BackColor = System.Drawing.Color.AliceBlue
        Me.txtSaleMan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaleMan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSaleMan.Location = New System.Drawing.Point(128, 94)
        Me.txtSaleMan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSaleMan.MaxLength = 60
        Me.txtSaleMan.Name = "txtSaleMan"
        Me.txtSaleMan.ReadOnly = True
        Me.txtSaleMan.Size = New System.Drawing.Size(96, 35)
        Me.txtSaleMan.TabIndex = 65
        Me.txtSaleMan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboTypeDoc
        '
        Me.cboTypeDoc.BackColor = System.Drawing.Color.White
        Me.cboTypeDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTypeDoc.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboTypeDoc.ForeColor = System.Drawing.Color.Blue
        Me.cboTypeDoc.ItemHeight = 39
        Me.cboTypeDoc.Location = New System.Drawing.Point(30, 21)
        Me.cboTypeDoc.Margin = New System.Windows.Forms.Padding(4)
        Me.cboTypeDoc.Name = "cboTypeDoc"
        Me.cboTypeDoc.Size = New System.Drawing.Size(414, 47)
        Me.cboTypeDoc.TabIndex = 73
        '
        'lbOrder
        '
        Me.lbOrder.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbOrder.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbOrder.ForeColor = System.Drawing.Color.White
        Me.lbOrder.Location = New System.Drawing.Point(500, 146)
        Me.lbOrder.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbOrder.Name = "lbOrder"
        Me.lbOrder.Size = New System.Drawing.Size(206, 50)
        Me.lbOrder.TabIndex = 14
        Me.lbOrder.Text = "Order"
        Me.lbOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 87)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 42)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "เลขที่"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNo
        '
        Me.txtNo.BackColor = System.Drawing.Color.Black
        Me.txtNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNo.ForeColor = System.Drawing.Color.Yellow
        Me.txtNo.Location = New System.Drawing.Point(124, 83)
        Me.txtNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(286, 44)
        Me.txtNo.TabIndex = 3
        Me.txtNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtRefNo)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.RadioButton3)
        Me.GroupBox3.Controls.Add(Me.txtDepoSit)
        Me.GroupBox3.Controls.Add(Me.txtCusDisc)
        Me.GroupBox3.Controls.Add(Me.Label45)
        Me.GroupBox3.Location = New System.Drawing.Point(1000, 494)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(594, 196)
        Me.GroupBox3.TabIndex = 77
        Me.GroupBox3.TabStop = False
        '
        'txtRefNo
        '
        Me.txtRefNo.BackColor = System.Drawing.Color.Yellow
        Me.txtRefNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRefNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRefNo.Location = New System.Drawing.Point(140, 133)
        Me.txtRefNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRefNo.MaxLength = 50
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(442, 39)
        Me.txtRefNo.TabIndex = 80
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(24, 79)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(174, 40)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "หักเงินมัดจำ"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(40, 140)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(102, 35)
        Me.RadioButton3.TabIndex = 81
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Ref#"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'txtDepoSit
        '
        Me.txtDepoSit.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtDepoSit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDepoSit.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDepoSit.ForeColor = System.Drawing.Color.White
        Me.txtDepoSit.Location = New System.Drawing.Point(204, 79)
        Me.txtDepoSit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDepoSit.Name = "txtDepoSit"
        Me.txtDepoSit.Size = New System.Drawing.Size(378, 43)
        Me.txtDepoSit.TabIndex = 66
        Me.txtDepoSit.Text = "0"
        Me.txtDepoSit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCusDisc
        '
        Me.txtCusDisc.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.txtCusDisc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCusDisc.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCusDisc.ForeColor = System.Drawing.Color.White
        Me.txtCusDisc.Location = New System.Drawing.Point(202, 23)
        Me.txtCusDisc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCusDisc.Name = "txtCusDisc"
        Me.txtCusDisc.Size = New System.Drawing.Size(380, 43)
        Me.txtCusDisc.TabIndex = 65
        Me.txtCusDisc.Text = "0"
        Me.txtCusDisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Blue
        Me.Label45.Location = New System.Drawing.Point(16, 31)
        Me.Label45.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(174, 40)
        Me.Label45.TabIndex = 66
        Me.Label45.Text = "ส่วนลดหน้าบิล"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(14, 504)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(148, 35)
        Me.RadioButton1.TabIndex = 78
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "หมายเหตุ"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'txtDetail
        '
        Me.txtDetail.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetail.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDetail.ForeColor = System.Drawing.Color.White
        Me.txtDetail.Location = New System.Drawing.Point(168, 500)
        Me.txtDetail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDetail.Name = "txtDetail"
        Me.txtDetail.Size = New System.Drawing.Size(818, 43)
        Me.txtDetail.TabIndex = 77
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 100)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 31)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Sale"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbSelSale
        '
        Me.lbSelSale.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbSelSale.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbSelSale.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSelSale.ForeColor = System.Drawing.Color.White
        Me.lbSelSale.Location = New System.Drawing.Point(528, 83)
        Me.lbSelSale.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbSelSale.Name = "lbSelSale"
        Me.lbSelSale.Size = New System.Drawing.Size(62, 50)
        Me.lbSelSale.TabIndex = 79
        Me.lbSelSale.Text = "..."
        Me.lbSelSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbSaleName
        '
        Me.lbSaleName.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbSaleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbSaleName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbSaleName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSaleName.ForeColor = System.Drawing.Color.White
        Me.lbSaleName.Location = New System.Drawing.Point(86, 83)
        Me.lbSaleName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbSaleName.Name = "lbSaleName"
        Me.lbSaleName.Size = New System.Drawing.Size(440, 50)
        Me.lbSaleName.TabIndex = 78
        Me.lbSaleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCusVat
        '
        Me.txtCusVat.BackColor = System.Drawing.Color.AliceBlue
        Me.txtCusVat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCusVat.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCusVat.ForeColor = System.Drawing.Color.Red
        Me.txtCusVat.Location = New System.Drawing.Point(712, 88)
        Me.txtCusVat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCusVat.Name = "txtCusVat"
        Me.txtCusVat.Size = New System.Drawing.Size(122, 44)
        Me.txtCusVat.TabIndex = 69
        Me.txtCusVat.Text = "0"
        Me.txtCusVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Blue
        Me.Label46.Location = New System.Drawing.Point(608, 100)
        Me.Label46.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(106, 35)
        Me.Label46.TabIndex = 70
        Me.Label46.Text = "VAT %"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbStatus)
        Me.GroupBox2.Controls.Add(Me.ListEdit)
        Me.GroupBox2.Controls.Add(Me.txtDetail)
        Me.GroupBox2.Controls.Add(Me.GroupBox7)
        Me.GroupBox2.Controls.Add(Me.lbSumary)
        Me.GroupBox2.Controls.Add(Me.lbTotal2)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.lbVat)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.lbDeposit)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.lbDisc)
        Me.GroupBox2.Controls.Add(Me.lbDicPage1)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 496)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(2080, 833)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'lbStatus
        '
        Me.lbStatus.BackColor = System.Drawing.Color.Black
        Me.lbStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStatus.ForeColor = System.Drawing.Color.Chartreuse
        Me.lbStatus.Location = New System.Drawing.Point(1000, 702)
        Me.lbStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(594, 108)
        Me.lbStatus.TabIndex = 8
        Me.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListEdit
        '
        Me.ListEdit.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ListEdit.FullRowSelect = True
        Me.ListEdit.HideSelection = False
        Me.ListEdit.Location = New System.Drawing.Point(8, 17)
        Me.ListEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.ListEdit.Name = "ListEdit"
        Me.ListEdit.Size = New System.Drawing.Size(2050, 473)
        Me.ListEdit.TabIndex = 6
        Me.ListEdit.UseCompatibleStateImageBehavior = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.opt4D)
        Me.GroupBox7.Controls.Add(Me.opt2D)
        Me.GroupBox7.Controls.Add(Me.lbAvgCost)
        Me.GroupBox7.Controls.Add(Me.lbAvgPrice)
        Me.GroupBox7.Controls.Add(Me.lbProFitretio)
        Me.GroupBox7.Controls.Add(Me.lbTotalWeight)
        Me.GroupBox7.Controls.Add(Me.lbTotaliTemAmt)
        Me.GroupBox7.Controls.Add(Me.lbTotalHDisc)
        Me.GroupBox7.Controls.Add(Me.lbNProfit)
        Me.GroupBox7.Controls.Add(Me.Label34)
        Me.GroupBox7.Controls.Add(Me.lbTotalProfit)
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Controls.Add(Me.Label20)
        Me.GroupBox7.Controls.Add(Me.lbTotalCost)
        Me.GroupBox7.Controls.Add(Me.lbTotaliTemDisc)
        Me.GroupBox7.Controls.Add(Me.Label10)
        Me.GroupBox7.Controls.Add(Me.Label28)
        Me.GroupBox7.Location = New System.Drawing.Point(16, 538)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox7.Size = New System.Drawing.Size(976, 265)
        Me.GroupBox7.TabIndex = 102
        Me.GroupBox7.TabStop = False
        '
        'opt4D
        '
        Me.opt4D.AutoSize = True
        Me.opt4D.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.opt4D.Location = New System.Drawing.Point(716, 163)
        Me.opt4D.Margin = New System.Windows.Forms.Padding(4)
        Me.opt4D.Name = "opt4D"
        Me.opt4D.Size = New System.Drawing.Size(120, 35)
        Me.opt4D.TabIndex = 106
        Me.opt4D.TabStop = True
        Me.opt4D.Text = "4 Digit"
        Me.opt4D.UseVisualStyleBackColor = True
        '
        'opt2D
        '
        Me.opt2D.AutoSize = True
        Me.opt2D.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.opt2D.Location = New System.Drawing.Point(716, 96)
        Me.opt2D.Margin = New System.Windows.Forms.Padding(4)
        Me.opt2D.Name = "opt2D"
        Me.opt2D.Size = New System.Drawing.Size(120, 35)
        Me.opt2D.TabIndex = 105
        Me.opt2D.TabStop = True
        Me.opt2D.Text = "2 Digit"
        Me.opt2D.UseVisualStyleBackColor = True
        '
        'lbAvgCost
        '
        Me.lbAvgCost.BackColor = System.Drawing.SystemColors.ControlText
        Me.lbAvgCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbAvgCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbAvgCost.ForeColor = System.Drawing.Color.Lime
        Me.lbAvgCost.Location = New System.Drawing.Point(528, 162)
        Me.lbAvgCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbAvgCost.Name = "lbAvgCost"
        Me.lbAvgCost.Size = New System.Drawing.Size(132, 42)
        Me.lbAvgCost.TabIndex = 104
        Me.lbAvgCost.Text = "0 %"
        Me.lbAvgCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbAvgPrice
        '
        Me.lbAvgPrice.BackColor = System.Drawing.SystemColors.ControlText
        Me.lbAvgPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbAvgPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbAvgPrice.ForeColor = System.Drawing.Color.Lime
        Me.lbAvgPrice.Location = New System.Drawing.Point(528, 27)
        Me.lbAvgPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbAvgPrice.Name = "lbAvgPrice"
        Me.lbAvgPrice.Size = New System.Drawing.Size(132, 42)
        Me.lbAvgPrice.TabIndex = 103
        Me.lbAvgPrice.Text = "0 %"
        Me.lbAvgPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbProFitretio
        '
        Me.lbProFitretio.BackColor = System.Drawing.SystemColors.ControlText
        Me.lbProFitretio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbProFitretio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbProFitretio.ForeColor = System.Drawing.Color.Lime
        Me.lbProFitretio.Location = New System.Drawing.Point(528, 208)
        Me.lbProFitretio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbProFitretio.Name = "lbProFitretio"
        Me.lbProFitretio.Size = New System.Drawing.Size(132, 42)
        Me.lbProFitretio.TabIndex = 102
        Me.lbProFitretio.Text = "0 %"
        Me.lbProFitretio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTotalWeight
        '
        Me.lbTotalWeight.BackColor = System.Drawing.Color.Black
        Me.lbTotalWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbTotalWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalWeight.ForeColor = System.Drawing.Color.Yellow
        Me.lbTotalWeight.Location = New System.Drawing.Point(812, 19)
        Me.lbTotalWeight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTotalWeight.Name = "lbTotalWeight"
        Me.lbTotalWeight.Size = New System.Drawing.Size(158, 48)
        Me.lbTotalWeight.TabIndex = 28
        Me.lbTotalWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTotaliTemAmt
        '
        Me.lbTotaliTemAmt.BackColor = System.Drawing.SystemColors.ControlText
        Me.lbTotaliTemAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbTotaliTemAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotaliTemAmt.ForeColor = System.Drawing.Color.Yellow
        Me.lbTotaliTemAmt.Location = New System.Drawing.Point(208, 27)
        Me.lbTotaliTemAmt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTotaliTemAmt.Name = "lbTotaliTemAmt"
        Me.lbTotaliTemAmt.Size = New System.Drawing.Size(306, 42)
        Me.lbTotaliTemAmt.TabIndex = 98
        Me.lbTotaliTemAmt.Text = "0"
        Me.lbTotaliTemAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTotalHDisc
        '
        Me.lbTotalHDisc.BackColor = System.Drawing.SystemColors.ControlText
        Me.lbTotalHDisc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbTotalHDisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalHDisc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbTotalHDisc.Location = New System.Drawing.Point(208, 117)
        Me.lbTotalHDisc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTotalHDisc.Name = "lbTotalHDisc"
        Me.lbTotalHDisc.Size = New System.Drawing.Size(306, 42)
        Me.lbTotalHDisc.TabIndex = 101
        Me.lbTotalHDisc.Text = "0"
        Me.lbTotalHDisc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbNProfit
        '
        Me.lbNProfit.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbNProfit.Location = New System.Drawing.Point(24, 213)
        Me.lbNProfit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNProfit.Name = "lbNProfit"
        Me.lbNProfit.Size = New System.Drawing.Size(178, 29)
        Me.lbNProfit.TabIndex = 87
        Me.lbNProfit.Text = "กำไร รวม :"
        Me.lbNProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label34.Location = New System.Drawing.Point(24, 123)
        Me.Label34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(178, 31)
        Me.Label34.TabIndex = 100
        Me.Label34.Text = "ลดหน้าบิล :"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTotalProfit
        '
        Me.lbTotalProfit.BackColor = System.Drawing.SystemColors.ControlText
        Me.lbTotalProfit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbTotalProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalProfit.ForeColor = System.Drawing.Color.Lime
        Me.lbTotalProfit.Location = New System.Drawing.Point(208, 208)
        Me.lbTotalProfit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTotalProfit.Name = "lbTotalProfit"
        Me.lbTotalProfit.Size = New System.Drawing.Size(306, 42)
        Me.lbTotalProfit.TabIndex = 88
        Me.lbTotalProfit.Text = "0"
        Me.lbTotalProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(24, 167)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(178, 31)
        Me.Label15.TabIndex = 89
        Me.Label15.Text = "ต้นทุน :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label20.Location = New System.Drawing.Point(20, 29)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(178, 38)
        Me.Label20.TabIndex = 99
        Me.Label20.Text = "รวม :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTotalCost
        '
        Me.lbTotalCost.BackColor = System.Drawing.SystemColors.ControlText
        Me.lbTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalCost.ForeColor = System.Drawing.Color.Ivory
        Me.lbTotalCost.Location = New System.Drawing.Point(208, 162)
        Me.lbTotalCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTotalCost.Name = "lbTotalCost"
        Me.lbTotalCost.Size = New System.Drawing.Size(306, 42)
        Me.lbTotalCost.TabIndex = 90
        Me.lbTotalCost.Text = "0"
        Me.lbTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTotaliTemDisc
        '
        Me.lbTotaliTemDisc.BackColor = System.Drawing.SystemColors.ControlText
        Me.lbTotaliTemDisc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbTotaliTemDisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotaliTemDisc.ForeColor = System.Drawing.Color.Red
        Me.lbTotaliTemDisc.Location = New System.Drawing.Point(208, 71)
        Me.lbTotaliTemDisc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTotaliTemDisc.Name = "lbTotaliTemDisc"
        Me.lbTotaliTemDisc.Size = New System.Drawing.Size(306, 42)
        Me.lbTotaliTemDisc.TabIndex = 96
        Me.lbTotaliTemDisc.Text = "0"
        Me.lbTotaliTemDisc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(20, 73)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(178, 38)
        Me.Label10.TabIndex = 97
        Me.Label10.Text = "ส่วนลด item :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Blue
        Me.Label28.Location = New System.Drawing.Point(656, 37)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(160, 31)
        Me.Label28.TabIndex = 29
        Me.Label28.Text = "น้ำหนัก (Kg)"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbSumary
        '
        Me.lbSumary.BackColor = System.Drawing.SystemColors.MenuText
        Me.lbSumary.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbSumary.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSumary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbSumary.Location = New System.Drawing.Point(1754, 504)
        Me.lbSumary.Margin = New System.Windows.Forms.Padding(4)
        Me.lbSumary.Name = "lbSumary"
        Me.lbSumary.Size = New System.Drawing.Size(304, 46)
        Me.lbSumary.TabIndex = 95
        Me.lbSumary.Text = "0"
        Me.lbSumary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbTotal2
        '
        Me.lbTotal2.BackColor = System.Drawing.Color.Black
        Me.lbTotal2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbTotal2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotal2.ForeColor = System.Drawing.Color.Cyan
        Me.lbTotal2.Location = New System.Drawing.Point(1758, 704)
        Me.lbTotal2.Margin = New System.Windows.Forms.Padding(4)
        Me.lbTotal2.Name = "lbTotal2"
        Me.lbTotal2.Size = New System.Drawing.Size(302, 46)
        Me.lbTotal2.TabIndex = 94
        Me.lbTotal2.Text = "0"
        Me.lbTotal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbVat
        '
        Me.lbVat.BackColor = System.Drawing.Color.Black
        Me.lbVat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbVat.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbVat.ForeColor = System.Drawing.Color.Yellow
        Me.lbVat.Location = New System.Drawing.Point(1758, 654)
        Me.lbVat.Margin = New System.Windows.Forms.Padding(4)
        Me.lbVat.Name = "lbVat"
        Me.lbVat.Size = New System.Drawing.Size(302, 46)
        Me.lbVat.TabIndex = 93
        Me.lbVat.Text = "0"
        Me.lbVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.Location = New System.Drawing.Point(1622, 706)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(142, 42)
        Me.Label19.TabIndex = 92
        Me.Label19.Text = "ยอดสุทธิ"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbDeposit
        '
        Me.lbDeposit.BackColor = System.Drawing.SystemColors.ControlText
        Me.lbDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbDeposit.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDeposit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbDeposit.Location = New System.Drawing.Point(1756, 602)
        Me.lbDeposit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDeposit.Name = "lbDeposit"
        Me.lbDeposit.Size = New System.Drawing.Size(306, 42)
        Me.lbDeposit.TabIndex = 83
        Me.lbDeposit.Text = "0"
        Me.lbDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label18.Location = New System.Drawing.Point(1580, 615)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(178, 29)
        Me.Label18.TabIndex = 84
        Me.Label18.Text = "เงินมัดจำ :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbDisc
        '
        Me.lbDisc.BackColor = System.Drawing.SystemColors.ControlText
        Me.lbDisc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbDisc.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.lbDisc.ForeColor = System.Drawing.Color.Red
        Me.lbDisc.Location = New System.Drawing.Point(1754, 552)
        Me.lbDisc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDisc.Name = "lbDisc"
        Me.lbDisc.Size = New System.Drawing.Size(306, 42)
        Me.lbDisc.TabIndex = 85
        Me.lbDisc.Text = "0"
        Me.lbDisc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbDicPage1
        '
        Me.lbDicPage1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lbDicPage1.Location = New System.Drawing.Point(1598, 563)
        Me.lbDicPage1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDicPage1.Name = "lbDicPage1"
        Me.lbDicPage1.Size = New System.Drawing.Size(160, 29)
        Me.lbDicPage1.TabIndex = 86
        Me.lbDicPage1.Text = "ส่วนลด :"
        Me.lbDicPage1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label16.Location = New System.Drawing.Point(1632, 517)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(142, 29)
        Me.Label16.TabIndex = 81
        Me.Label16.Text = "ยอดรวม :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(1634, 662)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(138, 29)
        Me.Label13.TabIndex = 79
        Me.Label13.Text = "Vat 7% :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbOldCode
        '
        Me.lbOldCode.BackColor = System.Drawing.Color.Black
        Me.lbOldCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbOldCode.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbOldCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbOldCode.Location = New System.Drawing.Point(6, 590)
        Me.lbOldCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbOldCode.Name = "lbOldCode"
        Me.lbOldCode.Size = New System.Drawing.Size(578, 48)
        Me.lbOldCode.TabIndex = 99
        Me.lbOldCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbStkCode
        '
        Me.lbStkCode.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbStkCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbStkCode.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStkCode.ForeColor = System.Drawing.Color.Black
        Me.lbStkCode.Location = New System.Drawing.Point(6, 525)
        Me.lbStkCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbStkCode.Name = "lbStkCode"
        Me.lbStkCode.Size = New System.Drawing.Size(578, 50)
        Me.lbStkCode.TabIndex = 25
        Me.lbStkCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbDel
        '
        Me.cmbDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDel.ForeColor = System.Drawing.Color.White
        Me.cmbDel.Location = New System.Drawing.Point(1832, 88)
        Me.cmbDel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDel.Name = "cmbDel"
        Me.cmbDel.Size = New System.Drawing.Size(232, 58)
        Me.cmbDel.TabIndex = 65
        Me.cmbDel.Text = "ลบรายการ"
        Me.cmbDel.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtTypeP)
        Me.GroupBox4.Controls.Add(Me.Label33)
        Me.GroupBox4.Controls.Add(Me.txtCondition)
        Me.GroupBox4.Controls.Add(Me.Label31)
        Me.GroupBox4.Controls.Add(Me.lbPONo)
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Controls.Add(Me.lbOrder)
        Me.GroupBox4.Controls.Add(Me.Label29)
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.lbProductName)
        Me.GroupBox4.Controls.Add(Me.cmbPrList)
        Me.GroupBox4.Controls.Add(Me.txtTotal)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.cmbFindStk)
        Me.GroupBox4.Controls.Add(Me.lbStock)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txtPrice)
        Me.GroupBox4.Controls.Add(Me.txtDisc)
        Me.GroupBox4.Controls.Add(Me.txtSaleQty)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.cmbDel)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.txtDetail2)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.llbAdd)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(16, 277)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(2080, 219)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'txtTypeP
        '
        Me.txtTypeP.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.txtTypeP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTypeP.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTypeP.ForeColor = System.Drawing.SystemColors.Info
        Me.txtTypeP.Location = New System.Drawing.Point(786, 148)
        Me.txtTypeP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTypeP.MaxLength = 50
        Me.txtTypeP.Name = "txtTypeP"
        Me.txtTypeP.Size = New System.Drawing.Size(264, 46)
        Me.txtTypeP.TabIndex = 93
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(718, 158)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(70, 27)
        Me.Label33.TabIndex = 83
        Me.Label33.Text = "ใบเบิก"
        '
        'txtCondition
        '
        Me.txtCondition.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCondition.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCondition.ForeColor = System.Drawing.SystemColors.Info
        Me.txtCondition.Location = New System.Drawing.Point(1364, 148)
        Me.txtCondition.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCondition.MaxLength = 50
        Me.txtCondition.Name = "txtCondition"
        Me.txtCondition.Size = New System.Drawing.Size(700, 46)
        Me.txtCondition.TabIndex = 90
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(1254, 150)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(116, 42)
        Me.Label31.TabIndex = 89
        Me.Label31.Text = "conditon"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbPONo
        '
        Me.lbPONo.BackColor = System.Drawing.Color.White
        Me.lbPONo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbPONo.Location = New System.Drawing.Point(134, 144)
        Me.lbPONo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPONo.Name = "lbPONo"
        Me.lbPONo.Size = New System.Drawing.Size(260, 54)
        Me.lbPONo.TabIndex = 83
        Me.lbPONo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(20, 150)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(152, 42)
        Me.Label30.TabIndex = 88
        Me.Label30.Text = "PO"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(406, 150)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(116, 42)
        Me.Label29.TabIndex = 87
        Me.Label29.Text = "Order :"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Yellow
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(1652, 96)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(168, 46)
        Me.TextBox1.TabIndex = 85
        Me.TextBox1.Text = "0"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.Location = New System.Drawing.Point(1584, 110)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(82, 42)
        Me.Label21.TabIndex = 86
        Me.Label21.Text = "รวม"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbProductName
        '
        Me.lbProductName.BackColor = System.Drawing.Color.Yellow
        Me.lbProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbProductName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbProductName.ForeColor = System.Drawing.Color.Black
        Me.lbProductName.Location = New System.Drawing.Point(72, 27)
        Me.lbProductName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbProductName.Name = "lbProductName"
        Me.lbProductName.Size = New System.Drawing.Size(888, 50)
        Me.lbProductName.TabIndex = 23
        Me.lbProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbPrList
        '
        Me.cmbPrList.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbPrList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbPrList.Location = New System.Drawing.Point(1512, 31)
        Me.cmbPrList.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPrList.Name = "cmbPrList"
        Me.cmbPrList.Size = New System.Drawing.Size(64, 52)
        Me.cmbPrList.TabIndex = 84
        Me.cmbPrList.Text = "..."
        Me.cmbPrList.UseVisualStyleBackColor = False
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.Yellow
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(1652, 29)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(168, 46)
        Me.txtTotal.TabIndex = 68
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(1584, 37)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(82, 42)
        Me.Label17.TabIndex = 67
        Me.Label17.Text = "รวมง"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbFindStk
        '
        Me.cmbFindStk.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbFindStk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbFindStk.Location = New System.Drawing.Point(960, 27)
        Me.cmbFindStk.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbFindStk.Name = "cmbFindStk"
        Me.cmbFindStk.Size = New System.Drawing.Size(90, 52)
        Me.cmbFindStk.TabIndex = 66
        Me.cmbFindStk.Text = "..."
        Me.cmbFindStk.UseVisualStyleBackColor = False
        '
        'lbStock
        '
        Me.lbStock.BackColor = System.Drawing.Color.Black
        Me.lbStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbStock.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStock.ForeColor = System.Drawing.Color.Yellow
        Me.lbStock.Location = New System.Drawing.Point(1150, 92)
        Me.lbStock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbStock.Name = "lbStock"
        Me.lbStock.Size = New System.Drawing.Size(124, 52)
        Me.lbStock.TabIndex = 30
        Me.lbStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(1066, 104)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 42)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Stock"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.Green
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrice.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPrice.ForeColor = System.Drawing.SystemColors.Info
        Me.txtPrice.Location = New System.Drawing.Point(1364, 31)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(146, 46)
        Me.txtPrice.TabIndex = 16
        Me.txtPrice.Text = "0"
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDisc
        '
        Me.txtDisc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDisc.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDisc.ForeColor = System.Drawing.Color.Red
        Me.txtDisc.Location = New System.Drawing.Point(1364, 96)
        Me.txtDisc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDisc.Name = "txtDisc"
        Me.txtDisc.Size = New System.Drawing.Size(212, 46)
        Me.txtDisc.TabIndex = 15
        Me.txtDisc.Text = "0"
        Me.txtDisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSaleQty
        '
        Me.txtSaleQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaleQty.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSaleQty.Location = New System.Drawing.Point(1152, 35)
        Me.txtSaleQty.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSaleQty.Name = "txtSaleQty"
        Me.txtSaleQty.Size = New System.Drawing.Size(122, 46)
        Me.txtSaleQty.TabIndex = 14
        Me.txtSaleQty.Text = "0"
        Me.txtSaleQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label26.Location = New System.Drawing.Point(1264, 106)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(116, 42)
        Me.Label26.TabIndex = 13
        Me.Label26.Text = "ส่วนลด"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label25.Location = New System.Drawing.Point(1288, 42)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(82, 42)
        Me.Label25.TabIndex = 12
        Me.Label25.Text = "ราคา"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label24.Location = New System.Drawing.Point(1058, 42)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(112, 42)
        Me.Label24.TabIndex = 11
        Me.Label24.Text = "จำนวน"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Blue
        Me.Label23.Location = New System.Drawing.Point(6, 48)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(54, 31)
        Me.Label23.TabIndex = 22
        Me.Label23.Text = "ขื่อ"
        '
        'txtDetail2
        '
        Me.txtDetail2.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtDetail2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetail2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDetail2.ForeColor = System.Drawing.SystemColors.Info
        Me.txtDetail2.Location = New System.Drawing.Point(130, 88)
        Me.txtDetail2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDetail2.MaxLength = 50
        Me.txtDetail2.Name = "txtDetail2"
        Me.txtDetail2.Size = New System.Drawing.Size(920, 44)
        Me.txtDetail2.TabIndex = 18
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(12, 100)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(116, 42)
        Me.Label27.TabIndex = 17
        Me.Label27.Text = "หมายเหตุ"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'llbAdd
        '
        Me.llbAdd.BackColor = System.Drawing.Color.DodgerBlue
        Me.llbAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.llbAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.llbAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.llbAdd.ForeColor = System.Drawing.Color.Yellow
        Me.llbAdd.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.llbAdd.Location = New System.Drawing.Point(1832, 19)
        Me.llbAdd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.llbAdd.Name = "llbAdd"
        Me.llbAdd.Size = New System.Drawing.Size(232, 60)
        Me.llbAdd.TabIndex = 19
        Me.llbAdd.TabStop = True
        Me.llbAdd.Text = "เพิ่มรายการ"
        Me.llbAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbOrder
        '
        Me.cmbOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbOrder.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbOrder.ForeColor = System.Drawing.Color.White
        Me.cmbOrder.Location = New System.Drawing.Point(26, 23)
        Me.cmbOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbOrder.Name = "cmbOrder"
        Me.cmbOrder.Size = New System.Drawing.Size(364, 90)
        Me.cmbOrder.TabIndex = 64
        Me.cmbOrder.Text = "เลือก Order"
        Me.cmbOrder.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(44, 113)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 42)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "ãºàºÔ¡ #"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCount
        '
        Me.lbCount.BackColor = System.Drawing.Color.Black
        Me.lbCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCount.ForeColor = System.Drawing.Color.Yellow
        Me.lbCount.Location = New System.Drawing.Point(46, 40)
        Me.lbCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCount.Name = "lbCount"
        Me.lbCount.Size = New System.Drawing.Size(380, 60)
        Me.lbCount.TabIndex = 4
        Me.lbCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbSave
        '
        Me.cmbSave.BackColor = System.Drawing.Color.Blue
        Me.cmbSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSave.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.cmbSave.ForeColor = System.Drawing.Color.Yellow
        Me.cmbSave.Location = New System.Drawing.Point(24, 590)
        Me.cmbSave.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSave.Name = "cmbSave"
        Me.cmbSave.Size = New System.Drawing.Size(360, 167)
        Me.cmbSave.TabIndex = 2
        Me.cmbSave.Text = "บันทึก/พิมพ์"
        Me.cmbSave.UseVisualStyleBackColor = False
        '
        'cmbCancel
        '
        Me.cmbCancel.BackColor = System.Drawing.Color.Yellow
        Me.cmbCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCancel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbCancel.ForeColor = System.Drawing.Color.Black
        Me.cmbCancel.Location = New System.Drawing.Point(26, 390)
        Me.cmbCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCancel.Name = "cmbCancel"
        Me.cmbCancel.Size = New System.Drawing.Size(364, 73)
        Me.cmbCancel.TabIndex = 5
        Me.cmbCancel.Text = "ยกเลิกเอกสาร"
        Me.cmbCancel.UseVisualStyleBackColor = False
        '
        'cmbCutItem
        '
        Me.cmbCutItem.BackColor = System.Drawing.Color.SlateGray
        Me.cmbCutItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbCutItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCutItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbCutItem.ForeColor = System.Drawing.Color.White
        Me.cmbCutItem.Location = New System.Drawing.Point(88, 837)
        Me.cmbCutItem.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCutItem.Name = "cmbCutItem"
        Me.cmbCutItem.Size = New System.Drawing.Size(364, 73)
        Me.cmbCutItem.TabIndex = 9
        Me.cmbCutItem.Text = "µÑ´ Order"
        Me.cmbCutItem.UseVisualStyleBackColor = False
        '
        'cmbExit
        '
        Me.cmbExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbExit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbExit.ForeColor = System.Drawing.Color.White
        Me.cmbExit.Location = New System.Drawing.Point(48, 787)
        Me.cmbExit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbExit.Name = "cmbExit"
        Me.cmbExit.Size = New System.Drawing.Size(360, 129)
        Me.cmbExit.TabIndex = 3
        Me.cmbExit.Text = "ออกจากโปรแกรม"
        Me.cmbExit.UseVisualStyleBackColor = False
        '
        'cmbPrint2
        '
        Me.cmbPrint2.BackColor = System.Drawing.Color.Purple
        Me.cmbPrint2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPrint2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbPrint2.ForeColor = System.Drawing.Color.White
        Me.cmbPrint2.Location = New System.Drawing.Point(26, 212)
        Me.cmbPrint2.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPrint2.Name = "cmbPrint2"
        Me.cmbPrint2.Size = New System.Drawing.Size(364, 83)
        Me.cmbPrint2.TabIndex = 10
        Me.cmbPrint2.Text = "พิมพ์ใบส่งของ A4"
        Me.cmbPrint2.UseVisualStyleBackColor = False
        '
        'lbCusID
        '
        Me.lbCusID.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbCusID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCusID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusID.ForeColor = System.Drawing.Color.Yellow
        Me.lbCusID.Location = New System.Drawing.Point(326, 17)
        Me.lbCusID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCusID.Name = "lbCusID"
        Me.lbCusID.Size = New System.Drawing.Size(128, 48)
        Me.lbCusID.TabIndex = 9
        Me.lbCusID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBox5.Controls.Add(Me.cmbSearch)
        Me.GroupBox5.Controls.Add(Me.lbCusName)
        Me.GroupBox5.Controls.Add(Me.lbSaleName)
        Me.GroupBox5.Controls.Add(Me.lbCreLimit)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.txtSaleMan)
        Me.GroupBox5.Controls.Add(Me.txtTermDtl)
        Me.GroupBox5.Controls.Add(Me.lbTaxID)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.txtCredit)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label44)
        Me.GroupBox5.Controls.Add(Me.txtCusVat)
        Me.GroupBox5.Controls.Add(Me.Label46)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.lbSelSale)
        Me.GroupBox5.Controls.Add(Me.lbCusID)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 0)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(858, 242)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        '
        'cmbSearch
        '
        Me.cmbSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbSearch.ForeColor = System.Drawing.Color.White
        Me.cmbSearch.Location = New System.Drawing.Point(776, 17)
        Me.cmbSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(62, 60)
        Me.cmbSearch.TabIndex = 11
        Me.cmbSearch.Text = "..."
        Me.cmbSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmbSearch.UseVisualStyleBackColor = False
        '
        'lbCusName
        '
        Me.lbCusName.BackColor = System.Drawing.Color.Blue
        Me.lbCusName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCusName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusName.ForeColor = System.Drawing.Color.White
        Me.lbCusName.Location = New System.Drawing.Point(86, 17)
        Me.lbCusName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCusName.Name = "lbCusName"
        Me.lbCusName.Size = New System.Drawing.Size(692, 60)
        Me.lbCusName.TabIndex = 10
        Me.lbCusName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbCreLimit
        '
        Me.lbCreLimit.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbCreLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCreLimit.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCreLimit.ForeColor = System.Drawing.Color.Yellow
        Me.lbCreLimit.Location = New System.Drawing.Point(88, 192)
        Me.lbCreLimit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCreLimit.Name = "lbCreLimit"
        Me.lbCreLimit.Size = New System.Drawing.Size(260, 48)
        Me.lbCreLimit.TabIndex = 78
        Me.lbCreLimit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(14, 206)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 35)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Cr.lm"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTermDtl
        '
        Me.txtTermDtl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtTermDtl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTermDtl.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTermDtl.Location = New System.Drawing.Point(214, 140)
        Me.txtTermDtl.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTermDtl.Name = "txtTermDtl"
        Me.txtTermDtl.Size = New System.Drawing.Size(620, 44)
        Me.txtTermDtl.TabIndex = 84
        '
        'lbTaxID
        '
        Me.lbTaxID.BackColor = System.Drawing.Color.White
        Me.lbTaxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbTaxID.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTaxID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbTaxID.Location = New System.Drawing.Point(444, 190)
        Me.lbTaxID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTaxID.Name = "lbTaxID"
        Me.lbTaxID.Size = New System.Drawing.Size(390, 50)
        Me.lbTaxID.TabIndex = 82
        Me.lbTaxID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Blue
        Me.Label22.Location = New System.Drawing.Point(360, 208)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(94, 35)
        Me.Label22.TabIndex = 83
        Me.Label22.Text = "TaxID"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCredit
        '
        Me.txtCredit.BackColor = System.Drawing.Color.AliceBlue
        Me.txtCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCredit.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCredit.ForeColor = System.Drawing.Color.Red
        Me.txtCredit.Location = New System.Drawing.Point(88, 138)
        Me.txtCredit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.ReadOnly = True
        Me.txtCredit.Size = New System.Drawing.Size(66, 44)
        Me.txtCredit.TabIndex = 68
        Me.txtCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(154, 152)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 35)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "วัน"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Blue
        Me.Label44.Location = New System.Drawing.Point(32, 150)
        Me.Label44.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(50, 35)
        Me.Label44.TabIndex = 67
        Me.Label44.Text = "Cr."
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 35)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 42)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ลูกค้า"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.cboTypeDoc)
        Me.GroupBox9.Controls.Add(Me.txtNo)
        Me.GroupBox9.Controls.Add(Me.Label2)
        Me.GroupBox9.Location = New System.Drawing.Point(2110, 10)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox9.Size = New System.Drawing.Size(476, 144)
        Me.GroupBox9.TabIndex = 81
        Me.GroupBox9.TabStop = False
        '
        'TabControl2
        '
        Me.TabControl2.Alignment = System.Windows.Forms.TabAlignment.Right
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(16, 13)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl2.Multiline = True
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1103, 263)
        Me.TabControl2.TabIndex = 82
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1062, 255)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ชื่อลูกค้า"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TabPage3.Controls.Add(Me.lbMapName)
        Me.TabPage3.Controls.Add(Me.lbMapCode)
        Me.TabPage3.Controls.Add(Me.lbAddr3)
        Me.TabPage3.Controls.Add(Me.lbAddr2)
        Me.TabPage3.Controls.Add(Me.lbContact)
        Me.TabPage3.Controls.Add(Me.lbAddr4)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.lbAddr1)
        Me.TabPage3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabPage3.Location = New System.Drawing.Point(4, 4)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Size = New System.Drawing.Size(1062, 255)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "ที่อยู่เปิดบิล"
        '
        'lbMapName
        '
        Me.lbMapName.BackColor = System.Drawing.Color.Blue
        Me.lbMapName.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbMapName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbMapName.Location = New System.Drawing.Point(866, 183)
        Me.lbMapName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMapName.Name = "lbMapName"
        Me.lbMapName.Size = New System.Drawing.Size(220, 46)
        Me.lbMapName.TabIndex = 9
        Me.lbMapName.Text = "Label15"
        Me.lbMapName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbMapCode
        '
        Me.lbMapCode.BackColor = System.Drawing.Color.Blue
        Me.lbMapCode.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbMapCode.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbMapCode.Location = New System.Drawing.Point(866, 129)
        Me.lbMapCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMapCode.Name = "lbMapCode"
        Me.lbMapCode.Size = New System.Drawing.Size(220, 46)
        Me.lbMapCode.TabIndex = 8
        Me.lbMapCode.Text = "Label15"
        Me.lbMapCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbAddr3
        '
        Me.lbAddr3.BackColor = System.Drawing.Color.Blue
        Me.lbAddr3.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbAddr3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbAddr3.Location = New System.Drawing.Point(82, 129)
        Me.lbAddr3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbAddr3.Name = "lbAddr3"
        Me.lbAddr3.Size = New System.Drawing.Size(766, 46)
        Me.lbAddr3.TabIndex = 7
        Me.lbAddr3.Text = "Label7"
        Me.lbAddr3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbAddr2
        '
        Me.lbAddr2.BackColor = System.Drawing.Color.Blue
        Me.lbAddr2.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbAddr2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbAddr2.Location = New System.Drawing.Point(82, 73)
        Me.lbAddr2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbAddr2.Name = "lbAddr2"
        Me.lbAddr2.Size = New System.Drawing.Size(766, 46)
        Me.lbAddr2.TabIndex = 6
        Me.lbAddr2.Text = "Label7"
        Me.lbAddr2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbContact
        '
        Me.lbContact.BackColor = System.Drawing.Color.Blue
        Me.lbContact.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbContact.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbContact.Location = New System.Drawing.Point(484, 183)
        Me.lbContact.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbContact.Name = "lbContact"
        Me.lbContact.Size = New System.Drawing.Size(360, 46)
        Me.lbContact.TabIndex = 5
        Me.lbContact.Text = "Label15"
        Me.lbContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbAddr4
        '
        Me.lbAddr4.BackColor = System.Drawing.Color.Blue
        Me.lbAddr4.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbAddr4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbAddr4.Location = New System.Drawing.Point(80, 183)
        Me.lbAddr4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbAddr4.Name = "lbAddr4"
        Me.lbAddr4.Size = New System.Drawing.Size(396, 46)
        Me.lbAddr4.TabIndex = 4
        Me.lbAddr4.Text = "Label15"
        Me.lbAddr4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(18, 19)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 46)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "·ÕèÍÂÙè"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbAddr1
        '
        Me.lbAddr1.BackColor = System.Drawing.Color.Blue
        Me.lbAddr1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbAddr1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbAddr1.Location = New System.Drawing.Point(82, 19)
        Me.lbAddr1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbAddr1.Name = "lbAddr1"
        Me.lbAddr1.Size = New System.Drawing.Size(766, 46)
        Me.lbAddr1.TabIndex = 0
        Me.lbAddr1.Text = "Label7"
        Me.lbAddr1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtShAddr4
        '
        Me.txtShAddr4.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtShAddr4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtShAddr4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtShAddr4.Location = New System.Drawing.Point(22, 206)
        Me.txtShAddr4.Margin = New System.Windows.Forms.Padding(4)
        Me.txtShAddr4.Name = "txtShAddr4"
        Me.txtShAddr4.Size = New System.Drawing.Size(762, 44)
        Me.txtShAddr4.TabIndex = 17
        '
        'txtShAddr3
        '
        Me.txtShAddr3.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtShAddr3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtShAddr3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtShAddr3.Location = New System.Drawing.Point(22, 150)
        Me.txtShAddr3.Margin = New System.Windows.Forms.Padding(4)
        Me.txtShAddr3.Name = "txtShAddr3"
        Me.txtShAddr3.Size = New System.Drawing.Size(762, 44)
        Me.txtShAddr3.TabIndex = 16
        '
        'txtShAddr2
        '
        Me.txtShAddr2.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtShAddr2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtShAddr2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtShAddr2.Location = New System.Drawing.Point(22, 94)
        Me.txtShAddr2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtShAddr2.Name = "txtShAddr2"
        Me.txtShAddr2.Size = New System.Drawing.Size(762, 44)
        Me.txtShAddr2.TabIndex = 15
        '
        'txtShAddr1
        '
        Me.txtShAddr1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtShAddr1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtShAddr1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtShAddr1.Location = New System.Drawing.Point(22, 40)
        Me.txtShAddr1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtShAddr1.Name = "txtShAddr1"
        Me.txtShAddr1.Size = New System.Drawing.Size(762, 44)
        Me.txtShAddr1.TabIndex = 14
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.lbCount)
        Me.GroupBox8.Controls.Add(Me.Label7)
        Me.GroupBox8.Location = New System.Drawing.Point(22, 12)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox8.Size = New System.Drawing.Size(458, 177)
        Me.GroupBox8.TabIndex = 93
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "GroupBox8"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.cmbPrint1)
        Me.GroupBox10.Controls.Add(Me.cmbRecal)
        Me.GroupBox10.Controls.Add(Me.chkLockTypeP)
        Me.GroupBox10.Controls.Add(Me.cmbSelRev)
        Me.GroupBox10.Controls.Add(Me.cmbSave)
        Me.GroupBox10.Controls.Add(Me.cmbOrder)
        Me.GroupBox10.Controls.Add(Me.cmbCancel)
        Me.GroupBox10.Controls.Add(Me.cmbPrint2)
        Me.GroupBox10.Location = New System.Drawing.Point(18, 4)
        Me.GroupBox10.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox10.Size = New System.Drawing.Size(418, 775)
        Me.GroupBox10.TabIndex = 94
        Me.GroupBox10.TabStop = False
        '
        'cmbPrint1
        '
        Me.cmbPrint1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.cmbPrint1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPrint1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbPrint1.ForeColor = System.Drawing.Color.White
        Me.cmbPrint1.Location = New System.Drawing.Point(26, 302)
        Me.cmbPrint1.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPrint1.Name = "cmbPrint1"
        Me.cmbPrint1.Size = New System.Drawing.Size(364, 83)
        Me.cmbPrint1.TabIndex = 95
        Me.cmbPrint1.Text = "พิมพ์ใบกำกับ"
        Me.cmbPrint1.UseVisualStyleBackColor = False
        '
        'cmbRecal
        '
        Me.cmbRecal.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmbRecal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbRecal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbRecal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbRecal.ForeColor = System.Drawing.Color.White
        Me.cmbRecal.Location = New System.Drawing.Point(26, 473)
        Me.cmbRecal.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbRecal.Name = "cmbRecal"
        Me.cmbRecal.Size = New System.Drawing.Size(364, 73)
        Me.cmbRecal.TabIndex = 65
        Me.cmbRecal.Text = "คำนวณใหม่"
        Me.cmbRecal.UseVisualStyleBackColor = False
        '
        'chkLockTypeP
        '
        Me.chkLockTypeP.AutoSize = True
        Me.chkLockTypeP.Checked = True
        Me.chkLockTypeP.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLockTypeP.Location = New System.Drawing.Point(116, 558)
        Me.chkLockTypeP.Margin = New System.Windows.Forms.Padding(4)
        Me.chkLockTypeP.Name = "chkLockTypeP"
        Me.chkLockTypeP.Size = New System.Drawing.Size(146, 29)
        Me.chkLockTypeP.TabIndex = 94
        Me.chkLockTypeP.Text = "Lock ใบเบิก"
        Me.chkLockTypeP.UseVisualStyleBackColor = True
        '
        'cmbSelRev
        '
        Me.cmbSelRev.BackColor = System.Drawing.Color.DarkGreen
        Me.cmbSelRev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSelRev.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbSelRev.ForeColor = System.Drawing.Color.White
        Me.cmbSelRev.Location = New System.Drawing.Point(26, 117)
        Me.cmbSelRev.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSelRev.Name = "cmbSelRev"
        Me.cmbSelRev.Size = New System.Drawing.Size(364, 90)
        Me.cmbSelRev.TabIndex = 65
        Me.cmbSelRev.Text = "เลือกใบเบิก"
        Me.cmbSelRev.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(2110, 319)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(480, 987)
        Me.TabControl1.TabIndex = 95
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox10)
        Me.TabPage2.Controls.Add(Me.cmbExit)
        Me.TabPage2.Location = New System.Drawing.Point(8, 8)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(464, 940)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.lbRevDocNo)
        Me.TabPage5.Controls.Add(Me.lbTypeP)
        Me.TabPage5.Controls.Add(Me.cmbCutItem)
        Me.TabPage5.Controls.Add(Me.lbArAcct)
        Me.TabPage5.Controls.Add(Me.GroupBox8)
        Me.TabPage5.Location = New System.Drawing.Point(8, 8)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage5.Size = New System.Drawing.Size(464, 940)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "TabPage5"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'lbRevDocNo
        '
        Me.lbRevDocNo.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbRevDocNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbRevDocNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbRevDocNo.ForeColor = System.Drawing.Color.White
        Me.lbRevDocNo.Location = New System.Drawing.Point(88, 762)
        Me.lbRevDocNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbRevDocNo.Name = "lbRevDocNo"
        Me.lbRevDocNo.Size = New System.Drawing.Size(348, 42)
        Me.lbRevDocNo.TabIndex = 87
        Me.lbRevDocNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbTypeP
        '
        Me.lbTypeP.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbTypeP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbTypeP.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTypeP.ForeColor = System.Drawing.Color.White
        Me.lbTypeP.Location = New System.Drawing.Point(88, 694)
        Me.lbTypeP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTypeP.Name = "lbTypeP"
        Me.lbTypeP.Size = New System.Drawing.Size(348, 42)
        Me.lbTypeP.TabIndex = 88
        Me.lbTypeP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbArAcct
        '
        Me.lbArAcct.BackColor = System.Drawing.Color.Black
        Me.lbArAcct.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbArAcct.ForeColor = System.Drawing.Color.Yellow
        Me.lbArAcct.Location = New System.Drawing.Point(18, 613)
        Me.lbArAcct.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbArAcct.Name = "lbArAcct"
        Me.lbArAcct.Size = New System.Drawing.Size(418, 58)
        Me.lbArAcct.TabIndex = 94
        Me.lbArAcct.Text = "LB"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.Button1)
        Me.GroupBox6.Controls.Add(Me.txtShAddr1)
        Me.GroupBox6.Controls.Add(Me.txtShAddr4)
        Me.GroupBox6.Controls.Add(Me.txtShAddr2)
        Me.GroupBox6.Controls.Add(Me.txtShAddr3)
        Me.GroupBox6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox6.Location = New System.Drawing.Point(1196, 2)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Size = New System.Drawing.Size(896, 275)
        Me.GroupBox6.TabIndex = 100
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "ที่จัดส่ง"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.BurlyWood
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(784, 38)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 50)
        Me.Button1.TabIndex = 85
        Me.Button1.Text = "..."
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(2612, 1388)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.lbOldCode)
        Me.Controls.Add(Me.lbStkCode)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSale"
        Me.Text = "โปรแกรมการขาย  [Update 23-01-63]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim frmPost As New frmRevOnline
    Dim frmCustomer As searchCus = New searchCus

    Dim prDoc As PrintDocument = New PrintDocument

    Dim prDlg As PrintDialog = New PrintDialog

    Dim UseFont As New Font("Cordia UPC", 19, FontStyle.Bold)
    Dim UseFont1 As New Font("MS Sans Serif", 9)

    Dim DS3 As DataSet = New DataSet
    Dim DA3 As SqlClient.SqlDataAdapter

    Dim DS4 As DataSet = New DataSet
    Dim DA4 As SqlClient.SqlDataAdapter
    Dim DS1 As DataSet = New DataSet
    Dim DA1 As SqlClient.SqlDataAdapter
    Dim DS As DataSet = New DataSet
    Dim DA As SqlClient.SqlDataAdapter
    Dim Drow As DataRow
    Dim dTB As New DataTable
    Dim txtSQLd As String

    Dim sb As StringBuilder
    Dim tr As SqlTransaction

    Dim ChangeCode As String

    Dim oldCode As String
    Dim NewCode As String
    '===================================================================
    ' µÑÇá»Ããªé·ÕèËÑÇàÍ¡ÊÒÃ
    Dim CusID As String = ""         '   ÃËÑÊÅÙ¡¤éÒ

    Dim DocID As String = ""         ' àÅ¢·ÕèàÍ¡ÊÒÃ  ·Õè¡ÓÅÑ§ ÊÃéÒ§/á¡éä¢   
    Dim VatType As String
    Dim IDNo As String = ""
    Dim runingDoc As String = ""
    Dim PackNo As String             ' àÅ¢·ÕèãºàºÔ¡
    Dim OrderNo As String            ' àÅ¢·Õè  Order  
    'Dim OrderNo As String = "s"
    'Dim con_Order As String = ""
    Dim whCode As String = ""        ' ÃËÑÊ¤ÅÑ§ÊÔ¹¤éÒ  

    Dim TrhDetail As String = ""

    Dim TrhDisc As Double = 0.0
    Dim TrhDePosit As Double = 0
    Dim TrhAmt As Double = 0
    Dim TrhVat As Double = 0
    Dim TrhTotal As Double = 0

    '     µÑÇá»Ã ÃÒÂ¡ÒÃÊÔ¹¤éÒ  + ÃÒ¤Ò  =========================================
    Dim stkCode As String
    'Dim DataNum As Integer
    Dim stkQty As Double
    Dim stkPrice As Double
    Dim stkWeight As Double
    Dim OrDerQty As Double

    'Dim OrderQty As Integer

    Dim i As Integer
    Dim itemInOrder As Integer = 0 'à¡çº¨Ó¹Ç¹order
    '===================================================================

    'Dim con_Order As String
    Dim Same As String
    Dim IssNum As Integer
    Dim IssWeight As Double
    Dim Iss As Integer
    Dim Or_Q1 As Integer
    Dim WIss As Double 'à¡çº¹¹.·Õè¨èÒÂ
    Dim Bal As Integer
    Dim WBal As Double

    Dim CusDel As String
    Dim Seq As Integer


    Dim BalWeight As Double
    Dim Edit As String
    Dim EditNum As Integer
    Dim EditWeight As Double
    Dim chkBase As Boolean

    '=============   Data ËÑÇºÔÅ ======================  copy   µÑÇá»ÃÁÒãËÁè  ¨Ò¡  sub Save01  - 8/11/56
    Dim docIDNo As String = ""
    Dim PickingDocNo As String

    'Dim PickingNo As String
    'Dim CusCode As String
    'Dim cusCode As String = ""
    'Dim idNo As String = ""
    'Dim runingDoc As String = ""
    'Dim OrderNo As String
    ''Dim DataOrder As String
    'Dim TrhDisc As Double = 0.0    '  ÊèÇ¹Å´Ë¹éÒºÔÅ
    'Dim TrhDetail As String = ""   '  ËÁÒÂàËµØ ËÑÇºÔÅ

    '  ============   ¢éÍÁÙÅÃÒÂ¡ÒÃÊÔ¹¤éÒ¢ÒÂ

    'Dim whCode As String = ""       '   ¤ÅÑ§ÊÔ¹¤éÒ
    'Dim stkCode As String = ""
    'Dim stkQty As Double
    'Dim stkPrice As Double
    'Dim stkWeight As Double
    'dim orderQty As Double
    'Dim DataNum As Integer

    '  ============   ¢éÍÁÙÅÃÒÂ¡ÒÃÊÔ¹¤éÒ¢ÒÂ =============    copy   µÑÇá»ÃÁÒãËÁè  ¨Ò¡  sub Save01  - 8/11/56

    Dim chkOrderLoad As Boolean = False
    Dim chkfrmLoad As Boolean = False
    Dim chkTrnH As Boolean = False
    Dim chkTrnD As Boolean = False
    Dim chkDetail As Boolean = False

    Dim chkSearch As Boolean = False
    Dim chkPrint As Boolean = False
    Dim chkStock As Boolean = False
    Dim chkDataD As Boolean = False
    Dim chkUpStock As Boolean = False
    Dim chkUpOrder As Boolean = False
    Dim chkOrder As Boolean = False
    Dim chkBal As Boolean = False
    Dim chkHead As Boolean = False
    Dim chkAR As Boolean = False

    Public chkPrnPO As Boolean = False
    Dim F_Date As Date

    Dim chkID As Boolean = False
    Dim chkSave As Boolean = False
    Dim chkArData As Boolean = False
    Dim chkProfit As Boolean = False

    Dim frmVat As New frmVat
    Dim frmCut As New frmCutItem
    'Dim frmFindCus As New searchCus
    Dim frmFindStk As New frmFindStk
    Dim frmSaleMan As frmSaleMan = New frmSaleMan

    Dim LOrder As New ListViewItem

    '========  µÑÇá»Ã ÊÓËÃÑº¡ÒÃà»Ô´àÍ¡ÊÒÃ¢Öé¹ÁÒá¡éä¢

    Dim editChk As Boolean = False
    Dim editStkCode As String = ""
    Dim editQty As Integer = 0
    Dim editStock As Integer = 0

    Private Sub cmbExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExit.Click
        If chkSave = True Then
            Me.Close()
        Else
            If MsgBox("ต้องการออกจากโปรแกรมใช่หรือไม", MsgBoxStyle.YesNo, "แจ้งเตือน") = MsgBoxResult.Yes Then
                Me.Close()

            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'selCusiD = ""
        'selCountry = ""
        'selAmphoe = ""
        'txtSaleQty.Text = "0"
        'txtPrice.Text = "0"

        Call ClearAll()

        lbTotaliTemDisc.Text = "0"
        lbTotaliTemAmt.Text = "0"
        txtUserName.Text = GetUserName()
        chkLockTypeP.Checked = True
        chkSaveOK = False

        sb = New StringBuilder
        Call addDataVat()
        chkfrmLoad = True
        'Call DBtools.DBConnection()
        'Call Factor1()
        'Call Factor2()
        'Call Factor3()

        '==================================================
        'âËÅ´ Ë¹éÒ¤¹ËÒÅÙ¡¤éÒ µÍ¹àÃÔèÁà¢éÒ
        'frmFindCus.ShowDialog()
        '==================================================


        lbWHcode.Text = selWH

        strFactor = selWH
        lbWhName.Text = DBtools.getWhName(selWH)


        lbStatus.Text = "¾ÃéÍÁ"
        'Call comboSale()
        'Call comboFactor()
        dtp01.Value = Today.ToShortDateString

        If chkNew = True Then
            Call frmCusSearch()
            If selCusiD = "" Then
                Me.Close()
            Else
                Call ShowSelRev()
            End If

        ElseIf chkEditDoc = True Then

            'GroupBox1.Enabled = False
            'GroupBox5.Enabled = False
            Call SearchData(EditNo)
            chkEditDoc = True
            'llbDel.Enabled = True
            'llbClear.Enabled = False
            ChkDClick = False
            'llbOk.Enabled = True

        End If

        setDBGrid()

        'Call HeadDataGrid1()
        'Call Table()


        'lbTotal.Text = "0.00"
        'txtDiscount.Text = "0"
        'Today = Date.Now

    End Sub

    Sub addDataVat()

        'dTB.Columns.Add(New DataColumn("T_Type", GetType(String)))
        'dTB.Columns.Add(New DataColumn("T_Name", GetType(String)))

        'Drow = dTB.NewRow
        'Drow(0) = ""
        'Drow(1) = ""
        'dTB.Rows.Add(Drow)

        'Drow = dTB.NewRow
        'Drow(0) = "V"
        'Drow(1) = "V" ' VAT"
        'dTB.Rows.Add(Drow)

        'Drow = dTB.NewRow
        'Drow(0) = "N"
        'Drow(1) = "N" ' No VAT"
        'dTB.Rows.Add(Drow)

        'Drow = dTB.NewRow
        'Drow(0) = "P"
        'Drow(1) = "P" '¤Ø³¾ÔÁ¾ì"
        'dTB.Rows.Add(Drow)

        'Drow = dTB.NewRow
        'Drow(0) = "M"
        'Drow(1) = "M" ' ¢ÒÂ¡èÍ¹ No VAT"
        'dTB.Rows.Add(Drow)

        'Drow = dTB.NewRow
        'Drow(0) = "B"
        'Drow(1) = "B" ' ¢ÒÂ¡èÍ¹ VAT"
        'dTB.Rows.Add(Drow)

        'Drow = dTB.NewRow
        'Drow(0) = "X"
        'Drow(1) = "X" ' Êè§¢Í§ à»Ô´ºÔÅ¡èÍ¹ "
        'dTB.Rows.Add(Drow)

        'Drow = dTB.NewRow
        'Drow(0) = "Y"
        'Drow(1) = "Y" ' Êè§¢Í§ à»Ô´ºÔÅ¡èÍ¹ "
        'dTB.Rows.Add(Drow)
        Dim DA As SqlClient.SqlDataAdapter
        Dim DS As New DataSet


        txtSQL = "Select (NoType_ID + '-' + NoType_Name)NoType_Name ,NoType_ID "
        txtSQL = txtSQL & "From NoTypeMast "
        txtSQL = txtSQL & "Order by NoType_VAT,NoType_ID DESC "

        DA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        DA.Fill(DS, "NoType")

        With cboTypeDoc
            .DataSource = DS.Tables("NoType")
            .DisplayMember = "NoType_Name"
            .ValueMember = "NoType_ID"
        End With
        cboTypeDoc.SelectedValue = "V"
        Dvat = "V"
    End Sub



    Sub setDBGrid()

        ListEdit.Columns.Add("No.", 30, HorizontalAlignment.Center) '0
        ListEdit.Columns.Add("PO No. ", 100, HorizontalAlignment.Center) 'àÅ¢·ÕèãºàºÔ¡  1
        ListEdit.Columns.Add("Order No.", 100, HorizontalAlignment.Center) '2
        ListEdit.Columns.Add("Cus Name", 1, HorizontalAlignment.Left) '3 
        ListEdit.Columns.Add("Stk_Code", 1, HorizontalAlignment.Left) '4
        ListEdit.Columns.Add("ชื่อสินค้า", 300, HorizontalAlignment.Left) '5

        ListEdit.Columns.Add("จำนวน", 80, HorizontalAlignment.Right) '6
        ListEdit.Columns.Add("ราคา", 100, HorizontalAlignment.Right) '7
        ListEdit.Columns.Add("ส่วนลด", 80, HorizontalAlignment.Right) 'ÊèÇ¹Å´/ÃÒÂ¡ÒÃ á¡éä¢ 08-04-59
        ListEdit.Columns.Add("หลักลด", 120, HorizontalAlignment.Right) '8

        ListEdit.Columns.Add("จำนวนเงินรวม", 130, HorizontalAlignment.Right) '9
        ' ÇÔà¤ÃÒÐËì
        ListEdit.Columns.Add("มูลค่าทุน ", 80, HorizontalAlignment.Right) '10
        ListEdit.Columns.Add("มูลค่ากำไร", 80, HorizontalAlignment.Right) '11
        ListEdit.Columns.Add("น้ำหนักขาย", 70, HorizontalAlignment.Right) '12
        ListEdit.Columns.Add("หมายเหตุ", 220, HorizontalAlignment.Left) '13
        ListEdit.Columns.Add("", 1, HorizontalAlignment.Center) 'ÃËÑÊÅÙ¡¤éÒ 14
        ListEdit.Columns.Add("", 1, HorizontalAlignment.Center) 'àÅ¢·Õè 15
        ListEdit.Columns.Add("", 1, HorizontalAlignment.Center) 'ÇÑ¹·Õè 16=


        '        ListEdit.Columns.Add("", 1, HorizontalAlignment.Center) 'µÑ´ 18 = 
        ListEdit.Columns.Add("", 40, HorizontalAlignment.Center) 'samecode 17=
        ListEdit.Columns.Add("", 40, HorizontalAlignment.Center) 'á¡éä¢ 18
        ListEdit.Columns.Add("", 40, HorizontalAlignment.Center) '¨Ó¹Ç¹¢ÒÂà´ÔÁ¡èÍ¹á¡éä¢ à¾×èÍ¹Óä»µÑ´ Stock 19
        ListEdit.Columns.Add("", 40, HorizontalAlignment.Center) '¹¹.¢ÒÂà´ÔÁ¡èÍ¹á¡éä¢ à¾×èÍ¹Óä»µÑ´ Stock 20
        ListEdit.Columns.Add("สถานะ", 70, HorizontalAlignment.Center) ' ºÍ¡Ê¶Ò¹Ð¡ÒÃ á¡éä¢ÃÒÂ¡ÒÃ  21
        ListEdit.Columns.Add("ใบจอง.", 150, HorizontalAlignment.Center) '22
        ListEdit.Columns.Add("ใบเบิก.", 120, HorizontalAlignment.Center) '23
        ListEdit.Columns.Add("Condition.", 220, HorizontalAlignment.Center) '24

        ListEdit.View = View.Details
        ListEdit.GridLines = True

    End Sub

    Sub SearchData(ByVal ENo As String)

        ListEdit.Items.Clear()
        DS.Clear()
        txtSQL1 = " SELECT    TranDataH.Trh_Type,TranDataH.Trh_noType, TranDataH.Trh_No, TranDataH.Trh_Date,"
        txtSQL1 = txtSQL1 & " TranDataH.Trh_cus, TranDataH.Trh_Amt, TranDataH.Trh_D_Amt, TranDataH.Trh_V_Amt, "
        txtSQL1 = txtSQL1 & " TranDataH.Trh_Disc, TranDataH.Trh_Full_Amt, TranDataH.Trh_Detail, TranDataH.Trh_Sale,"
        txtSQL1 = txtSQL1 & " TranDataH.Trh_Term, TranDataH.Trh_Cre_Lim,TranDataH.Trh_print, "

        txtSQL1 = txtSQL1 & " TranDataH.Trh_Bill, TranDataD.Dtl_idtrade, TranDataD.Dtl_num, TranDataD.Dtl_price,"
        txtSQL1 = txtSQL1 & " TranDataD.Dtl_sum, TranDataD.Dtl_detail,Dtl_Condition,TranDataD.Dtl_runnum ,"
        txtSQL1 = txtSQL1 & " TranDataD.Dtl_con_id,TranDataD.Dtl_Type_T,Dtl_Type_P,"
        txtSQL1 = txtSQL1 & " TranDataD.Dtl_po,TranDataD.Dtl_po,"
        txtSQL1 = txtSQL1 & " TranDataD.Dtl_T_Disc,TranDataD.Dtl_same_code, TranDataD.Dtl_cutA_code,"

        txtSQL1 = txtSQL1 & " ArFile.AR_NAME,ArFile.Ar_Tax_Code,ArFile.Ar_Acct, "
        txtSQL1 = txtSQL1 & " BaseMast.Stk_Name_1, BaseMast.Stk_Factor,SalesMan.SL_NAME, "
        txtSQL1 = txtSQL1 & " Trh_wh,Trh_Deposit,Trh_strDepoSit,Trh_Depo_Ref "

        txtSQL1 = txtSQL1 & " FROM ArFile RIGHT OUTER JOIN TranDataH "
        txtSQL1 = txtSQL1 & " LEFT OUTER JOIN SalesMan "
        txtSQL1 = txtSQL1 & " ON TranDataH.Trh_Sale = SalesMan.SL_ID "
        txtSQL1 = txtSQL1 & " ON ArFile.AR_CUS_ID = TranDataH.Trh_Cus  "


        txtSQL1 = txtSQL1 & " LEFT OUTER JOIN BaseMast "
        txtSQL1 = txtSQL1 & " RIGHT OUTER JOIN TranDataD  "
        txtSQL1 = txtSQL1 & " ON BaseMast.Stk_Code = TranDataD.Dtl_idtrade "
        txtSQL1 = txtSQL1 & " ON TranDataH.Trh_No = TranDataD.Dtl_no AND "
        txtSQL1 = txtSQL1 & " TranDataH.Trh_Type = TranDataD.Dtl_type"

        'txtSQL1 = txtSQL1 & " FROM         BaseMast RIGHT OUTER JOIN"
        'txtSQL1 = txtSQL1 & "     TranDataD ON BaseMast.Stk_Code = TranDataD.Dtl_idtrade RIGHT OUTER JOIN"
        'txtSQL1 = txtSQL1 & "        TranDataH LEFT OUTER JOIN"
        'txtSQL1 = txtSQL1 & "           ArFile ON TranDataH.Trh_Cus = ArFile.AR_CUS_ID ON TranDataD.Dtl_no = TranDataH.Trh_No AND TranDataD.Dtl_type = TranDataH.Trh_Type"
        txtSQL1 = txtSQL1 & " WHERE     (TranDataH.Trh_Type = 'S')"
        txtSQL1 = txtSQL1 & " and TranDatah.trh_no='" & ENo & "' "
        txtSQL1 = txtSQL1 & " order by dtl_runnum "

        If chkDetail = True Then
            DS.Tables("Detail").Clear()
            chkDetail = False
        End If

        DA = New SqlClient.SqlDataAdapter(txtSQL1, Conn)
        DA.Fill(DS, "Detail")
        chkDetail = True

        txtSQL = "Select * "
        txtSQL = txtSQL & "From TranDataH "
        txtSQL = txtSQL & "Where TranDataH.Trh_type='S' "
        txtSQL = txtSQL & "And TranDatah.Trh_no='" & ENo & "' "

        If chkTrnH = True Then
            DS.Tables("DataH").Clear()
            chkTrnH = False
        End If
        DA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        DA.Fill(DS, "DataH")
        chkTrnH = False

        txtSQL = "Select * "
        txtSQL = txtSQL & "From TranDataD "
        txtSQL = txtSQL & "Where TranDataD.Dtl_type='S' "
        txtSQL = txtSQL & "And TranDataD.Dtl_no='" & ENo & "' "
        If chkTrnH = True Then
            DS.Tables("DataD").Clear()
            chkTrnH = False
        End If
        DA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        DA.Fill(DS, "DataD")
        chkTrnD = False

        If DS.Tables("Detail").Rows.Count > 0 Then

            selCusiD = DS.Tables("Detail").Rows(0).Item("Trh_Cus")

            If DS.Tables("Detail").Rows(0).Item("trh_print") = "1" Then 'àªç¤ÇèÒâ´¹Â×¹ÂÑ¹áÅéÇËÃ×ÍÂÑ§

                MsgBox("เอกสารนี้ได้ยืนยันส่งบัญชีแล้ว โปรดตรวจสอบ ", MsgBoxStyle.OkOnly, "แจ้งเตือน")
                ' lbStatus.Text = "¾ÃéÍÁ"

                cmbSave.Visible = False
                cmbDel.Visible = False
                cmbCancel.Visible = False
                cmbPrint1.Visible = False
                cmbPrint2.Visible = False
                'ListEdit.Enabled = False

                GroupBox4.Visible = False
                GroupBox10.Visible = False


                'Me.Close()
                showData()
                lbStatus.Text = "ไม่สามารถแก้ไขได้"
            Else
                'ListEdit.Enabled = True
                cmbSave.Visible = True
                cmbDel.Visible = True
                cmbCancel.Visible = True
                cmbPrint1.Visible = True
                cmbPrint2.Visible = True
                GroupBox4.Visible = True
                GroupBox10.Visible = True

                showData()

            End If
            lockEdit()
        Else
            MsgBox("ไม่พบข้อมูล", MsgBoxStyle.OkOnly, "แจ้งเตือน")
            chkEditDoc = False

            chkNew = True

            Me.Close()

            '  ¡ÅÑºä» ·Õè from   frmBegin

        End If
    End Sub
    Sub showData()

        Dim i0, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16, i19, i18, i20, i21, i22 As String


        Dim setDigiCAL As String = "#,##0.00"
        'Dim DS As DataSet = New DataSet
        'Dim DA As SqlClient.SqlDataAdapter

        Dim strDisc As String = ""   '  i17
        Dim strTypeP As String = ""
        Dim strTypeT As String = ""
        Dim strCondition As String = ""
        Dim anydata() As String

        Dim i As Integer = 0
        Dim prDisc As Double = 0
        Dim Pr_Cost As Double = 0
        i22 = ""

        txtSQL = "Select * "
        txtSQL = txtSQL & "From ArFile "
        txtSQL = txtSQL & "Left Join MapSLineMast "
        txtSQL = txtSQL & "On Ar_Map_Code=Map_S_Line_Code "
        txtSQL = txtSQL & "Where Ar_Cus_id='" & DS.Tables("Detail").Rows(0).Item("Trh_Cus") & "'"

        DA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        DA.Fill(DS, "ArDetail")
        chkDetail = True
        selCusiD = DS.Tables("ArDetail").Rows(0).Item("Ar_Cus_id")
        If chkDataAmphoe(selCusiD) = False Then
            MsgBox("ยังไม่พบข้อมูลระบุ อำเภอ โปรดระบุ", MsgBoxStyle.Critical, "แจ้งเตือน")
            Dim frmAmphoe As frmSearchAmphoe = New frmSearchAmphoe
            frmAmphoe.ShowDialog(Me)

        End If

        '=============  à¾ÔèÁ·ÕèÍÂØèã¹¡ÒÃà»Ô´ºÔÅ ====================

        lbAddr1.Text = DS.Tables("ArDetail").Rows(0).Item("Ar_Addr")
        lbAddr2.Text = DS.Tables("ArDetail").Rows(0).Item("Ar_Addr_1")
        lbAddr3.Text = DS.Tables("ArDetail").Rows(0).Item("Ar_Addr_2")
        lbAddr4.Text = DS.Tables("ArDetail").Rows(0).Item("Ar_Tel_NO")
        lbContact.Text = DS.Tables("ArDetail").Rows(0).Item("Ar_Contact")
        txtShAddr1.Text = DS.Tables("ArDetail").Rows(0).Item("Ar_shp_VA")
        txtShAddr1.Text = DS.Tables("ArDetail").Rows(0).Item("Ar_shp_VA1")
        txtShAddr1.Text = DS.Tables("ArDetail").Rows(0).Item("Ar_shp_VA2")
        txtShAddr1.Text = DS.Tables("ArDetail").Rows(0).Item("Ar_shp_VA")
        lbArAcct.Text = DS.Tables("ArDetail").Rows(0).Item("Ar_Acct")

        If IsDBNull(DS.Tables("ArDetail").Rows(0).Item("Ar_Term_Dtl")) Then
            txtTermDtl.Text = ""
        Else
            txtTermDtl.Text = DS.Tables("ArDetail").Rows(0).Item("Ar_Term_Dtl")
        End If

        lbMapCode.Text = DS.Tables("ArDetail").Rows(0).Item("Ar_Map_Code")
        lbMapName.Text = DS.Tables("ArDetail").Rows(0).Item("Map_S_Line_Name")


        '=============  à¾ÔèÁ·ÕèÍÂØèã¹¡ÒÃà»Ô´ºÔÅ ====================

        dtp01.Value = Format(DS.Tables("Detail").Rows(0).Item("trh_date"), "dd/MM/yyyy")
        lbCusID.Text = DS.Tables("Detail").Rows(0).Item("trh_cus")
        PId = DS.Tables("Detail").Rows(0).Item("trh_cus")
        lbCusName.Text = DS.Tables("Detail").Rows(0).Item("ar_name")
        If IsDBNull(DS.Tables("Detail").Rows(0).Item("Ar_Tax_Code")) Then
            MsgBox("ไม่พบข้อมูลรหัสภาษี")
            lbTaxID.Text = "ไม่พบข้อมูล"
        Else
            lbTaxID.Text = DS.Tables("Detail").Rows(0).Item("Ar_Tax_Code")
        End If

        txtCredit.Text = DS.Tables("Detail").Rows(0).Item("trh_term")
        lbCreLimit.Text = DS.Tables("Detail").Rows(0).Item("trh_cre_lim")
        txtCusDisc.Text = DS.Tables("Detail").Rows(0).Item("trh_disc")
        txtCusVat.Text = DS.Tables("Detail").Rows(0).Item("trh_bill")
        txtSaleMan.Text = DS.Tables("Detail").Rows(0).Item("trh_sale")
        If IsDBNull(DS.Tables("Detail").Rows(0).Item("sl_name")) Then
            lbSaleName.Text = ""
        Else

            lbSaleName.Text = DS.Tables("Detail").Rows(0).Item("sl_name")
        End If

        cboTypeDoc.SelectedValue = DS.Tables("Detail").Rows(0).Item("trh_notype")
        Dvat = cboTypeDoc.SelectedValue
        txtNo.Text = DS.Tables("Detail").Rows(0).Item("trh_no")

        txtDetail.Text = DS.Tables("Detail").Rows(0).Item("trh_detail")
        lbWHcode.Text = DS.Tables("Detail").Rows(0).Item("trh_wh")
        lbWhName.Text = getWhName(lbWHcode.Text)

        If IsDBNull(DS.Tables("Detail").Rows(0).Item("trh_strDepoSit")) Then
            txtDepoSit.Text = 0
        Else
            txtDepoSit.Text = Trim(DS.Tables("Detail").Rows(0).Item("trh_strDeposit"))
        End If

        If IsDBNull(DS.Tables("Detail").Rows(0).Item("trh_depo_ref")) Then
            txtRefNo.Text = "N/A"
        Else
            'txtDepoSit.Text = DS.Tables("Detail").Rows(0).Item("trh_deposit")
            txtRefNo.Text = (DS.Tables("Detail").Rows(0).Item("trh_depo_ref"))
        End If

        'check ¡Ã³Õ·ÕèäÁÕÁÕ¢éÍÁÙÅã¹trandatad à¾×èÍ·Õè¨ÐÊÒÁÒÃ¶ÅºÃÒÂ¡ÒÃâ´Â·Õè head ÂÑ§ÍÂÙèä´é ¡Ã³Õ¨Í§ºÔÅ ËÃ×ÍºÔÅÁÕÃÒÂ¡ÒÃà´ÕÂÇáÅéÇä»¡´»ØèÁÅº¢éÍÁØÅ
        If Not IsDBNull(DS.Tables("Detail").Rows(0).Item("dtl_po")) Then

            'lbPNo.Text = DS.Tables("Detail").Rows(0).Item("dtl_po")

            'lbOrder.Text = DS.Tables("Detail").Rows(0).Item("dtl_con_id")
            'cboTypeDoc.SelectedValue = DS.Tables("Detail").Rows(0).Item("trh_noType")
            'lbTotal.Text = DS.Tables("Detail").Rows(0).Item("trh_d_amt")

            For i = 0 To DS.Tables("Detail").Rows.Count - 1

                With DS.Tables("Detail").Rows(i)
                    'i1 = i + 1
                    'Pr_Cost = DBtools.getCostByStk(.Item("dtl_idTrade").ToString, Now, True)

                    'MsgBox(" Pr_Code = " & Pr_Cost)

                    i0 = .Item("dtl_runnum")
                    i1 = .Item("dtl_po")
                    i2 = .Item("dtl_con_id")
                    If IsDBNull(.Item("dtl_type_P")) Then
                        strTypeP = ""
                    Else
                        strTypeP = .Item("dtl_Type_P")
                    End If
                    If IsDBNull(.Item("dtl_Type_T")) Then
                        strTypeT = ""
                    Else
                        strTypeT = .Item("dtl_Type_T")
                    End If

                    i3 = .Item("ar_name")
                    i4 = .Item("dtl_idTrade")
                    stkCode = i4

                    Pr_Cost = getCostByStk(stkCode, dtp01.Value, "", 0)
                    i5 = .Item("stk_name_1")
                    If lbArAcct.Text = "112010" Then
                        setDigiCAL = "#,##0.00"
                    Else
                        setDigiCAL = "#,##0.0000"
                    End If
                    '==========================================================
                    i6 = Format(.Item("dtl_num"), setDigiCAL)  '  ¨Ó¹Ç¹ÊÔ¹¤éÒ
                    i7 = Format(.Item("dtl_price"), setDigiCAL)  '  ÃÒ¤ÒµèÍË¹èÇÂ

                    If Microsoft.VisualBasic.Right(.Item("dtl_t_disc"), 1) = "b" Or Microsoft.VisualBasic.Right(.Item("dtl_t_disc"), 1) = "B" Then

                        prDisc = Format(CDbl(Microsoft.VisualBasic.Left(.Item("dtl_t_disc"), Len(.Item("dtl_t_disc")) - 1)), "#,###.00")


                    ElseIf Microsoft.VisualBasic.Right(.Item("dtl_t_disc"), 1) = "%" Then

                        prDisc = Format(CDbl(Microsoft.VisualBasic.Left(.Item("dtl_t_disc"), Len(.Item("dtl_t_disc")) - 1)), "#,###.00")
                        prDisc = ((.Item("dtl_price") * prDisc) / 100)

                    ElseIf .Item("dtl_t_disc") = 0 Or .Item("dtl_t_disc") = "" Then
                        prDisc = 0


                    ElseIf IsNumeric(txtDisc.Text) Then

                        prDisc = .Item("dtl_t_disc")


                    End If


                    i8 = Format((.Item("dtl_price") - prDisc), setDigiCAL)  ' Format(.Item("dtl_price") - ((.Item("dtl_price") * prDisc) / 100), setDigiCAL)
                    '==========================================================
                    i9 = Format(.Item("dtl_num") * (.Item("dtl_price") - prDisc), setDigiCAL)   '  Total                        
                    '==========================================================

                    '
                    '    If Microsoft.VisualBasic.Left(.Item("dtl_t_disc"), 1) = "%" Then

                    '    ElseIf Microsoft.VisualBasic.Left(.Item("dtl_t_disc"), 1) = "B" Then
                    '        prDisc = 
                    '    Else
                    '        prDisc = 0
                    '    End If


                    'Else

                    'End If

                    ' ÇÔà¤ÃÒÐËìì                              
                    i12 = Format(.Item("stk_factor") * .Item("dtl_num"), "#,###.00")   '  ¹éÓË¹Ñ¡

                    stkQty = .Item("dtl_num")
                    stkWeight = .Item("stk_factor") * .Item("dtl_num")

                    If DBtools.getCostType(stkCode) = 0 Then

                        i10 = Format(stkWeight * Pr_Cost, "#,###.00")    ' µé¹·Ø¹
                        i11 = Format(i9 - i10, "#,###.00")     ' ¡ÓäÃ

                    ElseIf DBtools.getCostType(stkCode) = 1 Then

                        i10 = Format(stkQty * Pr_Cost, "#,###.00")    ' µé¹·Ø¹
                        i11 = Format(i9 - i10, "#,###.00")     ' ¡ÓäÃ

                    Else


                        i10 = Format(stkWeight * Pr_Cost, "#,###.00")    ' µé¹·Ø¹
                        i11 = Format(i9 - i10, "#,###.00")     ' ¡ÓäÃ

                    End If
                    '==========================================================
                    If IsDBNull(.Item("dtl_condition")) Then
                        strCondition = ""
                    Else
                        strCondition = .Item("dtl_condition")
                    End If

                    i13 = .Item("dtl_detail")
                    i14 = .Item("trh_cus")
                    i15 = .Item("trh_no")
                    i16 = .Item("trh_date")
                    strDisc = .Item("dtl_t_disc")
                    '            i18 = .Item("dtl_cuta_code")
                    i18 = .Item("dtl_same_code")
                    i19 = "0"
                    i20 = Format(.Item("dtl_num"), "#,###.00")
                    i21 = Format(.Item("stk_factor") * .Item("dtl_num"), "#,###.00")

                    anydata = New String() {i0, i1, i2, i3, i4, i5, i6, i7, strDisc, i8, i9, i10, i11, i12, i13, i14, i15, i16, i18, i19, i20, i21, "", strTypeT, strTypeP, strCondition}
                    'lvi = New ListViewItem(anydata)
                    'ListEdit.Items.Add(lvi)

                    LOrder = New ListViewItem(anydata)
                    ListEdit.Items.Add(LOrder)


                    'Call sumTotal()

                    If i11 > 0 Then

                        colorList(1)
                    ElseIf i11 < 0 Then
                        colorList(0)
                    Else
                        colorList(2)
                    End If
                    'Call sumTotal()


                End With
            Next
        End If
        '   Lock   ª×èÍ-·ÕèÍÂÙè
        'If DS.Tables("Detail").Rows(0).Item("trh_cus") = "110667" Then
        '    GroupBox5.Enabled = True
        'End If

        lbCount.Text = DS.Tables("Detail").Rows.Count

        lbSumary.Text = Format(DS.Tables("DataH").Rows(0).Item("Trh_Amt"), "#,##0.00")

        'If ((DS.Tables("DataH").Rows(0).Item("Trh_noType") = "V" Or DS.Tables("DataH").Rows(0).Item("Trh_noType") = "P") And (DS.Tables("DataH").Rows(0).Item("Trh_Bill") = "0")) Then
        If ((DS.Tables("DataH").Rows(0).Item("Trh_noType") = "V" Or DS.Tables("DataH").Rows(0).Item("Trh_noType") = "P")) Then

            lbVat.Text = Format((DS.Tables("DataH").Rows(0).Item("Trh_Amt") * DS.Tables("DataH").Rows(0).Item("Trh_Bill")) / 100, "#,##0.00")
            lbTotal2.Text = Format(CDbl(lbSumary.Text) + CDbl(lbVat.Text), "#,##0.00")

            'ElseIf ((DS.Tables("DataH").Rows(0).Item("Trh_noType") = "V" Or DS.Tables("DataH").Rows(0).Item("Trh_noType") = "P") And (DS.Tables("DataH").Rows(0).Item("Trh_Bill") > "0")) Then

            '    lbVat.Text = Format(DS.Tables("DataH").Rows(0).Item("Trh_V_Amt"), "#,##0.00")
            '    lbTotal2.Text = Format(DS.Tables("DataH").Rows(0).Item("Trh_Amt") + DS.Tables("DataH").Rows(0).Item("Trh_V_Amt"), "#,##0.00")

        Else

            lbVat.Text = 0
            lbTotal2.Text = Format(DS.Tables("DataH").Rows(0).Item("Trh_Amt"), "#,##0.00")

        End If


        Call sumTotal()

        lbStatus.Text = "¡ÓÅÑ§á¡éä¢"

    End Sub
    Sub lockEdit()
        cboTypeDoc.Enabled = False

    End Sub

    Function AutoGenerateID(ByVal V_Type As String) As String


        Dim oldmonth As String = ""
        Dim newmonth As String = ""
        Dim runId As String = ""
        Dim showMonth As String = ""
        Dim idmonth As String = ""
        Dim years As String = ""

        Dim docNo As String = ""

        'Dim idcon As String
        'Dim test As String
        'Dim ID As 

        years = Microsoft.VisualBasic.Right(CStr(Year(F_Date)), 2)


        '**********************************************¢Í§ãËÁèºÔÅàÅ¢·Õèà¡Ô¹1000**********************************************
        'Try
        If CStr(V_Type) = "V" Or CStr(V_Type) = "P" Then

            V_Type = "V"

            txtSQL = "SELECT  top 1  Max(Trh_RunID) AS maxno, Trh_No "
            txtSQL = txtSQL & "FROM  TranDataH "
            txtSQL = txtSQL & "WHERE (Trh_Type='S') "
            txtSQL = txtSQL & "And left(trh_no,3)='V" & years & "' "
            '  µÑ´à´×Í¹ áÅÐ àÍÒà¢éÒ SQL àÅ×Í¡ÍÍ¡ÁÒ
            txtSQL = txtSQL & "AND RIGHT(LEFT(Trh_No, 5), 2) = '" & Format(Month(F_Date), "0#") & "' "

            txtSQL = txtSQL & "GROUP BY Trh_No "
            txtSQL = txtSQL & "ORDER BY Max(Trh_runid) DESC "
            txtSQL = txtSQL & " "

        ElseIf CStr(V_Type) = "N" Or CStr(V_Type) = "M" Then

            V_Type = "N"

            txtSQL = "SELECT   top 1 Max(Trh_RunID) AS maxno, Trh_No "
            txtSQL = txtSQL & "FROM   TranDataH "
            txtSQL = txtSQL & "WHERE (Trh_Type = 'S') "
            txtSQL = txtSQL & "And left(trh_no,3)='N" & years & "' "
            txtSQL = txtSQL & "AND RIGHT(LEFT(Trh_No, 5), 2) =  '" & Format(Month(F_Date), "0#") & "' "

            txtSQL = txtSQL & "GROUP BY Trh_No "
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
            '¨Ðä´éà´×Í¹¢Í§àÍ¡ÊÒÃãºÊØ´·éÒÂ
            oldmonth = CStr(Val(Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(CStr(DS.Tables("ID").Rows(0).Item("trh_no")), 5), 2)))
            ' à´×Í¹»Ñ¨¨ØºÑ¹
            newmonth = CStr(Month(F_Date))
            If oldmonth = newmonth Then

                If IsDBNull(DS.Tables("ID").Rows(0).Item("maxno")) Then
                    'test = DS.Tables("ID").Rows(0).Item("trh_no")
                    Num = 0
                Else
                    Num = DS.Tables("ID").Rows(0).Item("maxno")
                End If

                Num = Num + 1
                If Len(CStr(Num)) = 1 Then
                    runId = "0000" & CStr(Num)
                ElseIf Len(CStr(Num)) = 2 Then
                    runId = "000" & CStr(Num)
                ElseIf Len(CStr(Num)) = 3 Then
                    runId = "00" & CStr(Num)
                ElseIf Len(CStr(Num)) = 4 Then
                    runId = "0" & CStr(Num)
                ElseIf Len(CStr(Num)) = 5 Then
                    runId = CStr(Num)
                Else
                    runId = ""
                End If
                'runId = CStr(Num)
            Else
                runId = "00001"
            End If
            showMonth = CStr(Month(F_Date))

            If CDbl(showMonth) < 10 Then
                idmonth = "0" & showMonth
            Else
                idmonth = showMonth
            End If
            years = Microsoft.VisualBasic.Right(Format(Now, "dd/MM/yyyy"), 2)

            If CStr(V_Type) = "V" Or CStr(V_Type) = "P" Then
                docNo = "V" & years & idmonth & runId
            Else
                docNo = "N" & years & idmonth & runId
            End If
        Else 'à´×Í¹ãËÁè

            showMonth = CStr(Month(F_Date))
            Num = 1
            If CDbl(showMonth) < 10 Then
                idmonth = "0" & showMonth
            Else
                idmonth = showMonth
            End If

            years = Microsoft.VisualBasic.Right(Format(Now, "dd/MM/yyyy"), 2)
            docNo = CStr(V_Type) & years & idmonth & "00001"

        End If
        EditNo = docNo
        Return docNo

        'If CStr(V_Type) = "P" Then
        '    dtp01.Enabled = True
        'Else
        '    dtp01.Enabled = False
        'End If

        'Catch errprocess As Exception
        '    MessageBox.Show("¡ÃØ³ÒàÅ×Í¡»ÃÐàÀ·àÍ¡ÊÒÃ" & errprocess.Message, "¢éÍ¼Ô´¾ÅÒ´", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return ""
        '    Exit Function
        'End Try

    End Function
    Sub frmCusSearch()


        Me.BackColor = Color.DarkGray
        frmCustomer.ShowDialog()

        showArData(selCusiD)
        lbCusID.Text = selCusiD
        lbCusName.Text = PName
        If selCusiD = "" Then

        Else
            If chkDataAmphoe(selCusiD) = False Then
                MsgBox("ยังไม่ได้ระบุรหัส อำเภอ โปรดระบุ", MsgBoxStyle.Critical, "แจ้งเตือน")
                Dim frmAmphoe As frmSearchAmphoe = New frmSearchAmphoe
                frmAmphoe.ShowDialog(Me)

            End If

        End If


        Me.BackColor = Color.WhiteSmoke

    End Sub

    Private Sub cmbSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSearch.Click

        Call frmCusSearch()
        Call ShowSelRev()

        'Me.BackColor = Color.DarkGray
        'frmCustomer.ShowDialog()

        'lbCusID.Text = selCusiD
        'lbCusName.Text = PName
        'showArData(selCusiD)



        'Me.BackColor = Color.WhiteSmoke
    End Sub

    Sub ok()
        Dim frmOrder1 As frmOrder
        frmOrder1 = New frmOrder

        frmOrder1.ShowDialog()

        lbProductName.Text = SelectName
        txtPrice.Text = SelectPrice
        txtDisc.Text = SelectDisc
        txtSaleQty.Text = SelectNum

        If SelectNo <> "" Then
            lbOrder.Text = SelectNo
        Else
            lbOrder.Text = "ไม่พบ"
        End If

        lbStkCode.Text = SelectCode
        oldCode = SelectCode
        If SelectPNo <> "" Then
            lbPONo.Text = SelectPNo
        Else
            lbPONo.Text = "ไม่พบ PO"
        End If

        'lbWeight.Text = Format(SelectWeight, "#,##0.00")
        lbTotalWeight.Text = Format(SelectWeight * SelectNum, "#,##0.00")
        lbStock.Text = Format(SelectStock, "#,##0")
        'cboType1.SelectedValue = CodeT
        'cboGrp1.SelectedValue = CodeG
        'cboColor1.SelectedValue = CodeColor
        'cboTh.SelectedValue = CodeTh
        'cboSize.SelectedValue = CodeSize
        'cboPaper.SelectedValue = CodePaper
        'cboGrade.SelectedValue = CodeGrade


        SelectName = ""
        SelectPrice = 0
        SelectNo = ""
        SelectNum = 0
        SelectCode = ""
        SelectWeight = 0
        CodeT = ""
        CodeG = ""
        CodeColor = ""
        CodeTh = ""
        CodeSize = ""
        CodePaper = ""
        CodeGrade = ""


    End Sub



    Sub dataPickingList()
        Str01 = " SELECT distinct  TranDataH.Trh_Type, TranDataH.Trh_No, TranDataH.Trh_Cus, TranDataD.Dtl_idtrade, TranDataD.Dtl_num_2,TranDataD.Dtl_num,TranDataH.Trh_term,"
        Str01 = Str01 & " TranDataD.Dtl_need, TranDataD.Dtl_runnum, TranDataD.Dtl_no, TranDataD.Dtl_price,  TranDataD.Dtl_date,TranDataD.Dtl_cuta_code,TranDataD.Dtl_dates,TranDataD.Dtl_datef,"
        Str01 = Str01 & " TranDataD.Dtl_con_id, StkData.Std_Remain, ARFILE.AR_TYPE, ARFILE.AR_NAME, ARFILE.AR_ADDR, ARFILE.AR_ADDR_1, ARFILE.AR_ADDR_2,"
        Str01 = Str01 & " ARFILE.AR_TEL_NO , ARFILE.AR_FAX, BaseMast.Th_Code, BaseMast.Size_Code, BaseMast.Color_Code,BaseMast.stk_name_1"
        Str01 = Str01 & " FROM   StkData RIGHT OUTER JOIN  TranDataD LEFT OUTER JOIN BaseMast"
        Str01 = Str01 & " ON TranDataD.Dtl_idtrade = BaseMast.Stk_Code ON StkData.Std_Cusid = TranDataD.Dtl_idcus AND"
        Str01 = Str01 & " StkData.Std_IDCode = TranDataD.Dtl_idtrade RIGHT OUTER JOIN ARFILE RIGHT OUTER JOIN"
        Str01 = Str01 & " TranDataH ON ARFILE.AR_CUS_ID = TranDataH.Trh_Cus ON TranDataD.Dtl_con_id = TranDataH.Trh_No AND"
        Str01 = Str01 & " TranDataD.Dtl_type = TranDataH.Trh_Type "
        Str01 = Str01 & " where   (TranDataH.Trh_Type = 'P') AND (TranDataD.Dtl_num-TranDataD.Dtl_num_2 > 0)"
        Str01 = Str01 & " AND (TranDataD.Dtl_idcus = '" & lbCusID.Text & "') AND (ARFILE.AR_TYPE = N'AR')  "
        Str01 = Str01 & " ORDER BY TranDataD.Dtl_date"

    End Sub

    Function getTypeVATbyT(RevNo As String) As String

        Dim txtSQL As String = ""

        txtSQL = "Select * "
        txtSQL = txtSQL & "From TranDataH "
        txtSQL = txtSQL & "Where trh_Type='T' "
        txtSQL = txtSQL & "And trh_NO='" & RevNo & "' "

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "dbOrder")

        If subDS.Tables("dbOrder").Rows.Count = 0 Then
            Return "N"
        Else

            If IsDBNull(subDS.Tables("dbOrder").Rows(0).Item("trh_NoType")) Then
                Return "V"
            Else
                Return subDS.Tables("dbOrder").Rows(0).Item("trh_NoType")
            End If


        End If

    End Function

    Private Sub llbAdd_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbAdd.LinkClicked
        Dim setDigiCAL As String = "#,##0.00"

        Dim tempCode As String = ""
        Dim listData() As String
        Dim tempSum As Integer = 0
        Dim tempweight As Double = 0.0
        Dim tempDisc As Double = 0
        Dim iNo As Integer = 0
        Dim i As Integer = 0
        Dim stkFactor As Double = 0
        Dim stkAmt As Double = 0
        Dim pr_Cost As Double = 0
        Dim strRevNo As String = ""
        Dim strTypeP As String = ""
        Dim strDocPO As String = ""   'i1
        Dim strCondition As String = ""

        Dim i0, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16, i17, i19, i18, i20, i21, i22 As String
        Dim dblDiscItem As Double = 0

        stkCode = lbStkCode.Text

        Dvat = cboTypeDoc.SelectedValue
        If Dvat = "" Then

            MsgBox("ระบุข้อมูล Vat ", MsgBoxStyle.Critical, "แจ้งเตือน")
            Exit Sub
        Else

            If Dvat = "P" Or Dvat = "B" Or Dvat = "M" Then  '  »ÃÐàÀ·àÍ¡ÊÒÃ·ÕèäÁèµéÍ§ÁÕãºàºÔ¡

                'If Dvat = "B" Or Dvat = "M" Then

                'End If

            Else

                If Trim(txtTypeP.Text) = "" Then

                    MsgBox("àÅ¢·ÕèãºàºÔ¡äÁè¶Ù¡µéÍ§ µÃÇ¨ÊÍºÍÕ¡¤ÃÑé§ ")
                    txtTypeP.Focus()
                    txtTypeP.SelectAll()
                    Exit Sub
                End If

            End If
        End If

        If IsNumeric(txtSaleQty.Text) = False Then

            MsgBox("¢éÍÁÙÅ¨Ó¹Ç¹ÊÔ¹¤éÒäÁè¶Ù¡µéÍ§ µÃÇ¨ÊÍºÍÕ¡¤ÃÑé§ ")
            txtSaleQty.Focus()
            txtSaleQty.SelectAll()
            Exit Sub
        End If

        If IsNumeric(txtPrice.Text) = False Then

            MsgBox("¢éÍÁÙÅÃÒ¤ÒäÁè¶Ù¡µéÍ§ µÃÇ¨ÊÍºÍÕ¡¤ÃÑé§ ")
            txtPrice.Focus()
            txtPrice.SelectAll()
            Exit Sub
        End If



        'If IsNumeric(txtDisc.Text) = False Then

        '    MsgBox("¢éÍÁÙÅÃÒ¤ÒäÁè¶Ù¡µéÍ§ µÃÇ¨ÊÍºÍÕ¡¤ÃÑé§ ")
        '    txtDisc.Focus()
        '    txtDisc.SelectAll()
        '    Exit Sub
        'End If


        If lbProductName.Text = "" Or txtSaleQty.Text = "" Or txtPrice.Text = "" Or lbCusID.Text = "" _
        Or lbCusID.Text = "ÃËÑÊÅÙ¡¤éÒ" Then

            MsgBox("¡ÃØ³ÒµÃÇ¨ÊÍº¢éÍÁÙÅÍÕ¡¤ÃÑé§¡èÍ¹·Ó¡ÒÃà¾ÔèÁÃÒÂ¡ÒÃ", MsgBoxStyle.Critical = MsgBoxStyle.OkOnly, "á¨é§àµ×Í¹")
            Exit Sub

        End If

        'If  then

        'End If

        '***************************************************************ÊÓËÃÑºàªç¤ stockÇèÒ¾ÍËÃ×ÍäÁè ¶éÒäÁè¾Í¨ÐäÁèãËé¢ÒÂ *******************************


        If (getProDCode(stkCode) <> "04") And Not (Dvat = "P" Or Dvat = "B" Or Dvat = "M") Then   '  µÃÇ¨ÊÍºÇèÒà»ç¹ GMB(04)ËÃ×ÍäÁè ¶éÒà»ç¹äÁè¤Ô´ÊµêÍ¡

            If (txtSaleQty.Text > DBtools.getStock(stkCode, "110098", lbWHcode.Text)) Then
                'If (Dvat = "P" Or Dvat = "B") Then

                'Else

                MsgBox("StockäÁèà¾ÕÂ§¾Íã¹¡ÒÃ¢ÒÂ ·èÒ¹µéÍ§·Ó¡ÒÃâÍ¹ÊÔ¹¤éÒ¨Ò¡¤ÅÑ§Í×è¹ â´Â¡ÒÃ¡´ F2", MsgBoxStyle.OkOnly, "á¨é§àµ×Í¹")
                lbStock.Text = DBtools.getStock(stkCode, "110098", lbWHcode.Text)
                Exit Sub
                'End If

            Else

                tempSum = CInt(txtSaleQty.Text) * CDbl(txtPrice.Text) '¤Ó¹Ç³ÃÒ¤Ò¨ÃÔ§
                'tempweight = CInt(txtSaleQty.Text) * CDbl(lbWeight.Text) '¤Ó¹Ç³¹éÓË¹Ñ¡
                'tempDisTotal = tempSum - Format((tempSum * (CDbl(txtDiscount.Text) / 100)), "0.00") '¤Ó¹Ç³ÃÒ¤Ò·ÕèËÑ¡ÊèÇ¹Å´

                For i = 0 To ListEdit.Items.Count
                    iNo = i
                Next

                i0 = iNo + 1                                    '  ÅÓ´Ñº
                strDocPO = lbPONo.Text                                 '  àÅ¢·Õè PO

                i2 = lbOrder.Text                               '  àÅ¢·Õè  Order  
                strRevNo = lbRevDocNo.Text                      '  àÅ¢·Õèãº¨Í§
                strTypeP = txtTypeP.Text

                i3 = lbCusName.Text                             '  ª×èÍÅÙ¡¤éÒ
                i4 = stkCode                              '  ÃËÑÊÊÔ¹¤éÒ
                i5 = lbProductName.Text                         '  ª×èÍÊÔ¹¤éÒ  
                '=================================================

                i6 = txtSaleQty.Text                            '  ¨Ó¹Ç¹¢ÒÂ                  

                stkQty = CDbl(txtSaleQty.Text)
                If lbArAcct.Text = "112010" Then
                    setDigiCAL = "#,##0.00"
                Else
                    setDigiCAL = "#,##0.0000"
                End If
                i7 = Format(CDbl(txtPrice.Text), setDigiCAL)    '  ÃÒ¤Ò¢ÒÂ/ unit

                If Microsoft.VisualBasic.Right(txtDisc.Text, 1) = "%" Then

                    tempDisc = CDbl(Microsoft.VisualBasic.Left(txtDisc.Text, Len(txtDisc.Text) - 1))
                    tempDisc = (CDbl(txtPrice.Text) * CDbl(tempDisc)) / 100

                ElseIf Microsoft.VisualBasic.Right(txtDisc.Text, 1) = "b" Or Microsoft.VisualBasic.Right(txtDisc.Text, 1) = "B" Then

                    tempDisc = CDbl(Microsoft.VisualBasic.Left(txtDisc.Text, Len(txtDisc.Text) - 1))

                ElseIf IsNumeric(txtDisc.Text) Then

                    tempDisc = txtDisc.Text

                ElseIf txtDisc.Text = 0 Or txtDisc.Text = "" Then
                    'txtDisc.Text = 0
                    tempDisc = 0

                End If

                i8 = Format(txtPrice.Text - tempDisc, setDigiCAL)   ' ÃÒ¤ÒËÅÑ§Å´


                '=================================================

                i9 = Format(CDbl(txtSaleQty.Text) * CDbl(i8), "#,##0.0000")   '   Total
                dblDiscItem = i9
                '=================================================

                'ÇÔà¤ÃÒÐËì 
                stkFactor = DBtools.getStkWight(stkCode)
                stkPrice = getCostByStk(stkCode, dtp01.Value, "", 0)

                'stkPrice=
                If getCostType(stkCode) = 0 Then
                    stkAmt = (stkQty * stkFactor) * stkPrice
                Else
                    stkAmt = (stkQty * stkPrice)
                End If
                tempweight = (stkQty * stkFactor)

                i10 = Format(CDbl(stkAmt), setDigiCAL)    '  µé¹·Ø¹

                i11 = Format((i8 * stkQty) - stkAmt, "#,##0.00") ' profit ¡ÓäÃ

                '=================================================
                i12 = Format(tempweight, setDigiCAL)                   '  ¹éÓË¹Ñ¡ÃÇÁ
                i13 = txtDetail2.Text                                   '  ËÁÒÂàËµØ  ã¹ÃÒÂ¡ÒÃÊÔ¹¤éÒ
                strCondition = txtCondition.Text
                i14 = lbCusID.Text                                      '  ÃËÑÊ ÅÙ¡¤éÒ
                i15 = txtNo.Text                                        '  àÅ¢·Õè ºÔÅ 
                i16 = dtp01.Value                                       '  ÇÑ¹·Õè
                i17 = txtDisc.Text                                      '  ÊèÇ¹Å´ ã¹ÃÒÂ¡ÒÃ

                If lbOldCode.Text = "" Then
                    i18 = lbStkCode.Text
                Else
                    i18 = lbOldCode.Text
                End If

                i19 = "0"
                i20 = txtSaleQty.Text
                i21 = Format(tempweight, setDigiCAL)
                i22 = "A"

                ' If oldCode <> "" Then
                listData = New String() {i0, strDocPO, i2, i3, i4, i5,
                                         i6, i7, i17, i8,
                                         i9, i10, i11, i12, i13,
                                         i14, i15, i16, i18, i19, i20, i21, i22, strRevNo, strTypeP, strCondition}


                LOrder = New ListViewItem(listData)
                ListEdit.Items.Add(LOrder)
                If i11 > 0 Then

                    colorList(1)
                ElseIf i11 < 0 Then
                    colorList(0)
                Else
                    colorList(2)
                End If
                Call sumTotal()

                lbCount.Text = ListEdit.Items.Count
            End If 'if ¢Í§àªç¤ Stock 


        Else

            '    ¢ÒÂÊÔ¹¤éÒ·ÕèäÁèãªè  GMB 

            If (stkCode = oldCode) And (CDbl(txtSaleQty.Text) <= (editQty + DBtools.getStock(stkCode, "110098", lbWHcode.Text))) Then

            Else
                'If (txtSaleQty.Text > DBtools.getStock(lbCode.Text, "110098", lbWHcode.Text)) And Not ((Dvat = "P") Or (Dvat = "B")) Then

                '    MsgBox("StockäÁèà¾ÕÂ§¾Íã¹¡ÒÃ¢ÒÂ ·èÒ¹µéÍ§·Ó¡ÒÃâÍ¹ÊÔ¹¤éÒ¨Ò¡¤ÅÑ§Í×è¹ â´Â¡ÒÃ¡´ F2", MsgBoxStyle.OkOnly, "á¨é§àµ×Í¹")
                '    Exit Sub

                'End If

            End If

            tempSum = CInt(txtSaleQty.Text) * CDbl(txtPrice.Text) '¤Ó¹Ç³ÃÒ¤Ò¨ÃÔ§
            'tempweight = CInt(txtSaleQty.Text) * CDbl(lbWeight.Text) '¤Ó¹Ç³¹éÓË¹Ñ¡
            'tempDisTotal = tempSum - Format((tempSum * (CDbl(txtDiscount.Text) / 100)), "0.00") '¤Ó¹Ç³ÃÒ¤Ò·ÕèËÑ¡ÊèÇ¹Å´

            For i = 0 To ListEdit.Items.Count
                iNo = i
            Next

            i0 = iNo + 1                                    '  ÅÓ´Ñº
            strDocPO = lbPONo.Text                                 '  àÅ¢·Õè PO
            i2 = lbOrder.Text                               '  àÅ¢·Õè  Order  
            i3 = lbCusName.Text                             '  ª×èÍÅÙ¡¤éÒ
            i4 = lbStkCode.Text                                '  ÃËÑÊÊÔ¹¤éÒ
            i5 = lbProductName.Text                         '  ª×èÍÊÔ¹¤éÒ  
            '=================================================

            i6 = txtSaleQty.Text                            '  ¨Ó¹Ç¹¢ÒÂ                  
            stkQty = CDbl(txtSaleQty.Text)
            i7 = Format(CDbl(txtPrice.Text), "#,##0.0000")    '  ÃÒ¤Ò¢ÒÂ/ unit

            If Microsoft.VisualBasic.Right(txtDisc.Text, 1) = "%" Then

                tempDisc = CDbl(Microsoft.VisualBasic.Left(txtDisc.Text, Len(txtDisc.Text) - 1))
                tempDisc = (CDbl(txtPrice.Text) * CDbl(tempDisc)) / 100

            ElseIf Microsoft.VisualBasic.Right(txtDisc.Text, 1) = "b" Or Microsoft.VisualBasic.Right(txtDisc.Text, 1) = "B" Then

                tempDisc = CDbl(Microsoft.VisualBasic.Left(txtDisc.Text, Len(txtDisc.Text) - 1))

            ElseIf IsNumeric(txtDisc.Text) Then

                tempDisc = txtDisc.Text

            ElseIf txtDisc.Text = 0 Or txtDisc.Text = "" Then
                tempDisc = 0
            End If

            i8 = Format(txtPrice.Text - tempDisc, "#,##0.0000")   ' ÃÒ¤ÒËÅÑ§Å´

            '=================================================

            i9 = Format(CDbl(txtSaleQty.Text) * CDbl(i8), "#,##0.0000")   '   Total

            '=================================================

            'ÇÔà¤ÃÒÐËì 
            stkFactor = DBtools.getStkWight(lbStkCode.Text)
            stkPrice = getCostByStk(stkCode, dtp01.Value, "", 0)

            'stkPrice=
            If getCostType(stkCode) = 0 Then
                stkAmt = (stkQty * stkFactor) * stkPrice
            Else
                stkAmt = (stkQty * stkPrice)
            End If
            tempweight = (stkQty * stkFactor)

            i10 = Format(CDbl(stkAmt), "#,##0.00")    '  µé¹·Ø¹

            i11 = Format((i8 * stkQty) - stkAmt, "#,##0.00") ' profit ¡ÓäÃ

            '=================================================
            i12 = Format(tempweight, "#,##0.000")                   '  ¹éÓË¹Ñ¡ÃÇÁ
            i13 = txtDetail2.Text                                   '  ËÁÒÂàËµØ  ã¹ÃÒÂ¡ÒÃÊÔ¹¤éÒ
            i14 = lbCusID.Text                                      '  ÃËÑÊ ÅÙ¡¤éÒ
            i15 = txtNo.Text                                        '  àÅ¢·Õè ºÔÅ 
            i16 = dtp01.Value                                       '  ÇÑ¹·Õè
            i17 = txtDisc.Text                                      '  ÊèÇ¹Å´ ã¹ÃÒÂ¡ÒÃ

            If oldCode <> "" Then
                i18 = oldCode
            Else
                i18 = lbStkCode.Text
            End If

            i19 = "0"
            i20 = txtSaleQty.Text
            i21 = Format(tempweight, "#,##0.000")
            i22 = "A"

            ' If oldCode <> "" Then
            listData = New String() {i0, strDocPO, i2, i3, i4, i5,
                                     i6, i7, i17, i8,
                                     i9, i10, i11, i12, i13,
                                     i14, i15, i16, i18, i19, i20, i21, i22, strRevNo, strTypeP, strCondition}


            'listData = New String() {i0, strDocPO, i2, i3, i4, i5, _
            '                         i6, i7, i8, _
            '                         i9, i10, i11, i12, i13, _
            '                         i14, i15, i16, i17, i18, i19, i20, i21, i22, strRevNo, strTypeP}


            LOrder = New ListViewItem(listData)
            ListEdit.Items.Add(LOrder)
            If i11 > 0 Then

                colorList(1)
            ElseIf i11 < 0 Then
                colorList(0)
            Else
                colorList(2)
            End If


            lbCount.Text = ListEdit.Items.Count
        End If 'if ¢Í§àªç¤ Stock 

        tempSum = 0
        Call sumTotal()
        Call txtCLS()

    End Sub

    Sub iTemTotal()



    End Sub


    Sub sumTotal()

        Dim i As Integer = 0
        Dim tempTotal As Double = 0.0    'ÂÍ´ÊØ·¸Ô  lbTotal
        Dim tmpSummary As Double = 0     'ÂÍ´ÃÇÁ   lbSummary
        Dim tempWeight As Double = 0.0
        Dim tmpVAT As Double = 0     'ÂÍ´ÃÇÁ   lbVat
        Dim tmpPrice As Double = 0

        Dim strDisc As String = ""
        Dim tempDisc As Double = 0.0     'ÂÍ´ÊÇ¹Å´   lbDic

        Dim tmpTotaliTemDisc As Double = 0
        Dim tmpTotaliTemAmt As Double = 0
        Dim tmpTotaliTemCost As Double = 0

        Dim total As Double = 0.0
        Dim itemType As String = ""
        Dim chkVAT As String = Microsoft.VisualBasic.Left(txtNo.Text, 1)
        Dim calVAT As Double = CDbl(txtCusVat.Text)
        Dim trhDisc As Double
        Dim dblQty As Double = 0

        For i = 0 To ListEdit.Items.Count - 1   '  เริ่มคำนวน ข้อมูลใน list view  

            itemType = "A"
            strDisc = ListEdit.Items(i).SubItems(8).Text
            tmpPrice = CDbl(ListEdit.Items(i).SubItems(7).Text)
            dblQty = CDbl(ListEdit.Items(i).SubItems(6).Text)
            tmpTotaliTemCost = CDbl(ListEdit.Items(i).SubItems(11).Text) + tmpTotaliTemCost

            If Microsoft.VisualBasic.Right(strDisc, 1) = "b" Or Microsoft.VisualBasic.Right(strDisc, 1) = "B" Then  '  ¶éÒªèÍ§ÊèÇ¹Å´ÁÕ  "b" µèÍ·éÒÂËÁÒÂ¶Ö§Å´à»ç¹ºÒ·

                tempDisc = CDbl(Microsoft.VisualBasic.Left(strDisc, Len(strDisc) - 1))

            ElseIf Microsoft.VisualBasic.Right(strDisc, 1) = "%" Then

                tempDisc = CDbl(Microsoft.VisualBasic.Left(strDisc, Len(strDisc) - 1))
                tempDisc = (tmpPrice * tempDisc / 100)
            ElseIf IsNumeric(strDisc) Then
                tempDisc = CDbl(strDisc)
            ElseIf strDisc = 0 Then
                tempDisc = 0
            Else
                tempDisc = CDbl(strDisc)

            End If
            tmpPrice = tmpPrice - tempDisc

            total = Format(tmpPrice * dblQty, "#,##0.0000") '3

            tmpTotaliTemDisc = (tempDisc * dblQty) + tmpTotaliTemDisc
            tmpTotaliTemAmt = (total) + tmpTotaliTemAmt

            tempTotal += total      '   ÂÍ´à§Ô¹ËÅÑ§ËÑ¡ÊÇ¹Å´áÅéÇ 

            If ListEdit.Items(i).SubItems(13).Text = "" Then
                tempWeight += 0  '    ÂÍ´¹éÓË¹Ñ¡¢Í§ÃÒÂ¡ÒÃ¢ÒÂ
            Else
                tempWeight += ListEdit.Items(i).SubItems(13).Text   '    ÂÍ´¹éÓË¹Ñ¡¢Í§ÃÒÂ¡ÒÃ¢ÒÂ
            End If
        Next

        '====================================  àÃÔèÁ¤Ó¹Ç¹  =======================
        If chkVATtype(lbCusID.Text) = 0 Then

            lbSumary.Text = tempTotal.ToString("#,##0.0000")  '3
            TrhAmt = CDbl(lbSumary.Text)
            '   ÊèÇ¹Å´ 
            If Microsoft.VisualBasic.Right(txtCusDisc.Text, 1) = "b" Then  '  ¶éÒªèÍ§ÊèÇ¹Å´ÁÕ  "b" µèÍ·éÒÂËÁÒÂ¶Ö§Å´à»ç¹ºÒ·

                trhDisc = CDbl(Microsoft.VisualBasic.Left(txtCusDisc.Text, Len(txtCusDisc.Text) - 1))
            ElseIf Microsoft.VisualBasic.Right(txtCusDisc.Text, 1) = "%" Then

                trhDisc = CDbl(Microsoft.VisualBasic.Left(txtCusDisc.Text, Len(txtCusDisc.Text) - 1))
                trhDisc = (TrhAmt * trhDisc) / 100

            ElseIf IsNumeric(Microsoft.VisualBasic.Right(txtCusDisc.Text, 1)) Then
                trhDisc = txtCusDisc.Text
            End If
            tmpSummary = CDbl(TrhAmt - trhDisc)

            '  à§Ô¹ÁÑ´¨Ó
            If Microsoft.VisualBasic.Right(txtDepoSit.Text, 1) = "b" Then
                TrhDePosit = Microsoft.VisualBasic.Left(txtDepoSit.Text, Len(txtDepoSit.Text) - 1)
            ElseIf Microsoft.VisualBasic.Right(txtDepoSit.Text, 1) = "%" Then
                TrhDePosit = (Microsoft.VisualBasic.Left(txtDepoSit.Text, Len(txtDepoSit.Text) - 1))
                TrhDePosit = (tmpSummary * TrhDePosit) / 100
            ElseIf IsNumeric(Microsoft.VisualBasic.Right(txtDepoSit.Text, 1)) Then
                TrhDePosit = txtDepoSit.Text
            Else
                TrhDePosit = 0
            End If

            tmpSummary = (tmpSummary - TrhDePosit)


            lbSumary.Text = Format(TrhAmt, "#,##0.0000").ToString  '3
            lbDisc.Text = Format(trhDisc, "#,##0.0000").ToString  '3
            lbDeposit.Text = Format(TrhDePosit, "#,##0.0000").ToString '3
            TrhTotal = (TrhAmt - trhDisc - TrhDePosit)

            If chkVAT = "V" Or chkVAT = "v" Then
                TrhVat = (TrhTotal * calVAT) / 100
                lbVat.Text = Format((TrhTotal * calVAT) / 100, "#,##0.0000")  '3
            Else
                TrhVat = 0
                lbVat.Text = Format(0, "#,##0.0000") '3
            End If


        ElseIf chkVATtype(lbCusID.Text) = 1 Then

            lbTotal2.Text = tempTotal.ToString("#,##0.0000")  '3
            lbVat.Text = (lbTotal2.Text - lbSumary.Text).ToString("#,##0.00")
            lbSumary.Text = ((tempTotal * 100) / 107).ToString("#,##0.000")
            'TrhAmt = CDbl(lbSumary.Text)

        End If


        '===================================================================
        lbTotal2.Text = Format(TrhTotal + TrhVat, "#,##0.0000") '3

        lbTotalWeight.Text = tempWeight.ToString("#,##0.0000") '3        '
        lbTotaliTemAmt.Text = Format(tmpTotaliTemAmt + tmpTotaliTemDisc, "#,##0.00")
        lbTotaliTemDisc.Text = Format(tmpTotaliTemDisc, "#,##0.00")
        lbTotalHDisc.Text = Format(trhDisc, "#,##0.00")
        lbTotalCost.Text = Format(tmpTotaliTemCost, "#,##0.00")
        lbTotalProfit.Text = Format(tmpTotaliTemAmt - trhDisc - tmpTotaliTemCost, "#,##0.00")
        lbProFitretio.Text = Format(((tmpTotaliTemAmt - trhDisc - tmpTotaliTemCost) / tmpTotaliTemAmt) * 100, "#,##0.00").ToString & " %"
        lbAvgPrice.Text = Format((tmpTotaliTemAmt - trhDisc) / tempWeight, "#,##0.00")
        lbAvgCost.Text = Format(tmpTotaliTemCost / tempWeight, "#,##0.00")

    End Sub


    'Private Sub ListEdit_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListEdit.DoubleClick
    '    Dim LOrder As ListViewItem
    '    Dim tempCode As String = ""
    '    Dim listData() As String
    '    Dim tempSum As Integer = 0
    '    Dim tempweight As Double = 0.0
    '    Dim iNo As Integer = 0
    '    Dim i As Integer = 0
    '    If ChkDClick = True Then
    '        For i = 0 To ListEdit.SelectedItems.Count - 1

    '            LOrder = ListEdit.SelectedItems(i)
    '            ListEdit.Items.Remove(LOrder)

    '        Next
    '        For i = 0 To ListEdit.Items.Count
    '            iNo = i
    '        Next
    '        lbCount.Text = iNo

    '        Call sumTotal()


    '        'txtSaleNo.Text = ""
    '        Call comboFactor()
    '        'cboType.SelectedItem = Nothing
    '        'cboGrp.SelectedItem = Nothing
    '        'cboColor.SelectedItem = Nothing
    '        'cboTh.SelectedItem = Nothing
    '        'cboSize.SelectedItem = Nothing
    '        'cboPaper.SelectedItem = Nothing
    '        'cboGrade.SelectedItem = Nothing


    '        txtDetail.Text = ""
    '        lbTotalWeight.Text = ""
    '        lbTotal.Text = "0.00"
    '        'ListOrder.Items.Clear()
    '        'txtCredit.Text = ""
    '        'txtCusDisc.Text = ""
    '        'txtCusVat.Text = 7
    '        'lbCount.Text = ""
    '        lbProductName.Text = ""
    '        lbCode.Text = ""
    '        lbCode.Text = ""
    '        lbOrder.Text = ""
    '        lbProductName.Text = ""
    '        txtSale.Text = ""
    '        'txtDiscount.Text = ""
    '        txtPrice.Text = ""
    '        lbWeight.Text = ""
    '        lbStock.Text = 0
    '    Else

    '    End If
    'End Sub

    Private Sub llbOk_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Call ok()
    End Sub

    Function chkDataItem() As Boolean


        'Dim i As Integer

        '*********************************************** check àÅ¢·ÕèºÔÅ¡èÍ¹ÍÑ¹Í×è¹ áµèÂéÒÂä» check µÍ¹·éÒÂÊØ´ *****************************
        'If txtNo.Text = "" Then   '  µÃÇ¨àÅ¢·Õè àÍ¡ÊÒÃ
        '    MsgBox("¡ÃØ³Ò¡ÃÍ¡àÅ¢·Õè INVOICE", MsgBoxStyle.Critical = MsgBoxStyle.OkOnly, "á¨é§àµ×Í¹")
        '    txtNo.Focus()
        '    Return False
        'End If

        'If ListEdit.Items.Count = 0 Then   '  µÃÇ¨ ÃÒÂ¡ÒÃÊÔ¹¤éÒ ÇèÒÁÕËÃ×ÍäÁè
        '    MsgBox("äÁè¾ºÃÒÂ¡ÒÃÊÔ¹¤éÒ ", MsgBoxStyle.Critical = MsgBoxStyle.OkOnly, "á¨é§àµ×Í¹")
        '    Return False
        'End If
        If Dvat = "" Then
            MsgBox("ÂÑ§äÁèä´éàÅ×Í¡¢éÍÁÙÅ VAT ¡èÍ¹¡ÒÃºÑ¹·Ö¡", MsgBoxStyle.Critical, "á¨é§àµ×Í¹")
            Return False
        End If
        If lbCusID.Text = "" Or lbCusName.Text = "" Or txtCredit.Text = "" Or lbCreLimit.Text = "" _
        Or txtCusDisc.Text = "" Or txtCusVat.Text = "" Or txtSaleMan.Text = "" Then

            MsgBox("¡ÃØ³ÒµÃÇ¨ÊÍº¢éÍÁÙÅÍÕ¡¤ÃÑé§¡èÍ¹ºÑ¹·Ö¡", MsgBoxStyle.Critical = MsgBoxStyle.OkOnly, "á¨é§àµ×Í¹")
            Return False
        End If

        'If txtTypeP.Text = "" Then
        '    MsgBox("¡ÃØ³ÒãÊèàÅ¢·ÕèãºàºÔ¡", MsgBoxStyle.Critical, "á¨é§àµ×Í¹")
        '    Return False

        'End If
        'For i = 0 To ListEdit.Items.Count - 1

        '    If ListEdit.Items(i).SubItems(11).Text = "ÃËÑÊÅÙ¡¤éÒ" Or ListEdit.Items(i).SubItems(4).Text = "" Or ListEdit.Items(i).SubItems(6).Text = "" Or ListEdit.Items(i).SubItems(7).Text = "" Or ListEdit.Items(i).SubItems(11).Text = "" Then
        '        MsgBox("¡ÃØ³ÒµÃÇ¨ÊÍº¢éÍÁÙÅÍÕ¡¤ÃÑé§¡èÍ¹ºÑ¹·Ö¡", MsgBoxStyle.Critical = MsgBoxStyle.OkOnly, "á¨é§àµ×Í¹")
        '        Return False
        '    End If

        'Next i

        'If (DBtools.getDocNumber(txtNo.Text, "S") = True) And (lbStatus.Text <> "¡ÓÅÑ§á¡éä¢") Then
        '    MsgBox("àÅ¢·ÕèºÔÅ¹Õé¶Ù¡ãªéáÅéÇ ¡ÃØ³ÒàÅ×Í¡àÅ¢·ÕèãËÁè", MsgBoxStyle.Critical = MsgBoxStyle.OkOnly, "á¨é§àµ×Í¹")
        '    chkSave = False
        '    Return False

        'End If

        Return True

    End Function

    Sub delTranDataH()

        DS.Clear()
        txtSQL = " delete   from trandatah "
        txtSQL = txtSQL & "Where trh_no='" & txtNo.Text & "' "
        txtSQL = txtSQL & "and trh_type='S'"
        Try
            With subCom
                .CommandType = CommandType.Text
                .CommandText = txtSQL
                .Connection = Conn
                .ExecuteNonQuery()
            End With

        Catch errprocess As Exception
            MessageBox.Show("äÁèÊÒÁÒÃ¶Åº¢éÍÁÙÅä´éà¹×èÍ§¨Ò¡ " & errprocess.Message, "¢éÍ¼Ô´¾ÅÒ´", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

    End Sub

    Sub saveTranDataH()

        Dim Comm As New SqlClient.SqlCommand

        '        Dim sqlSave As String = ""
        DBtools.openDB()
        tr = Conn.BeginTransaction
        sb.Remove(0, sb.Length())

        If DBtools.getDocNumber(txtNo.Text, "S") = False Then
            '   ==============    ÊèÇ¹¡ÒÃ  Insert ¢éÍÁÙÅ    

            sb.Append("Insert Into TranDataH(Trh_type,Trh_notype,Trh_no,")   '  V1
            sb.Append("Trh_cus,Trh_date,Trh_Time,")   'V2
            sb.Append("Trh_amt,Trh_d_amt,Trh_full_amt,Trh_v_amt,Trh_Cost_Amt,Trh_Disc_D_Amt,") 'V3
            sb.Append("Trh_term,Trh_disc,Trh_sale,")  '  V4        
            sb.Append("trh_detail,trh_print,Trh_chk_print,trh_bill,trh_tran,trh_web,trh_cre_lim,")
            sb.Append("trh_runid,trh_update,Trh_wh,trh_DePosit,trh_strDePosit,")
            sb.Append("Trh_Depo_Ref,Trh_Term_Dtl,Trh_user,Trh_Disc_Amt,Trh_BillNote,Trh_Chk_Post) ")  ' V5

            sb.Append(" Values (@Trh_Type,@Trh_NoType,@Trh_No,")  '  V1
            sb.Append("@Trh_cus,@Trh_date,@Trh_Time,")   'V2

            sb.Append("@Trh_Amt,@Trh_D_Amt,@Trh_Full_Amt,@Trh_V_Amt,@Trh_Cost_Amt,@Trh_Disc_D_Amt,") 'V3

            sb.Append("@Trh_term,@Trh_disc,@Trh_sale,")  '  V4        
            sb.Append("@Trh_detail,@Trh_print,@Trh_chk_print,@Trh_bill,@Trh_tran,@Trh_web,@Th_cre_lim,")
            sb.Append("@Trh_runid,@Trh_update,@Trh_wh,@Trh_DePosit,@Trh_strDePosit,@Trh_DePoRef,")
            sb.Append("@Trh_Term_Dtl,@Trh_user,@Trh_Disc_Amt,@Trh_BillNote,@Trh_Chk_Post)")  ' V5            

        Else

            '   ==============    ÊèÇ¹¡ÒÃ  Update ¢éÍÁÙÅ    

            sb.Append("UPDATE TranDataH ")
            sb.Append("SET ")
            '=================  àÃ×èÍ§ÃÒÂÅÐàÍÕÂ´ËÑÇºÔÅ 
            'sb.Append("Trh_date=@Trh_date,")   'V2"

            sb.Append("Trh_cus=@Trh_cus,")
            sb.Append("Trh_term=@Trh_term,")
            sb.Append("trh_cre_lim=@Th_cre_lim,")
            sb.Append("Trh_disc=@Trh_disc,")
            sb.Append("Trh_sale=@Trh_sale,")
            sb.Append("trh_detail=@Trh_detail,")
            sb.Append("Trh_wh=@Trh_wh,")

            '=================  àÃ×èÍ§ÃÒ¤Ò

            sb.Append("Trh_DePosit=@Trh_DePosit,")
            sb.Append("Trh_strDePosit=@Trh_strDePosit,")

            sb.Append("Trh_amt=@Trh_Amt,")
            sb.Append("Trh_d_amt=@Trh_D_Amt,")
            sb.Append("Trh_v_amt=@Trh_V_Amt,") '====  V3"
            sb.Append("Trh_full_amt=@Trh_Full_Amt,")
            sb.Append("Trh_Disc_amt=@Trh_Disc_Amt,")  '
            sb.Append("Trh_Cost_Amt=@Trh_Cost_Amt,")  'Trh_Disc_D_Amt
            sb.Append("Trh_Disc_D_Amt=@Trh_Disc_D_Amt,")

            '=================  ÊèÇ¹»ÃÐ¡Íº ãªéµÃÇ¨ÊÍºµèÒ§æ 

            sb.Append("Trh_print=@Trh_print,")
            sb.Append("Trh_chk_print=@Trh_chk_print,")
            sb.Append("Trh_bill=@Trh_bill,")
            sb.Append("Trh_tran=@Trh_tran,")
            sb.Append("Trh_web=@Trh_web,")
            'sb.Append("Trh_runid=@Trh_runid,")  ' ¡ÒÃ Update  äÁèµéÍ§ update
            sb.Append("Trh_Depo_Ref=@Trh_DepoRef,")
            sb.Append("Trh_update=@Trh_update,")
            sb.Append("Trh_Term_Dtl=@Trh_Term_Dtl ")

            sb.Append("Where Trh_Type='S' ")
            sb.Append("And Trh_No=@Trh_No ")


        End If

        txtSQL = ""
        txtSQL = sb.ToString()

        With Comm

            .Connection = Conn
            .CommandText = txtSQL
            .Transaction = tr
            .Parameters.Clear()

            .Parameters.Add("@Trh_Type", SqlDbType.Char).Value = "S"   ' == V1
            .Parameters.Add("@Trh_NoType", SqlDbType.Char).Value = CStr(Dvat)
            .Parameters.Add("@Trh_No", SqlDbType.NVarChar).Value = Trim(txtNo.Text)

            .Parameters.Add("@Trh_Cus", SqlDbType.NVarChar).Value = Trim(lbCusID.Text)  '  =======V2
            .Parameters.Add("@Trh_Date", SqlDbType.SmallDateTime).Value = Format(dtp01.Value, "dd/MM/yyyy")
            .Parameters.Add("@Trh_Time", SqlDbType.Time).Value = Format(Now, "HH:mm:ss")

            '================================================================================================
            '   à§Ô¹ÃÇÁ ÂÑ§äÁèËÑ¡ ÊèÇ¹Å´ áÅÐ à§Ô¹ÁÑ´¨Ó
            If lbSumary.Text = "" Then
                '  à§Ô¹ÃÇÁÂÑ§äÁèËÑ¡ã´æ 
                .Parameters.Add("@Trh_Amt", SqlDbType.Float).Value = CDbl(0)   ' Trh_Amt   V3                 
                '  à§Ô¹ÃÇÁ·Õè¨ÐµéÍ§¤Ó¹Ç¹ ËÑ¡µèÒ§æ áÅéÇ  ( áµèÂÑ§äÁèä´é·Ó )  ktp 7-1-57
                .Parameters.Add("@Trh_Full_Amt", SqlDbType.Float).Value = CDbl(0)  '  Trh_Full_Amt  

                TrhAmt = CDbl(0)
            Else
                .Parameters.Add("@Trh_Amt", SqlDbType.Float).Value = CDbl(lbSumary.Text)   ' Trh_Amt   V3

                .Parameters.Add("@Trh_Full_Amt", SqlDbType.Float).Value = CDbl(lbSumary.Text)  '  Trh_Full_Amt  
                TrhAmt = CDbl(lbSumary.Text)

            End If

            IDNo = DBtools.getRunID(txtNo.Text)

            '   à§Ô¹ÊèÇ¹Å´
            If Microsoft.VisualBasic.Right(lbDisc.Text, 1) = "b" Then
                TrhDisc = CDbl(Microsoft.VisualBasic.Left(lbDisc.Text, Len(lbDisc.Text) - 1))

            ElseIf Microsoft.VisualBasic.Right(lbDisc.Text, 1) = "%" Then
                TrhDisc = CDbl(Microsoft.VisualBasic.Left(lbDisc.Text, Len(lbDisc.Text) - 1))
                TrhDisc = (TrhAmt * TrhDisc) / 100

            ElseIf IsNumeric(Microsoft.VisualBasic.Right(lbDisc.Text, 1)) Then
                TrhDisc = CDbl(lbDisc.Text)
            Else
                TrhDisc = 0
            End If

            TrhAmt = TrhAmt - TrhDisc
            .Parameters.Add("@Trh_Disc_Amt", SqlDbType.Float).Value = CDbl(TrhDisc)   ' à¡çºÊèÇ¹Å´ËÑÇºÔÅ Trh_Disc_Amt   V3

            '=================================================

            '   à§Ô¹ÁÑ´¨Ó
            If Microsoft.VisualBasic.Right(txtDepoSit.Text, 1) = "b" Then

                TrhDePosit = CDbl(Microsoft.VisualBasic.Left(txtDepoSit.Text, Len(txtDepoSit.Text) - 1))

            ElseIf Microsoft.VisualBasic.Right(txtDepoSit.Text, 1) = "%" Then
                TrhDePosit = CDbl(Microsoft.VisualBasic.Left(txtDepoSit.Text, Len(txtDepoSit.Text) - 1))
                TrhDePosit = (TrhAmt * TrhDePosit) / 100

            ElseIf IsNumeric(Microsoft.VisualBasic.Right(txtDepoSit.Text, 1)) Then
                TrhDePosit = CDbl(txtDepoSit.Text)
            Else
                TrhDePosit = 0 ' Microsoft.VisualBasic.Left(txtDepoSit.Text, Len(txtDepoSit.Text) - 1)
            End If
            ' TrhAmt = TrhAmt - TrhDePosit   µÑ´¡ÒÃÅºà§Ô¹ÁÑ´¨ÓÍÍ¡¨Ò¡  Trh_D_Amt    à¾ÃÒÐáÊ´§¢éÍÁÙÅã¹ÃÒÂ§Ò¹¼Ô´



            .Parameters.Add("@Trh_Cost_Amt", SqlDbType.Float).Value = CDbl(lbTotalCost.Text)
            .Parameters.Add("@Trh_Disc_D_Amt", SqlDbType.Float).Value = CDbl(lbTotaliTemDisc.Text)  '  à¡çº ÊèÇ¹Å´ Item

            'If Microsoft.VisualBasic.Right(txtCusDisc.Text, 1) = "b" Then
            '    .Parameters.Add("@Trh_V_Amt", SqlDbType.Float).Value = CDbl((CDbl(lbSumary.Text) - TrhDisc) * 7 / 100) ' Trh_V_Amt 
            'ElseIf Microsoft.VisualBasic.Right(txtCusDisc.Text, 1) = "%" Then
            '    .Parameters.Add("@Trh_V_Amt", SqlDbType.Float).Value = (CDbl(lbSumary.Text) - (CDbl(lbSumary.Text) * CDbl(TrhDisc)) / 100) * 7 / 100
            'ElseIf IsNumeric(Microsoft.VisualBasic.Right(txtCusDisc.Text, 1)) Then
            '    .Parameters.Add("@Trh_V_Amt", SqlDbType.Float).Value = CDbl((CDbl(lbSumary.Text) - TrhDisc) * 7 / 100) ' Trh_V_Amt 
            'Else
            '    .Parameters.Add("@Trh_V_Amt", SqlDbType.Float).Value = 0
            'End If   '    ============================== V3
            TrhAmt = TrhAmt
            TrhVat = (TrhAmt) * CInt(txtCusVat.Text) / 100
            .Parameters.Add("@Trh_V_Amt", SqlDbType.Float).Value = TrhVat

            If lbSumary.Text = "" Or txtCusDisc.Text = "" Then
                .Parameters.Add("@Trh_D_Amt", SqlDbType.Float).Value = TrhAmt 'lbSumary.Text
            Else
                .Parameters.Add("@Trh_D_Amt", SqlDbType.Float).Value = TrhAmt 'lbSumary.Text 'CDbl(TrhAmt)
                'If Microsoft.VisualBasic.Right(txtCusDisc.Text, 1) = "b" Then   '              Trh_D_Amt
                '    .Parameters.Add("@Trh_D_Amt", SqlDbType.Float).Value = (CDbl(lbSumary.Text) - TrhDisc - CDbl(txtDepoSit.Text))

                'ElseIf Microsoft.VisualBasic.Right(txtCusDisc.Text, 1) = "%" Then
                '    .Parameters.Add("@Trh_D_Amt", SqlDbType.Float).Value = (CDbl(lbSumary.Text) - (CDbl(lbSumary.Text) * CDbl(TrhDisc)) / 100) - CDbl(txtDepoSit.Text)

                'Else
                '    .Parameters.Add("@Trh_D_Amt", SqlDbType.Float).Value = (CDbl(lbSumary.Text))
                'End If                                                          '              Trh_D_Amt

            End If

            .Parameters.Add("@Trh_term", SqlDbType.Int).Value = CInt(Trim(txtCredit.Text))
            .Parameters.Add("@Trh_disc", SqlDbType.NVarChar).Value = Trim(txtCusDisc.Text)
            .Parameters.Add("@Trh_sale", SqlDbType.NVarChar).Value = Trim(txtSaleMan.Text)

            .Parameters.Add("@Trh_detail", SqlDbType.NVarChar).Value = Trim(txtDetail.Text)   ' =========================== V4
            .Parameters.Add("@Trh_print", SqlDbType.NVarChar).Value = 0
            .Parameters.Add("@Trh_chk_print", SqlDbType.NVarChar).Value = 0
            .Parameters.Add("@Trh_bill", SqlDbType.Float).Value = txtCusVat.Text
            .Parameters.Add("@Trh_tran", SqlDbType.Bit).Value = 0
            .Parameters.Add("@Trh_web", SqlDbType.Bit).Value = 0
            .Parameters.Add("@Th_cre_lim", SqlDbType.Float).Value = lbCreLimit.Text
            '============== µÑÇ¹Ñºà¾×Íãªéã¹¡ÒÃ¤Ó¹Ç¹àÅ¢·ÕèàÍ¡ÊÒÃ 

            .Parameters.Add("@Trh_runid", SqlDbType.Int).Value = trh_RunID   'CInt(IDNo)
            .Parameters.Add("@Trh_update", SqlDbType.DateTime).Value = (Format(Now, "dd/MM/yyyy hh:mm:ss"))
            .Parameters.Add("@Trh_wh", SqlDbType.NChar).Value = lbWHcode.Text
            .Parameters.Add("@Trh_DePosit", SqlDbType.Float).Value = CDbl(lbDeposit.Text)
            .Parameters.Add("@Trh_strDePosit", SqlDbType.NVarChar).Value = txtDepoSit.Text
            .Parameters.Add("@Trh_DePoRef", SqlDbType.NVarChar).Value = txtRefNo.Text
            .Parameters.Add("@Trh_Term_Dtl", SqlDbType.Text).Value = txtTermDtl.Text
            .Parameters.Add("@Trh_User", SqlDbType.Text).Value = txtUserName.Text
            .Parameters.Add("@Trh_BillNote", SqlDbType.Bit).Value = 0
            .Parameters.Add("@Trh_Chk_Post", SqlDbType.Int).Value = 0



            If Conn.State = ConnectionState.Closed Then DBtools.openDB()
            Try
                .ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            updateLastSales(lbCusID.Text, Format(dtp01.Value, "dd/MM/yyyy"))
        End With

        '  ======================================   ¨ºÊèÇ¹ insert ¢éÍÁÙÅËÑÇºÔÅ ===========================================


    End Sub

    Sub delTranDataD(ByVal dtlType As String, ByVal dtlNo As String, ByVal whCode As String)

        Dim iList As Integer = 0
        Dim subDS As New DataSet
        Dim subDA As New SqlClient.SqlDataAdapter
        Dim iLocal As Integer = 0

        Dim stkCode As String = ""
        Dim stkSameCode As String = ""
        Dim stkQty As Integer = 0
        Dim cusCode As String = ""
        Dim docConID As String = ""
        Dim docTypeT As String = ""
        Dim docTypeP As String = ""
        Dim Dtl_Condition As String = ""

        'DBtools.openDB()

        txtSQL = "Select * "
        txtSQL = txtSQL & "From TranDataD "
        txtSQL = txtSQL & "Where Dtl_Type='" & dtlType & "' "
        txtSQL = txtSQL & "And Dtl_No='" & dtlNo & "' "
        txtSQL = txtSQL & "And dtl_Wh='" & whCode & "' "
        'txtSQL = txtSQL & "And dtl_conDition='" & Dtl_Condition & "' "
        ' txtSQL = txtSQL & "And dtl_idCus='" & cusCode & "'"

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "data")

        For iList = 0 To subDS.Tables("data").Rows.Count - 1

            stkSameCode = subDS.Tables("data").Rows(iList).Item("dtl_same_Code").ToString
            stkCode = subDS.Tables("data").Rows(iList).Item("dtl_idTrade").ToString
            stkQty = subDS.Tables("data").Rows(iList).Item("dtl_num")
            cusCode = subDS.Tables("data").Rows(iList).Item("dtl_idCus")
            whCode = subDS.Tables("data").Rows(iList).Item("dtl_Wh")
            docConID = subDS.Tables("data").Rows(iList).Item("Dtl_Con_iD")
            Dtl_Condition = subDS.Tables("data").Rows(iList).Item("Dtl_Condition")

            If IsDBNull(subDS.Tables("data").Rows(iList).Item("Dtl_Type_P")) Then
                docTypeP = ""
            Else
                docTypeP = subDS.Tables("data").Rows(iList).Item("Dtl_Type_P")
            End If

            If IsDBNull(subDS.Tables("data").Rows(iList).Item("Dtl_Type_T")) Then
                docTypeT = ""
            Else
                docTypeT = subDS.Tables("data").Rows(iList).Item("Dtl_Type_T")
            End If

            txtSQL = "Delete "
            txtSQL = txtSQL & "from TranDataD "
            txtSQL = txtSQL & "Where Dtl_Type='S' "
            txtSQL = txtSQL & "And Dtl_idTrade='" & stkCode & "' "
            txtSQL = txtSQL & "And Dtl_No='" & dtlNo & "' "
            txtSQL = txtSQL & "And Dtl_idCus='" & cusCode & "' "

            DBtools.dbDelDATA(txtSQL, "")
            DBtools.dbSaveUser(SqlGetUserDelItem(stkCode, 0, txtNo.Text), txtNo.Text)

            If Dvat = "P" Or Dvat = "B" Or Dvat = "M" Then
                If Dvat = "B" Or Dvat = "M" Then
                    Call upDateOrderCon(stkSameCode, (stkQty * -1), docConID)  '   µÑ´ Order 
                    'Call updateTypeP(docTypeP, docConID, stkCode, 0)
                    'Call updateTypeT(docTypeT, docConID, stkCode, 0)
                End If
            Else

                Call DBtools.updateStock("110098", whCode, stkCode, 0, 0, (stkQty * -1), False)  '  ·Õèãªé  -1 ã¹¡ÒÃ¤Ù³à¾×èÍ  àÁ×èÍãªé function  upDateStock áÅéÇ ¨Ðä»à¨Í - ÁÑ¹¨Ð¡ÅÒÂà»ç¹ +
                Call upDateOrderCon(stkSameCode, (stkQty * -1), docConID)  '   µÑ´ Order 
                Call updateTypeP(docTypeP, docConID, stkCode, 0)
                'Call updateTypeT(docTypeT, docConID, stkCode, 0, "", Dtl_Condition)
                Call updateTypeT(docTypeT, docConID, stkCode, 0, "")
            End If
        Next
        'DBtools.closeDB()
    End Sub

    Sub saveTranDataD()

        Dim Comm As New SqlClient.SqlCommand
        Dim cusCode As String = ""
        Dim docConID As String = ""
        Dim docRev As String = ""
        Dim docTypeP As String = ""
        Dim docTypeT As String = ""
        Dim strCondition As String = ""
        Dim Trh_W_Sum As Double = 0
        Dim Trh_Cost As Double = 0
        Dim DtlCostsum As Double = 0

        Dim Trh_Prod_Sales As String = ""

        '        Dim sqlSave As String = ""
        tr = Conn.BeginTransaction
        sb.Remove(0, sb.Length())

        '  -  µÃÇ¨ÊÍºÃÒÂ¡ÒÃÊÔ¹¤éÒÇèÒà»ç¹ÃÒÂ¡ÒÃà´ÔÁäËÁ
        '  -  Update Stock ÊÔ¹¤éÒ·ÕèÁÕ ¤×¹ / ËÑ¡ ÍÍ¡ µÒÁ¨Ó¹Ç¹·Õè ¢ÒÂ ËÃ×Í Â¡àÅÔ¡¡ÒÃ¢ÒÂ
        '  -  µÃÇ¨ÊÍºÇèÒÁÕàÍ¡ÊÒÃà´ÔÁÍÂÙèàËÅ×ÍäÁè
        If DBtools.getDocNumber(EditNo, "S") = True Then
            '  ÅºÃÒÂ¡ÒÃã¹ àÍ¡ÊÒÃà¡èÒ   

            Call delTranDataD("S", EditNo, lbWHcode.Text)

        End If

        ' 
        '*************************************************************ºÑ¹·Ö¡Å§Trandatad ********************************************************************
        For i = 0 To ListEdit.Items.Count - 1
            'Try

            '  à¡çº¢éÍÁÙÅÅ§ã¹µÑÇá»Ã 
            whCode = lbWHcode.Text
            cusCode = ListEdit.Items(i).SubItems(15).Text  ' 08-04-59
            stkCode = ListEdit.Items(i).SubItems(4).Text
            stkQty = ListEdit.Items(i).SubItems(6).Text
            DtlCostsum = ListEdit.Items(i).SubItems(11).Text

            DocID = txtNo.Text
            docConID = ListEdit.Items(i).SubItems(2).Text
            docRev = ListEdit.Items(i).SubItems(23).Text

            If IsDBNull(ListEdit.Items(i).SubItems(24).Text) Then
                docTypeP = ""
            Else
                docTypeP = ListEdit.Items(i).SubItems(24).Text
            End If

            If IsDBNull(ListEdit.Items(i).SubItems(23).Text) Then
                docTypeT = ""
            Else
                docTypeT = ListEdit.Items(i).SubItems(23).Text
            End If

            Dim Dtl_Runnum As Double = 0
            Dim Dtl_type As String = ""
            'Dim Dtl_date As Date
            Dim Dtl_No As String = ""

            Dim Dtl_PO As String = ""
            Dim Dtl_IDcus As String = ""


            Dim Dtl_idTrade As String = ""
            Dim Dtl_Price As Double = 0
            Dim Dtl_Pr_Cost As Double = 0

            Dim Dtl_Num As Double = 0
            Dim Dtl_Sum As Double = 0
            Dim Dtl_Detail As String = ""

            Dim Dtl_Con_ID As String = ""
            Dim Dtl_Order As String = ""
            Dim Dtl_Condition As String = ""

            Dim Dtl_T_Disc As String = ""
            Dim Dtl_Date_1 As String = ""
            '  à¡çº¢ÍÁÙÅÃËÑÊÊÔ¹¤éÒã¹¡Ã³ÕãªéÊÔ¹¤éÒ·´á·¹ à¾×èÍ¹Óä»µÑ´ Order 
            Dim oldCode As String = ""
            Dim Dtl_Same_Code As String = ""
            Dim Dtl_WH As String = ""
            Dim Dtl_Type_P As String = ""
            Dim Dtl_Type_T As String = ""

            txtSQL = ""

            'txtSQL = sb.ToString()

            Dtl_Runnum = (i + 1)
            Dtl_type = "S"   ' == V1
            Dtl_No = DocID   'Trim(ListEdit.Items(i).SubItems(15).Text).ToString   '  àÅ¢·ÕèºÔÅ")
            '.Parameters.Add("@Trh_No", SqlDbType.NVarChar).Value = Trim(txtNo.Text)
            Dtl_PO = ListEdit.Items(i).SubItems(1).Text

            Dtl_IDcus = cusCode '(ListEdit.Items(i).SubItems(14).Text).ToString")

            Dtl_idTrade = stkCode '(ListEdit.Items(i).SubItems(4).Text).ToString
            Dtl_Price = CDbl((ListEdit.Items(i).SubItems(7).Text))

            Dtl_Num = stkQty 'CDbl((ListEdit.Items(i).SubItems(6).Text))
            Dtl_Sum = CDbl((ListEdit.Items(i).SubItems(10).Text))  ' 59-04-08
            Dtl_Detail = (ListEdit.Items(i).SubItems(14).Text).ToString ' 59-04-08
            Dtl_Condition = (ListEdit.Items(i).SubItems(25).Text).ToString  '

            Dtl_Con_ID = docConID
            Dtl_Order = lbTypeP.Text

            'lbRevDocNo.Text = ""

            Dtl_T_Disc = (ListEdit.Items(i).SubItems(8).Text).ToString  ' 59-04-08  á¡é¨Ò¡ 17 à»ç¹ 8
            'Dtl_Date_1 = (Format(Now, "dd/MM/yyyy hh:mm:ss"))

            ' (((Month( Now) & "/" & DateAndTime.Day(Now) & "/" & Year(Now) - 543)))
            Dtl_Date_1 = (((DateAndTime.Day(Now) & Month(Now) & Year(Now) - 543))).ToString
            'Dtl_Date_1 = (((DateAndTime.Day(Now) & "/" & Month(Now) & "/" & Year(Now) - 543))).ToString
            '  à¡çº¢ÍÁÙÅÃËÑÊÊÔ¹¤éÒã¹¡Ã³ÕãªéÊÔ¹¤éÒ·´á·¹ à¾×èÍ¹Óä»µÑ´ Order 
            oldCode = ListEdit.Items(i).SubItems(18).Text
            Dtl_Same_Code = (ListEdit.Items(i).SubItems(18).Text).ToString
            Dtl_WH = (lbWHcode.Text).ToString


            Dtl_Type_T = (ListEdit.Items(i).SubItems(23).Text).ToString   ' ãº¨Í§
            Dtl_Type_P = (ListEdit.Items(i).SubItems(24).Text).ToString   ' ãºàºÔ¡
            Dim dateStr As Date = ((DateAndTime.Day(dtp01.Value) & "/" & Month(dtp01.Value) & "/" & Year(dtp01.Value)))
            Dtl_Pr_Cost = getCostByStk(Dtl_idTrade, dateStr, "", 0) 'getCostByStk(stkCode, date01, "", 0) 
            'Dtl_Cost_Sum = DtlCostsum

            txtSQL = "Insert Into Trandatad("

            txtSQL = txtSQL & "Dtl_type,Dtl_date,Dtl_time,Dtl_No,Dtl_PO,"
            txtSQL = txtSQL & "Dtl_IDcus,"
            txtSQL = txtSQL & "Dtl_idTrade,Dtl_Price,Dtl_Num,Dtl_Sum,"  'V3
            txtSQL = txtSQL & "Dtl_Detail,Dtl_Con_ID,Dtl_Order,"
            txtSQL = txtSQL & "Dtl_Condition,Dtl_T_Disc,Dtl_Runnum,"  '  V4        
            txtSQL = txtSQL & "Dtl_Date_1,Dtl_Same_Code,Dtl_WH,"
            txtSQL = txtSQL & "Dtl_Type_P,Dtl_Type_T,Dtl_Pr_Cost,Dtl_Cost_Sum) "  ' V5  

            txtSQL = txtSQL & "Values('" & Dtl_type & "','"

            '((Month( dtp01.Value) & "-" & DateAndTime.Day( dtp01.Value) & "-" & Year( dtp01.Value) - 543))
            'txtSQL = txtSQL & Format(dtp01.Value, "dd/MM/yyyy") & "','"
            txtSQL = txtSQL & ((Month(dtp01.Value) & "/" & DateAndTime.Day(dtp01.Value) & "/" & Year(dtp01.Value) - 543)) & "','"
            txtSQL = txtSQL & (Format(Now, "HH:mm:ss")) & "','"
            txtSQL = txtSQL & Dtl_No & "','" & Dtl_PO & "','"  '  V1
            txtSQL = txtSQL & Dtl_IDcus & "','"  'V2
            txtSQL = txtSQL & Dtl_idTrade & "','" & Dtl_Price & "','" & Dtl_Num & "','" & Dtl_Sum & "','" 'V3
            txtSQL = txtSQL & Dtl_Detail & "','" & Dtl_Con_ID & "','" & Dtl_Order & "','"
            txtSQL = txtSQL & Dtl_Condition & "','" & Dtl_T_Disc & "','" & Dtl_Runnum & "','"  '  V4        
            txtSQL = txtSQL & Dtl_Date_1 & "','" & Dtl_Same_Code & "','" & Dtl_WH & "','"
            txtSQL = txtSQL & Dtl_Type_P & "','" & Dtl_Type_T & "','" & Dtl_Pr_Cost & "','" & DtlCostsum & "')"  ' V5  

            With Comm

                .Connection = Conn
                .CommandText = txtSQL
                .Transaction = tr
                '.Parameters.Clear()

                If Conn.State = ConnectionState.Closed Then DBtools.openDB()
                .ExecuteNonQuery()

            End With

            '            MsgBox("àÍ¡ÊÒÃà»ç¹áºº " & Dvat)
            DBtools.dbSaveUser(SqlGetUserSaveItem(stkCode, 0, DocID), DocID)
            prTools.setPrice(docType, cusCode, stkCode, CDbl((ListEdit.Items(i).SubItems(7).Text)))

            If Dvat = "P" Or Dvat = "B" Or Dvat = "M" Then  '   äÁè¤Ô´ÊµêÍ¡
                If Dvat = "B" Or Dvat = "M" Then
                    Call upDateOrderCon(oldCode, stkQty, docConID)

                End If
            Else   '   µÃ§¹ÕéÅ§ä» µÑ´ÊµêÍ¡

                Call DBtools.updateStock("110098", whCode, stkCode, 0, 0, stkQty, False)
                Call upDateOrderCon(oldCode, stkQty, docConID)

                Call updateTypeP(docTypeP, docConID, oldCode, 1)
                'Call updateTypeT(docTypeT, docConID, oldCode, 1, Dtl_No, Dtl_Condition)
                Call updateTypeT(docTypeT, docConID, oldCode, 1, Dtl_No)

            End If
            '    'updateTypeP(
            'Catch ex As Exception

            '    MsgBox("à¡Ô´¢éÍ¼Ô´¾ÅÒ´ã¹ÊèÇ¹¢éÍÁÙÅ-ÃÒÂ¡ÒÃ " & txtNo.Text & "- ÊÔ¹¤éÒ -" & DBtools.getStkName(stkCode) & "- ÃÒÂ¡ÒÃ¹ÕéÍÒ¨¨ÐÂÑ§äÁèä´é¶Ù¡ºÑ¹·Ö¡ - â»Ã´á¨é§ ICT ! ", MsgBoxStyle.Critical, "á¨é§àµ×Í¹")
            '    'Exit Sub

            'End Try
            Trh_Prod_Sales = getProDCode(Dtl_idTrade)
            If DBtools.getCostType(Dtl_idTrade) = 0 Then
                Dim dateCost As Date = (DateAndTime.Day(dtp01.Value) & "/" & (Month(dtp01.Value) & "/" & Year(dtp01.Value)))
                Dim Trh_w As Double = 0
                Dim prCost As Double = 0

                Trh_w = (getStkWight(Dtl_idTrade) * Dtl_Num)
                Trh_W_Sum = Trh_W_Sum + Trh_w

                prCost = getCostByStk(Dtl_idTrade, dateCost, "", 0)
                Trh_Cost = Trh_Cost + (prCost * Trh_w)

            Else
                Dim prCost As Double = 0
                Dim dateCost As Date = (DateAndTime.Day(dtp01.Value) & "/" & (Month(dtp01.Value) & "/" & Year(dtp01.Value)))
                Trh_W_Sum = 0

                prCost = getCostByStk(Dtl_idTrade, dateCost, "", 0)
                Trh_Cost = Trh_Cost + (prCost * Dtl_Num)
            End If

        Next

        'txtSQL = "Update TranDataH "
        'txtSQL = txtSQL & "Set 
        'txtSQL = txtSQL & "Where Trh_Type='S' and TRh_no='" & txtNo.Text & "'"
        'DBtools.dbSaveDATA(txtSQL, "")

        'txtSQL = "Update TranDataH "
        'txtSQL = txtSQL & "Set Trh_Item_Count='" & ans & "' "
        'txtSQL = txtSQL & "Where Trh_Type='S' and TRh_no='" & DocNo & "'"
        'DBtools.dbSaveDATA(txtSQL, "")

        ' update ¢éÍÁÙÅ¾ÔàÈÉ  à¾×èÍãªéã¹ÃÒÂ§Ò¹ 
        txtSQL = "Update TranDataH "
        txtSQL = txtSQL & "Set Trh_w_Sum=" & Trh_W_Sum & ", "
        txtSQL = txtSQL & "Trh_Cost_Amt=" & Trh_Cost & ","
        txtSQL = txtSQL & "Trh_Item_Count=" & (ListEdit.Items.Count) & ","
        txtSQL = txtSQL & "Trh_ProD_Sales='" & Trh_Prod_Sales & "' "

        txtSQL = txtSQL & "Where Trh_Type='S' and TRh_no='" & txtNo.Text & "'"

        DBtools.dbSaveDATA(txtSQL, "")
        Trh_W_Sum = 0
        Trh_Cost = 0

        '********************************************************¨º¡ÒÃºÑ¹·Ö¡¢éÍÁÙÅÅ§ trandatad *********************************************************

    End Sub

    Sub upDateOrderCon(ByVal stkCode As String, ByVal orderQty As Double, ByVal docConNo As String)
        '   ÊèÇ¹¢Í§µÑ´ Order 

        Dim subDS As DataSet = New DataSet
        Dim subDA As SqlClient.SqlDataAdapter
        Dim iCount As Integer = 0
        Dim Qty As Integer = 0

        txtSQL = "Select * "
        txtSQL = txtSQL & "From TranDataD "

        txtSQL = txtSQL & "Where Dtl_Type ='B' "
        txtSQL = txtSQL & "And Dtl_No='" & docConNo & "'"
        txtSQL = txtSQL & "And Dtl_idTrade ='" & stkCode & "' "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "Data")
        iCount = subDS.Tables("Data").Rows.Count
        '  µÃ§¹Õé¼Ô´  µéÍ§ãªé sum() ÁÒ  áµèãªéä»¡èÍ¹  äÇéÁÒá¡éä¢ãËé Select ¢éÍÁÙÅáºº sum 

        Try
            If subDS.Tables("Data").Rows.Count = 0 Then

                txtSQL = "Update trandatad "
                txtSQL = txtSQL & "Set "
                txtSQL = txtSQL & "dtl_num_2='" & orderQty & "' "

                txtSQL = txtSQL & "Where dtl_idtrade='" & stkCode & "' "
                txtSQL = txtSQL & "And dtl_con_id='" & docConNo & "' "
                txtSQL = txtSQL & "And dtl_type='B' "

                DBtools.dbSaveDATA(txtSQL, docConNo)

                ' ·Óà¾×èÍãËéäÁèÊÒÁÒÃ¶á¡éä¢ order ä´éËÅÑ§¨Ò¡ÁÕ¡ÒÃºÑ¹·Ö¡¢ÒÂ
                txtSQL = "Update TranDataH "
                txtSQL = txtSQL & "Set Trh_Print='1' "
                txtSQL = txtSQL & "Where Trh_Type='B' "
                txtSQL = txtSQL & "And trh_no='" & docConNo & "'"
                DBtools.dbSaveDATA(txtSQL, docConNo)

                DBtools.dbSaveUser(SqlGetChkOrderItem(stkCode, docConNo, False), DocID)

            Else

                Qty = subDS.Tables("Data").Rows(0).Item("Dtl_Num_2")
                'If stkCode = "010104000305030500001011" Then
                ' ·ÓäÇéµÃÇ¨ÊÍº ÃËÑÊÊÔ¹¤éÒ
                'MsgBox("ÊÔ¹¤éÒà»ç¹ 4 ÁÔÅ 1x1")
                'End If
                txtSQL = "Update trandatad "
                txtSQL = txtSQL & "Set "
                txtSQL = txtSQL & "dtl_num_2='" & orderQty + Qty & "' "

                txtSQL = txtSQL & "Where dtl_idtrade='" & stkCode & "' "
                txtSQL = txtSQL & "And dtl_con_id='" & docConNo & "' "
                txtSQL = txtSQL & "And dtl_type='B' "

                DBtools.dbSaveDATA(txtSQL, docConNo)

                ' ·Óà¾×èÍãËéäÁèÊÒÁÒÃ¶á¡éä¢ order ä´éËÅÑ§¨Ò¡ÁÕ¡ÒÃºÑ¹·Ö¡¢ÒÂ
                txtSQL = "Update TranDataH "
                txtSQL = txtSQL & "Set Trh_Print='1' "
                txtSQL = txtSQL & "Where Trh_Type='B' "
                txtSQL = txtSQL & "And trh_no='" & docConNo & "'"
                DBtools.dbSaveDATA(txtSQL, docConNo)

                DBtools.dbSaveUser(SqlGetChkOrderItem(stkCode, docConNo, True), DocID)
            End If
            DBtools.dbSaveUser(SqlGetUserUpdateOrOK, txtNo.Text)
        Catch ex As Exception

            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

            DBtools.dbSaveUser(SqlGetUserUpdateOrError, txtNo.Text & ex.Message)

        End Try
    End Sub

    Function SqlGetUserUpdateOrError() As String
        txtSQL = "Insert into userhistory("
        txtSQL = txtSQL & "history_user,history_Status,history_date,history_time,History_head"
        txtSQL = txtSQL & ")"
        txtSQL = txtSQL & "Values("
        txtSQL = txtSQL & "'" & GetUserName() & "','update Ord Error" & txtNo.Text & "   ','"
        '(((Month(Now) & "/" & DateAndTime.Day(Now) & "/" & Year(Now) - 543))) 

        txtSQL = txtSQL & (((Month(Now) & "/" & DateAndTime.Day(Now) & "/" & Year(Now) - 543))) & "','"
        txtSQL = txtSQL & (Format((Now), "HH:mm:ss")) & "','"
        txtSQL = txtSQL & txtNo.Text & "'"
        txtSQL = txtSQL & ")"
        Return txtSQL
    End Function
    Function SqlGetUserUpdateOrOK() As String
        txtSQL = "Insert into userhistory("
        txtSQL = txtSQL & "history_user,history_Status,history_date,history_time,History_head"
        txtSQL = txtSQL & ")"
        txtSQL = txtSQL & "Values("
        txtSQL = txtSQL & "'" & GetUserName() & "','á¡éä¢àÍ¡ÊÒÃàÅ¢·Õè" & txtNo.Text & "   ','"
        txtSQL = txtSQL & (((Month(Now) & "/" & DateAndTime.Day(Now) & "/" & Year(Now) - 543))) & "','"
        txtSQL = txtSQL & (Format((Now), "HH:mm:ss")) & "','"
        txtSQL = txtSQL & txtNo.Text & "'"
        txtSQL = txtSQL & ")"
        Return txtSQL
    End Function


    Sub getDataD()

        '   à¡çº¢éÍÁÙÅÅ§µÑÇá»Ã  ÊÓËÃÑº ºÑ¹·Ö¡ ÃÒÂ¡ÒÃÊÔ¹¤éÒ+ÃÒ¤ÒµèÒ§æ 
        'sb.Append("Values (@Dtl_type,@Dtl_date,@Dtl_No,@Dtl_PO,")  '  V1
        'sb.Append("@Dtl_IDcus,")   'V2
        'sb.Append("@Dtl_idTrade,@Dtl_Price,@Dtl_Num,@Dtl_Sum,") 'V3
        'sb.Append("@Dtl_Detail,@Dtl_Con_ID,@Dtl_T_Disc,@Dtl_Runnum,")  '  V4        
        'sb.Append("@Dtl_Date_1,@Dtl_Same_Code,@Dtl_WH )")  ' V5            

        For i = 0 To ListEdit.Items.Count - 1


            PackNo = CStr(ListEdit.Items(i).SubItems(1).Text)       '  àÅ¢·ÕèãºàºÔ¡
            OrderNo = CStr(ListEdit.Items(i).SubItems(2).Text)      '  àÅ¢·Õè  Order            
            stkCode = CStr(ListEdit.Items(i).SubItems(4).Text)      '  ÃËÑÊÊÔ¹¤éÒ            

            If ListEdit.Items(i).SubItems(7).Text <> "" Then
                stkPrice = CDbl(ListEdit.Items(i).SubItems(7).Text)   ' ÃÒ¤Ò¢ÒÂµèÍá¼è¹
            Else
                MsgBox("ÊÔ¹¤éÒ¹ÕéÃÒ¤Òà»ç¹ÈÙ¹Âì ", MsgBoxStyle.Critical, "àµ×Í¹")
                stkPrice = 0
            End If

            If ListEdit.Items(i).SubItems(6).Text <> "" Then
                EditNum = CSng(ListEdit.Items(i).SubItems(6).Text)   '  ¨Ó¹Ç¹¢ÒÂ
                stkQty = CSng(ListEdit.Items(i).SubItems(6).Text)      '  ¨Ó¹Ç¹¢ÒÂ
            End If

            If ListEdit.Items(i).SubItems(16).Text <> "" Then
                Edit = CStr(ListEdit.Items(i).SubItems(16).Text)     '   Same_Code
            End If

            If ListEdit.Items(i).SubItems(10).Text <> "" Then
                EditWeight = CSng(ListEdit.Items(i).SubItems(10).Text) ' ¹éÓË¹Ñ¡ÊÔ¹¤éÒÃÇÁ·Ñé§ËÁ´ËË
                stkWeight = CSng(ListEdit.Items(i).SubItems(9).Text)   '  ¹éèÓË¹Ñ¡¢ÒÂ
            End If


            '¢éÍÁÙÅ ËÁÒÂàËµØ
            If ListEdit.Items(i).SubItems(10).Text <> "" Then
                TrhDetail = CStr(ListEdit.Items(i).SubItems(10).Text)
            Else
                TrhDetail = ""
            End If


            '===============   àÃÕÂ¡ â»Ãá¡ÃÁà¾×èÍºÑ¹·Ö¡¢éÍÁÙÅ·Õèä´é¨Ò¡µÑÇá»Ã 

            '      Call saveTranDataD()


        Next


    End Sub

    Sub saveData01()

        Dim DS As DataSet = New DataSet
        Dim DA As SqlClient.SqlDataAdapter
        Dim SComMand As SqlClient.SqlCommand = New SqlClient.SqlCommand

        Dim i As Integer
        Dim itemInOrder As Integer = 0 'à¡çº¨Ó¹Ç¹order

        'Dim tmpMoney As Single = 0 'à¡çºÂÍ´à§Ô¹·Õèä´éÃÑº
        'Dim OldStkCode As String


        Dim chkDocTypeS As Boolean = False
        Dim chkEditItem As Integer = 1  ' 0=

        '============   µÃÇ¨ÊÍº¢éÍÁÙÅ¡èÍ¹ºÑ¹·Ö¡ =========================================================================


        '=============  §§ ÍÂÙè ¨ÍÂàªç¤·ÓäÁ   ==========================
        'DS.Clear()

        'txtSQLd = "Select * "
        'txtSQLd = txtSQLd & "From trandatad "
        'txtSQLd = txtSQLd & "Where dtl_no='" & txtNo.Text & "' "
        'txtSQLd = txtSQLd & "And dtl_type='s' "
        ''txtSQLd = txtSQLd & "And dtl_Wh='" & lbWHcode.Text & "'"

        'DA = New SqlClient.SqlDataAdapter(txtSQLd, Conn)
        'DA.Fill(DS, "DataD")

        '********************************************************ºÑ¹·Ö¡ ¢éÍÁÙÅËÅÑ¡ ¢Í§ËÑÇºÔÅ **********************************

        Call DBtools.getRunID(txtNo.Text)



        '******************************************************** à¡çº¢éÍÁÙÅËÅÑ¡ ¢Í§ÃÒÂ¡ÒÃã¹ºÔÅ *******************************************

        For i = 0 To ListEdit.Items.Count - 1

            '        OrderNo = DS.Tables("DataD").Rows(i).Item("dtl_con_id")
            'If DBtools.getDocNumber(OrderNo, "B") = True Then
            '            '=========  Å´¨Ó¹Ç¹ Order Å§µÒÁ¨Ó¹Ç¹¡ÒÃ¢ÒÂ 
            '            orderQty = subDs.Tables("UpOrder").Rows(0).Item("dtl_num_2") - stkQty
            '            Call upDateOrderCon(stkCode, orderQty, OrderNo)
            'End If

            PickingDocNo = CStr(ListEdit.Items(i).SubItems(1).Text)  '  àÅ¢·ÕèãºàºÔ¡
            OrderNo = CStr(ListEdit.Items(i).SubItems(2).Text)       '  àÅ¢·Õè  Order            

            stkCode = CStr(ListEdit.Items(i).SubItems(16).Text)    '  ÃËÑÊÊÔ¹¤éÒ            

            If ListEdit.Items(i).SubItems(16).Text <> "" Then
                Edit = CStr(ListEdit.Items(i).SubItems(16).Text)     '   Same_Code
            End If
            If ListEdit.Items(i).SubItems(6).Text <> "" Then
                EditNum = CSng(ListEdit.Items(i).SubItems(6).Text)   '  ¨Ó¹Ç¹¢ÒÂ
                stkQty = CSng(ListEdit.Items(i).SubItems(6).Text)      '  ¨Ó¹Ç¹¢ÒÂ
            End If
            If ListEdit.Items(i).SubItems(10).Text <> "" Then
                EditWeight = CSng(ListEdit.Items(i).SubItems(10).Text) ' ¹éÓË¹Ñ¡ÊÔ¹¤éÒÃÇÁ·Ñé§ËÁ´ËË
                stkWeight = CSng(ListEdit.Items(i).SubItems(9).Text)   '  ¹éèÓË¹Ñ¡¢ÒÂ
            End If

            If ListEdit.Items(i).SubItems(7).Text <> "" Then
                stkPrice = CDbl(ListEdit.Items(i).SubItems(7).Text)   ' ÃÒ¤Ò¢ÒÂµèÍá¼è¹
            Else
                stkPrice = 0
            End If
            If ListEdit.Items(i).SubItems(10).Text <> "" Then

                TrhDetail = CStr(ListEdit.Items(i).SubItems(10).Text)
            Else
                TrhDetail = ""

            End If

            '************************************************µÑ´Stock  µéÍ§µÑ´¨Ò¡ÃËÑÊÊÔ¹¤éÒãËÁè·Õèá¡éä¢áÅéÇ***********************************************
            'Dim STOCKTEST As Integer

            If txtSaleMan.Text <> "SL03" Then  '¶éÒ SL03 ¨Ðà»ç¹ ¤Ø³¾ÔÁ¾ì  



                DS.Clear()
                txtSQL = "SELECT    Stkdetl.DTL_STORE, Stkdetl.DTL_WH, Stkdetl.DTL_CODE, "
                txtSQL = txtSQL & " Stkdetl.DTL_LS_TT, Stkdetl.DTL_LS_Q1, Stkdetl.DTL_LS_Q2, Stkdetl.DTL_LS_TRN, "
                txtSQL = txtSQL & " Stkdetl.DTL_BAL_Q1, Stkdetl.DTL_BAL_Q2, Stkdetl.Dtl_OR_Q1, Stkdetl.Dtl_OR_Q2,"
                txtSQL = txtSQL & " Stkdetl.DTL_ISS_Q1, Stkdetl.DTL_ISS_Q2, Stkdetl.DTL_RCV_Q1, "
                txtSQL = txtSQL & " Stkdetl.DTL_RCV_Q2, Stkdetl.DTL_BAL_TT, Stkdetl.DTL_Pen_Q1, Stkdetl.DTL_Pen_Q2,"
                txtSQL = txtSQL & " Stkdetl.DTL_MIN_PT, Stkdetl.DTL_MAX_PT, Stkdetl.DTL_LS_LS, "
                txtSQL = txtSQL & " Stkdetl.DTL_DIST, Stkdetl.DTL_ACCT, Stkdetl.DTL_AC_DM,"
                txtSQL = txtSQL & " Stkdetl.DTL_AC_CS, Stkdetl.DTL_AC_CR, Stkdetl.DTL_AC_SL, Stkdetl.DTL_AC_SR, "
                txtSQL = txtSQL & " Stkdetl.DTL_AC_EX, Stkdetl.DTL_AC_WP, Stkdetl.DTL_AC_RT, BaseMast.Stk_Name_1 "

                txtSQL = txtSQL & " FROM Stkdetl LEFT OUTER JOIN"
                txtSQL = txtSQL & " BaseMast ON Stkdetl.DTL_CODE = BaseMast.Stk_Code "

                txtSQL = txtSQL & " where dtl_code='" & stkCode & "' "
                txtSQL = txtSQL & " And dtl_store='" & CusID & "' "
                txtSQL = txtSQL & " And stkdetl.dtl_wh='" & lbWHcode.Text & "' "

                DA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
                DA.Fill(DS, "Stock")
                'chkStock = True
                'STOCKTEST = DS.Tables("Stock").Rows(0).Item("dtl_bal_q1")

                If DS.Tables("Stock").Rows.Count > 0 Then

                    If Edit <> 1 Then

                        '[====================================================]
                        '[                                                    ]
                        '[                                                    ]
                        '[      ÁÕ»Ñ­ËÒ·Õè¨Ø´¹ÕéµéÍ§á¡éä¢                                                             ]
                        '[  Åº¢éÍÁÙÅä»áÅéÇáµè¡ÅÑºäÁèãËé Save ·ÓãËé¢éÍÁÙÅËÒÂ                              ]
                        '[                                                    ]
                        '[                                                    ]
                        '[====================================================]

                        If DBtools.getStock(stkCode, CusID, whCode) >= stkQty Then '  check ÇèÒ stock µéÍ§ÁÒ¡¡ÇèÒ·Õè¢ÒÂ¶Ö§¨ÐµÑ´ stock ä´é
                            Iss = CInt(DS.Tables("Stock").Rows(0).Item("dtl_iss_q1")) + stkQty
                            'WIss = Format(IssWeight + DS.Tables("Stock").Rows(0).Item("dtl_iss_q2"), "#,##0.000")
                            Bal = CInt(DS.Tables("Stock").Rows(0).Item("dtl_bal_q1")) - stkQty
                            'WBal = Format(DS.Tables("Stock").Rows(0).Item("dtl_bal_q2") - IssWeight, "#,##0.000")
                            'Else
                            '    MessageBox.Show("stock ¢Í§ '" & DS.Tables("Stock").Rows(0).Item("stk_name_1") & "' ¶Ö§ÃÒÂ¡ÒÃ·Õè  '" & i + 1 & "' ¨ÐÁÕ stock àËÅ×Íá¤è   '" & DS.Tables("Stock").Rows(0).Item("dtl_bal_q1") & "' «Öè§äÁè¾Í¡ÃØ³Ò·Ó¡ÒÃâÍ¹ÊÔ¹¤éÒâ´Â¡´»ØèÁ F12 áÅéÇ·Ó¡ÒÃ¡´»ØèÁºÑ¹·Ö¡ÍÕ¡¤ÃÑé§", "¤Óàµ×Í¹", MessageBoxButtons.OK)
                            '    Exit Sub
                        End If

                    ElseIf Edit = 1 Then 'á¡éä¢

                        If IssNum < EditNum Then '¨Ó¹Ç¹ãËÁè¹éÍÂ¡ÇèÒ¨Ó¹Ç¹à¡èÒ
                            Iss = DS.Tables("Stock").Rows(0).Item("dtl_iss_q1") + (IssNum)
                            Bal = DS.Tables("Stock").Rows(0).Item("dtl_bal_q1") - (IssNum)
                            'WIss = Format(DS.Tables("Stock").Rows(0).Item("dtl_iss_q2") - (IssWeight), "#,##0.00")
                            If OrderNo = "" Or OrderNo = "äÁèÁÕOrder" Then
                            Else
                                Or_Q1 = DS.Tables("Stock").Rows(0).Item("dtl_or_q1") - IssNum
                            End If
                        ElseIf IssNum > EditNum Then '¨Ó¹Ç¹ãËÁèÁÒ¡¡ÇèÒ¨Ó¹Ç¹à¡èÒ
                            Iss = DS.Tables("Stock").Rows(0).Item("dtl_iss_q1") + (IssNum)
                            Bal = DS.Tables("Stock").Rows(0).Item("dtl_bal_q1") - (IssNum)

                            If OrderNo = "" Or OrderNo = "äÁèÁÕOrder" Then
                            Else
                                Or_Q1 = DS.Tables("Stock").Rows(0).Item("dtl_or_q1") - IssNum
                            End If
                        ElseIf IssNum = EditNum Then '¨Ó¹Ç¹ãËÁèà·èÒ¡Ñº¨Ó¹Ç¹à¡èÒ ¤×Í äÁèä´éá¡éä¢µÑÇàÅ¢áµèá¡éä¢ÍÂèÒ§Í×è¹
                            Iss = IssNum + DS.Tables("Stock").Rows(0).Item("dtl_iss_q1")
                            Bal = DS.Tables("Stock").Rows(0).Item("dtl_bal_q1") - IssNum

                            If OrderNo = "" Or OrderNo = "äÁèÁÕOrder" Then
                            Else
                                Or_Q1 = DS.Tables("Stock").Rows(0).Item("dtl_or_q1") - IssNum
                            End If
                        End If

                    End If
                    txtSQL = "Update StkDetl "
                    txtSQL = txtSQL & "Set "
                    txtSQL = txtSQL & "dtl_iss_q1='" & Iss & "',"
                    txtSQL = txtSQL & "dtl_bal_q1='" & Bal & "' "
                    If OrderNo = "" Or OrderNo = "äÁèÁÕOrder" Then
                    Else
                        txtSQL = txtSQL & ",dtl_or_q1='" & Or_Q1 & "' "
                    End If
                    txtSQL = txtSQL & "Where dtl_code='" & NewCode & "' "
                    txtSQL = txtSQL & "And dtl_store='" & CusID & "' "
                    txtSQL = txtSQL & "And Dtl_Wh='" & lbWHcode.Text & "' "


                    Try
                        With subCom
                            .CommandType = CommandType.Text
                            .CommandText = txtSQL
                            .Connection = Conn
                            '.ExecuteNonQuery()
                        End With
                    Catch errprocess As Exception
                        MessageBox.Show("äÁèÊÒÁÒÃ¶à¾ÔèÁ¢éÍÁÙÅä´éà¹×èÍ§¨Ò¡ " & errprocess.Message, "¢éÍ¼Ô´¾ÅÒ´", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End Try
                End If
            End If

            '************************************************µÑ´Order***********************************************

            DS.Clear()

            txtSQL = "Select * "
            txtSQL = txtSQL & "From trandatad "

            txtSQL = txtSQL & "where dtl_idtrade='" & oldCode & "' "
            txtSQL = txtSQL & "And dtl_type='b' "
            txtSQL = txtSQL & "and dtl_con_id='" & OrderNo & "'"

            'If chkOrder = True Then
            '    DS.Tables("Order").Clear()
            '    chkOrder = False
            'End If
            DA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            DA.Fill(DS, "Order")
            'chkOrder = True

            If DS.Tables("Order").Rows.Count > 0 Then


                orderNum = IssNum + DS.Tables("Order").Rows(0).Item("dtl_num_2")


                txtSQL = "Update trandatad "
                txtSQL = txtSQL & "Set "
                txtSQL = txtSQL & "dtl_num_2='" & orderNum & "' "
                txtSQL = txtSQL & "Where dtl_idtrade='" & oldCode & "' "
                txtSQL = txtSQL & "And dtl_con_id='" & OrderNo & "' "
                txtSQL = txtSQL & "And dtl_type='B' "


                Try
                    With subCom
                        .CommandType = CommandType.Text
                        .CommandText = txtSQL
                        .Connection = Conn
                        '.ExecuteNonQuery()
                    End With
                Catch errprocess As Exception
                    MessageBox.Show("äÁèÊÒÁÒÃ¶à¾ÔèÁ¢éÍÁÙÅä´éà¹×èÍ§¨Ò¡ " & errprocess.Message, "¢éÍ¼Ô´¾ÅÒ´", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            End If

            oldCode = ""
            NewCode = ""
            OrderNo = ""


        Next

        '*******************************************add data into trandatah**********************************************
        If Microsoft.VisualBasic.Right(txtCusDisc.Text, 1) = "b" Then
            TrhDisc = CDbl(Microsoft.VisualBasic.Left(txtCusDisc.Text, (Len(txtCusDisc.Text) - 1)))
        Else
            TrhDisc = CDbl(txtCusDisc.Text)
        End If

        '==============  ·Óà¾×èÍÍÐäÃ  =====================
        '                                             '
        '                                             '
        '                                             '
        '==============  ·Óà¾×èÍÍÐäÃ  =====================
        If Len(txtNo.Text) = 8 Then
            IDNo = Microsoft.VisualBasic.Right(txtNo.Text, 3)
        ElseIf Len(txtNo.Text) = 9 Then
            'strDoc = Microsoft.VisualBasic.Right(txtNo.Text, 4)
            IDNo = Microsoft.VisualBasic.Right(txtNo.Text, 4)
        End If

        If Microsoft.VisualBasic.Left(txtNo.Text, 1) = "V" Then

            txtSQL = " insert into trandatah(trh_type,trh_notype,trh_no,trh_cus,trh_date,trh_amt,"
            txtSQL = txtSQL & "trh_d_amt,trh_detail,trh_full_amt,trh_term,trh_disc,trh_sale,trh_v_amt,trh_print,"
            txtSQL = txtSQL & "trh_bill,trh_tran,trh_web,trh_cre_lim,trh_runid,trh_update,Trh_wh,trh_DePosit)"

            txtSQL = txtSQL & " values('S','" & cboTypeDoc.SelectedValue & "','" & Trim(txtNo.Text) & "',"
            txtSQL = txtSQL & "'" & Trim(lbCusID.Text) & "','"

            ' (((Month( dtp01.Value) & "/" & DateAndTime.Day( dtp01.Value) & "/" & Year( dtp01.Value) - 543)))
            txtSQL = txtSQL & (((Month(dtp01.Value) & "/" & DateAndTime.Day(dtp01.Value) & "/" & Year(dtp01.Value) - 543))) & "',"
            'txtSQL = txtSQL & (Format(DateAdd(DateInterval.Year, -543, dtp01.Value), "MM/dd/yyyy")) & "',"
            txtSQL = txtSQL & "'" & CDbl(lbSumary.Text) & "',"

            If Microsoft.VisualBasic.Right(txtCusDisc.Text, 1) = "b" Then   '              Trh_D_Amt
                txtSQL = txtSQL & "'" & (CDbl(lbSumary.Text) - TrhDisc) & "',"
            Else
                txtSQL = txtSQL & "'" & (CDbl(lbSumary.Text) - (CDbl(lbSumary.Text) * CDbl(txtCusDisc.Text)) / 100) & "',"
            End If                                                          '              Trh_D_Amt

            txtSQL = txtSQL & "'" & txtDetail.Text & "','" & CDbl(lbSumary.Text) & "'"
            txtSQL = txtSQL & " ,'" & Trim(txtCredit.Text) & "','" & txtCusDisc.Text & "', '" & txtSaleMan.Text & "'"

            If Microsoft.VisualBasic.Right(txtCusDisc.Text, 1) = "b" Then

                txtSQL = txtSQL & "," & (CDbl(lbSumary.Text) - TrhDisc) * 7 / 100 & ","
            Else
                txtSQL = txtSQL & "," & (CDbl(lbSumary.Text) - (CDbl(lbSumary.Text) * CDbl(txtCusDisc.Text)) / 100) * 7 / 100 & ","
            End If
            txtSQL = txtSQL & " '0', '" & txtCusVat.Text & "','0','0','" & lbCreLimit.Text & "','" & CInt(IDNo) & "',"

            '(((Month( Now) & "/" & DateAndTime.Day(Now) & "/" & Year(Now) - 543)))
            txtSQL = txtSQL & "'" & (Format((Now), "MM/dd/yyyy hh:mm:ss")) & "',"

            txtSQL = txtSQL & " '" & lbWHcode.Text & "','" & txtDepoSit.Text & "')"

            '  ======================================   ¨ºÊèÇ¹ insert ¢éÍÁÙÅËÑÇºÔÅ ===========================================

        Else 'Nonvat

            txtSQL = " insert into trandatah(trh_type,trh_notype,trh_no,trh_cus,trh_date,trh_amt,trh_d_amt,trh_detail,"
            txtSQL = txtSQL & "trh_full_amt,trh_term,trh_disc,trh_sale,trh_v_amt,"
            txtSQL = txtSQL & "trh_print,trh_bill,trh_tran,trh_web,trh_cre_lim,trh_runid,trh_update,trh_wh,trh_DePosit) )"

            txtSQL = txtSQL & " values('S','" & cboTypeDoc.SelectedValue & "','" & Trim(txtNo.Text) & "',"


            txtSQL = txtSQL & "'" & Trim(lbCusID.Text) & "','"

            ' (((Month( dtp01.Value) & "/" & DateAndTime.Day( dtp01.Value) & "/" & Year( dtp01.Value) - 543)))
            txtSQL = txtSQL & (((Month(dtp01.Value) & "/" & DateAndTime.Day(dtp01.Value) & "/" & Year(dtp01.Value) - 543))) & "',"

            txtSQL = txtSQL & "'" & CDbl(lbSumary.Text) & "',"
            If Microsoft.VisualBasic.Right(txtCusDisc.Text, 1) = "b" Then
                txtSQL = txtSQL & "'" & (CDbl(lbSumary.Text) - TrhDisc) & "',"
            Else
                txtSQL = txtSQL & "'" & (CDbl(lbSumary.Text) - (CDbl(lbSumary.Text) * CDbl(txtCusDisc.Text)) / 100) & "',"
            End If

            txtSQL = txtSQL & "'" & txtDetail.Text & "','" & CDbl(lbSumary.Text) & "'"
            txtSQL = txtSQL & " ,'" & Trim(txtCredit.Text) & "','" & txtCusDisc.Text & "',"
            txtSQL = txtSQL & " '" & txtSaleMan.Text & "','0','0', '" & txtCusVat.Text & "',"
            txtSQL = txtSQL & "'0','0','" & lbCreLimit.Text & "','" & CInt(IDNo) & "',"

            ' (((Month( dtp01.Value) & "/" & DateAndTime.Day( dtp01.Value) & "/" & Year( dtp01.Value) - 543)))
            txtSQL = txtSQL & "'" & (Format((Now), "MM/dd/yyyy hh:mm:ss ")) & "',"
            txtSQL = txtSQL & "'" & lbWHcode.Text & "','" & txtDepoSit.Text & "')"
        End If
        Try
            With SComMand
                .CommandType = CommandType.Text
                .CommandText = txtSQL
                .Connection = Conn
                .ExecuteNonQuery()
            End With
        Catch errprocess As Exception
            MessageBox.Show("äÁèÊÒÁÒÃ¶à¾ÔèÁ¢éÍÁÙÅä´éà¹×èÍ§¨Ò¡ " & errprocess.Message, "¢éÍ¼Ô´¾ÅÒ´", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        ' ********************************************end of add data into trandatah*******************************************

        NoDoc = txtNo.Text
        'Call ClearAll()
        'Call runGetUserSave()  ' Â¡àÅÔ¡ä»ãªéã¹ dbTools á·¹á¡éä¢ 27-10-2559
        chkSave = True
        lbStatus.Text = "ºÑ¹·Ö¡¢éÍÁÙÅàÃÕÂºÃéÍÂáÅéÇ"
        MessageBox.Show("ºÑ¹·Ö¡¢éÍÁÙÅàÃÕÂºÃéÍÂáÅéÇ", "á¨é§¼Å¡ÒÃ·Ó§Ò¹")
        Call EnableF()
    End Sub

    '================================================================================================
    '[                                                                                               ]
    '[                                                                                               ]
    '[                                                                                               ]
    '[                                                                                               ]
    '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    Sub saveData02()

        Dim DS As DataSet = New DataSet
        Dim DA As SqlClient.SqlDataAdapter
        Dim sCommend As New SqlClient.SqlCommand


        'Dim tmpMoney As Single = 0 'à¡çºÂÍ´à§Ô¹·Õèä´éÃÑº
        'Dim OldStkCode As String

        Dim chkDocTypeS As Boolean = False
        Dim chkEditItem As Integer = 1  ' 0=

        If chkDataItem() = False Then Exit Sub '============   µÃÇ¨ÊÍº¤ÇÒÁ¤Ãº¶éÇ¹¢Í§¢éÍÁÙÅ¡èÍ¹ºÑ¹·Ö¡  

        '******************************************************** à¡çº¢éÍÁÙÅ¢Í§ÃÒÂÅÐàÍÕÂ´ÊÔ¹¤éÒã¹ºÔÅ Å§µÑÇá»Ã *******************************************


        DS.Clear()



        '********************************************************¨º¡ÒÃºÑ¹·Ö¡¢éÍÁÙÅÅ§ trandatad *********************************************************

        'End If

        '        OrderNo = DS.Tables("DataD").Rows(i).Item("dtl_con_id")
        'If DBtools.getDocNumber(OrderNo, "B") = True Then
        '            '=========  Å´¨Ó¹Ç¹ Order Å§µÒÁ¨Ó¹Ç¹¡ÒÃ¢ÒÂ 
        '            orderQty = subDs.Tables("UpOrder").Rows(0).Item("dtl_num_2") - stkQty
        '            Call upDateOrderCon(stkCode, orderQty, OrderNo)
        'End If

        '************************************************µÑ´Stock  µéÍ§µÑ´¨Ò¡ÃËÑÊÊÔ¹¤éÒãËÁè·Õèá¡éä¢áÅéÇ***********************************************
        'Dim STOCKTEST As Integer

        If txtSaleMan.Text <> "SL03" Then  '¶éÒ SL03 ¨Ðà»ç¹ ¤Ø³¾ÔÁ¾ì  

            '*************************************************************ºÑ¹·Ö¡Å§Trandatad ********************************************************************



            DS.Clear()
            txtSQL = "SELECT    Stkdetl.DTL_STORE, Stkdetl.DTL_WH, Stkdetl.DTL_CODE, "
            txtSQL = txtSQL & " Stkdetl.DTL_LS_TT, Stkdetl.DTL_LS_Q1, Stkdetl.DTL_LS_Q2, Stkdetl.DTL_LS_TRN, "
            txtSQL = txtSQL & " Stkdetl.DTL_BAL_Q1, Stkdetl.DTL_BAL_Q2, Stkdetl.Dtl_OR_Q1, Stkdetl.Dtl_OR_Q2,"
            txtSQL = txtSQL & " Stkdetl.DTL_ISS_Q1, Stkdetl.DTL_ISS_Q2, Stkdetl.DTL_RCV_Q1, "
            txtSQL = txtSQL & " Stkdetl.DTL_RCV_Q2, Stkdetl.DTL_BAL_TT, Stkdetl.DTL_Pen_Q1, Stkdetl.DTL_Pen_Q2,"
            txtSQL = txtSQL & " Stkdetl.DTL_MIN_PT, Stkdetl.DTL_MAX_PT, Stkdetl.DTL_LS_LS, "
            txtSQL = txtSQL & " Stkdetl.DTL_DIST, Stkdetl.DTL_ACCT, Stkdetl.DTL_AC_DM,"
            txtSQL = txtSQL & " Stkdetl.DTL_AC_CS, Stkdetl.DTL_AC_CR, Stkdetl.DTL_AC_SL, Stkdetl.DTL_AC_SR, "
            txtSQL = txtSQL & " Stkdetl.DTL_AC_EX, Stkdetl.DTL_AC_WP, Stkdetl.DTL_AC_RT, BaseMast.Stk_Name_1 "

            txtSQL = txtSQL & " FROM Stkdetl LEFT OUTER JOIN"
            txtSQL = txtSQL & " BaseMast ON Stkdetl.DTL_CODE = BaseMast.Stk_Code "

            txtSQL = txtSQL & " where dtl_code='" & stkCode & "' "
            txtSQL = txtSQL & " And dtl_store='" & CusID & "' "
            txtSQL = txtSQL & " And stkdetl.dtl_wh='" & lbWHcode.Text & "' "

            DA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            DA.Fill(DS, "Stock")
            'chkStock = True
            'STOCKTEST = DS.Tables("Stock").Rows(0).Item("dtl_bal_q1")

            If DS.Tables("Stock").Rows.Count > 0 Then

                If Edit <> 1 Then

                    '[====================================================]
                    '[                                                    ]
                    '[                                                    ]
                    '[      ÁÕ»Ñ­ËÒ·Õè¨Ø´¹ÕéµéÍ§á¡éä¢                                                             ]
                    '[  Åº¢éÍÁÙÅä»áÅéÇáµè¡ÅÑºäÁèãËé Save ·ÓãËé¢éÍÁÙÅËÒÂ                              ]
                    '[                                                    ]
                    '[                                                    ]
                    '[====================================================]

                    If DBtools.getStock(stkCode, CusID, whCode) >= stkQty Then '  check ÇèÒ stock µéÍ§ÁÒ¡¡ÇèÒ·Õè¢ÒÂ¶Ö§¨ÐµÑ´ stock ä´é
                        Iss = CInt(DS.Tables("Stock").Rows(0).Item("dtl_iss_q1")) + stkQty
                        'WIss = Format(IssWeight + DS.Tables("Stock").Rows(0).Item("dtl_iss_q2"), "#,##0.000")
                        Bal = CInt(DS.Tables("Stock").Rows(0).Item("dtl_bal_q1")) - stkQty
                        'WBal = Format(DS.Tables("Stock").Rows(0).Item("dtl_bal_q2") - IssWeight, "#,##0.000")
                        'Else
                        '    MessageBox.Show("stock ¢Í§ '" & DS.Tables("Stock").Rows(0).Item("stk_name_1") & "' ¶Ö§ÃÒÂ¡ÒÃ·Õè  '" & i + 1 & "' ¨ÐÁÕ stock àËÅ×Íá¤è   '" & DS.Tables("Stock").Rows(0).Item("dtl_bal_q1") & "' «Öè§äÁè¾Í¡ÃØ³Ò·Ó¡ÒÃâÍ¹ÊÔ¹¤éÒâ´Â¡´»ØèÁ F12 áÅéÇ·Ó¡ÒÃ¡´»ØèÁºÑ¹·Ö¡ÍÕ¡¤ÃÑé§", "¤Óàµ×Í¹", MessageBoxButtons.OK)
                        '    Exit Sub
                    End If

                ElseIf Edit = 1 Then 'á¡éä¢

                    If IssNum < EditNum Then '¨Ó¹Ç¹ãËÁè¹éÍÂ¡ÇèÒ¨Ó¹Ç¹à¡èÒ
                        Iss = DS.Tables("Stock").Rows(0).Item("dtl_iss_q1") + (IssNum)
                        Bal = DS.Tables("Stock").Rows(0).Item("dtl_bal_q1") - (IssNum)
                        'WIss = Format(DS.Tables("Stock").Rows(0).Item("dtl_iss_q2") - (IssWeight), "#,##0.00")
                        If OrderNo = "" Or OrderNo = "äÁèÁÕOrder" Then
                        Else
                            Or_Q1 = DS.Tables("Stock").Rows(0).Item("dtl_or_q1") - IssNum
                        End If
                    ElseIf IssNum > EditNum Then '¨Ó¹Ç¹ãËÁèÁÒ¡¡ÇèÒ¨Ó¹Ç¹à¡èÒ
                        Iss = DS.Tables("Stock").Rows(0).Item("dtl_iss_q1") + (IssNum)
                        Bal = DS.Tables("Stock").Rows(0).Item("dtl_bal_q1") - (IssNum)

                        If OrderNo = "" Or OrderNo = "äÁèÁÕOrder" Then
                        Else
                            Or_Q1 = DS.Tables("Stock").Rows(0).Item("dtl_or_q1") - IssNum
                        End If
                    ElseIf IssNum = EditNum Then '¨Ó¹Ç¹ãËÁèà·èÒ¡Ñº¨Ó¹Ç¹à¡èÒ ¤×Í äÁèä´éá¡éä¢µÑÇàÅ¢áµèá¡éä¢ÍÂèÒ§Í×è¹
                        Iss = IssNum + DS.Tables("Stock").Rows(0).Item("dtl_iss_q1")
                        Bal = DS.Tables("Stock").Rows(0).Item("dtl_bal_q1") - IssNum

                        If OrderNo = "" Or OrderNo = "äÁèÁÕOrder" Then

                        Else
                            Or_Q1 = DS.Tables("Stock").Rows(0).Item("dtl_or_q1") - IssNum
                        End If
                    End If

                End If
                txtSQL = "Update StkDetl "
                txtSQL = txtSQL & "Set "
                txtSQL = txtSQL & "dtl_iss_q1='" & Iss & "',"
                txtSQL = txtSQL & "dtl_bal_q1='" & Bal & "' "
                If OrderNo = "" Or OrderNo = "äÁèÁÕOrder" Then
                Else
                    txtSQL = txtSQL & ",dtl_or_q1='" & Or_Q1 & "' "
                End If
                txtSQL = txtSQL & "Where dtl_code='" & NewCode & "' "
                txtSQL = txtSQL & "And dtl_store='" & CusID & "' "
                txtSQL = txtSQL & "And Dtl_Wh='" & lbWHcode.Text & "' "


                Try
                    With subCom
                        .CommandType = CommandType.Text
                        .CommandText = txtSQL
                        .Connection = Conn
                        '.ExecuteNonQuery()
                    End With
                Catch errprocess As Exception
                    MessageBox.Show("äÁèÊÒÁÒÃ¶à¾ÔèÁ¢éÍÁÙÅä´éà¹×èÍ§¨Ò¡ " & errprocess.Message, "¢éÍ¼Ô´¾ÅÒ´", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            End If
        End If

        '************************************************µÑ´Order***********************************************

        DS.Clear()
        txtSQL = "select * from trandatad "
        txtSQL = txtSQL & "where dtl_idtrade='" & oldCode & "' "
        txtSQL = txtSQL & "And dtl_type='b' and dtl_con_id='" & OrderNo & "'"
        'If chkOrder = True Then
        '    DS.Tables("Order").Clear()
        '    chkOrder = False
        'End If
        DA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        DA.Fill(DS, "Order")
        'chkOrder = True

        If DS.Tables("Order").Rows.Count > 0 Then


            OrDerQty = IssNum + DS.Tables("Order").Rows(0).Item("dtl_num_2")

            txtSQL = "Update trandatad "
            txtSQL = txtSQL & "Set "
            txtSQL = txtSQL & "dtl_num_2='" & OrDerQty & "'"
            txtSQL = txtSQL & " where dtl_idtrade='" & oldCode & "' "
            txtSQL = txtSQL & "And dtl_con_id='" & OrderNo & "' and dtl_type='b'"

            Try
                With subCom
                    .CommandType = CommandType.Text
                    .CommandText = txtSQL
                    .Connection = Conn
                    '.ExecuteNonQuery()
                End With
            Catch errprocess As Exception
                MessageBox.Show("äÁèÊÒÁÒÃ¶à¾ÔèÁ¢éÍÁÙÅä´éà¹×èÍ§¨Ò¡ " & errprocess.Message, "¢éÍ¼Ô´¾ÅÒ´", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If

        oldCode = ""
        NewCode = ""
        OrderNo = ""


        'ãªéã¹¡ÒÃ update ¢éÍÁÙÅã¹ Order µéÍ§ÂéÒÂä»äÇéËÅÑ§ºÑ¹·Ö¡¢éÍÁÙÅáÅéÇ¶Ö§¤ÍÂÅ´ Order Å§
        'If DS.Tables("DataD").Rows.Count > 0 Then
        '    chkDocTypeS = True

        '    For i = 0 To DS.Tables("DataD").Rows.Count - 1

        '        stkCode = DS.Tables("DataD").Rows(i).Item("dtl_idTrade")
        '        stkQty = DS.Tables("DataD").Rows(i).Item("dtl_num")
        '        OrderNo = DS.Tables("DataD").Rows(i).Item("dtl_con_id")


        '        If DBtools.getDocNumber(OrderNo, "B") = True Then
        '            '=========  Å´¨Ó¹Ç¹ Order Å§µÒÁ¨Ó¹Ç¹¡ÒÃ¢ÒÂ 
        '            orderQty = subDs.Tables("UpOrder").Rows(0).Item("dtl_num_2") - stkQty
        '            Call upDateOrderCon(stkCode, orderQty, OrderNo)

        '        End If
        '    Next
        '    stkCode = ""
        '    OrderNo = ""
        '    stkQty = 0

        'End If

        DocID = txtNo.Text

        ' Call runGetUserSave()
        chkSave = True
        lbStatus.Text = "ºÑ¹·Ö¡¢éÍÁÙÅàÃÕÂºÃéÍÂáÅéÇ"
        MessageBox.Show("ºÑ¹·Ö¡¢éÍÁÙÅàÃÕÂºÃéÍÂáÅéÇ", "á¨é§¼Å¡ÒÃ·Ó§Ò¹")
        Call EnableF()

    End Sub

    Private Sub cmbSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSave.Click


        selCusiD = ""
        selCusiD = lbCusID.Text
        Dim frmEditNo As New frmEditNo
        Dvat = cboTypeDoc.SelectedValue
        SelectDate = dtp01.Value

        Call sumTotal()
        If chkDataItem() = False Then Exit Sub

        'If MsgBox("µéÍ§¡ÒÃºÑ¹·Ö¡àÍ¡ÊÒÃãªè ËÃ×Í äÁè ", MsgBoxStyle.YesNo, "á¨é§àµ×Í¹") = MsgBoxResult.Yes Then
        If txtNo.Text = "" Then   '   äÁèÁÕàÅ¢·ÕèàÍ¡ÊÒÃ ãËé Gen àÅ¢·Õè¢Öé¹ÁÒ¨Ò¡ AutoGen

            SelectDate = dtp01.Value
            frmEditNo.ShowDialog()
            IDNo = EditNo
            txtNo.Text = EditNo

            If txtNo.Text = "" Then

                MsgBox("ไม่พบเลขที่เอกสาร")

            Else

                Call mainSave()
                'Call runPrint()
                'Me.Close()
                'Call showCondition()
                If MsgBox("ต้องการพิมพ์เอกสารใช่หรือไม่ ", MsgBoxStyle.YesNo, "แจ้งเตือน") = MsgBoxResult.Yes Then
                    Dim frmPrint As New frmPrint
                    frmPrint.ShowDialog()
                End If
                ClearAll()
                Me.Close()

            End If

        Else

            If DBtools.getDocNumber(txtNo.Text, docType) = True Then

                '========================================================
                'If Not (cboTypeDoc.SelectedValue = "P") Then
                Dim chkPrint As Boolean = False

                chkPrint = getChkPrint(txtNo.Text)
                If chkPrint = True Then

                    Dim frmAnswers As New frmAnswers
                    frmAnswers.ShowDialog()
                    If chkUserUpdate = False Then
                        Exit Sub
                    End If

                End If
                'End If



                '========================================================

                'If MsgBox("àÍ¡ÊÒÃàÅ¢·Õè  **** " & txtNo.Text & " **** ÁÕ¢éÍÁÙÅà´ÔÁÍÂÙè  µéÍ§¡ÒÃºÑ¹·Ö¡¡ÒÃá¡éä¢ ", MsgBoxStyle.YesNo, "á¨é§àµ×Í¹ !") = MsgBoxResult.Yes Then
                EditNo = txtNo.Text
                Call mainSave()
                'Call runPrint()
                'Call showCondition()
                If MsgBox("ต้องการพิมพ์เอกสารใช่หรือไม่", MsgBoxStyle.YesNo, "แจ้งเตือน") = MsgBoxResult.Yes Then
                    Dim frmPrint As New frmPrint
                    frmPrint.ShowDialog()
                End If
                ClearAll()
                Me.Close()
                'Else
                '    MsgBox("àÍ¡ÊÒÃÂÑ§äÁè¶Ù¡ºÑ¹·Ö¡  µÃÇ¨ÊÍºÍÕ¡¤ÃÑé§")
                'End If
            Else

                'If MsgBox("àÅ¢·ÕèàÍ¡ÊÒÃ¹Õé ¡ÓË¹´â´Â¼Ùéãªé§Ò¹ äÁèä´éÍÍ¡â´ÂÃÐºº  ÇÑ¹·Õèã¹¡ÒÃºÑ¹·Ö¡ ¤×Í  ' " & dtp01.Value & " '", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                EditNo = txtNo.Text
                Call mainSave()
                'Call runPrint()
                'Call showCondition()
                Dim frmPrint As New frmPrint
                frmPrint.ShowDialog()
                ClearAll()
                Me.Close()

                '    Else

                'End If


            End If

            'If chkDataItem() = False Then Exit Sub   '»Ô´äÇé¡èÍ¹  
            'cboTypeDoc.SelectedValue = Dvat

        End If
        'Else

        'End If
        chkLockTypeP.Checked = True

    End Sub

    Sub showCondition()

        Dim frmShowCon As New frmShowCon
        frmShowCon.ShowDialog()

    End Sub
    Sub runPrint()

        If MsgBox("µéÍ§¡ÒÃ¾ÔÁ¾ìàÍ¡ÊÒÃËÃ×ÍäÁè ", MsgBoxStyle.YesNo, "á¨é§àµ×Í¹") = MsgBoxResult.Yes Then

            Call Print()
            Call Setting_Print()
            Call runGetUserPrint()
            Call ClearAll()
            Call EnableT()
            Call updatePrint(EditNo)  '  ãÊè¤èÒÇèÒ àÍ¡ÊÒÃ¹Õé ¾ÔÁ¾ìáÅéÇ 

            chkNew = False
            chkEditDoc = False
            EditNo = ""

        End If

        Me.Close()

    End Sub

    Sub mainSave()

        Try
            Call getRunID(txtNo.Text)  '   à¡çº¤èÒÅ§µÑÇá»Ã 
            saveTranDataH()  '  ºÑ¹·Ö¡¢éÍÁÙÅ TranDataH

            Try
                '    ÇÑ¹·Õè  2-12-56 
                saveTranDataD()
                chkSaveOK = True
                'runGetUserSave()
                'MsgBox("¢éÍÁÙÅ¶Ù¡ºÑ¹·Ö¡àÃÕÂºÃéÍÂáÅéÇ", MsgBoxStyle.OkOnly, "á¨é§¼Å¡ÒÃ·Ó§Ò¹")

            Catch ex As Exception

                MsgBox("à¡Ô´¢éÍ¼Ô´¾ÅÒ´ã¹ÊèÇ¹¢éÍÁÙÅ-ÃÒÂÅÐàÍÕÂ´ã¹ºÔÅ " & txtNo.Text & "â»Ã´á¨é§ ICT ! ", MsgBoxStyle.Critical, "á¨é§àµ×Í¹")
                chkSaveOK = False
                Exit Sub

            End Try

        Catch ex As Exception

            MsgBox("à¡Ô´¢éÍ¼Ô´¾ÅÒ´ã¹ÊèÇ¹¢éÍÁÙÅ-ËÑÇºÔÅ " & txtNo.Text & "â»Ã´á¨é§ ICT ! ", MsgBoxStyle.Critical, "á¨é§àµ×Í¹")
            chkSaveOK = False
            Exit Sub

        End Try

    End Sub

    Sub updateTypeT(strDocT_NO As String, strDocConID As String, stkCode As String, v_State As Integer, strDocS_NO As String)
        ', strCondition As String
        '  ·Óà¾×èÍ update ¢éÍÁÙÅãº¨Í§ÇèÒä´é¶Ù¡¹Óä»à»Ô´ºÔÅáÅéÇ
        '  ¶éÒ Dtl_State= 0  ËÁÒÂ¶Ö§ÂÑ§äÁèµÑ´

        txtSQL = "Update TranDataD "
        txtSQL = txtSQL & "Set TranDataD.Dtl_State=" & v_State & ","
        txtSQL = txtSQL & "TranDataD.Dtl_Type_S='" & strDocS_NO & "'  "

        txtSQL = txtSQL & "Where dtl_type='T' "
        txtSQL = txtSQL & "And dtl_no='" & strDocT_NO & "' "
        txtSQL = txtSQL & "And Dtl_idTrade='" & stkCode & "' "
        txtSQL = txtSQL & "And Dtl_con_id='" & strDocConID & "' "
        'txtSQL = txtSQL & "And Dtl_Condition='" & strCondition & "' "

        DBtools.dbSaveDATA(txtSQL, strDocT_NO)

    End Sub

    Sub updateLastSales(ArCode As String, LastSales As DateTime)

        '  ·Óà¾×èÍ update ¢éÍÁÙÅãº¨Í§ÇèÒä´é¶Ù¡¹Óä»à»Ô´ºÔÅáÅéÇ
        '  ¶éÒ Dtl_State= 0  ËÁÒÂ¶Ö§ÂÑ§äÁèµÑ´

        txtSQL = "Update ArFile "
        '(((Month( LastSales) & "/" & DateAndTime.Day( LastSales) & "/" & Year( LastSales) - 543)))

        txtSQL = txtSQL & "Set ArFile.Ar_LastSales_Date='"
        ' (((Month( LastSales) & "/" & DateAndTime.Day( LastSales) & "/" & Year( LastSales) - 543)))
        txtSQL = txtSQL & (((Month(LastSales) & "/" & DateAndTime.Day(LastSales) & "/" & Year(LastSales) - 543)))
        txtSQL = txtSQL & " " & (Format((Now), "HH:mm:ss")) & "' "

        txtSQL = txtSQL & "Where Ar_Cus_ID='" & ArCode & "' "


        DBtools.dbSaveDATA(txtSQL, ArCode)

    End Sub

    Sub updateTypeP(strDocP_NO As String, strDocConID As String, stkCode As String, v_State As Integer)

        '  ·Óà¾×èÍ update ¢éÍÁÙÅãº¨Í§ÇèÒä´é¶Ù¡¹Óä»à»Ô´ºÔÅáÅéÇ
        '  ¶éÒ Dtl_State= 0  ËÁÒÂ¶Ö§ÂÑ§äÁèµÑ´

        txtSQL = "Update TranDataD "
        txtSQL = txtSQL & "Set TranDataD.Dtl_State=" & v_State & " "

        txtSQL = txtSQL & "Where dtl_type='P' "
        txtSQL = txtSQL & "And dtl_no='" & strDocP_NO & "' "
        txtSQL = txtSQL & "And Dtl_idTrade='" & stkCode & "' "
        txtSQL = txtSQL & "And Dtl_con_id='" & strDocConID & "' "

        DBtools.dbSaveDATA(txtSQL, strDocP_NO)

        txtSQL = "Update TranDataH "
        If chkLockTypeP.Checked = True Then
            txtSQL = txtSQL & "Set TranDataH.Trh_Print=1 "
        Else
            txtSQL = txtSQL & "Set TranDataH.Trh_Print=0 "
        End If

        txtSQL = txtSQL & "Where Trh_type='P' "
        txtSQL = txtSQL & "And trh_no='" & strDocP_NO & "' "

        'txtSQL = txtSQL & "And Dtl_idTrade='" & stkCode & "' "
        'txtSQL = txtSQL & "And Dtl_con_id='" & strDocConID & "' "

        DBtools.dbSaveDATA(txtSQL, strDocP_NO)


    End Sub

    Sub EnableF()

        txtNo.Enabled = False
        cmbSearch.Enabled = False
        txtCredit.Enabled = False
        txtCusDisc.Enabled = False
        txtCusVat.Enabled = False
        lbSaleName.Enabled = False
        GroupBox4.Enabled = False
        ListEdit.Enabled = False
        cmbSave.Enabled = False
        cboTypeDoc.Enabled = False
        llbAdd.Enabled = False
        'llbEdit.Enabled = False
        'llbDel.Enabled = False
        ' llbClear.Enabled = False
        dtp01.Enabled = False

    End Sub

    Sub EnableT()

        txtNo.Enabled = True
        cmbSearch.Enabled = True
        txtCredit.Enabled = True
        txtCusDisc.Enabled = True
        txtCusVat.Enabled = True
        lbSaleName.Enabled = True
        GroupBox4.Enabled = True
        ListEdit.Enabled = True
        cmbSave.Enabled = True
        cboTypeDoc.Enabled = True
        llbAdd.Enabled = True
        'llbEdit.Enabled = True
        'llbDel.Enabled = True
        'llbClear.Enabled = True
        dtp01.Enabled = True

    End Sub

    '*****************************************************************»ØèÁà»ÅÕèÂ¹ÃËÑÊäÁèãªéáÅéÇ ¨Ðãªé»ØèÁcodeá·¹ ****************************************
    'Private Sub cmbChangeCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbChangeCode.Click
    '    DS3.Clear()
    '    DS4.Clear()
    '    If cboPaper.Text <> "" And cboGrade.Text <> "" Then
    '        Call GenCode()

    '    End If
    'End Sub
    'Sub GenCode()    'à»ÅÕèÂ¹ÃËÑÊ

    '    Dim i As Integer
    '    Dim Th As String
    '    Dim Size As String
    '    Dim Color As String
    '    Dim Type As String
    '    Dim Group As String

    '    oldCode = lbCode.Text

    '    txtSQL1 = " select   *  from basemast  where stk_code='" & lbCode.Text & "'"
    '    DA3 = New SqlClient.SqlDataAdapter(txtSQL1, Conn)
    '    DA3.Fill(DS3, "baseData")

    '    Type = DS3.Tables("basedata").Rows(0).Item("type_code")
    '    Group = DS3.Tables("basedata").Rows(0).Item("grp_code")
    '    Th = DS3.Tables("basedata").Rows(0).Item("Th_code")
    '    Size = DS3.Tables("basedata").Rows(0).Item("size_code")
    '    Color = DS3.Tables("basedata").Rows(0).Item("color_code")

    '    ChangeCode = Type & Group & Th & Size & Color
    '    txtSQL1 = "select paper_code,paper_name from papermast where paper_code='" & cboPaper.SelectedValue & "'"
    '    DA1 = New SqlClient.SqlDataAdapter(txtSQL1, Conn)
    '    DA1.Fill(DS4, "PaperMast")

    '    txtSQL1 = "select g_name,g_code from gmast where g_code='" & Convert.ToString(cboGrade.SelectedValue) & "'"
    '    DA1 = New SqlClient.SqlDataAdapter(txtSQL1, Conn)
    '    DA1.Fill(DS4, "gmast")

    '    ChangeCode = ChangeCode & cboPaper.SelectedValue & Convert.ToString(cboGrade.SelectedValue)
    '    'lbCode.Text = ChangeCode


    '    subDs.Clear()
    '    txtSQL = "  SELECT     *"
    '    txtSQL = txtSQL & " FROM         stkdetl  "
    '    txtSQL = txtSQL & " where  dtl_code='" & ChangeCode & "'"
    '    subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
    '    subDa.Fill(subDs, "StockBal")
    '    If subDs.Tables("StockBal").Rows.Count > 0 Then
    '        lbStock.Text = subDs.Tables("StockBal").Rows(0).Item("dtl_bal_q1")
    '    End If

    '    txtSQL = "select stk_code,stk_name_1,stk_factor from basemast where  stk_code='" & ChangeCode & "'"
    '    DA1 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
    '    DA1.Fill(DS4, "name")
    '    If DS4.Tables("name").Rows.Count > 0 Then
    '        lbProductName.Text = DS4.Tables("name").Rows(0).Item("stk_name_1")
    '        lbCode.Text = ChangeCode
    '        ChangeCode = ""
    '    Else
    '        MsgBox("äÁèÁÕÃËÑÊÊÔ¹¤éÒ¹Õé", MsgBoxStyle.Information = MsgBoxStyle.OKOnly, "á¨é§àµ×Í¹")

    '        cboGrade.Text = ""
    '        cboPaper.Text = ""
    '        Exit Sub
    '    End If
    'End Sub

    'Private Sub llbClear_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbClear.LinkClicked

    '    'ListEdit.Items.Clear()
    '    'Call sumTotal()


    'End Sub

    'Private Sub cboType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim subDs As DataSet = New DataSet
    '    Dim subDa1 As SqlClient.SqlDataAdapter
    '    Try
    '        txtSQL = "Select * "
    '        txtSQL = txtSQL & "from GrpMast "
    '        'txtSQL = txtSQL & "Where Grp_type_Code='" & cboType.SelectedValue & "' "
    '        txtSQL = txtSQL & "Order by Grp_Code"
    '        subDa1 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
    '        subDa1.Fill(subDs, "GrpMast")

    '        With cboGrp1
    '            .DataSource = subDs.Tables("GrpMast")
    '            .DisplayMember = "Grp_Name"
    '            .ValueMember = "Grp_Code"

    '        End With

    '        txtSQL = "Select  Color_Code,(color_code1 + '  '+ Color_StkName) as Color_StkName  From ColorMast "
    '        txtSQL = txtSQL & "Where Color_Type = '" & cboType1.SelectedValue & "' "
    '        txtSQL = txtSQL & "Order by Color_stkname "

    '        subDa1 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
    '        subDa1.Fill(subDs, "ColorMast")

    '        If subDs.Tables("ColorMast").Rows.Count > 0 Then
    '            With cboColor1
    '                .DataSource = subDs.Tables("ColorMast")
    '                .DisplayMember = "Color_StkName"
    '                .ValueMember = "Color_Code"
    '                .Text = ""
    '            End With
    '            cboColor1.SelectedItem = Nothing
    '        End If
    '    Catch ex As Exception

    '    End Try

    'End Sub

    Function getStock(ByVal stkCode As String, ByVal idCus As String, ByVal idWh As String) As Double

        Dim subDs As DataSet = New DataSet
        Dim subDa As SqlClient.SqlDataAdapter
        Dim stkNum As Double = 0
        subDs.Clear()
        txtSQL = "  SELECT   dtl_Code,sum(dtl_Bal_Q1)as dtl_Bal_Q1 "
        txtSQL = txtSQL & "FROM  stkdetl  "
        txtSQL = txtSQL & "where  dtl_wh='" & idWh & "' "
        txtSQL = txtSQL & "And dtl_Store='110098' "
        txtSQL = txtSQL & "And dtl_code='" & stkCode & "' "

        'If idCus = "" Then

        'Else
        'txtSQL = txtSQL & "And dtl_store='" & idCus & "' "
        'End If

        'If idWh = "" Then
        'Else
        '    txtSQL = txtSQL & "And dtl_Wh ='" & idWh & "' "
        'End If

        txtSQL = txtSQL & "Group By Dtl_Code "
        subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa.Fill(subDs, "StockBal")

        stkNum = subDs.Tables("StockBal").Rows.Count
        chkBal = True

        If stkNum > 0 Then
            Return subDs.Tables("StockBal").Rows(0).Item("dtl_bal_q1")
        Else
            Return 0
        End If

    End Function
    'Sub GenCode2()

    '    lbCode.Text = cboType1.SelectedValue & cboGrp1.SelectedValue & cboTh.SelectedValue & cboSize.SelectedValue & _
    '    cboColor1.SelectedValue & cboPaper.SelectedValue & cboGrade.SelectedValue

    '    ' ===================  µÃÇ¨ÊÍºÃËÑÊÊÔ¹¤éÒÇèÒÁÕ¡ÒÃÊÃéÒ§ÁÒËÃ×ÍÂÑ§ ====================================


    '    '====================================================================================
    '    If getChkBaseMast(lbCode.Text) = False Then

    '        MsgBox("ÃËÑÊ '" & lbCode.Text & lbProductName.Text & "' äÁè¾º¢éÍÁÙÅÊÔ¹¤éÒ! ¡ÃØ³ÒÊÃéÒ§»ÃÐÇÑµÔÊÔ¹¤éÒ¡èÍ¹", MsgBoxStyle.Critical)

    '    Else
    '        lbProductName.Text = DBtools.getStkName(lbCode.Text)
    '        lbWeight.Text = Format(DBtools.getStkWight(lbCode.Text), "#,##0.000")
    '        lbStock.Text = getStock(lbCode.Text, lbIDCus.Text, lbWHcode.Text)
    '    End If

    'End Sub

    'Private Sub cmbCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Call GenCode2()
    '    txtSale.Focus()
    'End Sub

    Private Sub ListEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListEdit.Click

    End Sub

    Sub runGetUserPrint()

        DBtools.dbSaveUser(SqlGetUserPrint, txtNo.Text)

    End Sub
    Function SqlGetUserPrint() As String

        txtSQL = "Insert into userhistory("
        txtSQL = txtSQL & "history_user,history_Status,history_date,history_time,History_head"
        txtSQL = txtSQL & ")"
        txtSQL = txtSQL & "Values("
        txtSQL = txtSQL & "'" & GetUserName() & "','¾ÔÁ¾ìàÍ¡ÊÒÃàÅ¢·Õè" & txtNo.Text & "   ','"
        '((Month( Now) & "-" & DateAndTime.Day( Now) & "-" & Year( Now) - 543))
        txtSQL = txtSQL & (((Month(Now) & "-" & DateAndTime.Day(Now) & "-" & Year(Now) - 543))) & "','"
        txtSQL = txtSQL & (Format((Now), "HH:mm:ss")) & "','"
        txtSQL = txtSQL & txtNo.Text & " '"
        txtSQL = txtSQL & ")"

        Return txtSQL

    End Function
    Sub runGetUserEdit()

        DBtools.dbSaveUser(SqlGetUserEdit, txtNo.Text)
    End Sub
    Function SqlGetUserEdit() As String

        txtSQL = "Insert into userhistory("
        txtSQL = txtSQL & "history_user,history_Status,history_date,history_time,History_head"
        txtSQL = txtSQL & ")"
        txtSQL = txtSQL & "Values("

        txtSQL = txtSQL & "'" & GetUserName() & "','á¡éä¢àÍ¡ÊÒÃàÅ¢·Õè" & txtNo.Text & "   ','"
        '((Month( Now) & "-" & DateAndTime.Day( Now) & "-" & Year( Now) - 543))
        txtSQL = txtSQL & (((Month(Now) & "-" & DateAndTime.Day(Now) & "-" & Year(Now) - 543))) & "','"
        txtSQL = txtSQL & (Format((Now), "HH:mm:ss")) & "','"
        txtSQL = txtSQL & txtNo.Text & "'"
        txtSQL = txtSQL & ")"
        Return txtSQL

    End Function
    'Sub runGetUserSave()

    '    DBtools.dbSaveUser(SqlGetUserSave("", ""), txtNo.Text)

    'End Sub

    Sub runGetUserCancel()

        DBtools.dbSaveUser(SqlGetUserCancel, txtNo.Text)

    End Sub
    Function SqlGetUserCancel() As String

        txtSQL = "Insert into userhistory("
        txtSQL = txtSQL & "history_user,history_Status,history_date,history_time,History_head"
        txtSQL = txtSQL & ")"
        txtSQL = txtSQL & "Values("
        txtSQL = txtSQL & "'" & GetUserName() & "','Â¡àÅÔ¡àÍ¡ÊÒÃ-" & txtNo.Text & "-','"
        'txtSQL = txtSQL & (Format(DateAdd(DateInterval.Year, -543, Now), "MM/dd/yyyy")) & "','"
        'txtSQL = txtSQL & (Format(DateAdd(DateInterval.Year, -543, Now), "HH:mm:ss")) & "','"
        txtSQL = txtSQL & (((Month(Now) & "-" & DateAndTime.Day(Now) & "-" & Year(Now) - 543))) & "','"
        txtSQL = txtSQL & (Format((Now), "HH:mm:ss")) & "','"
        txtSQL = txtSQL & txtNo.Text & "'"
        txtSQL = txtSQL & ")"

        Return txtSQL
    End Function
    Sub runGetUserDel(stkCode As String, DocNo As String, StkQty As String)

        DBtools.dbSaveUser(SqlGetUserDelItem(stkCode, StkQty, DocNo), DocNo)  '  2016-02-29

    End Sub

    Function SqlGetUserSaveItem(ByVal newCode As String, stkQty As Double, ByVal txtNo As String) As String

        txtSQL = "Insert into userhistory("
        txtSQL = txtSQL & "history_user,history_Status,history_date,history_time,History_head"
        txtSQL = txtSQL & ")"
        txtSQL = txtSQL & "Values("
        txtSQL = txtSQL & "'" & GetUserName() & "','-ºÑ¹·Ö¡-" & getStkName(newCode) & "-¨Ó¹Ç¹-" & stkQty & "-ã¹àÍ¡ÊÒÃ-" & txtNo & "','"
        'txtSQL = txtSQL & (Format(DateAdd(DateInterval.Year, -543, Now), "MM/dd/yyyy")) & "','"
        'txtSQL = txtSQL & (Format(DateAdd(DateInterval.Year, -543, Now), "HH:mm:ss")) & "','"
        txtSQL = txtSQL & (((Month(Now) & "-" & DateAndTime.Day(Now) & "-" & Year(Now) - 543))) & "','"
        txtSQL = txtSQL & (Format((Now), "HH:mm:ss")) & "','"

        txtSQL = txtSQL & txtNo & "'"
        txtSQL = txtSQL & ")"

        Return txtSQL
    End Function
    Function SqlGetUserDelItem(ByVal newCode As String, stkQty As Double, ByVal txtNo As String) As String

        txtSQL = "Insert into userhistory("
        txtSQL = txtSQL & "history_user,history_Status,history_date,history_time,History_head"
        txtSQL = txtSQL & ")"
        txtSQL = txtSQL & "Values("
        txtSQL = txtSQL & "'" & GetUserName() & "','-Åº-" & getStkName(newCode) & "-¨Ó¹Ç¹-" & stkQty & "-ã¹àÍ¡ÊÒÃ-" & txtNo & "','"
        'txtSQL = txtSQL & (Format(DateAdd(DateInterval.Year, -543, Now), "MM/dd/yyyy")) & "','"
        'txtSQL = txtSQL & (Format(DateAdd(DateInterval.Year, -543, Now), "HH:mm:ss")) & "','"
        txtSQL = txtSQL & (((Month(Now) & "-" & DateAndTime.Day(Now) & "-" & Year(Now) - 543))) & "','"
        txtSQL = txtSQL & (Format((Now), "HH:mm:ss")) & "','"
        txtSQL = txtSQL & txtNo & "'"
        txtSQL = txtSQL & ")"

        Return txtSQL
    End Function

    Function SqlGetChkOrderItem(ByVal newCode As String, ByVal txtNo As String, chkBit As Boolean) As String
        If chkBit = True Then

            txtSQL = "Insert into userhistory("
            txtSQL = txtSQL & "history_user,history_Status,history_date,history_time,History_head"
            txtSQL = txtSQL & ")"
            txtSQL = txtSQL & "Values("
            txtSQL = txtSQL & "'" & GetUserName() & "','-µÃÇ¨¾º-" & getStkName(newCode) & "-ã¹Order :" & txtNo & "','"

            txtSQL = txtSQL & (((Month(Now) & "-" & DateAndTime.Day(Now) & "-" & Year(Now) - 543))) & "','"
            txtSQL = txtSQL & (Format((Now), "HH:mm:ss")) & "','"

            'txtSQL = txtSQL & (Format(DateAdd(DateInterval.Year, -543, Now), "MM/dd/yyyy")) & "','"
            'txtSQL = txtSQL & (Format(DateAdd(DateInterval.Year, -543, Now), "HH:mm:ss")) & "','"

            txtSQL = txtSQL & txtNo & "'"
            txtSQL = txtSQL & ")"

        Else

            txtSQL = "Insert into userhistory("
            txtSQL = txtSQL & "history_user,history_Status,history_date,history_time,History_head"
            txtSQL = txtSQL & ")"
            txtSQL = txtSQL & "Values("
            txtSQL = txtSQL & "'" & GetUserName() & "','µÃÇ¨==äÁè¾º-" & getStkName(newCode) & " ã¹ Order : " & txtNo & "','"
            txtSQL = txtSQL & (((Month(Now) & "-" & DateAndTime.Day(Now) & "-" & Year(Now) - 543))) & "','"
            txtSQL = txtSQL & (Format((Now), "HH:mm:ss")) & "','"

            'txtSQL = txtSQL & (Format(DateAdd(DateInterval.Year, -543, Now), "MM/dd/yyyy")) & "','"
            'txtSQL = txtSQL & (Format(DateAdd(DateInterval.Year, -543, Now), "HH:mm:ss")) & "','"
            txtSQL = txtSQL & txtNo & "'"
            txtSQL = txtSQL & ")"


        End If


        Return txtSQL
    End Function

    Private Sub cmbCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCancel.Click


        Try

            If MsgBox("µéÍ§¡ÒÃÂ¡àÅÔ¡****-" & txtNo.Text & "*** ", MsgBoxStyle.YesNo, "á¨é§àµ×Í¹ ") = MsgBoxResult.Yes Then
                chkLockTypeP.Checked = False
                Call delTranDataH()
                Call delTranDataD("S", EditNo, lbWHcode.Text)

                Call runGetUserCancel()

                MsgBox("Â¡àÅÔ¡àÍ¡ÊÒÃ # " & txtNo.Text & " àÃÕÂºÃéÍÂáÅéÇ¤ÃêÒº ", MsgBoxStyle.Information)
                ClearAll()
                dtp01.Enabled = True

            Else

            End If

        Catch ex As Exception

        End Try

    End Sub

    Sub cancelDocument()

        Dim DS As DataSet = New DataSet
        Dim DA As SqlClient.SqlDataAdapter
        Dim SCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand

        Dim whCode As String = ""
        Dim docID As String = ""

        Dim i_row As Integer
        'Dim IdTrade As String
        'Dim Delnum As Integer
        Dim DataCode As String 'ÊÓËÃÑºà¡çºÃËÑÊÊÔ¹¤éÒ·Õè¨Ðä»Åºstock ·Ø¡¤ÃÑé§·ÕèÁÕ¡ÒÃºÑ¹·Ö¡
        Dim Datanum As Integer
        Dim DataOrder As String
        'Dim DataCus As String
        'Dim i As Integer



        txtSQL = "Delete From trandatah "
        txtSQL = txtSQL & "Where trh_no='" & txtNo.Text & "' "
        txtSQL = txtSQL & "And trh_type='S'"
        txtSQL = txtSQL & "And trh_wh='" & lbWHcode.Text & "' "
        Try

            With subCom
                .CommandType = CommandType.Text
                .CommandText = txtSQL
                .Connection = Conn
                .ExecuteNonQuery()
            End With

        Catch errprocess As Exception
            MessageBox.Show("äÁèÊÒÁÒÃ¶Åº¢éÍÁÙÅä´éà¹×èÍ§¨Ò¡ " & errprocess.Message, "¢éÍ¼Ô´¾ÅÒ´", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        DS.Clear()
        txtSQLd = " select * "
        txtSQLd = txtSQLd & "from trandatad "
        txtSQLd = txtSQLd & "where dtl_no='" & txtNo.Text & "' "
        txtSQLd = txtSQLd & "and dtl_type='s' "

        'If chkDataD = True Then
        '    DS.Tables("DataD").Clear()
        '    chkDataD = False
        'End If
        DA = New SqlClient.SqlDataAdapter(txtSQLd, Conn)
        DA.Fill(DS, "DataD")
        'chkDataD = True

        If DS.Tables("DataD").Rows.Count > 0 Then
            'For i = 0 To ListEdit.Items.Count - 1
            '    DataCus = CStr(ListEdit.Items(i).SubItems(11).Text) 'à¾×èÍãËéµÑ´stock¶Ù¡µÑÇ â´ÂàÅ×Í¡µÑ´ÊÔ¹¤éÒ¢Í§ÅÙ¡¤éÒã¹listview@260153
            'Next

            For i_row = 0 To DS.Tables("DataD").Rows.Count - 1

                docID = DS.Tables("DataD").Rows(i_row).Item("dtl_No")
                whCode = DS.Tables("DataD").Rows(i_row).Item("dtl_wh")
                stkCode = DS.Tables("DataD").Rows(i_row).Item("dtl_idTrade")

                delTranDataD("S", txtNo.Text, lbWHcode.Text)


                'If txtSaleMan.Text <> "SL03" Then

                '    subDs.Clear()
                '    txtSQL = "select * from stkdetl "
                '    txtSQL = txtSQL & "where dtl_code='" & DataCode & "' "
                '    txtSQL = txtSQL & "And dtl_store='" & DataCus & "' "
                '    txtSQL = txtSQL & "And dtl_wh='" & lbWHcode.Text & "' "
                '    'If chkUpStock = True Then
                '    '    subDs.Tables("UpStock").Clear()
                '    '    chkUpStock = False
                '    'End If
                '    subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
                '    subDa.Fill(subDs, "UpStock")
                '    'chkUpStock = True

                '    If subDs.Tables("UpStock").Rows.Count > 0 Then
                '        Iss = subDs.Tables("UpStock").Rows(0).Item("dtl_iss_q1") - Datanum
                '        'WIss = Format(DS.Tables("UpStock").Rows(0).Item("dtl_iss_q2") - IssWeight, "#,##0.00")
                '        Bal = subDs.Tables("UpStock").Rows(0).Item("dtl_bal_q1") + Datanum
                '        'WBal = Format(DS.Tables("UpStock").Rows(0).Item("dtl_bal_q2") + IssWeight, "#,##0.00")
                '        If DataOrder = "" Or DataOrder = "äÁèÁÕOrder" Then
                '        Else
                '            Or_Q1 = subDs.Tables("UpStock").Rows(0).Item("dtl_or_q1") + Datanum
                '        End If

                '        txtSQL = "Update stkdetl "
                '        txtSQL = txtSQL & "Set "
                '        txtSQL = txtSQL & "dtl_iss_q1='" & Iss & "',"
                '        'txtSQL = txtSQL & "dtl_iss_q2='" & WIss & "',"
                '        txtSQL = txtSQL & "dtl_bal_q1='" & Bal & "'"
                '        'txtSQL = txtSQL & "dtl_bal_q2='" & WBal & "'"
                '        If DataOrder = "" Or DataOrder = "äÁèÁÕOrder" Then
                '        Else
                '            txtSQL = txtSQL & ",dtl_or_q1='" & Or_Q1 & "'"
                '        End If
                '        txtSQL = txtSQL & " where dtl_code='" & DataCode & "' "
                '        txtSQL = txtSQL & "And dtl_store='" & DataCus & "' "
                '        txtSQL = txtSQL & "And Dtl_wh='" & lbWHcode.Text & "' "
                '        Try
                '            With subCom
                '                .CommandType = CommandType.Text
                '                .CommandText = txtSQL
                '                .Connection = Conn
                '                .ExecuteNonQuery()
                '            End With
                '        Catch errprocess As Exception
                '            MessageBox.Show("äÁèÊÒÁÒÃ¶à¾ÔèÁ¢éÍÁÙÅä´éà¹×èÍ§¨Ò¡ " & errprocess.Message, "¢éÍ¼Ô´¾ÅÒ´", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '            Exit Sub
                '        End Try
                '    End If




                '    txtSQL = "select * from trandatad "
                '    txtSQL = txtSQL & " where dtl_idtrade='" & DataCode & "' "
                '    txtSQL = txtSQL & "And dtl_con_id='" & DataOrder & "' "
                '    txtSQL = txtSQL & "And dtl_type='b' "
                '    If chkUpOrder = True Then
                '        subDs.Tables("UpOrder").Clear()
                '        chkUpOrder = False
                '    End If
                '    subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
                '    subDa.Fill(subDs, "UpOrder")
                '    chkUpOrder = True

                '    If subDs.Tables("UpOrder").Rows.Count > 0 Then
                '        orderNum = subDs.Tables("UpOrder").Rows(0).Item("dtl_num_2") - Datanum


                '        txtSQL = "Update trandatad "
                '        txtSQL = txtSQL & "Set "
                '        txtSQL = txtSQL & "dtl_num_2='" & orderNum & "'"
                '        txtSQL = txtSQL & " where dtl_idtrade='" & DataCode & "' and dtl_con_id='" & DataOrder & "' "
                '        txtSQL = txtSQL & "and dtl_type='b'"
                '        Try
                '            With subCom
                '                .CommandType = CommandType.Text
                '                .CommandText = txtSQL
                '                .Connection = Conn
                '                .ExecuteNonQuery()
                '            End With
                '        Catch errprocess As Exception
                '            MessageBox.Show("äÁèÊÒÁÒÃ¶à¾ÔèÁ¢éÍÁÙÅä´éà¹×èÍ§¨Ò¡ " & errprocess.Message, "¢éÍ¼Ô´¾ÅÒ´", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '            Exit Sub
                '        End Try
                '    End If




                'End If


            Next
            DataCode = ""
            Datanum = 0
            DataOrder = ""
        End If


        '***************************************Åº¢éÍÁÙÅã¹ trandatad ¡èÍ¹¨ÐºÑ¹·Ö¡ãËÁè*********************************************


        txtSQL = " delete   from trandatad where dtl_no='" & txtNo.Text & "' and dtl_type='s'"
        Try

            With subCom
                .CommandType = CommandType.Text
                .CommandText = txtSQL
                .Connection = Conn
                .ExecuteNonQuery()
            End With

        Catch errprocess As Exception
            MessageBox.Show("äÁèÊÒÁÒÃ¶Åº¢éÍÁÙÅä´éà¹×èÍ§¨Ò¡ " & errprocess.Message, "¢éÍ¼Ô´¾ÅÒ´", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try


        Call ClearAll()
        EditNo = ""
        ChkDClick = False
        MessageBox.Show("Â¡àÅÔ¡àÍ¡ÊÒÃàÃÕÂºÃéÍÂáÅéÇ", "á¨é§¼Å¡ÒÃ·Ó§Ò¹")
        Call EnableT()
    End Sub

    'Private Sub cmbBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBack.Click
    '    If chkSave = True Then
    '        'Dim frmbegin As frmBegin

    '        chkNew = False
    '        chkEditDoc = False
    '        EditNo = ""
    '        'frmBegin = New frmBegin
    '        Me.Close()

    '        'frmBegin.ShowDialog(Me)
    '    Else
    '        If MsgBox("¤Ø³µéÍ§¡ÒÃÍÍ¡¨Ò¡â»Ãá¡ÃÁ â´Â·ÕèäÁèºÑ¹·Ö¡¢éÍÁÙÅãªèËÃ×ÍäÁè?", MsgBoxStyle.YesNo, "á¨é§àµ×Í¹") = MsgBoxResult.Yes Then
    '            chkNew = False
    '            chkEditDoc = False
    '            EditNo = ""
    '            Me.Close()
    '        Else

    '        End If

    '    End If


    'End Sub
    Sub ClearAll()
        '==========================================================

        'tempDisTotal = 0.0

        'Call comboFactor()
        '===========================================================

        selCusiD = ""
        selCountry = ""
        selAmphoe = ""
        txtSaleQty.Text = "0"
        txtPrice.Text = "0"

        txtNo.Text = ""
        lbCusID.Text = ""
        lbCusName.Text = ""
        lbOrder.Text = "äÁèÁÕOrder"
        lbProductName.Text = ""
        txtSaleQty.Text = ""
        'txtDiscount.Text = ""
        txtPrice.Text = ""
        lbStkCode.Text = ""
        txtDetail.Text = ""
        lbTotalWeight.Text = ""
        lbSumary.Text = "0.00"
        ListEdit.Items.Clear()
        txtCredit.Text = ""
        txtCusDisc.Text = ""
        txtCusVat.Text = 7
        lbCount.Text = ""
        lbPONo.Text = "äÁèÁÕ PO"
        lbCreLimit.Text = ""
        'llbClear.Enabled = True
        'llbDel.Enabled = False
        'Call comboFactor()
        lbStatus.Text = "¾ÃéÍÁ"
        txtSaleMan.Text = ""
        lbSaleName.Text = ""
        lbVat.Text = "0.00"
        lbTotal2.Text = "0.00"
        txtTermDtl.Text = ""
        txtCondition.Text = ""
        lbRevDocNo.Text = ""
        chkLockTypeP.Checked = True

        selCusiD = ""
    End Sub

    Sub txtCLS()

        SelectCode = ""
        lbOrder.Text = "äÁèÁÕOrder"
        lbProductName.Text = ""
        lbStkCode.Text = ""
        lbOldCode.Text = ""
        txtDetail2.Text = ""
        'lbWeight.Text = ""
        txtSaleQty.Text = 0
        lbStock.Text = 0
        txtPrice.Text = 0
        txtDisc.Text = 0.0
        txtTotal.Text = 0.0
        txtTermDtl.Text = ""
        lbPONo.Text = "äÁèÁÕ PO"

        lbRevDocNo.Text = ""
        lbTypeP.Text = ""
        txtTypeP.Text = ""
        lbTaxID.Text = ""
        txtCondition.Text = ""
        chkLockTypeP.Checked = True

    End Sub

    'Private Sub llbDel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbDel.LinkClicked

    '    Dim i_row As Integer
    '    Dim LOrder As ListViewItem
    '    Dim iNo As Integer = 0
    '    Dim i As Integer
    '    Dim trhDisc As Double = 0.0

    '    For i_row = 0 To ListEdit.SelectedItems.Count - 1 'Ç¹loopã¹ listedit
    '        LEdit = ListEdit.SelectedItems(i_row)
    '        NewCode = ListEdit.Items(LEdit.Index).SubItems(4).Text
    '        IssNum = ListEdit.Items(LEdit.Index).SubItems(6).Text
    '        IssWeight = ListEdit.Items(LEdit.Index).SubItems(9).Text
    '        OrderNo = ListEdit.Items(LEdit.Index).SubItems(2).Text
    '        Same = ListEdit.Items(LEdit.Index).SubItems(16).Text
    '        CusDel = ListEdit.Items(LEdit.Index).SubItems(11).Text
    '        Seq = ListEdit.Items(LEdit.Index).SubItems(0).Text

    '        DS.Clear()
    '        txtSQL = "select * from trandatad "
    '        txtSQL = txtSQL & " where dtl_no='" & txtNo.Text & "'and dtl_idtrade='" & NewCode & "' and dtl_runnum='" & Seq & "' "
    '        DA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
    '        DA.Fill(DS, "DataDetail")
    '        If DS.Tables("DataDetail").Rows.Count > 0 Then
    '            If txtSaleMan.Text <> "SL03" Then
    '                DS.Clear()
    '                txtSQL = "select * from stkdetl "
    '                txtSQL = txtSQL & " where dtl_code='" & NewCode & "' and dtl_store='" & CusDel & "' "
    '                txtSQL = txtSQL & "And Dtl_wh='" & lbWHcode.Text & "' "
    '                DA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
    '                DA.Fill(DS, "UpStock")

    '                If DS.Tables("UpStock").Rows.Count > 0 Then
    '                    Iss = DS.Tables("UpStock").Rows(0).Item("dtl_iss_q1") - IssNum
    '                    'WIss = Format(DS.Tables("UpStock").Rows(0).Item("dtl_iss_q2") - IssWeight, "#,##0.00")
    '                    Bal = DS.Tables("UpStock").Rows(0).Item("dtl_bal_q1") + IssNum
    '                    'WBal = Format(DS.Tables("UpStock").Rows(0).Item("dtl_bal_q2") + IssWeight, "#,##0.00")
    '                    If OrderNo = "" Or OrderNo = "äÁèÁÕOrder" Then
    '                    Else
    '                        Or_Q1 = DS.Tables("UpStock").Rows(0).Item("dtl_or_q1") + IssNum
    '                    End If
    '                    txtSQL = "Update stkdetl "
    '                    txtSQL = txtSQL & "Set "
    '                    txtSQL = txtSQL & "dtl_iss_q1='" & Iss & "',"
    '                    'txtSQL = txtSQL & "dtl_iss_q2='" & WIss & "',"
    '                    txtSQL = txtSQL & "dtl_bal_q1='" & Bal & "'"
    '                    'txtSQL = txtSQL & "dtl_bal_q2='" & WBal & "'"
    '                    If OrderNo = "" Or OrderNo = "äÁèÁÕOrder" Then
    '                    Else
    '                        txtSQL = txtSQL & ",dtl_or_q1='" & Or_Q1 & "'"
    '                    End If
    '                    txtSQL = txtSQL & " where dtl_code='" & NewCode & "' and dtl_store='" & CusDel & "' "
    '                    txtSQL = txtSQL & "And Dtl_wh='" & lbWHcode.Text & "' "
    '                    Try
    '                        With subCom
    '                            .CommandType = CommandType.Text
    '                            .CommandText = txtSQL
    '                            .Connection = Conn
    '                            .ExecuteNonQuery()
    '                        End With
    '                    Catch errprocess As Exception
    '                        MessageBox.Show("äÁèÊÒÁÒÃ¶à¾ÔèÁ¢éÍÁÙÅä´éà¹×èÍ§¨Ò¡ " & errprocess.Message, "¢éÍ¼Ô´¾ÅÒ´", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                        Exit Sub
    '                    End Try
    '                End If
    '            End If ' ¨º end if ¢Í§¡ÒÃàªç¤ÇèÒà»ç¹¤Ù³¾ÔÁ¾ì¶éÒà»ç¹¤Ø³¾ÔÁ¾ìµÍ¹ÅºµéÍ§äÁè¤×¹Stock

    '            subDs.Clear()
    '            txtSQL = "select * from trandatad "
    '            txtSQL = txtSQL & " where dtl_idtrade='" & Same & "' and dtl_con_id='" & OrderNo & "' and dtl_type='b' "
    '            'If chkUpOrder = True Then
    '            '    subDs.Tables("UpOrder").Clear()
    '            '    chkUpOrder = False
    '            'End If
    '            subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
    '            subDa.Fill(subDs, "UpOrder")
    '            'chkUpOrder = True

    '            If subDs.Tables("UpOrder").Rows.Count > 0 Then
    '                OrDerQty = subDs.Tables("UpOrder").Rows(0).Item("dtl_num_2") - IssNum


    '                txtSQL = "Update trandatad "
    '                txtSQL = txtSQL & "Set "
    '                txtSQL = txtSQL & "dtl_num_2='" & OrDerQty & "'"
    '                txtSQL = txtSQL & " where dtl_idtrade='" & Same & "' and dtl_con_id='" & OrderNo & "' and dtl_type='b'"
    '                Try
    '                    With subCom
    '                        .CommandType = CommandType.Text
    '                        .CommandText = txtSQL
    '                        .Connection = Conn
    '                        .ExecuteNonQuery()
    '                    End With
    '                Catch errprocess As Exception
    '                    MessageBox.Show("äÁèÊÒÁÒÃ¶à¾ÔèÁ¢éÍÁÙÅä´éà¹×èÍ§¨Ò¡ " & errprocess.Message, "¢éÍ¼Ô´¾ÅÒ´", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                    Exit Sub
    '                End Try
    '            End If
    '            txtSQL = " delete   from trandatad where dtl_no='" & txtNo.Text & "' and dtl_type='S' and dtl_idtrade='" & NewCode & "' and dtl_runnum='" & Seq & "' "
    '            Try

    '                With subCom
    '                    .CommandType = CommandType.Text
    '                    .CommandText = txtSQL
    '                    .Connection = Conn
    '                    .ExecuteNonQuery()
    '                End With

    '            Catch errprocess As Exception
    '                MessageBox.Show("äÁèÊÒÁÒÃ¶Åº¢éÍÁÙÅä´éà¹×èÍ§¨Ò¡ " & errprocess.Message, "¢éÍ¼Ô´¾ÅÒ´", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                Exit Sub
    '            End Try
    '            Call SearchData(txtNo.Text)
    '            txtSQL = "Update trandatah "
    '            txtSQL = txtSQL & "Set "
    '            txtSQL = txtSQL & "trh_amt='" & CDbl(lbSumary.Text) & "'"
    '            txtSQL = txtSQL & "  , trh_full_amt='" & CDbl(lbSumary.Text) & "'"
    '            txtSQL = txtSQL & "  , trh_v_amt='" & CDbl(lbSumary.Text) * 7 / 100 & "'"
    '            If Microsoft.VisualBasic.Right(txtCusDisc.Text, 1) = "b" Then
    '                trhDisc = CDbl(Microsoft.VisualBasic.Left(txtCusDisc.Text, (Len(txtCusDisc.Text) - 1)))
    '                txtSQL = txtSQL & ",trh_d_amt ='" & (CDbl(lbSumary.Text) - trhDisc) & "',"
    '            Else
    '                txtSQL = txtSQL & "  , trh_d_amt='" & CDbl(lbSumary.Text) - (CDbl(lbSumary.Text) * CDbl(txtCusDisc.Text)) / 100 & "'"
    '            End If

    '            txtSQL = txtSQL & "where trh_no='" & txtNo.Text & "' and trh_type='s' "
    '            txtSQL = txtSQL & "And trh_wh='" & lbWHcode.Text & "' "
    '            Try
    '                With subCom
    '                    .CommandType = CommandType.Text
    '                    .CommandText = txtSQL
    '                    .Connection = Conn
    '                    .ExecuteNonQuery()
    '                End With
    '            Catch errprocess As Exception
    '                MessageBox.Show("äÁèÊÒÁÒÃ¶à¾ÔèÁ¢éÍÁÙÅä´éà¹×èÍ§¨Ò¡ " & errprocess.Message, "¢éÍ¼Ô´¾ÅÒ´", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                Exit Sub
    '            End Try

    '            Call runGetUserDel(NewCode, txtNo.Text, "0")

    '        Else



    '            LOrder = ListEdit.SelectedItems(i_row)
    '            ListEdit.Items.Remove(LOrder)

    '            For i = 0 To ListEdit.Items.Count
    '                iNo = i
    '            Next
    '            lbCount.Text = iNo

    '            Call sumTotal()
    '            'Call comboFactor()



    '            txtDetail.Text = ""
    '            'lbTotalWeight.Text = ""
    '            'lbTotal.Text = "0.00"

    '            lbProductName.Text = ""
    '            lbStkCode.Text = ""
    '            lbStkCode.Text = ""
    '            lbOrder.Text = ""
    '            lbProductName.Text = ""
    '            txtSaleQty.Text = ""

    '            txtPrice.Text = ""
    '            'lbWeight.Text = ""
    '            lbStock.Text = 0

    '        End If
    '    Next
    '    Iss = 0
    '    WIss = 0
    '    Bal = 0
    '    WBal = 0

    '    NewCode = ""
    '    Same = ""
    '    OrderNo = ""
    'End Sub

    Private Sub cmbOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOrder.Click

        If lbCusName.Text = "" Then

            MsgBox("â»Ã´àÅ×Í¡àÅ×Í¡ ÅÙ¡¤éÒ¡èÍ¹àÅ×Í¡ÃÒÂ¡ÒÃÊÔ¹¤éÒ ")
        Else

            Call OKCon()

        End If


    End Sub

    Sub OKCon()

        Dim frmOrder2 As New FormOrderCon

        frmOrder2.ShowDialog()


        lbProductName.Text = SelectName2
        txtPrice.Text = SelectPrice2
        txtSaleQty.Text = SelectNum2
        txtDisc.Text = SelectDisc

        If SelectNo2 <> "" Then
            lbOrder.Text = SelectNo2
        Else
            lbOrder.Text = "äÁèÁÕOrder"
        End If

        lbStkCode.Text = SelectCode2
        SelectCode = lbStkCode.Text
        'MsgBox("stk_code = " & lbCode.Text)

        lbOldCode.Text = SelectCode2
        '   àÅ¢·Õè   PO
        lbPONo.Text = SelectPNo2  ' "äÁèÁÕ"

        'lbWeight.Text = Format(SelectWeight2, "#,##0.00")
        lbTotalWeight.Text = Format(SelectWeight2 * SelectNum2, "#,##0.00")

        lbStock.Text = Format(SelectStock2, "#,##0")
        txtTotal.Text = (txtSaleQty.Text * txtPrice.Text)
        txtDetail2.Text = selectDetail
        Call calPrice()
        'cboType1.SelectedValue = CodeT
        'cboGrp1.SelectedValue = CodeG
        'cboColor1.SelectedValue = CodeColor
        'cboTh.SelectedValue = CodeTh
        'cboSize.SelectedValue = CodeSize
        'cboPaper.SelectedValue = CodePaper
        'cboGrade.SelectedValue = CodeGrade
        'cboCut.SelectedValue = "03"
        SelectName2 = ""
        SelectPrice2 = 0
        SelectNum2 = 0
        SelectNo2 = ""
        SelectCode2 = ""
        SelectPNo2 = ""
        SelectWeight2 = 0
        SelectStock2 = 0
        CodeT = ""
        CodeG = ""
        CodeColor = ""
        CodeTh = ""
        CodeSize = ""
        CodePaper = ""
        CodeGrade = ""

    End Sub

    Sub Setting_Print() '¢Í§à¡èÒ¡èÍ¹à»ÅÕèÂ¹ãËé¾ÔÁ¾ìµèÍà¹×èÍ§ »Ñ¨¨ØºÑ¹ãªéÍÑ¹¹Õéà¾ÃÒÐÇèÒ PrintáÅéÇäÁèàÅ×èÍ¹

        If IsInstallPrinter() = True Then

            'If prDlg.ShowDialog = DialogResult.OK Then

            '    prDoc.Print()

            'End If
            prDoc.Print()
        Else
            MessageBox.Show("¡ÃØ³ÒµÔ´µÑé§à¤Ã×èÍ§ Printer ¡èÍ¹ÊÑè§¾ÔÁ¾ìàÍ¡ÊÒÃ", "¼Å¡ÒÃµÃÇ¨ÊÍº", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
    'Sub Setting_Print()

    '    Dim pkSize As PaperSize


    '    'prDoc.DefaultPageSettings.PaperSize = prDoc.PrinterSettings.PaperSizes.Item(15) ' Epson 2080
    '    'prDoc.DefaultPageSettings.PaperSize = prDoc.PrinterSettings.PaperSizes.Item(0) 'Microsoft Document

    '    If IsInstallPrinter() = True Then
    '        If prDlg.ShowDialog = DialogResult.OK Then

    '            'prDoc.DefaultPageSettings.PaperSize = prDoc.PrinterSettings.PaperSizes.Item(0)
    '            prDoc.DefaultPageSettings.PaperSize = prDoc.PrinterSettings.PaperSizes.Item(15)


    '            prDoc.Print()


    '        End If'    Else
    '        MessageBox.Show("¡ÃØ³ÒµÔ´µÑé§à¤Ã×èÍ§ Printer ¡èÍ¹ÊÑè§¾ÔÁ¾ìàÍ¡ÊÒÃ", "¼Å¡ÒÃµÃÇ¨ÊÍº", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If

    'End Sub

    Sub Print()

        AddHandler prDoc.PrintPage, New PrintPageEventHandler(AddressOf Me.StringToPrint_Print)

        prDoc.DocumentName = "Bill"
        'prDoc.DefaultPageSettings.Landscape = True
        prDlg.Document = prDoc
        'prDlg.Document.PrinterSettings.PaperSizes=*************************************
        Cursor.Current = Cursors.Default
    End Sub
    Private Function IsInstallPrinter() As Boolean
        IsInstallPrinter = False
        If prDoc.PrinterSettings.PrinterName = "<no default printer>" Then
            IsInstallPrinter = False
        Else
            IsInstallPrinter = True
        End If
    End Function

    'Function prnStrNum(ByVal strNum As Double, ByVal PositionX As Integer, ByVal PositionY As Integer)
    '    Dim txtAns1, txtAns2, txt As String
    '    Dim i As Integer

    '    txtAns1 = str(Format(strNum, "#,###,###.00"))
    '    txtAns1 = Format(txtAns1, "#,###,###.00")

    '    For i = 0 To Len(txtAns1) - 1
    '        txt = (Microsoft.VisualBasic.Right(txtAns1, 1))
    '        If txt = "," Then
    '            PositionX = PositionX + 50
    '        End If
    '        Printer.CurrentX = PositionX
    '        Printer.CurrentY = PositionY
    '        Printer.Print(txt)
    '        txtAns2 = Microsoft.VisualBasic.Left(txtAns1, Len(txtAns1) - 1)
    '        txtAns1 = txtAns2
    '        PositionX = PositionX - 98
    '    Next i
    'End Function

    'Sub printHpo(ByVal sender As Object, ByVal e As PrintPageEventArgs)
    '    Dim NoSel1 As String
    '    Dim Disc As Double

    '    Dim DePoSit As Double

    '    Dim c As Integer = 0
    '    'Dim k As Integer = 0
    '    Dim str01 As String = ""
    '    Dim str02 As String = ""
    '    Dim str03 As String = ""
    '    Dim str04 As String = ""
    '    Dim str05 As String = ""
    '    Dim str06 As String = ""
    '    Dim str07 As String = ""
    '    Dim str08 As String = ""
    '    Dim str09 As String = ""
    '    Dim str10 As String = ""
    '    Dim str11 As String = ""
    '    Dim str12 As String = ""
    '    Dim str13 As String = ""
    '    Dim str14 As String = ""
    '    Dim str15 As String = ""
    '    Dim str16 As String = ""
    '    Dim str17 As String = ""
    '    Dim str18 As String = ""
    '    Dim str19 As String = ""
    '    Dim str20 As String = ""
    '    Dim str21 As String = ""
    '    Dim str22 As String = ""
    '    Dim str23 As String = ""
    '    Dim str24 As String = ""
    '    Dim str25 As String = "" 'à¡çºÃËÑÊÅÙ¡¤éÒ»Ôè¹à¡ÅéÒ
    '    Dim str26 As String = ""
    '    Dim str27 As String = ""
    '    Dim str28 As String = ""
    '    Dim yy As Integer = 0

    '    'Dim StrVat As String = ""
    '    Dim strVat As Double = 0.0
    '    'Dim StrFullAmt As String = ""
    '    'Dim StrAmt As String = ""
    '    Dim strFullAmt As Double = 0.0
    '    Dim StrAmt As Double = 0.0
    '    Dim DiscBath As Double = 0.0 'à¡çº¤èÒÊèÇ¹Å´à»ç¹ºÒ··ÕèµÑ´b·Ôé§

    '    NoSel1 = txtNo.Text

    '    If chkPrint = True Then
    '        DS.Tables("Print").Clear()
    '        chkPrint = False
    '    End If

    '    txtSQL = SQLPrint() 'ÁÕPO
    '    DS = New DataSet
    '    DA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
    '    DA.Fill(DS, "Print")
    '    chkPrint = True

    '    ''StrFullAmt = Format(DS.Tables("Print").Rows(c).Item("total"), "#,##0.000000")
    '    ''str16 = Microsoft.VisualBasic.Left(StrFullAmt, (Len(StrFullAmt)) - 4)
    '    'strFullAmt = Format(DS.Tables("Print").Rows(c).Item("total"), "#,##0.000000")
    '    'str16 = Format(Math.Round(strFullAmt, 2), "#,##0.00#")

    '    ' ''str16 = Format(DS.Tables("Print").Rows(c).Item("total"), "#,##0.00")
    '    'If (DS.Tables("Print").Rows.Count = 0) Then
    '    '    Disc = 0
    '    'Else

    '    If Microsoft.VisualBasic.Right(DS.Tables("Print").Rows(c).Item("trh_disc"), 1) <> "b" Then
    '        Disc = CDbl(DS.Tables("Print").Rows(c).Item("trh_disc"))
    '    Else
    '        Disc = CDbl(Microsoft.VisualBasic.Left(DS.Tables("Print").Rows(c).Item("trh_disc"), (Len(DS.Tables("Print").Rows(c).Item("trh_disc")) - 1)))
    '    End If

    '    If IsDBNull(DS.Tables("Print").Rows(c).Item("trh_Deposic")) Then
    '        DePoSit = 0
    '    Else

    '        DePoSit = CDbl(DS.Tables("Print").Rows(c).Item("trh_dePosic"))
    '    End If
    '    'End If


    '    'ThaiBaht01 = str16 'ÂÍ´à§Ô¹ÃÇÁ
    '    'str22 = DBtools.ThaiBaht(ThaiBaht01)


    '    str01 = CStr(DS.Tables("Print").Rows(c).Item("trh_no")) 'àÅ¢·ÕèºÔÅ
    '    ' ---------------------   á¡éä¢ÇÑ¹·Õè
    '    ' (((Month(DS.Tables("Print").Rows(c).Item("trh_date")) & "-" & DateAndTime.Day(DS.Tables("Print").Rows(c).Item("trh_date")) & "-" & Year(DS.Tables("Print").Rows(c).Item("trh_date")) - 543))) 
    '    str02 = (((Month(DS.Tables("Print").Rows(c).Item("trh_date")) & "/" & DateAndTime.Day(DS.Tables("Print").Rows(c).Item("trh_date")) & "/" & Year(DS.Tables("Print").Rows(c).Item("trh_date")) - 543)))  'ÇÑ¹·Õè
    '    'str02 = CStr(Format(DateAdd(DateInterval.Year, -543, DS.Tables("Print").Rows(c).Item("trh_date")), "dd/MM/yyyy")) 'ÇÑ¹·Õè


    '    str03 = CStr(DS.Tables("Print").Rows(c).Item("Name1")) 'ª×èÍÃéÒ¹
    '    str04 = CStr(DS.Tables("Print").Rows(c).Item("ar_addr")) '·ÕèÍÂÙè
    '    str05 = CStr(DS.Tables("Print").Rows(c).Item("ar_addr_1")) '·ÕèÍÂÙè
    '    str06 = CStr(DS.Tables("Print").Rows(c).Item("ar_addr_2")) '·ÕèÍÂÙè
    '    str19 = CStr(DS.Tables("Print").Rows(c).Item("trh_term")) 'à¤Ã´Ôµà·ÍÁ
    '    str07 = CStr(DS.Tables("Print").Rows(c).Item("dday")) 'ÇÑ¹·Õè¤Ãº¡ÓË¹´ªÓÃÐ
    '    str08 = CStr(DS.Tables("Print").Rows(c).Item("sl_name")) 'ª×èÍsale
    '    If DS.Tables("Print").Rows(c).Item("ar_shp_va") <> "" Then
    '        str26 = CStr(DS.Tables("Print").Rows(c).Item("ar_shp_va")) 'ª×èÍÊè§¢Í§
    '        str27 = CStr(DS.Tables("Print").Rows(c).Item("ar_shp_va1")) 'ª×èÍÊè§¢Í§
    '        str28 = CStr(DS.Tables("Print").Rows(c).Item("ar_shp_va2")) 'ª×èÍÊè§¢Í§
    '    End If
    '    'StrAmt = Format(DS.Tables("Print").Rows(c).Item("trh_amt"), "#,##0.000000")
    '    'str14 = Microsoft.VisualBasic.Left(StrAmt, (Len(StrAmt)) - 4) 'ÂÍ´à§Ô¹¡èÍ¹ÀÒÉÕ
    '    StrAmt = DS.Tables("Print").Rows(c).Item("trh_amt")
    '    str14 = Format(Math.Round(StrAmt, 3), "#,##0.00#") 'ÂÍ´à§Ô¹¡èÍ¹ÀÒÉÕ

    '    If DS.Tables("Print").Rows(c).Item("trh_v_amt") <> 0 Then
    '        'str15 = Format(DS.Tables("Print").Rows(c).Item("trh_v_amt"), "#,##0.00")
    '        'StrVat = Format(DS.Tables("Print").Rows(c).Item("trh_v_amt"), "#,##0.000000")
    '        'str15 = Microsoft.VisualBasic.Left(StrVat, (Len(StrVat)) - 4) 'ÀÒÉÕ
    '        strVat = DS.Tables("Print").Rows(c).Item("trh_v_amt")
    '        str15 = Format(Math.Round(strVat, 2), "#,##0.00#") 'ÀÒÉÕ

    '    End If
    '    str17 = CStr(DS.Tables("Print").Rows(c).Item("trh_detail")) 'ËÁÒÂàËµØËÅÑ¡
    '    str18 = CStr(DS.Tables("Print").Rows(c).Item("dtl_detail")) 'ËÁÒÂàËµØÂèÍÂ


    '    If Disc = 0 And DePoSit = 0 Then

    '    ElseIf Disc = 0 And DePoSit > 0 Then

    '        If IsDBNull(DS.Tables("Print").Rows(c).Item("trh_Deposic")) Then
    '            str20 = "0.00"
    '        Else
    '            'str20 = Format(Disc, "#,##0.00")
    '            str20 = Format(DePoSit, "#,##0.00#")
    '        End If

    '    ElseIf Disc > 0 And DePoSit = 0 Then

    '        If Microsoft.VisualBasic.Right(DS.Tables("Print").Rows(c).Item("trh_disc"), 1) <> "b" Then
    '            str20 = Format(Math.Round(CDbl(DS.Tables("Print").Rows(c).Item("trh_disc")) * CDbl(DS.Tables("Print").Rows(c).Item("trh_amt")) / 100, 2), "#,##0.00#")
    '        Else
    '            'str20 = Format(Disc, "#,##0.00")
    '            str20 = Format(Math.Round(Disc, 2), "#,##0.00#")
    '        End If

    '    ElseIf Disc > 0 And DePoSit > 0 Then



    '    End If



    '    str21 = Format(Math.Round(CDbl(DS.Tables("Print").Rows(c).Item("trh_d_amt")), 2), "#,##0.00#")
    '    str25 = CStr(DS.Tables("Print").Rows(c).Item("trh_cus")) 'ÃËÑÊÅÙ¡¤éÒ

    '    If DS.Tables("Print").Rows(c).Item("trh_v_amt") <> 0 Then
    '        str16 = Format(CDbl(str21) + CDbl(str15), "#,##0.00#")
    '    Else
    '        str16 = Format(CDbl(str21), "#,##0.00#")
    '    End If

    '    ThaiBaht01 = str16 'ÂÍ´à§Ô¹ÃÇÁ
    '    str22 = DBtools.ThaiBaht(ThaiBaht01)

    '    If DS.Tables("Print").Rows.Count > 0 Then
    '        For c = 0 To DS.Tables("Print").Rows.Count - 1

    '            str09 = c + 1
    '            str10 = CStr(DS.Tables("Print").Rows(c).Item("stk_name_1")) 'ª×èÍÊÔ¹¤éÒ
    '            str11 = CSng(DS.Tables("Print").Rows(c).Item("dtl_num")) '¨Ó¹Ç¹
    '            str12 = Format(Math.Round(CDbl(DS.Tables("Print").Rows(c).Item("Dtl_price")), 3), "#,##0.00##") 'ÃÒ¤Ò/á¼è¹
    '            If (DS.Tables("Print").Rows(c).Item("Dtl_t_disc")) <> "0" Then
    '                If Microsoft.VisualBasic.Right(DS.Tables("Print").Rows(c).Item("Dtl_t_disc"), 1) <> "b" Then
    '                    str13 = Format(Math.Round(CDbl(DS.Tables("Print").Rows(c).Item("Dtl_sum") - (DS.Tables("Print").Rows(c).Item("Dtl_sum") * DS.Tables("Print").Rows(c).Item("Dtl_t_disc") / 100)), 3), "#,##0.00") 'ÃÒ¤ÒÃÇÁ
    '                    str10 = CStr(DS.Tables("Print").Rows(c).Item("stk_name_1")) & " (Å´" & DS.Tables("Print").Rows(c).Item("Dtl_t_disc") & "%)" 'ª×èÍÊÔ¹¤éÒ
    '                Else
    '                    DiscBath = CDbl(Microsoft.VisualBasic.Left(DS.Tables("Print").Rows(c).Item("Dtl_t_disc"), (Len(DS.Tables("Print").Rows(c).Item("Dtl_t_disc")) - 1)))
    '                    str13 = Format(Math.Round(CDbl(DS.Tables("Print").Rows(c).Item("Dtl_sum") - DiscBath), 3), "#,##0.00") 'ÃÒ¤ÒÃÇÁ
    '                    str10 = CStr(DS.Tables("Print").Rows(c).Item("stk_name_1")) & " (Å´" & DiscBath & "ºÒ·)" 'ª×èÍÊÔ¹¤éÒ
    '                End If
    '            Else
    '                'str13 = Format(CDbl(DS.Tables("Print").Rows(c).Item("Dtl_sum")), "#,##0.00") 'ÃÒ¤ÒÃÇÁ
    '                str13 = Format(Math.Round(DS.Tables("Print").Rows(c).Item("Dtl_sum"), 3), "#,##0.00")
    '                str10 = CStr(DS.Tables("Print").Rows(c).Item("stk_name_1")) 'ª×èÍÊÔ¹¤éÒ
    '            End If

    '            str23 = CStr(DS.Tables("Print").Rows(c).Item("po"))
    '            str24 = CStr(DS.Tables("Print").Rows(c).Item("dtl_detail"))

    '            'AnyString1(e.Graphics, str09, 85, 460 + yy) 'ÅÓ´Ñº  **********áÊ´§PO
    '            'AnyString1(e.Graphics, str10, 135, 460 + yy) 'ª×èÍÊÔ¹¤éÒ
    '            'AnyString1(e.Graphics, str11, 525, 460 + yy) '¨Ó¹Ç¹
    '            'AnyString1(e.Graphics, str12, 620, 460 + yy) 'ÃÒ¤Ò
    '            'AnyString1(e.Graphics, str13, 730, 460 + yy) 'ÃÒ¤ÒÃÇÁ
    '            'AnyString1(e.Graphics, str23, 135, 480 + yy) 'po

    '            AnyString1(e.Graphics, str09, 85, 440 + yy, True) 'ÅÓ´Ñº
    '            AnyString1(e.Graphics, str10, 135, 440 + yy, False) 'ª×èÍÊÔ¹¤éÒ
    '            AnyString1(e.Graphics, str11, 525, 440 + yy, True) '¨Ó¹Ç¹
    '            AnyString1(e.Graphics, str12, 620, 440 + yy, True) 'ÃÒ¤Ò
    '            AnyString1(e.Graphics, str13, 730, 440 + yy, True) 'ÃÒ¤ÒÃÇÁ
    '            AnyString1(e.Graphics, str23, 135, 460 + yy, True) 'po
    '            If str24 <> "" Then
    '                AnyString1(e.Graphics, str24, 300, 460 + yy, False) 'ËÁÒÂàËµØÂèÍÂµèÍ·éÒÂPO
    '            End If

    '            yy = yy + 40
    '        Next

    '        'AnyString1(e.Graphics, str01, 680, 160) 'àÅ¢·ÕèºÔÅ
    '        'AnyString1(e.Graphics, str02, 680, 200) 'ÇÑ¹·ÕèºÔÅ
    '        'AnyString1(e.Graphics, str03, 130, 260) 'ª×èÍÃéÒ¹
    '        'AnyString1(e.Graphics, str04, 130, 280) '·ÕèÍÂÙè
    '        'AnyString1(e.Graphics, str05, 130, 300) '·ÕèÍÂÙè
    '        'AnyString1(e.Graphics, str06, 130, 320) '·ÕèÍÂÙè
    '        'If str26 <> "" Or str27 <> "" Or str28 <> "" Then
    '        '    AnyString1(e.Graphics, str26, 525, 260) '¢¹Êè§
    '        '    AnyString1(e.Graphics, str27, 525, 280) '·ÕèÍÂÙè
    '        '    AnyString1(e.Graphics, str28, 525, 300) '·ÕèÍÂÙè
    '        'Else
    '        '    AnyString1(e.Graphics, str04, 525, 260) '·ÕèÍÂÙèÊè§¢Í§
    '        '    AnyString1(e.Graphics, str05, 525, 280) '·ÕèÍÂÙè
    '        '    AnyString1(e.Graphics, str06, 525, 300) '·ÕèÍÂÙè
    '        'End If

    '        'AnyString1(e.Graphics, str19, 150, 390) 'à¤Ã´Ôµ
    '        'AnyString1(e.Graphics, str07, 360, 390) 'due
    '        'AnyString1(e.Graphics, str08, 680, 390) 'sale


    '        'AnyString1(e.Graphics, str01, 680, 150) 'àÅ¢·ÕèºÔÅ
    '        'AnyString1(e.Graphics, str02, 680, 190) 'ÇÑ¹·ÕèºÔÅ
    '        'AnyString1(e.Graphics, str03, 130, 260) 'ª×èÍÃéÒ¹
    '        'AnyString1(e.Graphics, str04, 130, 280) '·ÕèÍÂÙè
    '        'AnyString1(e.Graphics, str05, 130, 300) '·ÕèÍÂÙè
    '        'AnyString1(e.Graphics, str06, 130, 320) '·ÕèÍÂÙè
    '        'If str26 <> "" Or str27 <> "" Or str28 <> "" Then
    '        '    AnyString1(e.Graphics, str26, 525, 260) '¢¹Êè§
    '        '    AnyString1(e.Graphics, str27, 525, 280) '·ÕèÍÂÙè
    '        '    AnyString1(e.Graphics, str28, 525, 300) '·ÕèÍÂÙè
    '        'Else
    '        '    AnyString1(e.Graphics, str04, 525, 260) '·ÕèÍÂÙèÊè§¢Í§
    '        '    AnyString1(e.Graphics, str05, 525, 280) '·ÕèÍÂÙè
    '        '    AnyString1(e.Graphics, str06, 525, 300) '·ÕèÍÂÙè
    '        'End If
    '        'AnyString1(e.Graphics, str19, 150, 390) 'à¤Ã´Ôµ
    '        'AnyString1(e.Graphics, str07, 360, 390) 'due
    '        'AnyString1(e.Graphics, str08, 680, 390) 'sale

    '        AnyString1(e.Graphics, str01, 680, 130, False) 'àÅ¢·ÕèºÔÅ
    '        AnyString1(e.Graphics, str02, 680, 170, False) 'ÇÑ¹·ÕèºÔÅ
    '        AnyString1(e.Graphics, str03, 130, 240, False) 'ª×èÍÃéÒ¹
    '        AnyString1(e.Graphics, str04, 130, 260, False) '·ÕèÍÂÙè
    '        AnyString1(e.Graphics, str05, 130, 280, False) '·ÕèÍÂÙè
    '        AnyString1(e.Graphics, str06, 130, 300, False) '·ÕèÍÂÙè
    '        If str26 <> "" Or str27 <> "" Or str28 <> "" Then
    '            AnyString1(e.Graphics, str26, 525, 240, False) '¢¹Êè§
    '            AnyString1(e.Graphics, str27, 525, 260, False) '·ÕèÍÂÙè
    '            AnyString1(e.Graphics, str28, 525, 280, False) '·ÕèÍÂÙè
    '        Else
    '            AnyString1(e.Graphics, str04, 525, 240, False) '·ÕèÍÂÙèÊè§¢Í§
    '            AnyString1(e.Graphics, str05, 525, 260, False) '·ÕèÍÂÙè
    '            AnyString1(e.Graphics, str06, 525, 280, False) '·ÕèÍÂÙè
    '        End If

    '        AnyString1(e.Graphics, str19, 150, 380, False) 'à¤Ã´Ôµ
    '        AnyString1(e.Graphics, str07, 360, 380, False) 'due
    '        AnyString1(e.Graphics, str08, 680, 380, False) 'sale


    '        If Microsoft.VisualBasic.Left(txtNo.Text, 1) = "V" Then 'áººÁÕVat
    '            AnyString1(e.Graphics, "FM-FA-01 Rev.00 11/06/04", 600, 975, False)
    '            'AnyString1(e.Graphics, "FM-FA-01 Rev.00 11/06/04" & " (" & lbWHcode.Text & ") ", 600, 975)
    '            If str25 <> "110084" Then
    '                'AnyString1(e.Graphics, "ÇÑ¹·Õè 9 ¡.¤. 2551¤Ø³âÊÃÑµ¹ì Ç³ÔªÇÃÒ¡Ô¨ ¡ÃÃÁ¡ÒÃ¼Ùé¨Ñ´¡ÒÃº¨¡. á¾¹àÍàªÕÂ ÍØµÊÒË¡ÃÃÁ ÃÑºÁÍºÃÒ§ÇÑÅ¸ÃÃÁÒÀÔºÒÅ´Õà´è¹´éÒ¹¡ÒÃ»¯ÔºÑµÔµèÍ¾¹Ñ¡§Ò¹ ", 75, 845)
    '                'AnyString1(e.Graphics, "ÇÑ¹·Õè 9 ¡.¤. 2551¤Ø³âÊÃÑµ¹ì Ç³ÔªÇÃÒ¡Ô¨ ¡ÃÃÁ¡ÒÃ¼Ùé¨Ñ´¡ÒÃº¨¡. á¾¹àÍàªÕÂ ÍØµÊÒË¡ÃÃÁ ÃÑºÁÍºÃÒ§ÇÑÅºÑÇËÅÇ§ SMEs Award ", 75, 845)
    '                'AnyString1(e.Graphics, " New!!! Acrylic Mirror àÃÒÁÕ¼ÅÔµáÅéÇ¹Ð¤Ð Ê¹ã¨µÔ´µèÍÁÒä´éàÅÂ¤èÐ  ", 75, 860)
    '                'AnyString1(e.Graphics, "«×éÍ Pan-Glue 1,000 ¡ÃÑÁËÃ×Í 500 ¡ÃÑÁ á¶Á¿ÃÕ!ËÅÍ´©Õ´¹éÓÂÒÍÂèÒ§´Õ µÑé§áµèÇÑ¹·Õè 1 ¾ÄÉÀÒ¤Á¹Õé à»ç¹µé¹ä»", 75, 840)
    '                'AnyString1(e.Graphics, "ÁÒáÅéÇ...á¼è¹»ÃÐ¡ÒÂà¾ªÃ·Ùâ·¹ 2 ÊÕÁÕ·Ñé§»ÃÐ¡ÒÂà¾ªÃà§Ô¹ËÅÑ§¢ÒÇ »ÃÐ¡ÒÂà¾ªÃËÅÑ§´ÓËÃ×Í¨Ñº¤ÙèÊÕµÒÁã¨»ÃÒÃ¶¹Ò ", 75, 820)
    '                'AnyString1(e.Graphics, "àËÁÒÐÊÓËÃÑº§Ò¹»éÒÂ á¡ÐÊÅÑ¡´éÇÂ CNC Ê¹ã¨µÔ´µèÍã¹à´×Í¹ ¾.Â. ¹Õé ÃÑºâ»ÃâÁªÑè¹¾ÔàÈÉ·Ñ¹·Õ ", 75, 840)
    '                'AnyString1(e.Graphics, "ªÁ¢èÒÇ Update¢Í§á¾¹àÍà«ÕÂä´é·Õè website www.panglas.com áÅÐ·Õè Twitter @kensorat  ", 75, 840)
    '                'AnyString1(e.Graphics, "¶éÒÁÕÂÍ´Êè§ÊÔ¹¤éÒã¹ÇÑ¹à´ÕÂÇ¡Ñ¹¤Ãº 50,000 ºÒ·ËÃ×ÍÁÕ¡ÒÃ«×éÍÊÔ¹¤éÒ NPD ÃÑº¿ÃÕ '¡ÃÐ·§¢¹Á»Ñ§'µÑé§áµèÇÑ¹¹Õé-22 ¾.Â.¹Õé", 75, 840)
    '                'AnyString1(e.Graphics, "à¾ÕÂ§·èÒ¹ÁÕºÑµÃà¤Ã´Ôµ¢Í§¸¹Ò¤ÒÃ¡çÊÒÁÒÃ¶¢ÂÒÂÃÐÂÐàÇÅÒà¤Ã´ÔµáÅÐà¾ÔèÁ¤ÇÒÁÊÐ´Ç¡ã¹¡ÒÃªÓÃÐà§Ô¹ä´é ÊÍº¶ÒÁà¾ÔèÁàµÔÁ¡Ñº sale ·Õè´ÙáÅ·èÒ¹ä´éàÅÂÇÑ¹¹Õé", 75, 840)
    '                'AnyString1(e.Graphics, "¼ÅÃÒ§ÇÑÅLuckyStickerPanÁÙÅ¤èÒ 5,000ºÒ·µèÍ·Õè2ä´éá¡è µÃ§§Ç´·Õè 2ËÁÒÂàÅ¢ 192µÔ´µèÍÃÑºÃÒ§ÇÑÅä´éÇÑ¹¹Õé-15¾.Â.2554", 75, 840)
    '                'AnyString1(e.Graphics, "PromotionÇÑ¹äËÇé¾ÃÐ¨Ñ¹·Ãì «×éÍá¼è¹»ÃÐ¡ÒÂà¾ª 10 á¼è¹/ºÔÅ ÃÑº·Ñ¹·Õ¢¹ÁäËÇé¾ÃÐ¨Ñ¹·Ãì 1 ªÔé¹ µÑé§áµèÇÑ¹¹Õé-12 ¡Ñ¹ÂÒÂ¹È¡¹Õé", 75, 840)
    '                'AnyString1(e.Graphics, "«×éÍá¼è¹»ÃÐ¡ÒÂà¾ªáÅÐá¼è¹ÁØ¡ÊÕ·Í§ËÃ×ÍÊÕá´§ 20 á¼è¹ÃÑº¿ÃÕäÇµÒÁÔÅ¤ìà¨1á¾ê¤ ËÁ´à¢µ 5 µØÅÒ¤ÁÈ¡¹Õé", 75, 840)
    '                'AnyString1(e.Graphics, "á¾¹àÍà«ÕÂ¢Íà»ç¹¡ÓÅÑ§ã¨ãËé¡Ñº¼Ùé»ÃÐÊºÍØ·¡ÀÑÂ ãËé¼èÒ¹ÇÔ¡Äµ¹Õéä»ä´é´éÇÂ´Õ ÊÙéÊÙé¹Ð¤ÃÑº", 75, 840)
    '            End If
    '            If Disc = 0 And DePoSit = 0 Then 'ÁÕvatäÁèÁÕÊèÇ¹Å´ ,áÊ´§ PO

    '                AnyString1(e.Graphics, str22, 135, 880, False) 'thaibaht
    '                AnyString1(e.Graphics, str17, 135, 855, False) 'ËÁÒÂàËµØ
    '                AnyString1(e.Graphics, str14, 720, 860, False) 'ÂÍ´à§Ô¹¡èÍ¹ÀÒÉÕ
    '                AnyString1(e.Graphics, str15, 720, 880, False) 'ÀÒÉÕ
    '                AnyString1(e.Graphics, str16, 720, 905, False) 'ÂÍ´à§Ô¹ÃÇÁ

    '            ElseIf Disc = 0 And DePoSit > 0 Then

    '                AnyString1(e.Graphics, "ÂÍ´ÃÇÁ", 600, 820, False)
    '                AnyString1(e.Graphics, "ËÑ¡à§Ô¹ÁÑ´¨Ó", 600, 830, False)
    '                AnyString1(e.Graphics, str22, 135, 880, False) 'thaibaht
    '                AnyString1(e.Graphics, str17, 135, 855, False) 'ËÁÒÂàËµØ
    '                AnyString1(e.Graphics, str14, 720, 820, False) 'ÂÍ´à§Ô¹¡èÍ¹ËÑ¡ÊèÇ¹Å´
    '                AnyString1(e.Graphics, str20, 720, 840, False) 'ÊèÇ¹Å´
    '                AnyString1(e.Graphics, str21, 720, 860, False) 'ÂÍ´à§Ô¹ËÑ¡ÊèÇ¹Å´áÅéÇ
    '                AnyString1(e.Graphics, str15, 720, 880, False) 'ÀÒÉÕ
    '                AnyString1(e.Graphics, str16, 720, 905, False) 'ÂÍ´à§Ô¹ÃÇÁ

    '            ElseIf Disc > 0 And DePoSit = 0 Then

    '                AnyString1(e.Graphics, "ÂÍ´ÃÇÁ", 600, 820, False)
    '                AnyString1(e.Graphics, "ÊèÇ¹Å´", 600, 830, False)
    '                AnyString1(e.Graphics, str22, 135, 880, False) 'thaibaht
    '                AnyString1(e.Graphics, str17, 135, 855, False) 'ËÁÒÂàËµØ
    '                AnyString1(e.Graphics, str14, 720, 820, False) 'ÂÍ´à§Ô¹¡èÍ¹ËÑ¡ÊèÇ¹Å´
    '                AnyString1(e.Graphics, str20, 720, 840, False) 'ÊèÇ¹Å´
    '                AnyString1(e.Graphics, str21, 720, 860, False) 'ÂÍ´à§Ô¹ËÑ¡ÊèÇ¹Å´áÅéÇ
    '                AnyString1(e.Graphics, str15, 720, 880, False) 'ÀÒÉÕ
    '                AnyString1(e.Graphics, str16, 720, 905, False) 'ÂÍ´à§Ô¹ÃÇÁ
    '            ElseIf Disc > 0 And DePoSit > 0 Then



    '                AnyString1(e.Graphics, "ÂÍ´ÃÇÁ", 600, 820, False)
    '                AnyString1(e.Graphics, "ÊèÇ¹Å´", 600, 830, False)
    '                AnyString1(e.Graphics, str22, 135, 880, False) 'thaibaht
    '                AnyString1(e.Graphics, str17, 135, 855, False) 'ËÁÒÂàËµØ
    '                AnyString1(e.Graphics, str14, 720, 820, False) 'ÂÍ´à§Ô¹¡èÍ¹ËÑ¡ÊèÇ¹Å´
    '                AnyString1(e.Graphics, str20, 720, 840, False) 'ÊèÇ¹Å´
    '                AnyString1(e.Graphics, str21, 720, 860, False) 'ÂÍ´à§Ô¹ËÑ¡ÊèÇ¹Å´áÅéÇ
    '                AnyString1(e.Graphics, str15, 720, 880, False) 'ÀÒÉÕ
    '                AnyString1(e.Graphics, str16, 720, 905, False) 'ÂÍ´à§Ô¹ÃÇÁ
    '            End If
    '            'If Disc = 0 Then 'ÁÕvatäÁèÁÕÊèÇ¹Å´ áÊ´§ PO
    '            '    AnyString1(e.Graphics, str22, 135, 905) 'thaibaht
    '            '    AnyString1(e.Graphics, str17, 135, 855) 'ËÁÒÂàËµØ
    '            '    AnyString1(e.Graphics, str14, 720, 880) 'ÂÍ´à§Ô¹¡èÍ¹ÀÒÉÕ
    '            '    AnyString1(e.Graphics, str15, 720, 905) 'ÀÒÉÕ
    '            '    AnyString1(e.Graphics, str16, 720, 930) 'ÂÍ´à§Ô¹ÃÇÁ
    '            'Else 'ÁÕvatÁÕÊèÇ¹Å´
    '            '    AnyString1(e.Graphics, "ÂÍ´ÃÇÁ", 600, 840)
    '            '    AnyString1(e.Graphics, "ÊèÇ¹Å´", 600, 860)
    '            '    AnyString1(e.Graphics, str22, 135, 905) 'thaibaht
    '            '    AnyString1(e.Graphics, str17, 135, 855) 'ËÁÒÂàËµØ
    '            '    AnyString1(e.Graphics, str14, 720, 840) 'ÂÍ´à§Ô¹¡èÍ¹ËÑ¡ÊèÇ¹Å´
    '            '    AnyString1(e.Graphics, str20, 720, 860) 'ÊèÇ¹Å´
    '            '    AnyString1(e.Graphics, str21, 720, 880) 'ÂÍ´à§Ô¹ËÑ¡ÊèÇ¹Å´áÅéÇ
    '            '    AnyString1(e.Graphics, str15, 720, 905) 'ÀÒÉÕ
    '            '    AnyString1(e.Graphics, str16, 720, 930) 'ÂÍ´à§Ô¹ÃÇÁ
    '            'End If
    '        Else 'äÁèÁÕVat¨ÐµéÍ§Å´ºÃÃ·Ñ´ãËé¹éÍÂÅ§¡ÇèÒÁÕvat
    '            If str25 <> "110084" Then

    '                'AnyString1(e.Graphics, "«×éÍ Pan-Glue 1,000 ¡ÃÑÁËÃ×Í 500 ¡ÃÑÁ á¶Á¿ÃÕ!ËÅÍ´©Õ´¹éÓÂÒÍÂèÒ§´Õ µÑé§áµèÇÑ¹·Õè 1 ¾ÄÉÀÒ¤Á¹Õé à»ç¹µé¹ä»", 75, 860)
    '                'AnyString1(e.Graphics, "ÁÒáÅéÇ...á¼è¹»ÃÐ¡ÒÂà¾ªÃ·Ùâ·¹ 2 ÊÕÁÕ·Ñé§»ÃÐ¡ÒÂà¾ªÃà§Ô¹ËÅÑ§¢ÒÇ »ÃÐ¡ÒÂà¾ªÃËÅÑ§´ÓËÃ×Í¨Ñº¤ÙèÊÕµÒÁã¨»ÃÒÃ¶¹Ò ", 75, 840)
    '                'AnyString1(e.Graphics, "àËÁÒÐÊÓËÃÑº§Ò¹»éÒÂ á¡ÐÊÅÑ¡´éÇÂ CNC Ê¹ã¨µÔ´µèÍã¹à´×Í¹ ¾.Â. ¹Õé ÃÑºâ»ÃâÁªÑè¹¾ÔàÈÉ·Ñ¹·Õ ", 75, 860)
    '                'AnyString1(e.Graphics, "à¾ÕÂ§·èÒ¹ÁÕºÑµÃà¤Ã´Ôµ¢Í§¸¹Ò¤ÒÃ¡çÊÒÁÒÃ¶¢ÂÒÂÃÐÂÐàÇÅÒà¤Ã´ÔµáÅÐà¾ÔèÁ¤ÇÒÁÊÐ´Ç¡ã¹¡ÒÃªÓÃÐà§Ô¹ä´é ÊÍº¶ÒÁà¾ÔèÁàµÔÁ¡Ñº sale ·Õè´ÙáÅ·èÒ¹ä´éàÅÂÇÑ¹¹Õé", 75, 840)
    '                'AnyString1(e.Graphics, "¼ÅÃÒ§ÇÑÅLuckyStickerPanÁÙÅ¤èÒ 5,000ºÒ·µèÍ·Õè2ä´éá¡è µÃ§§Ç´·Õè 2ËÁÒÂàÅ¢ 192µÔ´µèÍÃÑºÃÒ§ÇÑÅä´éÇÑ¹¹Õé-15¾.Â.2554", 75, 840)
    '                'AnyString1(e.Graphics, "¶éÒÁÕÂÍ´Êè§ÊÔ¹¤éÒã¹ÇÑ¹à´ÕÂÇ¡Ñ¹¤Ãº 50,000 ºÒ·ËÃ×ÍÁÕ¡ÒÃ«×éÍÊÔ¹¤éÒ NPD ÃÑº¿ÃÕ '¡ÃÐ·§¢¹Á»Ñ§'µÑé§áµèÇÑ¹¹Õé-22 ¾.Â.¹Õé", 75, 840)
    '                'AnyString1(e.Graphics, "PromotionÇÑ¹äËÇé¾ÃÐ¨Ñ¹·Ãì «×éÍá¼è¹»ÃÐ¡ÒÂà¾ª 10 á¼è¹/ºÔÅ ÃÑº·Ñ¹·Õ¢¹ÁäËÇé¾ÃÐ¨Ñ¹·Ãì 1 ªÔé¹ µÑé§áµèÇÑ¹¹Õé-12 ¡Ñ¹ÂÒÂ¹È¡¹Õé", 75, 840)
    '                'AnyString1(e.Graphics, "«×éÍá¼è¹»ÃÐ¡ÒÂà¾ªáÅÐá¼è¹ÁØ¡ÊÕ·Í§ËÃ×ÍÊÕá´§ 20 á¼è¹ÃÑº¿ÃÕäÇµÒÁÔÅ¤ìà¨1á¾ê¤ ËÁ´à¢µ 5 µØÅÒ¤ÁÈ¡¹Õé", 75, 840)
    '                'AnyString1(e.Graphics, "á¾¹àÍà«ÕÂ¢Íà»ç¹¡ÓÅÑ§ã¨ãËé¡Ñº¼Ùé»ÃÐÊºÍØ·¡ÀÑÂ ãËé¼èÒ¹ÇÔ¡Äµ¹Õéä»ä´é´éÇÂ´Õ ÊÙéÊÙé¹Ð¤ÃÑº", 75, 840)
    '            End If
    '            'If Disc = 0 Then
    '            '    AnyString1(e.Graphics, str22, 135, 895) 'thaibaht
    '            '    AnyString1(e.Graphics, str17, 125, 880) 'ËÁÒÂàËµØ
    '            '    AnyString1(e.Graphics, str16, 720, 915) 'ÂÍ´à§Ô¹ÃÇÁ
    '            'Else
    '            '    AnyString1(e.Graphics, str22, 135, 895) 'thaibaht
    '            '    AnyString1(e.Graphics, str17, 125, 880) 'ËÁÒÂàËµØ
    '            '    AnyString1(e.Graphics, "ÂÍ´ÃÇÁ", 600, 880)
    '            '    AnyString1(e.Graphics, "ÊèÇ¹Å´", 600, 900)
    '            '    AnyString1(e.Graphics, str14, 720, 880) 'ÂÍ´à§Ô¹¡èÍ¹ËÑ¡ÊèÇ¹Å´
    '            '    AnyString1(e.Graphics, str20, 720, 900) 'ÊèÇ¹Å´
    '            '    AnyString1(e.Graphics, str16, 720, 915) 'ÂÍ´à§Ô¹ÃÇÁ
    '            'End If
    '            If Disc = 0 And DePoSit = 0 Then
    '                AnyString1(e.Graphics, str22, 135, 880, False) 'thaibaht
    '                AnyString1(e.Graphics, str17, 125, 870, False) 'ËÁÒÂàËµØ
    '                AnyString1(e.Graphics, str16, 720, 915, False) 'ÂÍ´à§Ô¹ÃÇÁ

    '            ElseIf Disc = 0 And DePoSit > 0 Then

    '                AnyString1(e.Graphics, str22, 135, 880, False) 'thaibaht
    '                AnyString1(e.Graphics, str17, 125, 870, False) 'ËÁÒÂàËµØ
    '                AnyString1(e.Graphics, "ÂÍ´ÃÇÁ", 600, 880, False)
    '                AnyString1(e.Graphics, "ËÑ¡à§Ô¹ÁÑ´¨Ó", 600, 900, False)
    '                AnyString1(e.Graphics, str14, 720, 880, False) 'ÂÍ´à§Ô¹¡èÍ¹ËÑ¡ÊèÇ¹Å´
    '                AnyString1(e.Graphics, str20, 720, 900, False) 'ÊèÇ¹Å´
    '                AnyString1(e.Graphics, str16, 720, 915, False) 'ÂÍ´à§Ô¹ÃÇÁ

    '            ElseIf Disc > 0 And DePoSit = 0 Then
    '                AnyString1(e.Graphics, str22, 135, 880, False) 'thaibaht
    '                AnyString1(e.Graphics, str17, 125, 870, False) 'ËÁÒÂàËµØ
    '                AnyString1(e.Graphics, "ÂÍ´ÃÇÁ", 600, 880, False)
    '                AnyString1(e.Graphics, "ÊèÇ¹Å´", 600, 900, False)
    '                AnyString1(e.Graphics, str14, 720, 880, False) 'ÂÍ´à§Ô¹¡èÍ¹ËÑ¡ÊèÇ¹Å´
    '                AnyString1(e.Graphics, str20, 720, 900, False) 'ÊèÇ¹Å´
    '                AnyString1(e.Graphics, str16, 720, 915, False) 'ÂÍ´à§Ô¹ÃÇÁ
    '            ElseIf Disc > 0 And DePoSit > 0 Then

    '                AnyString1(e.Graphics, str22, 135, 880, False) 'thaibaht
    '                AnyString1(e.Graphics, str17, 125, 870, False) 'ËÁÒÂàËµØ
    '                AnyString1(e.Graphics, "ÂÍ´ÃÇÁ", 600, 880, False)
    '                AnyString1(e.Graphics, "ÊèÇ¹Å´", 600, 900, False)
    '                AnyString1(e.Graphics, str14, 720, 880, False) 'ÂÍ´à§Ô¹¡èÍ¹ËÑ¡ÊèÇ¹Å´
    '                AnyString1(e.Graphics, str20, 720, 900, False) 'ÊèÇ¹Å´
    '                AnyString1(e.Graphics, str16, 720, 915, False) 'ÂÍ´à§Ô¹ÃÇÁ
    '            End If
    '        End If

    '    End If

    'End Sub

    'Sub prnTrhINV1(ByVal sender As Object, ByVal e As PrintPageEventArgs)
    '    Dim NoSel1 As String

    '    Dim c As Integer = 0
    '    'Dim k As Integer = 0
    '    '=================================================================
    '    '    ËÑÇºÔÅ    
    '    Dim strTrhNo As String = ""
    '    Dim strTrhDate As String = ""
    '    Dim strTrhCus As String = ""    'à¡çºÃËÑÊÅÙ¡¤éÒ»Ôè¹à¡ÅéÒ
    '    Dim strArName As String = ""

    '    Dim strArAddr As String = ""
    '    Dim strArAddr1 As String = ""
    '    Dim strArAddr2 As String = ""

    '    Dim strArShpVa As String = ""
    '    Dim strArShpVa1 As String = ""
    '    Dim strArShpVa2 As String = ""

    '    Dim strDDay As String = ""
    '    Dim strSLname As String = ""
    '    Dim strArTerm As String = ""

    '    Dim dblTrhAmt As Double = 0.0
    '    Dim StrTrhAmt As String = ""

    '    Dim dblTrhD_Amt As Double = 0.0
    '    Dim StrTrhD_Amt As String = ""

    '    Dim dblTrhDePoSit As Double = 0
    '    Dim strTrhDeposit As String = ""

    '    Dim dblTrhDisc As Double = 0
    '    Dim strTrhDisc As String = ""

    '    Dim StrTrhVat As String = ""
    '    Dim dblTrhVat As Double = 0.0

    '    Dim StrTrhFullAmt As String = ""
    '    Dim dblTrhFullAmt As Double = 0.0
    '    Dim stringTotal As String = ""

    '    Dim strTrhDetail As String = ""

    '    '=================================================================
    '    Dim str09 As String = ""
    '    Dim str10 As String = ""
    '    Dim str11 As String = ""
    '    Dim str12 As String = ""
    '    Dim str13 As String = ""

    '    'Dim strVAT0 As String = ""
    '    Dim str16 As String = ""
    '    '   ·éÒÂºÔÅ

    '    '   ÃÒÂ¡ÒÃÊÔ¹¤éÒ
    '    Dim strDtlDetail As String = ""
    '    Dim str21 As String = ""

    '    Dim str23 As String = ""
    '    Dim str24 As String = ""


    '    Dim yy As Integer = 0


    '    Dim DiscBath As Double = 0.0 'à¡çº¤èÒÊèÇ¹Å´à»ç¹ºÒ··ÕèµÑ´b·Ôé§

    '    NoSel1 = txtNo.Text

    '    If chkPrint = True Then
    '        DS.Tables("Print").Clear()
    '        chkPrint = False
    '    End If

    '    txtSQL = SQLprtTrhNo_PO(txtNo.Text)
    '    DS = New DataSet
    '    DA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
    '    DA.Fill(DS, "prnTrh")

    '    strTrhNo = CStr(DS.Tables("prnTrh").Rows(c).Item("trh_no")) 'àÅ¢·ÕèºÔÅ
    '    '(((Month(DS.Tables("Print").Rows(c).Item("trh_date")) & "/" & DateAndTime.Day(DS.Tables("Print").Rows(c).Item("trh_date")) & "/" & Year(DS.Tables("Print").Rows(c).Item("trh_date")) - 543))) 
    '    strTrhDate = (((Month(DS.Tables("Print").Rows(c).Item("trh_date")) & "/" & DateAndTime.Day(DS.Tables("Print").Rows(c).Item("trh_date")) & "/" & Year(DS.Tables("Print").Rows(c).Item("trh_date")) - 543)))  'ÇÑ¹·ÕèºÔÅ
    '    strArName = CStr(DS.Tables("prnTrh").Rows(c).Item("Ar_Name")) 'ª×èÍÃéÒ¹
    '    strArAddr = CStr(DS.Tables("prnTrh").Rows(c).Item("ar_addr")) '·ÕèÍÂÙè
    '    strArAddr1 = CStr(DS.Tables("prnTrh").Rows(c).Item("ar_addr_1")) '·ÕèÍÂÙè
    '    strArAddr2 = CStr(DS.Tables("prnTrh").Rows(c).Item("ar_addr_2")) '·ÕèÍÂÙè
    '    strArTerm = CStr(DS.Tables("prnTrh").Rows(c).Item("trh_term")) 'à¤Ã´Ôµà·ÍÁ

    '    If IsDBNull(DS.Tables("prnTrh").Rows(c).Item("dday")) Then
    '        strDDay = ""
    '    Else
    '        strDDay = CStr(DS.Tables("prnTrh").Rows(c).Item("dday")) 'ÇÑ¹·Õè¤Ãº¡ÓË¹´ªÓÃÐ
    '    End If

    '    strSLname = CStr(DS.Tables("prnTrh").Rows(c).Item("sl_name")) 'ª×èÍsale


    '    If IsDBNull(DS.Tables("prnTrh").Rows(c).Item("ar_shp_va")) Then
    '        strArShpVa = ""
    '    Else
    '        strArShpVa = CStr(DS.Tables("prnTrh").Rows(c).Item("ar_shp_va")) '·ÕèÊè§¢Í§

    '    End If
    '    'ElseIf DS.Tables("prnTrh").Rows(c).Item("ar_shp_va1") = "" Then
    '    '    strArShpVa1 = ""

    '    If IsDBNull(DS.Tables("prnTrh").Rows(c).Item("ar_shp_va1")) Then
    '        strArShpVa1 = ""

    '    Else
    '        strArShpVa1 = CStr(DS.Tables("prnTrh").Rows(c).Item("ar_shp_va1")) 'ª×èÍsale
    '    End If

    '    If IsDBNull(DS.Tables("prnTrh").Rows(c).Item("ar_shp_va2")) Then
    '        strArShpVa2 = ""
    '    Else
    '        strArShpVa2 = CStr(DS.Tables("prnTrh").Rows(c).Item("ar_shp_va2")) 'ª×èÍsale
    '    End If

    'End Sub

    Sub prnTrhInv2()
        Dim NoSel1 As String
        Dim c As Integer = 0
        'Dim k As Integer = 0
        '=================================================================
        '    ËÑÇºÔÅ    
        Dim strTrhNo As String = ""
        Dim strTrhDate As String = ""
        Dim strTrhCus As String = ""    'à¡çºÃËÑÊÅÙ¡¤éÒ»Ôè¹à¡ÅéÒ
        Dim strArName As String = ""

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

        Dim StrTrhVat As String = ""
        Dim dblTrhVat As Double = 0.0

        Dim StrTrhFullAmt As String = ""
        Dim dblTrhFullAmt As Double = 0.0
        Dim stringTotal As String = ""

        Dim strTrhDetail As String = ""

        '=================================================================
        Dim str09 As String = ""
        Dim str10 As String = ""
        Dim str11 As String = ""
        Dim str12 As String = ""
        Dim str13 As String = ""

        'Dim strVAT0 As String = ""
        Dim str16 As String = ""
        '   ·éÒÂºÔÅ

        '   ÃÒÂ¡ÒÃÊÔ¹¤éÒ
        Dim strDtlDetail As String = ""
        Dim str21 As String = ""

        Dim str23 As String = ""
        Dim str24 As String = ""


        Dim yy As Integer = 0

        'Dim StrAmt As String = ""

        Dim DiscBath As Double = 0.0 'à¡çº¤èÒÊèÇ¹Å´à»ç¹ºÒ··ÕèµÑ´b·Ôé§

        NoSel1 = txtNo.Text

        If chkPrint = True Then
            DS.Tables("Print").Clear()
            chkPrint = False
        End If
        '              àÃÔèÁªØ´¤ÓÊÑè§ ¾ÔÁ¾ì §Ò¹·Õè äÁèÁÕ PO 
        '======================================================================================================
        'txtSQL = SQLPrint2() 'äÁèÁÕPO (vat)

        txtSQL = SQLprtTrhNo_PO(txtNo.Text)
        DS = New DataSet
        DA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        DA.Fill(DS, "prnTrh")

        '=================================   ÊèÇ¹¢Í§à§Ô¹·éÒÂºÔÅ    ====================================================

        'dblTrhAmt = dblTrhAmt - dblTrhDisc - dblTrhDePoSit
        'StrTrhAmt = Format(dblTrhAmt, "#,##0.00#")

        dblTrhAmt = DS.Tables("prnTrh").Rows(c).Item("trh_amt")   '  ÂÍ´à§Ô¹  ¡èÍ¹Å´ÊèÇ¹Å´ 
        StrTrhAmt = Format(dblTrhAmt, "#,##0.00#")

        dblTrhD_Amt = DS.Tables("prnTrh").Rows(c).Item("trh_D_amt")
        StrTrhD_Amt = Format(Math.Round(dblTrhD_Amt, 3), "#,##0.00#") 'ÂÍ´à§Ô¹ ËÅÑ§Å´ÊèÇ¹Å´ 

        If IsDBNull(DS.Tables("prnTrh").Rows(c).Item("trh_disc")) Then
            dblTrhDisc = 0
        ElseIf Microsoft.VisualBasic.Right(DS.Tables("prnTrh").Rows(c).Item("trh_disc"), 1) = "b" Then

            dblTrhDisc = CDbl(Microsoft.VisualBasic.Left(DS.Tables("prnTrh").Rows(c).Item("trh_disc"), (Len(DS.Tables("prnTrh").Rows(c).Item("trh_disc")) - 1)))
            strTrhDisc = Format(Math.Round(dblTrhDisc, 2), "#,##0.00#")

        Else
            strTrhDisc = Format(Math.Round(CDbl(DS.Tables("prnTrh").Rows(c).Item("trh_disc")) * CDbl(DS.Tables("prnTrh").Rows(c).Item("trh_amt")) / 100, 2), "#,##0.00#")
            dblTrhDisc = CDbl(DS.Tables("prnTrh").Rows(c).Item("trh_disc"))

        End If

        If IsDBNull(DS.Tables("prnTrh").Rows(c).Item("trh_Deposit")) Then
            dblTrhDePoSit = 0
            strTrhDeposit = "0.00"
        Else
            dblTrhDePoSit = CDbl(DS.Tables("prnTrh").Rows(c).Item("trh_DePosit"))
            strTrhDeposit = Format(dblTrhDePoSit, "#,##0.00")
        End If

        dblTrhVat = (dblTrhD_Amt * 7) / 100
        StrTrhVat = Format(Math.Round(dblTrhVat, 2), "#,##0.00#") 'ÀÒÉÕ

        If dblTrhVat <> 0 Then
            StrTrhFullAmt = Format((dblTrhAmt + dblTrhVat), "#,##0.00#")
        Else
            StrTrhFullAmt = Format(dblTrhAmt, "#,##0.00#")
        End If
        ThaiBaht01 = StrTrhFullAmt  'ÂÍ´à§Ô¹ÃÇÁ
        stringTotal = DBtools.ThaiBaht(ThaiBaht01)

        strTrhDetail = CStr(DS.Tables("prnTrh").Rows(c).Item("trh_detail"))   'ËÁÒÂàËµØËÅÑ¡  ÊèÇ¹·éÒÂºÔÅ

        '==========================================================================

    End Sub

    Sub printNpo(ByVal sender As Object, ByVal e As PrintPageEventArgs)

        Dim NoSel1 As String

        Dim c As Integer = 0
        'Dim k As Integer = 0
        '=================================================================
        '    ËÑÇºÔÅ    
        Dim strTrhNo As String = ""
        Dim strTrhDate As String = ""
        Dim strTrhCus As String = ""    'à¡çºÃËÑÊÅÙ¡¤éÒ»Ôè¹à¡ÅéÒ
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
        Dim strTrhDiscPrn As String = ""  ' ãªéã¹¡ÒÃ¾ÔÁ¾ì % ÊèÇ¹Å´ ºÃÔàÇ³·éÒÂºÔÅ

        Dim StrTrhVat As String = ""
        Dim dblTrhVat As Double = 0.0

        Dim dblTrhTotal1 As Double = 0
        Dim strTrhTotal1 As String = ""
        'Dim dblTrhTotal2 As Double = 0

        Dim StrTrhFullAmt As String = ""
        Dim dblTrhFullAmt As Double = 0.0
        Dim stringTotal As String = ""

        Dim strTrhDetail As String = ""
        '   ·éÒÂºÔÅ

        '=================================================================
        '   ÃÒÂ¡ÒÃÊÔ¹¤éÒ

        Dim FMsetDigiCal As String = "#,##0.00"
        Dim setDigiCal As Integer = 0
        Dim strItem As String = ""
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

        Dim totalYY As Integer = 0  '  ¨Ñ´µÓáË¹è§ µÑÇàÅ¢¡èÍ¹Å´ áÅÐ ËÑ¡ÁÑ´¨Ó

        Dim calVAT As Double = 0
        Dim chkVAT As String = ""
        Dim tempDisc As Double = 0
        Dim strDisc As String = ""

        'Dim StrAmt As String = ""

        Dim DiscBath As Double = 0.0 'à¡çº¤èÒÊèÇ¹Å´à»ç¹ºÒ··ÕèµÑ´b·Ôé§

        NoSel1 = txtNo.Text

        If chkPrint = True Then
            DS.Tables("Print").Clear()
            chkPrint = False
        End If
        '              àÃÔèÁªØ´¤ÓÊÑè§ ¾ÔÁ¾ì §Ò¹·Õè äÁèÁÕ PO 
        '======================================================================================================
        'txtSQL = SQLPrint2() 'äÁèÁÕPO (vat)

        txtSQL = SQLprtTrhNo_PO(txtNo.Text)
        DS = New DataSet
        DA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        DA.Fill(DS, "prnTrh")

        txtSQL = SQLprtDtlNo_PO(txtNo.Text)
        'DS = New DataSet
        DA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        DA.Fill(DS, "prnDtl")
        chkPrint = True

        strTrhNo = CStr(DS.Tables("prnTrh").Rows(c).Item("trh_no")) 'àÅ¢·ÕèºÔÅ

        If Dvat = "N" Or Dvat = "n" Or Dvat = "M" Then
            chkVAT = "N"
        Else
            chkVAT = "V"
            'chkVAT = Microsoft.VisualBasic.Left(strTrhNo, 1)
        End If


        calVAT = DS.Tables("prnTrh").Rows(c).Item("trh_bill")
        '((Month(DS.Tables("prnTrh").Rows(c).Item("trh_date")) & "-" & DateAndTime.Day(DS.Tables("prnTrh").Rows(c).Item("trh_date")) & "-" & Year(DS.Tables("prnTrh").Rows(c).Item("trh_date")) - 543))
        'strTrhDate = CStr(Format(DateAdd(DateInterval.Year, -543, DS.Tables("prnTrh").Rows(c).Item("trh_date")), "dd/MM/yyyy")) 'ÇÑ¹·ÕèºÔÅ
        strTrhDate = CStr(Format(((DateAndTime.Day(DS.Tables("prnTrh").Rows(c).Item("trh_date")) & "/" & Month(DS.Tables("prnTrh").Rows(c).Item("trh_date")) & "/" & Year(DS.Tables("prnTrh").Rows(c).Item("trh_date")) - 543)))) 'ÇÑ¹·ÕèºÔÅ

        strTrhCus = CStr(DS.Tables("prnTrh").Rows(c).Item("trh_cus")) 'ÃËÑÊÅÙ¡¤éÒ
        strArName = CStr(DS.Tables("prnTrh").Rows(c).Item("Ar_Name")) 'ª×èÍÃéÒ¹
        strArAddr = CStr(DS.Tables("prnTrh").Rows(c).Item("ar_addr")) '·ÕèÍÂÙè
        strArAddr1 = CStr(DS.Tables("prnTrh").Rows(c).Item("ar_addr_1")) '·ÕèÍÂÙè
        strArAddr2 = CStr(DS.Tables("prnTrh").Rows(c).Item("ar_addr_2")) '·ÕèÍÂÙè
        strArTerm = CStr(DS.Tables("prnTrh").Rows(c).Item("trh_term")) 'à¤Ã´Ôµà·ÍÁ
        strArAcct = CStr(DS.Tables("prnTrh").Rows(c).Item("Ar_Acct")) 'à¤Ã´Ôµà·ÍÁ

        If strArAcct = "112010" Then
            setDigiCal = 2
            FMsetDigiCal = "#,##0.00"
        Else
            setDigiCal = 4
            FMsetDigiCal = "#,##0.0000"
        End If

        If Dvat = "N" Or Dvat = "n" Or Dvat = "M" Then
            strArTaxID = ""
        Else

            If IsDBNull(DS.Tables("prnTrh").Rows(c).Item("Ar_Tax_Code")) Then
                strArTaxID = ""
            ElseIf Trim(DS.Tables("prnTrh").Rows(c).Item("Ar_Tax_Code")) = "" Then
                strArTaxID = ""
            Else
                strArTaxID = "Tax ID:= " & CStr(DS.Tables("prnTrh").Rows(c).Item("Ar_Tax_Code"))
            End If

        End If

        If IsDBNull(DS.Tables("prnTrh").Rows(c).Item("Trh_Depo_Ref")) Then
            strTrhDepoRef = ""
        ElseIf Trim(DS.Tables("prnTrh").Rows(c).Item("Trh_Depo_Ref")) = "" Then
            strTrhDepoRef = ""
        Else
            strTrhDepoRef = CStr(DS.Tables("prnTrh").Rows(c).Item("Trh_Depo_Ref"))
        End If

        If IsDBNull(DS.Tables("prnTrh").Rows(c).Item("dday")) Then
            strDDay = ""
        Else
            strDDay = CStr(DS.Tables("prnTrh").Rows(c).Item("dday")) 'ÇÑ¹·Õè¤Ãº¡ÓË¹´ªÓÃÐ
        End If
        strSLname = CStr(DS.Tables("prnTrh").Rows(c).Item("sl_name")) 'ª×èÍsale

        If IsDBNull(DS.Tables("prnTrh").Rows(c).Item("ar_shp_va")) Then
            strArShpVa = ""
        Else
            strArShpVa = CStr(DS.Tables("prnTrh").Rows(c).Item("ar_shp_va")) '·ÕèÊè§¢Í§

        End If
        'ElseIf DS.Tables("prnTrh").Rows(c).Item("ar_shp_va1") = "" Then
        '    strArShpVa1 = ""

        If IsDBNull(DS.Tables("prnTrh").Rows(c).Item("ar_shp_va1")) Then
            strArShpVa1 = ""

        Else
            strArShpVa1 = CStr(DS.Tables("prnTrh").Rows(c).Item("ar_shp_va1")) 'ª×èÍsale
        End If

        If IsDBNull(DS.Tables("prnTrh").Rows(c).Item("ar_shp_va2")) Then
            strArShpVa2 = ""
        Else
            strArShpVa2 = CStr(DS.Tables("prnTrh").Rows(c).Item("ar_shp_va2")) 'ª×èÍsale
        End If

        '=================================   ÊèÇ¹¢Í§à§Ô¹·éÒÂºÔÅ    ====================================================

        'dblTrhAmt = dblTrhAmt - dblTrhDisc - dblTrhDePoSit
        'StrTrhAmt = Format(dblTrhAmt, "#,##0.00#")

        dblTrhAmt = DS.Tables("prnTrh").Rows(c).Item("trh_amt")   '  ÂÍ´à§Ô¹  ¡èÍ¹Å´ÊèÇ¹Å´ 
        StrTrhAmt = Format(dblTrhAmt, "#,##0.00")

        dblTrhD_Amt = DS.Tables("prnTrh").Rows(c).Item("trh_D_amt")
        StrTrhD_Amt = Format(Math.Round(dblTrhD_Amt, 3), "#,##0.00")

        'ÂÍ´à§Ô¹ ËÅÑ§Å´ÊèÇ¹Å´ 
        If IsDBNull(DS.Tables("prnTrh").Rows(c).Item("trh_disc")) Then
            dblTrhDisc = 0
        ElseIf Microsoft.VisualBasic.Right(DS.Tables("prnTrh").Rows(c).Item("trh_disc"), 1) = "B" Then

            'dblTrhDisc = CDbl(Microsoft.VisualBasic.Left(DS.Tables("prnTrh").Rows(c).Item("trh_disc"), (Len(DS.Tables("prnTrh").Rows(c).Item("trh_disc")) - 1)))

            dblTrhDisc = CDbl(Microsoft.VisualBasic.Left(DS.Tables("prnTrh").Rows(c).Item("trh_disc"), (Len(DS.Tables("prnTrh").Rows(c).Item("trh_disc")) - 1)))
            strTrhDisc = Format(Math.Round(dblTrhDisc, 2), "#,##0.00")
            strTrhDiscPrn = ""
        ElseIf Microsoft.VisualBasic.Right(DS.Tables("prnTrh").Rows(c).Item("trh_disc"), 1) = "b" Then

            ' dblTrhDisc = CDbl(Microsoft.VisualBasic.Left(DS.Tables("prnTrh").Rows(c).Item("trh_disc"), (Len(DS.Tables("prnTrh").Rows(c).Item("trh_disc")) - 1)))
            dblTrhDisc = CDbl(Microsoft.VisualBasic.Left(DS.Tables("prnTrh").Rows(c).Item("trh_disc"), (Len(DS.Tables("prnTrh").Rows(c).Item("trh_disc")) - 1)))
            strTrhDisc = Format(Math.Round(dblTrhDisc, 2), "#,##0.00")
            strTrhDiscPrn = ""
        ElseIf Microsoft.VisualBasic.Right(DS.Tables("prnTrh").Rows(c).Item("trh_disc"), 1) = "%" Then

            dblTrhDisc = CDbl(Microsoft.VisualBasic.Left(DS.Tables("prnTrh").Rows(c).Item("trh_disc"), (Len(DS.Tables("prnTrh").Rows(c).Item("trh_disc")) - 1)))
            dblTrhDisc = Math.Round((dblTrhDisc * DS.Tables("prnTrh").Rows(c).Item("trh_amt")) / 100, 2)
            strTrhDisc = Format(Math.Round(dblTrhDisc, 2), "#,##0.00")
            strTrhDiscPrn = DS.Tables("prnTrh").Rows(c).Item("trh_disc")


        ElseIf IsNumeric(Microsoft.VisualBasic.Right(DS.Tables("prnTrh").Rows(c).Item("trh_disc"), 1)) Then

            strTrhDisc = Format(Math.Round(CDbl(DS.Tables("prnTrh").Rows(c).Item("trh_disc"))), "#,##0.00")
            dblTrhDisc = CDbl(strTrhDisc)
            strTrhDiscPrn = ""
        End If

        '   à§Ô¹ÁÑ´¨Ó
        If IsDBNull(DS.Tables("prnTrh").Rows(c).Item("trh_Deposit")) Then

            dblTrhDePoSit = 0
            strTrhDeposit = "0.00"

        ElseIf Microsoft.VisualBasic.Right(DS.Tables("prnTrh").Rows(c).Item("trh_Deposit"), 1) = "%" Then
            dblTrhDePoSit = CDbl(Microsoft.VisualBasic.Left(DS.Tables("prnTrh").Rows(c).Item("trh_Deposit"), (Len(DS.Tables("prnTrh").Rows(c).Item("trh_Deposit")) - 1)))
            dblTrhDePoSit = (dblTrhAmt * dblTrhDePoSit) / 100
            strTrhDeposit = Format(dblTrhDePoSit, "#,##0.00")

        ElseIf Microsoft.VisualBasic.Right(DS.Tables("prnTrh").Rows(c).Item("trh_Deposit"), 1) = "b" Then

            dblTrhDePoSit = CDbl(Microsoft.VisualBasic.Left(DS.Tables("prnTrh").Rows(c).Item("trh_Deposit"), (Len(DS.Tables("prnTrh").Rows(c).Item("trh_Deposit")) - 1)))
            strTrhDeposit = Format(dblTrhDePoSit, "#,##0.00")

        ElseIf Microsoft.VisualBasic.Right(DS.Tables("prnTrh").Rows(c).Item("trh_Deposit"), 1) = "B" Then

            dblTrhDePoSit = CDbl(Microsoft.VisualBasic.Left(DS.Tables("prnTrh").Rows(c).Item("trh_Deposit"), (Len(DS.Tables("prnTrh").Rows(c).Item("trh_Deposit")) - 1)))
            strTrhDeposit = Format(dblTrhDePoSit, "#,##0.00")

        ElseIf IsNumeric(Microsoft.VisualBasic.Right(DS.Tables("prnTrh").Rows(c).Item("trh_Deposit"), 1)) Then

            dblTrhDePoSit = CDbl(DS.Tables("prnTrh").Rows(c).Item("trh_DePosit"))
            strTrhDeposit = Format(dblTrhDePoSit, "#,##0.00")

        End If

        dblTrhTotal1 = (dblTrhAmt - dblTrhDisc) - dblTrhDePoSit
        strTrhTotal1 = Format((dblTrhAmt - dblTrhDisc) - dblTrhDePoSit, "#,##0.00")

        '=======  VAT
        If chkVAT = "V" Or chkVAT = "v" Then
            dblTrhVat = (dblTrhTotal1 * calVAT) / 100
        Else
            dblTrhVat = 0
        End If

        StrTrhVat = Format(dblTrhVat, "#,##0.00") 'ÀÒÉÕ

        If dblTrhVat <> 0 Then
            StrTrhFullAmt = Format((dblTrhTotal1 + dblTrhVat), "#,##0.00")
        Else
            StrTrhFullAmt = Format(dblTrhTotal1, "#,##0.00")
        End If

        ThaiBaht01 = StrTrhFullAmt  'ÂÍ´à§Ô¹ÃÇÁ
        stringTotal = DBtools.ThaiBaht(ThaiBaht01)
        strTrhDetail = CStr(DS.Tables("prnTrh").Rows(c).Item("trh_detail"))   'ËÁÒÂàËµØËÅÑ¡  ÊèÇ¹·éÒÂºÔÅ

        '=========àÃÔèÁÊèÇ¹¢Í§¡ÒÃ Print   ÃÒÂÅÐàÍÕÂ´ÊÔ¹¤éÒ  =================================================================
        Dim offSetY As Integer = 0
        Dim offSetX As Integer = 0
        If Dvat = "N" Or Dvat = "n" Or Dvat = "M" Then
            offSetY = -65
            offSetX = -70
        End If
        If DS.Tables("prnDtl").Rows.Count > 0 Then

            For c = 0 To DS.Tables("prnDtl").Rows.Count - 1
                '===========================================================================================
                If chkVAT = "N" Then
                    '==========    ¾ÔÁ¾ì  ¿ÍÃìÁ N-VAT  ===============
                    strItem = c + 1  '   ÅÓ´Ñº Ë¹éÒÃÒÂ¡ÒÃ

                    If IsDBNull(DS.Tables("prnDtl").Rows(c).Item("stk_name_1")) Then
                        If IsDBNull(DS.Tables("prnDtl").Rows(c).Item("stk_name_2")) Then
                            strStkName = ""
                        Else
                            strStkName = CStr((DS.Tables("prnDtl").Rows(c).Item("stk_name_2"))) 'ª×èÍÊÔ¹¤éÒ PC
                        End If
                    Else
                        strStkName = CStr((DS.Tables("prnDtl").Rows(c).Item("stk_name_1"))) 'ª×èÍÊÔ¹¤éÒ Sale
                    End If

                    strQty = CSng(Format(DS.Tables("prnDtl").Rows(c).Item("dtl_num"), "#,##0.00")) '¨Ó¹Ç¹
                    strPrice = Format(CDbl(DS.Tables("prnDtl").Rows(c).Item("Dtl_price")), FMsetDigiCal) 'ÃÒ¤Ò/á¼è¹
                    strDisc = 0
                    strPriceDisc = ""
                    If (DS.Tables("prnDtl").Rows(c).Item("Dtl_t_disc")) = "0" Then

                        'str13 = Format(CDbl(DS.Tables("Print").Rows(c).Item("Dtl_sum")), "#,##0.00") 'ÃÒ¤ÒÃÇÁ
                        strSum = Format(Math.Round(DS.Tables("prnDtl").Rows(c).Item("Dtl_sum"), 4), FMsetDigiCal) '3-08-60
                        strStkName = CStr(DS.Tables("prnDtl").Rows(c).Item("stk_name_1")) 'ª×èÍÊÔ¹¤éÒ

                    Else

                        If IsDBNull(DS.Tables("prnDtl").Rows(c).Item("Dtl_t_disc")) Then
                            strDisc = 0
                        Else
                            strDisc = DS.Tables("prnDtl").Rows(c).Item("Dtl_t_disc")
                        End If

                        'If Microsoft.VisualBasic.Right(strDisc, 1) <> "b" Then
                        '    '  Å´ÃÒ¤Òà»ç¹ ºÒ·  "b"  
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
                            '  Å´ÃÒ¤Òà»ç¹ ºÒ·  "b"  
                            tempDisc = CDbl(Microsoft.VisualBasic.Left(strDisc, Len(strDisc) - 1))
                            strPriceDisc = Format(Math.Round(strPrice - tempDisc, 4), "#,##0.00")

                            strSum = Format(Math.Round(DS.Tables("prnDtl").Rows(c).Item("Dtl_sum"), 3), FMsetDigiCal) '3-08-60

                        ElseIf Microsoft.VisualBasic.Right(strDisc, 1) = "%" Then

                            tempDisc = CDbl(Microsoft.VisualBasic.Left(strDisc, Len(strDisc) - 1))
                            tempDisc = (CDbl(DS.Tables("prnDtl").Rows(c).Item("Dtl_price")) * CDbl(tempDisc)) / 100

                            strPriceDisc = Format(Math.Round(strPrice - tempDisc, 4), "#,##0.00")
                            strSum = Format(Math.Round(DS.Tables("prnDtl").Rows(c).Item("Dtl_sum"), 3), FMsetDigiCal) '3-08-60

                        ElseIf IsNumeric(strDisc) Then

                            tempDisc = CDbl(strDisc)
                            strPriceDisc = Format(Math.Round(strPrice - tempDisc, 4), "#,##0.00")
                            strSum = Format(Math.Round(DS.Tables("prnDtl").Rows(c).Item("Dtl_sum"), 3), FMsetDigiCal) '3-08-60

                        End If

                    End If

                    If IsDBNull(DS.Tables("prnDtl").Rows(c).Item("dtl_detail")) Or Trim(DS.Tables("prnDtl").Rows(c).Item("dtl_detail")) = "" Then
                        strDtlDetail = ""
                    Else
                        strDtlDetail = "( " & CStr(DS.Tables("prnDtl").Rows(c).Item("dtl_detail")) & " )" 'ËÁÒÂàËµØÂèÍÂ
                    End If
                    If chkPrnPO = True Then
                        If IsDBNull(DS.Tables("prnDtl").Rows(c).Item("Dtl_PO")) Or DS.Tables("prnDtl").Rows(c).Item("Dtl_PO") = "äÁèÁÕãºàºÔ¡" Then
                            strDtlPO = ""
                        Else
                            strDtlPO = CStr(DS.Tables("prnDtl").Rows(c).Item("Dtl_PO"))
                        End If
                    End If
                    strDtlDetail = strDtlPO & "  " & strDtlDetail  ' ÃÇÁ PO ¡Ñº ËÁÒÂàËµØ

                    AnyString1(e.Graphics, strItem, (85 + 10 - 10), 440 + 30 + yy + offSetY, True) 'ÅÓ´Ñº
                    AnyString1(e.Graphics, strStkName, (130 - 10), 440 + 30 + yy + offSetY, False) 'ª×èÍÊÔ¹¤éÒ
                    AnyString1(e.Graphics, strQty, (500 + 78 + offSetX), 440 + 30 + yy + offSetY, True) '¨Ó¹Ç¹
                    AnyString1(e.Graphics, strPrice, (590 + 55 + offSetX), 440 + 30 + yy + offSetY, True) 'ÃÒ¤Ò
                    'AnyString1(e.Graphics, strPrice, 620, 440 + yy) 'ÃÒ¤Ò  »ÃÑºµÓáË¹è§ ¨Ò¡ 620 à»ç¹ 590 
                    AnyString1(e.Graphics, (strPriceDisc), 590 + 120, 440 + 30 + yy + offSetY, True) 'ÃÒ¤ÒËÅÑ§Å´

                    If strDisc = "0" Or strDisc = "" Then
                        'strDisc = ""
                    Else
                        AnyString1(e.Graphics, "-" & strDisc, (640 + 40) + offSetX, 440 + 30 + yy + offSetY, True) 'ÊèÇ¹Å´
                    End If

                    AnyString1(e.Graphics, strSum, (730 + 65), 440 + 30 + yy + offSetY, True) 'ÃÒ¤ÒÃÇÁ
                    '   ¾ÔÁ¾ì àÅ¢·Õè PO ã¹ÃÒÂ¡ÒÃÊÔ¹¤éÒ 

                    'If chkPrnPO = True Then
                    '    If strDtlPO = "" Then
                    '        AnyString1(e.Graphics, strDtlPO, 135, 460 + 30 + yy + offSetY, False) 'po
                    '    Else
                    '        AnyString1(e.Graphics, strDtlPO, 135, 460 + 30 + yy + offSetY, False) 'po
                    '    End If
                    'Else
                    '    'AnyString1(e.Graphics, "", 135, 460 + yy) 'po
                    'End If

                    '   ¾ÔÁ¾ì ËÁÒÂàËµØ ã¹ÃÒÂ¡ÒÃÊÔ¹¤éÒ 
                    If strDtlDetail = "" Then
                        AnyString1(e.Graphics, strDtlDetail, 135, 460 + 30 + yy + offSetY, False) 'po
                    Else
                        AnyString1(e.Graphics, strDtlDetail, 135, 460 + 30 + yy + offSetY, False) 'po
                    End If

                    'If strDtlDetail = "" Then

                    'Else
                    '    If chkPrnPO = True And (Len(strDtlPO) > 0) Then
                    '        AnyString1(e.Graphics, strDtlDetail, (136 + (Len(strDtlPO) * 50) + 5), 460 + 30 + yy + offSetY, False) 'ËÁÒÂàËµØÂèÍÂµèÍ·éÒÂPO
                    '        'yy = yy + offSetY 
                    '        yy = yy + offSetY

                    '    Else
                    '        AnyString1(e.Graphics, strDtlDetail, (136 + 5), 460 + 30 + yy + offSetY, False) 'ËÁÒÂàËµØÂèÍÂµèÍ·éÒÂPO
                    '        yy = yy + offSetY
                    '        'AnyString1(e.Graphics, yy, (136 + (Len(strDtlPO) * 50) + 5), 460 + 30 + yy + offSetY, False) 'ËÁÒÂàËµØÂèÍÂµèÍ·éÒÂPO
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
                    '==================    ¾ÔÁ¾ì¿ÍÃìÁ VAT  =================

                    strItem = c + 1  '   ÅÓ´Ñº Ë¹éÒÃÒÂ¡ÒÃ

                    If IsDBNull(DS.Tables("prnDtl").Rows(c).Item("stk_name_1")) Then
                        If IsDBNull(DS.Tables("prnDtl").Rows(c).Item("stk_name_2")) Then
                            strStkName = ""
                        Else
                            strStkName = CStr((DS.Tables("prnDtl").Rows(c).Item("stk_name_2"))) 'ª×èÍÊÔ¹¤éÒ PC
                        End If
                    Else
                        strStkName = CStr((DS.Tables("prnDtl").Rows(c).Item("stk_name_1"))) 'ª×èÍÊÔ¹¤éÒ Sale
                    End If

                    strQty = CSng(Format(DS.Tables("prnDtl").Rows(c).Item("dtl_num"), "#,##0.00")) '¨Ó¹Ç¹
                    strPrice = Format(CDbl(DS.Tables("prnDtl").Rows(c).Item("Dtl_price")), FMsetDigiCal) 'ÃÒ¤Ò/á¼è¹
                    strDisc = ""
                    tempDisc = 0
                    strPriceDisc = ""


                    If (DS.Tables("prnDtl").Rows(c).Item("Dtl_t_disc")) = "0" Then
                        'str13 = Format(CDbl(DS.Tables("Print").Rows(c).Item("Dtl_sum")), "#,##0.00") 'ÃÒ¤ÒÃÇÁ
                        strSum = Format(Math.Round(DS.Tables("prnDtl").Rows(c).Item("Dtl_sum"), 3), FMsetDigiCal)
                        strStkName = CStr(DS.Tables("prnDtl").Rows(c).Item("stk_name_1")) 'ª×èÍÊÔ¹¤éÒ

                    Else

                        If IsDBNull(DS.Tables("prnDtl").Rows(c).Item("Dtl_t_disc")) Then
                            strDisc = 0
                        Else
                            strDisc = DS.Tables("prnDtl").Rows(c).Item("Dtl_t_disc")
                        End If

                        If Microsoft.VisualBasic.Right(strDisc, 1) = "b" Or Microsoft.VisualBasic.Right(strDisc, 1) = "B" Then
                            '  Å´ÃÒ¤Òà»ç¹ ºÒ·  "b"  
                            tempDisc = CDbl(Microsoft.VisualBasic.Left(strDisc, Len(strDisc) - 1))
                            strPriceDisc = Format(Math.Round(strPrice - tempDisc, 4), "#,##0.00")

                            strSum = Format(Math.Round(DS.Tables("prnDtl").Rows(c).Item("Dtl_sum"), 3), FMsetDigiCal)

                        ElseIf Microsoft.VisualBasic.Right(strDisc, 1) = "%" Then

                            tempDisc = CDbl(Microsoft.VisualBasic.Left(strDisc, Len(strDisc) - 1))
                            tempDisc = (CDbl(DS.Tables("prnDtl").Rows(c).Item("Dtl_price")) * CDbl(tempDisc)) / 100

                            strPriceDisc = Format(Math.Round(strPrice - tempDisc, 4), "#,##0.00")
                            strSum = Format(Math.Round(DS.Tables("prnDtl").Rows(c).Item("Dtl_sum"), 3), FMsetDigiCal)

                        ElseIf IsNumeric(strDisc) Then

                            tempDisc = CDbl(strDisc)
                            strPriceDisc = Format(Math.Round(strPrice - tempDisc, 4), "#,##0.00")
                            strSum = Format(Math.Round(DS.Tables("prnDtl").Rows(c).Item("Dtl_sum"), 3), FMsetDigiCal)

                        End If

                    End If

                    If IsDBNull(DS.Tables("prnDtl").Rows(c).Item("dtl_detail")) Or Trim(DS.Tables("prnDtl").Rows(c).Item("dtl_detail")) = "" Then
                        strDtlDetail = ""
                    Else
                        strDtlDetail = "( " & CStr(DS.Tables("prnDtl").Rows(c).Item("dtl_detail")) & " )" 'ËÁÒÂàËµØÂèÍÂ
                    End If

                    If IsDBNull(DS.Tables("prnDtl").Rows(c).Item("Dtl_PO")) Or DS.Tables("prnDtl").Rows(c).Item("Dtl_PO") = "äÁèÁÕãºàºÔ¡" Then
                        strDtlPO = ""
                    Else
                        strDtlPO = CStr(DS.Tables("prnDtl").Rows(c).Item("Dtl_PO"))
                    End If
                    'tempDisc


                    AnyString1(e.Graphics, strItem, 85, 440 + yy, True) 'ÅÓ´Ñº
                    AnyString1(e.Graphics, strStkName, 110, 440 + yy, False) 'ª×èÍÊÔ¹¤éÒ
                    AnyString1(e.Graphics, strQty, 500, 440 + yy, True) '¨Ó¹Ç¹
                    AnyString1(e.Graphics, strPrice, 590, 440 + yy, True) 'ÃÒ¤Ò/Ë¹èÇÂ
                    AnyString1(e.Graphics, (strPriceDisc), 590 + 120, 440 + yy, True) 'ÃÒ¤ÒËÅÑ§Å´

                    ' áººà´ÔÁ
                    'AnyString1(e.Graphics, strItem, (85 + 10), 440 + yy, True) 'ÅÓ´Ñº
                    'AnyString1(e.Graphics, strStkName, (135), 440 + yy, False) 'ª×èÍÊÔ¹¤éÒ
                    'AnyString1(e.Graphics, strQty, (500 + 40), 440 + yy, True) '¨Ó¹Ç¹
                    'AnyString1(e.Graphics, strPrice, (590 + 55), 440 + yy, True) 'ÃÒ¤Ò/Ë¹èÇÂ

                    If strDisc = "0" Or strDisc = "" Then
                        'strDisc = ""
                    Else
                        AnyString1(e.Graphics, "-" & strDisc, (625), 440 + yy, True) 'ÊèÇ¹Å´
                        'AnyString1(e.Graphics, "-" & strDisc, (640 + 40), 440 + yy, True) 'ÊèÇ¹Å´
                    End If

                    AnyString1(e.Graphics, strSum, (730 + 65), 440 + yy, True) 'ÃÒ¤ÒÃÇÁ
                    '   ¾ÔÁ¾ì àÅ¢·Õè PO ã¹ÃÒÂ¡ÒÃÊÔ¹¤éÒ 

                    If chkPrnPO = True Then
                        If strDtlPO = "" Then
                            AnyString1(e.Graphics, strDtlPO, 135, 460 + yy, False) 'po
                        Else

                            AnyString1(e.Graphics, strDtlPO, 135, 460 + yy, False) 'po
                        End If
                    Else
                        'AnyString1(e.Graphics, "", 135, 460 + yy) 'po
                    End If

                    '   ¾ÔÁ¾ì ËÁÒÂàËµØ ã¹ÃÒÂ¡ÒÃÊÔ¹¤éÒ 
                    If strDtlDetail = "" Then


                    Else
                        If chkPrnPO = True And (Len(strDtlPO) > 0) Then
                            AnyString1(e.Graphics, strDtlDetail, (136 + (Len(strDtlPO) * 10) + 5), 460 + yy, False) 'ËÁÒÂàËµØÂèÍÂµèÍ·éÒÂPO
                            yy = yy + 20
                        Else
                            AnyString1(e.Graphics, strDtlDetail, (136 + 5), 460 + yy, False) 'ËÁÒÂàËµØÂèÍÂµèÍ·éÒÂPO
                            yy = yy + 20
                        End If

                    End If

                    If chkPrnPO = True Then
                        yy = yy + 40
                    Else
                        yy = yy + 20
                    End If
                End If

                '===========================================================================================
            Next

        End If

        AnyString1(e.Graphics, strTrhNo, 680, 130 + offSetY, False) 'àÅ¢·ÕèºÔÅ
        AnyString1(e.Graphics, strTrhDate, 680, 170 + offSetY, False) 'ÇÑ¹·ÕèºÔÅ
        AnyString1(e.Graphics, strArName, 130, 240 + offSetY, False) 'ª×èÍÃéÒ¹
        AnyString1(e.Graphics, strArAddr, 130, 260 + offSetY, False) '·ÕèÍÂÙè
        AnyString1(e.Graphics, strArAddr1, 130, 280 + offSetY, False) '·ÕèÍÂÙè
        AnyString1(e.Graphics, strArAddr2, 130, 300 + offSetY, False) '·ÕèÍÂÙè
        AnyString1(e.Graphics, strArTaxID, 130, 320 + offSetY, False) '·ÕèÍÂÙè

        If strArShpVa = "" And strArShpVa1 = "" And strArShpVa2 = "" Then
            AnyString1(e.Graphics, strArAddr, 525, 260 + offSetY, False) '·ÕèÍÂÙèÊè§¢Í§
            AnyString1(e.Graphics, strArAddr1, 525, 280 + offSetY, False) '·ÕèÍÂÙè
            AnyString1(e.Graphics, strArAddr2, 525, 300 + offSetY, False) '·ÕèÍÂÙè

        Else
            AnyString1(e.Graphics, strArShpVa, 525, 260 + offSetY, False) '¢¹Êè§
            AnyString1(e.Graphics, strArShpVa1, 525, 280 + offSetY, False) '·ÕèÍÂÙè
            AnyString1(e.Graphics, strArShpVa2, 525, 300 + offSetY, False) '·ÕèÍÂÙè
        End If

        AnyString1(e.Graphics, strArTerm, 150, 370 + offSetY, False) 'à¤Ã´Ôµ
        AnyString1(e.Graphics, strDDay, 360, 370 + offSetY, False) 'due
        AnyString1(e.Graphics, strSLname, 680, 370 + offSetY, False) 'sale

        'If Microsoft.VisualBasic.Left(txtNo.Text, 1) = "V" Then 'áººÁÕVat

        '  =====  àÃÔèÁÊèÇ¹¢Í§  ·éÒÂºÔÅ   ·Õèà»ç¹ÂÍ´à§Ô¹  
        If Len(strTrhDetail) > 0 Then
            AnyString1(e.Graphics, "ËÁÒÂàËµØ :" & strTrhDetail, 135, 810, False)  '  »ÃÑº¨Ò¡  840 -->  810
        End If

        AnyString1(e.Graphics, stringTotal, 135, 860, False) 'thaibaht  µÑÇÍÑ¡ÉÃ¨Ó¹Ç¹ ÀÒÉÒä·Â  »ÃÑº¢Öé¹ÍÕ¡  30 ¨Ò¡  880 à»ç¹   850

        If chkVAT = "V" Or chkVAT = "v" Then

            AnyString1(e.Graphics, strTrhTotal1, (730 + 65), 860, True)   ' ÂÍ´à§Ô¹ËÅÑ§ËÅÑ¡ÊèÇ¹Å´ áÅÐ ËÑ¡ÁÑ´¨Ó
            AnyString1(e.Graphics, StrTrhVat, (730 + 65), 880, True)     'ÀÒÉÕ
            AnyString1(e.Graphics, StrTrhFullAmt, (730 + 65), 905, True) 'ÂÍ´à§Ô¹ÃÇÁ
            totalYY = 830
        Else
            AnyString1(e.Graphics, strTrhTotal1, (730 + 65), 885, True) 'ÂÍ´à§Ô¹ÃÇÁ »ÃÑº¨Ò¡ 915 à»ç¹ 885  
            totalYY = 830
        End If

        If dblTrhDePoSit > 0 Then
            AnyString1(e.Graphics, "ËÑ¡à§Ô¹ÁÑ´¨Ó " & strTrhDepoRef & ": ", 550, totalYY, False)
            'AnyString1(e.Graphics, str17, 135, 860) ' ËÁÒÂàËµØ·ÕèãÊàÅ¢·ÕèÁÑ´¨Ó
            AnyString1(e.Graphics, strTrhDeposit, (730 + 65), totalYY, True)
            totalYY = totalYY - 20

        End If
        If dblTrhDisc > 0 Then
            AnyString1(e.Graphics, "ËÑ¡à§Ô¹ÊèÇ¹Å´" & " " & strTrhDiscPrn, 550, totalYY, False)
            AnyString1(e.Graphics, strTrhDisc, (730 + 65), totalYY, True)
            totalYY = totalYY - 20

        End If

        If dblTrhDisc > 0 Or dblTrhDePoSit > 0 Then

            AnyString1(e.Graphics, "ÂÍ´ÃÇÁ", 550, totalYY, False)  '815 
            AnyString1(e.Graphics, StrTrhAmt, (730 + 65), totalYY, True)  '815 
            totalYY = totalYY - 20

        End If

        If chkVAT = "N" Then
            AnyString1(e.Graphics, "µÑ´ÊµêÍ¡¤ÅÑ§ÊÔ¹¤éÒ " & " (" & lbWHcode.Text & ") ", 650, 920, False)  '  »ÃÑº¨Ò¡ 950 à´ÔÁ¢Öé¹ÍÕ¡ 30
        Else
            AnyString1(e.Graphics, "FM-FA-01 Rev.00 11/06/04  " & " (" & lbWHcode.Text & ") ", 600, 930, False)
        End If


    End Sub


    Private Sub StringToPrint_Print(ByVal sender As Object, ByVal e As PrintPageEventArgs)


        If MsgBox("µéÍ§¡ÒÃáÊ´§ PO ËÃ×ÍäÁè", MsgBoxStyle.YesNo, "ÊÍº¶ÒÁ") = MsgBoxResult.Yes Then
            chkPrnPO = True
            'printHpo(sender, e)  '  ÂÑ§äÁèàÊÃé¨ »Ô´äÇé¡èÍ¹ 
            printNpo(sender, e)

        Else '¢Í§msgbox
            chkPrnPO = False
            printNpo(sender, e)


        End If ' ¢Í§msgbox



        Dno = ""


    End Sub

    Private Sub AnyString(ByVal g As Graphics, ByVal printString As String, ByVal xPos As Integer, ByVal yPos As Integer)
        Dim anyPoint As New PointF(xPos, yPos)
        g.DrawString(printString, UseFont, Brushes.Black, anyPoint)
    End Sub

    Private Sub AnyString1(ByVal g As Graphics, ByVal printString As String, ByVal xPos As Integer, ByVal yPos As Integer, backToFont As Boolean)

        Dim anyPoint As New PointF(xPos, yPos)
        Dim lenString As Integer

        Dim point_X As Integer = xPos    '   ¢ÂÑºµÓáË¹è§ X ¾ÔÁ¾ì¨Ò¡ ËÅÑ§ÁÒË¹éÒ
        Dim point_y As Integer = yPos    '   äÁèµéÍ§ÂØè§  ãªéµÒÁà´ÔÁ  
        Dim strPrint As String



        If backToFont = True Then
            lenString = Len(printString)     '   ËÒ¨Ó¹Ç¹µÑÇÍÑ¡ÉÃ



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

    Sub stepPrint()  '  by  Kritpon  27-02-58



    End Sub



    Function SQLPrint() As String  'ÁÕPO

        txtSQL = " Select  DISTINCT"
        txtSQL = txtSQL & " TranDataH.Trh_Type, TranDataH.Trh_Date,TranDataH.Trh_Disc, TranDataH.Trh_V_Amt,  TranDataH.Trh_Amt, TranDataH.Trh_D_Amt, TranDataH.Trh_Detail, "
        txtSQL = txtSQL & " TranDataH.Trh_D_Amt + TranDataH.Trh_V_Amt AS Total,TranDataH.Trh_No, TranDataH.Trh_Cus, TranDataH.Trh_Detail,TranDataH.Trh_Deposit,Trh_Depo_ref, TranDataD.Dtl_type, "
        txtSQL = txtSQL & " TranDataH.Trh_Term, TranDataD.Dtl_date, TranDataD.Dtl_need, TranDataD.Dtl_no, DATEADD(d, TranDataH.Trh_Term, TranDataD.Dtl_date) AS dday, "
        txtSQL = txtSQL & " TranDataD.Dtl_idtrade, TranDataH.Trh_Sale, TranDataD.Dtl_num, TranDataD.Dtl_price,TranDataD.Dtl_t_disc, TranDataD.Dtl_sum, TranDataD.Dtl_con_id, "
        txtSQL = txtSQL & " TranDataD.Dtl_cutA_code, TranDataD.Dtl_runnum, TranDataD.Dtl_detail, "
        txtSQL = txtSQL & " ArTable.AR_CUS_ID, ArTable.Cus_Code,ArTable.Ar_Tax_Code,ArTable.Name1, ArTable.ar_addr,ArTable.ar_shp_va,ArTable.ar_shp_va1,ArTable.ar_shp_va2, "
        txtSQL = txtSQL & " ArTable.ar_addr_1, ArTable.Ar_update, ArTable.ar_addr_2, ArTable.ar_sales, ArTable.ar_term,"
        txtSQL = txtSQL & " cutMast.Cut_Name_2, salesman.SL_NAME, "
        txtSQL = txtSQL & " BaseMast.Stk_Name_1, BaseMast.Stk_Name_2, BaseMast.Stk_Unit_1, TranDataD_1.Dtl_po AS po, TranDataD_1.Dtl_type AS expr2"

        txtSQL = txtSQL & " FROM salesman RIGHT OUTER JOIN"
        txtSQL = txtSQL & " TranDataH ON salesman.SL_ID = TranDataH.Trh_Sale LEFT OUTER JOIN"
        txtSQL = txtSQL & " cutMast RIGHT OUTER JOIN"
        txtSQL = txtSQL & " TranDataD LEFT OUTER JOIN"
        txtSQL = txtSQL & " TranDataD TranDataD_1 ON TranDataD.Dtl_con_id = TranDataD_1.Dtl_con_id LEFT OUTER JOIN"
        txtSQL = txtSQL & " BaseMast ON TranDataD.Dtl_idtrade = BaseMast.Stk_Code ON cutMast.Cut_Code = TranDataD.Dtl_cutA_code ON "
        txtSQL = txtSQL & " TranDataH.Trh_No = TranDataD.Dtl_no AND TranDataH.Trh_Type = TranDataD.Dtl_type FULL OUTER JOIN"
        txtSQL = txtSQL & "  (SELECT     *"
        txtSQL = txtSQL & " FROM          (SELECT     ArFile.Ar_Type, ARFILE.AR_CUS_ID, Arfile2.AR_CUS_ID AS Cus_Code, ARFILE.AR_NAME, Arfile2.ar_shp_va,Arfile2.ar_shp_va1,Arfile2.ar_shp_va2,Arfile2.AR_NAME AS Name1, "
        txtSQL = txtSQL & " Arfile2.ar_addr, Arfile2.ar_addr_1, Arfile2.ar_addr_2, Arfile2.ar_sales, Arfile2.ar_term, ArFile.Ar_update"
        txtSQL = txtSQL & " FROM          ARFILE CROSS JOIN"
        txtSQL = txtSQL & " ARFILE Arfile2"
        txtSQL = txtSQL & " WHERE      (Arfile2.AR_CUS_ID = '110346') AND (ARFILE.AR_TYPE = 'AR') AND (Arfile2.AR_TYPE = 'AR') AND (LEFT(ARFILE.AR_CUS_ID, 2) "
        txtSQL = txtSQL & "   = '12')) DERIVEDTBL"
        txtSQL = txtSQL & " UNION"
        txtSQL = txtSQL & " SELECT     *"
        txtSQL = txtSQL & "  FROM         (SELECT     ArFile.Ar_Type, ARFILE.AR_CUS_ID, Arfile2.AR_CUS_ID AS Cus_Code, ARFILE.AR_NAME,Arfile2.ar_shp_va,Arfile2.ar_shp_va1,Arfile2.ar_shp_va2, Arfile2.AR_NAME AS Name1, "
        txtSQL = txtSQL & " Arfile2.ar_addr, Arfile2.ar_addr_1, Arfile2.ar_addr_2, Arfile2.ar_sales, Arfile2.ar_term, ArFile.Ar_update"
        txtSQL = txtSQL & "   FROM          ARFILE LEFT OUTER JOIN"
        txtSQL = txtSQL & "  ARFILE Arfile2 ON ARFILE.AR_CUS_ID = Arfile2.AR_CUS_ID"
        txtSQL = txtSQL & "  WHERE      (ARFILE.AR_TYPE = 'AR') AND (Arfile2.AR_TYPE = 'AR') AND (NOT (LEFT(ARFILE.AR_CUS_ID, 2) = '12'))) DERIVEDTBL) "
        txtSQL = txtSQL & "   ArTable ON TranDataH.Trh_Cus = ArTable.AR_CUS_ID COLLATE Thai_CI_AS"
        txtSQL = txtSQL & " WHERE     (ArTable.Ar_Type = N'AR') AND (TranDataH.Trh_Type = 'S') AND (TranDataD.Dtl_type = 'S') "
        txtSQL = txtSQL & " AND (TranDataD_1.Dtl_type = 'B')"
        txtSQL = txtSQL & " and  TranDataH.Trh_no='" & txtNo.Text & "'"

        Return txtSQL
    End Function
    Function SQLPrint3() As String  'äÁèÁÕPO

        txtSQL = "Select  DISTINCT "
        txtSQL = txtSQL & "TranDataH.Trh_Type, TranDataH.Trh_Date,TranDataH.Trh_Disc, TranDataH.Trh_V_Amt,  TranDataH.Trh_Amt, TranDataH.Trh_D_Amt,"
        txtSQL = txtSQL & "TranDataH.Trh_Detail,TranDataH.Trh_D_Amt + TranDataH.Trh_V_Amt AS Total,TranDataH.Trh_No, "
        txtSQL = txtSQL & "TranDataH.Trh_Cus, TranDataH.Trh_Detail, TranDataD.Dtl_type,TranDataH.Trh_Term,Trh_Deposit,Trh_Depo_Ref, "
        txtSQL = txtSQL & "TranDataD.Dtl_date, TranDataD.Dtl_need, TranDataD.Dtl_no, DATEADD(d, TranDataH.Trh_Term, TranDataD.Dtl_date) AS dday, "
        txtSQL = txtSQL & "TranDataD.Dtl_idtrade, TranDataH.Trh_Sale, TranDataD.Dtl_num, TranDataD.Dtl_price,TranDataD.Dtl_t_disc, TranDataD.Dtl_sum, TranDataD.Dtl_con_id, "
        txtSQL = txtSQL & "TranDataD.Dtl_cutA_code, TranDataD.Dtl_runnum, TranDataD.Dtl_detail, "

        txtSQL = txtSQL & "ArTable.AR_CUS_ID, ArTable.Cus_Code, ArTable.Name1,"
        txtSQL = txtSQL & "ArTable.ar_addr,ArTable.ar_shp_va,ArTable.ar_shp_va1,ArTable.ar_shp_va2, "
        txtSQL = txtSQL & "ArTable.ar_addr_1, ArTable.Ar_update, ArTable.ar_addr_2, ArTable.ar_sales,"
        txtSQL = txtSQL & "ArTable.ar_term, cutMast.Cut_Name_2, salesman.SL_NAME, "

        txtSQL = txtSQL & "BaseMast.Stk_Name_1, BaseMast.Stk_Name_2, BaseMast.Stk_Unit_1, TranDataD.Dtl_con_id "
        txtSQL = txtSQL & "FROM (SELECT * "
        txtSQL = txtSQL & "FROM ("

        txtSQL = txtSQL & "SELECT ArFile.Ar_Type, ARFILE.AR_CUS_ID, Arfile2.AR_CUS_ID AS Cus_Code, "
        txtSQL = txtSQL & "ARFILE.AR_NAME, Arfile2.ar_shp_va,Arfile2.ar_shp_va1,Arfile2.ar_shp_va2,Arfile2.AR_NAME AS Name1, "
        txtSQL = txtSQL & "Arfile2.ar_addr, Arfile2.ar_addr_1, Arfile2.ar_addr_2, Arfile2.ar_sales, Arfile2.ar_term, ArFile.Ar_update "
        txtSQL = txtSQL & "FROM  ARFILE CROSS JOIN ARFILE Arfile2 "
        txtSQL = txtSQL & "WHERE (ARFILE.AR_TYPE = 'AR') AND (Arfile2.AR_CUS_ID = '110346') AND (Arfile2.AR_TYPE = 'AR') "
        txtSQL = txtSQL & "AND (LEFT(ARFILE.AR_CUS_ID, 2)='12')) DERIVEDTBL "

        txtSQL = txtSQL & "UNION  "
        txtSQL = txtSQL & "SELECT  * "
        txtSQL = txtSQL & "FROM "
        txtSQL = txtSQL & "(SELECT ArFile.Ar_Type, ARFILE.AR_CUS_ID, Arfile2.AR_CUS_ID AS Cus_Code, "
        txtSQL = txtSQL & "ARFILE.AR_NAME,Arfile2.ar_shp_va,Arfile2.ar_shp_va1,Arfile2.ar_shp_va2, Arfile2.AR_NAME AS Name1, "
        txtSQL = txtSQL & "Arfile2.ar_addr, Arfile2.ar_addr_1, Arfile2.ar_addr_2, Arfile2.ar_sales, Arfile2.ar_term, ArFile.Ar_update "
        txtSQL = txtSQL & "FROM ARFILE LEFT OUTER JOIN "
        txtSQL = txtSQL & "ARFILE Arfile2 ON ARFILE.AR_CUS_ID = Arfile2.AR_CUS_ID "
        txtSQL = txtSQL & "WHERE (ARFILE.AR_TYPE = 'AR') AND (Arfile2.AR_TYPE = 'AR') AND (NOT (LEFT(ARFILE.AR_CUS_ID, 2) = '12'))) DERIVEDTBL) "
        txtSQL = txtSQL & "ArTable FULL OUTER JOIN "
        txtSQL = txtSQL & "salesman RIGHT OUTER JOIN "
        txtSQL = txtSQL & "TranDataH ON salesman.SL_ID = TranDataH.Trh_Sale LEFT OUTER JOIN "
        txtSQL = txtSQL & "TranDataD LEFT OUTER JOIN "
        txtSQL = txtSQL & "BaseMast ON TranDataD.Dtl_idtrade = BaseMast.Stk_Code LEFT OUTER JOIN "
        txtSQL = txtSQL & "cutMast ON TranDataD.Dtl_cutA_code = cutMast.Cut_Code ON TranDataH.Trh_No = TranDataD.Dtl_no AND "
        txtSQL = txtSQL & "TranDataH.Trh_Type = TranDataD.Dtl_type ON ArTable.AR_CUS_ID COLLATE Thai_CI_AS = TranDataH.Trh_Cus "
        txtSQL = txtSQL & "WHERE (ArTable.Ar_Type = N'AR') AND (TranDataH.Trh_Type = 'S') AND TranDataH.Trh_No ='" & txtNo.Text & "' "

        Return txtSQL
    End Function
    Function SQLPrint2() As String  'äÁèÁÕPO

        txtSQL = "Select  DISTINCT "

        txtSQL = txtSQL & "TranDataH.Trh_Type, TranDataH.Trh_Date,TranDataH.Trh_Disc, TranDataH.Trh_V_Amt,"
        txtSQL = txtSQL & "TranDataH.Trh_Amt, TranDataH.Trh_D_Amt,"
        txtSQL = txtSQL & "TranDataH.Trh_Detail,TranDataH.Trh_D_Amt + TranDataH.Trh_V_Amt As Total,TranDataH.Trh_No, "
        txtSQL = txtSQL & "TranDataH.Trh_Cus, TranDataH.Trh_Detail, TranDataD.Dtl_type,TranDataH.Trh_Term,Trh_Deposit,"
        txtSQL = txtSQL & "Trh_Depo_Ref,TranDataD.Dtl_date, TranDataD.Dtl_need, TranDataD.Dtl_no,"
        txtSQL = txtSQL & "DATEADD(d,TranDataH.Trh_Term, TranDataD.Dtl_date) As dday, "
        txtSQL = txtSQL & "TranDataD.Dtl_idtrade, TranDataH.Trh_Sale, TranDataD.Dtl_num, TranDataD.Dtl_price,"
        txtSQL = txtSQL & "TranDataD.Dtl_t_disc, TranDataD.Dtl_sum, TranDataD.Dtl_con_id, "
        txtSQL = txtSQL & "TranDataD.Dtl_cutA_code, TranDataD.Dtl_runnum, TranDataD.Dtl_detail,TranDataD.Dtl_condition, "
        txtSQL = txtSQL & "ArTable.AR_CUS_ID, ArTable.Cus_Code, ArTable.Name1, ArTable.ar_addr,ArTable.ar_shp_va,"
        txtSQL = txtSQL & "ArTable.ar_shp_va1,ArTable.ar_shp_va2, "
        txtSQL = txtSQL & "ArTable.ar_addr_1, ArTable.Ar_update, ArTable.ar_addr_2, ArTable.ar_sales, ArTable.ar_term,"
        txtSQL = txtSQL & "cutMast.Cut_Name_2, salesman.SL_NAME, "
        txtSQL = txtSQL & "BaseMast.Stk_Name_1, BaseMast.Stk_Name_2, BaseMast.Stk_Unit_1, TranDataD.Dtl_con_id "

        txtSQL = txtSQL & "FROM (Select * "
        txtSQL = txtSQL & "FROM ("
        txtSQL = txtSQL & "Select ArFile.Ar_Type, ARFILE.AR_CUS_ID, Arfile2.AR_CUS_ID As Cus_Code, "
        txtSQL = txtSQL & "ARFILE.AR_NAME, Arfile2.ar_shp_va,Arfile2.ar_shp_va1,Arfile2.ar_shp_va2,Arfile2.AR_NAME As Name1, "
        txtSQL = txtSQL & "Arfile2.ar_addr, Arfile2.ar_addr_1, Arfile2.ar_addr_2, Arfile2.ar_sales, Arfile2.ar_term, ArFile.Ar_update "
        txtSQL = txtSQL & "FROM  ARFILE CROSS JOIN ARFILE Arfile2 "
        txtSQL = txtSQL & "WHERE (ARFILE.AR_TYPE = 'AR') AND (Arfile2.AR_CUS_ID = '110346') AND (Arfile2.AR_TYPE = 'AR') "
        txtSQL = txtSQL & "AND (LEFT(ARFILE.AR_CUS_ID, 2)='12')) DERIVEDTBL "

        txtSQL = txtSQL & "UNION  "
        txtSQL = txtSQL & "SELECT  * "
        txtSQL = txtSQL & "FROM "
        txtSQL = txtSQL & "(SELECT ArFile.Ar_Type, ARFILE.AR_CUS_ID,Arfile2.AR_CUS_ID AS Cus_Code, "
        txtSQL = txtSQL & "ARFILE.AR_NAME,Arfile2.ar_shp_va,Arfile2.ar_shp_va1,Arfile2.ar_shp_va2, Arfile2.AR_NAME AS Name1, "
        txtSQL = txtSQL & "Arfile2.ar_addr, Arfile2.ar_addr_1, Arfile2.ar_addr_2, Arfile2.ar_sales, Arfile2.ar_term, ArFile.Ar_update "
        txtSQL = txtSQL & "FROM ARFILE LEFT OUTER JOIN "
        txtSQL = txtSQL & "ARFILE Arfile2 ON ARFILE.AR_CUS_ID = Arfile2.AR_CUS_ID "
        txtSQL = txtSQL & "WHERE (ARFILE.AR_TYPE = 'AR') AND (Arfile2.AR_TYPE = 'AR') AND (NOT (LEFT(ARFILE.AR_CUS_ID, 2) = '12'))) DERIVEDTBL) "
        txtSQL = txtSQL & "ArTable FULL OUTER JOIN "
        txtSQL = txtSQL & "salesman RIGHT OUTER JOIN "
        txtSQL = txtSQL & "TranDataH ON salesman.SL_ID = TranDataH.Trh_Sale LEFT OUTER JOIN "
        txtSQL = txtSQL & "TranDataD LEFT OUTER JOIN "
        txtSQL = txtSQL & "BaseMast ON TranDataD.Dtl_idtrade = BaseMast.Stk_Code LEFT OUTER JOIN "
        txtSQL = txtSQL & "cutMast ON TranDataD.Dtl_cutA_code = cutMast.Cut_Code ON TranDataH.Trh_No = TranDataD.Dtl_no AND "
        txtSQL = txtSQL & "TranDataH.Trh_Type = TranDataD.Dtl_type ON ArTable.AR_CUS_ID COLLATE Thai_CI_AS = TranDataH.Trh_Cus "
        txtSQL = txtSQL & "WHERE (ArTable.Ar_Type = N'AR') AND (TranDataH.Trh_Type = 'S') AND TranDataH.Trh_No ='" & txtNo.Text & "' "

        Return txtSQL

    End Function

    Function SQLprtDtlNo_PO(ByVal txtNo As String) As String  'äÁèÁÕPO

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

    Function SQLprtTrhNo_PO(ByVal txtNo As String) As String  'äÁèÁÕPO

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



    Private Sub txtSale_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSaleQty.KeyDown
        If e.KeyCode = 13 Then
            txtPrice.Focus()
        End If
    End Sub

    Private Sub cboTypeDoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTypeDoc.SelectedIndexChanged


        'Call AutoGenerateID()
        If chkfrmLoad = True Then
            Dvat = cboTypeDoc.SelectedValue
            If Dvat = "P" Then
                MsgBox("àÅ×Í¡¾¹Ñ¡§Ò¹¢ÒÂ--> ¤Ø³¾ÔÁ¾ì ", MsgBoxStyle.Critical, "á¨é§àµ×Í¹")
                txtSaleMan.Text = "SL03" '.Rows(0).Item("Ar_Sales") 'DBtools.getSalesCode(CusCode)
                lbSaleName.Text = DBtools.getSaleName(txtSaleMan.Text)
                txtCredit.Text = "0"


            End If

            'Call findStkBase()
        Else

        End If




    End Sub
    Private Sub cmbCutItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCutItem.Click

        If lbCusID.Text <> "" Then
            frmCut.ShowDialog()

        End If

    End Sub



    Private Sub SelectSaleMan()

        frmSaleMan.cmbSave.Visible = False
        frmSaleMan.cmbDel.Visible = False
        frmSaleMan.cmbExit.Visible = True
        frmSaleMan.cmbSelect.Visible = True
        frmSaleMan.ShowDialog()
        If selSale <> "" And selSaleName <> "" Then
            'If selSale = "SL03" Then
            '    cboTypeDoc.SelectedValue = "P"
            'End If
            txtSaleMan.Text = selSale
            lbSaleName.Text = selSaleName
            selSale = ""
            selSaleName = ""

        End If

    End Sub


    Private Sub lbSelSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbSelSale.Click
        Call SelectSaleMan()

    End Sub

    Private Sub GroupBox6_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lbTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbPrint2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPrint2.Click
        'Dim ver
        Dim frmEditNo As New frmEditNo
        Dvat = cboTypeDoc.SelectedValue
        SelectDate = dtp01.Value

        Call sumTotal()

        If chkDataItem() = False Then Exit Sub


        If DBtools.getDocNumber(txtNo.Text, docType) = True Then
            EditNo = txtNo.Text
            Call AddtoExcel()
            'If MsgBox("àÍ¡ÊÒÃàÅ¢·Õè  **** " & txtNo.Text & " **** ÁÕ¢éÍÁÙÅà´ÔÁÍÂÙè  µéÍ§¡ÒÃºÑ¹·Ö¡¡ÒÃá¡éä¢ ", MsgBoxStyle.YesNo, "á¨é§àµ×Í¹ !") = MsgBoxResult.Yes Then


            '    'Call mainSave()
            '    'Call showCondition()


            'Else
            '    MsgBox("àÍ¡ÊÒÃÂÑ§äÁè¶Ù¡ºÑ¹·Ö¡  µÃÇ¨ÊÍºÍÕ¡¤ÃÑé§")
            'End If


        Else
            MsgBox("¢éÍÁÙÅ¼Ô´¾ÅÒ´  µÃÇ¨ÊÍºÍÕ¡¤ÃÑé§")

        End If



    End Sub

    Sub AddtoExcel()

        Dim subDS As DataSet = New DataSet
        Dim subDA As New SqlClient.SqlDataAdapter

        Dim fileName As String = ""
        'Dim myExcel As Excel.Application

        Dim objExcel As Microsoft.Office.Interop.Excel.Application
        Dim objExcelWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim objExcelWorkSheet As Microsoft.Office.Interop.Excel.Worksheet

        Dim i_row As Integer = "0"
        Dim c As Integer = 0
        Dim i As Integer = 0

        Call SQLPrint2()

        'subDS.Tables("Print").Clear()
        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "Print")

        If subDS.Tables("Print").Rows.Count > 0 Then

            'fileName = CurDir() & "\deliveryDoc.xlsx"
            fileName = CurDir() & "\deliveryDoc.xls"
            objExcel = New Microsoft.Office.Interop.Excel.Application
            objExcel.Visible = True
            objExcelWorkBook = objExcel.Workbooks.Open(fileName, 0, 1)
            objExcelWorkSheet = objExcelWorkBook.Worksheets(1)

            With objExcelWorkSheet

                For i_row = 0 To subDS.Tables("Print").Rows.Count - 1

                    '.ActiveWindow.FreezePanes = False
                    .Range("C3").Value = subDS.Tables("Print").Rows(i_row).Item("trh_date") 'ÇÑ¹·ÕèµÃÇ¨ÊÍº
                    .Range("C4").Value = subDS.Tables("Print").Rows(i_row).Item("Name1") 'ª×èÍÅÙ¡¤éÒ
                    .Range("D2").Value = subDS.Tables("Print").Rows(i_row).Item("trh_no") 'àÅ¢·Õè
                    .Range("C5").Value = subDS.Tables("Print").Rows(i_row).Item("ar_Shp_VA") 'ª×èÍÅÙ¡¤éÒ
                    If IsDBNull(subDS.Tables("Print").Rows(i_row).Item("Dtl_condition")) Or subDS.Tables("Print").Rows(i_row).Item("Dtl_condition") = "" Then
                        .Range("C6").Value = subDS.Tables("Print").Rows(i_row).Item("ar_Shp_VA1") & " " & subDS.Tables("Print").Rows(i_row).Item("ar_Shp_VA2") 'ª×èÍÅÙ¡¤éÒ

                    Else
                        .Range("C6").Value = subDS.Tables("Print").Rows(i_row).Item("Dtl_condition")
                    End If
                    If i_row = 0 Then
                        c = 8
                        i = 1
                    Else
                        c = c + 1
                        i = i + 1
                    End If
                    .Range("B" & c).Value = i
                    .Range("C" & c).Value = subDS.Tables("Print").Rows(i_row).Item("stk_name_1") 'ª×èÍÊÔ¹¤éÒ
                    .Range("D" & c).Value = subDS.Tables("Print").Rows(i_row).Item("dtl_num") '¨Ó¹Ç¹
                Next i_row
                .Range("C29").Value = subDS.Tables("Print").Rows(0).Item("trh_Detail") 'àÅ¢·Õè

            End With
            'myExcel.ActiveSheet.Protect(DrawingObjects:=True, Contents:=True, Scenarios:=True)
            'myExcel = Nothing
            subDA = Nothing
            subDS = Nothing
            objExcel = Nothing
            objExcelWorkBook = Nothing
            objExcelWorkSheet = Nothing
        End If
    End Sub

    Sub AddtoExcel2()

        Dim subDS As DataSet = New DataSet
        Dim subDA As SqlClient.SqlDataAdapter

        Dim fileName As String = ""
        'Dim myExcel As Excel.Application

        Dim objExcel As Microsoft.Office.Interop.Excel.Application
        Dim objExcelWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim objExcelWorkSheet As Microsoft.Office.Interop.Excel.Worksheet

        Dim i_row As Integer = "0"
        Dim c As Integer = 0
        Dim i As Integer = 0


        Call SQLPrint2()

        subDS.Clear()
        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "Print")

        If subDS.Tables("Print").Rows.Count > 0 Then

            fileName = CurDir() & "\deliveryDoc.xlsx"
            objExcel = New Microsoft.Office.Interop.Excel.Application
            objExcel.Visible = True
            objExcelWorkBook = objExcel.Workbooks.Open(fileName)
            objExcelWorkSheet = objExcelWorkBook.Worksheets(1)

            With objExcelWorkSheet

                For i_row = 0 To subDS.Tables("Print").Rows.Count - 1

                    '.ActiveWindow.FreezePanes = False
                    .Range("C3").Value = subDS.Tables("Print").Rows(i_row).Item("trh_date") 'ÇÑ¹·ÕèµÃÇ¨ÊÍº
                    .Range("C4").Value = subDS.Tables("Print").Rows(i_row).Item("Name1") 'ª×èÍÅÙ¡¤éÒ
                    .Range("D2").Value = subDS.Tables("Print").Rows(i_row).Item("trh_no") 'àÅ¢·Õè
                    If i_row = 0 Then
                        c = 8
                        i = 1
                    Else
                        c = c + 1
                        i = i + 1
                    End If
                    .Range("B" & c).Value = i
                    .Range("C" & c).Value = subDS.Tables("Print").Rows(i_row).Item("stk_name_1") 'ª×èÍÊÔ¹¤éÒ
                    .Range("D" & c).Value = subDS.Tables("Print").Rows(i_row).Item("dtl_num") '¨Ó¹Ç¹
                Next i_row
                .Range("C29").Value = subDS.Tables("Print").Rows(0).Item("trh_Detail") 'àÅ¢·Õè

            End With

            'myExcel.ActiveSheet.Protect(DrawingObjects:=True, Contents:=True, Scenarios:=True)
            'myExcel = Nothing

            objExcel = Nothing
            objExcelWorkBook = Nothing
            objExcelWorkSheet = Nothing

        End If
    End Sub
    Sub findStkBase()
        If Dvat = "" Then

            MsgBox("ÂÑ§äÁèä´éàÅ×Í¡¢éÍÁÙÅ VAT â»Ã´µÃÇ¨ÊÍº¡èÍ¹¡ÒÃ´Óà¹Ô¹¡ÒÃã´æ ", MsgBoxStyle.Critical, "á¨é§àµ×Í¹")
            Exit Sub
        Else
            If lbCusName.Text = "" Then

                MsgBox("äÁè¾º¡ÒÃàÅ×Í¡ÅÙ¡¤éÒ â»Ã´µÃÇ¨ÊÍº¢éÍÁÙÅÅÙ¡¤éÒ")
                Exit Sub

            End If
            Me.BackColor = Color.DarkGray
            frmFindStk.ShowDialog()
            Me.BackColor = Color.WhiteSmoke

            If chkSelStk = True Then  '  µÃÇ¨ÊÍºÇèÒÁÕ¡ÒÃàÅ×Í¡ÊÔ¹¤éÒäËÁ

                whCode = lbWHcode.Text
                lbStkCode.Text = SelectCode
                whCode = lbWHcode.Text
                lbProductName.Text = DBtools.getStkName(lbStkCode.Text)
                lbStock.Text = getStock(SelectCode, "110098", whCode)
                'lbWeight.Text = DBtools.getStkWight(lbStkCode.Text)

                If prTools.ChkPrice("B", lbCusID.Text, SelectCode) = True Then
                    txtPrice.Text = prTools.getPrice("B", lbCusID.Text, SelectCode)
                Else
                    If MsgBox("ÃÒ¤Òà´ÔÁ¤×Í " & txtPrice.Text & "ºÒ· µéÍ§¡ÒÃà»ÅÕèÂ¹ÃÒ¤ÒËÃ×ÍäÁè ? ", MsgBoxStyle.YesNo, "á¨é§àµ×Í¹ ") = MsgBoxResult.No Then

                        'txtPrice.Text = 0


                    Else
                        txtPrice.Focus()

                    End If

                End If


                If SelectCode = "" Then
                    MsgBox("â»Ã´àÅ×Í¡ÃÒÂ¡ÒÃÊÔ¹¤éÒÍÕ¡¤ÃÑé§ >< ")

                End If
                If lbStkCode.Text = "" Then

                    MsgBox("¾º¢éÍÁÙÅã¹¡ÃÍº¢éÍÁÙÅ  ¡ÃØ³Ò¡´ 'ÅºÃÒÂ¡ÒÃ' ËÃ×Í 'à¾ÔèÁÃÒÂ¡ÒÃ'  ")

                Else

                End If
                chkSelStk = False
            Else

            End If

        End If


    End Sub

    Private Sub cmbFindStk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFindStk.Click
        '


        Call findStkBase()


    End Sub

    Sub cutOrder(ByVal strNo As String, ByVal intQty As Double)

        txtSQL = "Update TranDataD "
        txtSQL = txtSQL & "Set Dtl_num_2='" & intQty & "'"
        txtSQL = txtSQL & ""


    End Sub

    Sub colorList(ByVal chkCost As Integer)
        'Dim LOrder As ListViewItem
        'If chkEditDoc = True Then

        If chkCost = 0 Then
            If chkProfit = True Then

                LOrder.BackColor = System.Drawing.Color.DarkRed
                LOrder.ForeColor = System.Drawing.Color.White
                LOrder.UseItemStyleForSubItems = True
                chkProfit = False

            Else

                LOrder.BackColor = System.Drawing.Color.Red
                LOrder.ForeColor = System.Drawing.Color.White
                LOrder.UseItemStyleForSubItems = True
                chkProfit = True
            End If
        ElseIf chkCost = 1 Then
            If chkProfit = True Then

                LOrder.BackColor = System.Drawing.Color.DarkGreen
                LOrder.ForeColor = System.Drawing.Color.White
                LOrder.UseItemStyleForSubItems = True
                chkProfit = False

            Else
                LOrder.BackColor = System.Drawing.Color.GreenYellow
                LOrder.ForeColor = System.Drawing.Color.Black
                LOrder.UseItemStyleForSubItems = True
                chkProfit = True
            End If
        Else

            LOrder.BackColor = System.Drawing.Color.Yellow
            LOrder.ForeColor = System.Drawing.Color.Black
            LOrder.UseItemStyleForSubItems = True
            chkProfit = False
        End If




        '    Else
        '        If chkProfit = True Then
        'LOrder.BackColor = System.Drawing.Color.White
        'LOrder.ForeColor = System.Drawing.Color.Black
        'LOrder.UseItemStyleForSubItems = True

        '        Else

        '            lvi.BackColor = System.Drawing.Color.WhiteSmoke
        '            lvi.ForeColor = System.Drawing.Color.Red
        '            lvi.UseItemStyleForSubItems = True

        '        End If




        'End If
    End Sub


    Private Sub cmbDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDel.Click

        'Dim LOrder As ListViewItem
        Dim tempCode As String = ""
        'Dim listData() As String
        Dim tempSum As Integer = 0
        Dim tempweight As Double = 0.0
        Dim iNo As Integer = 0
        Dim i As Integer = 0


        If lbProductName.Text = "" Or txtSaleQty.Text = "" Or txtPrice.Text = "" Or lbCusID.Text = "" Or lbCusID.Text = "ÃËÑÊÅÙ¡¤éÒ" Then
            MsgBox("¡ÃØ³ÒµÃÇ¨ÊÍº¢éÍÁÙÅÍÕ¡¤ÃÑé§¡èÍ¹·Ó¡ÒÃà¾ÔèÁÃÒÂ¡ÒÃ", MsgBoxStyle.Critical = MsgBoxStyle.OkOnly, "á¨é§àµ×Í¹")
            Exit Sub
        End If

        '***************************************************************ÊÓËÃÑºàªç¤ stockÇèÒ¾ÍËÃ×ÍäÁè ¶éÒäÁè¾Í¨ÐäÁèãËé¢ÒÂ *******************************


        If (getProDCode(lbStkCode.Text) = "04") Then   '  µÃÇ¨ÊÍºÇèÒà»ç¹ GMB(04) ËÃ×Í äÁè ¶éÒà»ç¹äÁè¤Ô´ÊµêÍ¡

            tempSum = CInt(txtSaleQty.Text) * CDbl(txtPrice.Text) '¤Ó¹Ç³ÃÒ¤Ò¨ÃÔ§
            'tempweight = CInt(txtSaleQty.Text) * CDbl(lbWeight.Text) '¤Ó¹Ç³¹éÓË¹Ñ¡
            'tempDisTotal = tempSum - Format((tempSum * (CDbl(txtDiscount.Text) / 100)), "0.00") '¤Ó¹Ç³ÃÒ¤Ò·ÕèËÑ¡ÊèÇ¹Å´


            For i = 0 To ListEdit.Items.Count
                iNo = i
            Next

            'If oldCode <> "" Then
            '    listData = New String() {iNo + 1, lbPNo.Text, lbOrder.Text, lbCusName.Text, lbCode.Text, lbProductName.Text, _
            '                             txtSaleQty.Text, txtPrice.Text, Format(CDbl(txtSaleQty.Text) * CDbl(txtPrice.Text), "#,##0.00"), _
            '                             Format(tempweight, "#,##0.000"), txtDetail2.Text, lbCusID.Text, txtNo.Text, dtp01.Value, _
            '                             txtDisc.Text, oldCode, "0", txtSaleQty.Text, Format(tempweight, "#,##0.000"), "D"}
            'Else
            '    listData = New String() {iNo + 1, lbPNo.Text, lbOrder.Text, lbCusName.Text, lbCode.Text, lbProductName.Text, _
            '                             txtSaleQty.Text, txtPrice.Text, Format(CDbl(txtSaleQty.Text) * CDbl(txtPrice.Text), "#,##0.00"), _
            '                             Format(tempweight, "#,##0.000"), txtDetail2.Text, lbCusID.Text, txtNo.Text, dtp01.Value, _
            '                             txtDisc.Text, lbCode.Text, "0", txtSaleQty.Text, Format(tempweight, "#,##0.000"), "D"}
            'End If
            '
            'LOrder = New ListViewItem(listData)
            'ListEdit.Items.Add(LOrder)
            'colorList("D")

            Call sumTotal()


            lbCount.Text = ListEdit.Items.Count


        Else ' else ¢Í§ if ·Õèàªç¤ÇèÒà»ç¹ÇÑÊ´ØàËÅ×Íãªé ËÃ×Í §Ò¹«èÍÁÊÃéÒ§ ËÃ×Íà¡Ã´ºÕËÃ×Í§Ò¹ºÃÔ¡ÒÃËÃ×ÍäÁè

            'If CInt(txtSaleQty.Text) > CInt(lbStock.Text) Then

            '    MsgBox("StockäÁèà¾ÕÂ§¾Íã¹¡ÒÃ¢ÒÂ ·èÒ¹µéÍ§·Ó¡ÒÃâÍ¹ÊÔ¹¤éÒ¨Ò¡¤ÅÑ§Í×è¹ â´Â¡ÒÃ¡´ F2", MsgBoxStyle.OkOnly, "á¨é§àµ×Í¹")
            '    'SelectCode = ""
            '    'txtCusDisc.Text = 0
            '    'tempSum = 0
            '    'lbStock.Text = 0
            '    'txtDetail.Text = ""
            '    'lbWeight.Text = ""
            '    'txtCusVat.Text = 7
            '    'txtDisc.Text = 0.0

            '    Exit Sub

            'Else

            '    tempSum = CInt(txtSaleQty.Text) * CDbl(txtPrice.Text) '¤Ó¹Ç³ÃÒ¤Ò¨ÃÔ§
            '    tempweight = CInt(txtSaleQty.Text) * CDbl(lbWeight.Text) '¤Ó¹Ç³¹éÓË¹Ñ¡
            '    'tempDisTotal = tempSum - Format((tempSum * (CDbl(txtDiscount.Text) / 100)), "0.00") '¤Ó¹Ç³ÃÒ¤Ò·ÕèËÑ¡ÊèÇ¹Å´

            '    For i = 0 To ListEdit.Items.Count
            '        iNo = i
            '    Next
            '    'If oldCode <> "" Then

            '    '    listData = New String() {iNo + 1, lbPNo.Text, lbOrder.Text, lbCusName.Text, lbCode.Text, lbProductName.Text, _
            '    '                             txtSaleQty.Text, txtPrice.Text, Format(CDbl(txtSaleQty.Text) * CDbl(txtPrice.Text), "#,##0.00"), _
            '    '                             Format(tempweight, "#,##0.000"), txtDetail2.Text, lbCusID.Text, txtNo.Text, dtp01.Value, _
            '    '                             txtDisc.Text, oldCode, "0", txtSaleQty.Text, Format(tempweight, "#,##0.000"), "D"}
            '    'Else
            '    '    listData = New String() {iNo + 1, lbPNo.Text, lbOrder.Text, lbCusName.Text, lbCode.Text, lbProductName.Text, _
            '    '                             txtSaleQty.Text, txtPrice.Text, Format(CDbl(txtSaleQty.Text) * CDbl(txtPrice.Text), "#,##0.00"), _
            '    '                             Format(tempweight, "#,##0.000"), txtDetail2.Text, lbCusID.Text, txtNo.Text, dtp01.Value, _
            '    '                             txtDisc.Text, lbCode.Text, "0", txtSaleQty.Text, Format(tempweight, "#,##0.000"), "D"}
            '    'End If
            '    'LOrder = New ListViewItem(listData)
            '    'ListEdit.Items.Add(LOrder)
            '    'colorList(0)
            '    Call sumTotal()

            '    lbCount.Text = ListEdit.Items.Count
            'End If 'if ¢Í§àªç¤ Stock 
        End If
        tempSum = 0
        tempSum = CInt(txtSaleQty.Text) * CDbl(txtPrice.Text) '¤Ó¹Ç³ÃÒ¤Ò¨ÃÔ§
        'tempweight = CInt(txtSaleQty.Text) * CDbl(lbWeight.Text) '¤Ó¹Ç³¹éÓË¹Ñ¡
        'tempDisTotal = tempSum - Format((tempSum * (CDbl(txtDiscount.Text) / 100)), "0.00") '¤Ó¹Ç³ÃÒ¤Ò·ÕèËÑ¡ÊèÇ¹Å´
        Call sumTotal()

        Call txtCLS()
    End Sub



    'Private Sub cboType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = 13 Then
    '        cboGrp1.Focus()
    '    End If
    'End Sub

    'Private Sub cboGrp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = 13 Then
    '        cboColor1.Focus()
    '    End If
    'End Sub

    'Private Sub cboColor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = 13 Then
    '        cboTh.Focus()
    '    End If
    'End Sub

    'Private Sub cboTh_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = 13 Then
    '        cboSize.Focus()
    '    End If
    'End Sub

    'Private Sub cboSize_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = 13 Then
    '        cboPaper.Focus()
    '    End If
    'End Sub

    'Private Sub cboPaper_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = 13 Then
    '        cboGrade.Focus()
    '    End If
    'End Sub

    'Private Sub cboGrade_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = 13 Then
    '        'cboCut.Focus()
    '    End If
    'End Sub

    'Private Sub cboCut_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = 13 Then
    '        cmbCode.Focus()
    '    End If
    'End Sub


    'Sub comboFactor()
    '    Dim da As SqlClient.SqlDataAdapter
    '    Dim ds As DataSet = New DataSet

    '    txtSQL = "Select  Type_Code,Type_Name,Type_Stk_Name "
    '    txtSQL = txtSQL & " From TypeMast "
    '    txtSQL = txtSQL & "Order by Type_Code "

    '    da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
    '    da.Fill(ds, "TypeMast")

    '    If ds.Tables("TypeMast").Rows.Count > 0 Then
    '        With cboType1
    '            .DataSource = ds.Tables("TypeMast")
    '            .DisplayMember = "Type_Name"
    '            .ValueMember = "Type_Code"
    '            .Text = ""
    '        End With
    '    End If
    '    cboType1.SelectedItem = Nothing

    '    txtSQL = "Select  Grp_Code,Grp_Name,Grp_StkName  From GrpMast "
    '    txtSQL = txtSQL & "Order by Grp_code "

    '    da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
    '    da.Fill(ds, "GrpMast")

    '    If ds.Tables("GrpMast").Rows.Count > 0 Then
    '        With cboGrp1
    '            .DataSource = ds.Tables("GrpMast")
    '            .DisplayMember = "Grp_Name"
    '            .ValueMember = "Grp_Code"
    '            .Text = ""
    '        End With
    '    End If
    '    cboGrp1.SelectedItem = Nothing


    '    '¢Í§-ºÍÅ txtSQL = "Select Color_code,Color_Name  from ColorMast "
    '    '"where Color_Code1 +' - ' + Color_Name  = '" & Combo1(0) & "' and color_type = '" & Right(Combo1(11).Text, 2) & "' "

    '    txtSQL = "Select  Color_Code,(color_code1 + '-'+ Color_StkName) as Color_StkName  From ColorMast "
    '    'txtSql = txtSql & " where color_type = '" & cboType.SelectedValue & "'"
    '    txtSQL = txtSQL & "Order by Color_Code "
    '    da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
    '    da.Fill(ds, "ColorMast")

    '    If ds.Tables("ColorMast").Rows.Count > 0 Then
    '        With cboColor1
    '            .DataSource = ds.Tables("ColorMast")
    '            .DisplayMember = "Color_StkName"
    '            .ValueMember = "Color_Code"
    '            .Text = ""
    '        End With
    '    End If
    '    cboColor1.SelectedItem = Nothing


    '    txtSQL = "Select  Th_Name,Th_Code,Th_Th  From ThMast "
    '    txtSQL = txtSQL & "Order by Th_Name "

    '    da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
    '    da.Fill(ds, "ThMast")

    '    If ds.Tables("ThMast").Rows.Count > 0 Then
    '        With cboTh
    '            .DataSource = ds.Tables("ThMast")
    '            .DisplayMember = "Th_Th"
    '            .ValueMember = "Th_Code"
    '            .Text = ""
    '        End With
    '    End If
    '    cboTh.SelectedItem = Nothing

    '    txtSQL = "Select  Size_Name_2,Size_Code  From SizeMast "
    '    txtSQL = txtSQL & "Order by Size_Name_2  "

    '    da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
    '    da.Fill(ds, "SizeMast")

    '    If ds.Tables("SizeMast").Rows.Count > 0 Then
    '        With cboSize
    '            .DataSource = ds.Tables("SizeMast")
    '            .DisplayMember = "Size_Name_2"
    '            .ValueMember = "Size_Code"
    '            .Text = ""
    '        End With
    '    End If
    '    cboSize.SelectedItem = Nothing

    '    txtSQL = "Select  Paper_Name,Paper_Code  From PaperMast "
    '    txtSQL = txtSQL & "Order by Paper_Code"

    '    da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
    '    da.Fill(ds, "PaperMast")

    '    If ds.Tables("PaperMast").Rows.Count > 0 Then
    '        With cboPaper
    '            .DataSource = ds.Tables("paperMast")
    '            .DisplayMember = "Paper_Name"
    '            .ValueMember = "Paper_Code"
    '            .Text = ""
    '        End With
    '    End If
    '    cboPaper.SelectedItem = Nothing

    '    txtSQL = "Select  G_Name,G_Name_2,G_Code  From GMast "
    '    txtSQL = txtSQL & "Order by G_Code"

    '    da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
    '    da.Fill(ds, "GMast")

    '    If ds.Tables("GMast").Rows.Count > 0 Then
    '        With cboGrade
    '            .DataSource = ds.Tables("GMast")
    '            .DisplayMember = "G_Name"
    '            .ValueMember() = "G_Code"
    '            .Text = ""
    '        End With
    '    End If
    '    cboGrade.SelectedItem = Nothing

    '    'txtSQL = "Select  cut_code,cut_Name_2,cut_name  From cutMast "
    '    'txtSQL = txtSQL & "Order by cut_name"

    '    'da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
    '    'da.Fill(ds, "CMast")

    '    'If ds.Tables("CMast").Rows.Count > 0 Then
    '    '    With cboCut
    '    '        .DataSource = ds.Tables("CMast")
    '    '        .DisplayMember = "cut_name"
    '    '        .ValueMember() = "cut_code"
    '    '        .Text = ""
    '    '    End With
    '    'End If
    '    'cboCut.SelectedItem = Nothing
    'End Sub
    'Function autoGenDocID() As String

    '    Dim da As SqlClient.SqlDataAdapter
    '    Dim ds As DataSet = New DataSet

    '    da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
    '    da.Fill(ds, "CMast")

    '    If ds.Tables("CMast").Rows.Count > 0 Then
    '        With cboCut
    '            .DataSource = ds.Tables("CMast")
    '            .DisplayMember = "cut_name"
    '            .ValueMember() = "cut_code"
    '            .Text = ""
    '        End With
    '    End If

    'End Function
    'Sub upDateStock()
    '    If DBtools.getDocNumber(txtNo.Text, "S") = True Then

    'For i = 0 To DS.Tables("DataD").Rows.Count - 1

    '    DataCode = DS.Tables("DataD").Rows(i).Item("dtl_idtrade")
    '    Datanum = DS.Tables("DataD").Rows(i).Item("dtl_num")
    '    DataOrder = DS.Tables("DataD").Rows(i).Item("dtl_con_id")
    '    'If chkUpStock = True Then
    '    '    subDs.Tables("UpStock").Clear()
    '    '    chkUpStock = False
    '    'End If
    '    subDs.Clear()
    '    txtSQL = "Select * "
    '    txtSQL = txtSQL & "From Stkdetl "
    '    txtSQL = txtSQL & "Where dtl_code='" & DataCode & "'"
    '    txtSQL = txtSQL & "And dtl_store='" & lbIDCus.Text & "' "
    '    txtSQL = txtSQL & "And dtl_WH='" & lbWHcode.Text & "' "

    '    subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
    '    subDa.Fill(subDs, "UpStock")
    '    'chkUpStock = True

    '    If subDs.Tables("UpStock").Rows.Count > 0 Then

    '        Iss = subDs.Tables("UpStock").Rows(0).Item("dtl_iss_q1") - DataNum
    '        Bal = subDs.Tables("UpStock").Rows(0).Item("dtl_bal_q1") + DataNum

    '        'WIss = Format(DS.Tables("UpStock").Rows(0).Item("dtl_iss_q2") - IssWeight, "#,##0.00")
    '        'WBal = Format(DS.Tables("UpStock").Rows(0).Item("dtl_bal_q2") + IssWeight, "#,##0.00")
    '        '**************************************************************äÇéÅ´ dtl_or_q1 ¡Ã³Õ·ÕèÁÕ¡ÒÃÅºÃÒÂ¡ÒÃ·Õè order ***********************************
    '        If DataOrder = "" Or DataOrder = "äÁèÁÕOrder" Then

    '        Else
    '            Or_Q1 = subDs.Tables("UpStock").Rows(0).Item("dtl_or_q1") + DataNum
    '        End If
    '        '******************************************************************************************************

    '        txtSQL = "Update Stkdetl "
    '        txtSQL = txtSQL & "Set "
    '        txtSQL = txtSQL & "dtl_iss_q1='" & Iss & "',"
    '        txtSQL = txtSQL & "dtl_bal_q1='" & Bal & "' "

    '        'txtSQL = txtSQL & "dtl_iss_q2='" & WIss & "',"
    '        'txtSQL = txtSQL & "dtl_bal_q2='" & WBal & "'"

    '        '******************************************************************************************************
    '        If DataOrder = "" Or DataOrder = "äÁèÁÕOrder" Then
    '        Else
    '            txtSQL = txtSQL & ",dtl_or_q1='" & Or_Q1 & "' "
    '        End If
    '        '******************************************************************************************************
    '        txtSQL = txtSQL & "Where dtl_code='" & DataCode & "' "
    '        txtSQL = txtSQL & "And dtl_store='" & lbIDCus.Text & "' "
    '        txtSQL = txtSQL & "And dtl_WH='" & lbWHcode.Text & "' "
    '        Try
    '            With subCom
    '                .CommandType = CommandType.Text
    '                .CommandText = txtSQL
    '                .Connection = Conn
    '                .ExecuteNonQuery()
    '            End With
    '        Catch errprocess As Exception
    '            MessageBox.Show("äÁèÊÒÁÒÃ¶à¾ÔèÁ¢éÍÁÙÅä´éà¹×èÍ§¨Ò¡ " & errprocess.Message, "¢éÍ¼Ô´¾ÅÒ´", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            Exit Sub
    '        End Try
    '    End If
    'Next
    'DataCode = ""
    'Datanum = 0
    'DataOrder = ""
    'End If

    '*********************************************************¨º¡ÒÃÅ´¨Ó¹Ç¹ã¹stock àÁ×èÍÁÕ¡ÒÃÅº¢éÍÁÙÅ *********************************
    'End Sub

    'Sub comboSale()
    '    Dim DS As DataSet = New DataSet
    '    Dim DA As SqlClient.SqlDataAdapter
    '    Dim chkSale As Boolean


    '    txtSQL = "Select  * "
    '    txtSQL = txtSQL & " From salesman"
    '    txtSQL = txtSQL & " where  sl_id= 'SL03' or sl_id='SL11' order by sl_id "
    '    If chkSale = True Then
    '        DS.Tables("Sale").Clear()
    '        chkSale = False
    '    End If
    '    DA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
    '    DA.Fill(DS, "Sale")
    '    chkSale = True

    '    If DS.Tables("Sale").Rows.Count > 0 Then
    '        With cboSale
    '            .DataSource = DS.Tables("Sale")
    '            .DisplayMember = "SL_NAME"
    '            .ValueMember = "SL_ID"

    '        End With
    '    End If
    'End Sub

    Sub calPrice()
        Dim tempDisc As Double = 0
        Dim tempTotal As Double = 0
        tempTotal = txtSaleQty.Text * txtPrice.Text

        If Microsoft.VisualBasic.Right(txtDisc.Text, 1) = "%" Then
            tempDisc = CDbl(Microsoft.VisualBasic.Left(txtDisc.Text, Len(txtDisc.Text) - 1))
            tempDisc = (tempTotal * tempDisc / 100)

        ElseIf Microsoft.VisualBasic.Right(txtDisc.Text, 1) = "B" Then
            tempDisc = CDbl(Microsoft.VisualBasic.Left(txtDisc.Text, Len(txtDisc.Text) - 1))
        End If

        txtTotal.Text = Format(tempTotal - tempDisc, "#,###.00")
        txtDisc.Focus()

    End Sub
    Private Sub txtPrice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPrice.KeyDown



        If IsNumeric(txtSaleQty.Text) = False Then
            MsgBox("¢éÍÁÙÅ¨Ó¹Ç¹ÊÔ¹¤éÒäÁè¶Ù¡µéÍ§ â»Ã´µÃÇ¨ÊÍº  ", MsgBoxStyle.Critical, "á¨é§àµ×Í¹")
            Exit Sub
        End If


        If e.KeyCode = Keys.Enter Then
            Call calPrice()

        End If

    End Sub


    Private Sub txtDisc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDisc.KeyDown
        Dim tempDisc As Double = 0
        Dim tempTotal As Double = 0

        tempTotal = txtSaleQty.Text * txtPrice.Text
        If e.KeyCode = Keys.Enter Then

            If Microsoft.VisualBasic.Right(txtDisc.Text, 1) = "%" Then
                tempDisc = CDbl(Microsoft.VisualBasic.Left(txtDisc.Text, Len(txtDisc.Text) - 1))
                tempDisc = (tempTotal * tempDisc / 100)

            ElseIf Microsoft.VisualBasic.Right(txtDisc.Text, 1) = "b" Then
                tempDisc = CDbl(Microsoft.VisualBasic.Left(txtDisc.Text, Len(txtDisc.Text) - 1))
            Else
                If IsNumeric(txtDisc.Text) Then
                    tempDisc = CDbl(txtDisc.Text)
                Else
                    tempDisc = 0
                End If


            End If

            txtTotal.Text = Format(tempTotal - tempDisc, "#,###.00")
            txtTotal.Focus()
        End If
    End Sub

    Private Sub txtDisc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDisc.TextChanged

    End Sub

    Private Sub txtTotal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTotal.KeyDown
        If e.KeyCode = Keys.Enter Then
            llbAdd.Focus()
        End If

    End Sub


    Private Sub ListEdit_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListEdit.DoubleClick

        Dim i As Integer
        editChk = False
        editStkCode = ""
        editStock = 0
        editQty = 0
        Dim strCondition As String = ""

        'Dim LEdit As ListViewItem
        For i = 0 To ListEdit.SelectedItems.Count - 1

            editChk = True

            LEdit = ListEdit.SelectedItems(i)
            Ditem = ListEdit.Items(LEdit.Index).SubItems(0).Text 'ÅÓ´Ñº
            DPNo = ListEdit.Items(LEdit.Index).SubItems(1).Text 'àÅ¢·ÕèPickking

            DOrder = ListEdit.Items(LEdit.Index).SubItems(2).Text 'àÅ¢·ÕèOrder

            Dpro = ListEdit.Items(LEdit.Index).SubItems(4).Text 'ÃËÑÊÊÔ¹¤éÒ
            Dproduct = ListEdit.Items(LEdit.Index).SubItems(5).Text 'ª×èÍÊÔ¹¤éÒ
            editStkCode = Dpro
            '=======================================================

            Dnum = ListEdit.Items(LEdit.Index).SubItems(6).Text '¨Ó¹Ç¹
            editQty = Dnum

            'lbStock.Text = Dnum
            editStock = getStock(editStkCode, "110098", lbWHcode.Text)
            Dprice = ListEdit.Items(LEdit.Index).SubItems(7).Text 'ÃÒ¤Ò
            DDisc = ListEdit.Items(LEdit.Index).SubItems(8).Text   ' ÊèÇ¹Å´  17

            '========================================================
            Dweight = ListEdit.Items(LEdit.Index).SubItems(13).Text '¹¹.
            DDetail2 = ListEdit.Items(LEdit.Index).SubItems(14).Text 'ËÁÒÂàËµØ
            Dcus = ListEdit.Items(LEdit.Index).SubItems(15).Text 'ÃËÑÊÅÙ¡¤éÒ
            Dno = ListEdit.Items(LEdit.Index).SubItems(16).Text 'àÅ¢·Õè---ãºàºÔ¡
            Ddate = ListEdit.Items(LEdit.Index).SubItems(17).Text 'ÇÑ¹·Õè
            'DDisc = ListEdit.Items(LEdit.Index).SubItems(17).Text   ' ÊèÇ¹Å´  17

            oldCode = ListEdit.Items(LEdit.Index).SubItems(18).Text 'ÃËÑÊÊÔ¹¤éÒ  Same Code
            lbOldCode.Text = ListEdit.Items(LEdit.Index).SubItems(18).Text 'ÃËÑÊÊÔ¹¤éÒ  à¡çºà¾×èÍàªç¤ÇèÒà»ç¹¡ÒÃá¡éä¢ ËÃ×Í à»ÅÕèÂ¹ÊÔ¹¤éÒãËÁè
            lbTypeP.Text = ListEdit.Items(LEdit.Index).SubItems(24).Text 'DPNo
            txtTypeP.Text = ListEdit.Items(LEdit.Index).SubItems(24).Text
            lbRevDocNo.Text = ListEdit.Items(LEdit.Index).SubItems(23).Text
            txtCondition.Text = ListEdit.Items(LEdit.Index).SubItems(25).Text
            'ListEdit.Items.Remove(LOrder)            
            LOrder = ListEdit.SelectedItems(i)
            ListEdit.Items.Remove(LOrder)

            'ListEdit.Items.Remove(LOrder.SubItems.Item(LEdit.Index))
        Next

        Dim tempDisc As Double = 0

        lbProductName.Text = Dproduct
        lbOrder.Text = DOrder
        lbStkCode.Text = Dpro
        txtSaleQty.Text = Dnum
        txtPrice.Text = Dprice
        lbStock.Text = getStock(editStkCode, "110098", lbWHcode.Text)
        'lbWeight.Text = DBtools.getStkWight(lbStkCode.Text)



        txtDetail2.Text = DDetail2

        If DDisc = "" Then
        Else
            txtDisc.Text = DDisc
        End If
        If Microsoft.VisualBasic.Right(txtDisc.Text, 1) = "b" Or Microsoft.VisualBasic.Right(txtDisc.Text, 1) = "B" Then
            tempDisc = CDbl(Microsoft.VisualBasic.Left(txtDisc.Text, Len(txtDisc.Text) - 1))

        ElseIf Microsoft.VisualBasic.Right(txtDisc.Text, 1) = "%" Then
            tempDisc = CDbl(Microsoft.VisualBasic.Left(txtDisc.Text, Len(txtDisc.Text) - 1))
            tempDisc = (CDbl(txtPrice.Text) * CDbl(tempDisc)) / 100

        ElseIf txtDisc.Text = 0 Or txtDisc.Text = "" Then
            tempDisc = 0
        Else
            If IsNumeric(txtDisc.Text) Then

                tempDisc = txtDisc.Text
            Else
                tempDisc = 0
            End If
        End If

        txtTotal.Text = (txtSaleQty.Text * txtPrice.Text) - tempDisc
        'lbStock.Text = DBtools.getStock(lbCode.Text, lbCusID.Text, lbWHcode.Text)


        'frmEdit = New Edit
        'frmEdit.ShowDialog()
        If Dno <> "" Then

            'dtp01.Value = Convert.ToDateTime(Ddate)
            txtNo.Text = Dno
            'lbIDCus.Text = Dcus


            txtSQL = "  SELECT     *"
            txtSQL = txtSQL & " FROM  trandatah "
            txtSQL = txtSQL & " Where  "
            txtSQL = txtSQL & "(trh_no='" & Dno & "') And trh_type='S' "
            txtSQL = txtSQL & "And trh_wh='" & lbWHcode.Text & "' "

            If chkHead = True Then
                subDs.Tables("Head").Clear()
                chkHead = False
            End If

            subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDa.Fill(subDs, "Head")
            chkHead = True

            If subDs.Tables("Head").Rows.Count > 0 Then
                txtCusDisc.Text = subDs.Tables("Head").Rows(0).Item("trh_disc")
                txtCusVat.Text = subDs.Tables("Head").Rows(0).Item("trh_bill")
                txtCredit.Text = subDs.Tables("Head").Rows(0).Item("trh_term")
                txtSaleMan.Text = subDs.Tables("Head").Rows(0).Item("trh_sale")
            End If
            subDs.Clear()

            txtSQL = "   SELECT     BaseMast.Stk_Code, BaseMast.Type_Code, TypeMast.Type_Name, "
            txtSQL = txtSQL & "     BaseMast.Grp_Code, GrpMast.Grp_Name, BaseMast.Th_Code, ThMast.Th_Name, "
            txtSQL = txtSQL & "     BaseMast.Size_Code, SizeMast.Size_Name, BaseMast.Paper_Code, "
            txtSQL = txtSQL & "      PaperMast.Paper_Name, BaseMast.G_Code, gMast.G_Name,colormast.color_code,colormast.color_name"

            txtSQL = txtSQL & "     FROM BaseMast LEFT OUTER JOIN"
            txtSQL = txtSQL & "     GrpMast ON BaseMast.Grp_Code = GrpMast.Grp_Code LEFT OUTER JOIN"
            txtSQL = txtSQL & "     TypeMast ON BaseMast.Type_Code = TypeMast.Type_Code LEFT OUTER JOIN"
            txtSQL = txtSQL & "     gMast ON BaseMast.G_Code = gMast.G_Code LEFT OUTER JOIN"
            txtSQL = txtSQL & "     PaperMast ON BaseMast.Paper_Code = PaperMast.Paper_Code LEFT OUTER JOIN"
            txtSQL = txtSQL & "     ThMast ON BaseMast.Th_Code = ThMast.Th_Code LEFT OUTER JOIN"
            txtSQL = txtSQL & "     ColorMast ON BaseMast.Color_Code = ColorMast.Color_Code LEFT OUTER JOIN"
            txtSQL = txtSQL & "     SizeMast ON BaseMast.Size_Code = SizeMast.Size_Code"

            txtSQL = txtSQL & "     Where basemast.stk_code='" & Dpro & "'"

            'If chkDetail = True Then
            '    chkDetail = False
            '    subDs.Tables("Detail").Clear()
            'End If

            subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDa.Fill(subDs, "Detail")

            lbPONo.Text = DPNo
            lbOrder.Text = DOrder
            'lbWeight.Text = Dweight / Dnum
            txtSaleQty.Text = Dnum
            lbStkCode.Text = Dpro
            lbProductName.Text = Dproduct
            txtPrice.Text = Dprice
            txtDetail2.Text = DDetail2
            txtDisc.Text = DDisc

            'ListOrder.Items(LEdit.Index).SubItems(8).Text = Dprice * Dnum
            Call sumTotal()

        Else

        End If
    End Sub

    'Private Sub llbEdit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbEdit.LinkClicked
    '    'Dim LOrder As ListViewItem
    '    Dim tempCode As String = ""
    '    'Dim listData() As String
    '    Dim tempSum As Double = 0.0
    '    Dim tempweight As Double = 0.0
    '    Dim iNo As Integer = 0
    '    Dim i As Integer = 0
    '    Try
    '        MsgBox("¡´á¡éä¢ÃÒÂ¡ÒÃ")
    '        tempSum = CInt(txtSaleQty.Text) * CDbl(txtPrice.Text) '¤Ó¹Ç³ÃÒ¤Ò¨ÃÔ§
    '        ' tempweight = CInt(txtSaleQty.Text) * CDbl(lbWeight.Text) '¤Ó¹Ç³¹éÓË¹Ñ¡

    '        ListEdit.Items(LEdit.Index).SubItems(13).Text = dtp01.Value
    '        ListEdit.Items(LEdit.Index).SubItems(12).Text = txtNo.Text
    '        ListEdit.Items(LEdit.Index).SubItems(11).Text = lbCusID.Text
    '        ListEdit.Items(LEdit.Index).SubItems(9).Text = Format(tempweight, "#,##0.000")
    '        ListEdit.Items(LEdit.Index).SubItems(6).Text = txtSaleQty.Text
    '        ListEdit.Items(LEdit.Index).SubItems(4).Text = lbStkCode.Text
    '        ListEdit.Items(LEdit.Index).SubItems(5).Text = lbProductName.Text
    '        ListEdit.Items(LEdit.Index).SubItems(7).Text = txtPrice.Text
    '        ListEdit.Items(LEdit.Index).SubItems(8).Text = Format(tempSum, "#,##0.00")
    '        ListEdit.Items(LEdit.Index).SubItems(1).Text = lbPONo.Text
    '        ListEdit.Items(LEdit.Index).SubItems(10).Text = txtDetail2.Text
    '        ListEdit.Items(LEdit.Index).SubItems(14).Text = txtDisc.Text
    '        'ListEdit.Items(LEdit.Index).SubItems(15).Text = cboCut.SelectedValue
    '        ListEdit.Items(LEdit.Index).SubItems(16).Text = oldCode
    '        ListEdit.Items(LEdit.Index).SubItems(17).Text = 1 'à¡çºà©¾ÒÐÃÒÂ¡ÒÃ·Õèá¡éä¢
    '        ListEdit.Items(LEdit.Index).SubItems(3).Text = lbCusName.Text  'à¡çºà©¾ÒÐÃÒÂ¡ÒÃ·Õèá¡éä¢

    '        Call sumTotal()


    '        Dno = ""
    '        Ddate = ""
    '        Dpro = ""
    '        Dproduct = ""
    '        Dnum = 0
    '        Dcus = ""
    '        Dcusname = ""
    '        Dprice = 0
    '        DDetail2 = ""


    '        lbCount.Text = ListEdit.Items.Count

    '        Call runGetUserEdit()

    '    Catch errprocess As Exception
    '        'MessageBox.Show("äÁèÊÒÁÒÃ¶Åº¢éÍÁÙÅä´éà¹×èÍ§¨Ò¡ " & errprocess.Message, "¢éÍ¼Ô´¾ÅÒ´", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Exit Sub
    '    End Try

    '    SelectCode = ""
    '    lbOrder.Text = ""
    '    lbProductName.Text = ""
    '    txtSaleQty.Text = ""
    '    tempSum = 0
    '    tempweight = 0.0
    '    txtPrice.Text = ""
    '    lbStkCode.Text = ""
    '    txtDetail.Text = ""
    '    'lbWeight.Text = ""
    '    txtCusVat.Text = 7
    '    lbStock.Text = 0

    'End Sub

    Private Sub cmbRecal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRecal.Click
        Call sumTotal()
    End Sub


    Private Sub cmbPrList_Click(sender As Object, e As EventArgs) Handles cmbPrList.Click

        Dim frmPriceList As New frmPriceList
        'selectcode
        'MsgBox(SelectCode)

        frmPriceList.ShowDialog()
        If SelectPrice = 0 Then
        Else

            txtPrice.Text = SelectPrice
            txtDisc.Text = SelectDisc

        End If


    End Sub

    Sub showArData(CusCode As String)
        Dim subDA As New SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        Dim cusCode0 As String = Trim(lbCusID.Text)

        txtSQL = "Select * "
        txtSQL = txtSQL & "From ArFile "

        txtSQL = txtSQL & "WHERE ArFile.AR_Cus_ID= '" & CusCode & "' "
        txtSQL = txtSQL & "And (Ar_Type='AR') "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "ARList")

        If subDS.Tables("ARList").Rows.Count > 0 Then
            With subDS.Tables("ARList")

                If IsDBNull(.Rows(0).Item("Ar_Tax_Code")) Then

                    lbTaxID.Text = ""
                Else
                    lbTaxID.Text = .Rows(0).Item("Ar_Tax_Code") 'DBtools.getCusTaxCode(selCusiD)
                End If
                lbCusName.Text = .Rows(0).Item("Ar_Name")
                If Trim(txtSaleMan.Text) = "" Or (cusCode0 <> CusCode) Then

                    txtSaleMan.Text = .Rows(0).Item("Ar_Sales") 'DBtools.getSalesCode(CusCode)
                    lbSaleName.Text = DBtools.getSaleName(txtSaleMan.Text)
                    txtCredit.Text = .Rows(0).Item("Ar_Term") 'DBtools.getCusLimit(lbCusID.Text)

                Else
                    MsgBox("¾º¢éÍÁÙÅ ¾¹Ñ§§Ò¹¢ÒÂ ÁÕ¡ÒÃàÅ×Í¡äÇéáÅéÇâ»Ã´µÃÇ¨ÊÍºÍÕ¡¤ÃÑé§ !", MsgBoxStyle.Critical, "á¨é§àµ×Í¹")

                End If



                txtCusDisc.Text = .Rows(0).Item("AR_DISC") 'DBtools.getArDisc(lbCusID.Text)

                lbCreLimit.Text = .Rows(0).Item("Ar_Cre_Lim") 'Format(CusLimit, "#,##0.00")

                lbAddr1.Text = .Rows(0).Item("Ar_Addr")
                lbAddr2.Text = .Rows(0).Item("Ar_Addr_1") 'DBtools.getArAddr2(lbCusID.Text)
                lbAddr3.Text = .Rows(0).Item("Ar_Addr_2") 'DBtools.getArAddr3(lbCusID.Text)

                txtCusVat.Text = .Rows(0).Item("Ar_VAT") 'DBtools.getArVat(lbCusID.Text)

            End With

            chkArData = True

        End If

    End Sub
    Sub ShowSelRev()

        selCusiD = lbCusID.Text
        frmPost.ShowDialog()
        If SelectCode2 = "" Then
            Exit Sub

        End If
        '===========  ÊèÇ¹ÅÙ¡¤éÒ  =======================
        If chkArData = False Then

            If selCusiD = "" Then

            Else
                lbCusID.Text = selCusiD
                lbCusName.Text = selCusName
                Call showArData(selCusiD)
            End If

        End If

        '===========  ÊèÇ¹àÍ¡ÊÒÃ =======================
        lbRevDocNo.Text = SelectRevNo2
        lbTypeP.Text = SelectTypeP_No2

        '===========  ÊèÇ¹ÊÔ¹¤éÒ  =======================
        lbOrder.Text = SelectNo2

        lbStkCode.Text = SelectCode2
        SelectCode = lbStkCode.Text
        lbOldCode.Text = SelectCode2
        lbPONo.Text = getDocPO(SelectNo2, SelectCode2)
        lbProductName.Text = getStkName(SelectCode2)
        'lbWeight.Text = DBtools.getStkWight(SelectCode2)
        lbStock.Text = getStock(SelectCode2, "110098", "01")
        txtPrice.Text = SelectPrice2
        txtDisc.Text = getDiscProd(SelectNo2, SelectCode2)
        txtSaleQty.Text = SelectNum2    '  ¨Ó¹Ç¹àºÔ¡  ´Ö§ÁÒ¨Ò¡¢éÍÁÙÅãºàºÔ¡·ÕèàÅ×Í¡
        txtDetail2.Text = getOrComment(lbOrder.Text, lbStkCode.Text)
        txtCondition.Text = selectCondition
        'If getTypeVATbyT(SelectRevNo2) = "V" Then

        '    cboTypeDoc.SelectedValue = "V"

        'ElseIf getTypeVATbyT(SelectRevNo2) = "N" Then

        '    cboTypeDoc.SelectedValue = "N"

        'ElseIf getTypeVATbyT(SelectRevNo2) = "X" Then
        '    cboTypeDoc.SelectedValue = "X"
        'ElseIf getTypeVATbyT(SelectRevNo2) = "M" Then
        '    cboTypeDoc.SelectedValue = "M"
        'ElseIf getTypeVATbyT(SelectRevNo2) = "B" Then
        '    cboTypeDoc.SelectedValue = "B"
        'ElseIf getTypeVATbyT(SelectRevNo2) = "P" Then
        '    cboTypeDoc.SelectedValue = "P"


        'End If
        Dim typeDoc As String = getTypeVATbyT(SelectRevNo2)

        If ListEdit.Items.Count <= 0 Then

            cboTypeDoc.SelectedValue = typeDoc ' getTypeVATbyT(SelectRevNo2)

            Exit Sub
        End If
        If typeDoc <> cboTypeDoc.SelectedValue Then
            MsgBox("¢éÍÁÙÅ»ÃÐàÀ·àÍ¡ÊÒÃ·ÕèàÅ×Í¡ äÁèµÃ§¡Ñº¢éÍÁÙÅ¡èÍ¹Ë¹éÒ â»Ã´µÃÇ¨ÊÍº ", MsgBoxStyle.Critical, "á¨é§àµ×Í¹")
        End If
    End Sub

    Private Sub cmbSelRev_Click(sender As Object, e As EventArgs) Handles cmbSelRev.Click

        Call ShowSelRev()

        'selCusiD = lbCusID.Text
        'frmPost.ShowDialog()
        ''===========  ÊèÇ¹ÅÙ¡¤éÒ  =======================
        'If chkArData = False Then

        '    If selCusiD = "" Then

        '    Else
        '        lbCusID.Text = selCusiD
        '        lbCusName.Text = selCusName
        '        Call showArData(selCusiD)
        '    End If

        'End If

        ''===========  ÊèÇ¹àÍ¡ÊÒÃ =======================
        'lbRevDocNo.Text = SelectRevNo2
        'lbTypeP.Text = SelectTypeP_No2

        ''===========  ÊèÇ¹ÊÔ¹¤éÒ  =======================
        'lbOrder.Text = SelectNo2

        'lbStkCode.Text = SelectCode2
        'SelectCode = lbStkCode.Text
        'lbOldCode.Text = SelectCode2
        'lbPONo.Text = getDocPO(SelectNo2, SelectCode2)
        'lbProductName.Text = getStkName(SelectCode2)
        'lbWeight.Text = DBtools.getStkWight(SelectCode2)
        'lbStock.Text = getStock(SelectCode2, "110098", "01")
        'txtPrice.Text = SelectPrice2
        'txtDisc.Text = getDiscProd(SelectNo2, SelectCode2)
        'txtSaleQty.Text = SelectNum2    '  ¨Ó¹Ç¹àºÔ¡  ´Ö§ÁÒ¨Ò¡¢éÍÁÙÅãºàºÔ¡·ÕèàÅ×Í¡
        'txtDetail2.Text = getOrComment(lbOrder.Text, lbStkCode.Text)

        'If getTypeVATbyT(SelectRevNo2) = "V" Then

        '    cboTypeDoc.Text = "V"

        'Else
        '    cboTypeDoc.Text = "N"
        'End If
    End Sub


    Private Sub lbTypeP_TextChanged(sender As Object, e As EventArgs) Handles lbTypeP.TextChanged

        txtTypeP.Text = lbTypeP.Text

    End Sub


    Private Sub lbCusName_Click(sender As Object, e As EventArgs) Handles lbCusName.Click

    End Sub

    Private Sub txtCredit_TextChanged(sender As Object, e As EventArgs) Handles txtCredit.TextChanged

    End Sub

    Private Sub ListEdit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListEdit.SelectedIndexChanged

    End Sub

    Private Sub cmbPrint1_Click(sender As Object, e As EventArgs) Handles cmbPrint1.Click
        'Dim frmEditNo As New frmEditNo
        'Dvat = cboTypeDoc.SelectedValue
        'SelectDate = dtp01.Value
        'EditNo = txtNo.Text

        ''Call sumTotal()

        'If chkDataItem() = False Then Exit Sub


        'If DBtools.getDocNumber(txtNo.Text, docType) = True Then

        '    Call runPrint()
        '    'If MsgBox("àÍ¡ÊÒÃàÅ¢·Õè  **** " & txtNo.Text & " **** ÁÕ¢éÍÁÙÅà´ÔÁÍÂÙè  µéÍ§¡ÒÃºÑ¹·Ö¡¡ÒÃá¡éä¢ ", MsgBoxStyle.YesNo, "á¨é§àµ×Í¹ !") = MsgBoxResult.Yes Then
        '    '    EditNo = txtNo.Text
        '    '    'Call mainSave()

        '    'Else
        '    '    MsgBox("àÍ¡ÊÒÃÂÑ§äÁè¶Ù¡ºÑ¹·Ö¡  µÃÇ¨ÊÍºÍÕ¡¤ÃÑé§")
        '    'End If
        'Else

        '    MsgBox("àÍ¡ÊÒÃÂÑ§äÁè¶Ù¡ºÑ¹·Ö¡  µÃÇ¨ÊÍºÍÕ¡¤ÃÑé§")

        'End If

        If DBtools.getDocNumber(txtNo.Text, docType) = True Then

            Dim frmPrint As New frmPrint
            frmPrint.ShowDialog()
            ClearAll()
            Me.Close()

        Else

            MsgBox("àÍ¡ÊÒÃÂÑ§ºÑ¹·Ö¡ â»Ã´µÃÇ¨ÊÍºÍÕ¡¤ÃÑé§  ", MsgBoxStyle.Critical, "á¨é§àµ×Í¹")
            'Me.Close()

        End If

    End Sub

End Class
