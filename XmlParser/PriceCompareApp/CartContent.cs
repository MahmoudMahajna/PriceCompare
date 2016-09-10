using System;
using System.Linq;
using System.Windows.Forms;
using PriceCompare.Logic;

namespace PriceCompareApp
{
    public partial class CartContent : Form
    {
        private readonly PriceCompareManager _priceCompareManager;
        public CartContent(PriceCompareManager priceCompareManager)
        {
            InitializeComponent();
            _priceCompareManager = priceCompareManager;
        }

        private async void CartContent_Load(object sender, EventArgs e)
        {
            try
            {
                var cartItems = await _priceCompareManager.GetCartItemsAsync();              
                BeginInvoke((Action)(() => cartItems.ToList().ForEach(item => CartContentPanel.Controls.Add(new ItemToShowInCart(_priceCompareManager,item.ItemCode,item.ItemName, item.Count,RemoveItemFromCart)))));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private async void RemoveItemFromCart(object sender, MouseEventArgs e)
        {
            try
            {
               await _priceCompareManager.RemoveItemFromCartAsync(((ItemToShowInCart)((Control)sender).Parent).ItemCode);
               BeginInvoke((Action) (() => CartContentPanel.Controls.Remove(((Control) sender).Parent)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void btnComparePrices_Click(object sender, EventArgs e)
        {
            Hide();
            var cartItems = await _priceCompareManager.GetCartItemsAsync();
            new PriceCompareStoresForm(_priceCompareManager,cartItems).ShowDialog();
        }
    }
}
