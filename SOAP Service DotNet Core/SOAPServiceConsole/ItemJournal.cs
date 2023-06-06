using System;
using System.Collections.Generic;
using System.Text;

namespace SOAPServiceConsole
{
	public class ItemJournal
	{
        public string posting_date { get; set; }
        public string document_no { get; set; }
        public List<JournalLineItem> line_items { get; set; }
    }
}
