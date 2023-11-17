// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using Microsoft.Win32;

namespace \u000E
{
  internal class \u0001
  {
    public static string \u0001()
    {
      try
      {
        RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(\u0010.\u0002.SubkeyApplication) ?? Registry.LocalMachine.OpenSubKey(\u0010.\u0002.WowSubkeyApplication);
        if (registryKey == null)
          return (string) null;
        string str = (string) registryKey.GetValue(\u0005.\u0004.\u0001(15180), (object) null);
        registryKey.Close();
        return str;
      }
      catch
      {
        return (string) null;
      }
    }
  }
}
