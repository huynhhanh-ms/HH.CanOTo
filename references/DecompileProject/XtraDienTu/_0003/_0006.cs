// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using SmartAssembly.SmartExceptionsCore;
using System;
using System.Net;

namespace \u0003
{
  internal class \u0006
  {
    internal static readonly string \u0001 = \u0005.\u0004.\u0001(18485);
    private string \u0002;
    private string \u0003;
    private IWebProxy \u0004;

    public void \u0001(IWebProxy _param1) => this.\u0004 = _param1;

    public void \u0001(\u0003.\u0004 _param1)
    {
      if (this.\u0003 == null)
      {
        try
        {
          UploadReportLoginService reportLoginService1 = new UploadReportLoginService();
          do
          {
            if (this.\u0004 != null)
            {
              UploadReportLoginService reportLoginService2 = reportLoginService1;
              IWebProxy webProxy = this.\u0004;
              if (true)
                reportLoginService2.Proxy = webProxy;
            }
            this.\u0003 = reportLoginService1.GetServerURL(this.\u0002);
            if (this.\u0003.Length != 0)
            {
              if (!(this.\u0003 == \u0005.\u0004.\u0001(18442)))
                goto label_11;
            }
            else
              goto label_2;
          }
          while (false);
          goto label_5;
label_2:
          throw new ApplicationException(\u0005.\u0004.\u0001(18401));
label_5:
          this.\u0003 = \u0006.\u0001;
        }
        catch (Exception ex)
        {
          _param1(\u0005.\u0004.\u0001(18451) + ex.Message);
          return;
        }
      }
label_11:
      _param1(this.\u0003.StartsWith(\u0005.\u0004.\u0001(16004)) ? this.\u0003 : \u0005.\u0004.\u0001(4547));
    }

    public void \u0001(
      byte[] _param1,
      string _param2,
      string _param3,
      string _param4,
      \u0003.\u0004 _param5)
    {
      try
      {
        ReportingService reportingService1 = new ReportingService(this.\u0003);
        while (this.\u0004 != null)
        {
          if (true)
          {
            ReportingService reportingService2 = reportingService1;
            IWebProxy webProxy = this.\u0004;
            if (true)
            {
              reportingService2.Proxy = webProxy;
              break;
            }
            break;
          }
        }
        _param5(reportingService1.UploadReport2(this.\u0002, _param1, _param2, _param3, _param4));
      }
      catch (Exception ex)
      {
        _param5(\u0005.\u0004.\u0001(18468) + ex.Message);
      }
    }

    public \u0006(string licenseID) => this.\u0002 = licenseID;
  }
}
