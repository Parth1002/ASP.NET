using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace MyWindowsService
{
    public partial class MyService : ServiceBase
    {
        public MyService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // TODO: Add code here to start your service.
            EventLog.WriteEntry("Starting MyService");
        }

        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop 
            //your service.
            EventLog.WriteEntry("Stopping MyService");

        }
    }
}
