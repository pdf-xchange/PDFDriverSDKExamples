
package com.trackersoftware.pdf.driversdk;

import com.sun.jna.platform.win32.COM.util.AbstractComEventCallbackListener;
import com.sun.jna.platform.win32.COM.util.annotation.ComEventCallback;
import com.sun.jna.platform.win32.COM.util.annotation.ComInterface;
import com.sun.jna.platform.win32.COM.util.IDispatch;
import com.sun.jna.platform.win32.Variant.VARIANT;

/**
 * _IPXCPrinterEvents interface
 *
 * <p>uuid({2B1FB2BD-7EDB-4722-A318-B3488058507E})</p>
 */
public abstract class _IPXCPrinterEventsListenerHandler extends AbstractComEventCallbackListener implements _IPXCPrinterEventsListener {
    @Override
    public void errorReceivingCallbackEvent(java.lang.String string, java.lang.Exception excptn) {
    }

    /**
     * <p>id(0x1)</p>
     */
    @Override
    public void OnStartDoc(Integer JobID,
            String pDocName,
            String pAppName){
    }
            
    /**
     * <p>id(0x2)</p>
     */
    @Override
    public void OnStartPage(Integer JobID,
            Integer nPageNumber){
    }
            
    /**
     * <p>id(0x3)</p>
     */
    @Override
    public void OnEndPage(Integer JobID,
            Integer nPageNumber){
    }
            
    /**
     * <p>id(0x4)</p>
     */
    @Override
    public void OnEndDoc(Integer JobID,
            Integer nResult){
    }
            
    /**
     * <p>id(0x5)</p>
     */
    @Override
    public void OnFileSaved(Integer JobID,
            String pFileName){
    }
            
    /**
     * <p>id(0x6)</p>
     */
    @Override
    public void OnFileSent(Integer JobID,
            String pFileName){
    }
            
    /**
     * <p>id(0x7)</p>
     */
    @Override
    public void OnError(Integer JobID,
            Integer nErrorCode){
    }
            
    /**
     * <p>id(0x8)</p>
     */
    @Override
    public void OnDocSpooled(Integer JobID,
            String sDocName,
            String sAppName){
    }
            
    
}