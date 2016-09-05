using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new PriceCompare1DbContext())
            {
                db.Items.Add(new Item() {ItemId = 1});
                db.SaveChanges();
            }
        }
    }
}
