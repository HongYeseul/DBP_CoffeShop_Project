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
    public partial class MainForm : Form
    {
        DBManager manager = DBManager.GetInstance();
        LoginManager LoginManager = LoginManager.GetInstance();
        String stdDetails = "{0, -10}{1, 15}";

        int Americano = 0;
        int Latte = 0;
        int CafeMocha = 0;

        public MainForm()
        {
            InitializeComponent();
            InitializeDateTimePicker();
        }

        private void InitializeDateTimePicker()
        {
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxCoffeeMenu.Items.Add(String.Format(stdDetails, "커피명", "가격"));


            string q = "SELECT CoffeeMenu FROM Coffee";
            manager.Select(q);
            listBoxCoffeeMenu.Items.Add(String.Format(stdDetails, "아메리카노", "1000"));
            listBoxCoffeeMenu.Items.Add(String.Format(stdDetails, "라떼", "2000"));
            listBoxCoffeeMenu.Items.Add(String.Format(stdDetails, "카페모카", "3000"));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginManager.ID = txtBoxID.Text.ToString();
            LoginManager.PW = txtBoxPW.Text.ToString();

            string result = manager.Login(LoginManager.ID, LoginManager.PW);
            labelName.Text = result;
            txtBoxID.Text = "";
            txtBoxPW.Text = "";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginManager.ID = "";
            LoginManager.PW = "";
            labelName.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Americano = 0;
            Latte = 0;
            CafeMocha = 0;
            labelAme.Text = Americano.ToString();
            labelLatte.Text = Latte.ToString();
            labelMocha.Text = CafeMocha.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime dt1 = dateTimePicker1.Value;
            String dt = dt1.ToString("yyyy-MM-dd");
            string who = LoginManager.ID;

            if(Americano != 0)
            {
                manager.Query(String.Format("INSERT INTO Coffee (Seller, CoffeeCount, CoffeePrice, CoffeeType, Date) VALUES ('{0}','{1}','{2}','Americano','{3}')",
                    who, Americano, Americano * 1000, dt));
            }
            if(Latte != 0)
            {
                manager.Query(String.Format("INSERT INTO Coffee (Seller, CoffeeCount, CoffeePrice, CoffeeType, Date) VALUES ('{0}','{1}','{2}','Latte','{3}')",
                    who, Latte, Latte * 2000, dt));
            }
            if(CafeMocha != 0)
            {
                manager.Query(String.Format("INSERT INTO Coffee (Seller, CoffeeCount, CoffeePrice, CoffeeType, Date) VALUES ('{0}','{1}','{2}','CafeMocha','{3}')",
                    who, CafeMocha, CafeMocha * 3000, dt));
            }

            Americano = 0; Latte = 0; CafeMocha = 0;
            labelAme.Text = Americano.ToString(); labelLatte.Text = Latte.ToString(); labelMocha.Text = CafeMocha.ToString();
        }

        private void listBoxCoffeeMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = listBoxCoffeeMenu.SelectedIndex;
            switch (idx)
            {
                case 1:
                    Americano++;
                    labelAme.Text = Americano.ToString();
                    break;
                case 2:
                    Latte++;
                    labelLatte.Text = Latte.ToString();
                    break;
                case 3:
                    CafeMocha++;
                    labelMocha.Text = CafeMocha.ToString();
                    break;
            }
        }

        private void comboBoxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = comboBoxSelect.SelectedIndex;

            if (labelName.Text != "admin")
                return;

            switch (idx)
            {
                case 0:
                    // 사용자별 일일 판매액 & 사용자별 일일 판매량 
                    dataGridView1.DataSource = manager.GridSelect("SELECT Seller, SUM(CoffeeCount) AS totalCount, SUM(CoffeePrice) AS totalPrice, Date " +
                        "FROM Coffee GROUP BY Seller, Date");
                    break;
                case 1:
                    // 커피종류별 일일 판매량 / 커피종류별 일일 판매액
                    dataGridView1.DataSource = manager.GridSelect("SELECT CoffeeType, SUM(CoffeeCount) AS totalCount, SUM(CoffeePrice) AS totalPrice, Date " +
                        "FROM Coffee Group BY CoffeeType, Date");
                    break;
                case 2:
                    // 커피종류별 월별 누적 판매량 / 커피종류별 월별 누적 판매액
                    dataGridView1.DataSource = manager.GridSelect("SELECT CoffeeType, SUM(CoffeeCount) AS totalCount, SUM(CoffeePrice) AS totalPrice, DATE_FORMAT(DATE, '%Y-%m') AS Month " +
                        "FROM Coffee Group BY CoffeeType, DATE_FORMAT(Date, '%Y-%m')");
                    break;
            }
        }
    }
}
