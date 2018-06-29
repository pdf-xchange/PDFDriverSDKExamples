
package com.trackersoftware.pdf.driversdk;

import com.sun.jna.platform.win32.COM.util.IComEnum;

public enum PrintEvent implements IComEnum {
    
    /**
     * (0)
     */
    event_None(0),
    
    /**
     * (1)
     */
    event_StartDoc(1),
    
    /**
     * (2)
     */
    event_StartPage(2),
    
    /**
     * (3)
     */
    event_EndPage(3),
    
    /**
     * (4)
     */
    event_EndDoc(4),
    
    /**
     * (5)
     */
    event_DocumentSaved(5),
    
    /**
     * (6)
     */
    event_DocumentSent(6),
    ;

    private PrintEvent(long value) {
        this.value = value;
    }
    private long value;

    public long getValue() {
        return this.value;
    }
}