// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using Microsoft.Win32;

namespace \u0010
{
  internal sealed class \u0002
  {
    public static string SubkeyApplication => \u0005.\u0004.\u0001(15189) + \u0008.\u0007.AppName;

    public static string WowSubkeyApplication => \u0005.\u0004.\u0001(15214) + \u0008.\u0007.AppName;

    public static object \u0001(string _param0, object _param1)
    {
      object obj1;
      if (true)
      {
        object obj2;
        using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(\u0010.\u0002.SubkeyApplication))
        {
          do
          {
            if (registryKey == null)
            {
              if (true)
                goto label_5;
            }
            else
              goto label_7;
label_4:
            continue;
label_7:
            obj2 = registryKey.GetValue(_param0, _param1);
            goto label_4;
          }
          while (false);
          goto label_11;
label_5:
          object obj3 = _param1;
          if (true)
          {
            obj1 = obj3;
            goto label_12;
          }
          else
            goto label_12;
        }
label_11:
        return obj2;
      }
label_12:
      return obj1;
    }

    private \u0002()
    {
    }
  }
}
