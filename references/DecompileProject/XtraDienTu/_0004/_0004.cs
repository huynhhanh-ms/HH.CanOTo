// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;
using Xtra.Data;

namespace \u0004
{
  internal class \u0004 : XtraForm
  {
    private IContainer \u0001;
    private SimpleButton \u0002;
    private SimpleButton \u0003;
    private TextEdit \u0004;
    private BindingSource \u0005;
    private LabelControl \u0006;
    private TextEdit \u0007;
    private LabelControl \u0008;
    private SimpleButton \u000E;
    private CanDienTuEntities \u000F;

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
        this.\u0001 = (IContainer) new System.ComponentModel.Container();
        componentResourceManager1 = new ComponentResourceManager(typeof (\u0004.\u0004));
        this.\u0004 = new TextEdit();
        this.\u0005 = new BindingSource(this.\u0001);
        this.\u0006 = new LabelControl();
        this.\u0007 = new TextEdit();
        this.\u0008 = new LabelControl();
        this.\u000E = new SimpleButton();
        this.\u0002 = new SimpleButton();
        this.\u0003 = new SimpleButton();
        this.\u0004.Properties.BeginInit();
        ((ISupportInitialize) this.\u0005).BeginInit();
        this.\u0007.Properties.BeginInit();
        this.SuspendLayout();
        this.\u0004.DataBindings.Add(new Binding(\u0005.\u0004.\u0001(3176), (object) this.\u0005, \u0005.\u0004.\u0001(2375), true));
        this.\u0004.Location = new Point(80, 12);
        this.\u0004.Name = \u0005.\u0004.\u0001(6691);
        this.\u0004.Properties.PasswordChar = '*';
        this.\u0004.Size = new Size(162, 20);
        this.\u0004.TabIndex = 4;
        this.\u0005.DataSource = (object) typeof (PassWord);
        this.\u0006.Location = new Point(5, 15);
        this.\u0006.Name = \u0005.\u0004.\u0001(6708);
        this.\u0006.Size = new Size(69, 13);
        this.\u0006.TabIndex = 7;
        this.\u0006.Text = \u0005.\u0004.\u0001(6725);
        this.\u0007.Location = new Point(80, 12);
        this.\u0007.Name = \u0005.\u0004.\u0001(6746);
        this.\u0007.Properties.PasswordChar = '*';
        this.\u0007.Size = new Size(162, 20);
        this.\u0007.TabIndex = 4;
        this.\u0007.Visible = false;
        this.\u0008.Location = new Point(2, 15);
        this.\u0008.Name = \u0005.\u0004.\u0001(6763);
        this.\u0008.Size = new Size(74, 13);
        this.\u0008.TabIndex = 7;
        this.\u0008.Text = \u0005.\u0004.\u0001(6780);
        this.\u0008.Visible = false;
        this.\u000E.Image = (Image) \u0008.\u0004.chec;
        this.\u000E.Location = new Point(5, 38);
        this.\u000E.Name = \u0005.\u0004.\u0001(4538);
        this.\u000E.Size = new Size(79, 41);
        this.\u000E.TabIndex = 6;
        this.\u000E.Text = \u0005.\u0004.\u0001(4547);
        this.\u0002.Image = (Image) \u0008.\u0004.exit;
        this.\u0002.Location = new Point(175, 38);
        this.\u0002.Name = \u0005.\u0004.\u0001(4516);
        this.\u0002.Size = new Size(79, 41);
        this.\u0002.TabIndex = 6;
        this.\u0002.Text = \u0005.\u0004.\u0001(6570);
        this.\u0003.Image = (Image) \u0008.\u0004.save;
        this.\u0003.Location = new Point(90, 38);
        this.\u0003.Name = \u0005.\u0004.\u0001(216);
        this.\u0003.Size = new Size(79, 41);
        this.\u0003.TabIndex = 5;
        this.\u0003.Text = \u0005.\u0004.\u0001(225);
        this.\u0003.Visible = false;
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(264, 97);
        this.Controls.Add((Control) this.\u0008);
        this.Controls.Add((Control) this.\u0006);
        this.Controls.Add((Control) this.\u000E);
        this.Controls.Add((Control) this.\u0002);
        this.Controls.Add((Control) this.\u0003);
        this.Controls.Add((Control) this.\u0007);
        this.Controls.Add((Control) this.\u0004);
        this.Icon = (Icon) componentResourceManager1.GetObject(\u0005.\u0004.\u0001(525));
        this.Name = \u0005.\u0004.\u0001(6801);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = \u0005.\u0004.\u0001(6818);
        this.\u0004.Properties.EndInit();
        ((ISupportInitialize) this.\u0005).EndInit();
        this.\u0007.Properties.EndInit();
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

