// Decompiled with JetBrains decompiler
// Type: .
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

namespace \u0001
{
  internal class \u0003 : XtraReport
  {
    private IContainer \u0001 = (IContainer) null;
    private DetailBand \u0002;
    private TopMarginBand \u0003;
    private BottomMarginBand \u0004;
    private ReportHeaderBand \u0005;
    private Parameter \u0006;
    private PageHeaderBand \u0007;
    private GroupFooterBand \u0008;
    private XRLabel \u000E;
    private XRLabel \u000F;
    private XRLabel \u0010;
    private XRLabel \u0011;
    private XRLabel \u0012;
    private Parameter \u0013;
    private XRTable \u0014;
    private XRTableRow \u0015;
    private XRTableCell \u0016;
    private XRTableCell \u0017;
    private XRTableCell \u0018;
    private XRTableCell \u0019;
    private XRTableCell \u001A;
    private XRTableCell \u001B;
    private XRTable \u001C;
    private XRTableRow \u001D;
    private XRTableCell \u001E;
    private XRTableCell \u001F;
    private XRTableCell \u007F;
    private XRTableCell \u0080;
    private XRTableCell \u0081;
    private XRTableCell \u0082;
    private XRTableCell \u0083;
    private XRTableCell \u0084;
    private XRTableCell \u0086;
    private XRTableCell \u0087;
    private XRTableCell \u0088;
    private XRTableCell \u0089;
    private XRTableCell \u008A;
    private XRTableCell \u008B;
    private XRTable \u008C;
    private XRTableRow \u008D;
    private XRTableCell \u008E;
    private XRTableCell \u008F;
    private BindingSource \u0090;
    private XRPageInfo \u0091;
    private XRPageInfo \u0092;
    private Parameter \u0093;
    private Parameter \u0094;
    private XRTableCell \u0095;
    private XRTableCell \u0096;
    private XRTableCell \u0097;
    private XRLabel \u0098;
    private Parameter \u0099;

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
      XRTableRow[] xrTableRowArray1;
      XRTableCell[] xrTableCellArray1;
      XRBinding[] xrBindingArray1;
      XRSummary xrSummary1;
      XRSummary xrSummary2;
      XRSummary xrSummary3;
      Band[] bandArray1;
      Parameter[] parameterArray1;
      try
      {
        this.\u0001 = (IContainer) new System.ComponentModel.Container();
        xrSummary1 = new XRSummary();
        xrSummary2 = new XRSummary();
        xrSummary3 = new XRSummary();
        this.\u0002 = new DetailBand();
        this.\u001C = new XRTable();
        this.\u001D = new XRTableRow();
        this.\u001E = new XRTableCell();
        this.\u001F = new XRTableCell();
        this.\u007F = new XRTableCell();
        this.\u0080 = new XRTableCell();
        this.\u0081 = new XRTableCell();
        this.\u0096 = new XRTableCell();
        this.\u0082 = new XRTableCell();
        this.\u0083 = new XRTableCell();
        this.\u0084 = new XRTableCell();
        this.\u0086 = new XRTableCell();
        this.\u0087 = new XRTableCell();
        this.\u0003 = new TopMarginBand();
        this.\u0004 = new BottomMarginBand();
        this.\u0098 = new XRLabel();
        this.\u0099 = new Parameter();
        this.\u0091 = new XRPageInfo();
        this.\u0092 = new XRPageInfo();
        this.\u0005 = new ReportHeaderBand();
        this.\u0012 = new XRLabel();
        this.\u0006 = new Parameter();
        this.\u000E = new XRLabel();
        this.\u000F = new XRLabel();
        this.\u0093 = new Parameter();
        this.\u0010 = new XRLabel();
        this.\u0094 = new Parameter();
        this.\u0011 = new XRLabel();
        this.\u0013 = new Parameter();
        this.\u0007 = new PageHeaderBand();
        this.\u0014 = new XRTable();
        this.\u0015 = new XRTableRow();
        this.\u0016 = new XRTableCell();
        this.\u0017 = new XRTableCell();
        this.\u0018 = new XRTableCell();
        this.\u0019 = new XRTableCell();
        this.\u001A = new XRTableCell();
        this.\u0095 = new XRTableCell();
        this.\u0088 = new XRTableCell();
        this.\u0089 = new XRTableCell();
        this.\u008A = new XRTableCell();
        this.\u008B = new XRTableCell();
        this.\u001B = new XRTableCell();
        this.\u0008 = new GroupFooterBand();
        this.\u008C = new XRTable();
        this.\u008D = new XRTableRow();
        this.\u008E = new XRTableCell();
        this.\u0097 = new XRTableCell();
        this.\u008F = new XRTableCell();
        this.\u0090 = new BindingSource(this.\u0001);
        this.\u001C.BeginInit();
        this.\u0014.BeginInit();
        this.\u008C.BeginInit();
        ((ISupportInitialize) this.\u0090).BeginInit();
        this.BeginInit();
        XRControlCollection controls1 = this.\u0002.Controls;
        xrControlArray1 = new XRControl[1]
        {
          (XRControl) this.\u001C
        };
        XRControl[] controls2 = xrControlArray1;
        controls1.AddRange(controls2);
        this.\u0002.HeightF = 25f;
        this.\u0002.Name = \u0005.\u0004.\u0001(7309);
        this.\u0002.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
        this.\u0002.TextAlignment = TextAlignment.TopLeft;
        this.\u001C.BackColor = Color.White;
        this.\u001C.BorderDashStyle = BorderDashStyle.Dot;
        this.\u001C.LocationFloat = new PointFloat(0.0f, 0.0f);
        this.\u001C.Name = \u0005.\u0004.\u0001(9502);
        XRTableRowCollection rows1 = this.\u001C.Rows;
        xrTableRowArray1 = new XRTableRow[1]{ this.\u001D };
        XRTableRow[] rows2 = xrTableRowArray1;
        rows1.AddRange(rows2);
        this.\u001C.SizeF = new SizeF(1130f, 25f);
        this.\u001C.StylePriority.UseBackColor = false;
        this.\u001C.StylePriority.UseBorderDashStyle = false;
        this.\u001C.StylePriority.UseTextAlignment = false;
        this.\u001C.TextAlignment = TextAlignment.MiddleCenter;
        this.\u001D.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
        XRTableCellCollection cells1 = this.\u001D.Cells;
        xrTableCellArray1 = new XRTableCell[11]
        {
          this.\u001E,
          this.\u001F,
          this.\u007F,
          this.\u0080,
          this.\u0081,
          this.\u0096,
          this.\u0082,
          this.\u0083,
          this.\u0084,
          this.\u0086,
          this.\u0087
        };
        XRTableCell[] cells2 = xrTableCellArray1;
        cells1.AddRange(cells2);
        this.\u001D.Name = \u0005.\u0004.\u0001(9515);
        this.\u001D.StylePriority.UseBorders = false;
        this.\u001D.Weight = 1.0;
        this.\u001E.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
        XRBindingCollection dataBindings1 = this.\u001E.DataBindings;
        xrBindingArray1 = new XRBinding[1]
        {
          new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(1574))
        };
        XRBinding[] bindings1 = xrBindingArray1;
        dataBindings1.AddRange(bindings1);
        this.\u001E.Multiline = true;
        this.\u001E.Name = \u0005.\u0004.\u0001(9532);
        this.\u001E.Padding = new PaddingInfo(2, 2, 2, 2, 100f);
        this.\u001E.StylePriority.UseBorders = false;
        this.\u001E.StylePriority.UsePadding = false;
        this.\u001E.Text = \u0005.\u0004.\u0001(9553);
        this.\u001E.Weight = 0.16284704344061635;
        this.\u001F.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
        XRBindingCollection dataBindings2 = this.\u001F.DataBindings;
        xrBindingArray1 = new XRBinding[1]
        {
          new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(2036), \u0005.\u0004.\u0001(9562))
        };
        XRBinding[] bindings2 = xrBindingArray1;
        dataBindings2.AddRange(bindings2);
        this.\u001F.Multiline = true;
        this.\u001F.Name = \u0005.\u0004.\u0001(9583);
        this.\u001F.Padding = new PaddingInfo(2, 2, 2, 2, 100f);
        this.\u001F.StylePriority.UseBorders = false;
        this.\u001F.StylePriority.UsePadding = false;
        this.\u001F.StylePriority.UseTextAlignment = false;
        this.\u001F.Text = \u0005.\u0004.\u0001(9604);
        this.\u001F.TextAlignment = TextAlignment.MiddleLeft;
        this.\u001F.Weight = 0.27379151293002779;
        this.\u007F.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
        XRBindingCollection dataBindings3 = this.\u007F.DataBindings;
        xrBindingArray1 = new XRBinding[1]
        {
          new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(2668))
        };
        XRBinding[] bindings3 = xrBindingArray1;
        dataBindings3.AddRange(bindings3);
        if (true)
        {
          this.\u007F.Multiline = true;
          this.\u007F.Name = \u0005.\u0004.\u0001(9617);
          this.\u007F.Padding = new PaddingInfo(2, 2, 2, 2, 100f);
          this.\u007F.StylePriority.UseBorders = false;
          this.\u007F.StylePriority.UsePadding = false;
          this.\u007F.StylePriority.UseTextAlignment = false;
          this.\u007F.Text = \u0005.\u0004.\u0001(7962);
          this.\u007F.TextAlignment = TextAlignment.MiddleLeft;
          this.\u007F.Weight = 0.5107298927461571;
          this.\u0080.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
          XRBindingCollection dataBindings4 = this.\u0080.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(1525))
          };
          XRBinding[] bindings4 = xrBindingArray1;
          dataBindings4.AddRange(bindings4);
          this.\u0080.Multiline = true;
          this.\u0080.Name = \u0005.\u0004.\u0001(9638);
          this.\u0080.Padding = new PaddingInfo(2, 2, 2, 2, 100f);
          this.\u0080.StylePriority.UseBorders = false;
          this.\u0080.StylePriority.UsePadding = false;
          this.\u0080.StylePriority.UseTextAlignment = false;
          this.\u0080.Text = \u0005.\u0004.\u0001(9659);
          this.\u0080.TextAlignment = TextAlignment.MiddleLeft;
          this.\u0080.Weight = 0.33506844833312244;
          this.\u0081.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
          XRBindingCollection dataBindings5 = this.\u0081.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(1661))
          };
          XRBinding[] bindings5 = xrBindingArray1;
          dataBindings5.AddRange(bindings5);
          this.\u0081.Multiline = true;
          this.\u0081.Name = \u0005.\u0004.\u0001(9680);
          this.\u0081.Padding = new PaddingInfo(2, 2, 2, 2, 100f);
          this.\u0081.StylePriority.UseBorders = false;
          this.\u0081.StylePriority.UsePadding = false;
          this.\u0081.StylePriority.UseTextAlignment = false;
          this.\u0081.Text = \u0005.\u0004.\u0001(9701);
          this.\u0081.TextAlignment = TextAlignment.MiddleRight;
          this.\u0081.Weight = 0.20627296571306858;
          this.\u0096.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
          XRBindingCollection dataBindings6 = this.\u0096.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(1700))
          };
          XRBinding[] bindings6 = xrBindingArray1;
          dataBindings6.AddRange(bindings6);
          this.\u0096.Name = \u0005.\u0004.\u0001(9722);
          this.\u0096.Padding = new PaddingInfo(2, 2, 2, 2, 100f);
          this.\u0096.StylePriority.UseBorders = false;
          this.\u0096.StylePriority.UsePadding = false;
          this.\u0096.StylePriority.UseTextAlignment = false;
          this.\u0096.Text = \u0005.\u0004.\u0001(9722);
          this.\u0096.TextAlignment = TextAlignment.MiddleRight;
          this.\u0096.Weight = 0.1791812318566908;
          this.\u0082.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
          XRBindingCollection dataBindings7 = this.\u0082.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(1825))
          };
          XRBinding[] bindings7 = xrBindingArray1;
          dataBindings7.AddRange(bindings7);
          this.\u0082.Multiline = true;
          this.\u0082.Name = \u0005.\u0004.\u0001(9743);
          this.\u0082.Padding = new PaddingInfo(2, 2, 2, 2, 100f);
          this.\u0082.StylePriority.UseBorders = false;
          this.\u0082.StylePriority.UsePadding = false;
          this.\u0082.StylePriority.UseTextAlignment = false;
          this.\u0082.Text = \u0005.\u0004.\u0001(9764);
          this.\u0082.TextAlignment = TextAlignment.MiddleRight;
          this.\u0082.Weight = 0.25145503694436111;
          this.\u0083.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
          XRBindingCollection dataBindings8 = this.\u0083.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(1727))
          };
          XRBinding[] bindings8 = xrBindingArray1;
          dataBindings8.AddRange(bindings8);
          this.\u0083.Multiline = true;
          this.\u0083.Name = \u0005.\u0004.\u0001(9781);
          this.\u0083.Padding = new PaddingInfo(2, 2, 2, 2, 100f);
          this.\u0083.StylePriority.UseBorders = false;
          this.\u0083.StylePriority.UsePadding = false;
          this.\u0083.StylePriority.UseTextAlignment = false;
          this.\u0083.Text = \u0005.\u0004.\u0001(9802);
          this.\u0083.TextAlignment = TextAlignment.MiddleRight;
          this.\u0083.Weight = 0.17113133435445135;
          this.\u0084.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
          XRBindingCollection dataBindings9 = this.\u0084.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(1997))
          };
          XRBinding[] bindings9 = xrBindingArray1;
          dataBindings9.AddRange(bindings9);
          this.\u0084.Multiline = true;
          this.\u0084.Name = \u0005.\u0004.\u0001(9811);
          this.\u0084.Padding = new PaddingInfo(2, 2, 2, 2, 100f);
          this.\u0084.StylePriority.UseBorders = false;
          this.\u0084.StylePriority.UsePadding = false;
          this.\u0084.StylePriority.UseTextAlignment = false;
          this.\u0084.Text = \u0005.\u0004.\u0001(9832);
          this.\u0084.TextAlignment = TextAlignment.MiddleRight;
          this.\u0084.Weight = 0.25851970664333773;
          this.\u0086.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
          XRBindingCollection dataBindings10 = this.\u0086.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(2551), \u0005.\u0004.\u0001(5326))
          };
          XRBinding[] bindings10 = xrBindingArray1;
          dataBindings10.AddRange(bindings10);
          this.\u0086.Multiline = true;
          this.\u0086.Name = \u0005.\u0004.\u0001(9849);
          this.\u0086.Padding = new PaddingInfo(2, 2, 2, 2, 100f);
          this.\u0086.StylePriority.UseBorders = false;
          this.\u0086.StylePriority.UsePadding = false;
          this.\u0086.StylePriority.UseTextAlignment = false;
          this.\u0086.Text = \u0005.\u0004.\u0001(9870);
          this.\u0086.TextAlignment = TextAlignment.MiddleRight;
          this.\u0086.Weight = 0.29892433282196906;
          this.\u0087.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
          XRBindingCollection dataBindings11 = this.\u0087.DataBindings;
          xrBindingArray1 = new XRBinding[1]
          {
            new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(2599), \u0005.\u0004.\u0001(5326))
          };
          XRBinding[] bindings11 = xrBindingArray1;
          dataBindings11.AddRange(bindings11);
          this.\u0087.Multiline = true;
          this.\u0087.Name = \u0005.\u0004.\u0001(9887);
          this.\u0087.Padding = new PaddingInfo(2, 2, 2, 2, 100f);
          this.\u0087.StylePriority.UseBorders = false;
          this.\u0087.StylePriority.UsePadding = false;
          this.\u0087.StylePriority.UseTextAlignment = false;
          this.\u0087.Text = \u0005.\u0004.\u0001(9908);
          this.\u0087.TextAlignment = TextAlignment.MiddleRight;
          this.\u0087.Weight = 0.32576270474251323;
          this.\u0003.HeightF = 26.875f;
          this.\u0003.Name = \u0005.\u0004.\u0001(7318);
          this.\u0003.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
          this.\u0003.TextAlignment = TextAlignment.TopLeft;
          XRControlCollection controls3 = this.\u0004.Controls;
          xrControlArray1 = new XRControl[3]
          {
            (XRControl) this.\u0098,
            (XRControl) this.\u0091,
            (XRControl) this.\u0092
          };
          XRControl[] controls4 = xrControlArray1;
          controls3.AddRange(controls4);
          this.\u0004.HeightF = 37.29165f;
        }
        this.\u0004.Name = \u0005.\u0004.\u0001(7331);
        this.\u0004.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
        this.\u0004.TextAlignment = TextAlignment.TopLeft;
        XRBindingCollection dataBindings12 = this.\u0098.DataBindings;
        xrBindingArray1 = new XRBinding[1]
        {
          new XRBinding(this.\u0099, \u0005.\u0004.\u0001(3154), \u0005.\u0004.\u0001(720))
        };
        XRBinding[] bindings12 = xrBindingArray1;
        dataBindings12.AddRange(bindings12);
        this.\u0098.LocationFloat = new PointFloat(228.125f, 4.500008f);
        this.\u0098.Name = \u0005.\u0004.\u0001(8195);
        this.\u0098.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.\u0098.SizeF = new SizeF(801.875f, 23f);
        this.\u0098.StylePriority.UseTextAlignment = false;
        this.\u0098.Text = \u0005.\u0004.\u0001(8195);
        this.\u0098.TextAlignment = TextAlignment.MiddleCenter;
        this.\u0099.Description = \u0005.\u0004.\u0001(7403);
        this.\u0099.Name = \u0005.\u0004.\u0001(7420);
        this.\u0099.ValueInfo = \u0005.\u0004.\u0001(9929);
        this.\u0099.Visible = false;
        this.\u0091.LocationFloat = new PointFloat(1030f, 4.500008f);
        this.\u0091.Name = \u0005.\u0004.\u0001(9970);
        this.\u0091.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.\u0091.SizeF = new SizeF(100f, 23f);
        this.\u0092.Format = \u0005.\u0004.\u0001(9987);
        this.\u0092.LocationFloat = new PointFloat(10.00001f, 4.5f);
        this.\u0092.Name = \u0005.\u0004.\u0001(10004);
        this.\u0092.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.\u0092.PageInfo = PageInfo.DateTime;
        this.\u0092.SizeF = new SizeF(207.9167f, 23f);
        this.\u0092.StylePriority.UseTextAlignment = false;
        this.\u0092.TextAlignment = TextAlignment.MiddleLeft;
        XRControlCollection controls5 = this.\u0005.Controls;
        xrControlArray1 = new XRControl[5]
        {
          (XRControl) this.\u0012,
          (XRControl) this.\u000E,
          (XRControl) this.\u000F,
          (XRControl) this.\u0010,
          (XRControl) this.\u0011
        };
        XRControl[] controls6 = xrControlArray1;
        controls5.AddRange(controls6);
        this.\u0005.HeightF = 127.5f;
        this.\u0005.Name = \u0005.\u0004.\u0001(7348);
        XRBindingCollection dataBindings13 = this.\u0012.DataBindings;
        xrBindingArray1 = new XRBinding[1]
        {
          new XRBinding(this.\u0006, \u0005.\u0004.\u0001(3154), \u0005.\u0004.\u0001(720))
        };
        XRBinding[] bindings13 = xrBindingArray1;
        dataBindings13.AddRange(bindings13);
        this.\u0012.LocationFloat = new PointFloat(360f, 104.5f);
        this.\u0012.Name = \u0005.\u0004.\u0001(8267);
        this.\u0012.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.\u0012.SizeF = new SizeF(423.9582f, 23f);
        this.\u0012.StylePriority.UseTextAlignment = false;
        this.\u0012.Text = \u0005.\u0004.\u0001(8267);
        this.\u0012.TextAlignment = TextAlignment.MiddleCenter;
        this.\u0006.Description = \u0005.\u0004.\u0001(10021);
        this.\u0006.Name = \u0005.\u0004.\u0001(10046);
        this.\u0006.Visible = false;
        this.\u000E.Font = new Font(\u0005.\u0004.\u0001(7365), 15f);
        this.\u000E.LocationFloat = new PointFloat(360f, 69.00001f);
        this.\u000E.Multiline = true;
        this.\u000E.Name = \u0005.\u0004.\u0001(8229);
        this.\u000E.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.\u000E.SizeF = new SizeF(423.9582f, 35.49999f);
        this.\u000E.StylePriority.UseFont = false;
        this.\u000E.StylePriority.UseTextAlignment = false;
        this.\u000E.Text = \u0005.\u0004.\u0001(10067);
        this.\u000E.TextAlignment = TextAlignment.MiddleCenter;
        XRBindingCollection dataBindings14 = this.\u000F.DataBindings;
        xrBindingArray1 = new XRBinding[1]
        {
          new XRBinding(this.\u0093, \u0005.\u0004.\u0001(3154), \u0005.\u0004.\u0001(720))
        };
        XRBinding[] bindings14 = xrBindingArray1;
        dataBindings14.AddRange(bindings14);
        this.\u000F.LocationFloat = new PointFloat(10.00001f, 33.00001f);
        this.\u000F.Name = \u0005.\u0004.\u0001(8310);
        this.\u000F.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.\u000F.SizeF = new SizeF(360.4167f, 23f);
        this.\u000F.StylePriority.UseTextAlignment = false;
        this.\u000F.Text = \u0005.\u0004.\u0001(8323);
        this.\u000F.TextAlignment = TextAlignment.MiddleLeft;
        this.\u0093.Description = \u0005.\u0004.\u0001(7403);
        this.\u0093.Name = \u0005.\u0004.\u0001(2646);
        this.\u0093.Visible = false;
        XRBindingCollection dataBindings15 = this.\u0010.DataBindings;
        xrBindingArray1 = new XRBinding[1]
        {
          new XRBinding(this.\u0094, \u0005.\u0004.\u0001(3154), \u0005.\u0004.\u0001(720))
        };
        XRBinding[] bindings15 = xrBindingArray1;
        dataBindings15.AddRange(bindings15);
        this.\u0010.LocationFloat = new PointFloat(10.00001f, 56.00001f);
        this.\u0010.Name = \u0005.\u0004.\u0001(8364);
        this.\u0010.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.\u0010.SizeF = new SizeF(360.4167f, 23f);
        this.\u0010.StylePriority.UseTextAlignment = false;
        this.\u0010.Text = \u0005.\u0004.\u0001(8377);
        this.\u0010.TextAlignment = TextAlignment.MiddleLeft;
        this.\u0094.Description = \u0005.\u0004.\u0001(7403);
        this.\u0094.Name = \u0005.\u0004.\u0001(7650);
        this.\u0094.Visible = false;
        XRBindingCollection dataBindings16 = this.\u0011.DataBindings;
        xrBindingArray1 = new XRBinding[1]
        {
          new XRBinding(this.\u0013, \u0005.\u0004.\u0001(3154), \u0005.\u0004.\u0001(720))
        };
        XRBinding[] bindings16 = xrBindingArray1;
        dataBindings16.AddRange(bindings16);
        this.\u0011.LocationFloat = new PointFloat(10.00001f, 10.00001f);
        this.\u0011.Name = \u0005.\u0004.\u0001(8280);
        this.\u0011.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.\u0011.SizeF = new SizeF(360.4167f, 23f);
        this.\u0011.StylePriority.UseTextAlignment = false;
        this.\u0011.Text = \u0005.\u0004.\u0001(8293);
        this.\u0011.TextAlignment = TextAlignment.MiddleLeft;
        this.\u0013.Description = \u0005.\u0004.\u0001(10100);
        this.\u0013.Name = \u0005.\u0004.\u0001(7641);
        this.\u0013.Visible = false;
        XRControlCollection controls7 = this.\u0007.Controls;
        xrControlArray1 = new XRControl[1]
        {
          (XRControl) this.\u0014
        };
        XRControl[] controls8 = xrControlArray1;
        controls7.AddRange(controls8);
        this.\u0007.HeightF = 25f;
        this.\u0007.Name = \u0005.\u0004.\u0001(10121);
        this.\u0014.BackColor = Color.WhiteSmoke;
        this.\u0014.LocationFloat = new PointFloat(0.0f, 0.0f);
        this.\u0014.Name = \u0005.\u0004.\u0001(10138);
        XRTableRowCollection rows3 = this.\u0014.Rows;
        xrTableRowArray1 = new XRTableRow[1]{ this.\u0015 };
        XRTableRow[] rows4 = xrTableRowArray1;
        rows3.AddRange(rows4);
        this.\u0014.SizeF = new SizeF(1130f, 25f);
        this.\u0014.StylePriority.UseBackColor = false;
        this.\u0014.StylePriority.UseTextAlignment = false;
        this.\u0014.TextAlignment = TextAlignment.MiddleCenter;
        this.\u0015.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
        XRTableCellCollection cells3 = this.\u0015.Cells;
        xrTableCellArray1 = new XRTableCell[11]
        {
          this.\u0016,
          this.\u0017,
          this.\u0018,
          this.\u0019,
          this.\u001A,
          this.\u0095,
          this.\u0088,
          this.\u0089,
          this.\u008A,
          this.\u008B,
          this.\u001B
        };
        XRTableCell[] cells4 = xrTableCellArray1;
        cells3.AddRange(cells4);
        this.\u0015.Name = \u0005.\u0004.\u0001(10151);
        this.\u0015.StylePriority.UseBorders = false;
        this.\u0015.Weight = 1.0;
        this.\u0016.Borders = BorderSide.All;
        this.\u0016.Multiline = true;
        this.\u0016.Name = \u0005.\u0004.\u0001(10168);
        this.\u0016.StylePriority.UseBorders = false;
        this.\u0016.Text = \u0005.\u0004.\u0001(9553);
        this.\u0016.Weight = 0.16284704344061635;
        this.\u0017.Borders = BorderSide.All;
        this.\u0017.Multiline = true;
        this.\u0017.Name = \u0005.\u0004.\u0001(10185);
        this.\u0017.StylePriority.UseBorders = false;
        this.\u0017.Text = \u0005.\u0004.\u0001(9604);
        this.\u0017.Weight = 0.27379151293002779;
        this.\u0018.Borders = BorderSide.All;
        this.\u0018.Multiline = true;
        this.\u0018.Name = \u0005.\u0004.\u0001(10202);
        this.\u0018.StylePriority.UseBorders = false;
        this.\u0018.Text = \u0005.\u0004.\u0001(7962);
        this.\u0018.Weight = 0.510729892746157;
        this.\u0019.Borders = BorderSide.All;
        this.\u0019.Multiline = true;
        this.\u0019.Name = \u0005.\u0004.\u0001(10219);
        this.\u0019.StylePriority.UseBorders = false;
        this.\u0019.Text = \u0005.\u0004.\u0001(9659);
        this.\u0019.Weight = 0.33506844833312238;
        this.\u001A.Borders = BorderSide.All;
        this.\u001A.Multiline = true;
        this.\u001A.Name = \u0005.\u0004.\u0001(10236);
        this.\u001A.StylePriority.UseBorders = false;
        this.\u001A.StylePriority.UseTextAlignment = false;
        this.\u001A.Text = \u0005.\u0004.\u0001(9701);
        this.\u001A.TextAlignment = TextAlignment.MiddleCenter;
        this.\u001A.Weight = 0.20627296571306858;
        this.\u0095.Borders = BorderSide.All;
        this.\u0095.Multiline = true;
        this.\u0095.Name = \u0005.\u0004.\u0001(10253);
        this.\u0095.StylePriority.UseBorders = false;
        this.\u0095.Text = \u0005.\u0004.\u0001(10274);
        this.\u0095.Weight = 0.17918123185669074;
        this.\u0088.Borders = BorderSide.All;
        this.\u0088.Multiline = true;
        this.\u0088.Name = \u0005.\u0004.\u0001(10287);
        this.\u0088.StylePriority.UseBorders = false;
        this.\u0088.Text = \u0005.\u0004.\u0001(9764);
        this.\u0088.Weight = 0.2514550512853283;
        this.\u0089.Borders = BorderSide.All;
        this.\u0089.Multiline = true;
        this.\u0089.Name = \u0005.\u0004.\u0001(10304);
        this.\u0089.StylePriority.UseBorders = false;
        this.\u0089.Text = \u0005.\u0004.\u0001(9802);
        this.\u0089.Weight = 0.17113117086742569;
        this.\u008A.Borders = BorderSide.All;
        this.\u008A.Multiline = true;
        this.\u008A.Name = \u0005.\u0004.\u0001(10321);
        this.\u008A.StylePriority.UseBorders = false;
        this.\u008A.Text = \u0005.\u0004.\u0001(1976);
        this.\u008A.Weight = 0.26052567523914372;
        this.\u008B.Borders = BorderSide.All;
        this.\u008B.Multiline = true;
        this.\u008B.Name = \u0005.\u0004.\u0001(10338);
        this.\u008B.StylePriority.UseBorders = false;
        this.\u008B.Text = \u0005.\u0004.\u0001(9870);
        this.\u008B.Weight = 0.29691788236966643;
        this.\u001B.Borders = BorderSide.All;
        this.\u001B.Multiline = true;
        this.\u001B.Name = \u0005.\u0004.\u0001(10359);
        this.\u001B.StylePriority.UseBorders = false;
        this.\u001B.StylePriority.UseTextAlignment = false;
        this.\u001B.Text = \u0005.\u0004.\u0001(9908);
        this.\u001B.TextAlignment = TextAlignment.MiddleCenter;
        this.\u001B.Weight = 0.32576333574506844;
        XRControlCollection controls9 = this.\u0008.Controls;
        xrControlArray1 = new XRControl[1]
        {
          (XRControl) this.\u008C
        };
        XRControl[] controls10 = xrControlArray1;
        controls9.AddRange(controls10);
        this.\u0008.HeightF = 27.08333f;
        this.\u0008.Name = \u0005.\u0004.\u0001(10376);
        this.\u008C.BackColor = Color.WhiteSmoke;
        this.\u008C.Borders = BorderSide.All;
        this.\u008C.LocationFloat = new PointFloat(0.0f, 0.0f);
        this.\u008C.Name = \u0005.\u0004.\u0001(10393);
        XRTableRowCollection rows5 = this.\u008C.Rows;
        xrTableRowArray1 = new XRTableRow[1]{ this.\u008D };
        XRTableRow[] rows6 = xrTableRowArray1;
        rows5.AddRange(rows6);
        this.\u008C.SizeF = new SizeF(1130f, 25f);
        this.\u008C.StylePriority.UseBackColor = false;
        this.\u008C.StylePriority.UseBorders = false;
        this.\u008C.StylePriority.UseTextAlignment = false;
        this.\u008C.TextAlignment = TextAlignment.MiddleCenter;
        this.\u008D.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
        XRTableCellCollection cells5 = this.\u008D.Cells;
        xrTableCellArray1 = new XRTableCell[3]
        {
          this.\u008E,
          this.\u0097,
          this.\u008F
        };
        XRTableCell[] cells6 = xrTableCellArray1;
        cells5.AddRange(cells6);
        this.\u008D.Name = \u0005.\u0004.\u0001(10406);
        this.\u008D.StylePriority.UseBorders = false;
        this.\u008D.Weight = 1.0;
        this.\u008E.Borders = BorderSide.All;
        XRBindingCollection dataBindings17 = this.\u008E.DataBindings;
        xrBindingArray1 = new XRBinding[1]
        {
          new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(1574))
        };
        XRBinding[] bindings17 = xrBindingArray1;
        dataBindings17.AddRange(bindings17);
        this.\u008E.Multiline = true;
        this.\u008E.Name = \u0005.\u0004.\u0001(10423);
        this.\u008E.Padding = new PaddingInfo(2, 2, 2, 2, 100f);
        this.\u008E.StylePriority.UseBorders = false;
        this.\u008E.StylePriority.UsePadding = false;
        this.\u008E.StylePriority.UseTextAlignment = false;
        xrSummary1.FormatString = \u0005.\u0004.\u0001(10444);
        xrSummary1.Func = SummaryFunc.Count;
        xrSummary1.Running = SummaryRunning.Report;
        this.\u008E.Summary = xrSummary1;
        this.\u008E.Text = \u0005.\u0004.\u0001(10423);
        this.\u008E.TextAlignment = TextAlignment.MiddleLeft;
        this.\u008E.Weight = 1.2824367684694713;
        this.\u0097.Borders = BorderSide.All;
        XRBindingCollection dataBindings18 = this.\u0097.DataBindings;
        xrBindingArray1 = new XRBinding[1]
        {
          new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(1825))
        };
        XRBinding[] bindings18 = xrBindingArray1;
        dataBindings18.AddRange(bindings18);
        this.\u0097.Name = \u0005.\u0004.\u0001(10473);
        this.\u0097.StylePriority.UseBorders = false;
        this.\u0097.StylePriority.UseTextAlignment = false;
        xrSummary2.FormatString = \u0005.\u0004.\u0001(10494);
        xrSummary2.Running = SummaryRunning.Report;
        this.\u0097.Summary = xrSummary2;
        this.\u0097.Text = \u0005.\u0004.\u0001(10473);
        this.\u0097.TextAlignment = TextAlignment.MiddleRight;
        this.\u0097.Weight = 0.63690934628541207;
        this.\u008F.Borders = BorderSide.All;
        XRBindingCollection dataBindings19 = this.\u008F.DataBindings;
        xrBindingArray1 = new XRBinding[1]
        {
          new XRBinding(\u0005.\u0004.\u0001(3154), (object) null, \u0005.\u0004.\u0001(2599))
        };
        XRBinding[] bindings19 = xrBindingArray1;
        dataBindings19.AddRange(bindings19);
        this.\u008F.Multiline = true;
        this.\u008F.Name = \u0005.\u0004.\u0001(10527);
        this.\u008F.Padding = new PaddingInfo(2, 2, 2, 2, 100f);
        this.\u008F.StylePriority.UseBorders = false;
        this.\u008F.StylePriority.UsePadding = false;
        this.\u008F.StylePriority.UseTextAlignment = false;
        xrSummary3.FormatString = \u0005.\u0004.\u0001(10548);
        xrSummary3.Running = SummaryRunning.Report;
        this.\u008F.Summary = xrSummary3;
        this.\u008F.Text = \u0005.\u0004.\u0001(10527);
        this.\u008F.TextAlignment = TextAlignment.MiddleRight;
        this.\u008F.Weight = 1.0543380957714317;
        this.\u0090.DataSource = (object) typeof (XeHang);
        BandCollection bands1 = this.Bands;
        bandArray1 = new Band[6]
        {
          (Band) this.\u0002,
          (Band) this.\u0003,
          (Band) this.\u0004,
          (Band) this.\u0005,
          (Band) this.\u0007,
          (Band) this.\u0008
        };
        Band[] bands2 = bandArray1;
        bands1.AddRange(bands2);
        this.DataSource = (object) this.\u0090;
        this.Landscape = true;
        this.Margins = new Margins(20, 17, 27, 37);
        this.PageHeight = 827;
        this.PageWidth = 1169;
        this.PaperKind = PaperKind.A4;
        ParameterCollection parameters1 = this.Parameters;
        parameterArray1 = new Parameter[5]
        {
          this.\u0006,
          this.\u0013,
          this.\u0093,
          this.\u0094,
          this.\u0099
        };
        Parameter[] parameters2 = parameterArray1;
        parameters1.AddRange(parameters2);
        this.Version = \u0005.\u0004.\u0001(9384);
        this.\u001C.EndInit();
        this.\u0014.EndInit();
        this.\u008C.EndInit();
        ((ISupportInitialize) this.\u0090).EndInit();
        this.EndInit();
      }
      catch (Exception ex)
      {
        XRSummary xrSummary4 = xrSummary1;
        XRSummary xrSummary5 = xrSummary2;
        XRSummary xrSummary6 = xrSummary3;
        XRControl[] xrControlArray2 = xrControlArray1;
        XRTableRow[] xrTableRowArray2 = xrTableRowArray1;
        XRTableCell[] xrTableCellArray2 = xrTableCellArray1;
        XRBinding[] xrBindingArray2 = xrBindingArray1;
        Band[] bandArray2 = bandArray1;
        Parameter[] parameterArray2 = parameterArray1;
        \u0005.\u0008.\u0001(ex, (object) xrSummary4, (object) xrSummary5, (object) xrSummary6, (object) xrControlArray2, (object) xrTableRowArray2, (object) xrTableCellArray2, (object) xrBindingArray2, (object) bandArray2, (object) parameterArray2, (object) this);
        throw;
      }
    }

    public \u0003()
    {
      try
      {
        this.\u0001();
      }
      catch (Exception ex)
      {
        \u0005.\u0008.\u0001(ex, (object) this);
        throw;
      }
    }
  }
}
