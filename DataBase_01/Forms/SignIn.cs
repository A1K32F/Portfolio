using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataBase_01.Forms
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("Picture_0.jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Attila_98\source\repos\DataBase_01\SignInDB\LoginDb.mdf;Integrated Security=True;Connect Timeout=30");
            string sqlquery = "select * from Logind Where username ='"+username_tb.Text.Trim()+"' and password='"+userpass_tb.Text.Trim()+ "'";
            SqlDataAdapter sda = new SqlDataAdapter(sqlquery,sqlcon);
            DataTable Tb = new DataTable();
            sda.Fill(Tb);
            if (Tb.Rows.Count == 1)
            {
                GlobalVariables.G_user = username_tb.Text.Trim();
                Main form = new Main();
                form.Tag = this;
                form.Show();
                Hide();


            }
            else
            {
                MessageBox.Show("Hibás emailcím vagy jelszó!");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp form_0 = new SignUp();
            form_0.Tag = this;
            form_0.Show();
            Hide();
        }
    }
}
