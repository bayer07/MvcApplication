using System;
using WebApplication.Enums;

namespace WebApplication.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }

        public DateTime TransactionDateTime { get; set; }

        public float Amount { get; set; }

        public CurrencyCodesEnum CurrencyCode { get; set; }
    }
}