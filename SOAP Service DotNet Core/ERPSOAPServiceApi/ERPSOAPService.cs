using ServiceReference1;
using System.ServiceModel;

namespace ERPSOAPServiceApi
{
	public static class ERPSOAPService
	{
        
        public static ERPSOAPService_PortClient WSClient(string company) {
			var client = new ERPSOAPService_PortClient();
			var binding = new BasicHttpBinding();
			binding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
			binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;

			client.Endpoint.Binding = binding;
			client.Endpoint.Address = new EndpointAddress($"http://win-jhhr4oovksp:7047/POWERDIVERPSERVICE/WS/{company}/Codeunit/ERPSOAPService");
			client.ClientCredentials.UserName.UserName = "super_admin";
			client.ClientCredentials.UserName.Password = "Techvision123?";
			return client;
		}
    }
}
