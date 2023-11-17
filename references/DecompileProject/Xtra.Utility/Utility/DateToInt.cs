// Decompiled with JetBrains decompiler
// Type: Xtra.Utility.DateToInt
// Assembly: Xtra.Utility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0A554BF-0B1B-420F-A5E2-9214C58F15B4
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Utility.dll

using System;

namespace Xtra.Utility
{
  public static class DateToInt
  {
    private static int[] daysOfMonth = new int[12]
    {
      31,
      28,
      31,
      30,
      31,
      30,
      31,
      31,
      30,
      31,
      30,
      31
    };

    public static bool IsLeapYear(int year) => year % 4 == 0 && year % 100 != 0 || year % 400 == 0;

    public static int DateToNumber(DateTime date)
    {
      string str1 = date.ToString("dd-MM-yyyy");
      string str2 = "-";
      int num = 0;
      int result1 = 0;
      int result2 = 0;
      int result3 = 0;
      char[] charArray = str2.ToCharArray();
      string[] strArray = str1.Split(charArray);
      int.TryParse(strArray[0], out result1);
      int.TryParse(strArray[1], out result2);
      int.TryParse(strArray[2], out result3);
      for (int year = 2011; year < result3; ++year)
        num += DateToInt.IsLeapYear(year) ? 366 : 365;
      DateToInt.daysOfMonth[1] = DateToInt.IsLeapYear(result3) ? 29 : 28;
      for (int index = 0; index < result2 - 1; ++index)
        num += DateToInt.daysOfMonth[index];
      return num + result1;
    }

    public static string NumberToDate(int date)
    {
      int year = 2000;
      int num1;
      do
      {
        num1 = DateToInt.IsLeapYear(year) ? 366 : 365;
        if (date > num1)
        {
          date -= num1;
          ++year;
        }
      }
      while (date > num1);
      int num2 = 0;
      DateToInt.daysOfMonth[1] = DateToInt.IsLeapYear(year) ? 29 : 28;
      do
      {
        if (date > DateToInt.daysOfMonth[num2 - 1])
        {
          date -= DateToInt.daysOfMonth[num2 - 1];
          ++num2;
        }
      }
      while (date > DateToInt.daysOfMonth[num2 - 1]);
      return date.ToString() + "-" + (object) num2 + "-" + (object) year;
    }
  }
}
