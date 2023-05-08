namespace ERPSOAPServiceApi
{
	public class CustomerBill
	{
        public int Id { get; set; }	
		public string Name { get; set; }
        public int Year { get; set; }
        public string Month { get; set; }
        public decimal Amount { get; set; }
    }
}
