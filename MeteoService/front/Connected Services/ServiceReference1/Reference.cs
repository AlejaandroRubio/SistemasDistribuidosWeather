﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace front.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CondicionesActuales", Namespace="http://schemas.datacontract.org/2004/07/MeteoService")]
    [System.SerializableAttribute()]
    public partial class CondicionesActuales : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TemperatureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WindField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Temperature {
            get {
                return this.TemperatureField;
            }
            set {
                if ((object.ReferenceEquals(this.TemperatureField, value) != true)) {
                    this.TemperatureField = value;
                    this.RaisePropertyChanged("Temperature");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Wind {
            get {
                return this.WindField;
            }
            set {
                if ((object.ReferenceEquals(this.WindField, value) != true)) {
                    this.WindField = value;
                    this.RaisePropertyChanged("Wind");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMeteoServicesvc")]
    public interface IMeteoServicesvc {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeteoServicesvc/GetCondicionesActuales", ReplyAction="http://tempuri.org/IMeteoServicesvc/GetCondicionesActualesResponse")]
        front.ServiceReference1.CondicionesActuales GetCondicionesActuales(string ciudad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeteoServicesvc/GetCondicionesActuales", ReplyAction="http://tempuri.org/IMeteoServicesvc/GetCondicionesActualesResponse")]
        System.Threading.Tasks.Task<front.ServiceReference1.CondicionesActuales> GetCondicionesActualesAsync(string ciudad);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMeteoServicesvcChannel : front.ServiceReference1.IMeteoServicesvc, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MeteoServicesvcClient : System.ServiceModel.ClientBase<front.ServiceReference1.IMeteoServicesvc>, front.ServiceReference1.IMeteoServicesvc {
        
        public MeteoServicesvcClient() {
        }
        
        public MeteoServicesvcClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MeteoServicesvcClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MeteoServicesvcClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MeteoServicesvcClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public front.ServiceReference1.CondicionesActuales GetCondicionesActuales(string ciudad) {
            return base.Channel.GetCondicionesActuales(ciudad);
        }
        
        public System.Threading.Tasks.Task<front.ServiceReference1.CondicionesActuales> GetCondicionesActualesAsync(string ciudad) {
            return base.Channel.GetCondicionesActualesAsync(ciudad);
        }
    }
}