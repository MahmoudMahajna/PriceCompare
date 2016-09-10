using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PriceCompare.Model;
using PriceCompareLogic;

namespace PriceCompareApp
{
    public partial class AddMissingItemsForm : Form
    {
        private readonly PriceCompareManager _priceCompareManager;
        private readonly IEnumerable<ItemCart> _itemsNotFound;
        private readonly FlowLayoutPanel _panel;
        private readonly int _storeId;
        private readonly long _chainId;
        public AddMissingItemsForm(long chainId,int storeId, PriceCompareManager priceCompareManager, IEnumerable<ItemCart> itemsNotFound, FlowLayoutPanel panel)
        {
            InitializeComponent();
            _priceCompareManager = priceCompareManager;
            _itemsNotFound = itemsNotFound;
            _panel = panel;
            _storeId = storeId;
            _chainId = chainId;
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
                var prices = await _priceCompareManager.GetItemsInStoreByStoreWithNameIdAsync(_storeId, txtSearch.Text,_chainId);
                if (prices == null) return;
                if (!IsHandleCreated)
                {
                    CreateHandle();
                }
                BeginInvoke((Action)(() =>
                {
                    lstboxItemsInStore.Items.Clear();
                    lstboxItemsInStore.Items.AddRange(prices.ToArray<object>());
                }));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var price = (Price)lstboxItemsInStore.SelectedItem;
                if (price == null) return;
                BeginInvoke((Action)(() => _panel.Controls.Add(new ItemToCompareControl(price.ItemName, price.ItemPrice, 1))));
                MessageBox.Show(@"Addded");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
    }
}
