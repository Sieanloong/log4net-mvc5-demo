using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Log4Net.Web.Controllers
{
    public class LoopController : Controller
    {
        private TimerManager TimerMgr = TimerManager.Instance;

        public void FireEventLoop(int evtCode, int runState)
        {
            if (evtCode > 0 && runState > 0)
            {
                switch (runState)
                { 
                    case 1:
                        TimerMgr.SetTimer(evtCode);
                        break;
                    case 2:
                        TimerMgr.CancelTimer(evtCode);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}