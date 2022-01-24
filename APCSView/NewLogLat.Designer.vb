<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewLogLat
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.txtLog = New System.Windows.Forms.Label
        Me.setRefLog = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.setRefLat = New System.Windows.Forms.NumericUpDown
        Me.setRefHeight = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.setPtNote = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.setRefLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setRefLat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setRefHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(221, 177)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'txtLog
        '
        Me.txtLog.AutoSize = True
        Me.txtLog.Location = New System.Drawing.Point(69, 31)
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(54, 13)
        Me.txtLog.TabIndex = 1
        Me.txtLog.Text = "Longitude"
        '
        'setRefLog
        '
        Me.setRefLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.setRefLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.setRefLog.DecimalPlaces = 8
        Me.setRefLog.ForeColor = System.Drawing.Color.White
        Me.setRefLog.Location = New System.Drawing.Point(146, 31)
        Me.setRefLog.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.setRefLog.Minimum = New Decimal(New Integer() {180, 0, 0, -2147483648})
        Me.setRefLog.Name = "setRefLog"
        Me.setRefLog.Size = New System.Drawing.Size(114, 20)
        Me.setRefLog.TabIndex = 2
        Me.setRefLog.Value = New Decimal(New Integer() {120, 0, 0, -2147483648})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Latitude"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Height"
        '
        'setRefLat
        '
        Me.setRefLat.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.setRefLat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.setRefLat.DecimalPlaces = 8
        Me.setRefLat.ForeColor = System.Drawing.Color.White
        Me.setRefLat.Location = New System.Drawing.Point(146, 67)
        Me.setRefLat.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        Me.setRefLat.Minimum = New Decimal(New Integer() {90, 0, 0, -2147483648})
        Me.setRefLat.Name = "setRefLat"
        Me.setRefLat.Size = New System.Drawing.Size(114, 20)
        Me.setRefLat.TabIndex = 5
        Me.setRefLat.Value = New Decimal(New Integer() {35, 0, 0, 0})
        '
        'setRefHeight
        '
        Me.setRefHeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.setRefHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.setRefHeight.DecimalPlaces = 1
        Me.setRefHeight.ForeColor = System.Drawing.Color.White
        Me.setRefHeight.Location = New System.Drawing.Point(146, 103)
        Me.setRefHeight.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.setRefHeight.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.setRefHeight.Name = "setRefHeight"
        Me.setRefHeight.Size = New System.Drawing.Size(114, 20)
        Me.setRefHeight.TabIndex = 6
        Me.setRefHeight.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(266, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "degrees"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(266, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "degrees"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(266, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "meters"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(69, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Note:"
        '
        'setPtNote
        '
        Me.setPtNote.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.setPtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.setPtNote.ForeColor = System.Drawing.Color.White
        Me.setPtNote.Location = New System.Drawing.Point(146, 140)
        Me.setPtNote.Name = "setPtNote"
        Me.setPtNote.Size = New System.Drawing.Size(100, 20)
        Me.setPtNote.TabIndex = 7
        '
        'NewLogLat
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(379, 218)
        Me.Controls.Add(Me.setPtNote)
        Me.Controls.Add(Me.setRefHeight)
        Me.Controls.Add(Me.setRefLat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.setRefLog)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewLogLat"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New Reference Point"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.setRefLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setRefLat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setRefHeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents txtLog As System.Windows.Forms.Label
    Friend WithEvents setRefLog As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents setRefLat As System.Windows.Forms.NumericUpDown
    Friend WithEvents setRefHeight As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents setPtNote As System.Windows.Forms.TextBox

End Class
