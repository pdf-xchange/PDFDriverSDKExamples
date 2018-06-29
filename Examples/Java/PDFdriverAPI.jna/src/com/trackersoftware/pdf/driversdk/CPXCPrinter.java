
package com.trackersoftware.pdf.driversdk;

import com.sun.jna.platform.win32.COM.COMException;
import com.sun.jna.platform.win32.COM.util.IComEventCallbackCookie;
import com.sun.jna.platform.win32.COM.util.IComEventCallbackListener;
import com.sun.jna.platform.win32.COM.util.IConnectionPoint;
import com.sun.jna.platform.win32.COM.util.IUnknown;
import com.sun.jna.platform.win32.COM.util.annotation.ComObject;
import com.sun.jna.platform.win32.COM.util.IRawDispatchHandle;

/**
 * CPXCPrinter Class
 *
 * <p>uuid({EC619340-761F-468C-A783-FA8EABD4129A})</p>
 * <p>source(_IPXCPrinterEvents)</p>
 * <p>interface(IPXCPrinter)</p>
 * <p>interface(IConnectionPoint)</p>
 */
@ComObject(clsId = "{EC619340-761F-468C-A783-FA8EABD4129A}")
public interface CPXCPrinter extends IUnknown
    ,IPXCPrinter
    ,IConnectionPoint
{

}