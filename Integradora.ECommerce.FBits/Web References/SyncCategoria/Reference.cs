﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Integradora.ECommerce.FBits.SyncCategoria {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SyncCategoriaSoap", Namespace="http://tempuri.org/")]
    public partial class SyncCategoria : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback InsertOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetItemsOperationCompleted;
        
        private System.Threading.SendOrPostCallback SelectOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetCategoriaIdByCodigoCategoriaInternoOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetListaCategoriaIdByCodigoCategoriaInternoOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SyncCategoria() {
            this.Url = global::Integradora.ECommerce.FBits.Properties.Settings.Default.Integradora_ECommerce_FBits_SyncCategoria;
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
        public event GetItemsCompletedEventHandler GetItemsCompleted;
        
        /// <remarks/>
        public event SelectCompletedEventHandler SelectCompleted;
        
        /// <remarks/>
        public event GetCategoriaIdByCodigoCategoriaInternoCompletedEventHandler GetCategoriaIdByCodigoCategoriaInternoCompleted;
        
        /// <remarks/>
        public event GetListaCategoriaIdByCodigoCategoriaInternoCompletedEventHandler GetListaCategoriaIdByCodigoCategoriaInternoCompleted;
        
        /// <remarks/>
        public event DeleteCompletedEventHandler DeleteCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Insert", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Insert(string token, IntegracaoCategoriaInfo obj) {
            object[] results = this.Invoke("Insert", new object[] {
                        token,
                        obj});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void InsertAsync(string token, IntegracaoCategoriaInfo obj) {
            this.InsertAsync(token, obj, null);
        }
        
        /// <remarks/>
        public void InsertAsync(string token, IntegracaoCategoriaInfo obj, object userState) {
            if ((this.InsertOperationCompleted == null)) {
                this.InsertOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertOperationCompleted);
            }
            this.InvokeAsync("Insert", new object[] {
                        token,
                        obj}, this.InsertOperationCompleted, userState);
        }
        
        private void OnInsertOperationCompleted(object arg) {
            if ((this.InsertCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertCompleted(this, new InsertCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetItems", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public IntegracaoCategoriaInfo[] GetItems(string token) {
            object[] results = this.Invoke("GetItems", new object[] {
                        token});
            return ((IntegracaoCategoriaInfo[])(results[0]));
        }
        
        /// <remarks/>
        public void GetItemsAsync(string token) {
            this.GetItemsAsync(token, null);
        }
        
        /// <remarks/>
        public void GetItemsAsync(string token, object userState) {
            if ((this.GetItemsOperationCompleted == null)) {
                this.GetItemsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetItemsOperationCompleted);
            }
            this.InvokeAsync("GetItems", new object[] {
                        token}, this.GetItemsOperationCompleted, userState);
        }
        
        private void OnGetItemsOperationCompleted(object arg) {
            if ((this.GetItemsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetItemsCompleted(this, new GetItemsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Select", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public IntegracaoCategoriaInfo Select(string token, string categoriaClienteId) {
            object[] results = this.Invoke("Select", new object[] {
                        token,
                        categoriaClienteId});
            return ((IntegracaoCategoriaInfo)(results[0]));
        }
        
        /// <remarks/>
        public void SelectAsync(string token, string categoriaClienteId) {
            this.SelectAsync(token, categoriaClienteId, null);
        }
        
        /// <remarks/>
        public void SelectAsync(string token, string categoriaClienteId, object userState) {
            if ((this.SelectOperationCompleted == null)) {
                this.SelectOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSelectOperationCompleted);
            }
            this.InvokeAsync("Select", new object[] {
                        token,
                        categoriaClienteId}, this.SelectOperationCompleted, userState);
        }
        
        private void OnSelectOperationCompleted(object arg) {
            if ((this.SelectCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SelectCompleted(this, new SelectCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetCategoriaIdByCodigoCategoriaInterno", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public IntegracaoCategoriaSelectInfo[] GetCategoriaIdByCodigoCategoriaInterno(string token, string categoriaInternoId) {
            object[] results = this.Invoke("GetCategoriaIdByCodigoCategoriaInterno", new object[] {
                        token,
                        categoriaInternoId});
            return ((IntegracaoCategoriaSelectInfo[])(results[0]));
        }
        
        /// <remarks/>
        public void GetCategoriaIdByCodigoCategoriaInternoAsync(string token, string categoriaInternoId) {
            this.GetCategoriaIdByCodigoCategoriaInternoAsync(token, categoriaInternoId, null);
        }
        
        /// <remarks/>
        public void GetCategoriaIdByCodigoCategoriaInternoAsync(string token, string categoriaInternoId, object userState) {
            if ((this.GetCategoriaIdByCodigoCategoriaInternoOperationCompleted == null)) {
                this.GetCategoriaIdByCodigoCategoriaInternoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCategoriaIdByCodigoCategoriaInternoOperationCompleted);
            }
            this.InvokeAsync("GetCategoriaIdByCodigoCategoriaInterno", new object[] {
                        token,
                        categoriaInternoId}, this.GetCategoriaIdByCodigoCategoriaInternoOperationCompleted, userState);
        }
        
        private void OnGetCategoriaIdByCodigoCategoriaInternoOperationCompleted(object arg) {
            if ((this.GetCategoriaIdByCodigoCategoriaInternoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCategoriaIdByCodigoCategoriaInternoCompleted(this, new GetCategoriaIdByCodigoCategoriaInternoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetListaCategoriaIdByCodigoCategoriaInterno", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public IntegracaoCategoriaSelectInfo[] GetListaCategoriaIdByCodigoCategoriaInterno(string token, string[] categoriaInternoId) {
            object[] results = this.Invoke("GetListaCategoriaIdByCodigoCategoriaInterno", new object[] {
                        token,
                        categoriaInternoId});
            return ((IntegracaoCategoriaSelectInfo[])(results[0]));
        }
        
        /// <remarks/>
        public void GetListaCategoriaIdByCodigoCategoriaInternoAsync(string token, string[] categoriaInternoId) {
            this.GetListaCategoriaIdByCodigoCategoriaInternoAsync(token, categoriaInternoId, null);
        }
        
        /// <remarks/>
        public void GetListaCategoriaIdByCodigoCategoriaInternoAsync(string token, string[] categoriaInternoId, object userState) {
            if ((this.GetListaCategoriaIdByCodigoCategoriaInternoOperationCompleted == null)) {
                this.GetListaCategoriaIdByCodigoCategoriaInternoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetListaCategoriaIdByCodigoCategoriaInternoOperationCompleted);
            }
            this.InvokeAsync("GetListaCategoriaIdByCodigoCategoriaInterno", new object[] {
                        token,
                        categoriaInternoId}, this.GetListaCategoriaIdByCodigoCategoriaInternoOperationCompleted, userState);
        }
        
        private void OnGetListaCategoriaIdByCodigoCategoriaInternoOperationCompleted(object arg) {
            if ((this.GetListaCategoriaIdByCodigoCategoriaInternoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetListaCategoriaIdByCodigoCategoriaInternoCompleted(this, new GetListaCategoriaIdByCodigoCategoriaInternoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Delete", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Delete(string token, string categoriaClienteId) {
            object[] results = this.Invoke("Delete", new object[] {
                        token,
                        categoriaClienteId});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void DeleteAsync(string token, string categoriaClienteId) {
            this.DeleteAsync(token, categoriaClienteId, null);
        }
        
        /// <remarks/>
        public void DeleteAsync(string token, string categoriaClienteId, object userState) {
            if ((this.DeleteOperationCompleted == null)) {
                this.DeleteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteOperationCompleted);
            }
            this.InvokeAsync("Delete", new object[] {
                        token,
                        categoriaClienteId}, this.DeleteOperationCompleted, userState);
        }
        
        private void OnDeleteOperationCompleted(object arg) {
            if ((this.DeleteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteCompleted(this, new DeleteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class IntegracaoCategoriaInfo {
        
        private string nomeField;
        
        private string categoriaClientePaiIdField;
        
        private string categoriaClienteIdField;
        
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
        public string CategoriaClientePaiId {
            get {
                return this.categoriaClientePaiIdField;
            }
            set {
                this.categoriaClientePaiIdField = value;
            }
        }
        
        /// <remarks/>
        public string CategoriaClienteId {
            get {
                return this.categoriaClienteIdField;
            }
            set {
                this.categoriaClienteIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class IntegracaoCategoriaSelectInfo {
        
        private int categoriaIdField;
        
        private string categoriaClienteIdField;
        
        /// <remarks/>
        public int CategoriaId {
            get {
                return this.categoriaIdField;
            }
            set {
                this.categoriaIdField = value;
            }
        }
        
        /// <remarks/>
        public string CategoriaClienteId {
            get {
                return this.categoriaClienteIdField;
            }
            set {
                this.categoriaClienteIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void InsertCompletedEventHandler(object sender, InsertCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void GetItemsCompletedEventHandler(object sender, GetItemsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetItemsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetItemsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public IntegracaoCategoriaInfo[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((IntegracaoCategoriaInfo[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void SelectCompletedEventHandler(object sender, SelectCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SelectCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SelectCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public IntegracaoCategoriaInfo Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((IntegracaoCategoriaInfo)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void GetCategoriaIdByCodigoCategoriaInternoCompletedEventHandler(object sender, GetCategoriaIdByCodigoCategoriaInternoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCategoriaIdByCodigoCategoriaInternoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCategoriaIdByCodigoCategoriaInternoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public IntegracaoCategoriaSelectInfo[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((IntegracaoCategoriaSelectInfo[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void GetListaCategoriaIdByCodigoCategoriaInternoCompletedEventHandler(object sender, GetListaCategoriaIdByCodigoCategoriaInternoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetListaCategoriaIdByCodigoCategoriaInternoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetListaCategoriaIdByCodigoCategoriaInternoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public IntegracaoCategoriaSelectInfo[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((IntegracaoCategoriaSelectInfo[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void DeleteCompletedEventHandler(object sender, DeleteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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