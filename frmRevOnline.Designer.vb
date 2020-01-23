<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRevOnline
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
        Me.lsvRev = New System.Windows.Forms.ListView()
        Me.txtDate01 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCancel = New System.Windows.Forms.Button()
        Me.cmbRun = New System.Windows.Forms.Button()
        Me.cmbSelect = New System.Windows.Forms.Button()
        Me.chkCus = New System.Windows.Forms.CheckBox()
        Me.lbCusName = New System.Windows.Forms.Label()
        Me.lbStkName = New System.Windows.Forms.Label()
        Me.lbDocTypeP = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkRev = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lsvRev
        '
        Me.lsvRev.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lsvRev.FullRowSelect = True
        Me.lsvRev.GridLines = True
        Me.lsvRev.Location = New System.Drawing.Point(14, 14)
        Me.lsvRev.Margin = New System.Windows.Forms.Padding(4)
        Me.lsvRev.Name = "lsvRev"
        Me.lsvRev.Size = New System.Drawing.Size(1009, 278)
        Me.lsvRev.TabIndex = 0
        Me.lsvRev.UseCompatibleStateImageBehavior = False
        '
        'txtDate01
        '
        Me.txtDate01.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDate01.Location = New System.Drawing.Point(823, 301)
        Me.txtDate01.Name = "txtDate01"
        Me.txtDate01.Size = New System.Drawing.Size(126, 26)
        Me.txtDate01.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(751, 309)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "วันที่นัดส่ง"
        '
        'cmbCancel
        '
        Me.cmbCancel.BackColor = System.Drawing.Color.Maroon
        Me.cmbCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmbCancel.Location = New System.Drawing.Point(778, 339)
        Me.cmbCancel.Name = "cmbCancel"
        Me.cmbCancel.Size = New System.Drawing.Size(246, 41)
        Me.cmbCancel.TabIndex = 4
        Me.cmbCancel.Text = "ยกเลิก"
        Me.cmbCancel.UseVisualStyleBackColor = False
        '
        'cmbRun
        '
        Me.cmbRun.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbRun.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmbRun.Location = New System.Drawing.Point(951, 299)
        Me.cmbRun.Name = "cmbRun"
        Me.cmbRun.Size = New System.Drawing.Size(69, 31)
        Me.cmbRun.TabIndex = 5
        Me.cmbRun.Text = "Run"
        Me.cmbRun.UseVisualStyleBackColor = False
        '
        'cmbSelect
        '
        Me.cmbSelect.BackColor = System.Drawing.Color.YellowGreen
        Me.cmbSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmbSelect.Location = New System.Drawing.Point(778, 339)
        Me.cmbSelect.Name = "cmbSelect"
        Me.cmbSelect.Size = New System.Drawing.Size(119, 41)
        Me.cmbSelect.TabIndex = 6
        Me.cmbSelect.Text = "เลือก"
        Me.cmbSelect.UseVisualStyleBackColor = False
        '
        'chkCus
        '
        Me.chkCus.AutoSize = True
        Me.chkCus.Checked = True
        Me.chkCus.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkCus.Location = New System.Drawing.Point(18, 303)
        Me.chkCus.Name = "chkCus"
        Me.chkCus.Size = New System.Drawing.Size(84, 22)
        Me.chkCus.TabIndex = 7
        Me.chkCus.Text = "เช็คลูกค้า"
        Me.chkCus.UseVisualStyleBackColor = True
        '
        'lbCusName
        '
        Me.lbCusName.BackColor = System.Drawing.Color.LightGreen
        Me.lbCusName.Location = New System.Drawing.Point(446, 301)
        Me.lbCusName.Name = "lbCusName"
        Me.lbCusName.Size = New System.Drawing.Size(279, 28)
        Me.lbCusName.TabIndex = 8
        '
        'lbStkName
        '
        Me.lbStkName.BackColor = System.Drawing.Color.Yellow
        Me.lbStkName.Location = New System.Drawing.Point(266, 350)
        Me.lbStkName.Name = "lbStkName"
        Me.lbStkName.Size = New System.Drawing.Size(461, 28)
        Me.lbStkName.TabIndex = 9
        '
        'lbDocTypeP
        '
        Me.lbDocTypeP.BackColor = System.Drawing.Color.Yellow
        Me.lbDocTypeP.Location = New System.Drawing.Point(324, 302)
        Me.lbDocTypeP.Name = "lbDocTypeP"
        Me.lbDocTypeP.Size = New System.Drawing.Size(116, 28)
        Me.lbDocTypeP.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(266, 304)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 28)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "ใบเบิก :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkRev
        '
        Me.chkRev.AutoSize = True
        Me.chkRev.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkRev.Location = New System.Drawing.Point(18, 339)
        Me.chkRev.Name = "chkRev"
        Me.chkRev.Size = New System.Drawing.Size(119, 22)
        Me.chkRev.TabIndex = 12
        Me.chkRev.Text = "เฉพาะที่จัดของ"
        Me.chkRev.UseVisualStyleBackColor = True
        '
        'frmRevOnline
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.ClientSize = New System.Drawing.Size(1036, 409)
        Me.Controls.Add(Me.chkRev)
        Me.Controls.Add(Me.cmbCancel)
        Me.Controls.Add(Me.lbDocTypeP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbStkName)
        Me.Controls.Add(Me.lbCusName)
        Me.Controls.Add(Me.chkCus)
        Me.Controls.Add(Me.cmbSelect)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbRun)
        Me.Controls.Add(Me.txtDate01)
        Me.Controls.Add(Me.lsvRev)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRevOnline"
        Me.Text = "รายการสินค้าเบิกส่ง"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsvRev As System.Windows.Forms.ListView
    Friend WithEvents txtDate01 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbCancel As System.Windows.Forms.Button
    Friend WithEvents cmbRun As System.Windows.Forms.Button
    Friend WithEvents cmbSelect As System.Windows.Forms.Button
    Friend WithEvents chkCus As System.Windows.Forms.CheckBox
    Friend WithEvents lbCusName As System.Windows.Forms.Label
    Friend WithEvents lbStkName As System.Windows.Forms.Label
    Friend WithEvents lbDocTypeP As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkRev As System.Windows.Forms.CheckBox
End Class
