// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using System;

namespace \u0007
{
  internal class \u0010 : EventArgs
  {
    private \u000E.\u0007 \u0001;
    private readonly bool \u0002;
    private readonly string \u0003 = string.Empty;
    private readonly string \u0004 = string.Empty;

    public \u000E.\u0007 Step => this.\u0001;

    public bool Failed => this.\u0002;

    public string ErrorMessage => this.\u0003;

    public string ReportID => this.\u0004;

    internal \u0010(\u000E.\u0007 step)
      : this(step, string.Empty)
    {
    }

    internal \u0010(\u000E.\u0007 step, string errorMessage)
      : this(step, errorMessage, string.Empty)
    {
    }

    internal \u0010(\u000E.\u0007 step, string errorMessage, string reportId)
    {
      this.\u0001 = step;
      this.\u0002 = errorMessage != null && errorMessage.Length > 0;
      this.\u0003 = errorMessage;
      this.\u0004 = reportId;
    }
  }
}
