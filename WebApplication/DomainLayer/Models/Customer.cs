using System.Collections.Generic;
using WebApplication.Interfaces;

namespace DomainLayer.Models
{
    public class Customer : IEntity<long>
    {
        public long Id { get; set; }

        public string CustomerName { get; set; }

        public string ContactEmail { get; set; }

        public string MobileNo { get; set; }

        public virtual ICollection<Transaction> Transaction { get; set; }
    }
}