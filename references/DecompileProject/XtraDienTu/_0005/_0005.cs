// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace \u0005
{
  internal sealed class \u0005 : IDisposable
  {
    private readonly Type \u0001;
    private readonly object \u0002;

    public \u0005()
    {
      Assembly assembly1;
      try
      {
        try
        {
          assembly1 = Assembly.Load("System.Core, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e");
          this.\u0001 = assembly1.GetType("System.Security.Cryptography.AesManaged");
        }
        catch (FileNotFoundException ex)
        {
          assembly1 = Assembly.Load("mscorlib");
          this.\u0001 = assembly1.GetType("System.Security.Cryptography.RijndaelManaged");
        }
        this.\u0002 = Activator.CreateInstance(this.\u0001);
      }
      catch (Exception ex)
      {
        Assembly assembly2 = assembly1;
        \u0008.\u0001(ex, (object) assembly2, (object) this);
        throw;
      }
    }

    public ICryptoTransform \u0001(byte[] _param1, byte[] _param2, bool _param3)
    {
      object[] objArray1;
      MethodInfo method;
      try
      {
        MethodInfo setMethod1 = this.\u0001.GetProperty("Key").GetSetMethod();
        object obj1 = this.\u0002;
        objArray1 = new object[1]{ (object) _param1 };
        object[] parameters1 = objArray1;
        setMethod1.Invoke(obj1, parameters1);
        MethodInfo setMethod2 = this.\u0001.GetProperty("IV").GetSetMethod();
        object obj2 = this.\u0002;
        objArray1 = new object[1]{ (object) _param2 };
        object[] parameters2 = objArray1;
        setMethod2.Invoke(obj2, parameters2);
        method = this.\u0001.GetMethod(_param3 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
        return (ICryptoTransform) method.Invoke(this.\u0002, new object[0]);
      }
      catch (Exception ex)
      {
        MethodInfo methodInfo = method;
        object[] objArray2 = objArray1;
        byte[] numArray1 = _param1;
        byte[] numArray2 = _param2;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (ValueType) _param3;
        \u0008.\u0001(ex, (object) methodInfo, (object) objArray2, (object) this, (object) numArray1, (object) numArray2, (object) local);
        throw;
      }
    }

    public void \u0001()
    {
      try
      {
        this.\u0001.GetMethod("Clear").Invoke(this.\u0002, new object[0]);
      }
      catch (Exception ex)
      {
        \u0008.\u0001(ex, (object) this);
        throw;
      }
    }

    public void \u0002()
    {
      try
      {
        this.\u0001();
      }
      catch (Exception ex)
      {
        \u0008.\u0001(ex, (object) this);
        throw;
      }
    }
  }
}
