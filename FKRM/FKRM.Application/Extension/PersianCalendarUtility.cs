using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FKRM.Application.Extension
{
    public class PersianCalendarUtility
    {
        public static string ConvertToPersianDate(DateTime? dateTime)
        {
            return ConvertToPersianDate(dateTime, false);
        }

        public static string ConvertToPersianDate(DateTime? dateTime, bool showTime = false)
        {
            if (!dateTime.HasValue)
                return null;

            var dt = dateTime.Value;

            PersianCalendar pc = new PersianCalendar();
            var result =
                $"{pc.GetYear(dt)}/{pc.GetMonth(dt).ToString().PadLeft(2, '0')}/{pc.GetDayOfMonth(dt).ToString().PadLeft(2, '0')}";
            if (showTime)
                result += " " + dt.Hour + ":" + dt.Minute;

            return result;
        }

        public static DateTime? ConvertToGregorianDate(string persianDate)
        {
            if (string.IsNullOrWhiteSpace(persianDate))
                return null;

            if (persianDate.Length < 6)
                return null;

            persianDate = ConvertNumerals(persianDate);

            persianDate = persianDate.Trim();

            if (persianDate.StartsWith("13") == false)
                persianDate = "13" + persianDate;

            if (persianDate.Contains("-"))
            {
                persianDate = persianDate.Replace('-', '/');
            }
            if (persianDate.IndexOf("/", StringComparison.Ordinal) == -1)
            {
                persianDate = persianDate.Substring(0, 4) + "/" +
                              persianDate.Substring(4, 2) + "/" +
                              persianDate.Substring(6);
            }

            try
            {
                var parts = persianDate.Split(new char[] { '/' });
                PersianCalendar pc = new PersianCalendar();
                return pc.ToDateTime(
                    int.Parse(parts[0]),
                    int.Parse(parts[1]),
                    int.Parse(parts[2]), 0, 0, 0, 0);

            }
            catch
            {
                return null;
            }

        }

        public static DateTime? ConvertToGregorianDate(string persianPresenceDateTime, string presenceHourMinute)
        {
            if (presenceHourMinute == null || persianPresenceDateTime == null)
                return null;

            var result = ConvertToGregorianDate(persianPresenceDateTime);

            if (result == null)
                return null;

            presenceHourMinute = ConvertNumerals(presenceHourMinute);

            if (presenceHourMinute.Length == 4 && presenceHourMinute.IndexOf(':') == -1)
                presenceHourMinute = presenceHourMinute.Insert(2, ":");
            else if (presenceHourMinute.IndexOf(':') == -1)
                return null;

            var timeparts = presenceHourMinute.Split(':');

            int hour = 0, minute = 0;

            if (!int.TryParse(timeparts[0], out hour))
            {
                return null;
            }
            else if (!(hour >= 0 && hour <= 23))
            {
                return null;
            }

            if (!int.TryParse(timeparts[1], out minute))
            {
                return null;
            }
            else if (!(minute >= 0 && minute <= 59))
            {
                return null;
            }

            result = result.Value.AddHours(hour).AddMinutes(minute);

            return result;
        }

        public static string ConvertNumerals(string input)
        {
            if (input == null)
                return null;

            return input.Replace('\u06f0', '0')
                    .Replace('\u06f1', '1')
                    .Replace('\u06f2', '2')
                    .Replace('\u06f3', '3')
                    .Replace('\u06f4', '4')
                    .Replace('\u06f5', '5')
                    .Replace('\u06f6', '6')
                    .Replace('\u06f7', '7')
                    .Replace('\u06f8', '8')
                    .Replace('\u06f9', '9');
        }

        public static DateTime GetLastOfPersianMonth(DateTime dateTime)
        {

            PersianCalendar calendar = new PersianCalendar();
            var persianYear = calendar.GetYear(dateTime);
            var persianMonth = calendar.GetMonth(dateTime);

            var lastDay = (persianMonth) <= 6 ? 31
                : persianMonth == 12 ? 29 : 30;

            return calendar.ToDateTime(persianYear, persianMonth, lastDay, 23, 59, 59, 0);
        }

        public static DateTime GetFirstOfPersianMonth(DateTime dateTime)
        {
            PersianCalendar calendar = new PersianCalendar();
            var persianYear = calendar.GetYear(dateTime);
            var persianMonth = calendar.GetMonth(dateTime);

            return calendar.ToDateTime(persianYear, persianMonth, 1, 0, 0, 0, 0);
        }

        public static int ConvertToMonthNumber(string monthName)
        {
            switch (monthName)
            {
                case "فروردین":
                    return 1;
                case "اردیبهشت":
                case "اردی‌بهشت":
                case "اردی بهشت":
                    return 2;
                case "خرداد":
                    return 3;
                case "تیر":
                    return 4;
                case "مرداد":
                    return 5;
                case "شهریور":
                    return 6;
                case "مهر":
                    return 7;
                case "آبان":
                    return 8;
                case "آذر":
                    return 9;
                case "دی":
                    return 10;
                case "بهمن":
                    return 11;
                case "اسفند":
                    return 12;
                default:
                    throw new Exception($"Month name '{monthName}' is not valid.");
            }
        }
    }
}

