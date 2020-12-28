using System;
using System.IO;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataBase_01.Forms
{
    public partial class DataList : Form
    {
       
        static void DataRead(DataTable table)
        {
            string[] lines = File.ReadAllLines("Data.txt", Encoding.Default);
            string[] values;

            table.Clear();
            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(',');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                table.Rows.Add(row);
            }
        }
        static void DataLoadfromSql(DataGridView dgv)
        {
            SqlConnection sqlcon = new SqlConnection(
               @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Attila_98\source\repos\DataBase_01\SignInDB\LoginDb.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "SELECT Felhasznalo AS 'Bejegyezte', Date AS 'Időpont' , Marka AS 'Márka', Tipus AS 'Típus', Tartozek  AS 'Tartozékok', Hordozhato AS 'Hordozható', Javit AS 'Javított', Megjegyzes AS 'Megjegyzés', Vezeteknev AS 'Megrendelő neve:', Keresztnev AS '.', Telefon AS 'Telefonszáma', Email AS 'Emailcíme' FROM Toolsdb";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlcon);
            DataSet data = new DataSet();
            sqlcon.Open();
            adapter.Fill(data, "Toolsdb");
            sqlcon.Close();
            dgv.DataSource = data;
            dgv.DataMember = "Toolsdb";
            
        }
        public DataList()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();

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
                DataSaveFromTools_0 form2 = new DataSaveFromTools_0();
                form2.Tag = this;
                form2.Show(this);
                Hide();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataList_Load(object sender, EventArgs e)
        {
           
            table.Columns.Add("ID",typeof(string));
            table.Columns.Add("Marka:", typeof(string));
            table.Columns.Add("Tipus:", typeof(string));
            table.Columns.Add("Tartozékok",typeof(string));
            table.Columns.Add("Hordozható:", typeof(string));
            table.Columns.Add("Javítás:", typeof(string));
            table.Columns.Add("Megjegyzés:", typeof(string));
            table.Columns.Add("Megrendelő neve:", typeof(string));
            table.Columns.Add(" ", typeof(string));
            table.Columns.Add("Telefonszám:", typeof(string));
            table.Columns.Add("Emailcím:", typeof(string));
            dataGridView1.DataSource = table;
        }

        private void reload_btn(object sender, EventArgs e)
        {
            //txt
            DataRead(table);

            //sql database
            DataLoadfromSql(dataGridView1);

            label1.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy ");
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
