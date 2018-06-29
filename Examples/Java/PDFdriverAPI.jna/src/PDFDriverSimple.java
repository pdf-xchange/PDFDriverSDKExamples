import com.sun.jna.Pointer;
import com.sun.jna.platform.win32.Ole32;
import com.sun.jna.platform.win32.Variant;
import com.sun.jna.platform.win32.COM.util.Factory;

import com.trackersoftware.pdf.driversdk.CPXCControlEx;
import com.trackersoftware.pdf.driversdk.CPXCPrinter;
import com.trackersoftware.pdf.driversdk.IPXCPrinter;

import java.awt.Graphics;
import java.awt.print.*;
import java.awt.print.Printable;

import javax.print.DocFlavor;
import javax.print.DocPrintJob;
import javax.print.PrintService;
import javax.print.PrintServiceLookup;
import javax.print.SimpleDoc;
import javax.print.attribute.HashPrintRequestAttributeSet;
import javax.print.attribute.PrintRequestAttributeSet;
import javax.print.attribute.standard.Copies;
import javax.swing.plaf.nimbus.NimbusLookAndFeel;

public class PDFDriverSimple {
	

	
	public static void main(String[] args) {
		Ole32.INSTANCE.CoInitializeEx(Pointer.NULL, Ole32.COINIT_MULTITHREADED);
		
		Factory fact = new Factory();
		
		CPXCControlEx inst = fact.createObject(CPXCControlEx.class);
		inst.RemoveOrphanPrinters("", "");
		
		IPXCPrinter PDFPrinter = inst.getPrinter(null, "PDF-XChange Sample Java", "<REG CODE>", "<DEV CODE>");

		System.out.println("Save.ShowSaveDialog: " + PDFPrinter.getOption("Save.File"));
		//PDFPrinter.setOption("Save.File", new Variant.VARIANT("test.pdf"));
		/*
		//PDFPrinter.setOption("General.Specification", new Variant.VARIANT(-1));
		PDFPrinter.setOption("Save.SaveType",  new Variant.VARIANT("Save"));
		PDFPrinter.setOption("Save.ShowSaveDialog", "No");
		PDFPrinter.setOption("Save.WhenExists", "Overwrite");
		PDFPrinter.setOption("Save.RunApp", "Yes");
		PDFPrinter.setOption("Save.File", "test.pdf");
		 */
		PDFPrinter.ApplyOptions(0);

		
		//PDFPrinter.SetAsDefaultPrinter();		
	    try
	    {	    	
	    	//PrintService ps = PrintServiceLookup.lookupDefaultPrintService();
	        //DocPrintJob pjob = ps.createPrintJob();
	    	
	        SimpleDoc doc = new SimpleDoc(new Printable() {
	        	public int print(Graphics pg, PageFormat pf, int pageNum) {
	        		if (pageNum > 10)
	        			return Printable.NO_SUCH_PAGE;
	        		
	        		pg.drawString("Page " + (pageNum + 1), 100, 100);
	        		pg.drawString("www.java2s.com test text ", 100, 200);
	        	    return Printable.PAGE_EXISTS;
	        	}
	        }, DocFlavor.SERVICE_FORMATTED.PRINTABLE, null);
	        PrintRequestAttributeSet attrib = new HashPrintRequestAttributeSet();
	        attrib.add(new Copies(1));
	        	        
	        DocPrintJob pjob = getPrinterJob(PDFPrinter.getName());
	        //DocPrintJob pjob = getPrinterJob("PDF-XChange Sample");
	        pjob.print(doc, attrib);
	        
	        /*
	    	PrinterJob pjob = PrinterJob.getPrinterJob();
	        pjob.setJobName("Graphics Demo Printout");
	        pjob.setCopies(1);
	        pjob.setPrintable(new Printable() {
	        	public int print(Graphics pg, PageFormat pf, int pageNum) {
	        		if (pageNum > 10)
	        			return Printable.NO_SUCH_PAGE;
	        		
	        		pg.drawString("Page " + (pageNum + 1), 100, 100);
	        		pg.drawString("www.java2s.com test text ", 100, 200);
	        	    return Printable.PAGE_EXISTS;
	        	}
	       });
	       if (pjob.printDialog() == false) // choose printer
	         return; 
	       pjob.print(); 
	       */
	   }
	   catch (Exception ex)
	   {
	   }		
	   //PDFPrinter.RestoreDefaultPrinter();
	}

	private static DocPrintJob getPrinterJob(String printerToUse) {
	    DocPrintJob job = null;
	    PrintService[] printServices = PrintServiceLookup.lookupPrintServices(null, null);
	    System.out.println("Number of print services: " + printServices.length);
	    for (PrintService printer : printServices) {
	        if (printer.getName().equals(printerToUse)) {
		        System.out.print(">");
	            job = printer.createPrintJob();
	        }
	        System.out.println("Printer: " + printer.getName());
	    }
	    return job;
	}
}
