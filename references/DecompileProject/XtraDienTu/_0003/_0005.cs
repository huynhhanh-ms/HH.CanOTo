// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using System;
using System.Net;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Web.Services.Protocols;
using System.Windows.Forms;

namespace \u0003
{
  internal abstract class \u0005
  {
    public const string \u0001 = "{1fe9e38e-05cc-46a3-ae48-6cda8fb62056}";
    public const string \u0002 = "{395edd3b-130e-4160-bb08-6931086cea46}";
    private static readonly bool \u0003 = Convert.ToBoolean(\u0005.\u0004.\u0001(18300));
    private static readonly string \u0004 = \u0005.\u0004.\u0001(16178);
    private static \u0003.\u0005 \u0005;
    private IWebProxy \u0006;
    private EventHandler \u0007;
    private \u0005.\u0007 \u0008;

    public event EventHandler DebuggerLaunched
    {
      add
      {
        EventHandler eventHandler1;
        if (true)
        {
          if (true)
            eventHandler1 = this.\u0007;
        }
        else
          goto label_5;
label_2:
        EventHandler comparand;
        if (true)
        {
          EventHandler eventHandler2 = eventHandler1;
          if (true)
          {
            comparand = eventHandler2;
            goto label_9;
          }
          else
            goto label_9;
        }
label_4:
        if (eventHandler1 != comparand)
          goto label_2;
label_5:
        if (true)
          return;
label_9:
        eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.\u0007, comparand + value, comparand);
        goto label_4;
      }
      remove
      {
        EventHandler eventHandler1;
        if (true)
        {
          if (true)
            eventHandler1 = this.\u0007;
        }
        else
          goto label_5;
label_2:
        EventHandler comparand;
        if (true)
        {
          EventHandler eventHandler2 = eventHandler1;
          if (true)
          {
            comparand = eventHandler2;
            goto label_9;
          }
          else
            goto label_9;
        }
label_4:
        if (eventHandler1 != comparand)
          goto label_2;
label_5:
        if (true)
          return;
label_9:
        eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.\u0007, comparand - value, comparand);
        goto label_4;
      }
    }

    public event \u0005.\u0007 SendingReportFeedback
    {
      add
      {
        \u0005.\u0007 obj1;
        if (true)
        {
          if (true)
            obj1 = this.\u0008;
        }
        else
          goto label_5;
label_2:
        \u0005.\u0007 comparand;
        if (true)
        {
          \u0005.\u0007 obj2 = obj1;
          if (true)
          {
            comparand = obj2;
            goto label_9;
          }
          else
            goto label_9;
        }
label_4:
        if (obj1 != comparand)
          goto label_2;
label_5:
        if (true)
          return;
label_9:
        obj1 = Interlocked.CompareExchange<\u0005.\u0007>(ref this.\u0008, comparand + value, comparand);
        goto label_4;
      }
      remove
      {
        \u0005.\u0007 obj1;
        if (true)
        {
          if (true)
            obj1 = this.\u0008;
        }
        else
          goto label_5;
label_2:
        \u0005.\u0007 comparand;
        if (true)
        {
          \u0005.\u0007 obj2 = obj1;
          if (true)
          {
            comparand = obj2;
            goto label_9;
          }
          else
            goto label_9;
        }
label_4:
        if (obj1 != comparand)
          goto label_2;
label_5:
        if (true)
          return;
label_9:
        obj1 = Interlocked.CompareExchange<\u0005.\u0007>(ref this.\u0008, comparand - value, comparand);
        goto label_4;
      }
    }

    protected abstract void \u0001(\u0004.\u000E _param1);

    protected abstract void \u0001(\u0001.\u0007 _param1);

    protected abstract void \u0001(\u0006.\u0002 _param1);

    [SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
    public static void \u0001(\u0003.\u0005 _param0)
    {
      if (_param0 == null)
        return;
      if (true)
        \u0003.\u0005.\u0005 = _param0;
      // ISSUE: method pointer
      AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler((object) _param0, __methodptr(\u0001));
      // ISSUE: method pointer
      Application.ThreadException += new ThreadExceptionEventHandler((object) _param0, __methodptr(\u0001));
    }

    private static \u0003.\u0005 Handler
    {
      get
      {
        if (\u0003.\u0005.\u0005 == null)
          goto label_16;
label_15:
        return \u0003.\u0005.\u0005;
label_16:
        Type[] types = Assembly.GetExecutingAssembly().GetTypes();
        if (true)
          goto label_17;
label_1:
        int index = 0;
        Type[] typeArray;
        while (true)
        {
          int num1 = index;
          int num2;
          while (true)
          {
            int num3 = typeArray.Length;
            if (true)
              goto label_14;
label_10:
            num2 = num1 + num3;
            if (false)
            {
              num1 = num2;
              continue;
            }
            break;
label_14:
            if (num1 < num3)
            {
              Type type = typeArray[index];
              if ((object) type != null && (object) type.BaseType != null)
              {
                if ((object) type.BaseType == (object) typeof (\u0003.\u0005))
                {
                  try
                  {
                    if (true)
                      \u0003.\u0005.\u0005 = (\u0003.\u0005) Activator.CreateInstance(type, true);
                    else
                      goto label_6;
label_5:
                    if (\u0003.\u0005.\u0005 == null)
                      goto label_9;
label_6:
                    if (false)
                      goto label_5;
                    else
                      goto label_15;
                  }
                  catch
                  {
                  }
                }
              }
label_9:
              int num4 = index;
              num3 = 1;
              num1 = num4;
              goto label_10;
            }
            else
              goto label_15;
          }
          index = num2;
        }
label_17:
        typeArray = types;
        goto label_1;
      }
    }

    public static void \u0001(Exception _param0, object[] _param1)
    {
label_0:
      if (_param0 == null)
        goto label_4;
      else
        goto label_8;
label_1:
      if (\u0003.\u0005.\u0004 == \u0005.\u0004.\u0001(16178))
      {
        if (true)
        {
          if (\u0003.\u0005.Handler.\u0001((SecurityException) _param0))
            return;
        }
        else
          goto label_0;
      }
label_4:
      while (true)
      {
        \u0005.\u0008.\u0001(_param0, _param1);
        if (true)
        {
          \u0003.\u0005.Handler.\u0001(_param0, false, false);
          if (true)
          {
            if (true)
              return;
            goto label_0;
          }
        }
        else
          goto label_8;
      }
      goto label_1;
label_8:
      if (!(_param0 is SecurityException))
        goto label_4;
      else
        goto label_1;
    }

    public static Exception \u0001(Exception _param0, object[] _param1)
    {
      try
      {
        if ((object) _param0.GetType() != (object) typeof (Exception) || !(_param0.Message == \u0005.\u0004.\u0001(18071)))
          \u0005.\u0008.\u0001(_param0, _param1);
        else
          goto label_3;
label_2:
        \u0003.\u0005.Handler.\u0001(_param0, true, false);
        goto label_5;
label_3:
        _param0 = _param0.InnerException;
        goto label_2;
      }
      catch
      {
      }
label_5:
      return (Exception) new SoapException(_param0.Message, SoapException.ServerFaultCode);
    }

    public static void \u0002(Exception _param0, object[] _param1)
    {
      try
      {
        if ((object) _param0.GetType() != (object) typeof (Exception) || !(_param0.Message == \u0005.\u0004.\u0001(18071)))
          \u0005.\u0008.\u0001(_param0, _param1);
        else
          goto label_3;
label_2:
        \u0003.\u0005.Handler.\u0001(_param0, true, true);
        return;
label_3:
        _param0 = _param0.InnerException;
        goto label_2;
      }
      catch
      {
      }
    }

    private void \u0001(object _param1, ThreadExceptionEventArgs _param2)
    {
      try
      {
        Exception exception;
        if (true)
          exception = _param2.Exception;
        Type type = exception.GetType();
        if (type.Name == \u0005.\u0004.\u0001(18084) && type.Namespace == \u0005.\u0004.\u0001(18109))
          exception = (Exception) type.GetField(\u0005.\u0004.\u0001(18154)).GetValue((object) exception);
        if (exception is SecurityException && \u0003.\u0005.\u0004 == \u0005.\u0004.\u0001(16178) && this.\u0001(exception as SecurityException))
          return;
        this.\u0001(exception, true, false);
      }
      catch
      {
      }
    }

    private void \u0001(object _param1, UnhandledExceptionEventArgs _param2)
    {
label_0:
      try
      {
        int num;
        if (_param2.ExceptionObject is SecurityException)
        {
          num = \u0003.\u0005.\u0004 == \u0005.\u0004.\u0001(16178) ? 1 : 0;
          if (true)
          {
            if (num == 0)
              goto label_6;
          }
          else
            goto label_4;
        }
        else
          goto label_6;
label_3:
        if (true)
          num = this.\u0001(_param2.ExceptionObject as SecurityException) ? 1 : 0;
        else
          goto label_0;
label_4:
        if (num != 0)
          return;
label_6:
        if (true)
        {
          if (true)
          {
            if (!(_param2.ExceptionObject is Exception))
              return;
          }
          else
            goto label_3;
        }
        this.\u0001((Exception) _param2.ExceptionObject, !_param2.IsTerminating, false);
      }
      catch
      {
      }
    }

    public void \u0001(IWebProxy _param1) => this.\u0006 = _param1;

    protected virtual Guid \u0001() => Guid.Empty;

    private bool \u0001(SecurityException _param1)
    {
      \u0006.\u0002 obj = new \u0006.\u0002(_param1);
      int num1;
      do
      {
        this.\u0001(obj);
        num1 = obj.ReportException ? 1 : 0;
        if (true)
        {
          if (num1 != 0)
            goto label_4;
        }
        else
          goto label_5;
      }
      while (false);
      goto label_12;
label_5:
      return num1 != 0;
label_4:
      int num2 = 0;
      return num2 != 0 ? num2 != 0 : num2 != 0;
label_12:
      int num3 = obj.TryToContinue ? 1 : 0;
      if (false)
        return num3 != 0;
      if (num3 == 0)
        Application.Exit();
      return true;
    }

    private unsafe void \u0001(Exception _param1, bool _param2, bool _param3)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(5);
      Type type = _param1.GetType();
      if (type.Name == \u0005.\u0004.\u0001(18084) && type.Namespace == \u0005.\u0004.\u0001(18109))
        _param1 = (Exception) type.GetField(\u0005.\u0004.\u0001(18154)).GetValue((object) _param1);
      *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) 1;
      if (_param1 == null)
        return;
      if (_param1 is ThreadAbortException)
        return;
      try
      {
        \u000E.\u0004 reportSender = new \u000E.\u0004(this.\u0001(), _param1, this.\u0006);
        reportSender.SendingReportFeedback += new \u0005.\u0007(this.\u0001);
        reportSender.DebuggerLaunched += new EventHandler(this.\u0001);
        reportSender.FatalException += new \u000E.\u0005(this.\u0001);
        \u0004.\u000E obj = new \u0004.\u000E(reportSender, _param1);
        if (\u000E.\u0001.\u0001() != null)
          obj.\u0001();
        if (!_param2)
        {
          obj.\u0001(false);
          obj.TryToContinue = false;
        }
        else
        {
          int num = _param3 ? 1 : 0;
          if (true)
          {
            if (num == 0)
              num = \u0003.\u0005.\u0003 ? 1 : 0;
            else
              goto label_13;
          }
          if (num == 0)
            goto label_14;
label_13:
          obj.\u0001(false);
          obj.TryToContinue = true;
        }
label_14:
        this.\u0001(obj);
        *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) !obj.TryToContinue;
      }
      catch (ThreadAbortException ex)
      {
      }
      catch (Exception ex)
      {
        this.\u0001(new \u0001.\u0007(ex));
      }
      if (*(sbyte*) ((IntPtr) voidPtr + 4) == (sbyte) 0)
        return;
      Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
      *(int*) voidPtr = 0;
      if (false)
        return;
      while (*(int*) voidPtr < assemblies.Length)
      {
        Assembly assembly = assemblies[*(int*) voidPtr];
        try
        {
          string fullName = assembly.FullName;
          if (fullName.EndsWith(\u0005.\u0004.\u0001(18179)))
          {
            if (fullName.StartsWith(\u0005.\u0004.\u0001(18204)))
            {
              object obj = assembly.GetType(\u0005.\u0004.\u0001(18237)).GetProperty(\u0005.\u0004.\u0001(18274)).GetGetMethod().Invoke((object) null, (object[]) null);
              obj.GetType().GetMethod(\u0005.\u0004.\u0001(18287), new Type[0]).Invoke(obj, (object[]) null);
            }
          }
        }
        catch
        {
        }
        *(int*) voidPtr = *(int*) voidPtr + 1;
      }
      try
      {
        Environment.ExitCode = -532462766;
        Application.Exit();
      }
      catch
      {
        try
        {
          Environment.Exit(-532462766);
        }
        catch
        {
        }
      }
    }

    private void \u0001(object _param1, \u0001.\u0007 _param2) => this.\u0001(_param2);

    private void \u0001(object _param1, EventArgs _param2)
    {
      EventHandler eventHandler = this.\u0007;
      if (eventHandler == null)
        return;
      eventHandler(_param1, _param2);
    }

    private void \u0001(object _param1, \u0007.\u0010 _param2)
    {
      \u0005.\u0007 obj = this.\u0008;
      if (obj == null)
        return;
      obj(_param1, _param2);
    }
  }
}
