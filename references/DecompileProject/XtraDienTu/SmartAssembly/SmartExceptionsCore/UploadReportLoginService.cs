// Decompiled with JetBrains decompiler
// Type: SmartAssembly.SmartExceptionsCore.UploadReportLoginService
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using System;
using System.Net;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace SmartAssembly.SmartExceptionsCore
{
  [WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
  internal class UploadReportLoginService : SoapHttpClientProtocol
  {
    public UploadReportLoginService()
    {
      string str = \u0003.\u0006.\u0001;
      this.Url = \u0003.\u0006.\u0001 + \u0005.\u0004.\u0001(18309);
      this.Timeout = 30000;
    }

    [SoapDocumentMethod("http://www.smartassembly.com/webservices/UploadReportLogin/GetServerURL")]
    public string GetServerURL(string licenseID) => (string) this.Invoke(\u0005.\u0004.\u0001(18342), new object[1]
    {
      (object) licenseID
    })[0];

    protected override WebRequest GetWebRequest(Uri uri)
    {
      WebRequest webRequest = base.GetWebRequest(uri);
      if (webRequest is HttpWebRequest httpWebRequest)
        goto label_2;
label_1:
      return webRequest;
label_2:
      httpWebRequest.ServicePoint.Expect100Continue = false;
      goto label_1;
    }
  }
}
