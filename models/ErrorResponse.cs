using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.models
{
    public class ErrorResponse
    {
        public string? Title { get; set; }
        public int StatusCode { get; set; }
        public string? Message { get; set; }
    }
}