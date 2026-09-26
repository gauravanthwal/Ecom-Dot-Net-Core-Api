using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Domain.Options
{
    public class ConnectionStringOptions
    {
        public const string SectionName = "ConnectionStrings";
        public string DefaultConnection {get; set;}
    }
}
