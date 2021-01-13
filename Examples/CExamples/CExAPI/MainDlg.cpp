// MainDlg.cpp : implementation of the CMainDlg class
//
/////////////////////////////////////////////////////////////////////////////

#include "stdafx.h"
#include "resource.h"

#include "aboutdlg.h"
#include "MainDlg.h"

static UINT	IDs[] = {IDC_NATIVE, IDC_SHELL, IDC_OLE_IE, IDC_NATIVE_MT};

HRESULT dump_com_error(_com_error &e)
{
	_bstr_t bstrSource(e.Source());
	_bstr_t bstrDescription(e.Description());
	CString s;
	s.Format(L"Code = 0x%08lx\n", e.Error());
	OutputDebugStringW(s);
	s.Format(L"Code meaning = %s\n", e.ErrorMessage()); OutputDebugStringW(s);
	s.Format(L"Source = %s\n", (LPCWSTR)bstrSource); OutputDebugStringW(s);
	s.Format(L"Description = %s\n", (LPCWSTR)bstrDescription); OutputDebugStringW(s);
	return e.Error();
}

CMainDlg::CMainDlg()
{
	m_TestID = 0;
	m_bRun = TRUE;
	m_bOverlay = FALSE;
	m_bUseCompression = TRUE;
	m_bEmbeddFonts = FALSE;
	//
	SHGetFolderPathW(m_hWnd, CSIDL_MYDOCUMENTS, nullptr, 0, m_fname);
	lstrcat(m_fname, _T("\\sample.pdf"));
	SHGetFolderPathW(m_hWnd, CSIDL_MYDOCUMENTS, nullptr, 0, m_oname);
	lstrcat(m_oname, _T("\\overlay.pdf"));
	//
	m_NumPrints = 0;
	m_nThreads = 0;
	ZeroMemory(m_Threads, sizeof(m_Threads));
}

CMainDlg::~CMainDlg()
{
	FinishPrinter();
	if (m_pFactory != nullptr)
		m_pFactory.Release();
}

BOOL CMainDlg::PreTranslateMessage(MSG* pMsg)
{
	return CWindow::IsDialogMessage(pMsg);
}

BOOL CMainDlg::OnIdle()
{
	return FALSE;
}

