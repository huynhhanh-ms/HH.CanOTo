// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0004
{
  internal class \u0001 : XtraForm
  {
    private IContainer \u0001;
    private LabelControl \u0002;
    private TextEdit \u0003;
    private PanelControl \u0004;
    private SimpleButton \u0005;
    private SimpleButton \u0006;
    private LabelControl \u0007;
    private TextEdit \u0008;
    private LabelControl \u000E;
    private TextEdit \u000F;
    private LabelControl \u0010;
    private TextEdit \u0011;
    private LabelControl \u0012;
    private TextEdit \u0013;
    private LabelControl \u0014;
    private TextEdit \u0015;

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
      ComponentResourceManager componentResourceManager1;
      try
      {
        componentResourceManager1 = new ComponentResourceManager(typeof (\u0004.\u0001));
        this.\u0002 = new LabelControl();
        this.\u0003 = new TextEdit();
        this.\u0004 = new PanelControl();
        this.\u0005 = new SimpleButton();
        this.\u0006 = new SimpleButton();
        this.\u0007 = new LabelControl();
        this.\u0008 = new TextEdit();
        this.\u000E = new LabelControl();
        this.\u000F = new TextEdit();
        this.\u0010 = new LabelControl();
        this.\u0011 = new TextEdit();
        this.\u0012 = new LabelControl();
        this.\u0013 = new TextEdit();
        this.\u0014 = new LabelControl();
        this.\u0015 = new TextEdit();
        this.\u0003.Properties.BeginInit();
        this.\u0004.BeginInit();
        if (true)
        {
          this.\u0004.SuspendLayout();
          this.\u0008.Properties.BeginInit();
          this.\u000F.Properties.BeginInit();
          this.\u0011.Properties.BeginInit();
          this.\u0013.Properties.BeginInit();
          this.\u0015.Properties.BeginInit();
          this.SuspendLayout();
          this.\u0002.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold);
          this.\u0002.Location = new Point(8, 60);
          this.\u0002.Name = \u0005.\u0004.\u0001(109);
          this.\u0002.Size = new Size(72, 13);
          this.\u0002.TabIndex = 0;
          this.\u0002.Text = \u0005.\u0004.\u0001(130);
          this.\u0003.Location = new Point(83, 57);
          this.\u0003.Name = \u0005.\u0004.\u0001(151);
          this.\u0003.Size = new Size(394, 20);
          this.\u0003.TabIndex = 1;
          this.\u0004.Controls.Add((Control) this.\u0005);
          this.\u0004.Controls.Add((Control) this.\u0006);
          this.\u0004.Dock = DockStyle.Top;
          this.\u0004.Location = new Point(0, 0);
          this.\u0004.LookAndFeel.SkinName = \u0005.\u0004.\u0001(160);
          this.\u0004.LookAndFeel.UseDefaultLookAndFeel = false;
          this.\u0004.Name = \u0005.\u0004.\u0001(173);
          this.\u0004.Size = new Size(490, 50);
          this.\u0004.TabIndex = 8;
          this.\u0005.Image = (Image) \u0008.\u0004.exit;
          this.\u0005.Location = new Point(105, 5);
          this.\u0005.LookAndFeel.SkinName = \u0005.\u0004.\u0001(160);
          this.\u0005.LookAndFeel.UseDefaultLookAndFeel = false;
          this.\u0005.Name = \u0005.\u0004.\u0001(194);
          this.\u0005.Size = new Size(90, 40);
        }
        this.\u0005.TabIndex = 0;
        this.\u0005.Text = \u0005.\u0004.\u0001(207);
        this.\u0006.Image = (Image) \u0008.\u0004.save;
        this.\u0006.Location = new Point(9, 5);
        this.\u0006.LookAndFeel.SkinName = \u0005.\u0004.\u0001(160);
        this.\u0006.LookAndFeel.UseDefaultLookAndFeel = false;
        this.\u0006.Name = \u0005.\u0004.\u0001(216);
        this.\u0006.Size = new Size(90, 40);
        this.\u0006.TabIndex = 0;
        this.\u0006.Text = \u0005.\u0004.\u0001(225);
        this.\u0007.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold);
        this.\u0007.Location = new Point(38, 82);
        this.\u0007.Name = \u0005.\u0004.\u0001(234);
        this.\u0007.Size = new Size(42, 13);
        this.\u0007.TabIndex = 0;
        this.\u0007.Text = \u0005.\u0004.\u0001((int) byte.MaxValue);
        this.\u0008.Location = new Point(83, 79);
        do
        {
          this.\u0008.Name = \u0005.\u0004.\u0001(276);
          this.\u0008.Size = new Size(394, 20);
          this.\u0008.TabIndex = 1;
          this.\u000E.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold);
          this.\u000E.Location = new Point(17, 104);
          this.\u000E.Name = \u0005.\u0004.\u0001(289);
          this.\u000E.Size = new Size(63, 13);
          this.\u000E.TabIndex = 0;
          this.\u000E.Text = \u0005.\u0004.\u0001(310);
          this.\u000F.Location = new Point(83, 101);
          this.\u000F.Name = \u0005.\u0004.\u0001(331);
          this.\u000F.Size = new Size(394, 20);
          this.\u000F.TabIndex = 1;
          this.\u0010.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold);
          this.\u0010.Location = new Point(34, 126);
          this.\u0010.Name = \u0005.\u0004.\u0001(348);
          this.\u0010.Size = new Size(46, 13);
          this.\u0010.TabIndex = 0;
          this.\u0010.Text = \u0005.\u0004.\u0001(369);
          this.\u0011.Location = new Point(83, 123);
          this.\u0011.Name = \u0005.\u0004.\u0001(386);
          this.\u0011.Size = new Size(394, 20);
          this.\u0011.TabIndex = 1;
          this.\u0012.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold);
          this.\u0012.Location = new Point(8, 148);
          this.\u0012.Name = \u0005.\u0004.\u0001(399);
          this.\u0012.Size = new Size(72, 13);
          this.\u0012.TabIndex = 0;
          this.\u0012.Text = \u0005.\u0004.\u0001(420);
          this.\u0013.Location = new Point(83, 167);
          this.\u0013.Name = \u0005.\u0004.\u0001(441);
          this.\u0013.Size = new Size(394, 20);
          this.\u0013.TabIndex = 1;
          this.\u0014.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold);
          this.\u0014.Location = new Point(4, 170);
          if (true)
          {
            this.\u0014.Name = \u0005.\u0004.\u0001(462);
            this.\u0014.Size = new Size(76, 13);
            this.\u0014.TabIndex = 0;
            this.\u0014.Text = \u0005.\u0004.\u0001(483);
            this.\u0015.Location = new Point(83, 145);
            this.\u0015.Name = \u0005.\u0004.\u0001(508);
          }
          this.\u0015.Size = new Size(394, 20);
          this.\u0015.TabIndex = 1;
          this.AutoScaleDimensions = new SizeF(6f, 13f);
          this.AutoScaleMode = AutoScaleMode.Font;
          this.ClientSize = new Size(490, 201);
          this.Controls.Add((Control) this.\u0004);
          this.Controls.Add((Control) this.\u0015);
          this.Controls.Add((Control) this.\u0014);
          this.Controls.Add((Control) this.\u0013);
          this.Controls.Add((Control) this.\u0012);
          this.Controls.Add((Control) this.\u0011);
          this.Controls.Add((Control) this.\u0010);
          this.Controls.Add((Control) this.\u000F);
          this.Controls.Add((Control) this.\u000E);
          this.Controls.Add((Control) this.\u0008);
          this.Controls.Add((Control) this.\u0007);
          this.Controls.Add((Control) this.\u0003);
          this.Controls.Add((Control) this.\u0002);
          this.Icon = (Icon) componentResourceManager1.GetObject(\u0005.\u0004.\u0001(525));
          this.LookAndFeel.UseDefaultLookAndFeel = false;
          this.Name = \u0005.\u0004.\u0001(542);
          this.StartPosition = FormStartPosition.CenterScreen;
          this.Text = \u0005.\u0004.\u0001(555);
          this.\u0003.Properties.EndInit();
          this.\u0004.EndInit();
          this.\u0004.ResumeLayout(false);
        }
        while (false);
        this.\u0008.Properties.EndInit();
        this.\u000F.Properties.EndInit();
        this.\u0011.Properties.EndInit();
        this.\u0013.Properties.EndInit();
        this.\u0015.Properties.EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
      }
      catch (Exception ex)
      {
        ComponentResourceManager componentResourceManager2 = componentResourceManager1;
        \u0005.\u0008.\u0001(ex, (object) componentResourceManager2, (object) this);
        throw;
      }
    }

    public \u0001()
    {
      EventHandler eventHandler1 = (EventHandler) null;
      EventHandler eventHandler2 = (EventHandler) null;
      EventHandler eventHandler3 = (EventHandler) null;
      this.\u0001 = (IContainer) null;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      try
      {
        this.\u0001();
        if (eventHandler1 == null)
          eventHandler1 = (EventHandler) ((_param1, _param2) =>
          {
            \u0008.\u0005 obj1;
            try
            {
              if (true)
                goto label_4;
label_3:
              this.\u0013.Text = obj1.TieuDeLoGo;
              return;
label_4:
              obj1 = new \u0008.\u0005();
              this.\u0015.Text = obj1.CongTyCan;
              this.\u0008.Text = obj1.DiaChi;
              do
              {
                this.\u000F.Text = obj1.DienThoai;
                this.\u0003.Text = obj1.Ten;
              }
              while (false);
              this.\u0011.Text = obj1.TieuDe;
              goto label_3;
            }
            catch (Exception ex)
            {
              \u0008.\u0005 obj2 = obj1;
              object obj3 = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) obj2, (object) this, obj3, (object) eventArgs);
              throw;
            }
          });
        this.Load += eventHandler1;
        SimpleButton simpleButton1 = this.\u0006;
        if (eventHandler2 == null)
          eventHandler2 = (EventHandler) ((_param1, _param2) =>
          {
            bool flag;
            try
            {
              while (true)
              {
                int num1 = \u0008.\u0005.\u0001(this.\u0003.Text, this.\u0008.Text, this.\u000F.Text, this.\u0011.Text, this.\u0015.Text, this.\u0013.Text) ? 1 : 0;
                int num2;
                while (true)
                {
                  num2 = num1 == 0 ? 1 : 0;
                  if (false)
                    num1 = num2;
                  else
                    break;
                }
                flag = num2 != 0;
                if (!flag)
                {
                  int num3 = (int) XtraMessageBox.Show(\u0005.\u0004.\u0001(584), \u0005.\u0004.\u0001(609), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                  this.Close();
                  do
                    ;
                  while (false);
                  if (true)
                    break;
                }
                else
                {
                  int num4 = (int) XtraMessageBox.Show(\u0005.\u0004.\u0001(626), \u0005.\u0004.\u0001(643), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  break;
                }
              }
            }
            catch (Exception ex)
            {
              // ISSUE: variable of a boxed type
              __Boxed<bool> local = (ValueType) flag;
              object obj = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) local, (object) this, obj, (object) eventArgs);
              throw;
            }
          });
        EventHandler eventHandler4 = eventHandler2;
        simpleButton1.Click += eventHandler4;
        SimpleButton simpleButton2 = this.\u0005;
        if (eventHandler3 == null)
          eventHandler3 = (EventHandler) ((_param1, _param2) =>
          {
            try
            {
              this.Close();
            }
            catch (Exception ex)
            {
              object obj = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) this, obj, (object) eventArgs);
              throw;
            }
          });
        EventHandler eventHandler5 = eventHandler3;
        simpleButton2.Click += eventHandler5;
      }
      catch (Exception ex)
      {
        EventHandler eventHandler6 = eventHandler1;
        EventHandler eventHandler7 = eventHandler2;
        EventHandler eventHandler8 = eventHandler3;
        \u0005.\u0008.\u0001(ex, (object) eventHandler6, (object) eventHandler7, (object) eventHandler8, (object) this);
        throw;
      }
    }
  }
}
