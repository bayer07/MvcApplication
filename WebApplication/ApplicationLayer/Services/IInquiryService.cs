using ApplicationLayer.Dto;
using System.Collections.Generic;

namespace ApplicationLayer.Services
{
    public interface IInquiryService
    {
        IEnumerable<InquiryDto> GetInquiry(long customerId);

        IEnumerable<InquiryDto> GetInquiry(string customerEmail);

        IEnumerable<InquiryDto> GetInquiry(long customerId, string customerEmail);
    }
}