LRESULT CMainDlg::OnInitDialog(UINT /*uMsg*/, WPARAM /*wParam*/, LPARAM /*lParam*/, BOOL& /*bHandled*/)
{
	try
	{
		m_pFactory = PXC::IPXCControlExPtr(__uuidof(PXC::CPXCControlEx));
	}
	catch (_com_error& e)
	{
		dump_com_error(e);
	}
	if (m_pFactory == nullptr)
	{
		MessageBox(_T("PDF-XChange Printer V7 SDK not installed or not properly registered. Application will quit."),
			_T("PDF-XChange Printer V7 Example"), MB_OK | MB_ICONERROR);
		return TRUE;
	}
	OutputDebugString(L"OnInitDialog: pFactory created!");
	//m_pFactory->RemoveOrphanPrinters(L"", L"");

	// center the dialog on the screen
	CenterWindow();

	// set icons
	HICON hIcon = (HICON)::LoadImage(_Module.GetResourceInstance(), MAKEINTRESOURCE(IDR_MAINFRAME),
		IMAGE_ICON, ::GetSystemMetrics(SM_CXICON), ::GetSystemMetrics(SM_CYICON), LR_DEFAULTCOLOR);
	SetIcon(hIcon, TRUE);
	HICON hIconSmall = (HICON)::LoadImage(_Module.GetResourceInstance(), MAKEINTRESOURCE(IDR_MAINFRAME),
		IMAGE_ICON, ::GetSystemMetrics(SM_CXSMICON), ::GetSystemMetrics(SM_CYSMICON), LR_DEFAULTCOLOR);
	SetIcon(hIconSmall, FALSE);

	// register object for message filtering and idle updates
	CMessageLoop* pLoop = _Module.GetMessageLoop();
	ATLASSERT(pLoop != nullptr);
	pLoop->AddMessageFilter(this);
	pLoop->AddIdleHandler(this);

	UIAddChildWindowContainer(m_hWnd);
	//
	SendDlgItemMessage(IDC_RUN, BM_SETCHECK, (m_bRun) ? BST_CHECKED : BST_UNCHECKED);
	SendDlgItemMessage(IDC_USE_COMPR, BM_SETCHECK, (m_bUseCompression) ? BST_CHECKED : BST_UNCHECKED);
	SendDlgItemMessage(IDC_USE_EMBEDD, BM_SETCHECK, (m_bEmbeddFonts) ? BST_CHECKED : BST_UNCHECKED);
	SetDlgItemText(IDC_FNAME, m_fname);
	SendDlgItemMessage(IDs[m_TestID], BM_SETCHECK, BST_CHECKED);
	SendDlgItemMessage(IDC_OVERLAY, BM_SETCHECK, m_bOverlay ? BST_CHECKED : BST_UNCHECKED);
	SetDlgItemText(IDC_ONAME, m_oname);

	//
	HWND wnd = GetDlgItem(IDC_PLACE);
	RECT r;
	::GetWindowRect(wnd, &r);
	ScreenToClient(&r);
	m_Dlg_Native.Create(m_hWnd);
	m_Dlg_Shell.Create(m_hWnd);
//	m_Dlg_Word.Create(m_hWnd);
	m_Dlg_IE.Create(m_hWnd);
	m_Dlg_NativeMT.Create(m_hWnd);
	//
	m_Dlg_Native.SetWindowPos(wnd, &r, SWP_NOSIZE | SWP_NOACTIVATE);
	m_Dlg_Shell.SetWindowPos(wnd, &r, SWP_NOACTIVATE);
//	m_Dlg_Word.SetWindowPos(wnd, &r, SWP_NOACTIVATE);
	m_Dlg_IE.SetWindowPos(wnd, &r, SWP_NOACTIVATE);
	m_Dlg_IE.m_IE->Navigate(L"https://www.tracker-software.com/", nullptr, nullptr, nullptr, nullptr);
	m_Dlg_NativeMT.SetWindowPos(wnd, &r, SWP_NOSIZE | SWP_NOACTIVATE);
	//
	ShowSubDlg(TRUE);
	//
	return TRUE;
}

LRESULT CMainDlg::OnDestroy(UINT /*uMsg*/, WPARAM /*wParam*/, LPARAM /*lParam*/, BOOL& /*bHandled*/)
{
	//
	if (m_nThreads > 0)
	{
	}
	//
	// unregister message filtering and idle updates
	CMessageLoop* pLoop = _Module.GetMessageLoop();
	ATLASSERT(pLoop != nullptr);
	pLoop->RemoveMessageFilter(this);
	pLoop->RemoveIdleHandler(this);

	return 0;
}

LRESULT CMainDlg::OnAppAbout(WORD /*wNotifyCode*/, WORD /*wID*/, HWND /*hWndCtl*/, BOOL& /*bHandled*/)
{
	CAboutDlg dlg;
	dlg.DoModal();
	return 0;
}

LRESULT CMainDlg::OnOK(WORD /*wNotifyCode*/, WORD wID, HWND /*hWndCtl*/, BOOL& /*bHandled*/)
{
	// TODO: Add validation code
	CloseDialog(wID);
	return 0;
}

LRESULT CMainDlg::OnCancel(WORD /*wNotifyCode*/, WORD wID, HWND /*hWndCtl*/, BOOL& /*bHandled*/)
{
	CloseDialog(wID);
	return 0;
}

void CMainDlg::CloseDialog(int nVal)
{
	DestroyWindow();
	::PostQuitMessage(nVal);
}

