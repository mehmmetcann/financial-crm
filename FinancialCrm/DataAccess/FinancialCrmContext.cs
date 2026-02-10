using FinancialCrm.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialCrm.DataAccess
{
    public class FinancialCrmContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public FinancialCrmContext()
            : base("Server=localhost\\SQLEXPRESS;Database=FinancialCrmDb;Trusted_Connection=True;")
        {
        }
    }
}
