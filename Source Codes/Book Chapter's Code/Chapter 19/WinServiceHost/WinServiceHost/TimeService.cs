using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WinServiceHost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TimeService" in both code and config file together.
    public class TimeService : ITimeService
    {
        public string GetCurrentTime()
        {
            string CurrentTime = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            return CurrentTime;
        }
    }
}
