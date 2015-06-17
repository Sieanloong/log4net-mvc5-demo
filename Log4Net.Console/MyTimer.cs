using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;
using log4net.Config;

namespace Log4Net.Console
{
    public class MyTimer
    {
        private System.Timers.Timer _timer;
        private DateTime _startTime;

        public ILog logger = LogManager.GetLogger("App");

        public void Start()
        {
            _startTime = DateTime.Now;
            _timer = new System.Timers.Timer(1000 * 10); // 10 seconds
            _timer.Elapsed += timer_Elapsed;
            _timer.Enabled = true;
        }

        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // Log a debug message
            logger.Debug("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            logger.Debug("                    Console Timer");
            logger.Debug("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            logger.Debug("");
            logger.Debug("");
            logger.Debug("");
            logger.Debug("                  Console timer log.");
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
            logger.Debug("\n\n\n\n\n\n DATA! \n\n\n\n");
        }
    }
}