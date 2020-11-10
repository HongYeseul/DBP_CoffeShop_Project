using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            initializeDateTimePicker();

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            buttonAdd.Click += buttonAdd_Click;
            buttonDelete.Click += buttonDelete_Click;
            buttonEdit.Click += buttonEdit_Click;

            using (MyDbContext context = new MyDbContext())
            {
                context.Database.EnsureCreated();
            }

            using (MyDbContext context = new MyDbContext())
            {
                context.Database.EnsureCreated();

                MyData data = context.Find<MyData>(1u);
                if (null != data)
                {
                    Console.WriteLine("Found");
                    Console.WriteLine(data.Name);
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                BindingSource bi = new BindingSource();
                bi.DataSource = context.Find<MyData>(1u);
                dataGridView1.DataSource = bi;
                dataGridView1.Refresh();
            }

            using (MyDbContext context = new MyDbContext())
            {
                context.Database.EnsureCreated();

                MyData found = null;
                foreach (var item in from data in context.Data
                                     where data.Key == 1
                                     select data)
                {
                    found = item;
                    break;
                }

                if (null == found)
                {
                    return;
                }
                //found.Number++;
                context.SaveChanges();
            }

            using (MyDbContext context = new MyDbContext())
            {
                context.Add(new MyData() { Name = "이름", Number = 123 });
                context.SaveChanges();
            }
        }

        private void initializeDateTimePicker()
        {
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            /*using (MyDbContext detail = new MyDbContext())
            {
                if (detail.ShowDialog() == DialogResult.OK)
                    tableBindingSource.DataSource = db.Tables.ToList();
            }*/

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt1 = dateTimePicker1.Value;
            Console.WriteLine(dt1.ToString());

            Console.WriteLine("Year" + dt1.Year);
            Console.WriteLine("Month" + dt1.Month);

            string dt = dt1.ToString("yyyy-MM-dd");
            Console.WriteLine("my date time format1 is " + dt);
        }
    }
}
