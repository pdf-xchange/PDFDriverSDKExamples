VERSION 5.00
Object = "{EAB22AC0-30C1-11CF-A7EB-0000C05BAE0B}#1.1#0"; "shdocvw.dll"
Begin VB.Form MainFrm 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "PDF-XChange Printer V7 API"
   ClientHeight    =   5145
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   7455
   Icon            =   "MainFrm.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5145
   ScaleWidth      =   7455
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame frType 
      Caption         =   "IE Explorer"
      Height          =   3015
      Index           =   2
      Left            =   2040
      TabIndex        =   15
      Top             =   120
      Visible         =   0   'False
      Width           =   5295
      Begin VB.CommandButton IE_GO 
         Caption         =   "Go"
         Height          =   350
         Left            =   4680
         TabIndex        =   23
         Top             =   240
         Width           =   495
      End
      Begin VB.TextBox IE_URL 
         Height          =   350
         Left            =   720
         TabIndex        =   22
         Top             =   240
         Width           =   3855
      End
      Begin SHDocVwCtl.WebBrowser IE_WebBrowser 
         Height          =   2175
         Left            =   120
         TabIndex        =   20
         Top             =   720
         Width           =   5055
         ExtentX         =   8916
         ExtentY         =   3836
         ViewMode        =   0
         Offline         =   0
         Silent          =   0
         RegisterAsBrowser=   0
         RegisterAsDropTarget=   1
         AutoArrange     =   0   'False
         NoClientEdge    =   0   'False
         AlignLeft       =   0   'False
         NoWebView       =   0   'False
         HideFileNames   =   0   'False
         SingleClick     =   0   'False
         SingleSelection =   0   'False
         NoFolders       =   0   'False
         Transparent     =   0   'False
         ViewID          =   "{0057D0E0-3573-11CF-AE69-08002B2E1262}"
         Location        =   "https://www.tracker-software.com/"
      End
      Begin VB.Label IE_URL_Label 
         Caption         =   "URL:"
         Height          =   255
         Left            =   120
         TabIndex        =   21
         Top             =   288
         Width           =   495
      End
   End
   Begin VB.Frame frType 
      Caption         =   "Print .doc File"
      Height          =   3015
      Index           =   1
      Left            =   2040
      TabIndex        =   14
      Top             =   120
      Visible         =   0   'False
      Width           =   5295
      Begin VB.Frame Frame1 
         Caption         =   "File to Print:"
         Height          =   1335
         Left            =   120
         TabIndex        =   16
         Top             =   360
         Width           =   4935
         Begin VB.CommandButton btnBrowseDoc 
            Caption         =   "Browse..."
            Height          =   375
            Left            =   3480
            TabIndex        =   18
            Top             =   840
            Width           =   1335
         End
         Begin VB.TextBox m_File 
            Height          =   350
            Left            =   120
            TabIndex        =   17
            Top             =   360
            Width           =   4695
         End
      End
   End
   Begin VB.Frame frType 
      Caption         =   "Native"
      Height          =   3015
      Index           =   0
      Left            =   2040
      TabIndex        =   13
      Top             =   120
      Width           =   5295
   End
   Begin VB.Frame OptFrame 
      Caption         =   "Options:"
      Height          =   1335
      Left            =   120
      TabIndex        =   7
      Top             =   3240
      Width           =   7215
      Begin VB.CommandButton doBrowseRes 
         Caption         =   "&Browse..."
         Height          =   375
         Left            =   6000
         TabIndex        =   19
         Top             =   828
         Width           =   1095
      End
      Begin VB.TextBox fName 
         Height          =   350
         Left            =   1080
         Locked          =   -1  'True
         TabIndex        =   12
         Text            =   "d:\sample.pdf"
         Top             =   840
         Width           =   4815
      End
      Begin VB.CheckBox doEmbedd 
         Caption         =   "&Embedd Fonts"
         Height          =   255
         Left            =   5760
         TabIndex        =   10
         Top             =   360
         Width           =   1335
      End
      Begin VB.CheckBox doCompress 
         Caption         =   "Use &Compression"
         Height          =   255
         Left            =   4080
         TabIndex        =   9
         Top             =   360
         Value           =   1  'Checked
         Width           =   1575
      End
      Begin VB.CheckBox doRun 
         Caption         =   "&Run Default Application for PDF Files After Printing"
         Height          =   255
         Left            =   120
         TabIndex        =   8
         Top             =   360
         Value           =   1  'Checked
         Width           =   3975
      End
      Begin VB.Label Label1 
         Caption         =   "Result &File:"
         Height          =   255
         Left            =   120
         TabIndex        =   11
         Top             =   840
         Width           =   855
      End
   End
   Begin VB.Frame TypeFrame 
      Caption         =   "Type:"
      Height          =   1455
      Left            =   120
      TabIndex        =   3
      Top             =   120
      Width           =   1815
      Begin VB.OptionButton TypeOption 
         Caption         =   "&IE Explorer"
         Height          =   255
         Index           =   2
         Left            =   120
         TabIndex        =   3
         Top             =   1080
         Width           =   1575
      End
      Begin VB.OptionButton TypeOption 
         Caption         =   "&Print .doc File"
         Height          =   255
         Index           =   1
         Left            =   120
         TabIndex        =   2
         Top             =   720
         Width           =   1575
      End
      Begin VB.OptionButton TypeOption 
         Caption         =   "&Native Printing"
         Height          =   255
         Index           =   0
         Left            =   120
         TabIndex        =   1
         Top             =   360
         Width           =   1575
      End
   End
   Begin VB.CommandButton btnGo 
      Caption         =   "&Go"
      Height          =   375
      Left            =   6000
      TabIndex        =   2
      Top             =   4680
      Width           =   1215
   End
   Begin VB.CommandButton btnClose 
      Caption         =   "&Close"
      Height          =   375
      Left            =   4680
      TabIndex        =   1
      Top             =   4680
      Width           =   1215
   End
   Begin VB.CommandButton btnAbout 
      Caption         =   "&About..."
      Height          =   375
      Left            =   120
      TabIndex        =   0
      Top             =   4680
      Width           =   1215
   End
