using System;
using System.Collections.Generic;
using System.Text;

namespace SharedObject
{
    public class SharedObject
    {
        public string Greeting(string name)
        {
            return ("New SharedObject says Hi: " + name);
        }
    }

}
