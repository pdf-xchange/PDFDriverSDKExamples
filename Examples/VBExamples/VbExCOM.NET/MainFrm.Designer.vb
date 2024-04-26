<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class MainFrm
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public dlgDestSave As System.Windows.Forms.SaveFileDialog
	Public dlgOpenOpen As System.Windows.Forms.OpenFileDialog
	Public WithEvents IE_GO As System.Windows.Forms.Button
	Public WithEvents IE_URL As System.Windows.Forms.TextBox
	Public WithEvents IE_URL_Label As System.Windows.Forms.Label
	Public WithEvents btnBrowseDoc As System.Windows.Forms.Button
	Public WithEvents m_File As System.Windows.Forms.TextBox
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents _frType_0 As System.Windows.Forms.GroupBox
	Public WithEvents doBrowseRes As System.Windows.Forms.Button
	Public WithEvents fName As System.Windows.Forms.TextBox
	Public WithEvents doEmbedd As System.Windows.Forms.CheckBox
	Public WithEvents doCompress As System.Windows.Forms.CheckBox
	Public WithEvents doRun As System.Windows.Forms.CheckBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents OptFrame As System.Windows.Forms.GroupBox
	Public WithEvents btnGo As System.Windows.Forms.Button
	Public WithEvents btnClose As System.Windows.Forms.Button
	Public WithEvents btnAbout As System.Windows.Forms.Button
	Public WithEvents TypeOption As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents frType As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFrm))
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.dlgDestSave = New System.Windows.Forms.SaveFileDialog()
		Me.dlgOpenOpen = New System.Windows.Forms.OpenFileDialog()
		Me.IE_WebBrowser = New AxSHDocVw.AxWebBrowser()
		Me.IE_GO = New System.Windows.Forms.Button()
		Me.IE_URL = New System.Windows.Forms.TextBox()
		Me.IE_URL_Label = New System.Windows.Forms.Label()
		Me.Frame1 = New System.Windows.Forms.GroupBox()
		Me.btnBrowseDoc = New System.Windows.Forms.Button()
		Me.m_File = New System.Windows.Forms.TextBox()
		Me._frType_0 = New System.Windows.Forms.GroupBox()
		Me.OptFrame = New System.Windows.Forms.GroupBox()
		Me.doBrowseRes = New System.Windows.Forms.Button()
		Me.fName = New System.Windows.Forms.TextBox()
		Me.doEmbedd = New System.Windows.Forms.CheckBox()
		Me.doCompress = New System.Windows.Forms.CheckBox()
		Me.doRun = New System.Windows.Forms.CheckBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnGo = New System.Windows.Forms.Button()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.btnAbout = New System.Windows.Forms.Button()
		Me.TypeOption = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
		Me.frType = New Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray(Me.components)
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.TabPage3 = New System.Windows.Forms.TabPage()
		Me.Panel1 = New System.Windows.Forms.Panel()
		CType(Me.IE_WebBrowser, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Frame1.SuspendLayout()
		Me.OptFrame.SuspendLayout()
		CType(Me.TypeOption, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.frType, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TabControl1.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		Me.TabPage2.SuspendLayout()
		Me.TabPage3.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'dlgDestSave
		'
		Me.dlgDestSave.Filter = "PDF Files (*.pdf)|*.pdf"
		Me.dlgDestSave.Title = "Save file"
		'
		'dlgOpenOpen
		'
		Me.dlgOpenOpen.DefaultExt = "doc"
		Me.dlgOpenOpen.Filter = "MS Word Documents (*.doc)|*.doc;*.ppt"
		Me.dlgOpenOpen.Title = "Choose MS Word Document"
		'
		'IE_WebBrowser
		'
		Me.IE_WebBrowser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.IE_WebBrowser.Enabled = True
		Me.IE_WebBrowser.Location = New System.Drawing.Point(11, 38)
		Me.IE_WebBrowser.OcxState = CType(resources.GetObject("IE_WebBrowser.OcxState"), System.Windows.Forms.AxHost.State)
		Me.IE_WebBrowser.Size = New System.Drawing.Size(852, 401)
		Me.IE_WebBrowser.TabIndex = 25
		'
		'IE_GO
		'
		Me.IE_GO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.IE_GO.BackColor = System.Drawing.SystemColors.Control
		Me.IE_GO.Cursor = System.Windows.Forms.Cursors.Default
		Me.IE_GO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.IE_GO.ForeColor = System.Drawing.SystemColors.ControlText
		Me.IE_GO.Location = New System.Drawing.Point(822, 6)
		Me.IE_GO.Name = "IE_GO"
		Me.IE_GO.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.IE_GO.Size = New System.Drawing.Size(49, 26)
		Me.IE_GO.TabIndex = 23
		Me.IE_GO.Text = "Go"
		Me.IE_GO.UseVisualStyleBackColor = False
		'
		'IE_URL
		'
		Me.IE_URL.AcceptsReturn = True
		Me.IE_URL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.IE_URL.BackColor = System.Drawing.SystemColors.Window
		Me.IE_URL.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.IE_URL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.IE_URL.ForeColor = System.Drawing.SystemColors.WindowText
		Me.IE_URL.Location = New System.Drawing.Point(79, 6)
		Me.IE_URL.MaxLength = 0
		Me.IE_URL.Name = "IE_URL"
		Me.IE_URL.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.IE_URL.Size = New System.Drawing.Size(737, 26)
		Me.IE_URL.TabIndex = 22
		Me.IE_URL.Text = "https://www.tracker-software.com/"
		'
		'IE_URL_Label
		'
		Me.IE_URL_Label.Cursor = System.Windows.Forms.Cursors.Default
		Me.IE_URL_Label.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.IE_URL_Label.ForeColor = System.Drawing.SystemColors.ControlText
		Me.IE_URL_Label.Location = New System.Drawing.Point(8, 9)
		Me.IE_URL_Label.Name = "IE_URL_Label"
		Me.IE_URL_Label.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.IE_URL_Label.Size = New System.Drawing.Size(60, 17)
		Me.IE_URL_Label.TabIndex = 21
		Me.IE_URL_Label.Text = "URL:"
		'
		'Frame1
		'
		Me.Frame1.Controls.Add(Me.btnBrowseDoc)
		Me.Frame1.Controls.Add(Me.m_File)
		Me.Frame1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.Location = New System.Drawing.Point(3, 3)
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Size = New System.Drawing.Size(871, 437)
		Me.Frame1.TabIndex = 16
		Me.Frame1.TabStop = False
		Me.Frame1.Text = "File to Print:"
		'
		'btnBrowseDoc
		'
		Me.btnBrowseDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnBrowseDoc.BackColor = System.Drawing.SystemColors.Control
		Me.btnBrowseDoc.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnBrowseDoc.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBrowseDoc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnBrowseDoc.Location = New System.Drawing.Point(768, 24)
		Me.btnBrowseDoc.Name = "btnBrowseDoc"
		Me.btnBrowseDoc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnBrowseDoc.Size = New System.Drawing.Size(89, 25)
		Me.btnBrowseDoc.TabIndex = 18
		Me.btnBrowseDoc.Text = "Browse..."
		Me.btnBrowseDoc.UseVisualStyleBackColor = False
		'
		'm_File
		'
		Me.m_File.AcceptsReturn = True
		Me.m_File.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.m_File.BackColor = System.Drawing.SystemColors.Window
		Me.m_File.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.m_File.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.m_File.ForeColor = System.Drawing.SystemColors.WindowText
		Me.m_File.Location = New System.Drawing.Point(8, 24)
		Me.m_File.MaxLength = 0
		Me.m_File.Name = "m_File"
		Me.m_File.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.m_File.Size = New System.Drawing.Size(754, 26)
		Me.m_File.TabIndex = 17
		'
		'_frType_0
		'
		Me._frType_0.Dock = System.Windows.Forms.DockStyle.Fill
		Me._frType_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._frType_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frType.SetIndex(Me._frType_0, CType(0, Short))
		Me._frType_0.Location = New System.Drawing.Point(3, 3)
		Me._frType_0.Name = "_frType_0"
		Me._frType_0.Padding = New System.Windows.Forms.Padding(0)
		Me._frType_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._frType_0.Size = New System.Drawing.Size(871, 437)
		Me._frType_0.TabIndex = 13
		Me._frType_0.TabStop = False
		Me._frType_0.Text = "Native"
		'
		'OptFrame
		'
		Me.OptFrame.BackColor = System.Drawing.SystemColors.Control
		Me.OptFrame.Controls.Add(Me.doBrowseRes)
		Me.OptFrame.Controls.Add(Me.fName)
		Me.OptFrame.Controls.Add(Me.doEmbedd)
		Me.OptFrame.Controls.Add(Me.doCompress)
		Me.OptFrame.Controls.Add(Me.doRun)
		Me.OptFrame.Controls.Add(Me.Label1)
		Me.OptFrame.Dock = System.Windows.Forms.DockStyle.Top
		Me.OptFrame.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.OptFrame.ForeColor = System.Drawing.SystemColors.ControlText
		Me.OptFrame.Location = New System.Drawing.Point(8, 8)
		Me.OptFrame.Name = "OptFrame"
		Me.OptFrame.Padding = New System.Windows.Forms.Padding(0)
		Me.OptFrame.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.OptFrame.Size = New System.Drawing.Size(869, 106)
		Me.OptFrame.TabIndex = 7
		Me.OptFrame.TabStop = False
		Me.OptFrame.Text = "Options:"
		'
		'doBrowseRes
		'
		Me.doBrowseRes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.doBrowseRes.BackColor = System.Drawing.SystemColors.Control
		Me.doBrowseRes.Cursor = System.Windows.Forms.Cursors.Default
		Me.doBrowseRes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.doBrowseRes.ForeColor = System.Drawing.SystemColors.ControlText
		Me.doBrowseRes.Location = New System.Drawing.Point(776, 52)
		Me.doBrowseRes.Name = "doBrowseRes"
		Me.doBrowseRes.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.doBrowseRes.Size = New System.Drawing.Size(80, 25)
		Me.doBrowseRes.TabIndex = 19
		Me.doBrowseRes.Text = "&Browse..."
		Me.doBrowseRes.UseVisualStyleBackColor = False
		'
		'fName
		'
		Me.fName.AcceptsReturn = True
		Me.fName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.fName.BackColor = System.Drawing.SystemColors.Window
		Me.fName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.fName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.fName.Location = New System.Drawing.Point(132, 52)
		Me.fName.MaxLength = 0
		Me.fName.Name = "fName"
		Me.fName.ReadOnly = True
		Me.fName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fName.Size = New System.Drawing.Size(636, 26)
		Me.fName.TabIndex = 12
		Me.fName.Text = "c:\sample.pdf"
		'
		'doEmbedd
		'
		Me.doEmbedd.BackColor = System.Drawing.SystemColors.Control
		Me.doEmbedd.Cursor = System.Windows.Forms.Cursors.Default
		Me.doEmbedd.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.doEmbedd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.doEmbedd.Location = New System.Drawing.Point(519, 22)
		Me.doEmbedd.Name = "doEmbedd"
		Me.doEmbedd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.doEmbedd.Size = New System.Drawing.Size(200, 24)
		Me.doEmbedd.TabIndex = 10
		Me.doEmbedd.Text = "&Embedd Fonts"
		Me.doEmbedd.UseVisualStyleBackColor = False
		'
		'doCompress
		'
		Me.doCompress.BackColor = System.Drawing.SystemColors.Control
		Me.doCompress.Checked = True
		Me.doCompress.CheckState = System.Windows.Forms.CheckState.Checked
		Me.doCompress.Cursor = System.Windows.Forms.Cursors.Default
		Me.doCompress.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.doCompress.ForeColor = System.Drawing.SystemColors.ControlText
		Me.doCompress.Location = New System.Drawing.Point(313, 22)
		Me.doCompress.Name = "doCompress"
		Me.doCompress.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.doCompress.Size = New System.Drawing.Size(200, 24)
		Me.doCompress.TabIndex = 9
		Me.doCompress.Text = "Use &Compression"
		Me.doCompress.UseVisualStyleBackColor = False
		'
		'doRun
		'
		Me.doRun.BackColor = System.Drawing.SystemColors.Control
		Me.doRun.Checked = True
		Me.doRun.CheckState = System.Windows.Forms.CheckState.Checked
		Me.doRun.Cursor = System.Windows.Forms.Cursors.Default
		Me.doRun.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.doRun.ForeColor = System.Drawing.SystemColors.ControlText
		Me.doRun.Location = New System.Drawing.Point(7, 22)
		Me.doRun.Name = "doRun"
		Me.doRun.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.doRun.Size = New System.Drawing.Size(300, 24)
		Me.doRun.TabIndex = 8
		Me.doRun.Text = "&Run Default Application for PDF Files After Printing"
		Me.doRun.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Location = New System.Drawing.Point(13, 55)
		Me.Label1.Name = "Label1"
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.Size = New System.Drawing.Size(113, 23)
		Me.Label1.TabIndex = 11
		Me.Label1.Text = "Result &File:"
		'
		'btnGo
		'
		Me.btnGo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnGo.BackColor = System.Drawing.SystemColors.Control
		Me.btnGo.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnGo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnGo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnGo.Location = New System.Drawing.Point(784, 120)
		Me.btnGo.Name = "btnGo"
		Me.btnGo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnGo.Size = New System.Drawing.Size(80, 25)
		Me.btnGo.TabIndex = 2
		Me.btnGo.Text = "&Go"
		Me.btnGo.UseVisualStyleBackColor = False
		'
		'btnClose
		'
		Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnClose.BackColor = System.Drawing.SystemColors.Control
		Me.btnClose.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnClose.Location = New System.Drawing.Point(696, 120)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnClose.Size = New System.Drawing.Size(80, 25)
		Me.btnClose.TabIndex = 1
		Me.btnClose.Text = "&Close"
		Me.btnClose.UseVisualStyleBackColor = False
		'
		'btnAbout
		'
		Me.btnAbout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnAbout.BackColor = System.Drawing.SystemColors.Control
		Me.btnAbout.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnAbout.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnAbout.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnAbout.Location = New System.Drawing.Point(24, 120)
		Me.btnAbout.Name = "btnAbout"
		Me.btnAbout.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnAbout.Size = New System.Drawing.Size(80, 25)
		Me.btnAbout.TabIndex = 0
		Me.btnAbout.Text = "&About..."
		Me.btnAbout.UseVisualStyleBackColor = False
		'
		'TabControl1
		'
		Me.TabControl1.Controls.Add(Me.TabPage1)
		Me.TabControl1.Controls.Add(Me.TabPage2)
		Me.TabControl1.Controls.Add(Me.TabPage3)
		Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TabControl1.Location = New System.Drawing.Point(2, 2)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(885, 474)
		Me.TabControl1.TabIndex = 17
		'
		'TabPage1
		'
		Me.TabPage1.Controls.Add(Me._frType_0)
		Me.TabPage1.Location = New System.Drawing.Point(4, 27)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage1.Size = New System.Drawing.Size(877, 443)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "Native Printing"
		Me.TabPage1.UseVisualStyleBackColor = True
		'
		'TabPage2
		'
		Me.TabPage2.Controls.Add(Me.Frame1)
		Me.TabPage2.Location = New System.Drawing.Point(4, 27)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage2.Size = New System.Drawing.Size(877, 443)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "Print .doc File"
		Me.TabPage2.UseVisualStyleBackColor = True
		'
		'TabPage3
		'
		Me.TabPage3.Controls.Add(Me.IE_WebBrowser)
		Me.TabPage3.Controls.Add(Me.IE_GO)
		Me.TabPage3.Controls.Add(Me.IE_URL)
		Me.TabPage3.Controls.Add(Me.IE_URL_Label)
		Me.TabPage3.Location = New System.Drawing.Point(4, 27)
		Me.TabPage3.Name = "TabPage3"
		Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage3.Size = New System.Drawing.Size(877, 443)
		Me.TabPage3.TabIndex = 2
		Me.TabPage3.Text = "&IE Explorer"
		Me.TabPage3.UseVisualStyleBackColor = True
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.OptFrame)
		Me.Panel1.Controls.Add(Me.btnAbout)
		Me.Panel1.Controls.Add(Me.btnClose)
		Me.Panel1.Controls.Add(Me.btnGo)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.Panel1.Location = New System.Drawing.Point(2, 476)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Padding = New System.Windows.Forms.Padding(8)
		Me.Panel1.Size = New System.Drawing.Size(885, 160)
		Me.Panel1.TabIndex = 18
		'
		'MainFrm
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(889, 638)
		Me.Controls.Add(Me.TabControl1)
		Me.Controls.Add(Me.Panel1)
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Location = New System.Drawing.Point(3, 22)
		Me.Name = "MainFrm"
		Me.Padding = New System.Windows.Forms.Padding(2)
		Me.Text = "PDF-XChange V7 Printer API (COM) Test"
		CType(Me.IE_WebBrowser, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.Frame1.PerformLayout()
		Me.OptFrame.ResumeLayout(False)
		Me.OptFrame.PerformLayout()
		CType(Me.TypeOption, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.frType, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TabControl1.ResumeLayout(False)
		Me.TabPage1.ResumeLayout(False)
		Me.TabPage2.ResumeLayout(False)
		Me.TabPage3.ResumeLayout(False)
		Me.TabPage3.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents IE_WebBrowser As AxSHDocVw.AxWebBrowser
	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents TabPage3 As TabPage
	Friend WithEvents Panel1 As Panel

#End Region
End Class