<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPriceList
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
        Me.listPrice = New System.Windows.Forms.ListView()
        Me.lbPrice = New System.Windows.Forms.Label()
        Me.cmbSelect = New System.Windows.Forms.Button()
        Me.lbDate = New System.Windows.Forms.Label()
        Me.lbDisc = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.optOrder = New System.Windows.Forms.RadioButton()
        Me.optSales = New System.Windows.Forms.RadioButton()
        Me.optCost = New System.Windows.Forms.RadioButton()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.lbStkName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'listPrice
        '
        Me.listPrice.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listPrice.FullRowSelect = True
        Me.listPrice.Location = New System.Drawing.Point(5, 4)
        Me.listPrice.Name = "listPrice"
        Me.listPrice.Size = New System.Drawing.Size(587, 325)
        Me.listPrice.TabIndex = 0
        Me.listPrice.UseCompatibleStateImageBehavior = False
        '
        'lbPrice
        '
        Me.lbPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbPrice.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbPrice.Location = New System.Drawing.Point(202, 398)
        Me.lbPrice.Name = "lbPrice"
        Me.lbPrice.Size = New System.Drawing.Size(151, 30)
        Me.lbPrice.TabIndex = 1
        Me.lbPrice.Text = "0.00"
        Me.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbSelect
        '
        Me.cmbSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSelect.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmbSelect.Location = New System.Drawing.Point(372, 398)
        Me.cmbSelect.Name = "cmbSelect"
        Me.cmbSelect.Size = New System.Drawing.Size(105, 72)
        Me.cmbSelect.TabIndex = 2
        Me.cmbSelect.Text = "เลือก"
        Me.cmbSelect.UseVisualStyleBackColor = False
        '
        'lbDate
        '
        Me.lbDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDate.ForeColor = System.Drawing.Color.Black
        Me.lbDate.Location = New System.Drawing.Point(108, 398)
        Me.lbDate.Name = "lbDate"
        Me.lbDate.Size = New System.Drawing.Size(88, 30)
        Me.lbDate.TabIndex = 3
        Me.lbDate.Text = "01/01/58"
        Me.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbDisc
        '
        Me.lbDisc.BackColor = System.Drawing.Color.Red
        Me.lbDisc.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDisc.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbDisc.Location = New System.Drawing.Point(202, 440)
        Me.lbDisc.Name = "lbDisc"
        Me.lbDisc.Size = New System.Drawing.Size(151, 30)
        Me.lbDisc.TabIndex = 4
        Me.lbDisc.Text = "0.00"
        Me.lbDisc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(125, 452)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ส่วนลด %"
        '
        'optOrder
        '
        Me.optOrder.AutoSize = True
        Me.optOrder.Location = New System.Drawing.Point(384, 375)
        Me.optOrder.Name = "optOrder"
        Me.optOrder.Size = New System.Drawing.Size(96, 17)
        Me.optOrder.TabIndex = 6
        Me.optOrder.Text = "ราคาจาก Order"
        Me.optOrder.UseVisualStyleBackColor = True
        '
        'optSales
        '
        Me.optSales.AutoSize = True
        Me.optSales.Checked = True
        Me.optSales.Location = New System.Drawing.Point(291, 375)
        Me.optSales.Name = "optSales"
        Me.optSales.Size = New System.Drawing.Size(65, 17)
        Me.optSales.TabIndex = 7
        Me.optSales.TabStop = True
        Me.optSales.Text = "ราคาขาย"
        Me.optSales.UseVisualStyleBackColor = True
        '
        'optCost
        '
        Me.optCost.BackColor = System.Drawing.Color.Goldenrod
        Me.optCost.Enabled = False
        Me.optCost.Location = New System.Drawing.Point(509, 375)
        Me.optCost.Name = "optCost"
        Me.optCost.Size = New System.Drawing.Size(79, 17)
        Me.optCost.TabIndex = 8
        Me.optCost.Text = "ราคาทุน"
        Me.optCost.UseVisualStyleBackColor = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExit.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdExit.Location = New System.Drawing.Point(483, 398)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(105, 72)
        Me.cmdExit.TabIndex = 9
        Me.cmdExit.Text = "ออก"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'lbStkName
        '
        Me.lbStkName.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbStkName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbStkName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStkName.Location = New System.Drawing.Point(5, 335)
        Me.lbStkName.Name = "lbStkName"
        Me.lbStkName.Size = New System.Drawing.Size(585, 28)
        Me.lbStkName.TabIndex = 10
        Me.lbStkName.Text = "ชื่อสินค้า"
        Me.lbStkName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmPriceList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(604, 486)
        Me.Controls.Add(Me.lbStkName)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.optCost)
        Me.Controls.Add(Me.optSales)
        Me.Controls.Add(Me.optOrder)
        Me.Controls.Add(Me.lbDisc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbDate)
        Me.Controls.Add(Me.cmbSelect)
        Me.Controls.Add(Me.lbPrice)
        Me.Controls.Add(Me.listPrice)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Name = "frmPriceList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ตารางราคา  12/02/58"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listPrice As System.Windows.Forms.ListView
    Friend WithEvents lbPrice As System.Windows.Forms.Label
    Friend WithEvents cmbSelect As System.Windows.Forms.Button
    Friend WithEvents lbDate As System.Windows.Forms.Label
    Friend WithEvents lbDisc As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents optOrder As System.Windows.Forms.RadioButton
    Friend WithEvents optSales As System.Windows.Forms.RadioButton
    Friend WithEvents optCost As System.Windows.Forms.RadioButton
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents lbStkName As System.Windows.Forms.Label
End Class
