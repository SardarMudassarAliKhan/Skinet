﻿using System;

namespace Skinet.Errors
{
    public class APIResponce
    {

        public int statusCode { get; set; }
        public string Message { get; set; }

        public APIResponce(int StatusCode, string  message = null)
        {
            statusCode = StatusCode;
            Message = message ?? DefaultStatusCodeMessage(StatusCode);
        }
        private string DefaultStatusCodeMessage(int StatusCode)
        {
            return StatusCode switch
            {
                400 => "A bad request you have made",
                401 => "Authorized you have not",
                404 => "Resource Found it was not",
                500 => "Sever lavel Error",
                0 =>"Some Thing Went Wrong"
            };
        }
    }
}
