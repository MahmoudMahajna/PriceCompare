using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceCompare.App
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
