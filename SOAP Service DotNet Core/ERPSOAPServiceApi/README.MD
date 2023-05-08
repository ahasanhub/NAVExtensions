SOAP Service Add in Asp.Net Core web api
1. Add the SOAP service reference to your ASP.NET Core project using the "Add Service Reference" dialog or the dotnet-svcutil tool.
2. In your code, create an instance of the service client using the generated proxy class:
   var client = new MyServiceClient();
3. Create a BasicHttpBinding object and set the Security property to use basic authentication:
   var binding = new BasicHttpBinding();
   binding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
   binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
4. Set the Endpoint.Binding property of the service client to use the BasicHttpBinding object:
   client.Endpoint.Binding = binding;
5. Set the ClientCredentials.UserName and ClientCredentials.Password properties of the service client to specify the username and password for the service:
   client.ClientCredentials.UserName.UserName = "myUsername";
   client.ClientCredentials.UserName.Password = "myPassword";
6. Call the SOAP service methods as usual:
   var result = client.MyMethod();

7. Get the Endpoint object of the service client, and set its Address property to the URL of the service:
  var endpoint = client.Endpoint;
   endpoint.Address = new EndpointAddress("http://my-service-url.com/MyService.svc");
