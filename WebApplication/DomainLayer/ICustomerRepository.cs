using DomainLayer;
using DomainLayer.Models;
using System.Collections.Generic;
using WebApplication.Interfaces;

public interface ICustomerRepository : IRepository<Customer, long>
{
    IEnumerable<Customer> GetInquiry(long customerId);

    IEnumerable<Customer> GetInquiry(string customerEmail);

    IEnumerable<Customer> GetInquiry(long customerId, string customerEmail);
}