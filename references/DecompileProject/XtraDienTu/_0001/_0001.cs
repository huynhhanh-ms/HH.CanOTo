// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using DevExpress.XtraEditors;
using System;
using System.IO;
using System.Windows.Forms;

namespace \u0001
{
  internal class \u0001
  {
    public void \u0001(bool _param1 = false)
    {
      string sourceFileName;
      SaveFileDialog saveFileDialog1;
      SaveFileDialog saveFileDialog2;
      SaveFileDialog saveFileDialog3;
      bool flag;
      DateTime now;
      OpenFileDialog openFileDialog1;
      OpenFileDialog openFileDialog2;
      OpenFileDialog openFileDialog3;
      string str1;
      try
      {
        str1 = \u0006.\u0001(\u0005.\u0004.\u0001(6970));
        flag = !_param1;
        if (!flag)
        {
          do
            ;
          while (false);
          sourceFileName = Application.StartupPath + \u0005.\u0004.\u0001(6991);
          saveFileDialog1 = new SaveFileDialog();
          saveFileDialog1.Filter = \u0005.\u0004.\u0001(7016);
          saveFileDialog1.FileName = \u0005.\u0004.\u0001(7049);
          if (true)
          {
            saveFileDialog2 = saveFileDialog1;
            saveFileDialog3 = saveFileDialog2;
            try
            {
              flag = saveFileDialog3.ShowDialog() != DialogResult.OK;
              if (flag)
                return;
              flag = !File.Exists(saveFileDialog3.FileName);
              if (!flag)
              {
                string fileName1 = saveFileDialog3.FileName;
                string fileName2 = saveFileDialog3.FileName;
                string format = \u0005.\u0004.\u0001(7074);
                now = DateTime.Now;
                string str2 = now.ToString(\u0005.\u0004.\u0001(7091));
                string str3 = string.Format(format, (object) str2);
                string destFileName = fileName2 + str3;
                File.Copy(fileName1, destFileName, true);
              }
              File.Copy(sourceFileName, saveFileDialog3.FileName, true);
              \u0006.\u0001(\u0005.\u0004.\u0001(6970), saveFileDialog3.FileName, (string) null);
              int num = (int) XtraMessageBox.Show(\u0005.\u0004.\u0001(7108), \u0005.\u0004.\u0001(7165), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
              return;
            }
            finally
            {
              flag = saveFileDialog3 == null;
              if (!flag)
                saveFileDialog3.Dispose();
            }
          }
        }
        else
        {
          openFileDialog1 = new OpenFileDialog();
          openFileDialog1.Filter = \u0005.\u0004.\u0001(7016);
        }
        openFileDialog1.FileName = \u0005.\u0004.\u0001(7049);
        openFileDialog2 = openFileDialog1;
        openFileDialog3 = openFileDialog2;
        try
        {
          flag = openFileDialog3.ShowDialog() != DialogResult.OK;
          if (!flag)
          {
            int num1 = 6970;
            if (num1 != 0)
            {
              \u0006.\u0001(\u0005.\u0004.\u0001(num1), openFileDialog3.FileName, (string) null);
              num1 = 7182;
            }
            int num2 = (int) XtraMessageBox.Show(\u0005.\u0004.\u0001(num1), \u0005.\u0004.\u0001(7165), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
        }
        finally
        {
          flag = openFileDialog3 == null;
          if (!flag)
            openFileDialog3.Dispose();
        }
      }
      catch (Exception ex)
      {
        object[] objArray = new object[12]
        {
          (object) str1,
          (object) sourceFileName,
          (object) saveFileDialog2,
          (object) saveFileDialog3,
          (object) saveFileDialog1,
          (object) openFileDialog2,
          (object) openFileDialog3,
          (object) openFileDialog1,
          (object) flag,
          (object) now,
          (object) this,
          (object) _param1
        };
        \u0005.\u0008.\u0001(ex, objArray);
        throw;
      }
    }
  }
}
