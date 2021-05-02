using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrivateAssembly
{
    public class Class1
    {
        public void Display(string Message)
        {
            MessageBox.Show(Message);
        }
    }
    public class Class2
    {
        public void Display(string Message)
        {
            MessageBox.Show(Message, "", MessageBoxButtons.OK,    MessageBoxIcon.Exclamation);
        }
    }
}
