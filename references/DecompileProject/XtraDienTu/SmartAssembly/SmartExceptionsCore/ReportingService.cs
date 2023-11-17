// Decompiled with JetBrains decompiler
// Type: SmartAssembly.SmartExceptionsCore.ReportingService
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using \u0005;
using System;
using System.Net;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

namespace SmartAssembly.SmartExceptionsCore
{
  [WebServiceBinding(Name = "ReportingServiceSoap", Namespace = "http://www.smartassembly.com/webservices/Reporting/")]
  internal class ReportingService : SoapHttpClientProtocol
  {
    public ReportingService(string serverUrl)
    {
      this.Url = serverUrl + \u0004.\u0001(18359);
      this.Timeout = 180000;
    }

    [SoapDocumentMethod("http://www.smartassembly.com/webservices/Reporting/UploadReport2")]
    public string UploadReport2(
      string licenseID,
      [XmlElement(DataType = "base64Binary")] byte[] data,
      string email,
      string appFriendlyName,
      string buildFriendlyNumber)
    {
      return (string) this.Invoke(\u0004.\u0001(18380), new object[5]
      {
        (object) licenseID,
        (object) data,
        (object) email,
        (object) appFriendlyName,
        (object) buildFriendlyNumber
      })[0];
    }

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
