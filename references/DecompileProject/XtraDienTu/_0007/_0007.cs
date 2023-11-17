// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using System;
using System.Runtime.InteropServices;
using System.Text;
using XtraDienTu.KeyGen;

namespace \u0007
{
  internal class \u0007
  {
    private const uint \u0001 = 1;
    private const uint \u0002 = 475264;
    private const uint \u0003 = 508040;
    private const uint \u0004 = 508036;
    private const uint \u0005 = 1;
    private const uint \u0006 = 2;
    private const uint \u0007 = 2147483648;
    private const uint \u0008 = 1073741824;
    private const uint \u000E = 3;

    private static unsafe void \u0001(byte[] _param0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(6);
      try
      {
        *(int*) voidPtr = 0;
        while (true)
        {
          *(sbyte*) ((IntPtr) voidPtr + 5) = (sbyte) (*(int*) voidPtr < _param0.Length);
          if (*(sbyte*) ((IntPtr) voidPtr + 5) != (sbyte) 0)
          {
            *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) _param0[*(int*) voidPtr];
            _param0[*(int*) voidPtr] = _param0[*(int*) voidPtr + 1];
            _param0[*(int*) voidPtr + 1] = *(byte*) ((IntPtr) voidPtr + 4);
            *(int*) voidPtr = *(int*) voidPtr + 2;
          }
          else
            break;
        }
      }
      catch (Exception ex)
      {
        // ISSUE: variable of a boxed type
        __Boxed<int> local1 = (ValueType) *(int*) voidPtr;
        // ISSUE: variable of a boxed type
        __Boxed<byte> local2 = (ValueType) *(byte*) ((IntPtr) voidPtr + 4);
        // ISSUE: variable of a boxed type
        __Boxed<bool> local3 = (ValueType) (bool) *(sbyte*) ((IntPtr) voidPtr + 5);
        byte[] numArray = _param0;
        \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) local3, (object) numArray);
        throw;
      }
    }

    [DllImport("kernel32.dll", EntryPoint = "CloseHandle", SetLastError = true)]
    private static extern int \u0001(IntPtr _param0);

    [DllImport("kernel32.dll", EntryPoint = "CreateFile", SetLastError = true)]
    private static extern IntPtr \u0001(
      string _param0,
      uint _param1,
      uint _param2,
      IntPtr _param3,
      uint _param4,
      uint _param5,
      IntPtr _param6);

    [DllImport("kernel32.dll", EntryPoint = "DeviceIoControl")]
    private static extern int \u0001(
      IntPtr _param0,
      uint _param1,
      IntPtr _param2,
      uint _param3,
      ref \u0007.\u0006 _param4,
      uint _param5,
      ref uint _param6,
      [Out] IntPtr _param7);

    [DllImport("kernel32.dll", EntryPoint = "DeviceIoControl")]
    private static extern int \u0001(
      IntPtr _param0,
      uint _param1,
      ref \u0001.\u0005 _param2,
      uint _param3,
      ref \u0007.\u0004 _param4,
      uint _param5,
      ref uint _param6,
      [Out] IntPtr _param7);

    private static HDDSerial \u0001(\u0007.\u0005 _param0)
    {
      HDDSerial hddSerial1;
      HDDSerial hddSerial2;
      try
      {
        hddSerial1 = new HDDSerial();
        \u0007.\u0007.\u0001(_param0.\u0013);
label_1:
        hddSerial1.MDNumber = Encoding.ASCII.GetString(_param0.\u0013).Trim();
        \u0007.\u0007.\u0001(_param0.\u0012);
        hddSerial1.Firmware = Encoding.ASCII.GetString(_param0.\u0012).Trim();
        do
        {
          if (true)
          {
            \u0007.\u0007.\u0001(_param0.\u000E);
            if (true)
              hddSerial1.SerialNumber = Encoding.ASCII.GetString(_param0.\u000E).Trim();
            else
              goto label_1;
          }
          hddSerial1.Capacity = _param0.\u007F / 2U / 1024U;
          hddSerial2 = hddSerial1;
        }
        while (false);
        return hddSerial2;
      }
      catch (Exception ex)
      {
        // ISSUE: variable of a boxed type
        __Boxed<HDDSerial> local1 = (ValueType) hddSerial1;
        // ISSUE: variable of a boxed type
        __Boxed<HDDSerial> local2 = (ValueType) hddSerial2;
        // ISSUE: variable of a boxed type
        __Boxed<\u0007.\u0005> local3 = (ValueType) _param0;
        \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) local3);
        throw;
      }
    }

    public static HDDSerial \u0001(byte _param0)
    {
      HDDSerial hddSerial1;
      HDDSerial hddSerial2;
      PlatformID platform;
      try
      {
        if (false)
          goto label_8;
        else
          goto label_13;
label_5:
        int num1;
        hddSerial1 = \u0007.\u0007.\u0003((byte) num1);
        goto label_11;
label_8:
        num1 = 14436;
label_9:
        if (num1 != 0)
          throw new NotSupportedException(\u0005.\u0004.\u0001(num1));
        goto label_5;
label_11:
        hddSerial2 = hddSerial1;
label_12:
        if (true)
          goto label_16;
label_13:
        platform = Environment.OSVersion.Platform;
        switch (platform)
        {
          case PlatformID.Win32S:
            throw new NotSupportedException(\u0005.\u0004.\u0001(14370));
          case PlatformID.Win32Windows:
            if (true)
            {
              hddSerial1 = \u0007.\u0007.\u0002(_param0);
              goto label_11;
            }
            else
              goto label_12;
          case PlatformID.Win32NT:
            num1 = (int) _param0;
            goto label_5;
          case PlatformID.WinCE:
            int num2 = 14403;
            num1 = num2 == 0 ? num2 : throw new NotSupportedException(\u0005.\u0004.\u0001(num2));
            goto label_9;
          default:
            goto label_8;
        }
      }
      catch (Exception ex)
      {
        // ISSUE: variable of a boxed type
        __Boxed<HDDSerial> local1 = (ValueType) hddSerial1;
        // ISSUE: variable of a boxed type
        __Boxed<PlatformID> local2 = (Enum) platform;
        // ISSUE: variable of a boxed type
        __Boxed<byte> local3 = (ValueType) _param0;
        \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) local3);
        throw;
      }
