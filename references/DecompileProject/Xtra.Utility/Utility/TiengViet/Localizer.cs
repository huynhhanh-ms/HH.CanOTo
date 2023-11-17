// Decompiled with JetBrains decompiler
// Type: Xtra.Utility.TiengViet.Localizer
// Assembly: Xtra.Utility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0A554BF-0B1B-420F-A5E2-9214C58F15B4
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Utility.dll

using DevExpress.Utils.Localization;
using DevExpress.XtraEditors.Controls;

namespace Xtra.Utility.TiengViet
{
  internal class Localizer : Localizer
  {
    public virtual string Language => "TiengViet";

    public virtual string GetLocalizedString(StringId id)
    {
      StringId stringId = id;
      string localizedString;
      if (stringId <= 35)
      {
        if (stringId != 8)
        {
          if (stringId == 35)
          {
            localizedString = "<Chọn một giá trị>";
            goto label_15;
          }
        }
        else
        {
          localizedString = "Đồng ý";
          goto label_15;
        }
      }
      else
      {
        switch (stringId - 60)
        {
          case 0:
            localizedString = "Đồng ý";
            goto label_15;
          case 1:
            localizedString = "Hủy";
            goto label_15;
          case 2:
            localizedString = "Đồng ý";
            goto label_15;
          case 3:
            localizedString = "Không";
            goto label_15;
          case 4:
            break;
          case 5:
            localizedString = "Thử lại";
            goto label_15;
          case 6:
            localizedString = "Bỏ qua";
            goto label_15;
          default:
            if (stringId == 259)
            {
              localizedString = "Áp dụng";
              goto label_15;
            }
            else
              break;
        }
      }
      localizedString = ((XtraLocalizer<StringId>) this).GetLocalizedString(id);
label_15:
      return localizedString;
    }
  }
}
