// Decompiled with JetBrains decompiler
// Type: Xtra.Data.XeHang
// Assembly: Xtra.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9ECEE879-7EA6-4124-AFF1-825108ED52BD
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Data.dll

using \u0002;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Xml.Serialization;

namespace Xtra.Data
{
  [EdmEntityType(NamespaceName = "CanDienTuModel", Name = "XeHang")]
  [DataContract(IsReference = true)]
  [Serializable]
  public class XeHang : EntityObject, IDataErrorInfo, INotifyPropertyChanged
  {
    private PropertyChangedEventHandler PropertyChanged;
    private Guid _Id;
    private int _SoChungTu;
    private string _SoXe;
    private double _TLXeHang;
    private double _TLXe;
    private double _TapChat;
    private int _SoBao;
    private double _TLHang;
    private double _TLTapChat;
    private double _TLBao;
    private double _TLTruBi;
    private double _TLSach;
    private int? _Gia30;
    private DateTime? _Ngay;
    private DateTime? _GioXeHang;
    private DateTime? _GioXe;
    private Guid _HangHoaID;
    private double _GiaMua;
    private string _DiaChi;
    private string _TenKH;
    private Guid _KhachHangID;
    private string _GhiChu;

    public string kieuCan
    {
      get
      {
        DateTime? nullable = this.GioXeHang;
        int num1;
        if (!nullable.HasValue)
        {
          num1 = 1;
        }
        else
        {
          nullable = this.GioXe;
          num1 = !nullable.HasValue ? 1 : 0;
        }
        bool flag = num1 != 0;
label_2:
        if (!flag)
        {
          if (true)
            nullable = this.GioXeHang;
          else
            goto label_15;
        }
        else
          goto label_16;
label_5:
        DateTime? gioXe = this.GioXe;
        int num2;
        if (nullable.HasValue & gioXe.HasValue)
        {
          num2 = nullable.GetValueOrDefault() < gioXe.GetValueOrDefault() ? 1 : 0;
          goto label_8;
        }
label_6:
        num2 = 0;
label_8:
        int num3;
        if (num2 == 0)
          num3 = 536;
        else
          goto label_11;
label_10:
        string str = \u0001.\u0001(num3);
        goto label_14;
label_11:
        if (true)
        {
          num3 = 553;
          if (num3 != 0)
            str = \u0001.\u0001(num3);
          else
            goto label_10;
        }
        else
          goto label_2;
label_14:
        string kieuCan = str;
label_15:
        if (false)
          goto label_6;
        else
          goto label_17;
label_16:
        kieuCan = \u0001.\u0001(570);
        if (false)
          goto label_5;
label_17:
        return kieuCan;
      }
    }

    public double ThanhTien
    {
      get
      {
        do
          ;
        while (false);
        double tlSach = this.TLSach;
        if (true)
          goto label_6;
label_3:
        return false ? tlSach : tlSach;
label_6:
        double num = this.GiaMua;
        if (true)
          num = num;
        tlSach *= num;
        goto label_3;
      }
    }

    private void OnTLSachChanged()
    {
      if (false)
        goto label_2;
label_1:
      if (true)
        this.NotifyPropertyChanged(\u0001.\u0001(571));
      else
        goto label_4;
label_2:
      if (true)
        this.NotifyPropertyChanged(\u0001.\u0001(584));
label_4:
      if (false)
        goto label_1;
    }

    private void OnGiaMuaChanged() => this.NotifyPropertyChanged(\u0001.\u0001(571));

    private void OnTLTapChatChanged()
    {
      if (true)
      {
        if (true)
        {
          this.TLSach = this.TLHang - (this.TLTapChat + this.TLTruBi);
          goto label_5;
        }
        else
          goto label_5;
      }
label_3:
      if (true)
        return;
label_5:
      this.NotifyPropertyChanged(\u0001.\u0001(601));
      goto label_3;
    }

    private void OnTLTruBiChanged()
    {
      this.TLTapChat = Math.Round((this.TLHang - this.TLTruBi) * this.TapChat / 100.0);
      this.NotifyPropertyChanged(\u0001.\u0001(610));
      this.TLSach = this.TLHang - (this.TLTapChat + this.TLTruBi);
      this.NotifyPropertyChanged(\u0001.\u0001(601));
    }

    private void OnSoBaoChanged()
    {
      do
      {
        do
        {
          this.TLTruBi = Math.Round((double) this.SoBao * this.TLBao / 1000.0);
        }
        while (false);
        this.NotifyPropertyChanged(\u0001.\u0001(623));
      }
      while (false);
    }

