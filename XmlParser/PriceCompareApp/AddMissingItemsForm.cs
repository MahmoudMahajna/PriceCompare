using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PriceCompare.Logic;
using PriceCompare.Model;

namespace PriceCompareApp
{
    public partial class AddMissingItemsForm : Form
    {
        private readonly PriceCompareManager _priceCompareManager;
        private readonly IEnumerable<ItemCart> _itemsInCart;
        private readonly IEnumerable<ItemCart> _itemsNotFound;
        private readonly FlowLayoutPanel _panel;
        private readonly int _storeId;
        public AddMissingItemsForm(int storeId, PriceCompareManager priceCompareManager, IEnumerable<ItemCart> itemsInCart, IEnumerable<ItemCart> itemsNotFound, FlowLayoutPanel panel)
        {
            InitializeComponent();
            _priceCompareManager = priceCompareManager;
            _itemsInCart = itemsInCart;
            _itemsNotFound = itemsNotFound;
            _panel = panel;
            _storeId = storeId;
        }

        private void AddMissingItemsForm_Load(object sender, EventArgs e)
        {
            if (_itemsNotFound != null)
            {
                BeginInvoke((Action)(() => lstBoxItemsNotFound.Items.AddRange(_itemsNotFound.ToArray<object>())));
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var prices = await _priceCompareManager.GetItemsInStoreByStoreWithNameIdAsync(_storeId, txtSearch.Text);
                if (prices == null) return;
                if (!IsHandleCreated)
                {
                    CreateHandle();
                }
                BeginInvoke((Action)(() => lstboxItemsInStore.Items.AddRange(prices.ToArray<object>())));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var price = (Price)lstboxItemsInStore.SelectedItem;
            BeginInvoke((Action)(() => _panel.Controls.Add(new ItemToCompareControl(price.ItemName, price.ItemPrice, 1))));
        }
    }
}
