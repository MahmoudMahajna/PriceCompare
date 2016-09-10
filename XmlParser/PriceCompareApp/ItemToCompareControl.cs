using System;
using System.Windows.Forms;

namespace PriceCompareApp
{
    public partial class ItemToCompareControl : UserControl
    {
        public ItemToCompareControl(string itemName,float itemPrice,int count)
        {
            InitializeComponent();
            lblItemName.Text = itemName;
            lblItemPrice.Text = $"{itemPrice}";
            nmCount.Value = count;
        }

        private void ItemToCompareControl_Load(object sender, EventArgs e)
        {

        }

        private void nmCount_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
