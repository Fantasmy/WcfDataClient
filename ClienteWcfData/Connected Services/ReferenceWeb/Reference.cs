﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteWcfData.ReferenceWeb {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Students", Namespace="http://schemas.datacontract.org/2004/07/WcfData.Model")]
    [System.SerializableAttribute()]
    public partial class Students : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string surnameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string surname {
            get {
                return this.surnameField;
            }
            set {
                if ((object.ReferenceEquals(this.surnameField, value) != true)) {
                    this.surnameField = value;
                    this.RaisePropertyChanged("surname");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ReferenceWeb.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAll", ReplyAction="http://tempuri.org/IService1/GetAllResponse")]
        System.Collections.Generic.List<ClienteWcfData.ReferenceWeb.Students> GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAll", ReplyAction="http://tempuri.org/IService1/GetAllResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ClienteWcfData.ReferenceWeb.Students>> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetById", ReplyAction="http://tempuri.org/IService1/GetByIdResponse")]
        ClienteWcfData.ReferenceWeb.Students GetById(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetById", ReplyAction="http://tempuri.org/IService1/GetByIdResponse")]
        System.Threading.Tasks.Task<ClienteWcfData.ReferenceWeb.Students> GetByIdAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Post", ReplyAction="http://tempuri.org/IService1/PostResponse")]
        ClienteWcfData.ReferenceWeb.Students Post(ClienteWcfData.ReferenceWeb.Students student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Post", ReplyAction="http://tempuri.org/IService1/PostResponse")]
        System.Threading.Tasks.Task<ClienteWcfData.ReferenceWeb.Students> PostAsync(ClienteWcfData.ReferenceWeb.Students student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Put", ReplyAction="http://tempuri.org/IService1/PutResponse")]
        ClienteWcfData.ReferenceWeb.Students Put(System.Guid guid, ClienteWcfData.ReferenceWeb.Students student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Put", ReplyAction="http://tempuri.org/IService1/PutResponse")]
        System.Threading.Tasks.Task<ClienteWcfData.ReferenceWeb.Students> PutAsync(System.Guid guid, ClienteWcfData.ReferenceWeb.Students student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete", ReplyAction="http://tempuri.org/IService1/DeleteResponse")]
        bool Delete(System.Guid guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete", ReplyAction="http://tempuri.org/IService1/DeleteResponse")]
        System.Threading.Tasks.Task<bool> DeleteAsync(System.Guid guid);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ClienteWcfData.ReferenceWeb.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ClienteWcfData.ReferenceWeb.IService1>, ClienteWcfData.ReferenceWeb.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<ClienteWcfData.ReferenceWeb.Students> GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ClienteWcfData.ReferenceWeb.Students>> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public ClienteWcfData.ReferenceWeb.Students GetById(System.Guid id) {
            return base.Channel.GetById(id);
        }
        
        public System.Threading.Tasks.Task<ClienteWcfData.ReferenceWeb.Students> GetByIdAsync(System.Guid id) {
            return base.Channel.GetByIdAsync(id);
        }
        
        public ClienteWcfData.ReferenceWeb.Students Post(ClienteWcfData.ReferenceWeb.Students student) {
            return base.Channel.Post(student);
        }
        
        public System.Threading.Tasks.Task<ClienteWcfData.ReferenceWeb.Students> PostAsync(ClienteWcfData.ReferenceWeb.Students student) {
            return base.Channel.PostAsync(student);
        }
        
        public ClienteWcfData.ReferenceWeb.Students Put(System.Guid guid, ClienteWcfData.ReferenceWeb.Students student) {
            return base.Channel.Put(guid, student);
        }
        
        public System.Threading.Tasks.Task<ClienteWcfData.ReferenceWeb.Students> PutAsync(System.Guid guid, ClienteWcfData.ReferenceWeb.Students student) {
            return base.Channel.PutAsync(guid, student);
        }
        
        public bool Delete(System.Guid guid) {
            return base.Channel.Delete(guid);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAsync(System.Guid guid) {
            return base.Channel.DeleteAsync(guid);
        }
    }
}
