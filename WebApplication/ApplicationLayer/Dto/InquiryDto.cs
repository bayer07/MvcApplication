using System.Collections.Generic;
using DomainLayer.Models;

namespace ApplicationLayer.Dto
{
    public class InquiryDto
    {
        public long CustomerID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public IEnumerable<TransactionDto> Transactions { get; set; }
    }
}
