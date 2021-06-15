using AutoMapper;
using FKRM.Application.Extension;
using System;
using System.Globalization;

namespace FKRM.Application.AutoMapper
{
    public class DateTimeToPersianDateTimeConverter : ITypeConverter<DateTime, string>
    {
        private readonly bool _includeHourMinute;
        private readonly string _separator;

        public DateTimeToPersianDateTimeConverter(string separator = "/", bool includeHourMinute = true)
        {
            _separator = separator;
            _includeHourMinute = includeHourMinute;
        }

        public string Convert(DateTime source, string destination, ResolutionContext context)
        {
            return PersianCalendarUtility.ConvertToPersianDate(source);
        }
    }
}