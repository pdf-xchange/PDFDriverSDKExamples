
package com.trackersoftware.pdf.driversdk;

import com.sun.jna.platform.win32.COM.util.annotation.ComInterface;
import com.sun.jna.platform.win32.COM.util.annotation.ComMethod;
import com.sun.jna.platform.win32.COM.util.annotation.ComProperty;
import com.sun.jna.platform.win32.COM.util.IDispatch;
import com.sun.jna.platform.win32.COM.util.IUnknown;
import com.sun.jna.platform.win32.COM.util.IRawDispatchHandle;
import com.sun.jna.platform.win32.Variant.VARIANT;

/**
 * IPXCControlEx Interface
 *
 * <p>uuid({8A35CB94-6FF4-431F-A1D0-8F3650392347})</p>
 */
@ComInterface(iid="{8A35CB94-6FF4-431F-A1D0-8F3650392347}")
public interface IPXCControlEx extends IUnknown, IRawDispatchHandle, IDispatch {
    /**
     * <p>id(0x60020000)</p>
     * <p>vtableId(7)</p>
     * @param pServerName [in] {@code String}
     * @param pPrinterName [in] {@code String}
     * @param pRegKey [in] {@code String}
     * @param pDevCode [in] {@code String}
     */
    @ComProperty(name = "Printer", dispId = 0x60020000)
    IPXCPrinter getPrinter(String pServerName,
            String pPrinterName,
            String pRegKey,
            String pDevCode);
            
    /**
     * <p>id(0x60020001)</p>
     * <p>vtableId(8)</p>
     * @param pServerName [in] {@code String}
     * @param pPrinterName [in] {@code String}
     */
    @ComMethod(name = "RemoveOrphanPrinters", dispId = 0x60020001)
    void RemoveOrphanPrinters(String pServerName,
            String pPrinterName);
            
    
}