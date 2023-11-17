// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.Objects;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security;
using System.Windows.Forms;
using System.Xml;
using Xtra.Data;

namespace \u0006
{
  internal class \u0001 : XtraForm
  {
    private IContainer \u0001;
    private SimpleButton \u0002;
    private SimpleButton \u0003;
    private TextEdit \u0004;
    private HyperLinkEdit \u0005;
    private HyperLinkEdit \u0006;
    private HyperLinkEdit \u0007;
    private CheckEdit \u0008;
    private CanDienTuEntities \u000E;

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
        this.\u0005 = new HyperLinkEdit();
        this.\u0006 = new HyperLinkEdit();
        this.\u0007 = new HyperLinkEdit();
        this.\u0008 = new CheckEdit();
        this.\u0002 = new SimpleButton();
        this.\u0003 = new SimpleButton();
        this.\u0004.Properties.BeginInit();
        this.\u0005.Properties.BeginInit();
        this.\u0006.Properties.BeginInit();
        this.\u0007.Properties.BeginInit();
        this.\u0008.Properties.BeginInit();
        this.SuspendLayout();
        this.\u0004.Location = new Point(28, 22);
        this.\u0004.Name = \u0005.\u0004.\u0001(6557);
        this.\u0004.Properties.Appearance.ForeColor = Color.White;
        this.\u0004.Properties.Appearance.Options.UseForeColor = true;
        this.\u0004.Properties.PasswordChar = '*';
        this.\u0004.Size = new Size(169, 20);
        this.\u0004.TabIndex = 8;
        this.\u0005.EditValue = (object) \u0005.\u0004.\u0001(11277);
        this.\u0005.Location = new Point(46, 89);
        this.\u0005.Name = \u0005.\u0004.\u0001(11294);
label_1:
        this.\u0005.Properties.Appearance.BackColor = Color.Transparent;
        do
        {
          this.\u0005.Properties.Appearance.ForeColor = Color.Black;
          this.\u0005.Properties.Appearance.Options.UseBackColor = true;
          this.\u0005.Properties.Appearance.Options.UseForeColor = true;
          this.\u0005.Properties.BorderStyle = BorderStyles.NoBorder;
          this.\u0005.Size = new Size(74, 18);
          this.\u0005.TabIndex = 13;
          this.\u0005.OpenLink += new OpenLinkEventHandler(this.\u0002);
          do
          {
            this.\u0006.EditValue = (object) \u0005.\u0004.\u0001(11323);
          }
          while (false);
          this.\u0006.Location = new Point(130, 89);
          this.\u0006.Name = \u0005.\u0004.\u0001(11348);
        }
        while (false);
        this.\u0006.Properties.Appearance.BackColor = Color.Transparent;
        if (true)
        {
          this.\u0006.Properties.Appearance.ForeColor = Color.Black;
          this.\u0006.Properties.Appearance.Options.UseBackColor = true;
          if (true)
          {
            this.\u0006.Properties.Appearance.Options.UseForeColor = true;
            this.\u0006.Properties.BorderStyle = BorderStyles.NoBorder;
            this.\u0006.Size = new Size(74, 18);
            this.\u0006.TabIndex = 14;
            this.\u0006.OpenLink += new OpenLinkEventHandler(this.\u0003);
          }
          else
            goto label_9;
label_8:
          this.\u0007.EditValue = (object) \u0005.\u0004.\u0001(11377);
          this.\u0007.Location = new Point(3, 113);
          this.\u0007.Name = \u0005.\u0004.\u0001(11398);
label_9:
          if (true)
          {
            this.\u0007.Properties.Appearance.BackColor = Color.Transparent;
            this.\u0007.Properties.Appearance.ForeColor = Color.Black;
            this.\u0007.Properties.Appearance.Options.UseBackColor = true;
            this.\u0007.Properties.Appearance.Options.UseForeColor = true;
            this.\u0007.Properties.BorderStyle = BorderStyles.NoBorder;
            this.\u0007.Size = new Size(230, 18);
            this.\u0007.TabIndex = 15;
            if (true)
            {
              this.\u0007.OpenLink += new OpenLinkEventHandler(this.\u0001);
              this.\u0008.Location = new Point(26, 55);
              this.\u0008.Name = \u0005.\u0004.\u0001(11427);
              this.\u0008.Properties.Caption = \u0005.\u0004.\u0001(11444);
              this.\u0008.Size = new Size(171, 19);
              this.\u0008.TabIndex = 16;
              if (true)
              {
                this.\u0002.Image = (Image) \u0008.\u0004.chec;
                this.\u0002.Location = new Point(28, 137);
                this.\u0002.Name = \u0005.\u0004.\u0001(4538);
                this.\u0002.Size = new Size(74, 40);
                this.\u0002.TabIndex = 11;
                this.\u0002.Text = \u0005.\u0004.\u0001(4547);
                this.\u0003.Image = (Image) \u0008.\u0004.exit;
                this.\u0003.Location = new Point(130, 137);
                this.\u0003.Name = \u0005.\u0004.\u0001(194);
                this.\u0003.Size = new Size(77, 40);
                this.\u0003.TabIndex = 12;
                this.\u0003.Text = \u0005.\u0004.\u0001(6570);
                if (true)
                {
                  this.AutoScaleDimensions = new SizeF(6f, 13f);
                  this.AutoScaleMode = AutoScaleMode.Font;
                  this.ClientSize = new Size(230, 193);
                  this.ControlBox = false;
                  this.Controls.Add((Control) this.\u0008);
                  this.Controls.Add((Control) this.\u0007);
                }
                else
                  goto label_8;
              }
              else
                goto label_16;
            }
            else
              goto label_1;
          }
          this.Controls.Add((Control) this.\u0006);
          this.Controls.Add((Control) this.\u0005);
          this.Controls.Add((Control) this.\u0002);
          this.Controls.Add((Control) this.\u0003);
          this.Controls.Add((Control) this.\u0004);
          this.Name = \u0005.\u0004.\u0001(11469);
        }
        this.StartPosition = FormStartPosition.CenterScreen;
label_16:
        this.Text = \u0005.\u0004.\u0001(11494);
        this.\u0004.Properties.EndInit();
        this.\u0005.Properties.EndInit();
        this.\u0006.Properties.EndInit();
        this.\u0007.Properties.EndInit();
        this.\u0008.Properties.EndInit();
        this.ResumeLayout(false);
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
      this.\u0001 = (IContainer) null;
      this.\u000E = new CanDienTuEntities();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      try
      {
        this.\u0001();
        this.\u0003();
        SimpleButton simpleButton = this.\u0002;
        if (eventHandler1 == null)
          eventHandler1 = (EventHandler) ((_param1, _param2) =>
          {
            ParameterExpression parameterExpression1;
            // ISSUE: variable of a compiler-generated type
            \u0006.\u0001.\u0001 obj1;
            ParameterExpression[] parameterExpressionArray1;
            bool flag;
            try
            {
              // ISSUE: object of a compiler-generated type is created
              obj1 = new \u0006.\u0001.\u0001();
              // ISSUE: reference to a compiler-generated field
              obj1.\u0001 = this.\u0004.Text;
              ObjectSet<PassWord> passWord = this.\u000E.PassWord;
              parameterExpression1 = Expression.Parameter(typeof (PassWord), \u0005.\u0004.\u0001(4088));
              // ISSUE: method reference
              // ISSUE: field reference
              // ISSUE: method reference
              BinaryExpression body = Expression.Equal((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (PassWord.get_Ten))), (Expression) Expression.Field((Expression) Expression.Constant((object) obj1), FieldInfo.GetFieldFromHandle(__fieldref (\u0006.\u0001.\u0001.\u0001))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.op_Equality)));
              parameterExpressionArray1 = new ParameterExpression[1]
              {
                parameterExpression1
              };
              ParameterExpression[] parameterExpressionArray2 = parameterExpressionArray1;
              Expression<Func<PassWord, bool>> predicate = Expression.Lambda<Func<PassWord, bool>>((Expression) body, parameterExpressionArray2);
              flag = !passWord.Where<PassWord>(predicate).Any<PassWord>();
              if (flag)
                goto label_2;
label_1:
              this.DialogResult = DialogResult.Yes;
              this.Close();
              this.\u0002();
              return;
label_2:
              // ISSUE: reference to a compiler-generated field
              flag = !(\u0005.\u0004.\u0001(6633) == obj1.\u0001);
              if (!flag)
              {
                this.DialogResult = DialogResult.OK;
                this.Close();
              }
              else
              {
                int num = (int) XtraMessageBox.Show(\u0005.\u0004.\u0001(6658), \u0005.\u0004.\u0001(643), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (false)
                  goto label_1;
              }
            }
            catch (Exception ex)
            {
              // ISSUE: variable of a compiler-generated type
              \u0006.\u0001.\u0001 obj2 = obj1;
              ParameterExpression parameterExpression2 = parameterExpression1;
              ParameterExpression[] parameterExpressionArray3 = parameterExpressionArray1;
              // ISSUE: variable of a boxed type
              __Boxed<bool> local = (ValueType) flag;
              object obj3 = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) obj2, (object) parameterExpression2, (object) parameterExpressionArray3, (object) local, (object) this, obj3, (object) eventArgs);
              throw;
            }
          });
        EventHandler eventHandler2 = eventHandler1;
        simpleButton.Click += eventHandler2;
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
        this.\u0003.Click += (EventHandler) ((_param0, _param1) =>
        {
          try
          {
            Environment.Exit(-1);
          }
          catch (Exception ex)
          {
            object obj = _param0;
            EventArgs eventArgs = _param1;
            \u0005.\u0008.\u0001(ex, obj, (object) eventArgs);
            throw;
          }
        });
      }
      catch (Exception ex)
      {
        EventHandler eventHandler3 = eventHandler1;
        KeyEventHandler keyEventHandler3 = keyEventHandler1;
        \u0005.\u0008.\u0001(ex, (object) eventHandler3, (object) keyEventHandler3, (object) this);
        throw;
      }
    }

    private void \u0002()
    {
      bool flag;
      try
      {
        while (true)
        {
          int num1 = this.\u0008.Checked ? 1 : 0;
          int num2;
          while (true)
          {
            flag = num1 == 0;
            if (!flag)
            {
              num2 = 11527;
              if (num2 == 0)
                num1 = num2;
              else
                goto label_9;
            }
            else
              break;
          }
          \u0001.\u0006.\u0001(\u0005.\u0004.\u0001(11527), \u0005.\u0004.\u0001(720), (string) null);
          if (false)
            continue;
          goto label_7;
label_9:
          \u0001.\u0006.\u0001(\u0005.\u0004.\u0001(num2), this.\u0004.EditValue.ToString(), (string) null);
          break;
        }
        if (true)
        {
          \u0001.\u0006.\u0001(\u0005.\u0004.\u0001(11536), \u0005.\u0004.\u0001(11549), (string) null);
          return;
        }
label_7:
        \u0001.\u0006.\u0001(\u0005.\u0004.\u0001(11536), \u0005.\u0004.\u0001(720), (string) null);
      }
      catch (Exception ex)
      {
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (ValueType) flag;
        \u0005.\u0008.\u0001(ex, (object) local, (object) this);
        throw;
      }
    }

    private void \u0003()
    {
      bool flag;
      try
      {
        do
        {
          int num1 = 11536;
          int num2;
          while (true)
          {
            num2 = !(\u0001.\u0006.\u0001(\u0005.\u0004.\u0001(num1)) == \u0005.\u0004.\u0001(11549)) ? 1 : 0;
            if (false)
              num1 = num2;
            else
              break;
          }
          flag = num2 != 0;
          if (!flag)
          {
            this.\u0004.EditValue = (object) \u0001.\u0006.\u0001(\u0005.\u0004.\u0001(11527));
            if (true)
            {
              if (true)
                this.\u0008.Checked = true;
              else
                break;
            }
            else
              goto label_4;
          }
          else
            break;
        }
        while (false);
        goto label_3;
label_4:
        return;
label_3:
        this.\u0004();
      }
      catch (Exception ex)
      {
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (ValueType) flag;
        \u0005.\u0008.\u0001(ex, (object) local, (object) this);
        throw;
      }
    }

    private void \u0001(object _param1, OpenLinkEventArgs _param2)
    {
      FileInfo fileInfo1;
      Process process1;
      string str1;
      bool flag;
      try
      {
        str1 = \u0001.\u0006.\u0001(\u0005.\u0004.\u0001(6970));
        flag = !File.Exists(str1);
        if (flag)
        {
          int num = (int) XtraMessageBox.Show(\u0005.\u0004.\u0001(11558));
        }
        else
        {
          fileInfo1 = new FileInfo(str1);
          process1 = new Process();
          process1.StartInfo.FileName = fileInfo1.DirectoryName;
          process1.Start();
        }
      }
      catch (Exception ex)
      {
        string str2 = str1;
        FileInfo fileInfo2 = fileInfo1;
        Process process2 = process1;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (ValueType) flag;
        object obj = _param1;
        OpenLinkEventArgs openLinkEventArgs = _param2;
        \u0005.\u0008.\u0001(ex, (object) str2, (object) fileInfo2, (object) process2, (object) local, (object) this, obj, (object) openLinkEventArgs);
        throw;
      }
    }

    private void \u0002(object _param1, OpenLinkEventArgs _param2)
    {
      \u0001.\u0001 obj1;
      try
      {
        do
        {
          if (true)
          {
            if (true)
            {
              \u0001.\u0001 obj2 = new \u0001.\u0001();
              if (true)
                obj1 = obj2;
            }
            else
              goto label_7;
          }
          obj1.\u0001(true);
          if (false)
            goto label_3;
label_7:
          if (true)
            goto label_8;
label_2:
          continue;
label_8:
          this.\u0005();
          goto label_2;
        }
        while (false);
        goto label_9;
label_3:
        return;
label_9:
        this.\u0004();
      }
      catch (Exception ex)
      {
        \u0001.\u0001 obj3 = obj1;
        object obj4 = _param1;
        OpenLinkEventArgs openLinkEventArgs = _param2;
        \u0005.\u0008.\u0001(ex, (object) obj3, (object) this, obj4, (object) openLinkEventArgs);
        throw;
      }
    }

    private void \u0003(object _param1, OpenLinkEventArgs _param2)
    {
      \u0001.\u0001 obj1;
      try
      {
        do
        {
          if (true)
          {
            if (true)
            {
              \u0001.\u0001 obj2 = new \u0001.\u0001();
              if (true)
                obj1 = obj2;
            }
            else
              goto label_7;
          }
          obj1.\u0001();
          if (false)
            goto label_3;
label_7:
          if (true)
            goto label_8;
label_2:
          continue;
label_8:
          this.\u0005();
          goto label_2;
        }
        while (false);
        goto label_9;
label_3:
        return;
label_9:
        this.\u0004();
      }
      catch (Exception ex)
      {
        \u0001.\u0001 obj3 = obj1;
        object obj4 = _param1;
        OpenLinkEventArgs openLinkEventArgs = _param2;
        \u0005.\u0008.\u0001(ex, (object) obj3, (object) this, obj4, (object) openLinkEventArgs);
        throw;
      }
    }

    private string \u0001(object _param1)
    {
      string str1;
      string str2;
      try
      {
        if (true)
        {
          if (true)
            str1 = SecurityElement.Escape(_param1.ToString());
          else
            goto label_6;
        }
        do
          ;
        while (false);
        str2 = str1;
      }
      catch (Exception ex)
      {
        string str3 = str1;
        object obj = _param1;
        \u0005.\u0008.\u0001(ex, (object) str3, (object) this, obj);
        throw;
      }
label_6:
      return str2;
    }

    private void \u0004()
    {
      string str1;
      bool flag;
      try
      {
        if (true)
        {
          str1 = \u0001.\u0006.\u0001(\u0005.\u0004.\u0001(6970));
          flag = !string.IsNullOrWhiteSpace(str1);
          if (false)
            return;
          if (!flag)
          {
            this.\u0007.Text = \u0005.\u0004.\u0001(11663);
            if (true)
              return;
            goto label_5;
          }
        }
        else
          goto label_4;
label_3:
        if (false)
          ;
label_4:
        this.\u0007.Text = \u0005.\u0004.\u0001(11704) + str1;
label_5:
        if (false)
          goto label_3;
      }
      catch (Exception ex)
      {
        string str2 = str1;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (ValueType) flag;
        \u0005.\u0008.\u0001(ex, (object) str2, (object) local, (object) this);
        throw;
      }
    }

    private void \u0005()
    {
      string str1;
      string str2;
      string str3;
      string str4;
      try
      {
        while (true)
        {
          str3 = \u0001.\u0006.\u0001(\u0005.\u0004.\u0001(6970));
          do
          {
            string str5 = \u0005.\u0004.\u0001(11725) + (object) '"' + \u0005.\u0004.\u0001(11931);
            if (true)
              goto label_8;
label_4:
            str1 = \u0005.\u0004.\u0001(11948) + (object) '"';
            str4 = str2 + str3 + str1;
            continue;
label_8:
            str2 = str5;
            goto label_4;
          }
          while (false);
          this.\u0001(str4);
          if (true)
            break;
        }
      }
      catch (Exception ex)
      {
        string str6 = str3;
        string str7 = str2;
        string str8 = str1;
        string str9 = str4;
        \u0005.\u0008.\u0001(ex, (object) str6, (object) str7, (object) str8, (object) str9, (object) this);
        throw;
      }
    }

    public void \u0001(string _param1)
    {
      IEnumerator enumerator1;
      XmlElement current;
      bool flag;
      IDisposable disposable1;
      XmlDocument xmlDocument1;
      try
      {
        xmlDocument1 = new XmlDocument();
        xmlDocument1.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        do
        {
          do
          {
            enumerator1 = xmlDocument1.DocumentElement.GetEnumerator();
label_3:
            try
            {
              while (true)
              {
                if (true)
                {
                  flag = enumerator1.MoveNext();
                  if (flag)
                  {
                    current = (XmlElement) enumerator1.Current;
                    flag = !(current.Name == \u0005.\u0004.\u0001(12005));
                    if (!flag)
                      current.FirstChild.Attributes[1].Value = _param1;
                  }
                  else
                    break;
                }
                else
                  goto label_3;
              }
            }
            finally
            {
              do
              {
                disposable1 = enumerator1 as IDisposable;
                if (true)
                {
                  int num1 = disposable1 == null ? 1 : 0;
                  int num2;
                  while (true)
                  {
                    flag = num1 != 0;
                    num2 = flag ? 1 : 0;
                    if (false)
                      num1 = num2;
                    else
                      break;
                  }
                  if (num2 != 0)
                    break;
                }
                disposable1.Dispose();
              }
              while (false);
            }
          }
          while (false);
          try
          {
            xmlDocument1.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            int num = (int) XtraMessageBox.Show(\u0005.\u0004.\u0001(12030), \u0005.\u0004.\u0001(7165), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
          catch (Exception ex)
          {
            do
            {
              int num = (int) XtraMessageBox.Show(\u0005.\u0004.\u0001(12071), \u0005.\u0004.\u0001(7165), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            while (false);
          }
        }
        while (false);
      }
      catch (Exception ex)
      {
        XmlDocument xmlDocument2 = xmlDocument1;
        XmlElement xmlElement = current;
        IEnumerator enumerator2 = enumerator1;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (ValueType) flag;
        IDisposable disposable2 = disposable1;
        string str = _param1;
        \u0005.\u0008.\u0001(ex, (object) xmlDocument2, (object) xmlElement, (object) enumerator2, (object) local, (object) disposable2, (object) this, (object) str);
        throw;
      }
    }
  }
}
