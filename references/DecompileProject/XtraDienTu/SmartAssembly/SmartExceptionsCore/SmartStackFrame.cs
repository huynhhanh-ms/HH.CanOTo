// Decompiled with JetBrains decompiler
// Type: SmartAssembly.SmartExceptionsCore.SmartStackFrame
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using \u0005;
using System;
using System.Runtime.Serialization;

namespace SmartAssembly.SmartExceptionsCore
{
  [Serializable]
  public class SmartStackFrame : ISerializable
  {
    public readonly int MethodID;
    public readonly object[] Objects;
    public readonly int ILOffset;
    public readonly int ExceptionStackDepth;

    public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      info.AddValue(\u0004.\u0001(17439), (object) this.MethodID, typeof (int));
      info.AddValue(\u0004.\u0001(17476), (object) this.ILOffset, typeof (int));
      info.AddValue(\u0004.\u0001(17513), (object) this.ExceptionStackDepth, typeof (int));
      int num1;
      if (this.Objects != null)
      {
        num1 = this.Objects.Length;
        goto label_4;
      }
label_2:
      if (true)
        num1 = 0;
      else
        goto label_14;
label_4:
      int num2 = num1;
      int index;
      if (true)
      {
        info.AddValue(\u0004.\u0001(17566), (object) num2, typeof (int));
        index = 0;
        goto label_17;
      }
      else
        goto label_2;
label_14:
      int num3 = index;
      int num4 = 1;
label_15:
      if (num4 != 0)
        index = num3 + num4;
      else
        goto label_18;
label_17:
      int num5 = index;
      num4 = num2;
      num3 = num5;
label_18:
      if (true)
      {
        if (num3 >= num4)
          return;
        string name = string.Format(\u0004.\u0001(17611), (object) index);
        try
        {
          while (this.Objects[index] != null)
          {
            if (true)
            {
              if (true)
              {
                info.AddValue(name, (object) (this.Objects[index].GetType().ToString() + \u0004.\u0001(15091) + this.Objects[index]), typeof (string));
                goto label_14;
              }
              else
                break;
            }
          }
          info.AddValue(name, (object) null, typeof (object));
          goto label_14;
        }
        catch (Exception ex)
        {
          goto label_14;
        }
      }
      else
        goto label_15;
    }

    internal SmartStackFrame(SerializationInfo info, StreamingContext context)
    {
      this.MethodID = info.GetInt32(\u0004.\u0001(17439));
      this.ILOffset = info.GetInt32(\u0004.\u0001(17476));
      this.ExceptionStackDepth = info.GetInt32(\u0004.\u0001(17513));
      int int32 = info.GetInt32(\u0004.\u0001(17566));
      this.Objects = new object[int32];
      for (int index = 0; index < int32; ++index)
      {
        try
        {
          this.Objects[index] = info.GetValue(string.Format(\u0004.\u0001(17611), (object) index), typeof (string));
        }
        catch (Exception ex)
        {
          this.Objects[index] = (object) \u0004.\u0001(17656);
        }
      }
    }

    internal SmartStackFrame(
      int methodID,
      object[] objects,
      int ilOffset,
      int exceptionStackDepth)
    {
      this.MethodID = methodID;
      this.ExceptionStackDepth = exceptionStackDepth;
      this.ILOffset = ilOffset;
      this.Objects = objects;
    }
  }
}
