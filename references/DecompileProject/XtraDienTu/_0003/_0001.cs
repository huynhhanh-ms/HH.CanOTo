// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0003
{
  internal class \u0001 : XtraForm
  {
    private IContainer \u0001;
    private SimpleButton \u0002;
    private SimpleButton \u0003;
    private TextEdit \u0004;

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
        \u0005.\u0008.\u0001(ex, (object) local1, (object) this, (object) local2);
        throw;
      }
    }

    private void \u0001()
    {
      try
      {
        this.\u0004 = new TextEdit();
        this.\u0002 = new SimpleButton();
        do
        {
          this.\u0003 = new SimpleButton();
          this.\u0004.Properties.BeginInit();
          this.SuspendLayout();
          this.\u0004.Location = new Point(10, 7);
          this.\u0004.Name = \u0005.\u0004.\u0001(6557);
          this.\u0004.Properties.PasswordChar = '*';
          this.\u0004.Size = new Size(174, 20);
        }
        while (false);
        this.\u0004.TabIndex = 13;
        this.\u0002.Image = (Image) \u0008.\u0004.chec;
        this.\u0002.Location = new Point(10, 33);
        this.\u0002.Name = \u0005.\u0004.\u0001(4538);
        this.\u0002.Size = new Size(81, 39);
        this.\u0002.TabIndex = 14;
        if (true)
        {
          this.\u0002.Text = \u0005.\u0004.\u0001(4547);
          this.\u0003.Image = (Image) \u0008.\u0004.exit;
          this.\u0003.Location = new Point(103, 33);
          this.\u0003.Name = \u0005.\u0004.\u0001(4516);
          this.\u0003.Size = new Size(81, 39);
          this.\u0003.TabIndex = 15;
          this.\u0003.Text = \u0005.\u0004.\u0001(6570);
          this.AutoScaleDimensions = new SizeF(6f, 13f);
          this.AutoScaleMode = AutoScaleMode.Font;
        }
        else
          goto label_4;
label_3:
label_4:
        this.ClientSize = new Size(195, 87);
        this.ControlBox = false;
        if (true)
        {
          this.Controls.Add((Control) this.\u0002);
          this.Controls.Add((Control) this.\u0003);
          this.Controls.Add((Control) this.\u0004);
          this.Name = \u0005.\u0004.\u0001(6579);
        }
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = \u0005.\u0004.\u0001(6604);
        this.\u0004.Properties.EndInit();
        this.ResumeLayout(false);
        if (false)
          goto label_3;
      }
      catch (Exception ex)
      {
        \u0005.\u0008.\u0001(ex, (object) this);
        throw;
      }
    }

    public \u0001()
    {
      EventHandler eventHandler1 = (EventHandler) null;
      KeyEventHandler keyEventHandler1 = (KeyEventHandler) null;
      EventHandler eventHandler2 = (EventHandler) null;
      this.\u0001 = (IContainer) null;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      try
      {
        this.\u0001();
        SimpleButton simpleButton1 = this.\u0002;
        if (eventHandler1 == null)
          eventHandler1 = (EventHandler) ((_param1, _param2) =>
          {
            string text;
            bool flag;
            try
            {
              text = this.\u0004.Text;
              flag = !(\u0005.\u0004.\u0001(6633) == text);
              if (true)
                goto label_8;
label_6:
              return;
label_8:
              if (!flag)
              {
                while (true)
                {
                  this.DialogResult = DialogResult.Yes;
                  if (true)
                  {
                    this.Close();
                    if (true)
                    {
                      if (false)
                        ;
                      return;
                    }
                  }
                }
              }
              int num = (int) XtraMessageBox.Show(\u0005.\u0004.\u0001(6658), \u0005.\u0004.\u0001(643), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              goto label_6;
            }
            catch (Exception ex)
            {
              string str = text;
              // ISSUE: variable of a boxed type
              __Boxed<bool> local = (ValueType) flag;
              object obj = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) str, (object) local, (object) this, obj, (object) eventArgs);
              throw;
            }
          });
        EventHandler eventHandler3 = eventHandler1;
        simpleButton1.Click += eventHandler3;
        TextEdit textEdit = this.\u0004;
        if (keyEventHandler1 == null)
          keyEventHandler1 = (KeyEventHandler) ((_param1, _param2) =>
          {
            bool flag;
            try
            {
              flag = _param2.KeyCode != Keys.Return;
              if (flag)
                return;
              this.\u0002.PerformClick();
            }
            catch (Exception ex)
            {
              // ISSUE: variable of a boxed type
              __Boxed<bool> local = (ValueType) flag;
              object obj = _param1;
              KeyEventArgs keyEventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) local, (object) this, obj, (object) keyEventArgs);
              throw;
            }
          });
        KeyEventHandler keyEventHandler2 = keyEventHandler1;
        textEdit.KeyDown += keyEventHandler2;
        SimpleButton simpleButton2 = this.\u0003;
        if (eventHandler2 == null)
          eventHandler2 = (EventHandler) ((_param1, _param2) =>
          {
            try
            {
              if (false)
                goto label_2;
label_1:
              if (false)
                return;
              this.Close();
label_2:
              if (false)
                goto label_1;
            }
            catch (Exception ex)
            {
              object obj = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) this, obj, (object) eventArgs);
              throw;
            }
          });
        EventHandler eventHandler4 = eventHandler2;
        simpleButton2.Click += eventHandler4;
      }
      catch (Exception ex)
      {
        EventHandler eventHandler5 = eventHandler1;
        KeyEventHandler keyEventHandler3 = keyEventHandler1;
        EventHandler eventHandler6 = eventHandler2;
        \u0005.\u0008.\u0001(ex, (object) eventHandler5, (object) keyEventHandler3, (object) eventHandler6, (object) this);
        throw;
      }
    }
  }
}
