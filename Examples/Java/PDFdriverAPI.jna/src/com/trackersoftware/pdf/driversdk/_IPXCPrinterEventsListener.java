
package com.trackersoftware.pdf.driversdk;

import com.sun.jna.platform.win32.COM.util.annotation.ComEventCallback;
import com.sun.jna.platform.win32.COM.util.annotation.ComInterface;
import com.sun.jna.platform.win32.COM.util.IDispatch;
import com.sun.jna.platform.win32.Variant.VARIANT;

/**
 * _IPXCPrinterEvents interface
 *
 * <p>uuid({2B1FB2BD-7EDB-4722-A318-B3488058507E})</p>
 */
@ComInterface(iid="{2B1FB2BD-7EDB-4722-A318-B3488058507E}")
public interface _IPXCPrinterEventsListener {
    /**
     * <p>id(0x1)</p>
     */
    @ComEventCallback(dispid = 0x1)
    void OnStartDoc(Integer JobID,
            String pDocName,
            String pAppName);
            
    /**
     * <p>id(0x2)</p>
     */
    @ComEventCallback(dispid = 0x2)
    void OnStartPage(Integer JobID,
            Integer nPageNumber);
            
    /**
     * <p>id(0x3)</p>
     */
    @ComEventCallback(dispid = 0x3)
    void OnEndPage(Integer JobID,
            Integer nPageNumber);
            
    /**
     * <p>id(0x4)</p>
     */
    @ComEventCallback(dispid = 0x4)
    void OnEndDoc(Integer JobID,
            Integer nResult);
            
    /**
     * <p>id(0x5)</p>
     */
    @ComEventCallback(dispid = 0x5)
    void OnFileSaved(Integer JobID,
            String pFileName);
            
    /**
     * <p>id(0x6)</p>
     */
    @ComEventCallback(dispid = 0x6)
    void OnFileSent(Integer JobID,
            String pFileName);
            
    /**
     * <p>id(0x7)</p>
     */
    @ComEventCallback(dispid = 0x7)
    void OnError(Integer JobID,
            Integer nErrorCode);
            
    /**
     * <p>id(0x8)</p>
     */
    @ComEventCallback(dispid = 0x8)
    void OnDocSpooled(Integer JobID,
            String sDocName,
            String sAppName);
            
    
}