using System;
using System.Collections.Generic;
using System.Linq;
using ApplicationLayer.Dto;

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
            var inquiry = _customerRepository.GetInquiry(customerId).Select(x => new InquiryDto { CustomerID = x.Id, Email = x.ContactEmail, Mobile = x.MobileNo, Name = x.CustomerName });
            return inquiry;
        }

        public IEnumerable<InquiryDto> GetInquiry(string customerEmail)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InquiryDto> GetInquiry(long customerId, string customerEmail)
        {
            throw new NotImplementedException();
        }
    }
}
