using System.IO;
using Microsoft.Extensions.Configuration;

namespace LoggerClass{
    public class ConfigurationManager : IConfigurationManager
    { 
        private IConfiguration config { get;}

        public ConfigurationManager(){
            config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
        }

        public LoggerConfiguration GetConfiguration()
        {
            LoggerConfiguration loggerConfiguration = new LoggerConfiguration();
            config.GetSection("loggerConfiguration").Bind(loggerConfiguration);
            return loggerConfiguration;
        }
    }
}