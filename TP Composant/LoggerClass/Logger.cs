using System;

namespace LoggerClass
{
    using System.IO;

    public class Logger : ILogger
    {
        private readonly LoggerConfiguration loggerConfiguration;

        public Logger(IConfigurationManager configurationManager)
        {
            loggerConfiguration = configurationManager.GetConfiguration();
        }

        public Logger() : this(new ConfigurationManager())
        {
        }

        public void LogInfo(string message)
        {
            Log("Info", message);
        }

        public void LogError(string error)
        {
            Log("Error", error);
        }


        private void Log(string type, string message)
        {
            WriteLine($"[{DateTime.Now.ToString(loggerConfiguration.HourFormat)}] - {type} - {message}");
        }

        private void WriteLine(string line)
        {
            bool append = true;
            using (StreamWriter file =
                new StreamWriter($"{loggerConfiguration.LogPath}\\log-{DateTime.Now.ToString(loggerConfiguration.DateFormat)}.log", append))
            {
                file.WriteLine(line);
            }
        }
    }
}
