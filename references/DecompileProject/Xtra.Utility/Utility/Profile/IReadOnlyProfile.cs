// Decompiled with JetBrains decompiler
// Type: Xtra.Utility.Profile.IReadOnlyProfile
// Assembly: Xtra.Utility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0A554BF-0B1B-420F-A5E2-9214C58F15B4
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Utility.dll

using System;
using System.Data;

namespace Xtra.Utility.Profile
{
  public interface IReadOnlyProfile : ICloneable
  {
    string Name { get; }

    object GetValue(string section, string entry);

    string GetValue(string section, string entry, string defaultValue);

    int GetValue(string section, string entry, int defaultValue);

    double GetValue(string section, string entry, double defaultValue);

    bool GetValue(string section, string entry, bool defaultValue);

    bool HasEntry(string section, string entry);

    bool HasSection(string section);

    string[] GetEntryNames(string section);

    string[] GetSectionNames();

    DataSet GetDataSet();
  }
}
