
package com.trackersoftware.pdf.driversdk;

import com.sun.jna.platform.win32.COM.COMException;
import com.sun.jna.platform.win32.COM.util.IComEventCallbackCookie;
import com.sun.jna.platform.win32.COM.util.IComEventCallbackListener;
import com.sun.jna.platform.win32.COM.util.IConnectionPoint;
import com.sun.jna.platform.win32.COM.util.IUnknown;
import com.sun.jna.platform.win32.COM.util.annotation.ComObject;
import com.sun.jna.platform.win32.COM.util.IRawDispatchHandle;

/**
 * CPXCControlEx Class
 *
 * <p>uuid({AE08E75B-62CE-4950-9CF7-EA76BDA421FD})</p>
 * <p>interface(IPXCControlEx)</p>
 */
@ComObject(clsId = "{AE08E75B-62CE-4950-9CF7-EA76BDA421FD}")
public interface CPXCControlEx extends IUnknown
    ,IPXCControlEx
{

}