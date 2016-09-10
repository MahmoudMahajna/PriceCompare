using System;
using System.Windows.Forms;

namespace PriceCompareApp
{
    public partial class ItemForShow : UserControl
    {
        public ItemForShow(long code,string name,MouseEventHandler addItemToCart)
        {
            InitializeComponent();
            lblCode.Text = code.ToString();
            lblName.Text=name;
            btnAddToCart.MouseClick += addItemToCart;
        }

        private void ItemForShow_Load(object sender, EventArgs e)
        {

        }
    }
}
