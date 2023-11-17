// Decompiled with JetBrains decompiler
// Type: Xtra.Utility.GridExportHelper
// Assembly: Xtra.Utility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0A554BF-0B1B-420F-A5E2-9214C58F15B4
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Utility.dll

using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System.IO;

namespace Xtra.Utility
{
  public class GridExportHelper
  {
    private GridControl _GridControl;
    private MemoryStream layoutStream = new MemoryStream();

    public static void ExportGridControl(GridControl gc, string fileName, ExportTarget type)
    {
      using (new WaitDialog("Đang xuất dữ liệu..."))
        new GridExportHelper().InternalExportGridControl(gc, fileName, type);
    }

    private GridView ExportedView => this._GridControl.MainView as GridView;

    private void InternalExportGridControl(GridControl gc, string fileName, ExportTarget type)
    {
      this._GridControl = gc;
      try
      {
        this.LockUpdate();
        this.SaveLayout();
        this.SubscribeEvents(this.ExportedView);
        this.CustomizeGridViewBeforeExport(this.ExportedView);
        this.DoExport(fileName, type);
      }
      finally
      {
        this.UnsubscribeEvents(this.ExportedView);
        this.RestoreLayout();
        this.UnlockUpdate();
      }
    }

    private void LockUpdate() => this._GridControl.BeginUpdate();

    private void UnlockUpdate() => this._GridControl.EndUpdate();

    private void RestoreLayout()
    {
      this.layoutStream.Position = 0L;
      ((BaseView) this.ExportedView).RestoreLayoutFromStream((Stream) this.layoutStream, OptionsLayoutBase.FullLayout);
    }

    private void SaveLayout() => ((BaseView) this.ExportedView).SaveLayoutToStream((Stream) this.layoutStream, OptionsLayoutBase.FullLayout);

    private void CustomizeGridViewBeforeExport(GridView view)
    {
      view.OptionsView.ColumnAutoWidth = false;
      view.BestFitColumns();
      view.OptionsPrint.AutoWidth = false;
    }

    private void view_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e) => e.DisplayText = string.Format("{0}", (object) e.DisplayText);

    private void SubscribeEvents(GridView view) => ((ColumnView) view).CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(this.view_CustomColumnDisplayText);

    private void UnsubscribeEvents(GridView view) => ((ColumnView) view).CustomColumnDisplayText -= new CustomColumnDisplayTextEventHandler(this.view_CustomColumnDisplayText);

    private void DoExport(string fileName, ExportTarget type) => ((BaseView) (this._GridControl.MainView as GridView)).Export(type, fileName);
  }
}
