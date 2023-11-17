// Decompiled with JetBrains decompiler
// Type: XtraDienTu.Properties.Settings
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using \u0005;
using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace XtraDienTu.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings \u0001;

    public static Settings Default
    {
      get
      {
label_0:
        Settings settings1;
        Settings settings2;
        try
        {
          if (true)
          {
            if (true)
            {
              Settings settings3 = Settings.\u0001;
              if (true)
                settings1 = settings3;
            }
            else
              goto label_8;
          }
          do
          {
            if (false)
              goto label_0;
          }
          while (false);
          settings2 = settings1;
        }
        catch (Exception ex)
        {
          Settings settings4 = settings1;
          \u0008.\u0001(ex, (object) settings4);
          throw;
        }
label_8:
        return settings2;
      }
    }

    static Settings()
    {
      try
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: object of a compiler-generated type is created
        Settings.\u0001 = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());
      }
      catch (Exception ex)
      {
        \u0008.\u0001(ex);
        throw;
      }
    }
  }
}
