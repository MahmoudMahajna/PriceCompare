using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ConsoleApplication1
{
    public class PriceCompare1DbContext : DbContext
    {
        public PriceCompare1DbContext()
        {

        }

       public DbSet<Item> Items { get; set; }
     //  public DbSet<Store> Stores { get; set; }
     //  public DbSet<Price> Prices { get; set; }
      //  public DbSet<Chain> Chains { get; set; }
    }
}