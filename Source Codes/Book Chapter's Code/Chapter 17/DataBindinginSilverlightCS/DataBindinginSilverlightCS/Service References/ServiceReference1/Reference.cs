﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 3.0.40818.0
// 
namespace DataBindinginSilverlightCS.ServiceReference1 {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/DataBindinginSilverlightCS.Web")]
    public partial class Employee : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int EmployeeIDField;
        
        private string LastNameField;
        
        private string FirstNameField;
        
        private string TitleField;
        
        private string TitleOfCourtesyField;
        
        private System.Nullable<System.DateTime> BirthDateField;
        
        private System.Nullable<System.DateTime> HireDateField;
        
        private string AddressField;
        
        private string CityField;
        
        private string RegionField;
        
        private string PostalCodeField;
        
        private string CountryField;
        
        private string HomePhoneField;
        
        private string ExtensionField;
        
        private DataBindinginSilverlightCS.ServiceReference1.Binary PhotoField;
        
        private string NotesField;
        
        private System.Nullable<int> ReportsToField;
        
        private string PhotoPathField;
        
        private System.Collections.ObjectModel.ObservableCollection<DataBindinginSilverlightCS.ServiceReference1.Employee> EmployeesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EmployeeID {
            get {
                return this.EmployeeIDField;
            }
            set {
                if ((this.EmployeeIDField.Equals(value) != true)) {
                    this.EmployeeIDField = value;
                    this.RaisePropertyChanged("EmployeeID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public string TitleOfCourtesy {
            get {
                return this.TitleOfCourtesyField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleOfCourtesyField, value) != true)) {
                    this.TitleOfCourtesyField = value;
                    this.RaisePropertyChanged("TitleOfCourtesy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public System.Nullable<System.DateTime> BirthDate {
            get {
                return this.BirthDateField;
            }
            set {
                if ((this.BirthDateField.Equals(value) != true)) {
                    this.BirthDateField = value;
                    this.RaisePropertyChanged("BirthDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public System.Nullable<System.DateTime> HireDate {
            get {
                return this.HireDateField;
            }
            set {
                if ((this.HireDateField.Equals(value) != true)) {
                    this.HireDateField = value;
                    this.RaisePropertyChanged("HireDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=7)]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=8)]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=9)]
        public string Region {
            get {
                return this.RegionField;
            }
            set {
                if ((object.ReferenceEquals(this.RegionField, value) != true)) {
                    this.RegionField = value;
                    this.RaisePropertyChanged("Region");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=10)]
        public string PostalCode {
            get {
                return this.PostalCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.PostalCodeField, value) != true)) {
                    this.PostalCodeField = value;
                    this.RaisePropertyChanged("PostalCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=11)]
        public string Country {
            get {
                return this.CountryField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryField, value) != true)) {
                    this.CountryField = value;
                    this.RaisePropertyChanged("Country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=12)]
        public string HomePhone {
            get {
                return this.HomePhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.HomePhoneField, value) != true)) {
                    this.HomePhoneField = value;
                    this.RaisePropertyChanged("HomePhone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=13)]
        public string Extension {
            get {
                return this.ExtensionField;
            }
            set {
                if ((object.ReferenceEquals(this.ExtensionField, value) != true)) {
                    this.ExtensionField = value;
                    this.RaisePropertyChanged("Extension");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=14)]
        public DataBindinginSilverlightCS.ServiceReference1.Binary Photo {
            get {
                return this.PhotoField;
            }
            set {
                if ((object.ReferenceEquals(this.PhotoField, value) != true)) {
                    this.PhotoField = value;
                    this.RaisePropertyChanged("Photo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=15)]
        public string Notes {
            get {
                return this.NotesField;
            }
            set {
                if ((object.ReferenceEquals(this.NotesField, value) != true)) {
                    this.NotesField = value;
                    this.RaisePropertyChanged("Notes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=16)]
        public System.Nullable<int> ReportsTo {
            get {
                return this.ReportsToField;
            }
            set {
                if ((this.ReportsToField.Equals(value) != true)) {
                    this.ReportsToField = value;
                    this.RaisePropertyChanged("ReportsTo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=17)]
        public string PhotoPath {
            get {
                return this.PhotoPathField;
            }
            set {
                if ((object.ReferenceEquals(this.PhotoPathField, value) != true)) {
                    this.PhotoPathField = value;
                    this.RaisePropertyChanged("PhotoPath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=18)]
        public System.Collections.ObjectModel.ObservableCollection<DataBindinginSilverlightCS.ServiceReference1.Employee> Employees {
            get {
                return this.EmployeesField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeesField, value) != true)) {
                    this.EmployeesField = value;
                    this.RaisePropertyChanged("Employees");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Binary", Namespace="http://schemas.datacontract.org/2004/07/System.Data.Linq")]
    public partial class Binary : object, System.ComponentModel.INotifyPropertyChanged {
        
        private byte[] BytesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Bytes {
            get {
                return this.BytesField;
            }
            set {
                if ((object.ReferenceEquals(this.BytesField, value) != true)) {
                    this.BytesField = value;
                    this.RaisePropertyChanged("Bytes");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMyService")]
    public interface IMyService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IMyService/GetByLastName", ReplyAction="http://tempuri.org/IMyService/GetByLastNameResponse")]
        System.IAsyncResult BeginGetByLastName(string lastname, System.AsyncCallback callback, object asyncState);
        
        System.Collections.ObjectModel.ObservableCollection<DataBindinginSilverlightCS.ServiceReference1.Employee> EndGetByLastName(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyServiceChannel : DataBindinginSilverlightCS.ServiceReference1.IMyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetByLastNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetByLastNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.ObjectModel.ObservableCollection<DataBindinginSilverlightCS.ServiceReference1.Employee> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.ObjectModel.ObservableCollection<DataBindinginSilverlightCS.ServiceReference1.Employee>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyServiceClient : System.ServiceModel.ClientBase<DataBindinginSilverlightCS.ServiceReference1.IMyService>, DataBindinginSilverlightCS.ServiceReference1.IMyService {
        
        private BeginOperationDelegate onBeginGetByLastNameDelegate;
        
        private EndOperationDelegate onEndGetByLastNameDelegate;
        
        private System.Threading.SendOrPostCallback onGetByLastNameCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public MyServiceClient() {
        }
        
        public MyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<GetByLastNameCompletedEventArgs> GetByLastNameCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult DataBindinginSilverlightCS.ServiceReference1.IMyService.BeginGetByLastName(string lastname, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetByLastName(lastname, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.ObjectModel.ObservableCollection<DataBindinginSilverlightCS.ServiceReference1.Employee> DataBindinginSilverlightCS.ServiceReference1.IMyService.EndGetByLastName(System.IAsyncResult result) {
            return base.Channel.EndGetByLastName(result);
        }
        
        private System.IAsyncResult OnBeginGetByLastName(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string lastname = ((string)(inValues[0]));
            return ((DataBindinginSilverlightCS.ServiceReference1.IMyService)(this)).BeginGetByLastName(lastname, callback, asyncState);
        }
        
        private object[] OnEndGetByLastName(System.IAsyncResult result) {
            System.Collections.ObjectModel.ObservableCollection<DataBindinginSilverlightCS.ServiceReference1.Employee> retVal = ((DataBindinginSilverlightCS.ServiceReference1.IMyService)(this)).EndGetByLastName(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetByLastNameCompleted(object state) {
            if ((this.GetByLastNameCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetByLastNameCompleted(this, new GetByLastNameCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetByLastNameAsync(string lastname) {
            this.GetByLastNameAsync(lastname, null);
        }
        
        public void GetByLastNameAsync(string lastname, object userState) {
            if ((this.onBeginGetByLastNameDelegate == null)) {
                this.onBeginGetByLastNameDelegate = new BeginOperationDelegate(this.OnBeginGetByLastName);
            }
            if ((this.onEndGetByLastNameDelegate == null)) {
                this.onEndGetByLastNameDelegate = new EndOperationDelegate(this.OnEndGetByLastName);
            }
            if ((this.onGetByLastNameCompletedDelegate == null)) {
                this.onGetByLastNameCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetByLastNameCompleted);
            }
            base.InvokeAsync(this.onBeginGetByLastNameDelegate, new object[] {
                        lastname}, this.onEndGetByLastNameDelegate, this.onGetByLastNameCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override DataBindinginSilverlightCS.ServiceReference1.IMyService CreateChannel() {
            return new MyServiceClientChannel(this);
        }
        
        private class MyServiceClientChannel : ChannelBase<DataBindinginSilverlightCS.ServiceReference1.IMyService>, DataBindinginSilverlightCS.ServiceReference1.IMyService {
            
            public MyServiceClientChannel(System.ServiceModel.ClientBase<DataBindinginSilverlightCS.ServiceReference1.IMyService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetByLastName(string lastname, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = lastname;
                System.IAsyncResult _result = base.BeginInvoke("GetByLastName", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.ObjectModel.ObservableCollection<DataBindinginSilverlightCS.ServiceReference1.Employee> EndGetByLastName(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.ObjectModel.ObservableCollection<DataBindinginSilverlightCS.ServiceReference1.Employee> _result = ((System.Collections.ObjectModel.ObservableCollection<DataBindinginSilverlightCS.ServiceReference1.Employee>)(base.EndInvoke("GetByLastName", _args, result)));
                return _result;
            }
        }
    }
}
