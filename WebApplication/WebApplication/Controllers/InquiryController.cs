using System;
using ApplicationLayer.Dto;
using ApplicationLayer.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace WebApplication.Controllers
{
    [RoutePrefix("api")]
    public class InquiryController : ApiController
    {
        readonly IInquiryService inquiryService;

        public InquiryController(IInquiryService inquiryService)
        {
            this.inquiryService = inquiryService;
        }

        [HttpGet]
        [Route("inquiry/{customerId}")]
        public IEnumerable<InquiryDto> GetTransaction(long customerId)
        {
            try
            {
                return inquiryService.GetInquiry(customerId);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}