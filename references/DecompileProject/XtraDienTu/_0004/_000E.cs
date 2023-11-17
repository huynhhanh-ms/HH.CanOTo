// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using System;
using System.IO;

namespace \u0004
{
  internal class \u000E : EventArgs
  {
    private \u000E.\u0004 \u0001;
    private Exception \u0002;
    private bool \u0003;
    private bool \u0004 = true;
    private bool \u0005 = true;
    private bool \u0006;

    public Exception Exception => this.\u0002;

    public bool CanDebug => this.\u0003;

    public bool CanSendReport => this.\u0004;

    public bool ShowContinueCheckbox => this.\u0005;

    [Obsolete("Use ShowContinueCheckbox instead, as this is now also false when the builder has chosen not to show the checkbox.")]
    public bool CanContinue => this.\u0005;

    internal void \u0001(bool _param1) => this.\u0005 = _param1;

    internal void \u0001() => this.\u0003 = true;

    internal void \u0002() => this.\u0004 = false;

    public bool TryToContinue
    {
      get => this.\u0006;
      set => this.\u0006 = value;
    }

    public void \u0003()
    {
      if (!this.\u0003)
        return;
      this.\u0001.\u0003();
    }

    public bool \u0001(string _param1)
    {
      if (File.Exists(_param1))
        File.Delete(_param1);
      return this.\u0001.\u0001(_param1);
    }

    public byte[] \u0001() => this.\u0001.\u0001();

    public bool \u0006() => this.\u0004 && this.\u0001.\u0001();

    public void \u0001(string _param1, string _param2) => this.\u0001.\u0001(_param1, (object) _param2);

    public void \u0002(string _param1, string _param2) => this.\u0001.\u0001(_param1, _param2);

    internal \u000E(\u000E.\u0004 reportSender, Exception exception)
    {
      this.\u0001 = reportSender;
      this.\u0002 = exception;
    }
  }
}
