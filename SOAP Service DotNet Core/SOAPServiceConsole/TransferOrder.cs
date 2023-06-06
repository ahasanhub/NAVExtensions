using System;
using System.Collections.Generic;
using System.Text;

namespace SOAPServiceConsole
{
    public class TransferOrder
    {        
        public string transfer_order_no { get; set; }
        public string transfer_from { get; set; }
        public string transfer_to { get; set; }
        public bool direct_transfer { get; set; }
        public string in_transit { get; set; }
        public string posting_date { get; set; }
        public string post_type { get; set; }
        public List<TransferItem> transfer_items { get; set; }

    }
}
