#include "StdAfx.h"
#include "PrintEventHandler.h"

HRESULT __stdcall PrintEventHandler::QueryInterface(const IID &riid, void **ppv)
{
	if (InlineIsEqualGUID(riid, __uuidof(IUnknown)))
		return *ppv = static_cast<IUnknown*>(this), S_OK;
	if (InlineIsEqualGUID(riid, __uuidof(IDispatch)))
		return *ppv = static_cast<IDispatch*>(this), S_OK;
	if (InlineIsEqualGUID(riid, __uuidof(PXC::_IPXCPrinterEvents)))
		return *ppv = this, S_OK;
	return E_NOINTERFACE;
}

HRESULT __stdcall PrintEventHandler::GetTypeInfoCount(UINT *pctinfo)
{
	return E_NOTIMPL;
}

HRESULT __stdcall PrintEventHandler::GetTypeInfo(UINT iTInfo, LCID lcid, ITypeInfo **ppTInfo)
{
	return E_NOTIMPL;
}
    
HRESULT __stdcall PrintEventHandler::GetIDsOfNames(REFIID riid, LPOLESTR *rgszNames, UINT cNames,
												   LCID lcid, DISPID *rgDispId)
{
	return E_NOTIMPL;
}
    
HRESULT __stdcall PrintEventHandler::Invoke(DISPID dispIdMember,
											REFIID riid,
											LCID lcid,
											WORD wFlags,
											DISPPARAMS *pDispParams,
											VARIANT *pVarResult,
											EXCEPINFO *pExcepInfo,
											UINT *puArgErr)
{
	pVarResult->vt = VT_HRESULT;
	PXC::_IPXCPrinterEvents* p(this);
	pVarResult->ulVal = ((*((HRESULT(__stdcall***)(PXC::_IPXCPrinterEvents*))p))[dispIdMember-1])(p);
	return S_OK;
}
