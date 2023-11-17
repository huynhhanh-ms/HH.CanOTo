// Decompiled with JetBrains decompiler
// Type: Xtra.Utility.TiengViet.BarLocalizer
// Assembly: Xtra.Utility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0A554BF-0B1B-420F-A5E2-9214C58F15B4
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Utility.dll

using DevExpress.Utils.Localization;
using DevExpress.XtraBars.Customization;
using DevExpress.XtraBars.Localization;

namespace Xtra.Utility.TiengViet
{
  internal class BarLocalizer : BarLocalizer
  {
    protected virtual CustomizationControl CreateCustomizationControl() => (CustomizationControl) new CustomizationControl();

    public virtual string Language => "TiengViet";

    public virtual string GetLocalizedString(BarString id)
    {
      BarString barString = id;
      string localizedString;
      switch (barString - 2)
      {
        case 0:
          localizedString = "Thêm hoặc xóa nút";
          break;
        case 1:
          localizedString = "Bạn thực sự muốn khởi tạo lại thanh công cụ '{0}'";
          break;
        case 2:
          localizedString = "Tùy chỉnh thanh công cụ";
          break;
        case 3:
          localizedString = "Khởi tạo lại";
          break;
        case 4:
          localizedString = "Tùy chỉnh...";
          break;
        case 5:
        case 6:
        case 8:
        case 9:
label_16:
          localizedString = ((XtraLocalizer<BarString>) this).GetLocalizedString(id);
          break;
        case 7:
          localizedString = "Tên thanh công cụ";
          break;
        case 10:
          localizedString = "Đổi tên";
          break;
        case 11:
          localizedString = "Tùy chỉnh thanh công cụ";
          break;
        default:
          if (barString != 28)
          {
            switch (barString - 34)
            {
              case 0:
                localizedString = "Đóng";
                break;
              case 1:
                localizedString = "Thu nhỏ";
                break;
              case 2:
                localizedString = "Phóng lớn";
                break;
              case 4:
                localizedString = "Hướng dẫn";
                break;
              default:
                goto label_16;
            }
          }
          else
          {
            localizedString = "Tất cả";
            break;
          }
          break;
      }
      if (localizedString.Contains("Tool"))
        localizedString = "";
      return localizedString;
    }
  }
}
