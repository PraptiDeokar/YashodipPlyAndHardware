using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YashodipPlyAndHardware.Models;

namespace YashodipPlyAndHardware.Data
{
    public class AppDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-UH27HU9;Database=YashodipDatabase;Integrated Security=True;TrustServerCertificate=True");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory>Subcategories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Bill> BillMaster { get; set; }

        public DbSet<BillChild> BillChild { get; set; }

    }
}
