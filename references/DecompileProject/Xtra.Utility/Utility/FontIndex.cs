// Decompiled with JetBrains decompiler
// Type: Xtra.Utility.FontIndex
// Assembly: Xtra.Utility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0A554BF-0B1B-420F-A5E2-9214C58F15B4
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Utility.dll

using System.ComponentModel;

namespace Xtra.Utility
{
  public enum FontIndex
  {
    [Description("Đéo biết font mã kiểu j??")] iNotKnown = -1, // 0xFFFFFFFF
    iNCR = 0,
    [Description("Utf-8")] iUTF = 1,
    [Description("Tiêu chuẩn Việt Nam")] iTCV = 2,
    [Description("VN Win")] iVNI = 3,
    iCP1258 = 4,
    iUTH = 5,
    [Description("Unicode")] iUNI = 6,
    iNOSIGN = 7,
    [Description("Vietware")] iVIQ = 8,
  }
}
