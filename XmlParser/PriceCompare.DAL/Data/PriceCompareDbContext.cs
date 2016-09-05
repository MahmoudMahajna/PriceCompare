using System.Data.Entity;
using PriceCompare.Model;

namespace PriceCompare.DAL.Data
{
    public class PriceCompareDbContext : DbContext
    {
        public PriceCompareDbContext()
        {
            Database.SetInitializer(new PriceCompareInitializer());
        }

       public DbSet<Item> Items { get; set; }
        public DbSet<Store> Stores { get; set; }
       public DbSet<Price> Prices { get; set; }
        public DbSet<Chain> Chains { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<ItemInCart> ItemsCarts { get; set; }
    }
}