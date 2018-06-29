Option Strict Off
Option Explicit On

Imports System.Drawing.Printing
'Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6

Imports PXCComLib7

Friend Class MainFrm
	Inherits System.Windows.Forms.Form

	Const SW_MINIMIZE As Short = 11

	Dim PDFPFactory As New CPXCControlEx
	Dim WithEvents PDFPrinter As CPXCPrinter
	' Attribute m_PDFPrinter.VB_VarHelpID = -1

	Public vFrame As Short

	Dim pname As String

	Private IsInitializing As Boolean

	Private Declare Function ShellExecute Lib "Shell32" Alias "ShellExecuteA" (ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer

	Private Declare Function ExtEscape Lib "Gdi32" (ByVal hDC As Integer, ByVal nEscape As Integer, ByVal cbInput As Integer, ByVal lpInData As String, ByVal cbOutput As Integer, ByVal lpOutData As Integer) As Integer



	Private Sub MainFrm_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		PDFPrinter.RestoreDefaultPrinter()
		PDFPrinter = Nothing
	End Sub

	Private Sub InitSaverObj()
		PDFPrinter = PDFPFactory.Printer("", "PDF-XChange V7 Sample", "<YOUR REG CODE>", "")
		pname = PDFPrinter.Name
		PDFPrinter.SetAsDefaultPrinter()
	End Sub

	Public Sub MainFrm_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.IsInitializing = True
		InitSaverObj()
		Me.IsInitializing = False

		fName.Text = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\sample.pdf"
	End Sub

	Private Sub btnAbout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnAbout.Click
		VB6.ShowForm(frmAbout)
	End Sub

	Private Sub btnBrowseDoc_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnBrowseDoc.Click
		dlgOpenOpen.FileName = m_File.Text
		dlgOpenOpen.ShowDialog()
		m_File.Text = dlgOpenOpen.FileName
	End Sub

	Private Sub btnClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnClose.Click
		Me.Close()
	End Sub

	Private Sub printDoc_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
		Dim textToPrint As String = "Just a simple Text"
		Dim printFont As New Font("Courier New", 12, FontStyle.Bold)

		Dim leftMargin As Single = ev.MarginBounds.Left
		Dim topMargin As Single = ev.MarginBounds.Top
		ev.Graphics.DrawString(textToPrint, printFont, Brushes.Black, leftMargin, topMargin)
		Dim dPen = New Pen(Color.Blue, 1)
		ev.Graphics.DrawEllipse(dPen, ev.MarginBounds.Left - 20, ev.MarginBounds.Top - 20, 240, 70)
	End Sub

	Private Sub btnGo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnGo.Click
		'Dim Printer As New Printer
		'Dim D As Integer
		'Dim P As Printer
		Dim bVal As Boolean

		PDFPrinter.ResetDefaults()
		PDFPrinter.Option("Save.File") = fName.Text
		PDFPrinter.Option("Save.SaveType") = "Save"
		PDFPrinter.Option("Save.ShowSaveDialog") = "No"
		PDFPrinter.Option("Save.WhenExists") = "Overwrite"
		bVal = doCompress.CheckState
		If (bVal = True) Then
			With PDFPrinter
				.Option("Compression.Graphics") = "Yes"
				.Option("Compression.Text") = "Yes"
				.Option("Compression.ASCII") = "No"
				.Option("Compression.Color.Enabled") = "Yes"
				.Option("Compression.Color.Method") = "Auto"
				.Option("Compression.Indexed.Enabled") = "Yes"
				.Option("Compression.Indexed.Method") = "Auto"
				.Option("Compression.Mono.Enabled") = "Yes"
				.Option("Compression.Mono.Method") = "Auto"
			End With
		Else
			PDFPrinter.Option("Compression.Graphics") = "No"
			PDFPrinter.Option("Compression.Text") = "No"
		End If
		bVal = doEmbedd.CheckState
		PDFPrinter.Option("Fonts.EmbedAll") = IIf(bVal = True, 1, 0)
		bVal = doRun.CheckState
		PDFPrinter.Option("Save.RunApp") = bVal
		If bVal = True Then
			PDFPrinter.Option("Save.RunCustom") = "No"
		End If

		' To Hide progress window uncomment the next line
		PDFPrinter.Option("Saver.ShowProgress") = "No"





		If (TabControl1.SelectedTab.Name = "TabPage3") Then
			IE_WebBrowser.ExecWB(SHDocVw.OLECMDID.OLECMDID_PRINT, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER)
		ElseIf (TabControl1.SelectedTab.Name = "TabPage2") Then
			ShellExecute(0, "printto", m_File.Text, """" & pname & """", CStr(VariantType.Null), SW_MINIMIZE)
		ElseIf (TabControl1.SelectedTab.Name = "TabPage1") Then
			PDFPrinter.SetAsDefaultPrinter()

			Dim printDoc As New PrintDocument
			AddHandler printDoc.PrintPage, AddressOf Me.printDoc_PrintPage
			printDoc.Print()


			PDFPrinter.RestoreDefaultPrinter()
			'	For Each P In Printers
			'		If P.DeviceName = pname Then
			'                  ' Set printer as default for current session
			'                  Printer = P
			'                  ' Stop looking for a printer
			'                  Exit For
			'		End If
			'	Next P
			'          '
			'          'initialize printer
			'          D = Printer.TwipsPerPixelX
			'	Printer.Orientation = PrinterObjectConstants.vbPRORPortrait
			'          'initialized
			'          Printer.FontName = "Arial"
			'	Printer.FontSize = 12
			'	Printer.CurrentX = 1000
			'	Printer.CurrentY = 3000
			'	Printer.Print("Sample printing from VB using PDF-XChange V6")
			'	Printer.Circle(3745, 3000, 2900)
			'	Printer.NewPage()
			'	Printer.EndDoc()
		End If
	End Sub

	Private Sub doBrowseRes_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles doBrowseRes.Click
		dlgDestSave.FileName = fName.Text
		dlgDestSave.ShowDialog()
		fName.Text = dlgDestSave.FileName
	End Sub

	Private Sub IE_GO_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles IE_GO.Click
		Dim URL As String
		URL = IE_URL.Text
		IE_WebBrowser.Navigate(URL)
	End Sub

	Private Sub PDFPrinter_OnEndDoc(ByVal JobID As Integer, ByVal bOK As Integer) Handles PDFPrinter.OnEndDoc
		'
	End Sub

	Private Sub PDFPrinter_OnEndPage(ByVal JobID As Integer, ByVal nPageNumber As Integer) Handles PDFPrinter.OnEndPage
		'
	End Sub

	Private Sub PDFPrinter_OnError(ByVal JobID As Integer, ByVal dwErrorCode As Integer) Handles PDFPrinter.OnError
		'
	End Sub

	Private Sub PDFPrinter_OnFileSaved(ByVal JobID As Integer, ByVal lpszFileName As String) Handles PDFPrinter.OnFileSaved
		MsgBox("PDF file was saved as '" & lpszFileName & "'")
	End Sub

	Private Sub PDFPrinter_OnFileSent(ByVal JobID As Integer, ByVal lpszFileName As String) Handles PDFPrinter.OnFileSent
		'
	End Sub

	Private Sub PDFPrinter_OnStartDoc(ByVal JobID As Integer, ByVal lpszDocName As String, ByVal lpszAppName As String) Handles PDFPrinter.OnStartDoc
		MsgBox("Document '" & lpszDocName & "' started.")
	End Sub

	Private Sub PDFPrinter_OnStartPage(ByVal JobID As Integer, ByVal nPageNumber As Integer) Handles PDFPrinter.OnStartPage
		'
	End Sub

	Private Sub _frType_1_Enter(sender As Object, e As EventArgs)

	End Sub
End Class