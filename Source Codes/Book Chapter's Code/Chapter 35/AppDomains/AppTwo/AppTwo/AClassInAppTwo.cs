using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppTwo
{
	[SerializableAttribute()]
	public class AClassInAppTwo: MarshalByRefObject
	{
		public AClassInAppTwo(string Msg)
		{
			MessageBox.Show("Creating Instance with message = " + Msg + " in AppDomain " + AppDomain.CurrentDomain.FriendlyName);
		}
		public void ASimpleMethod()
		{
		MessageBox.Show("Called in AppDomain " + AppDomain.CurrentDomain.FriendlyName);
		}
    }
}
