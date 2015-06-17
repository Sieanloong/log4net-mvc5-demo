using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Log4Net.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public ILog logger = LogManager.GetLogger(typeof(MvcApplication));

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Run logger config
            log4net.Config.XmlConfigurator.Configure(new FileInfo(Server.MapPath("~/Web.config")));

            var output = new StringBuilder();

            output.AppendLine();
            output.AppendLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            output.AppendLine("                         BEGIN LOG");
            output.AppendLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            output.AppendLine();
            output.Append("                     Web project started.");
            output.AppendLine();
            output.AppendLine();
            output.AppendLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            output.AppendLine("                         END LOG");
            output.AppendLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            logger.Debug(output);
        }
    }
}
