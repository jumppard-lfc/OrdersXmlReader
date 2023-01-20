using System;
namespace OrdersReaderBlazorApp.Data
{
	public class Employee1
	{
        public long Id { get; set; }
		public string Name { get; set; }
		public string Designation { get; set; }
		public DateOnly DOJ { get; set; } // new DateOnly(1998, 11, 17)
		public bool IsActive { get; set; }

		public Employee1() {}
    }
}

