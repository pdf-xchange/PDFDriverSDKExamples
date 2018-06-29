#pragma once

#include "resource.h"

class CDlg_IE : public CAxDialogImpl<CDlg_IE>,
				public IDispEventImpl<IDC_EXPLORER1, CDlg_IE>
{
public:
	CDlg_IE();
public:
	enum { IDD = IDD_OLE_IE };

	BEGIN_MSG_MAP(CDlg_IE)
		MESSAGE_HANDLER(WM_INITDIALOG, OnInitDialog)
		COMMAND_ID_HANDLER(IDC_GO, OnGo)
	END_MSG_MAP()

	LRESULT OnInitDialog(UINT /*uMsg*/, WPARAM /*wParam*/, LPARAM /*lParam*/, BOOL& /*bHandled*/);
	LRESULT OnGo(UINT, UINT, HWND, BOOL& bHandled);
public :
	BEGIN_SINK_MAP(CDlg_IE)
	END_SINK_MAP()
public:
	IWebBrowser2*	m_IE;
	TCHAR			m_URL[512];
};
