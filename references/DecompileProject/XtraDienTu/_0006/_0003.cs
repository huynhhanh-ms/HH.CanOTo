// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using System.Windows.Forms;

namespace \u0006
{
  internal class \u0003 : \u0003.\u0005
  {
    protected override void \u0001(\u0006.\u0002 _param1) => _param1.ReportException = true;

    protected override void \u0001(\u0004.\u000E _param1)
    {
      _param1.TryToContinue = false;
      int num1;
      for (int index = _param1.CanDebug ? 1 : 0; index == 0; index = num1)
      {
        num1 = 18543;
        if (num1 != 0)
        {
          int num2 = (int) MessageBox.Show(\u0005.\u0004.\u0001(num1), \u0005.\u0004.\u0001(18640), MessageBoxButtons.OK, MessageBoxIcon.Hand);
          if (true)
            return;
          break;
        }
      }
      if (false)
        return;
      _param1.\u0003();
    }

    protected override void \u0001(\u0001.\u0007 _param1)
    {
      int num = (int) MessageBox.Show(_param1.FatalException.ToString(), \u0005.\u0004.\u0001(18681), MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }

    public static bool \u0001()
    {
      \u0003.\u0005.\u0001((\u0003.\u0005) new \u0006.\u0003());
      return true;
    }
  }
}
