// Decompiled with JetBrains decompiler
// Type: Xtra.Utility.Profile.Registry
// Assembly: Xtra.Utility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0A554BF-0B1B-420F-A5E2-9214C58F15B4
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Utility.dll

using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace Xtra.Utility.Profile
{
  public class Registry : Xtra.Utility.Profile.Profile
  {
    private RegistryKey m_rootKey = Microsoft.Win32.Registry.CurrentUser;

    public Registry()
    {
    }

    public Registry(RegistryKey rootKey, string subKeyName)
      : base("")
    {
      if (rootKey != null)
        this.m_rootKey = rootKey;
      if (subKeyName == null)
        return;
      this.Name = subKeyName;
    }

    public Registry(Registry reg)
      : base((Xtra.Utility.Profile.Profile) reg)
    {
      this.m_rootKey = reg.m_rootKey;
    }

    public override string DefaultName
    {
      get
      {
        if (Application.CompanyName == "" || Application.ProductName == "")
          throw new InvalidOperationException("Application.CompanyName and/or Application.ProductName are empty and they're needed for the DefaultName.");
        return "Software\\" + Application.CompanyName + "\\" + Application.ProductName;
      }
    }

    public override object Clone() => (object) new Registry(this);

    public RegistryKey RootKey
    {
      get => this.m_rootKey;
      set
      {
        this.VerifyNotReadOnly();
        if (this.m_rootKey == value || !this.RaiseChangeEvent(true, ProfileChangeType.Other, (string) null, nameof (RootKey), (object) value))
          return;
        this.m_rootKey = value;
        this.RaiseChangeEvent(false, ProfileChangeType.Other, (string) null, nameof (RootKey), (object) value);
      }
    }

    protected RegistryKey GetSubKey(string section, bool create, bool writable)
    {
      this.VerifyName();
      string str = this.Name + "\\" + section;
      return create ? this.m_rootKey.CreateSubKey(str) : this.m_rootKey.OpenSubKey(str, writable);
    }

    public override void SetValue(string section, string entry, object value)
    {
      if (value == null)
      {
        this.RemoveEntry(section, entry);
      }
      else
      {
        this.VerifyNotReadOnly();
        this.VerifyAndAdjustSection(ref section);
        this.VerifyAndAdjustEntry(ref entry);
        if (!this.RaiseChangeEvent(true, ProfileChangeType.SetValue, section, entry, value))
          return;
        using (RegistryKey subKey = this.GetSubKey(section, true, true))
          subKey.SetValue(entry, value);
        this.RaiseChangeEvent(false, ProfileChangeType.SetValue, section, entry, value);
      }
    }

    public override object GetValue(string section, string entry)
    {
      this.VerifyAndAdjustSection(ref section);
      this.VerifyAndAdjustEntry(ref entry);
      using (RegistryKey subKey = this.GetSubKey(section, false, false))
        return subKey == null ? (object) null : subKey.GetValue(entry);
    }

    public override void RemoveEntry(string section, string entry)
    {
      this.VerifyNotReadOnly();
      this.VerifyAndAdjustSection(ref section);
      this.VerifyAndAdjustEntry(ref entry);
      using (RegistryKey subKey = this.GetSubKey(section, false, true))
      {
        if (subKey != null && subKey.GetValue(entry) != null && this.RaiseChangeEvent(true, ProfileChangeType.RemoveEntry, section, entry, (object) null))
        {
          subKey.DeleteValue(entry, false);
          this.RaiseChangeEvent(false, ProfileChangeType.RemoveEntry, section, entry, (object) null);
        }
      }
    }

    public override void RemoveSection(string section)
    {
      this.VerifyNotReadOnly();
      this.VerifyName();
      this.VerifyAndAdjustSection(ref section);
      using (RegistryKey registryKey = this.m_rootKey.OpenSubKey(this.Name, true))
      {
        if (registryKey != null && this.HasSection(section) && this.RaiseChangeEvent(true, ProfileChangeType.RemoveSection, section, (string) null, (object) null))
        {
          registryKey.DeleteSubKeyTree(section);
          this.RaiseChangeEvent(false, ProfileChangeType.RemoveSection, section, (string) null, (object) null);
        }
      }
    }

    public override string[] GetEntryNames(string section)
    {
      this.VerifyAndAdjustSection(ref section);
      using (RegistryKey subKey = this.GetSubKey(section, false, false))
        return subKey?.GetValueNames();
    }

    public override string[] GetSectionNames()
    {
      this.VerifyName();
      using (RegistryKey registryKey = this.m_rootKey.OpenSubKey(this.Name))
        return registryKey?.GetSubKeyNames();
    }
  }
}
