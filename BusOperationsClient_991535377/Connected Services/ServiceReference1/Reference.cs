﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusOperationsClient_991535377.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BusInfo", Namespace="http://schemas.datacontract.org/2004/07/FinalBusService_991535377")]
    [System.SerializableAttribute()]
    public partial class BusInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/FinalBusService_991535377")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IDBOperations")]
    public interface IDBOperations {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBOperations/AddBus", ReplyAction="http://tempuri.org/IDBOperations/AddBusResponse")]
        void AddBus(BusOperationsClient_991535377.ServiceReference1.BusInfo bus);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBOperations/AddBus", ReplyAction="http://tempuri.org/IDBOperations/AddBusResponse")]
        System.Threading.Tasks.Task AddBusAsync(BusOperationsClient_991535377.ServiceReference1.BusInfo bus);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBOperations/GetAllBus", ReplyAction="http://tempuri.org/IDBOperations/GetAllBusResponse")]
        BusOperationsClient_991535377.ServiceReference1.BusInfo[] GetAllBus();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBOperations/GetAllBus", ReplyAction="http://tempuri.org/IDBOperations/GetAllBusResponse")]
        System.Threading.Tasks.Task<BusOperationsClient_991535377.ServiceReference1.BusInfo[]> GetAllBusAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDBOperationsChannel : BusOperationsClient_991535377.ServiceReference1.IDBOperations, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DBOperationsClient : System.ServiceModel.ClientBase<BusOperationsClient_991535377.ServiceReference1.IDBOperations>, BusOperationsClient_991535377.ServiceReference1.IDBOperations {
        
        public DBOperationsClient() {
        }
        
        public DBOperationsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DBOperationsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DBOperationsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DBOperationsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddBus(BusOperationsClient_991535377.ServiceReference1.BusInfo bus) {
            base.Channel.AddBus(bus);
        }
        
        public System.Threading.Tasks.Task AddBusAsync(BusOperationsClient_991535377.ServiceReference1.BusInfo bus) {
            return base.Channel.AddBusAsync(bus);
        }
        
        public BusOperationsClient_991535377.ServiceReference1.BusInfo[] GetAllBus() {
            return base.Channel.GetAllBus();
        }
        
        public System.Threading.Tasks.Task<BusOperationsClient_991535377.ServiceReference1.BusInfo[]> GetAllBusAsync() {
            return base.Channel.GetAllBusAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IAuthenticateUser")]
    public interface IAuthenticateUser {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthenticateUser/GetAllUsers", ReplyAction="http://tempuri.org/IAuthenticateUser/GetAllUsersResponse")]
        BusOperationsClient_991535377.ServiceReference1.User[] GetAllUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthenticateUser/GetAllUsers", ReplyAction="http://tempuri.org/IAuthenticateUser/GetAllUsersResponse")]
        System.Threading.Tasks.Task<BusOperationsClient_991535377.ServiceReference1.User[]> GetAllUsersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuthenticateUserChannel : BusOperationsClient_991535377.ServiceReference1.IAuthenticateUser, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthenticateUserClient : System.ServiceModel.ClientBase<BusOperationsClient_991535377.ServiceReference1.IAuthenticateUser>, BusOperationsClient_991535377.ServiceReference1.IAuthenticateUser {
        
        public AuthenticateUserClient() {
        }
        
        public AuthenticateUserClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthenticateUserClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticateUserClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticateUserClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BusOperationsClient_991535377.ServiceReference1.User[] GetAllUsers() {
            return base.Channel.GetAllUsers();
        }
        
        public System.Threading.Tasks.Task<BusOperationsClient_991535377.ServiceReference1.User[]> GetAllUsersAsync() {
            return base.Channel.GetAllUsersAsync();
        }
    }
}
