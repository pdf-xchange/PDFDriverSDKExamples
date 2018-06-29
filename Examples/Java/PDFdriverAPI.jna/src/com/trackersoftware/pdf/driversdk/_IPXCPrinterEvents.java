
package com.trackersoftware.pdf.driversdk;

import com.sun.jna.platform.win32.COM.util.annotation.ComInterface;
import com.sun.jna.platform.win32.COM.util.annotation.ComMethod;
import com.sun.jna.platform.win32.COM.util.annotation.ComProperty;
import com.sun.jna.platform.win32.COM.util.IDispatch;
import com.sun.jna.platform.win32.COM.util.IUnknown;
import com.sun.jna.platform.win32.COM.util.IRawDispatchHandle;
import com.sun.jna.platform.win32.Variant.VARIANT;

/**
 * _IPXCPrinterEvents interface
 *
 * <p>uuid({2B1FB2BD-7EDB-4722-A318-B3488058507E})</p>
 */
@ComInterface(iid="{2B1FB2BD-7EDB-4722-A318-B3488058507E}")
public interface _IPXCPrinterEvents extends IUnknown, IRawDispatchHandle, IDispatch {
    /**
     * <p>id(0x1)</p>
     * @param JobID [in] {@code Integer}
     * @param pDocName [in] {@code String}
     * @param pAppName [in] {@code String}
     */
    @ComMethod(name = "OnStartDoc", dispId = 0x1)
    void OnStartDoc(Integer JobID,
            String pDocName,
            String pAppName);
            
    /**
     * <p>id(0x2)</p>
     * @param JobID [in] {@code Integer}
     * @param nPageNumber [in] {@code Integer}
     */
    @ComMethod(name = "OnStartPage", dispId = 0x2)
    void OnStartPage(Integer JobID,
            Integer nPageNumber);
            
    /**
     * <p>id(0x3)</p>
     * @param JobID [in] {@code Integer}
     * @param nPageNumber [in] {@code Integer}
     */
    @ComMethod(name = "OnEndPage", dispId = 0x3)
    void OnEndPage(Integer JobID,
            Integer nPageNumber);
            
    /**
     * <p>id(0x4)</p>
     * @param JobID [in] {@code Integer}
     * @param nResult [in] {@code Integer}
     */
    @ComMethod(name = "OnEndDoc", dispId = 0x4)
    void OnEndDoc(Integer JobID,
            Integer nResult);
            
    /**
     * <p>id(0x5)</p>
     * @param JobID [in] {@code Integer}
     * @param pFileName [in] {@code String}
     */
    @ComMethod(name = "OnFileSaved", dispId = 0x5)
    void OnFileSaved(Integer JobID,
            String pFileName);
            
    /**
     * <p>id(0x6)</p>
     * @param JobID [in] {@code Integer}
     * @param pFileName [in] {@code String}
     */
    @ComMethod(name = "OnFileSent", dispId = 0x6)
    void OnFileSent(Integer JobID,
            String pFileName);
            
    /**
     * <p>id(0x7)</p>
     * @param JobID [in] {@code Integer}
     * @param nErrorCode [in] {@code Integer}
     */
    @ComMethod(name = "OnError", dispId = 0x7)
    void OnError(Integer JobID,
            Integer nErrorCode);
            
    /**
     * <p>id(0x8)</p>
     * @param JobID [in] {@code Integer}
     * @param sDocName [in] {@code String}
     * @param sAppName [in] {@code String}
     */
    @ComMethod(name = "OnDocSpooled", dispId = 0x8)
    void OnDocSpooled(Integer JobID,
            String sDocName,
            String sAppName);
            
    
}