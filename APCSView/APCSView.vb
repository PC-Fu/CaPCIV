Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Drawing
Imports System.Drawing.Graphics
Imports System.Drawing.Imaging
Imports System
Imports System.IO
Public Class APCSView

    Public Declare Function timeGetTime Lib "winmm.dll" () As Integer

    Declare Sub SaveDistress Lib "APCSDLL.dll" Alias "SaveDistress" (<[In](), Out()> _
    ByRef nImage As Integer, ByRef numCrack As Integer, ByVal numPtCrack() As Integer, _
    ByVal xPixPtCrack(,,) As Integer, ByVal iTypeCrack() As Integer, ByVal lCrack() As Single, _
    ByVal attrbCrack() As Integer, ByVal FileName As String, ByRef lName As Integer)

    Declare Sub ReadDistress Lib "APCSDLL.dll" Alias "ReadDistress" (<[In](), Out()> _
    ByRef nImage As Integer, ByRef numCrack As Integer, ByVal numPtCrack() As Integer, _
    ByVal xPixPtCrack(,,) As Integer, ByVal iTypeCrack() As Integer, ByVal lCrack() As Single, _
    ByVal attrbCrack() As Integer, ByVal FileName As String, ByRef lName As Integer)

    Declare Sub SaveGeo Lib "APCSDLL.dll" Alias "SaveGeo" (<[In](), Out()> _
    ByRef nRefGeo As Integer, ByVal xPixRefGeo(,) As Integer, ByVal coorGeo(,) As Double, _
    ByRef numPDS As Integer, ByVal xPixPDSLine(,,) As Integer, ByVal flagManualPDSLine(,) As Integer, ByVal FileName As String, ByRef lName As Integer)

    Declare Sub ReadGeo Lib "APCSDLL.dll" Alias "ReadGeo" (<[In](), Out()> _
    ByRef nRefGeo As Integer, ByVal xPixRefGeo(,) As Integer, ByVal coorGeo(,) As Double, _
    ByRef numPDS As Integer, ByVal xPixPDSLine(,,) As Integer, ByVal flagManualPDSLine(,) As Integer, ByVal flagNew() As Integer, ByVal FileName As String, ByRef lName As Integer)

    Declare Sub RutDep Lib "APCSDLL.dll" Alias "RutDep" (<[In](), Out()> _
    ByRef nTP As Integer, ByVal nPtTP() As Integer, ByVal xPtTP(,) As Single, ByVal proFlt(,) As Single, ByVal iPtBound(,) As Integer, ByVal RDPara() As Single, ByVal iPtHump(,,) As Integer, ByVal iPtBot(,) As Integer, _
    ByVal RD(,) As Single, ByVal xRod(,) As Single, ByVal zrod(,) As Single)

    Declare Sub ReadTP Lib "APCSDLL.dll" Alias "ReadTP" (<[In](), Out()> _
    ByRef nTP As Integer, ByVal nPtTP() As Integer, ByVal xPtTP(,) As Single, ByVal proTRaw(,) As Single, ByVal dmiTP() As Single, ByVal FileName As String, ByRef lName As Integer)

    Declare Sub SaveTPs Lib "APCSDLL.dll" Alias "SaveTPs" (<[In](), Out()> _
    ByRef nTP As Integer, ByVal nPtTP() As Integer, ByVal xTP(,,) As Single, ByVal DMITP() As Single, ByVal xOffTP() As Single, ByVal factorCrctTP() As Single, ByVal FileName As String, ByRef lName As Integer)

    Declare Sub ReadTPs Lib "APCSDLL.dll" Alias "ReadTPs" (<[In](), Out()> _
    ByRef nTP As Integer, ByVal nPtTP() As Integer, ByVal xTP(,,) As Single, ByVal DMITP() As Single, ByVal xOffTP() As Single, ByVal factorCrctTP() As Single, ByVal FileName As String, ByRef lName As Integer)

    Declare Sub ReadLongPro Lib "APCSDll.dll" Alias "ReadLongPro" (<[In](), Out()> _
    ByRef nRsv As Integer, ByRef nPtPro As Integer, ByVal xPtPro() As Single, ByVal proAll(,) As Single, ByVal boundPro(,) As Single, ByVal FileName As String, ByRef lName As Integer)

    Declare Sub FilterTP Lib "APCSDLL.dll" Alias "FilterTP" (<[In](), Out()> _
    ByRef nTP As Integer, ByVal nPtTP() As Integer, ByVal xPtTP(,) As Single, ByVal proTRaw(,) As Single, ByVal proFlt(,) As Single, ByVal iPtBound(,) As Integer)

    Declare Sub ReadNote Lib "APCSDLL.dll" Alias "ReadNote" (<[In](), Out()> _
    ByRef nNote As Integer, ByVal coorGeo() As Double, ByVal noteGeo As String, ByRef lNote As Integer, ByVal FileName As String, ByRef lName As Integer)

    Declare Sub ReadTRP Lib "APCSDLL.dll" Alias "ReadTRP" (<[In](), Out()> _
    ByRef nTRP As Integer, ByVal nPtTRP() As Integer, ByVal xTRP() As Single, ByVal yTRP(,) As Single, ByVal DMITRP() As Single, ByVal FileName As String, ByRef lName As Integer)

    Dim canvasBM As Bitmap = New Bitmap(800, 800)

    Public FileName As String
    Dim curDir As String
    Dim lName As Integer
    Dim lCurDir As Integer
    Dim brightness As Single = 1
    Dim contrast As Single = 0.00001
    Dim a As Double = 6378137
    Dim b As Double = 6356752.3


    Dim flagLeftButtonDown As Boolean = False

    Dim scrMode As Integer = 0   ' =0 viewing; =1 editing

    Public imageRaw() As Bitmap
    Public nImage As Integer = -1
    Dim fileImage() As String
    Public iImage As Integer


    Dim iCurImage As Integer
    Dim xPixCursor As Integer() = New Integer(1) {}

    Public originImage(,) As Single
    Public sizeImage(,) As Integer
    Public offsetOrigin() As Integer = New Integer(1) {0, 0}
    Dim offsetMouseDown() As Integer = New Integer(1) {0, 0}
    Dim xMouseDown() As Integer = New Integer(1) {}
    Dim flagMouseDown As Integer = 0

    Dim thumbnailFactor() As Single = New Single(3) {2, 4, 8, 16}
    Dim imageTNRaw(,) As Bitmap


    Public scaleXSr2Pix As Single
    Dim scaleYSr2Pix As Single
    Dim factorZoom As Single = 1.2
    Dim XCursor() As Integer = New Integer(1) {}
    Dim timeNow() As Integer = New Integer(8) {}
    Dim sizePreWindow(1) As Integer
    Dim iTimer As Integer
    Dim nTimer As Integer = 10
    Dim timerStep As Single

    ' Global variables related to geoCoordinate points
    Public nRefGeo As Integer = 1
    Dim xPixRefGeo(,) As Integer = New Integer(999, 1) {}
    Public coorGeo(,) As Double = New Double(999, 2) {}
    Public noteGeo(999) As String
    Dim coorGeoCursor() As Double = New Double(1) {}
    Dim linRefGeo(999) As Single
    Public iAnchor As Integer = 0
    Public jAnchor As Integer = 1
    Dim mPerLatD As Double = 110952
    Dim mPerLogD As Double
    Dim xByGeo(,) As Double = New Double(999, 1) {}
    Public mPerPix As Double
    Dim qEast As Single = 0
    Dim cosQEast As Single = 1   ' QEast is the angle of the east direction
    Dim sinQEast As Single = 0
    Dim flagShwDeg As Boolean = True
    Dim tempGeo(2) As Double
    Dim PMDMI0 As Single = 0
    Dim flagPMPositive As Integer = 1
    Public flagPickingAnchor() As Boolean = New Boolean(1) {False, False}
    Public flagAnchored() As Boolean = New Boolean(1) {False, False}
    Public flagAddingRefGeo = False
    Dim flagScaled As Boolean = False


    'All the pens and brushes
    Dim PenLightGreen2 As Pen = New Pen(Color.White, 5)
    Dim PenWhite2 As Pen = New Pen(Color.White, 2)
    Dim PenCL As Pen = New Pen(Color.FromArgb(128, 255, 255, 0), 5)
    Dim dashCL() As Single = New Single(1) {15, 5}
    Dim PenGreen3 As Pen = New Pen(Color.LightGreen, 3)
    Dim brushBack As Brush = Brushes.Black
    Dim penHLPt As Pen = New Pen(Color.Red, 3)
    Dim brushWP As Brush = New SolidBrush(Color.FromArgb(20, 253, 234, 33))
    Dim brushCover As Brush = New SolidBrush(Color.FromArgb(192, 0, 0, 0))
    Dim colorPen() As Color = New Color(11) {Color.Red, Color.Yellow, Color.Snow, Color.Blue, Color.GreenYellow, Color.Pink, Color.Yellow, Color.Snow, Color.Blue, Color.GreenYellow, Color.Pink, Color.Brown}
    Dim brushPH As New SolidBrush(Color.FromArgb(128, 15, 255, 40))
    Dim brushPatch As New SolidBrush(Color.FromArgb(128, 255, 40, 15))
    Dim penSilver4 As New Pen(Color.Goldenrod, 4)





    'Variables related to reference lines
    Dim xPixCL(,) As Integer = New Integer(1, 1) {}
    Dim yPixDMI0 As Integer = 0

    'Variables related to measure
    Dim xPixMeasure(,) As Integer = New Integer(1, 1) {}
    Dim distMeasure As Double
    Dim angMeasure As Double

    'Variables related to magnify
    Public xPixMagCenter() As Integer = New Integer(1) {}
    Public scaleMag As Single = 1


    Public tempBMP As Bitmap

    'Variables related to Pavement Data Segment 
    Dim numPDS As Integer = 0
    Dim maxNumPDS As Integer = 0
    Dim xPixPDSLine(999, 1, 1) As Integer
    Dim flagManualPDSLine(,) As Integer   '=0 this is an automatic point;  =1 manual
    Dim flagPickingDMI0 As Boolean = False
    Dim iCurPDSLine As Integer = 0
    Dim iCurPDSPt As Integer = 0   '=0 left point; =1 rright point
    Dim xPixCursorDown() As Integer = New Integer(1) {}
    Dim xPixTempPt() As Integer = New Integer(1) {}
    Dim PMPDS() As Single
    Dim geoPDS(,) As Double
    Dim xPixPDSLineCenter(999, 1) As Integer   ' the number of slabs should be smaller than 1000
    Dim yPixIncPDS(999) As Integer
    Dim iCurSlb As Integer = 0


    'Variables related to cracks
    Dim numCrack As Integer = -1
    Dim numPtCrack() As Integer
    Dim xPixPtCrack(,,) As Integer
    Dim iPDSCrack() As Integer
    Dim iTypeCrack() As Integer  '=0 cracked deleted; =1 transverse; =2 longitudinal; =3 left wheelpath; =4  XF; =5 patch; =6 pothole
    '=7 rigid longitudinal crack; =8 rigid transverse; =9 corner crack; =10 XJ crack; =11 patch
    Dim lCrack() As Single
    Dim nCrackPDS() As Integer
    Dim iCrackPDS(,) As Integer
    Dim iCurPDS As Integer = 0
    Dim iCurCType As Integer = 0
    Dim iCurCrack As Integer = 0
    Dim attrbCrack() As Integer = New Integer(0) {} ' =0 sealed; =1 unsealed narrow; =2 unsealed wide
    ' =3  sealed+spalled; =4 sealed+not spalled; =5 not sealed+spalled; =6 not sealed+not spalled
    Dim flagAddingPH As Boolean = False
    Dim iTempCrack As Integer = 0


    ' Variables related to transverse profiles
    Public nTP As Integer = -1
    Public nPtTP(999) As Integer
    Public xPtTP(999, 9999) As Single
    Public proTRaw(999, 9999) As Single
    Dim dmiTP(999) As Single
    Public proFlt(999, 9999) As Single
    Public iCurTP As Integer = -1
    Public iPtBound(999, 6) As Integer
    Public xOffTP(999) As Single


    Dim datum As Single
    Public factorCrctTP(99) As Single
    Public RDPara() As Single = New Single(3) {0.001, 0.9, 10, 0}
    Public iPtHump(999, 1, 1) As Integer
    Public iPtBot(999, 1) As Integer
    Public RD(999, 1) As Single
    Public flagPlotRD As Boolean = False
    Public xRod(999, 5) As Single
    Public zRod(999, 5) As Single


    'variables related to longitudinal profiles
    Dim nRsv As Integer = 500000
    Dim nPtPro As Integer
    Dim xPtPro(nRsv - 1) As Single
    Dim proAll(9, nRsv - 1) As Single
    Dim boundPro(9, 1) As Single
    Dim proScale As Single = 10
    Dim intvPt As Single
    Dim iPtEnd(1) As Integer

    'Variables related to Fugro TRP transverse profiles
    Dim nTRP As Integer
    Dim nPtTRP(9999) As Integer
    Dim xTRP(999) As Single
    Dim yTRP(9999, 999) As Single
    Dim DMITRP(9999) As Single
    Dim iTRP As Integer


    'Variables related to notes
    Dim nNote As Integer
    Dim temGeo(1) As Double
    Dim tempNote As String = "                                                                                                    "
    Dim lNote As Integer = 100

    ' Variables related to ROW images
    Public imgROW() As Bitmap
    Public numROW As Integer
    Public listROW() As String










    Private Sub APCSView_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Overlay.Parent = Canvas
        Overlay.Location = New Point(0, 0)
        Overlay.Width = Canvas.Width
        Overlay.Height = Canvas.Height
        Overlay.BackColor = Color.Transparent
        sizePreWindow(0) = Me.Width
        sizePreWindow(1) = Me.Height
        Dim canvasBM As Bitmap = New Bitmap(Canvas.Width, Canvas.Height)

        'IniProjWizard.ShowDialog()



    End Sub


    Private Sub btnImpList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpList.Click

        Dim dist As Double() = New Double(1) {}
        dlgOpenFile.Filter = "layout files (*.lay)|*.lay|All files (*.*)|*.*"


        If dlgOpenFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            FileName = dlgOpenFile.FileName
            Dim sr As StreamReader = New StreamReader(dlgOpenFile.FileName)
            nImage = Convert.ToInt32(sr.ReadLine) - 1
            lCurDir = FileName.LastIndexOfAny("\") + 1
            curDir = FileName.Substring(0, lCurDir)

            Me.Text = "CaPCIV UCPRC " & curDir
            ReDim imageRaw(nImage)
            ReDim originImage(nImage, 1)
            ReDim sizeImage(nImage, 1)
            ReDim fileImage(nImage)
            ReDim imageTNRaw(nImage, 3)

            ReDim numPtCrack(nImage * 1000 - 1)
            ReDim xPixPtCrack(nImage * 1000 - 1, 19, 1)
            ReDim iPDSCrack(nImage * 1000 - 1)
            ReDim iTypeCrack(nImage * 1000 - 1)
            ReDim lCrack(nImage * 1000 - 1)
            ReDim attrbCrack(nImage * 1000 - 1)


            prgLoading.Maximum = nImage * 2
            message.AppendText("Loading images: " & Environment.NewLine)

            ' For i As Integer = 0 To numROW
            'tempFile = sr.ReadLine
            'infoFile = My.Computer.FileSystem.GetFileInfo(tempFile)
            'imgROW(i) = Bitmap.FromFile(tempFile)
            'listROW(i) = infoFile.Name
            'prgLoading.Value = i

            Dim infoFile As System.IO.FileInfo
            For iImage As Integer = 0 To nImage

                fileImage(iImage) = sr.ReadLine
                If Not fileImage(iImage).Contains("\") Then  ' if only the file name (not including the path) is given
                    fileImage(iImage) = curDir & fileImage(iImage)
                End If
                infoFile = My.Computer.FileSystem.GetFileInfo(fileImage(iImage))

                prgLoading.Value = iImage

                message.AppendText("Loading image: " & infoFile.Name & Environment.NewLine)

                imageRaw(iImage) = New Bitmap(fileImage(iImage))
                sizeImage(iImage, 0) = imageRaw(iImage).Width
                sizeImage(iImage, 1) = imageRaw(iImage).Height


                If iImage = 0 Then
                    originImage(iImage, 0) = 0
                    originImage(iImage, 1) = imageRaw(iImage).Height
                Else
                    originImage(iImage, 0) = 0
                    originImage(iImage, 1) = originImage(iImage - 1, 1) + sizeImage(iImage - 1, 1)
                End If

            Next



            scaleXSr2Pix = Canvas.Width / sizeImage(0, 0)
            scaleYSr2Pix = Canvas.Width / sizeImage(0, 0)
            '    Canvas.Height = (originImage(nImage, 1) + sizeImage(nImage, 1)) * scaleSr2Pix

            offsetOrigin(0) = 0
            offsetOrigin(1) = Canvas.Height

            xPixCL(0, 0) = imageRaw(0).Width / 2
            xPixCL(0, 1) = 0
            xPixCL(1, 0) = imageRaw(nImage).Width / 2
            xPixCL(1, 1) = originImage(nImage, 1)



            scrlCanvas.Minimum = Math.Min((Canvas.Height - originImage(nImage, 1) * scaleYSr2Pix) / 10, 0)
            scrlCanvas.Value = Math.Max(Math.Min((Canvas.Height - offsetOrigin(1)) / 10, scrlCanvas.Maximum), scrlCanvas.Minimum)

            sr.Close()
            Call GenerateTN()


            Overlay.Invalidate()

        End If   ' If lName > 1 Then

    End Sub


    Private Sub GenerateTN()
        For j As Integer = 0 To 3
            message.AppendText("Creating thumbnails" & " 1:" & thumbnailFactor(j).ToString & Environment.NewLine)

            For i As Integer = 0 To nImage
                Dim tempImage As Bitmap = New Bitmap(Convert.ToInt32(imageRaw(i).Width / thumbnailFactor(j)), Convert.ToInt32(imageRaw(i).Height / thumbnailFactor(j)), PixelFormat.Format16bppRgb565)
                ' Note: the pixelformat will affect the use of memory.  Ideally, we would like to use 8bit index for downward images (which is gray scale) but the drawimage method used to create
                '       the thumbnails does not take indexed pixel format.  If use 16 bit grayscale, it will throw a outofmemory error.

                Dim TNPaint As Graphics = Graphics.FromImage(tempImage)
                TNPaint.DrawImage(imageRaw(i), 0, 0, tempImage.Width, tempImage.Height) ', GraphicsUnit.Pixel, )

                imageTNRaw(i, j) = tempImage

                prgLoading.Value = nImage + nImage / 4 * j + 1 / 4 * (i + 1)
                'tempImage.Dispose()
                ' TNPaint.Dispose()
            Next


        Next

        prgLoading.Visible = False

    End Sub


    Private Sub Canvas_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Canvas.Paint



        Dim CanvasPaint As Graphics = e.Graphics
        Dim imageAttri As ImageAttributes = New ImageAttributes()
        Dim DRect As Rectangle
        Dim cm As ColorMatrix

        cm = New ColorMatrix(New Single()() { _
        New Single() {brightness, 0.0, 0.0, 0.0, 0.0}, _
        New Single() {0.0, brightness, 0.0, 0.0, 0.0}, _
        New Single() {0.0, 0.0, brightness, 0.0, 0.0}, _
        New Single() {0.0, 0.0, 0.0, 1.0, 0.0}, _
        New Single() {contrast, contrast, contrast, 0, 1.0}})
        'imageAttri.SetGamma(set1Gamma.Value)
        imageAttri.SetColorMatrix(cm)
        timeNow(0) = timeGetTime


        'draw the surface image
        If nImage > -1 And (Not chkHideImages.Checked) Then
            If Math.Max(scaleXSr2Pix, scaleYSr2Pix) > 1 Then
                For iImage As Integer = 0 To nImage
                    DRect = New Rectangle(xPix2Scr(originImage(iImage, 0)), yPix2Scr(originImage(iImage, 1)), sizeImage(iImage, 0) * scaleXSr2Pix, sizeImage(iImage, 1) * scaleYSr2Pix)
                    If chkImageAdj.Checked Then
                        CanvasPaint.DrawImage(imageRaw(iImage), DRect, 0, 0, imageRaw(iImage).Width, imageRaw(iImage).Height, GraphicsUnit.Pixel, imageAttri)
                    Else
                        CanvasPaint.DrawImage(imageRaw(iImage), DRect, 0, 0, imageRaw(iImage).Width, imageRaw(iImage).Height, GraphicsUnit.Pixel)
                    End If

                Next
            Else

                Dim j As Integer

                j = Math.Max(Math.Min(-Math.Log(Math.Max(scaleXSr2Pix, scaleYSr2Pix)) / Math.Log(2) - 1, 3), 0)
                For iImage As Integer = 0 To nImage
                    DRect = New Rectangle(xPix2Scr(originImage(iImage, 0)), yPix2Scr(originImage(iImage, 1)), sizeImage(iImage, 0) * scaleXSr2Pix, Math.Truncate(sizeImage(iImage, 1) * scaleYSr2Pix) + 1)
                    If chkImageAdj.Checked Then
                        CanvasPaint.DrawImage(imageTNRaw(iImage, j), DRect, 0, 0, imageTNRaw(iImage, j).Width, imageTNRaw(iImage, j).Height, _
                                              GraphicsUnit.Pixel, imageAttri)
                    Else
                        CanvasPaint.DrawImage(imageTNRaw(iImage, j), DRect, 0, 0, imageTNRaw(iImage, j).Width, imageTNRaw(iImage, j).Height, _
                                              GraphicsUnit.Pixel)
                    End If
                Next



            End If

        End If

        ' draw the compass
        If chkShowCompass.Checked = True Then
            CanvasPaint.DrawLine(PenLightGreen2, Convert.ToSingle(Canvas.Width - 100 + 50 * Math.Cos(qEast + Math.PI / 2)), Convert.ToSingle(100 - 50 * Math.Sin(qEast + Math.PI / 2)), Convert.ToSingle(Canvas.Width - 100 + 50 * Math.Cos(qEast + Math.PI / 2 + 3)), Convert.ToSingle(100 - 50 * Math.Sin(qEast + Math.PI / 2 + 3)))
            CanvasPaint.DrawLine(PenLightGreen2, Convert.ToSingle(Canvas.Width - 100 + 50 * Math.Cos(qEast + Math.PI / 2)), Convert.ToSingle(100 - 50 * Math.Sin(qEast + Math.PI / 2)), Convert.ToSingle(Canvas.Width - 100 + 50 * Math.Cos(qEast + Math.PI / 2 - 3)), Convert.ToSingle(100 - 50 * Math.Sin(qEast + Math.PI / 2 - 3)))
            CanvasPaint.DrawEllipse(PenLightGreen2, Canvas.Width - 150, 50, 100, 100)
        End If

        ' Update ROW image
        If chkShowROW.Checked Then
            Dim iROW As Integer
            iROW = yScr2Pix(Canvas.Height / 2) \ sizeImage(0, 1)
            ROWWindow.pixROW.Image = imgROW(Math.Max(Math.Min((iROW + ROWWindow.lagROWPav), numROW), 0))
            ROWWindow.Text = "ROW Image: " & listROW(Math.Max(Math.Min((iROW + ROWWindow.lagROWPav), numROW), 0))
        End If



    End Sub

    Private Sub Overlay_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Overlay.MouseDoubleClick



        'Add anchor
        If e.Button = Windows.Forms.MouseButtons.Left And flagPickingAnchor(0) Then
            NewLogLat.ShowDialog()
            If NewLogLat.DialogResult = Windows.Forms.DialogResult.OK Then
                xPixRefGeo(0, 0) = xScr2Pix(e.X)
                xPixRefGeo(0, 1) = yScr2Pix(e.Y)
                flagAnchored(0) = True
                btnAnchorA.BackColor = Color.SkyBlue
                btnAnchorA.Text = "Anchor A"
            Else
                flagPickingAnchor(0) = False
                btnAnchorA.Text = "Anchor A"
                If flagAnchored(0) = True Then
                    btnAnchorA.BackColor = Color.SkyBlue
                Else
                    btnAnchorA.BackColor = Color.Brown
                End If

            End If
        End If

        If e.Button = Windows.Forms.MouseButtons.Left And flagPickingAnchor(1) Then
            NewLogLat.ShowDialog()
            If NewLogLat.DialogResult = Windows.Forms.DialogResult.OK Then
                xPixRefGeo(1, 0) = xScr2Pix(e.X)
                xPixRefGeo(1, 1) = yScr2Pix(e.Y)
                flagAnchored(1) = True
                btnAnchorB.BackColor = Color.SkyBlue
                btnAnchorB.Text = "Anchor B"
            Else
                flagPickingAnchor(1) = False
                btnAnchorB.Text = "Anchor A"
                If flagAnchored(1) = True Then
                    btnAnchorB.BackColor = Color.SkyBlue
                Else
                    btnAnchorB.BackColor = Color.Brown
                End If

            End If
        End If





        'Pick geo-reference point for map
        If chkShowMap.Checked And scrMode = 0 Then
            Call xPix2Geo(xScr2Pix(e.X), yScr2Pix(e.Y), coorGeoCursor)
            MapWindow.mapBrow.Navigate("http://maps.google.com/maps?q=" & coorGeoCursor(1).ToString("F08") & "," & coorGeoCursor(0).ToString("F08"))
        End If

        'Picking the DMI=0 point
        If chkPickDMI0.Checked Then
            yPixDMI0 = yScr2Pix(e.Y)
            If rbTypeFlx.Checked Then
                Call iniPDSFlx(yPixDMI0)
            Else

                Call iniPDSRgd(yPixDMI0)

            End If

            chkPickDMI0.Checked = False
        End If



        'Finish adding the current crack
        If e.Button = Windows.Forms.MouseButtons.Left And (chkAddingCrack.Checked Or chkAddRgdDtrs.Checked) And iCurCType > 0 And iCurCType <> 6 Then
            Dim xPixCentDtrs(1) As Integer  ' centroid of a crack/patch to determine which slab this distress belongs to
            numCrack += 1
            If chkAddingCrack.Checked Then
                iPDSCrack(numCrack) = iCurPDS
            End If
            If rbTypeRigid.Checked Then
                For i As Integer = 0 To numPtCrack(numCrack)
                    xPixCentDtrs(0) += xPixPtCrack(numCrack, i, 0)
                    xPixCentDtrs(1) += xPixPtCrack(numCrack, i, 1)
                Next
                xPixCentDtrs(0) = xPixCentDtrs(0) / (numPtCrack(numCrack) + 1)
                xPixCentDtrs(1) = xPixCentDtrs(1) / (numPtCrack(numCrack) + 1)
                iCurPDS = CurSlab(xPixCentDtrs(0), xPixCentDtrs(1))
            End If
            iTypeCrack(numCrack) = iCurCType
            nCrackPDS(iCurPDS) += 1
            iCrackPDS(iCurPDS, nCrackPDS(iCurPDS)) = numCrack
            numPtCrack(numCrack + 1) = -1
            attrbCrack(numCrack) = CrackAttrb()

            If iCurCType <= 4 Or (iCurCType > 6 And iCurCType < 11) Then
                lCrack(numCrack) = LengthCrack(numCrack)
            End If

            If iCurCType = 5 Or iCurCType = 11 Then
                numPtCrack(numCrack) += 1
                xPixPtCrack(numCrack, numPtCrack(numCrack), 0) = xPixPtCrack(numCrack, 0, 0)
                xPixPtCrack(numCrack, numPtCrack(numCrack), 1) = xPixPtCrack(numCrack, 0, 1)
                lCrack(numCrack) = AreaPolygon(numCrack)

            End If
        End If

        'Pick the current crack
        If chkEditCrack.Checked Or chkEditRgdDtrs.Checked Then
            iCurCrack = iTempCrack
            If chkEditCrack.Checked And iTypeCrack(iCurCrack) > 0 And iTypeCrack(iCurCrack) <= 6 Then
                ShowFlxCrkAttrb()
            End If
            If chkEditRgdDtrs.Checked And iTypeCrack(iCurCrack) > 6 And iTypeCrack(iCurCrack) <= 11 Then
                ShowRgdCrkAttrb()
            End If
        End If



        Overlay.Invalidate()
    End Sub



    Private Sub Overlay_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Overlay.Paint
        Dim OverlayPaint As Graphics = e.Graphics




        If chkShowRefGeo.Checked Then
            Call DrawRefGeo(OverlayPaint)
        End If

        If chkShowCL.Checked Then
            Call DrawCL(OverlayPaint)
        End If

        If chkShowFiles.Checked Then
            Call DrawFiles(OverlayPaint)
        End If

        If chkMeasure.Checked Then
            Call DrawMeasure(OverlayPaint)
        End If

        If chkMag.Checked Then
            Call DrawMagZone(OverlayPaint)
        End If

        If chkAdjLaneBound.Checked And rbTypeFlx.Checked Then
            OverlayPaint.DrawEllipse(penHLPt, xPix2Scr(xPixPDSLine(iCurPDSLine, iCurPDSPt, 0)) - 3, yPix2Scr(xPixPDSLine(iCurPDSLine, iCurPDSPt, 1)) - 3, 7, 7)
        End If

        If chkAdjLaneBound.Checked And rbTypeRigid.Checked Then
            OverlayPaint.DrawEllipse(penHLPt, xPix2Scr(xPixPDSLineCenter(iCurSlb, 0)) - 3, yPix2Scr(xPixPDSLineCenter(iCurSlb, 1)) - 3, 7, 7)
        End If

        If chkAddingCrack.Checked Or chkEditCrack.Checked Or chkAddRgdDtrs.Checked Or chkEditRgdDtrs.Checked Then
            Drawcover(OverlayPaint)
        End If

        If chkShowCrack.Checked Then
            DrawCrack(OverlayPaint)
        End If

        If chkEditCrack.Checked Or chkEditRgdDtrs.Checked Then
            OverlayPaint.DrawEllipse(penHLPt, xPix2Scr(xPixPtCrack(iTempCrack, 0, 0)) - 3, yPix2Scr(xPixPtCrack(iTempCrack, 0, 1)) - 3, 7, 7)

        End If

        If chkShowTP.Checked Then
            TransProfile.Invalidate()
        End If

  
        If chkShowLongPro.Checked Then
            DrawLongPro(OverlayPaint)
        End If

        If chkShowAllTP.Checked Then
            DrawAllTP(OverlayPaint)
        End If

        If chkShowTPR.Checked Then
            DrawTPR(OverlayPaint)
        End If
    End Sub

    Private Sub APCSView_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged

        Canvas.Width = Math.Max(Me.Width, 1024) - 302
        Canvas.Height = Math.Max(Me.Height, 768) - 70
        message.Height = Me.Height - 671
        Overlay.Width = Canvas.Width
        Overlay.Height = Canvas.Height
        offsetOrigin(0) += (Me.Width - sizePreWindow(0)) / 2
        offsetOrigin(1) += (Me.Height - sizePreWindow(1)) / 2
        sizePreWindow(0) = Me.Width
        sizePreWindow(1) = Me.Height
        scrlCanvas.Height = Canvas.Height
        Dim canvasBM As Bitmap = New Bitmap(Canvas.Width, Canvas.Height)

        Overlay.Invalidate()
    End Sub

    Private Sub setZoomFactor_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setZoomFactor.ValueChanged
        factorZoom = setZoomFactor.Value
        Overlay.Focus()
    End Sub

    Private Sub btnZoomIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZoomIn.Click
        scaleXSr2Pix *= factorZoom
        scaleYSr2Pix *= factorZoom
        offsetOrigin(0) = Canvas.Width / 2 - (Canvas.Width / 2 - offsetOrigin(0)) * factorZoom
        offsetOrigin(1) = Canvas.Height / 2 - (Canvas.Height / 2 - offsetOrigin(1)) * factorZoom   ' to keep the center the same place on the screen
        AdjustScrolBar()

        Overlay.Invalidate()

    End Sub

    Private Sub btnZoomOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZoomOut.Click
        scaleXSr2Pix /= factorZoom
        scaleYSr2Pix /= factorZoom
        offsetOrigin(0) = Canvas.Width / 2 - (Canvas.Width / 2 - offsetOrigin(0)) / factorZoom
        offsetOrigin(1) = Canvas.Height / 2 - (Canvas.Height / 2 - offsetOrigin(1)) / factorZoom   ' to keep the center the same place on the screen
        AdjustScrolBar()

        Overlay.Invalidate()

    End Sub



    Private Sub Overlay_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Overlay.MouseDown
        'warning: select pavement type
        If rbTypeFlx.Checked = False And rbTypeRigid.Checked = False Then
            MessageBox.Show("Please select pavement surface type first.")
            rbTypeFlx.BackColor = Color.RoyalBlue
            rbTypeRigid.BackColor = Color.RoyalBlue

        Else


            If rbTypeFlx.Checked And flagScaled Then
                iCurPDS = Math.Min(Math.Max(Math.Truncate((yScr2Pix(e.Y) - yPixDMI0) / (10 / mPerPix)), 0), numPDS - 1)
            End If

            If rbTypeRigid.Checked Then
                iCurPDS = CurSlab(xScr2Pix(e.X), yScr2Pix(e.Y))
            End If

            If e.Button = Windows.Forms.MouseButtons.Right And chkMeasure.Checked = False Then
                flagMouseDown = 1
                offsetMouseDown(0) = offsetOrigin(0)
                offsetMouseDown(1) = offsetOrigin(1)
                xMouseDown(0) = e.X
                xMouseDown(1) = e.Y

            End If

            If e.Button = Windows.Forms.MouseButtons.Right And chkMeasure.Checked Then
                xPixMeasure(0, 0) = xScr2Pix(e.X)
                xPixMeasure(0, 1) = yScr2Pix(e.Y)

            End If


            ' Adjust flexible land boundary
            If e.Button = Windows.Forms.MouseButtons.Left And chkAdjLaneBound.Checked And rbTypeFlx.Checked Then
                flagLeftButtonDown = True
                xPixCursorDown(0) = xScr2Pix(e.X)
                xPixCursorDown(1) = yScr2Pix(e.Y)
                xPixTempPt(0) = xPixPDSLine(iCurPDSLine, iCurPDSPt, 0)
                xPixTempPt(1) = xPixPDSLine(iCurPDSLine, iCurPDSPt, 1)
                flagManualPDSLine(iCurPDSLine, iCurPDSPt) = 1

            End If


            'Adjust slab size
            If e.Button = Windows.Forms.MouseButtons.Left And chkAdjLaneBound.Checked And rbTypeRigid.Checked Then
                flagLeftButtonDown = True
                xPixCursorDown(0) = xScr2Pix(e.X)
                xPixCursorDown(1) = yScr2Pix(e.Y)
                xPixTempPt(0) = xPixPDSLineCenter(iCurSlb, 0)
                xPixTempPt(1) = xPixPDSLineCenter(iCurSlb, 1)
                flagManualPDSLine(iCurSlb, 1) = 1

            End If




            If e.Button = Windows.Forms.MouseButtons.Left And (chkAddingCrack.Checked Or chkAddRgdDtrs.Checked) And iCurCType > 0 And iCurCType <> 6 And numPtCrack(numCrack + 1) = -1 Then
                iCurCrack = numCrack + 1
            End If


            'Pick the center of a pothole
            If e.Button = Windows.Forms.MouseButtons.Left And chkAddingCrack.Checked And iCurCType = 6 Then
                flagAddingPH = True
                numCrack += 1
                xPixPtCrack(numCrack, 0, 0) = xScr2Pix(e.X)
                xPixPtCrack(numCrack, 0, 1) = yScr2Pix(e.Y)
                iTypeCrack(numCrack) = 6
                nCrackPDS(iCurPDS) += 1
                iCrackPDS(iCurPDS, nCrackPDS(iCurPDS)) = numCrack
                iPDSCrack(numCrack) = iCurPDS
                nCrackPDS(iCurPDS) += 1
                iCrackPDS(iCurPDS, nCrackPDS(iCurPDS)) = numCrack
            End If
        End If
    End Sub

    Private Sub Overlay_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Overlay.MouseClick

        ' Add a crack or a patch
        If e.Button = Windows.Forms.MouseButtons.Left And (chkAddingCrack.Checked Or chkAddRgdDtrs.Checked) And iCurCType > 0 And iCurCType <> 6 Then
            numPtCrack(numCrack + 1) += 1
            xPixPtCrack(numCrack + 1, numPtCrack(numCrack + 1), 0) = xScr2Pix(e.X)
            xPixPtCrack(numCrack + 1, numPtCrack(numCrack + 1), 1) = yScr2Pix(e.Y)
            Overlay.Invalidate()
        End If

        'Cancel adding crack
        If e.Button = Windows.Forms.MouseButtons.Middle And (chkAddingCrack.Checked Or chkAddRgdDtrs.Checked) And iCurCType > 0 And iCurCType <> 6 Then
            numPtCrack(numCrack + 1) = -1
        End If



    End Sub

    Private Sub Overlay_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Overlay.MouseMove

        'Drag the image on canvas
        If flagMouseDown = 1 Then
            offsetOrigin(0) = offsetMouseDown(0) + e.X - xMouseDown(0)
            offsetOrigin(1) = offsetMouseDown(1) + e.Y - xMouseDown(1)
            Overlay.Invalidate()
        End If




        'Show the long and lat of the mouse cursor location
        If chkShowCursorGeo.Checked Then
            Call xPix2Geo(xScr2Pix(e.X), yScr2Pix(e.Y), coorGeoCursor)
            Dim degree As Integer
            Dim minute As Integer
            Dim second As Single

            If flagShwDeg = True Then
                txtLongi.Text = coorGeoCursor(0).ToString("F08")
                txtLati.Text = coorGeoCursor(1).ToString("F08")
            Else
                Call Ang2MinSec(coorGeoCursor(0), degree, minute, second)
                txtLongi.Text = degree.ToString & "d " & minute.ToString & "' " & second.ToString("F02") & "''"
                Call Ang2MinSec(coorGeoCursor(1), degree, minute, second)
                txtLati.Text = degree.ToString & "d " & minute.ToString & "' " & second.ToString("F02") & "''"
            End If
            lbDMI.Text = "DMI=" & ((yScr2Pix(e.Y) - yPixDMI0) * mPerPix).ToString("F02") & " m"
            lbPM.Text = "PM" & (setPMDMI0.Value + ((yScr2Pix(e.Y) - yPixDMI0) * mPerPix) / 1609).ToString("F04")


        End If

        ' On screen measure
        If chkMeasure.Checked Then
            xPixMeasure(1, 0) = xScr2Pix(e.X)
            xPixMeasure(1, 1) = yScr2Pix(e.Y)

            distMeasure = Math.Sqrt((xPixMeasure(1, 0) - xPixMeasure(0, 0)) ^ 2 + (xPixMeasure(1, 1) - xPixMeasure(0, 1)) ^ 2) * mPerPix
            angMeasure = Math.Acos((xPixMeasure(1, 0) - xPixMeasure(0, 0)) / distMeasure * mPerPix) / Math.PI * 180
            If (xPixMeasure(1, 1) - xPixMeasure(0, 1)) < 0 Then
                angMeasure = -angMeasure
            End If

            Overlay.Invalidate()

        End If

        'Magnify zone
        If chkMag.Checked Then
            xPixMagCenter(0) = xScr2Pix(e.X)
            xPixMagCenter(1) = yScr2Pix(e.Y)
            Overlay.Invalidate()
            MagnifyWindow.canvasMag.Invalidate()

        End If


        'Locate current PSD point
        If chkAdjLaneBound.Checked And rbTypeFlx.Checked Then
            xPixCursor(0) = xScr2Pix(e.X)
            xPixCursor(1) = yScr2Pix(e.Y)
            Call LocateCurPSDLine(xPixCursor)
            Overlay.Invalidate()
        End If

        'Locate the current slab
        If chkAdjLaneBound.Checked And rbTypeRigid.Checked Then
            xPixCursor(0) = xScr2Pix(e.X)
            xPixCursor(1) = yScr2Pix(e.Y)
            Call LocateCurSlbLine(xPixCursor)
            Overlay.Invalidate()
        End If


        ' Adjusting lane boundaries

        If chkAdjLaneBound.Checked And flagLeftButtonDown = True And rbTypeFlx.Checked Then
            xPixPDSLine(iCurPDSLine, iCurPDSPt, 0) = xPixTempPt(0) + xScr2Pix(e.X) - xPixCursorDown(0)
            UpdatePDSLines()

            Overlay.Invalidate()
        End If

        ' Adjusting slab boundaries
        If chkAdjLaneBound.Checked And flagLeftButtonDown = True And rbTypeRigid.Checked Then
            xPixPDSLineCenter(iCurSlb, 1) = xPixTempPt(1) + yScr2Pix(e.Y) - xPixCursorDown(1)
            UpdateSlab()
            LastPDS()

        End If


        'pick the second point of a pothole

        If e.Button = Windows.Forms.MouseButtons.Left And chkAddingCrack.Checked And iCurCType = 6 And flagAddingPH = True Then
            xPixPtCrack(numCrack, 1, 0) = xScr2Pix(e.X)
            xPixPtCrack(numCrack, 1, 1) = yScr2Pix(e.Y)
            lCrack(numCrack) = Math.Sqrt((xPixPtCrack(numCrack, 1, 0) - xPixPtCrack(numCrack, 0, 0)) ^ 2 + (xPixPtCrack(numCrack, 1, 1) - xPixPtCrack(numCrack, 0, 1)) ^ 2)
            Overlay.Invalidate()
        End If

        'When editing cracks, locate the nearest point to mouse cursor
        If chkEditCrack.Checked Or chkEditRgdDtrs.Checked Then
            xPixCursor(0) = xScr2Pix(e.X)
            xPixCursor(1) = yScr2Pix(e.Y)
            If rbTypeFlx.Checked Then
                iCurPDS = Math.Min(Math.Max(Math.Truncate((xPixCursor(1) - yPixDMI0) / (10 / mPerPix)), 0), numPDS - 1)
            Else
                iCurPDS = CurSlab(xPixCursor(0), xPixCursor(1))
            End If
            Call LocateCurCrack(xPixCursor, iCurPDS)
            Overlay.Invalidate()
        End If





    End Sub

    Private Sub Overlay_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Overlay.MouseUp
        flagMouseDown = 0
        AdjustScrolBar()
        flagLeftButtonDown = False
        If flagAddingPH And iCurCType = 6 Then
            flagAddingPH = False
            numPtCrack(numCrack) = 1
            numPtCrack(numCrack + 1) = -1

        End If
        Overlay.Invalidate()

    End Sub

    Private Sub APCSView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        flagMouseDown = 0
    End Sub

    Private Sub btnFitScr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFitScr.Click
        scaleXSr2Pix = Canvas.Height / originImage(nImage, 1)
        scaleYSr2Pix = Canvas.Height / originImage(nImage, 1)
        offsetOrigin(0) = (Canvas.Width - sizeImage(0, 0) * scaleXSr2Pix) / 2
        offsetOrigin(1) = Canvas.Height
        AdjustScrolBar()

        Overlay.Invalidate()
    End Sub

    Private Function xScr2Pix(ByVal xScr As Integer) As Single
        xScr2Pix = (xScr - offsetOrigin(0)) / scaleXSr2Pix
    End Function

    Private Function yScr2Pix(ByVal yScr As Integer) As Single
        yScr2Pix = (offsetOrigin(1) - yScr) / scaleYSr2Pix
    End Function
    Private Function xPix2Scr(ByVal xPix As Integer) As Single
        xPix2Scr = xPix * scaleXSr2Pix + offsetOrigin(0)
    End Function
    Private Function yPix2Scr(ByVal yPix As Integer) As Single
        yPix2Scr = -yPix * scaleYSr2Pix + offsetOrigin(1)
    End Function
    Private Function yDMI2Scr(ByVal DMI As Single) As Single
        yDMI2Scr = yPix2Scr(DMI / mPerPix + yPixDMI0)
    End Function
    Private Function xPro2Scr(ByVal yPro As Single) As Single
        xPro2Scr = Math.Min(Canvas.Width - 100, Canvas.Width * 0.85) + yPro * proScale
    End Function
    Private Function yScr2DMI(ByVal yScr As Single) As Single
        yScr2DMI = (yScr2Pix(yScr) - yPixDMI0) * mPerPix
    End Function
    Private Function x2Scr(ByVal x As Single) As Single
        x2Scr = xPix2Scr(x / mPerPix)
    End Function


    Private Sub DrawRefGeo(ByRef graphOverlay As Graphics)
        Dim degree As Integer
        Dim minute As Integer
        Dim second As Single
        Dim tempTxtLong As String
        Dim tempTxtLati As String

        For iRefGeo As Integer = 0 To nRefGeo

            If flagShwDeg = True Then
                tempTxtLong = coorGeo(iRefGeo, 0).ToString("F08")
                tempTxtLati = coorGeo(iRefGeo, 1).ToString("F08")
            Else
                Call Ang2MinSec(coorGeo(iRefGeo, 0), degree, minute, second)
                tempTxtLong = "-" & degree.ToString & "d " & minute.ToString & "' " & second.ToString("F02") & "''"
                Call Ang2MinSec(coorGeo(iRefGeo, 1), degree, minute, second)
                tempTxtLati = degree.ToString & "d " & minute.ToString & "' " & second.ToString("F02") & "''"
            End If

            If iRefGeo = iAnchor Or iRefGeo = jAnchor Then
                graphOverlay.DrawEllipse(Pens.Red, xPix2Scr(xPixRefGeo(iRefGeo, 0)) - 3, yPix2Scr(xPixRefGeo(iRefGeo, 1)) - 3, 7, 7)
                graphOverlay.DrawString(tempTxtLong, Me.Font, Brushes.Red, xPix2Scr(xPixRefGeo(iRefGeo, 0)) + 10, yPix2Scr(xPixRefGeo(iRefGeo, 1)))
                graphOverlay.DrawString(tempTxtLati, Me.Font, Brushes.Red, xPix2Scr(xPixRefGeo(iRefGeo, 0)) + 10, yPix2Scr(xPixRefGeo(iRefGeo, 1)) + 20)
                graphOverlay.DrawString(noteGeo(iRefGeo), Me.Font, Brushes.Red, xPix2Scr(xPixRefGeo(iRefGeo, 0)) + 10, yPix2Scr(xPixRefGeo(iRefGeo, 1)) + 40)
            Else

                graphOverlay.FillRectangle(Brushes.DimGray, xPix2Scr(xPixRefGeo(iRefGeo, 0)), yPix2Scr(xPixRefGeo(iRefGeo, 1)), 105, 60)
                graphOverlay.DrawEllipse(Pens.Yellow, xPix2Scr(xPixRefGeo(iRefGeo, 0)) - 3, yPix2Scr(xPixRefGeo(iRefGeo, 1)) - 3, 7, 7)
                graphOverlay.DrawString(tempTxtLong, Me.Font, Brushes.Orange, xPix2Scr(xPixRefGeo(iRefGeo, 0)) + 10, yPix2Scr(xPixRefGeo(iRefGeo, 1)))
                graphOverlay.DrawString(tempTxtLati, Me.Font, Brushes.Orange, xPix2Scr(xPixRefGeo(iRefGeo, 0)) + 10, yPix2Scr(xPixRefGeo(iRefGeo, 1)) + 20)
                graphOverlay.DrawString(noteGeo(iRefGeo), Me.Font, Brushes.Orange, xPix2Scr(xPixRefGeo(iRefGeo, 0)) + 10, yPix2Scr(xPixRefGeo(iRefGeo, 1)) + 40)
            End If

        Next
    End Sub

    Private Sub DrawMeasure(ByRef graphOverlay As Graphics)

        graphOverlay.DrawLine(PenWhite2, xPix2Scr(xPixMeasure(0, 0)), yPix2Scr(xPixMeasure(0, 1)), xPix2Scr(xPixMeasure(1, 0)), yPix2Scr(xPixMeasure(1, 1)))
        graphOverlay.DrawLine(Pens.Black, xPix2Scr(xPixMeasure(0, 0)), yPix2Scr(xPixMeasure(0, 1)), xPix2Scr(xPixMeasure(1, 0)), yPix2Scr(xPixMeasure(1, 1)))
        graphOverlay.FillRectangle(Brushes.Black, xPix2Scr(xPixMeasure(1, 0)) + 20, yPix2Scr(xPixMeasure(1, 1)) + 20, 60, 40)
        graphOverlay.DrawString(distMeasure.ToString("F03"), Me.Font, Brushes.Orange, xPix2Scr(xPixMeasure(1, 0)) + 30, yPix2Scr(xPixMeasure(1, 1)) + 20)
        graphOverlay.DrawString(angMeasure.ToString("F01"), Me.Font, Brushes.Orange, xPix2Scr(xPixMeasure(1, 0)) + 30, yPix2Scr(xPixMeasure(1, 1)) + 35)
    End Sub

    Private Sub DrawCL(ByRef graphOverlay As Graphics)

        If numPDS > 0 Then
            For i As Integer = 0 To numPDS
                graphOverlay.DrawLine(PenLightGreen2, xPix2Scr(xPixPDSLine(i, 0, 0)), yPix2Scr(xPixPDSLine(i, 0, 1)), xPix2Scr(xPixPDSLine(i, 1, 0)), yPix2Scr(xPixPDSLine(i, 1, 1)))
            Next

            For i As Integer = 0 To numPDS - 1
                graphOverlay.DrawString((i + 1).ToString, Me.Font, Brushes.LightGreen, xPix2Scr((xPixPDSLine(i, 0, 0) + xPixPDSLine(i + 1, 1, 0)) / 2) - 5, yPix2Scr((xPixPDSLine(i, 0, 1) + xPixPDSLine(i + 1, 1, 1)) / 2) - 5)
            Next

            If rbTypeFlx.Checked Then
                For i As Integer = 0 To numPDS - 1
                    Dim tempCTPt(,) As Integer = New Integer(1, 1) {}
                    Dim wheelPath As New System.Drawing.Drawing2D.GraphicsPath

                    tempCTPt(0, 0) = (xPixPDSLine(i, 0, 0) + xPixPDSLine(i, 1, 0)) / 2
                    tempCTPt(0, 1) = (xPixPDSLine(i, 0, 1) + xPixPDSLine(i, 1, 1)) / 2
                    tempCTPt(1, 0) = (xPixPDSLine(i + 1, 0, 0) + xPixPDSLine(i + 1, 1, 0)) / 2
                    tempCTPt(1, 1) = (xPixPDSLine(i + 1, 0, 1) + xPixPDSLine(i + 1, 1, 1)) / 2


                    'graphOverlay.DrawLine(Pens.Blue, xPix2Scr(tempCTPt(0, 0)), yPix2Scr(tempCTPt(0, 1)), xPix2Scr(tempCTPt(1, 0)), yPix2Scr(tempCTPt(1, 1)))

                    wheelPath.Reset()
                    wheelPath.AddLine(xPix2Scr(tempCTPt(0, 0) - Convert.ToInt32(1.35 / mPerPix)), yPix2Scr(tempCTPt(0, 1)), xPix2Scr(tempCTPt(0, 0) - Convert.ToInt32(0.45 / mPerPix)), yPix2Scr(tempCTPt(0, 1)))
                    wheelPath.AddLine(xPix2Scr(tempCTPt(0, 0) - Convert.ToInt32(0.45 / mPerPix)), yPix2Scr(tempCTPt(0, 1)), xPix2Scr(tempCTPt(1, 0) - Convert.ToInt32(0.45 / mPerPix)), yPix2Scr(tempCTPt(1, 1)))
                    wheelPath.AddLine(xPix2Scr(tempCTPt(1, 0) - Convert.ToInt32(0.45 / mPerPix)), yPix2Scr(tempCTPt(1, 1)), xPix2Scr(tempCTPt(1, 0) - Convert.ToInt32(1.35 / mPerPix)), yPix2Scr(tempCTPt(1, 1)))

                    graphOverlay.FillPath(brushWP, wheelPath)

                    wheelPath.Reset()
                    wheelPath.AddLine(xPix2Scr(tempCTPt(0, 0) + Convert.ToInt32(1.35 / mPerPix)), yPix2Scr(tempCTPt(0, 1)), xPix2Scr(tempCTPt(0, 0) + Convert.ToInt32(0.45 / mPerPix)), yPix2Scr(tempCTPt(0, 1)))
                    wheelPath.AddLine(xPix2Scr(tempCTPt(0, 0) + Convert.ToInt32(0.45 / mPerPix)), yPix2Scr(tempCTPt(0, 1)), xPix2Scr(tempCTPt(1, 0) + Convert.ToInt32(0.45 / mPerPix)), yPix2Scr(tempCTPt(1, 1)))
                    wheelPath.AddLine(xPix2Scr(tempCTPt(1, 0) + Convert.ToInt32(0.45 / mPerPix)), yPix2Scr(tempCTPt(1, 1)), xPix2Scr(tempCTPt(1, 0) + Convert.ToInt32(1.35 / mPerPix)), yPix2Scr(tempCTPt(1, 1)))

                    graphOverlay.FillPath(brushWP, wheelPath)


                    graphOverlay.DrawLine(Pens.Orange, _
                                        xPix2Scr((xPixPDSLine(i, 0, 0) + xPixPDSLine(i, 1, 0)) / 2 - 0.45 / mPerPix), yPix2Scr((xPixPDSLine(i, 0, 1) + xPixPDSLine(i, 1, 1)) / 2), _
                                            xPix2Scr((xPixPDSLine(i + 1, 0, 0) + xPixPDSLine(i + 1, 1, 0)) / 2 - 0.45 / mPerPix), yPix2Scr((xPixPDSLine(i + 1, 0, 1) + xPixPDSLine(i + 1, 1, 1)) / 2))
                    graphOverlay.DrawLine(Pens.Orange, _
                                            xPix2Scr((xPixPDSLine(i, 0, 0) + xPixPDSLine(i, 1, 0)) / 2 + 0.45 / mPerPix), yPix2Scr((xPixPDSLine(i, 0, 1) + xPixPDSLine(i, 1, 1)) / 2), _
                                            xPix2Scr((xPixPDSLine(i + 1, 0, 0) + xPixPDSLine(i + 1, 1, 0)) / 2 + 0.45 / mPerPix), yPix2Scr((xPixPDSLine(i + 1, 0, 1) + xPixPDSLine(i + 1, 1, 1)) / 2))
                    graphOverlay.DrawLine(Pens.Orange, _
                                       xPix2Scr((xPixPDSLine(i, 0, 0) + xPixPDSLine(i, 1, 0)) / 2 - 1.35 / mPerPix), yPix2Scr((xPixPDSLine(i, 0, 1) + xPixPDSLine(i, 1, 1)) / 2), _
                                          xPix2Scr((xPixPDSLine(i + 1, 0, 0) + xPixPDSLine(i + 1, 1, 0)) / 2 - 1.35 / mPerPix), yPix2Scr((xPixPDSLine(i + 1, 0, 1) + xPixPDSLine(i + 1, 1, 1)) / 2))
                    graphOverlay.DrawLine(Pens.Orange, _
                                           xPix2Scr((xPixPDSLine(i, 0, 0) + xPixPDSLine(i, 1, 0)) / 2 + 1.35 / mPerPix), yPix2Scr((xPixPDSLine(i, 0, 1) + xPixPDSLine(i, 1, 1)) / 2), _
                                          xPix2Scr((xPixPDSLine(i + 1, 0, 0) + xPixPDSLine(i + 1, 1, 0)) / 2 + 1.35 / mPerPix), yPix2Scr((xPixPDSLine(i + 1, 0, 1) + xPixPDSLine(i + 1, 1, 1)) / 2))

                Next
            Else
                For i As Integer = 0 To numPDS - 1
                    Dim tempCTPt(,) As Integer = New Integer(3, 1) {}
                    Dim wheelPath As New System.Drawing.Drawing2D.GraphicsPath

                    tempCTPt(0, 0) = (3 * xPixPDSLine(i, 0, 0) + xPixPDSLine(i + 1, 0, 0)) / 4
                    tempCTPt(0, 1) = (3 * xPixPDSLine(i, 0, 1) + xPixPDSLine(i + 1, 0, 1)) / 4
                    tempCTPt(1, 0) = (3 * xPixPDSLine(i, 1, 0) + xPixPDSLine(i + 1, 1, 0)) / 4
                    tempCTPt(1, 1) = (3 * xPixPDSLine(i, 1, 1) + xPixPDSLine(i + 1, 1, 1)) / 4
                    tempCTPt(3, 0) = (xPixPDSLine(i, 0, 0) + 3 * xPixPDSLine(i + 1, 0, 0)) / 4
                    tempCTPt(3, 1) = (xPixPDSLine(i, 0, 1) + 3 * xPixPDSLine(i + 1, 0, 1)) / 4
                    tempCTPt(2, 0) = (xPixPDSLine(i, 1, 0) + 3 * xPixPDSLine(i + 1, 1, 0)) / 4
                    tempCTPt(2, 1) = (xPixPDSLine(i, 1, 1) + 3 * xPixPDSLine(i + 1, 1, 1)) / 4


                    'graphOverlay.DrawLine(Pens.Blue, xPix2Scr(tempCTPt(0, 0)), yPix2Scr(tempCTPt(0, 1)), xPix2Scr(tempCTPt(1, 0)), yPix2Scr(tempCTPt(1, 1)))

                    wheelPath.Reset()
                    For j = 0 To 2
                        wheelPath.AddLine(xPix2Scr(tempCTPt(j, 0)), yPix2Scr(tempCTPt(j, 1)), xPix2Scr(tempCTPt(j + 1, 0)), yPix2Scr(tempCTPt(j + 1, 1)))
                    Next
                    wheelPath.CloseFigure()
                    graphOverlay.FillPath(brushWP, wheelPath)

                    graphOverlay.DrawLine(Pens.Orange, xPix2Scr(tempCTPt(0, 0)), yPix2Scr(tempCTPt(0, 1)), xPix2Scr(tempCTPt(1, 0)), yPix2Scr(tempCTPt(1, 1)))
                    graphOverlay.DrawLine(Pens.Orange, xPix2Scr(tempCTPt(2, 0)), yPix2Scr(tempCTPt(2, 1)), xPix2Scr(tempCTPt(3, 0)), yPix2Scr(tempCTPt(3, 1)))
                Next
            End If

        End If


    End Sub

    Private Sub DrawCrack(ByRef graphOverlay As Graphics)
        Dim wLine As Single = Math.Max(2, 0.006 / mPerPix * scaleYSr2Pix)
        Dim penCrack As Pen


        For i As Integer = 0 To numCrack
            ' graphOverlay.DrawString(i.ToString, Me.Font, Brushes.Blue, xPix2Scr(xPixPtCrack(i, 0, 0)), yPix2Scr(xPixPtCrack(i, 0, 1)))
            If iTypeCrack(i) > 0 Then
                If iTypeCrack(i) = 5 Or iTypeCrack(i) = 11 Then
                    Dim tempPath As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath
                    For j As Integer = 0 To numPtCrack(i)
                        tempPath.AddLine(xPix2Scr(xPixPtCrack(i, j, 0)), yPix2Scr(xPixPtCrack(i, j, 1)), xPix2Scr(xPixPtCrack(i, j + 1, 0)), yPix2Scr(xPixPtCrack(i, j + 1, 1)))
                    Next
                    graphOverlay.FillPath(brushPatch, tempPath)
                End If

                If iTypeCrack(i) <= 5 Or iTypeCrack(i) >= 7 Then
                    If i = iCurCrack Then
                        penCrack = New Pen(Color.Red, wLine)
                    Else
                        penCrack = New Pen(colorPen(iTypeCrack(i)), wLine)
                    End If
                    For j As Integer = 0 To numPtCrack(i) - 1
                        graphOverlay.DrawLine(penCrack, xPix2Scr(xPixPtCrack(i, j, 0)), yPix2Scr(xPixPtCrack(i, j, 1)), xPix2Scr(xPixPtCrack(i, j + 1, 0)), yPix2Scr(xPixPtCrack(i, j + 1, 1)))
                    Next
                ElseIf iTypeCrack(i) = 6 Then
                    If i = iCurCrack Then
                        graphOverlay.FillEllipse(Brushes.Red, xPix2Scr(xPixPtCrack(i, 0, 0)) - lCrack(i) * scaleXSr2Pix, yPix2Scr(xPixPtCrack(i, 0, 1)) - lCrack(i) * scaleYSr2Pix, lCrack(i) * 2 * scaleXSr2Pix, lCrack(i) * 2 * scaleYSr2Pix)
                    Else
                        graphOverlay.FillEllipse(brushPH, xPix2Scr(xPixPtCrack(i, 0, 0)) - lCrack(i) * scaleXSr2Pix, yPix2Scr(xPixPtCrack(i, 0, 1)) - lCrack(i) * scaleYSr2Pix, lCrack(i) * 2 * scaleXSr2Pix, lCrack(i) * 2 * scaleYSr2Pix)
                    End If
                End If
            End If
        Next

        'Draw the current active crack and the points on the crack
        If iCurCrack > numCrack Then   ' This is a crack being added
            penCrack = New Pen(Color.Red, wLine)
            For j As Integer = 0 To numPtCrack(iCurCrack) - 1
                graphOverlay.DrawLine(penCrack, xPix2Scr(xPixPtCrack(iCurCrack, j, 0)), yPix2Scr(xPixPtCrack(iCurCrack, j, 1)), xPix2Scr(xPixPtCrack(iCurCrack, j + 1, 0)), yPix2Scr(xPixPtCrack(iCurCrack, j + 1, 1)))

            Next
            For j As Integer = 0 To numPtCrack(iCurCrack)
                graphOverlay.FillEllipse(Brushes.LightGreen, xPix2Scr(xPixPtCrack(iCurCrack, j, 0)) - 2, yPix2Scr(xPixPtCrack(iCurCrack, j, 1)) - 2, 5, 5)
            Next

        End If

    End Sub


    Private Sub DrawLongPro(ByRef graphOverlay As Graphics)

        iPtEnd(0) = Math.Max((yScr2DMI(Canvas.Height * 1.1) - xPtPro(0)) / intvPt, 0)
        iPtEnd(1) = Math.Min((yScr2DMI(-100) - xPtPro(0)) / intvPt, nPtPro - 1)
        Dim nPtperPix As Integer = Convert.ToInt32(1 / scaleYSr2Pix * mPerPix / intvPt) + 1


        For i As Integer = iPtEnd(0) To iPtEnd(1) - nPtperPix - 1 Step Math.Max(nPtperPix / 4, 1)
            graphOverlay.DrawLine(Pens.Red, xPro2Scr(proAll(setActPro.Value - 1, i)), yDMI2Scr(xPtPro(i)), xPro2Scr(proAll(setActPro.Value - 1, i + 1)), yDMI2Scr(xPtPro(i + 1)))
        Next
    End Sub

    Private Sub DrawAllTP(ByRef graphOverlay As Graphics)
        Dim PenTP As Pen = New Pen(Color.LightGreen, 3)
        Dim PenBase As Pen = New Pen(Color.DimGray, 4)
        For i As Integer = 0 To nTP - 1
            If (dmiTP(i) - yScr2DMI(0)) * (dmiTP(i) - yScr2DMI(Canvas.Height)) <= 0 Then

                graphOverlay.DrawLine(Penbase, x2Scr(xPtTP(i, 0) + xOffTP(i)), yDMI2Scr(dmiTP(i)), x2Scr(xPtTP(i, nPtTP(i) - 1) + xOffTP(i)), yDMI2Scr(dmiTP(i)))


                For j As Integer = 0 To nPtTP(i) - 2

                    graphOverlay.DrawLine(PenTP, x2Scr(xPtTP(i, j) + xOffTP(i)), yDMI2Scr(dmiTP(i)) - setScaleTP.Value * proTRaw(i, j) * 1000, x2Scr(xPtTP(i, j + 1) + xOffTP(i)), yDMI2Scr(dmiTP(i)) - setScaleTP.Value * proTRaw(i, j + 1) * 1000)
                Next
            End If
        Next
    End Sub

    Private Sub DrawTPR(ByRef graphOverlay As Graphics)
        Dim PenTP As Pen = New Pen(Color.LightBlue, 3)
        Dim PenBase As Pen = New Pen(Color.DimGray, 4)
        Dim xOffTRP As Single = 4.0
        For i As Integer = 0 To nTRP - 1 Step setIntvShowTPR.Value
            If (DMITRP(i) - yScr2DMI(0)) * (DMITRP(i) - yScr2DMI(Canvas.Height)) <= 0 Then

                'graphOverlay.DrawLine(PenBase, x2Scr(xTRP(0) + xOffTRP), yDMI2Scr(DMITRP(i)), x2Scr(xTRP(nPtTRP(i) - 1) + xOffTRP), yDMI2Scr(DMITRP(i)))


                For j As Integer = 0 To nPtTRP(i) - 2

                    graphOverlay.DrawLine(PenTP, x2Scr(xTRP(j) + xOffTRP), yDMI2Scr(DMITRP(i)) - setScaleTP.Value * yTRP(i, j) * 1000, x2Scr(xTRP(j + 1) + xOffTRP), yDMI2Scr(DMITRP(i)) - setScaleTP.Value * yTRP(i, j + 1) * 1000)
                Next
            End If
        Next
    End Sub

    Private Sub DrawTPLoc(ByRef graphOverlay As Graphics)
        'this subroutine is not used anymore.

        Dim PenTPLoc As Pen = New Pen(Color.AntiqueWhite, 5)
        For i As Integer = 0 To nTP
            If i = iCurTP Then
                PenTPLoc.Color = Color.Red
            Else
                PenTPLoc.Color = Color.YellowGreen
            End If
            'xPt(i) = xTP(iCurTP, i, 0) * factorCrctTP(iCurTP) + xOffTP(iCurTP)
            'zPt(i) = xTP(iCurTP, i, 1)
            'graphOverlay.DrawLine(PenTPLoc, xPix2Scr((xTP(i, 0, 0) * factorCrctTP(i) + xOffTP(i)) / mPerPix), yPix2Scr(yPixDMI0 + DMITP(i) / mPerPix), xPix2Scr((xTP(i, nPtTP(i), 0) * factorCrctTP(i) + xOffTP(i)) / mPerPix), yPix2Scr(yPixDMI0 + DMITP(i) / mPerPix))

        Next
    End Sub


    Private Sub Drawcover(ByRef graphOverlay As Graphics)

        If rbTypeFlx.Checked Then
            graphOverlay.FillRectangle(brushCover, xPix2Scr(originImage(nImage, 0)), yPix2Scr(originImage(nImage, 1)), sizeImage(0, 0) * scaleXSr2Pix, Convert.ToSingle((originImage(nImage, 1) - yPixDMI0 - 10 / mPerPix * (iCurPDS + 1)) * scaleYSr2Pix))

            graphOverlay.FillRectangle(brushCover, xPix2Scr(originImage(nImage, 0)), yPix2Scr(yPixDMI0 + 10 / mPerPix * iCurPDS), sizeImage(0, 0) * scaleXSr2Pix, Convert.ToSingle((yPixDMI0 + 10 / mPerPix * iCurPDS) * scaleYSr2Pix))

            graphOverlay.DrawRectangle(penSilver4, xPix2Scr(originImage(nImage, 0)) - 4, _
                                   yPix2Scr(yPixDMI0 + 10 / mPerPix * (iCurPDS + 1)) - 4, _
                                       sizeImage(0, 0) * scaleXSr2Pix + 8, _
                                       Convert.ToSingle(10 / mPerPix * scaleYSr2Pix + 9))
        Else
            graphOverlay.FillRectangle(brushCover, xPix2Scr(originImage(nImage, 0)), yPix2Scr(originImage(nImage, 1)), sizeImage(0, 0) * scaleXSr2Pix, Convert.ToSingle(scaleYSr2Pix * (originImage(nImage, 1) - Math.Max(xPixPDSLine(iCurPDS + 1, 0, 1), xPixPDSLine(iCurPDS + 1, 1, 1)))))

            graphOverlay.FillRectangle(brushCover, xPix2Scr(originImage(nImage, 0)), yPix2Scr(Math.Min(xPixPDSLine(iCurPDS, 0, 1), xPixPDSLine(iCurPDS, 1, 1))), sizeImage(0, 0) * scaleXSr2Pix, Convert.ToSingle(scaleYSr2Pix * Math.Min(xPixPDSLine(iCurPDS, 0, 1), xPixPDSLine(iCurPDS, 1, 1))))

            graphOverlay.DrawRectangle(penSilver4, xPix2Scr(originImage(nImage, 0)) - 4, _
                                       yPix2Scr(Math.Max(xPixPDSLine(iCurPDS + 1, 0, 1), xPixPDSLine(iCurPDS + 1, 1, 1))) - 4, _
                                       sizeImage(0, 0) * scaleXSr2Pix + 8, _
                                      Convert.ToSingle(scaleYSr2Pix * (Math.Max(xPixPDSLine(iCurPDS + 1, 0, 1), xPixPDSLine(iCurPDS + 1, 1, 1)) - Math.Min(xPixPDSLine(iCurPDS, 0, 1), xPixPDSLine(iCurPDS, 1, 1)))) + 8)

        End If


    End Sub

    Private Sub DrawFiles(ByRef graphOverlay As Graphics)
        For i As Integer = 0 To nImage
            graphOverlay.DrawRectangle(PenGreen3, xPix2Scr(originImage(i, 0)), yPix2Scr(originImage(i, 1)), _
                      sizeImage(i, 0) * scaleXSr2Pix, sizeImage(i, 1) * scaleYSr2Pix)
            graphOverlay.DrawString(fileImage(i), Me.Font, Brushes.LightGreen, xPix2Scr(originImage(i, 0)) + 10, yPix2Scr(originImage(i, 1)) + 10)

        Next

    End Sub

    Private Sub chkShowRefGeo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowRefGeo.CheckedChanged
        Overlay.Invalidate()
    End Sub

    Private Sub chkShowCompass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowCompass.CheckedChanged
        Canvas.Invalidate()
    End Sub

    Private Sub xPix2Geo(ByRef xPix As Integer, ByRef yPix As Integer, ByRef coorGeoCursor() As Double)
        Dim xGeo As Double
        Dim yGeo As Double
        Dim xTemp As Double
        Dim yTemp As Double

        xTemp = (xPix - xPixRefGeo(0, 0)) * mPerPix
        yTemp = (yPix - xPixRefGeo(0, 1)) * mPerPix

        xGeo = cosQEast * xTemp + sinQEast * yTemp
        yGeo = -sinQEast * xTemp + cosQEast * yTemp

        xGeo = xGeo + xByGeo(0, 0)
        yGeo = yGeo + xByGeo(0, 1)

        coorGeoCursor(0) = xGeo / mPerLogD
        coorGeoCursor(1) = yGeo / mPerLatD

    End Sub

    Private Sub xGeo2Pix(ByRef xPix As Integer, ByRef yPix As Integer, ByRef xGeo As Double, ByRef yGeo As Double)
        Dim xTemp1 As Double
        Dim yTemp1 As Double
        Dim xTemp2 As Double
        Dim yTemp2 As Double

        xTemp1 = xGeo * mPerLogD - xByGeo(0, 0)
        yTemp1 = yGeo * mPerLatD - xByGeo(0, 1)

        xTemp2 = cosQEast * xTemp1 - sinQEast * yTemp1
        yTemp2 = sinQEast * xTemp1 + cosQEast * yTemp1

        xPix = xTemp2 / mPerPix + xPixRefGeo(0, 0)
        yPix = yTemp2 / mPerPix + xPixRefGeo(0, 1)



    End Sub

    Private Sub scrlCanvas_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles scrlCanvas.Scroll
        offsetOrigin(1) = Canvas.Height - scrlCanvas.Value * 10
        Canvas.Invalidate()
    End Sub

    Private Sub btnExpand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpand.Click
        scaleYSr2Pix *= factorZoom
        offsetOrigin(1) = Canvas.Height / 2 - (Canvas.Height / 2 - offsetOrigin(1)) * factorZoom   ' to keep the center the same place on the screen
        AdjustScrolBar()
        Canvas.Invalidate()

    End Sub

    Private Sub btnCompress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompress.Click
        scaleXSr2Pix *= factorZoom
        offsetOrigin(1) = Canvas.Height / 2 - (Canvas.Height / 2 - offsetOrigin(1)) / factorZoom   ' to keep the center the same place on the screen
        offsetOrigin(1) = Canvas.Height / 2 - (Canvas.Height / 2 - offsetOrigin(1)) * factorZoom   ' to keep the center the same place on the screen

        Canvas.Invalidate()

    End Sub

    Private Sub AdjustScrolBar()
        If nImage > -1 Then
            scrlCanvas.Minimum = Math.Min((Canvas.Height - originImage(nImage, 1) * scaleYSr2Pix) / 10, 0)
            scrlCanvas.Value = Math.Max(Math.Min((Canvas.Height - offsetOrigin(1)) / 10, scrlCanvas.Maximum), scrlCanvas.Minimum)
        End If

    End Sub

    Private Sub txtLati_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLati.DoubleClick, txtLongi.DoubleClick
        If flagShwDeg = True Then
            flagShwDeg = False
        Else
            flagShwDeg = True
        End If
        Overlay.Invalidate()
    End Sub

    Private Sub chkShowCL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowCL.CheckedChanged
        Overlay.Invalidate()
    End Sub

    Private Sub Ang2MinSec(ByRef Ang As Double, ByRef Deg As Integer, ByRef Min As Integer, ByRef Sec As Single)
        Deg = Math.Truncate(Math.Abs(Ang))
        Min = Math.Truncate((Math.Abs(Ang) - Deg) * 60)
        Sec = (Math.Abs(Ang) - Deg - Min / 60) * 3600
        Deg = Math.Sign(Ang) * Deg
    End Sub

    Private Sub CalScale(ByRef iPtA As Integer, ByRef iPtB As Integer)
        Dim dist As Double() = New Double(1) {}


        dist(0) = Math.Sqrt((xByGeo(iPtB, 0) - xByGeo(iPtA, 0)) ^ 2 + (xByGeo(iPtB, 1) - xByGeo(iPtA, 1)) ^ 2)
        dist(1) = Math.Sqrt((xPixRefGeo(iPtB, 0) - xPixRefGeo(iPtA, 0)) ^ 2 + (xPixRefGeo(iPtB, 1) - xPixRefGeo(iPtA, 1)) ^ 2)
        mPerPix = dist(0) / dist(1)

        'Determine the rotation of the map

        Dim xGeo As Double
        Dim yGeo As Double
        Dim xPix As Double
        Dim yPix As Double

        xGeo = xByGeo(iPtB, 0) - xByGeo(iPtA, 0)
        yGeo = xByGeo(iPtB, 1) - xByGeo(iPtA, 1)
        xPix = (xPixRefGeo(iPtB, 0) - xPixRefGeo(iPtA, 0)) * mPerPix
        yPix = (xPixRefGeo(iPtB, 1) - xPixRefGeo(iPtA, 1)) * mPerPix

        cosQEast = (xGeo * xPix + yGeo * yPix) / (xPix ^ 2 + yPix ^ 2)
        sinQEast = (xGeo * yPix - yGeo * xPix) / (xPix ^ 2 + yPix ^ 2)

        qEast = Math.Acos(cosQEast)
        If sinQEast < 0 Then
            qEast = Math.PI * 2 - qEast
        End If

        chkShowCursorGeo.Enabled = True
        chkShowCompass.Enabled = True


    End Sub

    Private Sub chkShowFiles_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowFiles.CheckedChanged
        Overlay.Invalidate()
    End Sub


    Private Sub chkShowMap_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowMap.CheckedChanged
        If chkShowMap.Checked Then
            chkShowMap.Text = "Close Map"
            MapWindow.Show()
            MapWindow.mapBrow.Navigate("http://maps.google.com/maps?q=" & coorGeo(0, 1).ToString("F08") & "," & coorGeo(0, 0).ToString("F08"))
        Else
            MapWindow.Close()
            chkShowMap.Text = "Show Map"

        End If


    End Sub


    Private Sub DrawMagZone(ByRef graphOverlay As Graphics)
        graphOverlay.DrawRectangle(PenLightGreen2, xPix2Scr(xPixMagCenter(0) - MagnifyWindow.canvasMag.Width / 2 / scaleMag), _
                                   yPix2Scr(xPixMagCenter(1) + MagnifyWindow.canvasMag.Height / 2 / scaleMag), _
                                    MagnifyWindow.canvasMag.Width / scaleMag * scaleXSr2Pix, MagnifyWindow.canvasMag.Height / scaleMag * scaleYSr2Pix)
    End Sub

    Private Sub chkMag_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMag.CheckedChanged
        If chkMag.Checked Then
            MagnifyWindow.Show()
        Else
            MagnifyWindow.Close()

        End If
    End Sub

    Private Sub setScaleMag_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setScaleMag.ValueChanged
        scaleMag = setScaleMag.Value
        ' MagnifyWindow.canvasMag.Invalidate()
    End Sub

    Private Sub setGamma_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Overlay.Invalidate()
    End Sub

    Private Sub setBr_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Overlay.Invalidate()
    End Sub

    Private Sub setBright_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setBright.Scroll, setBright.ValueChanged
        brightness = 1.02 ^ setBright.Value + 0.00001
        Overlay.Focus()
        Overlay.Invalidate()
    End Sub

    Private Sub setContrast_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setContrast.Scroll, setContrast.ValueChanged
        contrast = setContrast.Value / 100
        Overlay.Focus()
        Overlay.Invalidate()
    End Sub


    Private Sub chkPickDMI0_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chkPickDMI0.Checked Then
            message.AppendText("Pick DMI=0 point by DOUBLE clicking" & Environment.NewLine)
            chkPickDMI0.Text = "Picking"
        Else
            message.AppendText("DMI=0 picked, regenerating Pavement Data Segments" & Environment.NewLine)
            chkPickDMI0.Text = "Pick DMI 0"
        End If
    End Sub

    Private Sub iniPDSFlx(ByRef yPixDMI0 As Integer)
        numPDS = Math.Truncate((originImage(nImage, 1) - yPixDMI0) / (10 / mPerPix))
        ReDim xPixPDSLine(numPDS, 1, 1)  ' x1,y1,x2,y2
        ReDim flagManualPDSLine(numPDS, 1)
        ReDim PMPDS(numPDS - 1)
        ReDim geoPDS(numPDS - 1, 1)

        For iPDSLine As Integer = 0 To numPDS
            xPixPDSLine(iPDSLine, 0, 0) = 0
            xPixPDSLine(iPDSLine, 0, 1) = yPixDMI0 + iPDSLine * 10 / mPerPix
            xPixPDSLine(iPDSLine, 1, 0) = sizeImage(0, 0)
            xPixPDSLine(iPDSLine, 1, 1) = yPixDMI0 + iPDSLine * 10 / mPerPix
            flagManualPDSLine(iPDSLine, 0) = 0
            flagManualPDSLine(iPDSLine, 1) = 0
        Next
        flagManualPDSLine(0, 0) = 1
        flagManualPDSLine(0, 1) = 1
        flagManualPDSLine(numPDS, 0) = 1
        flagManualPDSLine(numPDS, 1) = 1
        ReDim nCrackPDS(numPDS - 1)
        ReDim iCrackPDS(numPDS - 1, 1000)

        For i As Integer = 0 To numPDS - 1
            nCrackPDS(i) = -1
        Next

        If nRefGeo > 0 Then
            iniGeoPDS()
        End If
    End Sub

    Private Sub iniPDSRgd(ByRef yPixDMI0 As Integer)
        maxNumPDS = (Math.Truncate((originImage(nImage, 1) - yPixDMI0) / (2 / mPerPix)))
        numPDS = maxNumPDS
        ReDim xPixPDSLine(numPDS, 1, 1)  ' x1,y1,x2,y2
        ReDim flagManualPDSLine(numPDS, 1)
        ReDim PMPDS(numPDS - 1)
        ReDim geoPDS(numPDS - 1, 1)
        ReDim xPixPDSLineCenter(numPDS, 1)
        ReDim yPixIncPDS(numPDS - 1)
        xPixPDSLineCenter(0, 0) = sizeImage(0, 0) / 2
        xPixPDSLineCenter(0, 1) = yPixDMI0
        flagManualPDSLine(0, 1) = 1
        For i As Integer = 1 To numPDS
            yPixIncPDS(i - 1) = 4 / mPerPix
            xPixPDSLineCenter(i, 0) = sizeImage(0, 0) / 2
            xPixPDSLineCenter(i, 1) = xPixPDSLineCenter(i - 1, 1) + yPixIncPDS(i - 1)
            flagManualPDSLine(i, 1) = 0
        Next

        For i As Integer = 0 To numPDS
            xPixPDSLine(i, 0, 0) = 0
            xPixPDSLine(i, 0, 1) = xPixPDSLineCenter(i, 1) - sizeImage(0, 0) / 2 * Math.Tan(setSkewAng.Value / 180 * Math.PI)
            xPixPDSLine(i, 1, 0) = sizeImage(0, 0)
            xPixPDSLine(i, 1, 1) = xPixPDSLineCenter(i, 1) + sizeImage(0, 0) / 2 * Math.Tan(setSkewAng.Value / 180 * Math.PI)

        Next

        ReDim nCrackPDS(numPDS - 1)
        ReDim iCrackPDS(numPDS - 1, 1000)

        For i As Integer = 0 To numPDS - 1
            nCrackPDS(i) = -1
        Next

        If nRefGeo > 0 Then
            iniGeoPDS()
        End If

        LastPDS()

    End Sub


    Private Sub LastPDS()
        Dim i As Integer = 1
        Do While xPixPDSLineCenter(i, 1) < originImage(nImage, 1) And i < maxNumPDS - 1
            i += 1
        Loop
    End Sub

    Private Sub chkAdjLaneBound_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chkAdjLaneBound.Checked Then
            scrMode = 1
        Else
            scrMode = 0
        End If
    End Sub

    Private Sub LocateCurPSDLine(ByRef xPixCursor() As Integer)
        Dim dist2 As Single
        Dim minDist2 As Single = 1.0E+300
        For iPDS As Integer = 0 To numPDS
            For iPt As Integer = 0 To 1
                dist2 = (xPixCursor(0) - xPixPDSLine(iPDS, iPt, 0)) ^ 2 + (xPixCursor(1) - xPixPDSLine(iPDS, iPt, 1)) ^ 2
                If dist2 < minDist2 Then
                    minDist2 = dist2
                    iCurPDSLine = iPDS
                    iCurPDSPt = iPt
                End If
            Next
        Next


    End Sub

    Private Sub LocateCurSlbLine(ByRef xPixCursor() As Integer)
        Dim dist2 As Single
        Dim minDist2 As Single = 1.0E+300
        For iPDS As Integer = 1 To numPDS
            dist2 = (xPixCursor(0) - xPixPDSLineCenter(iPDS, 0)) ^ 2 + (xPixCursor(1) - xPixPDSLineCenter(iPDS, 1)) ^ 2
            If dist2 < minDist2 Then
                minDist2 = dist2
                iCurSlb = iPDS
            End If
        Next

    End Sub

    Private Sub LocateCurCrack(ByRef xPixCursor() As Integer, ByRef iCurPDS As Integer)
        Dim dist2 As Single
        Dim minDist2 As Single = 1.0E+300
        For iCrack As Integer = 0 To nCrackPDS(iCurPDS)
            dist2 = (xPixCursor(0) - xPixPtCrack(iCrackPDS(iCurPDS, iCrack), 0, 0)) ^ 2 + (xPixCursor(1) - xPixPtCrack(iCrackPDS(iCurPDS, iCrack), 0, 1)) ^ 2
            If dist2 < minDist2 Then
                minDist2 = dist2
                iTempCrack = iCrackPDS(iCurPDS, iCrack)
            End If
        Next

    End Sub

    Private Sub UpdatePDSLines()
        Dim iPreFixed As Integer
        Dim iNextFixed As Integer
        For iLR As Integer = 0 To 1
            For iPDS As Integer = 1 To numPDS - 1
                If flagManualPDSLine(iPDS, iLR) = 0 Then  'not a manual point
                    For i As Integer = 0 To iPDS - 1
                        If flagManualPDSLine(i, iLR) = 1 Then
                            iPreFixed = i
                        End If
                    Next
                    For i As Integer = numPDS To iPDS + 1 Step -1
                        If flagManualPDSLine(i, iLR) = 1 Then
                            iNextFixed = i
                        End If
                    Next

                    xPixPDSLine(iPDS, iLR, 0) = xPixPDSLine(iPreFixed, iLR, 0) + (xPixPDSLine(iNextFixed, iLR, 0) - xPixPDSLine(iPreFixed, iLR, 0)) / (iNextFixed - iPreFixed) * (iPDS - iPreFixed)
                End If
            Next

        Next
    End Sub

    Private Sub UpdateSlab()
        For iSlb As Integer = 1 To maxNumPDS
            If iSlb = iCurSlb And flagManualPDSLine(iSlb, 1) = 1 Then
                xPixPDSLine(iSlb, 0, 1) = xPixPDSLineCenter(iSlb, 1) - sizeImage(0, 0) / 2 * Math.Tan(setSkewAng.Value / 180 * Math.PI)
                xPixPDSLine(iSlb, 1, 1) = xPixPDSLineCenter(iSlb, 1) + sizeImage(0, 0) / 2 * Math.Tan(setSkewAng.Value / 180 * Math.PI)
                yPixIncPDS(iSlb - 1) = xPixPDSLineCenter(iSlb, 1) - xPixPDSLineCenter(iSlb - 1, 1)
            End If

            If flagManualPDSLine(iSlb, 1) = 0 Then
                yPixIncPDS(iSlb - 1) = yPixIncPDS(Math.Max(iSlb - 1 - 4, 0))
                xPixPDSLineCenter(iSlb, 1) = xPixPDSLineCenter(iSlb - 1, 1) + yPixIncPDS(iSlb - 1)
                xPixPDSLine(iSlb, 0, 1) = xPixPDSLineCenter(iSlb, 1) - sizeImage(0, 0) / 2 * Math.Tan(setSkewAng.Value / 180 * Math.PI)
                xPixPDSLine(iSlb, 1, 1) = xPixPDSLineCenter(iSlb, 1) + sizeImage(0, 0) / 2 * Math.Tan(setSkewAng.Value / 180 * Math.PI)
                yPixIncPDS(iSlb - 1) = xPixPDSLineCenter(iSlb, 1) - xPixPDSLineCenter(iSlb - 1, 1)

            End If

        Next
        Overlay.Invalidate()
    End Sub

    Private Sub chkAddingCrack_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAddingCrack.CheckedChanged
        If chkAddingCrack.Checked Then
            gbAddCrack.Visible = True
            gbAddCrack.Enabled = True
            numPtCrack(numCrack + 1) = -1
            chkEditCrack.Checked = False
            chkShowCrack.Checked = True

        Else
            gbAddCrack.Visible = False
            gbAddCrack.Enabled = False
            iCurCType = 0

        End If
    End Sub

    Private Sub btnNewTranCrk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewTranCrk.Click
        btnNewTranCrk.BackColor = Color.DarkOrange
        btnNewLongCrk.BackColor = Color.FromArgb(255, 64, 64, 64)
        btnNewWPCrk.BackColor = Color.FromArgb(255, 64, 64, 64)
        btnNewXCrk.BackColor = Color.FromArgb(255, 64, 64, 64)
        btnNewPatch.BackColor = Color.FromArgb(255, 64, 64, 64)
        btnNewPothole.BackColor = Color.FromArgb(255, 64, 64, 64)
        iCurCType = 1
        rbCrkSeal.Enabled = True
        rbCrkNarrow.Enabled = True
        rbCrkWide.Enabled = True
        rbCrkNarrow.Text = "Narrow"
        rbCrkSeal.Checked = True
        message.AppendText("Add new transverse crack.  Click left botten to add a point on the crack; double click to finish adding the current crack; click the middle button to cancel.")
    End Sub

    Private Sub btnNewLongCrk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewLongCrk.Click
        btnNewTranCrk.BackColor = Color.FromArgb(255, 64, 64, 64)
        btnNewLongCrk.BackColor = Color.DarkOrange
        btnNewWPCrk.BackColor = Color.FromArgb(255, 64, 64, 64)
        btnNewXCrk.BackColor = Color.FromArgb(255, 64, 64, 64)
        btnNewPatch.BackColor = Color.FromArgb(255, 64, 64, 64)
        btnNewPothole.BackColor = Color.FromArgb(255, 64, 64, 64)
        iCurCType = 2
        rbCrkSeal.Enabled = True
        rbCrkNarrow.Enabled = True
        rbCrkWide.Enabled = True
        rbCrkNarrow.Text = "Narrow"
        rbCrkSeal.Checked = True

        message.AppendText("Add new longitudinal crack.  Click left botten to add a point on the crack; double click to finish adding the current crack; click the middle button to cancel.")

    End Sub

    Private Sub newWPCrk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewWPCrk.Click
        btnNewTranCrk.BackColor = Color.FromArgb(255, 64, 64, 64)
        btnNewLongCrk.BackColor = Color.FromArgb(255, 64, 64, 64)
        btnNewWPCrk.BackColor = Color.DarkOrange
        btnNewXCrk.BackColor = Color.FromArgb(255, 64, 64, 64)
        btnNewPatch.BackColor = Color.FromArgb(255, 64, 64, 64)
        btnNewPothole.BackColor = Color.FromArgb(255, 64, 64, 64)
        iCurCType = 3
        rbCrkSeal.Enabled = True
        rbCrkNarrow.Enabled = True
        rbCrkWide.Enabled = False
        rbCrkNarrow.Text = "Not sealed"
        rbCrkSeal.Checked = True
        message.AppendText("Add new wheelpath crack.  Click left botten to add a point on the crack; double click to finish adding the current crack; click the middle button to cancel.")

    End Sub

    Private Sub btnNewXCrk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewXCrk.Click
        btnNewTranCrk.BackColor = Color.FromArgb(255, 64, 64, 64)
        btnNewLongCrk.BackColor = Color.FromArgb(255, 64, 64, 64)
        btnNewWPCrk.BackColor = Color.FromArgb(255, 64, 64, 64)
        btnNewXCrk.BackColor = Color.DarkOrange
        btnNewPatch.BackColor = Color.FromArgb(255, 64, 64, 64)
        btnNewPothole.BackColor = Color.FromArgb(255, 64, 64, 64)
        iCurCType = 4
        rbCrkSeal.Enabled = True
        rbCrkNarrow.Enabled = True
        rbCrkWide.Enabled = True
        rbCrkNarrow.Text = "Narrow"
        rbCrkSeal.Checked = True
        message.AppendText("Add new X-crack.  Click left botten to add a point on the crack; double click to finish adding the current crack; click the middle button to cancel.")

    End Sub
    Private Sub btnNewPatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewPatch.Click
        btnNewTranCrk.BackColor = Color.FromArgb(255, 64, 64, 64)
        btnNewLongCrk.BackColor = Color.FromArgb(255, 64, 64, 64)
        btnNewWPCrk.BackColor = Color.FromArgb(255, 64, 64, 64)
        btnNewXCrk.BackColor = Color.FromArgb(255, 64, 64, 64)
        btnNewPatch.BackColor = Color.DarkOrange
        btnNewPothole.BackColor = Color.FromArgb(255, 64, 64, 64)
        iCurCType = 5
        rbCrkSeal.Enabled = False
        rbCrkNarrow.Enabled = False
        rbCrkWide.Enabled = False
        rbCrkNarrow.Text = "Narrow"
    End Sub

    Private Sub btnNewPothole_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewPothole.Click
        btnNewTranCrk.BackColor = Color.FromArgb(255, 64, 64, 64)
        btnNewLongCrk.BackColor = Color.FromArgb(255, 64, 64, 64)
        btnNewWPCrk.BackColor = Color.FromArgb(255, 64, 64, 64)
        btnNewXCrk.BackColor = Color.FromArgb(255, 64, 64, 64)
        btnNewPatch.BackColor = Color.FromArgb(255, 64, 64, 64)
        btnNewPothole.BackColor = Color.DarkOrange
        iCurCType = 6
        rbCrkSeal.Enabled = False
        rbCrkNarrow.Enabled = False
        rbCrkWide.Enabled = False
        rbCrkNarrow.Text = "Narrow"
    End Sub


    Private Sub chkShowCrack_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowCrack.CheckedChanged
        chkShowCrack2.Checked = chkShowCrack.Checked
        chkShowCrack3.Checked = chkShowCrack.Checked
        Invalidate()
    End Sub

    Private Sub chkShowCrack2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowCrack2.CheckedChanged
        chkShowCrack.Checked = chkShowCrack2.Checked
        chkShowCrack3.Checked = chkShowCrack2.Checked
        Overlay.Invalidate()

    End Sub
    Private Sub chkShowCrack3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowCrack3.CheckedChanged
        chkShowCrack.Checked = chkShowCrack3.Checked
        chkShowCrack2.Checked = chkShowCrack3.Checked
        Overlay.Invalidate()

    End Sub
    Private Function LengthCrack(ByRef iCrack As Integer) As Single
        LengthCrack = 0
        For i As Integer = 0 To numPtCrack(iCrack) - 1
            LengthCrack += Math.Sqrt((xPixPtCrack(iCrack, i + 1, 0) - xPixPtCrack(iCrack, i, 0)) ^ 2 + (xPixPtCrack(iCrack, i + 1, 1) - xPixPtCrack(iCrack, i, 1)) ^ 2)
        Next
        LengthCrack = LengthCrack * mPerPix
    End Function

    Private Function AreaPolygon(ByRef iCrack As Integer) As Single
        AreaPolygon = 0
        For i As Integer = 0 To numPtCrack(iCrack)
            AreaPolygon += (xPixPtCrack(iCrack, i, 0) * xPixPtCrack(iCrack, i + 1, 1) - xPixPtCrack(iCrack, i + 1, 0) * xPixPtCrack(iCrack, i, 1))
        Next
        AreaPolygon = 0.5 * Math.Abs(AreaPolygon) * mPerPix ^ 2
    End Function

    Private Sub chkEditCrack_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEditCrack.CheckedChanged
        If chkEditCrack.Checked Then
            gbEditCrack.Enabled = True
            gbEditCrack.Visible = True
            chkAddingCrack.Checked = False
            chkShowCrack.Checked = True
            btnRmvCrack.Enabled = True

        Else
            gbEditCrack.Enabled = False
            gbEditCrack.Visible = False
            btnRmvCrack.Enabled = False

        End If
        Overlay.Invalidate()
    End Sub

    Private Sub btnRmvCrack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRmvCrack.Click
        iTypeCrack(iCurCrack) = 0
        iCurCrack = 0
        Overlay.Invalidate()
    End Sub




    Private Sub rbCrkSeal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCrkSeal.Click
        If rbCrkSeal.Checked Then
            attrbCrack(iCurCrack) = 0
        End If
    End Sub

    Private Sub rbCrkNarrow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCrkNarrow.Click
        If rbCrkNarrow.Checked Then
            attrbCrack(iCurCrack) = 1
        End If
    End Sub

    Private Sub rbCrkWide_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCrkWide.Click
        If rbCrkWide.Checked Then
            attrbCrack(iCurCrack) = 2
        End If
    End Sub

    Private Sub rbEditSealed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEditSealed.Click
        If rbEditSealed.Checked Then
            attrbCrack(iCurCrack) = 0
        End If
    End Sub

    Private Sub rbEditNarrow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEditNarrow.Click
        If rbEditNarrow.Checked Then
            attrbCrack(iCurCrack) = 1
        End If
    End Sub

    Private Sub rbEditWide_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEditWide.Click
        If rbEditWide.Checked Then
            attrbCrack(iCurCrack) = 2
        End If
    End Sub

    Private Sub btnSaveDistress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveDistress.Click
        dlgSaveFile.Filter = "Distress files (*.dis)|*.dis|All files (*.*)|*.*"
        dlgSaveFile.FileName = ""

        If dlgSaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileName = dlgSaveFile.FileName
            lName = FileName.Length

            If lName > 0 Then
                Call SaveDistress(nImage, numCrack, numPtCrack, xPixPtCrack, iTypeCrack, lCrack, attrbCrack, FileName, lName)
            End If

        End If
    End Sub

    Private Sub btnReadDistress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadDistress.Click
        dlgOpenFile.Filter = "Distress files (*.dis)|*.dis|All files (*.*)|*.*"

        If dlgOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileName = dlgOpenFile.FileName
            lName = FileName.Length

            If lName > 0 Then
                ReDim numPtCrack(nImage * 1000 - 1)
                ReDim xPixPtCrack(nImage * 1000 - 1, 19, 1)
                ReDim iPDSCrack(nImage * 1000 - 1)
                ReDim iTypeCrack(nImage * 1000 - 1)
                ReDim lCrack(nImage * 1000 - 1)
                ReDim attrbCrack(nImage * 1000 - 1)
                ReDim nCrackPDS(numPDS - 1)
                ReDim iCrackPDS(numPDS - 1, 1000)
                For i As Integer = 0 To numPDS - 1
                    nCrackPDS(i) = -1
                Next


                Call ReadDistress(nImage, numCrack, numPtCrack, xPixPtCrack, iTypeCrack, lCrack, attrbCrack, FileName, lName)

                Crack2PDS()
                chkShowCrack.Checked = True

            End If

        End If

    End Sub

    Private Sub Crack2PDS()
        Dim xPixCentDtrs(1) As Integer
        Dim nPt As Integer
        For i As Integer = 0 To numCrack
            ReDim xPixCentDtrs(1)

            If iTypeCrack(i) = 5 Or iTypeCrack(i) = 11 Then
                nPt = numPtCrack(i) - 1
            ElseIf iTypeCrack(i) = 6 Then
                nPt = 0
            Else
                nPt = numPtCrack(i)
            End If

            For iPt As Integer = 0 To nPt
                xPixCentDtrs(0) += xPixPtCrack(i, iPt, 0)
                xPixCentDtrs(1) += xPixPtCrack(i, iPt, 1)
            Next
            xPixCentDtrs(0) = xPixCentDtrs(0) / (nPt + 1)
            xPixCentDtrs(1) = xPixCentDtrs(1) / (nPt + 1)

            iPDSCrack(i) = CurSlab(xPixCentDtrs(0), xPixCentDtrs(1))
            nCrackPDS(iPDSCrack(i)) += 1
            iCrackPDS(iPDSCrack(i), nCrackPDS(iPDSCrack(i))) = i
        Next
    End Sub
    Private Sub setPMDMI0_ValueChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setPMDMI0.ValueChanged
        PMDMI0 = setPMDMI0.Value
        Call iniGeoPDS()

        Overlay.Focus()
    End Sub

    Private Sub lbFlagPMPostive_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If flagPMPositive = 1 Then
            flagPMPositive = 0
            lbFlagPMPostive.Text = "PM at DMI0, negative"
        Else
            flagPMPositive = 1
            lbFlagPMPostive.Text = "PM at DMI0, positive"
        End If
    End Sub

    Private Sub btnSaveGeo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveGeo.Click
        dlgSaveFile.Filter = "Geo files (*.geo)|*.geo|All files (*.*)|*.*"
        dlgSaveFile.FileName = ""


        If dlgSaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileName = dlgSaveFile.FileName
            lName = FileName.Length

            If lName > 0 Then
                SaveGeo(nRefGeo, xPixRefGeo, coorGeo, numPDS, xPixPDSLine, flagManualPDSLine, FileName, lName)
            End If

        End If

    End Sub


    Private Sub btnReadGeo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadGeo.Click
        dlgOpenFile.Filter = "Geo files (*.geo)|*.Geo|All files (*.*)|*.*"

        If dlgOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileName = dlgOpenFile.FileName
            lName = FileName.Length

            If lName > 0 Then
                Dim flagNew() As Integer = New Integer() {0, 0}
                ReadGeo(nRefGeo, xPixRefGeo, coorGeo, numPDS, xPixPDSLine, flagManualPDSLine, flagNew, FileName, lName)
                ' nRefGeo = flagNew(0)
                numPDS = flagNew(1)
                maxNumPDS = numPDS
                ReDim xPixPDSLine(numPDS, 1, 1)  ' x1,y1,x2,y2
                ReDim flagManualPDSLine(numPDS, 1)
                ReDim nCrackPDS(numPDS - 1)
                ReDim iCrackPDS(numPDS - 1, 1000)
                ReDim PMPDS(numPDS - 1)
                ReDim geoPDS(numPDS - 1, 1)

                For i As Integer = 0 To numPDS - 1
                    nCrackPDS(i) = -1
                Next


                ReadGeo(nRefGeo, xPixRefGeo, coorGeo, numPDS, xPixPDSLine, flagManualPDSLine, flagNew, FileName, lName)

                yPixDMI0 = (xPixPDSLine(0, 0, 1) + xPixPDSLine(0, 1, 1)) / 2

                For i As Integer = 0 To numPDS
                    xPixPDSLineCenter(i, 0) = (xPixPDSLine(i, 0, 0) + xPixPDSLine(i, 1, 0)) / 2
                    xPixPDSLineCenter(i, 1) = (xPixPDSLine(i, 0, 1) + xPixPDSLine(i, 1, 1)) / 2
                    flagManualPDSLine(i, 1) = 1
                Next
                For i As Integer = 0 To numPDS - 1
                    yPixIncPDS(i) = xPixPDSLineCenter(i + 1, 1) - xPixPDSLineCenter(i, 1)
                Next


                Dim tempLat As Double = (coorGeo(0, 1) + coorGeo(1, 1)) / 2 / 180 * Math.PI
                Call CalMPerLogLat(tempLat)

                For i As Integer = 0 To nRefGeo
                    xByGeo(i, 0) = coorGeo(i, 0) * mPerLogD
                    xByGeo(i, 1) = coorGeo(i, 1) * mPerLatD
                Next

                iAnchor = 0
                jAnchor = 1
                Call CalScale(iAnchor, jAnchor)
                flagAnchored(0) = True
                flagAnchored(1) = True
                'Call CalScale(0, nRefGeo)

                iniGeoPDS()

                setSkewAng.Value = Math.Atan((xPixPDSLine(0, 1, 1) - xPixPDSLine(0, 0, 1)) / (xPixPDSLine(0, 1, 0) - xPixPDSLine(0, 0, 0))) / Math.PI * 180

            End If

        End If


    End Sub

    Private Sub iniGeoPDS()
        Dim xPixTemp() As Integer = New Integer(1) {}
        Dim geoTemp() As Double = New Double(1) {}
        Dim tempDMI As Single
        For i As Integer = 0 To numPDS - 1
            xPixTemp(0) = (xPixPDSLine(i, 0, 0) + xPixPDSLine(i, 1, 0) + xPixPDSLine(i + 1, 0, 0) + xPixPDSLine(i + 1, 1, 0)) / 4
            xPixTemp(1) = (xPixPDSLine(i, 0, 1) + xPixPDSLine(i, 1, 1) + xPixPDSLine(i + 1, 0, 1) + xPixPDSLine(i + 1, 1, 1)) / 4
            xPix2Geo(xPixTemp(0), xPixTemp(1), geoTemp)
            geoPDS(i, 0) = geoTemp(0)
            geoPDS(i, 1) = geoTemp(1)
            tempDMI = (xPixTemp(1) - yPixDMI0) * mPerPix
            PMPDS(i) = setPMDMI0.Value + tempDMI / 1609
        Next

    End Sub
    Private Function SplitCrack(ByVal i As Integer, ByVal xLine As Double, ByVal yMinPx As Double, ByVal xyScale As Double, ByVal lType As Integer, ByVal rType As Integer) As Boolean
        '
        '  Make a new crack from the data points on one side of a scaled x line.
        '
        Dim x0 As Double, x1 As Double, x As Double
        Dim y0 As Double, y1 As Double, y As Double
        Dim StartsRight As Boolean, Crosses As Boolean = False, iPt As Integer

        SplitCrack = False
        ' XXX (jdl): Handle patches
        y1 = xPixPtCrack(i, 0, 1)
        x1 = xPixPtCrack(i, 0, 0) + xyScale * (y1 - yMinPx)
        StartsRight = (x1 > xLine)
        For iPt = 1 To numPtCrack(i)
            x0 = x1 : y0 = y1
            y1 = xPixPtCrack(i, iPt, 1)
            x1 = xPixPtCrack(i, iPt, 0) + xyScale * (y1 - yMinPx)
            If (x0 < xLine And x1 >= xLine) Or (x0 > xLine And x1 <= xLine) Then
                y = y0 + (y1 - y0) * (xLine - x0) / (x1 - x0)
                x = xLine - xyScale * (y - yMinPx)
                Crosses = True
                Exit For
            End If
        Next
        If Crosses Then
            numCrack += 1 ' We're always going to add a crack
            numPtCrack(numCrack) = 0 ' Set the length to zero
            numPtCrack(numCrack + 1) = -1 ' Set the end marker
            iPDSCrack(numCrack) = iPDSCrack(i) ' In the same data segment
            nCrackPDS(iPDSCrack(i)) += 1 ' Add to segment
            iCrackPDS(iPDSCrack(i), nCrackPDS(iPDSCrack(i))) = numCrack ' Back reference
            attrbCrack(numCrack) = attrbCrack(i) ' We just copy this
            If (StartsRight And rType = 0) Or (Not StartsRight And lType = 0) Then
                ' copy the second part of the crack
                xPixPtCrack(numCrack, 0, 0) = x
                xPixPtCrack(numCrack, 0, 1) = y
                For j As Integer = iPt To numPtCrack(i)
                    numPtCrack(numCrack) += 1
                    xPixPtCrack(numCrack, numPtCrack(numCrack), 0) = xPixPtCrack(i, j, 0)
                    xPixPtCrack(numCrack, numPtCrack(numCrack), 1) = xPixPtCrack(i, j, 1)
                Next
            Else
                ' copy the first part of the crack
                For j As Integer = 0 To iPt - 1
                    xPixPtCrack(numCrack, numPtCrack(numCrack), 0) = xPixPtCrack(i, j, 0)
                    xPixPtCrack(numCrack, numPtCrack(numCrack), 1) = xPixPtCrack(i, j, 1)
                    numPtCrack(numCrack) += 1
                Next
                xPixPtCrack(numCrack, numPtCrack(numCrack), 0) = x
                xPixPtCrack(numCrack, numPtCrack(numCrack), 1) = y
            End If
            If (rType = 0) Then
                iTypeCrack(numCrack) = lType
                iTypeCrack(i) = rType
            Else
                iTypeCrack(numCrack) = rType
                iTypeCrack(i) = lType
            End If
            lCrack(numCrack) = LengthCrack(numCrack)
            SplitCrack = True
        Else
            If (StartsRight And rType = 0) Or (Not StartsRight And lType = 0) Then
                iTypeCrack(i) = 0
            End If
        End If
    End Function
    Private Sub ReportFLX()
        Dim Output() As String = New String(39) {}
        Dim nTransCrack() As Integer
        Dim lLongicrack() As Single
        Dim lWPC() As Single
        Dim lSealWPC() As Single
        Dim lXFC() As Single   ' (0) length ratio; (1) weighted by seal/no seal; (2) weighted by wide/narrow
        Dim numPHL As Integer
        Dim aPatch As Single

        message.AppendText(Environment.NewLine & "Generating Distress Report" & Environment.NewLine)

        Output(1) = "06"
        Output(2) = "20101231"
        Output(3) = "SI"
        Output(4) = "03"
        Output(5) = "SOL"
        Output(6) = "123"
        Output(8) = "NB"
        Output(9) = "5"
        Output(13) = "FLX"
        Output(14) = "FLX"
        Output(15) = "0.0"
        Output(16) = "TVC"
        Output(20) = "LOC"
        Output(24) = "WPC"
        Output(29) = "XFC"
        Output(33) = "PHL"
        Output(35) = "PAT"
        Output(37) = "SHD"
        Output(38) = "FLX"
        Output(39) = "N"
        For i As Integer = 0 To numPDS - 1
            ' Be very lazy an treat the trapazoid as a rectangle with some corrections
            Dim yMinPx As Double
            Dim xMinPx As Double, xMaxPx As Double
            'Dim xRWPMinPx As Double, xRWPMaxPx As Double
            'Dim xLWPMinPx As Double, xLWPMaxPx As Double
            Dim xyScale As Double
            Dim x As Double, y As Double, l As Double

            yMinPx = (xPixPDSLine(i, 0, 1) + xPixPDSLine(i, 1, 1)) / 2 ' Should be same
            xMinPx = xPixPDSLine(i, 0, 0)
            xMaxPx = xPixPDSLine(i, 1, 0)
            ' XXX (jdl): We should make sure that the lane width is constant - it will make life better
            xyScale = -((xPixPDSLine(i + 1, 0, 0) + xPixPDSLine(i + 1, 1, 0)) - (xPixPDSLine(i, 0, 0) + xPixPDSLine(i, 1, 0))) / ((xPixPDSLine(i + 1, 0, 1) + xPixPDSLine(i + 1, 1, 1)) - 2 * yMinPx)
Again:
            For j As Integer = 0 To nCrackPDS(i)
                Dim allIn As Boolean = True, allOut As Boolean = True
                If iTypeCrack(iCrackPDS(i, j)) > 0 And iTypeCrack(iCrackPDS(i, j)) < 5 Then
                    If SplitCrack(iCrackPDS(i, j), xMinPx, yMinPx, xyScale, 0, iTypeCrack(iCrackPDS(i, j))) Then
                        GoTo Again
                    End If
                    If SplitCrack(iCrackPDS(i, j), xMaxPx, yMinPx, xyScale, iTypeCrack(iCrackPDS(i, j)), 0) Then
                        GoTo Again
                    End If
                End If
                If iTypeCrack(iCrackPDS(i, j)) = 1 Then
                    If lCrack(iCrackPDS(i, j)) <= 2.7 Then
                        iTypeCrack(iCrackPDS(i, j)) = 3
                        GoTo Again
                    End If
                ElseIf iTypeCrack(iCrackPDS(i, j)) = 2 Then
                    If lCrack(iCrackPDS(i, j)) < 5.0 Then
                        iTypeCrack(iCrackPDS(i, j)) = 4
                        GoTo Again
                    End If
                ElseIf iTypeCrack(iCrackPDS(i, j)) = 3 Then
                    ' Check in WP
                ElseIf iTypeCrack(iCrackPDS(i, j)) = 4 Then
                    ' Check not in WP and in section
                ElseIf iTypeCrack(iCrackPDS(i, j)) = 5 Then
                    l = Math.Sqrt(lCrack(iCrackPDS(i, j)) / Math.PI)
                    If Math.Sqrt(lCrack(iCrackPDS(i, j)) / Math.PI) < 0.5 Then
                        iTypeCrack(iCrackPDS(i, j)) = 6
                        x = 0 : y = 0
                        For iPt As Integer = 0 To numPtCrack(iCrackPDS(i, j)) - 1
                            x += xPixPtCrack(iCrackPDS(i, j), iPt, 0)
                            y += xPixPtCrack(iCrackPDS(i, j), iPt, 1)
                        Next
                        x = x / numPtCrack(iCrackPDS(i, j))
                        y = y / numPtCrack(iCrackPDS(i, j))
                        numPtCrack(iCrackPDS(i, j)) = 2
                        xPixPtCrack(iCrackPDS(i, j), 0, 0) = x
                        xPixPtCrack(iCrackPDS(i, j), 0, 1) = y
                        xPixPtCrack(iCrackPDS(i, j), 1, 0) = x
                        xPixPtCrack(iCrackPDS(i, j), 1, 1) = y + l
                        lCrack(iCrackPDS(i, j)) = l
                        GoTo Again
                    End If
                ElseIf iTypeCrack(iCrackPDS(i, j)) = 6 Then
                    l = lCrack(iCrackPDS(i, j)) * mPerPix
                    x = xPixPtCrack(iCrackPDS(i, j), 0, 0) + xyScale * (xPixPtCrack(iCrackPDS(i, j), 0, 1) - yMinPx)
                    If l < 0.05 Or x < xMinPx Or x > xMaxPx Then
                        iTypeCrack(iCrackPDS(i, j)) = 0
                    ElseIf l > 0.5 Then
                        iTypeCrack(iCrackPDS(i, j)) = 5
                        ' XXX (jdl): Need to fix up representation
                        GoTo Again
                    End If
                End If
            Next
        Next


        For i As Integer = 0 To numPDS - 1
            Output(7) = PMPDS(i).ToString("F03")
            Output(10) = "+" & geoPDS(i, 1).ToString("F08")
            Output(11) = geoPDS(i, 0).ToString("F08")
            Output(12) = coorGeo(0, 2).ToString("F01")
            ReDim nTransCrack(2)
            ReDim lLongicrack(2)
            ReDim lWPC(1)
            ReDim lSealWPC(1)
            ReDim lXFC(2)
            numPHL = 0
            aPatch = 0

            For j As Integer = 0 To nCrackPDS(i)

                'Transverse crack
                If iTypeCrack(iCrackPDS(i, j)) = 1 And lCrack(iCrackPDS(i, j)) > 2.7 Then
                    nTransCrack(attrbCrack(iCrackPDS(i, j))) += 1
                End If

                'Longitudinal crack
                If iTypeCrack(iCrackPDS(i, j)) = 2 Then
                    lLongicrack(attrbCrack(iCrackPDS(i, j))) += lCrack(iCrackPDS(i, j)) / 10.0
                End If

                'WP Crack
                If iTypeCrack(iCrackPDS(i, j)) = 3 Then
                    If xPixPtCrack(iCrackPDS(i, j), 0, 0) < (xPixPDSLine(i, 0, 0) + xPixPDSLine(i + 1, 1, 0)) / 2 Then   ' Left wheelpath
                        lWPC(0) += lCrack(iCrackPDS(i, j)) / 10.0
                        lSealWPC(0) += lCrack(iCrackPDS(i, j)) / 10.0 * attrbCrack(iCrackPDS(i, j))
                    Else
                        lWPC(1) += lCrack(iCrackPDS(i, j)) / 10.0
                        lSealWPC(1) += lCrack(iCrackPDS(i, j)) / 10.0 * attrbCrack(iCrackPDS(i, j))
                    End If
                End If

                'XF-Crack
                If iTypeCrack(iCrackPDS(i, j)) = 4 Then
                    lXFC(0) += lCrack(iCrackPDS(i, j)) / 10.0
                    If attrbCrack(iCrackPDS(i, j)) = 0 Then
                        lXFC(1) += lCrack(iCrackPDS(i, j)) / 10.0
                        lXFC(2) += lCrack(iCrackPDS(i, j)) / 10.0  ' sealed is considered wide too
                    ElseIf attrbCrack(iCrackPDS(i, j)) = 2 Then
                        lXFC(2) += lCrack(iCrackPDS(i, j)) / 10.0  ' sealed is considered wide too
                    End If

                End If

                ' Pothole
                If iTypeCrack(iCrackPDS(i, j)) = 6 Then
                    numPHL += 1
                End If

                'Patch

                If iTypeCrack(iCrackPDS(i, j)) = 5 Then
                    aPatch += lCrack(iCrackPDS(i, j)) / 10.0 / (xPixPDSLine(i, 1, 0) - xPixPDSLine(i, 0, 0)) / mPerPix
                End If

            Next

            Output(17) = nTransCrack(0).ToString
            Output(18) = nTransCrack(1).ToString
            Output(19) = nTransCrack(2).ToString

            Output(21) = lLongicrack(0).ToString("F02")
            Output(22) = lLongicrack(1).ToString("F02")
            Output(23) = lLongicrack(2).ToString("F02")

            If lWPC(0) > 0.05 Then
                Output(25) = lWPC(0).ToString("F02")
                If lSealWPC(0) < lWPC(0) * 0.5 Then
                    Output(26) = "S"
                Else
                    Output(26) = "N"
                End If
            Else
                Output(25) = "0.00"
                Output(26) = "I"
            End If

            If lWPC(1) > 0.05 Then
                Output(27) = lWPC(1).ToString("F02")
                If lSealWPC(1) < lWPC(1) * 0.5 Then
                    Output(28) = "S"
                Else
                    Output(28) = "N"
                End If
            Else
                Output(27) = "0.00"
                Output(28) = "I"
            End If


            If lXFC(0) > 0.05 Then
                Output(30) = lXFC(0).ToString("F02")
                If lXFC(1) > 0.5 * lXFC(0) Then
                    Output(31) = "S"
                Else
                    Output(31) = "N"
                End If
                If lXFC(2) > 0.5 * lXFC(0) Then
                    Output(32) = "W"
                Else
                    Output(32) = "N"
                End If

            Else
                Output(30) = "0.00"
                Output(31) = "I"
                Output(32) = "I"
            End If

            Output(34) = numPHL

            Output(36) = 100 * aPatch


            For iOut As Integer = 1 To 39
                message.AppendText(Output(iOut) & ",")
            Next

            message.AppendText(Environment.NewLine)
        Next


    End Sub

    Private Sub ReportRGD()
        Dim Output() As String = New String(47) {}
        Dim nCrack() As Integer  '4-dimension, Longi/Trans/corner/XJ
        Dim lenCrack() As Single
        Dim lenSeal() As Single
        Dim lenSpall() As Single
        Dim aPatch As Single

        message.AppendText(Environment.NewLine & "Generating Distress Report" & Environment.NewLine)

        Output(1) = "06"
        Output(2) = "20101231"
        Output(3) = "SI"
        Output(4) = "03"
        Output(5) = "SOL"
        Output(6) = "123"
        Output(8) = "NB"
        Output(9) = "5"
        Output(13) = "JPC"
        Output(14) = "JPC"
        Output(16) = "0.0"
        Output(17) = "LOC"
        Output(21) = "TVC"
        Output(25) = "CNC"
        Output(29) = "XJC"
        Output(33) = "APT"
        Output(35) = "1CK"
        Output(37) = "3CK"
        Output(39) = "LJC"
        Output(42) = "TJC"
        Output(45) = "SHD"
        Output(46) = "RID"
        Output(47) = "N"

        For i As Integer = 0 To numPDS - 1
            ReDim nCrack(3)
            ReDim lenCrack(3)
            ReDim lenSeal(3)
            ReDim lenSpall(3)
            aPatch = 0

            Output(7) = PMPDS(i).ToString("F03")
            Output(10) = "+" & geoPDS(i, 1).ToString("F08")
            Output(11) = geoPDS(i, 0).ToString("F08")
            Output(12) = coorGeo(0, 2).ToString("F01")
            Output(15) = (yPixIncPDS(i) * mPerPix).ToString("F01")

            ' Check through all the cracks/patches
            For j As Integer = 0 To nCrackPDS(i)

                If iTypeCrack(iCrackPDS(i, j)) >= 7 And iTypeCrack(iCrackPDS(i, j)) <= 10 Then
                    nCrack(iTypeCrack(iCrackPDS(i, j)) - 7) += 1
                    lenCrack(iTypeCrack(iCrackPDS(i, j)) - 7) += lCrack(iCrackPDS(i, j))
                    If attrbCrack(iCrackPDS(i, j)) = 3 Or attrbCrack(iCrackPDS(i, j)) = 4 Then
                        lenSeal(iTypeCrack(iCrackPDS(i, j)) - 7) += lCrack(iCrackPDS(i, j))
                    End If
                    If attrbCrack(iCrackPDS(i, j)) = 3 Or attrbCrack(iCrackPDS(i, j)) = 5 Then
                        lenSpall(iTypeCrack(iCrackPDS(i, j)) - 7) += lCrack(iCrackPDS(i, j))
                    End If
                End If
                If iTypeCrack(iCrackPDS(i, j)) = 11 Then
                    aPatch += lCrack(iCrackPDS(i, j)) / (yPixIncPDS(i) * mPerPix) / (xPixPDSLine(i, 1, 0) - xPixPDSLine(i, 0, 0)) / mPerPix
                End If

            Next

            'Summarize the four crack types
            For j As Integer = 0 To 3
                Output(18 + j * 4) = nCrack(j).ToString
                If nCrack(j) = 0 Then
                    Output(18 + j * 4 + 1) = "I"
                ElseIf lenSeal(j) > lenCrack(j) * 0.5 Then
                    Output(18 + j * 4 + 1) = "S"
                Else
                    Output(18 + j * 4 + 1) = "N"
                End If
                If nCrack(j) = 0 Then
                    Output(18 + j * 4 + 2) = "I"
                ElseIf lenSpall(j) > lenCrack(j) * 0.5 Then
                    Output(18 + j * 4 + 2) = "S"
                Else
                    Output(18 + j * 4 + 2) = "N"
                End If
            Next

            'Patch area ratio
            Output(34) = aPatch.ToString("F02")

            '1st stage crack
            If nCrack(0) + nCrack(1) + nCrack(3) = 1 Then
                Output(36) = "T"
            Else
                Output(36) = "F"
            End If

            If nCrack(0) >= 1 And (nCrack(1) + nCrack(3)) >= 1 Then
                Output(38) = "T"
            Else
                Output(38) = "F"
            End If

            If rbLongJntSeal.Checked Then
                Output(40) = "S"
            Else
                Output(40) = "N"
            End If

            If rbLongJntSpall.Checked Then
                Output(41) = "S"
            Else
                Output(41) = "N"
            End If

            If rbTransJntSeal.Checked Then
                Output(43) = "S"
            Else
                Output(43) = "N"
            End If

            If rbTransJntSpall.Checked Then
                Output(44) = "S"
            Else
                Output(44) = "N"
            End If



            For iOut As Integer = 1 To 47
                message.AppendText(Output(iOut) & ",")
            Next

            message.AppendText(Environment.NewLine)
        Next


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFlxReport.Click
        ReportFLX()
    End Sub

   


    Private Sub rbCrkSeal_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCrkSeal.CheckedChanged
        If rbCrkSeal.Checked Then
            rbCrkSeal.ForeColor = Color.Yellow
        Else
            rbCrkSeal.ForeColor = Color.White
        End If
    End Sub

    Private Sub rbCrkNarrow_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCrkNarrow.CheckedChanged
        If rbCrkNarrow.Checked Then
            rbCrkNarrow.ForeColor = Color.Yellow
        Else
            rbCrkNarrow.ForeColor = Color.White
        End If
    End Sub

    Private Sub rbCrkWide_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCrkWide.CheckedChanged
        If rbCrkWide.Checked Then
            rbCrkWide.ForeColor = Color.Yellow
        Else
            rbCrkWide.ForeColor = Color.White
        End If
    End Sub

    Private Sub rbEditTrans_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEditTrans.CheckedChanged
        If rbEditTrans.Checked Then
            rbEditTrans.ForeColor = Color.Yellow
        Else
            rbEditTrans.ForeColor = Color.White
        End If
    End Sub

    Private Sub rbEditLongi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEditLongi.CheckedChanged
        If rbEditLongi.Checked Then
            rbEditLongi.ForeColor = Color.Yellow
        Else
            rbEditLongi.ForeColor = Color.White
        End If
    End Sub

    Private Sub rbEditWP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEditWP.CheckedChanged
        If rbEditWP.Checked Then
            rbEditWP.ForeColor = Color.Yellow
        Else
            rbEditWP.ForeColor = Color.White
        End If
    End Sub

    Private Sub rbEditXF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEditXF.CheckedChanged
        If rbEditXF.Checked Then
            rbEditXF.ForeColor = Color.Yellow
        Else
            rbEditXF.ForeColor = Color.White
        End If

    End Sub

    Private Sub rbEditSealed_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEditSealed.CheckedChanged
        If rbEditSealed.Checked Then
            rbEditSealed.ForeColor = Color.Yellow
        Else
            rbEditSealed.ForeColor = Color.White
        End If

    End Sub

    Private Sub rbEditNarrow_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEditNarrow.CheckedChanged
        If rbEditNarrow.Checked Then
            rbEditNarrow.ForeColor = Color.Yellow
        Else
            rbEditNarrow.ForeColor = Color.White
        End If

    End Sub

    Private Sub rbEditWide_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEditWide.CheckedChanged
        If rbEditWide.Checked Then
            rbEditWide.ForeColor = Color.Yellow
        Else
            rbEditWide.ForeColor = Color.White
        End If

    End Sub


    Private Sub rbTypeFlx_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbTypeFlx.Click
        If rbTypeFlx.Checked Then
        End If
    End Sub

    Private Sub rbTypeRigid_Click(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbTypeRigid.Click

    End Sub



    Private Sub chkAdjLaneBound_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAdjLaneBound.CheckedChanged
        If chkAdjLaneBound.Checked = False Then
            iniGeoPDS()

        End If
    End Sub

    Private Sub setSkewAng_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setSkewAng.ValueChanged
        UpdateSlab()
        If numPDS > 0 Then
            xPixPDSLine(0, 0, 1) = xPixPDSLineCenter(0, 1) - sizeImage(0, 0) / 2 * Math.Tan(setSkewAng.Value / 180 * Math.PI)
            xPixPDSLine(0, 1, 1) = xPixPDSLineCenter(0, 1) + sizeImage(0, 0) / 2 * Math.Tan(setSkewAng.Value / 180 * Math.PI)

        End If
        Overlay.Focus()

    End Sub

    Private Sub rbRgdPatch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRgdPatch.CheckedChanged
        If rbRgdPatch.Checked Then
            gbRgdSeal.Enabled = False
            gbRgdSpall.Enabled = False
            iCurCType = 11
        Else
            gbRgdSeal.Enabled = True
            gbRgdSpall.Enabled = True

        End If
    End Sub

    Private Sub chkAddRgdDtrs_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAddRgdDtrs.CheckedChanged
        If chkAddRgdDtrs.Checked Then
            gbNewRgdDtrs.Visible = True
            gbNewRgdDtrs.Enabled = True
            numPtCrack(numCrack + 1) = -1
            chkEditRgdDtrs.Checked = False
            chkShowCrack.Checked = True

        Else
            gbNewRgdDtrs.Visible = False
            gbNewRgdDtrs.Enabled = False
        End If
    End Sub

    Private Sub rbRgdLongCrk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRgdLongCrk.CheckedChanged
        If rbRgdLongCrk.Checked Then
            iCurCType = 7
        End If
    End Sub

    Private Sub rbRgdTransCrk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRgdTransCrk.CheckedChanged
        If rbRgdTransCrk.Checked Then
            iCurCType = 8
        End If
    End Sub

    Private Sub rbRgdCorner_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRgdCorner.CheckedChanged
        If rbRgdCorner.Checked Then
            iCurCType = 9
        End If
    End Sub
    Private Sub rbRgdXJCrk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRgdXJCrk.CheckedChanged
        If rbRgdXJCrk.Checked Then
            iCurCType = 10
        End If
    End Sub
    Private Function CurSlab(ByRef xPix As Integer, ByRef yPix As Integer) As Integer
        Dim yPixMap As Integer  ' map the point to the centerline
        yPixMap = yPix - (xPix - sizeImage(0, 0) / 2) * Math.Tan(setSkewAng.Value / 180 * Math.PI)
        Dim iSlb As Integer = 0
        Do Until (iSlb >= numPDS - 1) Or (yPixMap >= xPixPDSLineCenter(iSlb, 1) And yPixMap <= xPixPDSLineCenter(iSlb + 1, 1))
            iSlb += 1
        Loop
        CurSlab = iSlb
    End Function

    Private Function CrackAttrb() As Integer
        If rbTypeFlx.Checked And chkAddingCrack.Checked Then

            If rbCrkSeal.Checked Then
                CrackAttrb = 0
            ElseIf rbCrkNarrow.Checked Then
                CrackAttrb = 1
            ElseIf rbCrkWide.Checked Then
                CrackAttrb = 2
            End If

        End If

        If rbTypeFlx.Checked And chkEditCrack.Checked Then

            If rbEditSealed.Checked Then
                CrackAttrb = 0
            ElseIf rbEditNarrow.Checked Then
                CrackAttrb = 1
            ElseIf rbEditWide.Checked Then
                CrackAttrb = 2
            End If

        End If


        If rbTypeRigid.Checked And chkAddRgdDtrs.Checked Then

            If rbRgdSeal.Checked And rbRgdSpall.Checked Then
                CrackAttrb = 3
            ElseIf rbRgdSeal.Checked And rbRgdNSpall.Checked Then
                CrackAttrb = 4
            ElseIf rbRgdNSeal.Checked And rbRgdSpall.Checked Then
                CrackAttrb = 5
            ElseIf rbRgdNSeal.Checked And rbRgdNSpall.Checked Then
                CrackAttrb = 6
            End If
        End If

        If rbTypeRigid.Checked And chkEditRgdDtrs.Checked Then

            If rbEditRgdSeal.Checked And rbEditRgdSpall.Checked Then
                CrackAttrb = 3
            ElseIf rbEditRgdSeal.Checked And rbEditRgdNSpall.Checked Then
                CrackAttrb = 4
            ElseIf rbEditRgdNSeal.Checked And rbEditRgdSpall.Checked Then
                CrackAttrb = 5
            ElseIf rbEditRgdNSeal.Checked And rbEditRgdNSpall.Checked Then
                CrackAttrb = 6
            End If
        End If


    End Function

    Private Sub chkEditRgdCrk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEditRgdDtrs.CheckedChanged
        If chkEditRgdDtrs.Checked Then
            gbEditRgdDtrs.Visible = True
            gbEditRgdDtrs.Enabled = True
            chkAddRgdDtrs.Checked = False
            chkShowCrack.Checked = True
            btnRmvRgdDtrs.Enabled = True
        Else
            gbEditRgdDtrs.Visible = False
            gbEditRgdDtrs.Enabled = False
            btnRmvRgdDtrs.Enabled = False
        End If
    End Sub
    Private Sub ShowFlxCrkAttrb()
        If iTypeCrack(iCurCrack) > 4 Then
            gbEditCrack.Visible = False
        Else
            gbEditCrack.Visible = True
        End If

        If iTypeCrack(iCurCrack) = 1 Then
            rbEditTrans.Checked = True
        ElseIf iTypeCrack(iCurCrack) = 2 Then
            rbEditLongi.Checked = True
        ElseIf iTypeCrack(iCurCrack) = 3 Then
            rbEditWP.Checked = True
        ElseIf iTypeCrack(iCurCrack) = 4 Then
            rbEditXF.Checked = True

        End If

        If iTypeCrack(iCurCrack) = 3 Then
            rbEditWide.Enabled = False
            rbEditNarrow.Text = "Not sealed"
        Else
            rbEditWide.Enabled = True
            rbEditNarrow.Text = "Narrow"
        End If


        If attrbCrack(iCurCrack) = 0 Then
            rbEditSealed.Checked = True
        ElseIf attrbCrack(iCurCrack) = 1 Then
            rbEditNarrow.Checked = True
        ElseIf attrbCrack(iCurCrack) = 2 Then
            rbEditWide.Checked = True
        End If
    End Sub
    Private Sub ShowRgdCrkAttrb()
        If iTypeCrack(iCurCrack) = 11 Then
            gbEditRgdSeal.Enabled = False
            gbEditRgdSpall.Enabled = False
        ElseIf iTypeCrack(iCurCrack) <> 0 Then
            gbEditRgdSeal.Enabled = True
            gbEditRgdSpall.Enabled = True
        End If

        If iTypeCrack(iCurCrack) = 7 Then
            rbEditRgdLongi.Checked = True
        ElseIf iTypeCrack(iCurCrack) = 8 Then
            rbEditRgdTrans.Checked = True
        ElseIf iTypeCrack(iCurCrack) = 9 Then
            rbEditRgdCorner.Checked = True
        ElseIf iTypeCrack(iCurCrack) = 10 Then
            rbEditRgdXJ.Checked = True
        ElseIf iTypeCrack(iCurCrack) = 11 Then
            rbEditRgdPatch.Checked = True
        End If

        If attrbCrack(iCurCrack) = 3 Then
            rbEditRgdSeal.Checked = True
            rbEditRgdSpall.Checked = True
        ElseIf attrbCrack(iCurCrack) = 4 Then
            rbEditRgdSeal.Checked = True
            rbEditRgdNSpall.Checked = True
        ElseIf attrbCrack(iCurCrack) = 5 Then
            rbEditRgdNSeal.Checked = True
            rbEditRgdSpall.Checked = True
        ElseIf attrbCrack(iCurCrack) = 6 Then
            rbEditRgdNSeal.Checked = True
            rbEditRgdNSpall.Checked = True
        End If


    End Sub

    Private Sub rbEditTrans_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbEditTrans.Click
        If rbEditTrans.Checked Then
            iTypeCrack(iCurCrack) = 1
        End If
    End Sub

    Private Sub rbEditLongi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbEditLongi.Click
        If rbEditLongi.Checked Then
            iTypeCrack(iCurCrack) = 2
        End If
    End Sub

    Private Sub rbEditWP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbEditWP.Click
        If rbEditWP.Checked Then
            iTypeCrack(iCurCrack) = 3
        End If
    End Sub

    Private Sub rbEditXF_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbEditXF.Click
        If rbEditXF.Checked Then
            iTypeCrack(iCurCrack) = 4
        End If

    End Sub

    Private Sub rbEditRgdLongi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbEditRgdLongi.Click
        If rbEditRgdLongi.Checked And iTypeCrack(iCurCrack) > 6 And iTypeCrack(iCurCrack) < 11 Then
            iTypeCrack(iCurCrack) = 7
        End If
    End Sub

    Private Sub rbEditRgdTrans_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbEditRgdTrans.Click
        If rbEditRgdTrans.Checked And iTypeCrack(iCurCrack) > 6 And iTypeCrack(iCurCrack) < 11 Then
            iTypeCrack(iCurCrack) = 8
        End If

    End Sub
    Private Sub rbEditRgdCorner_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbEditRgdCorner.Click
        If rbEditRgdCorner.Checked And iTypeCrack(iCurCrack) > 6 And iTypeCrack(iCurCrack) < 11 Then
            iTypeCrack(iCurCrack) = 9
        End If
    End Sub
    Private Sub rbEditRgdXJ_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbEditRgdXJ.Click
        If rbEditRgdXJ.Checked And iTypeCrack(iCurCrack) > 6 And iTypeCrack(iCurCrack) < 11 Then
            iTypeCrack(iCurCrack) = 10
        End If

    End Sub

    Private Sub rbEditRgdSeal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbEditRgdSeal.Click

        attrbCrack(iCurCrack) = CrackAttrb()

    End Sub

    Private Sub rbEditRgdSpall_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbEditRgdSpall.Click
        attrbCrack(iCurCrack) = CrackAttrb()

    End Sub

    Private Sub rbEditRgdNSeal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbEditRgdNSeal.Click
        attrbCrack(iCurCrack) = CrackAttrb()

    End Sub

    Private Sub rbEditRgdNSpall_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbEditRgdNSpall.Click
        attrbCrack(iCurCrack) = CrackAttrb()

    End Sub


    Private Sub rbTypeFlx_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTypeFlx.CheckedChanged
        If rbTypeFlx.Checked Then
            gbSurface.Enabled = False
            rbTypeRigid.BackColor = Color.FromArgb(255, 64, 64, 64)
            chkAddRgdDtrs.Enabled = False
            chkEditRgdDtrs.Enabled = False

        End If
    End Sub

    Private Sub rbTypeRigid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTypeRigid.CheckedChanged
        If rbTypeRigid.Checked Then
            gbSurface.Enabled = False
            rbTypeFlx.BackColor = Color.FromArgb(255, 64, 64, 64)
            chkAddingCrack.Enabled = False
            chkEditCrack.Enabled = False
        End If
    End Sub



    Private Sub APCSView_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel
        If flagMouseDown = 1 Then
            scaleXSr2Pix *= factorZoom ^ (e.Delta / 120)
            scaleYSr2Pix *= factorZoom ^ (e.Delta / 120)
            offsetOrigin(0) = (e.X - Overlay.Parent.Location.X) - ((e.X - Overlay.Parent.Location.X) - offsetOrigin(0)) * factorZoom ^ (e.Delta / 120)
            offsetOrigin(1) = (e.Y - Overlay.Parent.Location.Y) - ((e.Y - Overlay.Parent.Location.Y) - offsetOrigin(1)) * factorZoom ^ (e.Delta / 120)   ' to keep the center the same place on the screen
            AdjustScrolBar()
        Else
            scrlCanvas.Value = Math.Max(Math.Min(scrlCanvas.Value + e.Delta / 120 * 6, scrlCanvas.Maximum), scrlCanvas.Minimum)
            offsetOrigin(1) = Canvas.Height - scrlCanvas.Value * 10

        End If
        Overlay.Invalidate()
    End Sub


    Private Sub rbEditRgdPatch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEditRgdPatch.CheckedChanged
        If rbEditRgdPatch.Checked Then
            MessageBox.Show("A crack cannot be converted to a patch")
        End If
    End Sub

    Private Sub btnRgdReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRgdReport.Click
        ReportRGD()
    End Sub

    Private Sub btnRmvRgdDtrs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRmvRgdDtrs.Click
        iTypeCrack(iCurCrack) = 0
        iCurCrack = 0
        Overlay.Invalidate()
    End Sub



    Private Sub btnNextTP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextTP.Click
        If nTP >= 0 Then
            iCurTP = Math.Min((iCurTP + 1), nTP - 1)
            ShowTPParameter()
            If chkShowTP.Checked Then
                TransProfile.canvasTP.Invalidate()
            End If
            flagPlotRD = False
            For i As Integer = 0 To nPtTP(iCurTP)
                'xPt(i) = xTP(iCurTP, i, 0) * factorCrctTP(iCurTP) + xOffTP(iCurTP)
                'zPt(i) = xTP(iCurTP, i, 1)
            Next

        End If

        'If chkShowTPLoc.Checked Then
        'timerFly.Enabled = True
        'timerStep = ((yPixDMI0 + dmiTP(iCurTP) / mPerPix) * scaleYSr2Pix + Canvas.Height / 2 - offsetOrigin(1)) / nTimer
        'End If
        Overlay.Invalidate()

    End Sub

    Private Sub btnPreviousTP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviousTP.Click
        If nTP >= 0 Then
            iCurTP = Math.Max((iCurTP - 1), 0)
            ShowTPParameter()
            If chkShowTP.Checked Then
                TransProfile.canvasTP.Invalidate()
            End If
            flagPlotRD = False
            For i As Integer = 0 To nPtTP(iCurTP)
                'xPt(i) = xTP(iCurTP, i, 0) * factorCrctTP(iCurTP) + xOffTP(iCurTP)
                'zPt(i) = xTP(iCurTP, i, 1)
            Next

        End If
        ' If chkShowTPLoc.Checked Then
        'timerFly.Enabled = True
        'timerStep = ((yPixDMI0 + dmiTP(iCurTP) / mPerPix) * scaleYSr2Pix + Canvas.Height / 2 - offsetOrigin(1)) / nTimer
        'End If

        Overlay.Invalidate()

    End Sub
    Private Sub ShowTPParameter()
        lbCurTP.Text = (iCurTP + 1).ToString & " of " & (nTP).ToString
        setDMITP.Value = dmiTP(iCurTP)
        setXOffTP.Value = xOffTP(iCurTP)
        setCrctFactorTP.Value = factorCrctTP(iCurTP)

    End Sub


    Private Sub setDMITP_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setDMITP.ValueChanged
        If nTP >= 0 Then

            dmiTP(iCurTP) = setDMITP.Value
        End If

        If chkShowTP.Checked Then
            TransProfile.canvasTP.Invalidate()
        End If
        Overlay.Invalidate()

    End Sub

    Private Sub setXOffTP_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setXOffTP.ValueChanged
        If nTP >= 0 Then
            xOffTP(iCurTP) = setXOffTP.Value

        End If
        If chkShowTP.Checked Then
            TransProfile.canvasTP.Invalidate()
        End If
        Overlay.Invalidate()

    End Sub

    Private Sub setCrctFactorTP_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setCrctFactorTP.ValueChanged
        If nTP >= 0 Then
            factorCrctTP(iCurTP) = setCrctFactorTP.Value
        End If

        If chkShowTP.Checked Then
            TransProfile.canvasTP.Invalidate()
        End If
        Overlay.Invalidate()

    End Sub

    Private Sub chkShowTP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowTP.CheckedChanged
        If chkShowTP.Checked Then
            TransProfile.Show()
            For i As Integer = 0 To nPtTP(iCurTP)
                '  xPt(i) = xTP(iCurTP, i, 0) * factorCrctTP(iCurTP) + xOffTP(iCurTP)
                ' zPt(i) = xTP(iCurTP, i, 1)
            Next

        Else
            TransProfile.Close()
        End If
    End Sub



    Private Sub chkShowTPLoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Overlay.Invalidate()

    End Sub


    Private Sub timerFly_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timerFly.Tick
        iTimer += 1
        offsetOrigin(1) += timerStep
        AdjustScrolBar()
        Overlay.Invalidate()
        If iTimer = nTimer Then
            timerFly.Enabled = False
            iTimer = 0
        End If

    End Sub

    Private Sub btnOpenTPs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenTPs.Click
        dlgOpenFile.Filter = "Trans Profile files (*.ATP)|*.ATP|All files (*.*)|*.*"
        dlgOpenFile.FileName = ""


        If dlgOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileName = dlgOpenFile.FileName
            lName = FileName.Length

            If lName > 0 Then
                'ReadTPs(nTP, nPtTP, xTP, DMITP, xOffTP, factorCrctTP, FileName, lName)
                iCurTP = nTP
                ShowTPParameter()
            End If
        End If

    End Sub



    Private Sub btnSaveTPs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveTPs.Click
        dlgSaveFile.Filter = "Trans Profile files (*.ATP)|*.ATP|All files (*.*)|*.*"
        dlgSaveFile.FileName = ""


        If dlgSaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileName = dlgSaveFile.FileName
            lName = FileName.Length

            If lName > 0 Then
                ' SaveTPs(nTP, nPtTP, xTP, DMITP, xOffTP, factorCrctTP, FileName, lName)
            End If
            ShowTPParameter()
        End If

    End Sub



    Private Sub btnAnchorA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnchorA.Click
        If flagPickingAnchor(0) = False Then
            flagPickingAnchor(0) = True
            btnAnchorA.Text = "Picking Anchor A"
            btnAnchorA.BackColor = Color.DarkRed
        Else
            flagPickingAnchor(0) = False
            btnAnchorA.Text = "Anchor A"
            If flagAnchored(0) = True Then
                btnAnchorA.BackColor = Color.LightBlue
            Else
                btnAnchorA.BackColor = Color.Brown
            End If
        End If
    End Sub

    Private Sub btnAnchorB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnchorB.Click
        If flagPickingAnchor(1) = False Then
            flagPickingAnchor(1) = True
            btnAnchorB.Text = "Picking Anchor B"
            btnAnchorB.BackColor = Color.DarkRed
        Else
            flagPickingAnchor(1) = False
            btnAnchorB.Text = "Anchor B"
            If flagAnchored(1) = True Then
                btnAnchorB.BackColor = Color.LightBlue
            Else
                btnAnchorB.BackColor = Color.Brown
            End If
        End If

    End Sub

    Private Sub btnUpdateAnchor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateAnchor.Click
        Dim tempLat As Double

        If flagAnchored(0) And flagAnchored(1) Then
            tempLat = (coorGeo(0, 1) + coorGeo(0, 1)) / 2 / 180 * Math.PI
            Call CalMPerLogLat(tempLat)
            iAnchor = 0
            jAnchor = 1
            xByGeo(0, 0) = coorGeo(0, 0) * mPerLogD
            xByGeo(0, 1) = coorGeo(0, 1) * mPerLatD
            xByGeo(1, 0) = coorGeo(1, 0) * mPerLogD
            xByGeo(1, 1) = coorGeo(1, 1) * mPerLatD


            Call CalScale(iAnchor, jAnchor)

            btnAddRefPt.Enabled = True

            For i As Integer = 2 To nRefGeo
                Call xGeo2Pix(xPixRefGeo(i, 0), xPixRefGeo(i, 1), coorGeo(i, 0), coorGeo(i, 1))


                xByGeo(i, 0) = coorGeo(i, 0) * mPerLogD
                xByGeo(i, 1) = coorGeo(i, 1) * mPerLatD


            Next

            flagScaled = True
        End If
    End Sub

    Private Sub btnAddRefPt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRefPt.Click

        'Add new reference geographic coordinate
        flagAddingRefGeo = True
        NewLogLat.ShowDialog()
        If NewLogLat.DialogResult = Windows.Forms.DialogResult.OK Then

            Call xGeo2Pix(xPixRefGeo(nRefGeo, 0), xPixRefGeo(nRefGeo, 1), coorGeo(nRefGeo, 0), coorGeo(nRefGeo, 1))


            xByGeo(nRefGeo, 0) = coorGeo(nRefGeo, 0) * mPerLogD
            xByGeo(nRefGeo, 1) = coorGeo(nRefGeo, 1) * mPerLatD


        End If


        flagAddingRefGeo = False

        Overlay.Invalidate()


    End Sub

    Private Sub CalMPerLogLat(ByVal lat As Double)
        Dim M As Double
        Dim N As Double

        M = a ^ 2 * b ^ 2 / ((a * Math.Cos(lat)) ^ 2 + (b * Math.Sin(lat)) ^ 2) ^ 1.5
        N = a ^ 2 / ((a * Math.Cos(lat)) ^ 2 + (b * Math.Sin(lat)) ^ 2) ^ 0.5

        mPerLogD = Math.PI / 180 * Math.Cos(lat) * N
        mPerLatD = Math.PI / 180 * M

    End Sub

    Private Sub chkShowLongPro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowLongPro.CheckedChanged
        If chkShowLongPro.Checked Then
            pnLongPro.Visible = True
            pnLongPro.Enabled = True
        Else
            pnLongPro.Visible = False
            pnLongPro.Enabled = False
        End If
    End Sub

    Private Sub btnOpenLongPro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenLongPro.Click
        dlgOpenFile.Filter = "Bin files (*.bin)|*.Bin|All files (*.*)|*.*"

        If dlgOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileName = dlgOpenFile.FileName
            lName = FileName.Length

            If lName > 0 Then
                Call ReadLongPro(nRsv, nPtPro, xPtPro, proAll, boundPro, FileName, lName)
                chkShowLongPro.Enabled = True
                intvPt = (xPtPro(nPtPro - 1) - xPtPro(0)) / (nPtPro - 1)
            End If
        End If


    End Sub


    Private Sub setProScale_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setProScale.ValueChanged
        proScale = setProScale.Value
        setProScale.Increment = 0.5 * setProScale.Value
        Overlay.Invalidate()


    End Sub

    Private Sub setActPro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setActPro.ValueChanged
        Overlay.Invalidate()

    End Sub

    Private Sub btnReadRut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadRut.Click
        dlgOpenFile.Filter = "List of Trans Pro files (*.dat)|*.dat|All files (*.*)|*.*"


        If dlgOpenFile.ShowDialog() = Windows.Forms.DialogResult.OK Then

            FileName = dlgOpenFile.FileName
            lName = FileName.Length
            Call ReadTP(nTP, nPtTP, xPtTP, proTRaw, dmiTP, FileName, lName)

            Call FilterTP(nTP, nPtTP, xPtTP, proTRaw, proFlt, iPtBound)


            iCurTP = 0

            Call CalXOffTP()

            Call RutDep(nTP, nPtTP, xPtTP, proFlt, iPtBound, RDPara, iPtHump, iPtBot, RD, xRod, zRod)

            factorCrctTP(iCurTP) = setCrctFactorTP.Value
            lbCurTP.Text = (iCurTP + 1).ToString & " of " & (nTP).ToString

            'datum = 0
            'For i As Integer = 0 To nPtTP(iCurTP)
            ' datum += zPt(i)
            ' Next

            'datum /= (nPtTP(iCurTP) + 1)

            'For i As Integer = 0 To nPtTP(iCurTP)
            'xTP(nTP, i, 0) = xPt(i) - xPt(0)
            'xTP(nTP, i, 1) = zPt(i) - datum
            'Next

        End If
    End Sub


    Private Sub CalXOffTP()
        For iTP As Integer = 0 To nTP - 1
            Dim flagFound As Boolean = False
            For i As Integer = 0 To numPDS - 1
                If ((xPixPDSLine(i, 0, 1) + xPixPDSLine(i, 1, 1)) / 2 - dmiTP(iTP) / mPerPix + yPixDMI0) * ((xPixPDSLine(i + 1, 0, 1) + xPixPDSLine(i + 1, 1, 1)) / 2 - dmiTP(iTP) / mPerPix + yPixDMI0) < 0 Then
                    flagFound = True
                    xOffTP(iTP) = (xPixPDSLine(i, 0, 0) + xPixPDSLine(i + 1, 1, 0)) / 2 * mPerPix - xPtTP(iTP, iPtBound(iTP, 3))

                End If

                If flagFound = False Then
                    xOffTP(iTP) = imageRaw(0).Width / 2 * mPerPix - xPtTP(iTP, iPtBound(iTP, 3))

                End If
            Next
        Next

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRutFlt.Click
        Call RutDep(nTP, nPtTP, xPtTP, proFlt, iPtBound, RDPara, iPtHump, iPtBot, RD, xRod, zRod)
        ExportRD()
        TransProfile.Invalidate()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call RutDep(nTP, nPtTP, xPtTP, proTRaw, iPtBound, RDPara, iPtHump, iPtBot, RD, xRod, zRod)
        ExportRD()
        TransProfile.Invalidate()
    End Sub


    Private Sub ExportRD()

        message.Text = ""
        message.AppendText("DMI (m)" & ",  " & "RD-LWP (mm)" & ",  " & "RD-RWP (mm)" & Environment.NewLine)
        For i As Integer = 0 To nTP - 1
            message.AppendText(dmiTP(i).ToString("F00") & ",  " & (RD(i, 1) * 1000).ToString("F01") & ",  " & (RD(i, 0) * 1000).ToString("F01") & Environment.NewLine)
        Next
    End Sub

    Private Sub btnReadGeoNote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadGeoNote.Click
        dlgOpenFile.Filter = "Geo Note files (*.not)|*.Not|All files (*.*)|*.*"

        If dlgOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileName = dlgOpenFile.FileName
            lName = FileName.Length

            If lName > 0 Then
                nNote = 0

                Call ReadNote(nNote, tempGeo, tempNote, lNote, FileName, lName)


                If nNote > 0 Then
                    For i As Integer = 1 To nNote
                        Call ReadNote(nNote, tempGeo, tempNote, lNote, FileName, lName)
                        nRefGeo += 1
                        coorGeo(nRefGeo, 0) = tempGeo(0)
                        coorGeo(nRefGeo, 1) = tempGeo(1)
                        noteGeo(nRefGeo) = tempNote

                        Call xGeo2Pix(xPixRefGeo(nRefGeo, 0), xPixRefGeo(nRefGeo, 1), coorGeo(nRefGeo, 0), coorGeo(nRefGeo, 1))
                    Next

                    nNote = -1

                    Call ReadNote(nNote, tempGeo, tempNote, lNote, FileName, lName)
                End If

            End If
        End If



    End Sub

    Private Sub btnReadTRP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadTRP.Click
        dlgOpenFile.Filter = "TPR files (*.TPR)|*.TPR|All files (*.*)|*.*"


        If dlgOpenFile.ShowDialog() = Windows.Forms.DialogResult.OK Then

            FileName = dlgOpenFile.FileName
            lName = FileName.Length

            Call ReadTRP(nTRP, nPtTRP, xTRP, yTRP, DMITRP, FileName, lName)
        End If

    End Sub

    Private Sub btnLoadROW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadROW.Click

        dlgOpenFile.Filter = "layout files (*.lay)|*.lay|All files (*.*)|*.*"

        If dlgOpenFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim sr As StreamReader = New StreamReader(dlgOpenFile.FileName)
            numROW = Convert.ToInt32(sr.ReadLine) - 1
            If numROW = nImage Then
                ReDim imgROW(numROW)
                ReDim listROW(numROW)
                chkShowROW.Visible = True

                prgLoading.Maximum = numROW
                prgLoading.Visible = True

                Dim tempFile As String
                Dim infoFile As System.IO.FileInfo
                For i As Integer = 0 To numROW
                    tempFile = sr.ReadLine
                    infoFile = My.Computer.FileSystem.GetFileInfo(tempFile)
                    imgROW(i) = Bitmap.FromFile(tempFile)
                    listROW(i) = infoFile.Name
                    prgLoading.Value = i
                Next

                prgLoading.Visible = False
                ROWWindow.pixROW.Image = imgROW(0)
                sr.Close()
            Else
                MessageBox.Show("The number of downward images and that of ROW images are not the same.  Check your input.")
            End If

        End If

    End Sub

    Private Sub chkShowROW_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowROW.CheckedChanged
        If chkShowROW.Checked Then
            ROWWindow.Show()
            ROWWindow.TopMost = True
        End If
    End Sub

   
   
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
    Private Sub chkImageAdj_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkImageAdj.CheckedChanged
        Refresh()
    End Sub

End Class
