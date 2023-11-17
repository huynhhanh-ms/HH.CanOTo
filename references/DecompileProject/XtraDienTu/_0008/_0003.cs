// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Xtra.Data;

namespace \u0008
{
  internal class \u0003 : XtraReport
  {
    private IContainer \u0001 = (IContainer) null;
    private DetailBand \u0002;
    private TopMarginBand \u0003;
    private BottomMarginBand \u0004;
    private ReportHeaderBand \u0005;
    private XRLabel \u0006;
    private XRLabel \u0007;
    private XRLabel \u0008;
    private XRLabel \u000E;
    private XRLabel \u000F;
    private Parameter \u0010;
    private Parameter \u0011;
    private Parameter \u0012;
    private XRLabel \u0013;
    private XRLabel \u0014;
    private XRLabel \u0015;
    private XRLabel \u0016;
    private XRLabel \u0017;
    private XRLabel \u0018;
    private XRLabel \u0019;
    private XRLabel \u001A;
    private XRLabel \u001B;
    private XRLabel \u001C;
    private XRLabel \u001D;
    private XRLabel \u001E;
    private XRLabel \u001F;
    private XRLabel \u007F;
    private XRLabel \u0080;
    private XRLabel \u0081;
    private XRLabel \u0082;
    private XRLabel \u0083;
    private XRLabel \u0084;
    private XRLabel \u0086;
    private BindingSource \u0087;
    private Parameter \u0088;
    private XRLabel \u0089;
    private XRLabel \u008A;
    private XRLabel \u008B;
    private XRLabel \u008C;
    private XRLabel \u008D;
    private XRLabel \u008E;
    private XRLabel \u008F;
    private XRLabel \u0090;
    private Parameter \u0091;
    private XRLabel \u0092;
    private GroupHeaderBand \u0093;
    private XRLabel \u0094;
    private XRLabel \u0095;
    private XRLabel \u0096;
    private XRLabel \u0097;
    private XRLabel \u0098;
    private XRLabel \u0099;
    private XRLabel \u009A;
    private XRLabel \u009B;
    private XRLabel \u009C;
    private XRLabel \u009D;
    private XRLabel \u009E;
    private XRLabel \u009F;
    private XRLabel \u0001\u0002;
    private XRLabel \u0002\u0002;
    private XRLabel \u0003\u0002;
    private XRLabel \u0004\u0002;
    private XRLabel \u0005\u0002;
    private XRLabel \u0006\u0002;
    private XRLabel \u0007\u0002;
    private XRLabel \u0008\u0002;
    private XRLabel \u000E\u0002;
    private XRLabel \u000F\u0002;
    private XRLabel \u0010\u0002;
    private XRLabel \u0011\u0002;
    private XRLabel \u0012\u0002;
    private XRLabel \u0013\u0002;
    private XRLabel \u0014\u0002;
    private XRLabel \u0015\u0002;
    private XRLabel \u0016\u0002;
    private XRLabel \u0017\u0002;
    private XRLabel \u0018\u0002;
    private XRLabel \u0019\u0002;
    private XRLabel \u001A\u0002;
    private XRLabel \u001B\u0002;
    private XRLabel \u001C\u0002;
    private XRLabel \u001D\u0002;
    private XRLabel \u001E\u0002;
    private XRLabel \u001F\u0002;
    private XRLabel \u007F\u0002;
    private XRLabel \u0080\u0002;
    private XRLabel \u0081\u0002;
    private XRLabel \u0082\u0002;
    private XRLabel \u0083\u0002;
    private XRLabel \u0084\u0002;
    private XRLabel \u0086\u0002;
    private XRLabel \u0087\u0002;
    private XRLabel \u0088\u0002;
    private XRLabel \u0089\u0002;
    private XRLabel \u008A\u0002;
    private XRLabel \u008B\u0002;
    private XRLabel \u008C\u0002;
    private XRLabel \u008D\u0002;
    private XRLabel \u008E\u0002;
    private XRLabel \u008F\u0002;
    private XRLabel \u0090\u0002;
    private XRLabel \u0091\u0002;
    private XRLabel \u0092\u0002;
    private XRLabel \u0093\u0002;
    private XRLabel \u0094\u0002;
    private XRLabel \u0095\u0002;
    private XRLabel \u0096\u0002;
    private XRLabel \u0097\u0002;
    private XRLabel \u0098\u0002;
    private XRLabel \u0099\u0002;
    private XRLabel \u009A\u0002;
    private XRLabel \u009B\u0002;

    public \u0003()
    {
      \u0001.\u0002 obj1;
      bool flag;
      try
      {
        this.\u0001();
        obj1 = new \u0001.\u0002();
        flag = !(obj1.InKieuCan == \u0005.\u0004.\u0001(3771));
        if (!flag)
        {
          this.\u007F.Visible = true;
          this.\u0081\u0002.Visible = true;
          this.\u0088\u0002.Visible = true;
          this.\u0014.Visible = true;
        }
        else
        {
          this.\u007F.Visible = false;
          this.\u0081\u0002.Visible = false;
          this.\u0088\u0002.Visible = false;
          this.\u0014.Visible = false;
        }
      }
      catch (Exception ex)
      {
        \u0001.\u0002 obj2 = obj1;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (ValueType) flag;
        \u0005.\u0008.\u0001(ex, (object) obj2, (object) local, (object) this);
        throw;
      }
    }

    virtual void XtraReport.\u0001(bool _param1)
    {
      bool flag;
      try
      {
        do
        {
          if (_param1)
            goto label_10;
label_1:
          int num1 = 1;
          goto label_11;
label_4:
          int num2;
          if (num2 == 0)
          {
            if (true)
              this.\u0001.Dispose();
            else
              continue;
          }
          else
            goto label_7;
label_6:
          if (false)
            goto label_1;
label_7:
          if (true)
          {
            // ISSUE: explicit non-virtual call
            __nonvirtual (((XtraReport) this).Dispose(_param1));
            continue;
          }
          goto label_6;
label_10:
          int num3 = this.\u0001 == null ? 1 : 0;
          if (false)
          {
            num2 = num3;
            goto label_4;
          }
          else
            num1 = num3;
label_11:
          flag = num1 != 0;
          num2 = flag ? 1 : 0;
          goto label_4;
        }
        while (false);
      }
      catch (Exception ex)
      {
        // ISSUE: variable of a boxed type
        __Boxed<bool> local1 = (ValueType) flag;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local2 = (ValueType) _param1;
        \u0005.\u0008.\u0001(ex, (object) local1, (object) this, (object) local2);
        throw;
      }
    }

