using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Lab2_DbContext.Models;

namespace Lab2_DbContext.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=SHUBAMS-PC\MSSQLSERVER01;Database=RetailDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

    }
}
