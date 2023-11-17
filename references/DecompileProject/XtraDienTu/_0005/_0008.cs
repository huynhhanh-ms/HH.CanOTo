// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using SmartAssembly.SmartExceptionsCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace \u0005
{
  internal class \u0008
  {
    public const string \u0001 = "SmartStackFrames";

    public static void \u0001(Exception _param0) => \u0008.\u0001(_param0, new object[0]);

    public static void \u0001(Exception _param0, object _param1)
    {
      do
      {
        if (true)
          goto label_3;
label_2:
        continue;
label_3:
        \u0008.\u0001(_param0, new object[1]{ _param1 });
        goto label_2;
      }
      while (false);
    }

    public static void \u0001(Exception _param0, object _param1, object _param2) => \u0008.\u0001(_param0, new object[2]
    {
      _param1,
      _param2
    });

    public static void \u0001(Exception _param0, object _param1, object _param2, object _param3)
    {
      do
      {
        if (true)
          goto label_3;
label_2:
        continue;
label_3:
        \u0008.\u0001(_param0, new object[3]
        {
          _param1,
          _param2,
          _param3
        });
        goto label_2;
      }
      while (false);
    }

    public static void \u0001(
      Exception _param0,
      object _param1,
      object _param2,
      object _param3,
      object _param4)
    {
      \u0008.\u0001(_param0, new object[4]
      {
        _param1,
        _param2,
        _param3,
        _param4
      });
    }

    public static void \u0001(
      Exception _param0,
      object _param1,
      object _param2,
      object _param3,
      object _param4,
      object _param5)
    {
      \u0008.\u0001(_param0, new object[5]
      {
        _param1,
        _param2,
        _param3,
        _param4,
        _param5
      });
    }

    public static void \u0001(
      Exception _param0,
      object _param1,
      object _param2,
      object _param3,
      object _param4,
      object _param5,
      object _param6)
    {
      \u0008.\u0001(_param0, new object[6]
      {
        _param1,
        _param2,
        _param3,
        _param4,
        _param5,
        _param6
      });
    }

    public static void \u0001(
      Exception _param0,
      object _param1,
      object _param2,
      object _param3,
      object _param4,
      object _param5,
      object _param6,
      object _param7)
    {
      if (false)
        return;
      \u0008.\u0001(_param0, new object[7]
      {
        _param1,
        _param2,
        _param3,
        _param4,
        _param5,
        _param6,
        _param7
      });
    }

    public static void \u0001(
      Exception _param0,
      object _param1,
      object _param2,
      object _param3,
      object _param4,
      object _param5,
      object _param6,
      object _param7,
      object _param8)
    {
      \u0008.\u0001(_param0, new object[8]
      {
        _param1,
        _param2,
        _param3,
        _param4,
        _param5,
        _param6,
        _param7,
        _param8
      });
    }

    public static void \u0001(
      Exception _param0,
      object _param1,
      object _param2,
      object _param3,
      object _param4,
      object _param5,
      object _param6,
      object _param7,
      object _param8,
      object _param9)
    {
      \u0008.\u0001(_param0, new object[9]
      {
        _param1,
        _param2,
        _param3,
        _param4,
        _param5,
        _param6,
        _param7,
        _param8,
        _param9
      });
    }

    public static void \u0001(
      Exception _param0,
      object _param1,
      object _param2,
      object _param3,
      object _param4,
      object _param5,
      object _param6,
      object _param7,
      object _param8,
      object _param9,
      object _param10)
    {
      \u0008.\u0001(_param0, new object[10]
      {
        _param1,
        _param2,
        _param3,
        _param4,
        _param5,
        _param6,
        _param7,
        _param8,
        _param9,
        _param10
      });
    }

    public static unsafe void \u0001(Exception _param0, object[] _param1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(16);
      *(int*) voidPtr = -1;
      *(int*) ((IntPtr) voidPtr + 4) = -1;
      *(int*) ((IntPtr) voidPtr + 8) = 0;
      StackTrace stackTrace = new StackTrace(_param0);
      try
      {
        if (_param0.StackTrace != null)
        {
          string[] strArray = _param0.StackTrace.Split('\r', '\n');
          *(int*) ((IntPtr) voidPtr + 12) = 0;
          while (*(int*) ((IntPtr) voidPtr + 12) < strArray.Length)
          {
            if (strArray[*(int*) ((IntPtr) voidPtr + 12)].Length > 0)
              *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) + 1;
            *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + 1;
          }
        }
      }
      catch
      {
        *(int*) ((IntPtr) voidPtr + 8) = -1;
      }
      try
      {
        if (stackTrace.FrameCount > 0)
        {
          StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
          *(int*) voidPtr = (frame.GetMethod().MetadataToken & 16777215) - 1;
          *(int*) ((IntPtr) voidPtr + 4) = frame.GetILOffset();
        }
      }
      catch
      {
      }
      try
      {
        SmartStackFrame smartStackFrame = new SmartStackFrame(*(int*) voidPtr, _param1, *(int*) ((IntPtr) voidPtr + 4), *(int*) ((IntPtr) voidPtr + 8));
        LinkedList<object> linkedList;
        if (!_param0.Data.Contains((object) \u0004.\u0001(16832)))
        {
          linkedList = new LinkedList<object>();
          _param0.Data[(object) \u0004.\u0001(16832)] = (object) linkedList;
        }
        else
          linkedList = (LinkedList<object>) _param0.Data[(object) \u0004.\u0001(16832)];
        linkedList.AddLast((object) smartStackFrame);
      }
      catch
      {
      }
    }
  }
}
