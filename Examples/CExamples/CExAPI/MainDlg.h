// MainDlg.h : interface of the CMainDlg class
//
/////////////////////////////////////////////////////////////////////////////

#pragma once

#include "dlg_native.h"
#include "dlg_shell.h"
#include "dlg_ie.h"
#include "dlg_native_mt.h"
#include "PrintEventHandler.h"

class CMainDlg :
		public CAxDialogImpl<CMainDlg>, public CUpdateUI<CMainDlg>,
		public CMessageFilter, public CIdleHandler,
		public IDispEventImpl<0, CMainDlg, &__uuidof(PXC::_IPXCPrinterEvents), &PXC::LIBID_PXC, 1, 0>
{
public:
	CMainDlg();
	~CMainDlg();
public:
	enum { IDD = IDD_MAINDLG };

	virtual BOOL PreTranslateMessage(MSG* pMsg);
	virtual BOOL OnIdle();

	BEGIN_MSG_MAP(CMainDlg)
		MESSAGE_HANDLER(WM_INITDIALOG, OnInitDialog)
		MESSAGE_HANDLER(WM_DESTROY, OnDestroy)
		COMMAND_ID_HANDLER(ID_APP_ABOUT, OnAppAbout)
		COMMAND_ID_HANDLER(IDOK, OnOK)
		COMMAND_ID_HANDLER(IDCANCEL, OnCancel)
		COMMAND_ID_HANDLER(IDC_DORUN, OnGo)
		COMMAND_HANDLER(IDC_RUN, BN_CLICKED, OnAppRun)
		COMMAND_HANDLER(IDC_OVERLAY, BN_CLICKED, OnOverlay)
		COMMAND_HANDLER(IDC_USE_COMPR, BN_CLICKED, OnCompression)
		COMMAND_HANDLER(IDC_USE_EMBEDD, BN_CLICKED, OnEmbedd)
		COMMAND_HANDLER(IDC_BROWSE, BN_CLICKED, OnBrowse)
		COMMAND_HANDLER(IDC_OBROWSE, BN_CLICKED, OnBrowseOverlay)
		COMMAND_HANDLER(IDC_NATIVE, BN_CLICKED, OnTestID)
		COMMAND_HANDLER(IDC_SHELL, BN_CLICKED, OnTestID)
		COMMAND_HANDLER(IDC_OLE_IE, BN_CLICKED, OnTestID)
		COMMAND_HANDLER(IDC_NATIVE_MT, BN_CLICKED, OnTestID)
	END_MSG_MAP()

	BEGIN_UPDATE_UI_MAP(CMainDlg)
	END_UPDATE_UI_MAP()

	BEGIN_SINK_MAP(CMainDlg)
		SINK_ENTRY_EX(0, __uuidof(PXC::_IPXCPrinterEvents), 1, OnStartDoc)
		SINK_ENTRY_EX(0, __uuidof(PXC::_IPXCPrinterEvents), 2, OnStartPage)
		SINK_ENTRY_EX(0, __uuidof(PXC::_IPXCPrinterEvents), 3, OnEndPage)
		SINK_ENTRY_EX(0, __uuidof(PXC::_IPXCPrinterEvents), 4, OnEndDoc)
		SINK_ENTRY_EX(0, __uuidof(PXC::_IPXCPrinterEvents), 5, OnFileSaved)
		SINK_ENTRY_EX(0, __uuidof(PXC::_IPXCPrinterEvents), 6, OnFileSent)
		SINK_ENTRY_EX(0, __uuidof(PXC::_IPXCPrinterEvents), 7, OnError)
		SINK_ENTRY_EX(0, __uuidof(PXC::_IPXCPrinterEvents), 8, OnDocSpooled)
	END_SINK_MAP()

	LRESULT OnInitDialog(UINT /*uMsg*/, WPARAM /*wParam*/, LPARAM /*lParam*/, BOOL& /*bHandled*/);
	LRESULT OnDestroy(UINT /*uMsg*/, WPARAM /*wParam*/, LPARAM /*lParam*/, BOOL& /*bHandled*/);
	LRESULT OnAppAbout(WORD /*wNotifyCode*/, WORD /*wID*/, HWND /*hWndCtl*/, BOOL& /*bHandled*/);
	LRESULT OnOK(WORD /*wNotifyCode*/, WORD wID, HWND /*hWndCtl*/, BOOL& /*bHandled*/);
	LRESULT OnCancel(WORD /*wNotifyCode*/, WORD wID, HWND /*hWndCtl*/, BOOL& /*bHandled*/);
	LRESULT OnGo(WORD /*wNotifyCode*/, WORD wID, HWND /*hWndCtl*/, BOOL& /*bHandled*/);
	LRESULT OnAppRun(WORD /*wNotifyCode*/, WORD wID, HWND /*hWndCtl*/, BOOL& /*bHandled*/);
	LRESULT OnCompression(WORD /*wNotifyCode*/, WORD wID, HWND /*hWndCtl*/, BOOL& /*bHandled*/);
	LRESULT OnEmbedd(WORD /*wNotifyCode*/, WORD wID, HWND /*hWndCtl*/, BOOL& /*bHandled*/);
	LRESULT OnBrowse(WORD /*wNotifyCode*/, WORD wID, HWND /*hWndCtl*/, BOOL& /*bHandled*/);
	LRESULT OnBrowseOverlay(WORD /*wNotifyCode*/, WORD wID, HWND /*hWndCtl*/, BOOL& /*bHandled*/);
	LRESULT OnOverlay(WORD /*wNotifyCode*/, WORD wID, HWND /*hWndCtl*/, BOOL& /*bHandled*/);
	LRESULT OnTestID(WORD /*wNotifyCode*/, WORD wID, HWND /*hWndCtl*/, BOOL& /*bHandled*/);

	void CloseDialog(int nVal);
public:
	//
	HRESULT __stdcall OnStartDoc(long JobID, BSTR lpszDocName, BSTR lpszAppName);
	HRESULT __stdcall OnStartPage(long JobID, long nPageNumber);
	HRESULT __stdcall OnEndPage(long JobID, long nPageNumber);
	HRESULT __stdcall OnEndDoc(long JobID, long bOK);
	HRESULT __stdcall OnFileSaved(long JobID, BSTR lpszFileName);
	HRESULT __stdcall OnFileSent(long JobID, BSTR lpszFileName);
	HRESULT __stdcall OnError(long JobID, long dwErrorCode);
	HRESULT __stdcall OnDocSpooled(long JobID, BSTR lpszDocName, BSTR lpszAppName);
private:
	void ShowSubDlg(BOOL bShow);
	BOOL PreparePrinter();
	BOOL PreparePrinter(PXC::IPXCPrinterPtr& ptr, PXC::IPXCControlExPtr& pFactory, BOOL bNoEvents = FALSE);
	void FinishPrinter();
	static DWORD __stdcall _ThProc(LPVOID lParam);
	DWORD ThProc();
private:
	// _IPXCPrinterEvents
	DWORD	m_TestID;
	BOOL	m_bRun;
	BOOL	m_bUseCompression;
	BOOL	m_bEmbeddFonts;
	BOOL	m_bOverlay;
	TCHAR	m_oname[MAX_PATH];
	TCHAR	m_fname[MAX_PATH];
	DWORD		m_nThreads;
	HANDLE		m_Threads[8];
	//
	CDlg_Native		m_Dlg_Native;
	CDlg_Shell		m_Dlg_Shell;
	CDlg_IE			m_Dlg_IE;
	CDlg_Native_MT	m_Dlg_NativeMT;
	//
	PXC::IPXCPrinterPtr		m_pPrinter;
	PXC::IPXCControlExPtr	m_pFactory;
	//
	LONG					m_NumPrints;
	void waitPrintEnd();
};
