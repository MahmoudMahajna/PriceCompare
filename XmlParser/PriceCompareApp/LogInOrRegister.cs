using System;
using System.Windows.Forms;
using PriceCompare.DAL.Data;
using PriceCompare.DAL.Repositories;

namespace PriceCompareApp
{
    public partial class LogInOrRegister : Form
    {
        public LogInOrRegister()
        {
            InitializeComponent();
        }

        private void LogInOrRegister_Load(object sender, EventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsernameLogin.Text;
            var password = txtPasswordLogin.Text;
            if (username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show(@"Please enter a valid input");
                return;
            }
            using (var context = new PriceCompareDbContext())
            {
                var userRep = new UserRepository(context);
                var isExist = await userRep.IsUserExist(username);
                if (!isExist)
                {
                    MessageBox.Show(@"Username does not exist!");
                }
                else
                {
                    var result = await userRep.CheckUserPassword(username, password);
                    if (!result)
                    {
                        MessageBox.Show(@"Wrong password!");
                    }
                    else
                    {
                        var user = await userRep.GetUser(username);
                        Hide();
                        new MainWindow(user).ShowDialog();
                    }
                }

            }
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            var name = txtNameReg.Text;
            var username = txtUsernameReg.Text;
            var password = txtPasswordReg.Text;
            if (name.Length == 0 || username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show(@"Please enter a valid input");
                return;
            }
            using (var context = new PriceCompareDbContext())
            {
                var userRep = new UserRepository(context);
                var isExist = await userRep.IsUserExist(username);
                if (isExist)
                {
                    MessageBox.Show(@"Username exist! Use another username");
                }
                else
                {
                    var user = userRep.AddUser(name, username, password);
                    MessageBox.Show(user == null ? @"registration failed!" : @"registration successed");
                }
            }

        }
    }
}
