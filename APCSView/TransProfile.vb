Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Drawing
Imports System.Drawing.Graphics
Imports System.Drawing.Imaging

Public Class TransProfile

    Dim yScale As Single = 100 ' number of vertical pixels per m 
    Dim xPixOff As Integer
    Dim penTP As New Pen(Color.LightGreen, 3)
    Dim flagDist As Boolean = False
    Dim xDist(1, 1) As Single
    Dim tempDist0 As Single
    Dim tempDist1 As Single
    Dim tempDist2 As Single
    Dim jCurTP As Integer = APCSView.iCurTP


    Private Sub TransProfile_Invalidated(ByVal sender As Object, ByVal e As System.Windows.Forms.InvalidateEventArgs) Handles Me.Invalidated
        canvasTP.Invalidate()
    End Sub

    Private Sub TransProfile_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        canvasTP.Width = APCSView.Canvas.Width
        Me.Width = canvasTP.Width + 8
        canvasTP.Invalidate()
    End Sub


    Private Sub TransProfile_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel
        yScale = yScale * 1.1 ^ (e.Delta / 120)
        canvasTP.Invalidate()
    End Sub

    Private Sub canvasTP_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles canvasTP.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            flagDist = True
            xDist(0, 0) = Scr2XM(e.X)
            xDist(0, 1) = Scr2YM(e.Y)

        End If

    End Sub

    Private Sub canvasTP_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles canvasTP.MouseMove
        If flagDist Then
            xDist(1, 0) = Scr2XM(e.X)
            xDist(1, 1) = Scr2YM(e.Y)
            tempDist0 = Math.Sqrt((xDist(1, 0) - xDist(0, 0)) ^ 2 + (xDist(1, 1) - xDist(0, 1)) ^ 2) * 1000
            tempDist1 = (xDist(1, 0) - xDist(0, 0)) * 1000
            tempDist2 = (xDist(1, 1) - xDist(0, 1)) * 1000
            canvasTP.Invalidate()
        Else
            lbXCursor.Text = "x: " & (Scr2XM(e.X) * 1000).ToString("F00") & ", y: " & (Scr2YM(e.Y) * 1000).ToString("F00")
            canvasTP.Invalidate()
        End If
    End Sub

    Private Sub canvasTP_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles canvasTP.MouseUp
        flagDist = False
    End Sub




    Private Sub canvasTP_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles canvasTP.Paint
        xPixOff = APCSView.offsetOrigin(0) + (canvasTP.Width - APCSView.Canvas.Width) / 2
        jCurTP = APCSView.iCurTP

        Dim TPPaint As Graphics = e.Graphics

        For i As Integer = 1 To APCSView.nPtTP(jCurTP) - 1
            TPPaint.DrawLine(penTP, xM2Scr(APCSView.xPtTP(jCurTP, i - 1)), yM2Scr(APCSView.proFlt(jCurTP, i - 1)), _
                             xM2Scr(APCSView.xPtTP(jCurTP, i)), yM2Scr(APCSView.proFlt(jCurTP, i)))
            TPPaint.DrawLine(Pens.Orange, xM2Scr(APCSView.xPtTP(jCurTP, i - 1)), yM2Scr(APCSView.proTRaw(jCurTP, i - 1)), _
                             xM2Scr(APCSView.xPtTP(jCurTP, i)), yM2Scr(APCSView.proTRaw(jCurTP, i)))

        Next

        If chkShowRefLine.Checked Then
            For j As Integer = 0 To 6
                TPPaint.DrawLine(Pens.Gray, xM2Scr(APCSView.xPtTP(jCurTP, APCSView.iPtBound(jCurTP, j) - 1)), 0, _
                                     xM2Scr(APCSView.xPtTP(jCurTP, APCSView.iPtBound(jCurTP, j) - 1)), canvasTP.Height)
            Next

        End If
        TPPaint.FillEllipse(Brushes.Red, xM2Scr(APCSView.xPtTP(jCurTP, APCSView.iPtHump(jCurTP, 0, 0) - 1)) - 3, yM2Scr(APCSView.proFlt(jCurTP, APCSView.iPtHump(jCurTP, 0, 0) - 1)) - 3, 7, 7)
        TPPaint.FillEllipse(Brushes.Red, xM2Scr(APCSView.xPtTP(jCurTP, APCSView.iPtHump(jCurTP, 0, 1) - 1)) - 3, yM2Scr(APCSView.proFlt(jCurTP, APCSView.iPtHump(jCurTP, 0, 1) - 1)) - 3, 7, 7)
        TPPaint.FillEllipse(Brushes.Red, xM2Scr(APCSView.xPtTP(jCurTP, APCSView.iPtHump(jCurTP, 1, 0) - 1)) - 3, yM2Scr(APCSView.proFlt(jCurTP, APCSView.iPtHump(jCurTP, 1, 0) - 1)) - 3, 7, 7)
        TPPaint.FillEllipse(Brushes.Red, xM2Scr(APCSView.xPtTP(jCurTP, APCSView.iPtHump(jCurTP, 1, 1) - 1)) - 3, yM2Scr(APCSView.proFlt(jCurTP, APCSView.iPtHump(jCurTP, 1, 1) - 1)) - 3, 7, 7)
        TPPaint.FillEllipse(Brushes.Red, xM2Scr(APCSView.xPtTP(jCurTP, APCSView.iPtBot(jCurTP, 0) - 1)) - 3, yM2Scr(APCSView.proFlt(jCurTP, APCSView.iPtBot(jCurTP, 0) - 1)) - 3, 7, 7)
        TPPaint.FillEllipse(Brushes.Red, xM2Scr(APCSView.xPtTP(jCurTP, APCSView.iPtBot(jCurTP, 1) - 1)) - 3, yM2Scr(APCSView.proFlt(jCurTP, APCSView.iPtBot(jCurTP, 1) - 1)) - 3, 7, 7)
        TPPaint.DrawLine(Pens.Red, xM2Scr(APCSView.xRod(jCurTP, 0)), yM2Scr(APCSView.zRod(jCurTP, 0)), xM2Scr(APCSView.xRod(jCurTP, 1)), yM2Scr(APCSView.zRod(jCurTP, 1)))
        TPPaint.DrawLine(Pens.Red, xM2Scr(APCSView.xRod(jCurTP, 2)), yM2Scr(APCSView.zRod(jCurTP, 2)), xM2Scr(APCSView.xRod(jCurTP, 3)), yM2Scr(APCSView.zRod(jCurTP, 3)))
        TPPaint.DrawLine(Pens.Red, xM2Scr(APCSView.xPtTP(jCurTP, APCSView.iPtBot(jCurTP, 0) - 1)), yM2Scr(APCSView.proFlt(jCurTP, APCSView.iPtBot(jCurTP, 0) - 1)), xM2Scr(APCSView.xRod(jCurTP, 4)), yM2Scr(APCSView.zRod(jCurTP, 4)))
        TPPaint.DrawLine(Pens.Red, xM2Scr(APCSView.xPtTP(jCurTP, APCSView.iPtBot(jCurTP, 1) - 1)), yM2Scr(APCSView.proFlt(jCurTP, APCSView.iPtBot(jCurTP, 1) - 1)), xM2Scr(APCSView.xRod(jCurTP, 5)), yM2Scr(APCSView.zRod(jCurTP, 5)))
        lbRDLeft.Text = "Right  wheelpath rut depth: " & (APCSView.RD(jCurTP, 0) * 1000).ToString("F01") & " mm"
        lbRDRight.Text = "Left wheelpath rut depth: " & (APCSView.RD(jCurTP, 1) * 1000).ToString("F01") & " mm"

        If flagDist Then
            TPPaint.DrawLine(Pens.Orange, xM2Scr(xDist(0, 0)), yM2Scr(xDist(0, 1)), xM2Scr(xDist(1, 0)), yM2Scr(xDist(1, 1)))
            TPPaint.FillRectangle(Brushes.Gray, xM2Scr(xDist(1, 0)), yM2Scr(xDist(1, 1)) + 5, 250, 30)
            TPPaint.DrawString(tempDist0.ToString("F01") & " mm;  " & "dX = " & tempDist1.ToString("F01") & " mm;  " & "dY = " & tempDist2.ToString("F01") & " mm  ", Me.Font, Brushes.Orange, xM2Scr(xDist(1, 0)) + 10, yM2Scr(xDist(1, 1)) + 10)
        End If
    End Sub

    Private Function xM2Scr(ByRef x As Single) As Single
        xM2Scr = (x + APCSView.xOffTP(jCurTP)) / APCSView.mPerPix * APCSView.scaleXSr2Pix + xPixOff
    End Function

    Private Function yM2Scr(ByRef z As Single) As Single
        yM2Scr = canvasTP.Height / 2 - z * yScale
    End Function

    Private Function Scr2XM(ByRef ex As Integer) As Single
        Scr2XM = (ex - xPixOff) * APCSView.mPerPix / APCSView.scaleXSr2Pix - APCSView.xOffTP(jCurTP)
    End Function

    Private Function Scr2YM(ByRef eY As Integer) As Single
        Scr2YM = (canvasTP.Height / 2 - eY) / yScale
    End Function
    Private Sub TransProfile_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        canvasTP.Width = Me.Width - 8
        canvasTP.Height = Me.Height - 100
        canvasTP.Invalidate()
    End Sub

    Private Sub setTransparency_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setTransparency.Scroll
        Me.Opacity = 1 - setTransparency.Value / 35
    End Sub

    Private Sub chkTop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTop.CheckedChanged
        If chkTop.Checked Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub
End Class