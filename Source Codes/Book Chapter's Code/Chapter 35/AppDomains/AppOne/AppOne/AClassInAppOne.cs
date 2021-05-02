using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppOne
{
    class AClassInAppOne
    {
        		public AClassInAppOne(string Msg)
		{
			MessageBox.Show("Creating Instance with message = " +Msg+ " in AppDomain " + AppDomain.CurrentDomain.FriendlyName);
		}
		public void ASimpleMethod()
		{
		MessageBox.Show("Called In AppDomain " + AppDomain.CurrentDomain.FriendlyName);
		}

    }
}
