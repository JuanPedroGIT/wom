using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiException : ApiResponse
    {
        public ApiException(int statusCode, string menssage = null, string details = null) : base(statusCode, menssage)
        {
            Details = details;
        }

        public string  Details { get; set; }
    }
}