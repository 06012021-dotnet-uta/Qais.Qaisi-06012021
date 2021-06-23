using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shopping.Models;

namespace RLL
{
    public class RStore : DbContext
    {
        

        public DbSet<User> Users { get; set; }
        public DbSet<StoresName> StoresNames { get; set; }

        public DbSet<StoreBranch> storeBranches { get; set; }
        public DbSet<ItemsCat> itemsCats { get; set; }
        public DbSet<ItemsSubCat> itemsSubCats { get; set; }
        public DbSet<Item> items { get; set; }
        public DbSet<Inventory> inventories { get; set; }
        public DbSet<OrderNumber> orderNumbers { get; set; }
        public DbSet<Order> OrderList { get; set; }


        public RStore(DbContextOptions<RStore> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {



            //if (!optionsBuilder.IsConfigured)
            //{

            //   optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=SHOPPING_DB;Trusted_Connection=True;");
            //}
        }




    }
}
