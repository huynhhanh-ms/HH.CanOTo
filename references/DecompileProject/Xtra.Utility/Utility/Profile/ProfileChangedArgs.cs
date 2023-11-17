// Decompiled with JetBrains decompiler
// Type: Xtra.Utility.Profile.ProfileChangedArgs
// Assembly: Xtra.Utility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0A554BF-0B1B-420F-A5E2-9214C58F15B4
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Utility.dll

using System;

namespace Xtra.Utility.Profile
{
  public class ProfileChangedArgs : EventArgs
  {
    private readonly ProfileChangeType m_changeType;
    private readonly string m_section;
    private readonly string m_entry;
    private readonly object m_value;

    public ProfileChangedArgs(
      ProfileChangeType changeType,
      string section,
      string entry,
      object value)
    {
      this.m_changeType = changeType;
      this.m_section = section;
      this.m_entry = entry;
      this.m_value = value;
    }

    public ProfileChangeType ChangeType => this.m_changeType;

    public string Section => this.m_section;

    public string Entry => this.m_entry;

    public object Value => this.m_value;
  }
}
