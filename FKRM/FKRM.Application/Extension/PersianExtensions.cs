using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FKRM.Application.Extension
{
    public static class PersianExtensions
    {

        public static string ToShamsiDateTime(this DateTime info)
        {
            bool _includeHourMinute=true;
            string _separator="/";
            var year = info.Year;
            var month = info.Month;
            var day = info.Day;
            var persianCalendar = new PersianCalendar();
            var pYear = persianCalendar.GetYear(new DateTime(year, month, day, new GregorianCalendar()));
            var pMonth = persianCalendar.GetMonth(new DateTime(year, month, day, new GregorianCalendar()));
            var pDay = persianCalendar.GetDayOfMonth(new DateTime(year, month, day, new GregorianCalendar()));
            return _includeHourMinute ?
                string.Format("{0}{1}{2}{1}{3} {4}:{5}", pYear, _separator, pMonth.ToString("00", CultureInfo.InvariantCulture), pDay.ToString("00", CultureInfo.InvariantCulture), info.Hour.ToString("00"), info.Minute.ToString("00"))
                : string.Format("{0}{1}{2}{1}{3}", pYear, _separator, pMonth.ToString("00", CultureInfo.InvariantCulture), pDay.ToString("00", CultureInfo.InvariantCulture));
        }
    }
}
