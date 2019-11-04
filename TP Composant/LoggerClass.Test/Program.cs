using System;

namespace LoggerClass.Test
{
    using LoggerClass;
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new Logger();
            logger.LogInfo("message info");
            logger.LogError("message erreur");
        }
    }
}
