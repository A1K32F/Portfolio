using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataBase_01.Forms
{
    public partial class SignUp : Form
    {
        private ToolsUser user = new ToolsUser("user","00000000");
        
        SqlConnection sqlcon = new SqlConnection(
               @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Attila_98\source\repos\DataBase_01\SignInDB\LoginDb.mdf;Integrated Security=True;Connect Timeout=30");
        void Clear()
        {
            user_tb.Text = Passf.Text = PassS.Text = "";
        }
       
       
        public SignUp()
        {
            InitializeComponent();
           
        }

        private void Sign_Upbtn(object sender, EventArgs e)
        {
            if ((Passf.Text.Trim() == PassS.Text.Trim()) && (Passf.Text.Length >7)) 
            {
                if(user_tb.Text.Trim().Length >3)
                {
                    user.Uname = user_tb.Text.Trim();
                    user.Upass = Passf.Text.Trim();

                    string sqlquery_select = "select * from Logind Where username ='" + user.Uname + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(sqlquery_select, sqlcon);
                    DataTable Tb = new DataTable();
                    sda.Fill(Tb);
                    if(Tb.Rows.Count>0)
                    {
                        MessageBox.Show("A felhasználónév már foglalt, kérem válasszon újat!");
                        user_tb.Text = "";
                        user.Clear();
                    }
                    else
                    {
                        sqlcon.Open();
                        SqlCommand command = new SqlCommand("UserAdd",sqlcon);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@username", user.Uname);
                        command.Parameters.AddWithValue("@password", user.Upass);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Sikeres Regisztráció!");

                        Clear();
                        user.Clear();
                        
                    }
                }
                else
                {
                    if(user_tb.Text.Trim()=="")
                    {
                        MessageBox.Show("Adjon meg felhasználónevet!");
                    }
                    else
                    {
                        MessageBox.Show("Felhasználónév minimum 4 karakter!");
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Nem egyező vagy túl rövid jelszó! Minimum 8 karakter!");
            }
            
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignIn form_1 = new SignIn();
            form_1.Tag = this;
            form_1.Show();
            Hide();
        }
    }
}
