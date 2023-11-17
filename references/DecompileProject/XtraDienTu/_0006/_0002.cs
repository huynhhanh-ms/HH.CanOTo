// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using System;
using System.Security;

namespace \u0006
{
  internal class \u0002 : EventArgs
  {
    private SecurityException \u0001;
    private string \u0002 = string.Empty;
    private bool \u0003;
    private bool \u0004;
    private bool \u0005 = true;

    public SecurityException SecurityException => this.\u0001;

    public string SecurityMessage => this.\u0002;

    public bool CanContinue => this.\u0005;

    public bool TryToContinue
    {
      get => this.\u0003;
      set => this.\u0003 = value;
    }

    public bool ReportException
    {
      get => this.\u0004;
      set => this.\u0004 = value;
    }

    public \u0002(SecurityException securityException) => this.\u0001 = securityException;

    public \u0002(SecurityException securityException, bool canContinue)
      : this(securityException)
    {
      this.\u0005 = canContinue;
    }

    public \u0002(string securityMessage, bool canContinue)
      : this(new SecurityException(securityMessage), canContinue)
    {
      this.\u0002 = securityMessage;
    }
  }
}
