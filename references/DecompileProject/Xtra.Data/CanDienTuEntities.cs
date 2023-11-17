// Decompiled with JetBrains decompiler
// Type: Xtra.Data.CanDienTuEntities
// Assembly: Xtra.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9ECEE879-7EA6-4124-AFF1-825108ED52BD
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Data.dll

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Linq;
using System.Reflection;

namespace Xtra.Data
{
  public class CanDienTuEntities : ObjectContext
  {
    private ObjectSet<Xtra.Data.HangHoa> \u0001;
    private ObjectSet<Xtra.Data.KhachHang> \u0002;
    private ObjectSet<Xtra.Data.PassWord> \u0003;
    private ObjectSet<Xtra.Data.XeHang> \u0004;

    public override unsafe int SaveChanges(SaveOptions options)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(5);
      IEnumerable<ObjectStateEntry> objectStateEntries = this.ObjectStateManager.GetObjectStateEntries(EntityState.Deleted);
      do
      {
        IEnumerator<ObjectStateEntry> enumerator1 = objectStateEntries.GetEnumerator();
        try
        {
          while (true)
          {
            *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) enumerator1.MoveNext();
            if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
            {
              ObjectStateEntry current = enumerator1.Current;
            }
            else
              break;
          }
        }
        finally
        {
          *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (enumerator1 == null);
          if (*(sbyte*) ((IntPtr) voidPtr + 4) == (sbyte) 0)
            enumerator1.Dispose();
        }
        IEnumerator<ObjectStateEntry> enumerator2 = this.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified).GetEnumerator();
        try
        {
          string message;
          while (true)
          {
            *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) enumerator2.MoveNext();
            if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
            {
              ObjectStateEntry current = enumerator2.Current;
              *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (current.Entity == null);
              if (*(sbyte*) ((IntPtr) voidPtr + 4) == (sbyte) 0)
              {
                int num = ((IEnumerable<PropertyInfo>) current.Entity.GetType().GetProperties()).Any<PropertyInfo>() ? 1 : 0;
                if (true)
                {
                  string empty;
                  if (num == 0)
                    empty = string.Empty;
                  else if (!((IEnumerable<PropertyInfo>) current.Entity.GetType().GetProperties()).ToList<PropertyInfo>().Where<PropertyInfo>((Func<PropertyInfo, bool>) (_param0 => _param0.Name == \u0002.\u0001.\u0001(419))).Any<PropertyInfo>())
                  {
                    if (true)
                      empty = string.Empty;
                    else
                      goto label_20;
                  }
                  else
                    empty = ((IEnumerable<PropertyInfo>) current.Entity.GetType().GetProperties()).ToList<PropertyInfo>().Where<PropertyInfo>((Func<PropertyInfo, bool>) (_param0 => _param0.Name == \u0002.\u0001.\u0001(419))).First<PropertyInfo>().GetValue(current.Entity, (object[]) null).ToString();
                  message = empty;
                  *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) !(message != string.Empty);
                  num = (int) *(sbyte*) ((IntPtr) voidPtr + 4);
                }
                if (num == 0)
                  break;
label_20:;
              }
            }
            else
              goto label_26;
          }
          throw new ArgumentException(message);
        }
        finally
        {
          *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (enumerator2 == null);
          if (*(sbyte*) ((IntPtr) voidPtr + 4) == (sbyte) 0)
            enumerator2.Dispose();
        }
label_26:
        *(int*) voidPtr = base.SaveChanges(options);
      }
      while (false);
      return *(int*) voidPtr;
    }

    public CanDienTuEntities()
      : base(\u0002.\u0001.\u0001(313), \u0002.\u0001.\u0001(346))
    {
      this.ContextOptions.LazyLoadingEnabled = true;
    }

    public CanDienTuEntities(string connectionString)
      : base(connectionString, \u0002.\u0001.\u0001(346))
    {
      this.ContextOptions.LazyLoadingEnabled = true;
    }

    public CanDienTuEntities(EntityConnection connection)
      : base(connection, \u0002.\u0001.\u0001(346))
    {
      this.ContextOptions.LazyLoadingEnabled = true;
    }

    public ObjectSet<Xtra.Data.HangHoa> HangHoa
    {
      get
      {
        int num = this.\u0001 != null ? 1 : 0;
        bool flag;
        if (true)
          flag = num != 0;
        if (!flag)
          this.\u0001 = this.CreateObjectSet<Xtra.Data.HangHoa>(\u0002.\u0001.\u0001(371));
        return this.\u0001;
      }
    }

    public ObjectSet<Xtra.Data.KhachHang> KhachHang
    {
      get
      {
        int num = this.\u0002 != null ? 1 : 0;
        bool flag;
        if (true)
          flag = num != 0;
        if (!flag)
          this.\u0002 = this.CreateObjectSet<Xtra.Data.KhachHang>(\u0002.\u0001.\u0001(384));
        return this.\u0002;
      }
    }

    public ObjectSet<Xtra.Data.PassWord> PassWord
    {
      get
      {
        int num = this.\u0003 != null ? 1 : 0;
        bool flag;
        if (true)
          flag = num != 0;
        if (!flag)
          this.\u0003 = this.CreateObjectSet<Xtra.Data.PassWord>(\u0002.\u0001.\u0001(397));
        return this.\u0003;
      }
    }

    public ObjectSet<Xtra.Data.XeHang> XeHang
    {
      get
      {
        int num = this.\u0004 != null ? 1 : 0;
        bool flag;
        if (true)
          flag = num != 0;
        if (!flag)
          this.\u0004 = this.CreateObjectSet<Xtra.Data.XeHang>(\u0002.\u0001.\u0001(410));
        return this.\u0004;
      }
    }

    public void AddToHangHoa(Xtra.Data.HangHoa hangHoa) => this.AddObject(\u0002.\u0001.\u0001(371), (object) hangHoa);

    public void AddToKhachHang(Xtra.Data.KhachHang khachHang) => this.AddObject(\u0002.\u0001.\u0001(384), (object) khachHang);

    public void AddToPassWord(Xtra.Data.PassWord passWord) => this.AddObject(\u0002.\u0001.\u0001(397), (object) passWord);

    public void AddToXeHang(Xtra.Data.XeHang xeHang) => this.AddObject(\u0002.\u0001.\u0001(410), (object) xeHang);
  }
}