//////////////////////////////////////////////////////////////////////////
void CMainDlg::ShowSubDlg(BOOL bShow)
{
	HWND wnd = nullptr;
	switch (m_TestID)
	{
	case 0:
		wnd = m_Dlg_Native.m_hWnd;
		break;
	case 1:
		wnd = m_Dlg_Shell.m_hWnd;
		break;
	case 2:
		wnd = m_Dlg_IE.m_hWnd;
		break;
	case 3:
		wnd = m_Dlg_NativeMT.m_hWnd;
		break;
	}
	if (wnd)
		::ShowWindow(wnd, (bShow) ? SW_SHOW : SW_HIDE);
}

LRESULT CMainDlg::OnGo(WORD /*wNotifyCode*/, WORD wID, HWND /*hWndCtl*/, BOOL& /*bHandled*/)
{
	switch (m_TestID)
	{
	case 0:
		{
			DOCINFO di = {0};
			di.cbSize = sizeof(DOCINFO);
			di.lpszDocName = L"Sample Print";

			if (!PreparePrinter())
			{
				::MessageBeep((UINT)-1);
				break;
			}
			HDC dc = CreateDC(L"PDF-XChange V7", (LPCWSTR)m_pPrinter->Name, L"PXF-XChange7", nullptr);
			if (StartDoc(dc, &di) > 0)
			{
				InterlockedIncrement(&m_NumPrints);
				if (StartPage(dc) > 0)
				{
					HPEN p = CreatePen(PS_SOLID, 1, RGB(255, 0, 0));
					HPEN oldp = (HPEN)SelectObject(dc, p);
					MoveToEx(dc, 0, 0, nullptr);
					LineTo(dc, 2500, 2500);
					SelectObject(dc, oldp);
					EndPage(dc);
				}
				EndDoc(dc);
			}
			ReleaseDC(dc);
		}
		break;
	case 1:
		if (lstrlen(m_Dlg_Shell.m_fname) == 0)
		{
			::MessageBeep((UINT)-1);
			break;
		}
		if (!PreparePrinter())
		{
			::MessageBeep((UINT)-1);
			break;
		}
		InterlockedIncrement(&m_NumPrints);
		WCHAR pn[MAX_PATH];
		wsprintfW(pn, L"\"%s\"", (LPCWSTR)m_pPrinter->Name);
		ShellExecute(nullptr, _T("printto"), m_Dlg_Shell.m_fname, (LPCWSTR)pn, nullptr, SW_MINIMIZE);
		break;
	case 2:	// IE
		OutputDebugString(L"Printing from IE\n");
		if (!PreparePrinter())
		{
			::MessageBeep((UINT)-1);
		}
		InterlockedIncrement(&m_NumPrints);
		m_Dlg_IE.m_IE->ExecWB(OLECMDID_PRINT, OLECMDEXECOPT_DONTPROMPTUSER, nullptr, nullptr);
		break;
	case 3:
		m_nThreads = m_Dlg_NativeMT.GetNumThreads();
		for (DWORD i = 0; i < m_nThreads; i++)
		{
			DWORD dwID = 0;
			InterlockedIncrement(&m_NumPrints);
			m_Threads[i] = CreateThread(nullptr, 0, _ThProc, this, 0, &dwID);
		}
		break;
	}
	waitPrintEnd();
	FinishPrinter();
	return 0;
}

void CMainDlg::waitPrintEnd()
{
	while( true ) {
		MSG msg;
		while( ::PeekMessage(&msg, nullptr, 0, 0, PM_REMOVE) ) {
			::TranslateMessage(&msg);
			::DispatchMessage(&msg);
		}
		if (m_NumPrints <= 0)
		{
			break;
		}
	}
}


LRESULT CMainDlg::OnAppRun(WORD /*wNotifyCode*/, WORD wID, HWND /*hWndCtl*/, BOOL& /*bHandled*/)
{
	m_bRun = (SendDlgItemMessage(wID, BM_GETCHECK, 0, 0) == BST_CHECKED);
	return 0;
}

