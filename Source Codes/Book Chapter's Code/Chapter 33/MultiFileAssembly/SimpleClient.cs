using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SimpleClient
{
	class SimpleClient
	{
		public static void Main()
		{
			Class1.Class1 c1 = new Class1.Class1();
			c1.Greeting("SimpleClient");
			Class2.Class2 c2 = new Class2.Class2();
			c2.Greeting("SimpleClient");
		}
	}
}
	