    private void \u0001()
    {
      XRControl[] xrControlArray1;
      XRBinding[] xrBindingArray1;
      Band[] bandArray1;
      Parameter[] parameterArray1;
      try
      {
        this.\u0001 = (IContainer) new System.ComponentModel.Container();
        this.\u0002 = new DetailBand();
        this.\u0003 = new TopMarginBand();
        this.\u0004 = new BottomMarginBand();
        this.\u0005 = new ReportHeaderBand();
        this.\u0090 = new XRLabel();
        this.\u0091 = new Parameter();
        this.\u008C = new XRLabel();
        this.\u008D = new XRLabel();
        this.\u008E = new XRLabel();
        this.\u008F = new XRLabel();
        this.\u008A = new XRLabel();
        this.\u008B = new XRLabel();
        this.\u0088 = new Parameter();
        this.\u0010 = new Parameter();
        this.\u0011 = new Parameter();
        this.\u0012 = new Parameter();
        this.\u0089 = new XRLabel();
        this.\u0080 = new XRLabel();
        this.\u0081 = new XRLabel();
        this.\u0082 = new XRLabel();
        this.\u0083 = new XRLabel();
        this.\u0084 = new XRLabel();
        this.\u0086 = new XRLabel();
        this.\u007F = new XRLabel();
        this.\u001C = new XRLabel();
        this.\u001D = new XRLabel();
        this.\u001E = new XRLabel();
        this.\u001F = new XRLabel();
        this.\u001B = new XRLabel();
        this.\u001A = new XRLabel();
        this.\u0019 = new XRLabel();
        this.\u0018 = new XRLabel();
        this.\u0014 = new XRLabel();
        this.\u0015 = new XRLabel();
        this.\u0016 = new XRLabel();
        this.\u0013 = new XRLabel();
        this.\u000E = new XRLabel();
        this.\u000F = new XRLabel();
        this.\u0006 = new XRLabel();
        this.\u0007 = new XRLabel();
        this.\u0008 = new XRLabel();
        this.\u0017 = new XRLabel();
        this.\u0087 = new BindingSource(this.\u0001);
        this.\u0092 = new XRLabel();
        this.\u0093 = new GroupHeaderBand();
        this.\u0096 = new XRLabel();
        this.\u0095 = new XRLabel();
        this.\u0094 = new XRLabel();
        this.\u0097 = new XRLabel();
        this.\u009E = new XRLabel();
        this.\u009D = new XRLabel();
        this.\u009C = new XRLabel();
        this.\u009B = new XRLabel();
        this.\u009A = new XRLabel();
        this.\u0099 = new XRLabel();
        this.\u0098 = new XRLabel();
        this.\u0005\u0002 = new XRLabel();
        this.\u0004\u0002 = new XRLabel();
        this.\u0003\u0002 = new XRLabel();
        this.\u0002\u0002 = new XRLabel();
        this.\u0001\u0002 = new XRLabel();
        this.\u009F = new XRLabel();
        this.\u009B\u0002 = new XRLabel();
        this.\u009A\u0002 = new XRLabel();
        this.\u0099\u0002 = new XRLabel();
        this.\u0098\u0002 = new XRLabel();
        this.\u0097\u0002 = new XRLabel();
        this.\u0096\u0002 = new XRLabel();
        this.\u0095\u0002 = new XRLabel();
        this.\u0094\u0002 = new XRLabel();
        this.\u0093\u0002 = new XRLabel();
        this.\u0092\u0002 = new XRLabel();
        this.\u0091\u0002 = new XRLabel();
        this.\u0090\u0002 = new XRLabel();
        this.\u008F\u0002 = new XRLabel();
        this.\u008E\u0002 = new XRLabel();
        this.\u008D\u0002 = new XRLabel();
        this.\u008C\u0002 = new XRLabel();
        this.\u008B\u0002 = new XRLabel();
        this.\u008A\u0002 = new XRLabel();
        this.\u0089\u0002 = new XRLabel();
        this.\u0088\u0002 = new XRLabel();
        this.\u0087\u0002 = new XRLabel();
        this.\u0086\u0002 = new XRLabel();
        this.\u0084\u0002 = new XRLabel();
        this.\u0083\u0002 = new XRLabel();
        this.\u0082\u0002 = new XRLabel();
        this.\u0081\u0002 = new XRLabel();
        this.\u0080\u0002 = new XRLabel();
        this.\u007F\u0002 = new XRLabel();
        this.\u001F\u0002 = new XRLabel();
        this.\u001E\u0002 = new XRLabel();
        this.\u001D\u0002 = new XRLabel();
        this.\u001C\u0002 = new XRLabel();
        this.\u001B\u0002 = new XRLabel();
        this.\u001A\u0002 = new XRLabel();
        this.\u0019\u0002 = new XRLabel();
        this.\u0018\u0002 = new XRLabel();
        this.\u0017\u0002 = new XRLabel();
        this.\u0016\u0002 = new XRLabel();
        this.\u0015\u0002 = new XRLabel();
        this.\u0014\u0002 = new XRLabel();
        this.\u0013\u0002 = new XRLabel();
        this.\u0012\u0002 = new XRLabel();
        this.\u0011\u0002 = new XRLabel();
        this.\u0010\u0002 = new XRLabel();
        this.\u000F\u0002 = new XRLabel();
        this.\u000E\u0002 = new XRLabel();
        this.\u0008\u0002 = new XRLabel();
        this.\u0007\u0002 = new XRLabel();
        this.\u0006\u0002 = new XRLabel();
        ((ISupportInitialize) this.\u0087).BeginInit();
        this.BeginInit();
        this.\u0002.HeightF = 17.70833f;
        this.\u0002.Name = \u0005.\u0004.\u0001(7309);
        this.\u0002.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
        this.\u0002.TextAlignment = TextAlignment.TopLeft;
        this.\u0003.HeightF = 13.08333f;
        this.\u0003.Name = \u0005.\u0004.\u0001(7318);
        this.\u0003.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
        this.\u0003.TextAlignment = TextAlignment.TopLeft;
        this.\u0004.HeightF = 18f;
        this.\u0004.Name = \u0005.\u0004.\u0001(7331);
        this.\u0004.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
        this.\u0004.TextAlignment = TextAlignment.TopLeft;
        XRControlCollection controls1 = this.\u0005.Controls;
        xrControlArray1 = new XRControl[99]
        {
          (XRControl) this.\u0006\u0002,
          (XRControl) this.\u0007\u0002,
          (XRControl) this.\u0008\u0002,
          (XRControl) this.\u000E\u0002,
          (XRControl) this.\u000F\u0002,
          (XRControl) this.\u0010\u0002,
          (XRControl) this.\u0011\u0002,
          (XRControl) this.\u0012\u0002,
          (XRControl) this.\u0013\u0002,
          (XRControl) this.\u0014\u0002,
          (XRControl) this.\u0015\u0002,
          (XRControl) this.\u0016\u0002,
          (XRControl) this.\u0017\u0002,
          (XRControl) this.\u0018\u0002,
          (XRControl) this.\u0019\u0002,
          (XRControl) this.\u001A\u0002,
          (XRControl) this.\u001B\u0002,
          (XRControl) this.\u001C\u0002,
          (XRControl) this.\u001D\u0002,
          (XRControl) this.\u001E\u0002,
          (XRControl) this.\u001F\u0002,
          (XRControl) this.\u007F\u0002,
          (XRControl) this.\u0080\u0002,
          (XRControl) this.\u0081\u0002,
          (XRControl) this.\u0082\u0002,
          (XRControl) this.\u0083\u0002,
          (XRControl) this.\u0084\u0002,
          (XRControl) this.\u0086\u0002,
          (XRControl) this.\u0087\u0002,
          (XRControl) this.\u0088\u0002,
          (XRControl) this.\u0089\u0002,
          (XRControl) this.\u008A\u0002,
          (XRControl) this.\u008B\u0002,
          (XRControl) this.\u008C\u0002,
          (XRControl) this.\u008D\u0002,
          (XRControl) this.\u008E\u0002,
          (XRControl) this.\u008F\u0002,
          (XRControl) this.\u0090\u0002,
          (XRControl) this.\u0091\u0002,
          (XRControl) this.\u0092\u0002,
          (XRControl) this.\u0093\u0002,
          (XRControl) this.\u0094\u0002,
          (XRControl) this.\u0095\u0002,
          (XRControl) this.\u0096\u0002,
          (XRControl) this.\u0097\u0002,
          (XRControl) this.\u0098\u0002,
          (XRControl) this.\u0099\u0002,
          (XRControl) this.\u009A\u0002,
          (XRControl) this.\u009B\u0002,
          (XRControl) this.\u009F,
          (XRControl) this.\u0001\u0002,
          (XRControl) this.\u0002\u0002,
          (XRControl) this.\u0003\u0002,
          (XRControl) this.\u0004\u0002,
          (XRControl) this.\u0005\u0002,
          (XRControl) this.\u0098,
          (XRControl) this.\u0099,
          (XRControl) this.\u009A,
          (XRControl) this.\u009B,
          (XRControl) this.\u009C,
          (XRControl) this.\u009D,
          (XRControl) this.\u009E,
          (XRControl) this.\u0097,
          (XRControl) this.\u0094,
          (XRControl) this.\u0095,
          (XRControl) this.\u0096,
          (XRControl) this.\u0090,
          (XRControl) this.\u008C,
          (XRControl) this.\u008D,
          (XRControl) this.\u008E,
          (XRControl) this.\u008F,
          (XRControl) this.\u008A,
          (XRControl) this.\u008B,
          (XRControl) this.\u0089,
          (XRControl) this.\u0080,
          (XRControl) this.\u0081,
          (XRControl) this.\u0082,
          (XRControl) this.\u0083,
          (XRControl) this.\u0084,
          (XRControl) this.\u0086,
          (XRControl) this.\u007F,
          (XRControl) this.\u001C,
          (XRControl) this.\u001D,
          (XRControl) this.\u001E,
          (XRControl) this.\u001F,
          (XRControl) this.\u001B,
          (XRControl) this.\u001A,
          (XRControl) this.\u0019,
          (XRControl) this.\u0018,
          (XRControl) this.\u0014,
          (XRControl) this.\u0015,
          (XRControl) this.\u0016,
          (XRControl) this.\u0013,
          (XRControl) this.\u000E,
          (XRControl) this.\u000F,
          (XRControl) this.\u0006,
          (XRControl) this.\u0007,
          (XRControl) this.\u0008,
          (XRControl) this.\u0017
        };
        XRControl[] controls2 = xrControlArray1;
        controls1.AddRange(controls2);
        this.\u0005.HeightF = 1072.958f;
        this.\u0005.Name = \u0005.\u0004.\u0001(7348);
        XRBindingCollection dataBindings1 = this.\u0090.DataBindings;
        xrBindingArray1 = new XRBinding[1]
        {
          new XRBinding(this.\u0091, \u0005.\u0004.\u0001(3154), \u0005.\u0004.\u0001(720))
        };
        XRBinding[] bindings1 = xrBindingArray1;
        dataBindings1.AddRange(bindings1);
        this.\u0090.Font = new Font(\u0005.\u0004.\u0001(7365), 12f);
        this.\u0090.LocationFloat = new PointFloat(10.0001f, 506.2084f);
        if (true)
        {
          this.\u0090.Name = \u0005.\u0004.\u0001(7386);
          this.\u0090.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u0090.SizeF = new SizeF(781.9999f, 30.29163f);
          this.\u0090.StylePriority.UseFont = false;
          this.\u0090.StylePriority.UseTextAlignment = false;
          this.\u0090.Text = \u0005.\u0004.\u0001(7386);
          this.\u0090.TextAlignment = TextAlignment.MiddleCenter;
          this.\u0091.Description = \u0005.\u0004.\u0001(7403);
          this.\u0091.Name = \u0005.\u0004.\u0001(7420);
          this.\u0091.ValueInfo = \u0005.\u0004.\u0001(7433);
          this.\u0091.Visible = false;
          this.\u008C.BorderDashStyle = BorderDashStyle.Dot;
          this.\u008C.Borders = BorderSide.None;
          XRBindingCollection dataBindings2 = this.\u008C.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(2123), \u0005.\u0004.\u0001(7474))
          };
          XRBinding[] bindings2 = xrBindingArray1;
          dataBindings2.AddRange(bindings2);
          this.\u008C.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u008C.LocationFloat = new PointFloat(595.8327f, 276.8473f);
          this.\u008C.Multiline = true;
          this.\u008C.Name = \u0005.\u0004.\u0001(7491);
          this.\u008C.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u008C.SizeF = new SizeF(155.2087f, 23f);
          this.\u008C.StylePriority.UseBorderDashStyle = false;
          this.\u008C.StylePriority.UseBorders = false;
          this.\u008C.StylePriority.UseFont = false;
          this.\u008C.StylePriority.UseTextAlignment = false;
          this.\u008C.Text = \u0005.\u0004.\u0001(7504);
          this.\u008C.TextAlignment = TextAlignment.MiddleLeft;
          this.\u008D.BorderDashStyle = BorderDashStyle.Dot;
          this.\u008D.Borders = BorderSide.None;
          XRBindingCollection dataBindings3 = this.\u008D.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(2080), \u0005.\u0004.\u0001(7474))
          };
          XRBinding[] bindings3 = xrBindingArray1;
          dataBindings3.AddRange(bindings3);
          this.\u008D.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u008D.LocationFloat = new PointFloat(595.8327f, 253.2918f);
          this.\u008D.Multiline = true;
          this.\u008D.Name = \u0005.\u0004.\u0001(7525);
          this.\u008D.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u008D.SizeF = new SizeF(155.2087f, 23f);
          this.\u008D.StylePriority.UseBorderDashStyle = false;
          this.\u008D.StylePriority.UseBorders = false;
          this.\u008D.StylePriority.UseFont = false;
          this.\u008D.StylePriority.UseTextAlignment = false;
          this.\u008D.Text = \u0005.\u0004.\u0001(7504);
          this.\u008D.TextAlignment = TextAlignment.MiddleLeft;
          this.\u008E.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u008E.LocationFloat = new PointFloat(466.666f, 276.8473f);
          this.\u008E.Multiline = true;
          this.\u008E.Name = \u0005.\u0004.\u0001(7538);
          this.\u008E.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u008E.SizeF = new SizeF(95.83401f, 23f);
          this.\u008E.StylePriority.UseFont = false;
          this.\u008E.StylePriority.UseTextAlignment = false;
          this.\u008E.Text = \u0005.\u0004.\u0001(7551);
          this.\u008E.TextAlignment = TextAlignment.MiddleLeft;
          this.\u008F.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u008F.LocationFloat = new PointFloat(466.666f, 253.2918f);
          this.\u008F.Multiline = true;
          this.\u008F.Name = \u0005.\u0004.\u0001(7572);
          this.\u008F.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u008F.SizeF = new SizeF(95.83401f, 23f);
          this.\u008F.StylePriority.UseFont = false;
          this.\u008F.StylePriority.UseTextAlignment = false;
          this.\u008F.Text = \u0005.\u0004.\u0001(7585);
          this.\u008F.TextAlignment = TextAlignment.MiddleLeft;
          this.\u008A.BorderDashStyle = BorderDashStyle.Dot;
          this.\u008A.Borders = BorderSide.None;
          XRBindingCollection dataBindings4 = this.\u008A.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(2703))
          };
          XRBinding[] bindings4 = xrBindingArray1;
          dataBindings4.AddRange(bindings4);
          this.\u008A.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u008A.LocationFloat = new PointFloat(270.8329f, 323.112f);
          this.\u008A.Multiline = true;
          this.\u008A.Name = \u0005.\u0004.\u0001(7606);
          this.\u008A.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u008A.SizeF = new SizeF(480.2086f, 22.99997f);
          this.\u008A.StylePriority.UseBorderDashStyle = false;
          this.\u008A.StylePriority.UseBorders = false;
          this.\u008A.StylePriority.UseFont = false;
          this.\u008A.StylePriority.UseTextAlignment = false;
          this.\u008A.TextAlignment = TextAlignment.MiddleLeft;
          this.\u008B.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u008B.LocationFloat = new PointFloat(43.74962f, 323.112f);
          this.\u008B.Multiline = true;
          this.\u008B.Name = \u0005.\u0004.\u0001(7619);
          this.\u008B.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u008B.SizeF = new SizeF(88.54169f, 23f);
          this.\u008B.StylePriority.UseFont = false;
          this.\u008B.StylePriority.UseTextAlignment = false;
          this.\u008B.Text = \u0005.\u0004.\u0001(2690);
          this.\u008B.TextAlignment = TextAlignment.MiddleLeft;
          this.\u0088.Description = \u0005.\u0004.\u0001(7403);
          this.\u0088.Name = \u0005.\u0004.\u0001(7632);
          this.\u0088.Visible = false;
          this.\u0010.Description = \u0005.\u0004.\u0001(7403);
          this.\u0010.Name = \u0005.\u0004.\u0001(7641);
          this.\u0010.Visible = false;
          this.\u0011.Description = \u0005.\u0004.\u0001(7403);
          this.\u0011.Name = \u0005.\u0004.\u0001(2646);
          this.\u0011.Visible = false;
          this.\u0012.Description = \u0005.\u0004.\u0001(7403);
          this.\u0012.Name = \u0005.\u0004.\u0001(7650);
          this.\u0012.Visible = false;
          this.\u0089.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0089.LocationFloat = new PointFloat(312.5005f, 396.8215f);
          this.\u0089.Multiline = true;
          this.\u0089.Name = \u0005.\u0004.\u0001(7663);
          this.\u0089.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u0089.SizeF = new SizeF(125.0001f, 23f);
          this.\u0089.StylePriority.UseFont = false;
          this.\u0089.Text = \u0005.\u0004.\u0001(7676);
          this.\u0080.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0080.LocationFloat = new PointFloat(382.9163f, 300.528f);
          this.\u0080.Multiline = true;
          this.\u0080.Name = \u0005.\u0004.\u0001(7697);
          this.\u0080.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u0080.SizeF = new SizeF(41.66666f, 23f);
          this.\u0080.StylePriority.UseFont = false;
          this.\u0080.StylePriority.UseTextAlignment = false;
          this.\u0080.Text = \u0005.\u0004.\u0001(7710);
          this.\u0080.TextAlignment = TextAlignment.MiddleLeft;
          this.\u0081.BorderDashStyle = BorderDashStyle.Dot;
          this.\u0081.Borders = BorderSide.None;
          XRBindingCollection dataBindings5 = this.\u0081.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(1825))
          };
          XRBinding[] bindings5 = xrBindingArray1;
          dataBindings5.AddRange(bindings5);
          this.\u0081.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0081.LocationFloat = new PointFloat(270.8329f, 300.528f);
          this.\u0081.Multiline = true;
          this.\u0081.Name = \u0005.\u0004.\u0001(7715);
          this.\u0081.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u0081.SizeF = new SizeF(112.0834f, 23f);
          this.\u0081.StylePriority.UseBorderDashStyle = false;
          this.\u0081.StylePriority.UseBorders = false;
          this.\u0081.StylePriority.UseFont = false;
          this.\u0081.StylePriority.UseTextAlignment = false;
          this.\u0081.Text = \u0005.\u0004.\u0001(7728);
          this.\u0081.TextAlignment = TextAlignment.MiddleRight;
          this.\u0082.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0082.LocationFloat = new PointFloat(43.74962f, 300.1121f);
          this.\u0082.Multiline = true;
          this.\u0082.Name = \u0005.\u0004.\u0001(7745);
          this.\u0082.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u0082.SizeF = new SizeF(209.7915f, 23f);
          this.\u0082.StylePriority.UseFont = false;
          this.\u0082.StylePriority.UseTextAlignment = false;
          this.\u0082.Text = \u0005.\u0004.\u0001(7758);
          this.\u0082.TextAlignment = TextAlignment.MiddleJustify;
          this.\u0083.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0083.LocationFloat = new PointFloat(382.9163f, 276.8473f);
          this.\u0083.Multiline = true;
          this.\u0083.Name = \u0005.\u0004.\u0001(7791);
          this.\u0083.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u0083.SizeF = new SizeF(41.66666f, 23f);
          this.\u0083.StylePriority.UseFont = false;
          this.\u0083.StylePriority.UseTextAlignment = false;
          this.\u0083.Text = \u0005.\u0004.\u0001(7710);
          this.\u0083.TextAlignment = TextAlignment.MiddleLeft;
          this.\u0084.BorderDashStyle = BorderDashStyle.Dot;
          this.\u0084.Borders = BorderSide.None;
          XRBindingCollection dataBindings6 = this.\u0084.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(1700))
          };
          XRBinding[] bindings6 = xrBindingArray1;
          dataBindings6.AddRange(bindings6);
          this.\u0084.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0084.LocationFloat = new PointFloat(270.8329f, 276.8473f);
          this.\u0084.Multiline = true;
          this.\u0084.Name = \u0005.\u0004.\u0001(7804);
          this.\u0084.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u0084.SizeF = new SizeF(112.0834f, 23f);
          this.\u0084.StylePriority.UseBorderDashStyle = false;
          this.\u0084.StylePriority.UseBorders = false;
          this.\u0084.StylePriority.UseFont = false;
          this.\u0084.StylePriority.UseTextAlignment = false;
          this.\u0084.Text = \u0005.\u0004.\u0001(7728);
          this.\u0084.TextAlignment = TextAlignment.MiddleRight;
          this.\u0086.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0086.LocationFloat = new PointFloat(43.74962f, 276.6395f);
          this.\u0086.Multiline = true;
          this.\u0086.Name = \u0005.\u0004.\u0001(7817);
          this.\u0086.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u0086.SizeF = new SizeF(209.7916f, 23f);
          this.\u0086.StylePriority.UseFont = false;
          this.\u0086.StylePriority.UseTextAlignment = false;
          this.\u0086.Text = \u0005.\u0004.\u0001(7830);
          this.\u0086.TextAlignment = TextAlignment.MiddleJustify;
          this.\u007F.BorderDashStyle = BorderDashStyle.Dot;
          this.\u007F.Borders = BorderSide.None;
          XRBindingCollection dataBindings7 = this.\u007F.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(7859))
          };
          XRBinding[] bindings7 = xrBindingArray1;
          dataBindings7.AddRange(bindings7);
          this.\u007F.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u007F.LocationFloat = new PointFloat(595.8327f, 300.528f);
          this.\u007F.Multiline = true;
          this.\u007F.Name = \u0005.\u0004.\u0001(7872);
          this.\u007F.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u007F.SizeF = new SizeF(155.2087f, 23f);
          this.\u007F.StylePriority.UseBorderDashStyle = false;
          this.\u007F.StylePriority.UseBorders = false;
          this.\u007F.StylePriority.UseFont = false;
          this.\u007F.StylePriority.UseTextAlignment = false;
          this.\u007F.Text = \u0005.\u0004.\u0001(7885);
          this.\u007F.TextAlignment = TextAlignment.MiddleLeft;
          this.\u001C.BorderDashStyle = BorderDashStyle.Dot;
          this.\u001C.Borders = BorderSide.None;
          XRBindingCollection dataBindings8 = this.\u001C.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(1574))
          };
          XRBinding[] bindings8 = xrBindingArray1;
          dataBindings8.AddRange(bindings8);
          this.\u001C.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u001C.LocationFloat = new PointFloat(172.9161f, 181.7918f);
          this.\u001C.Multiline = true;
          this.\u001C.Name = \u0005.\u0004.\u0001(7906);
          this.\u001C.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u001C.SizeF = new SizeF(251.6668f, 25.49995f);
          this.\u001C.StylePriority.UseBorderDashStyle = false;
          this.\u001C.StylePriority.UseBorders = false;
          this.\u001C.StylePriority.UseFont = false;
          this.\u001C.StylePriority.UseTextAlignment = false;
          this.\u001C.Text = \u0005.\u0004.\u0001(7728);
          this.\u001C.TextAlignment = TextAlignment.MiddleLeft;
          this.\u001D.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u001D.LocationFloat = new PointFloat(43.74962f, 181.7918f);
          this.\u001D.Multiline = true;
          this.\u001D.Name = \u0005.\u0004.\u0001(7919);
          this.\u001D.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u001D.SizeF = new SizeF(115.6248f, 25.49995f);
          this.\u001D.StylePriority.UseFont = false;
          this.\u001D.StylePriority.UseTextAlignment = false;
          this.\u001D.Text = \u0005.\u0004.\u0001(7932);
          this.\u001D.TextAlignment = TextAlignment.MiddleLeft;
          this.\u001E.BorderDashStyle = BorderDashStyle.Dot;
          this.\u001E.Borders = BorderSide.None;
          XRBindingCollection dataBindings9 = this.\u001E.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(2668))
          };
          XRBinding[] bindings9 = xrBindingArray1;
          dataBindings9.AddRange(bindings9);
          this.\u001E.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u001E.LocationFloat = new PointFloat(172.9161f, 207.2918f);
          this.\u001E.Multiline = true;
          this.\u001E.Name = \u0005.\u0004.\u0001(7949);
          this.\u001E.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u001E.SizeF = new SizeF(251.6669f, 23f);
          this.\u001E.StylePriority.UseBorderDashStyle = false;
          this.\u001E.StylePriority.UseBorders = false;
          this.\u001E.StylePriority.UseFont = false;
          this.\u001E.StylePriority.UseTextAlignment = false;
          this.\u001E.Text = \u0005.\u0004.\u0001(7962);
          this.\u001E.TextAlignment = TextAlignment.MiddleLeft;
          this.\u001F.BorderDashStyle = BorderDashStyle.Dot;
          this.\u001F.Borders = BorderSide.None;
          XRBindingCollection dataBindings10 = this.\u001F.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(1525))
          };
          XRBinding[] bindings10 = xrBindingArray1;
          dataBindings10.AddRange(bindings10);
          this.\u001F.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u001F.LocationFloat = new PointFloat(595.8327f, 181.7918f);
          this.\u001F.Multiline = true;
          this.\u001F.Name = \u0005.\u0004.\u0001(7983);
          this.\u001F.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u001F.SizeF = new SizeF(155.2088f, 22.99998f);
          this.\u001F.StylePriority.UseBorderDashStyle = false;
          this.\u001F.StylePriority.UseBorders = false;
          this.\u001F.StylePriority.UseFont = false;
          this.\u001F.StylePriority.UseTextAlignment = false;
          this.\u001F.Text = \u0005.\u0004.\u0001(7996);
          this.\u001F.TextAlignment = TextAlignment.MiddleLeft;
          this.\u001B.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u001B.LocationFloat = new PointFloat(382.9163f, 253.2918f);
          this.\u001B.Multiline = true;
          this.\u001B.Name = \u0005.\u0004.\u0001(8017);
          this.\u001B.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u001B.SizeF = new SizeF(41.66666f, 23f);
          this.\u001B.StylePriority.UseFont = false;
          this.\u001B.StylePriority.UseTextAlignment = false;
          this.\u001B.Text = \u0005.\u0004.\u0001(7710);
          this.\u001B.TextAlignment = TextAlignment.MiddleLeft;
          this.\u001A.BorderDashStyle = BorderDashStyle.Dot;
          this.\u001A.Borders = BorderSide.None;
          XRBindingCollection dataBindings11 = this.\u001A.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(1661))
          };
          XRBinding[] bindings11 = xrBindingArray1;
          dataBindings11.AddRange(bindings11);
          this.\u001A.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u001A.LocationFloat = new PointFloat(270.8329f, 253.2918f);
          this.\u001A.Multiline = true;
          this.\u001A.Name = \u0005.\u0004.\u0001(8030);
          this.\u001A.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u001A.SizeF = new SizeF(112.0834f, 23f);
          this.\u001A.StylePriority.UseBorderDashStyle = false;
          this.\u001A.StylePriority.UseBorders = false;
          this.\u001A.StylePriority.UseFont = false;
          this.\u001A.StylePriority.UseTextAlignment = false;
          this.\u001A.Text = \u0005.\u0004.\u0001(7728);
          this.\u001A.TextAlignment = TextAlignment.MiddleRight;
          this.\u0019.BorderDashStyle = BorderDashStyle.Dot;
          this.\u0019.Borders = BorderSide.None;
          XRBindingCollection dataBindings12 = this.\u0019.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(1617))
          };
          XRBinding[] bindings12 = xrBindingArray1;
          dataBindings12.AddRange(bindings12);
          this.\u0019.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0019.LocationFloat = new PointFloat(172.9161f, 230.2917f);
          this.\u0019.Multiline = true;
          this.\u0019.Name = \u0005.\u0004.\u0001(8043);
          this.\u0019.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u0019.SizeF = new SizeF(251.6668f, 22.99998f);
          this.\u0019.StylePriority.UseBorderDashStyle = false;
          this.\u0019.StylePriority.UseBorders = false;
          this.\u0019.StylePriority.UseFont = false;
          this.\u0019.StylePriority.UseTextAlignment = false;
          this.\u0019.Text = \u0005.\u0004.\u0001(7728);
          this.\u0019.TextAlignment = TextAlignment.MiddleLeft;
          this.\u0018.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0018.LocationFloat = new PointFloat(580.2083f, 396.8215f);
          this.\u0018.Multiline = true;
          this.\u0018.Name = \u0005.\u0004.\u0001(8056);
          this.\u0018.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u0018.SizeF = new SizeF(125.0001f, 23f);
          this.\u0018.StylePriority.UseFont = false;
          this.\u0018.Text = \u0005.\u0004.\u0001(8069);
          this.\u0014.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0014.LocationFloat = new PointFloat(466.6662f, 300.528f);
          this.\u0014.Multiline = true;
          this.\u0014.Name = \u0005.\u0004.\u0001(8090);
          this.\u0014.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u0014.SizeF = new SizeF(91.66672f, 22.99998f);
          this.\u0014.StylePriority.UseFont = false;
          this.\u0014.StylePriority.UseTextAlignment = false;
          this.\u0014.Text = \u0005.\u0004.\u0001(8103);
          this.\u0014.TextAlignment = TextAlignment.MiddleLeft;
          this.\u0015.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0015.LocationFloat = new PointFloat(43.74962f, 230.8473f);
          this.\u0015.Multiline = true;
          this.\u0015.Name = \u0005.\u0004.\u0001(8124);
          this.\u0015.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u0015.SizeF = new SizeF(115.6248f, 23f);
          this.\u0015.StylePriority.UseFont = false;
          this.\u0015.StylePriority.UseTextAlignment = false;
          this.\u0015.Text = \u0005.\u0004.\u0001(1604);
          this.\u0015.TextAlignment = TextAlignment.MiddleLeft;
          this.\u0016.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0016.LocationFloat = new PointFloat(43.74962f, 253.8474f);
          this.\u0016.Multiline = true;
          this.\u0016.Name = \u0005.\u0004.\u0001(8137);
          this.\u0016.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u0016.SizeF = new SizeF(209.7916f, 23f);
          this.\u0016.StylePriority.UseFont = false;
          this.\u0016.StylePriority.UseTextAlignment = false;
          this.\u0016.Text = \u0005.\u0004.\u0001(8150);
          this.\u0016.TextAlignment = TextAlignment.MiddleJustify;
          this.\u0013.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0013.LocationFloat = new PointFloat(466.6662f, 181.7918f);
          this.\u0013.Multiline = true;
          this.\u0013.Name = \u0005.\u0004.\u0001(8195);
          this.\u0013.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u0013.SizeF = new SizeF(95.83389f, 22.99998f);
          this.\u0013.StylePriority.UseFont = false;
          this.\u0013.StylePriority.UseTextAlignment = false;
          this.\u0013.Text = \u0005.\u0004.\u0001(8208);
          this.\u0013.TextAlignment = TextAlignment.MiddleLeft;
          this.\u000E.Font = new Font(\u0005.\u0004.\u0001(7365), 17f, FontStyle.Bold);
          this.\u000E.LocationFloat = new PointFloat(230.6247f, 147.4168f);
          this.\u000E.Multiline = true;
          this.\u000E.Name = \u0005.\u0004.\u0001(8229);
          this.\u000E.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u000E.SizeF = new SizeF(300.0001f, 25.49996f);
          this.\u000E.StylePriority.UseFont = false;
          this.\u000E.StylePriority.UseTextAlignment = false;
          this.\u000E.Text = \u0005.\u0004.\u0001(8242);
          this.\u000E.TextAlignment = TextAlignment.MiddleCenter;
          XRBindingCollection dataBindings13 = this.\u000F.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(this.\u0088, \u0005.\u0004.\u0001(3154), \u0005.\u0004.\u0001(720))
          };
          XRBinding[] bindings13 = xrBindingArray1;
          dataBindings13.AddRange(bindings13);
          this.\u000F.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u000F.LocationFloat = new PointFloat(444.7914f, 357.155f);
          this.\u000F.Name = \u0005.\u0004.\u0001(8267);
          this.\u000F.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u000F.SizeF = new SizeF(290.625f, 23f);
          this.\u000F.StylePriority.UseFont = false;
          this.\u000F.StylePriority.UseTextAlignment = false;
          this.\u000F.Text = \u0005.\u0004.\u0001(8267);
          this.\u000F.TextAlignment = TextAlignment.MiddleCenter;
          XRBindingCollection dataBindings14 = this.\u0006.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(this.\u0010, \u0005.\u0004.\u0001(3154), \u0005.\u0004.\u0001(720))
          };
          XRBinding[] bindings14 = xrBindingArray1;
          dataBindings14.AddRange(bindings14);
          this.\u0006.Font = new Font(\u0005.\u0004.\u0001(7365), 15f, FontStyle.Bold);
          this.\u0006.LocationFloat = new PointFloat(10.00001f, 23.62512f);
          this.\u0006.Name = \u0005.\u0004.\u0001(8280);
          this.\u0006.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u0006.SizeF = new SizeF(360.4167f, 38.20836f);
          this.\u0006.StylePriority.UseFont = false;
          this.\u0006.StylePriority.UseTextAlignment = false;
          this.\u0006.Text = \u0005.\u0004.\u0001(8293);
          this.\u0006.TextAlignment = TextAlignment.MiddleLeft;
          XRBindingCollection dataBindings15 = this.\u0007.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(this.\u0011, \u0005.\u0004.\u0001(3154), \u0005.\u0004.\u0001(720))
          };
          XRBinding[] bindings15 = xrBindingArray1;
          dataBindings15.AddRange(bindings15);
          this.\u0007.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0007.LocationFloat = new PointFloat(10.00005f, 61.83348f);
          this.\u0007.Name = \u0005.\u0004.\u0001(8310);
          this.\u0007.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u0007.SizeF = new SizeF(360.4167f, 33.41665f);
          this.\u0007.StylePriority.UseFont = false;
          this.\u0007.StylePriority.UseTextAlignment = false;
          this.\u0007.Text = \u0005.\u0004.\u0001(8323);
          this.\u0007.TextAlignment = TextAlignment.MiddleLeft;
          XRBindingCollection dataBindings16 = this.\u0008.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(this.\u0012, \u0005.\u0004.\u0001(3154), \u0005.\u0004.\u0001(720))
          };
          XRBinding[] bindings16 = xrBindingArray1;
          dataBindings16.AddRange(bindings16);
          this.\u0008.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0008.LocationFloat = new PointFloat(10.00005f, 95.25013f);
          this.\u0008.Name = \u0005.\u0004.\u0001(8364);
          this.\u0008.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u0008.SizeF = new SizeF(360.4167f, 41.75002f);
          this.\u0008.StylePriority.UseFont = false;
          this.\u0008.StylePriority.UseTextAlignment = false;
          this.\u0008.Text = \u0005.\u0004.\u0001(8377);
          this.\u0008.TextAlignment = TextAlignment.MiddleLeft;
          this.\u0017.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0017.LocationFloat = new PointFloat(70.83362f, 396.8215f);
          this.\u0017.Multiline = true;
          this.\u0017.Name = \u0005.\u0004.\u0001(8414);
          this.\u0017.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u0017.SizeF = new SizeF(99.99997f, 23f);
          this.\u0017.StylePriority.UseFont = false;
          this.\u0017.Text = \u0005.\u0004.\u0001(8427);
          this.\u0087.DataSource = (object) typeof (XeHang);
          XRBindingCollection dataBindings17 = this.\u0092.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(this.\u0091, \u0005.\u0004.\u0001(3154), \u0005.\u0004.\u0001(720))
          };
          XRBinding[] bindings17 = xrBindingArray1;
          dataBindings17.AddRange(bindings17);
          this.\u0092.Font = new Font(\u0005.\u0004.\u0001(7365), 12f);
          this.\u0092.LocationFloat = new PointFloat(10.00001f, 0.0f);
          this.\u0092.Name = \u0005.\u0004.\u0001(8444);
          this.\u0092.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u0092.SizeF = new SizeF(781.9999f, 23f);
          this.\u0092.StylePriority.UseFont = false;
          this.\u0092.StylePriority.UseTextAlignment = false;
          this.\u0092.Text = \u0005.\u0004.\u0001(7386);
          this.\u0092.TextAlignment = TextAlignment.MiddleCenter;
          XRControlCollection controls3 = this.\u0093.Controls;
          xrControlArray1 = new XRControl[1]
          {
            (XRControl) this.\u0092
          };
          XRControl[] controls4 = xrControlArray1;
          controls3.AddRange(controls4);
          this.\u0093.HeightF = 27.08333f;
          this.\u0093.Name = \u0005.\u0004.\u0001(8461);
          this.\u0096.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0096.LocationFloat = new PointFloat(466.6662f, 204.7918f);
          this.\u0096.Multiline = true;
          this.\u0096.Name = \u0005.\u0004.\u0001(8478);
          this.\u0096.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u0096.SizeF = new SizeF(80.20834f, 22.99999f);
          this.\u0096.StylePriority.UseFont = false;
          this.\u0096.StylePriority.UseTextAlignment = false;
          this.\u0096.Text = \u0005.\u0004.\u0001(8491);
          this.\u0096.TextAlignment = TextAlignment.MiddleLeft;
          XRBindingCollection dataBindings18 = this.\u0095.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(2036), \u0005.\u0004.\u0001(8496))
          };
          XRBinding[] bindings18 = xrBindingArray1;
          dataBindings18.AddRange(bindings18);
          this.\u0095.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0095.LocationFloat = new PointFloat(595.8327f, 230.2917f);
          this.\u0095.Name = \u0005.\u0004.\u0001(8517);
          this.\u0095.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u0095.SizeF = new SizeF(155.2087f, 23f);
          this.\u0095.StylePriority.UseFont = false;
          this.\u0095.Text = \u0005.\u0004.\u0001(8517);
          this.\u0094.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0094.LocationFloat = new PointFloat(465.6246f, 230.2917f);
          this.\u0094.Multiline = true;
          this.\u0094.Name = \u0005.\u0004.\u0001(8530);
          this.\u0094.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u0094.SizeF = new SizeF(96.87537f, 22.99998f);
          this.\u0094.StylePriority.UseFont = false;
          this.\u0094.StylePriority.UseTextAlignment = false;
          this.\u0094.Text = \u0005.\u0004.\u0001(8543);
          this.\u0094.TextAlignment = TextAlignment.MiddleLeft;
          this.\u0097.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0097.LocationFloat = new PointFloat(43.74962f, 204.7918f);
          this.\u0097.Multiline = true;
          this.\u0097.Name = \u0005.\u0004.\u0001(8560);
          this.\u0097.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u0097.SizeF = new SizeF(115.6248f, 25.49995f);
          this.\u0097.StylePriority.UseFont = false;
          this.\u0097.StylePriority.UseTextAlignment = false;
          this.\u0097.Text = \u0005.\u0004.\u0001(8427);
          this.\u0097.TextAlignment = TextAlignment.MiddleLeft;
          this.\u009E.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u009E.LocationFloat = new PointFloat(159.3744f, 181.7918f);
          this.\u009E.Multiline = true;
          this.\u009E.Name = \u0005.\u0004.\u0001(8573);
          this.\u009E.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u009E.SizeF = new SizeF(15.62485f, 25.49995f);
          this.\u009E.StylePriority.UseFont = false;
          this.\u009E.StylePriority.UseTextAlignment = false;
          this.\u009E.Text = \u0005.\u0004.\u0001(8586);
          this.\u009E.TextAlignment = TextAlignment.MiddleLeft;
          this.\u009D.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u009D.LocationFloat = new PointFloat(159.3744f, 204.7918f);
          this.\u009D.Multiline = true;
          this.\u009D.Name = \u0005.\u0004.\u0001(8591);
          this.\u009D.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u009D.SizeF = new SizeF(15.62485f, 25.49995f);
          this.\u009D.StylePriority.UseFont = false;
          this.\u009D.StylePriority.UseTextAlignment = false;
          this.\u009D.Text = \u0005.\u0004.\u0001(8586);
          this.\u009D.TextAlignment = TextAlignment.MiddleLeft;
          this.\u009C.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u009C.LocationFloat = new PointFloat(159.3744f, 228.3474f);
          this.\u009C.Multiline = true;
          this.\u009C.Name = \u0005.\u0004.\u0001(8604);
          this.\u009C.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u009C.SizeF = new SizeF(15.62485f, 25.49995f);
          this.\u009C.StylePriority.UseFont = false;
          this.\u009C.StylePriority.UseTextAlignment = false;
          this.\u009C.Text = \u0005.\u0004.\u0001(8586);
          this.\u009C.TextAlignment = TextAlignment.MiddleLeft;
          this.\u009B.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u009B.LocationFloat = new PointFloat(253.5412f, 253.8474f);
          this.\u009B.Multiline = true;
          this.\u009B.Name = \u0005.\u0004.\u0001(8617);
          this.\u009B.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u009B.SizeF = new SizeF(15.62485f, 25.49995f);
          this.\u009B.StylePriority.UseFont = false;
          this.\u009B.StylePriority.UseTextAlignment = false;
          this.\u009B.Text = \u0005.\u0004.\u0001(8586);
          this.\u009B.TextAlignment = TextAlignment.MiddleLeft;
          this.\u009A.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u009A.LocationFloat = new PointFloat(253.5412f, 274.1395f);
          this.\u009A.Multiline = true;
          this.\u009A.Name = \u0005.\u0004.\u0001(8630);
          this.\u009A.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u009A.SizeF = new SizeF(15.62485f, 25.49995f);
          this.\u009A.StylePriority.UseFont = false;
          this.\u009A.StylePriority.UseTextAlignment = false;
          this.\u009A.Text = \u0005.\u0004.\u0001(8586);
          this.\u009A.TextAlignment = TextAlignment.MiddleLeft;
          this.\u0099.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0099.LocationFloat = new PointFloat(253.5412f, 300.528f);
          this.\u0099.Multiline = true;
          this.\u0099.Name = \u0005.\u0004.\u0001(8643);
          this.\u0099.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u0099.SizeF = new SizeF(15.62485f, 25.49995f);
          this.\u0099.StylePriority.UseFont = false;
          this.\u0099.StylePriority.UseTextAlignment = false;
          this.\u0099.Text = \u0005.\u0004.\u0001(8586);
          this.\u0099.TextAlignment = TextAlignment.MiddleLeft;
          this.\u0098.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0098.LocationFloat = new PointFloat(253.5412f, 323.1121f);
          this.\u0098.Multiline = true;
          this.\u0098.Name = \u0005.\u0004.\u0001(8656);
          this.\u0098.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
          this.\u0098.SizeF = new SizeF(15.62485f, 25.49995f);
          this.\u0098.StylePriority.UseFont = false;
          this.\u0098.StylePriority.UseTextAlignment = false;
          this.\u0098.Text = \u0005.\u0004.\u0001(8586);
          if (true)
          {
            this.\u0098.TextAlignment = TextAlignment.MiddleLeft;
            this.\u0005\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u0005\u0002.LocationFloat = new PointFloat(562.5f, 181.7918f);
            this.\u0005\u0002.Multiline = true;
            this.\u0005\u0002.Name = \u0005.\u0004.\u0001(8669);
            this.\u0005\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u0005\u0002.SizeF = new SizeF(15.62485f, 25.49995f);
            this.\u0005\u0002.StylePriority.UseFont = false;
            this.\u0005\u0002.StylePriority.UseTextAlignment = false;
            this.\u0005\u0002.Text = \u0005.\u0004.\u0001(8586);
            this.\u0005\u0002.TextAlignment = TextAlignment.MiddleLeft;
            this.\u0004\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u0004\u0002.LocationFloat = new PointFloat(562.4996f, 204.7918f);
            this.\u0004\u0002.Multiline = true;
            this.\u0004\u0002.Name = \u0005.\u0004.\u0001(8682);
            this.\u0004\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u0004\u0002.SizeF = new SizeF(15.62485f, 25.49995f);
            this.\u0004\u0002.StylePriority.UseFont = false;
            this.\u0004\u0002.StylePriority.UseTextAlignment = false;
            this.\u0004\u0002.Text = \u0005.\u0004.\u0001(8586);
            this.\u0004\u0002.TextAlignment = TextAlignment.MiddleLeft;
            this.\u0003\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u0003\u0002.LocationFloat = new PointFloat(562.4999f, 230.2917f);
            this.\u0003\u0002.Multiline = true;
            this.\u0003\u0002.Name = \u0005.\u0004.\u0001(8695);
            this.\u0003\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u0003\u0002.SizeF = new SizeF(15.62485f, 25.49995f);
            this.\u0003\u0002.StylePriority.UseFont = false;
            this.\u0003\u0002.StylePriority.UseTextAlignment = false;
            this.\u0003\u0002.Text = \u0005.\u0004.\u0001(8586);
            this.\u0003\u0002.TextAlignment = TextAlignment.MiddleLeft;
            this.\u0002\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u0002\u0002.LocationFloat = new PointFloat(562.4999f, 253.2918f);
            this.\u0002\u0002.Multiline = true;
            this.\u0002\u0002.Name = \u0005.\u0004.\u0001(8708);
            this.\u0002\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u0002\u0002.SizeF = new SizeF(15.62485f, 25.49995f);
            this.\u0002\u0002.StylePriority.UseFont = false;
            this.\u0002\u0002.StylePriority.UseTextAlignment = false;
            this.\u0002\u0002.Text = \u0005.\u0004.\u0001(8586);
            this.\u0002\u0002.TextAlignment = TextAlignment.MiddleLeft;
            this.\u0001\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u0001\u0002.LocationFloat = new PointFloat(562.5f, 274.1395f);
            this.\u0001\u0002.Multiline = true;
            this.\u0001\u0002.Name = \u0005.\u0004.\u0001(8721);
            this.\u0001\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u0001\u0002.SizeF = new SizeF(15.62485f, 25.49995f);
            this.\u0001\u0002.StylePriority.UseFont = false;
            this.\u0001\u0002.StylePriority.UseTextAlignment = false;
            this.\u0001\u0002.Text = \u0005.\u0004.\u0001(8586);
            this.\u0001\u0002.TextAlignment = TextAlignment.MiddleLeft;
            this.\u009F.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u009F.LocationFloat = new PointFloat(562.5f, 298.028f);
            this.\u009F.Multiline = true;
            this.\u009F.Name = \u0005.\u0004.\u0001(8734);
            this.\u009F.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u009F.SizeF = new SizeF(15.62485f, 25.49995f);
            this.\u009F.StylePriority.UseFont = false;
            this.\u009F.StylePriority.UseTextAlignment = false;
            this.\u009F.Text = \u0005.\u0004.\u0001(8586);
            this.\u009F.TextAlignment = TextAlignment.MiddleLeft;
            XRBindingCollection dataBindings19 = this.\u009B\u0002.DataBindings;
            xrBindingArray1 = new XRBinding[1]
            {
              new XRBinding(this.\u0010, \u0005.\u0004.\u0001(3154), \u0005.\u0004.\u0001(720))
            };
            XRBinding[] bindings19 = xrBindingArray1;
            dataBindings19.AddRange(bindings19);
            this.\u009B\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 15f, FontStyle.Bold);
            this.\u009B\u0002.LocationFloat = new PointFloat(10.00005f, 595.4163f);
            this.\u009B\u0002.Name = \u0005.\u0004.\u0001(8747);
            this.\u009B\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u009B\u0002.SizeF = new SizeF(360.4167f, 38.20836f);
            this.\u009B\u0002.StylePriority.UseFont = false;
            this.\u009B\u0002.StylePriority.UseTextAlignment = false;
            this.\u009B\u0002.Text = \u0005.\u0004.\u0001(8293);
            this.\u009B\u0002.TextAlignment = TextAlignment.MiddleLeft;
            XRBindingCollection dataBindings20 = this.\u009A\u0002.DataBindings;
            xrBindingArray1 = new XRBinding[1]
            {
              new XRBinding(this.\u0011, \u0005.\u0004.\u0001(3154), \u0005.\u0004.\u0001(720))
            };
            XRBinding[] bindings20 = xrBindingArray1;
            dataBindings20.AddRange(bindings20);
            this.\u009A\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u009A\u0002.LocationFloat = new PointFloat(10.0001f, 633.6247f);
            this.\u009A\u0002.Name = \u0005.\u0004.\u0001(8760);
            this.\u009A\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u009A\u0002.SizeF = new SizeF(360.4167f, 33.41665f);
            this.\u009A\u0002.StylePriority.UseFont = false;
            this.\u009A\u0002.StylePriority.UseTextAlignment = false;
            this.\u009A\u0002.Text = \u0005.\u0004.\u0001(8323);
            this.\u009A\u0002.TextAlignment = TextAlignment.MiddleLeft;
            XRBindingCollection dataBindings21 = this.\u0099\u0002.DataBindings;
            xrBindingArray1 = new XRBinding[1]
            {
              new XRBinding(this.\u0012, \u0005.\u0004.\u0001(3154), \u0005.\u0004.\u0001(720))
            };
            XRBinding[] bindings21 = xrBindingArray1;
            dataBindings21.AddRange(bindings21);
            this.\u0099\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u0099\u0002.LocationFloat = new PointFloat(10.0001f, 667.0413f);
            this.\u0099\u0002.Name = \u0005.\u0004.\u0001(8773);
            this.\u0099\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u0099\u0002.SizeF = new SizeF(360.4167f, 41.75002f);
            this.\u0099\u0002.StylePriority.UseFont = false;
            this.\u0099\u0002.StylePriority.UseTextAlignment = false;
            this.\u0099\u0002.Text = \u0005.\u0004.\u0001(8377);
            this.\u0099\u0002.TextAlignment = TextAlignment.MiddleLeft;
            this.\u0098\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u0098\u0002.LocationFloat = new PointFloat(70.83362f, 973.9048f);
            this.\u0098\u0002.Multiline = true;
            this.\u0098\u0002.Name = \u0005.\u0004.\u0001(8786);
            this.\u0098\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u0098\u0002.SizeF = new SizeF(99.99997f, 23f);
            this.\u0098\u0002.StylePriority.UseFont = false;
            this.\u0098\u0002.Text = \u0005.\u0004.\u0001(8427);
            XRBindingCollection dataBindings22 = this.\u0097\u0002.DataBindings;
            xrBindingArray1 = new XRBinding[1]
            {
              new XRBinding(this.\u0088, \u0005.\u0004.\u0001(3154), \u0005.\u0004.\u0001(720))
            };
            XRBinding[] bindings22 = xrBindingArray1;
            dataBindings22.AddRange(bindings22);
            this.\u0097\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u0097\u0002.LocationFloat = new PointFloat(444.7914f, 933.1967f);
            this.\u0097\u0002.Name = \u0005.\u0004.\u0001(8799);
            this.\u0097\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u0097\u0002.SizeF = new SizeF(291.6667f, 23f);
            this.\u0097\u0002.StylePriority.UseFont = false;
            this.\u0097\u0002.StylePriority.UseTextAlignment = false;
            this.\u0097\u0002.Text = \u0005.\u0004.\u0001(8267);
            this.\u0097\u0002.TextAlignment = TextAlignment.MiddleCenter;
            this.\u0096\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 17f, FontStyle.Bold);
            this.\u0096\u0002.LocationFloat = new PointFloat(230.6247f, 724.5001f);
            this.\u0096\u0002.Multiline = true;
            this.\u0096\u0002.Name = \u0005.\u0004.\u0001(8812);
            this.\u0096\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u0096\u0002.SizeF = new SizeF(300.0001f, 25.49996f);
            this.\u0096\u0002.StylePriority.UseFont = false;
            this.\u0096\u0002.StylePriority.UseTextAlignment = false;
            this.\u0096\u0002.Text = \u0005.\u0004.\u0001(8242);
            this.\u0096\u0002.TextAlignment = TextAlignment.MiddleCenter;
            this.\u0095\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u0095\u0002.LocationFloat = new PointFloat(466.6662f, 758.8751f);
            this.\u0095\u0002.Multiline = true;
            this.\u0095\u0002.Name = \u0005.\u0004.\u0001(8825);
            this.\u0095\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u0095\u0002.SizeF = new SizeF(95.83389f, 22.99998f);
            this.\u0095\u0002.StylePriority.UseFont = false;
            this.\u0095\u0002.StylePriority.UseTextAlignment = false;
            this.\u0095\u0002.Text = \u0005.\u0004.\u0001(8208);
            this.\u0095\u0002.TextAlignment = TextAlignment.MiddleLeft;
            this.\u0094\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u0094\u0002.LocationFloat = new PointFloat(43.74962f, 830.9307f);
            this.\u0094\u0002.Multiline = true;
            this.\u0094\u0002.Name = \u0005.\u0004.\u0001(8838);
            this.\u0094\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u0094\u0002.SizeF = new SizeF(209.7916f, 23f);
            this.\u0094\u0002.StylePriority.UseFont = false;
            this.\u0094\u0002.StylePriority.UseTextAlignment = false;
            this.\u0094\u0002.Text = \u0005.\u0004.\u0001(8150);
            this.\u0094\u0002.TextAlignment = TextAlignment.MiddleJustify;
            this.\u0093\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u0093\u0002.LocationFloat = new PointFloat(43.74962f, 807.9306f);
            this.\u0093\u0002.Multiline = true;
            this.\u0093\u0002.Name = \u0005.\u0004.\u0001(8851);
            this.\u0093\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u0093\u0002.SizeF = new SizeF(115.6248f, 23f);
            this.\u0093\u0002.StylePriority.UseFont = false;
            this.\u0093\u0002.StylePriority.UseTextAlignment = false;
            this.\u0093\u0002.Text = \u0005.\u0004.\u0001(1604);
            this.\u0093\u0002.TextAlignment = TextAlignment.MiddleLeft;
            this.\u0092\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u0092\u0002.LocationFloat = new PointFloat(466.6662f, 877.6113f);
            this.\u0092\u0002.Multiline = true;
            this.\u0092\u0002.Name = \u0005.\u0004.\u0001(8864);
            this.\u0092\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u0092\u0002.SizeF = new SizeF(91.66672f, 22.99998f);
            this.\u0092\u0002.StylePriority.UseFont = false;
            this.\u0092\u0002.StylePriority.UseTextAlignment = false;
            this.\u0092\u0002.Text = \u0005.\u0004.\u0001(8103);
            this.\u0092\u0002.TextAlignment = TextAlignment.MiddleLeft;
            this.\u0091\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u0091\u0002.LocationFloat = new PointFloat(580.2083f, 973.9048f);
            this.\u0091\u0002.Multiline = true;
            this.\u0091\u0002.Name = \u0005.\u0004.\u0001(8877);
            this.\u0091\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u0091\u0002.SizeF = new SizeF(125.0001f, 23f);
            this.\u0091\u0002.StylePriority.UseFont = false;
            this.\u0091\u0002.Text = \u0005.\u0004.\u0001(8069);
            this.\u0090\u0002.BorderDashStyle = BorderDashStyle.Dot;
            this.\u0090\u0002.Borders = BorderSide.None;
            XRBindingCollection dataBindings23 = this.\u0090\u0002.DataBindings;
            xrBindingArray1 = new XRBinding[1]
            {
              new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(1617))
            };
            XRBinding[] bindings23 = xrBindingArray1;
            dataBindings23.AddRange(bindings23);
            this.\u0090\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u0090\u0002.LocationFloat = new PointFloat(172.9161f, 807.3751f);
            this.\u0090\u0002.Multiline = true;
            this.\u0090\u0002.Name = \u0005.\u0004.\u0001(8890);
            this.\u0090\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u0090\u0002.SizeF = new SizeF(251.6668f, 23f);
            this.\u0090\u0002.StylePriority.UseBorderDashStyle = false;
            this.\u0090\u0002.StylePriority.UseBorders = false;
            this.\u0090\u0002.StylePriority.UseFont = false;
            this.\u0090\u0002.StylePriority.UseTextAlignment = false;
            this.\u0090\u0002.Text = \u0005.\u0004.\u0001(7728);
            this.\u0090\u0002.TextAlignment = TextAlignment.MiddleLeft;
            this.\u008F\u0002.BorderDashStyle = BorderDashStyle.Dot;
            this.\u008F\u0002.Borders = BorderSide.None;
            XRBindingCollection dataBindings24 = this.\u008F\u0002.DataBindings;
            xrBindingArray1 = new XRBinding[1]
            {
              new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(1661))
            };
            XRBinding[] bindings24 = xrBindingArray1;
            dataBindings24.AddRange(bindings24);
            this.\u008F\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u008F\u0002.LocationFloat = new PointFloat(270.8329f, 830.3751f);
            this.\u008F\u0002.Multiline = true;
            this.\u008F\u0002.Name = \u0005.\u0004.\u0001(8903);
            this.\u008F\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u008F\u0002.SizeF = new SizeF(112.0834f, 23f);
            this.\u008F\u0002.StylePriority.UseBorderDashStyle = false;
            this.\u008F\u0002.StylePriority.UseBorders = false;
            this.\u008F\u0002.StylePriority.UseFont = false;
            this.\u008F\u0002.StylePriority.UseTextAlignment = false;
            do
            {
              this.\u008F\u0002.Text = \u0005.\u0004.\u0001(7728);
              this.\u008F\u0002.TextAlignment = TextAlignment.MiddleRight;
              this.\u008E\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
              this.\u008E\u0002.LocationFloat = new PointFloat(382.9163f, 830.3751f);
              this.\u008E\u0002.Multiline = true;
              this.\u008E\u0002.Name = \u0005.\u0004.\u0001(8916);
              this.\u008E\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
              this.\u008E\u0002.SizeF = new SizeF(41.66666f, 23f);
              this.\u008E\u0002.StylePriority.UseFont = false;
              this.\u008E\u0002.StylePriority.UseTextAlignment = false;
            }
            while (false);
            this.\u008E\u0002.Text = \u0005.\u0004.\u0001(7710);
            this.\u008E\u0002.TextAlignment = TextAlignment.MiddleLeft;
            this.\u008D\u0002.BorderDashStyle = BorderDashStyle.Dot;
            this.\u008D\u0002.Borders = BorderSide.None;
            XRBindingCollection dataBindings25 = this.\u008D\u0002.DataBindings;
            xrBindingArray1 = new XRBinding[1]
            {
              new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(1525))
            };
            XRBinding[] bindings25 = xrBindingArray1;
            dataBindings25.AddRange(bindings25);
            this.\u008D\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u008D\u0002.LocationFloat = new PointFloat(595.8327f, 758.8751f);
            this.\u008D\u0002.Multiline = true;
            this.\u008D\u0002.Name = \u0005.\u0004.\u0001(8929);
            this.\u008D\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u008D\u0002.SizeF = new SizeF(155.2088f, 22.99998f);
            this.\u008D\u0002.StylePriority.UseBorderDashStyle = false;
            this.\u008D\u0002.StylePriority.UseBorders = false;
            this.\u008D\u0002.StylePriority.UseFont = false;
            this.\u008D\u0002.StylePriority.UseTextAlignment = false;
            this.\u008D\u0002.Text = \u0005.\u0004.\u0001(7996);
            this.\u008D\u0002.TextAlignment = TextAlignment.MiddleLeft;
            this.\u008C\u0002.BorderDashStyle = BorderDashStyle.Dot;
            this.\u008C\u0002.Borders = BorderSide.None;
            XRBindingCollection dataBindings26 = this.\u008C\u0002.DataBindings;
            xrBindingArray1 = new XRBinding[1]
            {
              new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(2668))
            };
            XRBinding[] bindings26 = xrBindingArray1;
            dataBindings26.AddRange(bindings26);
            this.\u008C\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            if (true)
            {
              this.\u008C\u0002.LocationFloat = new PointFloat(172.9161f, 784.3751f);
              this.\u008C\u0002.Multiline = true;
              this.\u008C\u0002.Name = \u0005.\u0004.\u0001(8942);
              this.\u008C\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
              this.\u008C\u0002.SizeF = new SizeF(251.6669f, 23f);
              this.\u008C\u0002.StylePriority.UseBorderDashStyle = false;
              this.\u008C\u0002.StylePriority.UseBorders = false;
              this.\u008C\u0002.StylePriority.UseFont = false;
              this.\u008C\u0002.StylePriority.UseTextAlignment = false;
              this.\u008C\u0002.Text = \u0005.\u0004.\u0001(7962);
            }
            this.\u008C\u0002.TextAlignment = TextAlignment.MiddleLeft;
            this.\u008B\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u008B\u0002.LocationFloat = new PointFloat(43.74962f, 758.8751f);
            this.\u008B\u0002.Multiline = true;
            this.\u008B\u0002.Name = \u0005.\u0004.\u0001(8955);
            this.\u008B\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u008B\u0002.SizeF = new SizeF(115.6248f, 25.49995f);
            this.\u008B\u0002.StylePriority.UseFont = false;
            this.\u008B\u0002.StylePriority.UseTextAlignment = false;
            this.\u008B\u0002.Text = \u0005.\u0004.\u0001(7932);
            this.\u008B\u0002.TextAlignment = TextAlignment.MiddleLeft;
            this.\u008A\u0002.BorderDashStyle = BorderDashStyle.Dot;
            this.\u008A\u0002.Borders = BorderSide.None;
            XRBindingCollection dataBindings27 = this.\u008A\u0002.DataBindings;
            xrBindingArray1 = new XRBinding[1]
            {
              new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(1574))
            };
            XRBinding[] bindings27 = xrBindingArray1;
            dataBindings27.AddRange(bindings27);
            this.\u008A\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u008A\u0002.LocationFloat = new PointFloat(172.9161f, 758.8751f);
            this.\u008A\u0002.Multiline = true;
            this.\u008A\u0002.Name = \u0005.\u0004.\u0001(8968);
            this.\u008A\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u008A\u0002.SizeF = new SizeF(251.6668f, 25.49994f);
            this.\u008A\u0002.StylePriority.UseBorderDashStyle = false;
            this.\u008A\u0002.StylePriority.UseBorders = false;
            this.\u008A\u0002.StylePriority.UseFont = false;
            this.\u008A\u0002.StylePriority.UseTextAlignment = false;
            this.\u008A\u0002.Text = \u0005.\u0004.\u0001(7728);
            this.\u008A\u0002.TextAlignment = TextAlignment.MiddleLeft;
            this.\u0089\u0002.BorderDashStyle = BorderDashStyle.Dot;
            this.\u0089\u0002.Borders = BorderSide.None;
            XRBindingCollection dataBindings28 = this.\u0089\u0002.DataBindings;
            xrBindingArray1 = new XRBinding[1]
            {
              new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(7859))
            };
            XRBinding[] bindings28 = xrBindingArray1;
            dataBindings28.AddRange(bindings28);
            this.\u0089\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u0089\u0002.LocationFloat = new PointFloat(595.8327f, 877.6113f);
            this.\u0089\u0002.Multiline = true;
            this.\u0089\u0002.Name = \u0005.\u0004.\u0001(8981);
            this.\u0089\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u0089\u0002.SizeF = new SizeF(155.2087f, 23f);
            this.\u0089\u0002.StylePriority.UseBorderDashStyle = false;
            this.\u0089\u0002.StylePriority.UseBorders = false;
            this.\u0089\u0002.StylePriority.UseFont = false;
            this.\u0089\u0002.StylePriority.UseTextAlignment = false;
            this.\u0089\u0002.Text = \u0005.\u0004.\u0001(7885);
            this.\u0089\u0002.TextAlignment = TextAlignment.MiddleLeft;
            this.\u0088\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u0088\u0002.LocationFloat = new PointFloat(43.74962f, 853.7228f);
            this.\u0088\u0002.Multiline = true;
            this.\u0088\u0002.Name = \u0005.\u0004.\u0001(8994);
            this.\u0088\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u0088\u0002.SizeF = new SizeF(209.7916f, 23f);
            this.\u0088\u0002.StylePriority.UseFont = false;
            this.\u0088\u0002.StylePriority.UseTextAlignment = false;
            this.\u0088\u0002.Text = \u0005.\u0004.\u0001(7830);
            this.\u0088\u0002.TextAlignment = TextAlignment.MiddleJustify;
            this.\u0087\u0002.BorderDashStyle = BorderDashStyle.Dot;
            this.\u0087\u0002.Borders = BorderSide.None;
            XRBindingCollection dataBindings29 = this.\u0087\u0002.DataBindings;
            xrBindingArray1 = new XRBinding[1]
            {
              new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(1700))
            };
            XRBinding[] bindings29 = xrBindingArray1;
            dataBindings29.AddRange(bindings29);
            this.\u0087\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u0087\u0002.LocationFloat = new PointFloat(270.8329f, 853.9307f);
            this.\u0087\u0002.Multiline = true;
            this.\u0087\u0002.Name = \u0005.\u0004.\u0001(9007);
            this.\u0087\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u0087\u0002.SizeF = new SizeF(112.0834f, 23f);
            this.\u0087\u0002.StylePriority.UseBorderDashStyle = false;
            this.\u0087\u0002.StylePriority.UseBorders = false;
            this.\u0087\u0002.StylePriority.UseFont = false;
            this.\u0087\u0002.StylePriority.UseTextAlignment = false;
            this.\u0087\u0002.Text = \u0005.\u0004.\u0001(7728);
            this.\u0087\u0002.TextAlignment = TextAlignment.MiddleRight;
            this.\u0086\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u0086\u0002.LocationFloat = new PointFloat(382.9163f, 853.3751f);
            this.\u0086\u0002.Multiline = true;
            this.\u0086\u0002.Name = \u0005.\u0004.\u0001(9020);
            this.\u0086\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u0086\u0002.SizeF = new SizeF(41.66666f, 23f);
            this.\u0086\u0002.StylePriority.UseFont = false;
            this.\u0086\u0002.StylePriority.UseTextAlignment = false;
            this.\u0086\u0002.Text = \u0005.\u0004.\u0001(7710);
            this.\u0086\u0002.TextAlignment = TextAlignment.MiddleLeft;
            this.\u0084\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u0084\u0002.LocationFloat = new PointFloat(43.74962f, 877.1954f);
            this.\u0084\u0002.Multiline = true;
            this.\u0084\u0002.Name = \u0005.\u0004.\u0001(9033);
            this.\u0084\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u0084\u0002.SizeF = new SizeF(209.7915f, 23f);
            this.\u0084\u0002.StylePriority.UseFont = false;
            this.\u0084\u0002.StylePriority.UseTextAlignment = false;
            this.\u0084\u0002.Text = \u0005.\u0004.\u0001(7758);
            this.\u0084\u0002.TextAlignment = TextAlignment.MiddleJustify;
            this.\u0083\u0002.BorderDashStyle = BorderDashStyle.Dot;
            this.\u0083\u0002.Borders = BorderSide.None;
            XRBindingCollection dataBindings30 = this.\u0083\u0002.DataBindings;
            xrBindingArray1 = new XRBinding[1]
            {
              new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(1825))
            };
            XRBinding[] bindings30 = xrBindingArray1;
            dataBindings30.AddRange(bindings30);
            this.\u0083\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u0083\u0002.LocationFloat = new PointFloat(270.8329f, 877.6113f);
            this.\u0083\u0002.Multiline = true;
            this.\u0083\u0002.Name = \u0005.\u0004.\u0001(9046);
            this.\u0083\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u0083\u0002.SizeF = new SizeF(112.0834f, 23f);
            this.\u0083\u0002.StylePriority.UseBorderDashStyle = false;
            this.\u0083\u0002.StylePriority.UseBorders = false;
            this.\u0083\u0002.StylePriority.UseFont = false;
            this.\u0083\u0002.StylePriority.UseTextAlignment = false;
            this.\u0083\u0002.Text = \u0005.\u0004.\u0001(7728);
            this.\u0083\u0002.TextAlignment = TextAlignment.MiddleRight;
            this.\u0082\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u0082\u0002.LocationFloat = new PointFloat(382.9163f, 877.6113f);
            this.\u0082\u0002.Multiline = true;
            this.\u0082\u0002.Name = \u0005.\u0004.\u0001(9059);
            this.\u0082\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u0082\u0002.SizeF = new SizeF(41.66666f, 23f);
            this.\u0082\u0002.StylePriority.UseFont = false;
            this.\u0082\u0002.StylePriority.UseTextAlignment = false;
            this.\u0082\u0002.Text = \u0005.\u0004.\u0001(7710);
            this.\u0082\u0002.TextAlignment = TextAlignment.MiddleLeft;
            this.\u0081\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u0081\u0002.LocationFloat = new PointFloat(312.5005f, 973.9048f);
            this.\u0081\u0002.Multiline = true;
            this.\u0081\u0002.Name = \u0005.\u0004.\u0001(9072);
            this.\u0081\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u0081\u0002.SizeF = new SizeF(125.0001f, 23f);
            this.\u0081\u0002.StylePriority.UseFont = false;
            this.\u0081\u0002.Text = \u0005.\u0004.\u0001(7676);
            this.\u0080\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u0080\u0002.LocationFloat = new PointFloat(43.74962f, 900.1953f);
            this.\u0080\u0002.Multiline = true;
            this.\u0080\u0002.Name = \u0005.\u0004.\u0001(9085);
            this.\u0080\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u0080\u0002.SizeF = new SizeF(88.54169f, 23f);
            this.\u0080\u0002.StylePriority.UseFont = false;
            this.\u0080\u0002.StylePriority.UseTextAlignment = false;
            this.\u0080\u0002.Text = \u0005.\u0004.\u0001(2690);
            this.\u0080\u0002.TextAlignment = TextAlignment.MiddleLeft;
            this.\u007F\u0002.BorderDashStyle = BorderDashStyle.Dot;
            this.\u007F\u0002.Borders = BorderSide.None;
            XRBindingCollection dataBindings31 = this.\u007F\u0002.DataBindings;
            xrBindingArray1 = new XRBinding[1]
            {
              new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(2703))
            };
            XRBinding[] bindings31 = xrBindingArray1;
            dataBindings31.AddRange(bindings31);
            this.\u007F\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u007F\u0002.LocationFloat = new PointFloat(270.8329f, 900.1953f);
            this.\u007F\u0002.Multiline = true;
            this.\u007F\u0002.Name = \u0005.\u0004.\u0001(9098);
            this.\u007F\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u007F\u0002.SizeF = new SizeF(480.2086f, 22.99997f);
            this.\u007F\u0002.StylePriority.UseBorderDashStyle = false;
            this.\u007F\u0002.StylePriority.UseBorders = false;
            this.\u007F\u0002.StylePriority.UseFont = false;
            this.\u007F\u0002.StylePriority.UseTextAlignment = false;
            this.\u007F\u0002.TextAlignment = TextAlignment.MiddleLeft;
            this.\u001F\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u001F\u0002.LocationFloat = new PointFloat(466.666f, 830.3751f);
            this.\u001F\u0002.Multiline = true;
            this.\u001F\u0002.Name = \u0005.\u0004.\u0001(9111);
            this.\u001F\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u001F\u0002.SizeF = new SizeF(95.83401f, 23f);
            this.\u001F\u0002.StylePriority.UseFont = false;
            this.\u001F\u0002.StylePriority.UseTextAlignment = false;
            this.\u001F\u0002.Text = \u0005.\u0004.\u0001(7585);
            this.\u001F\u0002.TextAlignment = TextAlignment.MiddleLeft;
            this.\u001E\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
            this.\u001E\u0002.LocationFloat = new PointFloat(466.666f, 853.9307f);
            this.\u001E\u0002.Multiline = true;
            this.\u001E\u0002.Name = \u0005.\u0004.\u0001(9124);
            this.\u001E\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.\u001E\u0002.SizeF = new SizeF(95.83401f, 23f);
            this.\u001E\u0002.StylePriority.UseFont = false;
            this.\u001E\u0002.StylePriority.UseTextAlignment = false;
            this.\u001E\u0002.Text = \u0005.\u0004.\u0001(7551);
            this.\u001E\u0002.TextAlignment = TextAlignment.MiddleLeft;
            this.\u001D\u0002.BorderDashStyle = BorderDashStyle.Dot;
            this.\u001D\u0002.Borders = BorderSide.None;
            XRBindingCollection dataBindings32 = this.\u001D\u0002.DataBindings;
            xrBindingArray1 = new XRBinding[1]
            {
              new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(2080), \u0005.\u0004.\u0001(7474))
            };
            XRBinding[] bindings32 = xrBindingArray1;
            dataBindings32.AddRange(bindings32);
            this.\u001D\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          }
          else
            goto label_8;
        }
        this.\u001D\u0002.LocationFloat = new PointFloat(595.8327f, 830.3751f);
        this.\u001D\u0002.Multiline = true;
        this.\u001D\u0002.Name = \u0005.\u0004.\u0001(9137);
        this.\u001D\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.\u001D\u0002.SizeF = new SizeF(155.2087f, 23f);
        this.\u001D\u0002.StylePriority.UseBorderDashStyle = false;
        this.\u001D\u0002.StylePriority.UseBorders = false;
        this.\u001D\u0002.StylePriority.UseFont = false;
        this.\u001D\u0002.StylePriority.UseTextAlignment = false;
        this.\u001D\u0002.Text = \u0005.\u0004.\u0001(7504);
        this.\u001D\u0002.TextAlignment = TextAlignment.MiddleLeft;
        this.\u001C\u0002.BorderDashStyle = BorderDashStyle.Dot;
        this.\u001C\u0002.Borders = BorderSide.None;
        XRBindingCollection dataBindings33 = this.\u001C\u0002.DataBindings;
        xrBindingArray1 = new XRBinding[1]
        {
          new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(2123), \u0005.\u0004.\u0001(7474))
        };
        XRBinding[] bindings33 = xrBindingArray1;
        dataBindings33.AddRange(bindings33);
        this.\u001C\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
        this.\u001C\u0002.LocationFloat = new PointFloat(595.8327f, 853.9307f);
        this.\u001C\u0002.Multiline = true;
        this.\u001C\u0002.Name = \u0005.\u0004.\u0001(9150);
        this.\u001C\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.\u001C\u0002.SizeF = new SizeF(155.2087f, 23f);
        this.\u001C\u0002.StylePriority.UseBorderDashStyle = false;
        this.\u001C\u0002.StylePriority.UseBorders = false;
        this.\u001C\u0002.StylePriority.UseFont = false;
        this.\u001C\u0002.StylePriority.UseTextAlignment = false;
        this.\u001C\u0002.Text = \u0005.\u0004.\u0001(7504);
        this.\u001C\u0002.TextAlignment = TextAlignment.MiddleLeft;
        this.\u001B\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
        this.\u001B\u0002.LocationFloat = new PointFloat(466.6662f, 781.8751f);
        this.\u001B\u0002.Multiline = true;
        this.\u001B\u0002.Name = \u0005.\u0004.\u0001(9163);
        this.\u001B\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.\u001B\u0002.SizeF = new SizeF(80.20834f, 22.99999f);
        this.\u001B\u0002.StylePriority.UseFont = false;
        this.\u001B\u0002.StylePriority.UseTextAlignment = false;
        this.\u001B\u0002.Text = \u0005.\u0004.\u0001(8491);
        this.\u001B\u0002.TextAlignment = TextAlignment.MiddleLeft;
        XRBindingCollection dataBindings34 = this.\u001A\u0002.DataBindings;
        xrBindingArray1 = new XRBinding[1]
        {
          new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(2036), \u0005.\u0004.\u0001(8496))
        };
        XRBinding[] bindings34 = xrBindingArray1;
        dataBindings34.AddRange(bindings34);
        this.\u001A\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
        this.\u001A\u0002.LocationFloat = new PointFloat(595.8327f, 807.3751f);
        this.\u001A\u0002.Name = \u0005.\u0004.\u0001(9176);
        this.\u001A\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.\u001A\u0002.SizeF = new SizeF(155.2087f, 23f);
        this.\u001A\u0002.StylePriority.UseFont = false;
        this.\u001A\u0002.Text = \u0005.\u0004.\u0001(8517);
        this.\u0019\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
        this.\u0019\u0002.LocationFloat = new PointFloat(465.6246f, 807.3751f);
        this.\u0019\u0002.Multiline = true;
        this.\u0019\u0002.Name = \u0005.\u0004.\u0001(9189);
        this.\u0019\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.\u0019\u0002.SizeF = new SizeF(96.87537f, 22.99998f);
        this.\u0019\u0002.StylePriority.UseFont = false;
        this.\u0019\u0002.StylePriority.UseTextAlignment = false;
        this.\u0019\u0002.Text = \u0005.\u0004.\u0001(8543);
        this.\u0019\u0002.TextAlignment = TextAlignment.MiddleLeft;
        this.\u0018\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
        this.\u0018\u0002.LocationFloat = new PointFloat(43.74962f, 781.8751f);
        this.\u0018\u0002.Multiline = true;
        this.\u0018\u0002.Name = \u0005.\u0004.\u0001(9202);
        this.\u0018\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.\u0018\u0002.SizeF = new SizeF(115.6248f, 25.49995f);
        this.\u0018\u0002.StylePriority.UseFont = false;
        this.\u0018\u0002.StylePriority.UseTextAlignment = false;
        this.\u0018\u0002.Text = \u0005.\u0004.\u0001(8427);
        this.\u0018\u0002.TextAlignment = TextAlignment.MiddleLeft;
        this.\u0017\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
        this.\u0017\u0002.LocationFloat = new PointFloat(159.3744f, 758.8751f);
        this.\u0017\u0002.Multiline = true;
        this.\u0017\u0002.Name = \u0005.\u0004.\u0001(9215);
        this.\u0017\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.\u0017\u0002.SizeF = new SizeF(15.62485f, 22.99988f);
        this.\u0017\u0002.StylePriority.UseFont = false;
        this.\u0017\u0002.StylePriority.UseTextAlignment = false;
        this.\u0017\u0002.Text = \u0005.\u0004.\u0001(8586);
        this.\u0017\u0002.TextAlignment = TextAlignment.MiddleLeft;
        this.\u0016\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
        this.\u0016\u0002.LocationFloat = new PointFloat(159.3745f, 781.8751f);
        this.\u0016\u0002.Multiline = true;
        this.\u0016\u0002.Name = \u0005.\u0004.\u0001(9228);
        this.\u0016\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.\u0016\u0002.SizeF = new SizeF(15.62485f, 25.49995f);
        this.\u0016\u0002.StylePriority.UseFont = false;
        this.\u0016\u0002.StylePriority.UseTextAlignment = false;
        this.\u0016\u0002.Text = \u0005.\u0004.\u0001(8586);
        this.\u0016\u0002.TextAlignment = TextAlignment.MiddleLeft;
