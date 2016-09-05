using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class ADbContext:DbContext
    {
        public DbSet<Item> Items { get; set; }
    }

    internal class Item
    {
        public int ItemId { get; set; }
        public int num { get; set; }
    }
}
