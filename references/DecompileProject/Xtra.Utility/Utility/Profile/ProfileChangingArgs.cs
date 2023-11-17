// Decompiled with JetBrains decompiler
// Type: Xtra.Utility.Profile.ProfileChangingArgs
// Assembly: Xtra.Utility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0A554BF-0B1B-420F-A5E2-9214C58F15B4
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Utility.dll

namespace Xtra.Utility.Profile
{
  public class ProfileChangingArgs : ProfileChangedArgs
  {
    private bool m_cancel;

    public ProfileChangingArgs(
      ProfileChangeType changeType,
      string section,
      string entry,
      object value)
      : base(changeType, section, entry, value)
    {
    }

    public bool Cancel
    {
      get => this.m_cancel;
      set => this.m_cancel = value;
    }
  }
}
