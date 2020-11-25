using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShopProject
{
    public partial class LoginForm : Form
    {
        DBManager manager = DBManager.GetInstance();
        LoginManager LoginManager = LoginManager.GetInstance();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginManager.ID = txtBoxID.Text.ToString();
            LoginManager.PW = txtBoxPW.Text.ToString();

            string result = manager.Login(LoginManager.ID, LoginManager.PW);
            txtBoxID.Text = "";
            txtBoxPW.Text = "";
        }
    }
}
