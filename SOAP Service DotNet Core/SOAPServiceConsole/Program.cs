using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace SOAPServiceConsole
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			var client = new ExecuteCodeUnit_PortClient();
			var binding = new BasicHttpBinding();
			binding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
			binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;

			client.Endpoint.Binding = binding;
			client.Endpoint.Address = new EndpointAddress("http://win-jhhr4oovksp:7047/POWERDIVERPSERVICE/WS/APSCL/Codeunit/ExecuteCodeUnit");
			client.ClientCredentials.UserName.UserName = "super_admin";
			client.ClientCredentials.UserName.Password = "Techvision123?";

			var order = new PurchaseOrder { document_no = "PO0001408", items = new List<Item> { new Item { item_no = "PO0001347", receive_qty = 2 }, } };
			//var order = new PurchaseOrder { document_no = "PO0001407", items = new List<Item> { new Item { item_no = "PO0001327", receive_qty = 2 }, new Item { item_no = "PO0001328", receive_qty = 2 }, new Item { item_no = "PO0001329", receive_qty = 1 }, } };
			var orderString= Newtonsoft.Json.JsonConvert.SerializeObject(order);
			try
			{
				var result=await client.ExecuteAsync("PurchaseReceive", orderString);
				Console.WriteLine(result.return_value);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				//throw;
			}
			
		}
	}
}
