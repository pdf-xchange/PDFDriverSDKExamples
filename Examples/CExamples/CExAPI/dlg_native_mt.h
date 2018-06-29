#pragma once

#include "resource.h"

class CDlg_Native_MT : public CDialogImpl<CDlg_Native_MT>
{
public:
	CDlg_Native_MT();
public:
	enum { IDD = IDD_NATIVE_MT };

	BEGIN_MSG_MAP(CDlg_Native_MT)
		MESSAGE_HANDLER(WM_INITDIALOG, OnInitDialog)
	END_MSG_MAP()

	LRESULT OnInitDialog(UINT /*uMsg*/, WPARAM /*wParam*/, LPARAM /*lParam*/, BOOL& /*bHandled*/);
public:
	DWORD GetNumThreads();
};

