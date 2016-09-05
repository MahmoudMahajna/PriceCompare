using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ADbContext())
            {
                db.Items.Add(new Item() {ItemId = 1, num = 1});
                db.SaveChanges();
            }
        }
    }
}
