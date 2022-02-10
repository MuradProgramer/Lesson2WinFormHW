using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Task2
{
    public partial class Form1 : Form
    {
        public List<User> Users { get; set; }
        int ind = 0;

        public Form1()
        {
            InitializeComponent();
            var jsonStr = File.ReadAllText("users.json");
            Users = JsonConvert.DeserializeObject<List<User>>(jsonStr);
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            if (txtb_load.Text == null || txtb_load.Text.Length == 0) 
                return;
            bool check = false;
            ind = 0;
            foreach (var item in Users)
            {
                if (item.Name.ToLower() == txtb_load.Text.ToLower())
                {
                    check = true;
                    break;
                }
                ind++;
            }
            if (!check)
                return;
            grpbox_Anket.Enabled = true;
            btn_save.Enabled = true;

            txtb_surname.Text = Users[ind].Surname;
            txtb_name.Text = Users[ind].Name;
            txtb_patronymic.Text = Users[ind].Patronymic;
            txtb_country.Text = Users[ind].Country;
            txtb_city.Text = Users[ind].City;
            mtxtb_phone.Text = Users[ind].Phone;
            dateTimePicker1.Value = DateTime.Parse(Users[ind].Birthday);
            if (Users[ind].IsMale) radioButton1.Checked = true;
            else radioButton2.Checked = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Users[ind].Surname = txtb_surname.Text;
            Users[ind].Name = txtb_name.Text;
            Users[ind].Patronymic = txtb_patronymic.Text;
            Users[ind].Country = txtb_country.Text;
            Users[ind].City = txtb_city.Text;
            Users[ind].Phone = mtxtb_phone.Text;
            Users[ind].Birthday = dateTimePicker1.Value.ToLongDateString();
            Users[ind].IsMale = (radioButton1.Checked == true);

            var str = JsonConvert.SerializeObject(Users, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("users.json", str);
        }
    }
}
