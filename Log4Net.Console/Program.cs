using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using System.IO;

namespace Log4Net.Console
{
    class Program
    {

        static void Main(string[] args)
        {
            ILog logger = LogManager.GetLogger("App");

            // Run logger config
            log4net.Config.XmlConfigurator.Configure();

            // Log a debug message
            logger.Debug("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            logger.Debug("                    Application_Start()");
            logger.Debug("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            logger.Debug("");
            logger.Debug("");
            logger.Debug("");
            logger.Debug("              Logger started in Console project.");
            logger.Debug("");
            logger.Debug("");
            logger.Debug("");
            logger.Debug("+++++++++++++++++++++++[ END ]+++++++++++++++++++++++++++");
            logger.Debug("");
            logger.Debug("");
            logger.Debug("");
            logger.Debug("");
            logger.Debug("");
            logger.Debug("");
            logger.Debug("");

            // Trigger log interval
            MyTimer timer = new MyTimer();
            timer.Start();

            System.Console.ReadLine();
        }
    }
}
