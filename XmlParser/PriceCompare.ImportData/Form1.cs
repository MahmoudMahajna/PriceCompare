using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PriceCompare.DAL.Data;
using PriceCompare.Model;
using PriceCompare.XmlParser;
using Item = PriceCompare.XmlParser.Item;
using Store = PriceCompare.XmlParser.Store;

namespace PriceCompare.ImportData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            using (var context = new PriceCompareDbContext())
            {
                try
                {
                    var itemCollection = (TivTamItemCollection)new TivTamPriceXmlParser().Parse(new StreamReader(openFileDialog1.FileName));
                    var items = itemCollection.Items;
                    AddItemsAndPrices(context, itemCollection.StoreId, items);
                    context.SaveChanges();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            using (var context = new PriceCompareDbContext())
            {
                try
                {
                    var itemCollection = (ShofesalItemsCollection)new ShofersalPriceXmlParser().Parse(new StreamReader(openFileDialog1.FileName));
                    var items = itemCollection.Items;
                    AddItemsAndPrices(context, itemCollection.StoreId, items);
                   await context.SaveChangesAsync();
                    MessageBox.Show(@"Done");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
        }

        private static void AddItemsAndPrices(PriceCompareDbContext context, int storeId, Item[] items)
        {
            var itemsToAdd = items.Select(
                item => new Model.Item
                {
                    ItemCode = item.ItemCode,
                    ItemType = item.ItemType,
                    ItemName = item.ItemName,
                    IsWeighted = item.IsWeighted,
                    ManufactureName = item.ManufacturerName
                });
            var toAdd = itemsToAdd as List<Model.Item> ?? itemsToAdd.ToList();
            RemoveExistItems(toAdd, context.Items);
            context.Items.AddRange(toAdd);
            var pricesToAdd = items.Select(
                item => new Price
                {
                    ItemCode = item.ItemCode,
                    StoreId = storeId,
                    ChainId = item.ChainId,
                    ItemPrice = item.ItemPrice,
                    ItemName = item.ItemName,
                    Quantity = item.Quantity,
                    UnitOfMeasurePrice = item.UnitOfMeasurePrice
                });

            context.Prices.AddRange(pricesToAdd);
        }

        private static void RemoveExistItems(ICollection<Model.Item> itemsToAdd, IQueryable<Model.Item> items)
        {
            var existItems = itemsToAdd.Where(item => items.FirstOrDefault(item1 => item.ItemCode == item1.ItemCode) != null).ToList();
            existItems.ForEach(item => itemsToAdd.Remove(item));
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            using (var context = new PriceCompareDbContext())
            {
                try
                {
                    var itemCollection = (TivTamItemCollection)new TivTamPriceXmlParser().Parse(new StreamReader(openFileDialog1.FileName));
                    var items = itemCollection.Items;
                    AddItemsAndPrices(context, itemCollection.StoreId, items);
                    await context.SaveChangesAsync();
                    MessageBox.Show(@"Done");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
        }


        private async void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            using (var context = new PriceCompareDbContext())
            {
                try
                {
                    var storeCollection = (StoresCollection)new StoresXmlParser().Parse(new StreamReader(openFileDialog1.FileName));
                    var stores = storeCollection.Stores;
                    AddStores(context, stores);
                    await context.SaveChangesAsync();
                    MessageBox.Show(@"Done");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
        }

        private static void AddStores(PriceCompareDbContext context, IEnumerable<Store> stores)
        {
            var storesToAdd = stores.Select(
                store => new Model.Store
                {
                    BikoretNo = store.BikoretNo,
                    ChainId = store.ChainId.ToString(),
                    StoreId = store.StoreId,
                    StoreName = store.StoreName,
                    StoreType = store.StoreType
                });
            context.Stores.AddRange(storesToAdd);
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            using (var context = new PriceCompareDbContext())
            {
                try
                {

                    context.Chains.Add(new Chain {ChainId = "7290058140886", ChainName = "רמי לוי"});
                    context.Chains.Add(new Chain { ChainId = "7290027600007", ChainName = "שופרסל" });
                    context.Chains.Add(new Chain { ChainId = "7290873255550", ChainName = "טיב טעם" });

                    context.SaveChanges();
                    MessageBox.Show(@"Added");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
        }
    }
}



