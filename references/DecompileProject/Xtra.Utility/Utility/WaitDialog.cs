// Decompiled with JetBrains decompiler
// Type: Xtra.Utility.WaitDialog
// Assembly: Xtra.Utility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0A554BF-0B1B-420F-A5E2-9214C58F15B4
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Utility.dll

using DevExpress.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Xtra.Utility
{
  public class WaitDialog : IDisposable
  {
    private bool _disposedValue;
    private WaitDialogForm WaitDialogForm;

    public WaitDialog(string Status)
    {
      WaitDialogForm waitDialogForm = new WaitDialogForm(Status, "Vui lòng chờ trong giây lát!");
      ((Control) waitDialogForm).UseWaitCursor = true;
      this.WaitDialogForm = waitDialogForm;
    }

    public WaitDialog(string Status, string Title, Size Size)
    {
      WaitDialogForm waitDialogForm = new WaitDialogForm(Status, Title, Size);
      ((Control) waitDialogForm).UseWaitCursor = true;
      this.WaitDialogForm = waitDialogForm;
    }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    protected void Dispose(bool disposing)
    {
      if (!this._disposedValue && disposing)
      {
        ((Form) this.WaitDialogForm).Close();
        ((Component) this.WaitDialogForm).Dispose();
      }
      this._disposedValue = true;
    }
  }
}
