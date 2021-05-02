using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract(Namespace = "http://tempuri.org/")]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class OperationService
{
    [OperationContract]
    public double Add(double Number1, double Number2)
    {
        return Number1 + Number2;
    }
    [OperationContract]
    public double Subtract(double Number1, double Number2)
    {
        return Number1 - Number2;
    }
    [OperationContract]
    public double Multiply(double Number1, double Number2)
    {
        return Number1 * Number2;
    }
    [OperationContract]
    public double Divide(double Number1, double Number2)
    {
        return Number1 / Number2;
    }

}
