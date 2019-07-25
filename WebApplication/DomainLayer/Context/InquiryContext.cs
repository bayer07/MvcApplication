using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace DomainLayer.Context
{
    public class InquiryContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public InquiryContext() : base("name=Context")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<InquiryContext>());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<InquiryContext>());
            Database.SetInitializer(new DropCreateDatabaseAlways<InquiryContext>());
            Database.SetInitializer(new InquiryInitializer());
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Transaction> Transactions { get; set; }
    }

    public class InquiryInitializer : CreateDatabaseIfNotExists<InquiryContext>
    {
        protected override void Seed(InquiryContext context)
        {
            base.Seed(context);

            var transaction1 = new Transaction { Amount = 10, CurrencyCode = "usd", TransactionDateTime = DateTime.Now, Status = Enums.CurrencyCodesEnum.Success };
            var transaction2 = new Transaction { Amount = 20, CurrencyCode = "rub", TransactionDateTime = DateTime.Now, Status = Enums.CurrencyCodesEnum.Success };
            var transactions1 = new List<Transaction> { transaction1, transaction2 };
            context.Customers.Add(new Customer { ContactEmail = "test1@mail.com", CustomerName = "User1", MobileNo = "+123456789", Transactions = transactions1 });

            var transaction3 = new Transaction { Amount = 10, CurrencyCode = "usd", TransactionDateTime = DateTime.Now, Status = Enums.CurrencyCodesEnum.Success };
            var transaction4 = new Transaction { Amount = 20, CurrencyCode = "rub", TransactionDateTime = DateTime.Now, Status = Enums.CurrencyCodesEnum.Success };
            var transactions2 = new List<Transaction> { transaction1, transaction2 };
            context.Customers.Add(new Customer { ContactEmail = "test2@mail.com", CustomerName = "User2", MobileNo = "+234567890", Transactions = transactions2 });

            var transaction5 = new Transaction { Amount = 10, CurrencyCode = "usd", TransactionDateTime = DateTime.Now, Status = Enums.CurrencyCodesEnum.Success };
            var transaction6 = new Transaction { Amount = 20, CurrencyCode = "rub", TransactionDateTime = DateTime.Now, Status = Enums.CurrencyCodesEnum.Success };
            var transactions3 = new List<Transaction> { transaction1, transaction2 };
            context.Customers.Add(new Customer { ContactEmail = "test2@mail.com", CustomerName = "User3", MobileNo = "+345678901", Transactions = transactions3 });
        }
    }
}
