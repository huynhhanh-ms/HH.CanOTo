// Decompiled with JetBrains decompiler
// Type: Xtra.Utility.TiengViet.ActiveVN
// Assembly: Xtra.Utility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0A554BF-0B1B-420F-A5E2-9214C58F15B4
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Utility.dll

using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.Utils;
using DevExpress.Utils.Localization;
using DevExpress.XtraBars.Localization;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraPrinting.Localization;
using System.Drawing;

namespace Xtra.Utility.TiengViet
{
  public class ActiveVN
  {
    public static void Active()
    {
      BonusSkins.Register();
      Format.Active();
      BarLocalizer.Active = (BarLocalizer) new BarLocalizer();
      GridLocalizer.Active = (XtraLocalizer<GridStringId>) new GridLocalizer();
      PreviewLocalizer.Active = (XtraLocalizer<PreviewStringId>) new PreviewLocalizer();
      Localizer.Active = (XtraLocalizer<StringId>) new Localizer();
      AppearanceObject.DefaultFont = new Font("Tahoma", 8.25f);
      string str = RegistryKeyHelper.ReadKey("Skin");
      if (!string.IsNullOrWhiteSpace(str))
      {
        UserLookAndFeel.Default.SetSkinStyle(str.ToString());
        UserLookAndFeel.Default.SkinName = str.ToString();
      }
      else
        UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
    }
  }
}
