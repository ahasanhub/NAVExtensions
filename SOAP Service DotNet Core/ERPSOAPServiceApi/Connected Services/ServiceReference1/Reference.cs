﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/ERPSOAPService", ConfigurationName="ServiceReference1.ERPSOAPService_Port")]
    public interface ERPSOAPService_Port
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/ERPSOAPService:InsertCustomerBill", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference1.InsertCustomerBill_Result> InsertCustomerBillAsync(ServiceReference1.InsertCustomerBill request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/ERPSOAPService:UpdateCustomerBill", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference1.UpdateCustomerBill_Result> UpdateCustomerBillAsync(ServiceReference1.UpdateCustomerBill request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/ERPSOAPService:DeleteCustomerBill", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference1.DeleteCustomerBill_Result> DeleteCustomerBillAsync(ServiceReference1.DeleteCustomerBill request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InsertCustomerBill", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/ERPSOAPService", IsWrapped=true)]
    public partial class InsertCustomerBill
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/ERPSOAPService", Order=0)]
        public string name;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/ERPSOAPService", Order=1)]
        public int year;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/ERPSOAPService", Order=2)]
        public string month;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/ERPSOAPService", Order=3)]
        public decimal amount;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/ERPSOAPService", Order=4)]
        public string profileJson;
        
        public InsertCustomerBill()
        {
        }
        
        public InsertCustomerBill(string name, int year, string month, decimal amount, string profileJson)
        {
            this.name = name;
            this.year = year;
            this.month = month;
            this.amount = amount;
            this.profileJson = profileJson;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InsertCustomerBill_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/ERPSOAPService", IsWrapped=true)]
    public partial class InsertCustomerBill_Result
    {
        
        public InsertCustomerBill_Result()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateCustomerBill", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/ERPSOAPService", IsWrapped=true)]
    public partial class UpdateCustomerBill
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/ERPSOAPService", Order=0)]
        public int id;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/ERPSOAPService", Order=1)]
        public string name;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/ERPSOAPService", Order=2)]
        public int year;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/ERPSOAPService", Order=3)]
        public string month;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/ERPSOAPService", Order=4)]
        public decimal amount;
        
        public UpdateCustomerBill()
        {
        }
        
        public UpdateCustomerBill(int id, string name, int year, string month, decimal amount)
        {
            this.id = id;
            this.name = name;
            this.year = year;
            this.month = month;
            this.amount = amount;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateCustomerBill_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/ERPSOAPService", IsWrapped=true)]
    public partial class UpdateCustomerBill_Result
    {
        
        public UpdateCustomerBill_Result()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteCustomerBill", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/ERPSOAPService", IsWrapped=true)]
    public partial class DeleteCustomerBill
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/ERPSOAPService", Order=0)]
        public int id;
        
        public DeleteCustomerBill()
        {
        }
        
        public DeleteCustomerBill(int id)
        {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteCustomerBill_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/ERPSOAPService", IsWrapped=true)]
    public partial class DeleteCustomerBill_Result
    {
        
        public DeleteCustomerBill_Result()
        {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface ERPSOAPService_PortChannel : ServiceReference1.ERPSOAPService_Port, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class ERPSOAPService_PortClient : System.ServiceModel.ClientBase<ServiceReference1.ERPSOAPService_Port>, ServiceReference1.ERPSOAPService_Port
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ERPSOAPService_PortClient() : 
                base(ERPSOAPService_PortClient.GetDefaultBinding(), ERPSOAPService_PortClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.ERPSOAPService_Port.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ERPSOAPService_PortClient(EndpointConfiguration endpointConfiguration) : 
                base(ERPSOAPService_PortClient.GetBindingForEndpoint(endpointConfiguration), ERPSOAPService_PortClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ERPSOAPService_PortClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ERPSOAPService_PortClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ERPSOAPService_PortClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ERPSOAPService_PortClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ERPSOAPService_PortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.InsertCustomerBill_Result> ServiceReference1.ERPSOAPService_Port.InsertCustomerBillAsync(ServiceReference1.InsertCustomerBill request)
        {
            return base.Channel.InsertCustomerBillAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.InsertCustomerBill_Result> InsertCustomerBillAsync(string name, int year, string month, decimal amount, string profileJson)
        {
            ServiceReference1.InsertCustomerBill inValue = new ServiceReference1.InsertCustomerBill();
            inValue.name = name;
            inValue.year = year;
            inValue.month = month;
            inValue.amount = amount;
            inValue.profileJson = profileJson;
            return ((ServiceReference1.ERPSOAPService_Port)(this)).InsertCustomerBillAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.UpdateCustomerBill_Result> ServiceReference1.ERPSOAPService_Port.UpdateCustomerBillAsync(ServiceReference1.UpdateCustomerBill request)
        {
            return base.Channel.UpdateCustomerBillAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.UpdateCustomerBill_Result> UpdateCustomerBillAsync(int id, string name, int year, string month, decimal amount)
        {
            ServiceReference1.UpdateCustomerBill inValue = new ServiceReference1.UpdateCustomerBill();
            inValue.id = id;
            inValue.name = name;
            inValue.year = year;
            inValue.month = month;
            inValue.amount = amount;
            return ((ServiceReference1.ERPSOAPService_Port)(this)).UpdateCustomerBillAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.DeleteCustomerBill_Result> ServiceReference1.ERPSOAPService_Port.DeleteCustomerBillAsync(ServiceReference1.DeleteCustomerBill request)
        {
            return base.Channel.DeleteCustomerBillAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.DeleteCustomerBill_Result> DeleteCustomerBillAsync(int id)
        {
            ServiceReference1.DeleteCustomerBill inValue = new ServiceReference1.DeleteCustomerBill();
            inValue.id = id;
            return ((ServiceReference1.ERPSOAPService_Port)(this)).DeleteCustomerBillAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ERPSOAPService_Port))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ERPSOAPService_Port))
            {
                return new System.ServiceModel.EndpointAddress("http://win-jhhr4oovksp:7047/POWERDIVERPSERVICE/WS/BPDB/Codeunit/ERPSOAPService");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ERPSOAPService_PortClient.GetBindingForEndpoint(EndpointConfiguration.ERPSOAPService_Port);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ERPSOAPService_PortClient.GetEndpointAddress(EndpointConfiguration.ERPSOAPService_Port);
        }
        
        public enum EndpointConfiguration
        {
            
            ERPSOAPService_Port,
        }
    }
}
