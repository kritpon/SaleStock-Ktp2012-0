<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAnswers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmbSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbUser = New System.Windows.Forms.Label()
        Me.txtDetail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCancel = New System.Windows.Forms.Button()
        Me.lbComName = New System.Windows.Forms.Label()
        Me.lbUserID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbSave
        '
        Me.cmbSave.BackColor = System.Drawing.Color.Maroon
        Me.cmbSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbSave.ForeColor = System.Drawing.Color.White
        Me.cmbSave.Location = New System.Drawing.Point(1027, 15)
        Me.cmbSave.Name = "cmbSave"
        Me.cmbSave.Size = New System.Drawing.Size(311, 116)
        Me.cmbSave.TabIndex = 0
        Me.cmbSave.Text = "บันทึก"
        Me.cmbSave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ชื่อผู้แก้ไข"
        '
        'lbUser
        '
        Me.lbUser.BackColor = System.Drawing.Color.Black
        Me.lbUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbUser.ForeColor = System.Drawing.Color.Yellow
        Me.lbUser.Location = New System.Drawing.Point(169, 15)
        Me.lbUser.Name = "lbUser"
        Me.lbUser.Size = New System.Drawing.Size(387, 62)
        Me.lbUser.TabIndex = 2
        '
        'txtDetail
        '
        Me.txtDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDetail.Location = New System.Drawing.Point(166, 162)
        Me.txtDetail.MaxLength = 250
        Me.txtDetail.Multiline = True
        Me.txtDetail.Name = "txtDetail"
        Me.txtDetail.Size = New System.Drawing.Size(846, 276)
        Me.txtDetail.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(50, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 37)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "รายการ"
        '
        'cmbCancel
        '
        Me.cmbCancel.BackColor = System.Drawing.Color.Yellow
        Me.cmbCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbCancel.ForeColor = System.Drawing.Color.Black
        Me.cmbCancel.Location = New System.Drawing.Point(1027, 173)
        Me.cmbCancel.Name = "cmbCancel"
        Me.cmbCancel.Size = New System.Drawing.Size(311, 116)
        Me.cmbCancel.TabIndex = 5
        Me.cmbCancel.Text = "ยกเลิก"
        Me.cmbCancel.UseVisualStyleBackColor = False
        '
        'lbComName
        '
        Me.lbComName.BackColor = System.Drawing.Color.Black
        Me.lbComName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbComName.ForeColor = System.Drawing.Color.Yellow
        Me.lbComName.Location = New System.Drawing.Point(572, 15)
        Me.lbComName.Name = "lbComName"
        Me.lbComName.Size = New System.Drawing.Size(440, 62)
        Me.lbComName.TabIndex = 7
        '
        'lbUserID
        '
        Me.lbUserID.BackColor = System.Drawing.Color.Black
        Me.lbUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbUserID.ForeColor = System.Drawing.Color.Yellow
        Me.lbUserID.Location = New System.Drawing.Point(169, 86)
        Me.lbUserID.Name = "lbUserID"
        Me.lbUserID.Size = New System.Drawing.Size(387, 62)
        Me.lbUserID.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(16, 456)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1329, 140)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "เอกสารเลขที่นี้ได้ถูกพิมพ์ไปแล้ว  โปรดระบุเหตุผลในการเปิดเอกสาร"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAnswers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1633, 605)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbUserID)
        Me.Controls.Add(Me.lbComName)
        Me.Controls.Add(Me.cmbCancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDetail)
        Me.Controls.Add(Me.lbUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbSave)
        Me.Name = "frmAnswers"
        Me.Text = "frmAnswers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbUser As Label
    Friend WithEvents txtDetail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbCancel As Button
    Friend WithEvents lbComName As Label
    Friend WithEvents lbUserID As Label
    Friend WithEvents Label3 As Label
End Class
