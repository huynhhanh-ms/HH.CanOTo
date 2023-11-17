// Decompiled with JetBrains decompiler
// Type: Xtra.Utility.TiengViet.PreviewLocalizer
// Assembly: Xtra.Utility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0A554BF-0B1B-420F-A5E2-9214C58F15B4
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Utility.dll

using DevExpress.Utils.Localization;
using DevExpress.XtraPrinting.Localization;

namespace Xtra.Utility.TiengViet
{
  internal class PreviewLocalizer : PreviewLocalizer
  {
    public virtual string Language => "TiengViet";

    public virtual string GetLocalizedString(PreviewStringId id)
    {
      PreviewStringId previewStringId = id;
      string localizedString;
      if (previewStringId <= 90)
      {
        switch (previewStringId - 18)
        {
          case 0:
            localizedString = "Thu phóng";
            goto label_21;
          case 1:
            break;
          case 2:
            localizedString = "Thu nhỏ";
            goto label_21;
          default:
            switch (previewStringId - 48)
            {
              case 0:
                localizedString = "Sơ đồ văn bản";
                goto label_21;
              case 1:
                localizedString = "Những tham số";
                goto label_21;
              default:
                switch (previewStringId - 88)
                {
                  case 0:
                    localizedString = "Trang {0} trên {1}";
                    goto label_21;
                  case 2:
                    localizedString = "Trang trống";
                    goto label_21;
                }
                break;
            }
        }
      }
      else if (previewStringId <= 114)
      {
        switch (previewStringId - 109)
        {
          case 0:
            localizedString = "Báo cáo chưa được tải";
            goto label_21;
          case 1:
            localizedString = "Đang tạo văn bản....";
            goto label_21;
          default:
            if (previewStringId == 114)
            {
              localizedString = "Có lỗi trong quá trình in văn bản\nVui lòng kiểm tra lại máy in đã được bật hoặc Driver đã được cài";
              goto label_21;
            }
            else
              break;
        }
      }
      else if (previewStringId != 148)
      {
        if (previewStringId == 391)
        {
          localizedString = "Phóng to";
          goto label_21;
        }
      }
      else
      {
        localizedString = "In văn bản";
        goto label_21;
      }
      localizedString = ((XtraLocalizer<PreviewStringId>) this).GetLocalizedString(id);
label_21:
      return localizedString;
    }
  }
}
