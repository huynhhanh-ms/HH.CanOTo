// Decompiled with JetBrains decompiler
// Type: Xtra.Utility.Profile.XmlBased
// Assembly: Xtra.Utility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0A554BF-0B1B-420F-A5E2-9214C58F15B4
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Utility.dll

using System.IO;
using System.Text;
using System.Xml;

namespace Xtra.Utility.Profile
{
  public abstract class XmlBased : Xtra.Utility.Profile.Profile
  {
    private Encoding m_encoding = Encoding.UTF8;
    internal XmlBuffer m_buffer;

    protected XmlBased()
    {
    }

    protected XmlBased(string fileName)
      : base(fileName)
    {
    }

    protected XmlBased(XmlBased profile)
      : base((Xtra.Utility.Profile.Profile) profile)
    {
      this.m_encoding = profile.Encoding;
    }

    protected XmlDocument GetXmlDocument()
    {
      if (this.m_buffer != null)
        return this.m_buffer.XmlDocument;
      this.VerifyName();
      if (!File.Exists(this.Name))
        return (XmlDocument) null;
      XmlDocument xmlDocument = new XmlDocument();
      xmlDocument.Load(this.Name);
      return xmlDocument;
    }

    protected void Save(XmlDocument doc)
    {
      if (this.m_buffer != null)
        this.m_buffer.m_needsFlushing = true;
      else
        doc.Save(this.Name);
    }

    public XmlBuffer Buffer(bool lockFile)
    {
      if (this.m_buffer == null)
        this.m_buffer = new XmlBuffer(this, lockFile);
      return this.m_buffer;
    }

    public XmlBuffer Buffer() => this.Buffer(true);

    public bool Buffering => this.m_buffer != null;

    public Encoding Encoding
    {
      get => this.m_encoding;
      set
      {
        this.VerifyNotReadOnly();
        if (this.m_encoding == value || !this.RaiseChangeEvent(true, ProfileChangeType.Other, (string) null, nameof (Encoding), (object) value))
          return;
        this.m_encoding = value;
        this.RaiseChangeEvent(false, ProfileChangeType.Other, (string) null, nameof (Encoding), (object) value);
      }
    }
  }
}
