// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using \u0004;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0001
{
  [DesignerCategory("Code")]
  internal class \u0008 : Control
  {
    private int \u0001 = 99;
    private readonly Bitmap \u0002 = \u000F.\u0001(\u0005.\u0004.\u0001(18049));
    private readonly Bitmap \u0003 = \u000F.\u0001(\u0005.\u0004.\u0001(18058));
    private readonly Timer \u0004 = new Timer();
    private float \u0005 = 1f;
    private float \u0006 = 1f;

    virtual void Control.\u0001(EventArgs _param1)
    {
      if (true)
      {
        if (true)
        {
          // ISSUE: explicit non-virtual call
          __nonvirtual (((Control) this).OnVisibleChanged(_param1));
          goto label_5;
        }
        else
          goto label_5;
      }
      else
        goto label_6;
label_3:
      if (true)
        return;
label_5:
      if (this.DesignMode)
        goto label_3;
label_6:
      this.\u0001(this.Visible);
      goto label_3;
    }

    private void \u0001(bool _param1)
    {
      this.\u0004.Enabled = _param1;
      this.\u0001 = 0;
      this.Refresh();
    }

    virtual void Control.\u0002(EventArgs _param1)
    {
      do
      {
        this.Size = new Size(Convert.ToInt32(250f * this.\u0005), Convert.ToInt32(42f * this.\u0006));
        if (true)
          goto label_3;
label_2:
        continue;
label_3:
        // ISSUE: explicit non-virtual call
        __nonvirtual (((Control) this).OnResize(_param1));
        goto label_2;
      }
      while (false);
    }

    virtual void Control.\u0001(float _param1, float _param2)
    {
      if (false)
        return;
      this.\u0005 = _param1;
      if (false)
        return;
      this.\u0006 = _param2;
      do
      {
        if (true)
          goto label_7;
label_3:
        continue;
label_7:
        // ISSUE: explicit non-virtual call
        __nonvirtual (((Control) this).ScaleCore(_param1, _param2));
        goto label_3;
      }
      while (false);
      ((Control) this).OnResize(EventArgs.Empty);
    }

    virtual void Control.\u0002(bool _param1)
    {
label_0:
      if (!_param1)
        goto label_7;
      else
        goto label_4;
label_2:
      if (true)
      {
        this.\u0004.Dispose();
        goto label_7;
      }
label_4:
      if (this.\u0002 != null)
      {
        if (true)
        {
          this.\u0002.Dispose();
          goto label_2;
        }
        else
          goto label_0;
      }
      else
        goto label_2;
label_7:
      // ISSUE: explicit non-virtual call
      __nonvirtual (((Control) this).Dispose(_param1));
      if (false)
        goto label_2;
    }

    virtual void Control.\u0001(PaintEventArgs _param1)
    {
      PaintEventArgs e = _param1;
      if (true)
      {
        // ISSUE: explicit non-virtual call
        __nonvirtual (((Control) this).OnPaint(e));
      }
      do
      {
        if (this.\u0003 != null)
          goto label_7;
label_2:
        if (this.\u0002 != null && this.\u0001 > 0)
          continue;
        goto label_1;
label_7:
        _param1.Graphics.DrawImage((Image) this.\u0003, new Rectangle(0, 0, Convert.ToInt32(250f * this.\u0005), Convert.ToInt32(42f * this.\u0006)), new Rectangle(0, 0, 250, 42), GraphicsUnit.Pixel);
        goto label_2;
      }
      while (false);
      goto label_4;
label_1:
      return;
label_4:
      _param1.Graphics.SetClip(new Rectangle(Convert.ToInt32(46f * this.\u0005), 0, Convert.ToInt32(165f * this.\u0005), Convert.ToInt32(34f * this.\u0006)));
      _param1.Graphics.DrawImage((Image) this.\u0002, new Rectangle(Convert.ToInt32((float) (this.\u0001 - 6) * this.\u0005), Convert.ToInt32(16f * this.\u0006), Convert.ToInt32(40f * this.\u0005), Convert.ToInt32(12f * this.\u0006)), 0, 0, 40, 12, GraphicsUnit.Pixel);
    }

    private void \u0001(object _param1, EventArgs _param2)
    {
      do
      {
        this.\u0001 += 11;
        if (this.\u0001 > 198)
        {
          if (true)
          {
            this.\u0001 = 0;
            goto label_6;
          }
        }
        else
          goto label_6;
label_3:
        if (true)
          continue;
label_6:
        this.Refresh();
        goto label_3;
      }
      while (false);
    }

    public \u0008()
    {
      this.\u0004.Interval = 85;
      this.\u0004.Tick += new EventHandler(this.\u0001);
      this.Size = new Size(250, 42);
      this.TabStop = false;
      this.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
    }
  }
}
