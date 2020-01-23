<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchAmphoe
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbExit = New System.Windows.Forms.Button()
        Me.lbCode = New System.Windows.Forms.Label()
        Me.cmbSelect = New System.Windows.Forms.Button()
        Me.lbName = New System.Windows.Forms.Label()
        Me.dbGrid = New System.Windows.Forms.DataGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbCountryCode = New System.Windows.Forms.Label()
        Me.lbCountryName = New System.Windows.Forms.Label()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFindStr = New System.Windows.Forms.TextBox()
        Me.lsvAddrCus = New System.Windows.Forms.ListView()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dbGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbExit)
        Me.GroupBox2.Location = New System.Drawing.Point(480, 374)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(488, 48)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'cmbExit
        '
        Me.cmbExit.BackColor = System.Drawing.Color.LightSkyBlue
        Me.cmbExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbExit.ForeColor = System.Drawing.Color.Navy
        Me.cmbExit.Location = New System.Drawing.Point(5, 16)
        Me.cmbExit.Name = "cmbExit"
        Me.cmbExit.Size = New System.Drawing.Size(464, 24)
        Me.cmbExit.TabIndex = 22
        Me.cmbExit.Text = "Exit"
        Me.cmbExit.UseVisualStyleBackColor = False
        '
        'lbCode
        '
        Me.lbCode.BackColor = System.Drawing.Color.Green
        Me.lbCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCode.ForeColor = System.Drawing.Color.White
        Me.lbCode.Location = New System.Drawing.Point(534, 312)
        Me.lbCode.Name = "lbCode"
        Me.lbCode.Size = New System.Drawing.Size(51, 33)
        Me.lbCode.TabIndex = 35
        '
        'cmbSelect
        '
        Me.cmbSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbSelect.ForeColor = System.Drawing.Color.Black
        Me.cmbSelect.Location = New System.Drawing.Point(900, 312)
        Me.cmbSelect.Name = "cmbSelect"
        Me.cmbSelect.Size = New System.Drawing.Size(64, 33)
        Me.cmbSelect.TabIndex = 31
        Me.cmbSelect.Text = "เลือก"
        Me.cmbSelect.UseVisualStyleBackColor = False
        '
        'lbName
        '
        Me.lbName.BackColor = System.Drawing.Color.Green
        Me.lbName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbName.ForeColor = System.Drawing.Color.White
        Me.lbName.Location = New System.Drawing.Point(582, 312)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(309, 33)
        Me.lbName.TabIndex = 30
        '
        'dbGrid
        '
        Me.dbGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dbGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dbGrid.CaptionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dbGrid.CaptionForeColor = System.Drawing.Color.White
        Me.dbGrid.CaptionText = "รายละเอียด"
        Me.dbGrid.DataMember = ""
        Me.dbGrid.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dbGrid.ForeColor = System.Drawing.Color.Black
        Me.dbGrid.HeaderFont = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dbGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbGrid.Location = New System.Drawing.Point(481, 3)
        Me.dbGrid.Name = "dbGrid"
        Me.dbGrid.PreferredColumnWidth = 300
        Me.dbGrid.ReadOnly = True
        Me.dbGrid.Size = New System.Drawing.Size(483, 262)
        Me.dbGrid.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(483, 326)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "อำเภอ"
        '
        'lbCountryCode
        '
        Me.lbCountryCode.BackColor = System.Drawing.Color.Green
        Me.lbCountryCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCountryCode.ForeColor = System.Drawing.Color.White
        Me.lbCountryCode.Location = New System.Drawing.Point(534, 347)
        Me.lbCountryCode.Name = "lbCountryCode"
        Me.lbCountryCode.Size = New System.Drawing.Size(51, 33)
        Me.lbCountryCode.TabIndex = 37
        '
        'lbCountryName
        '
        Me.lbCountryName.BackColor = System.Drawing.Color.Green
        Me.lbCountryName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCountryName.ForeColor = System.Drawing.Color.White
        Me.lbCountryName.Location = New System.Drawing.Point(582, 347)
        Me.lbCountryName.Name = "lbCountryName"
        Me.lbCountryName.Size = New System.Drawing.Size(309, 33)
        Me.lbCountryName.TabIndex = 36
        '
        'cmdFind
        '
        Me.cmdFind.BackColor = System.Drawing.Color.Yellow
        Me.cmdFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdFind.ForeColor = System.Drawing.Color.Black
        Me.cmdFind.Location = New System.Drawing.Point(900, 273)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(64, 33)
        Me.cmdFind.TabIndex = 39
        Me.cmdFind.Text = "ค้นหา"
        Me.cmdFind.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(483, 290)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "ค้นหา"
        '
        'txtFindStr
        '
        Me.txtFindStr.BackColor = System.Drawing.Color.PaleTurquoise
        Me.txtFindStr.Location = New System.Drawing.Point(534, 277)
        Me.txtFindStr.Name = "txtFindStr"
        Me.txtFindStr.Size = New System.Drawing.Size(357, 27)
        Me.txtFindStr.TabIndex = 41
        '
        'lsvAddrCus
        '
        Me.lsvAddrCus.FullRowSelect = True
        Me.lsvAddrCus.Location = New System.Drawing.Point(12, 3)
        Me.lsvAddrCus.Name = "lsvAddrCus"
        Me.lsvAddrCus.Size = New System.Drawing.Size(463, 262)
        Me.lsvAddrCus.TabIndex = 42
        Me.lsvAddrCus.UseCompatibleStateImageBehavior = False
        '
        'frmSearchAmphoe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 436)
        Me.ControlBox = False
        Me.Controls.Add(Me.lsvAddrCus)
        Me.Controls.Add(Me.txtFindStr)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.lbCountryCode)
        Me.Controls.Add(Me.lbCountryName)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lbCode)
        Me.Controls.Add(Me.cmbSelect)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.dbGrid)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSearchAmphoe"
        Me.Text = "frmFindAmphoe"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dbGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbExit As System.Windows.Forms.Button
    Friend WithEvents lbCode As System.Windows.Forms.Label
    Friend WithEvents cmbSelect As System.Windows.Forms.Button
    Friend WithEvents lbName As System.Windows.Forms.Label
    Friend WithEvents dbGrid As System.Windows.Forms.DataGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbCountryCode As System.Windows.Forms.Label
    Friend WithEvents lbCountryName As System.Windows.Forms.Label
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFindStr As System.Windows.Forms.TextBox
    Friend WithEvents lsvAddrCus As System.Windows.Forms.ListView
End Class
