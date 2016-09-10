using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PriceCompare.Logic;
using PriceCompare.Model;

namespace PriceCompare.App
{
    public partial class PriceCompareStoresForm : Form
    {
        private readonly PriceCompareManager _priceCompareManager;
        private readonly IEnumerable<ItemCart> _items;
        public PriceCompareStoresForm(PriceCompareManager priceCompareManager, IEnumerable<ItemCart> items)
        {
            InitializeComponent();
            _priceCompareManager = priceCompareManager;
            _items = items;
        }

        private void PriceCompareStoresForm_Load(object sender, EventArgs e)
        {
            try
            {
                FillChains();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void FillChains()
        {
            var chains = _priceCompareManager.GetChains();
            var enumerable = chains as Chain[] ?? chains.ToArray();
            BeginInvoke(AddChainsToComboBox(enumerable, cbChains1));
            BeginInvoke(AddChainsToComboBox(enumerable, cbChains2));
        }

        private static Action AddChainsToComboBox(IEnumerable<object> chains, ComboBox comboBox)
        {
            return () => comboBox.Items.AddRange(chains.ToArray());
        }

        private void cbChains1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FillStores(((Chain)((ComboBox)(sender)).SelectedItem).ChainId, 1);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void FillStores(string chainId, int cbNum)
        {
            var stores = _priceCompareManager.GetStoresByChainId(chainId);
            BeginInvoke(cbNum == 1 ? AddStoresToComboBox(stores, cbStores1) : AddStoresToComboBox(stores, cbStores2));
        }

        private static Action AddStoresToComboBox(IEnumerable<object> stores, ComboBox comboBox)
        {
            return (() =>
            {
                comboBox.Items.Clear();
                comboBox.Text = @"Choose store...";
                comboBox.Items.AddRange(stores.ToArray());
            });
        }

        private void cbChains2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FillStores(((Chain)((ComboBox)sender).SelectedItem).ChainId, 2);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void DealWithMissingItems(IEnumerable<Tuple<ItemCart, Price>> itemPriceTuplesList, int storeId,int cbNum)
        {

            var itemsNotFound = _priceCompareManager.GetNotFoundItemsInStore(itemPriceTuplesList);
            var itemsNotFoundList = itemsNotFound==null?null: itemsNotFound as IList<ItemCart> ?? itemsNotFound.ToList();
            if (!itemsNotFoundList?.Any()==true) return;
            if (itemsNotFound == null)
            {
                if (cbNum == 1)
                {
                    new AddMissingItemsForm(storeId, _priceCompareManager, _items,
                    _items, itemsToComparePanel1).ShowDialog();
                }
                if (cbNum == 2)
                {
                    new AddMissingItemsForm(storeId, _priceCompareManager, _items,
                    _items, itemsToComparePanel2).ShowDialog();
                }
            }
            else
            {
                if (cbNum == 1)
                {
                    new AddMissingItemsForm(storeId, _priceCompareManager, _items,
                        itemsNotFoundList, itemsToComparePanel1).ShowDialog();
                }
                if (cbNum == 2)
                {
                    new AddMissingItemsForm(storeId, _priceCompareManager, _items,
                        itemsNotFoundList, itemsToComparePanel2).ShowDialog();
                }
            }
            
        }
        private async void cbStores1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var storeId = ((Store)((ComboBox)sender).SelectedItem).StoreId;
                var itemPriceTuples = await _priceCompareManager.GetItemsInCartPricesByStoreAsync(storeId, _items);
                var itemPriceTuplesList = itemPriceTuples == null ? null : itemPriceTuples as IList<Tuple<ItemCart, Price>> ?? itemPriceTuples.ToList();
                FillItemsToItemsToComparePanel(itemPriceTuplesList, 1);
                DealWithMissingItems(itemPriceTuplesList, storeId, 1);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
        private async void cbStores2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var storeId = ((Store)((ComboBox)sender).SelectedItem).StoreId;
                var itemPriceTuples = await _priceCompareManager.GetItemsInCartPricesByStoreAsync(storeId, _items);
                var itemPriceTuplesList = itemPriceTuples==null? null: itemPriceTuples as IList<Tuple<ItemCart,Price>> ?? itemPriceTuples.ToList();
                FillItemsToItemsToComparePanel(itemPriceTuplesList, 2);
                DealWithMissingItems(itemPriceTuplesList, storeId,2);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
        private void FillItemsToItemsToComparePanel(IEnumerable<Tuple<ItemCart, Price>> itemPriceTuples, int panelnum)
        {
            try
            {
                if (itemPriceTuples == null) return;
                var itemsContols = itemPriceTuples.Where(itemPriceTuple => !(itemPriceTuple.Item2 == null || itemPriceTuple.Item1==null)).Select(
                    itemPriceTuple =>
                        new ItemToCompareControl(itemPriceTuple.Item1?.ItemName, itemPriceTuple.Item2.ItemPrice,itemPriceTuple.Item1.Count));
                var itemToCompareControls = itemsContols as ItemToCompareControl[] ?? itemsContols.ToArray();
                if (panelnum == 1)
                {
                    BeginInvoke(FillItemsInPanel(itemToCompareControls, itemsToComparePanel1));
                }
                if (panelnum == 2)
                {
                    BeginInvoke(FillItemsInPanel(itemToCompareControls, itemsToComparePanel2));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private static Action FillItemsInPanel(IEnumerable<Control> itemsContols, FlowLayoutPanel panel)
        {
            return () =>
            {
                panel.Controls.Clear();
                panel.Controls.AddRange(itemsContols.ToArray());
            };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var priceCountTuples1 = new List<Tuple<float, int>>();
            var priceCountTuples2 = new List<Tuple<float, int>>();
            AddTuplesToListFromPanel(priceCountTuples1,itemsToComparePanel1);
            AddTuplesToListFromPanel(priceCountTuples2, itemsToComparePanel2);
            float totalPrice1=_priceCompareManager.CalculateTotalPrice(priceCountTuples1);
           float totalPrice2= _priceCompareManager.CalculateTotalPrice(priceCountTuples2);
            lblTotalPrice1.Text = $"{totalPrice1}";
            lblTotalPrice2.Text = $"{totalPrice2}";
        }

        private static void AddTuplesToListFromPanel(ICollection<Tuple<float, int>> priceCountTuples, FlowLayoutPanel itemsToComparePanel1)
        {
            foreach (var control in itemsToComparePanel1.Controls)
            {
                priceCountTuples.Add(new Tuple<float, int>(float.Parse(((ItemToCompareControl)control).lblItemPrice.Text), (int)((ItemToCompareControl)control).nmCount.Value));
            }
        }
    }
}
