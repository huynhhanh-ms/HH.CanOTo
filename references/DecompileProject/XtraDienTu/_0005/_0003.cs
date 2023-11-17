// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraNavBar;
using DevExpress.XtraTabbedMdi;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace \u0005
{
  internal class \u0003 : XtraForm
  {
    private IContainer \u0001;
    private BarManager \u0002;
    private Bar \u0003;
    private BarDockControl \u0004;
    private BarDockControl \u0005;
    private BarDockControl \u0006;
    private BarDockControl \u0007;
    private BarSubItem \u0008;
    private BarButtonItem \u000E;
    private BarButtonItem \u000F;
    private BarSubItem \u0010;
    private BarButtonItem \u0011;
    private BarButtonItem \u0012;
    private BarSubItem \u0013;
    private BarButtonItem \u0014;
    private BarSubItem \u0015;
    private BarButtonItem \u0016;
    private BarButtonItem \u0017;
    private DefaultLookAndFeel \u0018;
    private BarButtonItem \u0019;
    private BarButtonItem \u001A;
    private BarButtonItem \u001B;
    private BarButtonItem \u001C;
    private NavBarControl \u001D;
    private NavBarGroup \u001E;
    private NavBarItem \u001F;
    private NavBarItem \u007F;
    private NavBarGroup \u0080;
    private NavBarItem \u0081;
    private NavBarGroup \u0082;
    private NavBarItem \u0083;
    private PanelControl \u0084;
    private NavBarItem \u0086;
    private DevExpress.Utils.ImageCollection \u0087;
    private LabelControl \u0088;
    private LabelControl \u0089;
    private DockManager \u008A;
    private DockPanel \u008B;
    private ControlContainer \u008C;
    private PanelControl \u008D;
    private XtraTabbedMdiManager \u008E;
    private NavBarItem \u008F;
    private DevExpress.Utils.ImageCollection \u0090;

    public \u0003()
    {
      EventHandler eventHandler1 = (EventHandler) null;
      this.\u0001 = (IContainer) null;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      try
      {
        this.\u0003();
        this.\u0001();
        if (eventHandler1 == null)
          eventHandler1 = (EventHandler) ((_param1, _param2) =>
          {
            \u0008.\u0005 obj1;
            string str1;
            \u0006.\u0001 obj2;
            bool flag;
            try
            {
              obj2 = new \u0006.\u0001();
              if (true)
                goto label_10;
label_5:
              this.\u000F.Enabled = true;
              do
              {
                do
                {
                  obj1 = new \u0008.\u0005();
                  str1 = obj1.DiaChi + \u0005.\u0004.\u0001(14014) + obj1.DienThoai;
                }
                while (false);
                this.\u0088.Text = \u0005.\u0004.\u0001(14027) + str1.ToString();
              }
              while (false);
              this.\u0089.Text = obj1.Ten.ToString();
label_9:
              this.\u0002();
              return;
label_10:
              int num1 = obj2.ShowDialog() != DialogResult.OK ? 1 : 0;
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
              {
                this.\u001A.Enabled = false;
                goto label_5;
              }
              else
              {
                do
                {
                  this.\u001A.Enabled = true;
                  if (true)
                  {
                    this.\u000F.Enabled = false;
                    this.\u0002();
                  }
                  else
                    goto label_9;
                }
                while (false);
              }
            }
            catch (Exception ex)
            {
              \u0006.\u0001 obj3 = obj2;
              \u0008.\u0005 obj4 = obj1;
              string str2 = str1;
              // ISSUE: variable of a boxed type
              __Boxed<bool> local = (ValueType) flag;
              object obj5 = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) obj3, (object) obj4, (object) str2, (object) local, (object) this, obj5, (object) eventArgs);
              throw;
            }
          });
        this.Load += eventHandler1;
      }
      catch (Exception ex)
      {
        EventHandler eventHandler2 = eventHandler1;
        \u0005.\u0008.\u0001(ex, (object) eventHandler2, (object) this);
        throw;
      }
    }

    private void \u0001()
    {
      try
      {
        XtraTabbedMdiManager tabbedMdiManager = this.\u008E;
        // ISSUE: method pointer
        MdiTabPageEventHandler pageEventHandler = new MdiTabPageEventHandler((object) this, __methodptr(\u0001));
        if (true)
          tabbedMdiManager.PageRemoved += pageEventHandler;
        // ISSUE: method pointer
        this.\u008E.PageAdded += new MdiTabPageEventHandler((object) this, __methodptr(\u0002));
        if (false)
          ;
      }
      catch (Exception ex)
      {
        \u0005.\u0008.\u0001(ex, (object) this);
        throw;
      }
    }

    public unsafe bool \u0001(Type _param1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(3);
      Form current;
      IEnumerator enumerator1;
      IDisposable disposable1;
      try
      {
        enumerator1 = Application.OpenForms.GetEnumerator();
        try
        {
          do
          {
            *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) enumerator1.MoveNext();
            if (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0)
            {
              current = (Form) enumerator1.Current;
              *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) !(current.GetType().Name == _param1.Name);
            }
            else
              goto label_9;
          }
          while (*(sbyte*) ((IntPtr) voidPtr + 1) != (sbyte) 0);
          current.Activate();
          *(sbyte*) voidPtr = (sbyte) 1;
          goto label_10;
        }
        finally
        {
          disposable1 = enumerator1 as IDisposable;
          *(sbyte*) ((IntPtr) voidPtr + 1) = (sbyte) (disposable1 == null);
          if (*(sbyte*) ((IntPtr) voidPtr + 1) == (sbyte) 0)
            disposable1.Dispose();
        }
label_9:
        *(sbyte*) voidPtr = (sbyte) 0;
label_10:
        *(sbyte*) ((IntPtr) voidPtr + 2) = *(sbyte*) voidPtr;
      }
      catch (Exception ex)
      {
        Form form = current;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local1 = (ValueType) (bool) *(sbyte*) voidPtr;
        IEnumerator enumerator2 = enumerator1;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local2 = (ValueType) (bool) *(sbyte*) ((IntPtr) voidPtr + 1);
        IDisposable disposable2 = disposable1;
        Type type = _param1;
        \u0005.\u0008.\u0001(ex, (object) form, (object) local1, (object) enumerator2, (object) local2, (object) disposable2, (object) this, (object) type);
        throw;
      }
      return (bool) *(sbyte*) ((IntPtr) voidPtr + 2);
    }

    public unsafe DateTime \u0001(string _param1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(9);
      DateTime result;
      DateTimeFormatInfo provider;
      try
      {
        *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) DateTime.TryParse(_param1, out result);
        if (*(sbyte*) ((IntPtr) voidPtr + 8) == (sbyte) 0)
          goto label_8;
label_7:
        return result;
label_8:
        *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) !double.TryParse(_param1, out *(double*) voidPtr);
        if (*(sbyte*) ((IntPtr) voidPtr + 8) == (sbyte) 0)
        {
          if (true)
          {
            result = DateTime.FromOADate(*(double*) voidPtr);
            if (true)
              goto label_6;
          }
        }
        else
        {
          provider = new DateTimeFormatInfo();
          provider.ShortDatePattern = \u0005.\u0004.\u0001(3776);
          result = Convert.ToDateTime(_param1, (IFormatProvider) provider);
        }
