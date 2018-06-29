#pragma once

#include "resource.h"

class CDlg_Native : public CDialogImpl<CDlg_Native>
{
public:
	CDlg_Native();
public:
	enum { IDD = IDD_NATIVE };

	BEGIN_MSG_MAP(CDlg_Native)
		MESSAGE_HANDLER(WM_INITDIALOG, OnInitDialog)
	END_MSG_MAP()

	LRESULT OnInitDialog(UINT /*uMsg*/, WPARAM /*wParam*/, LPARAM /*lParam*/, BOOL& /*bHandled*/);
private:
};