label_16:
      return hddSerial2;
    }

    private static unsafe HDDSerial \u0002(byte _param0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(5);
      \u0007.\u0006 structure1;
      \u0001.\u0005 structure2;
      \u0007.\u0004 structure3;
      IntPtr num1;
      HDDSerial hddSerial1;
      HDDSerial hddSerial2;
      try
      {
        IntPtr num2;
        do
        {
          structure1 = new \u0007.\u0006();
          structure2 = new \u0001.\u0005();
          structure3 = new \u0007.\u0004();
          *(int*) voidPtr = 0;
          do
          {
            num2 = \u0007.\u0007.\u0001(\u0005.\u0004.\u0001(14461), 0U, 0U, IntPtr.Zero, 1U, 0U, IntPtr.Zero);
            if (true)
            {
              num1 = num2;
              *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) !(num1 == IntPtr.Zero);
              int num3;
              for (int index = (int) *(sbyte*) ((IntPtr) voidPtr + 4); index != 0; index = num3)
              {
                *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (0 != \u0007.\u0007.\u0001(num1, 475264U, IntPtr.Zero, 0U, ref structure1, (uint) Marshal.SizeOf((object) structure1), ref *(uint*) voidPtr, IntPtr.Zero));
                if (*(sbyte*) ((IntPtr) voidPtr + 4) == (sbyte) 0)
                {
                  if (true)
                  {
                    \u0007.\u0007.\u0001(num1);
                    num3 = 14515;
                    if (num3 != 0)
                      throw new Exception(\u0005.\u0004.\u0001(num3));
                    continue;
                  }
                }
                else
                {
                  *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (0 != ((int) structure1.\u0005 & 1));
                  if (*(sbyte*) ((IntPtr) voidPtr + 4) == (sbyte) 0)
                  {
                    \u0007.\u0007.\u0001(num1);
                    throw new Exception(\u0005.\u0004.\u0001(14568));
                  }
                  *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (0 == ((int) _param0 & 1));
                  if (*(sbyte*) ((IntPtr) voidPtr + 4) == (sbyte) 0)
                    goto label_13;
                }
                structure2.\u0002.\u0006 = (byte) 160;
                goto label_15;
              }
              if (true)
                throw new Exception(\u0005.\u0004.\u0001(14478));
label_13:
              structure2.\u0002.\u0006 = (byte) 176;
label_15:
              *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (0L == ((long) structure1.\u0005 & (long) (16 >> (int) _param0)));
              if (*(sbyte*) ((IntPtr) voidPtr + 4) == (sbyte) 0)
                \u0007.\u0007.\u0001(num1);
              else
                goto label_18;
            }
            else
              goto label_22;
          }
          while (false);
          throw new Exception(string.Format(\u0005.\u0004.\u0001(14625), (object) ((int) _param0 + 1)));
label_18:
          structure2.\u0002.\u0007 = (byte) 236;
          structure2.\u0003 = _param0;
        }
        while (false);
        structure2.\u0002.\u0002 = (byte) 1;
        structure2.\u0002.\u0003 = (byte) 1;
        structure2.\u0001 = 512U;
        *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (0 != \u0007.\u0007.\u0001(num1, 508040U, ref structure2, (uint) Marshal.SizeOf((object) structure2), ref structure3, (uint) Marshal.SizeOf((object) structure3), ref *(uint*) voidPtr, IntPtr.Zero));
        if (true)
        {
          if (*(sbyte*) ((IntPtr) voidPtr + 4) == (sbyte) 0)
          {
            num2 = num1;
          }
          else
          {
            do
            {
              \u0007.\u0007.\u0001(num1);
              hddSerial1 = \u0007.\u0007.\u0001(structure3.\u0003);
              hddSerial2 = hddSerial1;
            }
            while (false);
            goto label_27;
          }
        }
        else
          goto label_23;
label_22:
        \u0007.\u0007.\u0001(num2);
label_23:
        throw new Exception(\u0005.\u0004.\u0001(14690));
      }
      catch (Exception ex)
      {
        // ISSUE: variable of a boxed type
        __Boxed<\u0007.\u0006> local1 = (ValueType) structure1;
        // ISSUE: variable of a boxed type
        __Boxed<\u0001.\u0005> local2 = (ValueType) structure2;
        // ISSUE: variable of a boxed type
        __Boxed<\u0007.\u0004> local3 = (ValueType) structure3;
        // ISSUE: variable of a boxed type
        __Boxed<uint> local4 = (ValueType) *(uint*) voidPtr;
        // ISSUE: variable of a boxed type
        __Boxed<IntPtr> local5 = (ValueType) num1;
        // ISSUE: variable of a boxed type
        __Boxed<HDDSerial> local6 = (ValueType) hddSerial1;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local7 = (ValueType) (bool) *(sbyte*) ((IntPtr) voidPtr + 4);
        // ISSUE: variable of a boxed type
        __Boxed<byte> local8 = (ValueType) _param0;
        \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) local3, (object) local4, (object) local5, (object) local6, (object) local7, (object) local8);
        throw;
      }
