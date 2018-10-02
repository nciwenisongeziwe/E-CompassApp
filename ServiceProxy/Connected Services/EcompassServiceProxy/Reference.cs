﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EcompassServiceProxy
{
    using System;
    using System.Runtime.Serialization;
    using System.Threading.Tasks;

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PnpProducts", Namespace="http://schemas.datacontract.org/2004/07/EcompassService")]
    public partial class PnpProducts : object
    {
        
        private EcompassServiceProxy.ProductCatagory CatagoryField;
        
        private System.DateTime ProductDateEndPromoField;
        
        private string ProductDescField;
        
        private double ProductDropPercentField;
        
        private int ProductIDField;
        
        private string ProductImageField;
        
        private string ProductNameField;
        
        private float ProductPriceField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public EcompassServiceProxy.ProductCatagory Catagory
        {
            get
            {
                return this.CatagoryField;
            }
            set
            {
                this.CatagoryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ProductDateEndPromo
        {
            get
            {
                return this.ProductDateEndPromoField;
            }
            set
            {
                this.ProductDateEndPromoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductDesc
        {
            get
            {
                return this.ProductDescField;
            }
            set
            {
                this.ProductDescField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double ProductDropPercent
        {
            get
            {
                return this.ProductDropPercentField;
            }
            set
            {
                this.ProductDropPercentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductID
        {
            get
            {
                return this.ProductIDField;
            }
            set
            {
                this.ProductIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductImage
        {
            get
            {
                return this.ProductImageField;
            }
            set
            {
                this.ProductImageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName
        {
            get
            {
                return this.ProductNameField;
            }
            set
            {
                this.ProductNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float ProductPrice
        {
            get
            {
                return this.ProductPriceField;
            }
            set
            {
                this.ProductPriceField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductCatagory", Namespace="http://schemas.datacontract.org/2004/07/EcompassService")]
    public partial class ProductCatagory : object
    {
        
        private string CatagoryDescField;
        
        private string CatagoryNameField;
        
        private int catagoryIDField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CatagoryDesc
        {
            get
            {
                return this.CatagoryDescField;
            }
            set
            {
                this.CatagoryDescField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CatagoryName
        {
            get
            {
                return this.CatagoryNameField;
            }
            set
            {
                this.CatagoryNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int catagoryID
        {
            get
            {
                return this.catagoryIDField;
            }
            set
            {
                this.catagoryIDField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EcompassServiceProxy.IEcompassService")]
    public interface IEcompassService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEcompassService/SayHelloTo", ReplyAction="http://tempuri.org/IEcompassService/SayHelloToResponse")]
        System.Threading.Tasks.Task<string> SayHelloToAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEcompassService/GetProductsData", ReplyAction="http://tempuri.org/IEcompassService/GetProductsDataResponse")]
        System.Threading.Tasks.Task<EcompassServiceProxy.PnpProducts[]> GetProductsDataAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface IEcompassServiceChannel : EcompassServiceProxy.IEcompassService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class EcompassServiceClient : System.ServiceModel.ClientBase<EcompassServiceProxy.IEcompassService>, EcompassServiceProxy.IEcompassService
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public EcompassServiceClient() : 
                base(EcompassServiceClient.GetDefaultBinding(), EcompassServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IEcompassService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public EcompassServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(EcompassServiceClient.GetBindingForEndpoint(endpointConfiguration), EcompassServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public EcompassServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(EcompassServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public EcompassServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(EcompassServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public EcompassServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<string> SayHelloToAsync()
        {
            return base.Channel.SayHelloToAsync();
        }
        
        public System.Threading.Tasks.Task<EcompassServiceProxy.PnpProducts[]> GetProductsDataAsync()
        {
            return base.Channel.GetProductsDataAsync();
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IEcompassService))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IEcompassService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:50874/EcompassService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return EcompassServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IEcompassService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return EcompassServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IEcompassService);
        }

        public Task SayHelloToAsync(string v)
        {
            throw new NotImplementedException();
        }

        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IEcompassService,
        }
    }
}
