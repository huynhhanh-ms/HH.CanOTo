// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Text;

namespace \u0005
{
  internal class \u0004
  {
    private static readonly string \u0001;
    private static readonly string \u0002;
    private static readonly byte[] \u0003;
    private static readonly Hashtable \u0004;
    private static readonly bool \u0005;
    private static readonly int \u0006;

    public static string \u0001(int _param0)
    {
      int index;
      int num1;
      int count;
      string str1;
      byte[] bytes;
      string str2;
      string str3;
      string str4;
      try
      {
        _param0 -= \u0005.\u0004.\u0006;
        if (\u0005.\u0004.\u0005)
          str4 = (string) \u0005.\u0004.\u0004[(object) _param0];
        else
          goto label_3;
label_2:
        if (true)
        {
          if (str4 != null)
          {
            str1 = str4;
            goto label_25;
          }
        }
        else
          goto label_6;
label_3:
        if (true)
        {
          if (true)
          {
            count = 0;
            index = _param0;
            num1 = (int) \u0005.\u0004.\u0003[index++];
          }
          else
            goto label_25;
        }
        else
          goto label_7;
label_6:
        if ((num1 & 128) != 0)
        {
          if ((num1 & 64) == 0)
          {
            count = ((num1 & 63) << 8) + (int) \u0005.\u0004.\u0003[index++];
            goto label_15;
          }
          else
          {
            int num2 = num1 & 31;
            int num3;
            while (true)
            {
              num3 = (num2 << 24) + ((int) \u0005.\u0004.\u0003[index++] << 16) + ((int) \u0005.\u0004.\u0003[index++] << 8);
              if (false)
                num2 = num3;
              else
                break;
            }
            int num4 = (int) \u0005.\u0004.\u0003[index++];
            count = num3 + num4;
            goto label_15;
          }
        }
label_7:
        count = num1;
        if (count == 0)
        {
          str1 = string.Empty;
          goto label_25;
        }
label_15:
        try
        {
          bytes = Convert.FromBase64String(Encoding.UTF8.GetString(\u0005.\u0004.\u0003, index, count));
          str2 = string.Intern(Encoding.UTF8.GetString(bytes, 0, bytes.Length));
          if (\u0005.\u0004.\u0005)
          {
            try
            {
              \u0005.\u0004.\u0004.Add((object) _param0, (object) str2);
            }
            catch
            {
            }
          }
          str3 = str2;
        }
        catch
        {
          str3 = (string) null;
        }
        if (true)
          str1 = str3;
        else
          goto label_2;
      }
      catch (Exception ex)
      {
        string str5 = str4;
        // ISSUE: variable of a boxed type
        __Boxed<int> local1 = (ValueType) count;
        // ISSUE: variable of a boxed type
        __Boxed<int> local2 = (ValueType) index;
        // ISSUE: variable of a boxed type
        __Boxed<int> local3 = (ValueType) num1;
        byte[] numArray = bytes;
        string str6 = str2;
        string str7 = str3;
        // ISSUE: variable of a boxed type
        __Boxed<int> local4 = (ValueType) _param0;
        \u0008.\u0001(ex, (object) str5, (object) local1, (object) local2, (object) local3, (object) numArray, (object) str6, (object) str7, (object) local4);
        throw;
      }
label_25:
      return str1;
    }

    static \u0004()
    {
      int int32;
      Stream manifestResourceStream;
      Assembly executingAssembly;
      try
      {
        \u0005.\u0004.\u0001 = "0";
        \u0005.\u0004.\u0002 = "100";
        \u0005.\u0004.\u0003 = (byte[]) null;
        \u0005.\u0004.\u0004 = (Hashtable) null;
        int num1;
        if (true)
          num1 = 0;
        else
          goto label_20;
label_2:
        \u0005.\u0004.\u0005 = num1 != 0;
        int num2 = 0;
        int num3;
        while (true)
        {
          \u0005.\u0004.\u0006 = num2;
          if (\u0005.\u0004.\u0001 == "1")
          {
            num3 = 1;
            if (num3 != 0)
            {
              if (num3 == 0)
                num2 = num3;
              else
                break;
            }
            else
              goto label_14;
          }
          else
            goto label_7;
        }
        \u0005.\u0004.\u0005 = num3 != 0;
        goto label_20;
label_14:
        num1 = num3;
        goto label_8;
label_7:
        num1 = Convert.ToInt32(\u0005.\u0004.\u0002);
label_8:
        if (true)
        {
          \u0005.\u0004.\u0006 = num1;
          executingAssembly = Assembly.GetExecutingAssembly();
          manifestResourceStream = executingAssembly.GetManifestResourceStream("{7749d704-2d35-4be7-aeda-8dbf5f69ea00}");
          try
          {
            if (false)
              goto label_13;
            else
              goto label_15;
label_12:
            manifestResourceStream.Read(\u0005.\u0004.\u0003, 0, int32);
label_13:
            manifestResourceStream.Close();
            if (true)
              return;
            goto label_12;
label_15:
            int32 = Convert.ToInt32(manifestResourceStream.Length);
            \u0005.\u0004.\u0003 = new byte[int32];
            goto label_12;
          }
          finally
          {
            manifestResourceStream?.Dispose();
          }
        }
        else
          goto label_2;
label_20:
        \u0005.\u0004.\u0004 = new Hashtable();
        goto label_7;
      }
      catch (Exception ex)
      {
        Assembly assembly = executingAssembly;
        Stream stream = manifestResourceStream;
        // ISSUE: variable of a boxed type
        __Boxed<int> local = (ValueType) int32;
        \u0008.\u0001(ex, (object) assembly, (object) stream, (object) local);
        throw;
      }
    }
  }
}
