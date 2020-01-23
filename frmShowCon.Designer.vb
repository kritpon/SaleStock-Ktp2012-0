<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowCon
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
        Me.lsvCond = New System.Windows.Forms.ListView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lsvCond
        '
        Me.lsvCond.BackColor = System.Drawing.SystemColors.Info
        Me.lsvCond.CheckBoxes = True
        Me.lsvCond.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lsvCond.FullRowSelect = True
        Me.lsvCond.Location = New System.Drawing.Point(9, 20)
        Me.lsvCond.Margin = New System.Windows.Forms.Padding(4)
        Me.lsvCond.Name = "lsvCond"
        Me.lsvCond.Size = New System.Drawing.Size(632, 299)
        Me.lsvCond.TabIndex = 17
        Me.lsvCond.UseCompatibleStateImageBehavior = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.lsvCond)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(650, 336)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'cmbExit
        '
        Me.cmbExit.BackColor = System.Drawing.Color.Green
        Me.cmbExit.ForeColor = System.Drawing.Color.White
        Me.cmbExit.Location = New System.Drawing.Point(533, 357)
        Me.cmbExit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbExit.Name = "cmbExit"
        Me.cmbExit.Size = New System.Drawing.Size(127, 36)
        Me.cmbExit.TabIndex = 34
        Me.cmbExit.Text = "OK "
        Me.cmbExit.UseVisualStyleBackColor = False
        '
        'frmShowCon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(672, 406)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbExit)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmShowCon"
        Me.Text = "แจ้งเตือน"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsvCond As System.Windows.Forms.ListView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbExit As System.Windows.Forms.Button
End Class
