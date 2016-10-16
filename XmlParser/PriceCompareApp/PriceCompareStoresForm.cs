using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PriceCompare.Model;
using PriceCompareLogic;

namespace PriceCompareApp
{

    /**
  * When creating a UI application- consider one of the following paradigms: MVC, MVP or MVVM
  * It is best to refrain from coding in the codebehind of the UI class.
  * This enables better testability and separation of UI from User interaction, Business Logic and Data Access.
  * 
  * Consider :
  * a) https://he.wikipedia.org/wiki/Model_View_Controller
  * b) https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93presenter
  * c) https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93viewmodel
  */
    public partial class PriceCompareStoresForm : Form
    {
        //Using constants is a very good way to improve readability
        private const int MinMaxItemsInStoreNumber = 3;
        private readonly PriceCompareManager _priceCompareManager;
        //Programming against an abstraction is also a very good practice!
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
                MessageBox.Show(exception.Message);
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
                MessageBox.Show(exception.Message);
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
                MessageBox.Show(exception.Message);
            }
        }

        private void DealWithMissingItems(IEnumerable<Tuple<ItemCart, Price>> itemPriceTuplesList, long chainId, int storeId, int cbNum)
        {

            var itemsNotFound = _priceCompareManager.GetNotFoundItemsInStore(itemPriceTuplesList);
            var itemsNotFoundList = itemsNotFound == null ? null : itemsNotFound as IList<ItemCart> ?? itemsNotFound.ToList();
            if (!itemsNotFoundList?.Any() == true) return;
            if (itemsNotFound == null)
            {
                if (cbNum == 1)
                {
                    new AddMissingItemsForm(chainId, storeId, _priceCompareManager,
                    _items, itemsToComparePanel1).ShowDialog();
                }
                if (cbNum == 2)
                {
                    new AddMissingItemsForm(chainId, storeId, _priceCompareManager,
                    _items, itemsToComparePanel2).ShowDialog();
                }
            }
            else
            {
                if (cbNum == 1)
                {
                    new AddMissingItemsForm(chainId, storeId, _priceCompareManager,
                        itemsNotFoundList, itemsToComparePanel1).ShowDialog();
                }
                if (cbNum == 2)
                {
                    new AddMissingItemsForm(chainId, storeId, _priceCompareManager,
                        itemsNotFoundList, itemsToComparePanel2).ShowDialog();
                }
            }

        }
        private async void cbStores1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                itemsToComparePanel1.Controls.Clear();
                var store = ((Store)((ComboBox)sender).SelectedItem);
                var itemPriceTuples = await _priceCompareManager.GetItemsInCartPricesByStoreAsync(long.Parse(store.ChainId), store.StoreId, _items);
                var itemPriceTuplesList = itemPriceTuples == null ? null : itemPriceTuples as IList<Tuple<ItemCart, Price>> ?? itemPriceTuples.ToList();
                FillItemsToItemsToComparePanel(itemPriceTuplesList, 1);
                DealWithMissingItems(itemPriceTuplesList, long.Parse(store.ChainId), store.StoreId, 1);
                cbMinItems1.Items.Clear();
                cbMaxItems1.Items.Clear();
                await GetAndAddMinMaxPricesInStore(store, 1);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private async Task GetAndAddMinMaxPricesInStore(Store store, int num)
        {
            var res = await _priceCompareManager.GetItemsPricesInStoreSortedAscAsync(store.StoreId, long.Parse(store.ChainId));
            var resArray = res as Price[] ?? res.ToArray();
            if (res == null || !resArray.Any()) return;
            var prices = resArray.ToArray();
            var revPrices = prices.Reverse().ToArray();
            for (var i = 0; i < MinMaxItemsInStoreNumber; i++)
            {
                if (num == 1)
                {
                    cbMinItems1.Items.Add(prices.ToArray()[i]);
                    cbMaxItems1.Items.Add(revPrices[i]);
                }
                if (num != 2) continue;
                cbMinItems2.Items.Add(prices.ToArray()[i]);
                cbMaxItems2.Items.Add(revPrices[i]);
            }
        }

        private async void cbStores2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                itemsToComparePanel2.Controls.Clear();
                var store = ((Store)((ComboBox)sender).SelectedItem);
                var itemPriceTuples = await _priceCompareManager.GetItemsInCartPricesByStoreAsync(long.Parse(store.ChainId), store.StoreId, _items);
                var itemPriceTuplesList = itemPriceTuples == null ? null : itemPriceTuples as IList<Tuple<ItemCart, Price>> ?? itemPriceTuples.ToList();
                FillItemsToItemsToComparePanel(itemPriceTuplesList, 2);
                DealWithMissingItems(itemPriceTuplesList, long.Parse(store.ChainId), store.StoreId, 2);
                cbMinItems2.Items.Clear();
                cbMaxItems2.Items.Clear();
                await GetAndAddMinMaxPricesInStore(store, 2);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void FillItemsToItemsToComparePanel(IEnumerable<Tuple<ItemCart, Price>> itemPriceTuples, int panelnum)
        {
            try
            {
                if (itemPriceTuples == null) return;
                var itemsContols = itemPriceTuples.Where(itemPriceTuple => !(itemPriceTuple.Item2 == null || itemPriceTuple.Item1 == null)).Select(
                    itemPriceTuple =>
                        new ItemToCompareControl(itemPriceTuple.Item1?.ItemName, itemPriceTuple.Item2.ItemPrice, itemPriceTuple.Item1.Count));
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
                MessageBox.Show(e.Message);
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
            try
            {
                var priceCountTuples1 = new List<Tuple<float, int>>();
                var priceCountTuples2 = new List<Tuple<float, int>>();
                AddTuplesToListFromPanel(priceCountTuples1, itemsToComparePanel1);
                AddTuplesToListFromPanel(priceCountTuples2, itemsToComparePanel2);
                var totalPrice1 = _priceCompareManager.CalculateTotalPrice(priceCountTuples1);
                var totalPrice2 = _priceCompareManager.CalculateTotalPrice(priceCountTuples2);
                lblTotalPrice1.Text = $"{totalPrice1}";
                lblTotalPrice2.Text = $"{totalPrice2}";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private static void AddTuplesToListFromPanel(ICollection<Tuple<float, int>> priceCountTuples, FlowLayoutPanel itemsToComparePanel1)
        {
            foreach (var control in itemsToComparePanel1.Controls)
            {
                priceCountTuples.Add(new Tuple<float, int>(float.Parse(((ItemToCompareControl)control).lblItemPrice.Text), (int)((ItemToCompareControl)control).nmCount.Value));
            }
        }

        private void cbMinItems1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddMinMaxItemToShow(cbMinItems1,minPanel1);
        }

        private void AddMinMaxItemToShow(ComboBox cb,Control panel)
        {
            var price = (Price)cb.SelectedItem;
            BeginInvoke((Action)(() =>
            {
                panel.Controls.Clear();
                panel.Controls.Add(new ItemToCompareControl(price.ItemName, price.ItemPrice, 0)
                {
                    nmCount = { Visible = false }
                });
            }));
        }

        private void cbMaxItems1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddMinMaxItemToShow(cbMaxItems1, maxPanel1);
        }

        private void cbMinItems2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddMinMaxItemToShow(cbMinItems2, minPanel2);
        }

        private void cbMaxItems2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddMinMaxItemToShow(cbMaxItems2, maxPanel2);
        }
    }
}
