#include "stdafx.h"
#include "dlg_ie.h"

CDlg_IE::CDlg_IE()
{
	m_IE = NULL;
	lstrcpy(m_URL, _T("http://www.tracker-software.com/"));
}

LRESULT CDlg_IE::OnInitDialog(UINT /*uMsg*/, WPARAM /*wParam*/, LPARAM /*lParam*/, BOOL& /*bHandled*/)
{
	CAxWindow view_ = GetDlgItem(IDC_EXPLORER1);
	if (view_.m_hWnd == NULL)
		return FALSE;
	HRESULT	hr;
	hr = view_.QueryControl(IID_IWebBrowser2, (void**)&m_IE);
	//
	SetDlgItemText(IDC_URL, m_URL);
	return TRUE;
}

LRESULT CDlg_IE::OnGo(UINT, UINT, HWND, BOOL& bHandled)
{
	m_URL[0] = '\0';
	GetDlgItemText(IDC_URL, m_URL, _countof(m_URL) - 1);
	CComBSTR url(m_URL);
	m_IE->Navigate(url, NULL, NULL, NULL, NULL);
	return 0;
}
