// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using \u0005;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0002
{
  internal class \u0002 : XtraForm
  {
    private IContainer \u0001 = (IContainer) null;

    public \u0002()
    {
      try
      {
        this.\u0001();
      }
      catch (Exception ex)
      {
        \u0008.\u0001(ex, (object) this);
        throw;
      }
    }

    virtual void XtraForm.\u0001(bool _param1)
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
            __nonvirtual (((XtraForm) this).Dispose(_param1));
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
        \u0008.\u0001(ex, (object) local1, (object) this, (object) local2);
        throw;
      }
    }

    private void \u0001()
    {
label_0:
      try
      {
        this.SuspendLayout();
        if (true)
          goto label_5;
label_1:
        do
        {
          do
          {
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(284, 262);
            this.Name = \u0004.\u0001(5821);
          }
          while (false);
          if (true)
            this.Text = \u0004.\u0001(5392);
          else
            goto label_0;
        }
        while (false);
        this.ResumeLayout(false);
        return;
label_5:
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        goto label_1;
      }
      catch (Exception ex)
      {
        \u0008.\u0001(ex, (object) this);
        throw;
      }
    }
  }
}
