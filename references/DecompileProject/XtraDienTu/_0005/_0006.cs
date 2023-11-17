// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using \u0007;
using System;
using System.Net;
using System.Text;
using System.Threading;

namespace \u0005
{
  internal class \u0006
  {
    protected const string \u0001 = "{100fd8cd-4fe2-410e-8c33-ae1af08ef31d}";
    private const string \u0002 = "{be78a0c5-c47c-4127-a428-52bdc580a02f}";
    private const string \u0003 = "{bf13b64c-b3d2-4165-b3f5-7f852d4744cf}";
    private IWebProxy \u0004;
    private \u0005.\u0007 \u0005;

    public void \u0001(IWebProxy _param1) => this.\u0004 = _param1;

    internal bool \u0001(byte[] _param1, \u0006.\u0003 _param2)
    {
      byte[] numArray;
      bool flag;
      try
      {
        numArray = \u000E.\u0003.\u0002(_param1);
        goto label_7;
      }
      catch (Exception ex)
      {
        this.\u0001(\u000E.\u0007.\u0001, \u000E.\u0003.\u0001);
        flag = false;
      }
label_6:
      return flag;
label_7:
      byte[] encryptedData = \u0007.\u000F.\u0001(numArray, \u0005.\u0004.\u0001(15576));
      if (encryptedData != null)
      {
        if (true)
        {
          this.\u0001(\u000E.\u0007.\u0002);
          \u0003.\u0006 services = new \u0003.\u0006(\u0005.\u0004.\u0001(15902));
          if (this.\u0004 != null)
            services.\u0001(this.\u0004);
          \u0006.\u0001 obj = new \u0006.\u0001(this, encryptedData, services, _param2);
          services.\u0001(new \u0003.\u0004(obj.\u0001));
          return obj.\u0005;
        }
        goto label_6;
      }
      else
      {
        this.\u0001(\u000E.\u0007.\u0001, \u0007.\u000F.\u0001);
        return false;
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
            obj1 = this.\u0005;
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
        obj1 = Interlocked.CompareExchange<\u0005.\u0007>(ref this.\u0005, comparand + value, comparand);
        goto label_4;
      }
      remove
      {
        \u0005.\u0007 obj1;
        if (true)
        {
          if (true)
            obj1 = this.\u0005;
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
        obj1 = Interlocked.CompareExchange<\u0005.\u0007>(ref this.\u0005, comparand - value, comparand);
        goto label_4;
      }
    }

    protected void \u0001(\u000E.\u0007 _param1, string _param2, string _param3)
    {
      \u0005.\u0007 obj1 = this.\u0005;
      \u0005.\u0007 obj2;
      if (true)
        obj2 = obj1;
      if (obj2 == null)
        return;
      obj2((object) this, new \u0010(_param1, _param2, _param3));
    }

    protected void \u0001(\u000E.\u0007 _param1, string _param2) => this.\u0001(_param1, _param2, string.Empty);

    protected void \u0001(\u000E.\u0007 _param1) => this.\u0001(_param1, string.Empty);

    private class \u0001
    {
      private readonly \u0006 \u0001;
      private readonly byte[] \u0002;
      private readonly \u0003.\u0006 \u0003;
      private readonly \u0006.\u0003 \u0004;
      public bool \u0005 = true;

      public \u0001(
        \u0006 reportSender,
        byte[] encryptedData,
        \u0003.\u0006 services,
        \u0006.\u0003 notificationEmailSettings)
      {
        this.\u0001 = reportSender;
        this.\u0004 = notificationEmailSettings;
        this.\u0003 = services;
        this.\u0002 = encryptedData;
      }

      public void \u0001(string _param1)
      {
        if (!(_param1 == \u0005.\u0004.\u0001(4547)))
        {
          string errorMessage = _param1;
          if (this.\u0001.\u0005 != null)
            this.\u0001.\u0005((object) this, new \u0010(\u000E.\u0007.\u0002, errorMessage));
          this.\u0005 = false;
        }
        else
        {
          this.\u0001.\u0001(\u000E.\u0007.\u0003);
          byte[] bytes = Encoding.UTF8.GetBytes(\u0005.\u0004.\u0001(15951));
          byte[] destinationArray = new byte[bytes.Length + this.\u0002.Length];
          Array.Copy((Array) bytes, (Array) destinationArray, bytes.Length);
          Array.Copy((Array) this.\u0002, 0, (Array) destinationArray, bytes.Length, this.\u0002.Length);
          \u0006.\u0002 obj = new \u0006.\u0002(this.\u0001);
          this.\u0003.\u0001(destinationArray, this.\u0004.EmailAddress, this.\u0004.AppFriendlyName, this.\u0004.BuildFriendlyNumber, new \u0003.\u0004(obj.\u0001));
          this.\u0005 = obj.\u0002;
        }
      }
    }

    private class \u0002
    {
      private readonly \u0006 \u0001;
      public bool \u0002;

      public \u0002(\u0006 reportSender) => this.\u0001 = reportSender;

      public void \u0001(string _param1)
      {
        if (_param1.StartsWith(\u0005.\u0004.\u0001(16004)))
        {
          this.\u0001.\u0001(\u000E.\u0007.\u0003, _param1);
          this.\u0002 = false;
        }
        else
        {
          this.\u0001.\u0001(\u000E.\u0007.\u0004, string.Empty, _param1);
          if (false)
            return;
          this.\u0002 = true;
        }
      }
    }

    internal class \u0003
    {
      public static \u0006.\u0003 \u0001 = new \u0006.\u0003((string) null, (string) null, (string) null);
      private readonly string \u0002;
      private readonly string \u0003;
      private readonly string \u0004;

      public \u0003(string emailAddress, string appFriendlyName, string buildFriendlyNumber)
      {
        this.\u0002 = emailAddress;
        this.\u0004 = buildFriendlyNumber;
        this.\u0003 = appFriendlyName;
      }

      public string BuildFriendlyNumber => this.\u0004;

      public string AppFriendlyName => this.\u0003;

      public string EmailAddress => this.\u0002;
    }
  }
}
