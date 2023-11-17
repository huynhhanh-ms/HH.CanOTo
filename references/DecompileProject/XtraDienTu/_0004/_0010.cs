// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace \u0004
{
  [DesignerCategory("Code")]
  internal class \u0010 : Control
  {
    private const string \u0001 = "Powered by SmartAssembly";
    private const string \u0002 = "http://www.red-gate.com/products/dotnet-development/smartassembly/?utm_source=smartassemblyui&utm_medium=supportlink&utm_content=aerdialogbox&utm_campaign=smartassembly";
    private Label \u0003 = new Label();
    private PictureBox \u0004 = new PictureBox();
    private ToolTip \u0005 = new ToolTip();
    private float \u0006 = 1f;
    private float \u0007 = 1f;

    virtual void Control.\u0001(EventArgs _param1)
    {
      do
      {
        this.Size = new Size(Convert.ToInt32(112f * this.\u0006), Convert.ToInt32(32f * this.\u0007));
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

    virtual void Control.\u0001(bool _param1)
    {
label_0:
      while (_param1)
      {
        do
        {
          if (true)
          {
            if (this.\u0005 == null)
              goto label_6;
          }
          else
            goto label_0;
        }
        while (false);
        ToolTip toolTip = this.\u0005;
        if (true)
          toolTip.Dispose();
label_6:
        if (this.\u0004 != null)
        {
          this.\u0004.Dispose();
          break;
        }
        break;
      }
      // ISSUE: explicit non-virtual call
      __nonvirtual (((Control) this).Dispose(_param1));
    }

    private void \u0001(object _param1, EventArgs _param2)
    {
      try
      {
        Process.Start(\u0005.\u0004.\u0001(17764));
      }
      catch
      {
      }
    }

    public \u0010()
    {
      this.SuspendLayout();
      this.\u0003.FlatStyle = FlatStyle.System;
      this.\u0003.Location = new Point(0, 10);
      this.\u0003.Size = new Size(62, 24);
      this.\u0003.Text = \u0005.\u0004.\u0001(17990);
      this.\u0004.Image = (Image) \u000F.\u0001(\u0005.\u0004.\u0001(18007));
      this.\u0004.Location = new Point(72, 0);
      this.\u0004.Size = new Size(32, 32);
      this.\u0004.SizeMode = PictureBoxSizeMode.StretchImage;
      this.\u0003.Click += new EventHandler(this.\u0001);
      this.\u0004.Click += new EventHandler(this.\u0001);
      this.Click += new EventHandler(this.\u0001);
      this.Cursor = Cursors.Hand;
      this.TabStop = false;
      this.Size = new Size(112, 32);
      this.Controls.AddRange(new Control[2]
      {
        (Control) this.\u0004,
        (Control) this.\u0003
      });
      this.\u0005.SetToolTip((Control) this, \u0005.\u0004.\u0001(18016));
      this.\u0005.SetToolTip((Control) this.\u0003, \u0005.\u0004.\u0001(18016));
      this.\u0005.SetToolTip((Control) this.\u0004, \u0005.\u0004.\u0001(18016));
      this.ResumeLayout(true);
    }
  }
}
