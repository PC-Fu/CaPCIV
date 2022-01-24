Public Class MapWindow

    Private Sub MapWindow_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        APCSView.chkShowMap.Checked = False
    End Sub
End Class