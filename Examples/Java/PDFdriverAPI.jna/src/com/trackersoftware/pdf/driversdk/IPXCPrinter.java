
package com.trackersoftware.pdf.driversdk;

import com.sun.jna.platform.win32.COM.util.annotation.ComInterface;
import com.sun.jna.platform.win32.COM.util.annotation.ComMethod;
import com.sun.jna.platform.win32.COM.util.annotation.ComProperty;
import com.sun.jna.platform.win32.COM.IStream;
import com.sun.jna.platform.win32.COM.util.IDispatch;
import com.sun.jna.platform.win32.COM.util.IUnknown;
import com.sun.jna.platform.win32.COM.util.IRawDispatchHandle;
import com.sun.jna.platform.win32.Variant.VARIANT;

/**
 * IPXCPrinter Interface
 *
 * <p>uuid({5342BC99-09C6-450E-8F61-AC7F41049151})</p>
 */
@ComInterface(iid="{5342BC99-09C6-450E-8F61-AC7F41049151}")
public interface IPXCPrinter extends IUnknown, IRawDispatchHandle, IDispatch {
    /**
     * <p>id(0x60020000)</p>
     * <p>vtableId(7)</p>
     */
    @ComProperty(name = "Name", dispId = 0x60020000)
    String getName();
            
    /**
     * <p>id(0x60020001)</p>
     * <p>vtableId(8)</p>
     * @param pOptionName [in] {@code String}
     * @param param1 [in] {@code Object}
     */
    @ComProperty(name = "Option", dispId = 0x60020001)
    void setOption(String pOptionName,
            Object param1);
            
    /**
     * <p>id(0x60020001)</p>
     * <p>vtableId(9)</p>
     * @param pOptionName [in] {@code String}
     */
    @ComProperty(name = "Option", dispId = 0x60020001)
    Object getOption(String pOptionName);
            
    /**
     * <p>id(0x60020003)</p>
     * <p>vtableId(10)</p>
     */
    @ComMethod(name = "ResetDefaults", dispId = 0x60020003)
    void ResetDefaults();
            
    /**
     * <p>id(0x60020004)</p>
     * <p>vtableId(11)</p>
     * @param dwFlags [in] {@code Integer}
     */
    @ComMethod(name = "ApplyOptions", dispId = 0x60020004)
    void ApplyOptions(Integer dwFlags);
            
    /**
     * <p>id(0x60020005)</p>
     * <p>vtableId(12)</p>
     */
    @ComProperty(name = "LastPrintEvent", dispId = 0x60020005)
    PrintEvent getLastPrintEvent();
            
    /**
     * <p>id(0x60020006)</p>
     * <p>vtableId(13)</p>
     * @param event [in] {@code PrintEvent}
     * @param timeOut [in] {@code Integer}
     */
    @ComMethod(name = "WaitForPrintEvent", dispId = 0x60020006)
    void WaitForPrintEvent(PrintEvent event,
            Integer timeOut);
            
    /**
     * <p>id(0x60020007)</p>
     * <p>vtableId(14)</p>
     * @param nParent [in] {@code Integer}
     * @param dwDetectFlags [in] {@code Integer}
     * @param sDet_FontName [in] {@code String}
     * @param nDet_FontStyle [in] {@code Integer}
     * @param nDet_Size [in] {@code Integer}
     * @param nDet_SizeDelta [in] {@code Integer}
     * @param nDet_TextColor [in] {@code Integer}
     * @param dwDisplayFlags [in] {@code Integer}
     * @param dwDisplayColor [in] {@code Integer}
     */
    @ComMethod(name = "AddBookmarkItem", dispId = 0x60020007)
    Integer AddBookmarkItem(Integer nParent,
            Integer dwDetectFlags,
            String sDet_FontName,
            Integer nDet_FontStyle,
            Integer nDet_Size,
            Integer nDet_SizeDelta,
            Integer nDet_TextColor,
            Integer dwDisplayFlags,
            Integer dwDisplayColor);
            
