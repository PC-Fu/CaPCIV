<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MagnifyWindow
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
        Me.canvasMag = New System.Windows.Forms.PictureBox
        CType(Me.canvasMag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'canvasMag
        '
        Me.canvasMag.BackColor = System.Drawing.Color.Black
        Me.canvasMag.Location = New System.Drawing.Point(0, 0)
        Me.canvasMag.Name = "canvasMag"
        Me.canvasMag.Size = New System.Drawing.Size(390, 370)
        Me.canvasMag.TabIndex = 0
        Me.canvasMag.TabStop = False
        '
        'MagnifyWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 373)
        Me.Controls.Add(Me.canvasMag)
        Me.Name = "MagnifyWindow"
        Me.Text = "Magnify Window"
        Me.TopMost = True
        CType(Me.canvasMag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents canvasMag As System.Windows.Forms.PictureBox
End Class
