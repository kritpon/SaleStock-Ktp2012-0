<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTestDisc
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
        Me.cmdRun = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtDisc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdRun
        '
        Me.cmdRun.Location = New System.Drawing.Point(291, 28)
        Me.cmdRun.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdRun.Name = "cmdRun"
        Me.cmdRun.Size = New System.Drawing.Size(200, 49)
        Me.cmdRun.TabIndex = 0
        Me.cmdRun.Text = "Run"
        Me.cmdRun.UseVisualStyleBackColor = True
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(83, 40)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(150, 27)
        Me.txtPrice.TabIndex = 1
        Me.txtPrice.Text = "0"
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDisc
        '
        Me.txtDisc.Location = New System.Drawing.Point(83, 97)
        Me.txtDisc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDisc.Name = "txtDisc"
        Me.txtDisc.Size = New System.Drawing.Size(150, 27)
        Me.txtDisc.TabIndex = 2
        Me.txtDisc.Text = "0"
        Me.txtDisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ราคา"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ส่วนลด"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(83, 173)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(150, 27)
        Me.txtTotal.TabIndex = 5
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "รวม"
        '
        'frmTestDisc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 283)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDisc)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.cmdRun)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmTestDisc"
        Me.Text = "frmTestDisc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdRun As System.Windows.Forms.Button
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtDisc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
