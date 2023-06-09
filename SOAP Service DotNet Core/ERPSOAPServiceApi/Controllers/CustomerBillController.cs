﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiceReference1;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace ERPSOAPServiceApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CustomerBillController : ControllerBase
	{
		private readonly ILogger<CustomerBillController> _logger;

		public CustomerBillController(ILogger<CustomerBillController> logger)
		{
			_logger = logger;
		}
		[HttpPost]
		public async Task<ActionResult<CustomerBill>> PostCustomerBill(CustomerBill bill)
		{
			var profile1 = new Profile { id = 1, first_name = "Ahasan", last_name = "Habib" };
			var profile2 = new Profile { id = 2, first_name = "Ahasan1", last_name = "Habib1" };
			var profile3 = new Profile { id = 3, first_name = "Ahasan2", last_name = "Habib2" };
			
			var profileList = new { result = new List<Profile> { profile1, profile2, profile3 } };
			var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(profileList);
			
			var client = ERPSOAPService.WSClient("BPDB");
			await client.InsertCustomerBillAsync(bill.Name, bill.Year, bill.Month, bill.Amount,jsonString);

			return Ok(bill);//CreatedAtAction(nameof(GetTodoItem), new { id = todoItem.Id }, todoItem);
		}
		[HttpPut("{id}")]
		public async Task<ActionResult> PutCustomerBill(int id, CustomerBill bill)
		{
			var client = ERPSOAPService.WSClient("BPDB");
			await client.UpdateCustomerBillAsync(id,bill.Name,bill.Year,bill.Month,bill.Amount);
			return NoContent();
		}
		[HttpDelete("{id}")]
		public async Task<ActionResult> DeleteCustomerBill(int id)
		{
			var client = ERPSOAPService.WSClient("BPDB");
			await client.DeleteCustomerBillAsync(id);
			return NoContent();
		}

	}
}
