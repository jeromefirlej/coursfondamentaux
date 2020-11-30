using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Demo
{
    public class Class1
    {
        public Class1(){
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string maClef = config.GetSection("maClef").Value;
        }
    }
}
