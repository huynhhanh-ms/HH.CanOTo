// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using System;
using System.Xml;

namespace \u0003
{
  internal class \u0007 : IDisposable
  {
    private readonly XmlWriter \u0001;

    public \u0007(XmlWriter xmlWriter, string name)
    {
      this.\u0001 = xmlWriter;
      this.\u0001.WriteStartElement(name);
    }

    public void \u0001() => this.\u0001.WriteEndElement();
  }
}
