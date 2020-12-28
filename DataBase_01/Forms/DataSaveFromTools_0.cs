using DataBase_01.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DataBase_01.Enums;
using System.Data.SqlClient;

namespace DataBase_01.Forms
{
    public partial class DataSaveFromTools_0 : Form
    {
        private List<ToolsAction> tool = new List<ToolsAction>();

        public void Clear_tb()
        {
            firstn_tb.Text = lastn_tb.Text = other_tb.Text = accessory_tb.Text =email_tb.Text=phone_tb.Text= "";
        }

        static void SaveData(List<ToolsAction> to)
        {
            StreamWriter Save = File.AppendText("Data.txt");

            foreach (ToolsAction name in to)
            {
                Save.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}",name.dateid.ToString(),name.marka,
                    name.tipus,name.tartozek,name.hordozhato,name.repairNew,name.megjegyzes,name.fname,name.lname,name.phoneN,name.email);
               
            }
            Save.Close();

        }
        static void SaveDataToSql(List<ToolsAction>to,string user)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Attila_98\source\repos\DataBase_01\SignInDB\LoginDb.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand command = new SqlCommand("ToolsAdd", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Felhasznalo", user);
            command.Parameters.AddWithValue("@Date", to[0].dateid.ToString("dd MMMM yyyy HH:mm:ss"));
            command.Parameters.AddWithValue("@Marka", to[0].marka);
            command.Parameters.AddWithValue("@Tipus", to[0].tipus);
            command.Parameters.AddWithValue("@Tartozek", to[0].tartozek);
            command.Parameters.AddWithValue("@Hordozhato", to[0].hordozhato);
            command.Parameters.AddWithValue("@Javit", to[0].repairNew);
            command.Parameters.AddWithValue("@Megjegyzes", to[0].megjegyzes);
            command.Parameters.AddWithValue("@Vezeteknev", to[0].fname);
            command.Parameters.AddWithValue("@Keresztnev", to[0].lname);
            command.Parameters.AddWithValue("@Telefon", to[0].phoneN);
            command.Parameters.AddWithValue("@Email", to[0].email);
            command.ExecuteNonQuery();
            MessageBox.Show("Sikeres Mentés!");
        }
      

        public DataSaveFromTools_0()
        {
            InitializeComponent();
            marka_cb.DataSource = Enum.GetValues(typeof(Marka));
            tipus_cb.DataSource = Enum.GetValues(typeof(Tipus));
            pictureBox1.Image = Image.FromFile("Picture_0.jpg");
            User_name_lb.Text = GlobalVariables.G_user;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataList form2 = new DataList();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void DataSaveFromRepair_0_Load(object sender, EventArgs e)
        {

        }

        private void Save_btn(object sender, EventArgs e)
        {
            
         try
            {
               
                
                tool.Add(new ToolsAction(marka_cb.SelectedItem.ToString(),tipus_cb.SelectedItem.ToString(),accessory_tb.Text, checkBox1.Checked, GlobalVariables.G_Repair,
                 other_tb.Text, firstn_tb.Text, lastn_tb.Text, phone_tb.Text, email_tb.Text));
                label12.Text = " ";
                

                //Save in txt
                /*SaveData(tool);*/

                //Save to sqldb
                SaveDataToSql(tool,User_name_lb.Text);

            }
            catch
            {
                label12.Text = "Hibás telefonszám, csak számot tartalmazhat!";
            }
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var form1 = (Main)Tag;
                form1.Show();
                Close();
            }
            catch
            {
                Main form2 = new Main();
                form2.Tag = this;
                form2.Show(this);
                Hide();

            }
        }
    }
}
