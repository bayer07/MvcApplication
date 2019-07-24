using System.Data.Entity;

namespace WebApplication.Context
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
        }

        public System.Data.Entity.DbSet<WebApplication.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<WebApplication.Models.Transaction> Transactions { get; set; }
    }
}