    /**
     * <p>id(0x60020008)</p>
     * <p>vtableId(15)</p>
     * @param sName [in] {@code String}
     * @param sText [in] {@code String}
     * @param sFontName [in] {@code String}
     * @param dwFontWeight [in] {@code Integer}
     * @param bItalic [in] {@code Integer}
     * @param bOutline [in] {@code Integer}
     * @param nFontSize [in] {@code Integer}
     * @param nLineWidth [in] {@code Integer}
     * @param nTextColor [in] {@code Integer}
     * @param dwAlign [in] {@code Integer}
     * @param xOffset [in] {@code Integer}
     * @param yOffset [in] {@code Integer}
     * @param nAngle [in] {@code Integer}
     * @param dwOpacity [in] {@code Integer}
     * @param dwFlags [in] {@code Integer}
     * @param dwPlaceType [in] {@code Integer}
     * @param sRange [in] {@code String}
     */
    @ComMethod(name = "AddTextWatermark", dispId = 0x60020008)
    void AddTextWatermark(String sName,
            String sText,
            String sFontName,
            Integer dwFontWeight,
            Integer bItalic,
            Integer bOutline,
            Integer nFontSize,
            Integer nLineWidth,
            Integer nTextColor,
            Integer dwAlign,
            Integer xOffset,
            Integer yOffset,
            Integer nAngle,
            Integer dwOpacity,
            Integer dwFlags,
            Integer dwPlaceType,
            String sRange);
            
    /**
     * <p>id(0x60020009)</p>
     * <p>vtableId(16)</p>
     * @param sName [in] {@code String}
     * @param sImageFileName [in] {@code String}
     * @param dwTransColor [in] {@code Integer}
     * @param dwWidth [in] {@code Integer}
     * @param dwHeight [in] {@code Integer}
     * @param dwAlign [in] {@code Integer}
     * @param xOffset [in] {@code Integer}
     * @param yOffset [in] {@code Integer}
     * @param nAngle [in] {@code Integer}
     * @param dwOpacity [in] {@code Integer}
     * @param dwFlags [in] {@code Integer}
     * @param dwPlaceType [in] {@code Integer}
     * @param sRange [in] {@code String}
     */
    @ComMethod(name = "AddImageWatermark", dispId = 0x60020009)
    void AddImageWatermark(String sName,
            String sImageFileName,
            Integer dwTransColor,
            Integer dwWidth,
            Integer dwHeight,
            Integer dwAlign,
            Integer xOffset,
            Integer yOffset,
            Integer nAngle,
            Integer dwOpacity,
            Integer dwFlags,
            Integer dwPlaceType,
            String sRange);
            
    /**
     * <p>id(0x6002000a)</p>
     * <p>vtableId(17)</p>
     * @param pStream [in] {@code IStream}
     */
    @ComMethod(name = "StorePrinterOptions", dispId = 0x6002000a)
    void StorePrinterOptions(IStream pStream);
            
    /**
     * <p>id(0x6002000b)</p>
     * <p>vtableId(18)</p>
     * @param pStream [in] {@code IStream}
     */
    @ComMethod(name = "ReStorePrinterOptions", dispId = 0x6002000b)
    void ReStorePrinterOptions(IStream pStream);
            
    /**
     * <p>id(0x6002000c)</p>
     * <p>vtableId(19)</p>
     */
    @ComMethod(name = "SetAsDefaultPrinter", dispId = 0x6002000c)
    void SetAsDefaultPrinter();
            
    /**
     * <p>id(0x6002000d)</p>
     * <p>vtableId(20)</p>
     */
    @ComMethod(name = "RestoreDefaultPrinter", dispId = 0x6002000d)
    void RestoreDefaultPrinter();
            
    /**
     * <p>id(0x6002000e)</p>
     * <p>vtableId(21)</p>
     * @param sName [in] {@code String}
     * @param nPort [in] {@code Integer}
     * @param bNeedAuth [in] {@code Integer}
     * @param sUser [in] {@code String}
     * @param sPassword [in] {@code String}
     * @param bSecureConnection [in] {@code Integer}
     */
    @ComMethod(name = "AddSMTPServer", dispId = 0x6002000e)
    void AddSMTPServer(String sName,
            Integer nPort,
            Integer bNeedAuth,
            String sUser,
            String sPassword,
            Integer bSecureConnection);
            
    /**
     * <p>id(0x6002000f)</p>
     * <p>vtableId(22)</p>
     * @param hParent [in] {@code Long}
     * @param bOK [out] {@code Boolean}
     */
    @ComMethod(name = "ShowSettings", dispId = 0x6002000f)
    void ShowSettings(Long hParent,
            VARIANT bOK);
            
    
}