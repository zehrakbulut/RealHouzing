using Microsoft.EntityFrameworkCore;
using RealHouzing.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-51V7O1A;initial catalog=RealHouzingApiDb;integrated security=true");
        }

        public DbSet<Category> Categories { get;set; }
        public DbSet<Product> Products { get; set; }
    }
}
