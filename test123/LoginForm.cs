using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test123
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
            LoginManager.LoginTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            Console.WriteLine(LoginManager.ID);

            manager.Login(LoginManager.ID, LoginManager.PW);

            MainForm m = new MainForm();
            m.Show();

            Console.WriteLine(LoginManager.LoginTime);
            
            if(LoginManager.ID != "admin")
                manager.Query(String.Format("INSERT INTO UserTimeLog(User, LoginTime) VALUES ('{0}','{1}')", LoginManager.ID, LoginManager.LoginTime));
            
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(checkBoxAdmin.Checked)
                manager.Query(String.Format("INSERT INTO Users (ID, PW, Admin) VALUES ('{0}',HEX(AES_ENCRYPT({1}, 'asdf')),'{2}')",
                        txtBoxNewID.Text, txtBoxNewPW.Text, 1));                   
            else
                manager.Query(String.Format("INSERT INTO Users (ID, PW, Admin) VALUES ('{0}',HEX(AES_ENCRYPT({1}, 'asdf')),'{2}')",
                        txtBoxNewID.Text, txtBoxNewPW.Text, 0));

            txtBoxNewID.Text = "";
            txtBoxNewPW.Text = "";
        }

        private void btnPasswordM_Click(object sender, EventArgs e)
        {
            PasswordModify m = new PasswordModify();
            m.Show();
        }
    }
}
