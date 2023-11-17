// Decompiled with JetBrains decompiler
// Type: Xtra.Utility.RegistryKeyHelper
// Assembly: Xtra.Utility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0A554BF-0B1B-420F-A5E2-9214C58F15B4
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Utility.dll

using Microsoft.Win32;
using System.Windows.Forms;

namespace Xtra.Utility
{
  public static class RegistryKeyHelper
  {
    public static void WriteKey(string Key, string Value, string Path = null)
    {
      if (Path == null)
        Path = string.Format("Software\\VietPhanMem.Net\\{0}", (object) Application.ProductName);
      Registry.CurrentUser.CreateSubKey(Path).SetValue(Key, (object) Value);
    }

    public static string ReadKey(string Key, string Path = null)
    {
      if (Path == null)
        Path = string.Format("Software\\VietPhanMem.Net\\{0}", (object) Application.ProductName);
      object obj = Registry.CurrentUser.CreateSubKey(Path).GetValue(Key);
      return obj == null ? "" : obj.ToString();
    }
  }
}
