using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.Remoting;


namespace AppOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppDomain SecondAppDomaing = AppDomain.CreateDomain("Second AppDomain");
            SecondAppDomaing.ExecuteAssembly("AppTwo.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AClassInAppOne LocObj = new AClassInAppOne(" - " + AppDomain.CurrentDomain.FriendlyName+ " says Hi!-");
            LocObj.ASimpleMethod();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppDomain SecondAppDomaing = AppDomain.CreateDomain("Second AppDomain");
            ObjectHandle objH = SecondAppDomaing.CreateInstance("AppTwo", "AppTwo.AClassInAppTwo",
            true, BindingFlags.CreateInstance, null, new object[]{" - " 
	+AppDomain.CurrentDomain.FriendlyName+ " says Hi!-"}, null, null, null);
            object obj = objH.Unwrap();
            ((AppTwo.AClassInAppTwo)obj).ASimpleMethod();

        }

    }
}
