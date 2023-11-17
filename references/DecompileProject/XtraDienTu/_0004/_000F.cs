// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using System.Drawing;
using System.IO;
using System.Reflection;

namespace \u0004
{
  internal class \u000F
  {
    public static Bitmap \u0001(string _param0)
    {
      try
      {
        Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(\u0005.\u0004.\u0001(17360) + _param0 + \u0005.\u0004.\u0001(17421));
        return manifestResourceStream == null ? (Bitmap) null : new Bitmap(manifestResourceStream);
      }
      catch
      {
        return (Bitmap) null;
      }
    }

    public static Icon \u0001(string _param0)
    {
      try
      {
        Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(\u0005.\u0004.\u0001(17360) + _param0 + \u0005.\u0004.\u0001(17430));
        return manifestResourceStream == null ? (Icon) null : new Icon(manifestResourceStream);
      }
      catch
      {
        return (Icon) null;
      }
    }
  }
}
