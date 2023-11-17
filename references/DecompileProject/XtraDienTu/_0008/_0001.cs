// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace \u0008
{
  internal static class \u0001
  {
    private static string \u0001;

    public static string \u0001(string _param0)
    {
      string str1;
      string str2;
      MD5 md5_1;
      byte[] bytes;
      try
      {
        if (false)
          goto label_2;
        else
          goto label_6;
label_1:
        if (true)
          bytes = Encoding.Default.GetBytes(_param0);
        else
          goto label_5;
label_2:
        if (true)
          goto label_8;
label_3:
        do
          ;
        while (false);
        str2 = str1;
        goto label_5;
label_8:
        str1 = BitConverter.ToString(md5_1.ComputeHash(bytes));
        goto label_3;
label_5:
        if (false)
          goto label_1;
        else
          goto label_10;
label_6:
        md5_1 = (MD5) new MD5CryptoServiceProvider();
        goto label_1;
      }
      catch (Exception ex)
      {
        MD5 md5_2 = md5_1;
        byte[] numArray = bytes;
        string str3 = str1;
        string str4 = _param0;
        \u0005.\u0008.\u0001(ex, (object) md5_2, (object) numArray, (object) str3, (object) str4);
        throw;
      }
label_10:
      return str2;
    }

    public static string \u0002(string _param0)
    {
      char[] chArray1;
      string[] strArray1;
      string str1;
      string str2;
      try
      {
        strArray1 = new string[5];
        string[] strArray2 = strArray1;
        string str3 = _param0;
        chArray1 = new char[1]{ '-' };
        char[] chArray2 = chArray1;
        object obj = (object) str3.Split(chArray2)[0];
        strArray2[0] = (string) obj;
        string[] strArray3 = strArray1;
        string str4 = _param0;
        chArray1 = new char[1]{ '-' };
        char[] chArray3 = chArray1;
        string str5 = str4.Split(chArray3)[1];
        strArray3[1] = str5;
        string[] strArray4 = strArray1;
        string str6 = _param0;
        chArray1 = new char[1]{ '-' };
        char[] chArray4 = chArray1;
        string str7 = str6.Split(chArray4)[2];
        strArray4[2] = str7;
        string[] strArray5 = strArray1;
        string str8 = _param0;
        chArray1 = new char[1]{ '-' };
        char[] chArray5 = chArray1;
        string str9 = str8.Split(chArray5)[3];
        strArray5[3] = str9;
        string[] strArray6 = strArray1;
        string str10 = _param0;
        chArray1 = new char[1]{ '-' };
        char[] chArray6 = chArray1;
        string str11 = str10.Split(chArray6)[4];
        strArray6[4] = str11;
        str1 = string.Concat(strArray1);
        str2 = new \u0002.\u0001().\u0001(\u0005.\u0004.\u0001(665) + str1 + \u0005.\u0004.\u0001(702));
        strArray1 = new string[9]
        {
          str2.Substring(2, 5),
          \u0005.\u0004.\u0001(715),
          str2.Substring(8, 5),
          \u0005.\u0004.\u0001(715),
          str2.Substring(14, 5),
          \u0005.\u0004.\u0001(715),
          str2.Substring(20, 5),
          \u0005.\u0004.\u0001(715),
          str2.Substring(26, 5)
        };
        return string.Concat(strArray1);
      }
      catch (Exception ex)
      {
        string str12 = str1;
        string str13 = str2;
        string str14;
        string str15 = str14;
        string[] strArray7 = strArray1;
        char[] chArray7 = chArray1;
        string str16 = _param0;
        \u0005.\u0008.\u0001(ex, (object) str12, (object) str13, (object) str15, (object) strArray7, (object) chArray7, (object) str16);
        throw;
      }
    }

    public static unsafe string \u0003(string _param0 = "213")
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(5);
      char[] chArray1;
      // ISSUE: variable of a compiler-generated type
      \u0008.\u0001.\u0001 obj1;
      string str1;
      string str2;
      try
      {
        if (false)
          goto label_4;
        else
          goto label_6;
label_3:
        *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (*(int*) voidPtr < 5);
label_4:
        if (*(sbyte*) ((IntPtr) voidPtr + 4) == (sbyte) 0)
          return str1.Substring(0, str1.Length - 1);
        // ISSUE: reference to a compiler-generated field
        str1 = str1 + obj1.\u0001.Substring(*(int*) voidPtr * 5, 5) + \u0005.\u0004.\u0001(715);
        *(int*) voidPtr = *(int*) voidPtr + 1;
        goto label_3;
label_6:
        // ISSUE: object of a compiler-generated type is created
        obj1 = new \u0008.\u0001.\u0001();
        str2 = \u0008.\u0001.\u0001(\u0007.\u0007.\u0001((byte) 0).SerialNumber);
        // ISSUE: reference to a compiler-generated field
        obj1.\u0001 = \u0005.\u0004.\u0001(720);
        string str3 = str2;
        chArray1 = new char[1]{ '-' };
        char[] chArray2 = chArray1;
        // ISSUE: reference to a compiler-generated method
        ((IEnumerable<string>) str3.Split(chArray2)).ToList<string>().ForEach(new Action<string>(obj1.\u0001));
        str1 = \u0005.\u0004.\u0001(720);
        *(int*) voidPtr = 0;
        goto label_3;
      }
      catch (Exception ex)
      {
        string str4 = str2;
        string str5 = str1;
        // ISSUE: variable of a boxed type
        __Boxed<int> local1 = (ValueType) *(int*) voidPtr;
        // ISSUE: variable of a compiler-generated type
        \u0008.\u0001.\u0001 obj2 = obj1;
        string str6;
        string str7 = str6;
        char[] chArray3 = chArray1;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local2 = (ValueType) (bool) *(sbyte*) ((IntPtr) voidPtr + 4);
        string str8 = _param0;
        \u0005.\u0008.\u0001(ex, (object) str4, (object) str5, (object) local1, (object) obj2, (object) str7, (object) chArray3, (object) local2, (object) str8);
        throw;
      }
    }

    public static unsafe string \u0001(DateTime _param0, string _param1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(5);
      // ISSUE: variable of a compiler-generated type
      \u0008.\u0001.\u0002 obj1;
      string str1;
      char[] chArray1;
      string str2;
      try
      {
        // ISSUE: object of a compiler-generated type is created
        obj1 = new \u0008.\u0001.\u0002();
        str1 = string.Format(\u0005.\u0004.\u0001(721), (object) _param1, (object) _param0).\u0004();
        // ISSUE: reference to a compiler-generated field
        obj1.\u0001 = \u0005.\u0004.\u0001(720);
        string str3 = str1;
        chArray1 = new char[1]{ '-' };
        char[] chArray2 = chArray1;
        // ISSUE: reference to a compiler-generated method
        ((IEnumerable<string>) str3.Split(chArray2)).ToList<string>().ForEach(new Action<string>(obj1.\u0001));
        str2 = \u0005.\u0004.\u0001(720);
        *(int*) voidPtr = 0;
        while (true)
        {
          *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (*(int*) voidPtr < 5);
          if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
          {
            // ISSUE: reference to a compiler-generated field
            str2 = str2 + obj1.\u0001.Substring(*(int*) voidPtr * 5, 5) + \u0005.\u0004.\u0001(715);
            *(int*) voidPtr = *(int*) voidPtr + 1;
          }
          else
            break;
        }
        return str2.Substring(0, str2.Length - 1);
      }
      catch (Exception ex)
      {
        string str4 = str1;
        string str5 = str2;
        // ISSUE: variable of a boxed type
        __Boxed<int> local1 = (ValueType) *(int*) voidPtr;
        // ISSUE: variable of a compiler-generated type
        \u0008.\u0001.\u0002 obj2 = obj1;
        string str6;
        string str7 = str6;
        char[] chArray3 = chArray1;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local2 = (ValueType) (bool) *(sbyte*) ((IntPtr) voidPtr + 4);
        // ISSUE: variable of a boxed type
        __Boxed<DateTime> local3 = (ValueType) _param0;
        string str8 = _param1;
        \u0005.\u0008.\u0001(ex, (object) str4, (object) str5, (object) local1, (object) obj2, (object) str7, (object) chArray3, (object) local2, (object) local3, (object) str8);
        throw;
      }
    }

    public static unsafe DateTime \u0001(string _param0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(5);
      DateTime now;
      DateTime dateTime1;
      string str1;
      DateTime dateTime2;
      DateTime dateTime3;
      try
      {
label_2:
        int num = 770;
        if (num != 0)
          goto label_12;
label_6:
        if (num != 0)
        {
          *(int*) voidPtr = *(int*) voidPtr + 1;
          goto label_9;
        }
label_7:
        dateTime2 = dateTime1;
        goto label_11;
label_9:
        *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (*(int*) voidPtr < 15000);
        if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
        {
          dateTime1 = dateTime1.AddDays(1.0);
          *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) !\u0008.\u0001.\u0001(_param0, dateTime1, str1);
          if (true)
          {
            num = (int) *(sbyte*) ((IntPtr) voidPtr + 4);
            goto label_6;
          }
          else
            goto label_7;
        }
        else
        {
          dateTime2 = new DateTime(2000, 1, 1);
          if (false)
            goto label_15;
        }
label_11:
        dateTime3 = dateTime2;
        goto label_15;
label_12:
        str1 = \u0008.\u0001.\u0003(\u0005.\u0004.\u0001(num));
        now = DateTime.Now;
        dateTime1 = now.AddMonths(-1);
        if (true)
        {
          if (true)
          {
            *(int*) voidPtr = 0;
            if (false)
              goto label_2;
            else
              goto label_9;
          }
          else
            goto label_9;
        }
        else
          goto label_11;
      }
      catch (Exception ex)
      {
        string str2 = str1;
        // ISSUE: variable of a boxed type
        __Boxed<DateTime> local1 = (ValueType) dateTime1;
        // ISSUE: variable of a boxed type
        __Boxed<int> local2 = (ValueType) *(int*) voidPtr;
        // ISSUE: variable of a boxed type
        __Boxed<DateTime> local3 = (ValueType) dateTime2;
        // ISSUE: variable of a boxed type
        __Boxed<DateTime> local4 = (ValueType) now;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local5 = (ValueType) (bool) *(sbyte*) ((IntPtr) voidPtr + 4);
        string str3 = _param0;
        \u0005.\u0008.\u0001(ex, (object) str2, (object) local1, (object) local2, (object) local3, (object) local4, (object) local5, (object) str3);
        throw;
      }
label_15:
      return dateTime3;
    }

    public static string \u0004(this string _param0)
    {
      string str1;
      MD5 md5_1;
      byte[] buffer;
      bool flag;
      try
      {
        do
        {
          byte[] bytes = Encoding.Default.GetBytes(_param0);
          if (true)
            goto label_12;
label_1:
          if (true)
            goto label_13;
label_9:
          continue;
label_13:
          md5_1 = (MD5) new MD5CryptoServiceProvider();
          try
          {
            str1 = BitConverter.ToString(md5_1.ComputeHash(buffer));
            goto label_9;
          }
          finally
          {
            int num1 = md5_1 == null ? 1 : 0;
            int num2;
            while (true)
            {
              flag = num1 != 0;
              num2 = flag ? 1 : 0;
              if (false)
                num1 = num2;
              else
                break;
            }
            if (num2 == 0)
              md5_1.Dispose();
          }
label_12:
          buffer = bytes;
          goto label_1;
        }
        while (false);
        return str1;
      }
      catch (Exception ex)
      {
        byte[] numArray = buffer;
        MD5 md5_2 = md5_1;
        string str2 = str1;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (ValueType) flag;
        string str3 = _param0;
        \u0005.\u0008.\u0001(ex, (object) numArray, (object) md5_2, (object) str2, (object) local, (object) str3);
        throw;
      }
    }

    public static unsafe bool \u0001(string _param0, string _param1)
    {
      int num = 3;
      if (num == 0)
        return num != 0;
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(num);
      try
      {
        *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) !(_param0 == \u0005.\u0004.\u0001(720));
        if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
          goto label_6;
        else
          goto label_5;
label_4:
        *(sbyte*) ((IntPtr) voidPtr + 2) = *(sbyte*) voidPtr;
        goto label_8;
label_5:
        *(sbyte*) voidPtr = (sbyte) 0;
        goto label_4;
label_6:
        *(sbyte*) voidPtr = (sbyte) (\u0008.\u0001.\u0001(\u0008.\u0001.\u0001(_param0), _param1) == _param0);
        goto label_4;
      }
      catch (Exception ex)
      {
        // ISSUE: variable of a boxed type
        __Boxed<bool> local1 = (ValueType) (bool) *(sbyte*) voidPtr;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local2 = (ValueType) (bool) *(sbyte*) ((IntPtr) voidPtr + 1);
        string str1 = _param0;
        string str2 = _param1;
        \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) str1, (object) str2);
        throw;
      }
