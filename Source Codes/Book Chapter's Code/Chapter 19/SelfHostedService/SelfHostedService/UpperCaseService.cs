using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SelfHostedService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UpperCaseService" in both code and config file together.
    public class UpperCaseService : IUpperCaseService
    {
        public string upperCase(string inputString)
        {
            string outputString = inputString.ToUpper();
            return outputString;
        }
    }
}
