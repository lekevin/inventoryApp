using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home prod = new Home();
            prod.Show();
            this.Hide();

            //SQLiteConnection sqlite_conn;
            //SQLiteCommand sqlite_cmd;
            //SQLiteDataReader sqlite_datareader;

            //sqlite_conn = new SQLiteConnection("Data Source="+System.AppDomain.CurrentDomain.BaseDirectory+"inventory.db");

            //sqlite_conn.Open();

            //var cmd = new SQLiteCommand("SELECT * FROM Orders", sqlite_conn);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