LRESULT CMainDlg::OnCompression(WORD /*wNotifyCode*/, WORD wID, HWND /*hWndCtl*/, BOOL& /*bHandled*/)
{
	m_bUseCompression = (SendDlgItemMessage(wID, BM_GETCHECK, 0, 0) == BST_CHECKED);
	return 0;
}

LRESULT CMainDlg::OnEmbedd(WORD /*wNotifyCode*/, WORD wID, HWND /*hWndCtl*/, BOOL& /*bHandled*/)
{
	m_bEmbeddFonts = (SendDlgItemMessage(wID, BM_GETCHECK, 0, 0) == BST_CHECKED);
	return 0;
}

LRESULT CMainDlg::OnBrowse(WORD /*wNotifyCode*/, WORD wID, HWND /*hWndCtl*/, BOOL& /*bHandled*/)
{
	CFileDialog fd(FALSE, _T("pdf"), nullptr, OFN_HIDEREADONLY | OFN_OVERWRITEPROMPT, _T("PDF Files (*.pdf)\0*.pdf\0\0"));
	if (fd.DoModal() == IDOK)
	{
		lstrcpy(m_fname, fd.m_szFileName);
		SetDlgItemText(IDC_FNAME, m_fname);
	}
	return 0;
}

LRESULT CMainDlg::OnBrowseOverlay(WORD /*wNotifyCode*/, WORD wID, HWND /*hWndCtl*/, BOOL& /*bHandled*/)
{
	CFileDialog fd(FALSE, _T("pdf"), nullptr, OFN_HIDEREADONLY | OFN_FILEMUSTEXIST, _T("PDF Files (*.pdf)\0*.pdf\0\0"));
	if (fd.DoModal() == IDOK)
	{
		lstrcpy(m_oname, fd.m_szFileName);
		SetDlgItemText(IDC_ONAME, m_oname);
	}
	return 0;
}

LRESULT CMainDlg::OnOverlay(WORD /*wNotifyCode*/, WORD wID, HWND /*hWndCtl*/, BOOL& /*bHandled*/)
{
	m_bOverlay = (SendDlgItemMessage(wID, BM_GETCHECK, 0, 0) == BST_CHECKED);
	return 0;
}

LRESULT CMainDlg::OnTestID(WORD /*wNotifyCode*/, WORD wID, HWND /*hWndCtl*/, BOOL& /*bHandled*/)
{
	for (DWORD i = 0; i < _countof(IDs); i++)
	{
		if ((wID == IDs[i]) && (SendDlgItemMessage(wID, BM_GETCHECK, 0, 0) == BST_CHECKED))
		{
			ShowSubDlg(FALSE);
			m_TestID = i;
			ShowSubDlg(TRUE);
		}
	}
	return 0;
}