label_8:
        this.\u0015\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
        this.\u0015\u0002.LocationFloat = new PointFloat(159.3745f, 805.4307f);
        this.\u0015\u0002.Multiline = true;
        this.\u0015\u0002.Name = \u0005.\u0004.\u0001(9241);
        this.\u0015\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.\u0015\u0002.SizeF = new SizeF(15.62485f, 25.49995f);
        this.\u0015\u0002.StylePriority.UseFont = false;
        this.\u0015\u0002.StylePriority.UseTextAlignment = false;
        this.\u0015\u0002.Text = \u0005.\u0004.\u0001(8586);
        this.\u0015\u0002.TextAlignment = TextAlignment.MiddleLeft;
        this.\u0014\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
        this.\u0014\u0002.LocationFloat = new PointFloat(253.5412f, 830.9307f);
        this.\u0014\u0002.Multiline = true;
        this.\u0014\u0002.Name = \u0005.\u0004.\u0001(9254);
        this.\u0014\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.\u0014\u0002.SizeF = new SizeF(15.62485f, 25.49995f);
        this.\u0014\u0002.StylePriority.UseFont = false;
        this.\u0014\u0002.StylePriority.UseTextAlignment = false;
        this.\u0014\u0002.Text = \u0005.\u0004.\u0001(8586);
        this.\u0014\u0002.TextAlignment = TextAlignment.MiddleLeft;
        this.\u0013\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
        this.\u0013\u0002.LocationFloat = new PointFloat(253.5412f, 851.2228f);
        this.\u0013\u0002.Multiline = true;
        this.\u0013\u0002.Name = \u0005.\u0004.\u0001(9267);
        this.\u0013\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.\u0013\u0002.SizeF = new SizeF(15.62485f, 25.49995f);
        this.\u0013\u0002.StylePriority.UseFont = false;
        this.\u0013\u0002.StylePriority.UseTextAlignment = false;
        this.\u0013\u0002.Text = \u0005.\u0004.\u0001(8586);
        this.\u0013\u0002.TextAlignment = TextAlignment.MiddleLeft;
        this.\u0012\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
        this.\u0012\u0002.LocationFloat = new PointFloat(253.5412f, 877.6113f);
        this.\u0012\u0002.Multiline = true;
        this.\u0012\u0002.Name = \u0005.\u0004.\u0001(9280);
        this.\u0012\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.\u0012\u0002.SizeF = new SizeF(15.62485f, 25.49995f);
        this.\u0012\u0002.StylePriority.UseFont = false;
        this.\u0012\u0002.StylePriority.UseTextAlignment = false;
        this.\u0012\u0002.Text = \u0005.\u0004.\u0001(8586);
        this.\u0012\u0002.TextAlignment = TextAlignment.MiddleLeft;
        this.\u0011\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
        this.\u0011\u0002.LocationFloat = new PointFloat(253.5412f, 897.6954f);
        this.\u0011\u0002.Multiline = true;
        this.\u0011\u0002.Name = \u0005.\u0004.\u0001(9293);
        this.\u0011\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.\u0011\u0002.SizeF = new SizeF(15.62485f, 25.49995f);
        this.\u0011\u0002.StylePriority.UseFont = false;
        this.\u0011\u0002.StylePriority.UseTextAlignment = false;
        this.\u0011\u0002.Text = \u0005.\u0004.\u0001(8586);
        this.\u0011\u0002.TextAlignment = TextAlignment.MiddleLeft;
        this.\u0010\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
        this.\u0010\u0002.LocationFloat = new PointFloat(562.5f, 758.8751f);
        this.\u0010\u0002.Multiline = true;
        this.\u0010\u0002.Name = \u0005.\u0004.\u0001(9306);
        this.\u0010\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.\u0010\u0002.SizeF = new SizeF(15.62485f, 25.49995f);
        this.\u0010\u0002.StylePriority.UseFont = false;
        this.\u0010\u0002.StylePriority.UseTextAlignment = false;
        this.\u0010\u0002.Text = \u0005.\u0004.\u0001(8586);
        this.\u0010\u0002.TextAlignment = TextAlignment.MiddleLeft;
        this.\u000F\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
        this.\u000F\u0002.LocationFloat = new PointFloat(562.4996f, 781.8751f);
        this.\u000F\u0002.Multiline = true;
        this.\u000F\u0002.Name = \u0005.\u0004.\u0001(9319);
        this.\u000F\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.\u000F\u0002.SizeF = new SizeF(15.62485f, 25.49995f);
        this.\u000F\u0002.StylePriority.UseFont = false;
        this.\u000F\u0002.StylePriority.UseTextAlignment = false;
        this.\u000F\u0002.Text = \u0005.\u0004.\u0001(8586);
        this.\u000F\u0002.TextAlignment = TextAlignment.MiddleLeft;
        this.\u000E\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
        this.\u000E\u0002.LocationFloat = new PointFloat(562.4999f, 807.3751f);
        this.\u000E\u0002.Multiline = true;
        this.\u000E\u0002.Name = \u0005.\u0004.\u0001(9332);
        this.\u000E\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.\u000E\u0002.SizeF = new SizeF(15.62485f, 25.49995f);
        this.\u000E\u0002.StylePriority.UseFont = false;
        this.\u000E\u0002.StylePriority.UseTextAlignment = false;
        this.\u000E\u0002.Text = \u0005.\u0004.\u0001(8586);
        this.\u000E\u0002.TextAlignment = TextAlignment.MiddleLeft;
        this.\u0008\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
        this.\u0008\u0002.LocationFloat = new PointFloat(562.4999f, 830.3751f);
        this.\u0008\u0002.Multiline = true;
        this.\u0008\u0002.Name = \u0005.\u0004.\u0001(9345);
        this.\u0008\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.\u0008\u0002.SizeF = new SizeF(15.62485f, 25.49995f);
        this.\u0008\u0002.StylePriority.UseFont = false;
        this.\u0008\u0002.StylePriority.UseTextAlignment = false;
        this.\u0008\u0002.Text = \u0005.\u0004.\u0001(8586);
        this.\u0008\u0002.TextAlignment = TextAlignment.MiddleLeft;
        this.\u0007\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
        this.\u0007\u0002.LocationFloat = new PointFloat(562.5f, 851.2227f);
        this.\u0007\u0002.Multiline = true;
        this.\u0007\u0002.Name = \u0005.\u0004.\u0001(9358);
        this.\u0007\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.\u0007\u0002.SizeF = new SizeF(15.62485f, 25.49995f);
        this.\u0007\u0002.StylePriority.UseFont = false;
        this.\u0007\u0002.StylePriority.UseTextAlignment = false;
        this.\u0007\u0002.Text = \u0005.\u0004.\u0001(8586);
        this.\u0007\u0002.TextAlignment = TextAlignment.MiddleLeft;
        this.\u0006\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
        this.\u0006\u0002.LocationFloat = new PointFloat(562.5f, 875.1113f);
        this.\u0006\u0002.Multiline = true;
        this.\u0006\u0002.Name = \u0005.\u0004.\u0001(9371);
        this.\u0006\u0002.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.\u0006\u0002.SizeF = new SizeF(15.62485f, 25.49995f);
        this.\u0006\u0002.StylePriority.UseFont = false;
        this.\u0006\u0002.StylePriority.UseTextAlignment = false;
        this.\u0006\u0002.Text = \u0005.\u0004.\u0001(8586);
        this.\u0006\u0002.TextAlignment = TextAlignment.MiddleLeft;
        BandCollection bands1 = this.Bands;
        bandArray1 = new Band[5]
        {
          (Band) this.\u0002,
          (Band) this.\u0003,
          (Band) this.\u0004,
          (Band) this.\u0005,
          (Band) this.\u0093
        };
        Band[] bands2 = bandArray1;
        bands1.AddRange(bands2);
        this.DataSource = (object) this.\u0087;
        this.Margins = new Margins(14, 11, 13, 18);
        this.PageHeight = 1169;
        this.PageWidth = 827;
        this.PaperKind = PaperKind.A4;
        ParameterCollection parameters1 = this.Parameters;
        parameterArray1 = new Parameter[5]
        {
          this.\u0011,
          this.\u0012,
          this.\u0010,
          this.\u0088,
          this.\u0091
        };
        Parameter[] parameters2 = parameterArray1;
        parameters1.AddRange(parameters2);
        this.Version = \u0005.\u0004.\u0001(9384);
        ((ISupportInitialize) this.\u0087).EndInit();
        this.EndInit();
      }
      catch (Exception ex)
      {
        XRControl[] xrControlArray2 = xrControlArray1;
        XRBinding[] xrBindingArray2 = xrBindingArray1;
        Band[] bandArray2 = bandArray1;
        Parameter[] parameterArray2 = parameterArray1;
        \u0005.\u0008.\u0001(ex, (object) xrControlArray2, (object) xrBindingArray2, (object) bandArray2, (object) parameterArray2, (object) this);
        throw;
      }
    }
  }
}
