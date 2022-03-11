using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string menssage = null)
        {
            StatusCode = statusCode;
            Menssage = menssage ?? GetStatusMessageForStatusCode(statusCode);
        }


        public int StatusCode { get; set; }
        public string Menssage { get; set; }


        private string GetStatusMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request, you have made",
                401 => "Autorized, you are not",
                404 => "Resource found, it was not",
                500 => "Errors are the parh the dark side. Errors lead to anger, Anger leads to hate. Hate leads to career change",
                _ => null
            };
        }

    }
}