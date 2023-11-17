// Decompiled with JetBrains decompiler
// Type: Xtra.Utility.TiengViet.Format
// Assembly: Xtra.Utility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0A554BF-0B1B-420F-A5E2-9214C58F15B4
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Utility.dll

using System.Globalization;
using System.Threading;

namespace Xtra.Utility.TiengViet
{
  internal class Format
  {
    public static void Active() => Thread.CurrentThread.CurrentCulture = new CultureInfo("vi-VN")
    {
      DateTimeFormat = {
        ShortDatePattern = "dd/MM/yyyy",
        MonthNames = new string[13]
        {
          "Tháng Một",
          "Tháng Hai",
          "Tháng Ba",
          "Tháng Tư",
          "Tháng Năm",
          "Tháng Sáu",
          "Tháng Bảy",
          "Tháng Tám",
          "Tháng Chín",
          "Tháng Mười",
          "Tháng Mười một",
          "Tháng Mười hai",
          ""
        },
        AbbreviatedMonthNames = new string[13]
        {
          "T1",
          "T2",
          "T3",
          "T4",
          "T5",
          "T6",
          "T7",
          "T8",
          "T9",
          "T10",
          "T11",
          "T12",
          ""
        },
        LongDatePattern = "dddd,dd MMMM \\nă\\m yyyy",
        MonthGenitiveNames = new string[13]
        {
          "tháng 01",
          "tháng 02",
          "tháng 03",
          "tháng 04",
          "tháng 05",
          "tháng 06",
          "tháng 07",
          "tháng 08",
          "tháng 09",
          "tháng 10",
          "tháng 11",
          "tháng 12",
          ""
        },
        ShortestDayNames = new string[7]
        {
          "CN",
          "Hai",
          "Ba",
          "Tư",
          "Năm",
          "Sáu",
          "Bảy"
        },
        MonthDayPattern = "dd MMMM",
        AbbreviatedDayNames = new string[7]
        {
          "CN",
          "Hai",
          "Ba",
          "Tư",
          "Năm",
          "Sáu",
          "Bảy"
        },
        DayNames = new string[7]
        {
          "Chủ nhật",
          "Thứ hai",
          "Thứ ba",
          "Thứ tư",
          "Thứ năm",
          "Thứ sáu",
          "Thứ bảy"
        }
      }
    };
  }
}
