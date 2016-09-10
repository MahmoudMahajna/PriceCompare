using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PriceCompare.Model;
using PriceCompareLogic;
using Item = PriceCompare.Model.Item;

namespace PriceCompareApp
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
                })).ContinueWith(x => BeginInvoke((Action)(() => itemsPanel.Controls.AddRange(itemsForShow.ToArray<Control>()))));
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
                if (!long.TryParse(((ItemForShow) ((Control) sender).Parent).lblCode.Text, out itemCode)) return;
                await _priceCompareManager.AddItemToCartAsync(itemCode);
                MessageBox.Show(@"Added");
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
            new CartContent(_priceCompareManager).Show();
        }
    }
}