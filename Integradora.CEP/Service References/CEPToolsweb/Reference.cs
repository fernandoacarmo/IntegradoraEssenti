﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Integradora.CEP.CEPToolsweb {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CepVO", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class CepVO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CepField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoLogradouroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LogradouroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BairroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CidadeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensagemField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Cep {
            get {
                return this.CepField;
            }
            set {
                if ((object.ReferenceEquals(this.CepField, value) != true)) {
                    this.CepField = value;
                    this.RaisePropertyChanged("Cep");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string TipoLogradouro {
            get {
                return this.TipoLogradouroField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoLogradouroField, value) != true)) {
                    this.TipoLogradouroField = value;
                    this.RaisePropertyChanged("TipoLogradouro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Logradouro {
            get {
                return this.LogradouroField;
            }
            set {
                if ((object.ReferenceEquals(this.LogradouroField, value) != true)) {
                    this.LogradouroField = value;
                    this.RaisePropertyChanged("Logradouro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Bairro {
            get {
                return this.BairroField;
            }
            set {
                if ((object.ReferenceEquals(this.BairroField, value) != true)) {
                    this.BairroField = value;
                    this.RaisePropertyChanged("Bairro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Cidade {
            get {
                return this.CidadeField;
            }
            set {
                if ((object.ReferenceEquals(this.CidadeField, value) != true)) {
                    this.CidadeField = value;
                    this.RaisePropertyChanged("Cidade");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoField, value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string Mensagem {
            get {
                return this.MensagemField;
            }
            set {
                if ((object.ReferenceEquals(this.MensagemField, value) != true)) {
                    this.MensagemField = value;
                    this.RaisePropertyChanged("Mensagem");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CEPToolsweb.ServicoSoap")]
    public interface ServicoSoap {
        
        // CODEGEN: Generating message contract since element name cep from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObterCep", ReplyAction="*")]
        Integradora.CEP.CEPToolsweb.ObterCepResponse ObterCep(Integradora.CEP.CEPToolsweb.ObterCepRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObterCep", ReplyAction="*")]
        System.Threading.Tasks.Task<Integradora.CEP.CEPToolsweb.ObterCepResponse> ObterCepAsync(Integradora.CEP.CEPToolsweb.ObterCepRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObterCepRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObterCep", Namespace="http://tempuri.org/", Order=0)]
        public Integradora.CEP.CEPToolsweb.ObterCepRequestBody Body;
        
        public ObterCepRequest() {
        }
        
        public ObterCepRequest(Integradora.CEP.CEPToolsweb.ObterCepRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObterCepRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string cep;
        
        public ObterCepRequestBody() {
        }
        
        public ObterCepRequestBody(string cep) {
            this.cep = cep;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObterCepResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObterCepResponse", Namespace="http://tempuri.org/", Order=0)]
        public Integradora.CEP.CEPToolsweb.ObterCepResponseBody Body;
        
        public ObterCepResponse() {
        }
        
        public ObterCepResponse(Integradora.CEP.CEPToolsweb.ObterCepResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObterCepResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Integradora.CEP.CEPToolsweb.CepVO ObterCepResult;
        
        public ObterCepResponseBody() {
        }
        
        public ObterCepResponseBody(Integradora.CEP.CEPToolsweb.CepVO ObterCepResult) {
            this.ObterCepResult = ObterCepResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicoSoapChannel : Integradora.CEP.CEPToolsweb.ServicoSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicoSoapClient : System.ServiceModel.ClientBase<Integradora.CEP.CEPToolsweb.ServicoSoap>, Integradora.CEP.CEPToolsweb.ServicoSoap {
        
        public ServicoSoapClient() {
        }
        
        public ServicoSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicoSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Integradora.CEP.CEPToolsweb.ObterCepResponse Integradora.CEP.CEPToolsweb.ServicoSoap.ObterCep(Integradora.CEP.CEPToolsweb.ObterCepRequest request) {
            return base.Channel.ObterCep(request);
        }
        
        public Integradora.CEP.CEPToolsweb.CepVO ObterCep(string cep) {
            Integradora.CEP.CEPToolsweb.ObterCepRequest inValue = new Integradora.CEP.CEPToolsweb.ObterCepRequest();
            inValue.Body = new Integradora.CEP.CEPToolsweb.ObterCepRequestBody();
            inValue.Body.cep = cep;
            Integradora.CEP.CEPToolsweb.ObterCepResponse retVal = ((Integradora.CEP.CEPToolsweb.ServicoSoap)(this)).ObterCep(inValue);
            return retVal.Body.ObterCepResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Integradora.CEP.CEPToolsweb.ObterCepResponse> Integradora.CEP.CEPToolsweb.ServicoSoap.ObterCepAsync(Integradora.CEP.CEPToolsweb.ObterCepRequest request) {
            return base.Channel.ObterCepAsync(request);
        }
        
        public System.Threading.Tasks.Task<Integradora.CEP.CEPToolsweb.ObterCepResponse> ObterCepAsync(string cep) {
            Integradora.CEP.CEPToolsweb.ObterCepRequest inValue = new Integradora.CEP.CEPToolsweb.ObterCepRequest();
            inValue.Body = new Integradora.CEP.CEPToolsweb.ObterCepRequestBody();
            inValue.Body.cep = cep;
            return ((Integradora.CEP.CEPToolsweb.ServicoSoap)(this)).ObterCepAsync(inValue);
        }
    }
}
