// Decompiled with JetBrains decompiler
// Type: .
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

namespace \u0007
{
  internal class \u0001 : XtraReport
  {
    private IContainer \u0001 = (IContainer) null;
    private DetailBand \u0002;
    private TopMarginBand \u0003;
    private BottomMarginBand \u0004;
    private BindingSource \u0005;
    private Parameter \u0006;
    private Parameter \u0007;
    private Parameter \u0008;
    private Parameter \u000E;
    private ReportHeaderBand \u000F;
    private XRLabel \u0010;
    private Parameter \u0011;
    private XRLabel \u0012;
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
    private XRLabel \u0087;
    private XRLabel \u0088;
    private XRLabel \u0089;
    private XRLabel \u008A;
    private XRLabel \u008B;
    private XRLabel \u008C;
    private XRLabel \u008D;
    private XRLabel \u008E;
    private XRLabel \u008F;
    private XRLabel \u0090;
    private XRLabel \u0091;
    private XRLabel \u0092;
    private XRLabel \u0093;
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
        this.\u0006 = new Parameter();
        this.\u0007 = new Parameter();
        this.\u0008 = new Parameter();
        this.\u000E = new Parameter();
        this.\u000F = new ReportHeaderBand();
        this.\u0015 = new XRLabel();
        this.\u0016 = new XRLabel();
        this.\u0017 = new XRLabel();
        this.\u0018 = new XRLabel();
        this.\u0019 = new XRLabel();
        this.\u001A = new XRLabel();
        this.\u001B = new XRLabel();
        this.\u001C = new XRLabel();
        this.\u001D = new XRLabel();
        this.\u001E = new XRLabel();
        this.\u001F = new XRLabel();
        this.\u007F = new XRLabel();
        this.\u0080 = new XRLabel();
        this.\u0081 = new XRLabel();
        this.\u0082 = new XRLabel();
        this.\u0083 = new XRLabel();
        this.\u0084 = new XRLabel();
        this.\u0086 = new XRLabel();
        this.\u0087 = new XRLabel();
        this.\u0088 = new XRLabel();
        this.\u0089 = new XRLabel();
        this.\u008A = new XRLabel();
        this.\u008B = new XRLabel();
        this.\u008C = new XRLabel();
        this.\u008D = new XRLabel();
        this.\u008E = new XRLabel();
        this.\u008F = new XRLabel();
        this.\u0090 = new XRLabel();
        this.\u0091 = new XRLabel();
        this.\u0092 = new XRLabel();
        this.\u0093 = new XRLabel();
        this.\u0094 = new XRLabel();
        this.\u0095 = new XRLabel();
        this.\u0096 = new XRLabel();
        this.\u0097 = new XRLabel();
        this.\u0098 = new XRLabel();
        this.\u0099 = new XRLabel();
        this.\u009A = new XRLabel();
        this.\u009B = new XRLabel();
        this.\u009C = new XRLabel();
        this.\u009D = new XRLabel();
        this.\u009E = new XRLabel();
        this.\u009F = new XRLabel();
        this.\u0001\u0002 = new XRLabel();
        this.\u0012 = new XRLabel();
        this.\u0013 = new XRLabel();
        this.\u0014 = new XRLabel();
        this.\u0010 = new XRLabel();
        this.\u0011 = new Parameter();
        this.\u0005 = new BindingSource(this.\u0001);
        ((ISupportInitialize) this.\u0005).BeginInit();
        this.BeginInit();
        this.\u0002.Dpi = 254f;
        this.\u0002.HeightF = 0.0f;
        this.\u0002.Name = \u0005.\u0004.\u0001(7309);
        this.\u0002.Padding = new PaddingInfo(0, 0, 0, 0, 254f);
        this.\u0002.TextAlignment = TextAlignment.TopLeft;
        this.\u0003.Dpi = 254f;
        this.\u0003.HeightF = 0.0f;
        this.\u0003.Name = \u0005.\u0004.\u0001(7318);
        this.\u0003.Padding = new PaddingInfo(0, 0, 0, 0, 254f);
        this.\u0003.TextAlignment = TextAlignment.TopLeft;
        this.\u0004.Dpi = 254f;
        this.\u0004.HeightF = 0.0f;
        this.\u0004.Name = \u0005.\u0004.\u0001(7331);
        this.\u0004.Padding = new PaddingInfo(0, 0, 0, 0, 254f);
        this.\u0004.TextAlignment = TextAlignment.TopLeft;
        this.\u0006.Description = \u0005.\u0004.\u0001(7403);
        this.\u0006.Name = \u0005.\u0004.\u0001(2646);
        this.\u0006.Visible = false;
        this.\u0007.Description = \u0005.\u0004.\u0001(7403);
        this.\u0007.Name = \u0005.\u0004.\u0001(7650);
        this.\u0007.Visible = false;
        this.\u0008.Description = \u0005.\u0004.\u0001(7403);
        this.\u0008.Name = \u0005.\u0004.\u0001(7632);
        this.\u0008.Visible = false;
        this.\u000E.Description = \u0005.\u0004.\u0001(7403);
        this.\u000E.Name = \u0005.\u0004.\u0001(7641);
        this.\u000E.Visible = false;
        XRControlCollection controls1 = this.\u000F.Controls;
        xrControlArray1 = new XRControl[48]
        {
          (XRControl) this.\u0015,
          (XRControl) this.\u0016,
          (XRControl) this.\u0017,
          (XRControl) this.\u0018,
          (XRControl) this.\u0019,
          (XRControl) this.\u001A,
          (XRControl) this.\u001B,
          (XRControl) this.\u001C,
          (XRControl) this.\u001D,
          (XRControl) this.\u001E,
          (XRControl) this.\u001F,
          (XRControl) this.\u007F,
          (XRControl) this.\u0080,
          (XRControl) this.\u0081,
          (XRControl) this.\u0082,
          (XRControl) this.\u0083,
          (XRControl) this.\u0084,
          (XRControl) this.\u0086,
          (XRControl) this.\u0087,
          (XRControl) this.\u0088,
          (XRControl) this.\u0089,
          (XRControl) this.\u008A,
          (XRControl) this.\u008B,
          (XRControl) this.\u008C,
          (XRControl) this.\u008D,
          (XRControl) this.\u008E,
          (XRControl) this.\u008F,
          (XRControl) this.\u0090,
          (XRControl) this.\u0091,
          (XRControl) this.\u0092,
          (XRControl) this.\u0093,
          (XRControl) this.\u0094,
          (XRControl) this.\u0095,
          (XRControl) this.\u0096,
          (XRControl) this.\u0097,
          (XRControl) this.\u0098,
          (XRControl) this.\u0099,
          (XRControl) this.\u009A,
          (XRControl) this.\u009B,
          (XRControl) this.\u009C,
          (XRControl) this.\u009D,
          (XRControl) this.\u009E,
          (XRControl) this.\u009F,
          (XRControl) this.\u0001\u0002,
          (XRControl) this.\u0012,
          (XRControl) this.\u0013,
          (XRControl) this.\u0014,
          (XRControl) this.\u0010
        };
        XRControl[] controls2 = xrControlArray1;
        controls1.AddRange(controls2);
        this.\u000F.Dpi = 254f;
        this.\u000F.HeightF = 1363.506f;
        this.\u000F.Name = \u0005.\u0004.\u0001(7348);
        XRBindingCollection dataBindings1 = this.\u0015.DataBindings;
        xrBindingArray1 = new XRBinding[1]
        {
          new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(2036), \u0005.\u0004.\u0001(8496))
        };
        XRBinding[] bindings1 = xrBindingArray1;
        dataBindings1.AddRange(bindings1);
        this.\u0015.Dpi = 254f;
        this.\u0015.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
        this.\u0015.LocationFloat = new PointFloat(1461.294f, 582.8139f);
        this.\u0015.Name = \u0005.\u0004.\u0001(8517);
        this.\u0015.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
        this.\u0015.SizeF = new SizeF(394.23f, 58.41998f);
        this.\u0015.StylePriority.UseFont = false;
        this.\u0015.Text = \u0005.\u0004.\u0001(8517);
        this.\u0016.Dpi = 254f;
        this.\u0016.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
        this.\u0016.LocationFloat = new PointFloat(143.6682f, 1005.8f);
        this.\u0016.Multiline = true;
        this.\u0016.Name = \u0005.\u0004.\u0001(8414);
        this.\u0016.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
        this.\u0016.SizeF = new SizeF(253.9999f, 58.41998f);
        this.\u0016.StylePriority.UseFont = false;
        this.\u0016.Text = \u0005.\u0004.\u0001(8427);
        this.\u0017.Dpi = 254f;
        this.\u0017.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
        this.\u0017.LocationFloat = new PointFloat(405.2879f, 459.624f);
        this.\u0017.Multiline = true;
        this.\u0017.Name = \u0005.\u0004.\u0001(8573);
        this.\u0017.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
        this.\u0017.SizeF = new SizeF(39.6871f, 64.7699f);
        this.\u0017.StylePriority.UseFont = false;
        this.\u0017.StylePriority.UseTextAlignment = false;
        this.\u0017.Text = \u0005.\u0004.\u0001(8586);
        this.\u0017.TextAlignment = TextAlignment.MiddleLeft;
        this.\u0018.Dpi = 254f;
        this.\u0018.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
        this.\u0018.LocationFloat = new PointFloat(103.9811f, 518.0439f);
        this.\u0018.Multiline = true;
        this.\u0018.Name = \u0005.\u0004.\u0001(8560);
        this.\u0018.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
        this.\u0018.SizeF = new SizeF(293.687f, 64.7699f);
        this.\u0018.StylePriority.UseFont = false;
        this.\u0018.StylePriority.UseTextAlignment = false;
        this.\u0018.Text = \u0005.\u0004.\u0001(8427);
        this.\u0018.TextAlignment = TextAlignment.MiddleLeft;
        this.\u0019.BorderDashStyle = BorderDashStyle.Dot;
        this.\u0019.Borders = BorderSide.None;
        XRBindingCollection dataBindings2 = this.\u0019.DataBindings;
        xrBindingArray1 = new XRBinding[1]
        {
          new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(2123), \u0005.\u0004.\u0001(7474))
        };
        XRBinding[] bindings2 = xrBindingArray1;
        dataBindings2.AddRange(bindings2);
        this.\u0019.Dpi = 254f;
        this.\u0019.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
        this.\u0019.LocationFloat = new PointFloat(1461.294f, 701.0652f);
        this.\u0019.Multiline = true;
        this.\u0019.Name = \u0005.\u0004.\u0001(7491);
        this.\u0019.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
        this.\u0019.SizeF = new SizeF(394.23f, 58.42004f);
        this.\u0019.StylePriority.UseBorderDashStyle = false;
        this.\u0019.StylePriority.UseBorders = false;
        this.\u0019.StylePriority.UseFont = false;
        this.\u0019.StylePriority.UseTextAlignment = false;
        this.\u0019.Text = \u0005.\u0004.\u0001(7504);
        this.\u0019.TextAlignment = TextAlignment.MiddleLeft;
        this.\u001A.BorderDashStyle = BorderDashStyle.Dot;
        this.\u001A.Borders = BorderSide.None;
        XRBindingCollection dataBindings3 = this.\u001A.DataBindings;
        xrBindingArray1 = new XRBinding[1]
        {
          new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(2703))
        };
        XRBinding[] bindings3 = xrBindingArray1;
        dataBindings3.AddRange(bindings3);
        this.\u001A.Dpi = 254f;
        this.\u001A.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
        this.\u001A.LocationFloat = new PointFloat(439.6839f, 819.6339f);
        this.\u001A.Multiline = true;
        this.\u001A.Name = \u0005.\u0004.\u0001(7606);
        this.\u001A.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
        this.\u001A.SizeF = new SizeF(1415.84f, 58.41986f);
        this.\u001A.StylePriority.UseBorderDashStyle = false;
        this.\u001A.StylePriority.UseBorders = false;
        this.\u001A.StylePriority.UseFont = false;
        this.\u001A.StylePriority.UseTextAlignment = false;
        this.\u001A.TextAlignment = TextAlignment.MiddleLeft;
        this.\u001B.Dpi = 254f;
        this.\u001B.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
        this.\u001B.LocationFloat = new PointFloat(103.9811f, 818.5777f);
        this.\u001B.Multiline = true;
        this.\u001B.Name = \u0005.\u0004.\u0001(7619);
        this.\u001B.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
        this.\u001B.SizeF = new SizeF(293.6871f, 58.41998f);
        this.\u001B.StylePriority.UseFont = false;
        this.\u001B.StylePriority.UseTextAlignment = false;
        this.\u001B.Text = \u0005.\u0004.\u0001(2690);
        this.\u001B.TextAlignment = TextAlignment.MiddleLeft;
        this.\u001C.Dpi = 254f;
        this.\u001C.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
        this.\u001C.LocationFloat = new PointFloat(1178.188f, 641.2339f);
        this.\u001C.Multiline = true;
        this.\u001C.Name = \u0005.\u0004.\u0001(7572);
        this.\u001C.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
        this.\u001C.SizeF = new SizeF(243.4183f, 58.42004f);
        this.\u001C.StylePriority.UseFont = false;
        this.\u001C.StylePriority.UseTextAlignment = false;
        this.\u001C.Text = \u0005.\u0004.\u0001(10569);
        this.\u001C.TextAlignment = TextAlignment.MiddleLeft;
        this.\u001D.BorderDashStyle = BorderDashStyle.Dot;
        this.\u001D.Borders = BorderSide.None;
        XRBindingCollection dataBindings4 = this.\u001D.DataBindings;
        xrBindingArray1 = new XRBinding[1]
        {
          new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(2080), \u0005.\u0004.\u0001(7474))
        };
        XRBinding[] bindings4 = xrBindingArray1;
        dataBindings4.AddRange(bindings4);
        this.\u001D.Dpi = 254f;
        this.\u001D.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
        this.\u001D.LocationFloat = new PointFloat(1461.294f, 641.2339f);
        this.\u001D.Multiline = true;
        this.\u001D.Name = \u0005.\u0004.\u0001(7525);
        this.\u001D.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
        this.\u001D.SizeF = new SizeF(394.23f, 58.42004f);
        this.\u001D.StylePriority.UseBorderDashStyle = false;
        this.\u001D.StylePriority.UseBorders = false;
        do
        {
          this.\u001D.StylePriority.UseFont = false;
          this.\u001D.StylePriority.UseTextAlignment = false;
          this.\u001D.Text = \u0005.\u0004.\u0001(7504);
          this.\u001D.TextAlignment = TextAlignment.MiddleLeft;
          this.\u001E.Dpi = 254f;
          this.\u001E.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u001E.LocationFloat = new PointFloat(1178.188f, 701.0652f);
          this.\u001E.Multiline = true;
          this.\u001E.Name = \u0005.\u0004.\u0001(7538);
          this.\u001E.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u001E.SizeF = new SizeF(243.4183f, 58.42004f);
          this.\u001E.StylePriority.UseFont = false;
          this.\u001E.StylePriority.UseTextAlignment = false;
          this.\u001E.Text = \u0005.\u0004.\u0001(10569);
          this.\u001E.TextAlignment = TextAlignment.MiddleLeft;
          this.\u001F.Dpi = 254f;
          this.\u001F.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u001F.LocationFloat = new PointFloat(405.2879f, 518.0439f);
          this.\u001F.Multiline = true;
          this.\u001F.Name = \u0005.\u0004.\u0001(8591);
          this.\u001F.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u001F.SizeF = new SizeF(39.6871f, 64.7699f);
          this.\u001F.StylePriority.UseFont = false;
          this.\u001F.StylePriority.UseTextAlignment = false;
          this.\u001F.Text = \u0005.\u0004.\u0001(8586);
          this.\u001F.TextAlignment = TextAlignment.MiddleLeft;
          this.\u007F.Dpi = 254f;
          this.\u007F.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u007F.LocationFloat = new PointFloat(1421.607f, 582.8139f);
          this.\u007F.Multiline = true;
          this.\u007F.Name = \u0005.\u0004.\u0001(8695);
          this.\u007F.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u007F.SizeF = new SizeF(39.68726f, 64.7699f);
          this.\u007F.StylePriority.UseFont = false;
          this.\u007F.StylePriority.UseTextAlignment = false;
          this.\u007F.Text = \u0005.\u0004.\u0001(8586);
          this.\u007F.TextAlignment = TextAlignment.MiddleLeft;
          this.\u0080.Dpi = 254f;
          this.\u0080.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0080.LocationFloat = new PointFloat(1421.607f, 641.2339f);
          this.\u0080.Multiline = true;
          this.\u0080.Name = \u0005.\u0004.\u0001(8708);
          this.\u0080.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u0080.SizeF = new SizeF(39.68726f, 64.7699f);
          this.\u0080.StylePriority.UseFont = false;
          this.\u0080.StylePriority.UseTextAlignment = false;
          this.\u0080.Text = \u0005.\u0004.\u0001(8586);
          this.\u0080.TextAlignment = TextAlignment.MiddleLeft;
          this.\u0081.Dpi = 254f;
          this.\u0081.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0081.LocationFloat = new PointFloat(1421.607f, 754.864f);
          this.\u0081.Multiline = true;
          this.\u0081.Name = \u0005.\u0004.\u0001(8734);
          this.\u0081.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u0081.SizeF = new SizeF(39.68726f, 64.76984f);
          this.\u0081.StylePriority.UseFont = false;
          this.\u0081.StylePriority.UseTextAlignment = false;
          this.\u0081.Text = \u0005.\u0004.\u0001(8586);
          this.\u0081.TextAlignment = TextAlignment.MiddleLeft;
          this.\u0082.Dpi = 254f;
          this.\u0082.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0082.LocationFloat = new PointFloat(1421.607f, 694.1871f);
          this.\u0082.Multiline = true;
          this.\u0082.Name = \u0005.\u0004.\u0001(8721);
          this.\u0082.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u0082.SizeF = new SizeF(39.68726f, 64.7699f);
          this.\u0082.StylePriority.UseFont = false;
          this.\u0082.StylePriority.UseTextAlignment = false;
          this.\u0082.Text = \u0005.\u0004.\u0001(8586);
          this.\u0082.TextAlignment = TextAlignment.MiddleLeft;
          this.\u0083.Dpi = 254f;
          this.\u0083.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0083.LocationFloat = new PointFloat(1421.607f, 459.624f);
          this.\u0083.Multiline = true;
          this.\u0083.Name = \u0005.\u0004.\u0001(8669);
          this.\u0083.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u0083.SizeF = new SizeF(39.68726f, 64.7699f);
          this.\u0083.StylePriority.UseFont = false;
          this.\u0083.StylePriority.UseTextAlignment = false;
          this.\u0083.Text = \u0005.\u0004.\u0001(8586);
          this.\u0083.TextAlignment = TextAlignment.MiddleLeft;
          this.\u0084.Dpi = 254f;
          this.\u0084.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0084.LocationFloat = new PointFloat(641.9316f, 642.6452f);
          this.\u0084.Multiline = true;
          this.\u0084.Name = \u0005.\u0004.\u0001(8617);
          this.\u0084.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u0084.SizeF = new SizeF(39.68713f, 64.76984f);
          this.\u0084.StylePriority.UseFont = false;
          this.\u0084.StylePriority.UseTextAlignment = false;
          this.\u0084.Text = \u0005.\u0004.\u0001(8586);
          this.\u0084.TextAlignment = TextAlignment.MiddleLeft;
          this.\u0086.Dpi = 254f;
          this.\u0086.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0086.LocationFloat = new PointFloat(405.2879f, 577.8752f);
          this.\u0086.Multiline = true;
          this.\u0086.Name = \u0005.\u0004.\u0001(8604);
          this.\u0086.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u0086.SizeF = new SizeF(39.6871f, 64.7699f);
          this.\u0086.StylePriority.UseFont = false;
          this.\u0086.StylePriority.UseTextAlignment = false;
          this.\u0086.Text = \u0005.\u0004.\u0001(8586);
          this.\u0086.TextAlignment = TextAlignment.MiddleLeft;
          this.\u0087.Dpi = 254f;
          this.\u0087.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0087.LocationFloat = new PointFloat(641.9316f, 694.1874f);
          this.\u0087.Multiline = true;
          this.\u0087.Name = \u0005.\u0004.\u0001(8630);
          this.\u0087.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u0087.SizeF = new SizeF(39.68713f, 64.7699f);
          this.\u0087.StylePriority.UseFont = false;
          this.\u0087.StylePriority.UseTextAlignment = false;
          this.\u0087.Text = \u0005.\u0004.\u0001(8586);
          this.\u0087.TextAlignment = TextAlignment.MiddleLeft;
          this.\u0088.Dpi = 254f;
          this.\u0088.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0088.LocationFloat = new PointFloat(405.2879f, 820.6903f);
          this.\u0088.Multiline = true;
          this.\u0088.Name = \u0005.\u0004.\u0001(8656);
          this.\u0088.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u0088.SizeF = new SizeF(39.68713f, 57.36353f);
          this.\u0088.StylePriority.UseFont = false;
          this.\u0088.StylePriority.UseTextAlignment = false;
          this.\u0088.Text = \u0005.\u0004.\u0001(8586);
          this.\u0088.TextAlignment = TextAlignment.MiddleLeft;
          this.\u0089.Dpi = 254f;
          this.\u0089.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0089.LocationFloat = new PointFloat(641.9316f, 761.2139f);
          this.\u0089.Multiline = true;
          this.\u0089.Name = \u0005.\u0004.\u0001(8643);
          this.\u0089.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u0089.SizeF = new SizeF(39.68707f, 57.36371f);
          this.\u0089.StylePriority.UseFont = false;
          this.\u0089.StylePriority.UseTextAlignment = false;
          this.\u0089.Text = \u0005.\u0004.\u0001(8586);
          this.\u0089.TextAlignment = TextAlignment.MiddleLeft;
          this.\u008A.Dpi = 254f;
          this.\u008A.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u008A.LocationFloat = new PointFloat(1324.029f, 1005.8f);
          this.\u008A.Multiline = true;
          this.\u008A.Name = \u0005.\u0004.\u0001(8056);
          this.\u008A.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u008A.SizeF = new SizeF(317.5002f, 58.41998f);
          this.\u008A.StylePriority.UseFont = false;
          this.\u008A.Text = \u0005.\u0004.\u0001(8069);
          this.\u008B.Dpi = 254f;
          this.\u008B.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u008B.LocationFloat = new PointFloat(1178.189f, 761.2139f);
          this.\u008B.Multiline = true;
          this.\u008B.Name = \u0005.\u0004.\u0001(8090);
          this.\u008B.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u008B.SizeF = new SizeF(232.8334f, 58.41992f);
          this.\u008B.StylePriority.UseFont = false;
          this.\u008B.StylePriority.UseTextAlignment = false;
          this.\u008B.Text = \u0005.\u0004.\u0001(8103);
          this.\u008B.TextAlignment = TextAlignment.MiddleLeft;
          this.\u008C.BorderDashStyle = BorderDashStyle.Dot;
          this.\u008C.Borders = BorderSide.None;
          XRBindingCollection dataBindings5 = this.\u008C.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(1617))
          };
          XRBinding[] bindings5 = xrBindingArray1;
          dataBindings5.AddRange(bindings5);
          this.\u008C.Dpi = 254f;
          this.\u008C.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u008C.LocationFloat = new PointFloat(439.6839f, 582.8139f);
          this.\u008C.Multiline = true;
          this.\u008C.Name = \u0005.\u0004.\u0001(8043);
          this.\u008C.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u008C.SizeF = new SizeF(639.2336f, 58.41998f);
          this.\u008C.StylePriority.UseBorderDashStyle = false;
          this.\u008C.StylePriority.UseBorders = false;
          this.\u008C.StylePriority.UseFont = false;
          this.\u008C.StylePriority.UseTextAlignment = false;
          this.\u008C.Text = \u0005.\u0004.\u0001(7728);
          this.\u008C.TextAlignment = TextAlignment.MiddleLeft;
          this.\u008D.Dpi = 254f;
          this.\u008D.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u008D.LocationFloat = new PointFloat(935.5444f, 641.2339f);
          this.\u008D.Multiline = true;
          this.\u008D.Name = \u0005.\u0004.\u0001(8017);
          this.\u008D.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u008D.SizeF = new SizeF(105.8333f, 58.42004f);
          this.\u008D.StylePriority.UseFont = false;
          this.\u008D.StylePriority.UseTextAlignment = false;
          this.\u008D.Text = \u0005.\u0004.\u0001(7710);
          this.\u008D.TextAlignment = TextAlignment.MiddleLeft;
          this.\u008E.BorderDashStyle = BorderDashStyle.Dot;
          this.\u008E.Borders = BorderSide.None;
          XRBindingCollection dataBindings6 = this.\u008E.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(1661), \u0005.\u0004.\u0001(10586))
          };
          XRBinding[] bindings6 = xrBindingArray1;
          dataBindings6.AddRange(bindings6);
          this.\u008E.Dpi = 254f;
          this.\u008E.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u008E.LocationFloat = new PointFloat(685.8528f, 641.2339f);
          this.\u008E.Multiline = true;
          this.\u008E.Name = \u0005.\u0004.\u0001(8030);
          this.\u008E.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u008E.SizeF = new SizeF(242.3584f, 58.42004f);
          this.\u008E.StylePriority.UseBorderDashStyle = false;
          this.\u008E.StylePriority.UseBorders = false;
          this.\u008E.StylePriority.UseFont = false;
          this.\u008E.StylePriority.UseTextAlignment = false;
          this.\u008E.Text = \u0005.\u0004.\u0001(7728);
          this.\u008E.TextAlignment = TextAlignment.MiddleRight;
          this.\u008F.Dpi = 254f;
          this.\u008F.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u008F.LocationFloat = new PointFloat(103.9811f, 584.2252f);
          this.\u008F.Multiline = true;
          this.\u008F.Name = \u0005.\u0004.\u0001(8124);
          this.\u008F.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u008F.SizeF = new SizeF(293.687f, 58.41998f);
          this.\u008F.StylePriority.UseFont = false;
          this.\u008F.StylePriority.UseTextAlignment = false;
          this.\u008F.Text = \u0005.\u0004.\u0001(1604);
          this.\u008F.TextAlignment = TextAlignment.MiddleLeft;
          XRBindingCollection dataBindings7 = this.\u0090.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(this.\u0008, \u0005.\u0004.\u0001(3154), \u0005.\u0004.\u0001(720))
          };
          XRBinding[] bindings7 = xrBindingArray1;
          dataBindings7.AddRange(bindings7);
          this.\u0090.Dpi = 254f;
          this.\u0090.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0090.LocationFloat = new PointFloat(1053.094f, 907.6922f);
          this.\u0090.Name = \u0005.\u0004.\u0001(8267);
          this.\u0090.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u0090.SizeF = new SizeF(717.0206f, 58.41998f);
          this.\u0090.StylePriority.UseFont = false;
          this.\u0090.StylePriority.UseTextAlignment = false;
          this.\u0090.Text = \u0005.\u0004.\u0001(8267);
          this.\u0090.TextAlignment = TextAlignment.MiddleCenter;
          this.\u0091.Dpi = 254f;
          this.\u0091.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0091.LocationFloat = new PointFloat(1175.543f, 582.8139f);
          this.\u0091.Multiline = true;
          this.\u0091.Name = \u0005.\u0004.\u0001(8530);
          this.\u0091.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u0091.SizeF = new SizeF(246.0634f, 58.41998f);
          this.\u0091.StylePriority.UseFont = false;
          this.\u0091.StylePriority.UseTextAlignment = false;
          this.\u0091.Text = \u0005.\u0004.\u0001(8543);
          this.\u0091.TextAlignment = TextAlignment.MiddleLeft;
          this.\u0092.Dpi = 254f;
          this.\u0092.Font = new Font(\u0005.\u0004.\u0001(7365), 17f, FontStyle.Bold);
          this.\u0092.LocationFloat = new PointFloat(634.5237f, 343.7743f);
          this.\u0092.Multiline = true;
          this.\u0092.Name = \u0005.\u0004.\u0001(8229);
          this.\u0092.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u0092.SizeF = new SizeF(762.0002f, 90.76703f);
          this.\u0092.StylePriority.UseFont = false;
          this.\u0092.StylePriority.UseTextAlignment = false;
          this.\u0092.Text = \u0005.\u0004.\u0001(8242);
          this.\u0092.TextAlignment = TextAlignment.MiddleCenter;
          this.\u0093.Dpi = 254f;
          this.\u0093.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0093.LocationFloat = new PointFloat(103.9811f, 642.6452f);
          this.\u0093.Multiline = true;
          this.\u0093.Name = \u0005.\u0004.\u0001(8137);
          this.\u0093.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u0093.SizeF = new SizeF(532.8706f, 58.41998f);
          this.\u0093.StylePriority.UseFont = false;
          this.\u0093.StylePriority.UseTextAlignment = false;
          this.\u0093.Text = \u0005.\u0004.\u0001(8150);
          this.\u0093.TextAlignment = TextAlignment.MiddleJustify;
          this.\u0094.Dpi = 254f;
          this.\u0094.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0094.LocationFloat = new PointFloat(1178.189f, 459.624f);
          this.\u0094.Multiline = true;
          this.\u0094.Name = \u0005.\u0004.\u0001(8195);
          this.\u0094.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u0094.SizeF = new SizeF(243.4181f, 58.41998f);
          this.\u0094.StylePriority.UseFont = false;
          this.\u0094.StylePriority.UseTextAlignment = false;
          this.\u0094.Text = \u0005.\u0004.\u0001(8208);
          this.\u0094.TextAlignment = TextAlignment.MiddleLeft;
          this.\u0095.BorderDashStyle = BorderDashStyle.Dot;
          this.\u0095.Borders = BorderSide.None;
          XRBindingCollection dataBindings8 = this.\u0095.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(1525))
          };
          XRBinding[] bindings8 = xrBindingArray1;
          dataBindings8.AddRange(bindings8);
          this.\u0095.Dpi = 254f;
          this.\u0095.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0095.LocationFloat = new PointFloat(1461.294f, 459.624f);
          this.\u0095.Multiline = true;
          this.\u0095.Name = \u0005.\u0004.\u0001(7983);
          this.\u0095.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u0095.SizeF = new SizeF(394.2303f, 58.41998f);
          this.\u0095.StylePriority.UseBorderDashStyle = false;
          this.\u0095.StylePriority.UseBorders = false;
          this.\u0095.StylePriority.UseFont = false;
          this.\u0095.StylePriority.UseTextAlignment = false;
          this.\u0095.Text = \u0005.\u0004.\u0001(7996);
          this.\u0095.TextAlignment = TextAlignment.MiddleLeft;
          this.\u0096.Dpi = 254f;
          this.\u0096.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0096.LocationFloat = new PointFloat(103.9811f, 760.1577f);
          this.\u0096.Multiline = true;
          this.\u0096.Name = \u0005.\u0004.\u0001(7745);
          this.\u0096.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u0096.SizeF = new SizeF(532.8704f, 58.41998f);
          this.\u0096.StylePriority.UseFont = false;
          this.\u0096.StylePriority.UseTextAlignment = false;
          this.\u0096.Text = \u0005.\u0004.\u0001(7758);
          this.\u0096.TextAlignment = TextAlignment.MiddleJustify;
          this.\u0097.Dpi = 254f;
          this.\u0097.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0097.LocationFloat = new PointFloat(935.5444f, 701.0652f);
          this.\u0097.Multiline = true;
          this.\u0097.Name = \u0005.\u0004.\u0001(7791);
          this.\u0097.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u0097.SizeF = new SizeF(105.8333f, 58.42004f);
          this.\u0097.StylePriority.UseFont = false;
          this.\u0097.StylePriority.UseTextAlignment = false;
          this.\u0097.Text = \u0005.\u0004.\u0001(7710);
          this.\u0097.TextAlignment = TextAlignment.MiddleLeft;
          this.\u0098.BorderDashStyle = BorderDashStyle.Dot;
          this.\u0098.Borders = BorderSide.None;
          XRBindingCollection dataBindings9 = this.\u0098.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(1825), \u0005.\u0004.\u0001(10586))
          };
          XRBinding[] bindings9 = xrBindingArray1;
          dataBindings9.AddRange(bindings9);
          this.\u0098.Dpi = 254f;
          this.\u0098.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0098.LocationFloat = new PointFloat(685.8528f, 761.2139f);
          this.\u0098.Multiline = true;
          this.\u0098.Name = \u0005.\u0004.\u0001(7715);
          this.\u0098.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u0098.SizeF = new SizeF(242.3584f, 58.41998f);
          this.\u0098.StylePriority.UseBorderDashStyle = false;
          this.\u0098.StylePriority.UseBorders = false;
          this.\u0098.StylePriority.UseFont = false;
          this.\u0098.StylePriority.UseTextAlignment = false;
          this.\u0098.Text = \u0005.\u0004.\u0001(7728);
          this.\u0098.TextAlignment = TextAlignment.MiddleRight;
          this.\u0099.Dpi = 254f;
          this.\u0099.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0099.LocationFloat = new PointFloat(685.8527f, 1005.8f);
          this.\u0099.Multiline = true;
          this.\u0099.Name = \u0005.\u0004.\u0001(7663);
          this.\u0099.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u0099.SizeF = new SizeF(317.5002f, 58.41998f);
          this.\u0099.StylePriority.UseFont = false;
          this.\u0099.Text = \u0005.\u0004.\u0001(7676);
          this.\u009A.Dpi = 254f;
          this.\u009A.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u009A.LocationFloat = new PointFloat(935.5444f, 761.2139f);
          this.\u009A.Multiline = true;
          this.\u009A.Name = \u0005.\u0004.\u0001(7697);
          this.\u009A.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u009A.SizeF = new SizeF(105.8333f, 58.41998f);
          this.\u009A.StylePriority.UseFont = false;
          this.\u009A.StylePriority.UseTextAlignment = false;
          this.\u009A.Text = \u0005.\u0004.\u0001(7710);
          this.\u009A.TextAlignment = TextAlignment.MiddleLeft;
          this.\u009B.BorderDashStyle = BorderDashStyle.Dot;
          this.\u009B.Borders = BorderSide.None;
          XRBindingCollection dataBindings10 = this.\u009B.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(1700), \u0005.\u0004.\u0001(10586))
          };
          XRBinding[] bindings10 = xrBindingArray1;
          dataBindings10.AddRange(bindings10);
          this.\u009B.Dpi = 254f;
          this.\u009B.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u009B.LocationFloat = new PointFloat(685.8528f, 701.0652f);
          this.\u009B.Multiline = true;
          this.\u009B.Name = \u0005.\u0004.\u0001(7804);
          this.\u009B.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u009B.SizeF = new SizeF(242.3584f, 58.42004f);
          this.\u009B.StylePriority.UseBorderDashStyle = false;
          this.\u009B.StylePriority.UseBorders = false;
          this.\u009B.StylePriority.UseFont = false;
          this.\u009B.StylePriority.UseTextAlignment = false;
          this.\u009B.Text = \u0005.\u0004.\u0001(7728);
          this.\u009B.TextAlignment = TextAlignment.MiddleRight;
          this.\u009C.Dpi = 254f;
          this.\u009C.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u009C.LocationFloat = new PointFloat(103.9811f, 459.624f);
          this.\u009C.Multiline = true;
          this.\u009C.Name = \u0005.\u0004.\u0001(7919);
          this.\u009C.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u009C.SizeF = new SizeF(293.687f, 64.7699f);
          this.\u009C.StylePriority.UseFont = false;
          this.\u009C.StylePriority.UseTextAlignment = false;
          this.\u009C.Text = \u0005.\u0004.\u0001(7932);
          this.\u009C.TextAlignment = TextAlignment.MiddleLeft;
          this.\u009D.BorderDashStyle = BorderDashStyle.Dot;
          this.\u009D.Borders = BorderSide.None;
          XRBindingCollection dataBindings11 = this.\u009D.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(2668))
          };
          XRBinding[] bindings11 = xrBindingArray1;
          dataBindings11.AddRange(bindings11);
          this.\u009D.Dpi = 254f;
          this.\u009D.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u009D.LocationFloat = new PointFloat(439.6839f, 524.394f);
          this.\u009D.Multiline = true;
          this.\u009D.Name = \u0005.\u0004.\u0001(7949);
          this.\u009D.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u009D.SizeF = new SizeF(639.2339f, 58.41998f);
          this.\u009D.StylePriority.UseBorderDashStyle = false;
          this.\u009D.StylePriority.UseBorders = false;
          this.\u009D.StylePriority.UseFont = false;
          this.\u009D.StylePriority.UseTextAlignment = false;
          this.\u009D.Text = \u0005.\u0004.\u0001(7962);
          this.\u009D.TextAlignment = TextAlignment.MiddleLeft;
          this.\u009E.BorderDashStyle = BorderDashStyle.Dot;
          this.\u009E.Borders = BorderSide.None;
          XRBindingCollection dataBindings12 = this.\u009E.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(1574))
          };
          XRBinding[] bindings12 = xrBindingArray1;
          dataBindings12.AddRange(bindings12);
          this.\u009E.Dpi = 254f;
          this.\u009E.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u009E.LocationFloat = new PointFloat(439.6839f, 459.624f);
          this.\u009E.Multiline = true;
          this.\u009E.Name = \u0005.\u0004.\u0001(7906);
          this.\u009E.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u009E.SizeF = new SizeF(639.2336f, 64.7699f);
          this.\u009E.StylePriority.UseBorderDashStyle = false;
          this.\u009E.StylePriority.UseBorders = false;
          this.\u009E.StylePriority.UseFont = false;
          this.\u009E.StylePriority.UseTextAlignment = false;
          this.\u009E.Text = \u0005.\u0004.\u0001(7728);
          this.\u009E.TextAlignment = TextAlignment.MiddleLeft;
          this.\u009F.Dpi = 254f;
          this.\u009F.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u009F.LocationFloat = new PointFloat(103.9811f, 700.5372f);
          this.\u009F.Multiline = true;
          this.\u009F.Name = \u0005.\u0004.\u0001(7817);
          this.\u009F.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u009F.SizeF = new SizeF(532.8706f, 58.41998f);
          this.\u009F.StylePriority.UseFont = false;
          this.\u009F.StylePriority.UseTextAlignment = false;
          this.\u009F.Text = \u0005.\u0004.\u0001(7830);
          this.\u009F.TextAlignment = TextAlignment.MiddleJustify;
          this.\u0001\u0002.BorderDashStyle = BorderDashStyle.Dot;
          this.\u0001\u0002.Borders = BorderSide.None;
          XRBindingCollection dataBindings13 = this.\u0001\u0002.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(7859))
          };
          XRBinding[] bindings13 = xrBindingArray1;
          dataBindings13.AddRange(bindings13);
          this.\u0001\u0002.Dpi = 254f;
          this.\u0001\u0002.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0001\u0002.LocationFloat = new PointFloat(1461.294f, 761.2139f);
          this.\u0001\u0002.Multiline = true;
          this.\u0001\u0002.Name = \u0005.\u0004.\u0001(7872);
          this.\u0001\u0002.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u0001\u0002.SizeF = new SizeF(394.23f, 58.41998f);
          this.\u0001\u0002.StylePriority.UseBorderDashStyle = false;
          this.\u0001\u0002.StylePriority.UseBorders = false;
          this.\u0001\u0002.StylePriority.UseFont = false;
          this.\u0001\u0002.StylePriority.UseTextAlignment = false;
          this.\u0001\u0002.Text = \u0005.\u0004.\u0001(7885);
          this.\u0001\u0002.TextAlignment = TextAlignment.MiddleLeft;
          XRBindingCollection dataBindings14 = this.\u0012.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(this.\u0007, \u0005.\u0004.\u0001(3154), \u0005.\u0004.\u0001(720))
          };
          XRBinding[] bindings14 = xrBindingArray1;
          dataBindings14.AddRange(bindings14);
          this.\u0012.Dpi = 254f;
          this.\u0012.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0012.LocationFloat = new PointFloat(74.0835f, 225.0293f);
          this.\u0012.Name = \u0005.\u0004.\u0001(8364);
          this.\u0012.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u0012.SizeF = new SizeF(915.4584f, 106.0451f);
          this.\u0012.StylePriority.UseFont = false;
          this.\u0012.StylePriority.UseTextAlignment = false;
          this.\u0012.Text = \u0005.\u0004.\u0001(8377);
          this.\u0012.TextAlignment = TextAlignment.MiddleLeft;
          XRBindingCollection dataBindings15 = this.\u0013.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(this.\u000E, \u0005.\u0004.\u0001(3154), \u0005.\u0004.\u0001(720))
          };
          XRBinding[] bindings15 = xrBindingArray1;
          dataBindings15.AddRange(bindings15);
          this.\u0013.Dpi = 254f;
          this.\u0013.Font = new Font(\u0005.\u0004.\u0001(7365), 15f, FontStyle.Bold);
          this.\u0013.LocationFloat = new PointFloat(74.08334f, 43.10178f);
          this.\u0013.Name = \u0005.\u0004.\u0001(8280);
          this.\u0013.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u0013.SizeF = new SizeF(915.4584f, 97.04922f);
          this.\u0013.StylePriority.UseFont = false;
          this.\u0013.StylePriority.UseTextAlignment = false;
          this.\u0013.Text = \u0005.\u0004.\u0001(8293);
          this.\u0013.TextAlignment = TextAlignment.MiddleLeft;
          XRBindingCollection dataBindings16 = this.\u0014.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(this.\u0006, \u0005.\u0004.\u0001(3154), \u0005.\u0004.\u0001(720))
          };
          XRBinding[] bindings16 = xrBindingArray1;
          dataBindings16.AddRange(bindings16);
          this.\u0014.Dpi = 254f;
          this.\u0014.Font = new Font(\u0005.\u0004.\u0001(7365), 13f);
          this.\u0014.LocationFloat = new PointFloat(74.0835f, 140.151f);
          this.\u0014.Name = \u0005.\u0004.\u0001(8310);
          this.\u0014.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u0014.SizeF = new SizeF(915.4584f, 84.8783f);
          this.\u0014.StylePriority.UseFont = false;
          this.\u0014.StylePriority.UseTextAlignment = false;
          this.\u0014.Text = \u0005.\u0004.\u0001(8323);
          this.\u0014.TextAlignment = TextAlignment.MiddleLeft;
          XRBindingCollection dataBindings17 = this.\u0010.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(this.\u0011, \u0005.\u0004.\u0001(3154), \u0005.\u0004.\u0001(720))
          };
          XRBinding[] bindings17 = xrBindingArray1;
          dataBindings17.AddRange(bindings17);
          this.\u0010.Dpi = 254f;
          this.\u0010.Font = new Font(\u0005.\u0004.\u0001(7365), 12f);
          this.\u0010.LocationFloat = new PointFloat(0.0f, 1303.899f);
          this.\u0010.Name = \u0005.\u0004.\u0001(8773);
          this.\u0010.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
          this.\u0010.SizeF = new SizeF(1855.525f, 58.42004f);
          this.\u0010.StylePriority.UseFont = false;
          this.\u0010.StylePriority.UseTextAlignment = false;
          this.\u0010.Text = \u0005.\u0004.\u0001(8773);
          this.\u0010.TextAlignment = TextAlignment.MiddleCenter;
          this.\u0011.Description = \u0005.\u0004.\u0001(7403);
          this.\u0011.Name = \u0005.\u0004.\u0001(7420);
          this.\u0011.ValueInfo = \u0005.\u0004.\u0001(10595);
          this.\u0011.Visible = false;
          this.\u0005.DataSource = (object) typeof (XeHang);
        }
        while (false);
        BandCollection bands1 = this.Bands;
        bandArray1 = new Band[4]
        {
          (Band) this.\u0002,
          (Band) this.\u0003,
          (Band) this.\u0004,
          (Band) this.\u000F
        };
        Band[] bands2 = bandArray1;
        bands1.AddRange(bands2);
        this.DataSource = (object) this.\u0005;
        this.Dpi = 254f;
        this.Margins = new Margins(122, 8, 0, 0);
        this.PageHeight = 1480;
        this.PageWidth = 2100;
        this.PaperKind = PaperKind.A5Rotated;
        ParameterCollection parameters1 = this.Parameters;
        parameterArray1 = new Parameter[5]
        {
          this.\u0006,
          this.\u0007,
          this.\u0008,
          this.\u000E,
          this.\u0011
        };
        Parameter[] parameters2 = parameterArray1;
        parameters1.AddRange(parameters2);
        this.ReportUnit = ReportUnit.TenthsOfAMillimeter;
        this.ShowPrintMarginsWarning = false;
        this.Version = \u0005.\u0004.\u0001(10656);
        ((ISupportInitialize) this.\u0005).EndInit();
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

    public \u0001()
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
          this.\u0001\u0002.Visible = true;
          this.\u008B.Visible = true;
        }
        else
        {
          this.\u0001\u0002.Visible = false;
          this.\u008B.Visible = false;
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
  }
}
