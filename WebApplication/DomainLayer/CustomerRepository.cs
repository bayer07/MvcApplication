using DomainLayer.Context;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DomainLayer
{
    public class CustomerRepository : ICustomerRepository
    {
        private InquiryContext dbContext = new InquiryContext();

        public long Create(Customer entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            dbContext.Customers.Add(entity);
            dbContext.SaveChanges();
            return entity.Id;
        }

        public IEnumerable<Customer> GetInquiry(long customerId)
        {
            if (customerId == 0)
                throw new ArgumentNullException(nameof(customerId));

            return dbContext.Customers.Where(x => x.Id == customerId);
        }

        public IEnumerable<Customer> GetInquiry(string customerEmail)
        {
            if (string.IsNullOrEmpty(customerEmail))
                throw new ArgumentNullException(nameof(customerEmail));

            return dbContext.Customers.Where(x => x.ContactEmail.ToLower() == customerEmail.ToLower());
        }

        public IEnumerable<Customer> GetInquiry(long customerId, string customerEmail)
        {
            if (string.IsNullOrEmpty(customerEmail))
                throw new ArgumentNullException(nameof(customerEmail));

            if (customerId == 0)
                throw new ArgumentNullException(nameof(customerId));

            return dbContext.Customers.Where(x => x.ContactEmail.ToLower() == customerEmail.ToLower() && x.Id == customerId);
        }
    }
}
