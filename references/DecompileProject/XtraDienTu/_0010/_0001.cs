// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0010
{
  internal class \u0001 : Form
  {
    private IContainer \u0001;
    private SimpleButton \u0002;
    private TextEdit \u0003;
    private TextEdit \u0004;
    private GroupControl \u0005;
    private LabelControl \u0006;
    private LabelControl \u0007;

    public \u0001()
    {
      EventHandler eventHandler1 = (EventHandler) null;
      this.\u0001 = (IContainer) null;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      try
      {
        this.\u0002();
        this.\u0001();
        SimpleButton simpleButton = this.\u0002;
        if (eventHandler1 == null)
          eventHandler1 = (EventHandler) ((_param1, _param2) =>
          {
            bool flag;
            DateTime dateTime;
            try
            {
              dateTime = \u0008.\u0001.\u0001(this.\u0004.Text);
              flag = !(\u0008.\u0001.\u0001(this.\u0004.Text) < DateTime.Now);
              if (!flag)
              {
                if (true)
                {
                  if (true)
                  {
                    int num = (int) XtraMessageBox.Show(\u0005.\u0004.\u0001(11055), \u0005.\u0004.\u0001(11120), MessageBoxButtons.OK, MessageBoxIcon.Hand);
                  }
                  else
                    goto label_7;
                }
                if (true)
                {
                  this.DialogResult = DialogResult.Cancel;
                  this.Close();
                  if (true)
                    return;
                }
                else
                  goto label_8;
              }
label_7:
              int num1 = (int) XtraMessageBox.Show(\u0005.\u0004.\u0001(11137), \u0005.\u0004.\u0001(11120), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
              \u000F.\u0002.\u0001(\u0005.\u0004.\u0001(10893), this.\u0004.Text, (string) null);
label_8:
              this.DialogResult = DialogResult.OK;
              this.Close();
              if (false)
                goto label_7;
            }
            catch (Exception ex)
            {
              // ISSUE: variable of a boxed type
              __Boxed<DateTime> local1 = (ValueType) dateTime;
              // ISSUE: variable of a boxed type
              __Boxed<bool> local2 = (ValueType) flag;
              object obj = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) this, obj, (object) eventArgs);
              throw;
            }
          });
        EventHandler eventHandler2 = eventHandler1;
        simpleButton.Click += eventHandler2;
      }
      catch (Exception ex)
      {
        EventHandler eventHandler3 = eventHandler1;
        \u0005.\u0008.\u0001(ex, (object) eventHandler3, (object) this);
        throw;
      }
    }

    private void \u0001()
    {
      try
      {
        if (false)
          return;
        if (true)
          goto label_5;
label_2:
        if (false)
          return;
        this.\u0004.EditValue = (object) \u000F.\u0002.\u0001(\u0005.\u0004.\u0001(10893));
        return;
label_5:
        TextEdit textEdit = this.\u0003;
        string str = \u0008.\u0001.\u0003(\u0005.\u0004.\u0001(770));
        if (true)
        {
          textEdit.EditValue = (object) str;
          goto label_2;
        }
        else
          goto label_2;
      }
      catch (Exception ex)
      {
        \u0005.\u0008.\u0001(ex, (object) this);
        throw;
      }
    }

    virtual void Form.\u0001(bool _param1)
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
            __nonvirtual (((Form) this).Dispose(_param1));
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

    private void \u0002()
    {
      try
      {
        this.\u0002 = new SimpleButton();
        this.\u0003 = new TextEdit();
        this.\u0004 = new TextEdit();
label_15:
        this.\u0005 = new GroupControl();
        this.\u0006 = new LabelControl();
label_1:
        this.\u0007 = new LabelControl();
        this.\u0003.Properties.BeginInit();
        if (false)
          return;
        this.\u0004.Properties.BeginInit();
        this.\u0005.BeginInit();
        this.\u0005.SuspendLayout();
        if (true)
        {
          this.SuspendLayout();
          this.\u0002.Location = new Point(114, 107);
          this.\u0002.Name = \u0005.\u0004.\u0001(10906);
          this.\u0002.Size = new Size(166, 62);
          this.\u0002.TabIndex = 2;
          this.\u0002.Text = \u0005.\u0004.\u0001(10919);
        }
        else
          goto label_12;
label_4:
        if (true)
        {
          this.\u0003.Location = new Point(83, 35);
          this.\u0003.Name = \u0005.\u0004.\u0001(10936);
          this.\u0003.Size = new Size(289, 20);
          this.\u0003.TabIndex = 3;
          this.\u0004.Location = new Point(83, 67);
          this.\u0004.Name = \u0005.\u0004.\u0001(10949);
          this.\u0004.Size = new Size(289, 20);
          do
          {
            this.\u0004.TabIndex = 3;
            if (true)
            {
              this.\u0005.Controls.Add((Control) this.\u0006);
              this.\u0005.Controls.Add((Control) this.\u0007);
            }
            else
              goto label_1;
          }
          while (false);
          this.\u0005.Controls.Add((Control) this.\u0003);
          if (true)
            this.\u0005.Controls.Add((Control) this.\u0002);
          else
            goto label_15;
        }
        this.\u0005.Controls.Add((Control) this.\u0004);
        this.\u0005.Location = new Point(12, 12);
        this.\u0005.LookAndFeel.SkinName = \u0005.\u0004.\u0001(3057);
        this.\u0005.Name = \u0005.\u0004.\u0001(3104);
        this.\u0005.Size = new Size(398, 198);
        this.\u0005.TabIndex = 4;
        this.\u0005.Text = \u0005.\u0004.\u0001(10962);
        this.\u0006.Location = new Point(22, 70);
        this.\u0006.Name = \u0005.\u0004.\u0001(234);
        this.\u0006.Size = new Size(22, 13);
        this.\u0006.TabIndex = 4;
        this.\u0006.Text = \u0005.\u0004.\u0001(10991);
        this.\u0007.Location = new Point(22, 38);
        this.\u0007.Name = \u0005.\u0004.\u0001(109);
        this.\u0007.Size = new Size(41, 13);
        this.\u0007.TabIndex = 4;
        if (true)
        {
          this.\u0007.Text = \u0005.\u0004.\u0001(11000);
          this.AutoScaleDimensions = new SizeF(6f, 13f);
        }
        else
          goto label_13;
label_12:
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(424, 220);
        this.Controls.Add((Control) this.\u0005);
        this.Name = \u0005.\u0004.\u0001(11013);
        this.StartPosition = FormStartPosition.CenterScreen;
        if (false)
          goto label_4;
label_13:
        this.Text = \u0005.\u0004.\u0001(11022);
        this.\u0003.Properties.EndInit();
        this.\u0004.Properties.EndInit();
        this.\u0005.EndInit();
        this.\u0005.ResumeLayout(false);
        this.\u0005.PerformLayout();
        this.ResumeLayout(false);
      }
      catch (Exception ex)
      {
        \u0005.\u0008.\u0001(ex, (object) this);
        throw;
      }
    }
  }
}