BOOL CMainDlg::PreparePrinter(PXC::IPXCPrinterPtr& printer, PXC::IPXCControlExPtr& pFactory, BOOL bNoEvents)
{
	WCHAR tbuf[256];
	wsprintfW(tbuf, L"PreparePrinter: pFactory=0x%.8x", pFactory);
	OutputDebugString(tbuf);
	if (printer == nullptr)
	{
		try
		{
			printer = pFactory->Printer[L"", L"PDF-XChange Standard V7", L"<KEY>", L"<DEVCODE>"];
		}
		catch (_com_error& e)
		{
			dump_com_error(e);
		}
		wsprintfW(tbuf, L"PreparePrinter: printer=0x%.8x", printer);
		OutputDebugString(tbuf);
		if (printer == nullptr)
			return FALSE;
		if (!bNoEvents)
			DispEventAdvise(printer);
	}

	CComVariant a;
	a = -1;
	//printer->put_Option(L"General.Specification", a);
	//printer->Option[L"General.Specification"] = _variant_t(-1);

	printer->Option[L"Save.SaveType"]		= L"Save";
	printer->Option[L"Save.ShowSaveDialog"]	= L"No";
	printer->Option[L"Save.File"]			= m_fname;
	printer->Option[L"Save.WhenExists"]		= L"Overwrite";
	printer->Option[L"Save.RunApp"]			= m_bRun;

	if (m_bRun)
	{
		printer->Option[L"Save.RunCustom"]	= L"No";
	}
	printer->Option[L"Overlay.Enabled"]		= m_bOverlay;
	if (printer)
	{
		printer->Option[L"Overlay.OverlayFile"] = m_oname;
	}
	printer->Option[L"Compression.Graphics"]	= m_bUseCompression;
	printer->Option[L"Compression.Text"]		= m_bUseCompression;
	printer->Option[L"Fonts.EmbedAll"]		= m_bEmbeddFonts;
	//
	//
	//printer->Option[L"DevMode.PapSize"]		= 256;
	//printer->Option[L"DevMode.CWidth"]		= 2970;
	//printer->Option[L"DevMode.CHeight"]		= 4200;

	printer->ApplyOptions(0);

	printer->SetAsDefaultPrinter();
	return TRUE;
}

BOOL CMainDlg::PreparePrinter()
{
	return PreparePrinter(m_pPrinter, m_pFactory);
}

void CMainDlg::FinishPrinter()
{
	if (m_pPrinter == nullptr)
		return;
	m_pPrinter->RestoreDefaultPrinter();
	DispEventUnadvise(m_pPrinter);
	m_pPrinter = nullptr;
}


DWORD CMainDlg::_ThProc(LPVOID lParam)
{
	CMainDlg* pThis = (CMainDlg*)lParam;
	return pThis->ThProc();
}

DWORD CMainDlg::ThProc()
{
	CoInitialize(nullptr);
	WCHAR str[MAX_PATH];
	wsprintfW(str, L"Thread %d started\n", GetCurrentThreadId());
	OutputDebugString(str);
	PXC::IPXCControlExPtr pFactory;
	PXC::IPXCPrinterPtr prn;
	BOOL bNoEvents = TRUE;
	do
	{
		pFactory = PXC::IPXCControlExPtr(__uuidof(PXC::CPXCControlEx));
		if (pFactory == nullptr)
		{
			wsprintfW(str, L"Thread %d: cannot create factory\n", GetCurrentThreadId());
			OutputDebugString(str);
		}

		if (!PreparePrinter(prn, pFactory, bNoEvents))
		{
			pFactory.Release();
			wsprintfW(str, L"Thread %d: cannot create printer\n", GetCurrentThreadId());
			OutputDebugString(str);
			return 0;
		}
		//
		WCHAR pname[MAX_PATH];
		wsprintfW(pname, L"C:\\102\\SamplePrint-%d.pdf", GetCurrentThreadId());
		DOCINFO di = {0};
		di.cbSize = sizeof(DOCINFO);
		di.lpszDocName = pname;

		prn->Option[L"Save.File"] = pname;

		HDC dc = CreateDC(L"PDF-XChange 7.0", (LPCWSTR)prn->Name, L"PDF-XChange7", nullptr);

		wsprintfW(str, L"Thread %d: dc = %.8lx\n", GetCurrentThreadId(), dc);
		OutputDebugString(str);

		if (StartDoc(dc, &di) > 0)
		{
			if (StartPage(dc) > 0)
			{
				HPEN p = CreatePen(PS_SOLID, 1, RGB(255, 0, 0));
				HPEN oldp = (HPEN)SelectObject(dc, p);
				MoveToEx(dc, 0, 0, nullptr);
				LineTo(dc, 2500, 2500);
				SelectObject(dc, oldp);
				EndPage(dc);
			}
			else
			{
				wsprintfW(str, L"Thread %d: cannot start page: error = %.8lx\n", GetCurrentThreadId(), GetLastError());
				OutputDebugString(str);
			}
			EndDoc(dc);
		}
		else
		{
			wsprintfW(str, L"Thread %d: cannot start document: error = %.8lx\n", GetCurrentThreadId(), GetLastError());
			OutputDebugString(str);
		}
		ReleaseDC(dc);
	} while (false);
	if (prn != nullptr)
	{
		{
			wsprintfW(str, L"Thread %d: DispEventUnadvise start\n", GetCurrentThreadId());
			OutputDebugString(str);
		}

		if(bNoEvents == FALSE)
			DispEventUnadvise(prn);
		{
			wsprintfW(str, L"Thread %d: DispEventUnadvise done\n", GetCurrentThreadId());
			OutputDebugString(str);
		}
		if(bNoEvents == FALSE)
			DispEventUnadvise(prn);
		prn.Release();
	}
	if (pFactory != nullptr)
	{
		pFactory.Release();
	}
	wsprintfW(str, L"Thread %d finished\n", GetCurrentThreadId());
	OutputDebugString(str);
	CoUninitialize();
	return 0;
}

