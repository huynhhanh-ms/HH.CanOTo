// Decompiled with JetBrains decompiler
// Type: Xtra.Utility.ImageHelper.Image2Byte
// Assembly: Xtra.Utility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0A554BF-0B1B-420F-A5E2-9214C58F15B4
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Utility.dll

using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Xtra.Utility.ImageHelper
{
  public static class Image2Byte
  {
    public static Image byteArrayToImage(byte[] byteArrayIn) => byteArrayIn != null ? Image.FromStream((Stream) new MemoryStream(byteArrayIn)) : (Image) null;

    public static byte[] imageToByteArray(Image imageIn)
    {
      MemoryStream memoryStream = new MemoryStream();
      imageIn.Save((Stream) memoryStream, ImageFormat.Gif);
      return memoryStream.ToArray();
    }
  }
}
