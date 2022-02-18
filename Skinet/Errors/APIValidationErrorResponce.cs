using Microsoft.AspNetCore.Mvc;
using Skinet.Controllers;
using System.Collections.Generic;

namespace Skinet.Errors
{
    public class APIValidationErrorResponce : APIResponce
    {
        public IEnumerable<string> Errors { get; set; }
        public APIValidationErrorResponce() : base(400)
        {

        }
    }
}