//////////////////////////////////////////////////////////////////////////
HRESULT CMainDlg::OnStartDoc(long JobID, BSTR lpszDocName, BSTR lpszAppName)
{
	WCHAR str[MAX_PATH];
	wsprintfW(str, L"OnStartDoc[%d]: JobID = %d\n", GetCurrentThreadId(), JobID);
	OutputDebugString(str);
	return	 S_OK;
}

HRESULT CMainDlg::OnStartPage(long JobID, long nPageNumber)
{
	WCHAR str[MAX_PATH];
	wsprintfW(str, L"OnStartPage[%d]: JobID = %d; page=%d\n", GetCurrentThreadId(), JobID, nPageNumber);
	OutputDebugString(str);
	return	 S_OK;
}

HRESULT CMainDlg::OnEndPage(long JobID, long nPageNumber)
{
	WCHAR str[MAX_PATH];
	wsprintfW(str, L"OnEndPage[%d]: JobID = %d; page=%d\n", GetCurrentThreadId(), JobID, nPageNumber);
	OutputDebugString(str);
	return	 S_OK;
}

HRESULT CMainDlg::OnEndDoc(long JobID, long bOK)
{
	WCHAR str[MAX_PATH];
	wsprintfW(str, L"OnEndDoc[%d]: JobID = %d; bOK=%d\n", GetCurrentThreadId(), JobID, bOK);
	OutputDebugString(str);
	return	 S_OK;
}

HRESULT CMainDlg::OnFileSaved(long JobID, BSTR lpszFileName)
{
	InterlockedDecrement(&m_NumPrints);
	WCHAR str[MAX_PATH];
	wsprintfW(str, L"OnFileSaved[%d]: JobID = %d\n", GetCurrentThreadId(), JobID);
	OutputDebugString(str);
	return S_OK;
}

HRESULT CMainDlg::OnFileSent(long JobID, BSTR lpszFileName)
{
	WCHAR str[MAX_PATH];
	wsprintfW(str, L"OnFileSent[%d]: JobID = %d\n", GetCurrentThreadId(), JobID);
	OutputDebugString(str);
	return	 S_OK;
}

HRESULT CMainDlg::OnError(long JobID, long dwErrorCode)
{
	WCHAR str[MAX_PATH];
	InterlockedDecrement(&m_NumPrints);
	wsprintfW(str, L"OnError[%d]: JobID = %d; Error=0x%.8lx\n", GetCurrentThreadId(), JobID, dwErrorCode);
	OutputDebugString(str);
	return S_OK;
}

HRESULT CMainDlg::OnDocSpooled(long JobID, BSTR lpszDocName, BSTR lpszAppName)
{
	WCHAR str[MAX_PATH];
	wsprintfW(str, L"OnDocSpooled[%d]: JobID = %d\n", GetCurrentThreadId(), JobID);
	OutputDebugString(str);
	return S_OK;
}
