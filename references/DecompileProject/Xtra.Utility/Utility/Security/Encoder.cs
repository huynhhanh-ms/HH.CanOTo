// Decompiled with JetBrains decompiler
// Type: Xtra.Utility.Security.Encoder
// Assembly: Xtra.Utility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0A554BF-0B1B-420F-A5E2-9214C58F15B4
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Utility.dll

using System.Security.Cryptography;
using System.Text;

namespace Xtra.Utility.Security
{
  public class Encoder
  {
    public string CalculateMD5Hash(string input)
    {
      byte[] hash = MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(input));
      StringBuilder stringBuilder = new StringBuilder();
      for (int index = 0; index < hash.Length; ++index)
        stringBuilder.Append(hash[index].ToString("x2"));
      return stringBuilder.ToString();
    }
  }
}
