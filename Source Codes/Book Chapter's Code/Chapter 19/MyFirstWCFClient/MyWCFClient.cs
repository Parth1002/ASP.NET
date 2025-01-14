﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Runtime.Serialization;



[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
[System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/")]
public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject
{
    
    private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
    
    private bool BoolValueField;
    
    private string StringValueField;
    
    public System.Runtime.Serialization.ExtensionDataObject ExtensionData
    {
        get
        {
            return this.extensionDataField;
        }
        set
        {
            this.extensionDataField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute()]
    public bool BoolValue
    {
        get
        {
            return this.BoolValueField;
        }
        set
        {
            this.BoolValueField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string StringValue
    {
        get
        {
            return this.StringValueField;
        }
        set
        {
            this.StringValueField = value;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IService")]
public interface IService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
    string GetData(int value);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService/GetDataUsingDataContractResponse")]
    CompositeType GetDataUsingDataContract(CompositeType composite);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SquareRoot", ReplyAction="http://tempuri.org/IService/SquareRootResponse")]
    double SquareRoot(double Number);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CubeRoot", ReplyAction="http://tempuri.org/IService/CubeRootResponse")]
    double CubeRoot(double Number1);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IServiceChannel : IService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class ServiceClient : System.ServiceModel.ClientBase<IService>, IService
{
    
    public ServiceClient()
    {
    }
    
    public ServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string GetData(int value)
    {
        return base.Channel.GetData(value);
    }
    
    public CompositeType GetDataUsingDataContract(CompositeType composite)
    {
        return base.Channel.GetDataUsingDataContract(composite);
    }
    
    public double SquareRoot(double Number)
    {
        return base.Channel.SquareRoot(Number);
    }
    
    public double CubeRoot(double Number1)
    {
        return base.Channel.CubeRoot(Number1);
    }
}
