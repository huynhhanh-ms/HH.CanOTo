// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using System;

namespace \u0008
{
  internal class \u000F
  {
    private readonly Type \u0001;
    private readonly object \u0002;
    private readonly bool \u0003;

    public \u000F(object o, bool firstLevel)
      : this(o, o?.GetType(), firstLevel)
    {
    }

    public \u000F(object o, Type t, bool firstLevel)
    {
      this.\u0002 = o;
      this.\u0001 = t;
      this.\u0003 = firstLevel;
    }

    public bool FirstLevel => this.\u0003;

    public object \u0001() => this.\u0002;

    public Type \u0001() => this.\u0001;
  }
}
