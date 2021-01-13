#include "stdafx.h"
#include "dlg_shell.h"

CDlg_Shell::CDlg_Shell()
{
	m_fname[0] = '\0';
}

LRESULT CDlg_Shell::OnInitDialog(UINT /*uMsg*/, WPARAM /*wParam*/, LPARAM /*lParam*/, BOOL& /*bHandled*/)
{
	SetDlgItemText(IDC_FNAME, m_fname);
	return TRUE;
}

LRESULT CDlg_Shell::OnBrowse(WORD /*wNotifyCode*/, WORD wID, HWND /*hWndCtl*/, BOOL& /*bHandled*/)
{
	CFileDialog fd(TRUE, _T("doc"), NULL, OFN_HIDEREADONLY | OFN_OVERWRITEPROMPT,
		_T("MS-Word Documents (*.doc)\0*.doc\0\0"));
	if (fd.DoModal() == IDOK)
	{
		lstrcpy(m_fname, fd.m_szFileName);
		SetDlgItemText(IDC_FNAME, m_fname);
	}
	return 0;
}
