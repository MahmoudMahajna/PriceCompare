using System;

namespace DatabaseManager
{
    class Program
    {
        static void Main(string[] args)
        {
            FillItemsIntoDatabse();
            Console.Read();
        }

        static void FillItemsIntoDatabse()
        {
            //var parser = new PriceXmlParser();
          //  ItemsCollection prices =(ItemsCollection) parser.Parse(new StreamReader(@"C:\Users\Mahmood\Desktop\PriceFull7290027600007-001-201608220331.xml"));
            //using (PriceCompareDataBaseEntities contex=new PriceCompareDataBaseEntities())
            //{
            //    foreach (var item in prices.Items)
            //    {
            //        contex.Items.Add(new Item() {ItemType = item.ItemType, ItemCode = item.ItemCode.ToString()});
            //    }
            //    contex.SaveChanges();
            //}
            using (PriceCompareDataBaseEntities contex = new PriceCompareDataBaseEntities())
            {
               contex.Items.Add(new Item() {Id=100,ItemCode = "123", ItemType = 12});
               contex.SaveChanges();
            }
        }
    }
}
