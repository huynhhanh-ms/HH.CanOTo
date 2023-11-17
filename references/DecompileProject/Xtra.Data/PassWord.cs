// Decompiled with JetBrains decompiler
// Type: Xtra.Data.PassWord
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
  [EdmEntityType(NamespaceName = "CanDienTuModel", Name = "PassWord")]
  [DataContract(IsReference = true)]
  [Serializable]
  public class PassWord : EntityObject, IDataErrorInfo, INotifyPropertyChanged
  {
    private Guid _Id;
    private string _Ten;

    public string Error
    {
      get
      {
        if (false)
          goto label_13;
        else
          goto label_10;
label_1:
        goto label_13;
label_6:
        string str1;
        string str2 = str1;
label_7:
        string error = str2;
        if (false)
          goto label_1;
label_9:
        return error;
label_10:
        int num = this.EntityState == EntityState.Added ? 0 : (this.EntityState != EntityState.Modified ? 1 : 0);
label_11:
        bool flag = num != 0;
        if (true)
        {
          if (flag)
          {
            error = string.Empty;
            goto label_9;
          }
          else
            goto label_1;
        }
        else
          goto label_6;
label_13:
        StringBuilder stringBuilder = new StringBuilder();
        if (!string.IsNullOrWhiteSpace(this[\u0001.\u0001(150)]))
          stringBuilder.AppendLine(this[\u0001.\u0001(150)]);
        str1 = stringBuilder.ToString();
        num = string.IsNullOrWhiteSpace(str1) ? 1 : 0;
        if (true)
        {
          if (num != 0)
          {
            str2 = string.Empty;
            goto label_7;
          }
          else
            goto label_6;
        }
        else
          goto label_11;
      }
    }

    public string this[string columnName]
    {
      get
      {
        if (this.EntityState == EntityState.Added)
          goto label_4;
        else
          goto label_21;
label_3:
        int num1;
        int num2;
        int num3;
        if (false)
        {
          num2 = num3;
          goto label_6;
        }
        else
        {
          num1 = num3;
          goto label_22;
        }
label_4:
        num1 = 0;
        goto label_22;
label_6:
        string str1;
        int num4;
        if (num2 == 0)
        {
          if (true)
          {
            string str2 = columnName;
            if (str2 != null)
              num4 = str2 == \u0001.\u0001(150) ? 1 : 0;
            else
              goto label_18;
          }
          else
            goto label_20;
        }
        else
        {
          str1 = string.Empty;
          goto label_20;
        }
label_11:
        if (num4 != 0)
        {
          num3 = string.IsNullOrWhiteSpace(this.Ten) ? 1 : 0;
          if (true)
          {
            string str3;
            if (num3 == 0)
            {
              str3 = string.Empty;
            }
            else
            {
              int num5 = 155;
              if (num5 == 0)
              {
                num3 = num5;
                goto label_3;
              }
              else
                str3 = \u0001.\u0001(num5);
            }
            str1 = str3;
            goto label_20;
          }
          else
            goto label_3;
        }
label_18:
        str1 = string.Empty;
label_20:
        return str1;
label_21:
        int num6 = this.EntityState == EntityState.Modified ? 1 : 0;
        if (true)
        {
          num3 = num6 == 0 ? 1 : 0;
          goto label_3;
        }
        else
        {
          num4 = num6;
          goto label_11;
        }
label_22:
        num2 = num1 != 0 ? 1 : 0;
        goto label_6;
      }
    }

    public static PassWord CreatePassWord(Guid id, string ten)
    {
      PassWord passWord1;
      if (true)
      {
        if (true)
        {
          passWord1 = new PassWord();
          passWord1.Id = id;
          if (true)
          {
            passWord1.Ten = ten;
            goto label_5;
          }
          else
            goto label_5;
        }
      }
      else
        goto label_5;
label_2:
      PassWord passWord2;
      return passWord2;
label_5:
      passWord2 = passWord1;
      goto label_2;
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = true, IsNullable = false)]
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

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
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
  }
}
