using System;
using System.Windows.Forms;

namespace PriceCompare.App
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
