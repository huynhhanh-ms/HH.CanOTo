// Decompiled with JetBrains decompiler
// Type: .
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

namespace \u0003
{
  internal class \u0002 : XtraForm
  {
    private PassWord \u0001;
    private IContainer \u0002;
    private TextEdit \u0003;
    private SimpleButton \u0004;
    private SimpleButton \u0005;
    private BindingSource \u0006;

    public CanDienTuEntities db
    {
      get
      {
label_0:
        CanDienTuEntities canDienTuEntities1;
        CanDienTuEntities canDienTuEntities2;
        try
        {
          if (false)
            goto label_2;
          else
            goto label_3;
label_1:
          if (true)
            canDienTuEntities2 = canDienTuEntities1;
          else
            goto label_0;
label_2:
          if (false)
            goto label_1;
          else
            goto label_7;
label_3:
          CanDienTuEntities canDienTuEntities3 = this.\u0007;
          if (true)
          {
            canDienTuEntities1 = canDienTuEntities3;
            goto label_1;
          }
          else
            goto label_1;
        }
        catch (Exception ex)
        {
          CanDienTuEntities canDienTuEntities4 = canDienTuEntities1;
          \u0005.\u0008.\u0001(ex, (object) canDienTuEntities4, (object) this);
          throw;
        }
label_7:
        return canDienTuEntities2;
      }
      set
      {
        try
        {
          this.\u0007 = value;
        }
        catch (Exception ex)
        {
          CanDienTuEntities canDienTuEntities = value;
          \u0005.\u0008.\u0001(ex, (object) this, (object) canDienTuEntities);
          throw;
        }
      }
    }

