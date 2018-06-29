unit Main;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, PXCComLib7_TLB, Printers, StdCtrls, ComCtrls, ShellAPI, OleCtrls,
  SHDocVw, ExtCtrls, ComObj, ActiveX, ShlObj, SHDocVw_TLB;
type
  TForm1 = class(TForm)
    GroupBox1: TGroupBox;
    cb_RunViewer: TCheckBox;
    cb_Compression: TCheckBox;
    cb_embFonts: TCheckBox;
    Label1: TLabel;
    ed_Dest: TEdit;
    b_browse: TButton;
    b_go: TButton;
    b_close: TButton;
    PageControl1: TPageControl;
    TabSheet1: TTabSheet;
    TabSheet2: TTabSheet;
    TabSheet3: TTabSheet;
    ed_textout: TEdit;
    Label2: TLabel;
    Label3: TLabel;
    ed_FileToPrint: TEdit;
    b_BrowseSrc: TButton;
    OpenDialog: TOpenDialog;
    SaveDialog: TSaveDialog;
    WebBrowser1: TWebBrowser;
    Panel1: TPanel;
    Label4: TLabel;
    ed_navigate: TEdit;
    b_navigate: TButton;
    l_events: TLabel;
    procedure b_closeClick(Sender: TObject);
    procedure b_goClick(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure b_BrowseSrcClick(Sender: TObject);
    procedure b_browseClick(Sender: TObject);
    procedure b_navigateClick(Sender: TObject);
    procedure FormDestroy(Sender: TObject);
  private
    { Private declarations }
    FEventSink: IUnknown; 
    FConnectionToken: integer;
    procedure OnPrinterEvent(sEvent:string);
    procedure SetPXCPrinterAsDefault;
    procedure RestoreDefaultPrinter;
  public
    { Public declarations }
    procedure InitSaverObj;
    procedure StartDocEvent;
    procedure StartPageEvent;
    procedure EndPageEvent;
    procedure EndDocEvent;
    procedure DocumentSavedEvent;
    procedure DocumentSentEvent;
  end;


 TEventSink = class(TInterfacedObject, IUnknown, IDispatch)
  private
    FController: TForm1;
    {IUknown methods}
    function QueryInterface(const IID: TGUID; out Obj):HResult;stdcall;
    {Idispatch}
    function GetTypeInfoCount(out Count: Integer): HResult; stdcall;
    function GetTypeInfo(Index, LocaleID: Integer; out TypeInfo): HResult; stdcall;
    function GetIDsOfNames(const IID: TGUID; Names: Pointer;
      NameCount, LocaleID: Integer; DispIDs: Pointer): HResult; stdcall;
    function Invoke(DispID: Integer; const IID: TGUID; LocaleID: Integer;
      Flags: Word; var Params; VarResult, ExcepInfo, ArgErr: Pointer): HResult; stdcall;
  public
    constructor Create(Controller: TForm1);
  end;

var
  Form1: TForm1;
  PDFPFactory: CPXCControlEx;
  PDFPrinter: CPXCPrinter;
  PrinterName: string;
  IsPXCPrinterDefault: boolean;

implementation

{$R *.dfm}



constructor TEventSink.Create(Controller: TForm1);
begin
  inherited Create;
  FController := Controller;
end;

function TEventSink.Invoke(DispID: integer; const IID: TGUID; LocaleID: integer; Flags: Word; var Params; VarResult,ExcepInfo,ArgErr:Pointer): HResult;
begin
  Result := S_OK;
  case DispID of
    1: FController.StartDocEvent;
    2: FController.StartPageEvent;
    3: FController.EndPageEvent;
    4: FController.EndDocEvent;
    5: FController.DocumentSavedEvent;
    6: FController.DocumentSentEvent;
  end;
end;

function TEventSink.QueryInterface(const IID: TGUID; out Obj):HResult;stdcall;
begin
  if GetInterFace(IID,Obj) then
    Result := S_OK
  else if IsEqualIID(IID,_IPXCPrinterEvents) then
    Result := QueryInterface(IDispatch,Obj)
  else
    Result := E_NOINTERFACE;
end;

function TEventSink.GetTypeInfoCount(out Count: Integer): HResult;
begin
  Result := S_OK;
end;
function TEventSink.GetTypeInfo(Index, LocaleID: Integer; out TypeInfo): HResult;
begin
  Result := S_OK;
end;
function TEventSink.GetIDsOfNames(const IID: TGUID; Names: Pointer;
      NameCount, LocaleID: Integer; DispIDs: Pointer): HResult;
begin
  Result := S_OK;
end;

//---------------------------------------------------------------------------------

procedure TForm1.InitSaverObj;
var
  prnt:OleVariant;
begin
  PDFPFactory:=CoCPXCControlEx.create;

  if PDFPFactory=nil then
  begin
    ShowMessage('PDF-XChange V6 SDK not installed or not properly registered. Application will quit.');
    Halt(0);
  end;
  prnt:=PDFPFactory.Printer['', 'PDF-XChange V6 Sample', '<YOUR REG CODE>', '<YOUR DEV CODE>'];

  PDFPrinter:= IDispatch(prnt) as CPXCPrinter;

  FEventSink := TEventSink.Create(self);
  InterfaceConnect(PDFPrinter, _IPXCPrinterEvents, FEventSink, FConnectionToken);

  PrinterName := PDFPrinter.Name;
  IsPXCPrinterDefault := false;

end;

procedure TForm1.FormCreate(Sender: TObject);
var
  LStr: array[0 .. MAX_PATH] of Char;
begin
  InitSaverObj;

  ed_Dest.Text := 'c:';
  if SHGetFolderPath(0, CSIDL_PERSONAL, 0, 0, @LStr) = S_OK then
    ed_Dest.Text := LStr;
  ed_Dest.Text := ed_Dest.Text + '\sample.pdf';
end;

procedure TForm1.SetPXCPrinterAsDefault;
begin
  if (IsPXCPrinterDefault) or (PDFPrinter = nil) then
    exit;

  PDFPrinter.SetAsDefaultPrinter;
  IsPXCPrinterDefault:=true;
end;

procedure TForm1.RestoreDefaultPrinter;
begin
  if (IsPXCPrinterDefault=false) or (PDFPrinter = nil) then
    exit;

  IsPXCPrinterDefault:=false;
  PDFPrinter.RestoreDefaultPrinter;
end;


procedure TForm1.OnPrinterEvent(sEvent:string);
begin
  l_events.Caption:=sEvent;
  RestoreDefaultPrinter;
end;

procedure TForm1.StartDocEvent;
begin
  OnPrinterEvent('StartDoc');
end;

procedure TForm1.StartPageEvent;
begin
  OnPrinterEvent('StartPage');
end;

procedure TForm1.EndPageEvent;
begin
  OnPrinterEvent('EndPage');
end;

procedure TForm1.EndDocEvent;
begin
  OnPrinterEvent('EndDoc');
end;

procedure TForm1.DocumentSavedEvent;
begin
  OnPrinterEvent('DocumentSaved');
end;

procedure TForm1.DocumentSentEvent;
begin
  OnPrinterEvent('DocumentSent');
end;

procedure TForm1.b_closeClick(Sender: TObject);
begin
  close;
end;

procedure TForm1.b_goClick(Sender: TObject);
begin
  if ed_Dest.Text='' then
    exit;

  l_events.Caption := '';
  PDFPrinter.Option['Save.RunApp']:=cb_RunViewer.checked;
//
  PDFPrinter.Option['Save.File'] := ed_Dest.Text;
  PDFPrinter.Option['Save.SaveType'] := 'Save';
  PDFPrinter.Option['Save.ShowSaveDialog'] := 'No';
  PDFPrinter.Option['Save.WhenExists'] := 'Overwrite';
//
  if cb_Compression.Checked then
  begin
    PDFPrinter.Option['Compression.Graphics'] := 'Yes';
    PDFPrinter.Option['Compression.Text'] := 'Yes';
    PDFPrinter.Option['Compression.ASCII'] := 'No';
    PDFPrinter.Option['Compression.Color.Enabled'] := 'Yes';
    PDFPrinter.Option['Compression.Color.Method'] := 'Auto';
    PDFPrinter.Option['Compression.Indexed.Enabled'] := 'Yes';
    PDFPrinter.Option['Compression.Indexed.Method'] := 'Auto';
    PDFPrinter.Option['Compression.Mono.Enabled'] := 'Yes';
    PDFPrinter.Option['Compression.Mono.Method'] := 'Auto';
  end
  else //cb_Compression.Checked
  begin
    PDFPrinter.Option['Compression.Graphics'] := 'No';
    PDFPrinter.Option['Compression.Text'] := 'No';
  end; //not cb_Compression.Checked
//
  PDFPrinter.Option['Fonts.EmbedAll'] := cb_embFonts.Checked;

  if PageControl1.TabIndex=0 then
  begin
    SetPXCPrinterAsDefault;
    Printer.Orientation := poLandscape;
  	Printer.BeginDoc;
  	Printer.Canvas.TextOut(300, 300, ed_textout.Text);
  	Printer.NewPage;
  	Printer.EndDoc;
  end
  else
  if PageControl1.TabIndex=1 then
  begin
    if FileExists(ed_FileToPrint.Text) then
    begin
      SetPXCPrinterAsDefault;
      ShellExecute(HWND(nil), 'printto', PChar(ed_FileToPrint.Text), PChar('"' + PrinterName + '"'), nil, SW_MINIMIZE);
    end;
  end
  else
  if PageControl1.TabIndex=2 then
  begin
    if (WebBrowser1.ReadyState = READYSTATE_COMPLETE) then
    begin
      SetPXCPrinterAsDefault;
	  	WebBrowser1.ExecWB(OLECMDID_PRINT, OLECMDEXECOPT_DONTPROMPTUSER);
    end;
  end;
end;


procedure TForm1.b_BrowseSrcClick(Sender: TObject);
begin
  if OpenDialog.Execute then
  begin
    ed_FileToPrint.Text:=OpenDialog.FileName;
  end;
end;

procedure TForm1.b_browseClick(Sender: TObject);
begin
  if SaveDialog.Execute then
  begin
    ed_Dest.Text:=SaveDialog.FileName;
  end;
end;

procedure TForm1.b_navigateClick(Sender: TObject);
begin
	WebBrowser1.Navigate(WideString(ed_navigate.Text));
end;

procedure TForm1.FormDestroy(Sender: TObject);
begin
  RestoreDefaultPrinter;
    
  InterfaceDisconnect(PDFPrinter,_IPXCPrinterEvents,FConnectionToken);
  PDFPrinter := nil;
  FEventSink := nil;
end;

end.