label_6:
        goto label_7;
      }
      catch (Exception ex)
      {
        // ISSUE: variable of a boxed type
        __Boxed<DateTime> local1 = (ValueType) result;
        // ISSUE: variable of a boxed type
        __Boxed<double> local2 = (ValueType) *(double*) voidPtr;
        DateTimeFormatInfo dateTimeFormatInfo = provider;
        DateTime dateTime;
        // ISSUE: variable of a boxed type
        __Boxed<DateTime> local3 = (ValueType) dateTime;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local4 = (ValueType) (bool) *(sbyte*) ((IntPtr) voidPtr + 8);
        string str = _param1;
        \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) dateTimeFormatInfo, (object) local3, (object) local4, (object) this, (object) str);
        throw;
      }
    }

    private void \u0001(object _param1, ItemClickEventArgs _param2)
    {
      try
      {
        do
        {
          if (false)
            ;
          if (true)
            goto label_4;
label_2:
          continue;
label_4:
          int num = (int) new \u0007.\u0003().ShowDialog();
          goto label_2;
        }
        while (false);
      }
      catch (Exception ex)
      {
        object obj = _param1;
        ItemClickEventArgs itemClickEventArgs = _param2;
        \u0005.\u0008.\u0001(ex, (object) this, obj, (object) itemClickEventArgs);
        throw;
      }
    }

    private void \u0002(object _param1, ItemClickEventArgs _param2)
    {
      try
      {
        do
        {
          if (false)
            ;
          if (true)
            goto label_4;
label_2:
          continue;
label_4:
          int num = (int) new \u0008.\u0006().ShowDialog();
          goto label_2;
        }
        while (false);
      }
      catch (Exception ex)
      {
        object obj = _param1;
        ItemClickEventArgs itemClickEventArgs = _param2;
        \u0005.\u0008.\u0001(ex, (object) this, obj, (object) itemClickEventArgs);
        throw;
      }
    }

    private void \u0003(object _param1, ItemClickEventArgs _param2)
    {
      try
      {
        do
        {
          if (false)
            ;
          if (true)
            goto label_4;
label_2:
          continue;
label_4:
          int num = (int) new \u0004.\u0004().ShowDialog();
          goto label_2;
        }
        while (false);
      }
      catch (Exception ex)
      {
        object obj = _param1;
        ItemClickEventArgs itemClickEventArgs = _param2;
        \u0005.\u0008.\u0001(ex, (object) this, obj, (object) itemClickEventArgs);
        throw;
      }
    }

    private void \u0004(object _param1, ItemClickEventArgs _param2)
    {
      try
      {
        do
        {
          if (false)
            ;
          if (true)
            goto label_4;
label_2:
          continue;
label_4:
          int num = (int) new \u0007.\u0002().ShowDialog();
          goto label_2;
        }
        while (false);
      }
      catch (Exception ex)
      {
        object obj = _param1;
        ItemClickEventArgs itemClickEventArgs = _param2;
        \u0005.\u0008.\u0001(ex, (object) this, obj, (object) itemClickEventArgs);
        throw;
      }
    }

    private void \u0005(object _param1, ItemClickEventArgs _param2)
    {
      bool flag;
      \u0005.\u0001 obj1;
      \u0006.\u0001 obj2;
      \u0004.\u0003 obj3;
      try
      {
        if (true)
          goto label_15;
label_12:
        obj1.Show();
label_13:
        return;
label_15:
        obj2 = new \u0006.\u0001();
label_16:
        int num1 = obj2.ShowDialog() == DialogResult.Yes ? 1 : 0;
        if (true)
        {
          int num2 = num1 == 0 ? 1 : 0;
          if (false)
          {
            num1 = num2;
            goto label_5;
          }
          else
          {
            flag = num2 != 0;
            num1 = flag ? 1 : 0;
          }
        }
        else
          goto label_5;
label_3:
        if (num1 != 0)
          return;
        obj3 = new \u0004.\u0003();
        num1 = obj3.ShowDialog() == DialogResult.OK ? 1 : 0;
label_5:
        if (true)
        {
          flag = num1 == 0;
          if (!flag)
          {
            flag = !this.\u0001(typeof (\u0005.\u0001));
            if (true)
              num1 = flag ? 1 : 0;
            else
              goto label_16;
          }
          else
            goto label_13;
        }
        if (true)
        {
          if (num1 == 0)
            return;
          obj1 = new \u0005.\u0001();
          obj1.MdiParent = (Form) this;
          goto label_12;
        }
        else
          goto label_3;
      }
      catch (Exception ex)
      {
        \u0006.\u0001 obj4 = obj2;
        \u0004.\u0003 obj5 = obj3;
        \u0005.\u0001 obj6 = obj1;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (ValueType) flag;
        object obj7 = _param1;
        ItemClickEventArgs itemClickEventArgs = _param2;
        \u0005.\u0008.\u0001(ex, (object) obj4, (object) obj5, (object) obj6, (object) local, (object) this, obj7, (object) itemClickEventArgs);
        throw;
      }
    }

    private void \u0006(object _param1, ItemClickEventArgs _param2)
    {
      \u0006.\u0001 obj1;
      bool flag;
      try
      {
        if (true)
          goto label_7;
label_5:
        if (true)
          return;
        goto label_8;
label_7:
        obj1 = new \u0006.\u0001();
label_8:
        do
        {
          int num1 = obj1.ShowDialog() != DialogResult.Yes ? 1 : 0;
          int num2;
          while (true)
          {
            if (true)
              flag = num1 != 0;
            num2 = flag ? 1 : 0;
            if (false)
              num1 = num2;
            else
              break;
          }
          if (num2 != 0)
            goto label_5;
        }
        while (false);
        if (true)
        {
          int num = (int) new \u0004.\u0001().ShowDialog();
          goto label_5;
        }
        else
          goto label_5;
      }
      catch (Exception ex)
      {
        \u0006.\u0001 obj2 = obj1;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (ValueType) flag;
        object obj3 = _param1;
        ItemClickEventArgs itemClickEventArgs = _param2;
        \u0005.\u0008.\u0001(ex, (object) obj2, (object) local, (object) this, obj3, (object) itemClickEventArgs);
        throw;
      }
    }

    private void \u0007(object _param1, ItemClickEventArgs _param2)
    {
      \u0003.\u0001 obj1;
      bool flag;
      try
      {
        if (true)
          goto label_7;
label_5:
        if (true)
          return;
        goto label_8;
label_7:
        obj1 = new \u0003.\u0001();
label_8:
        do
        {
          int num1 = obj1.ShowDialog() != DialogResult.Yes ? 1 : 0;
          int num2;
          while (true)
          {
            if (true)
              flag = num1 != 0;
            num2 = flag ? 1 : 0;
            if (false)
              num1 = num2;
            else
              break;
          }
          if (num2 != 0)
            goto label_5;
        }
        while (false);
        if (true)
        {
          int num = (int) new \u0008.\u0002().ShowDialog();
          goto label_5;
        }
        else
          goto label_5;
      }
      catch (Exception ex)
      {
        \u0003.\u0001 obj2 = obj1;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (ValueType) flag;
        object obj3 = _param1;
        ItemClickEventArgs itemClickEventArgs = _param2;
        \u0005.\u0008.\u0001(ex, (object) obj2, (object) local, (object) this, obj3, (object) itemClickEventArgs);
        throw;
      }
    }

    private void \u0008(object _param1, ItemClickEventArgs _param2)
    {
      \u0005.\u0001 obj1;
      bool flag;
      try
      {
        do
        {
          int num1 = this.\u0001(typeof (\u0005.\u0001)) ? 1 : 0;
          if (true)
            num1 = num1 == 0 ? 1 : 0;
          int num2;
          while (true)
          {
            if (true)
              flag = num1 != 0;
            num2 = flag ? 1 : 0;
            if (false)
              num1 = num2;
            else
              break;
          }
          if (num2 != 0)
            goto label_11;
label_6:
          continue;
label_11:
          obj1 = new \u0005.\u0001();
label_4:
          if (true)
          {
            obj1.MdiParent = (Form) this;
            if (true)
            {
              obj1.Show();
              goto label_6;
            }
            else
              goto label_4;
          }
          else
            goto label_11;
        }
        while (false);
      }
      catch (Exception ex)
      {
        \u0005.\u0001 obj2 = obj1;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (ValueType) flag;
        object obj3 = _param1;
        ItemClickEventArgs itemClickEventArgs = _param2;
        \u0005.\u0008.\u0001(ex, (object) obj2, (object) local, (object) this, obj3, (object) itemClickEventArgs);
        throw;
      }
    }

    private void \u0001(object _param1, NavBarLinkEventArgs _param2)
    {
      try
      {
        do
        {
          if (false)
            ;
          if (true)
            goto label_4;
label_2:
          continue;
label_4:
          int num = (int) new \u0007.\u0003().ShowDialog();
          goto label_2;
        }
        while (false);
      }
      catch (Exception ex)
      {
        object obj = _param1;
        NavBarLinkEventArgs barLinkEventArgs = _param2;
        \u0005.\u0008.\u0001(ex, (object) this, obj, (object) barLinkEventArgs);
        throw;
      }
    }

    private void \u0002(object _param1, NavBarLinkEventArgs _param2)
    {
      try
      {
        do
        {
          if (false)
            ;
          if (true)
            goto label_4;
label_2:
          continue;
label_4:
          int num = (int) new \u0008.\u0006().ShowDialog();
          goto label_2;
        }
        while (false);
      }
      catch (Exception ex)
      {
        object obj = _param1;
        NavBarLinkEventArgs barLinkEventArgs = _param2;
        \u0005.\u0008.\u0001(ex, (object) this, obj, (object) barLinkEventArgs);
        throw;
      }
    }

    private void \u0003(object _param1, NavBarLinkEventArgs _param2)
    {
      \u0006.\u0001 obj1;
      bool flag;
      try
      {
        if (true)
          goto label_7;
label_5:
        if (true)
          return;
        goto label_8;
label_7:
        obj1 = new \u0006.\u0001();
label_8:
        do
        {
          int num1 = obj1.ShowDialog() != DialogResult.Yes ? 1 : 0;
          int num2;
          while (true)
          {
            if (true)
              flag = num1 != 0;
            num2 = flag ? 1 : 0;
            if (false)
              num1 = num2;
            else
              break;
          }
          if (num2 != 0)
            goto label_5;
        }
        while (false);
        if (true)
        {
          int num = (int) new \u0004.\u0001().ShowDialog();
          goto label_5;
        }
        else
          goto label_5;
      }
      catch (Exception ex)
      {
        \u0006.\u0001 obj2 = obj1;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (ValueType) flag;
        object obj3 = _param1;
        NavBarLinkEventArgs barLinkEventArgs = _param2;
        \u0005.\u0008.\u0001(ex, (object) obj2, (object) local, (object) this, obj3, (object) barLinkEventArgs);
        throw;
      }
    }

    private void \u0002()
    {
      bool flag;
      try
      {
        int num1 = this.DesignMode ? 1 : 0;
        if (true)
        {
          if (num1 != 0)
            goto label_6;
        }
        else
          goto label_5;
label_2:
        num1 = \u0008.\u0001.\u0001(\u0001.\u0006.\u0001(\u0005.\u0004.\u0001(10893))) < DateTime.Now ? 1 : 0;
label_5:
        int num2;
        int exitCode;
        if (num1 != 0)
        {
          int num3 = new \u0010.\u0001().ShowDialog() == DialogResult.OK ? 1 : 0;
          if (true)
          {
            num2 = num3;
            goto label_7;
          }
          else
          {
            exitCode = num3;
            goto label_10;
          }
        }
label_6:
        num2 = 1;
label_7:
        flag = num2 != 0;
        if (true)
        {
          if (flag)
            return;
          exitCode = -1;
        }
        else
          goto label_2;
label_10:
        Environment.Exit(exitCode);
      }
      catch (Exception ex)
      {
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (ValueType) flag;
        \u0005.\u0008.\u0001(ex, (object) local, (object) this);
        throw;
      }
    }

    private void \u0004(object _param1, NavBarLinkEventArgs _param2)
    {
      \u0005.\u0001 obj1;
      bool flag;
      try
      {
        do
        {
          int num1 = this.\u0001(typeof (\u0005.\u0001)) ? 1 : 0;
          if (true)
            num1 = num1 == 0 ? 1 : 0;
          int num2;
          while (true)
          {
            if (true)
              flag = num1 != 0;
            num2 = flag ? 1 : 0;
            if (false)
              num1 = num2;
            else
              break;
          }
          if (num2 != 0)
            goto label_11;
label_6:
          continue;
label_11:
          obj1 = new \u0005.\u0001();
label_4:
          if (true)
          {
            obj1.MdiParent = (Form) this;
            if (true)
            {
              obj1.Show();
              goto label_6;
            }
            else
              goto label_4;
          }
          else
            goto label_11;
        }
        while (false);
      }
      catch (Exception ex)
      {
        \u0005.\u0001 obj2 = obj1;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (ValueType) flag;
        object obj3 = _param1;
        NavBarLinkEventArgs barLinkEventArgs = _param2;
        \u0005.\u0008.\u0001(ex, (object) obj2, (object) local, (object) this, obj3, (object) barLinkEventArgs);
        throw;
      }
    }

    private void \u000E(object _param1, ItemClickEventArgs _param2)
    {
      \u0005.\u0002 obj1;
      bool flag;
      try
      {
        do
        {
          int num1 = this.\u0001(typeof (\u0005.\u0002)) ? 1 : 0;
          if (true)
            num1 = num1 == 0 ? 1 : 0;
          int num2;
          while (true)
          {
            if (true)
              flag = num1 != 0;
            num2 = flag ? 1 : 0;
            if (false)
              num1 = num2;
            else
              break;
          }
          if (num2 != 0)
            goto label_11;
label_6:
          continue;
label_11:
          obj1 = new \u0005.\u0002();
label_4:
          if (true)
          {
            obj1.MdiParent = (Form) this;
            if (true)
            {
              obj1.Show();
              goto label_6;
            }
            else
              goto label_4;
          }
          else
            goto label_11;
        }
        while (false);
      }
      catch (Exception ex)
      {
        \u0005.\u0002 obj2 = obj1;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (ValueType) flag;
        object obj3 = _param1;
        ItemClickEventArgs itemClickEventArgs = _param2;
        \u0005.\u0008.\u0001(ex, (object) obj2, (object) local, (object) this, obj3, (object) itemClickEventArgs);
        throw;
      }
    }

    private void \u0005(object _param1, NavBarLinkEventArgs _param2)
    {
      \u0005.\u0002 obj1;
      bool flag;
      try
      {
        do
        {
          int num1 = this.\u0001(typeof (\u0005.\u0002)) ? 1 : 0;
          if (true)
            num1 = num1 == 0 ? 1 : 0;
          int num2;
          while (true)
          {
            if (true)
              flag = num1 != 0;
            num2 = flag ? 1 : 0;
            if (false)
              num1 = num2;
            else
              break;
          }
          if (num2 != 0)
            goto label_11;
label_6:
          continue;
label_11:
          obj1 = new \u0005.\u0002();
label_4:
          if (true)
          {
            obj1.MdiParent = (Form) this;
            if (true)
            {
              obj1.Show();
              goto label_6;
            }
            else
              goto label_4;
          }
          else
            goto label_11;
        }
        while (false);
      }
      catch (Exception ex)
      {
        \u0005.\u0002 obj2 = obj1;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (ValueType) flag;
        object obj3 = _param1;
        NavBarLinkEventArgs barLinkEventArgs = _param2;
        \u0005.\u0008.\u0001(ex, (object) obj2, (object) local, (object) this, obj3, (object) barLinkEventArgs);
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

    private void \u0003()
    {
      Bar[] barArray1;
      BarItem[] barItemArray1;
      LinkPersistInfo[] linkPersistInfoArray1;
      DockPanel[] dockPanelArray1;
      string[] strArray1;
      NavBarGroup[] navBarGroupArray1;
      NavBarItem[] navBarItemArray1;
      NavBarItemLink[] navBarItemLinkArray1;
      ComponentResourceManager componentResourceManager1;
      try
      {
        this.\u0001 = (IContainer) new System.ComponentModel.Container();
        componentResourceManager1 = new ComponentResourceManager(typeof (\u0005.\u0003));
        this.\u0002 = new BarManager(this.\u0001);
        this.\u0003 = new Bar();
        this.\u0008 = new BarSubItem();
        this.\u000E = new BarButtonItem();
        this.\u000F = new BarButtonItem();
        this.\u001C = new BarButtonItem();
        this.\u0010 = new BarSubItem();
        this.\u0011 = new BarButtonItem();
        this.\u0019 = new BarButtonItem();
        this.\u001A = new BarButtonItem();
        this.\u001B = new BarButtonItem();
        this.\u0013 = new BarSubItem();
        this.\u0014 = new BarButtonItem();
        this.\u0015 = new BarSubItem();
        this.\u0016 = new BarButtonItem();
        this.\u0017 = new BarButtonItem();
        this.\u0004 = new BarDockControl();
        this.\u0005 = new BarDockControl();
        this.\u0006 = new BarDockControl();
        this.\u0007 = new BarDockControl();
        this.\u008A = new DockManager(this.\u0001);
        this.\u008B = new DockPanel();
        this.\u008C = new ControlContainer();
        this.\u001D = new NavBarControl();
        this.\u001E = new NavBarGroup();
        this.\u001F = new NavBarItem();
        this.\u007F = new NavBarItem();
        this.\u0086 = new NavBarItem();
        this.\u0080 = new NavBarGroup();
        this.\u0081 = new NavBarItem();
        this.\u0082 = new NavBarGroup();
        this.\u0083 = new NavBarItem();
        this.\u0087 = new DevExpress.Utils.ImageCollection(this.\u0001);
        this.\u0090 = new DevExpress.Utils.ImageCollection(this.\u0001);
        this.\u0012 = new BarButtonItem();
        this.\u0018 = new DefaultLookAndFeel(this.\u0001);
        this.\u0084 = new PanelControl();
        this.\u0088 = new LabelControl();
        this.\u0089 = new LabelControl();
        this.\u008D = new PanelControl();
        this.\u008E = new XtraTabbedMdiManager(this.\u0001);
        this.\u008F = new NavBarItem();
        this.\u0002.BeginInit();
        this.\u008A.BeginInit();
        this.\u008B.SuspendLayout();
        this.\u008C.SuspendLayout();
        this.\u001D.BeginInit();
        this.\u0087.BeginInit();
        this.\u0090.BeginInit();
        this.\u0084.BeginInit();
        this.\u0084.SuspendLayout();
        this.\u008D.BeginInit();
        this.\u008D.SuspendLayout();
        ((ISupportInitialize) this.\u008E).BeginInit();
        this.SuspendLayout();
        Bars bars1 = this.\u0002.Bars;
        barArray1 = new Bar[1]{ this.\u0003 };
        Bar[] bars2 = barArray1;
        bars1.AddRange(bars2);
        this.\u0002.DockControls.Add(this.\u0004);
        this.\u0002.DockControls.Add(this.\u0005);
        this.\u0002.DockControls.Add(this.\u0006);
        this.\u0002.DockControls.Add(this.\u0007);
        this.\u0002.DockManager = this.\u008A;
        this.\u0002.Form = (Control) this;
        this.\u0002.Images = (object) this.\u0090;
        BarItems items1 = this.\u0002.Items;
        barItemArray1 = new BarItem[15]
        {
          (BarItem) this.\u0008,
          (BarItem) this.\u0010,
          (BarItem) this.\u0013,
          (BarItem) this.\u0015,
          (BarItem) this.\u000E,
          (BarItem) this.\u000F,
          (BarItem) this.\u0011,
          (BarItem) this.\u0012,
          (BarItem) this.\u0014,
          (BarItem) this.\u0016,
          (BarItem) this.\u0017,
          (BarItem) this.\u0019,
          (BarItem) this.\u001A,
          (BarItem) this.\u001B,
          (BarItem) this.\u001C
        };
        BarItem[] items2 = barItemArray1;
        items1.AddRange(items2);
        this.\u0002.MainMenu = this.\u0003;
        this.\u0002.MaxItemId = 15;
        this.\u0003.BarName = \u0005.\u0004.\u0001(12104);
        this.\u0003.DockCol = 0;
        this.\u0003.DockRow = 0;
        this.\u0003.DockStyle = BarDockStyle.Top;
        this.\u0003.FloatLocation = new Point(303, 170);
        LinksInfo linksPersistInfo1 = this.\u0003.LinksPersistInfo;
        linkPersistInfoArray1 = new LinkPersistInfo[4]
        {
          new LinkPersistInfo((BarItem) this.\u0008),
          new LinkPersistInfo((BarItem) this.\u0010),
          new LinkPersistInfo((BarItem) this.\u0013),
          new LinkPersistInfo((BarItem) this.\u0015)
        };
        LinkPersistInfo[] links1 = linkPersistInfoArray1;
        linksPersistInfo1.AddRange(links1);
        this.\u0003.OptionsBar.MultiLine = true;
        this.\u0003.OptionsBar.UseWholeRow = true;
        this.\u0003.Text = \u0005.\u0004.\u0001(12104);
        this.\u0008.Caption = \u0005.\u0004.\u0001(12117);
        this.\u0008.Id = 0;
        this.\u0008.ImageIndex = 14;
        LinksInfo linksPersistInfo2 = this.\u0008.LinksPersistInfo;
        linkPersistInfoArray1 = new LinkPersistInfo[3]
        {
          new LinkPersistInfo((BarItem) this.\u000E),
          new LinkPersistInfo((BarItem) this.\u000F),
          new LinkPersistInfo((BarItem) this.\u001C)
        };
        LinkPersistInfo[] links2 = linkPersistInfoArray1;
        linksPersistInfo2.AddRange(links2);
        this.\u0008.Name = \u0005.\u0004.\u0001(12134);
        this.\u0008.PaintStyle = BarItemPaintStyle.CaptionGlyph;
        this.\u000E.Caption = \u0005.\u0004.\u0001(5012);
        this.\u000E.Id = 4;
        this.\u000E.ImageIndex = 15;
        this.\u000E.Name = \u0005.\u0004.\u0001(12151);
        this.\u000E.ItemClick += new ItemClickEventHandler(this.\u0005);
        this.\u000F.Caption = \u0005.\u0004.\u0001(12176);
        this.\u000F.Id = 5;
        this.\u000F.ImageIndex = 12;
        this.\u000F.Name = \u0005.\u0004.\u0001(12197);
        this.\u000F.ItemClick += new ItemClickEventHandler(this.\u0003);
        this.\u001C.Caption = \u0005.\u0004.\u0001(12222);
        this.\u001C.Id = 14;
        this.\u001C.ImageIndex = 18;
        this.\u001C.Name = \u0005.\u0004.\u0001(12255);
        this.\u001C.ItemClick += new ItemClickEventHandler(this.\u0007);
        this.\u0010.Caption = \u0005.\u0004.\u0001(12272);
        this.\u0010.Id = 1;
        this.\u0010.ImageIndex = 21;
        LinksInfo linksPersistInfo3 = this.\u0010.LinksPersistInfo;
        linkPersistInfoArray1 = new LinkPersistInfo[4]
        {
          new LinkPersistInfo((BarItem) this.\u0011),
          new LinkPersistInfo((BarItem) this.\u0019),
          new LinkPersistInfo((BarItem) this.\u001A),
          new LinkPersistInfo((BarItem) this.\u001B)
        };
        LinkPersistInfo[] links3 = linkPersistInfoArray1;
        linksPersistInfo3.AddRange(links3);
        this.\u0010.Name = \u0005.\u0004.\u0001(12289);
        this.\u0010.PaintStyle = BarItemPaintStyle.CaptionGlyph;
        this.\u0011.Caption = \u0005.\u0004.\u0001(12306);
        this.\u0011.Id = 6;
        this.\u0011.ImageIndex = 23;
        this.\u0011.Name = \u0005.\u0004.\u0001(12323);
        this.\u0011.ItemClick += new ItemClickEventHandler(this.\u0001);
        this.\u0019.Caption = \u0005.\u0004.\u0001(12344);
        this.\u0019.Id = 11;
        this.\u0019.ImageIndex = 24;
        this.\u0019.Name = \u0005.\u0004.\u0001(12361);
        this.\u0019.ItemClick += new ItemClickEventHandler(this.\u0002);
        this.\u001A.Caption = \u0005.\u0004.\u0001(10880);
        this.\u001A.Id = 12;
        this.\u001A.ImageIndex = 12;
        this.\u001A.Name = \u0005.\u0004.\u0001(12382);
        this.\u001A.ItemClick += new ItemClickEventHandler(this.\u0004);
        this.\u001B.Caption = \u0005.\u0004.\u0001(12399);
        this.\u001B.Id = 13;
        this.\u001B.ImageIndex = 25;
        this.\u001B.Name = \u0005.\u0004.\u0001(12416);
        this.\u001B.ItemClick += new ItemClickEventHandler(this.\u0006);
        this.\u0013.Caption = \u0005.\u0004.\u0001(12433);
        this.\u0013.Id = 2;
        this.\u0013.ImageIndex = 22;
        LinksInfo linksPersistInfo4 = this.\u0013.LinksPersistInfo;
        linkPersistInfoArray1 = new LinkPersistInfo[1]
        {
          new LinkPersistInfo((BarItem) this.\u0014)
        };
        LinkPersistInfo[] links4 = linkPersistInfoArray1;
        linksPersistInfo4.AddRange(links4);
        this.\u0013.Name = \u0005.\u0004.\u0001(12450);
        this.\u0013.PaintStyle = BarItemPaintStyle.CaptionGlyph;
        this.\u0014.Caption = \u0005.\u0004.\u0001(12467);
        this.\u0014.Id = 8;
        this.\u0014.ImageIndex = 2;
        this.\u0014.Name = \u0005.\u0004.\u0001(12492);
        this.\u0014.ItemClick += new ItemClickEventHandler(this.\u0008);
        this.\u0015.Caption = \u0005.\u0004.\u0001(12509);
        this.\u0015.Id = 3;
        this.\u0015.ImageIndex = 26;
        LinksInfo linksPersistInfo5 = this.\u0015.LinksPersistInfo;
        linkPersistInfoArray1 = new LinkPersistInfo[2]
        {
          new LinkPersistInfo((BarItem) this.\u0016),
          new LinkPersistInfo(BarLinkUserDefines.None, false, (BarItem) this.\u0017, false)
        };
        LinkPersistInfo[] links5 = linkPersistInfoArray1;
        linksPersistInfo5.AddRange(links5);
        this.\u0015.Name = \u0005.\u0004.\u0001(12522);
        this.\u0015.PaintStyle = BarItemPaintStyle.CaptionGlyph;
        this.\u0016.Caption = \u0005.\u0004.\u0001(12539);
        this.\u0016.Id = 9;
        this.\u0016.ImageIndex = 27;
        this.\u0016.Name = \u0005.\u0004.\u0001(12556);
        this.\u0016.ItemClick += new ItemClickEventHandler(this.\u000E);
        this.\u0017.Caption = \u0005.\u0004.\u0001(12577);
        this.\u0017.Id = 10;
        this.\u0017.Name = \u0005.\u0004.\u0001(12594);
        this.\u0004.CausesValidation = false;
        this.\u0004.Dock = DockStyle.Top;
        this.\u0004.Location = new Point(0, 0);
        this.\u0004.Size = new Size(950, 26);
        this.\u0005.CausesValidation = false;
        this.\u0005.Dock = DockStyle.Bottom;
        this.\u0005.Location = new Point(0, 455);
        this.\u0005.Size = new Size(950, 0);
        this.\u0006.CausesValidation = false;
        this.\u0006.Dock = DockStyle.Left;
        this.\u0006.Location = new Point(0, 26);
        this.\u0006.Size = new Size(0, 429);
        this.\u0007.CausesValidation = false;
        this.\u0007.Dock = DockStyle.Right;
        this.\u0007.Location = new Point(950, 26);
        this.\u0007.Size = new Size(0, 429);
        this.\u008A.Form = (ContainerControl) this;
        this.\u008A.MenuManager = (IDXMenuManager) this.\u0002;
        DockPanelCollection rootPanels = this.\u008A.RootPanels;
        dockPanelArray1 = new DockPanel[1]{ this.\u008B };
        DockPanel[] panels = dockPanelArray1;
        rootPanels.AddRange(panels);
        StringUniqueCollection topZindexControls = this.\u008A.TopZIndexControls;
        strArray1 = new string[7]
        {
          \u0005.\u0004.\u0001(12615),
          \u0005.\u0004.\u0001(12664),
          \u0005.\u0004.\u0001(12725),
          \u0005.\u0004.\u0001(12766),
          \u0005.\u0004.\u0001(12807),
          \u0005.\u0004.\u0001(12852),
          \u0005.\u0004.\u0001(12909)
        };
        string[] values = strArray1;
        topZindexControls.AddRange(values);
        this.\u008B.Controls.Add((Control) this.\u008C);
        this.\u008B.Dock = DockingStyle.Left;
        this.\u008B.ID = new Guid(\u0005.\u0004.\u0001(12966));
        this.\u008B.Location = new Point(0, 26);
        this.\u008B.Name = \u0005.\u0004.\u0001(13015);
        this.\u008B.OriginalSize = new Size(193, 200);
        this.\u008B.Size = new Size(193, 429);
        this.\u008B.Text = \u0005.\u0004.\u0001(13028);
        this.\u008C.Controls.Add((Control) this.\u001D);
        this.\u008C.Location = new Point(7, 31);
        this.\u008C.Name = \u0005.\u0004.\u0001(13065);
        this.\u008C.Size = new Size(179, 391);
        this.\u008C.TabIndex = 0;
        this.\u001D.ActiveGroup = this.\u001E;
        this.\u001D.Appearance.Background.BackColor = Color.White;
        this.\u001D.Appearance.Background.Options.UseBackColor = true;
        this.\u001D.BackColor = Color.FromArgb(192, 192, (int) byte.MaxValue);
        this.\u001D.BorderStyle = BorderStyles.NoBorder;
        this.\u001D.Dock = DockStyle.Fill;
        NavGroupCollection groups1 = this.\u001D.Groups;
        navBarGroupArray1 = new NavBarGroup[3]
        {
          this.\u001E,
          this.\u0080,
          this.\u0082
        };
        NavBarGroup[] groups2 = navBarGroupArray1;
        groups1.AddRange(groups2);
        NavItemCollection items3 = this.\u001D.Items;
        navBarItemArray1 = new NavBarItem[5]
        {
          this.\u001F,
          this.\u007F,
          this.\u0081,
          this.\u0083,
          this.\u0086
        };
        NavBarItem[] items4 = navBarItemArray1;
        items3.AddRange(items4);
        this.\u001D.Location = new Point(0, 0);
        this.\u001D.Name = \u0005.\u0004.\u0001(13094);
        this.\u001D.OptionsNavPane.ExpandedWidth = 179;
        this.\u001D.Size = new Size(179, 391);
        this.\u001D.SmallImages = (object) this.\u0087;
        this.\u001D.TabIndex = 0;
        this.\u001D.Text = \u0005.\u0004.\u0001(13094);
        this.\u001E.Caption = \u0005.\u0004.\u0001(12272);
        this.\u001E.Expanded = true;
        NavLinkCollection itemLinks1 = this.\u001E.ItemLinks;
        navBarItemLinkArray1 = new NavBarItemLink[3]
        {
          new NavBarItemLink(this.\u001F),
          new NavBarItemLink(this.\u007F),
          new NavBarItemLink(this.\u0086)
        };
        NavBarItemLink[] links6 = navBarItemLinkArray1;
        itemLinks1.AddRange(links6);
        this.\u001E.Name = \u0005.\u0004.\u0001(13115);
        this.\u001F.Caption = \u0005.\u0004.\u0001(12306);
        this.\u001F.Name = \u0005.\u0004.\u0001(13132);
        this.\u001F.SmallImageIndex = 0;
        this.\u001F.LinkClicked += new NavBarLinkEventHandler(this.\u0001);
        this.\u007F.Caption = \u0005.\u0004.\u0001(12344);
        this.\u007F.Name = \u0005.\u0004.\u0001(13157);
        this.\u007F.SmallImageIndex = 0;
        this.\u007F.LinkClicked += new NavBarLinkEventHandler(this.\u0002);
        this.\u0086.Caption = \u0005.\u0004.\u0001(12399);
        this.\u0086.Name = \u0005.\u0004.\u0001(13186);
        this.\u0086.SmallImageIndex = 0;
        this.\u0086.LinkClicked += new NavBarLinkEventHandler(this.\u0003);
        this.\u0080.Caption = \u0005.\u0004.\u0001(12433);
        this.\u0080.Expanded = true;
        NavLinkCollection itemLinks2 = this.\u0080.ItemLinks;
        navBarItemLinkArray1 = new NavBarItemLink[1]
        {
          new NavBarItemLink(this.\u0081)
        };
        NavBarItemLink[] links7 = navBarItemLinkArray1;
        itemLinks2.AddRange(links7);
        this.\u0080.Name = \u0005.\u0004.\u0001(13211);
        this.\u0081.Caption = \u0005.\u0004.\u0001(12467);
        this.\u0081.Name = \u0005.\u0004.\u0001(13228);
        this.\u0081.SmallImageIndex = 2;
        this.\u0081.LinkClicked += new NavBarLinkEventHandler(this.\u0004);
        this.\u0082.Caption = \u0005.\u0004.\u0001(12509);
        this.\u0082.Expanded = true;
        NavLinkCollection itemLinks3 = this.\u0082.ItemLinks;
        navBarItemLinkArray1 = new NavBarItemLink[1]
        {
          new NavBarItemLink(this.\u0083)
        };
        NavBarItemLink[] links8 = navBarItemLinkArray1;
        itemLinks3.AddRange(links8);
        this.\u0082.Name = \u0005.\u0004.\u0001(13249);
        this.\u0083.Caption = \u0005.\u0004.\u0001(12539);
        this.\u0083.Name = \u0005.\u0004.\u0001(13266);
        this.\u0083.SmallImageIndex = 1;
        this.\u0083.LinkClicked += new NavBarLinkEventHandler(this.\u0005);
        this.\u0087.ImageSize = new Size(32, 32);
        this.\u0087.ImageStream = (ImageCollectionStreamer) componentResourceManager1.GetObject(\u0005.\u0004.\u0001(13291));
        this.\u0087.Images.SetKeyName(0, \u0005.\u0004.\u0001(13332));
        this.\u0087.Images.SetKeyName(1, \u0005.\u0004.\u0001(13345));
        this.\u0087.Images.SetKeyName(2, \u0005.\u0004.\u0001(13362));
        this.\u0087.Images.SetKeyName(3, \u0005.\u0004.\u0001(13375));
        this.\u0087.Images.SetKeyName(4, \u0005.\u0004.\u0001(13392));
        this.\u0087.Images.SetKeyName(5, \u0005.\u0004.\u0001(13409));
        this.\u0087.Images.SetKeyName(6, \u0005.\u0004.\u0001(13426));
        this.\u0087.Images.SetKeyName(7, \u0005.\u0004.\u0001(13362));
        this.\u0087.Images.SetKeyName(8, \u0005.\u0004.\u0001(13332));
        this.\u0087.Images.SetKeyName(9, \u0005.\u0004.\u0001(13439));
        this.\u0087.Images.SetKeyName(10, \u0005.\u0004.\u0001(13345));
        this.\u0087.Images.SetKeyName(11, \u0005.\u0004.\u0001(13456));
        this.\u0087.Images.SetKeyName(12, \u0005.\u0004.\u0001(13473));
        this.\u0087.Images.SetKeyName(13, \u0005.\u0004.\u0001(13490));
        this.\u0087.Images.SetKeyName(14, \u0005.\u0004.\u0001(13507));
        this.\u0087.Images.SetKeyName(15, \u0005.\u0004.\u0001(13520));
        this.\u0087.Images.SetKeyName(16, \u0005.\u0004.\u0001(13533));
        this.\u0087.Images.SetKeyName(17, \u0005.\u0004.\u0001(13546));
        this.\u0087.Images.SetKeyName(18, \u0005.\u0004.\u0001(13559));
        this.\u0087.Images.SetKeyName(19, \u0005.\u0004.\u0001(13572));
        this.\u0087.Images.SetKeyName(20, \u0005.\u0004.\u0001(13585));
        this.\u0087.Images.SetKeyName(21, \u0005.\u0004.\u0001(13602));
        this.\u0087.Images.SetKeyName(22, \u0005.\u0004.\u0001(13619));
        this.\u0087.Images.SetKeyName(23, \u0005.\u0004.\u0001(13632));
        this.\u0090.ImageStream = (ImageCollectionStreamer) componentResourceManager1.GetObject(\u0005.\u0004.\u0001(13649));
        this.\u0090.Images.SetKeyName(0, \u0005.\u0004.\u0001(13409));
        this.\u0090.Images.SetKeyName(1, \u0005.\u0004.\u0001(13426));
        this.\u0090.Images.SetKeyName(2, \u0005.\u0004.\u0001(13362));
        this.\u0090.Images.SetKeyName(3, \u0005.\u0004.\u0001(13332));
        this.\u0090.Images.SetKeyName(4, \u0005.\u0004.\u0001(13439));
        this.\u0090.Images.SetKeyName(5, \u0005.\u0004.\u0001(13345));
        this.\u0090.Images.SetKeyName(6, \u0005.\u0004.\u0001(13456));
        this.\u0090.Images.SetKeyName(7, \u0005.\u0004.\u0001(13473));
        this.\u0090.Images.SetKeyName(8, \u0005.\u0004.\u0001(13490));
        this.\u0090.Images.SetKeyName(9, \u0005.\u0004.\u0001(13507));
        this.\u0090.Images.SetKeyName(10, \u0005.\u0004.\u0001(13520));
        this.\u0090.Images.SetKeyName(11, \u0005.\u0004.\u0001(13533));
        this.\u0090.Images.SetKeyName(12, \u0005.\u0004.\u0001(13546));
        this.\u0090.Images.SetKeyName(13, \u0005.\u0004.\u0001(13559));
        this.\u0090.Images.SetKeyName(14, \u0005.\u0004.\u0001(13572));
        this.\u0090.Images.SetKeyName(15, \u0005.\u0004.\u0001(13375));
        this.\u0090.Images.SetKeyName(16, \u0005.\u0004.\u0001(13392));
        this.\u0090.Images.SetKeyName(17, \u0005.\u0004.\u0001(13585));
        this.\u0090.Images.SetKeyName(18, \u0005.\u0004.\u0001(13602));
        this.\u0090.Images.SetKeyName(19, \u0005.\u0004.\u0001(13619));
        this.\u0090.Images.SetKeyName(20, \u0005.\u0004.\u0001(13632));
        this.\u0090.Images.SetKeyName(21, \u0005.\u0004.\u0001(13690));
        this.\u0090.Images.SetKeyName(22, \u0005.\u0004.\u0001(13707));
        this.\u0090.Images.SetKeyName(23, \u0005.\u0004.\u0001(13724));
        this.\u0090.Images.SetKeyName(24, \u0005.\u0004.\u0001(13741));
        this.\u0090.Images.SetKeyName(25, \u0005.\u0004.\u0001(13762));
        this.\u0090.Images.SetKeyName(26, \u0005.\u0004.\u0001(13779));
        this.\u0090.Images.SetKeyName(27, \u0005.\u0004.\u0001(13800));
        this.\u0012.Caption = \u0005.\u0004.\u0001(8427);
        this.\u0012.Id = 7;
        this.\u0012.Name = \u0005.\u0004.\u0001(13817);
        this.\u0018.LookAndFeel.SkinName = \u0005.\u0004.\u0001(160);
        this.\u0084.Appearance.BackColor = Color.Gold;
        this.\u0084.Appearance.Options.UseBackColor = true;
        this.\u0084.BorderStyle = BorderStyles.NoBorder;
        this.\u0084.Controls.Add((Control) this.\u0088);
        this.\u0084.Controls.Add((Control) this.\u0089);
        this.\u0084.Dock = DockStyle.Top;
        this.\u0084.Location = new Point(2, 2);
        this.\u0084.Name = \u0005.\u0004.\u0001(1453);
        this.\u0084.Padding = new Padding(1);
        this.\u0084.Size = new Size(753, 50);
        this.\u0084.TabIndex = 18;
        this.\u0088.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold);
        this.\u0088.Appearance.ForeColor = Color.Black;
        this.\u0088.Location = new Point(17, 25);
        this.\u0088.Name = \u0005.\u0004.\u0001(13838);
        this.\u0088.Size = new Size(27, 13);
        this.\u0088.TabIndex = 0;
        this.\u0088.Text = \u0005.\u0004.\u0001(13855);
        this.\u0089.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 10f);
        this.\u0089.Appearance.ForeColor = Color.Black;
        this.\u0089.Location = new Point(17, 6);
        this.\u0089.Name = \u0005.\u0004.\u0001(13860);
        this.\u0089.Size = new Size(27, 16);
        this.\u0089.TabIndex = 0;
        this.\u0089.Text = \u0005.\u0004.\u0001(13855);
        this.\u008D.ContentImage = (Image) \u0008.\u0004.AnhNen;
        this.\u008D.Controls.Add((Control) this.\u0084);
        this.\u008D.Dock = DockStyle.Fill;
        this.\u008D.Location = new Point(193, 26);
        this.\u008D.Name = \u0005.\u0004.\u0001(13881);
        this.\u008D.Size = new Size(757, 429);
        this.\u008D.TabIndex = 25;
        this.\u008E.MdiParent = (Form) this;
        this.\u008F.Caption = \u0005.\u0004.\u0001(12577);
        this.\u008F.Name = \u0005.\u0004.\u0001(13898);
        this.\u008F.SmallImageIndex = 0;
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(950, 455);
        this.Controls.Add((Control) this.\u008D);
        this.Controls.Add((Control) this.\u008B);
        this.Controls.Add((Control) this.\u0006);
        this.Controls.Add((Control) this.\u0007);
        this.Controls.Add((Control) this.\u0005);
        this.Controls.Add((Control) this.\u0004);
        this.Icon = (Icon) componentResourceManager1.GetObject(\u0005.\u0004.\u0001(525));
        this.IsMdiContainer = true;
        this.LookAndFeel.SkinName = \u0005.\u0004.\u0001(13923);
        this.LookAndFeel.UseWindowsXPTheme = true;
        this.Name = \u0005.\u0004.\u0001(13932);
        this.Text = \u0005.\u0004.\u0001(13941);
        this.WindowState = FormWindowState.Maximized;
        this.\u0002.EndInit();
        this.\u008A.EndInit();
        this.\u008B.ResumeLayout(false);
        this.\u008C.ResumeLayout(false);
        this.\u001D.EndInit();
        this.\u0087.EndInit();
        this.\u0090.EndInit();
        this.\u0084.EndInit();
        this.\u0084.ResumeLayout(false);
        this.\u0084.PerformLayout();
        this.\u008D.EndInit();
        this.\u008D.ResumeLayout(false);
        ((ISupportInitialize) this.\u008E).EndInit();
        this.ResumeLayout(false);
      }
      catch (Exception ex)
      {
        ComponentResourceManager componentResourceManager2 = componentResourceManager1;
        Bar[] barArray2 = barArray1;
        BarItem[] barItemArray2 = barItemArray1;
        LinkPersistInfo[] linkPersistInfoArray2 = linkPersistInfoArray1;
        DockPanel[] dockPanelArray2 = dockPanelArray1;
        string[] strArray2 = strArray1;
        NavBarGroup[] navBarGroupArray2 = navBarGroupArray1;
        NavBarItem[] navBarItemArray2 = navBarItemArray1;
        NavBarItemLink[] navBarItemLinkArray2 = navBarItemLinkArray1;
        \u0005.\u0008.\u0001(ex, (object) componentResourceManager2, (object) barArray2, (object) barItemArray2, (object) linkPersistInfoArray2, (object) dockPanelArray2, (object) strArray2, (object) navBarGroupArray2, (object) navBarItemArray2, (object) navBarItemLinkArray2, (object) this);
        throw;
      }
    }
  }
}