label_8:
      return (bool) *(sbyte*) ((IntPtr) voidPtr + 2);
    }

    public static unsafe bool \u0001(string _param0, DateTime _param1, string _param2)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(3);
label_1:
      try
      {
        do
        {
          *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) !(_param0 == \u0005.\u0004.\u0001(720));
          if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
          {
            if (true)
            {
              *(sbyte*) voidPtr = (sbyte) 0;
              break;
            }
            goto label_1;
          }
          else
            *(sbyte*) voidPtr = (sbyte) (\u0008.\u0001.\u0001(_param1, _param2) == _param0);
        }
        while (false);
        *(sbyte*) ((IntPtr) voidPtr + 2) = *(sbyte*) voidPtr;
      }
      catch (Exception ex)
      {
        // ISSUE: variable of a boxed type
        __Boxed<bool> local1 = (ValueType) (bool) *(sbyte*) voidPtr;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local2 = (ValueType) (bool) *(sbyte*) ((IntPtr) voidPtr + 1);
        string str1 = _param0;
        // ISSUE: variable of a boxed type
        __Boxed<DateTime> local3 = (ValueType) _param1;
        string str2 = _param2;
        \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) str1, (object) local3, (object) str2);
        throw;
      }
      return (bool) *(sbyte*) ((IntPtr) voidPtr + 2);
    }

    public static string SerialKey
    {
      get
      {
        string str1;
        try
        {
          str1 = \u000F.\u0002.\u0001(\u0005.\u0004.\u0001(775));
        }
        catch (Exception ex)
        {
          string str2;
          string str3 = str2;
          \u0005.\u0008.\u0001(ex, (object) str3);
          throw;
        }
        return str1;
      }
      set
      {
        try
        {
          do
            ;
          while (false);
          \u000F.\u0002.\u0001(\u0005.\u0004.\u0001(775), value, (string) null);
        }
        catch (Exception ex)
        {
          string str = value;
          \u0005.\u0008.\u0001(ex, (object) str);
          throw;
        }
      }
    }

    public static byte[] \u0001(string _param0)
    {
      byte[] hash;
      byte[] numArray1;
      byte[] numArray2;
      MD5CryptoServiceProvider cryptoServiceProvider1;
      UTF8Encoding utF8Encoding1;
      try
      {
        cryptoServiceProvider1 = new MD5CryptoServiceProvider();
        utF8Encoding1 = new UTF8Encoding();
        do
        {
          hash = cryptoServiceProvider1.ComputeHash(utF8Encoding1.GetBytes(_param0));
          if (true)
          {
            if (true)
              numArray1 = hash;
          }
          else
            goto label_7;
        }
        while (false);
        numArray2 = numArray1;
      }
      catch (Exception ex)
      {
        MD5CryptoServiceProvider cryptoServiceProvider2 = cryptoServiceProvider1;
        byte[] numArray3 = hash;
        UTF8Encoding utF8Encoding2 = utF8Encoding1;
        byte[] numArray4 = numArray1;
        string str = _param0;
        \u0005.\u0008.\u0001(ex, (object) cryptoServiceProvider2, (object) numArray3, (object) utF8Encoding2, (object) numArray4, (object) str);
        throw;
      }
label_7:
      return numArray2;
    }

    public static string \u0005(string _param0)
    {
label_0:
      string str1;
      string lower;
      try
      {
        if (true)
          goto label_3;
label_1:
        do
        {
          if (true)
          {
            str1 = lower;
            if (true)
              ;
          }
          else
            goto label_0;
        }
        while (false);
        goto label_6;
label_3:
        lower = BitConverter.ToString(\u0008.\u0001.\u0001(_param0)).Replace(\u0005.\u0004.\u0001(715), \u0005.\u0004.\u0001(720)).ToLower();
        goto label_1;
      }
      catch (Exception ex)
      {
        string str2 = lower;
        string str3 = _param0;
        \u0005.\u0008.\u0001(ex, (object) str2, (object) str3);
        throw;
      }
label_6:
      return str1;
    }

    static \u0001()
    {
      try
      {
        \u0008.\u0001.\u0001 = \u0005.\u0004.\u0001(720);
      }
      catch (Exception ex)
      {
        \u0005.\u0008.\u0001(ex);
        throw;
      }
    }
  }
}
