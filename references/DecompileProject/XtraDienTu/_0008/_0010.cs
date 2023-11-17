// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace \u0008
{
  internal class \u0010
  {
    private const int \u0001 = 16;
    private const int \u0002 = 1024;
    private const int \u0003 = 2048;
    private const int \u0004 = 1;
    private const int \u0005 = 89;
    private const int \u0006 = 9;
    private static bool \u0007;
    private static \u0010.\u0002 \u0008;

    [DllImport("shell32", EntryPoint = "ExtractIconEx")]
    private static extern int \u0001(
      string _param0,
      int _param1,
      ref int _param2,
      ref int _param3,
      int _param4);

    [DllImport("user32", EntryPoint = "DrawText", CharSet = CharSet.Unicode)]
    private static extern int \u0001(
      IntPtr _param0,
      string _param1,
      int _param2,
      ref \u0010.\u0001 _param3,
      int _param4);

    [DllImport("gdi32.dll", EntryPoint = "SelectObject")]
    private static extern IntPtr \u0001(IntPtr _param0, IntPtr _param1);

    [DllImport("kernel32.Dll", EntryPoint = "GetVersionEx")]
    private static extern short \u0001(ref \u0010.\u0002 _param0);

    [DllImport("user32.dll", EntryPoint = "GetSystemMetrics")]
    private static extern int \u0001(int _param0);

    [DllImport("kernel32.dll", EntryPoint = "GetSystemInfo")]
    private static extern void \u0001(ref \u0010.\u0003 _param0);

    private static \u0010.\u0002 VersionInfo
    {
      get
      {
        if (!\u0010.\u0007)
        {
          \u0010.\u0008 = new \u0010.\u0002();
          try
          {
            do
            {
              \u0010.\u0008.\u0001 = Marshal.SizeOf(typeof (\u0010.\u0002));
              do
              {
                int num = (int) \u0010.\u0001(ref \u0010.\u0008);
              }
              while (false);
              \u0010.\u0007 = true;
            }
            while (false);
          }
          catch
          {
          }
        }
        return \u0010.\u0008;
      }
    }

    internal static bool IsX64
    {
      get
      {
        bool flag;
        try
        {
          \u0010.\u0003 obj;
          do
          {
            obj = new \u0010.\u0003();
          }
          while (false);
          \u0010.\u0001(ref obj);
          int num1 = (int) obj.\u0001;
          int num2;
          while (true)
          {
            num2 = num1 == 9 ? 1 : 0;
            if (false)
              num1 = num2;
            else if (false)
              num1 = num2;
            else
              break;
          }
          flag = num2 != 0;
        }
        catch
        {
          flag = false;
        }
        return flag;
      }
    }

    internal static bool IsServerR2
    {
      get
      {
        bool flag;
        try
        {
          do
          {
            if (true)
            {
              int num1 = \u0010.\u0001(89);
              int num2 = 0;
              if (num2 == 0)
              {
                int num3 = num1 == num2 ? 1 : 0;
                num2 = 0;
                num1 = num3;
              }
              flag = num1 == num2;
            }
          }
          while (false);
        }
        catch
        {
          if (true)
            flag = false;
        }
        return flag;
      }
    }

    internal static bool IsWorkstation => \u0010.VersionInfo.\u000F == (byte) 1;

    internal static string ServicePack => \u0010.VersionInfo.\u0006;

    public static Icon \u0001()
    {
      Icon icon;
      try
      {
        if (true)
          icon = \u0010.\u0002();
      }
      catch (Exception ex)
      {
        icon = \u0004.\u000F.\u0001(\u0005.\u0004.\u0001(18530));
      }
      return icon;
    }

    private static unsafe Icon \u0002()
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(12);
      *(int*) voidPtr = 0;
      *(int*) ((IntPtr) voidPtr + 4) = 0;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      *(int*) ((IntPtr) voidPtr + 8) = \u0010.\u0001(Application.ExecutablePath, -1, (int&) ((IntPtr) voidPtr + 4), (int&) ((IntPtr) voidPtr + 4), 1);
      if (*(int*) ((IntPtr) voidPtr + 8) > 0)
      {
        // ISSUE: cast to a reference type
        \u0010.\u0001(Application.ExecutablePath, 0, ref *(int*) voidPtr, (int&) ((IntPtr) voidPtr + 4), 1);
        if (*(int*) voidPtr != 0)
          return Icon.FromHandle(new IntPtr(*(int*) voidPtr));
      }
      return (Icon) null;
    }

    internal static int \u0001(Graphics _param0, string _param1, Font _param2, int _param3)
    {
      int num1;
      try
      {
        num1 = \u0010.\u0003(_param0, _param1, _param2, _param3);
        goto label_9;
      }
      catch (Exception ex1)
      {
        try
        {
          if (true)
          {
            num1 = Convert.ToInt32((double) \u0010.\u0002(_param0, _param1, _param2, _param3) * 1.1);
            goto label_9;
          }
          else
            goto label_9;
        }
        catch (Exception ex2)
        {
        }
      }
label_6:
      if (true)
        return 0;
label_9:
      if (true)
      {
        int num2 = num1;
        return false ? num2 : num2;
      }
      goto label_6;
    }

    private static int \u0002(Graphics _param0, string _param1, Font _param2, int _param3) => Size.Ceiling(_param0.MeasureString(_param1, _param2, _param3)).Height;

    private static int \u0003(Graphics _param0, string _param1, Font _param2, int _param3)
    {
      \u0010.\u0001 obj;
      if (true)
        obj = new \u0010.\u0001(new Rectangle(0, 0, _param3, 10000));
      else
        goto label_7;
label_2:
      int num1 = 3088;
      IntPtr hdc = _param0.GetHdc();
      IntPtr hfont = _param2.ToHfont();
      IntPtr num2 = hdc;
      IntPtr num3 = hfont;
label_5:
      IntPtr num4 = \u0010.\u0001(num2, num3);
      if (true)
      {
        int num5 = \u0010.\u0001(hdc, _param1, -1, ref obj, num1);
        if (false)
          return num5;
      }
      else
        goto label_10;
label_7:
      if (true)
      {
        IntPtr num6 = hdc;
        IntPtr num7 = num4;
        if (false)
        {
          num3 = num7;
          num2 = num6;
          goto label_5;
        }
        else
        {
          \u0010.\u0001(num6, num7);
          _param0.ReleaseHdc(hdc);
        }
      }
      else
        goto label_2;
label_10:
      return obj.\u0004 - obj.\u0002;
    }

    private struct \u0001
    {
      public int \u0001;
      public int \u0002;
      public int \u0003;
      public int \u0004;

      public \u0001(Rectangle rectangle)
      {
        this.\u0001 = rectangle.Left;
        this.\u0002 = rectangle.Top;
        this.\u0004 = rectangle.Bottom;
        this.\u0003 = rectangle.Right;
      }
    }

    private struct \u0002
    {
      public int \u0001;
      public uint \u0002;
      public uint \u0003;
      public uint \u0004;
      public uint \u0005;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
      public string \u0006;
      public ushort \u0007;
      public ushort \u0008;
      public ushort \u000E;
      public byte \u000F;
      private byte \u0010;
    }

    public struct \u0003
    {
      public ushort \u0001;
      private ushort \u0002;
      public uint \u0003;
      public IntPtr \u0004;
      public IntPtr \u0005;
      public IntPtr \u0006;
      public uint \u0007;
      public uint \u0008;
      public uint \u000E;
      public ushort \u000F;
      public ushort \u0010;
    }
  }
}