label_27:
      return hddSerial2;
    }

    private static unsafe HDDSerial \u0003(byte _param0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(5);
      \u0007.\u0006 structure1;
      \u0001.\u0005 structure2;
      \u0007.\u0004 structure3;
      IntPtr num1;
      try
      {
        structure1 = new \u0007.\u0006();
        structure2 = new \u0001.\u0005();
        structure3 = new \u0007.\u0004();
        *(int*) voidPtr = 0;
        int num2;
        if (true)
        {
          num1 = \u0007.\u0007.\u0001(string.Format(\u0005.\u0004.\u0001(14755), (object) _param0), 3221225472U, 3U, IntPtr.Zero, 3U, 0U, IntPtr.Zero);
          *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) !(num1 == IntPtr.Zero);
          num2 = (int) *(sbyte*) ((IntPtr) voidPtr + 4);
        }
        else
          goto label_9;
label_3:
        if (num2 == 0)
          throw new Exception(\u0005.\u0004.\u0001(14784));
        *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (0 != \u0007.\u0007.\u0001(num1, 475264U, IntPtr.Zero, 0U, ref structure1, (uint) Marshal.SizeOf((object) structure1), ref *(uint*) voidPtr, IntPtr.Zero));
        if (*(sbyte*) ((IntPtr) voidPtr + 4) == (sbyte) 0)
        {
          \u0007.\u0007.\u0001(num1);
          throw new Exception(string.Format(\u0005.\u0004.\u0001(14809), (object) ((int) _param0 + 1)));
        }
        *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (0 != ((int) structure1.\u0005 & 1));
        if (*(sbyte*) ((IntPtr) voidPtr + 4) == (sbyte) 0)
          \u0007.\u0007.\u0001(num1);
        else
          goto label_12;
label_9:
        int num3;
        if (true)
          num3 = 14568;
        else
          goto label_12;
label_11:
        throw new Exception(\u0005.\u0004.\u0001(num3));
label_12:
        *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (0 == ((int) _param0 & 1));
        structure2.\u0002.\u0006 = *(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0 ? (byte) 160 : (byte) 176;
        *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (0L == ((long) structure1.\u0005 & (long) (16 >> (int) _param0)));
        if (*(sbyte*) ((IntPtr) voidPtr + 4) == (sbyte) 0)
        {
          \u0007.\u0007.\u0001(num1);
          num2 = 14846;
          if (num2 != 0)
            throw new Exception(string.Format(\u0005.\u0004.\u0001(num2), (object) ((int) _param0 + 1)));
          goto label_3;
        }
        else
        {
          structure2.\u0002.\u0007 = (byte) 236;
          structure2.\u0003 = _param0;
          structure2.\u0002.\u0002 = (byte) 1;
          structure2.\u0002.\u0003 = (byte) 1;
          structure2.\u0001 = 512U;
          *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (0 != \u0007.\u0007.\u0001(num1, 508040U, ref structure2, (uint) Marshal.SizeOf((object) structure2), ref structure3, (uint) Marshal.SizeOf((object) structure3), ref *(uint*) voidPtr, IntPtr.Zero));
          if (*(sbyte*) ((IntPtr) voidPtr + 4) == (sbyte) 0)
          {
            \u0007.\u0007.\u0001(num1);
            throw new Exception(\u0005.\u0004.\u0001(14690));
          }
          num3 = \u0007.\u0007.\u0001(num1);
          if (true)
            return \u0007.\u0007.\u0001(structure3.\u0003);
          goto label_11;
        }
      }
      catch (Exception ex)
      {
        // ISSUE: variable of a boxed type
        __Boxed<\u0007.\u0006> local1 = (ValueType) structure1;
        // ISSUE: variable of a boxed type
        __Boxed<\u0001.\u0005> local2 = (ValueType) structure2;
        // ISSUE: variable of a boxed type
        __Boxed<\u0007.\u0004> local3 = (ValueType) structure3;
        // ISSUE: variable of a boxed type
        __Boxed<uint> local4 = (ValueType) *(uint*) voidPtr;
        // ISSUE: variable of a boxed type
        __Boxed<IntPtr> local5 = (ValueType) num1;
        HDDSerial hddSerial;
        // ISSUE: variable of a boxed type
        __Boxed<HDDSerial> local6 = (ValueType) hddSerial;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local7 = (ValueType) (bool) *(sbyte*) ((IntPtr) voidPtr + 4);
        // ISSUE: variable of a boxed type
        __Boxed<byte> local8 = (ValueType) _param0;
        \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) local3, (object) local4, (object) local5, (object) local6, (object) local7, (object) local8);
        throw;
      }
    }
  }
}
