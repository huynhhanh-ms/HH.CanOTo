// Decompiled with JetBrains decompiler
// Type: Xtra.Utility.Populate
// Assembly: Xtra.Utility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0A554BF-0B1B-420F-A5E2-9214C58F15B4
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Utility.dll

using System;
using System.Text.RegularExpressions;

namespace Xtra.Utility
{
  public static class Populate
  {
    public static string GenOrderNo1()
    {
      DateTime now = DateTime.Now;
      int hour = now.Hour;
      now = DateTime.Now;
      int minute = now.Minute;
      int num = hour * minute;
      now = DateTime.Now;
      int second = now.Second;
      return (num * second).ToString("000000");
    }

    public static string GenOrderNo2() => Populate.LayChuVaSo(DateTime.Now.ToString("dd/MM/yy HH:mm:ss"));

    public static string GenOrderNoByInc(string str)
    {
      string input = Populate.LayChuVaSo(str);
      string pattern = "(\\d+)$";
      string str1 = Regex.Match(input, pattern).Value;
      string str2 = Regex.Replace(input, pattern, "");
      int num1 = int.Parse("0" + str1);
      int length = str1.Length;
      int num2 = (double) (num1 + 1) / Math.Pow(10.0, (double) length) == 1.0 ? length + 1 : length;
      return str2 + (num1 + 1).ToString("D" + (object) num2);
    }

    public static string LayChuVaSo(string str)
    {
      str = new Regex("[^a-zA-Z0-9]").Replace(str, string.Empty);
      return str;
    }

    public static string ChiLayChu(string str)
    {
      str = new Regex("[^a-zA-Z]").Replace(str, string.Empty);
      return str;
    }

    public static string ChiLaySo(string str)
    {
      str = new Regex("[^0-9]").Replace(str, string.Empty);
      return str.ToUpper();
    }
  }
}
