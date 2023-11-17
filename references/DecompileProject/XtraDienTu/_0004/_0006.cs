// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace \u0004
{
  internal static class \u0006
  {
    public static void \u0001(
      object _param0,
      DateTime _param1,
      string _param2,
      string _param3,
      string _param4,
      string _param5,
      string _param6,
      DateTime _param7,
      bool _param8 = false)
    {
      \u0001.\u0003 report;
      BindingSource dataSource;
      bool flag;
      try
      {
        if (false)
          return;
        report = new \u0001.\u0003();
        try
        {
          dataSource = (BindingSource) report.DataSource;
          dataSource.DataSource = _param0;
          if (true)
            goto label_4;
label_3:
          report.Parameters[\u0005.\u0004.\u0001(10046)].Value = (object) string.Format(\u0005.\u0004.\u0001(15054), (object) _param1.ToString(\u0005.\u0004.\u0001(2973)), (object) _param7.ToString(\u0005.\u0004.\u0001(2973)));
          report.Parameters[\u0005.\u0004.\u0001(7420)].Value = (object) (_param5.ToString() + \u0005.\u0004.\u0001(15091) + _param6.ToString());
          report.ShowPreviewDialog();
          return;
label_4:
          do
          {
            report.Parameters[\u0005.\u0004.\u0001(2646)].Value = (object) (\u0005.\u0004.\u0001(15036) + _param2.ToString());
            report.Parameters[\u0005.\u0004.\u0001(7641)].Value = (object) _param3.ToString();
          }
          while (false);
          report.Parameters[\u0005.\u0004.\u0001(7650)].Value = (object) (\u0005.\u0004.\u0001(15045) + _param4.ToString());
          goto label_3;
        }
        finally
        {
          int num = report == null ? 1 : 0;
          if (true)
          {
            flag = num != 0;
            num = flag ? 1 : 0;
          }
          if (num == 0)
            report.Dispose();
        }
      }
      catch (Exception ex)
      {
        object[] objArray = new object[12]
        {
          (object) report,
          (object) dataSource,
          (object) flag,
          _param0,
          (object) _param1,
          (object) _param2,
          (object) _param3,
          (object) _param4,
          (object) _param5,
          (object) _param6,
          (object) _param7,
          (object) _param8
        };
        \u0005.\u0008.\u0001(ex, objArray);
        throw;
      }
    }

    public static void \u0001(
      object _param0,
      string _param1,
      string _param2,
      string _param3,
      string _param4,
      string _param5,
      DateTime _param6,
      bool _param7 = false)
    {
      \u0008.\u0003 report;
      BindingSource dataSource;
      bool flag;
      try
      {
        report = new \u0008.\u0003();
        try
        {
          dataSource = (BindingSource) report.DataSource;
          dataSource.DataSource = _param0;
          report.Parameters[\u0005.\u0004.\u0001(2646)].Value = (object) (\u0005.\u0004.\u0001(15036) + _param1.ToString());
          report.Parameters[\u0005.\u0004.\u0001(7641)].Value = (object) _param2.ToString();
          report.Parameters[\u0005.\u0004.\u0001(7650)].Value = (object) (\u0005.\u0004.\u0001(15045) + _param3.ToString());
          report.Parameters[\u0005.\u0004.\u0001(7632)].Value = (object) string.Format(\u0005.\u0004.\u0001(15096), (object) _param6.Day, (object) _param6.Month, (object) _param6.Year);
          report.Parameters[\u0005.\u0004.\u0001(7420)].Value = (object) (_param4.ToString() + \u0005.\u0004.\u0001(15091) + _param5.ToString());
          report.ShowPreviewDialog();
        }
        finally
        {
          flag = report == null;
          if (!flag)
            report.Dispose();
        }
      }
      catch (Exception ex)
      {
        object[] objArray = new object[11]
        {
          (object) report,
          (object) dataSource,
          (object) flag,
          _param0,
          (object) _param1,
          (object) _param2,
          (object) _param3,
          (object) _param4,
          (object) _param5,
          (object) _param6,
          (object) _param7
        };
        \u0005.\u0008.\u0001(ex, objArray);
        throw;
      }
    }

    public static void \u0002(
      object _param0,
      string _param1,
      string _param2,
      string _param3,
      string _param4,
      string _param5,
      DateTime _param6,
      bool _param7 = false)
    {
      \u0007.\u0001 report;
      BindingSource dataSource;
      bool flag;
      try
      {
        report = new \u0007.\u0001();
        try
        {
          dataSource = (BindingSource) report.DataSource;
          dataSource.DataSource = _param0;
          report.Parameters[\u0005.\u0004.\u0001(2646)].Value = (object) (\u0005.\u0004.\u0001(15036) + _param1.ToString());
          report.Parameters[\u0005.\u0004.\u0001(7641)].Value = (object) _param2.ToString();
          report.Parameters[\u0005.\u0004.\u0001(7650)].Value = (object) (\u0005.\u0004.\u0001(15045) + _param3.ToString());
          report.Parameters[\u0005.\u0004.\u0001(7632)].Value = (object) string.Format(\u0005.\u0004.\u0001(15096), (object) _param6.Day, (object) _param6.Month, (object) _param6.Year);
          report.Parameters[\u0005.\u0004.\u0001(7420)].Value = (object) (_param4.ToString() + \u0005.\u0004.\u0001(15091) + _param5.ToString());
          report.ShowPreviewDialog();
        }
        finally
        {
          flag = report == null;
          if (!flag)
            report.Dispose();
        }
      }
      catch (Exception ex)
      {
        object[] objArray = new object[11]
        {
          (object) report,
          (object) dataSource,
          (object) flag,
          _param0,
          (object) _param1,
          (object) _param2,
          (object) _param3,
          (object) _param4,
          (object) _param5,
          (object) _param6,
          (object) _param7
        };
        \u0005.\u0008.\u0001(ex, objArray);
        throw;
      }
    }
  }
}
