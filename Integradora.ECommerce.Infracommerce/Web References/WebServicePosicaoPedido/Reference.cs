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

namespace Integradora.ECommerce.Infracommerce.WebServicePosicaoPedido {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="TrackingServicesBinding", Namespace="http://www.accurate.com/acec/TrackingServices")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(trackingProperty[]))]
    public partial class TrackingServicesMediator_ep : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback captureTrackingOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public TrackingServicesMediator_ep() {
            this.Url = global::Integradora.Biblioteca.Dictionaries.Settings.InfracommerceURL_Tracking();
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
        public event captureTrackingCompletedEventHandler captureTrackingCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("captureTracking", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("captureTrackingResponse", Namespace="http://www.accurate.com/acec/TrackingServices")]
        public captureTrackingResponse captureTracking([System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.accurate.com/acec/TrackingServices")] captureTrackingRequest captureTrackingRequest) {
            object[] results = this.Invoke("captureTracking", new object[] {
                        captureTrackingRequest});
            return ((captureTrackingResponse)(results[0]));
        }
        
        /// <remarks/>
        public void captureTrackingAsync(captureTrackingRequest captureTrackingRequest) {
            this.captureTrackingAsync(captureTrackingRequest, null);
        }
        
        /// <remarks/>
        public void captureTrackingAsync(captureTrackingRequest captureTrackingRequest, object userState) {
            if ((this.captureTrackingOperationCompleted == null)) {
                this.captureTrackingOperationCompleted = new System.Threading.SendOrPostCallback(this.OncaptureTrackingOperationCompleted);
            }
            this.InvokeAsync("captureTracking", new object[] {
                        captureTrackingRequest}, this.captureTrackingOperationCompleted, userState);
        }
        
        private void OncaptureTrackingOperationCompleted(object arg) {
            if ((this.captureTrackingCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.captureTrackingCompleted(this, new captureTrackingCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.accurate.com/acec/TrackingServices")]
    public partial class captureTrackingRequest {
        
        private Tracking[] trackingListField;
        
        private string storeIdField;
        
        private bool generateEventsInSameTransactionField;
        
        private bool generateEventsInSameTransactionFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://www.accurate.com/acec/Tracking")]
        [System.Xml.Serialization.XmlArrayItemAttribute("tracking", IsNullable=false)]
        public Tracking[] trackingList {
            get {
                return this.trackingListField;
            }
            set {
                this.trackingListField = value;
            }
        }
        
        /// <remarks/>
        public string storeId {
            get {
                return this.storeIdField;
            }
            set {
                this.storeIdField = value;
            }
        }
        
        /// <remarks/>
        public bool generateEventsInSameTransaction {
            get {
                return this.generateEventsInSameTransactionField;
            }
            set {
                this.generateEventsInSameTransactionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool generateEventsInSameTransactionSpecified {
            get {
                return this.generateEventsInSameTransactionFieldSpecified;
            }
            set {
                this.generateEventsInSameTransactionFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.accurate.com/acec/Tracking")]
    public partial class Tracking {
        
        private long orderIdField;
        
        private long deliveryIdField;
        
        private string controlPointIdField;
        
        private string controlPointNmField;
        
        private System.DateTime occurrenceDtField;
        
        private long carrierIdField;
        
        private bool carrierIdFieldSpecified;
        
        private string carrierNmField;
        
        private string contractIdField;
        
        private string receiverNmField;
        
        private string carrierMessageField;
        
        private System.DateTime adjustedDeliveryDtField;
        
        private bool adjustedDeliveryDtFieldSpecified;
        
        private string cTRCNumberField;
        
        private string carrierURLField;
        
        private string invoiceURLField;
        
        private InvoiceInfo invoiceInfoField;
        
        private trackingProperty[] trackingPropertyListField;
        
        /// <remarks/>
        public long orderId {
            get {
                return this.orderIdField;
            }
            set {
                this.orderIdField = value;
            }
        }
        
        /// <remarks/>
        public long deliveryId {
            get {
                return this.deliveryIdField;
            }
            set {
                this.deliveryIdField = value;
            }
        }
        
        /// <remarks/>
        public string controlPointId {
            get {
                return this.controlPointIdField;
            }
            set {
                this.controlPointIdField = value;
            }
        }
        
        /// <remarks/>
        public string controlPointNm {
            get {
                return this.controlPointNmField;
            }
            set {
                this.controlPointNmField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime occurrenceDt {
            get {
                return this.occurrenceDtField;
            }
            set {
                this.occurrenceDtField = value;
            }
        }
        
        /// <remarks/>
        public long carrierId {
            get {
                return this.carrierIdField;
            }
            set {
                this.carrierIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool carrierIdSpecified {
            get {
                return this.carrierIdFieldSpecified;
            }
            set {
                this.carrierIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string carrierNm {
            get {
                return this.carrierNmField;
            }
            set {
                this.carrierNmField = value;
            }
        }
        
        /// <remarks/>
        public string contractId {
            get {
                return this.contractIdField;
            }
            set {
                this.contractIdField = value;
            }
        }
        
        /// <remarks/>
        public string receiverNm {
            get {
                return this.receiverNmField;
            }
            set {
                this.receiverNmField = value;
            }
        }
        
        /// <remarks/>
        public string carrierMessage {
            get {
                return this.carrierMessageField;
            }
            set {
                this.carrierMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime adjustedDeliveryDt {
            get {
                return this.adjustedDeliveryDtField;
            }
            set {
                this.adjustedDeliveryDtField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool adjustedDeliveryDtSpecified {
            get {
                return this.adjustedDeliveryDtFieldSpecified;
            }
            set {
                this.adjustedDeliveryDtFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string CTRCNumber {
            get {
                return this.cTRCNumberField;
            }
            set {
                this.cTRCNumberField = value;
            }
        }
        
        /// <remarks/>
        public string carrierURL {
            get {
                return this.carrierURLField;
            }
            set {
                this.carrierURLField = value;
            }
        }
        
        /// <remarks/>
        public string invoiceURL {
            get {
                return this.invoiceURLField;
            }
            set {
                this.invoiceURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.accurate.com/acec/InvoiceInfo")]
        public InvoiceInfo invoiceInfo {
            get {
                return this.invoiceInfoField;
            }
            set {
                this.invoiceInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public trackingProperty[] trackingPropertyList {
            get {
                return this.trackingPropertyListField;
            }
            set {
                this.trackingPropertyListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.accurate.com/acec/InvoiceInfo")]
    public partial class InvoiceInfo {
        
        private long issuerDocumentNrField;
        
        private bool issuerDocumentNrFieldSpecified;
        
        private long invoiceNumberField;
        
        private bool invoiceNumberFieldSpecified;
        
        private string invoiceSerialNumberField;
        
        private System.DateTime invoiceEmissionDateField;
        
        private bool invoiceEmissionDateFieldSpecified;
        
        private string invoiceEletronicKeyField;
        
        private ObjectData[] objectDataListField;
        
        /// <remarks/>
        public long issuerDocumentNr {
            get {
                return this.issuerDocumentNrField;
            }
            set {
                this.issuerDocumentNrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool issuerDocumentNrSpecified {
            get {
                return this.issuerDocumentNrFieldSpecified;
            }
            set {
                this.issuerDocumentNrFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public long invoiceNumber {
            get {
                return this.invoiceNumberField;
            }
            set {
                this.invoiceNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool invoiceNumberSpecified {
            get {
                return this.invoiceNumberFieldSpecified;
            }
            set {
                this.invoiceNumberFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string invoiceSerialNumber {
            get {
                return this.invoiceSerialNumberField;
            }
            set {
                this.invoiceSerialNumberField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime invoiceEmissionDate {
            get {
                return this.invoiceEmissionDateField;
            }
            set {
                this.invoiceEmissionDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool invoiceEmissionDateSpecified {
            get {
                return this.invoiceEmissionDateFieldSpecified;
            }
            set {
                this.invoiceEmissionDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string invoiceEletronicKey {
            get {
                return this.invoiceEletronicKeyField;
            }
            set {
                this.invoiceEletronicKeyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("objectData", IsNullable=false)]
        public ObjectData[] objectDataList {
            get {
                return this.objectDataListField;
            }
            set {
                this.objectDataListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.accurate.com/acec/InvoiceInfo")]
    public partial class ObjectData {
        
        private string objectIdField;
        
        /// <remarks/>
        public string objectId {
            get {
                return this.objectIdField;
            }
            set {
                this.objectIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.accurate.com/acec/Tracking")]
    public partial class trackingProperty {
        
        private string trackingPropertyIdField;
        
        private string trackingPropertyValueField;
        
        /// <remarks/>
        public string trackingPropertyId {
            get {
                return this.trackingPropertyIdField;
            }
            set {
                this.trackingPropertyIdField = value;
            }
        }
        
        /// <remarks/>
        public string trackingPropertyValue {
            get {
                return this.trackingPropertyValueField;
            }
            set {
                this.trackingPropertyValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.accurate.com/acec/TrackingServices")]
    public partial class captureTrackingResponse {
        
        private bool successField;
        
        /// <remarks/>
        public bool success {
            get {
                return this.successField;
            }
            set {
                this.successField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void captureTrackingCompletedEventHandler(object sender, captureTrackingCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class captureTrackingCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal captureTrackingCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public captureTrackingResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((captureTrackingResponse)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591