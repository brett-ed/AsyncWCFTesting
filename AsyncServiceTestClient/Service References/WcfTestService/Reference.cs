﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AsyncServiceTestClient.WcfTestService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfTestService.IDemoService")]
    public interface IDemoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/GetStringData", ReplyAction="http://tempuri.org/IDemoService/GetStringDataResponse")]
        string GetStringData(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/GetStringData", ReplyAction="http://tempuri.org/IDemoService/GetStringDataResponse")]
        System.Threading.Tasks.Task<string> GetStringDataAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDemoServiceChannel : AsyncServiceTestClient.WcfTestService.IDemoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DemoServiceClient : System.ServiceModel.ClientBase<AsyncServiceTestClient.WcfTestService.IDemoService>, AsyncServiceTestClient.WcfTestService.IDemoService {
        
        public DemoServiceClient() {
        }
        
        public DemoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DemoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DemoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DemoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetStringData(string name) {
            return base.Channel.GetStringData(name);
        }
        
        public System.Threading.Tasks.Task<string> GetStringDataAsync(string name) {
            return base.Channel.GetStringDataAsync(name);
        }
    }
}