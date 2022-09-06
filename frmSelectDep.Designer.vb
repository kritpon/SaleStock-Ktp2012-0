<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectDep
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDepSearch = New System.Windows.Forms.Button()
        Me.txtDepSearch = New System.Windows.Forms.TextBox()
        Me.lsvDepCus = New System.Windows.Forms.ListView()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDepSearch)
        Me.GroupBox1.Controls.Add(Me.txtDepSearch)
        Me.GroupBox1.Controls.Add(Me.lsvDepCus)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(908, 436)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnDepSearch
        '
        Me.btnDepSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnDepSearch.Font = New System.Drawing.Font("Cordia New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDepSearch.ForeColor = System.Drawing.Color.White
        Me.btnDepSearch.Location = New System.Drawing.Point(172, 22)
        Me.btnDepSearch.Name = "btnDepSearch"
        Me.btnDepSearch.Size = New System.Drawing.Size(96, 36)
        Me.btnDepSearch.TabIndex = 33
        Me.btnDepSearch.Text = "ค้นหา"
        Me.btnDepSearch.UseVisualStyleBackColor = False
        '
        'txtDepSearch
        '
        Me.txtDepSearch.BackColor = System.Drawing.Color.PaleTurquoise
        Me.txtDepSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDepSearch.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDepSearch.ForeColor = System.Drawing.Color.Black
        Me.txtDepSearch.Location = New System.Drawing.Point(6, 22)
        Me.txtDepSearch.Name = "txtDepSearch"
        Me.txtDepSearch.Size = New System.Drawing.Size(160, 36)
        Me.txtDepSearch.TabIndex = 32
        Me.txtDepSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lsvDepCus
        '
        Me.lsvDepCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lsvDepCus.FullRowSelect = True
        Me.lsvDepCus.HideSelection = False
        Me.lsvDepCus.Location = New System.Drawing.Point(6, 64)
        Me.lsvDepCus.Name = "lsvDepCus"
        Me.lsvDepCus.Size = New System.Drawing.Size(882, 348)
        Me.lsvDepCus.TabIndex = 0
        Me.lsvDepCus.UseCompatibleStateImageBehavior = False
        '
        'frmSelectDep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 460)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSelectDep"
        Me.Text = "เลือกเอกสารเงินมัดจำ"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lsvDepCus As ListView
    Friend WithEvents txtDepSearch As TextBox
    Friend WithEvents btnDepSearch As Button
End Class
