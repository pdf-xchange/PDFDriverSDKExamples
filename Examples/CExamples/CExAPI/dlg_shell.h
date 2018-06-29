#pragma once

#include "resource.h"

class CDlg_Shell : public CDialogImpl<CDlg_Shell>
{
public:
	CDlg_Shell();
public:
	enum { IDD = IDD_SHELL };

	BEGIN_MSG_MAP(CDlg_Shell)
		MESSAGE_HANDLER(WM_INITDIALOG, OnInitDialog)
		COMMAND_HANDLER(IDC_BROWSE, BN_CLICKED, OnBrowse)
	END_MSG_MAP()

	LRESULT OnInitDialog(UINT /*uMsg*/, WPARAM /*wParam*/, LPARAM /*lParam*/, BOOL& /*bHandled*/);
	LRESULT OnBrowse(WORD /*wNotifyCode*/, WORD wID, HWND /*hWndCtl*/, BOOL& /*bHandled*/);
public:
	TCHAR	m_fname[MAX_PATH];
};
