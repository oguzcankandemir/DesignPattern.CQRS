using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.DAL
{
    public class Context:DbContext
    {
            
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-D6N7I1U;initial catalog=DesignPattern2;integrated security=true;");
        }
        public DbSet<Product> Products { get; set; }
    }
}

