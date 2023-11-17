// Decompiled with JetBrains decompiler
// Type: Xtra.Utility.ReadNumber
// Assembly: Xtra.Utility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0A554BF-0B1B-420F-A5E2-9214C58F15B4
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Utility.dll

using System;

namespace Xtra.Utility
{
  public static class ReadNumber
  {
    private static string Đơn_Vị(string dv)
    {
      string str = "";
      switch (dv)
      {
        case "0":
          str = "";
          break;
        case "1":
          str = "một";
          break;
        case "2":
          str = "hai";
          break;
        case "3":
          str = "ba";
          break;
        case "4":
          str = "bốn";
          break;
        case "5":
          str = "năm";
          break;
        case "6":
          str = "sáu";
          break;
        case "7":
          str = "bảy";
          break;
        case "8":
          str = "tám";
          break;
        case "9":
          str = "chín";
          break;
      }
      return str;
    }

    private static string Chục(string chuc)
    {
      int int32_1 = Convert.ToInt32(chuc[1].ToString());
      int int32_2 = Convert.ToInt32(chuc);
      string str;
      if (int32_2 < 20)
      {
        switch (int32_2)
        {
          case 10:
            str = "mười";
            break;
          case 11:
            str = "mười một";
            break;
          case 15:
            str = "mười lăm";
            break;
          default:
            str = "mười " + ReadNumber.Đơn_Vị(chuc[1].ToString());
            break;
        }
      }
      else
      {
        switch (int32_1)
        {
          case 0:
            str = ReadNumber.Đơn_Vị(chuc[0].ToString()) + " mươi ";
            break;
          case 1:
            str = ReadNumber.Đơn_Vị(chuc[0].ToString()) + " mươi mốt";
            break;
          case 5:
            str = ReadNumber.Đơn_Vị(chuc[0].ToString()) + " mươi lăm";
            break;
          default:
            str = string.Format("{0} mươi {1}", (object) ReadNumber.Đơn_Vị(chuc[0].ToString()), (object) ReadNumber.Đơn_Vị(chuc[1].ToString()));
            break;
        }
      }
      if (chuc[0].ToString() == "0")
        str = str.Replace(" mươi ", "").Replace("mười ", "");
      return str;
    }

    private static string Trăm(string tram)
    {
      int int32 = Convert.ToInt32(tram);
      string str1;
      if (int32 == 0)
        str1 = "";
      else if (tram.Length == 1)
        str1 = ReadNumber.Đơn_Vị(tram);
      else if (tram.Length == 2)
        str1 = ReadNumber.Chục(tram);
      else if (int32 % 100 == 0)
        str1 = ReadNumber.Đơn_Vị(tram[0].ToString()) + " trăm";
      else if (int32 < 100)
        str1 = "lẻ " + ReadNumber.Chục(tram.Substring(1).ToString());
      else if (tram[1].ToString() != "0")
      {
        str1 = string.Format("{0} trăm {1}", (object) ReadNumber.Đơn_Vị(tram[0].ToString()), (object) ReadNumber.Chục(tram.Substring(1).ToString()));
      }
      else
      {
        char ch = tram[0];
        string str2 = ReadNumber.Đơn_Vị(ch.ToString());
        ch = tram[2];
        string str3 = ReadNumber.Đơn_Vị(ch.ToString());
        str1 = string.Format("{0} trăm lẻ {1}", (object) str2, (object) str3);
      }
      return str1;
    }

    private static string[] Tạo_Mảng_Số(string nghin)
    {
      try
      {
        nghin = Convert.ToInt32(nghin).ToString();
      }
      catch (Exception ex)
      {
      }
      int num1;
      int num2 = num1 = 0;
      int num3 = num1;
      int num4 = num1;
      int length1 = nghin.Length;
      int length2 = length1 % 3 != 0 ? length1 + length1 / 3 : length1 + length1 / 3 - 1;
      string[] strArray1 = new string[length2];
      int num5 = length2 - 1;
      for (; length1 > 0; --length1)
      {
        char ch;
        if (num4 != 3)
        {
          ++num4;
          ch = nghin[length1 - 1];
          int num6;
          if (ch.ToString() != " ")
          {
            ch = nghin[length1 - 1];
            num6 = !(ch.ToString() != "\n") ? 1 : 0;
          }
          else
            num6 = 1;
          if (num6 == 0)
          {
            string[] strArray2 = strArray1;
            int index = num5 - num2;
            ch = nghin[length1 - 1];
            string str = ch.ToString();
            strArray2[index] = str;
          }
        }
        else
        {
          num4 = 1;
          ++num3;
          if (num3 == 3)
          {
            num3 = 0;
            ++ReadNumber.Cấp_Tỉ;
            strArray1[num5 - num2] = "_";
          }
          else
            strArray1[num5 - num2] = ",";
          ++num2;
          string[] strArray3 = strArray1;
          int index = num5 - num2;
          ch = nghin[length1 - 1];
          string str = ch.ToString();
          strArray3[index] = str;
        }
        ++num2;
      }
      ReadNumber.t = string.Join("", strArray1);
      return string.Join("", strArray1).Split('_');
    }

    private static string Đọc_Số(string[] arr)
    {
      string str1;
      string str2 = str1 = "";
      string str3 = str1;
      string str4 = str1;
      string str5 = str1;
      string str6 = str1;
      string str7 = str1;
      string str8 = str1;
      int length = arr.Length;
      while (length > 0)
      {
        if (ReadNumber.Cấp_Tỉ > 0 && length < arr.Length)
          str4 += " tỉ ";
        string[] strArray = arr[length - 1].Split(',');
        string str9 = ReadNumber.Trăm(strArray[0].ToString());
        switch (strArray.Length)
        {
          case 1:
            str7 = str9 + str4;
            break;
          case 2:
            str6 = string.Format("{0} nghìn {1}{2}", (object) str9, (object) ReadNumber.Trăm(strArray[1].ToString()), (object) str4);
            break;
          case 3:
            int int32 = Convert.ToInt32(strArray[0]);
            string str10 = str9;
            string str11 = int32 <= 0 ? str9 : (int32 >= 100 ? str10 + " triệu " : str10.Replace(" lẻ ", "") + " triệu ");
            string str12 = ReadNumber.Trăm(strArray[1]);
            if (Convert.ToInt32(strArray[1]) > 0)
              str12 += " nghìn ";
            str5 = str11 + str12 + ReadNumber.Trăm(strArray[2]) + str4;
            break;
        }
        --length;
        str8 = str7 + str6 + str5 + str8;
        string str13;
        str5 = str13 = "";
        str6 = str13;
        str7 = str13;
        str2 = str13;
        str3 = str13;
      }
      ReadNumber.Cấp_Tỉ = 0;
      return str8;
    }

    public static string ByWords(this long so)
    {
      string nghin = so.ToString();
      string str = "";
      try
      {
        if (nghin != "")
          str = so != 0L ? ReadNumber.Đọc_Số(ReadNumber.Tạo_Mảng_Số(nghin)) : "không";
      }
      catch (Exception ex1)
      {
        try
        {
          str = ReadNumber.Đọc_Số(ReadNumber.Tạo_Mảng_Số(nghin));
        }
        catch (Exception ex2)
        {
          str = "Không đọc được số này, xin vui lòng kiểm tra lại!";
        }
      }
      return ReadNumber.Viethoa(str);
    }

    private static string Viethoa(string str)
    {
      char[] charArray = str.ToCharArray();
      charArray[0] = char.ToUpper(charArray[0]);
      return new string(charArray);
    }

    private static int Cấp_Tỉ { get; set; }

    private static string t { get; set; }
  }
}
