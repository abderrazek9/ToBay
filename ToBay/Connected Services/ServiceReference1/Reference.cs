﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToBay.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebServicedbSoap")]
    public interface WebServicedbSoap {
        
        // CODEGEN: Generating message contract since element name username from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SignupAsync", ReplyAction="*")]
        ToBay.ServiceReference1.SignupAsyncResponse SignupAsync(ToBay.ServiceReference1.SignupAsyncRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SignupAsync", ReplyAction="*")]
        System.Threading.Tasks.Task<ToBay.ServiceReference1.SignupAsyncResponse> SignupAsyncAsync(ToBay.ServiceReference1.SignupAsyncRequest request);
        
        // CODEGEN: Generating message contract since element name username from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Login", ReplyAction="*")]
        ToBay.ServiceReference1.LoginResponse Login(ToBay.ServiceReference1.LoginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Login", ReplyAction="*")]
        System.Threading.Tasks.Task<ToBay.ServiceReference1.LoginResponse> LoginAsync(ToBay.ServiceReference1.LoginRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SignupAsyncRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SignupAsync", Namespace="http://tempuri.org/", Order=0)]
        public ToBay.ServiceReference1.SignupAsyncRequestBody Body;
        
        public SignupAsyncRequest() {
        }
        
        public SignupAsyncRequest(ToBay.ServiceReference1.SignupAsyncRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SignupAsyncRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string username;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string name;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string pername;
        
        public SignupAsyncRequestBody() {
        }
        
        public SignupAsyncRequestBody(string username, string password, string name, string pername) {
            this.username = username;
            this.password = password;
            this.name = name;
            this.pername = pername;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SignupAsyncResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SignupAsyncResponse", Namespace="http://tempuri.org/", Order=0)]
        public ToBay.ServiceReference1.SignupAsyncResponseBody Body;
        
        public SignupAsyncResponse() {
        }
        
        public SignupAsyncResponse(ToBay.ServiceReference1.SignupAsyncResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class SignupAsyncResponseBody {
        
        public SignupAsyncResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Login", Namespace="http://tempuri.org/", Order=0)]
        public ToBay.ServiceReference1.LoginRequestBody Body;
        
        public LoginRequest() {
        }
        
        public LoginRequest(ToBay.ServiceReference1.LoginRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LoginRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string username;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public LoginRequestBody() {
        }
        
        public LoginRequestBody(string username, string password) {
            this.username = username;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LoginResponse", Namespace="http://tempuri.org/", Order=0)]
        public ToBay.ServiceReference1.LoginResponseBody Body;
        
        public LoginResponse() {
        }
        
        public LoginResponse(ToBay.ServiceReference1.LoginResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LoginResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string LoginResult;
        
        public LoginResponseBody() {
        }
        
        public LoginResponseBody(string LoginResult) {
            this.LoginResult = LoginResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServicedbSoapChannel : ToBay.ServiceReference1.WebServicedbSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServicedbSoapClient : System.ServiceModel.ClientBase<ToBay.ServiceReference1.WebServicedbSoap>, ToBay.ServiceReference1.WebServicedbSoap {
        
        public WebServicedbSoapClient() {
        }
        
        public WebServicedbSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServicedbSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServicedbSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServicedbSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ToBay.ServiceReference1.SignupAsyncResponse ToBay.ServiceReference1.WebServicedbSoap.SignupAsync(ToBay.ServiceReference1.SignupAsyncRequest request) {
            return base.Channel.SignupAsync(request);
        }
        
        public void SignupAsync(string username, string password, string name, string pername) {
            ToBay.ServiceReference1.SignupAsyncRequest inValue = new ToBay.ServiceReference1.SignupAsyncRequest();
            inValue.Body = new ToBay.ServiceReference1.SignupAsyncRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            inValue.Body.name = name;
            inValue.Body.pername = pername;
            ToBay.ServiceReference1.SignupAsyncResponse retVal = ((ToBay.ServiceReference1.WebServicedbSoap)(this)).SignupAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ToBay.ServiceReference1.SignupAsyncResponse> ToBay.ServiceReference1.WebServicedbSoap.SignupAsyncAsync(ToBay.ServiceReference1.SignupAsyncRequest request) {
            return base.Channel.SignupAsyncAsync(request);
        }
        
        public System.Threading.Tasks.Task<ToBay.ServiceReference1.SignupAsyncResponse> SignupAsyncAsync(string username, string password, string name, string pername) {
            ToBay.ServiceReference1.SignupAsyncRequest inValue = new ToBay.ServiceReference1.SignupAsyncRequest();
            inValue.Body = new ToBay.ServiceReference1.SignupAsyncRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            inValue.Body.name = name;
            inValue.Body.pername = pername;
            return ((ToBay.ServiceReference1.WebServicedbSoap)(this)).SignupAsyncAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ToBay.ServiceReference1.LoginResponse ToBay.ServiceReference1.WebServicedbSoap.Login(ToBay.ServiceReference1.LoginRequest request) {
            return base.Channel.Login(request);
        }
        
        public string Login(string username, string password) {
            ToBay.ServiceReference1.LoginRequest inValue = new ToBay.ServiceReference1.LoginRequest();
            inValue.Body = new ToBay.ServiceReference1.LoginRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            ToBay.ServiceReference1.LoginResponse retVal = ((ToBay.ServiceReference1.WebServicedbSoap)(this)).Login(inValue);
            return retVal.Body.LoginResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ToBay.ServiceReference1.LoginResponse> ToBay.ServiceReference1.WebServicedbSoap.LoginAsync(ToBay.ServiceReference1.LoginRequest request) {
            return base.Channel.LoginAsync(request);
        }
        
        public System.Threading.Tasks.Task<ToBay.ServiceReference1.LoginResponse> LoginAsync(string username, string password) {
            ToBay.ServiceReference1.LoginRequest inValue = new ToBay.ServiceReference1.LoginRequest();
            inValue.Body = new ToBay.ServiceReference1.LoginRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            return ((ToBay.ServiceReference1.WebServicedbSoap)(this)).LoginAsync(inValue);
        }
    }
}
