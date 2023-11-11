using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HH.WPF.Util
{
    class SerialPortReader
    {
        public static String String2Num(String rawData)
        {
            try
            {
                string pattern = @"-{0,1}[\d]+";
                Match match = Regex.Match(rawData, pattern);
                string rawNum = (match.Success) ? rawNum = match.Value : "-1";
                var num = Int128.Parse(rawNum) / 10 * 10;
                return num.ToString();
            }
            catch
            {
                return "-1";
            }
        }
    }
}
