using AutoMapper;
using System;
using System.Reflection;

namespace FKRM.Application.AutoMapper
{
    public class TypeTypeConverter : ITypeConverter<string, Type>
    {
        public Type Convert(string source, Type destination, ResolutionContext context)
        {
            return Assembly.GetExecutingAssembly().GetType(source);
        }
    }
}