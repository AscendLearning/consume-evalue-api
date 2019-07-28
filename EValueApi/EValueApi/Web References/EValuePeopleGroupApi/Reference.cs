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

namespace EValueApi.EValuePeopleGroupApi {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="PeopleGroup_1_0.cfcSoapBinding", Namespace="http://DefaultNamespace")]
    public partial class PeopleGroup_1_0Service : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getOperationCompleted;
        
        private System.Threading.SendOrPostCallback updateOperationCompleted;
        
        private System.Threading.SendOrPostCallback deleteOperationCompleted;
        
        private System.Threading.SendOrPostCallback createOperationCompleted;
        
        private System.Threading.SendOrPostCallback getAllOperationCompleted;
        
        private System.Threading.SendOrPostCallback getByExtIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback addExternalIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback rmvExternalIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback getUsersByGroupOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public PeopleGroup_1_0Service() {
            this.Url = global::EValueApi.Properties.Settings.Default.EValueApi_EValuePeopleGroupApi_PeopleGroup_1_0Service;
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
        public event getCompletedEventHandler getCompleted;
        
        /// <remarks/>
        public event updateCompletedEventHandler updateCompleted;
        
        /// <remarks/>
        public event deleteCompletedEventHandler deleteCompleted;
        
        /// <remarks/>
        public event createCompletedEventHandler createCompleted;
        
        /// <remarks/>
        public event getAllCompletedEventHandler getAllCompleted;
        
        /// <remarks/>
        public event getByExtIdCompletedEventHandler getByExtIdCompleted;
        
        /// <remarks/>
        public event addExternalIdCompletedEventHandler addExternalIdCompleted;
        
        /// <remarks/>
        public event rmvExternalIdCompletedEventHandler rmvExternalIdCompleted;
        
        /// <remarks/>
        public event getUsersByGroupCompletedEventHandler getUsersByGroupCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://DefaultNamespace", ResponseNamespace="http://DefaultNamespace")]
        [return: System.Xml.Serialization.SoapElementAttribute("getReturn")]
        public string get(string msg) {
            object[] results = this.Invoke("get", new object[] {
                        msg});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getAsync(string msg) {
            this.getAsync(msg, null);
        }
        
        /// <remarks/>
        public void getAsync(string msg, object userState) {
            if ((this.getOperationCompleted == null)) {
                this.getOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetOperationCompleted);
            }
            this.InvokeAsync("get", new object[] {
                        msg}, this.getOperationCompleted, userState);
        }
        
        private void OngetOperationCompleted(object arg) {
            if ((this.getCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getCompleted(this, new getCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://DefaultNamespace", ResponseNamespace="http://DefaultNamespace")]
        [return: System.Xml.Serialization.SoapElementAttribute("updateReturn")]
        public string update(string msg) {
            object[] results = this.Invoke("update", new object[] {
                        msg});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void updateAsync(string msg) {
            this.updateAsync(msg, null);
        }
        
        /// <remarks/>
        public void updateAsync(string msg, object userState) {
            if ((this.updateOperationCompleted == null)) {
                this.updateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnupdateOperationCompleted);
            }
            this.InvokeAsync("update", new object[] {
                        msg}, this.updateOperationCompleted, userState);
        }
        
        private void OnupdateOperationCompleted(object arg) {
            if ((this.updateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.updateCompleted(this, new updateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://DefaultNamespace", ResponseNamespace="http://DefaultNamespace")]
        [return: System.Xml.Serialization.SoapElementAttribute("deleteReturn")]
        public string delete(string msg) {
            object[] results = this.Invoke("delete", new object[] {
                        msg});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void deleteAsync(string msg) {
            this.deleteAsync(msg, null);
        }
        
        /// <remarks/>
        public void deleteAsync(string msg, object userState) {
            if ((this.deleteOperationCompleted == null)) {
                this.deleteOperationCompleted = new System.Threading.SendOrPostCallback(this.OndeleteOperationCompleted);
            }
            this.InvokeAsync("delete", new object[] {
                        msg}, this.deleteOperationCompleted, userState);
        }
        
        private void OndeleteOperationCompleted(object arg) {
            if ((this.deleteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.deleteCompleted(this, new deleteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://DefaultNamespace", ResponseNamespace="http://DefaultNamespace")]
        [return: System.Xml.Serialization.SoapElementAttribute("createReturn")]
        public string create(string msg) {
            object[] results = this.Invoke("create", new object[] {
                        msg});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void createAsync(string msg) {
            this.createAsync(msg, null);
        }
        
        /// <remarks/>
        public void createAsync(string msg, object userState) {
            if ((this.createOperationCompleted == null)) {
                this.createOperationCompleted = new System.Threading.SendOrPostCallback(this.OncreateOperationCompleted);
            }
            this.InvokeAsync("create", new object[] {
                        msg}, this.createOperationCompleted, userState);
        }
        
        private void OncreateOperationCompleted(object arg) {
            if ((this.createCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.createCompleted(this, new createCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://DefaultNamespace", ResponseNamespace="http://DefaultNamespace")]
        [return: System.Xml.Serialization.SoapElementAttribute("getAllReturn")]
        public string getAll(string msg) {
            object[] results = this.Invoke("getAll", new object[] {
                        msg});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getAllAsync(string msg) {
            this.getAllAsync(msg, null);
        }
        
        /// <remarks/>
        public void getAllAsync(string msg, object userState) {
            if ((this.getAllOperationCompleted == null)) {
                this.getAllOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAllOperationCompleted);
            }
            this.InvokeAsync("getAll", new object[] {
                        msg}, this.getAllOperationCompleted, userState);
        }
        
        private void OngetAllOperationCompleted(object arg) {
            if ((this.getAllCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAllCompleted(this, new getAllCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://DefaultNamespace", ResponseNamespace="http://DefaultNamespace")]
        [return: System.Xml.Serialization.SoapElementAttribute("getByExtIdReturn")]
        public string getByExtId(string msg) {
            object[] results = this.Invoke("getByExtId", new object[] {
                        msg});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getByExtIdAsync(string msg) {
            this.getByExtIdAsync(msg, null);
        }
        
        /// <remarks/>
        public void getByExtIdAsync(string msg, object userState) {
            if ((this.getByExtIdOperationCompleted == null)) {
                this.getByExtIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetByExtIdOperationCompleted);
            }
            this.InvokeAsync("getByExtId", new object[] {
                        msg}, this.getByExtIdOperationCompleted, userState);
        }
        
        private void OngetByExtIdOperationCompleted(object arg) {
            if ((this.getByExtIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getByExtIdCompleted(this, new getByExtIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://DefaultNamespace", ResponseNamespace="http://DefaultNamespace")]
        [return: System.Xml.Serialization.SoapElementAttribute("addExternalIdReturn")]
        public string addExternalId(string msg) {
            object[] results = this.Invoke("addExternalId", new object[] {
                        msg});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void addExternalIdAsync(string msg) {
            this.addExternalIdAsync(msg, null);
        }
        
        /// <remarks/>
        public void addExternalIdAsync(string msg, object userState) {
            if ((this.addExternalIdOperationCompleted == null)) {
                this.addExternalIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnaddExternalIdOperationCompleted);
            }
            this.InvokeAsync("addExternalId", new object[] {
                        msg}, this.addExternalIdOperationCompleted, userState);
        }
        
        private void OnaddExternalIdOperationCompleted(object arg) {
            if ((this.addExternalIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.addExternalIdCompleted(this, new addExternalIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://DefaultNamespace", ResponseNamespace="http://DefaultNamespace")]
        [return: System.Xml.Serialization.SoapElementAttribute("rmvExternalIdReturn")]
        public string rmvExternalId(string msg) {
            object[] results = this.Invoke("rmvExternalId", new object[] {
                        msg});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void rmvExternalIdAsync(string msg) {
            this.rmvExternalIdAsync(msg, null);
        }
        
        /// <remarks/>
        public void rmvExternalIdAsync(string msg, object userState) {
            if ((this.rmvExternalIdOperationCompleted == null)) {
                this.rmvExternalIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnrmvExternalIdOperationCompleted);
            }
            this.InvokeAsync("rmvExternalId", new object[] {
                        msg}, this.rmvExternalIdOperationCompleted, userState);
        }
        
        private void OnrmvExternalIdOperationCompleted(object arg) {
            if ((this.rmvExternalIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.rmvExternalIdCompleted(this, new rmvExternalIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://DefaultNamespace", ResponseNamespace="http://DefaultNamespace")]
        [return: System.Xml.Serialization.SoapElementAttribute("getUsersByGroupReturn")]
        public string getUsersByGroup(string msg) {
            object[] results = this.Invoke("getUsersByGroup", new object[] {
                        msg});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getUsersByGroupAsync(string msg) {
            this.getUsersByGroupAsync(msg, null);
        }
        
        /// <remarks/>
        public void getUsersByGroupAsync(string msg, object userState) {
            if ((this.getUsersByGroupOperationCompleted == null)) {
                this.getUsersByGroupOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetUsersByGroupOperationCompleted);
            }
            this.InvokeAsync("getUsersByGroup", new object[] {
                        msg}, this.getUsersByGroupOperationCompleted, userState);
        }
        
        private void OngetUsersByGroupOperationCompleted(object arg) {
            if ((this.getUsersByGroupCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getUsersByGroupCompleted(this, new getUsersByGroupCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void getCompletedEventHandler(object sender, getCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void updateCompletedEventHandler(object sender, updateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class updateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal updateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void deleteCompletedEventHandler(object sender, deleteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class deleteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal deleteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void createCompletedEventHandler(object sender, createCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class createCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal createCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void getAllCompletedEventHandler(object sender, getAllCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAllCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAllCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void getByExtIdCompletedEventHandler(object sender, getByExtIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getByExtIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getByExtIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void addExternalIdCompletedEventHandler(object sender, addExternalIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class addExternalIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal addExternalIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void rmvExternalIdCompletedEventHandler(object sender, rmvExternalIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class rmvExternalIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal rmvExternalIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void getUsersByGroupCompletedEventHandler(object sender, getUsersByGroupCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getUsersByGroupCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getUsersByGroupCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591