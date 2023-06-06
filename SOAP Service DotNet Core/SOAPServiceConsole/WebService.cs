using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;

namespace SOAPServiceConsole
{
    public static class WebService
    {
        public static WebServiceLocalBC.ExecuteCodeUnit_PortClient BCLocalClient()
        {
            //var company = "APSCL";
            var client = new WebServiceLocalBC.ExecuteCodeUnit_PortClient();
            var binding = new BasicHttpBinding();
            binding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
            binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;

            client.Endpoint.Binding = binding;
            client.Endpoint.Address = new EndpointAddress($"http://win-2ajr95f2ai3:7047/ERPDEVBC140/WS/APSCL/Codeunit/ExecuteCodeUnit");
            client.ClientCredentials.UserName.UserName = "super_admin";
            client.ClientCredentials.UserName.Password = "Techvision123?";

            return client;
        }
        public static ReportWebServiceForLocalBC.ReportWebService_PortClient ReportBCLocalClient()
        {
            
            var client = new ReportWebServiceForLocalBC.ReportWebService_PortClient();
            var binding = new BasicHttpBinding();
            binding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
            binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
            binding.MaxReceivedMessageSize = 9999999;
            client.Endpoint.Binding = binding;
            client.Endpoint.Address = new EndpointAddress($"http://win-2ajr95f2ai3:7047/ERPDEVBC140/WS/APSCL/Codeunit/ReportWebService");
            client.ClientCredentials.UserName.UserName = "super_admin";
            client.ClientCredentials.UserName.Password = "Techvision123?";

            return client;
        }
        public static ServiceReference3.ExecuteCodeUnit_PortClient BCTestClient()
        {
            var company = "APSCL";
            var client = new ServiceReference3.ExecuteCodeUnit_PortClient();
            var binding = new BasicHttpBinding();
            binding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
            binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;

            client.Endpoint.Binding = binding;
            client.Endpoint.Address = new EndpointAddress($"http://bctest.bdpowersectorerp.com:7047/POWERDIVBC/WS/{company}/Codeunit/ExecuteCodeUnit");
            client.ClientCredentials.UserName.UserName = "super_admin";
            client.ClientCredentials.UserName.Password = "Techvision123?";

            return client;
        }
    }
}
