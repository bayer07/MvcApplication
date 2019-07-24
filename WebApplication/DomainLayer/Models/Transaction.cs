using System;
using DomainLayer.Enums;

namespace DomainLayer.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }

        public DateTime TransactionDateTime { get; set; }

        public float Amount { get; set; }

        public string CurrencyCode { get; set; }

        public CurrencyCodesEnum Status { get; set; }
    }
}