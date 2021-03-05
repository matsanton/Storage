using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Storage.Models;

namespace Storage.Data
{
    public class StorageContext : DbContext
    {
        public DbSet<Storage.Models.Product> Product { get; set; }
        public StorageContext (DbContextOptions<StorageContext> options)
            : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Product>().HasData(
        //        new Product
        //        {
        //            Id = 2,
        //            Name = "S10",
        //            Category = "Mobile",
        //            Count = 98,
        //            Description = "Better",
        //            Orderdate = DateTime.Now.AddDays(-5),
        //            Price = 45000,
        //            Shelf = "9"
        //        }
        //    );
            
        //}

    }
}
