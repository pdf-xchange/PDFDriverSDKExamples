#################################################################################
#
# PDF-XChange 9.0 Printer API
# PowerShell Examples
#
#################################################################################

$pPrinterName = "PDF-XChange Sample PowerShell"

$prnFactory = New-Object -ComObject PXCComLib7.CPXCControlEx
                                    
$PDFPrinter = $prnFactory.Printer(`
        "", `
        $pPrinterName, `
        "<REG CODE>", `
        "<DEV CODE>"`
)

$PDFPrinter.AddTextWatermark("Watermark1", "Hello WaterMark 1", "Verdana", 400, 1, 0, 0, 0, 1, 1, 0,0,45, 10, 30,0,"1,2")

$PDFPrinter.AddTextWatermark(`
    "Watermark2",         <# BSTR sName,        #>`
    "PowerShell Sample",  <# BSTR sText,        #>`
    " Arial",             <# BSTR sFontName,    #>`            
     400,                 <# long dwFontWeight, #>`
     0,                   <# long bItalic,      #>`
     0,                   <# long bOutline,     #>`
     45,                  <# long nFontSize,    #>`
     0,                   <# long nLineWidth,   #>`
     1,                   <# long nTextcolor,   #>`
     1+32,                <# long dwAlign,      #>`
     0,                   <# long xOffset,      #>`
     0,                   <# long yOffset,      #>`
     0,                   <# long nAngle,       #>`
     25,                  <# long dwOpacity,    #>`
     2+4+8+16,            <# long dwFlags,      #>`
     0,                   <# long dwPlaceType,  #>`
    "1-"                  <# BSTR sRange);      #>`
)

$PDFPrinter.AddImageWatermark("Img", "https://www.tracker-software.com/img/productIcons/sm_drvapi_box_v5(1477)_250x250.png", -1, 250, 250, 17, 0, 0, 0, 100, 796, 0, "")
#$PDFPrinter.AddImageWatermark("Img", "D:\Project\Repos\PDFDriverSDKExamples\Examples\PowerShell\sm_drvapi_box_v5(1477)_250x250.png", 0, 250, 250, 17, 0, 0, 0, 10, 796, 0, "1-")

$PDFPrinter.Option("Watermarks.Enabled") = "Yes"
$PDFPrinter.Option("Watermarks.Watermarks") = "Watermark1;Watermark2;Img";

$PDFPrinter.Option("General.Specification") = -1;
$PDFPrinter.Option("Save.SaveType")	= "Save";
$PDFPrinter.Option("Save.ShowSaveDialog") = "No";
$PDFPrinter.Option("Save.WhenExists") = "Append";
$PDFPrinter.Option("Save.RunApp") = "Yes";


$PDFPrinter.Option("Save.File")	= "test1.pdf";


$PDFPrinter.ApplyOptions(0);

$PDFPrinter.SetAsDefaultPrinter()

#$printer = Get-CimInstance -Class Win32_Printer -Filter "Name='"$pPrinterName"'"
#Invoke-CimMethod -InputObject $printer -MethodName SetDefaultPrinter

#(New-Object -ComObject WScript.Network).SetDefaultPrinter($pPrinterName)

#Start-Process –FilePath “\\ds-nas\pdfStore\01\20\corruption of daily reports.pdf” -Verb PrintTo -PassThru

Start-Process -FilePath "\\ds-nas\pdfStore\01\20\AgCDailyExampledocx.docx" -Verb PrintTo -PassThru -Wait

$PDFPrinter.RestoreDefaultPrinter()

#Print file from temp printer
#Get-Content -Path '\\ds-nas\pdfStore\01\20\corruption of daily reports.pdf'  |  Out-Printer $pPrinterName
#Get-Content -Path .\PDFdriverAPI.ps1 |  Out-Printer $pPrinterName

<#
#sets the printer associated with the IPXCPrinter object as the system default printer

#Print file
Get-Content -Path .\PDFdriverAPI.ps1 | Out-Printer

#restores the original system default printer
$PDFPrinter.RestoreDefaultPrinter();
#>