    private void OnTLBaoChanged()
    {
      do
      {
        do
        {
          this.TLTruBi = Math.Round((double) this.SoBao * this.TLBao / 1000.0);
        }
        while (false);
        this.NotifyPropertyChanged(\u0001.\u0001(623));
      }
      while (false);
    }

    public unsafe double round(double value, int fractionDigits)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(16);
      *(double*) voidPtr = Math.Pow(10.0, (double) fractionDigits);
      *(double*) ((IntPtr) voidPtr + 8) = Math.Round(value * *(double*) voidPtr) / *(double*) voidPtr;
      return *(double*) ((IntPtr) voidPtr + 8);
    }

    private void OnTLHangChanged()
    {
      this.TLTapChat = Math.Round((this.TLHang - this.TLTruBi) * this.TapChat / 100.0);
      this.NotifyPropertyChanged(\u0001.\u0001(610));
      this.TLSach = this.TLHang - (this.TLTapChat + this.TLTruBi);
      this.NotifyPropertyChanged(\u0001.\u0001(601));
    }

    private void OnTapChatChanged()
    {
      while (true)
      {
        this.TLTapChat = Math.Round((this.TLHang - this.TLTruBi) * this.TapChat / 100.0);
        if (false)
          break;
        if (true)
        {
          this.NotifyPropertyChanged(\u0001.\u0001(610));
          break;
        }
      }
    }

    private void OnTLXeHangChanged()
    {
label_9:
      this.GioXeHang = new DateTime?(DateTime.Now);
label_10:
      this.NotifyPropertyChanged(\u0001.\u0001(636));
      if (true)
      {
        do
        {
          if (this.TLXe > 0.0 && this.TLXeHang > 0.0)
          {
            this.TLHang = this.TLXeHang - this.TLXe;
            do
              ;
            while (false);
            this.NotifyPropertyChanged(\u0001.\u0001(649));
            if (false)
              goto label_10;
          }
          else
          {
            if (false)
              ;
            this.TLHang = 0.0;
            this.NotifyPropertyChanged(\u0001.\u0001(649));
          }
          if (false)
            goto label_10;
        }
        while (false);
      }
      else
        goto label_9;
    }

    private void OnTLXeChanged()
    {
label_9:
      this.GioXe = new DateTime?(DateTime.Now);
label_10:
      this.NotifyPropertyChanged(\u0001.\u0001(658));
      if (true)
      {
        do
        {
          if (this.TLXe > 0.0 && this.TLXeHang > 0.0)
          {
            this.TLHang = this.TLXeHang - this.TLXe;
            do
              ;
            while (false);
            this.NotifyPropertyChanged(\u0001.\u0001(649));
            if (false)
              goto label_10;
          }
          else
          {
            if (false)
              ;
            this.TLHang = 0.0;
            this.NotifyPropertyChanged(\u0001.\u0001(649));
          }
          if (false)
            goto label_10;
        }
        while (false);
      }
      else
        goto label_9;
    }

    private void OnHangHoaIDChanged() => this.NotifyPropertyChanged(\u0001.\u0001(571));

