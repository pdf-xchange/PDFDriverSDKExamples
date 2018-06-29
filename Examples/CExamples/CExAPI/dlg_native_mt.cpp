#include "stdafx.h"
#include "dlg_native_mt.h"

CDlg_Native_MT::CDlg_Native_MT()
{
}

LRESULT CDlg_Native_MT::OnInitDialog(UINT /*uMsg*/, WPARAM /*wParam*/, LPARAM /*lParam*/, BOOL& /*bHandled*/)
{
	SendDlgItemMessage(IDC_TH_COUNT_SPIN, UDM_SETRANGE32, 1, 8);
	SendDlgItemMessage(IDC_TH_COUNT_SPIN, UDM_SETPOS32, 0, 8);
	return TRUE;
}

DWORD CDlg_Native_MT::GetNumThreads()
{
	DWORD dwRes = (DWORD)SendDlgItemMessage(IDC_TH_COUNT_SPIN, UDM_GETPOS32);
	if (dwRes == 0)
		dwRes = 1;
	if (dwRes > 8)
		dwRes = 8;
	return dwRes;
}
