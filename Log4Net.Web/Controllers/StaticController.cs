using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Log4Net.Web.Controllers
{
    public class StaticController : Controller
    {
        private ILog logger = LogManager.GetLogger(typeof(MvcApplication));

        public void FireEvent(int evtCode)
        {
            if(evtCode != null && evtCode > 0)
            {
                switch (evtCode)
                { 
                    case 1:
                        logger.Debug("This is a debug message.");
                        break;
                    case 2:
                        logger.Info("This is an info message.");
                        break;
                    case 3:
                        logger.Warn("This is a warn message.");
                        break;
                    case 4:
                        logger.Error("This is an error message.");
                        break;
                    case 5:
                        logger.Fatal("This is a fatal message. Good luck.");
                        break;
                    default:
                        logger.Debug("This is a default debug log.");
                        break;
                }

            }
        }
    }
}