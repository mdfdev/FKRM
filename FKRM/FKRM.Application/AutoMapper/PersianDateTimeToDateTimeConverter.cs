using AutoMapper;
using FKRM.Application.Extension;
using System;

namespace FKRM.Application.AutoMapper
{
    public class PersianDateTimeToDateTimeConverter : ITypeConverter<string, DateTime>
    {
        private readonly string _separator;
        private readonly bool _includeHourMinute;

        public PersianDateTimeToDateTimeConverter(string separator = "-", bool includeHourMinute = true)
        {
            _separator = separator;
            _includeHourMinute = includeHourMinute;
        }
        public DateTime Convert(string source, DateTime destination, ResolutionContext context)
        {
            var convertToGregorianDate = PersianCalendarUtility.ConvertToGregorianDate(source);
            if (convertToGregorianDate != null)
                return convertToGregorianDate.Value;
            throw new Exception($"The date {source} is not valid and cannot be null");
        }
    }
}