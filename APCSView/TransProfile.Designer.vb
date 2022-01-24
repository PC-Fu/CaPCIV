<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransProfile
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
        Me.canvasTP = New System.Windows.Forms.PictureBox
        Me.chkTop = New System.Windows.Forms.CheckBox
        Me.setTransparency = New System.Windows.Forms.TrackBar
        Me.lbRDLeft = New System.Windows.Forms.Label
        Me.lbRDRight = New System.Windows.Forms.Label
        Me.lbXCursor = New System.Windows.Forms.Label
        Me.chkShowRefLine = New System.Windows.Forms.CheckBox
        CType(Me.canvasTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setTransparency, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'canvasTP
        '
        Me.canvasTP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.canvasTP.Location = New System.Drawing.Point(0, 0)
        Me.canvasTP.Name = "canvasTP"
        Me.canvasTP.Size = New System.Drawing.Size(722, 300)
        Me.canvasTP.TabIndex = 0
        Me.canvasTP.TabStop = False
        '
        'chkTop
        '
        Me.chkTop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkTop.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkTop.AutoSize = True
        Me.chkTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkTop.Location = New System.Drawing.Point(671, 305)
        Me.chkTop.Name = "chkTop"
        Me.chkTop.Size = New System.Drawing.Size(39, 23)
        Me.chkTop.TabIndex = 1
        Me.chkTop.Text = "TOP"
        Me.chkTop.UseVisualStyleBackColor = True
        '
        'setTransparency
        '
        Me.setTransparency.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.setTransparency.Location = New System.Drawing.Point(561, 305)
        Me.setTransparency.Maximum = 25
        Me.setTransparency.Name = "setTransparency"
        Me.setTransparency.Size = New System.Drawing.Size(104, 42)
        Me.setTransparency.TabIndex = 2
        Me.setTransparency.TabStop = False
        Me.setTransparency.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'lbRDLeft
        '
        Me.lbRDLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbRDLeft.AutoSize = True
        Me.lbRDLeft.Location = New System.Drawing.Point(12, 350)
        Me.lbRDLeft.Name = "lbRDLeft"
        Me.lbRDLeft.Size = New System.Drawing.Size(23, 13)
        Me.lbRDLeft.TabIndex = 3
        Me.lbRDLeft.Text = "RD"
        '
        'lbRDRight
        '
        Me.lbRDRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbRDRight.AutoSize = True
        Me.lbRDRight.Location = New System.Drawing.Point(12, 324)
        Me.lbRDRight.Name = "lbRDRight"
        Me.lbRDRight.Size = New System.Drawing.Size(23, 13)
        Me.lbRDRight.TabIndex = 4
        Me.lbRDRight.Text = "RD"
        '
        'lbXCursor
        '
        Me.lbXCursor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbXCursor.AutoSize = True
        Me.lbXCursor.Location = New System.Drawing.Point(569, 350)
        Me.lbXCursor.Name = "lbXCursor"
        Me.lbXCursor.Size = New System.Drawing.Size(39, 13)
        Me.lbXCursor.TabIndex = 5
        Me.lbXCursor.Text = "Label1"
        '
        'chkShowRefLine
        '
        Me.chkShowRefLine.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkShowRefLine.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkShowRefLine.AutoSize = True
        Me.chkShowRefLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowRefLine.Location = New System.Drawing.Point(421, 305)
        Me.chkShowRefLine.Name = "chkShowRefLine"
        Me.chkShowRefLine.Size = New System.Drawing.Size(87, 23)
        Me.chkShowRefLine.TabIndex = 6
        Me.chkShowRefLine.Text = "Show Ref Line"
        Me.chkShowRefLine.UseVisualStyleBackColor = True
        '
        'TransProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(722, 373)
        Me.Controls.Add(Me.chkShowRefLine)
        Me.Controls.Add(Me.lbXCursor)
        Me.Controls.Add(Me.lbRDRight)
        Me.Controls.Add(Me.lbRDLeft)
        Me.Controls.Add(Me.setTransparency)
        Me.Controls.Add(Me.chkTop)
        Me.Controls.Add(Me.canvasTP)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximumSize = New System.Drawing.Size(10000, 1000)
        Me.MinimumSize = New System.Drawing.Size(8, 400)
        Me.Name = "TransProfile"
        Me.Text = "TransProfile"
        CType(Me.canvasTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setTransparency, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents canvasTP As System.Windows.Forms.PictureBox
    Friend WithEvents chkTop As System.Windows.Forms.CheckBox
    Friend WithEvents setTransparency As System.Windows.Forms.TrackBar
    Friend WithEvents lbRDLeft As System.Windows.Forms.Label
    Friend WithEvents lbRDRight As System.Windows.Forms.Label
    Friend WithEvents lbXCursor As System.Windows.Forms.Label
    Friend WithEvents chkShowRefLine As System.Windows.Forms.CheckBox
End Class
