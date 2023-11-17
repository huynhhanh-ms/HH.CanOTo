// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xtra.Data;

namespace \u0008
{
  internal class \u0006 : XtraForm
  {
    private IContainer \u0001;
    private PanelControl \u0002;
    private SimpleButton \u0003;
    private SimpleButton \u0004;
    private SimpleButton \u0005;
    private SimpleButton \u0006;
    private GridControl \u0007;
    private GridView \u0008;
    private BindingSource \u000E;
    private GridColumn \u000F;
    private GridColumn \u0010;
    private GridColumn \u0011;
    private CanDienTuEntities \u0012;

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
      BaseView[] baseViewArray1;
      GridColumn[] gridColumnArray1;
      ComponentResourceManager componentResourceManager1;
      try
      {
        this.\u0001 = (IContainer) new System.ComponentModel.Container();
        ComponentResourceManager componentResourceManager2 = new ComponentResourceManager(typeof (\u0008.\u0006));
        if (true)
          componentResourceManager1 = componentResourceManager2;
        this.\u0002 = new PanelControl();
        this.\u0003 = new SimpleButton();
        this.\u0004 = new SimpleButton();
        this.\u0005 = new SimpleButton();
        this.\u0006 = new SimpleButton();
        this.\u0007 = new GridControl();
        this.\u000E = new BindingSource(this.\u0001);
        this.\u0008 = new GridView();
        this.\u000F = new GridColumn();
        this.\u0010 = new GridColumn();
        this.\u0011 = new GridColumn();
        this.\u0002.BeginInit();
        this.\u0002.SuspendLayout();
        this.\u0007.BeginInit();
        ((ISupportInitialize) this.\u000E).BeginInit();
        this.\u0008.BeginInit();
        this.SuspendLayout();
        this.\u0002.Controls.Add((Control) this.\u0003);
        this.\u0002.Controls.Add((Control) this.\u0004);
        this.\u0002.Controls.Add((Control) this.\u0005);
        this.\u0002.Controls.Add((Control) this.\u0006);
        this.\u0002.Dock = DockStyle.Top;
        this.\u0002.Location = new Point(0, 0);
        this.\u0002.Name = \u0005.\u0004.\u0001(173);
        this.\u0002.Size = new Size(652, 46);
        this.\u0002.TabIndex = 7;
        this.\u0003.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        this.\u0003.Image = (Image) \u0008.\u0004.delete;
        this.\u0003.Location = new Point(472, 5);
        this.\u0003.Name = \u0005.\u0004.\u0001(1218);
        this.\u0003.Size = new Size(81, 36);
        this.\u0003.TabIndex = 0;
        this.\u0003.Text = \u0005.\u0004.\u0001(1227);
        this.\u0004.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        this.\u0004.Image = (Image) \u0008.\u0004.exit;
        this.\u0004.Location = new Point(559, 6);
        this.\u0004.Name = \u0005.\u0004.\u0001(194);
        this.\u0004.Size = new Size(81, 35);
        this.\u0004.TabIndex = 0;
        this.\u0004.Text = \u0005.\u0004.\u0001(207);
        this.\u0005.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        this.\u0005.Image = (Image) \u0008.\u0004.save;
        this.\u0005.Location = new Point(385, 5);
        this.\u0005.Name = \u0005.\u0004.\u0001(216);
        this.\u0005.Size = new Size(81, 36);
        this.\u0005.TabIndex = 0;
        this.\u0005.Text = \u0005.\u0004.\u0001(225);
        this.\u0006.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        this.\u0006.Image = (Image) \u0008.\u0004._new;
        this.\u0006.Location = new Point(298, 5);
        this.\u0006.Name = \u0005.\u0004.\u0001(1313);
        this.\u0006.Size = new Size(81, 36);
        this.\u0006.TabIndex = 0;
        this.\u0006.Text = \u0005.\u0004.\u0001(1326);
        this.\u0007.DataSource = (object) this.\u000E;
        this.\u0007.Dock = DockStyle.Fill;
        this.\u0007.Location = new Point(0, 46);
        this.\u0007.LookAndFeel.SkinName = \u0005.\u0004.\u0001(3057);
        this.\u0007.LookAndFeel.UseDefaultLookAndFeel = false;
        this.\u0007.MainView = (BaseView) this.\u0008;
        this.\u0007.Name = \u0005.\u0004.\u0001(1474);
        this.\u0007.Size = new Size(652, 216);
        this.\u0007.TabIndex = 8;
        ViewRepositoryCollection viewCollection = this.\u0007.ViewCollection;
        baseViewArray1 = new BaseView[1]
        {
          (BaseView) this.\u0008
        };
        BaseView[] views = baseViewArray1;
        viewCollection.AddRange(views);
        this.\u000E.DataSource = (object) typeof (KhachHang);
        GridColumnCollection columns1 = this.\u0008.Columns;
        gridColumnArray1 = new GridColumn[3]
        {
          this.\u000F,
          this.\u0010,
          this.\u0011
        };
        GridColumn[] columns2 = gridColumnArray1;
        columns1.AddRange(columns2);
        this.\u0008.GridControl = this.\u0007;
        this.\u0008.Name = \u0005.\u0004.\u0001(1491);
        this.\u0008.OptionsCustomization.AllowFilter = false;
        this.\u0008.OptionsCustomization.AllowSort = false;
        this.\u0008.OptionsView.ColumnAutoWidth = false;
        this.\u0008.OptionsView.EnableAppearanceEvenRow = true;
        this.\u0008.OptionsView.EnableAppearanceOddRow = true;
        this.\u0008.OptionsView.ShowGroupPanel = false;
        this.\u000F.Caption = \u0005.\u0004.\u0001(2324);
        this.\u000F.FieldName = \u0005.\u0004.\u0001(2192);
        this.\u000F.Name = \u0005.\u0004.\u0001(2799);
        this.\u000F.Visible = true;
        this.\u000F.VisibleIndex = 0;
        this.\u000F.Width = 93;
        this.\u0010.Caption = \u0005.\u0004.\u0001(2350);
        this.\u0010.FieldName = \u0005.\u0004.\u0001(2375);
        this.\u0010.Name = \u0005.\u0004.\u0001(2821);
        this.\u0010.Visible = true;
        this.\u0010.VisibleIndex = 1;
        this.\u0010.Width = 187;
        this.\u0011.Caption = \u0005.\u0004.\u0001(2629);
        this.\u0011.FieldName = \u0005.\u0004.\u0001(2646);
        this.\u0011.Name = \u0005.\u0004.\u0001(2655);
        this.\u0011.Visible = true;
        this.\u0011.VisibleIndex = 2;
        this.\u0011.Width = 354;
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(652, 262);
        this.Controls.Add((Control) this.\u0007);
        this.Controls.Add((Control) this.\u0002);
        this.Icon = (Icon) componentResourceManager1.GetObject(\u0005.\u0004.\u0001(525));
        this.LookAndFeel.Style = LookAndFeelStyle.Flat;
        this.Name = \u0005.\u0004.\u0001(14915);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = \u0005.\u0004.\u0001(14932);
        this.\u0002.EndInit();
        this.\u0002.ResumeLayout(false);
        this.\u0007.EndInit();
        ((ISupportInitialize) this.\u000E).EndInit();
        this.\u0008.EndInit();
        this.ResumeLayout(false);
      }
      catch (Exception ex)
      {
        ComponentResourceManager componentResourceManager3 = componentResourceManager1;
        BaseView[] baseViewArray2 = baseViewArray1;
        GridColumn[] gridColumnArray2 = gridColumnArray1;
        \u0005.\u0008.\u0001(ex, (object) componentResourceManager3, (object) baseViewArray2, (object) gridColumnArray2, (object) this);
        throw;
      }
    }

