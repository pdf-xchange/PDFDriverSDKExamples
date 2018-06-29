object Form1: TForm1
  Left = 427
  Top = 136
  Caption = 'PDF-XChange V7 Printer API Test'
  ClientHeight = 442
  ClientWidth = 519
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  OnCreate = FormCreate
  OnDestroy = FormDestroy
  DesignSize = (
    519
    442)
  PixelsPerInch = 96
  TextHeight = 13
  object l_events: TLabel
    Left = 8
    Top = 414
    Width = 65
    Height = 13
    Anchors = [akLeft, akBottom]
    Caption = 'Printer events'
  end
  object GroupBox1: TGroupBox
    Left = 8
    Top = 311
    Width = 503
    Height = 89
    Anchors = [akLeft, akRight, akBottom]
    Caption = 'Print options:'
    TabOrder = 0
    DesignSize = (
      503
      89)
    object Label1: TLabel
      Left = 6
      Top = 51
      Width = 52
      Height = 13
      Caption = 'Result File:'
    end
    object cb_RunViewer: TCheckBox
      Left = 8
      Top = 16
      Width = 265
      Height = 17
      Caption = 'Run Default Application for PDF Files After Printing'
      Checked = True
      State = cbChecked
      TabOrder = 0
    end
    object cb_Compression: TCheckBox
      Left = 280
      Top = 16
      Width = 113
      Height = 17
      Caption = 'Use Compression'
      Checked = True
      State = cbChecked
      TabOrder = 1
    end
    object cb_embFonts: TCheckBox
      Left = 392
      Top = 16
      Width = 97
      Height = 17
      Caption = 'Embeded Fonts'
      TabOrder = 2
    end
    object ed_Dest: TEdit
      Left = 64
      Top = 48
      Width = 343
      Height = 21
      Anchors = [akLeft, akTop, akRight]
      TabOrder = 3
      Text = 'c:\sample.pdf'
    end
    object b_browse: TButton
      Left = 413
      Top = 46
      Width = 75
      Height = 25
      Anchors = [akTop, akRight]
      Caption = 'Browse...'
      TabOrder = 4
      OnClick = b_browseClick
    end
  end
  object b_go: TButton
    Left = 436
    Top = 409
    Width = 75
    Height = 25
    Anchors = [akRight, akBottom]
    Caption = 'Go'
    TabOrder = 1
    OnClick = b_goClick
  end
  object b_close: TButton
    Left = 355
    Top = 409
    Width = 75
    Height = 25
    Anchors = [akRight, akBottom]
    Cancel = True
    Caption = 'Close'
    TabOrder = 2
    OnClick = b_closeClick
  end
  object PageControl1: TPageControl
    Left = 8
    Top = 8
    Width = 503
    Height = 297
    ActivePage = TabSheet1
    Anchors = [akLeft, akTop, akRight, akBottom]
    TabOrder = 3
    object TabSheet1: TTabSheet
      Caption = 'Native Printing'
      DesignSize = (
        495
        269)
      object Label2: TLabel
        Left = 8
        Top = 8
        Width = 44
        Height = 13
        Caption = 'Text Out:'
      end
      object ed_textout: TEdit
        Left = 3
        Top = 27
        Width = 489
        Height = 21
        Anchors = [akLeft, akTop, akRight]
        TabOrder = 0
        Text = 'Hi There!!!'
      end
    end
    object TabSheet2: TTabSheet
      Caption = 'Print .doc file'
      ImageIndex = 1
      DesignSize = (
        495
        269)
      object Label3: TLabel
        Left = 8
        Top = 8
        Width = 74
        Height = 13
        Caption = 'Doc file to print:'
      end
      object ed_FileToPrint: TEdit
        Left = 8
        Top = 24
        Width = 403
        Height = 21
        Anchors = [akLeft, akTop, akRight]
        TabOrder = 0
      end
      object b_BrowseSrc: TButton
        Left = 417
        Top = 24
        Width = 75
        Height = 21
        Anchors = [akTop, akRight]
        Caption = 'Browse...'
        TabOrder = 1
        OnClick = b_BrowseSrcClick
      end
    end
    object TabSheet3: TTabSheet
      Caption = 'IE Explorer'
      ImageIndex = 2
      object WebBrowser1: TWebBrowser
        Left = 0
        Top = 49
        Width = 495
        Height = 220
        Align = alClient
        TabOrder = 0
        ExplicitWidth = 497
        ControlData = {
          4C00000029330000BD1600000000000000000000000000000000000000000000
          000000004C000000000000000000000001000000E0D057007335CF11AE690800
          2B2E126208000000000000004C0000000114020000000000C000000000000046
          8000000000000000000000000000000000000000000000000000000000000000
          00000000000000000100000000000000000000000000000000000000}
      end
      object Panel1: TPanel
        Left = 0
        Top = 0
        Width = 495
        Height = 49
        Align = alTop
        BevelOuter = bvNone
        TabOrder = 1
        DesignSize = (
          495
          49)
        object Label4: TLabel
          Left = 8
          Top = 8
          Width = 46
          Height = 13
          Caption = 'Navigate:'
        end
        object ed_navigate: TEdit
          Left = 8
          Top = 24
          Width = 399
          Height = 21
          Anchors = [akLeft, akTop, akRight]
          TabOrder = 0
          Text = 'http://www.docu-track.com/'
        end
        object b_navigate: TButton
          Left = 413
          Top = 24
          Width = 75
          Height = 21
          Anchors = [akTop, akRight]
          Caption = 'Go'
          TabOrder = 1
          OnClick = b_navigateClick
        end
      end
    end
  end
  object OpenDialog: TOpenDialog
    Filter = 'MS Word Documents (*.doc)|*.doc'
    Left = 452
    Top = 176
  end
  object SaveDialog: TSaveDialog
    DefaultExt = 'pdf'
    FileName = 'pdf'
    Filter = 'PDF File|*.pdf'
    Left = 448
    Top = 224
  end
end
