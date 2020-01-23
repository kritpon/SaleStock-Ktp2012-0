Public Class frmVat
    Inherits System.Windows.Forms.Form
    Dim Drow As DataRow
    Dim dTB As New DataTable
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
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cboTypeDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    Friend WithEvents cmbClose As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label16 = New System.Windows.Forms.Label
        Me.cboTypeDoc = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNo = New System.Windows.Forms.TextBox
        Me.cmbClose = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(8, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 16)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "ประเภทเอกสาร"
        '
        'cboTypeDoc
        '
        Me.cboTypeDoc.Location = New System.Drawing.Point(96, 16)
        Me.cboTypeDoc.Name = "cboTypeDoc"
        Me.cboTypeDoc.Size = New System.Drawing.Size(72, 21)
        Me.cboTypeDoc.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 23)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "เลขที่"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNo
        '
        Me.txtNo.BackColor = System.Drawing.Color.Black
        Me.txtNo.Enabled = False
        Me.txtNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNo.ForeColor = System.Drawing.Color.Yellow
        Me.txtNo.Location = New System.Drawing.Point(72, 56)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(96, 22)
        Me.txtNo.TabIndex = 24
        Me.txtNo.Text = ""
        Me.txtNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbClose
        '
        Me.cmbClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbClose.Location = New System.Drawing.Point(208, 56)
        Me.cmbClose.Name = "cmbClose"
        Me.cmbClose.TabIndex = 27
        Me.cmbClose.Text = "ปิด"
        '
        'frmVat
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 94)
        Me.Controls.Add(Me.cmbClose)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cboTypeDoc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNo)
        Me.Name = "frmVat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกประเภทเอกสาร"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmVat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dTB.Columns.Add(New DataColumn("T_Type", GetType(String)))
        dTB.Columns.Add(New DataColumn("T_Name", GetType(String)))
        Drow = dTB.NewRow
        Drow(0) = "V"
        Drow(1) = "Vat"
        dTB.Rows.Add(Drow)

        Drow = dTB.NewRow
        Drow(0) = "N"
        Drow(1) = "NonVat"
        dTB.Rows.Add(Drow)

        Drow = dTB.NewRow
        Drow(0) = "P"
        Drow(1) = "คุณพิมพ์"
        dTB.Rows.Add(Drow)


        With cboTypeDoc
            .DataSource = dTB
            .DisplayMember = "T_Name"
            .ValueMember = "T_Type"
        End With
        cboTypeDoc.SelectedIndex = 0
    End Sub

    Private Sub cboTypeDoc_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTypeDoc.SelectedIndexChanged
        Call AutoGenerateID()
    End Sub
    Sub AutoGenerateID()

        Dim DS As DataSet = New DataSet
        Dim DA As SqlClient.SqlDataAdapter
        Dim oldmonth As String
        Dim newmonth As String
        Dim runid As String
        Dim showmonth As String
        Dim idmonth As String
        Dim years As String
        'Dim idcon As String
        Dim test As String

        'TypeDoc = cboTypeDoc.SelectedValue

        Try
            If cboTypeDoc.SelectedValue = "V" Or cboTypeDoc.SelectedValue = "P" Then
                txtSQL = " SELECT     TOP 1 Trh_No"
                txtSQL = txtSQL & "  FROM   TranDataH "
                txtSQL = txtSQL & "  WHERE     (Trh_Type = 'S') and left(trh_no,2)='V5'"
                txtSQL = txtSQL & " ORDER BY Trh_No DESC"
            ElseIf cboTypeDoc.SelectedValue = "N" Then
                txtSQL = " SELECT     TOP 1 Trh_No"
                txtSQL = txtSQL & "  FROM   TranDataH "
                txtSQL = txtSQL & "  WHERE     (Trh_Type = 'S') and left(trh_no,2)='N5'"
                txtSQL = txtSQL & " ORDER BY Trh_No DESC"
            End If
            If chkID = True Then
                chkID = False
                DS.Tables("ID").Clear()
            End If

            DA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            DA.Fill(DS, "ID")
            chkID = True

            If DS.Tables("ID").Rows.Count > 0 Then

                oldmonth = Val(Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(DS.Tables("ID").Rows(0).Item("trh_no"), 5), 2)) 'จะได้เดือน
                newmonth = Month(Now)
                If oldmonth = newmonth Then
                    If Not IsDBNull(DS.Tables("ID").Rows(0).Item("trh_no")) Then
                        test = DS.Tables("ID").Rows(0).Item("trh_no")
                        Num = CInt(Microsoft.VisualBasic.Right(DS.Tables("ID").Rows(0).Item("trh_no"), 3))
                    Else
                        Num = 0
                    End If
                    Num = Num + 1
                    If Len(CStr(Num)) = 1 Then
                        runid = "00" & CStr(Num)
                    ElseIf Len(CStr(Num)) = 2 Then
                        runid = "0" & CStr(Num)
                    ElseIf Len(CStr(Num)) = 3 Then
                        runid = CStr(Num)
                    Else
                        runid = ""
                    End If

                Else
                    runid = "001"

                End If
                showmonth = Month(Now)
                If showmonth < 10 Then
                    idmonth = "0" & showmonth
                Else
                    idmonth = showmonth
                End If

                years = Microsoft.VisualBasic.Right(Format(Now, "dd/MM/yyyy"), 2)
                If cboTypeDoc.SelectedValue = "V" Or cboTypeDoc.SelectedValue = "P" Then
                    txtNo.Text = "V" & years & idmonth & runid
                Else
                    txtNo.Text = "N" & years & idmonth & runid
                End If
                NumberDoc = txtNo.Text
            Else
                showmonth = Month(Now)
                If showmonth < 10 Then
                    idmonth = "0" & showmonth
                Else
                    idmonth = showmonth
                End If

                years = Microsoft.VisualBasic.Right(Format(Now, "dd/MM/yyyy"), 2)

                txtNo.Text = cboTypeDoc.SelectedValue & years & idmonth & "001"
                NumberDoc = txtNo.Text
            End If
        Catch errprocess As Exception
            'MessageBox.Show("กรุณาเลือกประเภทเอกสาร" & errprocess.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

  
    Private Sub cmbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbClose.Click
        Me.Close()
    End Sub
End Class
