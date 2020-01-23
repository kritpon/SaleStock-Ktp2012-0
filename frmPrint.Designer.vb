<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrint
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
        Me.cmbDrvPrint = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbDocNo = New System.Windows.Forms.Label()
        Me.cmbPrint = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbDrvPrint
        '
        Me.cmbDrvPrint.FormattingEnabled = True
        Me.cmbDrvPrint.Location = New System.Drawing.Point(226, 127)
        Me.cmbDrvPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDrvPrint.Name = "cmbDrvPrint"
        Me.cmbDrvPrint.Size = New System.Drawing.Size(639, 47)
        Me.cmbDrvPrint.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 135)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "เครื่องพิมพ์"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 39)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "เลขที่เอกสาร"
        '
        'lbDocNo
        '
        Me.lbDocNo.BackColor = System.Drawing.Color.Yellow
        Me.lbDocNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbDocNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDocNo.Location = New System.Drawing.Point(226, 45)
        Me.lbDocNo.Name = "lbDocNo"
        Me.lbDocNo.Size = New System.Drawing.Size(442, 52)
        Me.lbDocNo.TabIndex = 5
        Me.lbDocNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbPrint
        '
        Me.cmbPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmbPrint.Location = New System.Drawing.Point(872, 36)
        Me.cmbPrint.Name = "cmbPrint"
        Me.cmbPrint.Size = New System.Drawing.Size(207, 138)
        Me.cmbPrint.TabIndex = 6
        Me.cmbPrint.Text = "พิมพ์"
        Me.cmbPrint.UseVisualStyleBackColor = False
        '
        'frmPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1101, 264)
        Me.Controls.Add(Me.cmbPrint)
        Me.Controls.Add(Me.lbDocNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbDrvPrint)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPrint"
        Me.Text = "พิมพ์ผ่าน Network"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbDrvPrint As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbDocNo As System.Windows.Forms.Label
    Friend WithEvents cmbPrint As System.Windows.Forms.Button
End Class
