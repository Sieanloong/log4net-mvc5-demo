using log4net;
using log4net.Appender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Log4Net.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public void SetEmailFlag(int state)
        {
            if (state > 0)
            {
                int portNumber;

                if (state == 1)
                {
                    // Set to correct port if trying to enable email notifications
                    portNumber = 587;
                }
                else 
                {
                    // Set to invalid dummy port if trying to disable email notifications
                    portNumber = 9999;
                }

                // Get reference to the current config and SmtpAppender
                log4net.Repository.Hierarchy.Hierarchy h = (log4net.Repository.Hierarchy.Hierarchy)log4net.LogManager.GetRepository();
                log4net.Appender.SmtpAppender smtpAppender = (SmtpAppender)h.GetAppenders().Where(x => x.Name == "SmtpAppender").FirstOrDefault();
                
                // Update port number and refresh config
                smtpAppender.Port = portNumber;
                smtpAppender.ActivateOptions();
            }
        }
    }
}