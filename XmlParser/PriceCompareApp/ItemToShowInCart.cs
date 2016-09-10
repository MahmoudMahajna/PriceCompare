using System;
using System.Windows.Forms;
using PriceCompare.Logic;

namespace PriceCompare.App
{
    public partial class ItemToShowInCart : UserControl
    {
        private readonly PriceCompareManager _priceCompareManager;
        public long ItemCode { get; }
        public ItemToShowInCart(PriceCompareManager priceCompareManager,long itemCode,string itemName,int itemCount,MouseEventHandler removeItemFromCart)
        {
            InitializeComponent();
            ItemCode = itemCode;
            _priceCompareManager = priceCompareManager;
            lblItemName.Text = itemName;
            nmItemCount.Value = itemCount;
            btnRemove.MouseClick += removeItemFromCart;
        }

        private async void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           await _priceCompareManager.UpdateItemInCartAsync(ItemCode,(int)nmItemCount.Value);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ItemToShowInCart_Load(object sender, EventArgs e)
        {

        }

    }
}
