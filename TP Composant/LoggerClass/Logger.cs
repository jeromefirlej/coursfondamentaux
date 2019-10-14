using System;

namespace LoggerClass
{
    using System.IO;
    using Microsoft.Extensions.Configuration;

    public class Logger : ILogger
    {
        public string DateFormat { get; set; }
        public Logger(){
             IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
                
            DateFormat =  config.GetSection("dateFormat").Value;
        }
        
    }
}
