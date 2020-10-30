using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Singleton
{
    public partial class MainForm : Form
    {
        DBManager manager = DBManager.GetInstance();
        ConfigManager ConfigManager = ConfigManager.GetInstance();
        public MainForm()
        {
            InitializeComponent();
            Major_Init();
            Init();
        }

        private void Init()
        {
            if (ConfigManager.InitAuto())
            {
                checkBoxAutoLoad.Checked = true;
                LoadAllStudent();
            }
            if(ConfigManager.InitLastIdx() != -1)
            {
                for (int i = 1; i <= 3; i++)
                {
                    TextBox txtNameTarget = (Controls.Find("textBoxStudentName" + i.ToString(), true)[0] as TextBox);
                    TextBox txtSIDTarget = (Controls.Find("textBoxStudentNum" + i.ToString(), true)[0] as TextBox);
                    ComboBox comboTarget = (Controls.Find("comboBoxStudentGender" + i.ToString(), true)[0] as ComboBox);
                    txtNameTarget.Text = "";
                    txtSIDTarget.Text = "";
                    comboTarget.Text = "";
                }
                checkBoxLastLoad.Checked = true;
                listBoxMajor.SelectedIndex = ConfigManager.GetRecentlyUsedListIdx();
                LoadStudent();
            }
        }
        private void LoadStudent()
        {
            List<StudentInfo> l = manager.SelectStudent("WHERE major = '" + listBoxMajor.SelectedItem.ToString() + "'");
            for (int i = 1; i <= l.Count; i++)
            {
                TextBox txtNameTarget = (Controls.Find("textBoxStudentName" + i.ToString(), true)[0] as TextBox);
                TextBox txtSIDTarget = (Controls.Find("textBoxStudentNum" + i.ToString(), true)[0] as TextBox);
                ComboBox comboTarget = (Controls.Find("comboBoxStudentGender" + i.ToString(), true)[0] as ComboBox);
                txtNameTarget.Text = l[i - 1].name;
                txtSIDTarget.Text = l[i - 1].num;
                comboTarget.Text = l[i - 1].gender;
            }
        }
        private void LoadAllStudent()
        {
            List<StudentInfo> l = manager.SelectStudent("");
            for (int i = 1; i <= l.Count; i++)
            {
                TextBox txtNameTarget = (Controls.Find("textBoxStudentName" + i.ToString(), true)[0] as TextBox);
                TextBox txtSIDTarget = (Controls.Find("textBoxStudentNum" + i.ToString(), true)[0] as TextBox);
                ComboBox comboTarget = (Controls.Find("comboBoxStudentGender" + i.ToString(), true)[0] as ComboBox);
                txtNameTarget.Text = l[i - 1].name;
                txtSIDTarget.Text = l[i - 1].num;
                comboTarget.Text = l[i - 1].gender;
            }
        }
        
        private void Major_Init()
        {
            List<MajorInfo> l = manager.SelectMajor();
            for(int i=0; i<l.Count; i++)
            {
                listBoxMajor.Items.Add(l[i].major);
            }
        }
        private void buttonAddMajor_Click(object sender, EventArgs e)
        {
            listBoxMajor.Items.Add(textBoxMajor.Text);
            string query = "INSERT INTO major (major) VALUES ('"+textBoxMajor.Text+"')";
            textBoxMajor.Text = "";
            manager.Query(query);
        }
        private void buttonSaveStudent1_Click(object sender, EventArgs e)
        {
            StudentInfo s1 = new StudentInfo(textBoxStudentName1.Text,textBoxStudentNum1.Text, comboBoxStudentGender1.Text, listBoxMajor.SelectedItem.ToString());
            manager.Query(s1.StudentSave());
        }

        private void buttonDeleteStudent1_Click(object sender, EventArgs e)
        {
            DeleteButton(1);
        }

        private void buttonLoadStudent_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 3; i++)
            {
                TextBox txtNameTarget = (Controls.Find("textBoxStudentName" + i.ToString(), true)[0] as TextBox);
                TextBox txtSIDTarget = (Controls.Find("textBoxStudentNum" + i.ToString(), true)[0] as TextBox);
                ComboBox comboTarget = (Controls.Find("comboBoxStudentGender" + i.ToString(), true)[0] as ComboBox);
                txtNameTarget.Text ="";
                txtSIDTarget.Text ="";
                comboTarget.Text ="";
            }
            LoadStudent();
        }

        

        private void buttonStudentSave2_Click(object sender, EventArgs e)
        {
            StudentInfo s2 = new StudentInfo(textBoxStudentName2.Text, textBoxStudentNum2.Text, comboBoxStudentGender2.Text, listBoxMajor.SelectedItem.ToString());

            manager.Query(s2.StudentSave());
        }

        private void buttonStudentDelete2_Click(object sender, EventArgs e)
        {
            DeleteButton(2);
        }

        private void DeleteButton(int num)
        {
            TextBox txtNameTarget = (Controls.Find("textBoxStudentName" + num.ToString(), true)[0] as TextBox);
            TextBox txtSIDTarget = (Controls.Find("textBoxStudentNum" + num.ToString(), true)[0] as TextBox);
            ComboBox comboTarget = (Controls.Find("comboBoxStudentGender" + num.ToString(), true)[0] as ComboBox);
            StudentInfo s = new StudentInfo(txtNameTarget.Text, txtSIDTarget.Text, comboTarget.Text, listBoxMajor.SelectedItem.ToString());
            manager.Query(s.StudentDelete(Convert.ToInt32(manager.Select(s.name))));
            txtNameTarget.Text = "";
            txtSIDTarget.Text = "";
            comboTarget.Text = "";
        }

        private void buttonStudentSave3_Click(object sender, EventArgs e)
        {
            StudentInfo s3 = new StudentInfo(textBoxStudentName3.Text, textBoxStudentNum3.Text, comboBoxStudentGender3.Text, listBoxMajor.SelectedItem.ToString());

            manager.Query(s3.StudentSave());
        }

        

        private void buttonStudentDelete3_Click(object sender, EventArgs e)
        {
            DeleteButton(3);
        }

        private void checkBoxAutoLoad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoLoad.Checked)
                ConfigManager.AutoSet(true);
            else
                ConfigManager.AutoSet(false);
        }

        private void checkBoxLastLoad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLastLoad.Checked)
                ConfigManager.LastLoadSet(listBoxMajor.SelectedIndex);
            else
                ConfigManager.LastLoadSet(-1);
        }
    }
}
