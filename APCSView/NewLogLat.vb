Imports System.Windows.Forms

Public Class NewLogLat

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

        If APCSView.flagAddingRefGeo Then
            APCSView.nRefGeo += 1
            APCSView.coorGeo(APCSView.nRefGeo, 0) = setRefLog.Value
            APCSView.coorGeo(APCSView.nRefGeo, 1) = setRefLat.Value
            APCSView.coorGeo(APCSView.nRefGeo, 2) = setRefHeight.Value
            APCSView.noteGeo(APCSView.nRefGeo) = setPtNote.Text
        ElseIf APCSView.flagPickingAnchor(0) Then
            APCSView.coorGeo(0, 0) = setRefLog.Value
            APCSView.coorGeo(0, 1) = setRefLat.Value
            APCSView.coorGeo(0, 2) = setRefHeight.Value
            APCSView.noteGeo(0) = setPtNote.Text
            APCSView.flagPickingAnchor(0) = False
        ElseIf APCSView.flagPickingAnchor(1) Then
            APCSView.coorGeo(1, 0) = setRefLog.Value
            APCSView.coorGeo(1, 1) = setRefLat.Value
            APCSView.coorGeo(1, 2) = setRefHeight.Value
            APCSView.noteGeo(1) = setPtNote.Text
            APCSView.flagPickingAnchor(1) = False

        End If

        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub setRefLog_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setRefLog.ValueChanged
        If setRefLog.Value > 0 Then
            MessageBox.Show("Warning. North America should have negative longitude values!")
        End If
    End Sub
End Class
