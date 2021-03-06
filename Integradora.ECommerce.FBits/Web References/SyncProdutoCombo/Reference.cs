﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34209.
// 
#pragma warning disable 1591

namespace Integradora.ECommerce.FBits.SyncProdutoCombo {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SyncProdutoComboSoap", Namespace="http://tempuri.org/")]
    public partial class SyncProdutoCombo : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback InsertOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SyncProdutoCombo() {
            this.Url = global::Integradora.ECommerce.FBits.Properties.Settings.Default.Integradora_ECommerce_FBits_SyncProdutoCombo;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event InsertCompletedEventHandler InsertCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Insert", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Insert(string token, IntegracaoProdutoCombo pData) {
            object[] results = this.Invoke("Insert", new object[] {
                        token,
                        pData});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void InsertAsync(string token, IntegracaoProdutoCombo pData) {
            this.InsertAsync(token, pData, null);
        }
        
        /// <remarks/>
        public void InsertAsync(string token, IntegracaoProdutoCombo pData, object userState) {
            if ((this.InsertOperationCompleted == null)) {
                this.InsertOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertOperationCompleted);
            }
            this.InvokeAsync("Insert", new object[] {
                        token,
                        pData}, this.InsertOperationCompleted, userState);
        }
        
        private void OnInsertOperationCompleted(object arg) {
            if ((this.InsertCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertCompleted(this, new InsertCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class IntegracaoProdutoCombo {
        
        private int fabricanteIdField;
        
        private string nomeField;
        
        private string urlVideoField;
        
        private System.Nullable<decimal> valorField;
        
        private IntegracaoProdutoComboComponente[] listaComponentesField;
        
        /// <remarks/>
        public int FabricanteId {
            get {
                return this.fabricanteIdField;
            }
            set {
                this.fabricanteIdField = value;
            }
        }
        
        /// <remarks/>
        public string Nome {
            get {
                return this.nomeField;
            }
            set {
                this.nomeField = value;
            }
        }
        
        /// <remarks/>
        public string urlVideo {
            get {
                return this.urlVideoField;
            }
            set {
                this.urlVideoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<decimal> Valor {
            get {
                return this.valorField;
            }
            set {
                this.valorField = value;
            }
        }
        
        /// <remarks/>
        public IntegracaoProdutoComboComponente[] ListaComponentes {
            get {
                return this.listaComponentesField;
            }
            set {
                this.listaComponentesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class IntegracaoProdutoComboComponente {
        
        private string sKUField;
        
        private int quantidadeField;
        
        private bool varianteField;
        
        /// <remarks/>
        public string SKU {
            get {
                return this.sKUField;
            }
            set {
                this.sKUField = value;
            }
        }
        
        /// <remarks/>
        public int Quantidade {
            get {
                return this.quantidadeField;
            }
            set {
                this.quantidadeField = value;
            }
        }
        
        /// <remarks/>
        public bool Variante {
            get {
                return this.varianteField;
            }
            set {
                this.varianteField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void InsertCompletedEventHandler(object sender, InsertCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InsertCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InsertCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591