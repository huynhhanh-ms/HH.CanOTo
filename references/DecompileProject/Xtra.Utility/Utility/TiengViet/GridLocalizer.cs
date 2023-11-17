// Decompiled with JetBrains decompiler
// Type: Xtra.Utility.TiengViet.GridLocalizer
// Assembly: Xtra.Utility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0A554BF-0B1B-420F-A5E2-9214C58F15B4
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Utility.dll

using DevExpress.Utils.Localization;
using DevExpress.XtraGrid.Localization;

namespace Xtra.Utility.TiengViet
{
  internal class GridLocalizer : GridLocalizer
  {
    public virtual string Language => "TiengViet";

    public virtual string GetLocalizedString(GridStringId id)
    {
      string localizedString;
      switch (id - 81)
      {
        case 0:
          localizedString = "Kéo tiêu đề cột của lưới vào đây để nhóm thông tin theo cột đó";
          break;
        case 1:
          localizedString = "Bấm vào đây để thêm dòng mới";
          break;
        default:
          localizedString = ((XtraLocalizer<GridStringId>) this).GetLocalizedString(id);
          break;
      }
      return localizedString;
    }
  }
}
