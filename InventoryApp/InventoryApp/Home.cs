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
    public partial class Home : Form
    {
        SQLiteDataReader dr;

        public Home()
        {
            InitializeComponent();
        }

        private void proddata_show()
        {
            var con = new SQLiteConnection(@"URI=file:" + Application.StartupPath + "\\inventory.db");
            con.Open();

            string stm = "SELECT * FROM PRODUCTS";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                productGrid.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4));
            }
        }

        private void mandata_show()
        {
            var con = new SQLiteConnection(@"URI=file:" + Application.StartupPath + "\\inventory.db");
            con.Open();

            string stm = "SELECT * FROM MANUFACTURER";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                manGrid.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3));
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payments prod = new Payments();
            prod.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manufacturers prod = new Manufacturers();
            prod.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManageUsers prod = new ManageUsers();
            prod.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Products prod = new Products();
            prod.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Orders prod = new Orders();
            prod.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Home_Load_1(object sender, EventArgs e)
        {
            proddata_show();
            mandata_show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(@"URI=file:" + Application.StartupPath + "\\inventory.db");
            con.Open();

            string stm = "SELECT PRODUCTS.*, MANUFACTURER.* FROM PRODUCTS INNER JOIN MANUFACTURER ON PRODUCTS.manID=MANUFACTURER.mID";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                joinView.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7), dr.GetString(8));
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
