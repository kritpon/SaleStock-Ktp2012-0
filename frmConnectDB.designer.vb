<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnectDB
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
        Me.components = New System.ComponentModel.Container()
        Me.cmdConnect = New System.Windows.Forms.Button()
        Me.lbDBconnect = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbTimer1 = New System.Windows.Forms.Label()
        Me.cmbOpenFile = New System.Windows.Forms.Button()
        Me.openFile01 = New System.Windows.Forms.OpenFileDialog()
        Me.lbFileName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdConnect
        '
        Me.cmdConnect.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.cmdConnect.Font = New System.Drawing.Font("Tahoma", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdConnect.ForeColor = System.Drawing.Color.White
        Me.cmdConnect.Location = New System.Drawing.Point(628, 16)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(144, 66)
        Me.cmdConnect.TabIndex = 0
        Me.cmdConnect.Text = "RUN"
        Me.cmdConnect.UseVisualStyleBackColor = False
        '
        'lbDBconnect
        '
        Me.lbDBconnect.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbDBconnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDBconnect.ForeColor = System.Drawing.Color.Black
        Me.lbDBconnect.Location = New System.Drawing.Point(16, 14)
        Me.lbDBconnect.Name = "lbDBconnect"
        Me.lbDBconnect.Size = New System.Drawing.Size(606, 69)
        Me.lbDBconnect.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lbTimer1
        '
        Me.lbTimer1.AutoSize = True
        Me.lbTimer1.Location = New System.Drawing.Point(18, 111)
        Me.lbTimer1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTimer1.Name = "lbTimer1"
        Me.lbTimer1.Size = New System.Drawing.Size(57, 20)
        Me.lbTimer1.TabIndex = 4
        Me.lbTimer1.Text = "Label2"
        '
        'cmbOpenFile
        '
        Me.cmbOpenFile.BackColor = System.Drawing.Color.Gold
        Me.cmbOpenFile.Font = New System.Drawing.Font("Tahoma", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbOpenFile.ForeColor = System.Drawing.Color.Black
        Me.cmbOpenFile.Location = New System.Drawing.Point(628, 99)
        Me.cmbOpenFile.Name = "cmbOpenFile"
        Me.cmbOpenFile.Size = New System.Drawing.Size(144, 66)
        Me.cmbOpenFile.TabIndex = 5
        Me.cmbOpenFile.Text = "เลือก Data"
        Me.cmbOpenFile.UseVisualStyleBackColor = False
        '
        'openFile01
        '
        Me.openFile01.FileName = "OpenFileDialog1"
        '
        'lbFileName
        '
        Me.lbFileName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbFileName.Location = New System.Drawing.Point(86, 106)
        Me.lbFileName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbFileName.Name = "lbFileName"
        Me.lbFileName.Size = New System.Drawing.Size(536, 54)
        Me.lbFileName.TabIndex = 6
        Me.lbFileName.Text = "Label2"
        '
        'frmConnectDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(790, 204)
        Me.Controls.Add(Me.lbFileName)
        Me.Controls.Add(Me.cmbOpenFile)
        Me.Controls.Add(Me.lbTimer1)
        Me.Controls.Add(Me.lbDBconnect)
        Me.Controls.Add(Me.cmdConnect)
        Me.Name = "frmConnectDB"
        Me.Text = "เลือกฐานข้อมูล"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdConnect As Button
    Friend WithEvents lbDBconnect As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbTimer1 As Label
    Friend WithEvents cmbOpenFile As Button
    Friend WithEvents openFile01 As OpenFileDialog
    Friend WithEvents lbFileName As Label
End Class
