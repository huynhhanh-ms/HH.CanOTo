// Decompiled with JetBrains decompiler
// Type: Xtra.Utility.ImageHelper.ImageHelper
// Assembly: Xtra.Utility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0A554BF-0B1B-420F-A5E2-9214C58F15B4
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Utility.dll

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Xtra.Utility.ImageHelper
{
  public class ImageHelper
  {
    public static Image resizeImage(Image imgToResize, Size size)
    {
      int width1 = imgToResize.Width;
      int height1 = imgToResize.Height;
      float num1 = (float) size.Width / (float) width1;
      float num2 = (float) size.Height / (float) height1;
      float num3 = (double) num2 >= (double) num1 ? num1 : num2;
      int width2 = (int) ((double) width1 * (double) num3);
      int height2 = (int) ((double) height1 * (double) num3);
      Bitmap bitmap = new Bitmap(width2, height2);
      Graphics graphics = Graphics.FromImage((Image) bitmap);
      graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
      graphics.DrawImage(imgToResize, 0, 0, width2, height2);
      graphics.Dispose();
      return (Image) bitmap;
    }

    public static Image cropImage(Image img, Rectangle cropArea)
    {
      Bitmap bitmap = new Bitmap(img);
      return (Image) bitmap.Clone(cropArea, bitmap.PixelFormat);
    }

    public void saveJpeg(string path, Bitmap img, long quality)
    {
      EncoderParameter encoderParameter = new EncoderParameter(Encoder.Quality, quality);
      ImageCodecInfo encoderInfo = this.getEncoderInfo("image/jpeg");
      if (encoderInfo == null)
        return;
      EncoderParameters encoderParams = new EncoderParameters(1);
      encoderParams.Param[0] = encoderParameter;
      img.Save(path, encoderInfo, encoderParams);
    }

    public ImageCodecInfo getEncoderInfo(string mimeType)
    {
      ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
      for (int index = 0; index < imageEncoders.Length; ++index)
      {
        if (imageEncoders[index].MimeType == mimeType)
          return imageEncoders[index];
      }
      return (ImageCodecInfo) null;
    }
  }
}