    public \u0002()
    {
      EventHandler eventHandler1 = (EventHandler) null;
      EventHandler eventHandler2 = (EventHandler) null;
      EventHandler eventHandler3 = (EventHandler) null;
      EventHandler eventHandler4 = (EventHandler) null;
      FormClosingEventHandler closingEventHandler1 = (FormClosingEventHandler) null;
      this.\u0002 = (IContainer) null;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      try
      {
        this.\u0001();
        if (eventHandler1 == null)
          eventHandler1 = (EventHandler) ((_param1, _param2) =>
          {
            ParameterExpression[] parameterExpressionArray1;
            ParameterExpression parameterExpression1;
            try
            {
              BindingSource bindingSource = this.\u0006;
              ObjectSet<PassWord> passWord = this.db.PassWord;
              parameterExpression1 = Expression.Parameter(typeof (PassWord), \u0005.\u0004.\u0001(4088));
              // ISSUE: method reference
              // ISSUE: method reference
              // ISSUE: method reference
              BinaryExpression body = Expression.Equal((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (PassWord.get_Id))), (Expression) Expression.Call((Expression) null, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Guid.NewGuid)), new Expression[0]), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Guid.op_Equality)));
              parameterExpressionArray1 = new ParameterExpression[1]
              {
                parameterExpression1
              };
              ParameterExpression[] parameterExpressionArray2 = parameterExpressionArray1;
              Expression<Func<PassWord, bool>> predicate = Expression.Lambda<Func<PassWord, bool>>((Expression) body, parameterExpressionArray2);
              IQueryable<PassWord> queryable = passWord.Where<PassWord>(predicate);
              bindingSource.DataSource = (object) queryable;
            }
            catch (Exception ex)
            {
              ParameterExpression parameterExpression2 = parameterExpression1;
              ParameterExpression[] parameterExpressionArray3 = parameterExpressionArray1;
              object obj = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) parameterExpression2, (object) parameterExpressionArray3, (object) this, obj, (object) eventArgs);
              throw;
            }
          });
        this.Load += eventHandler1;
        if (eventHandler2 == null)
          eventHandler2 = (EventHandler) ((_param1, _param2) =>
          {
label_0:
            bool flag;
            try
            {
              if (true)
                flag = this.\u0001 == null;
              else
                goto label_7;
label_6:
              if (flag)
              {
                this.\u0006.AddNew();
                if (true)
                  return;
                goto label_0;
              }
label_7:
              this.\u0006.DataSource = (object) this.\u0001;
              if (true)
              {
                if (false)
                  ;
                if (false)
                  goto label_6;
              }
              else
                goto label_6;
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
        this.Shown += eventHandler2;
        this.\u0006.AddingNew += (AddingNewEventHandler) ((_param0, _param1) =>
        {
          PassWord passWord1;
          try
          {
            if (false)
              return;
            AddingNewEventArgs addingNewEventArgs = _param1;
            passWord1 = new PassWord();
            passWord1.Id = Guid.NewGuid();
            PassWord passWord2 = passWord1;
            addingNewEventArgs.NewObject = (object) passWord2;
          }
          catch (Exception ex)
          {
            PassWord passWord3 = passWord1;
            object obj = _param0;
            AddingNewEventArgs addingNewEventArgs = _param1;
            \u0005.\u0008.\u0001(ex, (object) passWord3, obj, (object) addingNewEventArgs);
            throw;
          }
        });
        SimpleButton simpleButton1 = this.\u0004;
        if (eventHandler3 == null)
          eventHandler3 = (EventHandler) ((_param1, _param2) =>
          {
            try
            {
              this.\u0006.EndEdit();
              do
              {
                this.db.SaveChanges();
                this.Close();
              }
              while (false);
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
        simpleButton1.Click += eventHandler5;
        SimpleButton simpleButton2 = this.\u0005;
        if (eventHandler4 == null)
          eventHandler4 = (EventHandler) ((_param1, _param2) =>
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
        EventHandler eventHandler6 = eventHandler4;
        simpleButton2.Click += eventHandler6;
        if (closingEventHandler1 == null)
          closingEventHandler1 = (FormClosingEventHandler) ((_param1, _param2) =>
          {
            bool flag;
            try
            {
              int num = \u0004.\u0005.\u0001(this.db) ? 1 : 0;
              if (true)
                goto label_3;
label_1:
              if (num != 0)
                return;
              _param2.Cancel = true;
              return;
label_3:
              flag = num != 0;
              num = flag ? 1 : 0;
              goto label_1;
            }
            catch (Exception ex)
            {
              // ISSUE: variable of a boxed type
              __Boxed<bool> local = (ValueType) flag;
              object obj = _param1;
              FormClosingEventArgs closingEventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) local, (object) this, obj, (object) closingEventArgs);
              throw;
            }
          });
        this.FormClosing += closingEventHandler1;
      }
      catch (Exception ex)
      {
        EventHandler eventHandler7 = eventHandler1;
        EventHandler eventHandler8 = eventHandler2;
        EventHandler eventHandler9 = eventHandler3;
        EventHandler eventHandler10 = eventHandler4;
        FormClosingEventHandler closingEventHandler2 = closingEventHandler1;
        \u0005.\u0008.\u0001(ex, (object) eventHandler7, (object) eventHandler8, (object) eventHandler9, (object) eventHandler10, (object) closingEventHandler2, (object) this);
        throw;
      }
    }

    public \u0002(PassWord pw)
      : this()
    {
      try
      {
        this.\u0001 = pw;
      }
      catch (Exception ex)
      {
        PassWord passWord = pw;
        \u0005.\u0008.\u0001(ex, (object) this, (object) passWord);
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
              this.\u0002.Dispose();
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
          int num3 = this.\u0002 == null ? 1 : 0;
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
        this.\u0002 = (IContainer) new System.ComponentModel.Container();
        this.\u0003 = new TextEdit();
        this.\u0006 = new BindingSource(this.\u0002);
        this.\u0005 = new SimpleButton();
        this.\u0004 = new SimpleButton();
        this.\u0003.Properties.BeginInit();
        ((ISupportInitialize) this.\u0006).BeginInit();
        if (true)
        {
          this.SuspendLayout();
          this.\u0003.DataBindings.Add(new Binding(\u0005.\u0004.\u0001(3176), (object) this.\u0006, \u0005.\u0004.\u0001(2375), true));
          if (true)
          {
            this.\u0003.Location = new Point(15, 5);
            this.\u0003.Name = \u0005.\u0004.\u0001(6557);
            this.\u0003.Size = new Size(157, 20);
            this.\u0003.TabIndex = 1;
            this.\u0006.DataSource = (object) typeof (PassWord);
            this.\u0005.Image = (Image) \u0008.\u0004.exit;
            this.\u0005.Location = new Point(96, 31);
            this.\u0005.Name = \u0005.\u0004.\u0001(194);
            this.\u0005.Size = new Size(78, 42);
            this.\u0005.TabIndex = 3;
            this.\u0005.Text = \u0005.\u0004.\u0001(207);
            this.\u0004.Image = (Image) \u0008.\u0004.save;
          }
          else
            goto label_5;
        }
        else
          goto label_6;
label_3:
        this.\u0004.Location = new Point(12, 31);
        this.\u0004.Name = \u0005.\u0004.\u0001(216);
        this.\u0004.Size = new Size(78, 42);
        this.\u0004.TabIndex = 2;
        this.\u0004.Text = \u0005.\u0004.\u0001(225);
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        if (true)
        {
          this.AutoScaleMode = AutoScaleMode.Font;
          this.ClientSize = new Size(185, 83);
          this.ControlBox = false;
        }
        else
          goto label_8;
label_5:
        this.Controls.Add((Control) this.\u0005);
        this.Controls.Add((Control) this.\u0004);
        this.Controls.Add((Control) this.\u0003);
        this.Name = \u0005.\u0004.\u0001(10867);
label_6:
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = \u0005.\u0004.\u0001(10880);
        if (true)
          this.\u0003.Properties.EndInit();
        else
          goto label_3;
label_8:
        ((ISupportInitialize) this.\u0006).EndInit();
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
