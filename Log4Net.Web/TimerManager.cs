using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Log4Net.Web
{
    public class TimerManager
    {
        private static TimerManager instance;
        public static TimerManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TimerManager();
                }
                return instance;
            }
        }

        ILog logger = LogManager.GetLogger(typeof(MvcApplication));

        private System.Timers.Timer _debugTimer;
        private System.Timers.Timer _infoTimer;
        private System.Timers.Timer _warnTimer;
        private System.Timers.Timer _errorTimer;
        private System.Timers.Timer _fatalTimer;

        double intervalSec = 1;

        public TimerManager()
        {
            _debugTimer = new System.Timers.Timer(1000 * intervalSec);
            _infoTimer = new System.Timers.Timer(1000 * intervalSec);
            _warnTimer = new System.Timers.Timer(1000 * intervalSec);
            _errorTimer = new System.Timers.Timer(1000 * intervalSec);
            _fatalTimer = new System.Timers.Timer(1000 * intervalSec);

            _debugTimer.Elapsed += timer_Debug;
            _infoTimer.Elapsed += timer_Info;
            _warnTimer.Elapsed += timer_Warn;
            _errorTimer.Elapsed += timer_Error;
            _fatalTimer.Elapsed += timer_Fatal;

            _debugTimer.Enabled = false;
            _infoTimer.Enabled = false;
            _warnTimer.Enabled = false;
            _errorTimer.Enabled = false;
            _fatalTimer.Enabled = false;
        }

        public void SetTimer(int timerCode)
        {
            if (timerCode > 0)
            {
                switch (timerCode)
                {
                    case 1:
                        _debugTimer.Enabled = true;
                        break;
                    case 2:
                        _infoTimer.Enabled = true;
                        break;
                    case 3:
                        _warnTimer.Enabled = true;
                        break;
                    case 4:
                        _errorTimer.Enabled = true;
                        break;
                    case 5:
                        _fatalTimer.Enabled = true;
                        break;
                    default:
                        break;
                }
            }
        }

        public void CancelTimer(int timerCode)
        {
            if (timerCode > 0)
            {
                switch (timerCode)
                {
                    case 1:
                        _debugTimer.Enabled = false;
                        break;
                    case 2:
                        _infoTimer.Enabled = false;
                        break;
                    case 3:
                        _warnTimer.Enabled = false;
                        break;
                    case 4:
                        _errorTimer.Enabled = false;
                        break;
                    case 5:
                        _fatalTimer.Enabled = false;
                        break;
                    default:
                        break;
                }
            }
        }

        private void timer_Debug(object sender, System.Timers.ElapsedEventArgs e)
        {
            logger.Debug("(Loop) This is a debug message.");
        }

        private void timer_Info(object sender, System.Timers.ElapsedEventArgs e)
        {
            logger.Info("(Loop) This is an info message.");
        }

        private void timer_Warn(object sender, System.Timers.ElapsedEventArgs e)
        {
            logger.Warn("(Loop) This is a warn message.");
        }

        private void timer_Error(object sender, System.Timers.ElapsedEventArgs e)
        {
            logger.Error("(Loop) This is an error message.");
        }

        private void timer_Fatal(object sender, System.Timers.ElapsedEventArgs e)
        {
            logger.Fatal("(Loop) This is a fatal message. Good luck.");
        }
    }
}