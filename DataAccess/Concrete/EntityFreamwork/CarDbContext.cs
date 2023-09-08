using Core.Entities;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFreamwork
{
    public class CarDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server =.\SQLEXPRESS02  ; Database = car ; Trusted_Connection = true; TrustServerCertificate=True");
            
        }
        public DbSet<Car> cars { get; set; }
        public DbSet<Color> colors { get; set; }
        public DbSet<Brand> brands { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<User>  users { get; set; }
        public DbSet<OperationClaim> operationClaims { get; set; }
        public DbSet<UserOperationClaim> userOperationClaims { get; set; }

    }
}
