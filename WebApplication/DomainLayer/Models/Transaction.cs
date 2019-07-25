using System;
using DomainLayer.Enums;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }

        public DateTime TransactionDateTime { get; set; }

        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Invalid Amount")]
        public float Amount { get; set; }

        public string CurrencyCode { get; set; }

        public CurrencyCodesEnum Status { get; set; }
    }
}