    private void OnKhachHangIDChanged()
    {
      if (false)
        goto label_9;
      else
        goto label_13;
label_7:
      KhachHang khachHang1;
      if (khachHang1 != null)
        this.TenKH = khachHang1.Ten;
      else
        goto label_12;
label_9:
      this.DiaChi = khachHang1.DiaChi;
      this.NotifyPropertyChanged(\u0001.\u0001(571));
      while (true)
      {
        if (true)
          goto label_12;
      }
      goto label_7;
label_12:
      return;
label_13:
      CanDienTuEntities canDienTuEntities1 = new CanDienTuEntities();
      if (true)
        goto label_14;
label_2:
      bool flag;
      if (true)
      {
        int num1 = this.KhachHangID != Guid.Empty ? 1 : 0;
        int num2;
        while (true)
        {
          num2 = num1 == 0 ? 1 : 0;
          if (false)
            num1 = num2;
          else if (false)
            num1 = num2;
          else
            break;
        }
        flag = num2 != 0;
      }
      if (flag)
        return;
      CanDienTuEntities canDienTuEntities2;
      khachHang1 = canDienTuEntities2.KhachHang.Where<KhachHang>((Expression<Func<KhachHang, bool>>) (khachHang => khachHang.Id == this.KhachHangID)).FirstOrDefault<KhachHang>();
      goto label_7;
label_14:
      canDienTuEntities2 = canDienTuEntities1;
      goto label_2;
    }

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
        if (!string.IsNullOrWhiteSpace(this[\u0001.\u0001(672)]))
          stringBuilder.AppendLine(this[\u0001.\u0001(672)]);
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
        if (false)
          goto label_11;
        else
          goto label_10;
label_1:
        string str1;
        string str2;
        if (str1 == \u0001.\u0001(672))
        {
          str2 = this.HangHoa == null ? \u0001.\u0001(685) : string.Empty;
          goto label_9;
        }
label_3:
        str2 = string.Empty;
label_9:
        return str2;
label_10:
        while (this.EntityState != EntityState.Added && this.EntityState != EntityState.Modified)
        {
          if (true)
          {
            if (true)
            {
              if (true)
              {
                if (true)
                {
                  str2 = string.Empty;
                  goto label_9;
                }
                else
                  goto label_9;
              }
              else
                goto label_3;
            }
            else
              goto label_1;
          }
        }
label_11:
        str1 = columnName;
        if (str1 == null)
          goto label_3;
        else
          goto label_1;
      }
    }

    public new event PropertyChangedEventHandler PropertyChanged
    {
      add
      {
        do
        {
          PropertyChangedEventHandler changedEventHandler1 = this.PropertyChanged;
label_8:
          PropertyChangedEventHandler comparand = changedEventHandler1;
label_9:
          PropertyChangedEventHandler changedEventHandler2 = comparand + value;
          if (true)
          {
            changedEventHandler1 = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, changedEventHandler2, comparand);
            do
            {
              if (true)
              {
                int num = changedEventHandler1 == comparand ? 1 : 0;
                if (true)
                  num = num == 0 ? 1 : 0;
                if (num != 0)
                  goto label_8;
              }
              else
                goto label_9;
            }
            while (false);
          }
        }
        while (false);
      }
      remove
      {
        do
        {
          PropertyChangedEventHandler changedEventHandler1 = this.PropertyChanged;
label_8:
          PropertyChangedEventHandler comparand = changedEventHandler1;
label_9:
          PropertyChangedEventHandler changedEventHandler2 = comparand - value;
          if (true)
          {
            changedEventHandler1 = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, changedEventHandler2, comparand);
            do
            {
              if (true)
              {
                int num = changedEventHandler1 == comparand ? 1 : 0;
                if (true)
                  num = num == 0 ? 1 : 0;
                if (num != 0)
                  goto label_8;
              }
              else
                goto label_9;
            }
            while (false);
          }
        }
        while (false);
      }
    }

    public void NotifyPropertyChanged(string info)
    {
      if (true)
        goto label_5;
label_2:
      do
      {
        this.PropertyChanged((object) this, new PropertyChangedEventArgs(info));
      }
      while (false);
      return;
label_5:
      int num = this.PropertyChanged == null ? 1 : 0;
      if (true)
        goto label_6;
label_1:
      if (num != 0)
        return;
      goto label_2;
label_6:
      num = num != 0 ? 1 : 0;
      goto label_1;
    }

    public static XeHang CreateXeHang(
      Guid id,
      int soChungTu,
      double tLXeHang,
      double tLXe,
      double tapChat,
      int soBao,
      double tLHang,
      double tLTapChat,
      double tLBao,
      double tLTruBi,
      double tLSach,
      Guid hangHoaID,
      double giaMua,
      Guid khachHangID)
    {
      XeHang xeHang1 = new XeHang();
      xeHang1.Id = id;
      if (false)
        goto label_3;
      else
        goto label_6;
label_2:
      xeHang1.TLHang = tLHang;
label_3:
      xeHang1.TLTapChat = tLTapChat;
      xeHang1.TLBao = tLBao;
label_4:
      xeHang1.TLTruBi = tLTruBi;
      xeHang1.TLSach = tLSach;
      xeHang1.HangHoaID = hangHoaID;
      xeHang1.GiaMua = giaMua;
      if (true)
      {
        xeHang1.KhachHangID = khachHangID;
        return xeHang1;
      }
      goto label_2;
label_6:
      XeHang xeHang2 = xeHang1;
      int num = soChungTu;
      if (true)
        goto label_7;
label_1:
      if (true)
      {
        xeHang1.TLXeHang = tLXeHang;
        xeHang1.TLXe = tLXe;
        xeHang1.TapChat = tapChat;
        xeHang1.SoBao = soBao;
        goto label_2;
      }
      else
        goto label_4;
label_7:
      xeHang2.SoChungTu = num;
      goto label_1;
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

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public int SoChungTu
    {
      get => this._SoChungTu;
      set
      {
        do
        {
          if (true)
            goto label_5;
label_2:
          if (true)
            goto label_7;
label_4:
          continue;
label_7:
          this.ReportPropertyChanged(\u0001.\u0001(718));
          goto label_4;
label_5:
          this.ReportPropertyChanging(\u0001.\u0001(718));
          if (true)
          {
            this._SoChungTu = StructuralObject.SetValidValue(value);
            goto label_2;
          }
          else
            goto label_2;
        }
        while (false);
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public string SoXe
    {
      get => this._SoXe;
      set
      {
label_0:
        if (true)
          goto label_4;
label_2:
        if (true)
        {
          this.ReportPropertyChanged(\u0001.\u0001(731));
          if (true)
            return;
          goto label_0;
        }
label_4:
        do
        {
          string property = \u0001.\u0001(731);
          if (true)
            goto label_5;
label_1:
          continue;
label_5:
          this.ReportPropertyChanging(property);
          goto label_1;
        }
        while (false);
        this._SoXe = StructuralObject.SetValidValue(value, true);
        goto label_2;
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public double TLXeHang
    {
      get => this._TLXeHang;
      set
      {
        if (false)
          goto label_3;
        else
          goto label_6;
label_1:
        if (true)
        {
          this._TLXeHang = StructuralObject.SetValidValue(value);
          this.ReportPropertyChanged(\u0001.\u0001(740));
        }
        else
          goto label_4;
label_3:
label_4:
        do
        {
          this.OnTLXeHangChanged();
        }
        while (false);
        if (true)
          return;
        goto label_1;
label_6:
        this.ReportPropertyChanging(\u0001.\u0001(740));
        goto label_1;
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public double TLXe
    {
      get => this._TLXe;
      set
      {
        if (false)
          goto label_3;
        else
          goto label_6;
label_1:
        if (true)
        {
          this._TLXe = StructuralObject.SetValidValue(value);
          this.ReportPropertyChanged(\u0001.\u0001(753));
        }
        else
          goto label_4;
label_3:
label_4:
        do
        {
          this.OnTLXeChanged();
        }
        while (false);
        if (true)
          return;
        goto label_1;
label_6:
        this.ReportPropertyChanging(\u0001.\u0001(753));
        goto label_1;
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public double TapChat
    {
      get => this._TapChat;
      set
      {
        if (false)
          goto label_3;
        else
          goto label_6;
label_1:
        if (true)
        {
          this._TapChat = StructuralObject.SetValidValue(value);
          this.ReportPropertyChanged(\u0001.\u0001(762));
        }
        else
          goto label_4;
label_3:
label_4:
        do
        {
          this.OnTapChatChanged();
        }
        while (false);
        if (true)
          return;
        goto label_1;
label_6:
        this.ReportPropertyChanging(\u0001.\u0001(762));
        goto label_1;
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public int SoBao
    {
      get => this._SoBao;
      set
      {
        if (false)
          goto label_3;
        else
          goto label_6;
label_1:
        if (true)
        {
          this._SoBao = StructuralObject.SetValidValue(value);
          this.ReportPropertyChanged(\u0001.\u0001(775));
        }
        else
          goto label_4;
label_3:
label_4:
        do
        {
          this.OnSoBaoChanged();
        }
        while (false);
        if (true)
          return;
        goto label_1;
label_6:
        this.ReportPropertyChanging(\u0001.\u0001(775));
        goto label_1;
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public double TLHang
    {
      get => this._TLHang;
      set
      {
        if (false)
          goto label_3;
        else
          goto label_6;
label_1:
        if (true)
        {
          this._TLHang = StructuralObject.SetValidValue(value);
          this.ReportPropertyChanged(\u0001.\u0001(649));
        }
        else
          goto label_4;
label_3:
label_4:
        do
        {
          this.OnTLHangChanged();
        }
        while (false);
        if (true)
          return;
        goto label_1;
label_6:
        this.ReportPropertyChanging(\u0001.\u0001(649));
        goto label_1;
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public double TLTapChat
    {
      get => this._TLTapChat;
      set
      {
        if (false)
          goto label_3;
        else
          goto label_6;
label_1:
        if (true)
        {
          this._TLTapChat = StructuralObject.SetValidValue(value);
          this.ReportPropertyChanged(\u0001.\u0001(610));
        }
        else
          goto label_4;
label_3:
label_4:
        do
        {
          this.OnTLTapChatChanged();
        }
        while (false);
        if (true)
          return;
        goto label_1;
label_6:
        this.ReportPropertyChanging(\u0001.\u0001(610));
        goto label_1;
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public double TLBao
    {
      get => this._TLBao;
      set
      {
        if (false)
          goto label_3;
        else
          goto label_6;
label_1:
        if (true)
        {
          this._TLBao = StructuralObject.SetValidValue(value);
          this.ReportPropertyChanged(\u0001.\u0001(784));
        }
        else
          goto label_4;
label_3:
label_4:
        do
        {
          this.OnTLBaoChanged();
        }
        while (false);
        if (true)
          return;
        goto label_1;
label_6:
        this.ReportPropertyChanging(\u0001.\u0001(784));
        goto label_1;
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public double TLTruBi
    {
      get => this._TLTruBi;
      set
      {
        if (false)
          goto label_3;
        else
          goto label_6;
label_1:
        if (true)
        {
          this._TLTruBi = StructuralObject.SetValidValue(value);
          this.ReportPropertyChanged(\u0001.\u0001(623));
        }
        else
          goto label_4;
label_3:
label_4:
        do
        {
          this.OnTLTruBiChanged();
        }
        while (false);
        if (true)
          return;
        goto label_1;
label_6:
        this.ReportPropertyChanging(\u0001.\u0001(623));
        goto label_1;
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public double TLSach
    {
      get => this._TLSach;
      set
      {
        if (false)
          goto label_3;
        else
          goto label_6;
label_1:
        if (true)
        {
          this._TLSach = StructuralObject.SetValidValue(value);
          this.ReportPropertyChanged(\u0001.\u0001(601));
        }
        else
          goto label_4;
label_3:
label_4:
        do
        {
          this.OnTLSachChanged();
        }
        while (false);
        if (true)
          return;
        goto label_1;
label_6:
        this.ReportPropertyChanging(\u0001.\u0001(601));
        goto label_1;
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public int? Gia30
    {
      get => this._Gia30;
      set
      {
        do
        {
          if (true)
            goto label_5;
label_2:
          if (true)
            goto label_7;
label_4:
          continue;
label_7:
          this.ReportPropertyChanged(\u0001.\u0001(793));
          goto label_4;
label_5:
          this.ReportPropertyChanging(\u0001.\u0001(793));
          if (true)
          {
            this._Gia30 = StructuralObject.SetValidValue(value);
            goto label_2;
          }
          else
            goto label_2;
        }
        while (false);
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public DateTime? Ngay
    {
      get => this._Ngay;
      set
      {
        do
        {
          if (true)
            goto label_5;
label_2:
          if (true)
            goto label_7;
label_4:
          continue;
label_7:
          this.ReportPropertyChanged(\u0001.\u0001(802));
          goto label_4;
label_5:
          this.ReportPropertyChanging(\u0001.\u0001(802));
          if (true)
          {
            this._Ngay = StructuralObject.SetValidValue(value);
            goto label_2;
          }
          else
            goto label_2;
        }
        while (false);
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    public DateTime? GioXeHang
    {
      get => this._GioXeHang;
      set
      {
        do
        {
          if (true)
            goto label_5;
label_2:
          if (true)
            goto label_7;
label_4:
          continue;
label_7:
          this.ReportPropertyChanged(\u0001.\u0001(636));
          goto label_4;
label_5:
          this.ReportPropertyChanging(\u0001.\u0001(636));
          if (true)
          {
            this._GioXeHang = StructuralObject.SetValidValue(value);
            goto label_2;
          }
          else
            goto label_2;
        }
        while (false);
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public DateTime? GioXe
    {
      get => this._GioXe;
      set
      {
        do
        {
          if (true)
            goto label_5;
label_2:
          if (true)
            goto label_7;
label_4:
          continue;
label_7:
          this.ReportPropertyChanged(\u0001.\u0001(658));
          goto label_4;
label_5:
          this.ReportPropertyChanging(\u0001.\u0001(658));
          if (true)
          {
            this._GioXe = StructuralObject.SetValidValue(value);
            goto label_2;
          }
          else
            goto label_2;
        }
        while (false);
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public Guid HangHoaID
    {
      get => this._HangHoaID;
      set
      {
        if (false)
          goto label_3;
        else
          goto label_6;
label_1:
        if (true)
        {
          this._HangHoaID = StructuralObject.SetValidValue(value);
          this.ReportPropertyChanged(\u0001.\u0001(672));
        }
        else
          goto label_4;
label_3:
label_4:
        do
        {
          this.OnHangHoaIDChanged();
        }
        while (false);
        if (true)
          return;
        goto label_1;
label_6:
        this.ReportPropertyChanging(\u0001.\u0001(672));
        goto label_1;
      }
    }

    [DataMember]
    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    public double GiaMua
    {
      get => this._GiaMua;
      set
      {
        if (false)
          goto label_3;
        else
          goto label_6;
label_1:
        if (true)
        {
          this._GiaMua = StructuralObject.SetValidValue(value);
          this.ReportPropertyChanged(\u0001.\u0001(811));
        }
        else
          goto label_4;
label_3:
label_4:
        do
        {
          this.OnGiaMuaChanged();
        }
        while (false);
        if (true)
          return;
        goto label_1;
label_6:
        this.ReportPropertyChanging(\u0001.\u0001(811));
        goto label_1;
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
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

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public string TenKH
    {
      get => this._TenKH;
      set
      {
label_0:
        if (true)
          goto label_4;
label_2:
        if (true)
        {
          this.ReportPropertyChanged(\u0001.\u0001(820));
          if (true)
            return;
          goto label_0;
        }
label_4:
        do
        {
          string property = \u0001.\u0001(820);
          if (true)
            goto label_5;
label_1:
          continue;
label_5:
          this.ReportPropertyChanging(property);
          goto label_1;
        }
        while (false);
        this._TenKH = StructuralObject.SetValidValue(value, true);
        goto label_2;
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
    [DataMember]
    public Guid KhachHangID
    {
      get => this._KhachHangID;
      set
      {
        if (false)
          goto label_3;
        else
          goto label_6;
label_1:
        if (true)
        {
          this._KhachHangID = StructuralObject.SetValidValue(value);
          this.ReportPropertyChanged(\u0001.\u0001(829));
        }
        else
          goto label_4;
label_3:
label_4:
        do
        {
          this.OnKhachHangIDChanged();
        }
        while (false);
        if (true)
          return;
        goto label_1;
label_6:
        this.ReportPropertyChanging(\u0001.\u0001(829));
        goto label_1;
      }
    }

    [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
    [DataMember]
    public string GhiChu
    {
      get => this._GhiChu;
      set
      {
label_0:
        if (true)
          goto label_4;
label_2:
        if (true)
        {
          this.ReportPropertyChanged(\u0001.\u0001(846));
          if (true)
            return;
          goto label_0;
        }
label_4:
        do
        {
          string property = \u0001.\u0001(846);
          if (true)
            goto label_5;
label_1:
          continue;
label_5:
          this.ReportPropertyChanging(property);
          goto label_1;
        }
        while (false);
        this._GhiChu = StructuralObject.SetValidValue(value, true);
        goto label_2;
      }
    }

    [XmlIgnore]
    [EdmRelationshipNavigationProperty("CanDienTuModel", "FK_HangHoaXeHang", "HangHoa")]
    [SoapIgnore]
    [DataMember]
    public HangHoa HangHoa
    {
      get
      {
        HangHoa hangHoa;
        do
        {
          if (true)
          {
            if (true)
              hangHoa = ((IEntityWithRelationships) this).RelationshipManager.GetRelatedReference<HangHoa>(\u0001.\u0001(491), \u0001.\u0001(371)).Value;
          }
        }
        while (false);
        return hangHoa;
      }
      set
      {
        if (false)
          ;
        do
        {
          if (true)
            goto label_4;
label_3:
          continue;
label_4:
          ((IEntityWithRelationships) this).RelationshipManager.GetRelatedReference<HangHoa>(\u0001.\u0001(491), \u0001.\u0001(371)).Value = value;
          if (true)
            goto label_3;
        }
        while (false);
      }
    }

    [Browsable(false)]
    [DataMember]
    public EntityReference<HangHoa> HangHoaReference
    {
      get
      {
        do
          ;
        while (false);
        return ((IEntityWithRelationships) this).RelationshipManager.GetRelatedReference<HangHoa>(\u0001.\u0001(491), \u0001.\u0001(371));
      }
      set
      {
        do
        {
          if (value == null)
            goto label_4;
        }
        while (false);
        goto label_2;
label_4:
        return;
label_2:
        if (false)
          return;
        ((IEntityWithRelationships) this).RelationshipManager.InitializeRelatedReference<HangHoa>(\u0001.\u0001(491), \u0001.\u0001(371), value);
      }
    }
  }
}
