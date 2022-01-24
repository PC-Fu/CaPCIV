<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APCSView
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
        Me.components = New System.ComponentModel.Container
        Me.MainTab = New System.Windows.Forms.TabControl
        Me.tabSystem = New System.Windows.Forms.TabPage
        Me.chkShowROW = New System.Windows.Forms.CheckBox
        Me.btnLoadROW = New System.Windows.Forms.Button
        Me.chkHideImages = New System.Windows.Forms.CheckBox
        Me.btnReadGeoNote = New System.Windows.Forms.Button
        Me.chkShowLongPro = New System.Windows.Forms.CheckBox
        Me.btnOpenLongPro = New System.Windows.Forms.Button
        Me.btnAddRefPt = New System.Windows.Forms.Button
        Me.btnUpdateAnchor = New System.Windows.Forms.Button
        Me.btnAnchorB = New System.Windows.Forms.Button
        Me.btnAnchorA = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnReadDistress = New System.Windows.Forms.Button
        Me.setSkewAng = New System.Windows.Forms.NumericUpDown
        Me.btnSaveDistress = New System.Windows.Forms.Button
        Me.gbSurface = New System.Windows.Forms.GroupBox
        Me.rbTypeRigid = New System.Windows.Forms.RadioButton
        Me.rbTypeFlx = New System.Windows.Forms.RadioButton
        Me.chkAdjLaneBound = New System.Windows.Forms.CheckBox
        Me.btnReadGeo = New System.Windows.Forms.Button
        Me.btnSaveGeo = New System.Windows.Forms.Button
        Me.lbFlagPMPostive = New System.Windows.Forms.Label
        Me.setPMDMI0 = New System.Windows.Forms.NumericUpDown
        Me.chkPickDMI0 = New System.Windows.Forms.CheckBox
        Me.chkShowCrack2 = New System.Windows.Forms.CheckBox
        Me.setScaleMag = New System.Windows.Forms.NumericUpDown
        Me.chkMag = New System.Windows.Forms.CheckBox
        Me.chkMeasure = New System.Windows.Forms.CheckBox
        Me.chkShowMap = New System.Windows.Forms.CheckBox
        Me.chkShowFiles = New System.Windows.Forms.CheckBox
        Me.chkShowCL = New System.Windows.Forms.CheckBox
        Me.chkShowCompass = New System.Windows.Forms.CheckBox
        Me.chkShowCursorGeo = New System.Windows.Forms.CheckBox
        Me.chkShowRefGeo = New System.Windows.Forms.CheckBox
        Me.btnImpList = New System.Windows.Forms.Button
        Me.tabFlx = New System.Windows.Forms.TabPage
        Me.btnFlxReport = New System.Windows.Forms.Button
        Me.gbEditCrack = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbEditWide = New System.Windows.Forms.RadioButton
        Me.rbEditNarrow = New System.Windows.Forms.RadioButton
        Me.rbEditSealed = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbEditXF = New System.Windows.Forms.RadioButton
        Me.rbEditWP = New System.Windows.Forms.RadioButton
        Me.rbEditLongi = New System.Windows.Forms.RadioButton
        Me.rbEditTrans = New System.Windows.Forms.RadioButton
        Me.btnRmvCrack = New System.Windows.Forms.Button
        Me.chkEditCrack = New System.Windows.Forms.CheckBox
        Me.chkShowCrack = New System.Windows.Forms.CheckBox
        Me.gbAddCrack = New System.Windows.Forms.GroupBox
        Me.btnNewPothole = New System.Windows.Forms.Button
        Me.rbCrkWide = New System.Windows.Forms.RadioButton
        Me.btnNewPatch = New System.Windows.Forms.Button
        Me.btnNewWPCrk = New System.Windows.Forms.Button
        Me.btnNewXCrk = New System.Windows.Forms.Button
        Me.rbCrkNarrow = New System.Windows.Forms.RadioButton
        Me.btnNewLongCrk = New System.Windows.Forms.Button
        Me.rbCrkSeal = New System.Windows.Forms.RadioButton
        Me.btnNewTranCrk = New System.Windows.Forms.Button
        Me.chkAddingCrack = New System.Windows.Forms.CheckBox
        Me.tabRgd = New System.Windows.Forms.TabPage
        Me.btnRgdReport = New System.Windows.Forms.Button
        Me.rbTranJnt = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.rbTransJntNSpall = New System.Windows.Forms.RadioButton
        Me.rbTransJntSpall = New System.Windows.Forms.RadioButton
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.rbTransJntNSeal = New System.Windows.Forms.RadioButton
        Me.rbTransJntSeal = New System.Windows.Forms.RadioButton
        Me.gbLongJnt = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.rbLongJntNSpall = New System.Windows.Forms.RadioButton
        Me.rbLongJntSpall = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rbLongJntNSeal = New System.Windows.Forms.RadioButton
        Me.rbLongJntSeal = New System.Windows.Forms.RadioButton
        Me.chkShowCrack3 = New System.Windows.Forms.CheckBox
        Me.btnRmvRgdDtrs = New System.Windows.Forms.Button
        Me.gbEditRgdDtrs = New System.Windows.Forms.GroupBox
        Me.gbEditRgdDtrsType = New System.Windows.Forms.GroupBox
        Me.rbEditRgdCorner = New System.Windows.Forms.RadioButton
        Me.rbEditRgdPatch = New System.Windows.Forms.RadioButton
        Me.rbEditRgdXJ = New System.Windows.Forms.RadioButton
        Me.rbEditRgdTrans = New System.Windows.Forms.RadioButton
        Me.rbEditRgdLongi = New System.Windows.Forms.RadioButton
        Me.gbEditRgdSpall = New System.Windows.Forms.GroupBox
        Me.rbEditRgdNSpall = New System.Windows.Forms.RadioButton
        Me.rbEditRgdSpall = New System.Windows.Forms.RadioButton
        Me.gbEditRgdSeal = New System.Windows.Forms.GroupBox
        Me.rbEditRgdNSeal = New System.Windows.Forms.RadioButton
        Me.rbEditRgdSeal = New System.Windows.Forms.RadioButton
        Me.chkEditRgdDtrs = New System.Windows.Forms.CheckBox
        Me.gbNewRgdDtrs = New System.Windows.Forms.GroupBox
        Me.gbRgdDtrs = New System.Windows.Forms.GroupBox
        Me.rbRgdCorner = New System.Windows.Forms.RadioButton
        Me.rbRgdPatch = New System.Windows.Forms.RadioButton
        Me.rbRgdXJCrk = New System.Windows.Forms.RadioButton
        Me.rbRgdTransCrk = New System.Windows.Forms.RadioButton
        Me.rbRgdLongCrk = New System.Windows.Forms.RadioButton
        Me.gbRgdSpall = New System.Windows.Forms.GroupBox
        Me.rbRgdNSpall = New System.Windows.Forms.RadioButton
        Me.rbRgdSpall = New System.Windows.Forms.RadioButton
        Me.gbRgdSeal = New System.Windows.Forms.GroupBox
        Me.rbRgdNSeal = New System.Windows.Forms.RadioButton
        Me.rbRgdSeal = New System.Windows.Forms.RadioButton
        Me.chkAddRgdDtrs = New System.Windows.Forms.CheckBox
        Me.tabTransProf = New System.Windows.Forms.TabPage
        Me.setIntvShowTPR = New System.Windows.Forms.NumericUpDown
        Me.chkShowTPR = New System.Windows.Forms.CheckBox
        Me.btnReadTRP = New System.Windows.Forms.Button
        Me.setScaleTP = New System.Windows.Forms.NumericUpDown
        Me.chkShowAllTP = New System.Windows.Forms.CheckBox
        Me.btnRutFlt = New System.Windows.Forms.Button
        Me.btnReadRut = New System.Windows.Forms.Button
        Me.btnSaveTPs = New System.Windows.Forms.Button
        Me.btnOpenTPs = New System.Windows.Forms.Button
        Me.chkShowTP = New System.Windows.Forms.CheckBox
        Me.lbCurTP = New System.Windows.Forms.Label
        Me.btnPreviousTP = New System.Windows.Forms.Button
        Me.btnNextTP = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.setCrctFactorTP = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.setXOffTP = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.setDMITP = New System.Windows.Forms.NumericUpDown
        Me.txtLati = New System.Windows.Forms.Label
        Me.txtLongi = New System.Windows.Forms.Label
        Me.Canvas = New System.Windows.Forms.PictureBox
        Me.dlgOpenFile = New System.Windows.Forms.OpenFileDialog
        Me.btnZoomIn = New System.Windows.Forms.Button
        Me.btnZoomOut = New System.Windows.Forms.Button
        Me.setZoomFactor = New System.Windows.Forms.NumericUpDown
        Me.Overlay = New System.Windows.Forms.PictureBox
        Me.btnFitScr = New System.Windows.Forms.Button
        Me.scrlCanvas = New System.Windows.Forms.VScrollBar
        Me.btnCompress = New System.Windows.Forms.Button
        Me.btnExpand = New System.Windows.Forms.Button
        Me.setBright = New System.Windows.Forms.TrackBar
        Me.setContrast = New System.Windows.Forms.TrackBar
        Me.prgLoading = New System.Windows.Forms.ProgressBar
        Me.message = New System.Windows.Forms.TextBox
        Me.dlgSaveFile = New System.Windows.Forms.SaveFileDialog
        Me.lbDMI = New System.Windows.Forms.Label
        Me.lbPM = New System.Windows.Forms.Label
        Me.timerFly = New System.Windows.Forms.Timer(Me.components)
        Me.pnLongPro = New System.Windows.Forms.Panel
        Me.setProScale = New System.Windows.Forms.NumericUpDown
        Me.setActPro = New System.Windows.Forms.NumericUpDown
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkImageAdj = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.MainTab.SuspendLayout()
        Me.tabSystem.SuspendLayout()
        CType(Me.setSkewAng, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSurface.SuspendLayout()
        CType(Me.setPMDMI0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setScaleMag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFlx.SuspendLayout()
        Me.gbEditCrack.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbAddCrack.SuspendLayout()
        Me.tabRgd.SuspendLayout()
        Me.rbTranJnt.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.gbLongJnt.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbEditRgdDtrs.SuspendLayout()
        Me.gbEditRgdDtrsType.SuspendLayout()
        Me.gbEditRgdSpall.SuspendLayout()
        Me.gbEditRgdSeal.SuspendLayout()
        Me.gbNewRgdDtrs.SuspendLayout()
        Me.gbRgdDtrs.SuspendLayout()
        Me.gbRgdSpall.SuspendLayout()
        Me.gbRgdSeal.SuspendLayout()
        Me.tabTransProf.SuspendLayout()
        CType(Me.setIntvShowTPR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setScaleTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setCrctFactorTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setXOffTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setDMITP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Canvas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setZoomFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Overlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setBright, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setContrast, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnLongPro.SuspendLayout()
        CType(Me.setProScale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setActPro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainTab
        '
        Me.MainTab.Controls.Add(Me.tabSystem)
        Me.MainTab.Controls.Add(Me.tabFlx)
        Me.MainTab.Controls.Add(Me.tabRgd)
        Me.MainTab.Controls.Add(Me.tabTransProf)
        Me.MainTab.Location = New System.Drawing.Point(0, 0)
        Me.MainTab.Name = "MainTab"
        Me.MainTab.SelectedIndex = 0
        Me.MainTab.Size = New System.Drawing.Size(270, 598)
        Me.MainTab.TabIndex = 0
        '
        'tabSystem
        '
        Me.tabSystem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tabSystem.Controls.Add(Me.chkShowROW)
        Me.tabSystem.Controls.Add(Me.btnLoadROW)
        Me.tabSystem.Controls.Add(Me.chkHideImages)
        Me.tabSystem.Controls.Add(Me.btnReadGeoNote)
        Me.tabSystem.Controls.Add(Me.chkShowLongPro)
        Me.tabSystem.Controls.Add(Me.btnOpenLongPro)
        Me.tabSystem.Controls.Add(Me.btnAddRefPt)
        Me.tabSystem.Controls.Add(Me.btnUpdateAnchor)
        Me.tabSystem.Controls.Add(Me.btnAnchorB)
        Me.tabSystem.Controls.Add(Me.btnAnchorA)
        Me.tabSystem.Controls.Add(Me.Label1)
        Me.tabSystem.Controls.Add(Me.btnReadDistress)
        Me.tabSystem.Controls.Add(Me.setSkewAng)
        Me.tabSystem.Controls.Add(Me.btnSaveDistress)
        Me.tabSystem.Controls.Add(Me.gbSurface)
        Me.tabSystem.Controls.Add(Me.chkAdjLaneBound)
        Me.tabSystem.Controls.Add(Me.btnReadGeo)
        Me.tabSystem.Controls.Add(Me.btnSaveGeo)
        Me.tabSystem.Controls.Add(Me.lbFlagPMPostive)
        Me.tabSystem.Controls.Add(Me.setPMDMI0)
        Me.tabSystem.Controls.Add(Me.chkPickDMI0)
        Me.tabSystem.Controls.Add(Me.chkShowCrack2)
        Me.tabSystem.Controls.Add(Me.setScaleMag)
        Me.tabSystem.Controls.Add(Me.chkMag)
        Me.tabSystem.Controls.Add(Me.chkMeasure)
        Me.tabSystem.Controls.Add(Me.chkShowMap)
        Me.tabSystem.Controls.Add(Me.chkShowFiles)
        Me.tabSystem.Controls.Add(Me.chkShowCL)
        Me.tabSystem.Controls.Add(Me.chkShowCompass)
        Me.tabSystem.Controls.Add(Me.chkShowCursorGeo)
        Me.tabSystem.Controls.Add(Me.chkShowRefGeo)
        Me.tabSystem.Controls.Add(Me.btnImpList)
        Me.tabSystem.Location = New System.Drawing.Point(4, 22)
        Me.tabSystem.Name = "tabSystem"
        Me.tabSystem.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSystem.Size = New System.Drawing.Size(262, 572)
        Me.tabSystem.TabIndex = 0
        Me.tabSystem.Text = "System"
        Me.tabSystem.UseVisualStyleBackColor = True
        '
        'chkShowROW
        '
        Me.chkShowROW.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkShowROW.AutoSize = True
        Me.chkShowROW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowROW.Location = New System.Drawing.Point(179, 71)
        Me.chkShowROW.Name = "chkShowROW"
        Me.chkShowROW.Size = New System.Drawing.Size(74, 23)
        Me.chkShowROW.TabIndex = 44
        Me.chkShowROW.Text = "Show ROW"
        Me.chkShowROW.UseVisualStyleBackColor = True
        Me.chkShowROW.Visible = False
        '
        'btnLoadROW
        '
        Me.btnLoadROW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadROW.Location = New System.Drawing.Point(179, 38)
        Me.btnLoadROW.Name = "btnLoadROW"
        Me.btnLoadROW.Size = New System.Drawing.Size(74, 23)
        Me.btnLoadROW.TabIndex = 43
        Me.btnLoadROW.Text = "Load ROW"
        Me.btnLoadROW.UseVisualStyleBackColor = True
        '
        'chkHideImages
        '
        Me.chkHideImages.AutoSize = True
        Me.chkHideImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkHideImages.Location = New System.Drawing.Point(93, 196)
        Me.chkHideImages.Name = "chkHideImages"
        Me.chkHideImages.Size = New System.Drawing.Size(82, 17)
        Me.chkHideImages.TabIndex = 42
        Me.chkHideImages.Text = "Hide Images"
        Me.chkHideImages.UseVisualStyleBackColor = True
        '
        'btnReadGeoNote
        '
        Me.btnReadGeoNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReadGeoNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.btnReadGeoNote.Location = New System.Drawing.Point(6, 172)
        Me.btnReadGeoNote.Name = "btnReadGeoNote"
        Me.btnReadGeoNote.Size = New System.Drawing.Size(73, 41)
        Me.btnReadGeoNote.TabIndex = 41
        Me.btnReadGeoNote.Text = "Load Geo Note"
        Me.btnReadGeoNote.UseVisualStyleBackColor = True
        '
        'chkShowLongPro
        '
        Me.chkShowLongPro.AutoSize = True
        Me.chkShowLongPro.Enabled = False
        Me.chkShowLongPro.Location = New System.Drawing.Point(136, 387)
        Me.chkShowLongPro.Name = "chkShowLongPro"
        Me.chkShowLongPro.Size = New System.Drawing.Size(99, 17)
        Me.chkShowLongPro.TabIndex = 40
        Me.chkShowLongPro.Text = "Show Long Pro"
        Me.chkShowLongPro.UseVisualStyleBackColor = True
        '
        'btnOpenLongPro
        '
        Me.btnOpenLongPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenLongPro.Location = New System.Drawing.Point(6, 381)
        Me.btnOpenLongPro.Name = "btnOpenLongPro"
        Me.btnOpenLongPro.Size = New System.Drawing.Size(115, 23)
        Me.btnOpenLongPro.TabIndex = 39
        Me.btnOpenLongPro.Text = "Load Long Pro"
        Me.ToolTips.SetToolTip(Me.btnOpenLongPro, "Open the BIN file exported by ProView")
        Me.btnOpenLongPro.UseVisualStyleBackColor = True
        '
        'btnAddRefPt
        '
        Me.btnAddRefPt.Enabled = False
        Me.btnAddRefPt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRefPt.Location = New System.Drawing.Point(6, 143)
        Me.btnAddRefPt.Name = "btnAddRefPt"
        Me.btnAddRefPt.Size = New System.Drawing.Size(73, 23)
        Me.btnAddRefPt.TabIndex = 37
        Me.btnAddRefPt.Text = "Add Ref. Pt"
        Me.btnAddRefPt.UseVisualStyleBackColor = True
        '
        'btnUpdateAnchor
        '
        Me.btnUpdateAnchor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateAnchor.Location = New System.Drawing.Point(179, 112)
        Me.btnUpdateAnchor.Name = "btnUpdateAnchor"
        Me.btnUpdateAnchor.Size = New System.Drawing.Size(77, 23)
        Me.btnUpdateAnchor.TabIndex = 36
        Me.btnUpdateAnchor.Text = "Update"
        Me.btnUpdateAnchor.UseVisualStyleBackColor = True
        '
        'btnAnchorB
        '
        Me.btnAnchorB.BackColor = System.Drawing.Color.Brown
        Me.btnAnchorB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnchorB.Location = New System.Drawing.Point(93, 112)
        Me.btnAnchorB.Name = "btnAnchorB"
        Me.btnAnchorB.Size = New System.Drawing.Size(73, 23)
        Me.btnAnchorB.TabIndex = 35
        Me.btnAnchorB.Text = "Anchor B"
        Me.btnAnchorB.UseVisualStyleBackColor = False
        '
        'btnAnchorA
        '
        Me.btnAnchorA.BackColor = System.Drawing.Color.Brown
        Me.btnAnchorA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnchorA.Location = New System.Drawing.Point(6, 113)
        Me.btnAnchorA.Name = "btnAnchorA"
        Me.btnAnchorA.Size = New System.Drawing.Size(73, 23)
        Me.btnAnchorA.TabIndex = 34
        Me.btnAnchorA.Text = "Anchor A"
        Me.btnAnchorA.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 346)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Skwed joint angle"
        '
        'btnReadDistress
        '
        Me.btnReadDistress.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReadDistress.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReadDistress.Location = New System.Drawing.Point(136, 536)
        Me.btnReadDistress.Name = "btnReadDistress"
        Me.btnReadDistress.Size = New System.Drawing.Size(115, 30)
        Me.btnReadDistress.TabIndex = 9
        Me.btnReadDistress.Text = "Read Distress"
        Me.btnReadDistress.UseVisualStyleBackColor = True
        '
        'setSkewAng
        '
        Me.setSkewAng.DecimalPlaces = 1
        Me.setSkewAng.Location = New System.Drawing.Point(6, 346)
        Me.setSkewAng.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        Me.setSkewAng.Minimum = New Decimal(New Integer() {90, 0, 0, -2147483648})
        Me.setSkewAng.Name = "setSkewAng"
        Me.setSkewAng.Size = New System.Drawing.Size(73, 20)
        Me.setSkewAng.TabIndex = 31
        Me.setSkewAng.TabStop = False
        '
        'btnSaveDistress
        '
        Me.btnSaveDistress.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSaveDistress.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveDistress.Location = New System.Drawing.Point(6, 536)
        Me.btnSaveDistress.Name = "btnSaveDistress"
        Me.btnSaveDistress.Size = New System.Drawing.Size(115, 30)
        Me.btnSaveDistress.TabIndex = 8
        Me.btnSaveDistress.Text = "Save Distress"
        Me.btnSaveDistress.UseVisualStyleBackColor = True
        '
        'gbSurface
        '
        Me.gbSurface.Controls.Add(Me.rbTypeRigid)
        Me.gbSurface.Controls.Add(Me.rbTypeFlx)
        Me.gbSurface.Location = New System.Drawing.Point(93, 19)
        Me.gbSurface.Name = "gbSurface"
        Me.gbSurface.Size = New System.Drawing.Size(74, 87)
        Me.gbSurface.TabIndex = 30
        Me.gbSurface.TabStop = False
        Me.gbSurface.Text = "Surface"
        '
        'rbTypeRigid
        '
        Me.rbTypeRigid.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbTypeRigid.AutoSize = True
        Me.rbTypeRigid.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.rbTypeRigid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.rbTypeRigid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.rbTypeRigid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbTypeRigid.Location = New System.Drawing.Point(10, 50)
        Me.rbTypeRigid.Name = "rbTypeRigid"
        Me.rbTypeRigid.Size = New System.Drawing.Size(55, 25)
        Me.rbTypeRigid.TabIndex = 1
        Me.rbTypeRigid.Text = "  Rigid  "
        Me.rbTypeRigid.UseVisualStyleBackColor = True
        '
        'rbTypeFlx
        '
        Me.rbTypeFlx.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbTypeFlx.AutoSize = True
        Me.rbTypeFlx.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.rbTypeFlx.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.rbTypeFlx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.rbTypeFlx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbTypeFlx.Location = New System.Drawing.Point(10, 19)
        Me.rbTypeFlx.Name = "rbTypeFlx"
        Me.rbTypeFlx.Size = New System.Drawing.Size(54, 25)
        Me.rbTypeFlx.TabIndex = 0
        Me.rbTypeFlx.Text = "Flexible"
        Me.rbTypeFlx.UseVisualStyleBackColor = True
        '
        'chkAdjLaneBound
        '
        Me.chkAdjLaneBound.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkAdjLaneBound.AutoSize = True
        Me.chkAdjLaneBound.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue
        Me.chkAdjLaneBound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkAdjLaneBound.Location = New System.Drawing.Point(93, 285)
        Me.chkAdjLaneBound.Name = "chkAdjLaneBound"
        Me.chkAdjLaneBound.Size = New System.Drawing.Size(75, 23)
        Me.chkAdjLaneBound.TabIndex = 29
        Me.chkAdjLaneBound.Text = "  Adj.   Lines"
        Me.ToolTips.SetToolTip(Me.chkAdjLaneBound, "Ajust reference lines")
        Me.chkAdjLaneBound.UseVisualStyleBackColor = True
        '
        'btnReadGeo
        '
        Me.btnReadGeo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReadGeo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReadGeo.Location = New System.Drawing.Point(136, 500)
        Me.btnReadGeo.Name = "btnReadGeo"
        Me.btnReadGeo.Size = New System.Drawing.Size(115, 30)
        Me.btnReadGeo.TabIndex = 28
        Me.btnReadGeo.Text = "Read Geo Ref"
        Me.btnReadGeo.UseVisualStyleBackColor = True
        '
        'btnSaveGeo
        '
        Me.btnSaveGeo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSaveGeo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveGeo.Location = New System.Drawing.Point(6, 500)
        Me.btnSaveGeo.Name = "btnSaveGeo"
        Me.btnSaveGeo.Size = New System.Drawing.Size(115, 30)
        Me.btnSaveGeo.TabIndex = 27
        Me.btnSaveGeo.Text = "Save Geo Ref"
        Me.btnSaveGeo.UseVisualStyleBackColor = True
        '
        'lbFlagPMPostive
        '
        Me.lbFlagPMPostive.AutoSize = True
        Me.lbFlagPMPostive.Location = New System.Drawing.Point(82, 321)
        Me.lbFlagPMPostive.Name = "lbFlagPMPostive"
        Me.lbFlagPMPostive.Size = New System.Drawing.Size(180, 13)
        Me.lbFlagPMPostive.TabIndex = 26
        Me.lbFlagPMPostive.Text = "PM at DMI=0, negative if decreasing"
        '
        'setPMDMI0
        '
        Me.setPMDMI0.DecimalPlaces = 3
        Me.setPMDMI0.Location = New System.Drawing.Point(6, 319)
        Me.setPMDMI0.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.setPMDMI0.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.setPMDMI0.Name = "setPMDMI0"
        Me.setPMDMI0.Size = New System.Drawing.Size(73, 20)
        Me.setPMDMI0.TabIndex = 25
        Me.setPMDMI0.TabStop = False
        Me.ToolTips.SetToolTip(Me.setPMDMI0, "Negative if PM decreasing")
        '
        'chkPickDMI0
        '
        Me.chkPickDMI0.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkPickDMI0.AutoSize = True
        Me.chkPickDMI0.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue
        Me.chkPickDMI0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkPickDMI0.Location = New System.Drawing.Point(6, 285)
        Me.chkPickDMI0.Name = "chkPickDMI0"
        Me.chkPickDMI0.Size = New System.Drawing.Size(70, 23)
        Me.chkPickDMI0.TabIndex = 23
        Me.chkPickDMI0.Text = "Pick DMI 0"
        Me.ToolTips.SetToolTip(Me.chkPickDMI0, "Double click the location of DMI=0 on downward image")
        Me.chkPickDMI0.UseVisualStyleBackColor = True
        '
        'chkShowCrack2
        '
        Me.chkShowCrack2.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkShowCrack2.AutoSize = True
        Me.chkShowCrack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowCrack2.Location = New System.Drawing.Point(179, 285)
        Me.chkShowCrack2.Name = "chkShowCrack2"
        Me.chkShowCrack2.Size = New System.Drawing.Size(81, 23)
        Me.chkShowCrack2.TabIndex = 22
        Me.chkShowCrack2.Text = "Shw  Distress"
        Me.chkShowCrack2.UseVisualStyleBackColor = True
        '
        'setScaleMag
        '
        Me.setScaleMag.DecimalPlaces = 1
        Me.setScaleMag.Increment = New Decimal(New Integer() {2, 0, 0, 65536})
        Me.setScaleMag.Location = New System.Drawing.Point(6, 256)
        Me.setScaleMag.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.setScaleMag.Name = "setScaleMag"
        Me.setScaleMag.Size = New System.Drawing.Size(69, 20)
        Me.setScaleMag.TabIndex = 19
        Me.setScaleMag.TabStop = False
        Me.setScaleMag.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'chkMag
        '
        Me.chkMag.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkMag.AutoSize = True
        Me.chkMag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkMag.Location = New System.Drawing.Point(6, 227)
        Me.chkMag.Name = "chkMag"
        Me.chkMag.Size = New System.Drawing.Size(69, 23)
        Me.chkMag.TabIndex = 18
        Me.chkMag.Text = "  Magnify   "
        Me.chkMag.UseVisualStyleBackColor = True
        '
        'chkMeasure
        '
        Me.chkMeasure.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkMeasure.AutoSize = True
        Me.chkMeasure.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue
        Me.chkMeasure.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkMeasure.Location = New System.Drawing.Point(93, 227)
        Me.chkMeasure.Name = "chkMeasure"
        Me.chkMeasure.Size = New System.Drawing.Size(76, 23)
        Me.chkMeasure.TabIndex = 17
        Me.chkMeasure.Text = "   Measure   "
        Me.chkMeasure.UseVisualStyleBackColor = True
        '
        'chkShowMap
        '
        Me.chkShowMap.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkShowMap.AutoSize = True
        Me.chkShowMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowMap.Location = New System.Drawing.Point(179, 256)
        Me.chkShowMap.Name = "chkShowMap"
        Me.chkShowMap.Size = New System.Drawing.Size(77, 23)
        Me.chkShowMap.TabIndex = 16
        Me.chkShowMap.Tag = "Show google map in a new window.  Double click any location on downward image to " & _
            "see the location in google map."
        Me.chkShowMap.Text = "Show    Map"
        Me.chkShowMap.UseVisualStyleBackColor = True
        '
        'chkShowFiles
        '
        Me.chkShowFiles.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkShowFiles.AutoSize = True
        Me.chkShowFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowFiles.Location = New System.Drawing.Point(93, 256)
        Me.chkShowFiles.Name = "chkShowFiles"
        Me.chkShowFiles.Size = New System.Drawing.Size(76, 23)
        Me.chkShowFiles.TabIndex = 15
        Me.chkShowFiles.Text = "Show    JPG"
        Me.chkShowFiles.UseVisualStyleBackColor = True
        '
        'chkShowCL
        '
        Me.chkShowCL.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkShowCL.AutoSize = True
        Me.chkShowCL.Checked = True
        Me.chkShowCL.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowCL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowCL.Location = New System.Drawing.Point(179, 227)
        Me.chkShowCL.Name = "chkShowCL"
        Me.chkShowCL.Size = New System.Drawing.Size(78, 23)
        Me.chkShowCL.TabIndex = 14
        Me.chkShowCL.Text = "Show   Lines"
        Me.chkShowCL.UseVisualStyleBackColor = True
        '
        'chkShowCompass
        '
        Me.chkShowCompass.AutoSize = True
        Me.chkShowCompass.Enabled = False
        Me.chkShowCompass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowCompass.Location = New System.Drawing.Point(179, 146)
        Me.chkShowCompass.Name = "chkShowCompass"
        Me.chkShowCompass.Size = New System.Drawing.Size(66, 17)
        Me.chkShowCompass.TabIndex = 13
        Me.chkShowCompass.Text = "Compass"
        Me.chkShowCompass.UseVisualStyleBackColor = True
        '
        'chkShowCursorGeo
        '
        Me.chkShowCursorGeo.AutoSize = True
        Me.chkShowCursorGeo.Enabled = False
        Me.chkShowCursorGeo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowCursorGeo.Location = New System.Drawing.Point(93, 172)
        Me.chkShowCursorGeo.Name = "chkShowCursorGeo"
        Me.chkShowCursorGeo.Size = New System.Drawing.Size(107, 17)
        Me.chkShowCursorGeo.TabIndex = 12
        Me.chkShowCursorGeo.Text = "Show Geo Coord."
        Me.chkShowCursorGeo.UseVisualStyleBackColor = True
        '
        'chkShowRefGeo
        '
        Me.chkShowRefGeo.AutoSize = True
        Me.chkShowRefGeo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowRefGeo.Location = New System.Drawing.Point(93, 149)
        Me.chkShowRefGeo.Name = "chkShowRefGeo"
        Me.chkShowRefGeo.Size = New System.Drawing.Size(73, 17)
        Me.chkShowRefGeo.TabIndex = 10
        Me.chkShowRefGeo.Text = "Show Ref."
        Me.chkShowRefGeo.UseVisualStyleBackColor = True
        '
        'btnImpList
        '
        Me.btnImpList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImpList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImpList.ForeColor = System.Drawing.Color.White
        Me.btnImpList.Location = New System.Drawing.Point(6, 23)
        Me.btnImpList.Name = "btnImpList"
        Me.btnImpList.Size = New System.Drawing.Size(73, 83)
        Me.btnImpList.TabIndex = 0
        Me.btnImpList.Text = "Load Images"
        Me.ToolTips.SetToolTip(Me.btnImpList, "Load downward pavement images.  It may take a couple minutes.  Don't load more th" & _
                "an 60 photos (assuming 8M pixels per pix) if you have a 32-bit version.")
        Me.btnImpList.UseVisualStyleBackColor = True
        '
        'tabFlx
        '
        Me.tabFlx.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tabFlx.Controls.Add(Me.btnFlxReport)
        Me.tabFlx.Controls.Add(Me.gbEditCrack)
        Me.tabFlx.Controls.Add(Me.btnRmvCrack)
        Me.tabFlx.Controls.Add(Me.chkEditCrack)
        Me.tabFlx.Controls.Add(Me.chkShowCrack)
        Me.tabFlx.Controls.Add(Me.gbAddCrack)
        Me.tabFlx.Controls.Add(Me.chkAddingCrack)
        Me.tabFlx.Location = New System.Drawing.Point(4, 22)
        Me.tabFlx.Name = "tabFlx"
        Me.tabFlx.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFlx.Size = New System.Drawing.Size(262, 572)
        Me.tabFlx.TabIndex = 1
        Me.tabFlx.Text = "Flexible"
        Me.tabFlx.UseVisualStyleBackColor = True
        '
        'btnFlxReport
        '
        Me.btnFlxReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFlxReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFlxReport.ForeColor = System.Drawing.Color.DarkOrange
        Me.btnFlxReport.Location = New System.Drawing.Point(169, 516)
        Me.btnFlxReport.Name = "btnFlxReport"
        Me.btnFlxReport.Size = New System.Drawing.Size(88, 47)
        Me.btnFlxReport.TabIndex = 10
        Me.btnFlxReport.Text = "Generate Report"
        Me.btnFlxReport.UseVisualStyleBackColor = True
        '
        'gbEditCrack
        '
        Me.gbEditCrack.Controls.Add(Me.GroupBox1)
        Me.gbEditCrack.Controls.Add(Me.GroupBox2)
        Me.gbEditCrack.Location = New System.Drawing.Point(3, 229)
        Me.gbEditCrack.Name = "gbEditCrack"
        Me.gbEditCrack.Size = New System.Drawing.Size(249, 113)
        Me.gbEditCrack.TabIndex = 7
        Me.gbEditCrack.TabStop = False
        Me.gbEditCrack.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbEditWide)
        Me.GroupBox1.Controls.Add(Me.rbEditNarrow)
        Me.GroupBox1.Controls.Add(Me.rbEditSealed)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 37)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'rbEditWide
        '
        Me.rbEditWide.AutoSize = True
        Me.rbEditWide.Location = New System.Drawing.Point(173, 14)
        Me.rbEditWide.Name = "rbEditWide"
        Me.rbEditWide.Size = New System.Drawing.Size(50, 17)
        Me.rbEditWide.TabIndex = 2
        Me.rbEditWide.TabStop = True
        Me.rbEditWide.Text = "Wide"
        Me.rbEditWide.UseVisualStyleBackColor = True
        '
        'rbEditNarrow
        '
        Me.rbEditNarrow.AutoSize = True
        Me.rbEditNarrow.Location = New System.Drawing.Point(91, 14)
        Me.rbEditNarrow.Name = "rbEditNarrow"
        Me.rbEditNarrow.Size = New System.Drawing.Size(59, 17)
        Me.rbEditNarrow.TabIndex = 1
        Me.rbEditNarrow.TabStop = True
        Me.rbEditNarrow.Text = "Narrow"
        Me.rbEditNarrow.UseVisualStyleBackColor = True
        '
        'rbEditSealed
        '
        Me.rbEditSealed.AutoSize = True
        Me.rbEditSealed.Location = New System.Drawing.Point(8, 14)
        Me.rbEditSealed.Name = "rbEditSealed"
        Me.rbEditSealed.Size = New System.Drawing.Size(58, 17)
        Me.rbEditSealed.TabIndex = 0
        Me.rbEditSealed.TabStop = True
        Me.rbEditSealed.Text = "Sealed"
        Me.rbEditSealed.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbEditXF)
        Me.GroupBox2.Controls.Add(Me.rbEditWP)
        Me.GroupBox2.Controls.Add(Me.rbEditLongi)
        Me.GroupBox2.Controls.Add(Me.rbEditTrans)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(237, 55)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'rbEditXF
        '
        Me.rbEditXF.AutoSize = True
        Me.rbEditXF.Location = New System.Drawing.Point(125, 32)
        Me.rbEditXF.Name = "rbEditXF"
        Me.rbEditXF.Size = New System.Drawing.Size(69, 17)
        Me.rbEditXF.TabIndex = 3
        Me.rbEditXF.TabStop = True
        Me.rbEditXF.Text = "XF-Crack"
        Me.rbEditXF.UseVisualStyleBackColor = True
        '
        'rbEditWP
        '
        Me.rbEditWP.AutoSize = True
        Me.rbEditWP.Location = New System.Drawing.Point(8, 32)
        Me.rbEditWP.Name = "rbEditWP"
        Me.rbEditWP.Size = New System.Drawing.Size(77, 17)
        Me.rbEditWP.TabIndex = 2
        Me.rbEditWP.TabStop = True
        Me.rbEditWP.Text = "Wheelpath"
        Me.rbEditWP.UseVisualStyleBackColor = True
        '
        'rbEditLongi
        '
        Me.rbEditLongi.AutoSize = True
        Me.rbEditLongi.Location = New System.Drawing.Point(125, 14)
        Me.rbEditLongi.Name = "rbEditLongi"
        Me.rbEditLongi.Size = New System.Drawing.Size(82, 17)
        Me.rbEditLongi.TabIndex = 1
        Me.rbEditLongi.TabStop = True
        Me.rbEditLongi.Text = "Longitudinal"
        Me.rbEditLongi.UseVisualStyleBackColor = True
        '
        'rbEditTrans
        '
        Me.rbEditTrans.AutoSize = True
        Me.rbEditTrans.Checked = True
        Me.rbEditTrans.Location = New System.Drawing.Point(8, 14)
        Me.rbEditTrans.Name = "rbEditTrans"
        Me.rbEditTrans.Size = New System.Drawing.Size(79, 17)
        Me.rbEditTrans.TabIndex = 0
        Me.rbEditTrans.TabStop = True
        Me.rbEditTrans.Text = "Tranvserve"
        Me.rbEditTrans.UseVisualStyleBackColor = True
        '
        'btnRmvCrack
        '
        Me.btnRmvCrack.Enabled = False
        Me.btnRmvCrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRmvCrack.Location = New System.Drawing.Point(162, 200)
        Me.btnRmvCrack.Name = "btnRmvCrack"
        Me.btnRmvCrack.Size = New System.Drawing.Size(75, 23)
        Me.btnRmvCrack.TabIndex = 6
        Me.btnRmvCrack.Text = "Remove"
        Me.btnRmvCrack.UseVisualStyleBackColor = True
        '
        'chkEditCrack
        '
        Me.chkEditCrack.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkEditCrack.AutoSize = True
        Me.chkEditCrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkEditCrack.Location = New System.Drawing.Point(4, 200)
        Me.chkEditCrack.Name = "chkEditCrack"
        Me.chkEditCrack.Size = New System.Drawing.Size(140, 23)
        Me.chkEditCrack.TabIndex = 5
        Me.chkEditCrack.Text = "Edit Crack/Patch/Pothole"
        Me.chkEditCrack.UseVisualStyleBackColor = True
        '
        'chkShowCrack
        '
        Me.chkShowCrack.AutoSize = True
        Me.chkShowCrack.Location = New System.Drawing.Point(150, 11)
        Me.chkShowCrack.Name = "chkShowCrack"
        Me.chkShowCrack.Size = New System.Drawing.Size(93, 17)
        Me.chkShowCrack.TabIndex = 4
        Me.chkShowCrack.Text = "Show Distress"
        Me.chkShowCrack.UseVisualStyleBackColor = True
        '
        'gbAddCrack
        '
        Me.gbAddCrack.Controls.Add(Me.btnNewPothole)
        Me.gbAddCrack.Controls.Add(Me.rbCrkWide)
        Me.gbAddCrack.Controls.Add(Me.btnNewPatch)
        Me.gbAddCrack.Controls.Add(Me.btnNewWPCrk)
        Me.gbAddCrack.Controls.Add(Me.btnNewXCrk)
        Me.gbAddCrack.Controls.Add(Me.rbCrkNarrow)
        Me.gbAddCrack.Controls.Add(Me.btnNewLongCrk)
        Me.gbAddCrack.Controls.Add(Me.rbCrkSeal)
        Me.gbAddCrack.Controls.Add(Me.btnNewTranCrk)
        Me.gbAddCrack.Enabled = False
        Me.gbAddCrack.Location = New System.Drawing.Point(3, 29)
        Me.gbAddCrack.Name = "gbAddCrack"
        Me.gbAddCrack.Size = New System.Drawing.Size(254, 145)
        Me.gbAddCrack.TabIndex = 3
        Me.gbAddCrack.TabStop = False
        '
        'btnNewPothole
        '
        Me.btnNewPothole.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.btnNewPothole.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.btnNewPothole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewPothole.Location = New System.Drawing.Point(131, 112)
        Me.btnNewPothole.Name = "btnNewPothole"
        Me.btnNewPothole.Size = New System.Drawing.Size(103, 23)
        Me.btnNewPothole.TabIndex = 6
        Me.btnNewPothole.Text = "New Pothole"
        Me.btnNewPothole.UseVisualStyleBackColor = True
        '
        'rbCrkWide
        '
        Me.rbCrkWide.AutoSize = True
        Me.rbCrkWide.Location = New System.Drawing.Point(179, 80)
        Me.rbCrkWide.Name = "rbCrkWide"
        Me.rbCrkWide.Size = New System.Drawing.Size(50, 17)
        Me.rbCrkWide.TabIndex = 3
        Me.rbCrkWide.Text = "Wide"
        Me.rbCrkWide.UseVisualStyleBackColor = True
        '
        'btnNewPatch
        '
        Me.btnNewPatch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.btnNewPatch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.btnNewPatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewPatch.Location = New System.Drawing.Point(14, 112)
        Me.btnNewPatch.Name = "btnNewPatch"
        Me.btnNewPatch.Size = New System.Drawing.Size(103, 23)
        Me.btnNewPatch.TabIndex = 5
        Me.btnNewPatch.Text = "New Patch"
        Me.btnNewPatch.UseVisualStyleBackColor = True
        '
        'btnNewWPCrk
        '
        Me.btnNewWPCrk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.btnNewWPCrk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.btnNewWPCrk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewWPCrk.Location = New System.Drawing.Point(14, 51)
        Me.btnNewWPCrk.Name = "btnNewWPCrk"
        Me.btnNewWPCrk.Size = New System.Drawing.Size(103, 23)
        Me.btnNewWPCrk.TabIndex = 0
        Me.btnNewWPCrk.Text = "New WP Crack"
        Me.btnNewWPCrk.UseVisualStyleBackColor = True
        '
        'btnNewXCrk
        '
        Me.btnNewXCrk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.btnNewXCrk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.btnNewXCrk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewXCrk.Location = New System.Drawing.Point(131, 51)
        Me.btnNewXCrk.Name = "btnNewXCrk"
        Me.btnNewXCrk.Size = New System.Drawing.Size(103, 23)
        Me.btnNewXCrk.TabIndex = 0
        Me.btnNewXCrk.Text = "New X-Crack"
        Me.btnNewXCrk.UseVisualStyleBackColor = True
        '
        'rbCrkNarrow
        '
        Me.rbCrkNarrow.AutoSize = True
        Me.rbCrkNarrow.Location = New System.Drawing.Point(97, 80)
        Me.rbCrkNarrow.Name = "rbCrkNarrow"
        Me.rbCrkNarrow.Size = New System.Drawing.Size(59, 17)
        Me.rbCrkNarrow.TabIndex = 2
        Me.rbCrkNarrow.Text = "Narrow"
        Me.rbCrkNarrow.UseVisualStyleBackColor = True
        '
        'btnNewLongCrk
        '
        Me.btnNewLongCrk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.btnNewLongCrk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.btnNewLongCrk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewLongCrk.Location = New System.Drawing.Point(131, 19)
        Me.btnNewLongCrk.Name = "btnNewLongCrk"
        Me.btnNewLongCrk.Size = New System.Drawing.Size(103, 26)
        Me.btnNewLongCrk.TabIndex = 0
        Me.btnNewLongCrk.Text = "New Long. Crack"
        Me.btnNewLongCrk.UseVisualStyleBackColor = True
        '
        'rbCrkSeal
        '
        Me.rbCrkSeal.AutoSize = True
        Me.rbCrkSeal.Checked = True
        Me.rbCrkSeal.Location = New System.Drawing.Point(14, 80)
        Me.rbCrkSeal.Name = "rbCrkSeal"
        Me.rbCrkSeal.Size = New System.Drawing.Size(58, 17)
        Me.rbCrkSeal.TabIndex = 1
        Me.rbCrkSeal.TabStop = True
        Me.rbCrkSeal.Text = "Sealed"
        Me.rbCrkSeal.UseVisualStyleBackColor = True
        '
        'btnNewTranCrk
        '
        Me.btnNewTranCrk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.btnNewTranCrk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.btnNewTranCrk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewTranCrk.Location = New System.Drawing.Point(14, 19)
        Me.btnNewTranCrk.Name = "btnNewTranCrk"
        Me.btnNewTranCrk.Size = New System.Drawing.Size(103, 26)
        Me.btnNewTranCrk.TabIndex = 0
        Me.btnNewTranCrk.Text = "New Tran. Crack"
        Me.btnNewTranCrk.UseVisualStyleBackColor = True
        '
        'chkAddingCrack
        '
        Me.chkAddingCrack.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkAddingCrack.AutoSize = True
        Me.chkAddingCrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkAddingCrack.Location = New System.Drawing.Point(3, 6)
        Me.chkAddingCrack.Name = "chkAddingCrack"
        Me.chkAddingCrack.Size = New System.Drawing.Size(76, 23)
        Me.chkAddingCrack.TabIndex = 2
        Me.chkAddingCrack.Text = "Add Distress"
        Me.chkAddingCrack.UseVisualStyleBackColor = True
        '
        'tabRgd
        '
        Me.tabRgd.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tabRgd.Controls.Add(Me.btnRgdReport)
        Me.tabRgd.Controls.Add(Me.rbTranJnt)
        Me.tabRgd.Controls.Add(Me.gbLongJnt)
        Me.tabRgd.Controls.Add(Me.chkShowCrack3)
        Me.tabRgd.Controls.Add(Me.btnRmvRgdDtrs)
        Me.tabRgd.Controls.Add(Me.gbEditRgdDtrs)
        Me.tabRgd.Controls.Add(Me.chkEditRgdDtrs)
        Me.tabRgd.Controls.Add(Me.gbNewRgdDtrs)
        Me.tabRgd.Controls.Add(Me.chkAddRgdDtrs)
        Me.tabRgd.Location = New System.Drawing.Point(4, 22)
        Me.tabRgd.Name = "tabRgd"
        Me.tabRgd.Size = New System.Drawing.Size(262, 572)
        Me.tabRgd.TabIndex = 2
        Me.tabRgd.Text = "Rigid"
        Me.tabRgd.UseVisualStyleBackColor = True
        '
        'btnRgdReport
        '
        Me.btnRgdReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRgdReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRgdReport.ForeColor = System.Drawing.Color.DarkOrange
        Me.btnRgdReport.Location = New System.Drawing.Point(115, 530)
        Me.btnRgdReport.Name = "btnRgdReport"
        Me.btnRgdReport.Size = New System.Drawing.Size(139, 36)
        Me.btnRgdReport.TabIndex = 10
        Me.btnRgdReport.Text = "Generate Report"
        Me.btnRgdReport.UseVisualStyleBackColor = True
        '
        'rbTranJnt
        '
        Me.rbTranJnt.Controls.Add(Me.GroupBox6)
        Me.rbTranJnt.Controls.Add(Me.GroupBox5)
        Me.rbTranJnt.Location = New System.Drawing.Point(135, 401)
        Me.rbTranJnt.Name = "rbTranJnt"
        Me.rbTranJnt.Size = New System.Drawing.Size(119, 123)
        Me.rbTranJnt.TabIndex = 9
        Me.rbTranJnt.TabStop = False
        Me.rbTranJnt.Text = "Transverse Joint"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rbTransJntNSpall)
        Me.GroupBox6.Controls.Add(Me.rbTransJntSpall)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 64)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(107, 52)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        '
        'rbTransJntNSpall
        '
        Me.rbTransJntNSpall.AutoSize = True
        Me.rbTransJntNSpall.Checked = True
        Me.rbTransJntNSpall.Location = New System.Drawing.Point(7, 29)
        Me.rbTransJntNSpall.Name = "rbTransJntNSpall"
        Me.rbTransJntNSpall.Size = New System.Drawing.Size(80, 17)
        Me.rbTransJntNSpall.TabIndex = 1
        Me.rbTransJntNSpall.TabStop = True
        Me.rbTransJntNSpall.Text = "Not Spalled"
        Me.rbTransJntNSpall.UseVisualStyleBackColor = True
        '
        'rbTransJntSpall
        '
        Me.rbTransJntSpall.AutoSize = True
        Me.rbTransJntSpall.Location = New System.Drawing.Point(7, 10)
        Me.rbTransJntSpall.Name = "rbTransJntSpall"
        Me.rbTransJntSpall.Size = New System.Drawing.Size(60, 17)
        Me.rbTransJntSpall.TabIndex = 0
        Me.rbTransJntSpall.Text = "Spalled"
        Me.rbTransJntSpall.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rbTransJntNSeal)
        Me.GroupBox5.Controls.Add(Me.rbTransJntSeal)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 14)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(107, 48)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        '
        'rbTransJntNSeal
        '
        Me.rbTransJntNSeal.AutoSize = True
        Me.rbTransJntNSeal.Location = New System.Drawing.Point(7, 30)
        Me.rbTransJntNSeal.Name = "rbTransJntNSeal"
        Me.rbTransJntNSeal.Size = New System.Drawing.Size(78, 17)
        Me.rbTransJntNSeal.TabIndex = 1
        Me.rbTransJntNSeal.Text = "Not Sealed"
        Me.rbTransJntNSeal.UseVisualStyleBackColor = True
        '
        'rbTransJntSeal
        '
        Me.rbTransJntSeal.AutoSize = True
        Me.rbTransJntSeal.Checked = True
        Me.rbTransJntSeal.Location = New System.Drawing.Point(7, 10)
        Me.rbTransJntSeal.Name = "rbTransJntSeal"
        Me.rbTransJntSeal.Size = New System.Drawing.Size(58, 17)
        Me.rbTransJntSeal.TabIndex = 0
        Me.rbTransJntSeal.TabStop = True
        Me.rbTransJntSeal.Text = "Sealed"
        Me.rbTransJntSeal.UseVisualStyleBackColor = True
        '
        'gbLongJnt
        '
        Me.gbLongJnt.Controls.Add(Me.GroupBox4)
        Me.gbLongJnt.Controls.Add(Me.GroupBox3)
        Me.gbLongJnt.Location = New System.Drawing.Point(8, 401)
        Me.gbLongJnt.Name = "gbLongJnt"
        Me.gbLongJnt.Size = New System.Drawing.Size(121, 123)
        Me.gbLongJnt.TabIndex = 9
        Me.gbLongJnt.TabStop = False
        Me.gbLongJnt.Text = "Longitudinal Joint"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbLongJntNSpall)
        Me.GroupBox4.Controls.Add(Me.rbLongJntSpall)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 64)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(112, 52)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'rbLongJntNSpall
        '
        Me.rbLongJntNSpall.AutoSize = True
        Me.rbLongJntNSpall.Checked = True
        Me.rbLongJntNSpall.Location = New System.Drawing.Point(7, 29)
        Me.rbLongJntNSpall.Name = "rbLongJntNSpall"
        Me.rbLongJntNSpall.Size = New System.Drawing.Size(80, 17)
        Me.rbLongJntNSpall.TabIndex = 1
        Me.rbLongJntNSpall.TabStop = True
        Me.rbLongJntNSpall.Text = "Not Spalled"
        Me.rbLongJntNSpall.UseVisualStyleBackColor = True
        '
        'rbLongJntSpall
        '
        Me.rbLongJntSpall.AutoSize = True
        Me.rbLongJntSpall.Location = New System.Drawing.Point(7, 10)
        Me.rbLongJntSpall.Name = "rbLongJntSpall"
        Me.rbLongJntSpall.Size = New System.Drawing.Size(60, 17)
        Me.rbLongJntSpall.TabIndex = 0
        Me.rbLongJntSpall.Text = "Spalled"
        Me.rbLongJntSpall.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbLongJntNSeal)
        Me.GroupBox3.Controls.Add(Me.rbLongJntSeal)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(112, 48)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'rbLongJntNSeal
        '
        Me.rbLongJntNSeal.AutoSize = True
        Me.rbLongJntNSeal.Location = New System.Drawing.Point(7, 30)
        Me.rbLongJntNSeal.Name = "rbLongJntNSeal"
        Me.rbLongJntNSeal.Size = New System.Drawing.Size(78, 17)
        Me.rbLongJntNSeal.TabIndex = 1
        Me.rbLongJntNSeal.Text = "Not Sealed"
        Me.rbLongJntNSeal.UseVisualStyleBackColor = True
        '
        'rbLongJntSeal
        '
        Me.rbLongJntSeal.AutoSize = True
        Me.rbLongJntSeal.Checked = True
        Me.rbLongJntSeal.Location = New System.Drawing.Point(7, 10)
        Me.rbLongJntSeal.Name = "rbLongJntSeal"
        Me.rbLongJntSeal.Size = New System.Drawing.Size(58, 17)
        Me.rbLongJntSeal.TabIndex = 0
        Me.rbLongJntSeal.TabStop = True
        Me.rbLongJntSeal.Text = "Sealed"
        Me.rbLongJntSeal.UseVisualStyleBackColor = True
        '
        'chkShowCrack3
        '
        Me.chkShowCrack3.AutoSize = True
        Me.chkShowCrack3.Location = New System.Drawing.Point(150, 9)
        Me.chkShowCrack3.Name = "chkShowCrack3"
        Me.chkShowCrack3.Size = New System.Drawing.Size(93, 17)
        Me.chkShowCrack3.TabIndex = 8
        Me.chkShowCrack3.Text = "Show Distress"
        Me.chkShowCrack3.UseVisualStyleBackColor = True
        '
        'btnRmvRgdDtrs
        '
        Me.btnRmvRgdDtrs.Enabled = False
        Me.btnRmvRgdDtrs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRmvRgdDtrs.Location = New System.Drawing.Point(150, 205)
        Me.btnRmvRgdDtrs.Name = "btnRmvRgdDtrs"
        Me.btnRmvRgdDtrs.Size = New System.Drawing.Size(75, 23)
        Me.btnRmvRgdDtrs.TabIndex = 7
        Me.btnRmvRgdDtrs.Text = "Remove"
        Me.btnRmvRgdDtrs.UseVisualStyleBackColor = True
        '
        'gbEditRgdDtrs
        '
        Me.gbEditRgdDtrs.Controls.Add(Me.gbEditRgdDtrsType)
        Me.gbEditRgdDtrs.Controls.Add(Me.gbEditRgdSpall)
        Me.gbEditRgdDtrs.Controls.Add(Me.gbEditRgdSeal)
        Me.gbEditRgdDtrs.Enabled = False
        Me.gbEditRgdDtrs.Location = New System.Drawing.Point(8, 228)
        Me.gbEditRgdDtrs.Name = "gbEditRgdDtrs"
        Me.gbEditRgdDtrs.Size = New System.Drawing.Size(246, 168)
        Me.gbEditRgdDtrs.TabIndex = 6
        Me.gbEditRgdDtrs.TabStop = False
        Me.gbEditRgdDtrs.Visible = False
        '
        'gbEditRgdDtrsType
        '
        Me.gbEditRgdDtrsType.Controls.Add(Me.rbEditRgdCorner)
        Me.gbEditRgdDtrsType.Controls.Add(Me.rbEditRgdPatch)
        Me.gbEditRgdDtrsType.Controls.Add(Me.rbEditRgdXJ)
        Me.gbEditRgdDtrsType.Controls.Add(Me.rbEditRgdTrans)
        Me.gbEditRgdDtrsType.Controls.Add(Me.rbEditRgdLongi)
        Me.gbEditRgdDtrsType.Location = New System.Drawing.Point(6, 8)
        Me.gbEditRgdDtrsType.Name = "gbEditRgdDtrsType"
        Me.gbEditRgdDtrsType.Size = New System.Drawing.Size(130, 155)
        Me.gbEditRgdDtrsType.TabIndex = 2
        Me.gbEditRgdDtrsType.TabStop = False
        '
        'rbEditRgdCorner
        '
        Me.rbEditRgdCorner.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbEditRgdCorner.AutoSize = True
        Me.rbEditRgdCorner.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.rbEditRgdCorner.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.rbEditRgdCorner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.rbEditRgdCorner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbEditRgdCorner.Location = New System.Drawing.Point(12, 68)
        Me.rbEditRgdCorner.Name = "rbEditRgdCorner"
        Me.rbEditRgdCorner.Size = New System.Drawing.Size(105, 25)
        Me.rbEditRgdCorner.TabIndex = 4
        Me.rbEditRgdCorner.TabStop = True
        Me.rbEditRgdCorner.Text = "    Corner Crack    "
        Me.rbEditRgdCorner.UseVisualStyleBackColor = True
        '
        'rbEditRgdPatch
        '
        Me.rbEditRgdPatch.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbEditRgdPatch.AutoSize = True
        Me.rbEditRgdPatch.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.rbEditRgdPatch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.rbEditRgdPatch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.rbEditRgdPatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbEditRgdPatch.Location = New System.Drawing.Point(10, 124)
        Me.rbEditRgdPatch.Name = "rbEditRgdPatch"
        Me.rbEditRgdPatch.Size = New System.Drawing.Size(106, 25)
        Me.rbEditRgdPatch.TabIndex = 3
        Me.rbEditRgdPatch.TabStop = True
        Me.rbEditRgdPatch.Text = "   Asphalt Patch    "
        Me.rbEditRgdPatch.UseVisualStyleBackColor = True
        '
        'rbEditRgdXJ
        '
        Me.rbEditRgdXJ.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbEditRgdXJ.AutoSize = True
        Me.rbEditRgdXJ.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.rbEditRgdXJ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.rbEditRgdXJ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.rbEditRgdXJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbEditRgdXJ.Location = New System.Drawing.Point(10, 96)
        Me.rbEditRgdXJ.Name = "rbEditRgdXJ"
        Me.rbEditRgdXJ.Size = New System.Drawing.Size(107, 25)
        Me.rbEditRgdXJ.TabIndex = 2
        Me.rbEditRgdXJ.TabStop = True
        Me.rbEditRgdXJ.Text = "       XJ-Crack        "
        Me.rbEditRgdXJ.UseVisualStyleBackColor = True
        '
        'rbEditRgdTrans
        '
        Me.rbEditRgdTrans.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbEditRgdTrans.AutoSize = True
        Me.rbEditRgdTrans.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.rbEditRgdTrans.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.rbEditRgdTrans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.rbEditRgdTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbEditRgdTrans.Location = New System.Drawing.Point(12, 40)
        Me.rbEditRgdTrans.Name = "rbEditRgdTrans"
        Me.rbEditRgdTrans.Size = New System.Drawing.Size(106, 25)
        Me.rbEditRgdTrans.TabIndex = 1
        Me.rbEditRgdTrans.TabStop = True
        Me.rbEditRgdTrans.Text = " Transverse Crack"
        Me.rbEditRgdTrans.UseVisualStyleBackColor = True
        '
        'rbEditRgdLongi
        '
        Me.rbEditRgdLongi.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbEditRgdLongi.AutoSize = True
        Me.rbEditRgdLongi.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.rbEditRgdLongi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.rbEditRgdLongi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.rbEditRgdLongi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbEditRgdLongi.Location = New System.Drawing.Point(12, 12)
        Me.rbEditRgdLongi.Name = "rbEditRgdLongi"
        Me.rbEditRgdLongi.Size = New System.Drawing.Size(107, 25)
        Me.rbEditRgdLongi.TabIndex = 0
        Me.rbEditRgdLongi.TabStop = True
        Me.rbEditRgdLongi.Text = "Longitudinal Crack"
        Me.rbEditRgdLongi.UseVisualStyleBackColor = True
        '
        'gbEditRgdSpall
        '
        Me.gbEditRgdSpall.Controls.Add(Me.rbEditRgdNSpall)
        Me.gbEditRgdSpall.Controls.Add(Me.rbEditRgdSpall)
        Me.gbEditRgdSpall.Location = New System.Drawing.Point(142, 97)
        Me.gbEditRgdSpall.Name = "gbEditRgdSpall"
        Me.gbEditRgdSpall.Size = New System.Drawing.Size(98, 60)
        Me.gbEditRgdSpall.TabIndex = 1
        Me.gbEditRgdSpall.TabStop = False
        '
        'rbEditRgdNSpall
        '
        Me.rbEditRgdNSpall.AutoSize = True
        Me.rbEditRgdNSpall.Location = New System.Drawing.Point(6, 33)
        Me.rbEditRgdNSpall.Name = "rbEditRgdNSpall"
        Me.rbEditRgdNSpall.Size = New System.Drawing.Size(80, 17)
        Me.rbEditRgdNSpall.TabIndex = 1
        Me.rbEditRgdNSpall.TabStop = True
        Me.rbEditRgdNSpall.Text = "Not Spalled"
        Me.rbEditRgdNSpall.UseVisualStyleBackColor = True
        '
        'rbEditRgdSpall
        '
        Me.rbEditRgdSpall.AutoSize = True
        Me.rbEditRgdSpall.Location = New System.Drawing.Point(6, 10)
        Me.rbEditRgdSpall.Name = "rbEditRgdSpall"
        Me.rbEditRgdSpall.Size = New System.Drawing.Size(60, 17)
        Me.rbEditRgdSpall.TabIndex = 0
        Me.rbEditRgdSpall.TabStop = True
        Me.rbEditRgdSpall.Text = "Spalled"
        Me.rbEditRgdSpall.UseVisualStyleBackColor = True
        '
        'gbEditRgdSeal
        '
        Me.gbEditRgdSeal.Controls.Add(Me.rbEditRgdNSeal)
        Me.gbEditRgdSeal.Controls.Add(Me.rbEditRgdSeal)
        Me.gbEditRgdSeal.Location = New System.Drawing.Point(142, 19)
        Me.gbEditRgdSeal.Name = "gbEditRgdSeal"
        Me.gbEditRgdSeal.Size = New System.Drawing.Size(98, 61)
        Me.gbEditRgdSeal.TabIndex = 0
        Me.gbEditRgdSeal.TabStop = False
        '
        'rbEditRgdNSeal
        '
        Me.rbEditRgdNSeal.AutoSize = True
        Me.rbEditRgdNSeal.Location = New System.Drawing.Point(6, 36)
        Me.rbEditRgdNSeal.Name = "rbEditRgdNSeal"
        Me.rbEditRgdNSeal.Size = New System.Drawing.Size(78, 17)
        Me.rbEditRgdNSeal.TabIndex = 1
        Me.rbEditRgdNSeal.TabStop = True
        Me.rbEditRgdNSeal.Text = "Not Sealed"
        Me.rbEditRgdNSeal.UseVisualStyleBackColor = True
        '
        'rbEditRgdSeal
        '
        Me.rbEditRgdSeal.AutoSize = True
        Me.rbEditRgdSeal.Location = New System.Drawing.Point(6, 13)
        Me.rbEditRgdSeal.Name = "rbEditRgdSeal"
        Me.rbEditRgdSeal.Size = New System.Drawing.Size(58, 17)
        Me.rbEditRgdSeal.TabIndex = 0
        Me.rbEditRgdSeal.TabStop = True
        Me.rbEditRgdSeal.Text = "Sealed"
        Me.rbEditRgdSeal.UseVisualStyleBackColor = True
        '
        'chkEditRgdDtrs
        '
        Me.chkEditRgdDtrs.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkEditRgdDtrs.AutoSize = True
        Me.chkEditRgdDtrs.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.chkEditRgdDtrs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.chkEditRgdDtrs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.chkEditRgdDtrs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkEditRgdDtrs.Location = New System.Drawing.Point(8, 205)
        Me.chkEditRgdDtrs.Name = "chkEditRgdDtrs"
        Me.chkEditRgdDtrs.Size = New System.Drawing.Size(99, 23)
        Me.chkEditRgdDtrs.TabIndex = 5
        Me.chkEditRgdDtrs.Text = "Edit Crack/Patch"
        Me.chkEditRgdDtrs.UseVisualStyleBackColor = True
        '
        'gbNewRgdDtrs
        '
        Me.gbNewRgdDtrs.Controls.Add(Me.gbRgdDtrs)
        Me.gbNewRgdDtrs.Controls.Add(Me.gbRgdSpall)
        Me.gbNewRgdDtrs.Controls.Add(Me.gbRgdSeal)
        Me.gbNewRgdDtrs.Enabled = False
        Me.gbNewRgdDtrs.Location = New System.Drawing.Point(8, 32)
        Me.gbNewRgdDtrs.Name = "gbNewRgdDtrs"
        Me.gbNewRgdDtrs.Size = New System.Drawing.Size(248, 167)
        Me.gbNewRgdDtrs.TabIndex = 4
        Me.gbNewRgdDtrs.TabStop = False
        Me.gbNewRgdDtrs.Visible = False
        '
        'gbRgdDtrs
        '
        Me.gbRgdDtrs.Controls.Add(Me.rbRgdCorner)
        Me.gbRgdDtrs.Controls.Add(Me.rbRgdPatch)
        Me.gbRgdDtrs.Controls.Add(Me.rbRgdXJCrk)
        Me.gbRgdDtrs.Controls.Add(Me.rbRgdTransCrk)
        Me.gbRgdDtrs.Controls.Add(Me.rbRgdLongCrk)
        Me.gbRgdDtrs.Location = New System.Drawing.Point(6, 11)
        Me.gbRgdDtrs.Name = "gbRgdDtrs"
        Me.gbRgdDtrs.Size = New System.Drawing.Size(130, 150)
        Me.gbRgdDtrs.TabIndex = 1
        Me.gbRgdDtrs.TabStop = False
        '
        'rbRgdCorner
        '
        Me.rbRgdCorner.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbRgdCorner.AutoSize = True
        Me.rbRgdCorner.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.rbRgdCorner.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.rbRgdCorner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.rbRgdCorner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbRgdCorner.Location = New System.Drawing.Point(12, 65)
        Me.rbRgdCorner.Name = "rbRgdCorner"
        Me.rbRgdCorner.Size = New System.Drawing.Size(105, 25)
        Me.rbRgdCorner.TabIndex = 4
        Me.rbRgdCorner.TabStop = True
        Me.rbRgdCorner.Text = "     Corner Crack   "
        Me.rbRgdCorner.UseVisualStyleBackColor = True
        '
        'rbRgdPatch
        '
        Me.rbRgdPatch.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbRgdPatch.AutoSize = True
        Me.rbRgdPatch.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.rbRgdPatch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.rbRgdPatch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.rbRgdPatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbRgdPatch.Location = New System.Drawing.Point(12, 119)
        Me.rbRgdPatch.Name = "rbRgdPatch"
        Me.rbRgdPatch.Size = New System.Drawing.Size(106, 25)
        Me.rbRgdPatch.TabIndex = 3
        Me.rbRgdPatch.Text = "   Asphalt Patch    "
        Me.rbRgdPatch.UseVisualStyleBackColor = True
        '
        'rbRgdXJCrk
        '
        Me.rbRgdXJCrk.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbRgdXJCrk.AutoSize = True
        Me.rbRgdXJCrk.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.rbRgdXJCrk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.rbRgdXJCrk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.rbRgdXJCrk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbRgdXJCrk.Location = New System.Drawing.Point(11, 92)
        Me.rbRgdXJCrk.Name = "rbRgdXJCrk"
        Me.rbRgdXJCrk.Size = New System.Drawing.Size(107, 25)
        Me.rbRgdXJCrk.TabIndex = 2
        Me.rbRgdXJCrk.Text = "        XJ-Crack       "
        Me.rbRgdXJCrk.UseVisualStyleBackColor = True
        '
        'rbRgdTransCrk
        '
        Me.rbRgdTransCrk.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbRgdTransCrk.AutoSize = True
        Me.rbRgdTransCrk.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.rbRgdTransCrk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.rbRgdTransCrk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.rbRgdTransCrk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbRgdTransCrk.Location = New System.Drawing.Point(12, 38)
        Me.rbRgdTransCrk.Name = "rbRgdTransCrk"
        Me.rbRgdTransCrk.Size = New System.Drawing.Size(106, 25)
        Me.rbRgdTransCrk.TabIndex = 1
        Me.rbRgdTransCrk.Text = " Transverse Crack"
        Me.rbRgdTransCrk.UseVisualStyleBackColor = True
        '
        'rbRgdLongCrk
        '
        Me.rbRgdLongCrk.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbRgdLongCrk.AutoSize = True
        Me.rbRgdLongCrk.Checked = True
        Me.rbRgdLongCrk.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.rbRgdLongCrk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.rbRgdLongCrk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.rbRgdLongCrk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbRgdLongCrk.Location = New System.Drawing.Point(12, 11)
        Me.rbRgdLongCrk.Name = "rbRgdLongCrk"
        Me.rbRgdLongCrk.Size = New System.Drawing.Size(107, 25)
        Me.rbRgdLongCrk.TabIndex = 0
        Me.rbRgdLongCrk.TabStop = True
        Me.rbRgdLongCrk.Text = "Longitudinal Crack"
        Me.rbRgdLongCrk.UseVisualStyleBackColor = True
        '
        'gbRgdSpall
        '
        Me.gbRgdSpall.Controls.Add(Me.rbRgdNSpall)
        Me.gbRgdSpall.Controls.Add(Me.rbRgdSpall)
        Me.gbRgdSpall.Location = New System.Drawing.Point(142, 98)
        Me.gbRgdSpall.Name = "gbRgdSpall"
        Me.gbRgdSpall.Size = New System.Drawing.Size(98, 57)
        Me.gbRgdSpall.TabIndex = 3
        Me.gbRgdSpall.TabStop = False
        '
        'rbRgdNSpall
        '
        Me.rbRgdNSpall.AutoSize = True
        Me.rbRgdNSpall.Location = New System.Drawing.Point(6, 34)
        Me.rbRgdNSpall.Name = "rbRgdNSpall"
        Me.rbRgdNSpall.Size = New System.Drawing.Size(80, 17)
        Me.rbRgdNSpall.TabIndex = 3
        Me.rbRgdNSpall.Text = "Not Spalled"
        Me.rbRgdNSpall.UseVisualStyleBackColor = True
        '
        'rbRgdSpall
        '
        Me.rbRgdSpall.AutoSize = True
        Me.rbRgdSpall.Checked = True
        Me.rbRgdSpall.Location = New System.Drawing.Point(6, 11)
        Me.rbRgdSpall.Name = "rbRgdSpall"
        Me.rbRgdSpall.Size = New System.Drawing.Size(60, 17)
        Me.rbRgdSpall.TabIndex = 1
        Me.rbRgdSpall.TabStop = True
        Me.rbRgdSpall.Text = "Spalled"
        Me.rbRgdSpall.UseVisualStyleBackColor = True
        '
        'gbRgdSeal
        '
        Me.gbRgdSeal.Controls.Add(Me.rbRgdNSeal)
        Me.gbRgdSeal.Controls.Add(Me.rbRgdSeal)
        Me.gbRgdSeal.Location = New System.Drawing.Point(142, 22)
        Me.gbRgdSeal.Name = "gbRgdSeal"
        Me.gbRgdSeal.Size = New System.Drawing.Size(98, 56)
        Me.gbRgdSeal.TabIndex = 2
        Me.gbRgdSeal.TabStop = False
        '
        'rbRgdNSeal
        '
        Me.rbRgdNSeal.AutoSize = True
        Me.rbRgdNSeal.Location = New System.Drawing.Point(9, 33)
        Me.rbRgdNSeal.Name = "rbRgdNSeal"
        Me.rbRgdNSeal.Size = New System.Drawing.Size(78, 17)
        Me.rbRgdNSeal.TabIndex = 2
        Me.rbRgdNSeal.Text = "Not Sealed"
        Me.rbRgdNSeal.UseVisualStyleBackColor = True
        '
        'rbRgdSeal
        '
        Me.rbRgdSeal.AutoSize = True
        Me.rbRgdSeal.Checked = True
        Me.rbRgdSeal.Location = New System.Drawing.Point(9, 11)
        Me.rbRgdSeal.Name = "rbRgdSeal"
        Me.rbRgdSeal.Size = New System.Drawing.Size(58, 17)
        Me.rbRgdSeal.TabIndex = 0
        Me.rbRgdSeal.TabStop = True
        Me.rbRgdSeal.Text = "Sealed"
        Me.rbRgdSeal.UseVisualStyleBackColor = True
        '
        'chkAddRgdDtrs
        '
        Me.chkAddRgdDtrs.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkAddRgdDtrs.AutoSize = True
        Me.chkAddRgdDtrs.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.chkAddRgdDtrs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.chkAddRgdDtrs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.chkAddRgdDtrs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkAddRgdDtrs.Location = New System.Drawing.Point(8, 3)
        Me.chkAddRgdDtrs.Name = "chkAddRgdDtrs"
        Me.chkAddRgdDtrs.Size = New System.Drawing.Size(76, 23)
        Me.chkAddRgdDtrs.TabIndex = 0
        Me.chkAddRgdDtrs.Text = "Add Distress"
        Me.chkAddRgdDtrs.UseVisualStyleBackColor = True
        '
        'tabTransProf
        '
        Me.tabTransProf.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tabTransProf.Controls.Add(Me.setIntvShowTPR)
        Me.tabTransProf.Controls.Add(Me.chkShowTPR)
        Me.tabTransProf.Controls.Add(Me.btnReadTRP)
        Me.tabTransProf.Controls.Add(Me.setScaleTP)
        Me.tabTransProf.Controls.Add(Me.chkShowAllTP)
        Me.tabTransProf.Controls.Add(Me.btnRutFlt)
        Me.tabTransProf.Controls.Add(Me.btnReadRut)
        Me.tabTransProf.Controls.Add(Me.btnSaveTPs)
        Me.tabTransProf.Controls.Add(Me.btnOpenTPs)
        Me.tabTransProf.Controls.Add(Me.chkShowTP)
        Me.tabTransProf.Controls.Add(Me.lbCurTP)
        Me.tabTransProf.Controls.Add(Me.btnPreviousTP)
        Me.tabTransProf.Controls.Add(Me.btnNextTP)
        Me.tabTransProf.Controls.Add(Me.Label4)
        Me.tabTransProf.Controls.Add(Me.setCrctFactorTP)
        Me.tabTransProf.Controls.Add(Me.Label3)
        Me.tabTransProf.Controls.Add(Me.setXOffTP)
        Me.tabTransProf.Controls.Add(Me.Label2)
        Me.tabTransProf.Controls.Add(Me.setDMITP)
        Me.tabTransProf.Location = New System.Drawing.Point(4, 22)
        Me.tabTransProf.Name = "tabTransProf"
        Me.tabTransProf.Size = New System.Drawing.Size(262, 572)
        Me.tabTransProf.TabIndex = 3
        Me.tabTransProf.Text = "Rut"
        Me.tabTransProf.UseVisualStyleBackColor = True
        '
        'setIntvShowTPR
        '
        Me.setIntvShowTPR.Location = New System.Drawing.Point(204, 343)
        Me.setIntvShowTPR.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.setIntvShowTPR.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.setIntvShowTPR.Name = "setIntvShowTPR"
        Me.setIntvShowTPR.Size = New System.Drawing.Size(54, 20)
        Me.setIntvShowTPR.TabIndex = 23
        Me.setIntvShowTPR.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'chkShowTPR
        '
        Me.chkShowTPR.AutoSize = True
        Me.chkShowTPR.Location = New System.Drawing.Point(90, 344)
        Me.chkShowTPR.Name = "chkShowTPR"
        Me.chkShowTPR.Size = New System.Drawing.Size(108, 17)
        Me.chkShowTPR.TabIndex = 22
        Me.chkShowTPR.Text = "Show Fugro TPR"
        Me.chkShowTPR.UseVisualStyleBackColor = True
        '
        'btnReadTRP
        '
        Me.btnReadTRP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReadTRP.Location = New System.Drawing.Point(11, 336)
        Me.btnReadTRP.Name = "btnReadTRP"
        Me.btnReadTRP.Size = New System.Drawing.Size(73, 31)
        Me.btnReadTRP.TabIndex = 21
        Me.btnReadTRP.Text = "Read TRP"
        Me.btnReadTRP.UseVisualStyleBackColor = True
        '
        'setScaleTP
        '
        Me.setScaleTP.DecimalPlaces = 1
        Me.setScaleTP.Location = New System.Drawing.Point(127, 118)
        Me.setScaleTP.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.setScaleTP.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.setScaleTP.Name = "setScaleTP"
        Me.setScaleTP.Size = New System.Drawing.Size(119, 20)
        Me.setScaleTP.TabIndex = 20
        Me.ToolTips.SetToolTip(Me.setScaleTP, "num. of pixel per mm depth")
        Me.setScaleTP.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'chkShowAllTP
        '
        Me.chkShowAllTP.AutoSize = True
        Me.chkShowAllTP.Location = New System.Drawing.Point(8, 118)
        Me.chkShowAllTP.Name = "chkShowAllTP"
        Me.chkShowAllTP.Size = New System.Drawing.Size(113, 17)
        Me.chkShowAllTP.TabIndex = 19
        Me.chkShowAllTP.Text = "Show Trans. Profs"
        Me.chkShowAllTP.UseVisualStyleBackColor = True
        '
        'btnRutFlt
        '
        Me.btnRutFlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRutFlt.Location = New System.Drawing.Point(143, 81)
        Me.btnRutFlt.Name = "btnRutFlt"
        Me.btnRutFlt.Size = New System.Drawing.Size(103, 23)
        Me.btnRutFlt.TabIndex = 17
        Me.btnRutFlt.Text = "Cal Rut Depth"
        Me.btnRutFlt.UseVisualStyleBackColor = True
        '
        'btnReadRut
        '
        Me.btnReadRut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReadRut.Location = New System.Drawing.Point(8, 22)
        Me.btnReadRut.Name = "btnReadRut"
        Me.btnReadRut.Size = New System.Drawing.Size(127, 42)
        Me.btnReadRut.TabIndex = 16
        Me.btnReadRut.Text = "Process Trans Prof."
        Me.btnReadRut.UseVisualStyleBackColor = True
        '
        'btnSaveTPs
        '
        Me.btnSaveTPs.Enabled = False
        Me.btnSaveTPs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveTPs.Location = New System.Drawing.Point(139, 514)
        Me.btnSaveTPs.Name = "btnSaveTPs"
        Me.btnSaveTPs.Size = New System.Drawing.Size(93, 45)
        Me.btnSaveTPs.TabIndex = 15
        Me.btnSaveTPs.Text = "Save Profiles"
        Me.ToolTips.SetToolTip(Me.btnSaveTPs, "Not active")
        Me.btnSaveTPs.UseVisualStyleBackColor = True
        '
        'btnOpenTPs
        '
        Me.btnOpenTPs.Enabled = False
        Me.btnOpenTPs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenTPs.Location = New System.Drawing.Point(15, 515)
        Me.btnOpenTPs.Name = "btnOpenTPs"
        Me.btnOpenTPs.Size = New System.Drawing.Size(93, 45)
        Me.btnOpenTPs.TabIndex = 14
        Me.btnOpenTPs.Text = "Open Profiles"
        Me.ToolTips.SetToolTip(Me.btnOpenTPs, "Not active")
        Me.btnOpenTPs.UseVisualStyleBackColor = True
        '
        'chkShowTP
        '
        Me.chkShowTP.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkShowTP.AutoSize = True
        Me.chkShowTP.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.chkShowTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowTP.Location = New System.Drawing.Point(8, 81)
        Me.chkShowTP.Name = "chkShowTP"
        Me.chkShowTP.Size = New System.Drawing.Size(127, 23)
        Me.chkShowTP.TabIndex = 11
        Me.chkShowTP.Text = "Transv. Profile Window"
        Me.chkShowTP.UseVisualStyleBackColor = True
        '
        'lbCurTP
        '
        Me.lbCurTP.AutoSize = True
        Me.lbCurTP.Location = New System.Drawing.Point(175, 22)
        Me.lbCurTP.Name = "lbCurTP"
        Me.lbCurTP.Size = New System.Drawing.Size(34, 13)
        Me.lbCurTP.TabIndex = 10
        Me.lbCurTP.Text = "0 of 0"
        '
        'btnPreviousTP
        '
        Me.btnPreviousTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreviousTP.Location = New System.Drawing.Point(143, 39)
        Me.btnPreviousTP.Name = "btnPreviousTP"
        Me.btnPreviousTP.Size = New System.Drawing.Size(43, 25)
        Me.btnPreviousTP.TabIndex = 9
        Me.btnPreviousTP.Text = "<"
        Me.btnPreviousTP.UseVisualStyleBackColor = True
        '
        'btnNextTP
        '
        Me.btnNextTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextTP.Location = New System.Drawing.Point(203, 39)
        Me.btnNextTP.Name = "btnNextTP"
        Me.btnNextTP.Size = New System.Drawing.Size(43, 25)
        Me.btnNextTP.TabIndex = 8
        Me.btnNextTP.Text = ">"
        Me.btnNextTP.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Distance Correction"
        '
        'setCrctFactorTP
        '
        Me.setCrctFactorTP.DecimalPlaces = 3
        Me.setCrctFactorTP.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.setCrctFactorTP.Location = New System.Drawing.Point(125, 236)
        Me.setCrctFactorTP.Name = "setCrctFactorTP"
        Me.setCrctFactorTP.Size = New System.Drawing.Size(120, 20)
        Me.setCrctFactorTP.TabIndex = 6
        Me.setCrctFactorTP.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Lateral Offset /m"
        '
        'setXOffTP
        '
        Me.setXOffTP.DecimalPlaces = 3
        Me.setXOffTP.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.setXOffTP.Location = New System.Drawing.Point(125, 194)
        Me.setXOffTP.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.setXOffTP.Minimum = New Decimal(New Integer() {5, 0, 0, -2147483648})
        Me.setXOffTP.Name = "setXOffTP"
        Me.setXOffTP.Size = New System.Drawing.Size(120, 20)
        Me.setXOffTP.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "DMI /m"
        '
        'setDMITP
        '
        Me.setDMITP.DecimalPlaces = 2
        Me.setDMITP.Location = New System.Drawing.Point(125, 155)
        Me.setDMITP.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.setDMITP.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.setDMITP.Name = "setDMITP"
        Me.setDMITP.Size = New System.Drawing.Size(121, 20)
        Me.setDMITP.TabIndex = 2
        '
        'txtLati
        '
        Me.txtLati.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtLati.AutoSize = True
        Me.txtLati.Location = New System.Drawing.Point(12, 719)
        Me.txtLati.Name = "txtLati"
        Me.txtLati.Size = New System.Drawing.Size(22, 13)
        Me.txtLati.TabIndex = 8
        Me.txtLati.Text = "Lat"
        '
        'txtLongi
        '
        Me.txtLongi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtLongi.AutoSize = True
        Me.txtLongi.Location = New System.Drawing.Point(12, 702)
        Me.txtLongi.Name = "txtLongi"
        Me.txtLongi.Size = New System.Drawing.Size(33, 13)
        Me.txtLongi.TabIndex = 7
        Me.txtLongi.Text = "Longi"
        '
        'Canvas
        '
        Me.Canvas.BackColor = System.Drawing.Color.Black
        Me.Canvas.Location = New System.Drawing.Point(270, 0)
        Me.Canvas.Name = "Canvas"
        Me.Canvas.Size = New System.Drawing.Size(722, 698)
        Me.Canvas.TabIndex = 0
        Me.Canvas.TabStop = False
        '
        'btnZoomIn
        '
        Me.btnZoomIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZoomIn.ForeColor = System.Drawing.Color.White
        Me.btnZoomIn.Location = New System.Drawing.Point(927, 702)
        Me.btnZoomIn.Name = "btnZoomIn"
        Me.btnZoomIn.Size = New System.Drawing.Size(40, 35)
        Me.btnZoomIn.TabIndex = 2
        Me.btnZoomIn.Text = "In"
        Me.btnZoomIn.UseVisualStyleBackColor = True
        '
        'btnZoomOut
        '
        Me.btnZoomOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZoomOut.ForeColor = System.Drawing.Color.White
        Me.btnZoomOut.Location = New System.Drawing.Point(972, 701)
        Me.btnZoomOut.Name = "btnZoomOut"
        Me.btnZoomOut.Size = New System.Drawing.Size(40, 35)
        Me.btnZoomOut.TabIndex = 3
        Me.btnZoomOut.Text = "Out"
        Me.btnZoomOut.UseVisualStyleBackColor = True
        '
        'setZoomFactor
        '
        Me.setZoomFactor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.setZoomFactor.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.setZoomFactor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.setZoomFactor.DecimalPlaces = 2
        Me.setZoomFactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.setZoomFactor.ForeColor = System.Drawing.Color.White
        Me.setZoomFactor.Location = New System.Drawing.Point(862, 711)
        Me.setZoomFactor.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.setZoomFactor.Name = "setZoomFactor"
        Me.setZoomFactor.Size = New System.Drawing.Size(59, 21)
        Me.setZoomFactor.TabIndex = 4
        Me.setZoomFactor.TabStop = False
        Me.setZoomFactor.Value = New Decimal(New Integer() {12, 0, 0, 65536})
        '
        'Overlay
        '
        Me.Overlay.Location = New System.Drawing.Point(270, 0)
        Me.Overlay.Name = "Overlay"
        Me.Overlay.Size = New System.Drawing.Size(100, 50)
        Me.Overlay.TabIndex = 5
        Me.Overlay.TabStop = False
        '
        'btnFitScr
        '
        Me.btnFitScr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFitScr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFitScr.Location = New System.Drawing.Point(724, 702)
        Me.btnFitScr.Name = "btnFitScr"
        Me.btnFitScr.Size = New System.Drawing.Size(40, 35)
        Me.btnFitScr.TabIndex = 6
        Me.btnFitScr.Text = "Fit"
        Me.btnFitScr.UseVisualStyleBackColor = True
        '
        'scrlCanvas
        '
        Me.scrlCanvas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scrlCanvas.Location = New System.Drawing.Point(995, 0)
        Me.scrlCanvas.Maximum = 0
        Me.scrlCanvas.Minimum = -200
        Me.scrlCanvas.Name = "scrlCanvas"
        Me.scrlCanvas.Size = New System.Drawing.Size(20, 698)
        Me.scrlCanvas.TabIndex = 7
        '
        'btnCompress
        '
        Me.btnCompress.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCompress.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompress.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnCompress.Location = New System.Drawing.Point(816, 702)
        Me.btnCompress.Name = "btnCompress"
        Me.btnCompress.Size = New System.Drawing.Size(40, 35)
        Me.btnCompress.TabIndex = 8
        Me.btnCompress.Text = "↔"
        Me.btnCompress.UseVisualStyleBackColor = True
        '
        'btnExpand
        '
        Me.btnExpand.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpand.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnExpand.Location = New System.Drawing.Point(770, 702)
        Me.btnExpand.Name = "btnExpand"
        Me.btnExpand.Size = New System.Drawing.Size(40, 35)
        Me.btnExpand.TabIndex = 9
        Me.btnExpand.Text = "↕"
        Me.btnExpand.UseVisualStyleBackColor = True
        '
        'setBright
        '
        Me.setBright.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.setBright.Location = New System.Drawing.Point(564, 698)
        Me.setBright.Maximum = 100
        Me.setBright.Minimum = -100
        Me.setBright.Name = "setBright"
        Me.setBright.Size = New System.Drawing.Size(150, 42)
        Me.setBright.TabIndex = 10
        Me.setBright.TabStop = False
        Me.setBright.TickFrequency = 0
        Me.setBright.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'setContrast
        '
        Me.setContrast.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.setContrast.Location = New System.Drawing.Point(408, 698)
        Me.setContrast.Maximum = 100
        Me.setContrast.Minimum = -100
        Me.setContrast.Name = "setContrast"
        Me.setContrast.Size = New System.Drawing.Size(150, 42)
        Me.setContrast.TabIndex = 11
        Me.setContrast.TabStop = False
        Me.setContrast.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'prgLoading
        '
        Me.prgLoading.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.prgLoading.ForeColor = System.Drawing.Color.DarkOrange
        Me.prgLoading.Location = New System.Drawing.Point(417, 726)
        Me.prgLoading.Name = "prgLoading"
        Me.prgLoading.Size = New System.Drawing.Size(285, 14)
        Me.prgLoading.TabIndex = 12
        '
        'message
        '
        Me.message.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.message.ForeColor = System.Drawing.Color.White
        Me.message.Location = New System.Drawing.Point(0, 600)
        Me.message.Multiline = True
        Me.message.Name = "message"
        Me.message.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.message.Size = New System.Drawing.Size(270, 97)
        Me.message.TabIndex = 13
        '
        'lbDMI
        '
        Me.lbDMI.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbDMI.AutoSize = True
        Me.lbDMI.Location = New System.Drawing.Point(191, 702)
        Me.lbDMI.Name = "lbDMI"
        Me.lbDMI.Size = New System.Drawing.Size(27, 13)
        Me.lbDMI.TabIndex = 14
        Me.lbDMI.Text = "DMI"
        '
        'lbPM
        '
        Me.lbPM.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbPM.AutoSize = True
        Me.lbPM.Location = New System.Drawing.Point(191, 719)
        Me.lbPM.Name = "lbPM"
        Me.lbPM.Size = New System.Drawing.Size(23, 13)
        Me.lbPM.TabIndex = 15
        Me.lbPM.Text = "PM"
        '
        'timerFly
        '
        Me.timerFly.Interval = 50
        '
        'pnLongPro
        '
        Me.pnLongPro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnLongPro.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnLongPro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnLongPro.Controls.Add(Me.setProScale)
        Me.pnLongPro.Controls.Add(Me.setActPro)
        Me.pnLongPro.Enabled = False
        Me.pnLongPro.Location = New System.Drawing.Point(878, 543)
        Me.pnLongPro.Name = "pnLongPro"
        Me.pnLongPro.Size = New System.Drawing.Size(114, 154)
        Me.pnLongPro.TabIndex = 16
        Me.pnLongPro.Visible = False
        '
        'setProScale
        '
        Me.setProScale.DecimalPlaces = 3
        Me.setProScale.Location = New System.Drawing.Point(15, 56)
        Me.setProScale.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.setProScale.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.setProScale.Name = "setProScale"
        Me.setProScale.Size = New System.Drawing.Size(84, 20)
        Me.setProScale.TabIndex = 1
        Me.setProScale.Tag = "Num. of pixles per mm depth"
        Me.setProScale.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'setActPro
        '
        Me.setActPro.Location = New System.Drawing.Point(15, 15)
        Me.setActPro.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.setActPro.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.setActPro.Name = "setActPro"
        Me.setActPro.Size = New System.Drawing.Size(84, 20)
        Me.setActPro.TabIndex = 0
        Me.setActPro.Tag = "Channel number.  See proview.  5 is LWP filtered, 6 is RWP"
        Me.setActPro.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'chkImageAdj
        '
        Me.chkImageAdj.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkImageAdj.AutoSize = True
        Me.chkImageAdj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkImageAdj.Location = New System.Drawing.Point(350, 702)
        Me.chkImageAdj.Name = "chkImageAdj"
        Me.chkImageAdj.Size = New System.Drawing.Size(49, 17)
        Me.chkImageAdj.TabIndex = 17
        Me.chkImageAdj.Text = "Apply"
        Me.chkImageAdj.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(457, 726)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(206, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Brightness                                     Contrast"
        '
        'APCSView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.prgLoading)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chkImageAdj)
        Me.Controls.Add(Me.pnLongPro)
        Me.Controls.Add(Me.lbPM)
        Me.Controls.Add(Me.lbDMI)
        Me.Controls.Add(Me.message)
        Me.Controls.Add(Me.setContrast)
        Me.Controls.Add(Me.setBright)
        Me.Controls.Add(Me.btnExpand)
        Me.Controls.Add(Me.btnCompress)
        Me.Controls.Add(Me.scrlCanvas)
        Me.Controls.Add(Me.btnFitScr)
        Me.Controls.Add(Me.Overlay)
        Me.Controls.Add(Me.txtLati)
        Me.Controls.Add(Me.Canvas)
        Me.Controls.Add(Me.txtLongi)
        Me.Controls.Add(Me.setZoomFactor)
        Me.Controls.Add(Me.btnZoomOut)
        Me.Controls.Add(Me.btnZoomIn)
        Me.Controls.Add(Me.MainTab)
        Me.ForeColor = System.Drawing.Color.White
        Me.MinimumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "APCSView"
        Me.Text = "APCSView by UCPRC"
        Me.MainTab.ResumeLayout(False)
        Me.tabSystem.ResumeLayout(False)
        Me.tabSystem.PerformLayout()
        CType(Me.setSkewAng, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSurface.ResumeLayout(False)
        Me.gbSurface.PerformLayout()
        CType(Me.setPMDMI0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setScaleMag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFlx.ResumeLayout(False)
        Me.tabFlx.PerformLayout()
        Me.gbEditCrack.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbAddCrack.ResumeLayout(False)
        Me.gbAddCrack.PerformLayout()
        Me.tabRgd.ResumeLayout(False)
        Me.tabRgd.PerformLayout()
        Me.rbTranJnt.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.gbLongJnt.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.gbEditRgdDtrs.ResumeLayout(False)
        Me.gbEditRgdDtrsType.ResumeLayout(False)
        Me.gbEditRgdDtrsType.PerformLayout()
        Me.gbEditRgdSpall.ResumeLayout(False)
        Me.gbEditRgdSpall.PerformLayout()
        Me.gbEditRgdSeal.ResumeLayout(False)
        Me.gbEditRgdSeal.PerformLayout()
        Me.gbNewRgdDtrs.ResumeLayout(False)
        Me.gbRgdDtrs.ResumeLayout(False)
        Me.gbRgdDtrs.PerformLayout()
        Me.gbRgdSpall.ResumeLayout(False)
        Me.gbRgdSpall.PerformLayout()
        Me.gbRgdSeal.ResumeLayout(False)
        Me.gbRgdSeal.PerformLayout()
        Me.tabTransProf.ResumeLayout(False)
        Me.tabTransProf.PerformLayout()
        CType(Me.setIntvShowTPR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setScaleTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setCrctFactorTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setXOffTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setDMITP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Canvas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setZoomFactor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Overlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setBright, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setContrast, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnLongPro.ResumeLayout(False)
        CType(Me.setProScale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setActPro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainTab As System.Windows.Forms.TabControl
    Friend WithEvents tabSystem As System.Windows.Forms.TabPage
    Friend WithEvents tabFlx As System.Windows.Forms.TabPage
    Friend WithEvents Canvas As System.Windows.Forms.PictureBox
    Friend WithEvents btnImpList As System.Windows.Forms.Button
    Friend WithEvents dlgOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnZoomIn As System.Windows.Forms.Button
    Friend WithEvents btnZoomOut As System.Windows.Forms.Button
    Friend WithEvents setZoomFactor As System.Windows.Forms.NumericUpDown
    Friend WithEvents Overlay As System.Windows.Forms.PictureBox
    Friend WithEvents txtLati As System.Windows.Forms.Label
    Friend WithEvents txtLongi As System.Windows.Forms.Label
    Friend WithEvents btnFitScr As System.Windows.Forms.Button
    Friend WithEvents chkShowRefGeo As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowCursorGeo As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowCompass As System.Windows.Forms.CheckBox
    Friend WithEvents scrlCanvas As System.Windows.Forms.VScrollBar
    Friend WithEvents btnCompress As System.Windows.Forms.Button
    Friend WithEvents btnExpand As System.Windows.Forms.Button
    Friend WithEvents chkShowCL As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowFiles As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowMap As System.Windows.Forms.CheckBox
    Friend WithEvents chkMeasure As System.Windows.Forms.CheckBox
    Friend WithEvents setScaleMag As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkMag As System.Windows.Forms.CheckBox
    Friend WithEvents setBright As System.Windows.Forms.TrackBar
    Friend WithEvents setContrast As System.Windows.Forms.TrackBar
    Friend WithEvents prgLoading As System.Windows.Forms.ProgressBar
    Friend WithEvents message As System.Windows.Forms.TextBox
    Friend WithEvents chkAddingCrack As System.Windows.Forms.CheckBox
    Friend WithEvents gbAddCrack As System.Windows.Forms.GroupBox
    Friend WithEvents btnNewTranCrk As System.Windows.Forms.Button
    Friend WithEvents rbCrkWide As System.Windows.Forms.RadioButton
    Friend WithEvents rbCrkNarrow As System.Windows.Forms.RadioButton
    Friend WithEvents rbCrkSeal As System.Windows.Forms.RadioButton
    Friend WithEvents btnNewLongCrk As System.Windows.Forms.Button
    Friend WithEvents btnNewWPCrk As System.Windows.Forms.Button
    Friend WithEvents btnNewXCrk As System.Windows.Forms.Button
    Friend WithEvents chkShowCrack As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowCrack2 As System.Windows.Forms.CheckBox
    Friend WithEvents btnNewPatch As System.Windows.Forms.Button
    Friend WithEvents btnNewPothole As System.Windows.Forms.Button
    Friend WithEvents gbEditCrack As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbEditLongi As System.Windows.Forms.RadioButton
    Friend WithEvents rbEditTrans As System.Windows.Forms.RadioButton
    Friend WithEvents btnRmvCrack As System.Windows.Forms.Button
    Friend WithEvents chkEditCrack As System.Windows.Forms.CheckBox
    Friend WithEvents rbEditXF As System.Windows.Forms.RadioButton
    Friend WithEvents rbEditWP As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbEditWide As System.Windows.Forms.RadioButton
    Friend WithEvents rbEditNarrow As System.Windows.Forms.RadioButton
    Friend WithEvents rbEditSealed As System.Windows.Forms.RadioButton
    Friend WithEvents btnSaveDistress As System.Windows.Forms.Button
    Friend WithEvents dlgSaveFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnReadDistress As System.Windows.Forms.Button
    Friend WithEvents lbFlagPMPostive As System.Windows.Forms.Label
    Friend WithEvents setPMDMI0 As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkPickDMI0 As System.Windows.Forms.CheckBox
    Friend WithEvents btnReadGeo As System.Windows.Forms.Button
    Friend WithEvents btnSaveGeo As System.Windows.Forms.Button
    Friend WithEvents lbDMI As System.Windows.Forms.Label
    Friend WithEvents lbPM As System.Windows.Forms.Label
    Friend WithEvents btnFlxReport As System.Windows.Forms.Button
    Friend WithEvents tabRgd As System.Windows.Forms.TabPage
    Friend WithEvents chkAdjLaneBound As System.Windows.Forms.CheckBox
    Friend WithEvents gbSurface As System.Windows.Forms.GroupBox
    Friend WithEvents rbTypeRigid As System.Windows.Forms.RadioButton
    Friend WithEvents rbTypeFlx As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents setSkewAng As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkAddRgdDtrs As System.Windows.Forms.CheckBox
    Friend WithEvents gbRgdSpall As System.Windows.Forms.GroupBox
    Friend WithEvents gbRgdSeal As System.Windows.Forms.GroupBox
    Friend WithEvents gbRgdDtrs As System.Windows.Forms.GroupBox
    Friend WithEvents rbRgdPatch As System.Windows.Forms.RadioButton
    Friend WithEvents rbRgdXJCrk As System.Windows.Forms.RadioButton
    Friend WithEvents rbRgdTransCrk As System.Windows.Forms.RadioButton
    Friend WithEvents rbRgdLongCrk As System.Windows.Forms.RadioButton
    Friend WithEvents rbRgdNSpall As System.Windows.Forms.RadioButton
    Friend WithEvents rbRgdSpall As System.Windows.Forms.RadioButton
    Friend WithEvents rbRgdNSeal As System.Windows.Forms.RadioButton
    Friend WithEvents rbRgdSeal As System.Windows.Forms.RadioButton
    Friend WithEvents gbNewRgdDtrs As System.Windows.Forms.GroupBox
    Friend WithEvents chkEditRgdDtrs As System.Windows.Forms.CheckBox
    Friend WithEvents gbEditRgdDtrs As System.Windows.Forms.GroupBox
    Friend WithEvents gbEditRgdDtrsType As System.Windows.Forms.GroupBox
    Friend WithEvents gbEditRgdSpall As System.Windows.Forms.GroupBox
    Friend WithEvents gbEditRgdSeal As System.Windows.Forms.GroupBox
    Friend WithEvents rbEditRgdPatch As System.Windows.Forms.RadioButton
    Friend WithEvents rbEditRgdXJ As System.Windows.Forms.RadioButton
    Friend WithEvents rbEditRgdTrans As System.Windows.Forms.RadioButton
    Friend WithEvents rbEditRgdLongi As System.Windows.Forms.RadioButton
    Friend WithEvents btnRmvRgdDtrs As System.Windows.Forms.Button
    Friend WithEvents rbEditRgdNSpall As System.Windows.Forms.RadioButton
    Friend WithEvents rbEditRgdSpall As System.Windows.Forms.RadioButton
    Friend WithEvents rbEditRgdNSeal As System.Windows.Forms.RadioButton
    Friend WithEvents rbEditRgdSeal As System.Windows.Forms.RadioButton
    Friend WithEvents chkShowCrack3 As System.Windows.Forms.CheckBox
    Friend WithEvents rbRgdCorner As System.Windows.Forms.RadioButton
    Friend WithEvents rbEditRgdCorner As System.Windows.Forms.RadioButton
    Friend WithEvents rbTranJnt As System.Windows.Forms.GroupBox
    Friend WithEvents gbLongJnt As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbLongJntSeal As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbLongJntNSpall As System.Windows.Forms.RadioButton
    Friend WithEvents rbLongJntSpall As System.Windows.Forms.RadioButton
    Friend WithEvents rbLongJntNSeal As System.Windows.Forms.RadioButton
    Friend WithEvents rbTransJntNSpall As System.Windows.Forms.RadioButton
    Friend WithEvents rbTransJntSpall As System.Windows.Forms.RadioButton
    Friend WithEvents rbTransJntNSeal As System.Windows.Forms.RadioButton
    Friend WithEvents rbTransJntSeal As System.Windows.Forms.RadioButton
    Friend WithEvents btnRgdReport As System.Windows.Forms.Button
    Friend WithEvents tabTransProf As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents setDMITP As System.Windows.Forms.NumericUpDown
    Friend WithEvents setXOffTP As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents setCrctFactorTP As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnPreviousTP As System.Windows.Forms.Button
    Friend WithEvents btnNextTP As System.Windows.Forms.Button
    Friend WithEvents lbCurTP As System.Windows.Forms.Label
    Friend WithEvents chkShowTP As System.Windows.Forms.CheckBox
    Friend WithEvents timerFly As System.Windows.Forms.Timer
    Friend WithEvents btnSaveTPs As System.Windows.Forms.Button
    Friend WithEvents btnOpenTPs As System.Windows.Forms.Button
    Friend WithEvents btnAnchorB As System.Windows.Forms.Button
    Friend WithEvents btnAnchorA As System.Windows.Forms.Button
    Friend WithEvents btnUpdateAnchor As System.Windows.Forms.Button
    Friend WithEvents btnAddRefPt As System.Windows.Forms.Button
    Friend WithEvents pnLongPro As System.Windows.Forms.Panel
    Friend WithEvents chkShowLongPro As System.Windows.Forms.CheckBox
    Friend WithEvents btnOpenLongPro As System.Windows.Forms.Button
    Friend WithEvents setActPro As System.Windows.Forms.NumericUpDown
    Friend WithEvents setProScale As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnReadRut As System.Windows.Forms.Button
    Friend WithEvents btnRutFlt As System.Windows.Forms.Button
    Friend WithEvents chkShowAllTP As System.Windows.Forms.CheckBox
    Friend WithEvents setScaleTP As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnReadGeoNote As System.Windows.Forms.Button
    Friend WithEvents btnReadTRP As System.Windows.Forms.Button
    Friend WithEvents setIntvShowTPR As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkShowTPR As System.Windows.Forms.CheckBox
    Friend WithEvents chkHideImages As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowROW As System.Windows.Forms.CheckBox
    Friend WithEvents btnLoadROW As System.Windows.Forms.Button
    Friend WithEvents ToolTips As System.Windows.Forms.ToolTip
    Friend WithEvents chkImageAdj As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
