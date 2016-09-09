using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PriceCompare.DAL.Data;
using PriceCompare.Logic;
using PriceCompare.Model;
using PriceCompare.XmlParser;
using PriceCompareApp;
using Item = PriceCompare.Model.Item;

namespace PriceCompare.App
{
    public partial class MainWindow : Form
    {
        private readonly PriceCompareManager _priceCompareManager;
        public MainWindow(User user)
        {
            InitializeComponent();
            _priceCompareManager = new PriceCompareManager(user);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblHello.Text = $"Hello {_priceCompareManager.User.Name}";
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text.Length == 0)
                {
                    return;
                }
                var items = await _priceCompareManager.GetItemsByNameAsync(txtSearch.Text);
                var itemsForShow = new List<ItemForShow>();
                BeginInvoke((Action) (() => itemsPanel.Controls.Clear()));
                await Task.Run(() => items?.AsParallel().ForAll(item =>
                {
                    itemsForShow.Add(new ItemForShow(item.ItemCode, item.ItemName, AddItemToCart));
                })).ContinueWith(x => BeginInvoke((Action)(() => itemsPanel.Controls.AddRange(itemsForShow.ToArray()))));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                Invoke((Action)(() => itemsPanel.Controls.Clear()));
                IEnumerable<Item> items1 = null, items2 = null, items3 = null;
                if (checkBox1.Checked)
                {
                    items1 = await _priceCompareManager.GetItemsWithManufactureNameAsync(checkBox1.Text);
                }
                if (checkBox2.Checked)
                {
                    items2 = await _priceCompareManager.GetItemsWithManufactureNameAsync(checkBox2.Text);
                }
                if (checkBox3.Checked)
                {
                    items3 = await _priceCompareManager.GetItemsWithManufactureNameAsync(checkBox3.Text);
                }
                await AddItemsToPanelAsync(items1);
                await AddItemsToPanelAsync(items2);
                await AddItemsToPanelAsync(items3);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private async Task AddItemsToPanelAsync(IEnumerable<Item> items) =>
            await Task.Run(() =>
            {
                BeginInvoke((Action)(() => items?.ToList().ForEach(item =>
                {
                    var itemForShow = new ItemForShow(item.ItemCode, item.ItemName, AddItemToCart);
                    itemsPanel.Controls.Add(itemForShow);
                })));
            });

        private async void AddItemToCart(object sender, MouseEventArgs e)
        {
            try
            {
                long itemCode;
                if (long.TryParse(((ItemForShow)((Control)sender).Parent).lblCode.Text, out itemCode))
                {
                    await _priceCompareManager.AddItemToCartAsync(itemCode);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGoToCart_Click(object sender, EventArgs e)
        {
            new CartContent(_priceCompareManager).ShowDialog();
        }
    }
}


//using (var context = new PriceCompareDbContext())
//{
//    //var substring = txtSearch.Text;
//    //itemsPanel.Controls.Clear();
//    //await context.Items.Where(item => item.ItemName.Contains(substring)).ForEachAsync(item =>
//    //{
//    //    var itemForShow = new ItemForShow(item.ItemCode, item.ItemName);
//    //    itemsPanel.Invoke((Action)(() => itemsPanel.Controls.Add(itemForShow)));
//    //});
//    //ItemRepository ir = new ItemRepository(context);
//    //var items = await ir.GetAllItems();
//    //var x= itemsPanel.BeginInvoke((Action) (() => items.ToList().ForEach(item =>
//    //{
//    //    var itemForShow = new ItemForShow(item.ItemCode, item.ItemName);
//    //    itemsPanel.Controls.Add(itemForShow);
//    //})));
//}

//using (var context = new PriceCompareDbContext())
//{


//    //context.Chains.AddOrUpdate(c => c.ChainId, new Chain()
//    //{
//    //    ChainId = "7290027600007",
//    //    ChainName = "שופרסל"
//    //});
//    //var storeCollection =
//    //    (StoresCollection)
//    //        new StoresXmlParser().Parse(new StreamReader(@"C:\Users\Mahmood\Desktop\StoresShoperSal.xml"));
//    //var stores = storeCollection.Stores;
//    //stores.ToList().ForEach(store =>context.Stores.Add(
//    //    new Store()
//    //            {
//    //                StoreId = store.StoreId,
//    //                StoreName = store.StoreName,
//    //                StoreType = store.StoreType,
//    //                ChainId = store.SubChainId,
//    //                BikoretNo = store.BikoretNo
//    //            }));
//    //var itemCollection = (ItemsCollection)new PriceXmlParser().Parse(new StreamReader(@"C:\Users\Mahmood\Desktop\PriceFull7290027600007-001-201608220331.xml"));
//    //var items = itemCollection.Items;
//    //items.ToList().ForEach((item) => AddOrUpdatePrices(item, context, itemCollection));

//    //var aa = context.Items.Select(i => i);
//    //context.Items.RemoveRange(aa);
//    //var aaa = context.Prices.Select(i => i);
//    //context.Prices.RemoveRange(aaa);

//    //var itemCollection = (ItemsCollection)new PriceXmlParser().Parse(new StreamReader(@"C:\Users\Mahmood\Desktop\PriceFull7290027600007-001-201608220331.xml"));
//    //var items = itemCollection.Items;
//    //var itemsToAdd = items.Select(
//    //    item =>
//    //        new PriceCompare.Model.Item()
//    //        {
//    //            ItemCode = item.ItemCode,
//    //            ItemType = item.ItemType,
//    //            ItemName = item.ItemName,
//    //            IsWeighted = item.IsWeighted,
//    //            ManufactureName = item.ManufacturerName
//    //        });

//    //context.Items.AddRange(itemsToAdd);

//    var itemCollection = (TivTamItemCollection)new TivTamPriceXmlParser().Parse(new StreamReader(@"C:\Users\Mahmood\Desktop\PriceFull7290873255550-002-201608290010.xml"));
//    var items = itemCollection.Items;
//    var itemsToAdd = items.Select(
//        item =>
//            new Item
//            {
//                ItemCode = item.ItemCode,
//                ItemType = item.ItemType,
//                ItemName = item.ItemName,
//                IsWeighted = item.IsWeighted,
//                ManufactureName = item.ManufacturerName
//            }
//        );

//    context.Items.AddRange(itemsToAdd);
//    var pricesToAdd = items.Select(item => new Price
//    {
//        ItemCode = item.ItemCode,
//        StoreId = itemCollection.StoreId,
//        ItemPrice = (float)item.ItemPrice
//    });
//    context.Prices.AddRange(pricesToAdd);

//    try
//    {
//        context.SaveChanges();
//    }
//    catch (Exception exception)
//    {
//        MessageBox.Show(exception.ToString());
//    }
//}