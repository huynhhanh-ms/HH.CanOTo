// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace \u0001
{
  internal static class \u0006
  {
    public static string \u0001(string _param0, string _param1 = null)
    {
      object obj1;
      string str1;
      bool flag;
      try
      {
        if (true)
          goto label_10;
label_5:
        string str2 = obj1.ToString();
        goto label_7;
label_6:
        str2 = \u0005.\u0004.\u0001(720);
label_7:
        str1 = str2;
        if (true)
        {
          if (true)
            return str1;
          goto label_6;
        }
        else
          goto label_5;
label_10:
        flag = _param1 != null;
        if (flag)
          goto label_3;
label_1:
        string str3 = string.Format(\u0005.\u0004.\u0001(14999), (object) Application.ProductName);
        if (true)
          goto label_11;
label_2:
        if (false)
          goto label_5;
        else
          goto label_3;
label_11:
        _param1 = str3;
        goto label_2;
label_3:
        obj1 = Registry.CurrentUser.CreateSubKey(_param1).GetValue(_param0);
        if (true)
        {
          if (obj1 == null)
            goto label_6;
          else
            goto label_5;
        }
        else
          goto label_1;
      }
      catch (Exception ex)
      {
        object obj2 = obj1;
        string str4 = str1;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (ValueType) flag;
        string str5 = _param0;
        string str6 = _param1;
        \u0005.\u0008.\u0001(ex, obj2, (object) str4, (object) local, (object) str5, (object) str6);
        throw;
      }
    }

    public static void \u0001(string _param0, string _param1, string _param2 = null)
    {
      bool flag;
      try
      {
        do
        {
          int num1 = _param2 == null ? 1 : 0;
          int num2;
          while (true)
          {
            num2 = num1 == 0 ? 1 : 0;
            if (false)
              num1 = num2;
            else
              break;
          }
          flag = num2 != 0;
          if (!flag)
            _param2 = string.Format(\u0005.\u0004.\u0001(14999), (object) Application.ProductName);
        }
        while (false);
        Registry.CurrentUser.CreateSubKey(_param2).SetValue(_param0, (object) _param1);
      }
      catch (Exception ex)
      {
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (ValueType) flag;
        string str1 = _param0;
        string str2 = _param1;
        string str3 = _param2;
        \u0005.\u0008.\u0001(ex, (object) local, (object) str1, (object) str2, (object) str3);
        throw;
      }
    }
  }
}
