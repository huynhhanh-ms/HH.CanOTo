// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Objects;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Xtra.Data;

namespace \u0004
{
  internal static class \u0005
  {
    public static unsafe bool \u0001(CanDienTuEntities _param0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(2);
      bool flag;
      DialogResult dialogResult1;
      DialogResult dialogResult2;
      IEnumerable<ObjectStateEntry> objectStateEntries1;
      IEnumerator<ObjectStateEntry> enumerator1;
      ObjectStateEntry current;
      object entity;
      try
      {
        objectStateEntries1 = _param0.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Deleted | EntityState.Modified);
        flag = objectStateEntries1.ToList<ObjectStateEntry>().Count < 1;
        if (!flag)
        {
          dialogResult1 = XtraMessageBox.Show(\u0005.\u0004.\u0001(9393), \u0005.\u0004.\u0001(4171), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
          dialogResult2 = dialogResult1;
          switch (dialogResult2)
          {
            case DialogResult.Cancel:
              *(sbyte*) voidPtr = (sbyte) 0;
              goto label_27;
            case DialogResult.Yes:
              enumerator1 = objectStateEntries1.GetEnumerator();
              try
              {
                while (true)
                {
                  flag = enumerator1.MoveNext();
                  if (flag)
                  {
                    current = enumerator1.Current;
                    flag = current.State != EntityState.Deleted;
                    if (!flag)
                      entity = current.Entity;
                  }
                  else
                    break;
                }
              }
              finally
              {
                flag = enumerator1 == null;
                if (!flag)
                  enumerator1.Dispose();
              }
              _param0.SaveChanges();
              *(sbyte*) voidPtr = (sbyte) 1;
              goto label_27;
            case DialogResult.No:
              enumerator1 = objectStateEntries1.GetEnumerator();
              try
              {
                while (true)
                {
                  flag = enumerator1.MoveNext();
                  if (flag)
                  {
                    current = enumerator1.Current;
                    flag = current.State != EntityState.Modified && current.State != EntityState.Deleted;
                    if (!flag)
                    {
                      _param0.Refresh(RefreshMode.StoreWins, current.Entity);
                    }
                    else
                    {
                      flag = current.State != EntityState.Added;
                      if (!flag)
                        _param0.Detach(current.Entity);
                    }
                  }
                  else
                    break;
                }
              }
              finally
              {
                flag = enumerator1 == null;
                if (!flag)
                  enumerator1.Dispose();
              }
              *(sbyte*) voidPtr = (sbyte) 1;
              goto label_27;
          }
        }
        *(sbyte*) voidPtr = (sbyte) 1;
label_27:
        *(sbyte*) ((IntPtr) voidPtr + 1) = *(sbyte*) voidPtr;
      }
      catch (Exception ex)
      {
        IEnumerable<ObjectStateEntry> objectStateEntries2 = objectStateEntries1;
        // ISSUE: variable of a boxed type
        __Boxed<DialogResult> local1 = (Enum) dialogResult1;
        ObjectStateEntry objectStateEntry = current;
        object obj = entity;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local2 = (ValueType) (bool) *(sbyte*) voidPtr;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local3 = (ValueType) flag;
        // ISSUE: variable of a boxed type
        __Boxed<DialogResult> local4 = (Enum) dialogResult2;
        IEnumerator<ObjectStateEntry> enumerator2 = enumerator1;
        CanDienTuEntities canDienTuEntities = _param0;
        \u0005.\u0008.\u0001(ex, (object) objectStateEntries2, (object) local1, (object) objectStateEntry, obj, (object) local2, (object) local3, (object) local4, (object) enumerator2, (object) canDienTuEntities);
        throw;
      }
      return (bool) *(sbyte*) ((IntPtr) voidPtr + 1);
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

    public static string \u0001(string _param0)
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
        lower = BitConverter.ToString(\u0004.\u0005.\u0001(_param0)).Replace(\u0005.\u0004.\u0001(715), \u0005.\u0004.\u0001(720)).ToLower();
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
  }
}
