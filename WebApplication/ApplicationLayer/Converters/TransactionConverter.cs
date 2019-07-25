using ApplicationLayer.Dto;
using DomainLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace ApplicationLayer.Converters
{
    public class TransactionsConverter
    {
        public static IEnumerable<TransactionDto> Convert(IEnumerable<Transaction> transactions)
        {
            return transactions.Select(x => new TransactionDto { Id = x.TransactionID, Amount = x.Amount.ToString(), Currency = x.CurrencyCode, Date = x.TransactionDateTime.ToString("MM/dd/yyyy HH:mm"), Status = x.Status.ToString() });
        }
    }
}
