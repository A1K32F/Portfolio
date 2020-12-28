using DataBase_01.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
using DataBase_01.Enums;




namespace DataBase_01
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("Picture_0.jpg");
            comboBox1.DataSource = Enum.GetValues(typeof(Fomenu));
            user_name_lb.Text = GlobalVariables.G_user;
        }

        private void button1_Click(object sender, EventArgs e)

        {
           
            switch(comboBox1.SelectedItem.ToString())
            {
                case "Lekérdezés":
                        {
                        DataList form2 = new DataList();
                        form2.Tag = this;
                        form2.Show(this);
                        Hide();
                        break;
                        }
                case "Javítás":
                    {
                        GlobalVariables.G_Repair = true;
                        DataSaveFromTools_0 form3 = new DataSaveFromTools_0();
                        form3.Tag = this;
                        form3.Show(this);
                        Hide();
                        break;
                    }
                case "Rendelés":
                    {
                        GlobalVariables.G_Repair = false;
                        DataSaveFromTools_0 form3 = new DataSaveFromTools_0();
                        form3.Tag = this;
                        form3.Show(this);
                        Hide();
                        break;
                    }
            }
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GlobalVariables.G_user = "";
            GlobalVariables.G_User_p = false;
            SignIn form_s = new SignIn();
            form_s.Tag = this;
            form_s.Show(this);
            Hide();
        }
    }
}
