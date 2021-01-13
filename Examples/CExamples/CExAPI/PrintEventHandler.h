#pragma once
#include "oaidl.h"

class __declspec(novtable) PrintEventHandler : public PXC::_IPXCPrinterEvents
{
public:
	// IUnknown
	HRESULT __stdcall QueryInterface(const IID &riid, void **ppv);
	ULONG __stdcall AddRef(){return 1;}
	ULONG __stdcall Release(){return 1;}
	// IDispatch
    HRESULT __stdcall GetTypeInfoCount(UINT *pctinfo);
    HRESULT __stdcall GetTypeInfo(UINT iTInfo, LCID lcid, ITypeInfo **ppTInfo);
        
    HRESULT __stdcall GetIDsOfNames(REFIID riid, LPOLESTR *rgszNames,
											   UINT cNames,
											   LCID lcid,
											   DISPID *rgDispId);
        
	HRESULT __stdcall Invoke(DISPID dispIdMember,
							 REFIID riid,
							 LCID lcid,
							 WORD wFlags,
							 DISPPARAMS *pDispParams,
							 VARIANT *pVarResult,
							 EXCEPINFO *pExcepInfo,
							 UINT *puArgErr);
};
