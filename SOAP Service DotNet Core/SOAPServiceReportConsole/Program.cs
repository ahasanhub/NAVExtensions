using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using System.IO;

namespace SOAPServiceReportConsole
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			var company = "APSCL";
			var client = new ReportService_PortClient();
			var binding = new BasicHttpBinding();
			binding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
			binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
			binding.MaxReceivedMessageSize = 9999999;
			client.Endpoint.Binding = binding;
			client.Endpoint.Address = new EndpointAddress($"http://win-jhhr4oovksp:7047/POWERDIVERPSERVICE/WS/{company}/Codeunit/ReportService");
			client.ClientCredentials.UserName.UserName = "super_admin";
			client.ClientCredentials.UserName.Password = "Techvision123?";

			
			try
			{
				var reportNo = 50156;
				var parameters = "<?xml version=\"1.0\" standalone=\"yes\"?><ReportParameters name=\"Training Summary Report\" id=\"50156\"><Options><Field name=\"OfficeCode\">100</Field><Field name=\"OfficeName\">MANAGING DIRECTOR OFFICE</Field><Field name=\"IncludeChildOffice\">false</Field><Field name=\"test\" /><Field name=\"DesignationCode\" /><Field name=\"DesignationName\" /><Field name=\"DesignationType\">0</Field><Field name=\"CadreOption\">0</Field><Field name=\"FromDateVariable\">2023-03-01</Field><Field name=\"ToDateVariable\">2023-05-15</Field></Options><DataItems><DataItem name=\"Company\">VERSION(1) SORTING(Field1)</DataItem></DataItems></ReportParameters>";
				var result=await client.GenerateReportAsync(reportNo,parameters);
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
