using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Core.Wrappers
{
    public class Response<T>
    {
        public Response()
        {
        }
        public Response(T data, List<string> message = null)
        {
            Succeeded = true;
            Message = message;
            Data = data;
        }
        public Response(List<string> message)
        {
            Succeeded = false;
            Message = message;
        }
        public bool Succeeded { get; set; }
        public List<string> Message { get; set; }
        public List<string> Errors { get; set; }
        public T Data { get; set; }
    }
}
