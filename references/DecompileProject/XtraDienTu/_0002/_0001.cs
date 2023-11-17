// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using \u0005;
using System;
using System.Security.Cryptography;
using System.Text;

namespace \u0002
{
  internal class \u0001
  {
    public unsafe string \u0001(string _param1)
    {
      string str1;
      if (true)
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(5);
        StringBuilder stringBuilder1;
        byte[] hash;
        try
        {
          hash = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(_param1));
          stringBuilder1 = new StringBuilder();
label_3:
          *(int*) voidPtr = 0;
          while (true)
          {
            *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (*(int*) voidPtr < hash.Length);
            if (true)
            {
              if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
              {
                if (true)
                {
                  if (true)
                  {
                    stringBuilder1.Append(hash[*(int*) voidPtr].ToString(\u0004.\u0001(660)));
                    if (false)
                      ;
                  }
                  else
                    goto label_12;
                }
                *(int*) voidPtr = *(int*) voidPtr + 1;
              }
              else
                break;
            }
            else
              goto label_3;
          }
          str1 = stringBuilder1.ToString();
        }
        catch (Exception ex)
        {
          byte[] numArray = hash;
          StringBuilder stringBuilder2 = stringBuilder1;
          // ISSUE: variable of a boxed type
          __Boxed<int> local1 = (ValueType) *(int*) voidPtr;
          string str2;
          string str3 = str2;
          // ISSUE: variable of a boxed type
          __Boxed<bool> local2 = (ValueType) (bool) *(sbyte*) ((IntPtr) voidPtr + 4);
          string str4 = _param1;
          \u0008.\u0001(ex, (object) numArray, (object) stringBuilder2, (object) local1, (object) str3, (object) local2, (object) this, (object) str4);
          throw;
        }
      }
label_12:
      return str1;
    }
  }
}
