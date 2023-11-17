// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0010
{
  [DesignerCategory("Code")]
  internal class \u0005 : Control
  {
    private readonly Label \u0001 = new Label();
    private Image \u0002;
    private bool \u0003;
    private readonly Timer \u0004 = new Timer();
    private bool \u0005 = true;
    private string \u0006 = string.Empty;
    private float \u0007 = 1f;
    private float \u0008 = 1f;

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    string Control.Text
    {
      get => __nonvirtual (((Control) this).Text);
      set
      {
        __nonvirtual (((Control) this).Text) = value;
        this.Refresh();
      }
    }

    public void \u0001()
    {
label_0:
      this.\u0004.Enabled = false;
      this.\u0002 = (Image) null;
      do
      {
        if (true)
        {
          if (false)
            return;
          this.\u0003 = false;
          this.\u0006 = string.Empty;
        }
        else
          goto label_0;
      }
      while (false);
      this.Refresh();
      this.Height = 16;
    }

    public void \u0002()
    {
      this.\u0004.Enabled = true;
      this.\u0002 = (Image) \u0004.\u000F.\u0001(\u0005.\u0004.\u0001(17701));
      this.\u0003 = true;
      this.Refresh();
    }

    public void \u0003() => this.\u0002(string.Empty);

    public void \u0002(string _param1)
    {
      if (true)
      {
        if (true)
          this.\u0006 = _param1;
        else
          goto label_6;
      }
      this.\u0004.Enabled = false;
label_6:
      this.\u0002 = (Image) \u0004.\u000F.\u0001(_param1.Length > 0 ? \u0005.\u0004.\u0001(17719) : \u0005.\u0004.\u0001(17714));
      this.\u0005 = true;
      this.\u0003 = true;
      if (_param1.Length > 0)
        this.Height = 100;
      this.Refresh();
    }

    virtual void Control.\u0001(EventArgs _param1)
    {
label_0:
      this.\u0001.SetBounds(Convert.ToInt32(22f * this.\u0007), Convert.ToInt32(this.\u0008), this.Width - Convert.ToInt32(22f * this.\u0007), this.Height - Convert.ToInt32(this.\u0008));
      do
      {
        if (true)
        {
          // ISSUE: explicit non-virtual call
          __nonvirtual (((Control) this).OnResize(_param1));
        }
        else
          goto label_0;
      }
      while (false);
    }

    virtual void Control.\u0001(float _param1, float _param2)
    {
      if (false)
        return;
      this.\u0007 = _param1;
      if (false)
        return;
      this.\u0008 = _param2;
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

    virtual void Control.\u0001(PaintEventArgs _param1)
    {
label_0:
      // ISSUE: explicit non-virtual call
      __nonvirtual (((Control) this).OnPaint(_param1));
      int num1 = this.DesignMode ? 1 : 0;
      int num2;
      if (true)
      {
        if (true)
        {
          if (num1 != 0)
            goto label_16;
label_5:
          if (this.\u0002 != null)
          {
            if (false)
              return;
            num1 = this.\u0005 ? 1 : 0;
            goto label_8;
          }
          else
            goto label_10;
label_16:
          this.\u0002 = (Image) \u0004.\u000F.\u0001(\u0005.\u0004.\u0001(17701));
          this.\u0003 = true;
          goto label_5;
        }
        else
        {
          num2 = num1;
          goto label_12;
        }
      }
label_8:
      if (num1 == 0)
        goto label_10;
label_9:
      _param1.Graphics.DrawImage(this.\u0002, new Rectangle(0, 0, Convert.ToInt32(16f * this.\u0007), Convert.ToInt32(16f * this.\u0008)), new Rectangle(0, 0, 16, 16), GraphicsUnit.Pixel);
label_10:
      if (true)
        num2 = this.\u0003 ? 1 : 0;
      else
        goto label_0;
label_12:
      if (num2 != 0)
      {
        if (true)
        {
          // ISSUE: explicit non-virtual call
          // ISSUE: explicit non-virtual call
          this.\u0001.Text = this.\u0006.Length > 0 ? __nonvirtual (((Control) this).Text) + \u0005.\u0004.\u0001(17728) + this.\u0006 + \u0005.\u0004.\u0001(17733) : __nonvirtual (((Control) this).Text);
        }
        else
          goto label_9;
      }
      else
        this.\u0001.Text = string.Empty;
    }

    public \u0005()
    {
      this.\u0004.Interval = 250;
      this.\u0004.Tick += new EventHandler(this.\u0001);
      this.\u0001.FlatStyle = FlatStyle.System;
      this.Controls.Add((Control) this.\u0001);
      this.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
      this.TabStop = false;
    }

    public \u0005(string text)
      : this()
    {
      // ISSUE: explicit non-virtual call
      __nonvirtual (((Control) this).Text) = \u0005.\u0004.\u0001(15141) + text;
    }

    virtual void Control.\u0001(bool _param1)
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

    private void \u0001(object _param1, EventArgs _param2)
    {
      this.\u0005 = !this.\u0005;
      this.Refresh();
    }
  }
}
