// Decompiled with JetBrains decompiler
// Type: .
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
  internal class \u0004 : Label
  {
    private void \u0001()
    {
      try
      {
        do
        {
          if (true)
            goto label_10;
label_9:
          continue;
label_10:
          using (Graphics graphics = this.CreateGraphics())
          {
            int num;
            do
            {
              num = \u0008.\u0010.\u0001(graphics, this.Text, this.Font, this.Width);
            }
            while (false);
            if (true)
            {
              if (num <= 0)
                goto label_9;
            }
            this.Height = num;
            goto label_9;
          }
        }
        while (false);
      }
      catch
      {
      }
    }

    virtual void Label.\u0001(EventArgs _param1)
    {
      // ISSUE: explicit non-virtual call
      __nonvirtual (((Label) this).OnFontChanged(_param1));
      this.\u0001();
    }

    virtual void Control.\u0002(EventArgs _param1)
    {
      // ISSUE: explicit non-virtual call
      __nonvirtual (((Control) this).OnResize(_param1));
      this.\u0001();
    }

    virtual void Label.\u0003(EventArgs _param1)
    {
      // ISSUE: explicit non-virtual call
      __nonvirtual (((Label) this).OnTextChanged(_param1));
      this.\u0001();
    }

    public \u0004()
    {
      this.FlatStyle = FlatStyle.System;
      this.UseMnemonic = false;
    }
  }
}
