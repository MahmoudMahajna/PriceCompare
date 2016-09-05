using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServerAPI.Models
{
    public class PriceCompareDbContext : DbContext
    {
        public PriceCompareDbContext()
        {

        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Price> Prices { get; set; }
       // public DbSet<Store> Chains { get; set; }
    }
}