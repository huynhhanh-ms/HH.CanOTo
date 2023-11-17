// Decompiled with JetBrains decompiler
// Type: Xtra.Utility.Profile.Ini
// Assembly: Xtra.Utility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0A554BF-0B1B-420F-A5E2-9214C58F15B4
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Utility.dll

using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Xtra.Utility.Profile
{
  public class Ini : Xtra.Utility.Profile.Profile
  {
    public Ini()
    {
    }

    public Ini(string fileName)
      : base(fileName)
    {
    }

    public Ini(Ini ini)
      : base((Xtra.Utility.Profile.Profile) ini)
    {
    }

    public override string DefaultName => this.DefaultNameWithoutExtension + ".ini";

    public override object Clone() => (object) new Ini(this);

    [DllImport("kernel32", SetLastError = true)]
    private static extern int WritePrivateProfileString(
      string section,
      string key,
      string value,
      string fileName);

    [DllImport("kernel32", SetLastError = true)]
    private static extern int WritePrivateProfileString(
      string section,
      string key,
      int value,
      string fileName);

    [DllImport("kernel32", SetLastError = true)]
    private static extern int WritePrivateProfileString(
      string section,
      int key,
      string value,
      string fileName);

    [DllImport("kernel32")]
    private static extern int GetPrivateProfileString(
      string section,
      string key,
      string defaultValue,
      StringBuilder result,
      int size,
      string fileName);

    [DllImport("kernel32")]
    private static extern int GetPrivateProfileString(
      string section,
      int key,
      string defaultValue,
      [MarshalAs(UnmanagedType.LPArray)] byte[] result,
      int size,
      string fileName);

    [DllImport("kernel32")]
    private static extern int GetPrivateProfileString(
      int section,
      string key,
      string defaultValue,
      [MarshalAs(UnmanagedType.LPArray)] byte[] result,
      int size,
      string fileName);

    public override void SetValue(string section, string entry, object value)
    {
      if (value == null)
      {
        this.RemoveEntry(section, entry);
      }
      else
      {
        this.VerifyNotReadOnly();
        this.VerifyName();
        this.VerifyAndAdjustSection(ref section);
        this.VerifyAndAdjustEntry(ref entry);
        if (!this.RaiseChangeEvent(true, ProfileChangeType.SetValue, section, entry, value))
          return;
        if (Ini.WritePrivateProfileString(section, entry, value.ToString(), this.Name) == 0)
          throw new Win32Exception();
        this.RaiseChangeEvent(false, ProfileChangeType.SetValue, section, entry, value);
      }
    }

    public override object GetValue(string section, string entry)
    {
      this.VerifyName();
      this.VerifyAndAdjustSection(ref section);
      this.VerifyAndAdjustEntry(ref entry);
      int num = 250;
      StringBuilder result;
      int privateProfileString;
      while (true)
      {
        result = new StringBuilder(num);
        privateProfileString = Ini.GetPrivateProfileString(section, entry, "", result, num, this.Name);
        if (privateProfileString >= num - 1)
          num *= 2;
        else
          break;
      }
      return privateProfileString == 0 && !this.HasEntry(section, entry) ? (object) null : (object) result.ToString();
    }

    public override void RemoveEntry(string section, string entry)
    {
      if (!this.HasEntry(section, entry))
        return;
      this.VerifyNotReadOnly();
      this.VerifyName();
      this.VerifyAndAdjustSection(ref section);
      this.VerifyAndAdjustEntry(ref entry);
      if (!this.RaiseChangeEvent(true, ProfileChangeType.RemoveEntry, section, entry, (object) null))
        return;
      if (Ini.WritePrivateProfileString(section, entry, 0, this.Name) == 0)
        throw new Win32Exception();
      this.RaiseChangeEvent(false, ProfileChangeType.RemoveEntry, section, entry, (object) null);
    }

    public override void RemoveSection(string section)
    {
      if (!this.HasSection(section))
        return;
      this.VerifyNotReadOnly();
      this.VerifyName();
      this.VerifyAndAdjustSection(ref section);
      if (!this.RaiseChangeEvent(true, ProfileChangeType.RemoveSection, section, (string) null, (object) null))
        return;
      if (Ini.WritePrivateProfileString(section, 0, "", this.Name) == 0)
        throw new Win32Exception();
      this.RaiseChangeEvent(false, ProfileChangeType.RemoveSection, section, (string) null, (object) null);
    }

    public override string[] GetEntryNames(string section)
    {
      if (!this.HasSection(section))
        return (string[]) null;
      this.VerifyAndAdjustSection(ref section);
      int size = 500;
      byte[] numArray;
      int privateProfileString;
      while (true)
      {
        numArray = new byte[size];
        privateProfileString = Ini.GetPrivateProfileString(section, 0, "", numArray, size, this.Name);
        if (privateProfileString >= size - 2)
          size *= 2;
        else
          break;
      }
      string str = Encoding.ASCII.GetString(numArray, 0, privateProfileString - (privateProfileString > 0 ? 1 : 0));
      return str == "" ? new string[0] : str.Split(new char[1]);
    }

    public override string[] GetSectionNames()
    {
      if (!File.Exists(this.Name))
        return (string[]) null;
      int size = 500;
      byte[] numArray;
      int privateProfileString;
      while (true)
      {
        numArray = new byte[size];
        privateProfileString = Ini.GetPrivateProfileString(0, "", "", numArray, size, this.Name);
        if (privateProfileString >= size - 2)
          size *= 2;
        else
          break;
      }
      string str = Encoding.ASCII.GetString(numArray, 0, privateProfileString - (privateProfileString > 0 ? 1 : 0));
      return str == "" ? new string[0] : str.Split(new char[1]);
    }
  }
}
