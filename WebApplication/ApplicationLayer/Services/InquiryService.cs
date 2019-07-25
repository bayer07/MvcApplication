using System.Collections.Generic;
using System.Linq;
using ApplicationLayer.Dto;
using ApplicationLayer.Converters;

namespace ApplicationLayer.Services
{
    public class InquiryService : IInquiryService
    {
        private readonly ICustomerRepository _customerRepository;

        public InquiryService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IEnumerable<InquiryDto> GetInquiry(long customerId)
        {
            var inquiry = _customerRepository.GetInquiry(customerId);
            return inquiry.Select(x => new InquiryDto { CustomerID = x.Id, Email = x.ContactEmail, Mobile = x.MobileNo, Name = x.CustomerName, Transactions = TransactionsConverter.Convert(x.Transactions) });
        }

        public IEnumerable<InquiryDto> GetInquiry(string customerEmail)
        {
            var inquiry = _customerRepository.GetInquiry(customerEmail);
            return inquiry.Select(x => new InquiryDto { CustomerID = x.Id, Email = x.ContactEmail, Mobile = x.MobileNo, Name = x.CustomerName, Transactions = TransactionsConverter.Convert(x.Transactions) });
        }

        public IEnumerable<InquiryDto> GetInquiry(long customerId, string customerEmail)
        {
            var inquiry = _customerRepository.GetInquiry(customerId, customerEmail);
            return inquiry.Select(x => new InquiryDto { CustomerID = x.Id, Email = x.ContactEmail, Mobile = x.MobileNo, Name = x.CustomerName, Transactions = TransactionsConverter.Convert(x.Transactions) });
        }
    }
}
