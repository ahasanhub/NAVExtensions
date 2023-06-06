using System;
using System.Collections.Generic;
using System.Text;

namespace SOAPServiceConsole
{
	public class JournalLineItem
	{
        public int entry_type { get; set; }
        public string item_no { get; set; }
        public string location_code { get; set; }
        public int quantity { get; set; }
    }
}
