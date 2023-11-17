// Decompiled with JetBrains decompiler
// Type: Xtra.Data.KhachHang
// Assembly: Xtra.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9ECEE879-7EA6-4124-AFF1-825108ED52BD
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Data.dll

using \u0002;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Text;

namespace Xtra.Data
{
  [DataContract(IsReference = true)]
  [EdmEntityType(NamespaceName = "CanDienTuModel", Name = "KhachHang")]
  [Serializable]
  public class KhachHang : EntityObject, IDataErrorInfo, INotifyPropertyChanged
  {
    private Guid _Id;
    private string _MaSo;
    private string _Ten;
    private string _DiaChi;

    public string Error
    {
      get
      {
        string error;
        int num1;
        if (true)
        {
          if (true)
          {
            int num2;
            if (this.EntityState == EntityState.Added)
              num2 = 0;
            else
              goto label_17;
label_7:
            do
              ;
            while (false);
            if (num2 != 0)
            {
              error = string.Empty;
              goto label_15;
            }
            else
              goto label_19;
label_17:
            int num3 = this.EntityState == EntityState.Modified ? 1 : 0;
            if (true)
            {
              if (true)
              {
                num2 = num3 == 0 ? 1 : 0;
                goto label_7;
              }
              else
              {
                num2 = num3;
                goto label_7;
              }
            }
            else
              num1 = num3;
          }
          else
            goto label_15;
        }
        else
          goto label_19;
label_8:
        StringBuilder stringBuilder;
        if (num1 == 0)
          stringBuilder.AppendLine(this[\u0001.\u0001(150)]);
        bool flag = string.IsNullOrWhiteSpace(this[\u0001.\u0001(201)]);
        if (true)
        {
          if (!flag)
            stringBuilder.AppendLine(this[\u0001.\u0001(201)]);
          string str = stringBuilder.ToString();
          error = !string.IsNullOrWhiteSpace(str) ? str : string.Empty;
        }
label_15:
        return error;
label_19:
        stringBuilder = new StringBuilder();
        num1 = string.IsNullOrWhiteSpace(this[\u0001.\u0001(150)]) ? 1 : 0;
        goto label_8;
      }
    }

    public string this[string columnName]
    {
      get
      {
        int num1;
        if (this.EntityState == EntityState.Added)
        {
          if (true)
          {
            num1 = 0;
            goto label_24;
          }
        }
        else
          goto label_23;
label_16:
        num1 = (int) byte.MaxValue;
        string str1;
        if (num1 != 0)
          str1 = \u0001.\u0001(num1);
        else
          goto label_24;
label_18:
        string str2 = str1;
label_22:
        return str2;
label_23:
        num1 = this.EntityState != EntityState.Modified ? 1 : 0;
label_24:
        if (num1 != 0)
        {
          if (true)
          {
            str2 = string.Empty;
            goto label_22;
          }
          else
            goto label_22;
        }
        else
        {
          string str3 = columnName;
          if (str3 != null)
          {
            int num2;
            string str4;
            if (!(str3 == \u0001.\u0001(150)))
            {
              if (!(str3 == \u0001.\u0001(201)))
              {
                if (false)
                  goto label_19;
                else
                  goto label_19;
              }
              else
              {
                int num3 = string.IsNullOrWhiteSpace(this.MaSo) ? 1 : 0;
                if (false)
                  num2 = num3;
                else if (num3 == 0)
                {
                  str1 = string.Empty;
                  goto label_18;
                }
                else
                  goto label_16;
              }
            }
            else if (!string.IsNullOrWhiteSpace(this.Ten))
            {
              if (true)
              {
                str4 = string.Empty;
                goto label_12;
              }
              else
                goto label_22;
            }
            else
              num2 = 210;
            str4 = \u0001.\u0001(num2);
label_12:
            str2 = str4;
            goto label_22;
          }
label_19:
          str2 = string.Empty;
          goto label_22;
        }
      }
    }

    public static KhachHang CreateKhachHang(Guid id, string maSo, string ten)
    {
      KhachHang khachHang1;
      if (true)
      {
        if (false)
          ;
        KhachHang khachHang2 = new KhachHang();
        if (true)
          goto label_7;
label_2:
        KhachHang khachHang3;
        while (true)
        {
          khachHang3.Id = id;
          KhachHang khachHang4 = khachHang3;
          string str = maSo;
          if (true)
            goto label_9;
label_3:
          if (true)
          {
            khachHang3.Ten = ten;
            break;
          }
          continue;
label_9:
          khachHang4.MaSo = str;
          goto label_3;
        }
        khachHang1 = khachHang3;
        goto label_5;
label_7:
        khachHang3 = khachHang2;
        goto label_2;
      }
label_5:
      return khachHang1;
    }

    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
    [DataMember]
    public Guid Id
    {
      get => this._Id;
      set
      {
        int num = this._Id != value ? 1 : 0;
        if (true)
        {
          bool flag = num == 0;
          if (true)
            num = flag ? 1 : 0;
          else
            goto label_7;
        }
        if (num != 0)
          goto label_5;
label_3:
        if (false)
          goto label_8;
        else
          goto label_7;
label_5:
        if (true)
          return;
        goto label_3;
label_7:
        this.ReportPropertyChanging(\u0001.\u0001(196));
label_8:
        this._Id = StructuralObject.SetValidValue(value);
        this.ReportPropertyChanged(\u0001.\u0001(196));
        goto label_5;
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public string MaSo
    {
      get => this._MaSo;
      set
      {
label_0:
        if (true)
          goto label_4;
label_2:
        if (true)
        {
          this.ReportPropertyChanged(\u0001.\u0001(201));
          if (true)
            return;
          goto label_0;
        }
label_4:
        do
        {
          string property = \u0001.\u0001(201);
          if (true)
            goto label_5;
label_1:
          continue;
label_5:
          this.ReportPropertyChanging(property);
          goto label_1;
        }
        while (false);
        this._MaSo = StructuralObject.SetValidValue(value, false);
        goto label_2;
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public string Ten
    {
      get => this._Ten;
      set
      {
label_0:
        if (true)
          goto label_4;
label_2:
        if (true)
        {
          this.ReportPropertyChanged(\u0001.\u0001(150));
          if (true)
            return;
          goto label_0;
        }
label_4:
        do
        {
          string property = \u0001.\u0001(150);
          if (true)
            goto label_5;
label_1:
          continue;
label_5:
          this.ReportPropertyChanging(property);
          goto label_1;
        }
        while (false);
        this._Ten = StructuralObject.SetValidValue(value, false);
        goto label_2;
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public string DiaChi
    {
      get => this._DiaChi;
      set
      {
label_0:
        if (true)
          goto label_4;
label_2:
        if (true)
        {
          this.ReportPropertyChanged(\u0001.\u0001(304));
          if (true)
            return;
          goto label_0;
        }
label_4:
        do
        {
          string property = \u0001.\u0001(304);
          if (true)
            goto label_5;
label_1:
          continue;
label_5:
          this.ReportPropertyChanging(property);
          goto label_1;
        }
        while (false);
        this._DiaChi = StructuralObject.SetValidValue(value, true);
        goto label_2;
      }
    }
  }
}
