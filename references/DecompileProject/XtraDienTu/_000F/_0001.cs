// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using \u0005;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace \u000F
{
  internal static class \u0001
  {
    [STAThread]
    private static void \u0001()
    {
      CultureInfo cultureInfo;
      try
      {
        if (false)
          goto label_7;
        else
          goto label_13;
label_1:
        int num1;
        int num2;
        if (true)
        {
          if (num2 == 0)
            return;
          BonusSkins.Register();
        }
        else
        {
          num1 = num2;
          goto label_15;
        }
label_3:
        num1 = 14965;
        goto label_15;
label_7:
        do
        {
          if (true)
            goto label_16;
label_8:
          if (true)
          {
            if (true)
              continue;
            goto label_5;
          }
          else
            goto label_3;
label_16:
          Application.EnableVisualStyles();
          goto label_8;
        }
        while (false);
        goto label_11;
label_5:
        return;
label_11:
        UserLookAndFeel.Default.SetSkinStyle(\u0005.\u0004.\u0001(14974));
        num2 = 0;
        if (num2 == 0)
        {
          Application.SetCompatibleTextRenderingDefault(num2 != 0);
          Application.ThreadException += (ThreadExceptionEventHandler) ((_param0, _param1) =>
          {
            Exception exception1;
            try
            {
              do
              {
                exception1 = _param1.Exception;
                int num3 = (int) XtraMessageBox.Show(exception1.Message, \u0005.\u0004.\u0001(7165), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              }
              while (false);
            }
            catch (Exception ex)
            {
              Exception exception2 = exception1;
              object obj = _param0;
              ThreadExceptionEventArgs exceptionEventArgs = _param1;
              \u0008.\u0001(ex, (object) exception2, obj, (object) exceptionEventArgs);
              throw;
            }
          });
          Application.Run((Form) new \u0005.\u0003());
          return;
        }
        goto label_1;
label_13:
        num2 = \u0006.\u0003.\u0001() ? 1 : 0;
        goto label_1;
label_15:
        cultureInfo = new CultureInfo(\u0005.\u0004.\u0001(num1));
        Thread.CurrentThread.CurrentCulture = cultureInfo;
        goto label_7;
      }
      catch (Exception ex)
      {
        object[] objArray = new object[1]
        {
          (object) cultureInfo
        };
        \u0003.\u0005.\u0001(ex, objArray);
      }
    }
  }
}
