<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MapWindow
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
        Me.mapBrow = New System.Windows.Forms.WebBrowser
        Me.SuspendLayout()
        '
        'mapBrow
        '
        Me.mapBrow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mapBrow.Location = New System.Drawing.Point(0, 0)
        Me.mapBrow.MinimumSize = New System.Drawing.Size(20, 20)
        Me.mapBrow.Name = "mapBrow"
        Me.mapBrow.Size = New System.Drawing.Size(792, 773)
        Me.mapBrow.TabIndex = 0
        '
        'MapWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(792, 773)
        Me.Controls.Add(Me.mapBrow)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "MapWindow"
        Me.Text = "MapBrowser"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mapBrow As System.Windows.Forms.WebBrowser
End Class
