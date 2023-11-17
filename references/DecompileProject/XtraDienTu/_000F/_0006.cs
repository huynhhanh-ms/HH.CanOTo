// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u000F
{
  [DesignerCategory("Code")]
  internal class \u0006 : Control
  {
    private Label \u0001 = new Label();
    private Image \u0002;
    private Icon \u0003;
    private Bitmap \u0004;
    private \u000F.\u0007 \u0005;
    private float \u0006 = 1f;
    private float \u0007 = 1f;

    public \u000F.\u0007 IconState
    {
      get => this.\u0005;
      set
      {
        do
        {
          if (this.\u0005 != value)
            goto label_8;
label_7:
          continue;
label_8:
          this.\u0005 = value;
          if (true)
            goto label_9;
label_4:
          if (true)
            this.\u0004 = (Bitmap) null;
label_6:
          this.Refresh();
          goto label_7;
label_9:
          switch (this.\u0005)
          {
            case \u000F.\u0007.\u0002:
              this.\u0004 = \u0004.\u000F.\u0001(\u0005.\u0004.\u0001(17738));
              goto label_6;
            case \u000F.\u0007.\u0003:
              if (true)
              {
                this.\u0004 = \u0004.\u000F.\u0001(\u0005.\u0004.\u0001(17751));
                goto label_6;
              }
              else
                goto label_4;
            default:
              goto label_4;
          }
        }
        while (false);
      }
    }

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    string Control.Text
    {
      get => this.\u0001.Text;
      set => this.\u0001.Text = value;
    }

    public Image Image
    {
      get => this.\u0002;
      set
      {
        this.\u0002 = value;
        this.Refresh();
      }
    }

    virtual void Control.\u0001(bool _param1)
    {
      if (_param1)
        goto label_4;
label_3:
      // ISSUE: explicit non-virtual call
      __nonvirtual (((Control) this).Dispose(_param1));
      return;
label_4:
      if (this.\u0003 != null)
      {
        this.\u0003.Dispose();
        this.\u0003 = (Icon) null;
      }
      if (this.\u0002 != null)
        goto label_7;
label_1:
      if (this.\u0004 != null)
      {
        this.\u0004.Dispose();
        this.\u0004 = (Bitmap) null;
        goto label_3;
      }
      else
        goto label_3;
label_7:
      this.\u0002.Dispose();
      this.\u0002 = (Image) null;
      goto label_1;
    }

    virtual void Control.\u0001(EventArgs _param1)
    {
      this.\u0001.SetBounds(Convert.ToInt32(13f * this.\u0006), Convert.ToInt32(15f * this.\u0007), this.Width - Convert.ToInt32(69f * this.\u0006), this.Height - Convert.ToInt32(18f * this.\u0007));
      // ISSUE: explicit non-virtual call
      __nonvirtual (((Control) this).OnResize(_param1));
    }

    virtual void Control.\u0001(float _param1, float _param2)
    {
      if (false)
        return;
      this.\u0006 = _param1;
      if (false)
        return;
      this.\u0007 = _param2;
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
      if (true)
        goto label_7;
label_5:
      Rectangle rectangle;
      _param1.Graphics.DrawIcon(this.\u0003, rectangle);
      if (this.\u0004 == null)
        return;
      _param1.Graphics.DrawImage((Image) this.\u0004, new Rectangle(rectangle.Right - Convert.ToInt32(12f * this.\u0006), rectangle.Bottom - Convert.ToInt32(12f * this.\u0007), Convert.ToInt32(16f * this.\u0006), Convert.ToInt32(16f * this.\u0007)), new Rectangle(0, 0, 16, 16), GraphicsUnit.Pixel);
      return;
label_7:
      PaintEventArgs e = _param1;
      if (true)
      {
        // ISSUE: explicit non-virtual call
        __nonvirtual (((Control) this).OnPaint(e));
      }
      _param1.Graphics.DrawLine(SystemPens.ControlDark, 0, this.ClientSize.Height - 2, this.ClientSize.Width, this.ClientSize.Height - 2);
      _param1.Graphics.DrawLine(SystemPens.ControlLightLight, 0, this.ClientSize.Height - 1, this.ClientSize.Width, this.ClientSize.Height - 1);
      rectangle = new Rectangle(this.ClientSize.Width - Convert.ToInt32(48f * this.\u0006), Convert.ToInt32(11f * this.\u0007), Convert.ToInt32(32f * this.\u0006), Convert.ToInt32(32f * this.\u0007));
      if (this.\u0002 != null)
        _param1.Graphics.DrawImage(this.\u0002, rectangle, new Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel);
      else if (this.\u0003 != null)
        goto label_5;
    }

    virtual void Control.\u0002(EventArgs _param1)
    {
      try
      {
        if (false)
          return;
        this.\u0001.Font = new Font(this.Font, FontStyle.Bold);
        if (false)
          return;
        // ISSUE: explicit non-virtual call
        __nonvirtual (((Control) this).OnFontChanged(_param1));
      }
      catch
      {
      }
    }

    public \u0006()
    {
      try
      {
        this.\u0001.FlatStyle = FlatStyle.System;
        this.\u0001.Font = new Font(this.Font, FontStyle.Bold);
      }
      catch
      {
      }
      this.Controls.Add((Control) this.\u0001);
      this.BackColor = SystemColors.Window;
      this.TabStop = false;
      this.Dock = DockStyle.Top;
      this.Height = 58;
      this.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
      this.\u0003 = \u0008.\u0010.\u0001();
      ((Control) this).OnResize(EventArgs.Empty);
    }

    public \u0006(string text)
      : this()
    {
      this.\u0001.Text = text;
    }
  }
}