    public \u0004()
    {
      EventHandler eventHandler1 = (EventHandler) null;
      KeyEventHandler keyEventHandler1 = (KeyEventHandler) null;
      KeyEventHandler keyEventHandler2 = (KeyEventHandler) null;
      EventHandler eventHandler2 = (EventHandler) null;
      EventHandler eventHandler3 = (EventHandler) null;
      this.\u0001 = (IContainer) null;
      this.\u000F = new CanDienTuEntities();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      try
      {
        this.\u0001();
        SimpleButton simpleButton1 = this.\u000E;
        if (eventHandler1 == null)
          eventHandler1 = (EventHandler) ((_param1, _param2) =>
          {
            ParameterExpression parameterExpression1;
            // ISSUE: variable of a compiler-generated type
            \u0004.\u0004.\u0001 obj1;
            ParameterExpression[] parameterExpressionArray1;
            bool flag;
            try
            {
              // ISSUE: object of a compiler-generated type is created
              obj1 = new \u0004.\u0004.\u0001();
              // ISSUE: reference to a compiler-generated field
              obj1.\u0001 = this.\u0004.Text;
              do
              {
                ObjectSet<PassWord> passWord = this.\u000F.PassWord;
                parameterExpression1 = Expression.Parameter(typeof (PassWord), \u0005.\u0004.\u0001(4088));
                // ISSUE: method reference
                // ISSUE: field reference
                // ISSUE: method reference
                BinaryExpression body = Expression.Equal((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (PassWord.get_Ten))), (Expression) Expression.Field((Expression) Expression.Constant((object) obj1), FieldInfo.GetFieldFromHandle(__fieldref (\u0004.\u0004.\u0001.\u0001))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.op_Equality)));
                parameterExpressionArray1 = new ParameterExpression[1]
                {
                  parameterExpression1
                };
                ParameterExpression[] parameterExpressionArray2 = parameterExpressionArray1;
                Expression<Func<PassWord, bool>> predicate = Expression.Lambda<Func<PassWord, bool>>((Expression) body, parameterExpressionArray2);
                flag = !passWord.Where<PassWord>(predicate).Any<PassWord>();
                if (!flag)
                {
                  if (true)
                  {
                    if (true)
                    {
                      this.\u0008.Visible = true;
                      do
                      {
                        this.\u0007.Visible = true;
                      }
                      while (false);
                      this.\u0003.Visible = true;
                    }
                    if (true)
                      this.\u0006.Visible = false;
                    else
                      goto label_10;
                  }
                  else
                    goto label_9;
                }
                else
                  goto label_10;
              }
              while (false);
              goto label_8;
label_9:
              return;
label_8:
              this.\u0004.Visible = false;
              this.\u000E.Visible = false;
              return;
label_10:
              int num = (int) XtraMessageBox.Show(\u0005.\u0004.\u0001(6839), \u0005.\u0004.\u0001(643), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
              // ISSUE: variable of a compiler-generated type
              \u0004.\u0004.\u0001 obj2 = obj1;
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
        EventHandler eventHandler4 = eventHandler1;
        simpleButton1.Click += eventHandler4;
        TextEdit textEdit1 = this.\u0007;
        if (keyEventHandler1 == null)
          keyEventHandler1 = (KeyEventHandler) ((_param1, _param2) =>
          {
            bool flag;
            try
            {
              flag = _param2.KeyCode != Keys.Return;
              if (flag)
                return;
              this.\u0003.PerformClick();
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
        KeyEventHandler keyEventHandler3 = keyEventHandler1;
        textEdit1.KeyDown += keyEventHandler3;
        TextEdit textEdit2 = this.\u0004;
        if (keyEventHandler2 == null)
          keyEventHandler2 = (KeyEventHandler) ((_param1, _param2) =>
          {
            bool flag;
            try
            {
              flag = _param2.KeyCode != Keys.Return;
              if (flag)
                return;
              this.\u000E.PerformClick();
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
        KeyEventHandler keyEventHandler4 = keyEventHandler2;
        textEdit2.KeyDown += keyEventHandler4;
        SimpleButton simpleButton2 = this.\u0002;
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
        EventHandler eventHandler5 = eventHandler2;
        simpleButton2.Click += eventHandler5;
        SimpleButton simpleButton3 = this.\u0003;
        if (eventHandler3 == null)
          eventHandler3 = (EventHandler) ((_param1, _param2) =>
          {
            ParameterExpression parameterExpression3;
            // ISSUE: variable of a compiler-generated type
            \u0004.\u0004.\u0002 obj4;
            ParameterExpression[] parameterExpressionArray4;
            PassWord passWord1;
            string str1;
            try
            {
              // ISSUE: object of a compiler-generated type is created
              obj4 = new \u0004.\u0004.\u0002();
              // ISSUE: reference to a compiler-generated field
              obj4.\u0001 = this.\u0004.Text;
              string text = this.\u0007.Text;
              if (true)
                str1 = text;
              ObjectSet<PassWord> passWord2 = this.\u000F.PassWord;
              parameterExpression3 = Expression.Parameter(typeof (PassWord), \u0005.\u0004.\u0001(4088));
              // ISSUE: method reference
              // ISSUE: field reference
              // ISSUE: method reference
              BinaryExpression body1 = Expression.Equal((Expression) Expression.Property((Expression) parameterExpression3, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (PassWord.get_Ten))), (Expression) Expression.Field((Expression) Expression.Constant((object) obj4), FieldInfo.GetFieldFromHandle(__fieldref (\u0004.\u0004.\u0002.\u0001))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.op_Equality)));
              parameterExpressionArray4 = new ParameterExpression[1]
              {
                parameterExpression3
              };
              ParameterExpression[] parameterExpressionArray5 = parameterExpressionArray4;
              Expression<Func<PassWord, bool>> predicate = Expression.Lambda<Func<PassWord, bool>>((Expression) body1, parameterExpressionArray5);
              IQueryable<PassWord> source = passWord2.Where<PassWord>(predicate);
              parameterExpression3 = Expression.Parameter(typeof (PassWord), \u0005.\u0004.\u0001(4088));
              // ISSUE: method reference
              MemberExpression body2 = Expression.Property((Expression) parameterExpression3, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (PassWord.get_Id)));
              parameterExpressionArray4 = new ParameterExpression[1]
              {
                parameterExpression3
              };
              ParameterExpression[] parameterExpressionArray6 = parameterExpressionArray4;
              Expression<Func<PassWord, Guid>> keySelector = Expression.Lambda<Func<PassWord, Guid>>((Expression) body2, parameterExpressionArray6);
              passWord1 = source.OrderBy<PassWord, Guid>(keySelector).First<PassWord>();
              if (true)
                passWord1.Ten = str1.ToString();
              try
              {
                if (false)
                  ;
                this.\u000F.SaveChanges();
                int num = (int) XtraMessageBox.Show(\u0005.\u0004.\u0001(6876), \u0005.\u0004.\u0001(609), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (false)
                  return;
                this.Close();
              }
              catch (Exception ex)
              {
                int num = (int) XtraMessageBox.Show(\u0005.\u0004.\u0001(6921) + ex.Message, \u0005.\u0004.\u0001(643), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              }
            }
            catch (Exception ex)
            {
              string str2 = str1;
              PassWord passWord3 = passWord1;
              Exception exception = ex;
              // ISSUE: variable of a compiler-generated type
              \u0004.\u0004.\u0002 obj5 = obj4;
              ParameterExpression parameterExpression4 = parameterExpression3;
              ParameterExpression[] parameterExpressionArray7 = parameterExpressionArray4;
              object obj6 = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) str2, (object) passWord3, (object) exception, (object) obj5, (object) parameterExpression4, (object) parameterExpressionArray7, (object) this, obj6, (object) eventArgs);
              throw;
            }
          });
        EventHandler eventHandler6 = eventHandler3;
        simpleButton3.Click += eventHandler6;
      }
      catch (Exception ex)
      {
        EventHandler eventHandler7 = eventHandler1;
        KeyEventHandler keyEventHandler5 = keyEventHandler1;
        KeyEventHandler keyEventHandler6 = keyEventHandler2;
        EventHandler eventHandler8 = eventHandler2;
        EventHandler eventHandler9 = eventHandler3;
        \u0005.\u0008.\u0001(ex, (object) eventHandler7, (object) keyEventHandler5, (object) keyEventHandler6, (object) eventHandler8, (object) eventHandler9, (object) this);
        throw;
      }
    }
  }
}
