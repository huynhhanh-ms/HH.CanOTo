// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0004
{
  internal class \u0003 : XtraForm
  {
    private IContainer \u0001;
    private SimpleButton \u0002;
    private SimpleButton \u0003;
    private ComboBoxEdit \u0004;
    private LabelControl \u0005;
    private GroupControl \u0006;
    private ComboBoxEdit \u0007;
    private ComboBoxEdit \u0008;
    private ComboBoxEdit \u000E;
    private LabelControl \u000F;
    private LabelControl \u0010;
    private LabelControl \u0011;
    private SpinEdit \u0012;
    private LabelControl \u0013;
    private LabelControl \u0014;
    private LabelControl \u0015;
    private SpinEdit \u0016;
    private SpinEdit \u0017;
    private DXValidationProvider \u0018;
    private ComboBoxEdit \u0019;
    private LabelControl \u001A;
    private ComboBoxEdit \u001B;
    private LabelControl \u001C;

    public \u0003()
    {
      EventHandler eventHandler1 = (EventHandler) null;
      EventHandler eventHandler2 = (EventHandler) null;
      EventHandler eventHandler3 = (EventHandler) null;
      this.\u0001 = (IContainer) null;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      try
      {
        this.\u0002();
        if (eventHandler1 == null)
          eventHandler1 = (EventHandler) ((_param1, _param2) =>
          {
            \u0001.\u0002 obj1;
            try
            {
              this.\u0001();
              obj1 = new \u0001.\u0002();
              this.\u0004.Text = obj1.InKieuCan;
              this.\u0008.Text = obj1.InGioCan;
              if (true)
              {
                this.\u0007.Text = obj1.InGia30;
                this.\u000E.Text = obj1.GiayInOto;
                this.\u0019.Text = obj1.CanTuDongOto;
                this.\u0016.Text = obj1.DonGia30;
                this.\u0012.Text = obj1.DonGiaLon25;
              }
              this.\u001B.Text = obj1.CanTiep;
              this.\u0017.Text = obj1.DonGiaNho25;
            }
            catch (Exception ex)
            {
              \u0001.\u0002 obj2 = obj1;
              object obj3 = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) obj2, (object) this, obj3, (object) eventArgs);
              throw;
            }
          });
        this.Load += eventHandler1;
        SimpleButton simpleButton1 = this.\u0003;
        if (eventHandler2 == null)
          eventHandler2 = (EventHandler) ((_param1, _param2) =>
          {
            bool flag;
            try
            {
              flag = !this.\u0018.Validate();
              if (flag)
                return;
              flag = !\u0001.\u0002.\u0001(this.\u0019.Text, this.\u000E.Text, this.\u0008.Text, this.\u0007.Text, this.\u0004.Text, this.\u001B.Text, this.\u0012.Text, this.\u0017.Text, this.\u0016.Text);
              if (!flag)
              {
                int num = (int) XtraMessageBox.Show(\u0005.\u0004.\u0001(584), \u0005.\u0004.\u0001(609), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.DialogResult = DialogResult.OK;
                this.Close();
              }
              else
              {
                int num1 = (int) XtraMessageBox.Show(\u0005.\u0004.\u0001(626), \u0005.\u0004.\u0001(643), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        SimpleButton simpleButton2 = this.\u0002;
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

    public void \u0001()
    {
      string[] items1;
      string[] strArray1;
      string[] items2;
      string[] items3;
      string[] items4;
      string[] items5;
      string[] items6;
      try
      {
        strArray1 = new string[2]
        {
          \u0005.\u0004.\u0001(3771),
          \u0005.\u0004.\u0001(4213)
        };
        items1 = strArray1;
        this.\u0019.Properties.Items.AddRange((object[]) items1);
        strArray1 = new string[3]
        {
          \u0005.\u0004.\u0001(4112),
          \u0005.\u0004.\u0001(4125),
          \u0005.\u0004.\u0001(4503)
        };
        items2 = strArray1;
        this.\u000E.Properties.Items.AddRange((object[]) items2);
        strArray1 = new string[2]
        {
          \u0005.\u0004.\u0001(3771),
          \u0005.\u0004.\u0001(4213)
        };
        items3 = strArray1;
        this.\u0008.Properties.Items.AddRange((object[]) items3);
        strArray1 = new string[2]
        {
          \u0005.\u0004.\u0001(3771),
          null
        };
        if (true)
          strArray1[1] = \u0005.\u0004.\u0001(4213);
        do
        {
          items4 = strArray1;
          this.\u0007.Properties.Items.AddRange((object[]) items4);
          strArray1 = new string[2]
          {
            \u0005.\u0004.\u0001(3771),
            \u0005.\u0004.\u0001(4213)
          };
          items5 = strArray1;
          this.\u0004.Properties.Items.AddRange((object[]) items5);
          strArray1 = new string[2]
          {
            \u0005.\u0004.\u0001(3771),
            null
          };
        }
        while (false);
        strArray1[1] = \u0005.\u0004.\u0001(4213);
        items6 = strArray1;
        this.\u001B.Properties.Items.AddRange((object[]) items6);
      }
      catch (Exception ex)
      {
        string[] strArray2 = items1;
        string[] strArray3 = items2;
        string[] strArray4 = items3;
        string[] strArray5 = items4;
        string[] strArray6 = items5;
        string[] strArray7 = items6;
        string[] strArray8 = strArray1;
        \u0005.\u0008.\u0001(ex, (object) strArray2, (object) strArray3, (object) strArray4, (object) strArray5, (object) strArray6, (object) strArray7, (object) strArray8, (object) this);
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
        \u0005.\u0008.\u0001(ex, (object) local1, (object) this, (object) local2);
        throw;
      }
    }

    private void \u0002()
    {
      int[] bits;
      EditorButton[] editorButtonArray1;
      try
      {
        this.\u0001 = (IContainer) new System.ComponentModel.Container();
        this.\u0002 = new SimpleButton();
        this.\u0003 = new SimpleButton();
        this.\u0016 = new SpinEdit();
        this.\u0017 = new SpinEdit();
        this.\u0012 = new SpinEdit();
        this.\u0013 = new LabelControl();
        this.\u0004 = new ComboBoxEdit();
        this.\u0014 = new LabelControl();
        this.\u0015 = new LabelControl();
        this.\u0005 = new LabelControl();
        this.\u0006 = new GroupControl();
        this.\u0007 = new ComboBoxEdit();
        this.\u0008 = new ComboBoxEdit();
        this.\u000E = new ComboBoxEdit();
        this.\u0019 = new ComboBoxEdit();
        this.\u001B = new ComboBoxEdit();
        this.\u000F = new LabelControl();
        this.\u001C = new LabelControl();
        this.\u0010 = new LabelControl();
        this.\u0011 = new LabelControl();
        this.\u001A = new LabelControl();
        this.\u0018 = new DXValidationProvider(this.\u0001);
        this.\u0016.Properties.BeginInit();
        this.\u0017.Properties.BeginInit();
        do
        {
          this.\u0012.Properties.BeginInit();
          this.\u0004.Properties.BeginInit();
          this.\u0006.BeginInit();
          this.\u0006.SuspendLayout();
          this.\u0007.Properties.BeginInit();
          this.\u0008.Properties.BeginInit();
          this.\u000E.Properties.BeginInit();
          this.\u0019.Properties.BeginInit();
          this.\u001B.Properties.BeginInit();
          ((ISupportInitialize) this.\u0018).BeginInit();
          this.SuspendLayout();
          this.\u0002.Image = (Image) \u0008.\u0004.exit;
          this.\u0002.Location = new Point(159, 270);
          this.\u0002.Name = \u0005.\u0004.\u0001(4516);
          this.\u0002.Size = new Size(85, 40);
          this.\u0002.TabIndex = 4;
          this.\u0002.Text = \u0005.\u0004.\u0001(4529);
          this.\u0003.Image = (Image) \u0008.\u0004.save;
          this.\u0003.Location = new Point(49, 270);
          this.\u0003.Name = \u0005.\u0004.\u0001(4538);
          this.\u0003.Size = new Size(85, 40);
          this.\u0003.TabIndex = 5;
          this.\u0003.Text = \u0005.\u0004.\u0001(4547);
          SpinEdit spinEdit1 = this.\u0016;
          bits = new int[4];
          // ISSUE: variable of a boxed type
          __Boxed<Decimal> local1 = (ValueType) new Decimal(bits);
          spinEdit1.EditValue = (object) local1;
          this.\u0016.Location = new Point(129, 229);
          this.\u0016.Name = \u0005.\u0004.\u0001(4552);
          EditorButtonCollection buttons1 = this.\u0016.Properties.Buttons;
          editorButtonArray1 = new EditorButton[1]
          {
            new EditorButton()
          };
          EditorButton[] buttons2 = editorButtonArray1;
          buttons1.AddRange(buttons2);
          this.\u0016.Size = new Size(131, 20);
          if (true)
          {
            this.\u0016.TabIndex = 3;
            SpinEdit spinEdit2 = this.\u0017;
            bits = new int[4];
            // ISSUE: variable of a boxed type
            __Boxed<Decimal> local2 = (ValueType) new Decimal(bits);
            spinEdit2.EditValue = (object) local2;
            this.\u0017.Location = new Point(129, 206);
            this.\u0017.Name = \u0005.\u0004.\u0001(4569);
            EditorButtonCollection buttons3 = this.\u0017.Properties.Buttons;
            editorButtonArray1 = new EditorButton[1]
            {
              new EditorButton()
            };
            EditorButton[] buttons4 = editorButtonArray1;
            buttons3.AddRange(buttons4);
            this.\u0017.Size = new Size(131, 20);
            this.\u0017.TabIndex = 3;
            SpinEdit spinEdit3 = this.\u0012;
            bits = new int[4];
            // ISSUE: variable of a boxed type
            __Boxed<Decimal> local3 = (ValueType) new Decimal(bits);
            spinEdit3.EditValue = (object) local3;
            this.\u0012.Location = new Point(129, 183);
            this.\u0012.Name = \u0005.\u0004.\u0001(4590);
            EditorButtonCollection buttons5 = this.\u0012.Properties.Buttons;
            editorButtonArray1 = new EditorButton[1]
            {
              new EditorButton()
            };
            EditorButton[] buttons6 = editorButtonArray1;
            buttons5.AddRange(buttons6);
            this.\u0012.Size = new Size(131, 20);
            this.\u0012.TabIndex = 3;
            this.\u0013.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold);
            this.\u0013.Location = new Point(59, 232);
            this.\u0013.Name = \u0005.\u0004.\u0001(4611);
            this.\u0013.Size = new Size(64, 13);
            this.\u0013.TabIndex = 0;
            this.\u0013.Text = \u0005.\u0004.\u0001(4620);
            this.\u0004.Location = new Point(129, 120);
            this.\u0004.Name = \u0005.\u0004.\u0001(4641);
            EditorButtonCollection buttons7 = this.\u0004.Properties.Buttons;
            editorButtonArray1 = new EditorButton[1]
            {
              new EditorButton(ButtonPredefines.Combo)
            };
            EditorButton[] buttons8 = editorButtonArray1;
            buttons7.AddRange(buttons8);
            this.\u0004.Size = new Size(131, 20);
            this.\u0004.TabIndex = 2;
            this.\u0014.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold);
            if (true)
            {
              this.\u0014.Location = new Point(23, 209);
              if (true)
              {
                this.\u0014.Name = \u0005.\u0004.\u0001(4658);
                this.\u0014.Size = new Size(100, 13);
                this.\u0014.TabIndex = 0;
              }
              this.\u0014.Text = \u0005.\u0004.\u0001(4667);
              this.\u0015.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold);
              this.\u0015.Location = new Point(14, 186);
              this.\u0015.Name = \u0005.\u0004.\u0001(4696);
              this.\u0015.Size = new Size(109, 13);
              this.\u0015.TabIndex = 0;
              this.\u0015.Text = \u0005.\u0004.\u0001(4717);
              this.\u0005.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold);
              this.\u0005.Location = new Point(57, 123);
              this.\u0005.Name = \u0005.\u0004.\u0001(4750);
              this.\u0005.Size = new Size(66, 13);
              this.\u0005.TabIndex = 0;
              this.\u0005.Text = \u0005.\u0004.\u0001(4771);
              this.\u0006.Controls.Add((Control) this.\u0002);
              this.\u0006.Controls.Add((Control) this.\u0016);
              this.\u0006.Controls.Add((Control) this.\u0003);
              this.\u0006.Controls.Add((Control) this.\u0007);
              this.\u0006.Controls.Add((Control) this.\u0017);
              this.\u0006.Controls.Add((Control) this.\u0008);
              this.\u0006.Controls.Add((Control) this.\u0012);
              this.\u0006.Controls.Add((Control) this.\u0013);
              this.\u0006.Controls.Add((Control) this.\u000E);
              this.\u0006.Controls.Add((Control) this.\u0014);
              this.\u0006.Controls.Add((Control) this.\u0019);
              this.\u0006.Controls.Add((Control) this.\u0015);
              this.\u0006.Controls.Add((Control) this.\u001B);
              this.\u0006.Controls.Add((Control) this.\u0004);
              this.\u0006.Controls.Add((Control) this.\u000F);
              this.\u0006.Controls.Add((Control) this.\u001C);
              this.\u0006.Controls.Add((Control) this.\u0010);
              this.\u0006.Controls.Add((Control) this.\u0005);
              this.\u0006.Controls.Add((Control) this.\u0011);
              this.\u0006.Controls.Add((Control) this.\u001A);
              this.\u0006.Location = new Point(6, 6);
              this.\u0006.LookAndFeel.SkinName = \u0005.\u0004.\u0001(160);
              this.\u0006.LookAndFeel.UseDefaultLookAndFeel = false;
              this.\u0006.Name = \u0005.\u0004.\u0001(3104);
            }
            else
              goto label_11;
          }
          else
            goto label_8;
        }
        while (false);
        this.\u0006.Size = new Size(285, 325);
        this.\u0006.TabIndex = 3;
        this.\u0006.Text = \u0005.\u0004.\u0001(4792);
        this.\u0007.Location = new Point(129, 94);
        this.\u0007.Name = \u0005.\u0004.\u0001(4817);
        EditorButtonCollection buttons9 = this.\u0007.Properties.Buttons;
        editorButtonArray1 = new EditorButton[1]
        {
          new EditorButton(ButtonPredefines.Combo)
        };
        EditorButton[] buttons10 = editorButtonArray1;
        buttons9.AddRange(buttons10);
        this.\u0007.Size = new Size(131, 20);
        this.\u0007.TabIndex = 2;
label_7:
        this.\u0008.Location = new Point(129, 71);
        this.\u0008.Name = \u0005.\u0004.\u0001(4830);
        EditorButtonCollection buttons11 = this.\u0008.Properties.Buttons;
        editorButtonArray1 = new EditorButton[1]
        {
          new EditorButton(ButtonPredefines.Combo)
        };
        EditorButton[] buttons12 = editorButtonArray1;
        buttons11.AddRange(buttons12);
        this.\u0008.Size = new Size(131, 20);
        this.\u0008.TabIndex = 2;
        this.\u000E.Location = new Point(129, 48);
        this.\u000E.Name = \u0005.\u0004.\u0001(4847);
        EditorButtonCollection buttons13 = this.\u000E.Properties.Buttons;
        editorButtonArray1 = new EditorButton[1]
        {
          new EditorButton(ButtonPredefines.Combo)
        };
        EditorButton[] buttons14 = editorButtonArray1;
        buttons13.AddRange(buttons14);
        this.\u000E.Size = new Size(131, 20);
        this.\u000E.TabIndex = 2;
        this.\u0019.Location = new Point(129, 25);
        this.\u0019.Name = \u0005.\u0004.\u0001(4860);
label_8:
        EditorButtonCollection buttons15 = this.\u0019.Properties.Buttons;
        editorButtonArray1 = new EditorButton[1]
        {
          new EditorButton(ButtonPredefines.Combo)
        };
        EditorButton[] buttons16 = editorButtonArray1;
        buttons15.AddRange(buttons16);
        do
        {
          this.\u0019.Size = new Size(131, 20);
          this.\u0019.TabIndex = 2;
          this.\u001B.Location = new Point(129, 146);
          this.\u001B.Name = \u0005.\u0004.\u0001(4881);
          EditorButtonCollection buttons17 = this.\u001B.Properties.Buttons;
          editorButtonArray1 = new EditorButton[1]
          {
            new EditorButton(ButtonPredefines.Combo)
          };
          EditorButton[] buttons18 = editorButtonArray1;
          buttons17.AddRange(buttons18);
          this.\u001B.Size = new Size(131, 20);
          this.\u001B.TabIndex = 2;
          this.\u000F.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold);
          this.\u000F.Location = new Point(70, 97);
          this.\u000F.Name = \u0005.\u0004.\u0001(399);
          this.\u000F.Size = new Size(53, 13);
          this.\u000F.TabIndex = 0;
          this.\u000F.Text = \u0005.\u0004.\u0001(4894);
          this.\u001C.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold);
          this.\u001C.Location = new Point(57, 149);
          this.\u001C.Name = \u0005.\u0004.\u0001(109);
          this.\u001C.Size = new Size(68, 13);
          this.\u001C.TabIndex = 0;
          this.\u001C.Text = \u0005.\u0004.\u0001(4911);
          this.\u0010.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold);
          this.\u0010.Location = new Point(63, 74);
          this.\u0010.Name = \u0005.\u0004.\u0001(348);
          this.\u0010.Size = new Size(60, 13);
          this.\u0010.TabIndex = 0;
          this.\u0010.Text = \u0005.\u0004.\u0001(4936);
          this.\u0011.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold);
          this.\u0011.Location = new Point(80, 51);
          this.\u0011.Name = \u0005.\u0004.\u0001(289);
          this.\u0011.Size = new Size(43, 13);
          this.\u0011.TabIndex = 0;
          this.\u0011.Text = \u0005.\u0004.\u0001(4957);
        }
        while (false);
        this.\u001A.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold);
        this.\u001A.Location = new Point(48, 28);
        this.\u001A.Name = \u0005.\u0004.\u0001(234);
        this.\u001A.Size = new Size(75, 13);
        this.\u001A.TabIndex = 0;
        this.\u001A.Text = \u0005.\u0004.\u0001(4974);
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
label_11:
        this.ClientSize = new Size(304, 342);
        this.Controls.Add((Control) this.\u0006);
        this.LookAndFeel.SkinName = \u0005.\u0004.\u0001(3057);
        this.LookAndFeel.UseDefaultLookAndFeel = false;
        this.Name = \u0005.\u0004.\u0001(4999);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = \u0005.\u0004.\u0001(5012);
        this.\u0016.Properties.EndInit();
        this.\u0017.Properties.EndInit();
        this.\u0012.Properties.EndInit();
        if (true)
        {
          this.\u0004.Properties.EndInit();
          this.\u0006.EndInit();
          this.\u0006.ResumeLayout(false);
          this.\u0006.PerformLayout();
          this.\u0007.Properties.EndInit();
          this.\u0008.Properties.EndInit();
          this.\u000E.Properties.EndInit();
          this.\u0019.Properties.EndInit();
          this.\u001B.Properties.EndInit();
          ((ISupportInitialize) this.\u0018).EndInit();
          this.ResumeLayout(false);
        }
        else
          goto label_7;
      }
      catch (Exception ex)
      {
        int[] numArray = bits;
        EditorButton[] editorButtonArray2 = editorButtonArray1;
        \u0005.\u0008.\u0001(ex, (object) numArray, (object) editorButtonArray2, (object) this);
        throw;
      }
    }
  }
}