End
Attribute VB_Name = "MainFrm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Const SW_MINIMIZE = 11

Dim PDFPFactory As New PXCComLib7.CPXCControlEx
Dim WithEvents PDFPrinter As PXCComLib7.CPXCPrinter
Attribute PDFPrinter.VB_VarHelpID = -1
' Attribute m_PDFPrinter.VB_VarHelpID = -1

Public vFrame As Integer

Dim pname As String

Private Declare Function ShellExecute Lib "Shell32" Alias "ShellExecuteA" (ByVal hwnd As Long, _
        ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, _
        ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long

Private Declare Function ExtEscape Lib "Gdi32" (ByVal hDC As Long, _
        ByVal nEscape As Long, ByVal cbInput As Long, ByVal lpInData As String, _
        ByVal cbOutput As Long, ByVal lpOutData As Long) As Long

Private Declare Function GetOpenFileName Lib "comdlg32.dll" Alias _
		"GetOpenFileNameA" (pOpenfilename As OPENFILENAME) As Long

Private Declare Function GetSaveFileName Lib "comdlg32.dll" Alias _
		"GetSaveFileNameA" (pOpenfilename As OPENFILENAME) As Long


Private Type OPENFILENAME
		lStructSize As Long
		hwndOwner As Long
		hInstance As Long
		lpstrFilter As String
		lpstrCustomFilter As String
		nMaxCustFilter As Long
		nFilterIndex As Long
		lpstrFile As String
		nMaxFile As Long
		lpstrFileTitle As String
		nMaxFileTitle As Long
		lpstrInitialDir As String
		lpstrTitle As String
		flags As Long
		nFileOffset As Integer
		nFileExtension As Integer
		lpstrDefExt As String
		lCustData As Long
		lpfnHook As Long
		lpTemplateName As String
End Type
      

Private Sub Form_Unload(Cancel As Integer)
    PDFPrinter.RestoreDefaultPrinter
    Set PDFPrinter = Nothing
End Sub

Private Sub InitSaverObj()
    Set PDFPrinter = PDFPFactory.Printer("", "PDF-XChange Standard V7", "<YOUR REG CODE>", "<YOUR DEV CODE>")
    pname = PDFPrinter.Name
    PDFPrinter.SetAsDefaultPrinter
End Sub

Public Sub Form_Load()
    InitSaverObj
    TypeOption(0).Value = True
End Sub

Private Sub btnAbout_Click()
    frmAbout.Show vbModal, Me
End Sub

Private Sub btnBrowseDoc_Click()   
    Dim sFilter As String
    Dim OpenFile As OPENFILENAME
    OpenFile.lStructSize = Len(OpenFile)
    sFilter = "MS Word Documents (*.doc)" & Chr(0) & "*.doc;*.ppt" & Chr(0)
    OpenFile.lpstrFilter = sFilter
    OpenFile.nFilterIndex = 1
    OpenFile.lpstrFile = String(257, 0)
    OpenFile.nMaxFile = Len(OpenFile.lpstrFile) - 1
    OpenFile.lpstrFileTitle = OpenFile.lpstrFile
    OpenFile.nMaxFileTitle = OpenFile.nMaxFile
    OpenFile.lpstrInitialDir = "C:\"
    OpenFile.lpstrTitle = "Choose MS Word Document"
    OpenFile.lpstrDefExt = "doc"
    OpenFile.flags = 0

    Dim lReturn As Long
    lReturn = GetOpenFileName(OpenFile)
	If (lReturn) Then
		m_File.Text = Trim$(Left$(OpenFile.lpstrFile, Len(OpenFile.lpstrFile) - 2))
	End If
End Sub

Private Sub btnClose_Click()
    Unload Me
End Sub

Private Sub Make_ShowHide(Index As Integer, bShow As Boolean)
    frType(Index).Visible = bShow
End Sub

Private Sub btnGo_Click()
    Dim fn As String
    Dim D As Long
    Dim D2 As Long
    Dim DD As Byte
    Dim P As Printer
    Dim bVal As Boolean
    Dim s As String
    
    PDFPrinter.ResetDefaults
    PDFPrinter.Option("Save.File") = fName.Text
    PDFPrinter.Option("Save.SaveType") = "Save"
    PDFPrinter.Option("Save.ShowSaveDialog") = "No"
    PDFPrinter.Option("Save.WhenExists") = "Overwrite"

    bVal = doCompress.Value
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
    bVal = doEmbedd.Value
    PDFPrinter.Option("Fonts.EmbedAll") = IIf(bVal = True, 1, 0)
    bVal = doRun.Value
    PDFPrinter.Option("Save.RunApp") = bVal
    If bVal = True Then
        PDFPrinter.Option("Save.RunCustom") = "No"
    End If
    
    ' To Hide progress window uncomment the next line
    PDFPrinter.Option("Saver.ShowProgress") = "No"
    

	 PDFPrinter.Option("Watermarks.Enabled") = "Yes"
	 PDFPrinter.AddImageWatermark "I", "WatermarkImg.png", -1, 1550, 1254, 17, 0, 0, 0, 50, 796, 0, ""
	 PDFPrinter.AddTextWatermark "T", "Watermark Text", "Arial", 0, 0, 0, 0, 0, 0, 17, 0, 0, 0, 50, 28, 0, ""
	 PDFPrinter.Option("Watermarks.Watermarks") = "I;T"
	 PDFPrinter.ApplyOptions 0

    If (TypeOption(2).Value) Then
        IE_WebBrowser.ExecWB OLECMDID_PRINT, OLECMDEXECOPT_DONTPROMPTUSER
    ElseIf (TypeOption(1).Value) Then
        ShellExecute 0, "printto", m_File.Text, """" + pname + """", vbNull, SW_MINIMIZE
    ElseIf (TypeOption(0).Value) Then
        For Each P In Printers
            If P.DeviceName = pname Then
                ' Set printer as default for current session
                Set Printer = P
                ' Stop looking for a printer
                Exit For
            End If
        Next
        '
        'initialize printer
        D = Printer.TwipsPerPixelX
        Printer.Orientation = vbPRORPortrait
        'initialized
        D = Printer.hDC
        '
        Printer.FontName = "Arial"
        Printer.FontSize = 12
        Printer.CurrentX = 1000
        Printer.CurrentY = 3000
        Printer.Print "Sample printing from VB using PDF-XChange V7"
        Printer.Circle (3745, 3000), 2900
        Printer.NewPage
        Printer.EndDoc
    End If
End Sub

Private Sub doBrowseRes_Click()
    Dim sFilter As String
    Dim OpenFile As OPENFILENAME
    OpenFile.lStructSize = Len(OpenFile)
    sFilter = "PDF Files (*.pdf)" & Chr(0) & "*.pdf" & Chr(0)
    OpenFile.lpstrFilter = sFilter
    OpenFile.nFilterIndex = 1
    OpenFile.lpstrFile = String(257, 0)
    OpenFile.nMaxFile = Len(OpenFile.lpstrFile) - 1
    OpenFile.lpstrFileTitle = OpenFile.lpstrFile
    OpenFile.nMaxFileTitle = OpenFile.nMaxFile
    OpenFile.lpstrInitialDir = "C:\"
    OpenFile.lpstrTitle = "Choose MS Word Document"
    OpenFile.lpstrDefExt = "doc"
    OpenFile.flags = 0

    Dim lReturn As Long
    lReturn = GetSaveFileName(OpenFile)
	If (lReturn) Then
		 fName.Text = Trim$(Left$(OpenFile.lpstrFile, Len(OpenFile.lpstrFile) - 2))
	End If

End Sub

Private Sub IE_GO_Click()
    Dim URL As String
    URL = IE_URL.Text
    IE_WebBrowser.Navigate URL
End Sub

Private Sub PDFPrinter_OnEndDoc(ByVal JobID As Long, ByVal bOK As Long)
    '
End Sub

Private Sub PDFPrinter_OnEndPage(ByVal JobID As Long, ByVal nPageNumber As Long)
    '
End Sub

Private Sub PDFPrinter_OnError(ByVal JobID As Long, ByVal dwErrorCode As Long)
    '
End Sub

Private Sub PDFPrinter_OnFileSaved(ByVal JobID As Long, ByVal lpszFileName As String)
    MsgBox "PDF file was saved as '" + lpszFileName + "'"
End Sub

Private Sub PDFPrinter_OnFileSent(ByVal JobID As Long, ByVal lpszFileName As String)
    '
End Sub

Private Sub PDFPrinter_OnStartDoc(ByVal JobID As Long, ByVal lpszDocName As String, ByVal lpszAppName As String)
     MsgBox "Document '" + lpszDocName + "' started."
End Sub

Private Sub PDFPrinter_OnStartPage(ByVal JobID As Long, ByVal nPageNumber As Long)
    '
End Sub

Private Sub TypeOption_Click(Index As Integer)
    If (Index = vFrame) Then
        Exit Sub
    End If
    Make_ShowHide vFrame, False
    vFrame = Index
    If (Index = 2) Then
        If IE_URL.Text = "" Then
            IE_URL.Text = "https://www.tracker-software.com/"
            IE_GO_Click
        End If
    End If
    Make_ShowHide vFrame, True
End Sub

