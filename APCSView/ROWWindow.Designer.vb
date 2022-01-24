<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ROWWindow
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
        Me.pixROW = New System.Windows.Forms.PictureBox
        Me.btnLagMinus = New System.Windows.Forms.Button
        Me.btnLagPlus = New System.Windows.Forms.Button
        Me.chkTopMost = New System.Windows.Forms.CheckBox
        Me.lbLag = New System.Windows.Forms.Label
        CType(Me.pixROW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pixROW
        '
        Me.pixROW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pixROW.Location = New System.Drawing.Point(7, 6)
        Me.pixROW.Name = "pixROW"
        Me.pixROW.Size = New System.Drawing.Size(800, 450)
        Me.pixROW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pixROW.TabIndex = 0
        Me.pixROW.TabStop = False
        '
        'btnLagMinus
        '
        Me.btnLagMinus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLagMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLagMinus.ForeColor = System.Drawing.Color.Orange
        Me.btnLagMinus.Location = New System.Drawing.Point(7, 463)
        Me.btnLagMinus.Name = "btnLagMinus"
        Me.btnLagMinus.Size = New System.Drawing.Size(75, 23)
        Me.btnLagMinus.TabIndex = 1
        Me.btnLagMinus.Text = "Lag - 1"
        Me.btnLagMinus.UseVisualStyleBackColor = True
        '
        'btnLagPlus
        '
        Me.btnLagPlus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLagPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLagPlus.ForeColor = System.Drawing.Color.Orange
        Me.btnLagPlus.Location = New System.Drawing.Point(88, 463)
        Me.btnLagPlus.Name = "btnLagPlus"
        Me.btnLagPlus.Size = New System.Drawing.Size(75, 23)
        Me.btnLagPlus.TabIndex = 2
        Me.btnLagPlus.Text = "Lag + 1"
        Me.btnLagPlus.UseVisualStyleBackColor = True
        '
        'chkTopMost
        '
        Me.chkTopMost.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkTopMost.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkTopMost.AutoSize = True
        Me.chkTopMost.Checked = True
        Me.chkTopMost.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTopMost.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.chkTopMost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkTopMost.ForeColor = System.Drawing.Color.Orange
        Me.chkTopMost.Location = New System.Drawing.Point(720, 463)
        Me.chkTopMost.Name = "chkTopMost"
        Me.chkTopMost.Size = New System.Drawing.Size(87, 23)
        Me.chkTopMost.TabIndex = 3
        Me.chkTopMost.Text = "Always on Top"
        Me.chkTopMost.UseVisualStyleBackColor = True
        '
        'lbLag
        '
        Me.lbLag.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbLag.AutoSize = True
        Me.lbLag.ForeColor = System.Drawing.Color.Orange
        Me.lbLag.Location = New System.Drawing.Point(170, 470)
        Me.lbLag.Name = "lbLag"
        Me.lbLag.Size = New System.Drawing.Size(37, 13)
        Me.lbLag.TabIndex = 4
        Me.lbLag.Text = "Lag=0"
        '
        'ROWWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(812, 495)
        Me.Controls.Add(Me.lbLag)
        Me.Controls.Add(Me.chkTopMost)
        Me.Controls.Add(Me.btnLagPlus)
        Me.Controls.Add(Me.btnLagMinus)
        Me.Controls.Add(Me.pixROW)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ROWWindow"
        Me.Text = "ROW Image"
        CType(Me.pixROW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pixROW As System.Windows.Forms.PictureBox
    Friend WithEvents btnLagMinus As System.Windows.Forms.Button
    Friend WithEvents btnLagPlus As System.Windows.Forms.Button
    Friend WithEvents chkTopMost As System.Windows.Forms.CheckBox
    Friend WithEvents lbLag As System.Windows.Forms.Label
End Class
