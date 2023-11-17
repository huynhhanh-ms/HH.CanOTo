// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace \u0008
{
  internal class \u0002 : XtraForm
  {
    private IContainer \u0001;
    private GroupControl \u0002;
    private TextEdit \u0003;
    private LabelControl \u0004;
    private LabelControl \u0005;
    private LabelControl \u0006;
    private LabelControl \u0007;
    private LabelControl \u0008;
    private ComboBoxEdit \u000E;
    private ComboBoxEdit \u000F;
    private ComboBoxEdit \u0010;
    private ComboBoxEdit \u0011;
    private SimpleButton \u0012;
    private SimpleButton \u0013;
    private ComboBoxEdit \u0014;
    private LabelControl \u0015;
    private GroupControl \u0016;
    private TextEdit \u0017;
    private TextEdit \u0018;
    private TextEdit \u0019;
    private TextEdit \u001A;
    private LabelControl \u001B;
    private LabelControl \u001C;
    private LabelControl \u001D;
    private LabelControl \u001E;
    private TextEdit \u001F;
    private LabelControl \u007F;

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
      EditorButton[] editorButtonArray1;
      ComponentResourceManager componentResourceManager1;
      try
      {
        componentResourceManager1 = new ComponentResourceManager(typeof (\u0008.\u0002));
        this.\u0002 = new GroupControl();
        this.\u0014 = new ComboBoxEdit();
        this.\u0015 = new LabelControl();
        this.\u000E = new ComboBoxEdit();
        this.\u000F = new ComboBoxEdit();
        this.\u0010 = new ComboBoxEdit();
        this.\u0011 = new ComboBoxEdit();
        this.\u0003 = new TextEdit();
        this.\u0005 = new LabelControl();
        this.\u0006 = new LabelControl();
        this.\u0007 = new LabelControl();
        this.\u0008 = new LabelControl();
        this.\u0004 = new LabelControl();
        this.\u0012 = new SimpleButton();
        this.\u0013 = new SimpleButton();
        this.\u0016 = new GroupControl();
        this.\u001F = new TextEdit();
        this.\u0017 = new TextEdit();
        this.\u0018 = new TextEdit();
        this.\u0019 = new TextEdit();
        this.\u001A = new TextEdit();
        this.\u007F = new LabelControl();
        this.\u001B = new LabelControl();
        this.\u001C = new LabelControl();
        this.\u001D = new LabelControl();
        this.\u001E = new LabelControl();
        this.\u0002.BeginInit();
        this.\u0002.SuspendLayout();
        this.\u0014.Properties.BeginInit();
        this.\u000E.Properties.BeginInit();
        this.\u000F.Properties.BeginInit();
        this.\u0010.Properties.BeginInit();
        this.\u0011.Properties.BeginInit();
        this.\u0003.Properties.BeginInit();
        this.\u0016.BeginInit();
        this.\u0016.SuspendLayout();
        this.\u001F.Properties.BeginInit();
        this.\u0017.Properties.BeginInit();
        this.\u0018.Properties.BeginInit();
        this.\u0019.Properties.BeginInit();
        this.\u001A.Properties.BeginInit();
        this.SuspendLayout();
        this.\u0002.Controls.Add((Control) this.\u0014);
        this.\u0002.Controls.Add((Control) this.\u0015);
        this.\u0002.Controls.Add((Control) this.\u000E);
        this.\u0002.Controls.Add((Control) this.\u000F);
        this.\u0002.Controls.Add((Control) this.\u0010);
        this.\u0002.Controls.Add((Control) this.\u0011);
        this.\u0002.Controls.Add((Control) this.\u0003);
        this.\u0002.Controls.Add((Control) this.\u0005);
        this.\u0002.Controls.Add((Control) this.\u0006);
        this.\u0002.Controls.Add((Control) this.\u0007);
        this.\u0002.Controls.Add((Control) this.\u0008);
        this.\u0002.Controls.Add((Control) this.\u0004);
        this.\u0002.Location = new Point(9, 12);
        this.\u0002.LookAndFeel.SkinName = \u0005.\u0004.\u0001(160);
        if (true)
        {
          this.\u0002.LookAndFeel.UseDefaultLookAndFeel = false;
          this.\u0002.Name = \u0005.\u0004.\u0001(3104);
          this.\u0002.Size = new Size(262, 173);
          this.\u0002.TabIndex = 0;
          this.\u0002.Text = \u0005.\u0004.\u0001(5834);
          this.\u0014.Location = new Point(75, 142);
          this.\u0014.Name = \u0005.\u0004.\u0001(5851);
          EditorButtonCollection buttons1 = this.\u0014.Properties.Buttons;
          editorButtonArray1 = new EditorButton[1]
          {
            new EditorButton(ButtonPredefines.Combo)
          };
          EditorButton[] buttons2 = editorButtonArray1;
          buttons1.AddRange(buttons2);
          this.\u0014.Size = new Size(174, 20);
          this.\u0014.TabIndex = 4;
          this.\u0014.SelectedIndexChanged += new EventHandler(this.\u0002);
          this.\u0015.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold);
          this.\u0015.Location = new Point(8, 145);
          this.\u0015.Name = \u0005.\u0004.\u0001(4696);
          this.\u0015.Size = new Size(61, 13);
          this.\u0015.TabIndex = 3;
          this.\u0015.Text = \u0005.\u0004.\u0001(5872);
          this.\u000E.Location = new Point(75, 116);
          this.\u000E.Name = \u0005.\u0004.\u0001(5889);
          EditorButtonCollection buttons3 = this.\u000E.Properties.Buttons;
          editorButtonArray1 = new EditorButton[1]
          {
            new EditorButton(ButtonPredefines.Combo)
          };
          EditorButton[] buttons4 = editorButtonArray1;
          buttons3.AddRange(buttons4);
          this.\u000E.Size = new Size(174, 20);
          this.\u000E.TabIndex = 2;
          this.\u000E.EditValueChanged += new EventHandler(this.\u0001);
          this.\u000F.Location = new Point(75, 93);
          this.\u000F.Name = \u0005.\u0004.\u0001(5906);
          EditorButtonCollection buttons5 = this.\u000F.Properties.Buttons;
          editorButtonArray1 = new EditorButton[1]
          {
            new EditorButton(ButtonPredefines.Combo)
          };
          EditorButton[] buttons6 = editorButtonArray1;
          buttons5.AddRange(buttons6);
          this.\u000F.Size = new Size(174, 20);
          this.\u000F.TabIndex = 2;
          this.\u0010.Location = new Point(75, 70);
          this.\u0010.Name = \u0005.\u0004.\u0001(5927);
          EditorButtonCollection buttons7 = this.\u0010.Properties.Buttons;
          editorButtonArray1 = new EditorButton[1]
          {
            new EditorButton(ButtonPredefines.Combo)
          };
          EditorButton[] buttons8 = editorButtonArray1;
          buttons7.AddRange(buttons8);
          this.\u0010.Size = new Size(174, 20);
          this.\u0010.TabIndex = 2;
          this.\u0011.Location = new Point(75, 47);
          this.\u0011.Name = \u0005.\u0004.\u0001(5948);
          EditorButtonCollection buttons9 = this.\u0011.Properties.Buttons;
          editorButtonArray1 = new EditorButton[1]
          {
            new EditorButton(ButtonPredefines.Combo)
          };
          EditorButton[] buttons10 = editorButtonArray1;
          buttons9.AddRange(buttons10);
          this.\u0011.Size = new Size(174, 20);
          this.\u0011.TabIndex = 2;
          this.\u0003.Location = new Point(75, 24);
          this.\u0003.Name = \u0005.\u0004.\u0001(5969);
          this.\u0003.Size = new Size(174, 20);
          this.\u0003.TabIndex = 1;
          this.\u0005.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold);
          this.\u0005.Location = new Point(32, 119);
          this.\u0005.Name = \u0005.\u0004.\u0001(399);
          this.\u0005.Size = new Size(37, 13);
          this.\u0005.TabIndex = 0;
          this.\u0005.Text = \u0005.\u0004.\u0001(5986);
          this.\u0006.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold);
          this.\u0006.Location = new Point(15, 96);
          this.\u0006.Name = \u0005.\u0004.\u0001(348);
          this.\u0006.Size = new Size(54, 13);
          if (true)
          {
            this.\u0006.TabIndex = 0;
            this.\u0006.Text = \u0005.\u0004.\u0001(5999);
            this.\u0007.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold);
            this.\u0007.Location = new Point(14, 73);
            this.\u0007.Name = \u0005.\u0004.\u0001(289);
            this.\u0007.Size = new Size(55, 13);
            this.\u0007.TabIndex = 0;
            this.\u0007.Text = \u0005.\u0004.\u0001(6016);
            this.\u0008.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold);
            this.\u0008.Location = new Point(7, 50);
            this.\u0008.Name = \u0005.\u0004.\u0001(234);
            this.\u0008.Size = new Size(62, 13);
            this.\u0008.TabIndex = 0;
            this.\u0008.Text = \u0005.\u0004.\u0001(6029);
            this.\u0004.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold);
            this.\u0004.Location = new Point(37, 27);
            this.\u0004.Name = \u0005.\u0004.\u0001(109);
            this.\u0004.Size = new Size(32, 13);
            this.\u0004.TabIndex = 0;
            this.\u0004.Text = \u0005.\u0004.\u0001(6046);
            this.\u0012.Image = (Image) \u0008.\u0004.save;
            this.\u0012.Location = new Point(126, 191);
            this.\u0012.LookAndFeel.SkinName = \u0005.\u0004.\u0001(160);
            this.\u0012.LookAndFeel.UseDefaultLookAndFeel = false;
            this.\u0012.Name = \u0005.\u0004.\u0001(216);
            this.\u0012.Size = new Size(98, 45);
            this.\u0012.TabIndex = 1;
            this.\u0012.Text = \u0005.\u0004.\u0001(225);
            this.\u0013.Image = (Image) \u0008.\u0004.exit;
            this.\u0013.Location = new Point(347, 191);
            this.\u0013.LookAndFeel.SkinName = \u0005.\u0004.\u0001(160);
            this.\u0013.LookAndFeel.UseDefaultLookAndFeel = false;
            this.\u0013.Name = \u0005.\u0004.\u0001(6055);
            this.\u0013.Size = new Size(88, 45);
            this.\u0013.TabIndex = 1;
            this.\u0013.Text = \u0005.\u0004.\u0001(6068);
            this.\u0016.Controls.Add((Control) this.\u001F);
            this.\u0016.Controls.Add((Control) this.\u0017);
            this.\u0016.Controls.Add((Control) this.\u0018);
            this.\u0016.Controls.Add((Control) this.\u0019);
            this.\u0016.Controls.Add((Control) this.\u001A);
            this.\u0016.Controls.Add((Control) this.\u007F);
            this.\u0016.Controls.Add((Control) this.\u001B);
            this.\u0016.Controls.Add((Control) this.\u001C);
            this.\u0016.Controls.Add((Control) this.\u001D);
            this.\u0016.Controls.Add((Control) this.\u001E);
            this.\u0016.Location = new Point(292, 12);
            this.\u0016.LookAndFeel.SkinName = \u0005.\u0004.\u0001(160);
            this.\u0016.LookAndFeel.UseDefaultLookAndFeel = false;
            this.\u0016.Name = \u0005.\u0004.\u0001(3066);
            this.\u0016.Size = new Size(262, 173);
            this.\u0016.TabIndex = 0;
            this.\u0016.Text = \u0005.\u0004.\u0001(6077);
            this.\u001F.Location = new Point(128, 120);
            this.\u001F.Name = \u0005.\u0004.\u0001(6126);
            this.\u001F.Size = new Size(121, 20);
            this.\u001F.TabIndex = 1;
            this.\u0017.Location = new Point(128, 93);
            this.\u0017.Name = \u0005.\u0004.\u0001(6143);
            this.\u0017.Size = new Size(121, 20);
            this.\u0017.TabIndex = 1;
            this.\u0018.Location = new Point(128, 70);
            this.\u0018.Name = \u0005.\u0004.\u0001(6156);
            this.\u0018.Size = new Size(121, 20);
            this.\u0018.TabIndex = 1;
            this.\u0019.Location = new Point(128, 47);
            this.\u0019.Name = \u0005.\u0004.\u0001(6177);
          }
          this.\u0019.Size = new Size(121, 20);
          this.\u0019.TabIndex = 1;
          this.\u001A.Location = new Point(128, 24);
          this.\u001A.Name = \u0005.\u0004.\u0001(6194);
          this.\u001A.Size = new Size(121, 20);
          this.\u001A.TabIndex = 1;
          this.\u007F.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold);
          this.\u007F.Location = new Point(3, 123);
          this.\u007F.Name = \u0005.\u0004.\u0001(462);
          this.\u007F.Size = new Size(93, 13);
          this.\u007F.TabIndex = 0;
          this.\u007F.Text = \u0005.\u0004.\u0001(6211);
          this.\u001B.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold);
          this.\u001B.Location = new Point(55, 96);
          this.\u001B.Name = \u0005.\u0004.\u0001(6240);
          this.\u001B.Size = new Size(39, 13);
          this.\u001B.TabIndex = 0;
          this.\u001B.Text = \u0005.\u0004.\u0001(4465);
          this.\u001C.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold);
          this.\u001C.Location = new Point(15, 73);
          this.\u001C.Name = \u0005.\u0004.\u0001(6261);
          this.\u001C.Size = new Size(79, 13);
          this.\u001C.TabIndex = 0;
          this.\u001C.Text = \u0005.\u0004.\u0001(4432);
          this.\u001D.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold);
        }
        this.\u001D.Location = new Point(41, 50);
        this.\u001D.Name = \u0005.\u0004.\u0001(6282);
        this.\u001D.Size = new Size(53, 13);
        this.\u001D.TabIndex = 0;
        this.\u001D.Text = \u0005.\u0004.\u0001(4407);
        this.\u001E.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold);
        this.\u001E.Location = new Point(5, 27);
        this.\u001E.Name = \u0005.\u0004.\u0001(6303);
        this.\u001E.Size = new Size(89, 13);
        this.\u001E.TabIndex = 0;
        this.\u001E.Text = \u0005.\u0004.\u0001(6324);
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(564, 252);
        this.Controls.Add((Control) this.\u0013);
        this.Controls.Add((Control) this.\u0012);
        this.Controls.Add((Control) this.\u0016);
        this.Controls.Add((Control) this.\u0002);
        this.Icon = (Icon) componentResourceManager1.GetObject(\u0005.\u0004.\u0001(525));
        this.LookAndFeel.SkinName = \u0005.\u0004.\u0001(3057);
        this.LookAndFeel.UseDefaultLookAndFeel = false;
        this.Name = \u0005.\u0004.\u0001(6357);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = \u0005.\u0004.\u0001(6370);
        this.\u0002.EndInit();
        this.\u0002.ResumeLayout(false);
        this.\u0002.PerformLayout();
        this.\u0014.Properties.EndInit();
        this.\u000E.Properties.EndInit();
        this.\u000F.Properties.EndInit();
        this.\u0010.Properties.EndInit();
        this.\u0011.Properties.EndInit();
        this.\u0003.Properties.EndInit();
        this.\u0016.EndInit();
        this.\u0016.ResumeLayout(false);
        this.\u0016.PerformLayout();
        this.\u001F.Properties.EndInit();
        this.\u0017.Properties.EndInit();
        this.\u0018.Properties.EndInit();
        this.\u0019.Properties.EndInit();
        this.\u001A.Properties.EndInit();
        this.ResumeLayout(false);
      }
      catch (Exception ex)
      {
        ComponentResourceManager componentResourceManager2 = componentResourceManager1;
        EditorButton[] editorButtonArray2 = editorButtonArray1;
        \u0005.\u0008.\u0001(ex, (object) componentResourceManager2, (object) editorButtonArray2, (object) this);
        throw;
      }
    }

    public \u0002()
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
            \u0004.\u0002 obj1;
            try
            {
              this.\u0002();
              obj1 = new \u0004.\u0002();
              this.\u0014.Text = obj1.ModelCanOto;
              this.\u0010.Text = obj1.BaudrateOto;
label_1:
              while (true)
              {
                this.\u000F.Text = obj1.DataBitsOto;
                this.\u000E.Text = obj1.PatityOto;
                this.\u0011.Text = obj1.PortNameOto;
                this.\u0003.Text = obj1.TSHTOto;
                do
                {
                  if (true)
                  {
                    this.\u001A.Text = obj1.Kytudau;
                    if (true)
                    {
                      this.\u0019.Text = obj1.Vitridau;
                      this.\u0018.Text = obj1.Vitriketthuc;
                    }
                  }
                  else
                    goto label_1;
                }
                while (false);
                this.\u0017.Text = obj1.Dodai;
                this.\u001F.Text = obj1.ThapPhan;
                break;
              }
            }
            catch (Exception ex)
            {
              \u0004.\u0002 obj2 = obj1;
              object obj3 = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) obj2, (object) this, obj3, (object) eventArgs);
              throw;
            }
          });
        this.Load += eventHandler1;
        SimpleButton simpleButton1 = this.\u0012;
        if (eventHandler2 == null)
          eventHandler2 = (EventHandler) ((_param1, _param2) =>
          {
            string[] strArray1;
            string str1;
            bool flag;
            try
            {
              if (true)
              {
                strArray1 = new string[7];
                strArray1[0] = this.\u0011.Text;
                strArray1[1] = \u0005.\u0004.\u0001(6522);
                goto label_12;
              }
              else
                goto label_6;
label_4:
              int num1;
              if (true)
                flag = num1 != 0;
              else
                goto label_8;
label_6:
              if (!flag)
              {
                num1 = 584;
              }
              else
              {
                int num2 = (int) XtraMessageBox.Show(\u0005.\u0004.\u0001(626), \u0005.\u0004.\u0001(643), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
              }
label_8:
              if (num1 != 0)
              {
                int num3 = (int) XtraMessageBox.Show(\u0005.\u0004.\u0001(num1), \u0005.\u0004.\u0001(609), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (true)
                {
                  this.Close();
                  return;
                }
              }
              else
                goto label_4;
label_12:
              strArray1[2] = this.\u0010.Text;
              strArray1[3] = \u0005.\u0004.\u0001(6522);
              strArray1[4] = this.\u000F.Text;
              strArray1[5] = \u0005.\u0004.\u0001(6522);
              strArray1[6] = this.\u000E.Text;
              if (true)
                str1 = string.Concat(strArray1);
              num1 = !\u0004.\u0002.\u0001(this.\u0014.Text, str1, this.\u0011.Text, this.\u0010.Text, this.\u000F.Text, this.\u000E.Text, this.\u001A.Text, this.\u0019.Text, this.\u0018.Text, this.\u0017.Text, this.\u001F.Text) ? 1 : 0;
              goto label_4;
            }
            catch (Exception ex)
            {
              string str2 = str1;
              string[] strArray2 = strArray1;
              // ISSUE: variable of a boxed type
              __Boxed<bool> local = (ValueType) flag;
              object obj = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) str2, (object) strArray2, (object) local, (object) this, obj, (object) eventArgs);
              throw;
            }
          });
        EventHandler eventHandler4 = eventHandler2;
        simpleButton1.Click += eventHandler4;
        SimpleButton simpleButton2 = this.\u0013;
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

    public void \u0002()
    {
      string[] strArray1;
      string[] items1;
      string[] portNames;
      string[] items2;
      string[] items3;
      string[] items4;
      try
      {
        int length = 8;
        if (length != 0)
        {
          strArray1 = new string[length];
          strArray1[0] = \u0005.\u0004.\u0001(6403);
          strArray1[1] = \u0005.\u0004.\u0001(6416);
          strArray1[2] = \u0005.\u0004.\u0001(6421);
          strArray1[3] = \u0005.\u0004.\u0001(6430);
          strArray1[4] = \u0005.\u0004.\u0001(4058);
          strArray1[5] = \u0005.\u0004.\u0001(3966);
          strArray1[6] = \u0005.\u0004.\u0001(6435);
          if (true)
          {
            strArray1[7] = \u0005.\u0004.\u0001(6444);
            items1 = strArray1;
            if (true)
            {
              this.\u0014.Properties.Items.AddRange((object[]) items1);
              if (true)
              {
                portNames = SerialPort.GetPortNames();
                this.\u0011.Properties.Items.AddRange((object[]) portNames);
                strArray1 = new string[6];
              }
              else
                goto label_6;
            }
            else
              goto label_6;
          }
          strArray1[0] = \u0005.\u0004.\u0001(6453);
          strArray1[1] = \u0005.\u0004.\u0001(6462);
          strArray1[2] = \u0005.\u0004.\u0001(6471);
          strArray1[3] = \u0005.\u0004.\u0001(6480);
          strArray1[4] = \u0005.\u0004.\u0001(6489);
          strArray1[5] = \u0005.\u0004.\u0001(6498);
        }
        else
          goto label_9;
label_6:
        items2 = strArray1;
        if (false)
          return;
        this.\u0010.Properties.Items.AddRange((object[]) items2);
label_8:
        length = 3;
label_9:
        strArray1 = new string[length];
        strArray1[0] = \u0005.\u0004.\u0001(6507);
        strArray1[1] = \u0005.\u0004.\u0001(6512);
        strArray1[2] = \u0005.\u0004.\u0001(6517);
        items3 = strArray1;
        this.\u000F.Properties.Items.AddRange((object[]) items3);
        strArray1 = new string[3]
        {
          \u0005.\u0004.\u0001(3798),
          \u0005.\u0004.\u0001(3793),
          \u0005.\u0004.\u0001(3807)
        };
        if (true)
        {
          items4 = strArray1;
          if (true)
            this.\u000E.Properties.Items.AddRange((object[]) items4);
          else
            goto label_8;
        }
        else
          goto label_6;
      }
      catch (Exception ex)
      {
        string[] strArray2 = items1;
        string[] strArray3 = portNames;
        string[] strArray4 = items2;
        string[] strArray5 = items3;
        string[] strArray6 = items4;
        string[] strArray7 = strArray1;
        \u0005.\u0008.\u0001(ex, (object) strArray2, (object) strArray3, (object) strArray4, (object) strArray5, (object) strArray6, (object) strArray7, (object) this);
        throw;
      }
    }

    private void \u0001(object _param1, EventArgs _param2)
    {
      string[] strArray1;
      string str1;
      try
      {
        strArray1 = new string[7];
        if (true)
          goto label_3;
label_1:
        strArray1[4] = this.\u000F.Text;
        if (true)
        {
          strArray1[5] = \u0005.\u0004.\u0001(6522);
          strArray1[6] = this.\u000E.Text;
          str1 = string.Concat(strArray1);
          this.\u0003.Text = str1;
          return;
        }
        goto label_4;
label_3:
        strArray1[0] = this.\u0011.Text;
        strArray1[1] = \u0005.\u0004.\u0001(6522);
label_4:
        strArray1[2] = this.\u0010.Text;
        strArray1[3] = \u0005.\u0004.\u0001(6522);
        goto label_1;
      }
      catch (Exception ex)
      {
        string str2 = str1;
        string[] strArray2 = strArray1;
        object obj = _param1;
        EventArgs eventArgs = _param2;
        \u0005.\u0008.\u0001(ex, (object) str2, (object) strArray2, (object) this, obj, (object) eventArgs);
        throw;
      }
    }

    private void \u0002(object _param1, EventArgs _param2)
    {
      bool flag;
      try
      {
        int num1 = this.\u0014.Text == \u0005.\u0004.\u0001(6403) ? 1 : 0;
        int num2;
        int num3;
        while (true)
        {
          int num4 = num1 == 0 ? 1 : 0;
          while (true)
          {
            flag = num4 != 0;
            if (flag)
              goto label_4;
            else
              goto label_31;
label_3:
label_4:
            flag = !(this.\u0014.Text == \u0005.\u0004.\u0001(6430));
            if (!flag)
            {
              this.\u0017.Text = \u0005.\u0004.\u0001(6537);
              this.\u001A.Text = \u0005.\u0004.\u0001(6542);
              this.\u001F.Text = \u0005.\u0004.\u0001(6532);
            }
            else
              goto label_8;
label_6:
            if (true)
            {
              this.\u0019.Text = \u0005.\u0004.\u0001(6547);
              this.\u0018.Text = \u0005.\u0004.\u0001(6507);
            }
            else
              goto label_3;
label_8:
            int num5 = !(this.\u0014.Text == \u0005.\u0004.\u0001(6416)) ? 1 : 0;
            if (true)
            {
              flag = num5 != 0;
              if (flag)
                goto label_11;
            }
            else
            {
              num4 = num5;
              continue;
            }
label_10:
            this.\u0017.Text = \u0005.\u0004.\u0001(6537);
            this.\u001A.Text = \u0005.\u0004.\u0001(6527);
            this.\u001F.Text = \u0005.\u0004.\u0001(6532);
            this.\u0019.Text = \u0005.\u0004.\u0001(6547);
            this.\u0018.Text = \u0005.\u0004.\u0001(6507);
label_11:
            num2 = this.\u0014.Text == \u0005.\u0004.\u0001(6421) ? 1 : 0;
            if (true)
            {
              flag = num2 == 0;
              if (false)
                goto label_6;
              else
                break;
            }
            else
              goto label_24;
label_31:
            this.\u0017.Text = \u0005.\u0004.\u0001(6512);
            this.\u001A.Text = \u0005.\u0004.\u0001(6527);
            this.\u001F.Text = \u0005.\u0004.\u0001(6532);
            this.\u0019.Text = \u0005.\u0004.\u0001(6532);
            if (true)
            {
              this.\u0018.Text = \u0005.\u0004.\u0001(6512);
              goto label_3;
            }
            else
              goto label_10;
          }
          if (!flag)
          {
            this.\u0017.Text = \u0005.\u0004.\u0001(6537);
            this.\u001A.Text = \u0005.\u0004.\u0001(6552);
            this.\u001F.Text = \u0005.\u0004.\u0001(6532);
            this.\u0019.Text = \u0005.\u0004.\u0001(6547);
            this.\u0018.Text = \u0005.\u0004.\u0001(6507);
          }
          flag = !(this.\u0014.Text == \u0005.\u0004.\u0001(6435));
          num3 = flag ? 1 : 0;
          if (false)
            num1 = num3;
          else
            break;
        }
        if (num3 == 0)
        {
          this.\u0017.Text = \u0005.\u0004.\u0001(6542);
          this.\u001A.Text = \u0005.\u0004.\u0001(6542);
          this.\u001F.Text = \u0005.\u0004.\u0001(6532);
          this.\u0019.Text = \u0005.\u0004.\u0001(6527);
          this.\u0018.Text = \u0005.\u0004.\u0001(6507);
        }
        int num6 = !(this.\u0014.Text == \u0005.\u0004.\u0001(4058)) ? 1 : 0;
label_19:
        flag = num6 != 0;
        int num7 = flag ? 1 : 0;
        if (true)
        {
          if (num7 == 0)
          {
            this.\u0017.Text = \u0005.\u0004.\u0001(6532);
            this.\u001A.Text = \u0005.\u0004.\u0001(6532);
            this.\u001F.Text = \u0005.\u0004.\u0001(6532);
            this.\u0019.Text = \u0005.\u0004.\u0001(6532);
            this.\u0018.Text = \u0005.\u0004.\u0001(6532);
          }
          num7 = this.\u0014.Text == \u0005.\u0004.\u0001(3966) ? 1 : 0;
        }
        flag = num7 == 0;
        num2 = flag ? 1 : 0;
label_24:
        if (num2 == 0)
        {
          this.\u0017.Text = \u0005.\u0004.\u0001(6532);
          this.\u001A.Text = \u0005.\u0004.\u0001(6532);
          this.\u001F.Text = \u0005.\u0004.\u0001(6532);
          this.\u0019.Text = \u0005.\u0004.\u0001(6532);
          this.\u0018.Text = \u0005.\u0004.\u0001(6532);
        }
        num6 = !(this.\u0014.Text == \u0005.\u0004.\u0001(6444)) ? 1 : 0;
        if (true)
        {
          flag = num6 != 0;
          if (flag)
            return;
          this.\u0017.Text = \u0005.\u0004.\u0001(6532);
          this.\u001A.Text = \u0005.\u0004.\u0001(6532);
          this.\u001F.Text = \u0005.\u0004.\u0001(6532);
          this.\u0019.Text = \u0005.\u0004.\u0001(6532);
          this.\u0018.Text = \u0005.\u0004.\u0001(6532);
        }
        else
          goto label_19;
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
    }
  }
}
