Public Class ROWWindow
    Public lagROWPav As Integer = 0


    Private Sub ROWWindow_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        APCSView.chkShowROW.Checked = False
    End Sub

    Private Sub ROWWindow_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        pixROW.Width = Me.Width - 20
        pixROW.Height = pixROW.Width / 16 * 9

    End Sub

    Private Sub chkTopMost_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTopMost.CheckedChanged
        If chkTopMost.Checked = False Then
            Me.TopMost = False
        Else
            Me.TopMost = True
        End If
    End Sub

    Private Sub btnLagPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLagPlus.Click
        lagROWPav += 1
        lbLag.Text = "Lag=" & lagROWPav
        APCSView.Canvas.Invalidate()

    End Sub

    Private Sub btnLagMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLagMinus.Click
        lagROWPav -= 1
        lbLag.Text = "Lag=" & lagROWPav

        APCSView.Canvas.Invalidate()

    End Sub
End Class