using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.ServiceModel;

namespace WinServiceHost
{
    partial class Service1 : ServiceBase
    {
        public ServiceHost myHost;
        public Service1()
        {
            InitializeComponent();
            myHost = new ServiceHost(typeof(TimeService));
        }

        protected override void OnStart(string[] args)
        {
            myHost.Open();
        }
        protected override void OnStop()
        {
            myHost.Close();
        }

    }
}
