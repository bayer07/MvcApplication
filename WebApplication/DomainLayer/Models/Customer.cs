using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebApplication.Interfaces;

namespace DomainLayer.Models
{
    public class Customer : IEntity<long>
    {
        [Key]
        public long Id { get; set; }

        [MaxLength(30)]
        public string CustomerName { get; set; }

        [EmailAddress, MaxLength(25)]
        public string ContactEmail { get; set; }

        [Phone, StringLength(maximumLength: 10, MinimumLength = 10)]
        public string MobileNo { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}