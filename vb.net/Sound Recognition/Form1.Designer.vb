<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.pleft = New System.Windows.Forms.PictureBox
        Me.pdown = New System.Windows.Forms.PictureBox
        Me.pstop = New System.Windows.Forms.PictureBox
        Me.pright = New System.Windows.Forms.PictureBox
        Me.pup = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtbox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lstbox = New System.Windows.Forms.ListBox
        Me.btnstop = New System.Windows.Forms.Button
        Me.btnstart = New System.Windows.Forms.Button
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboParity = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.cboPort = New System.Windows.Forms.ComboBox
        Me.cboStop = New System.Windows.Forms.ComboBox
        Me.cboData = New System.Windows.Forms.ComboBox
        Me.cboBaud = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.SkinEngine1 = New Sunisoft.IrisSkin.SkinEngine(CType(Me, System.ComponentModel.Component))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.statuslbl = New System.Windows.Forms.ToolStripStatusLabel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.pleft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pstop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pright, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(255, 348)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = Global.Sound_Recognition.My.Resources.Resources.imagesCA0Z1B52
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.LinkLabel1)
        Me.TabPage1.Controls.Add(Me.pleft)
        Me.TabPage1.Controls.Add(Me.pdown)
        Me.TabPage1.Controls.Add(Me.pstop)
        Me.TabPage1.Controls.Add(Me.pright)
        Me.TabPage1.Controls.Add(Me.pup)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.txtbox)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.lstbox)
        Me.TabPage1.Controls.Add(Me.btnstop)
        Me.TabPage1.Controls.Add(Me.btnstart)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(247, 321)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Control"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(2, 304)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(181, 14)
        Me.LinkLabel1.TabIndex = 77
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "&Open All operations window"
        '
        'pleft
        '
        Me.pleft.BackgroundImage = Global.Sound_Recognition.My.Resources.Resources.left_
        Me.pleft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pleft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pleft.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pleft.ErrorImage = Global.Sound_Recognition.My.Resources.Resources.left_
        Me.pleft.InitialImage = Global.Sound_Recognition.My.Resources.Resources.left_
        Me.pleft.Location = New System.Drawing.Point(45, 63)
        Me.pleft.Name = "pleft"
        Me.pleft.Size = New System.Drawing.Size(51, 42)
        Me.pleft.TabIndex = 76
        Me.pleft.TabStop = False
        '
        'pdown
        '
        Me.pdown.BackgroundImage = Global.Sound_Recognition.My.Resources.Resources.down_
        Me.pdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pdown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pdown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pdown.ErrorImage = Global.Sound_Recognition.My.Resources.Resources.down_
        Me.pdown.InitialImage = Global.Sound_Recognition.My.Resources.Resources.down_
        Me.pdown.Location = New System.Drawing.Point(102, 106)
        Me.pdown.Name = "pdown"
        Me.pdown.Size = New System.Drawing.Size(39, 45)
        Me.pdown.TabIndex = 75
        Me.pdown.TabStop = False
        '
        'pstop
        '
        Me.pstop.BackgroundImage = Global.Sound_Recognition.My.Resources.Resources._stop
        Me.pstop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pstop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pstop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pstop.ErrorImage = Global.Sound_Recognition.My.Resources.Resources._stop
        Me.pstop.InitialImage = Global.Sound_Recognition.My.Resources.Resources._stop
        Me.pstop.Location = New System.Drawing.Point(102, 68)
        Me.pstop.Name = "pstop"
        Me.pstop.Size = New System.Drawing.Size(38, 32)
        Me.pstop.TabIndex = 74
        Me.pstop.TabStop = False
        '
        'pright
        '
        Me.pright.BackgroundImage = Global.Sound_Recognition.My.Resources.Resources.right_
        Me.pright.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pright.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pright.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pright.ErrorImage = Global.Sound_Recognition.My.Resources.Resources.right_
        Me.pright.InitialImage = Global.Sound_Recognition.My.Resources.Resources.right_
        Me.pright.Location = New System.Drawing.Point(146, 63)
        Me.pright.Name = "pright"
        Me.pright.Size = New System.Drawing.Size(51, 42)
        Me.pright.TabIndex = 73
        Me.pright.TabStop = False
        '
        'pup
        '
        Me.pup.BackgroundImage = Global.Sound_Recognition.My.Resources.Resources.up_
        Me.pup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pup.ErrorImage = Global.Sound_Recognition.My.Resources.Resources.up_
        Me.pup.InitialImage = Global.Sound_Recognition.My.Resources.Resources.up_
        Me.pup.Location = New System.Drawing.Point(102, 17)
        Me.pup.Name = "pup"
        Me.pup.Size = New System.Drawing.Size(38, 45)
        Me.pup.TabIndex = 72
        Me.pup.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.PictureBox2.BackgroundImage = Global.Sound_Recognition.My.Resources.Resources.Cardinal_directions
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.InitialImage = Global.Sound_Recognition.My.Resources.Resources.Cardinal_directions
        Me.PictureBox2.Location = New System.Drawing.Point(198, 276)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(38, 22)
        Me.PictureBox2.TabIndex = 71
        Me.PictureBox2.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(12, 259)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(137, 16)
        Me.Label18.TabIndex = 70
        Me.Label18.Text = "Currently Operation"
        '
        'txtbox
        '
        Me.txtbox.Enabled = False
        Me.txtbox.Location = New System.Drawing.Point(8, 276)
        Me.txtbox.Name = "txtbox"
        Me.txtbox.Size = New System.Drawing.Size(184, 22)
        Me.txtbox.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(12, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 16)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Available Operations"
        '
        'lstbox
        '
        Me.lstbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstbox.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstbox.FormattingEnabled = True
        Me.lstbox.ItemHeight = 14
        Me.lstbox.Items.AddRange(New Object() {"one", "four", "five", "seven", "eight"})
        Me.lstbox.Location = New System.Drawing.Point(8, 166)
        Me.lstbox.Name = "lstbox"
        Me.lstbox.Size = New System.Drawing.Size(228, 74)
        Me.lstbox.TabIndex = 53
        '
        'btnstop
        '
        Me.btnstop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnstop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnstop.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnstop.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstop.Location = New System.Drawing.Point(169, 17)
        Me.btnstop.Name = "btnstop"
        Me.btnstop.Size = New System.Drawing.Size(65, 42)
        Me.btnstop.TabIndex = 52
        Me.btnstop.Text = "Sto&p"
        Me.btnstop.UseVisualStyleBackColor = True
        '
        'btnstart
        '
        Me.btnstart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnstart.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstart.Location = New System.Drawing.Point(14, 17)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(65, 42)
        Me.btnstart.TabIndex = 51
        Me.btnstart.Text = "Sta&rt"
        Me.btnstart.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Silver
        Me.TabPage2.BackgroundImage = Global.Sound_Recognition.My.Resources.Resources.serial_plug
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(247, 321)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Config. Port"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 203)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(239, 127)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "About Designer and  Rights"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(76, 104)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(76, 14)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "2009-2010"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(66, 89)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 14)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "20108522621"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 71)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(162, 14)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "awad_ali_90@yahoo.com"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(46, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 14)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Al-Azhar University"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(228, 14)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Computer and Systems Department"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(46, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 14)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "eng.\ AwAd BeKhEt"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboParity)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.cboPort)
        Me.GroupBox1.Controls.Add(Me.cboStop)
        Me.GroupBox1.Controls.Add(Me.cboData)
        Me.GroupBox1.Controls.Add(Me.cboBaud)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(236, 137)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selecting Port"
        '
        'cboParity
        '
        Me.cboParity.FormattingEnabled = True
        Me.cboParity.Location = New System.Drawing.Point(126, 70)
        Me.cboParity.Name = "cboParity"
        Me.cboParity.Size = New System.Drawing.Size(94, 22)
        Me.cboParity.TabIndex = 22
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(91, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(34, 14)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Port"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(123, 95)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 14)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Stop Bits"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 95)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 14)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Data Bits"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(123, 54)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 14)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Parity"
        '
        'cboPort
        '
        Me.cboPort.FormattingEnabled = True
        Me.cboPort.Location = New System.Drawing.Point(8, 31)
        Me.cboPort.Name = "cboPort"
        Me.cboPort.Size = New System.Drawing.Size(212, 22)
        Me.cboPort.TabIndex = 20
        '
        'cboStop
        '
        Me.cboStop.FormattingEnabled = True
        Me.cboStop.Location = New System.Drawing.Point(126, 111)
        Me.cboStop.Name = "cboStop"
        Me.cboStop.Size = New System.Drawing.Size(94, 22)
        Me.cboStop.TabIndex = 23
        '
        'cboData
        '
        Me.cboData.FormattingEnabled = True
        Me.cboData.Items.AddRange(New Object() {"5", "6", "7", "8"})
        Me.cboData.Location = New System.Drawing.Point(8, 111)
        Me.cboData.Name = "cboData"
        Me.cboData.Size = New System.Drawing.Size(98, 22)
        Me.cboData.TabIndex = 24
        '
        'cboBaud
        '
        Me.cboBaud.FormattingEnabled = True
        Me.cboBaud.Items.AddRange(New Object() {"300", "600", "1200", "2400", "4800", "9600", "14400", "28800", "36000", "115000"})
        Me.cboBaud.Location = New System.Drawing.Point(8, 70)
        Me.cboBaud.Name = "cboBaud"
        Me.cboBaud.Size = New System.Drawing.Size(98, 22)
        Me.cboBaud.TabIndex = 21
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 54)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 14)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Baud Rate"
        '
        'TabPage3
        '
        Me.TabPage3.BackgroundImage = CType(resources.GetObject("TabPage3.BackgroundImage"), System.Drawing.Image)
        Me.TabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage3.Controls.Add(Me.Label21)
        Me.TabPage3.Controls.Add(Me.Label20)
        Me.TabPage3.Controls.Add(Me.ListBox1)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(247, 321)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "All operations"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Blue
        Me.Label21.Location = New System.Drawing.Point(156, 294)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(22, 23)
        Me.Label21.TabIndex = 65
        Me.Label21.Text = "0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Blue
        Me.Label20.Location = New System.Drawing.Point(23, 294)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(110, 23)
        Me.Label20.TabIndex = 64
        Me.Label20.Text = "# of All = "
        '
        'ListBox1
        '
        Me.ListBox1.Enabled = False
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Location = New System.Drawing.Point(6, 41)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(230, 242)
        Me.ListBox1.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(3, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 18)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "What has been done"
        '
        'SerialPort1
        '
        '
        'SkinEngine1
        '
        Me.SkinEngine1.SerialNumber = "dKNSNCMQ1zofXM77S9evt7xPHy2sibGZzkZyOuG1QZNkNiaOPkjNdg=="
        Me.SkinEngine1.SkinFile = "D:\faculty of engneering\Programing\Visual Basic & V B.net\ثيمات للمشاريع\themes\" & _
            "One\OneBlue.ssk"
        Me.SkinEngine1.SkinStreamMain = CType(resources.GetObject("SkinEngine1.SkinStreamMain"), System.IO.Stream)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statuslbl})
        Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 349)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(254, 21)
        Me.StatusStrip1.TabIndex = 64
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statuslbl
        '
        Me.statuslbl.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statuslbl.ForeColor = System.Drawing.Color.Black
        Me.statuslbl.Name = "statuslbl"
        Me.statuslbl.Size = New System.Drawing.Size(48, 16)
        Me.statuslbl.Text = "Status: "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(201, 351)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 19)
        Me.PictureBox1.TabIndex = 65
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "remotecontrol3.png")
        '
        'Main
        '
        Me.AcceptButton = Me.btnstart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(254, 370)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controlled car by Voice"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.pleft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pstop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pright, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstbox As System.Windows.Forms.ListBox
    Friend WithEvents btnstop As System.Windows.Forms.Button
    Friend WithEvents btnstart As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents Label13 As System.Windows.Forms.Label
    Private WithEvents cboParity As System.Windows.Forms.ComboBox
    Private WithEvents Label17 As System.Windows.Forms.Label
    Private WithEvents cboData As System.Windows.Forms.ComboBox
    Private WithEvents Label16 As System.Windows.Forms.Label
    Private WithEvents cboBaud As System.Windows.Forms.ComboBox
    Private WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents Label15 As System.Windows.Forms.Label
    Private WithEvents cboStop As System.Windows.Forms.ComboBox
    Private WithEvents cboPort As System.Windows.Forms.ComboBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents statuslbl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents pleft As System.Windows.Forms.PictureBox
    Friend WithEvents pdown As System.Windows.Forms.PictureBox
    Friend WithEvents pstop As System.Windows.Forms.PictureBox
    Friend WithEvents pright As System.Windows.Forms.PictureBox
    Friend WithEvents pup As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
