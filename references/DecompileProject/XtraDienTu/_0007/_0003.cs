// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.ComponentModel;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xtra.Data;

namespace \u0007
{
  internal class \u0003 : XtraForm
  {
    private CanDienTuEntities \u0001;
    private IContainer \u0002;
    private PanelControl \u0003;
    private SimpleButton \u0004;
    private SimpleButton \u0005;
    private SimpleButton \u0006;
    private SimpleButton \u0007;
    private GridControl \u0008;
    private GridView \u000E;
    private BindingSource \u000F;
    private GridColumn \u0010;
    private GridColumn \u0011;
    private GridColumn \u0012;
    private GridColumn \u0013;

    public unsafe \u0003()
    {
      EventHandler eventHandler1 = (EventHandler) null;
      EventHandler eventHandler2 = (EventHandler) null;
      AddingNewEventHandler addingNewEventHandler1 = (AddingNewEventHandler) null;
      EventHandler eventHandler3 = (EventHandler) null;
      EventHandler eventHandler4 = (EventHandler) null;
      FormClosingEventHandler closingEventHandler1 = (FormClosingEventHandler) null;
      EventHandler eventHandler5 = (EventHandler) null;
      this.\u0001 = new CanDienTuEntities();
      this.\u0002 = (IContainer) null;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      try
      {
        this.\u0002();
        if (eventHandler1 == null)
          eventHandler1 = (EventHandler) ((_param1, _param2) =>
          {
            try
            {
              this.\u0001();
            }
            catch (Exception ex)
            {
              object obj = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) this, obj, (object) eventArgs);
              throw;
            }
          });
        this.Shown += eventHandler1;
        SimpleButton simpleButton1 = this.\u0007;
        if (eventHandler2 == null)
          eventHandler2 = (EventHandler) ((_param1, _param2) =>
          {
            try
            {
              if (false)
                return;
              this.\u000F.AddNew();
            }
            catch (Exception ex)
            {
              object obj = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) this, obj, (object) eventArgs);
              throw;
            }
          });
        EventHandler eventHandler6 = eventHandler2;
        simpleButton1.Click += eventHandler6;
        BindingSource bindingSource = this.\u000F;
        if (addingNewEventHandler1 == null)
          addingNewEventHandler1 = (AddingNewEventHandler) ((_param1, _param2) =>
          {
            if (false)
              return;
            // ISSUE: untyped stack allocation
            void* voidPtr = (void*) __untypedstackalloc(5);
            ParameterExpression parameterExpression1;
            ParameterExpression[] parameterExpressionArray1;
            HangHoa hangHoa1;
            HangHoa hangHoa2;
            try
            {
              do
              {
                this.\u0001.SaveChanges();
                do
                {
                  *(int*) voidPtr = 0;
                  if (true)
                  {
                    *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (this.\u0001.HangHoa.ToList<HangHoa>().Count <= 0);
                    if (*(sbyte*) ((IntPtr) voidPtr + 4) == (sbyte) 0)
                    {
                      ObjectSet<HangHoa> hangHoa3 = this.\u0001.HangHoa;
                      parameterExpression1 = Expression.Parameter(typeof (HangHoa), \u0005.\u0004.\u0001(4088));
                      // ISSUE: method reference
                      MemberExpression body = Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (HangHoa.get_SapXep)));
                      parameterExpressionArray1 = new ParameterExpression[1]
                      {
                        parameterExpression1
                      };
                      ParameterExpression[] parameterExpressionArray2 = parameterExpressionArray1;
                      Expression<Func<HangHoa, int>> keySelector = Expression.Lambda<Func<HangHoa, int>>((Expression) body, parameterExpressionArray2);
                      hangHoa1 = hangHoa3.OrderByDescending<HangHoa, int>(keySelector).ToList<HangHoa>().FirstOrDefault<HangHoa>();
                      *(int*) voidPtr = hangHoa1.SapXep + 1;
                    }
                    else
                      goto label_5;
                  }
                  else
                    goto label_4;
                }
                while (false);
                goto label_6;
label_5:
                *(int*) voidPtr = 1;
label_6:
                AddingNewEventArgs addingNewEventArgs = _param2;
                hangHoa2 = new HangHoa();
                hangHoa2.Id = Guid.NewGuid();
                hangHoa2.SapXep = *(int*) voidPtr;
                HangHoa hangHoa4 = hangHoa2;
                addingNewEventArgs.NewObject = (object) hangHoa4;
              }
              while (false);
              goto label_7;
label_4:
              return;
label_7:;
            }
            catch (Exception ex)
            {
              // ISSUE: variable of a boxed type
              __Boxed<int> local1 = (ValueType) *(int*) voidPtr;
              HangHoa hangHoa5 = hangHoa1;
              HangHoa hangHoa6 = hangHoa2;
              // ISSUE: variable of a boxed type
              __Boxed<bool> local2 = (ValueType) (bool) *(sbyte*) ((IntPtr) voidPtr + 4);
              ParameterExpression parameterExpression2 = parameterExpression1;
              ParameterExpression[] parameterExpressionArray3 = parameterExpressionArray1;
              object obj = _param1;
              AddingNewEventArgs addingNewEventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) local1, (object) hangHoa5, (object) hangHoa6, (object) local2, (object) parameterExpression2, (object) parameterExpressionArray3, (object) this, obj, (object) addingNewEventArgs);
              throw;
            }
          });
        AddingNewEventHandler addingNewEventHandler2 = addingNewEventHandler1;
        bindingSource.AddingNew += addingNewEventHandler2;
        SimpleButton simpleButton2 = this.\u0006;
        if (eventHandler3 == null)
          eventHandler3 = (EventHandler) ((_param1, _param2) =>
          {
            try
            {
              if (false)
                return;
              this.\u0001.SaveChanges();
            }
            catch (Exception ex)
            {
              object obj = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) this, obj, (object) eventArgs);
              throw;
            }
          });
        EventHandler eventHandler7 = eventHandler3;
        simpleButton2.Click += eventHandler7;
        SimpleButton simpleButton3 = this.\u0005;
        if (eventHandler4 == null)
          eventHandler4 = (EventHandler) ((_param1, _param2) =>
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
        EventHandler eventHandler8 = eventHandler4;
        simpleButton3.Click += eventHandler8;
        if (closingEventHandler1 == null)
          closingEventHandler1 = (FormClosingEventHandler) ((_param1, _param2) =>
          {
            bool flag;
            try
            {
              int num = \u0004.\u0005.\u0001(this.\u0001) ? 1 : 0;
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
        SimpleButton simpleButton4 = this.\u0004;
        if (eventHandler5 == null)
          eventHandler5 = (EventHandler) ((_param1, _param2) =>
          {
label_0:
            bool flag;
            HangHoa current;
            try
            {
label_14:
              int num1 = this.\u000F.Current == null ? 1 : 0;
              while (true)
              {
                flag = num1 != 0;
                int count;
                do
                {
                  if (!flag)
                  {
                    if (true)
                    {
                      current = (HangHoa) this.\u000F.Current;
                      count = current.XeHang.Count;
                      if (true)
                      {
                        flag = count <= 0;
                        if (!flag)
                        {
                          int num2 = (int) XtraMessageBox.Show(\u0005.\u0004.\u0001(14211), \u0005.\u0004.\u0001(14292), MessageBoxButtons.OK, MessageBoxIcon.Hand);
                          goto label_12;
                        }
                        else
                        {
                          int num3 = XtraMessageBox.Show(\u0005.\u0004.\u0001(14309), \u0005.\u0004.\u0001(4171), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes ? 1 : 0;
                          if (true)
                          {
                            flag = num3 == 0;
                            if (!flag)
                            {
                              if (true)
                              {
                                this.\u0001.HangHoa.DeleteObject(current);
                                num3 = this.\u0001.SaveChanges();
                              }
                              else
                                goto label_0;
                            }
                            else
                              goto label_10;
                          }
label_10:
                          if (false)
                            continue;
                        }
                      }
                      else
                        goto label_2;
                    }
                    else
                      goto label_14;
                  }
                  this.\u0001();
label_12:;
                }
                while (false);
                break;
label_2:
                num1 = count;
              }
            }
            catch (Exception ex)
            {
              HangHoa hangHoa = current;
              // ISSUE: variable of a boxed type
              __Boxed<bool> local = (ValueType) flag;
              object obj = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) hangHoa, (object) local, (object) this, obj, (object) eventArgs);
              throw;
            }
          });
        EventHandler eventHandler9 = eventHandler5;
        simpleButton4.Click += eventHandler9;
      }
      catch (Exception ex)
      {
        EventHandler eventHandler10 = eventHandler1;
        EventHandler eventHandler11 = eventHandler2;
        AddingNewEventHandler addingNewEventHandler3 = addingNewEventHandler1;
        EventHandler eventHandler12 = eventHandler3;
        EventHandler eventHandler13 = eventHandler4;
        FormClosingEventHandler closingEventHandler2 = closingEventHandler1;
        EventHandler eventHandler14 = eventHandler5;
        \u0005.\u0008.\u0001(ex, (object) eventHandler10, (object) eventHandler11, (object) addingNewEventHandler3, (object) eventHandler12, (object) eventHandler13, (object) closingEventHandler2, (object) eventHandler14, (object) this);
        throw;
      }
    }

    public void \u0001(object _param1)
    {
      object[] objArray1;
      bool flag;
      try
      {
        if (false)
          return;
        flag = !this.InvokeRequired;
        if (flag)
        {
          this.\u000F.DataSource = _param1;
        }
        else
        {
          // ISSUE: method pointer
          Action<object> method = new Action<object>((object) this, __methodptr(\u0001));
          objArray1 = new object[1]{ _param1 };
          object[] objArray2 = objArray1;
          this.Invoke((Delegate) method, objArray2);
        }
      }
      catch (Exception ex)
      {
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (ValueType) flag;
        object[] objArray3 = objArray1;
        object obj = _param1;
        \u0005.\u0008.\u0001(ex, (object) local, (object) objArray3, (object) this, obj);
        throw;
      }
    }

    private void \u0001()
    {
      try
      {
        do
          ;
        while (false);
        // ISSUE: method pointer
        new Task(new Action((object) this, __methodptr(\u0003))).Start();
      }
      catch (Exception ex)
      {
        \u0005.\u0008.\u0001(ex, (object) this);
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

    private void \u0002()
    {
      BaseView[] baseViewArray1;
      GridColumn[] gridColumnArray1;
      ComponentResourceManager componentResourceManager1;
      try
      {
        this.\u0002 = (IContainer) new System.ComponentModel.Container();
        componentResourceManager1 = new ComponentResourceManager(typeof (\u0007.\u0003));
        this.\u0003 = new PanelControl();
        this.\u0004 = new SimpleButton();
        do
        {
          this.\u0005 = new SimpleButton();
          this.\u0006 = new SimpleButton();
          this.\u0007 = new SimpleButton();
          this.\u0008 = new GridControl();
          this.\u000F = new BindingSource(this.\u0002);
          this.\u000E = new GridView();
          this.\u0010 = new GridColumn();
          this.\u0011 = new GridColumn();
          this.\u0012 = new GridColumn();
          do
          {
            this.\u0013 = new GridColumn();
            this.\u0003.BeginInit();
            this.\u0003.SuspendLayout();
            this.\u0008.BeginInit();
            ((ISupportInitialize) this.\u000F).BeginInit();
            this.\u000E.BeginInit();
            this.SuspendLayout();
            this.\u0003.Controls.Add((Control) this.\u0004);
            this.\u0003.Controls.Add((Control) this.\u0005);
            this.\u0003.Controls.Add((Control) this.\u0006);
            this.\u0003.Controls.Add((Control) this.\u0007);
            this.\u0003.Dock = DockStyle.Top;
            this.\u0003.Location = new Point(0, 0);
            this.\u0003.Name = \u0005.\u0004.\u0001(173);
            this.\u0003.Size = new Size(501, 47);
            this.\u0003.TabIndex = 6;
            this.\u0004.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.\u0004.Image = (Image) \u0008.\u0004.delete;
            this.\u0004.Location = new Point(247, 5);
            this.\u0004.Name = \u0005.\u0004.\u0001(1218);
            this.\u0004.Size = new Size(79, 36);
            this.\u0004.TabIndex = 0;
            this.\u0004.Text = \u0005.\u0004.\u0001(1227);
            this.\u0005.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.\u0005.Image = (Image) \u0008.\u0004.exit;
            this.\u0005.Location = new Point(417, 5);
            this.\u0005.Name = \u0005.\u0004.\u0001(194);
            this.\u0005.Size = new Size(79, 36);
            this.\u0005.TabIndex = 0;
            this.\u0005.Text = \u0005.\u0004.\u0001(207);
            this.\u0006.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.\u0006.Image = (Image) \u0008.\u0004.save;
            this.\u0006.Location = new Point(332, 5);
            this.\u0006.Name = \u0005.\u0004.\u0001(216);
            this.\u0006.Size = new Size(79, 36);
            this.\u0006.TabIndex = 0;
            this.\u0006.Text = \u0005.\u0004.\u0001(225);
            this.\u0007.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.\u0007.Image = (Image) \u0008.\u0004._new;
            this.\u0007.Location = new Point(162, 5);
            this.\u0007.Name = \u0005.\u0004.\u0001(1313);
            this.\u0007.Size = new Size(79, 36);
            this.\u0007.TabIndex = 0;
            this.\u0007.Text = \u0005.\u0004.\u0001(1326);
            this.\u0008.DataSource = (object) this.\u000F;
            this.\u0008.Dock = DockStyle.Fill;
            this.\u0008.Location = new Point(0, 47);
            this.\u0008.LookAndFeel.SkinName = \u0005.\u0004.\u0001(3057);
            this.\u0008.LookAndFeel.UseDefaultLookAndFeel = false;
            this.\u0008.MainView = (BaseView) this.\u000E;
            this.\u0008.Name = \u0005.\u0004.\u0001(1474);
            this.\u0008.Size = new Size(501, 184);
            this.\u0008.TabIndex = 7;
            ViewRepositoryCollection viewCollection = this.\u0008.ViewCollection;
            baseViewArray1 = new BaseView[1]
            {
              (BaseView) this.\u000E
            };
            BaseView[] views = baseViewArray1;
            viewCollection.AddRange(views);
            this.\u000F.DataSource = (object) typeof (HangHoa);
            GridColumnCollection columns1 = this.\u000E.Columns;
            gridColumnArray1 = new GridColumn[4]
            {
              this.\u0010,
              this.\u0011,
              this.\u0012,
              this.\u0013
            };
            GridColumn[] columns2 = gridColumnArray1;
            columns1.AddRange(columns2);
            this.\u000E.GridControl = this.\u0008;
            this.\u000E.Name = \u0005.\u0004.\u0001(1491);
            this.\u000E.OptionsCustomization.AllowFilter = false;
            this.\u000E.OptionsCustomization.AllowSort = false;
            this.\u000E.OptionsView.ColumnAutoWidth = false;
            this.\u000E.OptionsView.EnableAppearanceEvenRow = true;
            this.\u000E.OptionsView.EnableAppearanceOddRow = true;
            this.\u000E.OptionsView.ShowGroupPanel = false;
            this.\u0010.Caption = \u0005.\u0004.\u0001(2324);
            this.\u0010.FieldName = \u0005.\u0004.\u0001(2192);
            this.\u0010.Name = \u0005.\u0004.\u0001(2799);
            this.\u0010.Visible = true;
            this.\u0010.VisibleIndex = 0;
            this.\u0010.Width = 78;
            this.\u0011.Caption = \u0005.\u0004.\u0001(1504);
            this.\u0011.FieldName = \u0005.\u0004.\u0001(2375);
            this.\u0011.Name = \u0005.\u0004.\u0001(2821);
            this.\u0011.Visible = true;
          }
          while (false);
          this.\u0011.VisibleIndex = 1;
          this.\u0011.Width = 198;
          this.\u0012.Caption = \u0005.\u0004.\u0001(14083);
          this.\u0012.FieldName = \u0005.\u0004.\u0001(14108);
          this.\u0012.Name = \u0005.\u0004.\u0001(14117);
          this.\u0012.Visible = true;
          this.\u0012.VisibleIndex = 2;
          this.\u0012.Width = 113;
          this.\u0013.Caption = \u0005.\u0004.\u0001(14130);
          this.\u0013.FieldName = \u0005.\u0004.\u0001(14147);
          this.\u0013.Name = \u0005.\u0004.\u0001(14156);
          this.\u0013.Visible = true;
          this.\u0013.VisibleIndex = 3;
          this.AutoScaleDimensions = new SizeF(6f, 13f);
          this.AutoScaleMode = AutoScaleMode.Font;
          this.ClientSize = new Size(501, 231);
          this.Controls.Add((Control) this.\u0008);
          this.Controls.Add((Control) this.\u0003);
          this.Icon = (Icon) componentResourceManager1.GetObject(\u0005.\u0004.\u0001(525));
          this.Name = \u0005.\u0004.\u0001(14169);
        }
        while (false);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = \u0005.\u0004.\u0001(14182);
        this.\u0003.EndInit();
        this.\u0003.ResumeLayout(false);
        this.\u0008.EndInit();
        ((ISupportInitialize) this.\u000F).EndInit();
        this.\u000E.EndInit();
        this.ResumeLayout(false);
      }
      catch (Exception ex)
      {
        ComponentResourceManager componentResourceManager2 = componentResourceManager1;
        BaseView[] baseViewArray2 = baseViewArray1;
        GridColumn[] gridColumnArray2 = gridColumnArray1;
        \u0005.\u0008.\u0001(ex, (object) componentResourceManager2, (object) baseViewArray2, (object) gridColumnArray2, (object) this);
        throw;
      }
    }
  }
}
