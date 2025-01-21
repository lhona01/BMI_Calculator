﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SOAP_BMI.ServiceReference_SOAP {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BMI", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class BMI : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private double bmiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string riskField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string riskColorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SOAP_BMI.ServiceReference_SOAP.ArrayOfString externalLinkField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public double bmi {
            get {
                return this.bmiField;
            }
            set {
                if ((this.bmiField.Equals(value) != true)) {
                    this.bmiField = value;
                    this.RaisePropertyChanged("bmi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string risk {
            get {
                return this.riskField;
            }
            set {
                if ((object.ReferenceEquals(this.riskField, value) != true)) {
                    this.riskField = value;
                    this.RaisePropertyChanged("risk");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string riskColor {
            get {
                return this.riskColorField;
            }
            set {
                if ((object.ReferenceEquals(this.riskColorField, value) != true)) {
                    this.riskColorField = value;
                    this.RaisePropertyChanged("riskColor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public SOAP_BMI.ServiceReference_SOAP.ArrayOfString externalLink {
            get {
                return this.externalLinkField;
            }
            set {
                if ((object.ReferenceEquals(this.externalLinkField, value) != true)) {
                    this.externalLinkField = value;
                    this.RaisePropertyChanged("externalLink");
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
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference_SOAP.soap_BMISoap")]
    public interface soap_BMISoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getBMI", ReplyAction="*")]
        double getBMI(int height, int weight);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getBMI", ReplyAction="*")]
        System.Threading.Tasks.Task<double> getBMIAsync(int height, int weight);
        
        // CODEGEN: Generating message contract since element name myHealthResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/myHealth", ReplyAction="*")]
        SOAP_BMI.ServiceReference_SOAP.myHealthResponse myHealth(SOAP_BMI.ServiceReference_SOAP.myHealthRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/myHealth", ReplyAction="*")]
        System.Threading.Tasks.Task<SOAP_BMI.ServiceReference_SOAP.myHealthResponse> myHealthAsync(SOAP_BMI.ServiceReference_SOAP.myHealthRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class myHealthRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="myHealth", Namespace="http://tempuri.org/", Order=0)]
        public SOAP_BMI.ServiceReference_SOAP.myHealthRequestBody Body;
        
        public myHealthRequest() {
        }
        
        public myHealthRequest(SOAP_BMI.ServiceReference_SOAP.myHealthRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class myHealthRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int height;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int weight;
        
        public myHealthRequestBody() {
        }
        
        public myHealthRequestBody(int height, int weight) {
            this.height = height;
            this.weight = weight;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class myHealthResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="myHealthResponse", Namespace="http://tempuri.org/", Order=0)]
        public SOAP_BMI.ServiceReference_SOAP.myHealthResponseBody Body;
        
        public myHealthResponse() {
        }
        
        public myHealthResponse(SOAP_BMI.ServiceReference_SOAP.myHealthResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class myHealthResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public SOAP_BMI.ServiceReference_SOAP.BMI myHealthResult;
        
        public myHealthResponseBody() {
        }
        
        public myHealthResponseBody(SOAP_BMI.ServiceReference_SOAP.BMI myHealthResult) {
            this.myHealthResult = myHealthResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface soap_BMISoapChannel : SOAP_BMI.ServiceReference_SOAP.soap_BMISoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class soap_BMISoapClient : System.ServiceModel.ClientBase<SOAP_BMI.ServiceReference_SOAP.soap_BMISoap>, SOAP_BMI.ServiceReference_SOAP.soap_BMISoap {
        
        public soap_BMISoapClient() {
        }
        
        public soap_BMISoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public soap_BMISoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public soap_BMISoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public soap_BMISoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double getBMI(int height, int weight) {
            return base.Channel.getBMI(height, weight);
        }
        
        public System.Threading.Tasks.Task<double> getBMIAsync(int height, int weight) {
            return base.Channel.getBMIAsync(height, weight);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SOAP_BMI.ServiceReference_SOAP.myHealthResponse SOAP_BMI.ServiceReference_SOAP.soap_BMISoap.myHealth(SOAP_BMI.ServiceReference_SOAP.myHealthRequest request) {
            return base.Channel.myHealth(request);
        }
        
        public SOAP_BMI.ServiceReference_SOAP.BMI myHealth(int height, int weight) {
            SOAP_BMI.ServiceReference_SOAP.myHealthRequest inValue = new SOAP_BMI.ServiceReference_SOAP.myHealthRequest();
            inValue.Body = new SOAP_BMI.ServiceReference_SOAP.myHealthRequestBody();
            inValue.Body.height = height;
            inValue.Body.weight = weight;
            SOAP_BMI.ServiceReference_SOAP.myHealthResponse retVal = ((SOAP_BMI.ServiceReference_SOAP.soap_BMISoap)(this)).myHealth(inValue);
            return retVal.Body.myHealthResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SOAP_BMI.ServiceReference_SOAP.myHealthResponse> SOAP_BMI.ServiceReference_SOAP.soap_BMISoap.myHealthAsync(SOAP_BMI.ServiceReference_SOAP.myHealthRequest request) {
            return base.Channel.myHealthAsync(request);
        }
        
        public System.Threading.Tasks.Task<SOAP_BMI.ServiceReference_SOAP.myHealthResponse> myHealthAsync(int height, int weight) {
            SOAP_BMI.ServiceReference_SOAP.myHealthRequest inValue = new SOAP_BMI.ServiceReference_SOAP.myHealthRequest();
            inValue.Body = new SOAP_BMI.ServiceReference_SOAP.myHealthRequestBody();
            inValue.Body.height = height;
            inValue.Body.weight = weight;
            return ((SOAP_BMI.ServiceReference_SOAP.soap_BMISoap)(this)).myHealthAsync(inValue);
        }
    }
}
