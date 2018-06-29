program DriverAPI;

uses
  Forms,
  Main in 'Main.pas' {Form1};

{$R *.res}

begin
  Application.Initialize;
  Application.Title := 'PDF-XChange V7 API Test';
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
