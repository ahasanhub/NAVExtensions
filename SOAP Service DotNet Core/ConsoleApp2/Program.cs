using ServiceReference1;
using ServiceReference2;
using System;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			//ExecuteCodeUnit_PortClient client = new ExecuteCodeUnit_PortClient();
			//var result=client.ExecuteAsync("Name
			var client = new CustomerBill_PortClient();
			var binding = new BasicHttpBinding();
			binding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
			binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;

			client.Endpoint.Binding = binding;
			client.Endpoint.Address = new EndpointAddress("http://win-jhhr4oovksp:7047/POWERDIVERPSERVICE/WS/BPDB/Codeunit/CustomerBill");
			client.ClientCredentials.UserName.UserName = "super_admin";
			client.ClientCredentials.UserName.Password = "Techvision123?";
			var greet=await client.GreetingAsync("Ahasan1");
			await client.BillGenerationAsync("Istiak1",2023,"June",200);

			//CustomerBill_PortClient portClient = new CustomerBill_PortClient();
			////portClient.ClientCredentials= new ClientCredentials(userName, password);
			//var greet=await portClient.GreetingAsync("Ahasan");
			Console.WriteLine("Hello World!");

		}
	}
}
