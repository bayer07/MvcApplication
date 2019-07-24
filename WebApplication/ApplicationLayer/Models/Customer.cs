using System.Collections.Generic;

namespace WebApplication.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public string CustomerName { get; set; }

        public string ContactEmail { get; set; }

        public string MobileNo { get; set; }

        public IEnumerable<int> MyProperty { get; set; }
    }
}