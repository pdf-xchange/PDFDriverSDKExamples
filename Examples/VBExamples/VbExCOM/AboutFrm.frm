VERSION 5.00
Begin VB.Form frmAbout 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "About..."
   ClientHeight    =   1575
   ClientLeft      =   2340
   ClientTop       =   1935
   ClientWidth     =   5295
   ClipControls    =   0   'False
   ControlBox      =   0   'False
   LinkTopic       =   "AboutFrm"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1087.093
   ScaleMode       =   0  'User
   ScaleWidth      =   4972.279
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'CenterOwner
   Begin VB.CommandButton cmdOK 
      Cancel          =   -1  'True
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   345
      Left            =   3960
      TabIndex        =   0
      Top             =   1080
      Width           =   1260
   End
   Begin VB.Frame Frame1 
      ClipControls    =   0   'False
      Height          =   1335
      Left            =   120
      TabIndex        =   5
      Top             =   120
      Width           =   3735
      Begin VB.PictureBox picIcon 
         Appearance      =   0  'Flat
         BorderStyle     =   0  'None
         CausesValidation=   0   'False
         ClipControls    =   0   'False
         ForeColor       =   &H80000008&
         Height          =   540
         Left            =   120
         Picture         =   "AboutFrm.frx":0000
         ScaleHeight     =   379.26
         ScaleMode       =   0  'User
         ScaleWidth      =   379.26
         TabIndex        =   1
         Top             =   240
         Width           =   540
      End
      Begin VB.Label lblTitle 
         Caption         =   "PDF-XChange 7.0 Printer API (COM)"
         ForeColor       =   &H00000000&
         Height          =   260
         Left            =   840
         TabIndex        =   3
         Top             =   240
         Width           =   2685
      End
      Begin VB.Label lblDescription 
         Caption         =   "Copyright (c) 2002-18 by Tracker Software Products (Canada) Ltd."
         ForeColor       =   &H00000000&
         Height          =   360
         Left            =   120
         TabIndex        =   2
         Top             =   800
         Width           =   3525
      End
      Begin VB.Label lblVersion 
         Caption         =   "VB Examples"
         Height          =   225
         Left            =   840
         TabIndex        =   4
         Top             =   480
         Width           =   2805
      End
   End
End
Attribute VB_Name = "frmAbout"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

' Reg Key Security Options...
Const READ_CONTROL = &H20000
Const KEY_QUERY_VALUE = &H1
Const KEY_SET_VALUE = &H2
Const KEY_CREATE_SUB_KEY = &H4
Const KEY_ENUMERATE_SUB_KEYS = &H8
Const KEY_NOTIFY = &H10
Const KEY_CREATE_LINK = &H20
Const KEY_ALL_ACCESS = KEY_QUERY_VALUE + KEY_SET_VALUE + _
                       KEY_CREATE_SUB_KEY + KEY_ENUMERATE_SUB_KEYS + _
                       KEY_NOTIFY + KEY_CREATE_LINK + READ_CONTROL
                     
' Reg Key ROOT Types...
Const HKEY_LOCAL_MACHINE = &H80000002
Const ERROR_SUCCESS = 0
Const REG_SZ = 1                         ' Unicode nul terminated string
Const REG_DWORD = 4                      ' 32-bit number

Const gREGKEYSYSINFOLOC = "SOFTWARE\Microsoft\Shared Tools Location"
Const gREGVALSYSINFOLOC = "MSINFO"
Const gREGKEYSYSINFO = "SOFTWARE\Microsoft\Shared Tools\MSINFO"
Const gREGVALSYSINFO = "PATH"

Private Declare Function RegOpenKeyEx Lib "advapi32" Alias "RegOpenKeyExA" (ByVal hKey As Long, ByVal lpSubKey As String, ByVal ulOptions As Long, ByVal samDesired As Long, ByRef phkResult As Long) As Long
Private Declare Function RegQueryValueEx Lib "advapi32" Alias "RegQueryValueExA" (ByVal hKey As Long, ByVal lpValueName As String, ByVal lpReserved As Long, ByRef lpType As Long, ByVal lpData As String, ByRef lpcbData As Long) As Long
Private Declare Function RegCloseKey Lib "advapi32" (ByVal hKey As Long) As Long

Private Sub cmdOK_Click()
  Unload Me
End Sub

