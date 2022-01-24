Public Class MagnifyWindow

    Dim offset() As Integer = New Integer(1) {}

    Private Sub MagnifyWindow_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        APCSView.chkMag.Checked = False
    End Sub



    Private Sub MagnifyWindow_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        canvasMag.Width = Me.Width - 10
        canvasMag.Height = Me.Height - 30
    End Sub


    Private Sub canvasMag_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles canvasMag.Paint
        If APCSView.nImage > -1 Then
            Dim MagPaint As Graphics = e.Graphics

            offset(0) = canvasMag.Width / 2 - APCSView.xPixMagCenter(0) * APCSView.scaleMag
            offset(1) = canvasMag.Height / 2 + APCSView.xPixMagCenter(1) * APCSView.scaleMag

            For iImage As Integer = 0 To APCSView.nImage
                MagPaint.DrawImage(APCSView.imageRaw(iImage), xPix2Scr(APCSView.originImage(iImage, 0)), yPix2Scr(APCSView.originImage(iImage, 1)), _
                                      APCSView.sizeImage(iImage, 0) * APCSView.scaleMag, APCSView.sizeImage(iImage, 1) * APCSView.scaleMag)
            Next

        End If



    End Sub

    Private Function xPix2Scr(ByVal xPix As Integer) As Single
        xPix2Scr = xPix * APCSView.scaleMag + offset(0)
    End Function
    Private Function yPix2Scr(ByVal yPix As Integer) As Single
        yPix2Scr = -yPix * APCSView.scaleMag + offset(1)
    End Function


End Class