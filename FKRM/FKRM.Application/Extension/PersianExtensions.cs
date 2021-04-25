using System;
using System.Globalization;
using System.Linq;

namespace FKRM.Application.Extension
{
    public static class PersianExtensions
    {
        public static  bool CheckNationId(this string nationalCode) {
            bool result;
            try      {    
                string[] allDigitEqual = new[] { "0000000000", "1111111111",
                    "2222222222", "3333333333", "4444444444", "5555555555",
                    "6666666666", "7777777777", "8888888888", "9999999999" };  
                if (allDigitEqual.Contains(nationalCode)) 
                    return false; 
                var chArray = nationalCode.ToCharArray();        
                var num0 = Convert.ToInt32(chArray[0].ToString()) * 10;     
                var num2 = Convert.ToInt32(chArray[1].ToString()) * 9;      
                var num3 = Convert.ToInt32(chArray[2].ToString()) * 8;     
                var num4 = Convert.ToInt32(chArray[3].ToString()) * 7;    
                var num5 = Convert.ToInt32(chArray[4].ToString()) * 6;    
                var num6 = Convert.ToInt32(chArray[5].ToString()) * 5;     
                var num7 = Convert.ToInt32(chArray[6].ToString()) * 4;     
                var num8 = Convert.ToInt32(chArray[7].ToString()) * 3;      
                var num9 = Convert.ToInt32(chArray[8].ToString()) * 2;      
                var a = Convert.ToInt32(chArray[9].ToString());             
                var b = (((((((num0 + num2) + num3) + num4) + num5) + num6) + num7) + num8) + num9;  
                var c = b % 11;       
                return (((c < 2) && (a == c)) || ((c >= 2) && ((11 - c) == a)));      
            }           
            catch { 
                result = false; 
            }  
            return result;      
        } 
        public static string ToShamsiDateTime(this DateTime info)
        {
            string rt;
            try
            {

                bool _includeHourMinute = true;
                string _separator = "/";
                var year = info.Year;
                var month = info.Month;
                var day = info.Day;
                var persianCalendar = new PersianCalendar();
                var pYear = persianCalendar.GetYear(new DateTime(year, month, day, new GregorianCalendar()));
                var pMonth = persianCalendar.GetMonth(new DateTime(year, month, day, new GregorianCalendar()));
                var pDay = persianCalendar.GetDayOfMonth(new DateTime(year, month, day, new GregorianCalendar()));
                rt = _includeHourMinute ?
                    string.Format("{0}{1}{2}{1}{3} {4}:{5}", pYear, _separator, pMonth.ToString("00", CultureInfo.InvariantCulture), pDay.ToString("00", CultureInfo.InvariantCulture), info.Hour.ToString("00"), info.Minute.ToString("00"))
                    : string.Format("{0}{1}{2}{1}{3}", pYear, _separator, pMonth.ToString("00", CultureInfo.InvariantCulture), pDay.ToString("00", CultureInfo.InvariantCulture));

            }
            catch
            {
                rt = "N/A";
            }
            return rt;
        }
    }
}
