using System;
using System.Collections.Generic;
using System.Text;

namespace SOAPServiceConsole
{
	public class PurchaseOrder
	{
        public string document_no { get; set; }
        public List<Item> items { get; set; }
    }
}
