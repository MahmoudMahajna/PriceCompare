using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServerAPI.Models;

namespace ServerAPI.Tests
{
    [TestClass]
    class DatabaseCreateTest
    {
        [TestMethod]
        public void DatabaseCreate()
        {
            using (var context = new PriceCompareDbContext())
            {
                context.Items.Add(new Item() {ItemCode = "123", ItemId = 1, ItemType = 1});
                context.SaveChanges();
            }
        }
    }
}