    public \u0006()
    {
      EventHandler eventHandler1 = (EventHandler) null;
      EventHandler eventHandler2 = (EventHandler) null;
      EventHandler eventHandler3 = (EventHandler) null;
      EventHandler eventHandler4 = (EventHandler) null;
      FormClosingEventHandler closingEventHandler1 = (FormClosingEventHandler) null;
      EventHandler eventHandler5 = (EventHandler) null;
      this.\u0001 = (IContainer) null;
      this.\u0012 = new CanDienTuEntities();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      try
      {
        this.\u0001();
        if (eventHandler1 == null)
          eventHandler1 = (EventHandler) ((_param1, _param2) =>
          {
            try
            {
              this.\u0002();
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
        SimpleButton simpleButton1 = this.\u0006;
        if (eventHandler2 == null)
          eventHandler2 = (EventHandler) ((_param1, _param2) =>
          {
            try
            {
              if (false)
                return;
              this.\u000E.AddNew();
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
        this.\u000E.AddingNew += (AddingNewEventHandler) ((_param0, _param1) =>
        {
          KhachHang khachHang1;
          try
          {
            if (false)
              return;
            AddingNewEventArgs addingNewEventArgs = _param1;
            khachHang1 = new KhachHang();
            khachHang1.Id = Guid.NewGuid();
            KhachHang khachHang2 = khachHang1;
            addingNewEventArgs.NewObject = (object) khachHang2;
          }
          catch (Exception ex)
          {
            KhachHang khachHang3 = khachHang1;
            object obj = _param0;
            AddingNewEventArgs addingNewEventArgs = _param1;
            \u0005.\u0008.\u0001(ex, (object) khachHang3, obj, (object) addingNewEventArgs);
            throw;
          }
        });
        SimpleButton simpleButton2 = this.\u0005;
        if (eventHandler3 == null)
          eventHandler3 = (EventHandler) ((_param1, _param2) =>
          {
            try
            {
              if (false)
                return;
              this.\u0012.SaveChanges();
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
        SimpleButton simpleButton3 = this.\u0004;
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
              int num = \u0004.\u0005.\u0001(this.\u0012) ? 1 : 0;
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
        SimpleButton simpleButton4 = this.\u0003;
        if (eventHandler5 == null)
          eventHandler5 = (EventHandler) ((_param1, _param2) =>
          {
            bool flag;
            try
            {
              do
              {
                int num = this.\u000E.Current == null ? 1 : 0;
                if (false)
                  goto label_2;
                else
                  goto label_5;
label_1:
                if (true)
                  num = this.\u0012.SaveChanges();
                else
                  goto label_6;
label_2:
                if (false)
                  goto label_1;
                else
                  goto label_9;
label_5:
                flag = num != 0;
label_6:
                if (!flag)
                {
                  this.\u000E.RemoveCurrent();
                  if (false)
                    continue;
                  goto label_1;
                }
label_9:
                this.\u0002();
              }
              while (false);
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
        EventHandler eventHandler9 = eventHandler5;
        simpleButton4.Click += eventHandler9;
      }
      catch (Exception ex)
      {
        EventHandler eventHandler10 = eventHandler1;
        EventHandler eventHandler11 = eventHandler2;
        EventHandler eventHandler12 = eventHandler3;
        EventHandler eventHandler13 = eventHandler4;
        FormClosingEventHandler closingEventHandler2 = closingEventHandler1;
        EventHandler eventHandler14 = eventHandler5;
        \u0005.\u0008.\u0001(ex, (object) eventHandler10, (object) eventHandler11, (object) eventHandler12, (object) eventHandler13, (object) closingEventHandler2, (object) eventHandler14, (object) this);
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
          this.\u000E.DataSource = _param1;
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

    private void \u0002()
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
  }
}
