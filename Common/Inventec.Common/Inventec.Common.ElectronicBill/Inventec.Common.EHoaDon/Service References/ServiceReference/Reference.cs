﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inventec.Common.EHoaDon.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.WSPublicEHoaDonSoap")]
    public interface WSPublicEHoaDonSoap {
        
        // CODEGEN: Generating message contract since element name partnerGUID from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExecCommand", ReplyAction="*")]
        Inventec.Common.EHoaDon.ServiceReference.ExecCommandResponse ExecCommand(Inventec.Common.EHoaDon.ServiceReference.ExecCommandRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExecCommand", ReplyAction="*")]
        System.Threading.Tasks.Task<Inventec.Common.EHoaDon.ServiceReference.ExecCommandResponse> ExecCommandAsync(Inventec.Common.EHoaDon.ServiceReference.ExecCommandRequest request);
        
        // CODEGEN: Generating message contract since element name PartnerGUID from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExecuteCommand", ReplyAction="*")]
        Inventec.Common.EHoaDon.ServiceReference.ExecuteCommandResponse ExecuteCommand(Inventec.Common.EHoaDon.ServiceReference.ExecuteCommandRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExecuteCommand", ReplyAction="*")]
        System.Threading.Tasks.Task<Inventec.Common.EHoaDon.ServiceReference.ExecuteCommandResponse> ExecuteCommandAsync(Inventec.Common.EHoaDon.ServiceReference.ExecuteCommandRequest request);
        
        // CODEGEN: Generating message contract since element name TokenID from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddBlockedIP", ReplyAction="*")]
        Inventec.Common.EHoaDon.ServiceReference.AddBlockedIPResponse AddBlockedIP(Inventec.Common.EHoaDon.ServiceReference.AddBlockedIPRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddBlockedIP", ReplyAction="*")]
        System.Threading.Tasks.Task<Inventec.Common.EHoaDon.ServiceReference.AddBlockedIPResponse> AddBlockedIPAsync(Inventec.Common.EHoaDon.ServiceReference.AddBlockedIPRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExecCommandRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ExecCommand", Namespace="http://tempuri.org/", Order=0)]
        public Inventec.Common.EHoaDon.ServiceReference.ExecCommandRequestBody Body;
        
        public ExecCommandRequest() {
        }
        
        public ExecCommandRequest(Inventec.Common.EHoaDon.ServiceReference.ExecCommandRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ExecCommandRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string partnerGUID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string CommandData;
        
        public ExecCommandRequestBody() {
        }
        
        public ExecCommandRequestBody(string partnerGUID, string CommandData) {
            this.partnerGUID = partnerGUID;
            this.CommandData = CommandData;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExecCommandResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ExecCommandResponse", Namespace="http://tempuri.org/", Order=0)]
        public Inventec.Common.EHoaDon.ServiceReference.ExecCommandResponseBody Body;
        
        public ExecCommandResponse() {
        }
        
        public ExecCommandResponse(Inventec.Common.EHoaDon.ServiceReference.ExecCommandResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ExecCommandResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ExecCommandResult;
        
        public ExecCommandResponseBody() {
        }
        
        public ExecCommandResponseBody(string ExecCommandResult) {
            this.ExecCommandResult = ExecCommandResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExecuteCommandRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ExecuteCommand", Namespace="http://tempuri.org/", Order=0)]
        public Inventec.Common.EHoaDon.ServiceReference.ExecuteCommandRequestBody Body;
        
        public ExecuteCommandRequest() {
        }
        
        public ExecuteCommandRequest(Inventec.Common.EHoaDon.ServiceReference.ExecuteCommandRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ExecuteCommandRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string PartnerGUID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string EncryptedCommandData;
        
        public ExecuteCommandRequestBody() {
        }
        
        public ExecuteCommandRequestBody(string PartnerGUID, string EncryptedCommandData) {
            this.PartnerGUID = PartnerGUID;
            this.EncryptedCommandData = EncryptedCommandData;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExecuteCommandResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ExecuteCommandResponse", Namespace="http://tempuri.org/", Order=0)]
        public Inventec.Common.EHoaDon.ServiceReference.ExecuteCommandResponseBody Body;
        
        public ExecuteCommandResponse() {
        }
        
        public ExecuteCommandResponse(Inventec.Common.EHoaDon.ServiceReference.ExecuteCommandResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ExecuteCommandResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ExecuteCommandResult;
        
        public ExecuteCommandResponseBody() {
        }
        
        public ExecuteCommandResponseBody(string ExecuteCommandResult) {
            this.ExecuteCommandResult = ExecuteCommandResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddBlockedIPRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddBlockedIP", Namespace="http://tempuri.org/", Order=0)]
        public Inventec.Common.EHoaDon.ServiceReference.AddBlockedIPRequestBody Body;
        
        public AddBlockedIPRequest() {
        }
        
        public AddBlockedIPRequest(Inventec.Common.EHoaDon.ServiceReference.AddBlockedIPRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddBlockedIPRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string TokenID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string IPAddress;
        
        public AddBlockedIPRequestBody() {
        }
        
        public AddBlockedIPRequestBody(string TokenID, string IPAddress) {
            this.TokenID = TokenID;
            this.IPAddress = IPAddress;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddBlockedIPResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddBlockedIPResponse", Namespace="http://tempuri.org/", Order=0)]
        public Inventec.Common.EHoaDon.ServiceReference.AddBlockedIPResponseBody Body;
        
        public AddBlockedIPResponse() {
        }
        
        public AddBlockedIPResponse(Inventec.Common.EHoaDon.ServiceReference.AddBlockedIPResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddBlockedIPResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string AddBlockedIPResult;
        
        public AddBlockedIPResponseBody() {
        }
        
        public AddBlockedIPResponseBody(string AddBlockedIPResult) {
            this.AddBlockedIPResult = AddBlockedIPResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSPublicEHoaDonSoapChannel : Inventec.Common.EHoaDon.ServiceReference.WSPublicEHoaDonSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSPublicEHoaDonSoapClient : System.ServiceModel.ClientBase<Inventec.Common.EHoaDon.ServiceReference.WSPublicEHoaDonSoap>, Inventec.Common.EHoaDon.ServiceReference.WSPublicEHoaDonSoap {
        
        public WSPublicEHoaDonSoapClient() {
        }
        
        public WSPublicEHoaDonSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSPublicEHoaDonSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSPublicEHoaDonSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSPublicEHoaDonSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Inventec.Common.EHoaDon.ServiceReference.ExecCommandResponse Inventec.Common.EHoaDon.ServiceReference.WSPublicEHoaDonSoap.ExecCommand(Inventec.Common.EHoaDon.ServiceReference.ExecCommandRequest request) {
            return base.Channel.ExecCommand(request);
        }
        
        public string ExecCommand(string partnerGUID, string CommandData) {
            Inventec.Common.EHoaDon.ServiceReference.ExecCommandRequest inValue = new Inventec.Common.EHoaDon.ServiceReference.ExecCommandRequest();
            inValue.Body = new Inventec.Common.EHoaDon.ServiceReference.ExecCommandRequestBody();
            inValue.Body.partnerGUID = partnerGUID;
            inValue.Body.CommandData = CommandData;
            Inventec.Common.EHoaDon.ServiceReference.ExecCommandResponse retVal = ((Inventec.Common.EHoaDon.ServiceReference.WSPublicEHoaDonSoap)(this)).ExecCommand(inValue);
            return retVal.Body.ExecCommandResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Inventec.Common.EHoaDon.ServiceReference.ExecCommandResponse> Inventec.Common.EHoaDon.ServiceReference.WSPublicEHoaDonSoap.ExecCommandAsync(Inventec.Common.EHoaDon.ServiceReference.ExecCommandRequest request) {
            return base.Channel.ExecCommandAsync(request);
        }
        
        public System.Threading.Tasks.Task<Inventec.Common.EHoaDon.ServiceReference.ExecCommandResponse> ExecCommandAsync(string partnerGUID, string CommandData) {
            Inventec.Common.EHoaDon.ServiceReference.ExecCommandRequest inValue = new Inventec.Common.EHoaDon.ServiceReference.ExecCommandRequest();
            inValue.Body = new Inventec.Common.EHoaDon.ServiceReference.ExecCommandRequestBody();
            inValue.Body.partnerGUID = partnerGUID;
            inValue.Body.CommandData = CommandData;
            return ((Inventec.Common.EHoaDon.ServiceReference.WSPublicEHoaDonSoap)(this)).ExecCommandAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Inventec.Common.EHoaDon.ServiceReference.ExecuteCommandResponse Inventec.Common.EHoaDon.ServiceReference.WSPublicEHoaDonSoap.ExecuteCommand(Inventec.Common.EHoaDon.ServiceReference.ExecuteCommandRequest request) {
            return base.Channel.ExecuteCommand(request);
        }
        
        public string ExecuteCommand(string PartnerGUID, string EncryptedCommandData) {
            Inventec.Common.EHoaDon.ServiceReference.ExecuteCommandRequest inValue = new Inventec.Common.EHoaDon.ServiceReference.ExecuteCommandRequest();
            inValue.Body = new Inventec.Common.EHoaDon.ServiceReference.ExecuteCommandRequestBody();
            inValue.Body.PartnerGUID = PartnerGUID;
            inValue.Body.EncryptedCommandData = EncryptedCommandData;
            Inventec.Common.EHoaDon.ServiceReference.ExecuteCommandResponse retVal = ((Inventec.Common.EHoaDon.ServiceReference.WSPublicEHoaDonSoap)(this)).ExecuteCommand(inValue);
            return retVal.Body.ExecuteCommandResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Inventec.Common.EHoaDon.ServiceReference.ExecuteCommandResponse> Inventec.Common.EHoaDon.ServiceReference.WSPublicEHoaDonSoap.ExecuteCommandAsync(Inventec.Common.EHoaDon.ServiceReference.ExecuteCommandRequest request) {
            return base.Channel.ExecuteCommandAsync(request);
        }
        
        public System.Threading.Tasks.Task<Inventec.Common.EHoaDon.ServiceReference.ExecuteCommandResponse> ExecuteCommandAsync(string PartnerGUID, string EncryptedCommandData) {
            Inventec.Common.EHoaDon.ServiceReference.ExecuteCommandRequest inValue = new Inventec.Common.EHoaDon.ServiceReference.ExecuteCommandRequest();
            inValue.Body = new Inventec.Common.EHoaDon.ServiceReference.ExecuteCommandRequestBody();
            inValue.Body.PartnerGUID = PartnerGUID;
            inValue.Body.EncryptedCommandData = EncryptedCommandData;
            return ((Inventec.Common.EHoaDon.ServiceReference.WSPublicEHoaDonSoap)(this)).ExecuteCommandAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Inventec.Common.EHoaDon.ServiceReference.AddBlockedIPResponse Inventec.Common.EHoaDon.ServiceReference.WSPublicEHoaDonSoap.AddBlockedIP(Inventec.Common.EHoaDon.ServiceReference.AddBlockedIPRequest request) {
            return base.Channel.AddBlockedIP(request);
        }
        
        public string AddBlockedIP(string TokenID, string IPAddress) {
            Inventec.Common.EHoaDon.ServiceReference.AddBlockedIPRequest inValue = new Inventec.Common.EHoaDon.ServiceReference.AddBlockedIPRequest();
            inValue.Body = new Inventec.Common.EHoaDon.ServiceReference.AddBlockedIPRequestBody();
            inValue.Body.TokenID = TokenID;
            inValue.Body.IPAddress = IPAddress;
            Inventec.Common.EHoaDon.ServiceReference.AddBlockedIPResponse retVal = ((Inventec.Common.EHoaDon.ServiceReference.WSPublicEHoaDonSoap)(this)).AddBlockedIP(inValue);
            return retVal.Body.AddBlockedIPResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Inventec.Common.EHoaDon.ServiceReference.AddBlockedIPResponse> Inventec.Common.EHoaDon.ServiceReference.WSPublicEHoaDonSoap.AddBlockedIPAsync(Inventec.Common.EHoaDon.ServiceReference.AddBlockedIPRequest request) {
            return base.Channel.AddBlockedIPAsync(request);
        }
        
        public System.Threading.Tasks.Task<Inventec.Common.EHoaDon.ServiceReference.AddBlockedIPResponse> AddBlockedIPAsync(string TokenID, string IPAddress) {
            Inventec.Common.EHoaDon.ServiceReference.AddBlockedIPRequest inValue = new Inventec.Common.EHoaDon.ServiceReference.AddBlockedIPRequest();
            inValue.Body = new Inventec.Common.EHoaDon.ServiceReference.AddBlockedIPRequestBody();
            inValue.Body.TokenID = TokenID;
            inValue.Body.IPAddress = IPAddress;
            return ((Inventec.Common.EHoaDon.ServiceReference.WSPublicEHoaDonSoap)(this)).AddBlockedIPAsync(inValue);
        }
    }
}
