
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IdentityModel.Selectors;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace SOAPServiceConsole
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			//await PurchaseReceiveFromLocal();
			//await PurchaseReceiveFromTest();

			//await ItemJournalFromLocal();
			//await ItemJournalFromTest();	
			//await ItemJournalFromLocalBC();	
			//await TransferOrderFromLocalBC();
			//await TransferOrderFromBCTest();
			await ReportDownloadFromLocalBC();

        }
		public static async Task PurchaseReceiveFromLocal()
		{
			var company = "APSCL";
			var client = new ServiceReference1.ExecuteCodeUnit_PortClient();
			var binding = new BasicHttpBinding();
			binding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
			binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;

			client.Endpoint.Binding = binding;
			client.Endpoint.Address = new EndpointAddress($"http://win-jhhr4oovksp:7047/POWERDIVERPSERVICE/WS/{company}/Codeunit/ExecuteCodeUnit");
			client.ClientCredentials.UserName.UserName = "super_admin";
			client.ClientCredentials.UserName.Password = "Techvision123?";

			var order = new PurchaseOrder { document_no = "PO0001409", items = new List<Item> { new Item { item_no = "PO0001347", receive_qty = 3 }, } };
			//var order = new PurchaseOrder { document_no = "PO0001407", items = new List<Item> { new Item { item_no = "PO0001327", receive_qty = 2 }, new Item { item_no = "PO0001328", receive_qty = 2 }, new Item { item_no = "PO0001329", receive_qty = 1 }, } };
			var orderString = Newtonsoft.Json.JsonConvert.SerializeObject(order);
			try
			{				
				await client.ExecuteAsync("PurchaseReceive", orderString);
				Console.WriteLine("Purchase receive has been completed.");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				//throw;
			}
		}
		public static async Task ItemJournalFromLocal()
		{
			var company = "APSCL";
			var client = new ServiceReference1.ExecuteCodeUnit_PortClient();
			var binding = new BasicHttpBinding();
			binding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
			binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;

			client.Endpoint.Binding = binding;
			client.Endpoint.Address = new EndpointAddress($"http://win-nem95r88i3f:7047/ERPDEVNAV110/WS/{company}/Codeunit/ExecuteCodeUnit");
			client.ClientCredentials.UserName.UserName = "super_admin";
			client.ClientCredentials.UserName.Password = "Techvision123?";
			
			//Line Item entrytype is option field that contains the following options
			// 0=Purchase,1=Sale,2=Positive Adjmt.,3=Negative Adjmt.,4=Transfer,5=Consumption,6=Output,9="" ,8=Assembly Consumption,9=Assembly Output
			var itemJournal = new ItemJournal { posting_date= DateTime.Today.ToString("dd/MM/yyyy",CultureInfo.InvariantCulture), document_no = "DX029", line_items = new List<JournalLineItem> { new JournalLineItem { entry_type = 2, item_no = "ITM0000002",location_code="GREEN", quantity=7 }, } };
			var itemJournalString = Newtonsoft.Json.JsonConvert.SerializeObject(itemJournal);
			try
			{
				var result=await client.ExecuteAsync("ItemJournal", itemJournalString);
				//Console.WriteLine("Item Journal were successfully posted.");
				Console.WriteLine(result.return_value);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				//throw;
			}
		}

		public static async Task ItemJournalFromTest()
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

			//Line Item entrytype is option field that contains the following options
			// 0=Purchase,1=Sale,2=Positive Adjmt.,3=Negative Adjmt.,4=Transfer,5=Consumption,6=Output,9="" ,8=Assembly Consumption,9=Assembly Output
			var itemJournal = new ItemJournal { posting_date = DateTime.Today.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture), document_no = "Dx028", line_items = new List<JournalLineItem> { new JournalLineItem { entry_type = 2, item_no = "ITM0000002",location_code="GREEN", quantity = 4 }, } };
			var itemJournalString = Newtonsoft.Json.JsonConvert.SerializeObject(itemJournal);
			try
			{
				var result = await client.ExecuteAsync("ItemJournal", itemJournalString);
				//Console.WriteLine("Item Journal were successfully posted.");
				Console.WriteLine(result.return_value);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				//throw;
			}
		}
		public static async Task ItemJournalFromLocalBC()
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

			//Line Item entrytype is option field that contains the following options
			// 0=Purchase,1=Sale,2=Positive Adjmt.,3=Negative Adjmt.,4=Transfer,5=Consumption,6=Output,9="" ,8=Assembly Consumption,9=Assembly Output
			var itemJournal = new ItemJournal { posting_date = DateTime.Today.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture), document_no = "DC010", line_items = new List<JournalLineItem> { new JournalLineItem { entry_type = 2, item_no = "ITM0000002", quantity = 7 }, } };
			var itemJournalString = Newtonsoft.Json.JsonConvert.SerializeObject(itemJournal);
			try
			{
				var result = await client.ExecuteAsync("ItemJournal", itemJournalString);
				//Console.WriteLine("Item Journal were successfully posted.");
				Console.WriteLine(result.return_value);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				//throw;
			}
		}
		public static async Task PurchaseReceiveFromTest()
		{
			var company = "APSCL";
			var client = new ServiceReference2.ExecuteCodeUnit_PortClient();
			var binding = new BasicHttpBinding();
			binding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
			binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;

			client.Endpoint.Binding = binding;
			client.Endpoint.Address = new EndpointAddress($"http://bctest.bdpowersectorerp.com:7047/POWERDIVBC/WS/{company}/Codeunit/ExecuteCodeUnit");
			client.ClientCredentials.UserName.UserName = "super_admin";
			client.ClientCredentials.UserName.Password = "Techvision123?";



			var order = new PurchaseOrder { document_no = "PO0001331", items = new List<Item> { new Item { item_no = "ITM0000003", receive_qty = 1 }, } };
			//var order = new PurchaseOrder { document_no = "PO0001407", items = new List<Item> { new Item { item_no = "PO0001327", receive_qty = 2 }, new Item { item_no = "PO0001328", receive_qty = 2 }, new Item { item_no = "PO0001329", receive_qty = 1 }, } };
			var orderString = Newtonsoft.Json.JsonConvert.SerializeObject(order);
			try
			{
				
				await client.ExecuteAsync("PurchaseReceive", orderString);				
				Console.WriteLine("Purchase receive has been completed.");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				//throw;
			}
		}

        public static async Task TransferOrderFromLocalBC()
        {
			var client = WebService.BCLocalClient();
            //{"transfer_order_no":"1014","transfer_from":"DHAKA","transfer_to":"SYLHET","direct_transfer":false,"in_transit":"INTRANLOC",
			//"posting_date":"23/05/2023","post_type":"None|Ship|Receive|Ship&Receive","transfer_items":[{"item_no":"ITM0000002","quantity":6}]}';
            var transferOrder = new TransferOrder { transfer_order_no="1035",transfer_from= "DHAKA" ,transfer_to= "SYLHET" ,direct_transfer=false,
				in_transit= "INTRANLOC" ,posting_date = DateTime.Today.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture), post_type= "Ship&Receive",
				transfer_items=new List<TransferItem> { new TransferItem { item_no= "ITM0000002", quantity = 5 } } };
            
            var transferOrderString = Newtonsoft.Json.JsonConvert.SerializeObject(transferOrder);
            try
            {
                var result = await client.ExecuteAsync("TransferOrder", transferOrderString);
                //Console.WriteLine("Item Journal were successfully posted.");
                Console.WriteLine(result.return_value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                //throw;
            }
        }

        public static async Task TransferOrderFromBCTest()
        {
            var client = WebService.BCTestClient();
            //{"transfer_order_no":"1014","transfer_from":"DHAKA","transfer_to":"SYLHET","direct_transfer":false,"in_transit":"INTRANLOC",
            //"posting_date":"23/05/2023","post_type":"None|Ship|Receive|Ship&Receive","transfer_items":[{"item_no":"ITM0000002","quantity":6}]}';
            var transferOrder = new TransferOrder
            {
                transfer_order_no = "TO006",
                transfer_from = "DHAKA1",
                transfer_to = "GAZIPUR",
                direct_transfer = false,
                in_transit = "ASHUGANJ",
                posting_date = DateTime.Today.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                post_type = "Ship",
                transfer_items = new List<TransferItem> { new TransferItem { item_no = "ITM0000002", quantity = 12 } }
            };

            var transferOrderString = Newtonsoft.Json.JsonConvert.SerializeObject(transferOrder);
            try
            {
                var result = await client.ExecuteAsync("TransferOrder", transferOrderString);
                //Console.WriteLine("Item Journal were successfully posted.");
                Console.WriteLine(result.return_value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                //throw;
            }
        }

		public static async Task ReportDownloadFromLocalBC()
		{
			var client= WebService.ReportBCLocalClient();
            try
            {
                //var reportNo = 50156;
                var reportNo = 50082;
                //var parameters = "<?xml version=\"1.0\" standalone=\"yes\"?><ReportParameters name=\"Training Summary Report\" id=\"50156\"><Options><Field name=\"OfficeCode\">100</Field><Field name=\"OfficeName\">MANAGING DIRECTOR OFFICE</Field><Field name=\"IncludeChildOffice\">false</Field><Field name=\"test\" /><Field name=\"DesignationCode\" /><Field name=\"DesignationName\" /><Field name=\"DesignationType\">0</Field><Field name=\"CadreOption\">0</Field><Field name=\"FromDateVariable\">2023-03-01</Field><Field name=\"ToDateVariable\">2023-05-15</Field></Options><DataItems><DataItem name=\"Company\">VERSION(1) SORTING(Field1)</DataItem></DataItems></ReportParameters>";
                var parameters = "<?xml version=\"1.0\" standalone=\"yes\"?><ReportParameters name=\"Employee Foreign Tour\" id=\"50082\"><Options><Field name=\"FromDateVariable\" /><Field name=\"ToDateVariable\" /><Field name=\"OfficeId\">100</Field><Field name=\"OfficeName\">MANAGING DIRECTOR OFFICE</Field><Field name=\"DesignationCode\" /><Field name=\"DesignationName\" /><Field name=\"EmployeeId\" /><Field name=\"EmployeeName\" /><Field name=\"TourCategoryName\">0</Field><Field name=\"test\" /><Field name=\"TourPurpose\" /><Field name=\"TourPurposeName\" /><Field name=\"CountryCode\" /><Field name=\"CountryName\" /></Options><DataItems><DataItem name=\"Company Information\">VERSION(1) SORTING(Field1)</DataItem><DataItem name=\"Employee Foreign Tour\">VERSION(1) SORTING(Field7) ORDER(1)</DataItem></DataItems></ReportParameters>";
                var result = await client.GenerateReportAsync(reportNo, parameters);
                //File.WriteAllBytes("C:\\temp\report50156.pdf", Convert.FromBase64String(result.return_value));
                using (System.IO.FileStream stream = System.IO.File.Create("c:\\temp\\file.pdf"))
                {
                    System.Byte[] byteArray = System.Convert.FromBase64String(result.return_value);
                    stream.Write(byteArray, 0, byteArray.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                //throw;
            }
        }
    }
}
